using System.Data.Entity;
using System.Runtime.CompilerServices;
using System.Threading;
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

        Dictionary<User, IPortalCallback> portalClientsDictionary = new Dictionary<User, IPortalCallback>();
        
        List<User> portalList = new List<User>();

        List<string> topPlayersList = new List<string>();

        List<Game> gamesList = new List<Game>();   

        //NEW STUFF
        object syncObj = new object();

        public Game GetCurrentGame(int gameIdinList)
        {
            if (gamesList.First(x => x.Id == gameIdinList) == null)
            {
                throw new Exception("There is no such game in the server.");
            }
            else
            {
                return gamesList.First(x => x.Id == gameIdinList);
            }
        }

        public WCFRouletteServer()
        {
           
        }

        public void Play(int gameId, User user)
        {

            var currentGame = GetCurrentGame(gameId);

            //if (!currentGame.gameClientsDictionary.ContainsValue(currentGame.CurrentGameCallback) &&
            //    !SearchUsersByNickname(user.NickName))
            //{
                lock (syncObj)
                {
                    GetCurrentGame(gameId).gameClientsDictionary.Add(user, currentGame.CurrentGameCallback);
                    GetCurrentGame(gameId).playerList.Add(user);

                    foreach (User userinList in GetCurrentGame(gameId).gameClientsDictionary.Keys)
                    {
                        IGameCallback callback = GetCurrentGame(gameId).gameClientsDictionary[userinList];
                        try
                        {
                            callback.PlayerReady(userinList);
                        }
                        catch(Exception ex)
                        {
                            
                        }

                    }

                }
             //}


        }

        public void PlaceBullet(int gameId, int cylinderHole, User user)
        {
            lock (syncObj)
            {
                GetCurrentGame(gameId)._cylinder[cylinderHole - 1] = true;

                foreach (IGameCallback callback in GetCurrentGame(gameId).gameClientsDictionary.Values)
                {
                    callback.BulletPlaced(user, new UMessage() { MessageContent = "Bullet has been placed by: " + user.NickName });
                }
            }
            
            
            
        }

        public void SpinCylinder(int gameId)
        {
            //gamesList.First(x=>x.Id = 55)
            lock (syncObj)
            {
                var rnum = new Random();
                for (int i = 0; i < 6; i++)
                {
                    GetCurrentGame(gameId)._cylinder[i] = false;
                }
                GetCurrentGame(gameId)._cylinder[rnum.Next(0, 6)] = true;

                foreach (IGameCallback callback in GetCurrentGame(gameId).gameClientsDictionary.Values)
                {
                    callback.CylinderSpun(new UMessage() { MessageContent = "The cylinder has been spun." });
                }
            }
        }

        public bool Shoot(int gameId, User player, int holeChosen)
        {
           
            var oponent = GetCurrentGame(gameId).playerList.FirstOrDefault(x => x.NickName != player.NickName);
            
            if (GetCurrentGame(gameId)._cylinder[holeChosen] == false)
            {
                if (oponent != null)
                {
                    var otherPlayer = oponent.NickName;

                    foreach (User u in GetCurrentGame(gameId).gameClientsDictionary.Keys)
                    {
                        IGameCallback callback = GetCurrentGame(gameId).gameClientsDictionary[u];
                        callback.FireAlive(otherPlayer);
                    }
                    
                    Thread.Sleep(7000);
                    GetCurrentGame(gameId).gameClientsDictionary.FirstOrDefault(x => x.Key.NickName == otherPlayer).Value.YourTurn(player, holeChosen + 1);
                }
            }
            else
            {
                foreach (User u in GetCurrentGame(gameId).gameClientsDictionary.Keys)
                {
                    IGameCallback callback = GetCurrentGame(gameId).gameClientsDictionary[u];
                    callback.PlayerLost(player, new UMessage() { MessageContent = player.NickName + " has lost the game by taking a bullet to his forehead." });
                }

                //Saving winning user ID to database Game column of specific game.
                var setWinner = db.Games.First(x => x.Id == gameId);
                if (oponent != null) setWinner.Winner = oponent.Id;
                db.Entry(setWinner).State = EntityState.Modified;

                //Updating wins column in users table to count how many wins user has made.
                var winCounter = db.Users.First(x=> x.Id == oponent.Id);
                winCounter.Wins += 1;
                //.AsNoTracking fixes error:
                //Attaching an entity of type 'ContosoUniversity.Models.Department' failed because another entity of the same type already has the same primary key value.
                //error

                //db.Users.Attach(winCounter);
                db.Entry(winCounter).State = EntityState.Modified;

                db.SaveChanges();
            }

            return false;
        }

        //sends message in game.
        public void SendMessage(int gameId, User user, UMessage message)
        {
            try
            {
                foreach (User rec in GetCurrentGame(gameId).gameClientsDictionary.Keys)
                {
                    IGameCallback callback = GetCurrentGame(gameId).gameClientsDictionary[rec];
                    callback.PlayerSentMessage(user, message);

                }
            }
            catch (Exception ex)
            {


            }
        }

        //public void DetermineWinner(int gameId)
        //{
        //    throw new NotImplementedException();
        //}

        public void Rematch(int gameId)
        {
            throw new NotImplementedException();
        }

        public void Leave(int gameId, User user)
        {
            foreach (User c in GetCurrentGame(gameId).gameClientsDictionary.Keys)
            {
                if (user.NickName == c.NickName)
                {
                    lock (syncObj)
                    {
                        GetCurrentGame(gameId).gameClientsDictionary.Remove(c);
                        GetCurrentGame(gameId).playerList.Remove(c);
                        foreach (IGameCallback callback in GetCurrentGame(gameId).gameClientsDictionary.Values)
                        {
                            //callback.RefreshClients(this.clientList);
                            callback.PlayerLeft(user, new UMessage() { MessageContent = "Player " + user.NickName + " disconnected." });
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


        public List<string> ReceiveTopPlayers()
        {
            var topplayers = db.Users.Select(x => new {x.NickName, x.Wins}).OrderByDescending(x => x.Wins).Take(10);
            topPlayersList.Clear();
            int counter = 1;
            foreach (var player in topplayers)
            {
                topPlayersList.Add(counter.ToString()+ ". " +player.NickName +" Total Wins:"+ player.Wins);
                counter++;
            }
            return topPlayersList;
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


            int gameId = db.Games.ToList().Last().Id;

                
                gamesList.Add(new Game(firstPlayer: portalList.First(x => x.NickName == Nickname).Id, secondPlayer: user.Id) { Id = gameId});

            //worked
                //portalClientsDictionary[portalClientsDictionary.Keys.First(x => x.NickName == Nickname)].AgreedToPlay(user, gameId);

                lock (syncObj)
                {
                    //GetCurrentGame(gameId).gameClientsDictionary.Add(user, GetCurrentGame(gameId).CurrentGameCallback);
                    //GetCurrentGame(gameId).playerList.Add(user);

                    //GetCurrentGame(gameId).gameClientsDictionary.Add(portalClientsDictionary.Keys.First(x => x.NickName == Nickname), GetCurrentGame(gameId).CurrentGameCallback);

                    foreach (User userinList in portalClientsDictionary.Keys.Where(x=>x.NickName == Nickname || x.NickName == user.NickName))
                    {
                        IPortalCallback callback = portalClientsDictionary[userinList];
                        try
                        {
                            callback.AgreedToPlay(gameId);
                        }
                        catch (Exception ex)
                        {

                        }

                    }

                }
            ////worked
            //    portalClientsDictionary[portalClientsDictionary.
            //        Keys.First(x => x.NickName == user.NickName)]
            //        .AgreedToPlay(portalClientsDictionary.Keys.FirstOrDefault(x=>x.NickName==Nickname), gameId);


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