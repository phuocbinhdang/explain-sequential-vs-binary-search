using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Bai_Tap
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        int Search(double[] array, int n, double X)
        {
            int find = -1;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == X)
                {
                    find = i;
                    return find;
                }
            }
            return find;
        }

        void Star()
        {
            Thread.Sleep(500);
            c0.BackColor = Color.LightBlue;
            c1.BackColor = Color.LightBlue;
            c2.BackColor = Color.LightBlue;
            c3.BackColor = Color.LightBlue;
            c4.BackColor = Color.LightBlue;
            c5.BackColor = Color.LightBlue;
            c6.BackColor = Color.LightBlue;
            c7.BackColor = Color.LightBlue;
            c8.BackColor = Color.LightBlue;
            c9.BackColor = Color.LightBlue;
        }

        void ShowC0()
        {
            Thread.Sleep(1000);
            c0.Text = x.Text;
            Thread.Sleep(1000);
            c0.BackColor = Color.LightGreen;
            MessageBox.Show("Tìm thấy phần tử " + x.Text + " tại vị trí 1");
        }

        void ShowC1()
        {
            Thread.Sleep(1000);
            c0.Text = x.Text;
            Thread.Sleep(1000);
            c0.BackColor = Color.Red;
            Thread.Sleep(1000);
            c0.BackColor = Color.White;
            c0.Text = "";
            c1.Text = x.Text;
            Thread.Sleep(1000);
            c1.BackColor = Color.LightGreen;
            MessageBox.Show("Tìm thấy phần tử " + x.Text + " tại vị trí 2");
        }

        void ShowC2()
        {
            Thread.Sleep(1000);
            c0.Text = x.Text;
            Thread.Sleep(1000);
            c0.BackColor = Color.Red;
            Thread.Sleep(1000);
            c0.BackColor = Color.Gray;
            c0.Text = "";
            c1.Text = x.Text;
            Thread.Sleep(1000);
            c1.BackColor = Color.Red;
            Thread.Sleep(1000);
            c1.BackColor = Color.Gray;
            c1.Text = "";
            c2.Text = x.Text;
            Thread.Sleep(1000);
            c2.BackColor = Color.LightGreen;
            MessageBox.Show("Tìm thấy phần tử " + x.Text + " tại vị trí 3");
        }

        void ShowC3()
        {
            Thread.Sleep(1000);
            c0.Text = x.Text;
            Thread.Sleep(1000);
            c0.BackColor = Color.Red;
            Thread.Sleep(1000);
            c0.BackColor = Color.Gray;
            c0.Text = "";
            c1.Text = x.Text;
            Thread.Sleep(1000);
            c1.BackColor = Color.Red;
            Thread.Sleep(1000);
            c1.BackColor = Color.Gray;
            c1.Text = "";
            c2.Text = x.Text;
            Thread.Sleep(1000);
            c2.BackColor = Color.Red;
            Thread.Sleep(1000);
            c2.BackColor = Color.Gray;
            c2.Text = "";
            c3.Text = x.Text;
            Thread.Sleep(1000);
            c3.BackColor = Color.LightGreen;
            MessageBox.Show("Tìm thấy phần tử " + x.Text + " tại vị trí 4");
        }

        void ShowC4()
        {
            Thread.Sleep(1000);
            c0.Text = x.Text;
            Thread.Sleep(1000);
            c0.BackColor = Color.Red;
            Thread.Sleep(1000);
            c0.BackColor = Color.Gray;
            c0.Text = "";
            c1.Text = x.Text;
            Thread.Sleep(1000);
            c1.BackColor = Color.Red;
            Thread.Sleep(1000);
            c1.BackColor = Color.Gray;
            c1.Text = "";
            c2.Text = x.Text;
            Thread.Sleep(1000);
            c2.BackColor = Color.Red;
            Thread.Sleep(1000);
            c2.BackColor = Color.Gray;
            c2.Text = "";
            c3.Text = x.Text;
            Thread.Sleep(1000);
            c3.BackColor = Color.Red;
            Thread.Sleep(1000);
            c3.BackColor = Color.Gray;
            c3.Text = "";
            c4.Text = x.Text;
            Thread.Sleep(1000);
            c4.BackColor = Color.LightGreen;
            MessageBox.Show("Tìm thấy phần tử " + x.Text + " tại vị trí 5");
        }

        void ShowC5()
        {
            Thread.Sleep(1000);
            c0.Text = x.Text;
            Thread.Sleep(1000);
            c0.BackColor = Color.Red;
            Thread.Sleep(1000);
            c0.BackColor = Color.Gray;
            c0.Text = "";
            c1.Text = x.Text;
            Thread.Sleep(1000);
            c1.BackColor = Color.Red;
            Thread.Sleep(1000);
            c1.BackColor = Color.Gray;
            c1.Text = "";
            c2.Text = x.Text;
            Thread.Sleep(1000);
            c2.BackColor = Color.Red;
            Thread.Sleep(1000);
            c2.BackColor = Color.Gray;
            c2.Text = "";
            c3.Text = x.Text;
            Thread.Sleep(1000);
            c3.BackColor = Color.Red;
            Thread.Sleep(1000);
            c3.BackColor = Color.Gray;
            c3.Text = "";
            c4.Text = x.Text;
            Thread.Sleep(1000);
            c4.BackColor = Color.Red;
            Thread.Sleep(1000);
            c4.BackColor = Color.Gray;
            c4.Text = "";
            c5.Text = x.Text;
            Thread.Sleep(1000);
            c5.BackColor = Color.LightGreen;
            MessageBox.Show("Tìm thấy phần tử " + x.Text + " tại vị trí 6");
        }

        void ShowC6()
        {
            Thread.Sleep(1000);
            c0.Text = x.Text;
            Thread.Sleep(1000);
            c0.BackColor = Color.Red;
            Thread.Sleep(1000);
            c0.BackColor = Color.Gray;
            c0.Text = "";
            c1.Text = x.Text;
            Thread.Sleep(1000);
            c1.BackColor = Color.Red;
            Thread.Sleep(1000);
            c1.BackColor = Color.Gray;
            c1.Text = "";
            c2.Text = x.Text;
            Thread.Sleep(1000);
            c2.BackColor = Color.Red;
            Thread.Sleep(1000);
            c2.BackColor = Color.Gray;
            c2.Text = "";
            c3.Text = x.Text;
            Thread.Sleep(1000);
            c3.BackColor = Color.Red;
            Thread.Sleep(1000);
            c3.BackColor = Color.Gray;
            c3.Text = "";
            c4.Text = x.Text;
            Thread.Sleep(1000);
            c4.BackColor = Color.Red;
            Thread.Sleep(1000);
            c4.BackColor = Color.Gray;
            c4.Text = "";
            c5.Text = x.Text;
            Thread.Sleep(1000);
            c5.BackColor = Color.Red;
            Thread.Sleep(1000);
            c5.BackColor = Color.Gray;
            c5.Text = "";
            c6.Text = x.Text;
            Thread.Sleep(1000);
            c6.BackColor = Color.LightGreen;
            MessageBox.Show("Tìm thấy phần tử " + x.Text + " tại vị trí 7");
        }

        void ShowC7()
        {
            Thread.Sleep(1000);
            c0.Text = x.Text;
            Thread.Sleep(1000);
            c0.BackColor = Color.Red;
            Thread.Sleep(1000);
            c0.BackColor = Color.Gray;
            c0.Text = "";
            c1.Text = x.Text;
            Thread.Sleep(1000);
            c1.BackColor = Color.Red;
            Thread.Sleep(1000);
            c1.BackColor = Color.Gray;
            c1.Text = "";
            c2.Text = x.Text;
            Thread.Sleep(1000);
            c2.BackColor = Color.Red;
            Thread.Sleep(1000);
            c2.BackColor = Color.Gray;
            c2.Text = "";
            c3.Text = x.Text;
            Thread.Sleep(1000);
            c3.BackColor = Color.Red;
            Thread.Sleep(1000);
            c3.BackColor = Color.Gray;
            c3.Text = "";
            c4.Text = x.Text;
            Thread.Sleep(1000);
            c4.BackColor = Color.Red;
            Thread.Sleep(1000);
            c4.BackColor = Color.Gray;
            c4.Text = "";
            c5.Text = x.Text;
            Thread.Sleep(1000);
            c5.BackColor = Color.Red;
            Thread.Sleep(1000);
            c5.BackColor = Color.Gray;
            c5.Text = "";
            c6.Text = x.Text;
            Thread.Sleep(1000);
            c6.BackColor = Color.Red;
            Thread.Sleep(1000);
            c6.BackColor = Color.Gray;
            c6.Text = "";
            c7.Text = x.Text;
            Thread.Sleep(1000);
            c7.BackColor = Color.LightGreen;
            MessageBox.Show("Tìm thấy phần tử " + x.Text + " tại vị trí 8");
        }

        void ShowC8()
        {
            Thread.Sleep(1000);
            c0.Text = x.Text;
            Thread.Sleep(1000);
            c0.BackColor = Color.Red;
            Thread.Sleep(1000);
            c0.BackColor = Color.Gray;
            c0.Text = "";
            c1.Text = x.Text;
            Thread.Sleep(1000);
            c1.BackColor = Color.Red;
            Thread.Sleep(1000);
            c1.BackColor = Color.Gray;
            c1.Text = "";
            c2.Text = x.Text;
            Thread.Sleep(1000);
            c2.BackColor = Color.Red;
            Thread.Sleep(1000);
            c2.BackColor = Color.Gray;
            c2.Text = "";
            c3.Text = x.Text;
            Thread.Sleep(1000);
            c3.BackColor = Color.Red;
            Thread.Sleep(1000);
            c3.BackColor = Color.Gray;
            c3.Text = "";
            c4.Text = x.Text;
            Thread.Sleep(1000);
            c4.BackColor = Color.Red;
            Thread.Sleep(1000);
            c4.BackColor = Color.Gray;
            c4.Text = "";
            c5.Text = x.Text;
            Thread.Sleep(1000);
            c5.BackColor = Color.Red;
            Thread.Sleep(1000);
            c5.BackColor = Color.Gray;
            c5.Text = "";
            c6.Text = x.Text;
            Thread.Sleep(1000);
            c6.BackColor = Color.Red;
            Thread.Sleep(1000);
            c6.BackColor = Color.Gray;
            c6.Text = "";
            c7.Text = x.Text;
            Thread.Sleep(1000);
            c7.BackColor = Color.Red;
            Thread.Sleep(1000);
            c7.BackColor = Color.Gray;
            c7.Text = "";
            c8.Text = x.Text;
            Thread.Sleep(1000);
            c8.BackColor = Color.LightGreen;
            MessageBox.Show("Tìm thấy phần tử " + x.Text + " tại vị trí 9");
        }

        void ShowC9()
        {
            Thread.Sleep(1000);
            c0.Text = x.Text;
            Thread.Sleep(1000);
            c0.BackColor = Color.Red;
            Thread.Sleep(1000);
            c0.BackColor = Color.Gray;
            c0.Text = "";
            c1.Text = x.Text;
            Thread.Sleep(1000);
            c1.BackColor = Color.Red;
            Thread.Sleep(1000);
            c1.BackColor = Color.Gray;
            c1.Text = "";
            c2.Text = x.Text;
            Thread.Sleep(1000);
            c2.BackColor = Color.Red;
            Thread.Sleep(1000);
            c2.BackColor = Color.Gray;
            c2.Text = "";
            c3.Text = x.Text;
            Thread.Sleep(1000);
            c3.BackColor = Color.Red;
            Thread.Sleep(1000);
            c3.BackColor = Color.Gray;
            c3.Text = "";
            c4.Text = x.Text;
            Thread.Sleep(1000);
            c4.BackColor = Color.Red;
            Thread.Sleep(1000);
            c4.BackColor = Color.Gray;
            c4.Text = "";
            c5.Text = x.Text;
            Thread.Sleep(1000);
            c5.BackColor = Color.Red;
            Thread.Sleep(1000);
            c5.BackColor = Color.Gray;
            c5.Text = "";
            c6.Text = x.Text;
            Thread.Sleep(1000);
            c6.BackColor = Color.Red;
            Thread.Sleep(1000);
            c6.BackColor = Color.Gray;
            c6.Text = "";
            c7.Text = x.Text;
            Thread.Sleep(1000);
            c7.BackColor = Color.Red;
            Thread.Sleep(1000);
            c7.BackColor = Color.Gray;
            c7.Text = "";
            c8.Text = x.Text;
            Thread.Sleep(1000);
            c8.BackColor = Color.Red;
            Thread.Sleep(1000);
            c8.BackColor = Color.Gray;
            c8.Text = "";
            c9.Text = x.Text;
            Thread.Sleep(1000);
            c9.BackColor = Color.LightGreen;
            MessageBox.Show("Tìm thấy phần tử " + x.Text + " tại vị trí 10");
        }

        void CantFind()
        {
            Thread.Sleep(1000);
            c0.Text = x.Text;
            Thread.Sleep(1000);
            c0.BackColor = Color.Red;
            Thread.Sleep(1000);
            c0.BackColor = Color.Gray;
            c0.Text = "";
            c1.Text = x.Text;
            Thread.Sleep(1000);
            c1.BackColor = Color.Red;
            Thread.Sleep(1000);
            c1.BackColor = Color.Gray;
            c1.Text = "";
            c2.Text = x.Text;
            Thread.Sleep(1000);
            c2.BackColor = Color.Red;
            Thread.Sleep(1000);
            c2.BackColor = Color.Gray;
            c2.Text = "";
            c3.Text = x.Text;
            Thread.Sleep(1000);
            c3.BackColor = Color.Red;
            Thread.Sleep(1000);
            c3.BackColor = Color.Gray;
            c3.Text = "";
            c4.Text = x.Text;
            Thread.Sleep(1000);
            c4.BackColor = Color.Red;
            Thread.Sleep(1000);
            c4.BackColor = Color.Gray;
            c4.Text = "";
            c5.Text = x.Text;
            Thread.Sleep(1000);
            c5.BackColor = Color.Red;
            Thread.Sleep(1000);
            c5.BackColor = Color.Gray;
            c5.Text = "";
            c6.Text = x.Text;
            Thread.Sleep(1000);
            c6.BackColor = Color.Red;
            Thread.Sleep(1000);
            c6.BackColor = Color.Gray;
            c6.Text = "";
            c7.Text = x.Text;
            Thread.Sleep(1000);
            c7.BackColor = Color.Red;
            Thread.Sleep(1000);
            c7.BackColor = Color.Gray;
            c7.Text = "";
            c8.Text = x.Text;
            Thread.Sleep(1000);
            c8.BackColor = Color.Red;
            Thread.Sleep(1000);
            c8.BackColor = Color.Gray;
            c8.Text = "";
            c9.Text = x.Text;
            Thread.Sleep(1000);
            c9.BackColor = Color.Red;
            Thread.Sleep(1000);
            c9.BackColor = Color.Gray;
            c9.Text = "";
            MessageBox.Show("Không tìm thấy phần tử");
        }

        
        private void TiepTuc_Click(object sender, EventArgs e)
        {
            c0.Clear(); 
            c1.Clear();
            c2.Clear();
            c3.Clear();
            c4.Clear();
            c5.Clear();
            c6.Clear();
            c7.Clear();
            c8.Clear();
            c9.Clear();

            c0.BackColor = Color.White;
            c1.BackColor = Color.White;
            c2.BackColor = Color.White;
            c3.BackColor = Color.White;
            c4.BackColor = Color.White;
            c5.BackColor = Color.White;
            c6.BackColor = Color.White;
            c7.BackColor = Color.White;
            c8.BackColor = Color.White;
            c9.BackColor = Color.White;

            double[] array = new double[10];

            //phan tu 1
            if (a0.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập phần tử thứ 1 !!!");
                return;
            }
            else
            {
                double d0 = Convert.ToDouble(a0.Text);
                array[0] = d0;
            }

            //phan tu 2
            if (a1.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập phần tử thứ 2 !!!");
                return;
            }
            else
            {
                double d1 = Convert.ToDouble(a1.Text);
                array[1] = d1;
            }

            //phan tu 3
            if (a2.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập phần tử thứ 3 !!!");
                return;
            }
            else
            {
                double d2 = Convert.ToDouble(a2.Text);
                array[2] = d2;
            }

            //phan tu 4
            if (a3.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập phần tử thứ 4 !!!");
                return;
            }
            else
            {
                double d3 = Convert.ToDouble(a3.Text);
                array[3] = d3;
            }

            //phan tu 5
            if (a4.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập phần tử thứ 5 !!!");
                return;
            }
            else
            {
                double d4 = Convert.ToDouble(a4.Text);
                array[4] = d4;
            }

            //phan tu 6
            if (a5.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập phần tử thứ 6 !!!");
                return;
            }
            else
            {
                double d5 = Convert.ToDouble(a5.Text);
                array[5] = d5;
            }

            //phan tu 7
            if (a6.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập phần tử thứ 7 !!!");
                return;
            }
            else
            {
                double d6 = Convert.ToDouble(a6.Text);
                array[6] = d6;
            }

            //phan tu 8
            if (a7.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập phần tử thứ 8 !!!");
                return;
            }
            else
            {
                double d7 = Convert.ToDouble(a7.Text);
                array[7] = d7;
            }

            //phan tu 9
            if (a8.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập phần tử thứ 9 !!!");
                return;
            }
            else
            {
                double d8 = Convert.ToDouble(a8.Text);
                array[8] = d8;
            }

            //phan tu 10
            if (a9.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập phần tử thứ 10 !!!");
                return;
            }
            else
            {
                double d9 = Convert.ToDouble(a9.Text);
                array[9] = d9;
            }

            if (x.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập phần tử muốn tìm !!!");
                return;
            }
            double X = Convert.ToDouble(x.Text);

            //b0->b9
            b0.Text = a0.Text;
            b1.Text = a1.Text;
            b2.Text = a2.Text;
            b3.Text = a3.Text;
            b4.Text = a4.Text;
            b5.Text = a5.Text;
            b6.Text = a6.Text;
            b7.Text = a7.Text;
            b8.Text = a8.Text;
            b9.Text = a9.Text;

            ThreadStart ts = new ThreadStart(Star);
            Thread thrd = new Thread(ts);
            thrd.Start();

            int find = Search(array, 10, X);

            if (find == -1)
            {
                ts = new ThreadStart(CantFind);
                thrd = new Thread(ts);
                thrd.Start();
                return;
            }

            if (find == 0)
            {
                ts = new ThreadStart(ShowC0);
                thrd = new Thread(ts);
                thrd.Start();
                return;
            }

            if (find == 1)
            {
                ts = new ThreadStart(ShowC1);
                thrd = new Thread(ts);
                thrd.Start();
                return;
            }

            if (find == 2)
            {
                ts = new ThreadStart(ShowC2);
                thrd = new Thread(ts);
                thrd.Start();
                return;
            }

            if (find == 3)
            {
                ts = new ThreadStart(ShowC3);
                thrd = new Thread(ts);
                thrd.Start();
                return;
            }

            if (find == 4)
            {
                ts = new ThreadStart(ShowC4);
                thrd = new Thread(ts);
                thrd.Start();
                return;
            }

            if (find == 5)
            {
                ts = new ThreadStart(ShowC5);
                thrd = new Thread(ts);
                thrd.Start();
                return;
            }

            if (find == 6)
            {
                ts = new ThreadStart(ShowC6);
                thrd = new Thread(ts);
                thrd.Start();
                return;
            }

            if (find == 7)
            {
                ts = new ThreadStart(ShowC7);
                thrd = new Thread(ts);
                thrd.Start();
                return;
            }

            if (find == 8)
            {
                ts = new ThreadStart(ShowC8);
                thrd = new Thread(ts);
                thrd.Start();
                return;
            }

            if (find == 9)
            {
                ts = new ThreadStart(ShowC9);
                thrd = new Thread(ts);
                thrd.Start();
                return;
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {

            c0.Text = b0.Text = a0.Text = "";
            c1.Text = b1.Text = a1.Text = "";
            c2.Text = b2.Text = a2.Text = "";
            c3.Text = b3.Text = a3.Text = "";
            c4.Text = b4.Text = a4.Text = "";
            c5.Text = b5.Text = a5.Text = "";
            c6.Text = b6.Text = a6.Text = "";
            c7.Text = b7.Text = a7.Text = "";
            c8.Text = b8.Text = a8.Text = "";
            c9.Text = b9.Text = a9.Text = "";
            x.Text = "";
            c0.BackColor = Color.White;
            c1.BackColor = Color.White;
            c2.BackColor = Color.White;
            c3.BackColor = Color.White;
            c4.BackColor = Color.White;
            c5.BackColor = Color.White;
            c6.BackColor = Color.White;
            c7.BackColor = Color.White;
            c8.BackColor = Color.White;
            c9.BackColor = Color.White;
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

    }
}

