
using System.Security.Cryptography;
using RussianRouletteServiceLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ServiceModel;
using System.Data;
using RussianRouletteServiceLibrary.Data;

namespace RussianRouletteServiceLibrary
{
    //[CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Single, UseSynchronizationContext=false)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
                     ConcurrencyMode = ConcurrencyMode.Multiple,
                     UseSynchronizationContext = false)]
    public class WCFRouletteServer : IGame, IPortal, IDisposable
    {
        //Database object
        ServiceContext db = new ServiceContext();
        public bool[] _cylinder = new bool[6];

        

        //Event actions
        //static Action<User, UMessage> m_PortalEvents = delegate {};
        //static Action<int> m_PortalTest = delegate { };
        //static Action<User, UMessage> m_Portal = delegate { };

        private Action<User, UMessage> gameCallbacks = delegate { };
        //private Game _gameObj = new Game();

        //private Game newGame = null;

        public IGameCallback CurrentCallback
        {
            get
            {
                return OperationContext.Current.
                       GetCallbackChannel<IGameCallback>();
            }
        }

        public bool SearchUsersByNickname(string nickname)
        {
            return clients.Keys.Any(c => c.NickName == nickname);
        }

        Dictionary<User, IGameCallback> clients = new Dictionary<User, IGameCallback>();
        
        List<User> playerList = new List<User>();

        List<User> portalList = new List<User>();


        //NEW STUFF
        object syncObj = new object();

        public WCFRouletteServer()
        {
           
        }

        public void Play(User user)
        {
            //IGameCallback subscriber =
            //           OperationContext.Current.GetCallbackChannel<IGameCallback>();
            //gameCallbacks += subscriber.PlayerSentMessage;
            //gameCallbacks += subscriber.PlayerDisconnected;
            //gameCallbacks += subscriber.PlayerLost;
            //gameCallbacks += subscriber.BulletPlaced;
            //gameCallbacks += subscriber.CylinderSpun;
            //gameCallbacks += subscriber.RematchRequested;


            if (!clients.ContainsValue(CurrentCallback) &&
                !SearchUsersByNickname(user.NickName))
            {
                lock (syncObj)
                {
                    clients.Add(user, CurrentCallback);
                    playerList.Add(user);

                    foreach (User userinList in clients.Keys)
                    {
                        IGameCallback callback = clients[userinList];
                        try
                        {
                            //callback.RefreshClients(clientList);
                            callback.PlayerReady(userinList);
                        }
                        catch(Exception ex)
                        {
                            
                            //_gameObj.clients.Remove(userinList);
                            //return false;
                        }

                    }

                }
                //return true;
            }
            //return false;


        }

        public void PlaceBullet(int cylinderHole, User user)
        {
            lock (syncObj)
            {
                _cylinder[cylinderHole - 1] = true;
                //gameCallbacks(new User(), new UMessage());
                foreach (IGameCallback callback in clients.Values)
                {
                    callback.BulletPlaced(user, new UMessage(){ MessageContent = "Bullet has been placed by: " + user.NickName});
                }
            }
            
            
            
        }

        public void SpinCylinder()
        {
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
            //try
            //{
            //    gameCallbacks(user, message);
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            try
            {
                foreach (User rec in clients.Keys)
                {
                    //if (rec.NickName == user.NickName)
                    //{
                        IGameCallback callback = clients[rec];
                        callback.PlayerSentMessage(user, message);

                        //foreach (User sender in _gameObj.clients.Keys)
                        //{
                        //    if (sender.NickName == message.User.NickName)
                        //    {
                        //        IGameCallback senderCallback = _gameObj.clients[sender];
                        //        senderCallback.PlayerSentMessage(user, message);
                        //        return;
                        //    }
                        //}
                    //}
                }
            }
            catch (Exception)
            {
                
                throw;
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

        public void Disconnect(User user)
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
                            callback.PlayerDisconnected(user, new UMessage(){ MessageContent = "Player " +user.NickName + " disconnected."});
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

        public bool SignIn(User user)
        {
            var userDb = db.Users.FirstOrDefault(x => x.Email == user.Email);
            if (userDb != null)
            {
                if (db.Users.FirstOrDefault(x => x.Email == user.Email).Password == user.Password)
                {
                    IPortalCallback subscriber =
                        OperationContext.Current.GetCallbackChannel<IPortalCallback>();
                    //m_PortalEvents += subscriber.OnUserSignIn;
                    //m_PortalEvents += subscriber.OnPublicMessageSent;

                    //m_Portal += subscriber.OnUserSignIn;
                    //m_Portal += subscriber.OnUserSignOut;
                    //m_Portal += subscriber.OnPublicMessageSent;

                    //m_PortalEvents(user, new UMessage() { MessageContent = "User :: "+user.NickName+" has signed in", TimeSent = DateTime.Now});
                    return true;

                }
                else
                    return false;
            }
            else return false;
        }

        public void SendPortalMessage(User user, UMessage message)
        {

        }

        //Sends a public message to main portal channel
        public void SendPublicMessage(UMessage message)
        {
            
        }

        public void SendPrivateMessage(User user, UMessage message)
        {

        }

        public void InviteToPlay(User user)
        {
            var newgameId = db.Games.Last().Id+1;
            
            //newGame = new Game(newgameId, user, user);
        }

        public void AgreeToPlay()
        {

        }


        public void Dispose()
        {
            db.Dispose();
        }
    }
}