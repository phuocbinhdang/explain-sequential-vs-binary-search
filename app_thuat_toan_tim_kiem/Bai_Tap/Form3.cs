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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        double[] Sorting(double[] array, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] > array[j])
                    {
                        double temp;
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        int BinarySearch(double[] array, double X, int i, int j)
        {
            if (i <= j)
            {
                int mid = i + (j - i) / 2;
                if (array[mid] == X)
                    return mid;
                if (X > array[mid])
                    return BinarySearch(array, X, mid + 1, j);
                else
                    return BinarySearch(array, X, i, mid - 1);
            }
            return -1;
        }

        void C5()
        {
            Thread.Sleep(1000);
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
            c10.Clear();
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
            c10.BackColor = Color.LightBlue;
            Thread.Sleep(1000);
            c5.Text = x.Text;
            if (x.Text == b5.Text)
            {
                Thread.Sleep(1000);
                c5.BackColor = Color.LightGreen;
                Thread.Sleep(1000);
                MessageBox.Show("Tìm thấy phần tử " + x.Text + " tại vị trí 6");
            }
        }

        //c5red
        void C8()
        {
            C5();
            Thread.Sleep(1000);
            c0.BackColor = Color.Red;
            c1.BackColor = Color.Red;
            c2.BackColor = Color.Red;
            c3.BackColor = Color.Red;
            c4.BackColor = Color.Red;
            c5.BackColor = Color.Red;
            Thread.Sleep(1000);
            c5.Text = "";
            c0.BackColor = Color.Gray;
            c1.BackColor = Color.Gray;
            c2.BackColor = Color.Gray;
            c3.BackColor = Color.Gray;
            c4.BackColor = Color.Gray;
            c5.BackColor = Color.Gray;
            Thread.Sleep(1000);
            c8.Text = x.Text;
            if (x.Text == b8.Text)
            {
                Thread.Sleep(1000);
                c8.BackColor = Color.LightGreen;
                Thread.Sleep(1000);
                MessageBox.Show("Tìm thấy phần tử " + x.Text + " tại vị trí 9");
            }
        }

        //c5red
        void C2()
        {
            C5();
            Thread.Sleep(1000);
            c5.BackColor = Color.Red;
            c6.BackColor = Color.Red;
            c7.BackColor = Color.Red;
            c8.BackColor = Color.Red;
            c9.BackColor = Color.Red;
            c10.BackColor = Color.Red;
            Thread.Sleep(1000);
            c5.Text = "";
            c5.BackColor = Color.Gray;
            c6.BackColor = Color.Gray;
            c7.BackColor = Color.Gray;
            c8.BackColor = Color.Gray;
            c9.BackColor = Color.Gray;
            c10.BackColor = Color.Gray;
            Thread.Sleep(1000);
            c2.Text = x.Text;
            if (x.Text == b2.Text)
            {
                Thread.Sleep(1000);
                c2.BackColor = Color.LightGreen;
                Thread.Sleep(1000);
                MessageBox.Show("Tìm thấy phần tử " + x.Text + " tại vị trí 3");
            }
        }

        //c8red c5red
        void C9()
        {
            C8();
            Thread.Sleep(1000);
            c6.BackColor = Color.Red;
            c7.BackColor = Color.Red;
            c8.BackColor = Color.Red;
            Thread.Sleep(1000);
            c8.Text = "";
            c6.BackColor = Color.Gray;
            c7.BackColor = Color.Gray;
            c8.BackColor = Color.Gray;
            Thread.Sleep(1000);
            c9.Text = x.Text;
            if (x.Text == b9.Text)
            {
                Thread.Sleep(1000);
                c9.BackColor = Color.LightGreen;
                Thread.Sleep(1000);
                MessageBox.Show("Tìm thấy phần tử " + x.Text + " tại vị trí 10");
            }
        }

        //c8red c5red
        void C6()
        {
            C8();
            Thread.Sleep(1000);
            c8.BackColor = Color.Red;
            c9.BackColor = Color.Red;
            c10.BackColor = Color.Red;
            Thread.Sleep(1000);
            c8.Text = "";
            c8.BackColor = Color.Gray;
            c9.BackColor = Color.Gray;
            c10.BackColor = Color.Gray;
            Thread.Sleep(1000);
            c6.Text = x.Text;
            if (x.Text == b6.Text)
            {
                Thread.Sleep(1000);
                c6.BackColor = Color.LightGreen;
                Thread.Sleep(1000);
                MessageBox.Show("Tìm thấy phần tử " + x.Text + " tại vị trí 7");
            }
        }

        //c2red c5red
        void C3()
        {
            C2();
            Thread.Sleep(1000);
            c0.BackColor = Color.Red;
            c1.BackColor = Color.Red;
            c2.BackColor = Color.Red;
            Thread.Sleep(1000);
            c2.Text = "";
            c0.BackColor = Color.Gray;
            c1.BackColor = Color.Gray;
            c2.BackColor = Color.Gray;
            Thread.Sleep(1000);
            c3.Text = x.Text;
            if (x.Text == b3.Text)
            {
                Thread.Sleep(1000);
                c3.BackColor = Color.LightGreen;
                Thread.Sleep(1000);
                MessageBox.Show("Tìm thấy phần tử " + x.Text + " tại vị trí 4");
            }
        }

        //c2red c5red
        void C0()
        {
            C2();
            Thread.Sleep(1000);
            c2.BackColor = Color.Red;
            c3.BackColor = Color.Red;
            c4.BackColor = Color.Red;
            Thread.Sleep(1000);
            c2.Text = "";
            c2.BackColor = Color.Gray;
            c3.BackColor = Color.Gray;
            c4.BackColor = Color.Gray;
            Thread.Sleep(1000);
            c0.Text = x.Text;
            if (x.Text == b0.Text)
            {
                Thread.Sleep(1000);
                c0.BackColor = Color.LightGreen;
                Thread.Sleep(1000);
                MessageBox.Show("Tìm thấy phần tử " + x.Text + " tại vị trí 1");
            }
        }

        //c9red c8red c5red
        void C10()
        {
            C9();
            Thread.Sleep(1000);
            c9.BackColor = Color.Red;
            Thread.Sleep(1000);
            c9.Text = "";
            c9.BackColor = Color.Gray;
            Thread.Sleep(1000);
            c10.Text = x.Text;
            if (x.Text == b10.Text)
            {
                Thread.Sleep(1000);
                c10.BackColor = Color.LightGreen;
                Thread.Sleep(1000);
                MessageBox.Show("Tìm thấy phần tử " + x.Text + " tại vị trí 11");
            }
        }

        //c6red c8red c5red
        void C7()
        {
            C6();
            Thread.Sleep(1000);
            c6.BackColor = Color.Red;
            Thread.Sleep(1000);
            c6.Text = "";
            c6.BackColor = Color.Gray;
            Thread.Sleep(1000);
            c7.Text = x.Text;
            if (x.Text == b7.Text)
            {
                Thread.Sleep(1000);
                c7.BackColor = Color.LightGreen;
                Thread.Sleep(1000);
                MessageBox.Show("Tìm thấy phần tử " + x.Text + " tại vị trí 8");
            }
        }

        //c3red c2red c5red
        void C4()
        {
            C3();
            Thread.Sleep(1000);
            c3.BackColor = Color.Red;
            Thread.Sleep(1000);
            c3.Text = "";
            c3.BackColor = Color.Gray;
            Thread.Sleep(1000);
            c4.Text = x.Text;
            if (x.Text == b4.Text)
            {
                Thread.Sleep(1000);
                c4.BackColor = Color.LightGreen;
                Thread.Sleep(1000);
                MessageBox.Show("Tìm thấy phần tử " + x.Text + " tại vị trí 5");
            }
        }

        //c0red c2red c5red
        void C1()
        {
            C0();
            Thread.Sleep(1000);
            c0.BackColor = Color.Red;
            Thread.Sleep(1000);
            c0.Text = "";
            c0.BackColor = Color.Gray;
            Thread.Sleep(1000);
            c1.Text = x.Text;
            if (x.Text == b1.Text)
            {
                Thread.Sleep(1000);
                c1.BackColor = Color.LightGreen;
                Thread.Sleep(1000);
                MessageBox.Show("Tìm thấy phần tử " + x.Text + " tại vị trí 2");
            }
        }

        void CantFind(double[] array, double X)
        {
            if (array[0] > X)
            {
                C0();
                Thread.Sleep(1000);
                c0.BackColor = Color.Red;
                c1.BackColor = Color.Red;
                Thread.Sleep(1000);
                c0.Text = "";
                c0.BackColor = Color.Gray;
                c1.BackColor = Color.Gray;
                Thread.Sleep(1000);
                MessageBox.Show("Không tìm thấy phần tử");
                return;
            }
            if (array[0] < X && X < array[2])
            {
                C1();
                c1.BackColor = Color.Red;
                Thread.Sleep(1000);
                c1.Text = "";
                c1.BackColor = Color.Gray;
                Thread.Sleep(1000);
                MessageBox.Show("Không tìm thấy phần tử");
                return;
            }
            if (array[3] > X)
            {
                C3();
                Thread.Sleep(1000);
                c3.BackColor = Color.Red;
                c4.BackColor = Color.Red;
                Thread.Sleep(1000);
                c3.Text = "";
                c3.BackColor = Color.Gray;
                c4.BackColor = Color.Gray;
                Thread.Sleep(1000);
                MessageBox.Show("Không tìm thấy phần tử");
                return;
            }
            if (array[3] < X && X < array[5])
            {
                C4();
                Thread.Sleep(1000);
                c4.BackColor = Color.Red;
                Thread.Sleep(1000);
                c4.Text = "";
                c4.BackColor = Color.Gray;
                Thread.Sleep(1000);
                MessageBox.Show("Không tìm thấy phần tử");
                return;
            }
            if (array[6] > X)
            {
                C6();
                Thread.Sleep(1000);
                c6.BackColor = Color.Red;
                c7.BackColor = Color.Red;
                Thread.Sleep(1000);
                c6.Text = "";
                c6.BackColor = Color.Gray;
                c7.BackColor = Color.Gray;
                Thread.Sleep(1000);
                MessageBox.Show("Không tìm thấy phần tử");
                return;
            }
            if (array[6] < X && X < array[8])
            {
                C7();
                Thread.Sleep(1000);
                c7.BackColor = Color.Red;
                Thread.Sleep(1000);
                c7.Text = "";
                c7.BackColor = Color.Gray;
                Thread.Sleep(1000);
                MessageBox.Show("Không tìm thấy phần tử");
                return;
            }
            if (array[9] > X)
            {
                C9();
                Thread.Sleep(1000);
                c9.BackColor = Color.Red;
                c10.BackColor = Color.Red;
                Thread.Sleep(1000);
                c9.Text = "";
                c9.BackColor = Color.Gray;
                c10.BackColor = Color.Gray;
                Thread.Sleep(1000);
                MessageBox.Show("Không tìm thấy phần tử");
                return;
            }
            if (array[9] < X )
            {
                C10();
                Thread.Sleep(1000);
                c10.BackColor = Color.Red;
                Thread.Sleep(1000);
                c10.Text = "";
                c10.BackColor = Color.Gray;
                Thread.Sleep(1000);
                MessageBox.Show("Không tìm thấy phần tử");
                return;
            }
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
            c10.Clear();

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
            c10.BackColor = Color.White;

            double[] array = new double[11];

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

            //phan tu 11
            if (a10.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập phần tử thứ 10 !!!");
                return;
            }
            else
            {
                double d10 = Convert.ToDouble(a10.Text);
                array[10] = d10;
            }

            if (x.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập phần tử muốn tìm !!!");
                return;
            }
            double X = Convert.ToDouble(x.Text);

            array = Sorting(array, 11);

            b0.Text = array[0].ToString();
            b1.Text = array[1].ToString();
            b2.Text = array[2].ToString();
            b3.Text = array[3].ToString();
            b4.Text = array[4].ToString();
            b5.Text = array[5].ToString();
            b6.Text = array[6].ToString();
            b7.Text = array[7].ToString();
            b8.Text = array[8].ToString();
            b9.Text = array[9].ToString();
            b10.Text = array[10].ToString();


            int find = BinarySearch(array, X, 0, 10);
            if (find == -1)
            {
                ThreadStart ts = new ThreadStart(() => CantFind(array, X));
                Thread thrd = new Thread(ts);
                thrd.Start();
                return;
            }
            if (find == 0)
            {
                ThreadStart ts = new ThreadStart(C0);
                Thread thrd = new Thread(ts);
                thrd.Start();
                return;
            }
            if (find == 1)
            {
                ThreadStart ts = new ThreadStart(C1);
                Thread thrd = new Thread(ts);
                thrd.Start();
                return;
            }
            if (find == 2)
            {
                ThreadStart ts = new ThreadStart(C2);
                Thread thrd = new Thread(ts);
                thrd.Start();
                return;
            }
            if (find == 3)
            {
                ThreadStart ts = new ThreadStart(C3);
                Thread thrd = new Thread(ts);
                thrd.Start();
                return;
            }
            if (find == 4)
            {
                ThreadStart ts = new ThreadStart(C4);
                Thread thrd = new Thread(ts);
                thrd.Start();
                return;
            }
            if (find == 5)
            {
                ThreadStart ts = new ThreadStart(C5);
                Thread thrd = new Thread(ts);
                thrd.Start();
                return;
            }
            if (find == 6)
            {
                ThreadStart ts = new ThreadStart(C6);
                Thread thrd = new Thread(ts);
                thrd.Start();
                return;
            }
            if (find == 7)
            {
                ThreadStart ts = new ThreadStart(C7);
                Thread thrd = new Thread(ts);
                thrd.Start();
                return;
            }
            if (find == 8)
            {
                ThreadStart ts = new ThreadStart(C8);
                Thread thrd = new Thread(ts);
                thrd.Start();
                return;
            }
            if (find == 9)
            {
                ThreadStart ts = new ThreadStart(C9);
                Thread thrd = new Thread(ts);
                thrd.Start();
                return;
            }
            if (find == 10)
            {
                ThreadStart ts = new ThreadStart(C10);
                Thread thrd = new Thread(ts);
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
            c10.Text = b10.Text = a10.Text = "";
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
            c10.BackColor = Color.White;

        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}

