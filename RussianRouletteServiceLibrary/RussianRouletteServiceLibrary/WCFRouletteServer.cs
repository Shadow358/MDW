using RussianRouletteServiceLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using RussianRouletteServiceLibrary.Data;

namespace RussianRouletteServiceLibrary
{
  
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
                     ConcurrencyMode = ConcurrencyMode.Multiple,
                     UseSynchronizationContext = false)]
    public class WCFRouletteServer : IGame, IPortal, IDisposable
    {
        //Database object
        ServiceContext db = new ServiceContext();
      
        public bool[] _cylinder = new bool[6];

      private Action<User, UMessage> gameCallbacks = delegate { };
      
        public IGameCallback CurrentGameCallback
        {
            get
            {
                return OperationContext.Current.
                       GetCallbackChannel<IGameCallback>();
            }
        }

        public IPortalCallback CurrentPortalCallback
        {
            get
            {
                return OperationContext.Current.
                       GetCallbackChannel<IPortalCallback>();
            }
        }

        public bool SearchUsersByNickname(string nickname)
        {
            return portalClientsDictionary.Keys.Any(c => c.NickName == nickname);
        }

        Dictionary<User, IGameCallback> clients = new Dictionary<User, IGameCallback>();

        Dictionary<User, IPortalCallback> portalClientsDictionary = new Dictionary<User, IPortalCallback>();
        

        List<User> playerList = new List<User>();

        List<User> portalList = new List<User>();

        List<Game> gamesList = new List<Game>();   

        //NEW STUFF
        object syncObj = new object();

        public WCFRouletteServer()
        {
           
        }

        public void Play(User user)
        {
            if (!clients.ContainsValue(CurrentGameCallback) &&
                !SearchUsersByNickname(user.NickName))
            {
                lock (syncObj)
                {
                    clients.Add(user, CurrentGameCallback);
                    playerList.Add(user);

                    foreach (User userinList in clients.Keys)
                    {
                        IGameCallback callback = clients[userinList];
                        try
                        {
                            callback.PlayerReady(userinList);
                        }
                        catch(Exception ex)
                        {
                            
                        }

                    }

                }
             }


        }

        public void PlaceBullet(int cylinderHole, User user)
        {
            lock (syncObj)
            {
                _cylinder[cylinderHole - 1] = true;

                foreach (IGameCallback callback in clients.Values)
                {
                    callback.BulletPlaced(user, new UMessage(){ MessageContent = "Bullet has been placed by: " + user.NickName});
                }
            }
            
            
            
        }

        public void SpinCylinder()
        {
            //gamesList.First(x=>x.Id = 55)
            lock (syncObj)
            {
                var rnum = new Random();
                for (int i = 0; i < 6; i++)
                {
                    _cylinder[i] = false;
                }
                _cylinder[rnum.Next(0, 6)] = true;

                foreach (IGameCallback callback in clients.Values)
                {
                    callback.CylinderSpun(new UMessage() { MessageContent = "The cylinder has been spun." });
                }
            }
        }

        public bool Shoot(User player, int holeChosen)
        {
            if (_cylinder[holeChosen] == false)
            {
                var oponent = playerList.FirstOrDefault(x => x.NickName != player.NickName);
                if (oponent != null)
                {
                    var otherPlayer = oponent.NickName;
                    clients.FirstOrDefault(x => x.Key.NickName == otherPlayer).Value.YourTurn(player, holeChosen+1);
                }
                
            }
            else
            {
                foreach (User u in clients.Keys)
                {
                    IGameCallback callback = clients[u];
                    callback.PlayerLost(player, new UMessage(){MessageContent = player.NickName + " has lost the game by taking a bullet to his forehead."});
                }
            }

            return false;
        }

        //sends message in game.
        public void SendMessage(User user, UMessage message)
        {
            try
            {
                foreach (User rec in clients.Keys)
                {
                        IGameCallback callback = clients[rec];
                        callback.PlayerSentMessage(user, message);

                }
            }
            catch (Exception ex)
            {
                
                
            }
        }

        public void DetermineWinner()
        {
            throw new NotImplementedException();
        }

        public void Rematch()
        {
            throw new NotImplementedException();
        }

        public void Leave(User user)
        {
            foreach (User c in clients.Keys)
            {
                if (user.NickName == c.NickName)
                {
                    lock (syncObj)
                    {
                        this.clients.Remove(c);
                        this.portalList.Remove(c);
                        foreach (IGameCallback callback in clients.Values)
                        {
                            //callback.RefreshClients(this.clientList);
                            callback.PlayerLeft(user, new UMessage(){ MessageContent = "Player " +user.NickName + " disconnected."});
                        }
                    }
                    return;
                }
            }
        }


        ///
        /// IPortal section
        ///

        public string SignUp(User user)
        {
            //using(var db = new ServiceContext())
            //{
                var userList = db.Users.ToList();
                if(userList.FirstOrDefault(x => x.Email == user.Email) != null)
                {
                    //return "User already exists";
                    return "exists";
                }
                else
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                   // return "User with email: "+ user.Email +" has been registered";
                    return "registered";
                }
            //}
        }

        public bool checkSignIn(User user)
        {
            User userDb = db.Users.FirstOrDefault(x => x.Email == user.Email);

            if (userDb != null && userDb.Password == user.Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<string> GetUsersList()
        {
            List<string> tempList = new List<string>();
            foreach (User item in portalList)
            {
                tempList.Add(item.NickName);
            }
            return tempList;
        }

        public void SignIn(User user)
        {
            User userDb = db.Users.FirstOrDefault(x => x.Email == user.Email);
            
            if (userDb != null)
            {
                User currentUser = new User()
                {
                    Email = userDb.Email,
                    FirstName = userDb.FirstName,
                    LastName = userDb.LastName,
                    NickName = userDb.NickName,
                    Id = userDb.Id,
                    UMessages = userDb.UMessages
                };
               
                                
                if (userDb.Password == user.Password)
                {
                    if (!portalClientsDictionary.ContainsValue(CurrentPortalCallback) &&
                        !SearchUsersByNickname(userDb.NickName))
                    {
                        lock (syncObj)
                        {

                            portalClientsDictionary.Add(userDb, CurrentPortalCallback);
                            portalList.Add(userDb);
                            try
                            {
                                portalClientsDictionary[
                                    portalClientsDictionary.Keys.First(x => x.Email == userDb.Email)].SignInSuccess(currentUser);//new User(){ Email = userDb.Email, FirstName = userDb.FirstName, LastName = userDb.LastName, NickName = userDb.NickName, Id = userDb.Id, UMessages = userDb.UMessages});

                             
                                    foreach (User rec in portalClientsDictionary.Keys)//.Where(x=>x.Email != userDb.Email))
                                    {
                                        IPortalCallback callback = portalClientsDictionary[rec];
                                        //callback.OnUserSignIn(portalList, new UMessage(){ MessageContent = "joined"});
                                        callback.OnUserSignIn(GetUsersList(), new UMessage() { MessageContent = "User : " + currentUser.NickName + " : has joined the portal!", User = user });
                                        
                                    }
                                
                            }
                            catch (Exception ex)
                            {

                            }
                        }
                    }
                }
            }
        }


        //Sends a public message to main portal channel
        public void SendPublicMessage(User user,UMessage message)
        {
            try
            {
                foreach (User rec in portalClientsDictionary.Keys)
                {
                    
                    IPortalCallback callback = portalClientsDictionary[rec];
                    callback.OnPublicMessageSent(user, message);

                    
                }
            }
            catch (Exception ex)
            {


            }
        }

        public void SendPrivateMessage(User user, UMessage message)
        {

        }

        public void InviteToPlay(string Nickname, User user)
        {
            if (SearchUsersByNickname(Nickname))
            {
                portalClientsDictionary[portalClientsDictionary.Keys.First(x=>x.NickName == Nickname)].InvitedToPlay(user);
            }
        }

        public void AgreeToPlay(string Nickname, User user)
        {
            db.Games.Add(new Game(firstPlayer: portalList.First(x => x.NickName == Nickname).Id, secondPlayer: user.Id));
            db.SaveChanges();
            
            var dbGameList = db.Games.Local.First().Id;


            var listas = db.Games.ToList();

                portalClientsDictionary[portalClientsDictionary.Keys.First(x=>x.NickName == Nickname)].AgreedToPlay(user);
                gamesList.Add(new Game(firstPlayer: portalList.First(x => x.NickName == Nickname).Id, secondPlayer: user.Id) { Id = dbGameList});

               //portalClientsDictionary[portalClientsDictionary.Keys.First(x => x.NickName == Nickname && x.NickName == user.NickName)].AgreedToPlay(user);
            
                //new Game(){ Id = db.Games.Last().Id, FirstPlayer = portalList.First(x=>x.NickName == Nickname).Id, SecondPlayer = user.Id });
        }

        public void Disconnect(User user)
        {
            
                
                    lock (syncObj)
                    {
                        this.portalClientsDictionary.Remove(
                            portalClientsDictionary.Keys.First(x => x.Email == user.Email));
                        this.portalList.Remove(portalList.First(x=>x.Email ==user.Email));
                        foreach (IPortalCallback callback in portalClientsDictionary.Values)
                        {
                            //callback.RefreshClients(this.clientList);
                            callback.UserDisconnected(GetUsersList(), new UMessage() { MessageContent = "User : " + user.NickName + " : has left the portal!", User = user});
                                        
                        }
                    }
                
            
        }

        


        public void Dispose()
        {
            db.Dispose();
        }
    }
}