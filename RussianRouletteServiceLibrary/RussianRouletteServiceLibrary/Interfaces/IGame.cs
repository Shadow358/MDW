using RussianRouletteServiceLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;

namespace RussianRouletteServiceLibrary.Interfaces
{
    [DataContract]
    public class Game
    {
        [DataMember]
        public int _id { get; set; }

        public User _player1 { get; set; }
        public User _player2 { get; set; }

        public List<UMessage> _gameChat;
        private bool[] _cylinder;
        public User _winner;

        public Game(User player1, User player2)
        {
            _cylinder = new bool[6];
            _gameChat = new List<UMessage>();

        }
    }

    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(IGameCallback))]
    public interface IGame
    {
        [OperationContract]
        void Play();

        [OperationContract]
        string PlaceBullet(int cylinderHole);

        [OperationContract]
        string SpingCylinder();

        [OperationContract]
        bool Shoot(User player);

        [OperationContract]
        void SendMessage(UMessage message);

        [OperationContract]
        string DetermineWinner();

        [OperationContract]
        string Rematch();
    }

    public interface IGameCallback
    {
        [OperationContract(IsOneWay = true)]
        void PlayerSentMessage();

        [OperationContract(IsOneWay = true)]
        void PlayerDisconnected();

        [OperationContract(IsOneWay = true)]
        void PlayerReady();

        [OperationContract(IsOneWay = true)]
        void PlayerLost();
    }

}