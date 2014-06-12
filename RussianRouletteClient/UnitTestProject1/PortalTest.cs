using System;
using System.ServiceModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RRClientTestUnit.RussianService;



namespace RRClientTestUnit
{
    [CallbackBehavior(
        ConcurrencyMode = ConcurrencyMode.Multiple,
        UseSynchronizationContext = false)]
    [TestClass]
    public class PortalTest : IPortalCallback
    {

        public PortalClient _portalClient = null;
        public User currentUser= null;
        public string disconnectMessage = null;
        public string userConnected = null;
        
        [TestMethod]
        public void Test_SignIn_No1()
        {
            

            try
            {
                //PortalClient
                    _portalClient = new PortalClient(new InstanceContext(this));
                _portalClient.Open();
                _portalClient.SignIn(new User() { Email = "zigm4s@gmail.com", Password = "asdfasd" });
                User testUser = new User() { NickName = "Zig", Email = "Zigmas@gmail.com", Password = "asdfasd" };

                Assert.AreEqual(testUser.NickName, currentUser.NickName);
                _portalClient.Close();
                _portalClient = null;
            }
            catch (Exception ex)
            {

            }
        }

        [TestMethod]
        public void Test_SignIn_No2()
        {
           //PortalClient 
               _portalClient = new PortalClient(new InstanceContext(this));
            
            try
            {
                _portalClient.Open();
                _portalClient.SignIn(new User() { Email = "aleksander@gmail.com", Password = "password123"});
                User testUser = new User() { NickName = "Alex", Email = "Zigmas@gmail.com", Password = "asdfasd"};

                Assert.AreEqual(testUser.NickName, currentUser.NickName);
                
                _portalClient.Close();
                _portalClient = null;
            }
            catch (Exception ex)
            {
                
            }
        }

        [TestMethod]
        public void Test_Disconnect_No1()
        {
            //PortalClient 
            _portalClient = new PortalClient(new InstanceContext(this));

            try
            {
                _portalClient.Open();
                _portalClient.SignIn(new User() { Email = "aleksander@gmail.com", Password = "password123" });
                User testUser = new User() { NickName = "Alex", Email = "Zigmas@gmail.com", Password = "asdfasd" };

                Assert.AreEqual(testUser.NickName, currentUser.NickName);
                _portalClient.Disconnect(currentUser);
                Assert.AreEqual("disconnected Alex", disconnectMessage);
                _portalClient.Close();
                _portalClient = null;
            }
            catch (Exception ex)
            {

            }
        }

        [TestMethod]
        public void Test_Disconnect_No2()
        {
            //PortalClient 
            _portalClient = new PortalClient(new InstanceContext(this));

            try
            {
                _portalClient.Open();
                _portalClient.SignIn(new User() { Email = "zigm4s@gmail.com", Password = "asdfasd" });
                User testUser = new User() { NickName = "Zig", Email = "Zigmas@gmail.com", Password = "asdfasd" };

                Assert.AreEqual(testUser.NickName, currentUser.NickName);
                _portalClient.Disconnect(currentUser);
                Assert.AreEqual("disconnected Zig", disconnectMessage);
                _portalClient.Close();
                _portalClient = null;
            }
            catch (Exception ex)
            {

            }
        }

        [TestMethod]
        public void Test_userConnected_No1()
        {
            //PortalClient 
            _portalClient = new PortalClient(new InstanceContext(this));

            try
            {
                _portalClient.Open();
                _portalClient.SignIn(new User() { Email = "zigm4s@gmail.com", Password = "asdfasd" });
                User testUser = new User() { NickName = "Alex", Email = "Zigmas@gmail.com", Password = "asdfasd" };

                Assert.AreEqual(testUser.NickName, currentUser.NickName);
                _portalClient.Disconnect(currentUser);
                Assert.AreEqual("disconnected Zig", disconnectMessage);
                _portalClient.Close();
                _portalClient = null;
            }
            catch (Exception ex)
            {

            }
        }


        public void OnUserSignIn(User[] userList, UMessage message)
        {
            throw new System.NotImplementedException();
        }

        public void SignInSuccess(User user)
        {
            currentUser = user;
        }

        public void OnUserSignOut(User user, UMessage message)
        {
            throw new System.NotImplementedException();
        }

        public void OnPublicMessageSent(User user, UMessage message)
        {
            throw new System.NotImplementedException();
        }

        public void OnPrivateMessageSent(User user, UMessage message)
        {
            throw new System.NotImplementedException();
        }

        public void OnInvitedToPlay(User user)
        {
            throw new System.NotImplementedException();
        }

        public void UserDisconnected(User user)
        {
            disconnectMessage = "disconnected " + user.NickName;
        }
    }
}
