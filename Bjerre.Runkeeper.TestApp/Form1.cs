using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bjerre.Runkeeper.TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void collectStats_Click(object sender, EventArgs e)
        {
            var username = usernameBox.Text;
            var password = passwordBox.Text;
            var startDate = startDateBox.Text;
            AddLog(string.Format("Collects stats for user:'{0}' pass:'{1}' from '{2}'", username, password, startDate));
            var allActivities = Helpers.CollectStats.GetAllActivities(username, password,startDate);
            foreach (var monthActivities in allActivities)
                AddLog(string.Format("Distance '{0}' Time '{1}'", monthActivities.distance, monthActivities.elapsedTime));
        }

        private delegate void AddLogDelegate(string text);
        private void AddLog(string text)
        {
            if (richTextBox1.InvokeRequired)
            {
                var addLogDelegate = new AddLogDelegate(AddLog);
                Invoke(addLogDelegate, new object[] { text });
            }
            else
            {
                richTextBox1.Text += text + Environment.NewLine;
                richTextBox1.Select(richTextBox1.Text.Length, 0);
                richTextBox1.ScrollToCaret();
            }
        }



        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
