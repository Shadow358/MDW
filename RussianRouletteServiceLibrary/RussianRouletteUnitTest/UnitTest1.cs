using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RussianRouletteUnitTest.RussianRouletteServer;
using System.ServiceModel;

namespace RussianRouletteUnitTest
{
    [TestClass]
    public class UnitTest1
    {

        class MyCallbackClasses : IGameCallback
        {
            public void PlayerReady()
            {
                
            }

            public void PlayerSentMessage()
            {

            }
        }

        private GameClient _gameClient = null;
        private PortalClient _portalClient = null;
        private InstanceContext _instance = null;
        public string message = null;


        [TestMethod]
        public void RegisterUserTest()
        {


            _instance = new InstanceContext(new MyCallbackClasses());
           // _gameClient = new GameClient(_instance);
           // _gameClient.Open();
            try
            {
                _portalClient = new PortalClient();
                _portalClient.Open();
            }
            finally
            {
               var response = _portalClient.RegisterUser(new User() { Email = "Zigm4s@gmail.com", FirstName = "Zigmas", LastName = "Slusnys", NickName = "Zigm4s", Password = "passwordZigmas" });
                Assert.AreEqual("exists", response);
            }
        }
    }
}
