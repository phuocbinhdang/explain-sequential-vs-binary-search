using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TiepTuc_Click(object sender, EventArgs e)
        {
            if (LinerSearch.Checked == true)
            {
                Form2 NewForm = new Form2();
                NewForm.Show();
                this.Dispose(false);
            }
            else if (BinarySearch.Checked == true)
            {
                Form3 NewForm = new Form3();
                NewForm.Show();
                this.Dispose(false);
            }
        }


    }
}
