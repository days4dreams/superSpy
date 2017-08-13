using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superSpy
{
    public partial class AgentPortal : Form
    {
        SecretAgent ciaAgent = new SecretAgent();

        public AgentPortal()
        {
            InitializeComponent();
        }

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            string userInput = textBoxPassword.Text;
            if (userInput == string.Empty)
            {
                MessageBox.Show("Please enter a Password");
            }
            else
            {
                string returned = ciaAgent.AgentGreeting(userInput);
                labelRealNameOutput.Text = returned;
            }
        }

        private void labelInstruction_Click(object sender, EventArgs e)
        {

        }
    }
}
