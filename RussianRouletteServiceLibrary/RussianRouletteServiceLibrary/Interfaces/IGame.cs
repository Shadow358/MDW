using RussianRouletteServiceLibrary.Data;
using System.ServiceModel;

namespace RussianRouletteServiceLibrary.Interfaces
{
    //[DataContract]
    //public class Game
    //{
    //    [DataMember]
    //    public int _id { get; set; }

    //    public User _player1 { get; set; }
    //    public User _player2 { get; set; }

    //    public List<UMessage> _gameChat;
    //    public bool[] _cylinder;
    //    public User _winner;

    //    public Dictionary<User, IGameCallback> clients = null;

    //    public List<User> playerList = null;

    //    public Game(User player1, User player2)
    //    {

    //        clients = new Dictionary<User, IGameCallback>();
    //        playerList = new List<User>();

    //        _cylinder = new bool[6];
    //        _gameChat = new List<UMessage>();

    //    }

    //    public Game()
    //    {
    //        clients = new Dictionary<User, IGameCallback>();
    //        playerList = new List<User>();

    //        _cylinder = new bool[6];
    //        _gameChat = new List<UMessage>();

    //    }

        

    //    public IGameCallback CurrentCallback
    //    {
    //        get
    //        {
    //            return OperationContext.Current.
    //                   GetCallbackChannel<IGameCallback>();
    //        }
    //    }

    //    public bool SearchUsersByNickname(string nickname)
    //    {
    //        return clients.Keys.Any(c => c.NickName == nickname);
    //    }
    //}

    [ServiceContract(SessionMode = SessionMode.Allowed, CallbackContract = typeof(IGameCallback))]
    public interface IGame
    {
        [OperationContract]
        void Play(int gameId, User user);

        [OperationContract]
        void PlaceBullet(int gameId, int cylinderHole, User user);

        [OperationContract]
        void SpinCylinder(int gameId);

        [OperationContract]
        bool Shoot(int gameId, User player, int chosenHole);

        [OperationContract(IsOneWay = true)]
        void SendMessage(int gameId, User user, UMessage message);

        [OperationContract]
        void DetermineWinner(int gameId);

        [OperationContract]
        void Rematch(int gameId);

        [OperationContract]
        void Leave(int gameId, User user);


    }

    public interface IGameCallback
    {
        [OperationContract(IsOneWay = true)]
        void PlayerSentMessage(User user, UMessage message);

        [OperationContract(IsOneWay = true)]
        void PlayerLeft(User user, UMessage message);

        [OperationContract(IsOneWay = true)]
        void PlayerReady(User user);

        [OperationContract(IsOneWay = true)]
        void PlayerLost(User user, UMessage message);

        [OperationContract(IsOneWay = true)]
        void BulletPlaced(User user, UMessage message);

        [OperationContract(IsOneWay = true)]
        void CylinderSpun(UMessage message);

        [OperationContract(IsOneWay = true)]
        void RematchRequested(User user, UMessage message);

        [OperationContract(IsOneWay = true)]
        void YourTurn(User user, int nextHole);


    }

}