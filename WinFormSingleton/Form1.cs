using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSingleton
{
    public partial class Form1 : Form
    {
        // Properties
        private string logID;
        private string roleID;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            logID = txtBoxLog.Text;
            roleID = txtBoxRole.Text;

            ApplicationState state = ApplicationState.GetState();
            state.LoginId = logID;
            state.RoleId = roleID;

            ApplicationState state2 = ApplicationState.GetState();
            lblLog.Text = state2.LoginId;
            lblRole.Text = state2.RoleId;
            lblState.Text = (state == state2).ToString();

        }
    }
}
