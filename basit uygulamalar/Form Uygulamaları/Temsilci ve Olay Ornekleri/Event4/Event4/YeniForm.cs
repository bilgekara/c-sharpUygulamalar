using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event4
{
    public partial class YeniForm : Form
    {
        public event EventHandler SayButonunaTiklandi;

        public YeniForm()
        {
            InitializeComponent();
        }

        private void sayButton_Click(object sender, EventArgs e)
        {
            if (SayButonunaTiklandi == null) return;
            SayButonunaTiklandi(this, new EventArgs());
        }
    }
}
