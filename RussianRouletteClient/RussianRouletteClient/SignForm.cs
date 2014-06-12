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
    public partial class StartForm : Form, IPortalCallback
    {
        #region IPortal callbacks
        

        public void OnUserSignIn(string[] userList, UMessage message)
        {
            throw new NotImplementedException();
        }

        public void SignInSuccess(User user)
        {
            
            currentUser = user;
        }

        public void OnUserSignOut(User user, UMessage message)
        {
            throw new NotImplementedException();
        }

        public void OnPublicMessageSent(User user, UMessage message)
        {
            throw new NotImplementedException();
        }

        public void OnPrivateMessageSent(User user, UMessage message)
        {
            throw new NotImplementedException();
        }

        public void InvitedToPlay(User user)
        {
            throw new NotImplementedException();
        }

         public void AgreedToPlay(int gameId)
         {
             throw new NotImplementedException();
         }

         public void UserDisconnected(string[] userList, UMessage message)
         {
             throw new NotImplementedException();
         }

         public void UserDisconnected(User user)
         {
             throw new NotImplementedException();
         }

         public void GetUserList(User[] users)
         {
             throw new NotImplementedException();
         }

         #endregion



        public PortalClient _portalClient = null;
        private InstanceContext _instance = null;
        public User currentUser;// = new User() { Email = "zigm4s@gmail.com", Id = 0, FirstName = "Zigmas", LastName = "Slusnys", NickName = "Ziggy", Password = "asdfasd" };

         
        public StartForm()
        {
            
               _portalClient = new PortalClient(new InstanceContext(this));
               

           
            InitializeComponent();
            Text = "Welcome to Russian Roulette!";
            _portalClient.Open();
            
        }

        //319, 462 opened registration

        //319, 173 closed registration

         private void btn_SignIn_Click(object sender, EventArgs e)
         {
             currentUser = new User() {Email = tb_Email.Text, Password = tb_Password.Text};
             bool checkSignIn = _portalClient.checkSignIn(currentUser);
             if (checkSignIn)
             {
                 this.DialogResult = DialogResult.OK;
                 //PortalForm portalas = new PortalForm(currentUser);
                 //portalas.Show();
             }
             else
             {
                 MessageBox.Show("failed to login");
             }
         }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            for(int i = 173; i < 462; i++)
            {
                this.Size = new Size(319, i);
            }
        }

        private void btn_RegSignUp_Click(object sender, EventArgs e)
        {
            if (tb_RegPassword.Text == tb_RegRepeatPassword.Text)
            {
                _portalClient.SignUp(new User() { Email = tb_RegEmail.Text, FirstName = tb_RegFirstname.Text, LastName = tb_RegLastname.Text, NickName = tb_RegNickname.Text, Password = tb_RegPassword.Text });
                MessageBox.Show("You have successfully registered!");
            }
            else
            {
                MessageBox.Show("Passwords have to match");
            }
        }

        private void btn_RegClose_Click(object sender, EventArgs e)
        {
            for (int i = 462; i < 173; i--)
            {
                this.Size = new Size(319, i);
            }
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (_portalClient.State != CommunicationState.Faulted)
                {
                    //MessageBox.Show("Closing client");
                    //_gameClient.Disconnect(clientUser);
                   // _portalClient.ChannelFactory.Close();
                    _portalClient.Close();
                }
                else
                {
                    MessageBox.Show("Aborting client");
                    //_portalClient.Disconnect(clientUser);
                    _portalClient.Abort();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
        }
    }
}
