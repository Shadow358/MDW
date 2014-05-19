using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RussianRouletteClient.RussianRouletteService;
using System.ServiceModel;

namespace RussianRouletteClient
{
    [CallbackBehavior(
        ConcurrencyMode = ConcurrencyMode.Reentrant,
        UseSynchronizationContext = false)]
    public partial class GameForm : Form, IGameCallback
    {
        #region IGame Callbacks
        public void PlayerSentMessage(User user, UMessage message)
        {
            lb_ChatBox.Items.Add("[" + message.TimeSent + "] " + user.NickName + " : " + message.MessageContent);
        }

        public void PlayerDisconnected()
        {

        }


        public void PlayerReady()
        {

        }


        public void PlayerLost()
        {

        }
        #endregion

        private GameClient _gameClient = null;
        private InstanceContext _instance = null;
        private User clientUser = new User(){ Email = "zigm4s@gmail.com", Id = 0, FirstName = "Zigmas", LastName = "Slusnys", NickName = "Ziggy", Password = "test123"};

        public GameForm()
        {
            _gameClient = new GameClient(new InstanceContext(this));
            InitializeComponent();
            _gameClient.Open();
        }

        private void btn_Spin_Click(object sender, EventArgs e)
        {
            _gameClient.SpingCylinder();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            _gameClient.Play();
        }

        private void btn_Rematch_Click(object sender, EventArgs e)
        {
            _gameClient.Rematch();
        }

        private void btn_Fire_Click(object sender, EventArgs e)
        {
            _gameClient.Shoot(new User() { });
        }

        private void btn_SendMessage_Click(object sender, EventArgs e)
        {
            _gameClient.SendMessage(this.clientUser,new UMessage() { MessageContent = tb_GameChat.Text, TimeSent = DateTime.Now, SenderId = clientUser.Id});
        }


    }
}
