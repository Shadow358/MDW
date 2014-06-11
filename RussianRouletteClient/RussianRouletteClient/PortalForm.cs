using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RussianRouletteClient.RussianRouletteService;
using System.ServiceModel;

namespace RussianRouletteClient
{
    [CallbackBehavior(
        ConcurrencyMode = ConcurrencyMode.Multiple,
        UseSynchronizationContext = false)]
    public partial class PortalForm : Form, IPortalCallback
    {
        #region IPortal callbacks
        //public void OnUserSignIn(User user, UMessage message)
        //{
        //    MessageBox.Show("User " + user.NickName + " has signed in.");
        //}

        public void OnUserSignIn(string[] userList, UMessage message)
        {
            Invoke(new MethodInvoker(() => lb_usersOnline.Items.Clear()));
                
            foreach (var item in _portalProxy.GetUsersList().ToList())
            {
                if (item == currentUser.NickName) {
                    //Invoke(new MethodInvoker(() => lb_usersOnline.Items.Add("*" + item)));
                    Invoke(new MethodInvoker(() => Text = "Russian Roulette :: Welcome " + currentUser.NickName));

                }
                else
                {
                    Invoke(new MethodInvoker(() => lb_usersOnline.Items.Add(item)));
                }
            }

            if (message.User.NickName != currentUser.NickName)
            {
                Invoke(
                    new MethodInvoker(
                        () =>
                            ChatBox.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] System message: " +
                                               message.MessageContent + "\n")));
                Invoke(
                    new MethodInvoker(
                        () =>
                ChatBox.ScrollToCaret()));
            }
            //lb_usersOnline.DataSource = userList;
            //MessageBox.Show(message.MessageContent);
        }

        public void SignInSuccess(User user)
        {
            currentUser = user;
        }

        public void OnUserSignOut(User user, UMessage message)
        {
            MessageBox.Show(user.NickName + message.MessageContent);
        }

        public void InvitedToPlay(User user)
        {
            DialogResult dialogResult = MessageBox.Show("You have been invited to play by the user " + user.NickName + ". Accept?", "Accept game invitation",
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _portalProxy.AgreeToPlay(user.NickName, currentUser);
                //this.Hide();
                //Thread.Sleep(5000);
                //this.Show();
                //GameForm gameForm = new GameForm(currentUser, gameId: 1);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
            //MessageBox.Show("You have been invited to play by the user " + user.NickName);
        }

        public void AgreedToPlay(int gameId)
        {

            //Invoke(new MethodInvoker(() => Portalfor));
            //this.Hide();
            //Thread.Sleep(7000);
            //this.Show();
            GameForm gameForm = new GameForm(currentUser, gameId: gameId);
            gameForm.ShowDialog();
            //MessageBox.Show("User accepted to play. The game will soon initiate");


        }

        public void UserDisconnected(string[] userList, UMessage message)
        {
            Invoke(new MethodInvoker(() => lb_usersOnline.Items.Clear()));

            foreach (var item in _portalProxy.GetUsersList().ToList())
            {
                if (item != currentUser.NickName)
                {
                    Invoke(new MethodInvoker(() => lb_usersOnline.Items.Add(item)));
                }
            }

            if (message.User.NickName != currentUser.NickName)
            {
                Invoke(
                    new MethodInvoker(
                        () =>
                            ChatBox.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] System message: " +
                                               message.MessageContent + "\n")));
                Invoke(
                    new MethodInvoker(
                        () =>
                ChatBox.ScrollToCaret()));
            }
        }

        public void GetUserList(User[] users)
        {
            throw new NotImplementedException();
        }

        public void OnPublicMessageSent(User user, UMessage message)
        {
            string nickname = user.NickName == currentUser.NickName ? "You" : user.NickName;
            //Invoke(new MethodInvoker(() => lb_publicChat.Items.Add(nickname + " : " + message.MessageContent)));
            Invoke(new MethodInvoker(() => ChatBox.AppendText(("[" +DateTime.Now.ToString("HH:mm:ss")+"] " + nickname + " : " + message.MessageContent+"\n"))));
            Invoke(
                    new MethodInvoker(
                        () =>
                ChatBox.ScrollToCaret()));
        }

        public void OnPrivateMessageSent(User user, UMessage message)
        {

        }
        #endregion

        //Describes portal client object
        public PortalClient _portalProxy = null;
        public User currentUser = null;

        public PortalForm(User portalUser)
        {
            

            _portalProxy = new PortalClient(new InstanceContext(this));
            
            InitializeComponent();

            currentUser = portalUser;
            
            
            try
            {

                
                _portalProxy.Open();

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
               

                _portalProxy.SignIn(currentUser);
            }
            this.AcceptButton = btn_SendMessage;
        }

        private void PortalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _portalProxy.Disconnect(currentUser);
            try
            {
                if (_portalProxy.State != CommunicationState.Faulted)
                {

                    
                    _portalProxy.ChannelFactory.Close();
                    _portalProxy.Close();
                }
                else
                {
                    MessageBox.Show("Aborting client");
                    _portalProxy.Disconnect(currentUser);
                    _portalProxy.Abort();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }

        private void btn_SendMessage_Click(object sender, EventArgs e)
        {
            _portalProxy.SendPublicMessage(currentUser, new UMessage(){ MessageContent = typeBox.Text, TimeSent = DateTime.Now});
            typeBox.Text = "";
        }

        private void lb_usersOnline_Click(object sender, EventArgs e)
        {
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Invite to play").Click += delegate
            {
               
                _portalProxy.InviteToPlay(lb_usersOnline.SelectedItem.ToString(), currentUser);
            };

            cm.MenuItems.Add("Send message");



            lb_usersOnline.ContextMenu = cm;
        }

        private void typeBox_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    btn_SendMessage_Click(sender, e);
            //}
        }

        private void Top10ListBox_SelectedIndexChanged(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Name == "tabPage2")
            {
                Top10ListBox.Items.Clear();
                foreach (string s in _portalProxy.ReceiveTopPlayers())
                {
                    Top10ListBox.Items.Add(s);
                }
            }
        }
    }
}
