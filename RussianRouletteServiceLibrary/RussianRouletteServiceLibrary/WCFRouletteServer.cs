
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
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession,
                     ConcurrencyMode = ConcurrencyMode.Reentrant,
                     UseSynchronizationContext = false)]
    public class WCFRouletteServer : IGame, IPortal
    {
        //Database object
        ServiceContext db = new ServiceContext();

        //Event actions
        //static Action<User, UMessage> m_PortalEvents = delegate {};
        static Action<int> m_PortalTest = delegate { };
        static Action<User, UMessage> m_Portal = delegate { };

        public WCFRouletteServer()
        {

        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public string PlaceBullet(int cylinderHole)
        {
            throw new NotImplementedException();
        }

        public string SpingCylinder()
        {
            throw new NotImplementedException();
        }

        public bool Shoot(User player)
        {
            throw new NotImplementedException();
        }

        //sends message in game.
        public void SendMessage(UMessage message)
        {
        }

        public string DetermineWinner()
        {
            throw new NotImplementedException();
        }

        public string Rematch()
        {
            throw new NotImplementedException();
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

                    m_Portal += subscriber.OnUserSignIn;
                    m_Portal += subscriber.OnUserSignOut;
                    m_Portal += subscriber.OnPublicMessageSent;

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

        }

        public void AgreeToPlay()
        {

        }


    }
}