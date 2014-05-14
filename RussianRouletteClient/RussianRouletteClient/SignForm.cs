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
        ConcurrencyMode = ConcurrencyMode.Single,
        UseSynchronizationContext = false)]
    public partial class StartForm : Form, IPortalCallback
    {        
            #region IPortal callbacks
            //public void OnUserSignIn(User user, UMessage message)
            //{
            //    MessageBox.Show("User " + user.NickName + " has signed in.");
            //}
            //public void OnUserSignOut(User user)
            //{

            //}

            //public void OnPublicMessageSent(User user, UMessage message)
            //{

            //}

            //public void OnPrivateMessageSent(User user, UMessage message)
            //{

            //}
            public void OnUserLogin(int numeris)
            {
                MessageBox.Show(numeris.ToString());
            }
            #endregion
        

       private GameClient _gameClient = null;
       private PortalClient _portalClient = null;
       private InstanceContext _instance = null;
       public string message = null;

        public StartForm()
       {
               _instance = new InstanceContext(this);
               _portalClient = new PortalClient(_instance);
               

           
            InitializeComponent();
            _portalClient.Open();
            
        }

        //319, 462 opened registration

        //319, 173 closed registration

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            bool login = _portalClient.SignIn(new User() { Email = tb_Email.Text, Password = tb_Password.Text });
            MessageBox.Show(login.ToString());
            
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
                _portalClient.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
           
        }
    }
}
