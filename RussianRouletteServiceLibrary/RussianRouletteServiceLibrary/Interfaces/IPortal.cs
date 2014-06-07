using RussianRouletteServiceLibrary.Data;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace RussianRouletteServiceLibrary.Interfaces
{
    [DataContract]
    public class Portal
    {
        //[DataMember]
        public String PortalName { get; set; }

    }

    [ServiceContract(
    SessionMode = SessionMode.Allowed,
    CallbackContract = typeof(IPortalCallback))]
    public interface IPortal
    {
        [OperationContract]
        string SignUp(User user);

        [OperationContract]
        void SignIn(User user);

        [OperationContract]
        void SendPublicMessage(User user, UMessage message);

        [OperationContract]
        void SendPrivateMessage(User user, UMessage message);

        [OperationContract]
        void InviteToPlay(string Nickname, User user);

        [OperationContract]
        void AgreeToPlay(string Nickname, User user);

        [OperationContract]
        void Disconnect(User user);

        [OperationContract]
        bool checkSignIn(User user);

        [OperationContract]
        List<string> GetUsersList();

    }

    public interface IPortalCallback
    {
        [OperationContract(IsOneWay = true)]
        void OnUserSignIn(List<string> userList , UMessage message);

        [OperationContract(IsOneWay = true)]
        void SignInSuccess(User user);

        [OperationContract(IsOneWay = true)]
        void OnUserSignOut(User user, UMessage message);

        [OperationContract(IsOneWay = true)]
        void OnPublicMessageSent(User user, UMessage message);

        [OperationContract(IsOneWay = true)]
        void OnPrivateMessageSent(User user, UMessage message);

        [OperationContract(IsOneWay = true)]
        void InvitedToPlay(User user);

        [OperationContract(IsOneWay = true)]
        void AgreedToPlay(int gameId);

        [OperationContract(IsOneWay = true)]
        void UserDisconnected(List<string> userList, UMessage message);

        [OperationContract(IsOneWay = true)]
        void GetUserList(List<User> users);
    }
}