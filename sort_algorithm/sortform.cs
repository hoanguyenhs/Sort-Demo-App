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
    public partial class sortform : Office2007RibbonForm
    {
        public sortform()
        {
            InitializeComponent();
        }

        #region CODE KHAI BÁO BIẾN TOÀN CỤC VÀ CÁC HÀM HỖ TRỢ
        private int spt;
        private int tocdo;
        private sortall sa = new sortall();
        private thongtin tt = new thongtin();
        private Random random = new Random();
        private int[] giatribandau = new int[30];
        private int[] giatri = new int[31];
        private int[] giatrib = new int[31];
        private LabelX[] chiso = new LabelX[30];
        private TextBoxX[] mang = new TextBoxX[30];
        private TextBoxX[] mangb = new TextBoxX[15];
        private TextBoxX[] mangc = new TextBoxX[15];

        private void ngu(int milisecond)
        {
            if (sd_tocdo.Value == 10)
            {
                Application.DoEvents();
                return;
            }
            if (sd_tocdo.Value == 0)
            {
                while (sd_tocdo.Value == 0)
                {
                    Application.DoEvents();
                }
            }
            for (int i = 0; i < milisecond; i++)
            {
                Application.DoEvents();
                Thread.Sleep(10);
            }
        }

        private void caidatmau(TextBoxX t, Color nen, Color vien, Color chu)
        {
            t.BackColor = nen;
            t.Border.BorderColor = vien;
            t.ForeColor = chu;
            t.Refresh();
        }

        private void sapxepxong()
        {
            for (int i = 0; i < spt; i++)
                caidatmau(mang[i], Color.LawnGreen, Color.White, Color.Black);
            lb_down.Visible = false;
            lb_up.Visible = false;
            lb_pointer.Visible = false;
            lb_chuthich.Text = "Đã sắp xếp xong!";
            bt_xoa.Enabled = true;
            bt_lamhet.Enabled = false;
            bt_lamlai.Enabled = true;
            gp_thuattoan.Enabled = true;
            lbl_a.Visible = false;
            lbl_b.Visible = false;
            lbl_c.Visible = false;
            gp_timkiem.Enabled = true;
            bt_tamdung.Enabled = false;
        }
        #endregion

        #region CODE PHẦN DI CHUYỂN
        private void dichuyenlen(TextBoxX t1)
        {
            Point p1 = t1.Location;
            while (t1.Location.Y > p1.Y - 40)
            {
                Application.DoEvents();
                t1.Top -= 2;
                ngu(tocdo);
            }
            t1.Refresh();
        }

        private void dichuyenxuong(TextBoxX t1)
        {
            Point p1 = t1.Location;
            while (t1.Location.Y < p1.Y + 40)
            {
                Application.DoEvents();
                t1.Top += 2;
                ngu(tocdo);
            }
            t1.Refresh();
        }

        private void dichuyenquatrai(Control t1)
        {
            Point p1 = t1.Location;
            while (t1.Location.X > p1.X - 40)
            {
                Application.DoEvents();
                t1.Left -= 2;
                ngu(tocdo);
            }
            t1.Refresh();
        }

        private void dichuyenquaphai(TextBoxX t1)
        {
            Point p1 = t1.Location;
            while (t1.Location.X < p1.X + 40)
            {
                Application.DoEvents();
                t1.Left += 2;
                ngu(tocdo);
            }
            t1.Refresh();
        }

        private void hoanvi_that(TextBoxX t1, TextBoxX t2)
        {
            Point p1 = t1.Location;
            Point p2 = t2.Location;
            while ((t1.Location.Y > p1.Y - 40) || (t2.Location.Y < p2.Y + 40))
            {
                Application.DoEvents();
                t1.Top -= 2;
                t2.Top += 2;
                ngu(tocdo);
            }
            if (p1.X < p2.X)
            {
                while ((t1.Location.X < p2.X) || (t2.Location.X > p1.X))
                {
                    Application.DoEvents();
                    t1.Left += 2;
                    t2.Left -= 2;
                    ngu(tocdo);
                }
            }
            else if (p1.X > p2.X)
            {
                while ((t1.Location.X > p2.X) || (t2.Location.X < p1.X))
                {
                    Application.DoEvents();
                    t1.Left -= 2;
                    t2.Left += 2;
                    ngu(tocdo);
                }
            }
            while ((t1.Location.Y < p2.Y) || (t2.Location.Y > p1.Y))
            {
                Application.DoEvents();
                t1.Top += 2;
                t2.Top -= 2;
                ngu(tocdo);
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
            Point p2 = new Point(40 * (i + 1), 160);
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
            Point p2 = new Point(40 * (i + 1), 160);
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

        #region CODE MENU + FORMLOAD + TIMERTICK
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        private void btn_thongtin_Click(object sender, EventArgs e)
        {
            tt.Show();
        }
        private void btn_form3_Click(object sender, EventArgs e)
        {
            sa.Show();
            Hide();
        }

        private void time_tocdo_Tick(object sender, EventArgs e)
        {
            tocdo = sd_tocdo.Maximum - sd_tocdo.Value;
            spt = sd_spt.Value;
        }

        private void sortform_Load(object sender, EventArgs e)
        {
            code.Items.Add("void InterchangeSort(int a[], int n)");
            code.Items.Add("{");
            code.Items.Add("   int i,j;\n");
            code.Items.Add("   for (i = 0; i < n - 1; i++)");
            code.Items.Add("       for (j = i + 1; j < n; j++)");
            code.Items.Add("           if(a[i]>a[j])");
            code.Items.Add("               doicho(a[i], a[j]);");
            code.Items.Add("}");
            lb_up.Visible = false;
            lb_down.Visible = false;
            lb_pointer.Visible = false;
            bt_xoa.Enabled = false;
            gp_tuychon.Enabled = false;
            gp_timkiem.Enabled = false;
        }
        #endregion

        #region CODE PHẦN KHỞI TẠO MẢNG
        private void sd_spt_ValueChanged(object sender, EventArgs e)
        {
            sd_spt.Text = "   " + sd_spt.Value.ToString();
        }

        private void mang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void vecactextbox()
        {
            for (int i = 0; i < spt; i++)
            {
                mang[i] = new TextBoxX();
                mang[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                mang[i].Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
                mang[i].Border.BorderBottomWidth = 2;
                mang[i].Border.BorderColor = Color.Red;
                mang[i].Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
                mang[i].Border.BorderLeftWidth = 2;
                mang[i].Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
                mang[i].Border.BorderRightWidth = 2;
                mang[i].Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
                mang[i].Border.BorderTopWidth = 2;
                mang[i].Border.Class = "TextBoxBorder";
                mang[i].Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
                mang[i].FocusHighlightEnabled = true;
                mang[i].Font = new System.Drawing.Font("Consolas", 13F);
                mang[i].ForeColor = System.Drawing.Color.Black;
                mang[i].Location = new System.Drawing.Point(40 * (i + 1), 160);
                mang[i].MaxLength = 2;
                mang[i].Size = new System.Drawing.Size(30, 30);
                mang[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                mang[i].KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mang_KeyPress);
                chiso[i] = new LabelX();
                chiso[i].BackgroundStyle.Class = "";
                chiso[i].BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
                chiso[i].Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                chiso[i].ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
                chiso[i].Location = new System.Drawing.Point((40 * (i + 1)) + 5, 280);
                chiso[i].Size = new System.Drawing.Size(30, 30);
                chiso[i].TabIndex = 2;
                chiso[i].Text = i.ToString();
                p_main.Controls.Add(mang[i]);
                p_main.Controls.Add(chiso[i]);
            }
        }

        private void bt_taongaunhien_Click(object sender, EventArgs e)
        {
            vecactextbox();
            for (int i = 0; i < spt; i++)
            {
                mang[i].Text = random.Next(0, 99).ToString();
                mang[i].ReadOnly = true;
                mang[i].FocusHighlightEnabled = false;
            }
            bt_timkiem.Enabled = true;
            bt_ok.Enabled = true;
            bt_taongaunhien.Enabled = false;
            bt_nhap.Enabled = false;
            bt_xoa.Enabled = true;
            gp_thuattoan.Enabled = true;
            gp_tuychon.Enabled = true;
            bt_lamhet.Enabled = true;
            bt_lamlai.Enabled = false;
            bt_batdau.Enabled = true;
            gp_timkiem.Enabled = true;
            lb_chuthich.Text = "Lựa chọn thuật toán";
            for (int i = 0; i < spt; i++)
            {
                giatribandau[i] = int.Parse(mang[i].Text);
                giatri[i] = int.Parse(mang[i].Text);
            }
            for (int i = 0; i < spt; i++)
                for (int j = spt - 1; j > i; j--)
                    if (giatri[j] < giatri[j - 1])
                    {
                        giatri[30] = giatri[j];
                        giatri[j] = giatri[j - 1];
                        giatri[j - 1] = giatri[30];
                    }
        }

        private void bt_nhap_Click(object sender, EventArgs e)
        {
            if (bt_nhap.Text.Equals("Nhập từ bàn phím"))
            {
                vecactextbox();
                bt_nhap.Text = "Hoàn tất";
                lb_chuthich.Text = "Nhập các giá trị từ bàn phím";
                bt_taongaunhien.Enabled = false;
            }
            else if (bt_nhap.Text.Equals("Hoàn tất"))
            {
                for (int i = 0; i < spt; i++)
                {
                    if (mang[i].Text.Length == 0)
                        mang[i].Text = random.Next(0, 99).ToString();
                    mang[i].ReadOnly = true;
                    mang[i].FocusHighlightEnabled = false;
                }
                bt_nhap.Text = "Nhập từ bàn phím";
                lb_chuthich.Text = "Lựa chọn thuật toán";
                bt_nhap.Enabled = false;
                bt_xoa.Enabled = true;
                gp_thuattoan.Enabled = true;
                gp_tuychon.Enabled = true;
                bt_lamhet.Enabled = true;
                bt_lamlai.Enabled = false;
                bt_batdau.Enabled = true;
                bt_ok.Enabled = true;
                bt_timkiem.Enabled = true;
                gp_timkiem.Enabled = true;
                for (int i = 0; i < spt; i++)
                {
                    giatribandau[i] = int.Parse(mang[i].Text);
                    giatri[i] = int.Parse(mang[i].Text);
                }
                for (int i = 0; i < spt; i++)
                    for (int j = spt - 1; j > i; j--)
                        if (giatri[j] < giatri[j - 1])
                        {
                            giatri[30] = giatri[j];
                            giatri[j] = giatri[j - 1];
                            giatri[j - 1] = giatri[30];
                        }
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                p_main.Controls.Remove(mang[i]);
                p_main.Controls.Remove(chiso[i]);
            }
            lb_chuthich.Text = "Tạo mảng để sắp xếp";
            bt_taongaunhien.Enabled = true;
            bt_nhap.Enabled = true;
            bt_xoa.Enabled = false;
            gp_tuychon.Enabled = false;
            lbl_a.Visible = false;
            gp_timkiem.Enabled = false;
        }
        #endregion

        #region CODE TRÌNH BÀY THUẬT TOÁN
        private void sd_kickthuoc_ValueChanged(object sender, EventArgs e)
        {
            code.Font = new Font("Microsoft Sans Serif", sd_kickthuoc.Value);
        }

        private void rdo_interchange_CheckedChanged(object sender, EventArgs e)
        {
            code.Items.Clear();
            code.Items.Add("void InterchangeSort(int a[], int n)");
            code.Items.Add("{");
            code.Items.Add("   int i,j;");
            code.Items.Add("   for (i = 0; i < n - 1; i++)");
            code.Items.Add("       for (j = i + 1; j < n; j++)");
            code.Items.Add("           if(a[i]>a[j])");
            code.Items.Add("               doicho(a[i], a[j]);");
            code.Items.Add("}");
        }

        private void rdo_selection_CheckedChanged(object sender, EventArgs e)
        {
            code.Items.Clear();
            code.Items.Add("void SelectionSort(int a[], int n)");
            code.Items.Add("{");
            code.Items.Add("   int min,i,j;");
            code.Items.Add("   for (i = 0; i < n - 1; i++)");
            code.Items.Add("   {");
            code.Items.Add("       min = i;");
            code.Items.Add("       for (j = i + 1; j < n; i++)");
            code.Items.Add("           if (a[j] < a[min])");
            code.Items.Add("               min = j;");
            code.Items.Add("        doicho(a[min], a[i]);");
            code.Items.Add("   }");
            code.Items.Add("}");
        }

        private void rdo_bubble_CheckedChanged(object sender, EventArgs e)
        {
            code.Items.Clear();
            code.Items.Add("void BubbleSort(int a[], int n)");
            code.Items.Add("{");
            code.Items.Add("   int i, j;");
            code.Items.Add("   for (i = 0; i < n - 1; i++)");
            code.Items.Add("       for (j = n - 1; j > i; j--)");
            code.Items.Add("           if (a[j] < a[j - 1])");
            code.Items.Add("               doicho(a[j], a[j - 1]);");
            code.Items.Add("}");
        }

        private void rdo_shake_CheckedChanged(object sender, EventArgs e)
        {
            code.Items.Clear();
            code.Items.Add("void ShackerSort(int a[], int n)");
            code.Items.Add("{");
            code.Items.Add("   int i, j;");
            code.Items.Add("   int left, right, k;");
            code.Items.Add("   left = 0; right = n - 1; k = n -1;");
            code.Items.Add("   while (left < right)");
            code.Items.Add("   {");
            code.Items.Add("       for (j = right; j > left; j--)");
            code.Items.Add("           if (a[j] < a[j - 1])");
            code.Items.Add("           {");
            code.Items.Add("               doicho(a[j], a[j - 1]);");
            code.Items.Add("               k = j;");
            code.Items.Add("           }");
            code.Items.Add("       left = k;");
            code.Items.Add("       for (j = left; j < right; j++)");
            code.Items.Add("           if (a[j] > a[j + 1])");
            code.Items.Add("           {");
            code.Items.Add("               doicho(a[j], a[j + 1]);");
            code.Items.Add("               k = j;");
            code.Items.Add("           }");
            code.Items.Add("       right = k;");
            code.Items.Add("   }");
            code.Items.Add("}");
        }

        private void rdo_insertion_CheckedChanged(object sender, EventArgs e)
        {
            code.Items.Clear();
            code.Items.Add("void InsertionSort(int a[], int n)");
            code.Items.Add("{");
            code.Items.Add("   int i, j, x;");
            code.Items.Add("   for (i = 1; i < n; i++)");
            code.Items.Add("   {");
            code.Items.Add("       x = a[i];");
            code.Items.Add("       j = i - 1;");
            code.Items.Add("       while ((pos >= 0) && (a[pos] > x))");
            code.Items.Add("       {");
            code.Items.Add("           a[pos + 1] = a[pos];");
            code.Items.Add("           pos--;");
            code.Items.Add("       }");
            code.Items.Add("       a[pos + 1] = x;");
            code.Items.Add("   }");
            code.Items.Add("}");
        }

        private void rdo_shell_CheckedChanged(object sender, EventArgs e)
        {
            code.Items.Clear();
            code.Items.Add("void ShellSort(int a[], int n, int h[], int k)");
            code.Items.Add("{");
            code.Items.Add("   int step, i, j, x, len;");
            code.Items.Add("   for (step = 0; step < k; step++)");
            code.Items.Add("   {");
            code.Items.Add("       len = h[step];");
            code.Items.Add("       for (i = len; i < n; i++)");
            code.Items.Add("       {");
            code.Items.Add("           x = a[i];");
            code.Items.Add("           j = i - len;");
            code.Items.Add("           while (x < a[j] && j >= 0)");
            code.Items.Add("           {");
            code.Items.Add("	            a[j + len]  = a[j];");
            code.Items.Add("	            j = j - len;");
            code.Items.Add("           }");
            code.Items.Add("           a[j + len] = x;");
            code.Items.Add("       }");
            code.Items.Add("   }");
            code.Items.Add("}");
        }

        private void rdo_quick_CheckedChanged(object sender, EventArgs e)
        {
            code.Items.Clear();
            code.Items.Add("void QuickSort(int a[], int left, int right)");
            code.Items.Add("{");
            code.Items.Add("   int i, j, x;");
            code.Items.Add("   x = a[(left + right) / 2]; ");
            code.Items.Add("   i = left; j = right;");
            code.Items.Add("   while (i < j)");
            code.Items.Add("   {");
            code.Items.Add("       while (a[i] < x) i++;");
            code.Items.Add("       while (a[j] > x) j--;");
            code.Items.Add("       if (i <= j)");
            code.Items.Add("       {");
            code.Items.Add("           doicho(a[i], a[j]);");
            code.Items.Add("           i++; j--;");
            code.Items.Add("       }");
            code.Items.Add("   }");
            code.Items.Add("   if (left < j)");
            code.Items.Add("       QuickSort(a, left, j);");
            code.Items.Add("   if (i < right)");
            code.Items.Add("       QuickSort(a, i, right);");
            code.Items.Add("}");
        }

        private void rdo_heap_CheckedChanged(object sender, EventArgs e)
        {
            code.Items.Clear();
            code.Items.Add("void Shift(int a[], int l, int r)");
            code.Items.Add("{");
            code.Items.Add("   int i, j, x;");
            code.Items.Add("   i = l;");
            code.Items.Add("   j = 2 * i + 1;");
            code.Items.Add("   x = a[i];");
            code.Items.Add("   while (j <= r)");
            code.Items.Add("   {");
            code.Items.Add("       if (j < r)");
            code.Items.Add("           if (a[j] < a[j + 1])");
            code.Items.Add("               j++;");
            code.Items.Add("       if (a[j] <= x)");
            code.Items.Add("           return;");
            code.Items.Add("       else");
            code.Items.Add("       {");
            code.Items.Add("           a[i] = a[j];");
            code.Items.Add("           a[j] = x;");
            code.Items.Add("           i = j;");
            code.Items.Add("           j = 2 * i + 1;");
            code.Items.Add("           x = a[i];");
            code.Items.Add("       }");
            code.Items.Add("   }");
            code.Items.Add("}");
            code.Items.Add("");
            code.Items.Add("void CreateHeap(int a[], int n)");
            code.Items.Add("{");
            code.Items.Add("   int l = n / 2 - 1;");
            code.Items.Add("   while (l >= 0)");
            code.Items.Add("   {");
            code.Items.Add("       Shift(a, l, n - 1);");
            code.Items.Add("       l--;");
            code.Items.Add("   }");
            code.Items.Add("}");
            code.Items.Add("");
            code.Items.Add("void HeapSort(int a[], int n)");
            code.Items.Add("{");
            code.Items.Add("   int r;");
            code.Items.Add("   CreateHeap(a, n);");
            code.Items.Add("   r = n - 1;");
            code.Items.Add("   while (r > 0)");
            code.Items.Add("   {");
            code.Items.Add("       doicho(a[0], a[r]);");
            code.Items.Add("       r--;");
            code.Items.Add("       if (r > 0)");
            code.Items.Add("       Shift(a, 0, r);");
            code.Items.Add("   }");
            code.Items.Add("}");
        }

        private void rdo_merge_CheckedChanged(object sender, EventArgs e)
        {
            code.Items.Clear();
            code.Items.Add("void Distribute(int a[], int n, int &nb, int &nc, int k)");
            code.Items.Add("{");
            code.Items.Add("   int i, pa, pb, pc;");
            code.Items.Add("   pa = pb = pc = 0;");
            code.Items.Add("   while (pa < n)");
            code.Items.Add("   {");
            code.Items.Add("       for (i = 0; (pa < n) && (i < k); i++, pa++, pb++)");
            code.Items.Add("           b[pb] = a[pa];");
            code.Items.Add("       for (i = 0; (pa < n) && (i < k); i++, pa++, pc++)");
            code.Items.Add("           c[pc] = a[pa];");
            code.Items.Add("   }");
            code.Items.Add("   nb = pb;");
            code.Items.Add("   nc = pc;");
            code.Items.Add("   }");
            code.Items.Add("");
            code.Items.Add("int min(int a, int b)");
            code.Items.Add("{");
            code.Items.Add("   if (a > b)");
            code.Items.Add("       return b;");
            code.Items.Add("   else");
            code.Items.Add("       return a;");
            code.Items.Add("}");
            code.Items.Add("");
            code.Items.Add("void Merge(int a[], int nb, int nc, int k)");
            code.Items.Add("{");
            code.Items.Add("   int p, pb, pc, ib, ic, kb, kc;");
            code.Items.Add("   p = pb = pc = 0;");
            code.Items.Add("   ib = ic = 0;");
            code.Items.Add("   while ((nb > 0) && (nc > 0))");
            code.Items.Add("   {");
            code.Items.Add("       kb = min(k, nb);");
            code.Items.Add("       kc = min(k, nc);");
            code.Items.Add("       if (b[pb + ib] <= c[pc + ic])");
            code.Items.Add("       {");
            code.Items.Add("           a[p++] = b[pb+ib];");
            code.Items.Add("           ib++;");
            code.Items.Add("           if (ib == kb)");
            code.Items.Add("           {");
            code.Items.Add("               for (; ic < kc; ic++)");
            code.Items.Add("	                a[p++] = c[pc + ic];");
            code.Items.Add("               pb += kb; ");
            code.Items.Add("               pc += kc; ");
            code.Items.Add("               ib = ic = 0;");
            code.Items.Add("               nb -= kb; ");
            code.Items.Add("               nc -= kc;");
            code.Items.Add("           }");
            code.Items.Add("       }");
            code.Items.Add("       else");
            code.Items.Add("       {");
            code.Items.Add("           a[p++] = c[pc + ic];");
            code.Items.Add("           ic++;");
            code.Items.Add("           if (ic == kc)");
            code.Items.Add("           {");
            code.Items.Add("               for (; ib < kb; ib++)");
            code.Items.Add("	                a[p++] = b[pb + ib];");
            code.Items.Add("               pb += kb; ");
            code.Items.Add("               pc += kc; ");
            code.Items.Add("               ib = ic = 0;");
            code.Items.Add("               nb -= kb; ");
            code.Items.Add("               nc -= kc;");
            code.Items.Add("           }");
            code.Items.Add("       }");
            code.Items.Add("   }");
            code.Items.Add("}");
            code.Items.Add("");
            code.Items.Add("void MergeSort(int a[], int n)");
            code.Items.Add("{");
            code.Items.Add("   int k, nc = 0, nb = 0;");
            code.Items.Add("   for (k = 1; k < n; k *= 2) ");
            code.Items.Add("   {");
            code.Items.Add("       Distribute(a, n, nb, nc, k);");
            code.Items.Add("       Merge(a, nb, nc, k);");
            code.Items.Add("   }");
            code.Items.Add("}");
        }

        private void rdo_binary_CheckedChanged(object sender, EventArgs e)
        {
            code.Items.Clear();
            code.Items.Add("void BinaryInsertionSort(int a[], int n)");
            code.Items.Add("{");
            code.Items.Add("   int l, r, m, i, j, x;");
            code.Items.Add("   for (i = 1; i < n; i++)");
            code.Items.Add("   {");
            code.Items.Add("       x = a[i];");
            code.Items.Add("       l = 0;");
            code.Items.Add("       r = i;");
            code.Items.Add("       while (l < r)");
            code.Items.Add("       {");
            code.Items.Add("           m = (l + r) / 2;");
            code.Items.Add("           if (x >= a[m])");
            code.Items.Add("               l = m + 1;");
            code.Items.Add("           else");
            code.Items.Add("               r = m;");
            code.Items.Add("       }");
            code.Items.Add("       for (j = i - 1; j >= l; j--)");
            code.Items.Add("           a[j] = a[j - 1];");
            code.Items.Add("       a[l] = x;");
            code.Items.Add("   }");
            code.Items.Add("}");
        }
        #endregion

        #region CODE PHẦN TÙY CHỌN
        private void sd_tocdo_ValueChanged(object sender, EventArgs e)
        {
            sd_tocdo.Text = "    " + sd_tocdo.Value.ToString();
        }

        private void bt_batdau_Click(object sender, EventArgs e)
        {
            gp_timkiem.Enabled = false;
            lb_chuthich.Visible = true;
            bt_xoa.Enabled = false;
            gp_thuattoan.Enabled = false;
            bt_batdau.Enabled = false;
            bt_xoa.Enabled = false;
            bt_lamlai.Enabled = false;
            bt_lamhet.Enabled = false;
            bt_tamdung.Enabled = true;
            if (rdo_interchange.Checked == true)
                interchage_sort();
            if (rdo_selection.Checked == true)
                selection_sort();
            if (rdo_bubble.Checked == true)
                bubble_sort();
            if (rdo_shake.Checked == true)
                shake_sort();
            if (rdo_insertion.Checked == true)
                insertion_sort();
            if (rdo_binary.Checked == true)
                binary_sort();
            if (rdo_shell.Checked == true)
                shell_sort();
            if (rdo_quick.Checked == true)
            {
                quick_sort(0, spt - 1);
                sapxepxong();
            }
            if (rdo_merge.Checked == true)
            {
                mangb = new TextBoxX[spt];
                mangc = new TextBoxX[spt];
                Application.DoEvents();
                meger_sort(spt);
            }
            if (rdo_heap.Checked == true)
            {
                heap_sort(spt);
            }
        }

        private void bt_tamdung_Click(object sender, EventArgs e)
        {
            if (bt_tamdung.Text == "Tạm dừng")
            {
                bt_tamdung.Text = "Tiếp tục";
                bt_tamdung.Image = global::sort_algorithm.Properties.Resources.Tick;
                while (bt_tamdung.Text == "Tiếp tục")
                {
                    Application.DoEvents();
                }
            }
            else if (bt_tamdung.Text == "Tiếp tục")
            {
                bt_tamdung.Text = "Tạm dừng";
                bt_tamdung.Image = global::sort_algorithm.Properties.Resources.No;
            }
        }

        private void bt_lamlai_Click(object sender, EventArgs e)
        {
            bt_timkiem.Enabled = false;
            bt_ok.Enabled = false;
            bt_tamdung.Visible = true;
            bt_lamhet.Enabled = true;
            bt_batdau.Enabled = true;
            bt_timkiem.Enabled = true;
            bt_ok.Enabled = true;
            for (int i = 0; i < spt; i++)
            {
                mang[i].Text = giatribandau[i].ToString();
                caidatmau(mang[i], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
            }
        }
        private void bt_lamhet_Click(object sender, EventArgs e)
        {

            bt_lamhet.Enabled = false;
            bt_timkiem.Enabled = true;
            bt_ok.Enabled = true;
            for (int i = 0; i < spt; i++)
            {
                mang[i].Text = giatri[i].ToString();
                mang[i].ReadOnly = true;
                mang[i].FocusHighlightEnabled = false;
            }

            sapxepxong();
        }
        #endregion

        #region CODE PHẦN SẮP XẾP
        #region INTERCHANGE SORT
        private void interchage_sort()
        {
            int i, j;
            for (i = 0; i < spt - 1; i++)
            {
                code.SelectedIndex = 3;
                lbl_a.Visible = true;
                lb_down.Visible = true;
                lb_down.Location = new Point(mang[i].Location.X, 80);
                lb_down.Text = "    i  ";
                lb_down.Refresh();
                code.SelectedIndex = 4;
                ngu(tocdo);
                caidatmau(mang[i], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red, Color.Black);
                for (j = i + 1; j < spt; j++)
                {
                    code.SelectedIndex = 5;
                    lb_up.Visible = true;
                    lb_up.Location = new Point(mang[j].Location.X, 240);
                    lb_up.Text = "    j  ";
                    lb_up.Refresh();
                    lb_chuthich.Text = "Hoán vị ( a[" + i + "], " + "a[" + j + "] )";
                    lb_chuthich.Refresh();
                    ngu(tocdo);
                    caidatmau(mang[j], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red, Color.Black);
                    if (int.Parse(mang[j].Text) < int.Parse(mang[i].Text))
                    {
                        code.SelectedIndex = 6;
                        hoanvi_that(mang[j], mang[i]);
                        hoanvi_ao(mang[j], mang[i]);
                        code.SelectedIndex = 7;
                    }
                    caidatmau(mang[j], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                }
                caidatmau(mang[i], Color.LawnGreen, Color.White, Color.Black);
            }
            code.SelectedIndex = 0;
            sapxepxong();
        }
        #endregion
        #region SELECTION SORT
        private void selection_sort()
        {
            int i, j, min;
            for (i = 0; i < spt - 1; i++)
            {
                code.SelectedIndex = 3;
                ngu(10 * tocdo);
                code.SelectedIndex = 5;
                ngu(10 * tocdo);
                lbl_a.Visible = true;
                min = i;
                lb_down.Visible = true;
                lb_down.Location = new Point(mang[i].Location.X, 80);
                lb_down.Text = " Min ";
                lb_down.Refresh();
                caidatmau(mang[min], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red, Color.Black);
                ngu(10 * tocdo);
                for (j = i + 1; j < spt; j++)
                {
                    code.SelectedIndex = 6;
                    ngu(10 * tocdo);
                    Application.DoEvents();
                    code.SelectedIndex = 7;
                    ngu(10 * tocdo);
                    caidatmau(mang[j], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red, Color.Black);
                    if (int.Parse(mang[j].Text) < int.Parse(mang[min].Text))
                        min = j;
                    caidatmau(mang[j], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                    code.SelectedIndex = 8;
                    ngu(10 * tocdo);
                    lb_up.Visible = true;
                    lb_up.Location = new Point(mang[min].Location.X, 240);
                    lb_up.Text = "   i  ";
                    lb_up.Refresh();
                    caidatmau(mang[min], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                    ngu(10 * tocdo);
                }
                if (min != i)
                {
                    code.SelectedIndex = 9;
                    ngu(tocdo);
                    lb_chuthich.Text = "Hoán vị ( a[" + min + "], " + "a[" + i + "] )";
                    lb_chuthich.Refresh();
                    caidatmau(mang[min], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red, Color.Black);
                    caidatmau(mang[i], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red, Color.Black);
                    hoanvi_that(mang[min], mang[i]);
                    hoanvi_ao(mang[min], mang[i]);
                    caidatmau(mang[min], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                    caidatmau(mang[i], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);

                }
                else
                {
                    caidatmau(mang[min], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                    caidatmau(mang[i], Color.LawnGreen, Color.White, Color.Black);
                    continue;
                }
                caidatmau(mang[min], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                caidatmau(mang[i], Color.LawnGreen, Color.White, Color.Black);
            }
            code.SelectedIndex = 0;
            sapxepxong();
        }
        #endregion
        #region BUBBLE SORT
        private void bubble_sort()
        {
            int i, j;
            code.SelectedIndex = 0;
            ngu(tocdo);
            for (i = 0; i < spt - 1; i++)
            {
                lbl_a.Visible = true;
                lb_down.Visible = true;
                lb_down.Location = new Point(mang[i].Location.X, 80);
                lb_down.Text = "   i  ";
                lb_down.Refresh();
                for (j = spt - 1; j > i; j--)
                {
                    Application.DoEvents();
                    code.SelectedIndex = 4;
                    ngu(tocdo);
                    code.SelectedIndex = 5;
                    ngu(tocdo);
                    if (int.Parse(mang[j].Text) < int.Parse(mang[j - 1].Text))
                    {
                        lb_up.Visible = true;
                        lb_up.Location = new Point(mang[j].Location.X, 240);
                        lb_up.Text = "   j  ";
                        lb_up.Refresh();
                        lb_pointer.Visible = true;
                        code.SelectedIndex = 6;
                        lb_pointer.Location = new Point(mang[j - 1].Location.X, 240);
                        for (int k = 1; k < 4; k++)
                        {
                            lb_pointer.Location = new Point(mang[j - 1].Location.X, 235);
                            ngu(5);
                            lb_pointer.Location = new Point(mang[j - 1].Location.X, 245);
                            ngu(5);
                            lb_pointer.Location = new Point(mang[j - 1].Location.X, 240);
                        }
                        lb_pointer.Refresh();
                        caidatmau(mang[j], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red, Color.Black);
                        caidatmau(mang[j - 1], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red, Color.Black);
                        hoanvi_that(mang[j], mang[j - 1]);
                        hoanvi_ao(mang[j], mang[j - 1]);
                        lb_chuthich.Text = "Hoán vị ( a[" + (j - 1) + "], " + "a[" + j + "] )";
                        lb_chuthich.Refresh();
                        caidatmau(mang[j], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                        caidatmau(mang[j - 1], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                    }
                }
                caidatmau(mang[i], Color.LawnGreen, Color.White, Color.Black);
            }
            code.SelectedIndex = 0;
            sapxepxong();
        }
        #endregion
        #region SHAKE SORT
        private void shake_sort()
        {
            code.SelectedIndex = 0;
            int j;
            int left, right, k;
            left = 0;
            right = spt - 1;
            k = 0;
            lbl_a.Visible = true;
            while (left < right)
            {
                code.SelectedIndex = 5;
                ngu(tocdo);
                for (j = right; j > left; j--)
                {
                    code.SelectedIndex = 7;
                    ngu(tocdo);
                    lb_up.Visible = true;
                    lb_up.Location = new Point(mang[j].Location.X, 240);
                    lb_up.Text = "j";
                    lb_up.Refresh();
                    lb_pointer.Visible = true;
                    Application.DoEvents();
                    code.SelectedIndex = 8;
                    if (int.Parse(mang[j].Text) <= int.Parse(mang[j - 1].Text))
                    {
                        code.SelectedIndex = 10;
                        for (int m = 1; m < 4; m++)
                        {
                            lb_pointer.Location = new Point(mang[j - 1].Location.X, 235);
                            ngu(5);
                            lb_pointer.Location = new Point(mang[j - 1].Location.X, 245);
                            ngu(5);
                            lb_pointer.Location = new Point(mang[j - 1].Location.X, 240);
                        }
                        lb_pointer.Refresh();
                        caidatmau(mang[j], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red, Color.Black);
                        caidatmau(mang[j - 1], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red, Color.Black);
                        lb_chuthich.Text = "Hoán vị ( a[" + j + "], " + "a[" + (j - 1) + "] )";
                        hoanvi_that(mang[j], mang[j - 1]);
                        hoanvi_ao(mang[j], mang[j - 1]);
                        caidatmau(mang[j], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                        caidatmau(mang[j - 1], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                        code.SelectedIndex = 11;
                        ngu(tocdo);
                        k = j;

                    }

                }


                left = k;
                lb_down.Visible = true;
                lb_down.Location = new Point(mang[left - 1].Location.X, 80);
                lb_down.Text = "   k  ";
                lb_down.Refresh();
                code.SelectedIndex = 14;
                ngu(tocdo);
                caidatmau(mang[j], Color.LawnGreen, Color.White, Color.Black);
                for (j = left; j < right; j++)
                {
                    code.SelectedIndex = 15;
                    ngu(tocdo);
                    if (int.Parse(mang[j + 1].Text) <= int.Parse(mang[j].Text))
                    {
                        code.SelectedIndex = 17;
                        ngu(tocdo);
                        for (int m = 1; m < 4; m++)
                        {
                            lb_pointer.Location = new Point(mang[j + 1].Location.X, 245);
                            ngu(5);
                            lb_pointer.Location = new Point(mang[j + 1].Location.X, 235);
                            ngu(5);
                            lb_pointer.Location = new Point(mang[j + 1].Location.X, 240);
                        }
                        lb_pointer.Refresh();
                        lb_up.Visible = true;
                        lb_up.Location = new Point(mang[j].Location.X, 240);
                        lb_up.Text = "    j  ";
                        lb_up.Refresh();
                        lb_pointer.Visible = true;
                        caidatmau(mang[j + 1], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red, Color.Black);
                        caidatmau(mang[j], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red, Color.Black);
                        lb_chuthich.Text = "Hoán vị ( a[" + j + "], " + "a[" + (j + 1) + "] )";
                        hoanvi_that(mang[j], mang[j + 1]);
                        hoanvi_ao(mang[j], mang[j + 1]);
                        caidatmau(mang[j + 1], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                        caidatmau(mang[j], System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                        code.SelectedIndex = 18;
                        ngu(tocdo);
                        k = j;

                    }

                }
                right = k;
                lb_down.Visible = true;
                lb_down.Location = new Point(mang[right + 1].Location.X, mang[right + 1].Location.Y - 70);
                lb_down.Text = "   k  ";
                lb_down.Refresh();
                caidatmau(mang[j], Color.LawnGreen, Color.White, Color.Black);
            }

            code.SelectedIndex = 0;
            sapxepxong();
        }
        #endregion
        #region INSERTION SORT
        private void insertion_sort()
        {
            code.SelectedIndex = 0;
            lbl_a.Visible = true;
            int i, j, vitri, dem1 = 0, dem2 = 0;
            for (i = 1; i < spt; i++)
            {
                code.SelectedIndex = 1;
                lb_down.Visible = true;
                lb_down.Location = new Point(mang[i].Location.X, 80);
                lb_down.Text = "    i  ";
                lb_down.Refresh();
                code.SelectedIndex = 3;
                ngu(tocdo);
                caidatmau(mang[i], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red, Color.Black);
                dichuyenlen(mang[i]);
                code.SelectedIndex = 5;
                vitri = i - 1;
                code.SelectedIndex = 6;
                ngu(tocdo);
                lb_chuthich.Visible = true;
                lb_chuthich.Text = "So sánh ( a[" + vitri + " ], a[" + i + "] )";
                lb_chuthich.Refresh();
                ngu(10 * tocdo);
                /////////
                lb_pointer.Visible = true;
                lb_pointer.Location = new Point(mang[vitri].Location.X, 240);
                lb_pointer.Text = "   pos  ";
                lb_pointer.Refresh();
                caidatmau(mang[0], Color.LawnGreen, Color.White, Color.Black);
                lb_pointer.Location = new Point(mang[vitri].Location.X, mang[vitri].Location.Y + 240);
                ngu(3);
                while (vitri >= 0 && int.Parse(mang[vitri].Text) > int.Parse(mang[i].Text))
                {
                    code.SelectedIndex = 7;
                    lb_pointer.Visible = true;
                    lb_pointer.Location = new Point(mang[vitri].Location.X, 240);
                    lb_pointer.Text = "  pos  ";
                    lb_pointer.Location = new Point(mang[vitri].Location.X, 240);
                    ngu(3);
                    lb_chuthich.Visible = true;
                    lb_chuthich.Text = "So sánh ( a[" + vitri + " ], a[" + i + "] )";
                    ngu(10 * tocdo);
                    lb_chuthich.Visible = false;
                    code.SelectedIndex = 9;
                    dichuyenquaphai(mang[vitri]);
                    code.SelectedIndex = 10;
                    dem1++;
                    dem2++;
                    vitri--;
                    code.SelectedIndex = 12;
                    lb_pointer.Visible = true;

                }
                while (dem1 > 0)
                {
                    lb_chuthich.Visible = true;
                    lb_chuthich.Text = "Chèn vào vị trí " + vitri;
                    dichuyenquatrai(mang[i]);
                    lb_chuthich.Refresh();
                    dem1--;
                }
                dichuyenxuong(mang[i]);
                lb_chuthich.Visible = false;
                caidatmau(mang[i], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                if (dem2 > 0)
                {
                    for (j = i - dem2; j < i; j++)
                        hoanvi_ao(mang[j], mang[i]);
                }
                dem2 = 0;
                caidatmau(mang[vitri + 1], Color.LawnGreen, Color.White, Color.Black);
            }
            code.SelectedIndex = 0;
            sapxepxong();
        }
        #endregion
        #region INSERTION BINARY SORT
        private void binary_sort()
        {
            code.SelectedIndex = 0;
            lbl_a.Visible = true;
            int i, j, t, l, r, m, dem1 = 0, dem2 = 0;
            caidatmau(mang[0], Color.LawnGreen, Color.White, Color.Black);
            for (i = 1; i < spt; i++)
            {
                code.SelectedIndex = 3;
                ngu(tocdo);
                lb_up.Visible = true;
                lb_up.Location = new Point(mang[i].Location.X, 240);
                lb_up.Text = "    i  ";
                lb_up.Refresh();

                caidatmau(mang[i], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red, Color.Black);
                dichuyenlen(mang[i]);
                code.SelectedIndex = 5;
                ngu(tocdo);
                l = 0;
                r = i;
                code.SelectedIndex = 7;
                lb_chuthich.Text = "i = " + i + " đi lên";
                lb_chuthich.Refresh();
                ngu(20 * tocdo);
                while (l < r)
                {
                    code.SelectedIndex = 8;
                    ngu(tocdo);
                    m = (l + r) / 2;
                    if (int.Parse(mang[i].Text) >= int.Parse(mang[m].Text))
                    {
                        l = m + 1;
                        code.SelectedIndex = 11;
                        ngu(tocdo);
                    }
                    else
                    {
                        r = m;
                        code.SelectedIndex = 12;
                        ngu(tocdo);
                    }

                }
                code.SelectedIndex = 13;
                ngu(tocdo);
                code.SelectedIndex = 14;
                j = i - 1;
                while (j >= l)
                {
                    code.SelectedIndex = 16;
                    ngu(tocdo);
                    lb_up.Visible = true;
                    lb_up.Location = new Point(mang[i].Location.X, 240);
                    lb_up.Text = "    i  ";
                    lb_up.Refresh();
                    lb_down.Visible = true;
                    lb_down.Location = new Point(mang[j].Location.X, 80);
                    lb_down.Text = "    i  ";
                    lb_down.Refresh();
                    code.SelectedIndex = 17;
                    dichuyenquaphai(mang[j]);
                    dem1++;
                    dem2++;
                    caidatmau(mang[j], Color.LawnGreen, Color.White, Color.Black);
                    j--;
                    lb_up.Visible = false;
                    lb_down.Visible = false;
                    lb_chuthich.Text = "So sánh ( a[" + i + " ], a[" + (j + 1) + "] )";
                    lb_chuthich.Refresh();
                    ngu(20 * tocdo);

                }
                while (dem1 > 0)
                {

                    lb_down.Visible = true;
                    lb_down.Location = new Point(mang[i].Location.X, 80);
                    lb_down.Text = "    i  ";
                    lb_down.Refresh();
                    code.SelectedIndex = 17;
                    ngu(3);
                    dichuyenquatrai(mang[i]);
                    dem1--;
                    lb_chuthich.Text = "Đi từ vị trí a[" + (i) + "]  Sang Vị Trí(a[" + (j + 1) + "] )";
                    lb_chuthich.Refresh();
                    ngu(3);
                }
                lb_down.Visible = true;
                lb_down.Location = new Point(mang[i].Location.X, 80);
                lb_down.Text = "    i  ";
                lb_down.Refresh();
                code.SelectedIndex = 17;
                dichuyenxuong(mang[i]);
                caidatmau(mang[i], Color.LawnGreen, Color.White, Color.Black);
                if (dem2 > 0)
                {
                    for (t = i - dem2; t < i; t++)
                    {
                        lb_down.Visible = true;
                        lb_down.Location = new Point(mang[t].Location.X, 80);
                        lb_down.Text = "    t  ";
                        lb_down.Refresh();
                        lb_up.Visible = true;
                        lb_up.Location = new Point(mang[i].Location.X, 240);
                        lb_up.Text = "    i  ";
                        lb_up.Refresh();
                        hoanvi_ao(mang[t], mang[i]);
                    }
                }
                dem2 = 0;
                caidatmau(mang[j + 1], Color.LawnGreen, Color.White, Color.Black);
                lb_down.Visible = false;
                lb_up.Visible = false;
            }
            sapxepxong();
        }
        #endregion
        #region SHELL SORT
        private void shell_sort()
        {
            code.SelectedIndex = 0;
            int[] h;
            int i, j, t, k, dodai, buocnhay, dem1 = 0, dem2 = 0;
            k = Convert.ToInt32(Math.Log10(spt) / Math.Log10(2));
            h = new int[k];
            h[k - 1] = 1;
            for (i = k - 2; i >= 0; i--)
                h[i] = (2 * h[i + 1] + 1);
            for (buocnhay = 0; buocnhay < k; buocnhay++)
            {
                code.SelectedIndex = 3;
                ngu(tocdo);
                dodai = h[buocnhay];
                for (i = dodai; i < spt; i++)
                {
                    code.SelectedIndex = 5;
                    ngu(tocdo);
                    lb_chuthich.Visible = true;
                    lb_chuthich.Text = "bước nhảy h = [ " + buocnhay + " ] = " + dodai;
                    caidatmau(mang[i], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red, Color.Black);
                    lb_up.Visible = true;
                    lb_up.Location = new Point(mang[i].Location.X, 240);
                    lb_up.Text = "    i  ";
                    lb_up.Refresh();
                    dichuyenlen(mang[i]);
                    lb_up.Visible = false;
                    code.SelectedIndex = 8;
                    ngu(tocdo);
                    j = i - dodai;
                    for (t = j; t >= 0; t = t - dodai)
                    {
                        lb_down.Visible = true;
                        lb_down.Location = new Point(mang[j].Location.X, 80);
                        lb_down.Text = "    i  ";
                        lb_down.Refresh();
                        caidatmau(mang[t], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red, Color.Black);
                        code.SelectedIndex = 9;
                        ngu(tocdo);
                        dichuyenxuong(mang[t]);
                        lb_down.Visible = false;
                    }
                    lb_chuthich.Visible = true;
                    lb_chuthich.Text = "Sắp xếp trong mảng con...( mảng con tương ứng với bước nhảy h = " + dodai + " )......!!!.";
                    if ((int.Parse(mang[i].Text) < int.Parse(mang[j].Text)))
                    {
                        while ((j >= 0) && (int.Parse(mang[i].Text) < int.Parse(mang[j].Text)))
                        {
                            for (t = 0; t < dodai; t++)
                            {
                                code.SelectedIndex = 12;
                                dichuyenquaphai(mang[j]);
                            }
                            lb_pointer.Refresh();
                            dem1++;
                            dem2++;
                            code.SelectedIndex = 13;
                            j = j - dodai;
                            ngu(tocdo);
                        }
                        for (t = i - dodai; t >= 0; t = t - dodai)
                        {
                            lb_down.Visible = true;
                            lb_down.Location = new Point(mang[t].Location.X, 80);
                            lb_down.Text = "    i  ";
                            lb_down.Refresh();
                            dichuyenlen(mang[t]);
                            lb_down.Visible = false;
                            caidatmau(mang[t], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                        }
                    }
                    else
                    {
                        code.SelectedIndex = 15;
                        for (t = j; t >= 0; t = t - dodai)
                        {
                            lb_down.Visible = true;
                            lb_down.Location = new Point(mang[t].Location.X, 80);
                            lb_down.Text = "    i  ";
                            lb_down.Refresh();
                            dichuyenlen(mang[t]);
                            lb_down.Visible = false;
                            caidatmau(mang[t], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                        }
                    }
                    while (dem1 > 0)
                    {
                        for (t = 0; t < dodai; t++)
                            dichuyenquatrai(mang[i]);
                        dem1--;
                        lb_up.Visible = true;
                        lb_up.Location = new Point(mang[i].Location.X, 240);
                        lb_up.Text = "    j  ";
                        lb_up.Refresh();
                    }
                    code.SelectedIndex = 15;
                    dichuyenxuong(mang[i]);
                    lb_up.Visible = false;
                    caidatmau(mang[i], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                    code.SelectedIndex = 1;
                    if (dem2 > 0)
                    {
                        for (t = i - (dem2 * dodai); t < i; t = t + dodai)
                            hoanvi_ao(mang[t], mang[i]);
                    }
                    dem2 = 0;
                }
            }
            code.SelectedIndex = 0;
            sapxepxong();
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
            code.SelectedIndex = 0;
            int i, pa, pb, pc;
            pa = pb = pc = 0;
            lb_chuthich.Visible = true;
            lb_chuthich.Text = "Tách mảng a thành 2 mảng b và c.";
            while (pa < spt)
            {
                code.SelectedIndex = 4;
                for (i = 0; (pa < spt) && (i < k); i++, pa++, pb++)
                {
                    code.SelectedIndex = 6;
                    lbl_b.Visible = true;
                    mangb[pb] = mang[pa];
                    mangb[pb].Text = mang[pa].Text;
                    code.SelectedIndex = 7;
                    ngu(tocdo);
                    caidatmau(mangb[pb], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Blue, Color.Black);
                    dichuyenlen(mangb[pb]);
                    dichuyenlen(mangb[pb]);
                    dichchuyen(mangb[pb], pb);
                }
                for (i = 0; (pa < spt) && (i < k); i++, pa++, pc++)
                {
                    code.SelectedIndex = 8;
                    lbl_c.Visible = true;
                    mangc[pc] = mang[pa];
                    mangc[pc].Text = mang[pa].Text;
                    code.SelectedIndex = 9;
                    ngu(tocdo);
                    caidatmau(mangc[pc], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Green, Color.Black);
                    dichuyenxuong(mangc[pc]);
                    dichuyenxuong(mangc[pc]);
                    dichchuyen(mangc[pc], pc);
                }
                nb = pb;
                nc = pc;
            }
        }
        private void merge(int nb, int nc, int k)
        {
            lbl_a.Visible = true;
            lb_chuthich.Visible = true;
            lb_chuthich.Text = "Gộp mảng b , mảng c vào thành mảng a";
            int pa, pb, pc, ib, ic, cdaib, cdaic, kb, kc;
            cdaib = nb;
            cdaic = nc;
            pa = pb = pc = 0; ib = ic = 0;
            while ((nb > 0) && (nc > 0))
            {
                code.SelectedIndex = 29;
                ngu(tocdo);
                kb = min(k, nb);
                kc = min(k, nc);
                if (int.Parse(mangb[(pb + ib)].Text) <= int.Parse(mangc[(pc + ic)].Text))
                {
                    code.SelectedIndex = 34;
                    ngu(tocdo);
                    mang[pa] = mangb[pb + ib];
                    denvitri(mangb[pb + ib], pa);
                    caidatmau(mangb[pb + ib], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                    pa++;
                    code.SelectedIndex = 34;
                    ngu(tocdo);
                    ib++;
                    if (ib == kb)
                    {
                        code.SelectedIndex = 37;
                        ngu(tocdo);
                        for (; ic < kc; ic++)
                        {
                            code.SelectedIndex = 39;
                            ngu(tocdo);
                            mang[pa] = mangc[pc + ic];
                            denvitri(mangc[pc + ic], pa);
                            caidatmau(mangc[pc + ic], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                            pa++;
                            code.SelectedIndex = 39;
                            ngu(tocdo);
                        }
                        pb += kb;
                        pc += kc;
                        code.SelectedIndex = 40;
                        ib = ic = 0;
                        nb -= kb;
                        code.SelectedIndex = 42;
                        nc -= kc;
                    }
                }
                else
                {
                    code.SelectedIndex = 48;
                    ngu(tocdo);
                    mang[pa] = mangc[pc + ic];
                    code.SelectedIndex = 49;
                    ngu(tocdo);
                    denvitri(mangc[pc + ic], pa);
                    caidatmau(mangc[pc + ic], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                    pa++;
                    ic++;
                    if (ic == kc)
                    {
                        code.SelectedIndex = 50;
                        ngu(tocdo);
                        for (; ib < kb; ib++)
                        {
                            ngu(tocdo);
                            mang[pa] = mangb[pb + ib];
                            code.SelectedIndex = 54;
                            ngu(tocdo);
                            denvitri(mangb[pb + ib], pa);
                            caidatmau(mangb[pb + ib], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                            pa++;
                        }
                        code.SelectedIndex = 54;
                        pb += kb;
                        code.SelectedIndex = 55;
                        ngu(tocdo);
                        pc += kc;
                        code.SelectedIndex = 56;
                        ib = ic = 0;
                        code.SelectedIndex = 57;
                        nb -= kb;
                        code.SelectedIndex = 58;
                        nc -= kc;
                    }
                }
            }
            for (; nb > 0; nb--)
            {
                Application.DoEvents();
                code.SelectedIndex = 34;
                ngu(tocdo);
                denvitri(mangb[cdaib - nb], pa);
                pa++;
                caidatmau(mangb[cdaib - nb], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
            }
            for (; nc > 0; nc--)
            {
                code.SelectedIndex = 39;
                ngu(tocdo);
                Application.DoEvents();
                denvitri(mangc[cdaic - nc], pa);
                pa++;
                caidatmau(mangc[cdaic - nc], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
            }
        }
        private void meger_sort(int n)
        {
            lbl_a.Visible = true;
            int k, nc = 0, nb = 0;
            for (k = 1; k < n; k *= 2)
            {
                distribute(ref nb, ref nc, k);
                merge(nb, nc, k);
            }
            lbl_b.Visible = false;
            lbl_c.Visible = false;
            code.SelectedIndex = 65;
            sapxepxong();
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
            code.SelectedIndex = 0;
            lb_chuthich.Visible = true;
            lb_chuthich.Text = "Hiệu chỉnh Heap!...";
            int i, j, x, tam;
            TextBoxX temp;
            i = left;
            code.SelectedIndex = 3;
            ngu(tocdo);
            j = 2 * i + 1;
            code.SelectedIndex = 4;
            lb_down.Visible = true;
            lb_down.Location = new Point(mang[i].Location.X, mang[i].Location.Y - 75);
            lb_down.Text = "    i  ";
            lb_down.Refresh();
            lb_up.Visible = true;
            lb_up.Location = new Point(mang[j].Location.X, mang[j].Location.Y + 73);
            lb_up.Text = "    j  ";
            lb_up.Refresh();
            code.SelectedIndex = 5;
            ngu(tocdo);
            x = int.Parse(mang[i].Text);
            temp = mang[i];
            tam = i;
            while (j <= right)
            {
                if (j < right)
                    if (int.Parse(mang[j].Text) < int.Parse(mang[j + 1].Text))
                        j++;
                code.SelectedIndex = 10;
                lb_up.Visible = true;
                lb_up.Location = new Point(mang[j].Location.X, mang[j].Location.Y + 73);
                lb_up.Text = "    j  ";
                lb_up.Refresh();
                if (int.Parse(mang[j].Text) <= x)
                {
                    code.SelectedIndex = 12;
                    return;
                }
                else
                {
                    int t = int.Parse(mang[i].Text);
                    t = int.Parse(mang[j].Text);
                    x = int.Parse(mang[j].Text);
                    code.SelectedIndex = 14;
                    code.SelectedIndex = 15;
                    ngu(tocdo);
                    hoanvi_that(mang[j], temp);
                    hoanvi_ao(mang[j], mang[tam]);
                    code.SelectedIndex = 16;
                    ngu(tocdo);
                    code.SelectedIndex = 17;
                    i = j;
                    code.SelectedIndex = 18;
                    ngu(tocdo);
                    j = 2 * i + 1;
                    if (j <= right)
                    {
                        lb_down.Visible = true;
                        lb_down.Location = new Point(mang[i].Location.X, mang[i].Location.Y - 75);
                        lb_down.Text = "   i  ";
                        lb_down.Refresh();
                        lb_up.Visible = true;
                        lb_up.Location = new Point(mang[j].Location.X, mang[j].Location.Y + 73);
                        lb_up.Text = "   j  ";
                        lb_up.Refresh();
                    }
                    code.SelectedIndex = 19;
                    ngu(tocdo);
                    x = int.Parse(mang[i].Text);
                    temp = mang[i];
                    tam = i;
                }
            }
            lb_chuthich.Visible = false;
        }
        private void CreateHeap(int n)
        {
            lb_chuthich.Visible = true;
            lb_chuthich.Text = "Hiệu chỉnh Heap!!!.";
            int left = n / 2 - 1;
            while (left >= 0)
            {
                code.SelectedIndex = 29;
                ngu(tocdo);
                shift(left, n - 1);

                left--;
            }
            lb_chuthich.Visible = false;
        }
        private void heap_sort(int n)
        {
            lbl_a.Visible = true;
            int right;
            CreateHeap(n);
            right = n - 1;
            lb_up.Visible = true;
            lb_up.Location = new Point(mang[right].Location.X, mang[right].Location.Y + 73);
            lb_up.Text = "    r  ";
            lb_up.Refresh();
            while (right > 0)
            {

                Application.DoEvents();
                hoanviint(int.Parse(mang[0].Text), int.Parse(mang[right].Text));
                lb_down.Visible = false;
                lb_up.Visible = false;
                lb_chuthich.Visible = true;
                lb_chuthich.Text = "Hoán vị ( a [ 0 ] , a [ " + right + " ] )";
                lb_up.Visible = true;
                lb_up.Location = new Point(mang[right].Location.X, mang[right].Location.Y + 73);
                lb_up.Text = "    r  ";
                lb_up.Refresh();
                lb_down.Visible = true;
                lb_down.Location = new Point(mang[0].Location.X, mang[0].Location.Y - 75);
                lb_down.Text = "   0  ";
                lb_down.Refresh();
                hoanvi_that(mang[0], mang[right]);
                hoanvi_ao(mang[0], mang[right]);
                caidatmau(mang[right], Color.LawnGreen, Color.White, Color.Black);
                lb_chuthich.Visible = true;
                lb_chuthich.Text = "a [ " + right + " ] đã được sắp xếp !..";
                ngu(20);
                right--;
                lb_up.Visible = true;
                lb_up.Location = new Point(mang[right].Location.X, mang[right].Location.Y + 73);
                lb_up.Text = "    r  ";
                lb_up.Refresh();
                if (right > 0)
                {
                    shift(0, right);
                }
            }
            caidatmau(mang[0], Color.LawnGreen, Color.White, Color.Black);
            lb_down.Visible = false;
            lb_up.Visible = false;
            sapxepxong();
        }
        # endregion
        #region QUICK SORT
        private void quick_sort(int left, int right)
        {
            code.SelectedIndex = 0;
            lbl_a.Visible = true;

            int m, l, r;
            l = left;
            r = right;
            m = int.Parse(mang[left].Text);

            while (left < right)
            {
                while ((int.Parse(mang[right].Text) >= m) && (left < right))
                {
                    right--;
                }


                if (left != right)
                {
                    code.SelectedIndex = 1;
                    lb_down.Visible = true;
                    lb_down.Location = new Point(mang[left].Location.X, 80);
                    lb_down.Text = "   L  ";
                    lb_down.Refresh();
                    lb_up.Visible = true;
                    lb_up.Location = new Point(mang[right].Location.X, 240);
                    lb_up.Text = "   R  ";
                    lb_up.Refresh();

                    caidatmau(mang[left], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red, Color.Black);
                    caidatmau(mang[right], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red, Color.Black);
                    lb_chuthich.Text = "Hoán vị ( a[" + left + "], " + "a[" + right + "] )";
                    lb_chuthich.Refresh();
                    hoanviint(left, right);
                    hoanvi_that(mang[left], mang[right]);
                    hoanvi_ao(mang[left], mang[right]);
                    caidatmau(mang[left], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                    caidatmau(mang[right], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                    left++;
                }

                while ((int.Parse(mang[left].Text) <= m) && (left < right))
                {
                    left++;
                }

                if (left != right)
                {
                    caidatmau(mang[left], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red, Color.Black);
                    caidatmau(mang[right], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), Color.Red, Color.Black);
                    lb_chuthich.Text = "HOÁN VỊ ( a[" + right + "], " + "a[" + left + "] )";
                    lb_chuthich.Refresh();
                    hoanviint(right, left);
                    hoanvi_that(mang[right], mang[left]);
                    hoanvi_ao(mang[right], mang[left]);
                    caidatmau(mang[left], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                    caidatmau(mang[right], Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), Color.Red, Color.Black);
                    right--;
                }
            }
            caidatmau(mang[left], Color.LawnGreen, Color.White, Color.Black);

            int t = int.Parse(mang[left].Text);
            t = m;
            m = left;
            left = l;
            right = r;

            if (left < m)
            {
                quick_sort(left, m - 1);
                caidatmau(mang[m - 1], Color.LawnGreen, Color.White, Color.Black);
            }
            if (right > m)
            {
                quick_sort(m + 1, right);
                caidatmau(mang[m + 1], Color.LawnGreen, Color.White, Color.Black);
            }

        }
        #endregion
        #endregion

        #region CODE PHẦN TÌM KIẾM
        private void tb_timkiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            lb_chuthich.Visible = true;
            bt_timkiem.Enabled = false;
            bt_ok.Enabled = true;
          
            if (rb_tuyentinh.Checked == true)
            {
                tb_timkiem.Enabled = true;
                code_tim.Items.Clear();
                code_tim.Items.Add("void Tk_Tuyentinh()");
                code_tim.Items.Add("{");
                code_tim.Items.Add("    int a ,count = 0 ;");
                code_tim.Items.Add("    for ( int i=0 ; i<spt ; i++ )");
                code_tim.Items.Add("        if ( i == a )");
                code_tim.Items.Add("            Tim thay! ");
                code_tim.Items.Add("            Khong tim thay!");
                code_tim.Items.Add("}");
                bt_ok.Checked = true;
             //   bt_timkiem.Checked = false;
                tuyentinh();
            }
            if (rb_nhiphan.Checked == true)
            {
                tb_timkiem.Enabled = true;
                code_tim.Items.Clear();
                code_tim.Items.Add(" void tk_nhiphan() ");
                code_tim.Items.Add("{");
                code_tim.Items.Add("    int a , count = 0 , left=0 , right=spt-1;");
                code_tim.Items.Add("while (left <=right)");
                code_tim.Items.Add("    {");
                code_tim.Items.Add("        int mid = ( left + right )/2 ;");
                code_tim.Items.Add("        if ( a <= mid )");
                code_tim.Items.Add("          right = mid - 1 ;");
                code_tim.Items.Add("        else");
                code_tim.Items.Add("            left = mid + 1 ;");
                code_tim.Items.Add("    }");
                code_tim.Items.Add("    if ( count ==0 )");
                code_tim.Items.Add("        Khong tim thay!!");
                code_tim.Items.Add("    else ");
                code_tim.Items.Add("        Tim thay!!!");
                code_tim.Items.Add("}");
                bt_ok.Checked = true;
             //   bt_timkiem.Checked = true;
                nhiphan(0, spt);
            }
        }
        #region TIM KIEM TUYEN TINH
        private void tuyentinh()
        {
            int i;
            int timkiem;
            int count = 0;
            try
            {
                timkiem = int.Parse(tb_timkiem.Text);
            }
            catch
            {
                MessageBox.Show("Từ khóa tìm kiếm không hợp lệ !!!");
                return;
            }
            for (i = 0; i < spt; i++)
            {
                lb_chuthich.Text = " i = " + i;
                lb_pointer.Visible = true;
                lb_pointer.Location = new Point(mang[i].Location.X, mang[i].Location.Y + 40);
                lb_pointer.Refresh();
                ngu(40);
                if (int.Parse(mang[i].Text) == timkiem)
                {
                    dichuyenlen(mang[i]);
                    count++;
                }
            }
            ngu(10);
            lb_pointer.Visible = false;
            if (count == 0)
            {
                lb_chuthich.Text = "Không tìm thấy " + timkiem + " tại vị trí nào cả!!!";
            }
            else
            {
                for (i = 0; i < spt; i++)
                {
                    lb_chuthich.Text = "Tìm thấy " + timkiem + " ....";
                }
            }
            for (i = 0; i < spt; i++)
            {
                if (int.Parse(mang[i].Text) == timkiem)
                {
                    mang[i].Top -= 40;
                }
            }

        }
        #endregion
        #region TIM KIEM NHI PHAN
        public void nhiphan(int a, int b)
        {
            int timkiem;
            int count = 0;
            string timkiem_gt = " ; ";
            for (int i = 0; i < spt; i++)
            {
                for (int j = i + 1; j < spt; j++)
                {
                    if (int.Parse(mang[i].Text) > int.Parse(mang[j].Text))
                    {
                        MessageBox.Show("Bạn phải sắp xếp mảng trước khi sử dụng thuật Tìm kiếm nhị phân !!!");
                        code_tim.Items.Clear();
                        mang[i].Top = 160;
                        return;
                    }
                }
            }
            try
            {
                timkiem = int.Parse(tb_timkiem.Text);
            }
            catch
            {
                MessageBox.Show("Từ khóa tìm kiếm không hợp lệ !!!");
                return;
            }
            int left_tk = 0;
            int right_tk = spt - 1;
            while (left_tk <= right_tk)
            {
                int mid_tk = (left_tk + right_tk) / 2;
                Thread.Sleep(10);
                ngu(50);
                lb_chuthich.Text = "  mid = " + mid_tk;
                lb_pointer.Visible = true;
                lb_pointer.Location = new Point(mang[mid_tk].Location.X, mang[mid_tk].Location.Y + 40);
                lb_pointer.Refresh();
                ngu(40);
                if (timkiem == int.Parse(mang[mid_tk].Text))
                {
                    count++;
                    timkiem_gt += mid_tk + " ; ";
                }
                if (timkiem <= int.Parse(mang[mid_tk].Text))
                {
                    right_tk = mid_tk - 1;
                }
                else left_tk = mid_tk + 1;
            }
            lb_pointer.Visible = false;
            if (count == 0)
            {
                lb_chuthich.Text = "Không tìm thấy " + timkiem + " tại vị trí nào cả!!!";
            }
            else
            {
                for (int i = 0; i < spt; i++)
                {
                    if (int.Parse(mang[i].Text) == timkiem)
                    {
                        mang[i].Top -= 40;
                    }
                    lb_chuthich.Text = "Tìm thấy " + timkiem + " ....";
                }
            }
        }
        #endregion

        private void bt_ok_Click(object sender, EventArgs e)
        {
            bt_timkiem.Enabled = true;
            for (int i = 0; i < spt; i++)
            {
                code_tim.Items.Clear();
                mang[i].Top = 160;
                caidatmau(mang[i], Color.LawnGreen, Color.White, Color.Black);
            }
            lb_chuthich.Visible = false;
        }
        #endregion
    }
}