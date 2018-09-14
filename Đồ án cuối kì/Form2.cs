using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án_cuối_kì
{
    public partial class Form2 : Form
    {
        private bool Troll;
        public Form2()
        {
            InitializeComponent();
        }

        public bool troll
        {
            get { return Troll; }
            set { Troll = value; }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool TSMTrollChecked = Troll;
            if (TSMTrollChecked == true)
                if (MessageBox.Show("Thầy sẽ cho nhóm em 10 điểm chứ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
