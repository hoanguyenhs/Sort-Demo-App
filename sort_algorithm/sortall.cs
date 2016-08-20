using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace sort_algorithm
{
    public partial class sortall : Office2007Form
    {
        public sortall()
        {
            InitializeComponent();
        }

        private Random random = new Random();      
        private TextBoxX[] mang1 = new TextBoxX[20];
        private TextBoxX[] mang2 = new TextBoxX[20];
        private TextBoxX[] mang3 = new TextBoxX[20];
        private TextBoxX[] mang4 = new TextBoxX[20];
        private TextBoxX[] mang5 = new TextBoxX[20];
        private TextBoxX[] mang6 = new TextBoxX[20];
        private TextBoxX[] mang7 = new TextBoxX[20];
        private TextBoxX[] mang8 = new TextBoxX[20];
        private TextBoxX[] mang9 = new TextBoxX[20];
        private TextBoxX[] mang10 = new TextBoxX[20];
        private TextBoxX[] mang10b = new TextBoxX[20];
        private TextBoxX[] mang10c = new TextBoxX[20];

        #region CODE PHẦN DI CHUYỂN
        private void dichuyenlen(TextBoxX t1)
        {
            Point p1 = t1.Location;
            while (t1.Location.Y > p1.Y - 25)
            {
                Application.DoEvents();
                t1.Top -= 1;
            }
            t1.Refresh();
        }

        private void dichuyenxuong(TextBoxX t1)
        {
            Point p1 = t1.Location;
            while (t1.Location.Y < p1.Y + 25)
                t1.Top += 1;
            t1.Refresh();
        }

        private void dichuyenquatrai(Control t1)
        {
            Point p1 = t1.Location;
            while (t1.Location.X > p1.X - 25)
                t1.Left -= 1;
            t1.Refresh();
        }

        private void dichuyenquaphai(TextBoxX t1)
        {
            Point p1 = t1.Location;
            while (t1.Location.X < p1.X + 25)
                t1.Left += 1;
            t1.Refresh();
        }

        private void hoanvi_that(TextBoxX t1, TextBoxX t2)
        {
            Point p1 = t1.Location;
            Point p2 = t2.Location;
            while ((t1.Location.Y > p1.Y - 25) || (t2.Location.Y < p2.Y + 25))
            {
                Application.DoEvents();
                t1.Top -= 1;
                t2.Top += 1;
            }
            if (p1.X < p2.X)
            {
                while ((t1.Location.X < p2.X) || (t2.Location.X > p1.X))
                {
                    Application.DoEvents();
                    t1.Left += 1;
                    t2.Left -= 1;
                }
            }
            else if (p1.X > p2.X)
            {
                while ((t1.Location.X > p2.X) || (t2.Location.X < p1.X))
                {
                    Application.DoEvents();
                    t1.Left -= 1;
                    t2.Left += 1;
                }
            }
            while ((t1.Location.Y < p2.Y) || (t2.Location.Y > p1.Y))
            {
                Application.DoEvents();
                t1.Top += 1;
                t2.Top -= 1;
            }
            t1.Refresh();
            t2.Refresh();
        }

        private void saochep(TextBoxX dich, TextBoxX nguon)
        {
            Application.DoEvents();
            dich.Name = nguon.Name;
            dich.BackColor = nguon.BackColor;
            dich.Border.BorderBottom = nguon.Border.BorderBottom;
            dich.Border.BorderBottomWidth = nguon.Border.BorderBottomWidth;
            dich.Border.BorderColor = nguon.Border.BorderColor;
            dich.Border.BorderLeft = nguon.Border.BorderLeft;
            dich.Border.BorderLeftWidth = nguon.Border.BorderLeftWidth;
            dich.Border.BorderRight = nguon.Border.BorderRight;
            dich.Border.BorderRightWidth = nguon.Border.BorderRightWidth;
            dich.Border.BorderTop = nguon.Border.BorderTop;
            dich.Border.BorderTopWidth = nguon.Border.BorderTopWidth;
            dich.Border.Class = nguon.Border.Class;
            dich.Border.CornerType = nguon.Border.CornerType;
            dich.FocusHighlightEnabled = nguon.FocusHighlightEnabled;
            dich.Font = nguon.Font;
            dich.ForeColor = nguon.ForeColor;
            dich.Location = nguon.Location;
            dich.MaxLength = nguon.MaxLength;
            dich.Size = nguon.Size;
            dich.TextAlign = nguon.TextAlign;
            dich.Text = nguon.Text;
        }

        private void hoanvi_ao(TextBoxX t1, TextBoxX t2)
        {
            TextBoxX tam = new TextBoxX();
            saochep(tam, t1);
            saochep(t1, t2);
            saochep(t2, tam);
        }

        private void dichchuyen(TextBoxX t, int i)
        {
            Point p1 = t.Location;
            Point p2 = new Point(25 * (i + 1) + 625, 450);
            if (p1.X < p2.X)
                while (t.Location.X < p2.X)
                    dichuyenquaphai(t);
            else
                while (t.Location.X > p2.X)
                    dichuyenquatrai(t);
        }

        private void denvitri(TextBoxX t, int i)
        {
            Point p1 = t.Location;
            Point p2 = new Point(25 * (i + 1) + 625, 450);
            if (p1.Y < p2.Y)
                while (t.Location.Y < p2.Y - ((p2.Y - p1.Y) / 2))
                    dichuyenxuong(t);
            else
                while (t.Location.Y > p2.Y + ((p1.Y - p2.Y) / 2))
                    dichuyenlen(t);
            if (p1.X < p2.X)
                while (t.Location.X < p2.X)
                    dichuyenquaphai(t);
            else
                while (t.Location.X > p2.X)
                    dichuyenquatrai(t);
            if (p1.Y < p2.Y)
                while (t.Location.Y < p2.Y)
                    dichuyenxuong(t);
            else
                while (t.Location.Y > p2.Y)
                    dichuyenlen(t);
        }
        #endregion

        #region CÀI ĐẶT MÀU
        private void caidatmau(TextBoxX t, Color nen, Color vien)
        {
                t.BackColor = nen;
                t.Border.BorderColor = vien;
                t.Refresh();
        }
        #endregion

        #region CODE FORM LOAD
        private void veLabel1(TextBoxX[] l, int x, int y)
        {
            for (int i = 0; i < 20; i++)
            {
                l[i] = new TextBoxX();
                l[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                l[i].Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
                l[i].Border.BorderBottomWidth = 2;
                l[i].Border.BorderColor = Color.Red;
                l[i].Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
                l[i].Border.BorderLeftWidth = 2;
                l[i].Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
                l[i].Border.BorderRightWidth = 2;
                l[i].Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
                l[i].Border.BorderTopWidth = 2;
                l[i].Border.Class = "TextBoxBorder";
                l[i].Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
                l[i].Font = new System.Drawing.Font("Consolas", 8F);
                l[i].ForeColor = System.Drawing.Color.Black;
                l[i].Location = new System.Drawing.Point((25 * (i + 1)) + 25, y);
                l[i].Size = new System.Drawing.Size(20, 20);
                l[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                l[i].ReadOnly = true;
                this.Controls.Add(l[i]);
            }
        }

        private void veLabel2(TextBoxX[] l, int x, int y)
        {
            for (int i = 0; i < 20; i++)
            {
                l[i] = new TextBoxX();
                l[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                l[i].Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
                l[i].Border.BorderBottomWidth = 2;
                l[i].Border.BorderColor = Color.Red;
                l[i].Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
                l[i].Border.BorderLeftWidth = 2;
                l[i].Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
                l[i].Border.BorderRightWidth = 2;
                l[i].Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
                l[i].Border.BorderTopWidth = 2;
                l[i].Border.Class = "TextBoxBorder";
                l[i].Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
                l[i].Font = new System.Drawing.Font("Consolas", 8F);
                l[i].ForeColor = System.Drawing.Color.Black;
                l[i].Location = new System.Drawing.Point((25 * (i + 1)) + 625, y);
                l[i].Size = new System.Drawing.Size(20, 20);
                l[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                l[i].ReadOnly = true;
                this.Controls.Add(l[i]);
            }
        }

        private void sortall_Load(object sender, EventArgs e)
        {
            veLabel1(mang1, 50, 100);
            veLabel1(mang2, 50, 200);
            veLabel1(mang3, 50, 300);
            veLabel1(mang4, 50, 400);
            veLabel1(mang5, 50, 500);
            veLabel1(mang6, 50, 600);
            veLabel2(mang7, 650, 100);
            veLabel2(mang8, 650, 200);
            veLabel2(mang9, 650, 300);
            veLabel2(mang10, 650, 450);
            for (int i = 0; i < 20; i++)
            {
                int r = random.Next(0, 99);
                mang1[i].Text = r.ToString();
                mang2[i].Text = r.ToString();
                mang3[i].Text = r.ToString();
                mang4[i].Text = r.ToString();
                mang5[i].Text = r.ToString();
                mang6[i].Text = r.ToString();
                mang7[i].Text = r.ToString();
                mang8[i].Text = r.ToString();
                mang9[i].Text = r.ToString();
                mang10[i].Text = r.ToString();
            }
            bt_thoat.Enabled = false;
        }

        #endregion

        #region INTERCHANGE SORT
        private void interchage_sort()
        {
            this.Invoke((MethodInvoker)delegate
            {
                int i, j;
                for (i = 0; i < 20 - 1; i++)
                {
                    caidatmau(mang1[i], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red);
                    for (j = i + 1; j < 20; j++)
                    {
                        caidatmau(mang1[j], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red);
                        if (int.Parse(mang1[j].Text) < int.Parse(mang1[i].Text))
                        {
                            hoanvi_that(mang1[j], mang1[i]);
                            hoanvi_ao(mang1[j], mang1[i]);
                            caidatmau(mang1[j], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                        }
                        else
                            caidatmau(mang1[j], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                    }
                    caidatmau(mang1[i], Color.LawnGreen, Color.White);
                }
                for (i = 0; i < 20; i++)
                    caidatmau(mang1[i], Color.LawnGreen, Color.White);
            });
        }
        #endregion
        #region SELECTION SORT
        private void selection_sort()
        {
            this.Invoke((MethodInvoker)delegate
            {
                int i, j, min;
                for (i = 0; i < 20 - 1; i++)
                {
                    min = i;
                    caidatmau(mang2[min], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red);
                    for (j = i + 1; j < 20; j++)
                    {
                        caidatmau(mang2[j], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red);
                        if (int.Parse(mang2[j].Text) < int.Parse(mang2[min].Text))
                            min = j;
                        caidatmau(mang2[j], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                        caidatmau(mang2[min], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                    }
                    if (min != i)
                    {
                        caidatmau(mang2[min], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red);
                        caidatmau(mang2[i], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red);
                        hoanvi_that(mang2[min], mang2[i]);
                        hoanvi_ao(mang2[min], mang2[i]);
                        caidatmau(mang2[min], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                        caidatmau(mang2[i], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);

                    }
                    else
                    {
                        caidatmau(mang2[min], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                        caidatmau(mang2[i], Color.LawnGreen, Color.White);
                        continue;
                    }
                    caidatmau(mang2[min], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                    caidatmau(mang2[i], Color.LawnGreen, Color.White);
                }
                for (i = 0; i < 20; i++)
                    caidatmau(mang2[i], Color.LawnGreen, Color.White);
            });
        }
        #endregion
        #region BUBBLE SORT
        private void bubble_sort()
        {
            this.Invoke((MethodInvoker)delegate
            {
                int i, j;
                for (i = 0; i < 20 - 1; i++)
                {
                    for (j = 20 - 1; j > i; j--)
                    {
                        if (int.Parse(mang3[j].Text) < int.Parse(mang3[j - 1].Text))
                        {
                            caidatmau(mang3[j], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red);
                            caidatmau(mang3[j - 1], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red);
                            hoanvi_that(mang3[j], mang3[j - 1]);
                            hoanvi_ao(mang3[j], mang3[j - 1]);
                            caidatmau(mang3[j], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                            caidatmau(mang3[j - 1], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                        }
                    }
                    caidatmau(mang3[i], Color.LawnGreen, Color.White);
                }
                for (i = 0; i < 20; i++)
                    caidatmau(mang3[i], Color.LawnGreen, Color.White);
            });
        }
        #endregion
        #region SHAKE SORT
        private void shake_sort()
        {
            this.Invoke((MethodInvoker)delegate
            {
                int j;
                int left, right, k;
                left = 0;
                right = 20 - 1;
                k = 0;
                while (left < right)
                {
                    for (j = right; j > left; j--)
                    {
                        if (int.Parse(mang4[j].Text) <= int.Parse(mang4[j - 1].Text))
                        {
                            caidatmau(mang4[j], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red);
                            caidatmau(mang4[j - 1], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red);
                            hoanvi_that(mang4[j], mang4[j - 1]);
                            hoanvi_ao(mang4[j], mang4[j - 1]);
                            caidatmau(mang4[j], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                            caidatmau(mang4[j - 1], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                            k = j;
                        }
                    }
                    left = k;
                    caidatmau(mang4[j], Color.LawnGreen, Color.White);
                    for (j = left; j < right; j++)
                    {
                        if (int.Parse(mang4[j + 1].Text) <= int.Parse(mang4[j].Text))
                        {
                            caidatmau(mang4[j + 1], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red);
                            caidatmau(mang4[j], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red);
                            hoanvi_that(mang4[j], mang4[j + 1]);
                            hoanvi_ao(mang4[j], mang4[j + 1]);
                            caidatmau(mang4[j + 1], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                            caidatmau(mang4[j], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                            k = j;
                        }
                    }
                    right = k;
                    caidatmau(mang4[j], Color.LawnGreen, Color.White);
                }
                for (int i = 0; i < 20; i++)
                    caidatmau(mang4[i], Color.LawnGreen, Color.White);
            });
        }
        #endregion
        #region INSERTION SORT
        private void insertion_sort()
        {
            this.Invoke((MethodInvoker)delegate
            {
                int i, j, vitri, dem1 = 0, dem2 = 0;
                for (i = 1; i < 20; i++)
                {
                    caidatmau(mang5[i], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red);
                    dichuyenlen(mang5[i]);
                    vitri = i - 1;
                    caidatmau(mang5[0], Color.LawnGreen, Color.White);
                    while (vitri >= 0 && int.Parse(mang5[vitri].Text) > int.Parse(mang5[i].Text))
                    {
                        dichuyenquaphai(mang5[vitri]);
                        dem1++;
                        dem2++;
                        vitri--;
                    }
                    while (dem1 > 0)
                    {
                        dichuyenquatrai(mang5[i]);
                        dem1--;
                    }
                    dichuyenxuong(mang5[i]);
                    caidatmau(mang5[i], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                    if (dem2 > 0)
                    {
                        for (j = i - dem2; j < i; j++)
                            hoanvi_ao(mang5[j], mang5[i]);
                    }
                    dem2 = 0;
                    caidatmau(mang5[vitri + 1], Color.LawnGreen, Color.White);
                }
                for (i = 0; i < 20; i++)
                    caidatmau(mang5[i], Color.LawnGreen, Color.White);
            });
        }
        #endregion
        #region INSERTION BINARY SORT
        private void binary_sort()
        {
            this.Invoke((MethodInvoker)delegate
            {
                int i, j, t, l, r, m, dem1 = 0, dem2 = 0;
                caidatmau(mang6[0], Color.LawnGreen, Color.White);
                for (i = 1; i < 20; i++)
                {
                    caidatmau(mang6[i], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red);
                    dichuyenlen(mang6[i]);
                    l = 0;
                    r = i;
                    while (l < r)
                    {
                        m = (l + r) / 2;
                        if (int.Parse(mang6[i].Text) >= int.Parse(mang6[m].Text))
                            l = m + 1;
                        else
                            r = m;
                    }
                    j = i - 1;
                    while (j >= l)
                    {
                        dichuyenquaphai(mang6[j]);
                        dem1++;
                        dem2++;
                        caidatmau(mang6[j], Color.LawnGreen, Color.White);
                        j--;
                    }
                    while (dem1 > 0)
                    {

                        dichuyenquatrai(mang6[i]);
                        dem1--;
                    }
                    dichuyenxuong(mang6[i]);
                    caidatmau(mang6[i], Color.LawnGreen, Color.White);
                    if (dem2 > 0)
                    {
                        for (t = i - dem2; t < i; t++)
                            hoanvi_ao(mang6[t], mang6[i]);
                    }
                    dem2 = 0;
                    caidatmau(mang6[j + 1], Color.LawnGreen, Color.White);
                }
                for (i = 0; i < 20; i++)
                    caidatmau(mang6[i], Color.LawnGreen, Color.White);
            });
        }
        #endregion
        #region SHELL SORT
        private void shell_sort()
        {
            this.Invoke((MethodInvoker)delegate
            {
                int[] h;
                int i, j, t, k, dodai, buocnhay, dem1 = 0, dem2 = 0;
                k = Convert.ToInt32(Math.Log10(20) / Math.Log10(2));
                h = new int[k];
                h[k - 1] = 1;
                for (i = k - 2; i >= 0; i--)
                    h[i] = (2 * h[i + 1] + 1);
                for (buocnhay = 0; buocnhay < k; buocnhay++)
                {
                    dodai = h[buocnhay];
                    for (i = dodai; i < 20; i++)
                    {
                        caidatmau(mang7[i], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red);
                        dichuyenlen(mang7[i]);
                        j = i - dodai;
                        for (t = j; t >= 0; t = t - dodai)
                        {
                            caidatmau(mang7[t], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red);
                            dichuyenxuong(mang7[t]);
                        }
                        if ((int.Parse(mang7[i].Text) < int.Parse(mang7[j].Text)))
                        {
                            while ((j >= 0) && (int.Parse(mang7[i].Text) < int.Parse(mang7[j].Text)))
                            {
                                for (t = 0; t < dodai; t++)
                                    dichuyenquaphai(mang7[j]);
                                dem1++;
                                dem2++;
                                j = j - dodai;
                            }
                            for (t = i - dodai; t >= 0; t = t - dodai)
                            {
                                dichuyenlen(mang7[t]);
                                caidatmau(mang7[t], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                            }
                        }
                        else
                        {
                            for (t = j; t >= 0; t = t - dodai)
                            {
                                dichuyenlen(mang7[t]);
                                caidatmau(mang7[t], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                            }
                        }
                        while (dem1 > 0)
                        {
                            for (t = 0; t < dodai; t++)
                                dichuyenquatrai(mang7[i]);
                            dem1--;
                        }
                        dichuyenxuong(mang7[i]);
                        caidatmau(mang7[i], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                        if (dem2 > 0)
                        {
                            for (t = i - (dem2 * dodai); t < i; t = t + dodai)
                                hoanvi_ao(mang7[t], mang7[i]);
                        }
                        dem2 = 0;
                    }
                }
                for (i = 0; i < 20; i++)
                    caidatmau(mang7[i], Color.LawnGreen, Color.White);
            });
        }
        #endregion
        #region MERGE SORT
        private int min(int a, int b)
        {
            if (a > b)
                return b;
            else
                return a;
        }
        private void distribute(ref int nb, ref int nc, int k)
        {
            int i, pa, pb, pc;
            pa = pb = pc = 0;
            while (pa < 20)
            {
                for (i = 0; (pa < 20) && (i < k); i++, pa++, pb++)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        mang10b[pb] = mang10[pa];
                        mang10b[pb].Text = mang10[pa].Text;
                        caidatmau(mang10b[pb], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Blue);
                        dichuyenlen(mang10b[pb]);
                        dichuyenlen(mang10b[pb]);
                        dichchuyen(mang10b[pb], pb);
                    });
                }
                for (i = 0; (pa < 20) && (i < k); i++, pa++, pc++)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        mang10c[pc] = mang10[pa];
                        mang10c[pc].Text = mang10[pa].Text;
                        caidatmau(mang10c[pc], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Green);
                        dichuyenxuong(mang10c[pc]);
                        dichuyenxuong(mang10c[pc]);
                        dichchuyen(mang10c[pc], pc);
                    });
                }
                nb = pb;
                nc = pc;
            }
        }
        private void merge(int nb, int nc, int k)
        {
            this.Invoke((MethodInvoker)delegate
            {
                int pa, pb, pc, ib, ic, cdaib, cdaic, kb, kc;
                cdaib = nb;
                cdaic = nc;
                pa = pb = pc = 0; ib = ic = 0;
                while ((nb > 0) && (nc > 0))
                {
                    kb = min(k, nb);
                    kc = min(k, nc);
                    if (int.Parse(mang10b[(pb + ib)].Text) <= int.Parse(mang10c[(pc + ic)].Text))
                    {
                        mang10[pa] = mang10b[pb + ib];
                        denvitri(mang10b[pb + ib], pa);
                        caidatmau(mang10b[pb + ib], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                        pa++;
                        ib++;
                        if (ib == kb)
                        {
                            for (; ic < kc; ic++)
                            {
                                mang10[pa] = mang10c[pc + ic];
                                denvitri(mang10c[pc + ic], pa);
                                caidatmau(mang10c[pc + ic], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                                pa++;
                            }
                            pb += kb;
                            pc += kc;
                            ib = ic = 0;
                            nb -= kb;
                            nc -= kc;
                        }
                    }
                    else
                    {
                        mang10[pa] = mang10c[pc + ic];
                        denvitri(mang10c[pc + ic], pa);
                        caidatmau(mang10c[pc + ic], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                        pa++;
                        ic++;
                        if (ic == kc)
                        {
                            for (; ib < kb; ib++)
                            {
                                mang10[pa] = mang10b[pb + ib];
                                denvitri(mang10b[pb + ib], pa);
                                caidatmau(mang10b[pb + ib], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                                pa++;
                            };
                            pb += kb;
                            pc += kc;
                            ib = ic = 0;
                            nb -= kb;
                            nc -= kc;
                        }
                    }
                }
                for (; nb > 0; nb--)
                {
                    Application.DoEvents();
                    denvitri(mang10b[cdaib - nb], pa);
                    pa++;
                    caidatmau(mang10b[cdaib - nb], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                }
                for (; nc > 0; nc--)
                {
                    Application.DoEvents();
                    denvitri(mang10c[cdaic - nc], pa);
                    pa++;
                    caidatmau(mang10c[cdaic - nc], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                }
            });
        }
        private void meger_sort(int n)
        {
            this.Invoke((MethodInvoker)delegate
            {
                int k, nc = 0, nb = 0;
                for (k = 1; k < n; k *= 2)
                {
                    distribute(ref nb, ref nc, k);
                    merge(nb, nc, k);
                }
                for (int i = 0; i < 20; i++)
                    caidatmau(mang10[i], Color.LawnGreen, Color.White);
            });
        }
        #endregion
        #region HEAP SORT
        private void hoanviint(int t1, int t2)
        {
            int tam;
            tam = t1;
            t1 = t2;
            t2 = tam;
        }
        private void shift(int left, int right)
        {
            this.Invoke((MethodInvoker)delegate
            {
                int i, j, x, tam;
                TextBoxX temp;
                i = left;
                j = 2 * i + 1;
                x = int.Parse(mang9[i].Text);
                temp = mang9[i];
                tam = i;
                while (j <= right)
                {
                    if (j < right)
                        if (int.Parse(mang9[j].Text) < int.Parse(mang9[j + 1].Text))
                            j++;
                    if (int.Parse(mang9[j].Text) <= x)

                        return;
                    else
                    {
                        int t = int.Parse(mang9[i].Text);
                        t = int.Parse(mang9[j].Text);
                        x = int.Parse(mang9[j].Text);
                        hoanvi_that(mang9[j], temp);
                        hoanvi_ao(mang9[j], mang9[tam]);
                        i = j;
                        j = 2 * i + 1;
                        x = int.Parse(mang9[i].Text);
                        temp = mang9[i];
                        tam = i;
                    }
                }
            });
        }
        private void CreateHeap(int n)
        {
            this.Invoke((MethodInvoker)delegate
            {
                int left = n / 2 - 1;
                while (left >= 0)
                {
                    shift(left, n - 1);
                    left--;
                }
            });
        }
        private void heap_sort(int n)
        {
            this.Invoke((MethodInvoker)delegate
            {
                int right;
                CreateHeap(n);
                right = n - 1;
                while (right > 0)
                {

                    Application.DoEvents();
                    hoanviint(int.Parse(mang9[0].Text), int.Parse(mang9[right].Text));
                    hoanvi_that(mang9[0], mang9[right]);
                    hoanvi_ao(mang9[0], mang9[right]);
                    caidatmau(mang9[right], Color.LawnGreen, Color.White);
                    right--;
                    if (right > 0)
                        shift(0, right);
                }
                caidatmau(mang9[0], Color.LawnGreen, Color.White);
                for (int i = 0; i < 20; i++)
                    caidatmau(mang9[i], Color.LawnGreen, Color.White);
            });
        }
        # endregion
        #region QUICK SORT
        private void quick_sort(int left, int right)
        {
            this.Invoke((MethodInvoker)delegate
            {
                int m, l, r;
                l = left;
                r = right;
                m = int.Parse(mang8[left].Text);

                while (left < right)
                {
                    while ((int.Parse(mang8[right].Text) >= m) && (left < right))
                    {
                        right--;
                    }
                    if (left != right)
                    {
                        caidatmau(mang8[left], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red);
                        caidatmau(mang8[right], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red);
                        hoanviint(left, right);
                        hoanvi_that(mang8[left], mang8[right]);
                        hoanvi_ao(mang8[left], mang8[right]);
                        caidatmau(mang8[left], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                        caidatmau(mang8[right], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                        left++;
                    }

                    while ((int.Parse(mang8[left].Text) <= m) && (left < right))
                    {
                        left++;
                    }
                    if (left != right)
                    {
                        caidatmau(mang8[left], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red);
                        caidatmau(mang8[right], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red);
                        hoanviint(right, left);
                        hoanvi_that(mang8[right], mang8[left]);
                        hoanvi_ao(mang8[right], mang8[left]);
                        caidatmau(mang8[left], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                        caidatmau(mang8[right], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red);
                        right--;
                    }
                }
                caidatmau(mang8[left], Color.LawnGreen, Color.White);

                int t = int.Parse(mang8[left].Text);
                t = m;
                m = left;
                left = l;
                right = r;

                if (left < m)
                {
                    quick_sort(left, m - 1);
                    caidatmau(mang8[m - 1], Color.LawnGreen, Color.White);
                }
                if (right > m)
                {
                    quick_sort(m + 1, right);
                    caidatmau(mang8[m + 1], Color.LawnGreen, Color.White);
                }
            });
        }
        #endregion

        private void thuchien(object o)
        {
            int i = int.Parse(o.ToString());
            if (i == 1)
                interchage_sort();
            else if (i == 2)
                selection_sort();
            else if (i == 3)
                bubble_sort();
            else if (i == 4)
                shake_sort();
            else if (i == 5)
                insertion_sort();
            else if (i == 6)
                binary_sort();
            else if (i == 7)
                shell_sort();
            else if (i == 8)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    quick_sort(0, 20 - 1);
                    for (int j = 0; j < 20; j++)
                        caidatmau(mang8[j], Color.LawnGreen, Color.White);
                });
            }
            else if (i == 9)
                heap_sort(20);
            else if (i == 10)
                meger_sort(20);
        }

        private Thread qly_thread;

        private void lam_threadpool()
        {
            WaitCallback workMethod = new WaitCallback(thuchien);
            ThreadPool.QueueUserWorkItem(workMethod, 1);
            ThreadPool.QueueUserWorkItem(workMethod, 2);
            ThreadPool.QueueUserWorkItem(workMethod, 3);
            ThreadPool.QueueUserWorkItem(workMethod, 4);
            ThreadPool.QueueUserWorkItem(workMethod, 5);
            ThreadPool.QueueUserWorkItem(workMethod, 6);
            ThreadPool.QueueUserWorkItem(workMethod, 7);
            ThreadPool.QueueUserWorkItem(workMethod, 8);
            ThreadPool.QueueUserWorkItem(workMethod, 9);
            ThreadPool.QueueUserWorkItem(workMethod, 10);
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            bt_start.Enabled = false;
            qly_thread = new Thread(lam_threadpool);
            qly_thread.Start();
            bt_thoat.Enabled = true;
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}