﻿using System;
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
        ConcurrencyMode = ConcurrencyMode.Multiple,
        UseSynchronizationContext = false)]
    public partial class GameForm : Form, IGameCallback
    {
        #region IGame Callbacks
        public void PlayerSentMessage(User user, UMessage message)
        {
            //MessageBox.Show(user.NickName + " " + message.MessageContent);

            string nickname = user.NickName == gameUser.NickName ? "You" : user.NickName;
            Invoke(new MethodInvoker(() => lb_ChatBox.Items.Add(nickname + " : " + message.MessageContent)));
            
            //lb_ChatBox.Items.Add(nickname + " : " + message.MessageContent);

            //Invoke(new MethodInvoker(() => lb_ChatBox.Items.Add(nickname + " : " + message.MessageContent)));
            //RetrieveMsg(user, message);
            //MessageBox.Show(user.NickName + " sent a message: " +message.MessageContent);
            //lb_ChatBox.Items.Add("[" + message.TimeSent + "] " + user.NickName + " : " + message.MessageContent);
        }

        public void PlayerLeft(User user, UMessage message)
        {
            //MessageBox.Show(message.MessageContent);
            Invoke(new MethodInvoker(() => lb_ChatBox.Items.Add("[System]" + ": " + message.MessageContent)));
            
        }

        public void PlayerReady(User user)
        {
            
            //if(user != gameUser)
            //Invoke(new MethodInvoker(() => lb_ChatBox.Items.Add("[System]" + ": " + "Player " + user.NickName + " is ready to play.")));
            
        }

        public void PlayerLost(User user, UMessage message)
        {
            cylinderCounter = 0;
            //MessageBox.Show(message.MessageContent);
            Invoke(new MethodInvoker(() => lb_ChatBox.Items.Add("[System]" + ": " + message.MessageContent)));
            
        }

        public void BulletPlaced(User user, UMessage message)
        {
            //MessageBox.Show(user.NickName + " placed a bullet");
        }

        public void CylinderSpun(UMessage message)
        {
            //MessageBox.Show("The cylinder of the revolver has been spun");
            Invoke(new MethodInvoker(() => lb_ChatBox.Items.Add("[System]" + ": " + "The cylinder has been spun.")));
            
        }

        public void RematchRequested(User user, UMessage message)
        {
            throw new NotImplementedException();
        }
        
        public void YourTurn(User user, int nextHole)
        {
            cylinderCounter = nextHole;
            //MessageBox.Show(user.NickName + " did not die. Now it's your turn to try your luck.");
            Invoke(new MethodInvoker(() => lb_ChatBox.Items.Add("[System]" + ": " + user.NickName + " did not die. Now it's your turn to try your luck.")));
            
        }

        #endregion

        public bool loggedIn = false;

        private GameClient _gameClient = null;
        private InstanceContext _instance = null;
        private User gameUser = null;// = new User(){ Email = "zigm4s@gmail.com", Id = 0, FirstName = "Zigmas", LastName = "Slusnys", NickName = "Ziggy", Password = "test123"};
        private int currentGameId;


        private int cylinderCounter = 0; 


        public GameForm(User portalUser, int gameId)
        {
            string state;
            currentGameId = gameId;
            gameUser = portalUser;

            
            if (_gameClient != null)
            {
                MessageBox.Show("nelygu null");
                MessageBox.Show(_gameClient.State.ToString());
                //_gameClient = new GameClient(new InstanceContext(this));
            }
            else
            {

                _gameClient = new GameClient(new InstanceContext(this));
                //MessageBox.Show(_gameClient.State.ToString());
            }

            InitializeComponent();

            Text = "You are: " + gameUser.NickName + " Game number: " + gameId;

            try
            {
                _gameClient.Open();
                _gameClient.Play(currentGameId, gameUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void btn_Spin_Click(object sender, EventArgs e)
        {
            _gameClient.SpinCylinder(currentGameId);
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Rematch_Click(object sender, EventArgs e)
        {
            _gameClient.Rematch(currentGameId);
        }

        private void btn_Fire_Click(object sender, EventArgs e)
        {
            _gameClient.Shoot(currentGameId, gameUser, cylinderCounter);
        }

        private void btn_SendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                _gameClient.SendMessage(currentGameId, this.gameUser,
                    new UMessage()
                    {
                        MessageContent = tb_GameChat.Text,
                        TimeSent = DateTime.Now,
                        SenderId = gameUser.Id,
                        User = gameUser
                        
                    });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try {
                if (_gameClient.State != System.ServiceModel.CommunicationState.Faulted)
                {
                    //MessageBox.Show("Closing client");
                    _gameClient.Leave(currentGameId, gameUser);
                    _gameClient.ChannelFactory.Close();
                    _gameClient.Close();
                }
                else
                {
                    //MessageBox.Show("Aborting client");
                    _gameClient.Leave(currentGameId, gameUser);
                    _gameClient.Abort();
                }
                }
            catch(Exception ex)
            { MessageBox.Show(ex.ToString());}
        }


    }
}
