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
    public partial class PortalForm : Form, IPortalCallback
    {
        #region IPortal callbacks
        public void OnUserSignIn(User user, UMessage message)
        {
            
            MessageBox.Show("User " + user.NickName + " has signed in.");
        }
        public void OnUserSignOut(User user)
        {

        }

        public void OnPublicMessageSent(User user, UMessage message)
        {

        }

        public void OnPrivateMessageSent(User user, UMessage message)
        {

        }
        public void OnUserLogin(int numeris)
        {
            MessageBox.Show(numeris.ToString());
        }
        #endregion

        //Describes portal client object
        private PortalClient _portalClient = null;

        public PortalForm()
        {
            InitializeComponent();
            try
            {
                _portalClient = new PortalClient(new InstanceContext(this));
                _portalClient.SignIn(new User() { Email = "Zigm4s@gmail.com", Password = "asdfasd" });
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
