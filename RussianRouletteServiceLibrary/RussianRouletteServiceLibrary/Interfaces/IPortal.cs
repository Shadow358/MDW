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
    public class Portal
    {
        [DataMember]
        public String PortalName { get; set; }

    }

    [ServiceContract(
    SessionMode = SessionMode.Required,
    CallbackContract = typeof(IPortalCallback))]
    public interface IPortal
    {
        [OperationContract]
        string SignUp(User user);

        [OperationContract]
        bool SignIn(User user);

        [OperationContract]
        void SendPublicMessage(UMessage message);

        [OperationContract]
        void SendPrivateMessage(User user, UMessage message);

        [OperationContract]
        void InviteToPlay(User user);

        [OperationContract]
        void AgreeToPlay();
    }

    public interface IPortalCallback
    {
        [OperationContract(IsOneWay = true)]
        void OnUserSignIn(User user, UMessage message);

        [OperationContract(IsOneWay = true)]
        void OnUserSignOut(User user, UMessage message);

        [OperationContract(IsOneWay = true)]
        void OnPublicMessageSent(User user, UMessage message);

        [OperationContract(IsOneWay = true)]
        void OnPrivateMessageSent(User user, UMessage message);

        [OperationContract(IsOneWay=true)]
        void OnInvitedToPlay(User user);
    }
}