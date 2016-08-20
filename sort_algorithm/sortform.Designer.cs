namespace sort_algorithm
{
    partial class sortform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sortform));
            this.control = new DevComponents.DotNetBar.RibbonControl();
            this.controlgp = new DevComponents.DotNetBar.RibbonPanel();
            this.gp_tuychon = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.bt_lamhet = new DevComponents.DotNetBar.ButtonX();
            this.bt_tamdung = new DevComponents.DotNetBar.ButtonX();
            this.bt_lamlai = new DevComponents.DotNetBar.ButtonX();
            this.bt_batdau = new DevComponents.DotNetBar.ButtonX();
            this.lb_tocdo = new DevComponents.DotNetBar.LabelX();
            this.sd_tocdo = new DevComponents.DotNetBar.Controls.Slider();
            this.gp_code = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.code = new System.Windows.Forms.ListBox();
            this.sd_kickthuoc = new DevComponents.DotNetBar.Controls.Slider();
            this.gp_thuattoan = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rdo_binary = new System.Windows.Forms.RadioButton();
            this.rdo_merge = new System.Windows.Forms.RadioButton();
            this.rdo_heap = new System.Windows.Forms.RadioButton();
            this.rdo_quick = new System.Windows.Forms.RadioButton();
            this.rdo_shell = new System.Windows.Forms.RadioButton();
            this.rdo_insertion = new System.Windows.Forms.RadioButton();
            this.rdo_shake = new System.Windows.Forms.RadioButton();
            this.rdo_bubble = new System.Windows.Forms.RadioButton();
            this.rdo_selection = new System.Windows.Forms.RadioButton();
            this.rdo_interchange = new System.Windows.Forms.RadioButton();
            this.gp_khoitaomang = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.bt_nhap = new DevComponents.DotNetBar.ButtonX();
            this.lb_spt = new DevComponents.DotNetBar.LabelX();
            this.bt_xoa = new DevComponents.DotNetBar.ButtonX();
            this.bt_taongaunhien = new DevComponents.DotNetBar.ButtonX();
            this.sd_spt = new DevComponents.DotNetBar.Controls.Slider();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.group_code_tk = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.code_tim = new System.Windows.Forms.ListBox();
            this.gp_timkiem = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.bt_ok = new DevComponents.DotNetBar.ButtonX();
            this.group_timkiem = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rb_nhiphan = new System.Windows.Forms.RadioButton();
            this.rb_tuyentinh = new System.Windows.Forms.RadioButton();
            this.bt_timkiem = new DevComponents.DotNetBar.ButtonX();
            this.tb_timkiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_timkiem = new DevComponents.DotNetBar.LabelX();
            this.menubar = new DevComponents.DotNetBar.RibbonTabItem();
            this.rb_tools = new DevComponents.DotNetBar.RibbonTabItem();
            this.bt_menu = new DevComponents.DotNetBar.Office2007StartButton();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.btn_thongtin = new DevComponents.DotNetBar.ButtonItem();
            this.btn_form3 = new DevComponents.DotNetBar.ButtonItem();
            this.btn_thoat = new DevComponents.DotNetBar.ButtonItem();
            this.p_main = new DevComponents.DotNetBar.PanelEx();
            this.lbl_c = new DevComponents.DotNetBar.LabelX();
            this.lbl_b = new DevComponents.DotNetBar.LabelX();
            this.lbl_a = new DevComponents.DotNetBar.LabelX();
            this.lb_pointer = new DevComponents.DotNetBar.LabelX();
            this.lb_down = new DevComponents.DotNetBar.LabelX();
            this.lb_up = new DevComponents.DotNetBar.LabelX();
            this.lb_chuthich = new DevComponents.DotNetBar.LabelX();
            this.time_tocdo = new System.Windows.Forms.Timer(this.components);
            this.control.SuspendLayout();
            this.controlgp.SuspendLayout();
            this.gp_tuychon.SuspendLayout();
            this.gp_code.SuspendLayout();
            this.gp_thuattoan.SuspendLayout();
            this.gp_khoitaomang.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.group_code_tk.SuspendLayout();
            this.gp_timkiem.SuspendLayout();
            this.group_timkiem.SuspendLayout();
            this.p_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // control
            // 
            // 
            // 
            // 
            this.control.BackgroundStyle.Class = "";
            this.control.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.control.CaptionVisible = true;
            this.control.Controls.Add(this.controlgp);
            this.control.Controls.Add(this.ribbonPanel1);
            this.control.Dock = System.Windows.Forms.DockStyle.Top;
            this.control.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.menubar,
            this.rb_tools});
            this.control.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.control.Location = new System.Drawing.Point(5, 1);
            this.control.Name = "control";
            this.control.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.control.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bt_menu});
            this.control.Size = new System.Drawing.Size(1272, 301);
            this.control.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.control.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.control.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.control.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.control.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.control.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.control.SystemText.QatDialogAddButton = "&Add >>";
            this.control.SystemText.QatDialogCancelButton = "Cancel";
            this.control.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.control.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.control.SystemText.QatDialogOkButton = "OK";
            this.control.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.control.SystemText.QatDialogRemoveButton = "&Remove";
            this.control.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.control.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.control.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.control.TabGroupHeight = 14;
            this.control.TabIndex = 0;
            // 
            // controlgp
            // 
            this.controlgp.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.controlgp.Controls.Add(this.gp_tuychon);
            this.controlgp.Controls.Add(this.gp_code);
            this.controlgp.Controls.Add(this.gp_thuattoan);
            this.controlgp.Controls.Add(this.gp_khoitaomang);
            this.controlgp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlgp.Location = new System.Drawing.Point(0, 56);
            this.controlgp.Name = "controlgp";
            this.controlgp.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.controlgp.Size = new System.Drawing.Size(1272, 243);
            // 
            // 
            // 
            this.controlgp.Style.Class = "";
            this.controlgp.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.controlgp.StyleMouseDown.Class = "";
            this.controlgp.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.controlgp.StyleMouseOver.Class = "";
            this.controlgp.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.controlgp.TabIndex = 1;
            // 
            // gp_tuychon
            // 
            this.gp_tuychon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gp_tuychon.CanvasColor = System.Drawing.SystemColors.Control;
            this.gp_tuychon.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gp_tuychon.Controls.Add(this.bt_lamhet);
            this.gp_tuychon.Controls.Add(this.bt_tamdung);
            this.gp_tuychon.Controls.Add(this.bt_lamlai);
            this.gp_tuychon.Controls.Add(this.bt_batdau);
            this.gp_tuychon.Controls.Add(this.lb_tocdo);
            this.gp_tuychon.Controls.Add(this.sd_tocdo);
            this.gp_tuychon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_tuychon.Location = new System.Drawing.Point(999, 1);
            this.gp_tuychon.Name = "gp_tuychon";
            this.gp_tuychon.Size = new System.Drawing.Size(272, 240);
            // 
            // 
            // 
            this.gp_tuychon.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gp_tuychon.Style.BackColorGradientAngle = 90;
            this.gp_tuychon.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gp_tuychon.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_tuychon.Style.BorderBottomWidth = 1;
            this.gp_tuychon.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gp_tuychon.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_tuychon.Style.BorderLeftWidth = 1;
            this.gp_tuychon.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_tuychon.Style.BorderRightWidth = 1;
            this.gp_tuychon.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_tuychon.Style.BorderTopWidth = 1;
            this.gp_tuychon.Style.Class = "";
            this.gp_tuychon.Style.CornerDiameter = 4;
            this.gp_tuychon.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gp_tuychon.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gp_tuychon.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gp_tuychon.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gp_tuychon.StyleMouseDown.Class = "";
            this.gp_tuychon.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gp_tuychon.StyleMouseOver.Class = "";
            this.gp_tuychon.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gp_tuychon.TabIndex = 3;
            this.gp_tuychon.Text = "Tùy chọn";
            // 
            // bt_lamhet
            // 
            this.bt_lamhet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_lamhet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_lamhet.Image = ((System.Drawing.Image)(resources.GetObject("bt_lamhet.Image")));
            this.bt_lamhet.Location = new System.Drawing.Point(146, 99);
            this.bt_lamhet.Name = "bt_lamhet";
            this.bt_lamhet.Size = new System.Drawing.Size(114, 45);
            this.bt_lamhet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_lamhet.TabIndex = 11;
            this.bt_lamhet.Text = "Sắp xếp hết";
            this.bt_lamhet.Click += new System.EventHandler(this.bt_lamhet_Click);
            // 
            // bt_tamdung
            // 
            this.bt_tamdung.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_tamdung.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_tamdung.Image = ((System.Drawing.Image)(resources.GetObject("bt_tamdung.Image")));
            this.bt_tamdung.Location = new System.Drawing.Point(7, 160);
            this.bt_tamdung.Name = "bt_tamdung";
            this.bt_tamdung.Size = new System.Drawing.Size(114, 45);
            this.bt_tamdung.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_tamdung.TabIndex = 9;
            this.bt_tamdung.Text = "Tạm dừng";
            this.bt_tamdung.Click += new System.EventHandler(this.bt_tamdung_Click);
            // 
            // bt_lamlai
            // 
            this.bt_lamlai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_lamlai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_lamlai.Image = ((System.Drawing.Image)(resources.GetObject("bt_lamlai.Image")));
            this.bt_lamlai.Location = new System.Drawing.Point(146, 160);
            this.bt_lamlai.Name = "bt_lamlai";
            this.bt_lamlai.Size = new System.Drawing.Size(114, 45);
            this.bt_lamlai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_lamlai.TabIndex = 9;
            this.bt_lamlai.Text = "Làm lại từ đầu";
            this.bt_lamlai.Click += new System.EventHandler(this.bt_lamlai_Click);
            // 
            // bt_batdau
            // 
            this.bt_batdau.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_batdau.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_batdau.Image = ((System.Drawing.Image)(resources.GetObject("bt_batdau.Image")));
            this.bt_batdau.Location = new System.Drawing.Point(7, 99);
            this.bt_batdau.Name = "bt_batdau";
            this.bt_batdau.Size = new System.Drawing.Size(114, 45);
            this.bt_batdau.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_batdau.TabIndex = 8;
            this.bt_batdau.Text = "Bắt đầu";
            this.bt_batdau.Click += new System.EventHandler(this.bt_batdau_Click);
            // 
            // lb_tocdo
            // 
            this.lb_tocdo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.lb_tocdo.BackgroundStyle.Class = "";
            this.lb_tocdo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_tocdo.Image = ((System.Drawing.Image)(resources.GetObject("lb_tocdo.Image")));
            this.lb_tocdo.Location = new System.Drawing.Point(61, 9);
            this.lb_tocdo.Name = "lb_tocdo";
            this.lb_tocdo.SingleLineColor = System.Drawing.SystemColors.Control;
            this.lb_tocdo.Size = new System.Drawing.Size(135, 24);
            this.lb_tocdo.TabIndex = 7;
            this.lb_tocdo.Text = "Tốc độ thuật toán:";
            // 
            // sd_tocdo
            // 
            this.sd_tocdo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.sd_tocdo.BackgroundStyle.Class = "";
            this.sd_tocdo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sd_tocdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sd_tocdo.Location = new System.Drawing.Point(4, 43);
            this.sd_tocdo.Maximum = 10;
            this.sd_tocdo.Name = "sd_tocdo";
            this.sd_tocdo.Size = new System.Drawing.Size(259, 30);
            this.sd_tocdo.TabIndex = 0;
            this.sd_tocdo.Text = "    5";
            this.sd_tocdo.Value = 5;
            this.sd_tocdo.ValueChanged += new System.EventHandler(this.sd_tocdo_ValueChanged);
            // 
            // gp_code
            // 
            this.gp_code.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gp_code.CanvasColor = System.Drawing.SystemColors.Control;
            this.gp_code.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gp_code.Controls.Add(this.code);
            this.gp_code.Controls.Add(this.sd_kickthuoc);
            this.gp_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_code.Location = new System.Drawing.Point(549, 1);
            this.gp_code.Name = "gp_code";
            this.gp_code.Size = new System.Drawing.Size(446, 240);
            // 
            // 
            // 
            this.gp_code.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gp_code.Style.BackColorGradientAngle = 90;
            this.gp_code.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gp_code.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_code.Style.BorderBottomWidth = 1;
            this.gp_code.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gp_code.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_code.Style.BorderLeftWidth = 1;
            this.gp_code.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_code.Style.BorderRightWidth = 1;
            this.gp_code.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_code.Style.BorderTopWidth = 1;
            this.gp_code.Style.Class = "";
            this.gp_code.Style.CornerDiameter = 4;
            this.gp_code.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gp_code.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gp_code.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gp_code.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gp_code.StyleMouseDown.Class = "";
            this.gp_code.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gp_code.StyleMouseOver.Class = "";
            this.gp_code.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gp_code.TabIndex = 2;
            this.gp_code.Text = "Hiển thị Code các thuật toán";
            // 
            // code
            // 
            this.code.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.code.ForeColor = System.Drawing.Color.Black;
            this.code.HorizontalScrollbar = true;
            this.code.ItemHeight = 16;
            this.code.Location = new System.Drawing.Point(3, 3);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(398, 212);
            this.code.TabIndex = 2;
            // 
            // sd_kickthuoc
            // 
            this.sd_kickthuoc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.sd_kickthuoc.BackgroundStyle.Class = "";
            this.sd_kickthuoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sd_kickthuoc.Location = new System.Drawing.Point(407, -35);
            this.sd_kickthuoc.Maximum = 19;
            this.sd_kickthuoc.Minimum = 1;
            this.sd_kickthuoc.Name = "sd_kickthuoc";
            this.sd_kickthuoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sd_kickthuoc.Size = new System.Drawing.Size(28, 249);
            this.sd_kickthuoc.SliderOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.sd_kickthuoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.sd_kickthuoc.TabIndex = 1;
            this.sd_kickthuoc.Value = 10;
            this.sd_kickthuoc.ValueChanged += new System.EventHandler(this.sd_kickthuoc_ValueChanged);
            // 
            // gp_thuattoan
            // 
            this.gp_thuattoan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gp_thuattoan.CanvasColor = System.Drawing.SystemColors.Control;
            this.gp_thuattoan.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gp_thuattoan.Controls.Add(this.rdo_binary);
            this.gp_thuattoan.Controls.Add(this.rdo_merge);
            this.gp_thuattoan.Controls.Add(this.rdo_heap);
            this.gp_thuattoan.Controls.Add(this.rdo_quick);
            this.gp_thuattoan.Controls.Add(this.rdo_shell);
            this.gp_thuattoan.Controls.Add(this.rdo_insertion);
            this.gp_thuattoan.Controls.Add(this.rdo_shake);
            this.gp_thuattoan.Controls.Add(this.rdo_bubble);
            this.gp_thuattoan.Controls.Add(this.rdo_selection);
            this.gp_thuattoan.Controls.Add(this.rdo_interchange);
            this.gp_thuattoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_thuattoan.Location = new System.Drawing.Point(252, 1);
            this.gp_thuattoan.Name = "gp_thuattoan";
            this.gp_thuattoan.Size = new System.Drawing.Size(292, 240);
            // 
            // 
            // 
            this.gp_thuattoan.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gp_thuattoan.Style.BackColorGradientAngle = 90;
            this.gp_thuattoan.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gp_thuattoan.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_thuattoan.Style.BorderBottomWidth = 1;
            this.gp_thuattoan.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gp_thuattoan.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_thuattoan.Style.BorderLeftWidth = 1;
            this.gp_thuattoan.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_thuattoan.Style.BorderRightWidth = 1;
            this.gp_thuattoan.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_thuattoan.Style.BorderTopWidth = 1;
            this.gp_thuattoan.Style.Class = "";
            this.gp_thuattoan.Style.CornerDiameter = 4;
            this.gp_thuattoan.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gp_thuattoan.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gp_thuattoan.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gp_thuattoan.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gp_thuattoan.StyleMouseDown.Class = "";
            this.gp_thuattoan.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gp_thuattoan.StyleMouseOver.Class = "";
            this.gp_thuattoan.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gp_thuattoan.TabIndex = 1;
            this.gp_thuattoan.Text = "Lựa chọn thuật toán";
            // 
            // rdo_binary
            // 
            this.rdo_binary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rdo_binary.AutoSize = true;
            this.rdo_binary.BackColor = System.Drawing.SystemColors.Control;
            this.rdo_binary.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdo_binary.Location = new System.Drawing.Point(143, 179);
            this.rdo_binary.Margin = new System.Windows.Forms.Padding(10);
            this.rdo_binary.Name = "rdo_binary";
            this.rdo_binary.Size = new System.Drawing.Size(150, 21);
            this.rdo_binary.TabIndex = 9;
            this.rdo_binary.Text = "Binary Insertion Sort";
            this.rdo_binary.UseVisualStyleBackColor = false;
            this.rdo_binary.CheckedChanged += new System.EventHandler(this.rdo_binary_CheckedChanged);
            // 
            // rdo_merge
            // 
            this.rdo_merge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rdo_merge.AutoSize = true;
            this.rdo_merge.BackColor = System.Drawing.SystemColors.Control;
            this.rdo_merge.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdo_merge.Location = new System.Drawing.Point(142, 139);
            this.rdo_merge.Margin = new System.Windows.Forms.Padding(10);
            this.rdo_merge.Name = "rdo_merge";
            this.rdo_merge.Size = new System.Drawing.Size(98, 21);
            this.rdo_merge.TabIndex = 8;
            this.rdo_merge.Text = "Merge Sort";
            this.rdo_merge.UseVisualStyleBackColor = false;
            this.rdo_merge.CheckedChanged += new System.EventHandler(this.rdo_merge_CheckedChanged);
            // 
            // rdo_heap
            // 
            this.rdo_heap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rdo_heap.AutoSize = true;
            this.rdo_heap.BackColor = System.Drawing.SystemColors.Control;
            this.rdo_heap.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdo_heap.Location = new System.Drawing.Point(142, 99);
            this.rdo_heap.Margin = new System.Windows.Forms.Padding(10);
            this.rdo_heap.Name = "rdo_heap";
            this.rdo_heap.Size = new System.Drawing.Size(93, 21);
            this.rdo_heap.TabIndex = 7;
            this.rdo_heap.Text = "Heap Sort";
            this.rdo_heap.UseVisualStyleBackColor = false;
            this.rdo_heap.CheckedChanged += new System.EventHandler(this.rdo_heap_CheckedChanged);
            // 
            // rdo_quick
            // 
            this.rdo_quick.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rdo_quick.AutoSize = true;
            this.rdo_quick.BackColor = System.Drawing.SystemColors.Control;
            this.rdo_quick.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdo_quick.Location = new System.Drawing.Point(143, 59);
            this.rdo_quick.Margin = new System.Windows.Forms.Padding(10);
            this.rdo_quick.Name = "rdo_quick";
            this.rdo_quick.Size = new System.Drawing.Size(93, 21);
            this.rdo_quick.TabIndex = 6;
            this.rdo_quick.Text = "Quick Sort";
            this.rdo_quick.UseVisualStyleBackColor = false;
            this.rdo_quick.CheckedChanged += new System.EventHandler(this.rdo_quick_CheckedChanged);
            // 
            // rdo_shell
            // 
            this.rdo_shell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rdo_shell.AutoSize = true;
            this.rdo_shell.BackColor = System.Drawing.SystemColors.Control;
            this.rdo_shell.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdo_shell.Location = new System.Drawing.Point(143, 19);
            this.rdo_shell.Margin = new System.Windows.Forms.Padding(10);
            this.rdo_shell.Name = "rdo_shell";
            this.rdo_shell.Size = new System.Drawing.Size(89, 21);
            this.rdo_shell.TabIndex = 5;
            this.rdo_shell.Text = "Shell Sort";
            this.rdo_shell.UseVisualStyleBackColor = false;
            this.rdo_shell.CheckedChanged += new System.EventHandler(this.rdo_shell_CheckedChanged);
            // 
            // rdo_insertion
            // 
            this.rdo_insertion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rdo_insertion.AutoSize = true;
            this.rdo_insertion.BackColor = System.Drawing.SystemColors.Control;
            this.rdo_insertion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdo_insertion.Location = new System.Drawing.Point(10, 179);
            this.rdo_insertion.Margin = new System.Windows.Forms.Padding(10);
            this.rdo_insertion.Name = "rdo_insertion";
            this.rdo_insertion.Size = new System.Drawing.Size(109, 21);
            this.rdo_insertion.TabIndex = 4;
            this.rdo_insertion.Text = "Insertion Sort";
            this.rdo_insertion.UseVisualStyleBackColor = false;
            this.rdo_insertion.CheckedChanged += new System.EventHandler(this.rdo_insertion_CheckedChanged);
            // 
            // rdo_shake
            // 
            this.rdo_shake.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rdo_shake.AutoSize = true;
            this.rdo_shake.BackColor = System.Drawing.SystemColors.Control;
            this.rdo_shake.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdo_shake.Location = new System.Drawing.Point(9, 139);
            this.rdo_shake.Margin = new System.Windows.Forms.Padding(10);
            this.rdo_shake.Name = "rdo_shake";
            this.rdo_shake.Size = new System.Drawing.Size(98, 21);
            this.rdo_shake.TabIndex = 3;
            this.rdo_shake.Text = "Shake Sort";
            this.rdo_shake.UseVisualStyleBackColor = false;
            this.rdo_shake.CheckedChanged += new System.EventHandler(this.rdo_shake_CheckedChanged);
            // 
            // rdo_bubble
            // 
            this.rdo_bubble.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rdo_bubble.AutoSize = true;
            this.rdo_bubble.BackColor = System.Drawing.SystemColors.Control;
            this.rdo_bubble.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdo_bubble.Location = new System.Drawing.Point(9, 99);
            this.rdo_bubble.Margin = new System.Windows.Forms.Padding(10);
            this.rdo_bubble.Name = "rdo_bubble";
            this.rdo_bubble.Size = new System.Drawing.Size(102, 21);
            this.rdo_bubble.TabIndex = 2;
            this.rdo_bubble.Text = "Bubble Sort";
            this.rdo_bubble.UseVisualStyleBackColor = false;
            this.rdo_bubble.CheckedChanged += new System.EventHandler(this.rdo_bubble_CheckedChanged);
            // 
            // rdo_selection
            // 
            this.rdo_selection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rdo_selection.AutoSize = true;
            this.rdo_selection.BackColor = System.Drawing.SystemColors.Control;
            this.rdo_selection.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdo_selection.Location = new System.Drawing.Point(10, 59);
            this.rdo_selection.Margin = new System.Windows.Forms.Padding(10);
            this.rdo_selection.Name = "rdo_selection";
            this.rdo_selection.Size = new System.Drawing.Size(115, 21);
            this.rdo_selection.TabIndex = 1;
            this.rdo_selection.Text = "Selection Sort";
            this.rdo_selection.UseVisualStyleBackColor = false;
            this.rdo_selection.CheckedChanged += new System.EventHandler(this.rdo_selection_CheckedChanged);
            // 
            // rdo_interchange
            // 
            this.rdo_interchange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rdo_interchange.AutoSize = true;
            this.rdo_interchange.BackColor = System.Drawing.SystemColors.Control;
            this.rdo_interchange.Checked = true;
            this.rdo_interchange.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdo_interchange.Location = new System.Drawing.Point(10, 19);
            this.rdo_interchange.Margin = new System.Windows.Forms.Padding(10);
            this.rdo_interchange.Name = "rdo_interchange";
            this.rdo_interchange.Size = new System.Drawing.Size(129, 21);
            this.rdo_interchange.TabIndex = 0;
            this.rdo_interchange.TabStop = true;
            this.rdo_interchange.Text = "Interchange Sort";
            this.rdo_interchange.UseVisualStyleBackColor = false;
            this.rdo_interchange.CheckedChanged += new System.EventHandler(this.rdo_interchange_CheckedChanged);
            // 
            // gp_khoitaomang
            // 
            this.gp_khoitaomang.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gp_khoitaomang.CanvasColor = System.Drawing.SystemColors.Control;
            this.gp_khoitaomang.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gp_khoitaomang.Controls.Add(this.bt_nhap);
            this.gp_khoitaomang.Controls.Add(this.lb_spt);
            this.gp_khoitaomang.Controls.Add(this.bt_xoa);
            this.gp_khoitaomang.Controls.Add(this.bt_taongaunhien);
            this.gp_khoitaomang.Controls.Add(this.sd_spt);
            this.gp_khoitaomang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_khoitaomang.Location = new System.Drawing.Point(11, 1);
            this.gp_khoitaomang.Name = "gp_khoitaomang";
            this.gp_khoitaomang.Size = new System.Drawing.Size(236, 240);
            // 
            // 
            // 
            this.gp_khoitaomang.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gp_khoitaomang.Style.BackColorGradientAngle = 90;
            this.gp_khoitaomang.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gp_khoitaomang.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_khoitaomang.Style.BorderBottomWidth = 1;
            this.gp_khoitaomang.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gp_khoitaomang.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_khoitaomang.Style.BorderLeftWidth = 1;
            this.gp_khoitaomang.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_khoitaomang.Style.BorderRightWidth = 1;
            this.gp_khoitaomang.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_khoitaomang.Style.BorderTopWidth = 1;
            this.gp_khoitaomang.Style.Class = "";
            this.gp_khoitaomang.Style.CornerDiameter = 4;
            this.gp_khoitaomang.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gp_khoitaomang.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gp_khoitaomang.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gp_khoitaomang.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gp_khoitaomang.StyleMouseDown.Class = "";
            this.gp_khoitaomang.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gp_khoitaomang.StyleMouseOver.Class = "";
            this.gp_khoitaomang.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gp_khoitaomang.TabIndex = 0;
            this.gp_khoitaomang.Text = "Khởi tạo mảng";
            // 
            // bt_nhap
            // 
            this.bt_nhap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_nhap.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_nhap.Image = ((System.Drawing.Image)(resources.GetObject("bt_nhap.Image")));
            this.bt_nhap.Location = new System.Drawing.Point(38, 124);
            this.bt_nhap.Name = "bt_nhap";
            this.bt_nhap.Size = new System.Drawing.Size(156, 32);
            this.bt_nhap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_nhap.TabIndex = 7;
            this.bt_nhap.Text = "Nhập từ bàn phím";
            this.bt_nhap.Click += new System.EventHandler(this.bt_nhap_Click);
            // 
            // lb_spt
            // 
            this.lb_spt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.lb_spt.BackgroundStyle.Class = "";
            this.lb_spt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_spt.Image = ((System.Drawing.Image)(resources.GetObject("lb_spt.Image")));
            this.lb_spt.Location = new System.Drawing.Point(67, 3);
            this.lb_spt.Name = "lb_spt";
            this.lb_spt.SingleLineColor = System.Drawing.SystemColors.Control;
            this.lb_spt.Size = new System.Drawing.Size(97, 30);
            this.lb_spt.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.lb_spt.TabIndex = 6;
            this.lb_spt.Text = "Số phần tử:";
            // 
            // bt_xoa
            // 
            this.bt_xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_xoa.Image = ((System.Drawing.Image)(resources.GetObject("bt_xoa.Image")));
            this.bt_xoa.Location = new System.Drawing.Point(39, 173);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(156, 32);
            this.bt_xoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_xoa.TabIndex = 5;
            this.bt_xoa.Text = "Xóa mảng";
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_taongaunhien
            // 
            this.bt_taongaunhien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_taongaunhien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_taongaunhien.Image = ((System.Drawing.Image)(resources.GetObject("bt_taongaunhien.Image")));
            this.bt_taongaunhien.Location = new System.Drawing.Point(39, 78);
            this.bt_taongaunhien.Name = "bt_taongaunhien";
            this.bt_taongaunhien.Size = new System.Drawing.Size(156, 32);
            this.bt_taongaunhien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_taongaunhien.TabIndex = 3;
            this.bt_taongaunhien.Text = "Tạo ngẫu nhiên";
            this.bt_taongaunhien.Click += new System.EventHandler(this.bt_taongaunhien_Click);
            // 
            // sd_spt
            // 
            this.sd_spt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sd_spt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            // 
            // 
            // 
            this.sd_spt.BackgroundStyle.Class = "";
            this.sd_spt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sd_spt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sd_spt.Location = new System.Drawing.Point(5, 42);
            this.sd_spt.Maximum = 30;
            this.sd_spt.Minimum = 1;
            this.sd_spt.Name = "sd_spt";
            this.sd_spt.Size = new System.Drawing.Size(220, 23);
            this.sd_spt.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.sd_spt.TabIndex = 1;
            this.sd_spt.Text = "   30";
            this.sd_spt.Value = 30;
            this.sd_spt.ValueChanged += new System.EventHandler(this.sd_spt_ValueChanged);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.group_code_tk);
            this.ribbonPanel1.Controls.Add(this.gp_timkiem);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(1272, 243);
            // 
            // 
            // 
            this.ribbonPanel1.Style.Class = "";
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.Class = "";
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.Class = "";
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 2;
            this.ribbonPanel1.Visible = false;
            // 
            // group_code_tk
            // 
            this.group_code_tk.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.group_code_tk.CanvasColor = System.Drawing.SystemColors.Control;
            this.group_code_tk.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.group_code_tk.Controls.Add(this.code_tim);
            this.group_code_tk.Location = new System.Drawing.Point(254, 3);
            this.group_code_tk.Name = "group_code_tk";
            this.group_code_tk.Size = new System.Drawing.Size(424, 240);
            // 
            // 
            // 
            this.group_code_tk.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.group_code_tk.Style.BackColorGradientAngle = 90;
            this.group_code_tk.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.group_code_tk.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.group_code_tk.Style.BorderBottomWidth = 1;
            this.group_code_tk.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.group_code_tk.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.group_code_tk.Style.BorderLeftWidth = 1;
            this.group_code_tk.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.group_code_tk.Style.BorderRightWidth = 1;
            this.group_code_tk.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.group_code_tk.Style.BorderTopWidth = 1;
            this.group_code_tk.Style.Class = "";
            this.group_code_tk.Style.CornerDiameter = 4;
            this.group_code_tk.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.group_code_tk.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.group_code_tk.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.group_code_tk.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.group_code_tk.StyleMouseDown.Class = "";
            this.group_code_tk.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.group_code_tk.StyleMouseOver.Class = "";
            this.group_code_tk.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.group_code_tk.TabIndex = 1;
            this.group_code_tk.Text = "Hiện Code giải thuật tìm kiếm";
            // 
            // code_tim
            // 
            this.code_tim.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.code_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.code_tim.FormattingEnabled = true;
            this.code_tim.ItemHeight = 15;
            this.code_tim.Location = new System.Drawing.Point(3, 3);
            this.code_tim.Name = "code_tim";
            this.code_tim.Size = new System.Drawing.Size(412, 214);
            this.code_tim.TabIndex = 0;
            // 
            // gp_timkiem
            // 
            this.gp_timkiem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gp_timkiem.CanvasColor = System.Drawing.SystemColors.Control;
            this.gp_timkiem.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gp_timkiem.Controls.Add(this.bt_ok);
            this.gp_timkiem.Controls.Add(this.group_timkiem);
            this.gp_timkiem.Controls.Add(this.bt_timkiem);
            this.gp_timkiem.Controls.Add(this.tb_timkiem);
            this.gp_timkiem.Controls.Add(this.lb_timkiem);
            this.gp_timkiem.Location = new System.Drawing.Point(7, 2);
            this.gp_timkiem.Name = "gp_timkiem";
            this.gp_timkiem.Size = new System.Drawing.Size(237, 240);
            // 
            // 
            // 
            this.gp_timkiem.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gp_timkiem.Style.BackColorGradientAngle = 90;
            this.gp_timkiem.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gp_timkiem.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_timkiem.Style.BorderBottomWidth = 1;
            this.gp_timkiem.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gp_timkiem.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_timkiem.Style.BorderLeftWidth = 1;
            this.gp_timkiem.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_timkiem.Style.BorderRightWidth = 1;
            this.gp_timkiem.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_timkiem.Style.BorderTopWidth = 1;
            this.gp_timkiem.Style.Class = "";
            this.gp_timkiem.Style.CornerDiameter = 4;
            this.gp_timkiem.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gp_timkiem.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gp_timkiem.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gp_timkiem.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gp_timkiem.StyleMouseDown.Class = "";
            this.gp_timkiem.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gp_timkiem.StyleMouseOver.Class = "";
            this.gp_timkiem.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gp_timkiem.TabIndex = 0;
            this.gp_timkiem.Text = "Tìm Kiếm";
            // 
            // bt_ok
            // 
            this.bt_ok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_ok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_ok.Location = new System.Drawing.Point(159, 60);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(50, 33);
            this.bt_ok.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_ok.TabIndex = 5;
            this.bt_ok.Text = "OK";
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // group_timkiem
            // 
            this.group_timkiem.CanvasColor = System.Drawing.SystemColors.Control;
            this.group_timkiem.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.group_timkiem.Controls.Add(this.rb_nhiphan);
            this.group_timkiem.Controls.Add(this.rb_tuyentinh);
            this.group_timkiem.Location = new System.Drawing.Point(15, 117);
            this.group_timkiem.Name = "group_timkiem";
            this.group_timkiem.Size = new System.Drawing.Size(200, 96);
            // 
            // 
            // 
            this.group_timkiem.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.group_timkiem.Style.BackColorGradientAngle = 90;
            this.group_timkiem.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.group_timkiem.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.group_timkiem.Style.BorderBottomWidth = 1;
            this.group_timkiem.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.group_timkiem.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.group_timkiem.Style.BorderLeftWidth = 1;
            this.group_timkiem.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.group_timkiem.Style.BorderRightWidth = 1;
            this.group_timkiem.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.group_timkiem.Style.BorderTopWidth = 1;
            this.group_timkiem.Style.Class = "";
            this.group_timkiem.Style.CornerDiameter = 4;
            this.group_timkiem.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.group_timkiem.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.group_timkiem.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.group_timkiem.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.group_timkiem.StyleMouseDown.Class = "";
            this.group_timkiem.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.group_timkiem.StyleMouseOver.Class = "";
            this.group_timkiem.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.group_timkiem.TabIndex = 4;
            this.group_timkiem.Text = "Thuật toán";
            // 
            // rb_nhiphan
            // 
            this.rb_nhiphan.AutoSize = true;
            this.rb_nhiphan.Location = new System.Drawing.Point(18, 55);
            this.rb_nhiphan.Name = "rb_nhiphan";
            this.rb_nhiphan.Size = new System.Drawing.Size(113, 17);
            this.rb_nhiphan.TabIndex = 3;
            this.rb_nhiphan.Text = "Tìm kiếm Nhị phân";
            this.rb_nhiphan.UseVisualStyleBackColor = true;
            // 
            // rb_tuyentinh
            // 
            this.rb_tuyentinh.AutoSize = true;
            this.rb_tuyentinh.Checked = true;
            this.rb_tuyentinh.Location = new System.Drawing.Point(18, 16);
            this.rb_tuyentinh.Name = "rb_tuyentinh";
            this.rb_tuyentinh.Size = new System.Drawing.Size(122, 17);
            this.rb_tuyentinh.TabIndex = 2;
            this.rb_tuyentinh.TabStop = true;
            this.rb_tuyentinh.Text = "Tìm kiếm Tuyến tính";
            this.rb_tuyentinh.UseVisualStyleBackColor = true;
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_timkiem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("bt_timkiem.Image")));
            this.bt_timkiem.Location = new System.Drawing.Point(15, 60);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(126, 33);
            this.bt_timkiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_timkiem.TabIndex = 3;
            this.bt_timkiem.Text = "Tìm kiếm";
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_timkiem.Border.Class = "TextBoxBorder";
            this.tb_timkiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_timkiem.FocusHighlightEnabled = true;
            this.tb_timkiem.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timkiem.ForeColor = System.Drawing.Color.Black;
            this.tb_timkiem.Location = new System.Drawing.Point(167, 13);
            this.tb_timkiem.MaxLength = 2;
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(42, 31);
            this.tb_timkiem.TabIndex = 2;
            // 
            // lb_timkiem
            // 
            this.lb_timkiem.BackColor = System.Drawing.SystemColors.ControlLight;
            // 
            // 
            // 
            this.lb_timkiem.BackgroundStyle.Class = "";
            this.lb_timkiem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_timkiem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timkiem.Location = new System.Drawing.Point(19, 16);
            this.lb_timkiem.Name = "lb_timkiem";
            this.lb_timkiem.SingleLineColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_timkiem.Size = new System.Drawing.Size(137, 26);
            this.lb_timkiem.TabIndex = 1;
            this.lb_timkiem.Text = "Nhập giá trị cần tìm:";
            // 
            // menubar
            // 
            this.menubar.Checked = true;
            this.menubar.Name = "menubar";
            this.menubar.Panel = this.controlgp;
            this.menubar.Text = "Menu";
            // 
            // rb_tools
            // 
            this.rb_tools.Name = "rb_tools";
            this.rb_tools.Panel = this.ribbonPanel1;
            this.rb_tools.Text = "Công cụ";
            // 
            // bt_menu
            // 
            this.bt_menu.AutoExpandOnClick = true;
            this.bt_menu.CanCustomize = false;
            this.bt_menu.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.bt_menu.Image = ((System.Drawing.Image)(resources.GetObject("bt_menu.Image")));
            this.bt_menu.ImagePaddingHorizontal = 2;
            this.bt_menu.ImagePaddingVertical = 2;
            this.bt_menu.Name = "bt_menu";
            this.bt_menu.ShowSubItems = false;
            this.bt_menu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.bt_menu.Text = "&File";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.MinimumSize = new System.Drawing.Size(200, 150);
            this.itemContainer1.MultiLine = true;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.ResizeItemsToFit = false;
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2});
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.ItemSpacing = 0;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer3});
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer3.MinimumSize = new System.Drawing.Size(120, 0);
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_thongtin,
            this.btn_form3,
            this.btn_thoat});
            // 
            // btn_thongtin
            // 
            this.btn_thongtin.BeginGroup = true;
            this.btn_thongtin.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_thongtin.FixedSize = new System.Drawing.Size(200, 50);
            this.btn_thongtin.FontBold = true;
            this.btn_thongtin.Image = ((System.Drawing.Image)(resources.GetObject("btn_thongtin.Image")));
            this.btn_thongtin.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btn_thongtin.Name = "btn_thongtin";
            this.btn_thongtin.SubItemsExpandWidth = 24;
            this.btn_thongtin.Text = "Thông Tin &Nhóm";
            this.btn_thongtin.Click += new System.EventHandler(this.btn_thongtin_Click);
            // 
            // btn_form3
            // 
            this.btn_form3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_form3.FixedSize = new System.Drawing.Size(200, 50);
            this.btn_form3.FontBold = true;
            this.btn_form3.Image = ((System.Drawing.Image)(resources.GetObject("btn_form3.Image")));
            this.btn_form3.Name = "btn_form3";
            this.btn_form3.Text = "&So sánh Thuật Toán";
            this.btn_form3.Click += new System.EventHandler(this.btn_form3_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BeginGroup = true;
            this.btn_thoat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_thoat.FixedSize = new System.Drawing.Size(200, 50);
            this.btn_thoat.FontBold = true;
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.SubItemsExpandWidth = 24;
            this.btn_thoat.Text = "&Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // p_main
            // 
            this.p_main.CanvasColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.p_main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.p_main.Controls.Add(this.lbl_c);
            this.p_main.Controls.Add(this.lbl_b);
            this.p_main.Controls.Add(this.lbl_a);
            this.p_main.Controls.Add(this.lb_pointer);
            this.p_main.Controls.Add(this.lb_down);
            this.p_main.Controls.Add(this.lb_up);
            this.p_main.Controls.Add(this.lb_chuthich);
            this.p_main.Location = new System.Drawing.Point(5, 304);
            this.p_main.Name = "p_main";
            this.p_main.Size = new System.Drawing.Size(1272, 354);
            this.p_main.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.p_main.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.p_main.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.p_main.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.p_main.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.p_main.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.p_main.Style.GradientAngle = 90;
            this.p_main.TabIndex = 1;
            // 
            // lbl_c
            // 
            // 
            // 
            // 
            this.lbl_c.BackgroundStyle.Class = "";
            this.lbl_c.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_c.ForeColor = System.Drawing.Color.Green;
            this.lbl_c.Location = new System.Drawing.Point(3, 240);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(29, 23);
            this.lbl_c.TabIndex = 4;
            this.lbl_c.Text = "c:";
            this.lbl_c.Visible = false;
            // 
            // lbl_b
            // 
            this.lbl_b.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_b.BackgroundStyle.Class = "";
            this.lbl_b.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_b.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_b.Location = new System.Drawing.Point(3, 80);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(26, 23);
            this.lbl_b.TabIndex = 3;
            this.lbl_b.Text = "b:";
            this.lbl_b.Visible = false;
            // 
            // lbl_a
            // 
            // 
            // 
            // 
            this.lbl_a.BackgroundStyle.Class = "";
            this.lbl_a.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_a.ForeColor = System.Drawing.Color.Red;
            this.lbl_a.Location = new System.Drawing.Point(3, 160);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(26, 23);
            this.lbl_a.TabIndex = 2;
            this.lbl_a.Text = "a:";
            this.lbl_a.Visible = false;
            // 
            // lb_pointer
            // 
            this.lb_pointer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lb_pointer.BackgroundImage")));
            this.lb_pointer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            // 
            // 
            // 
            this.lb_pointer.BackgroundStyle.Class = "";
            this.lb_pointer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_pointer.Location = new System.Drawing.Point(82, 10);
            this.lb_pointer.Name = "lb_pointer";
            this.lb_pointer.Size = new System.Drawing.Size(35, 35);
            this.lb_pointer.TabIndex = 0;
            // 
            // lb_down
            // 
            this.lb_down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lb_down.BackgroundImage")));
            this.lb_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            // 
            // 
            // 
            this.lb_down.BackgroundStyle.Class = "";
            this.lb_down.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_down.Location = new System.Drawing.Point(46, 10);
            this.lb_down.Name = "lb_down";
            this.lb_down.Size = new System.Drawing.Size(30, 35);
            this.lb_down.TabIndex = 0;
            // 
            // lb_up
            // 
            this.lb_up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lb_up.BackgroundImage")));
            this.lb_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            // 
            // 
            // 
            this.lb_up.BackgroundStyle.Class = "";
            this.lb_up.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_up.Location = new System.Drawing.Point(10, 10);
            this.lb_up.Name = "lb_up";
            this.lb_up.Size = new System.Drawing.Size(30, 35);
            this.lb_up.TabIndex = 0;
            // 
            // lb_chuthich
            // 
            // 
            // 
            // 
            this.lb_chuthich.BackgroundStyle.Class = "";
            this.lb_chuthich.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_chuthich.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_chuthich.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.lb_chuthich.Location = new System.Drawing.Point(0, 0);
            this.lb_chuthich.Name = "lb_chuthich";
            this.lb_chuthich.Size = new System.Drawing.Size(1272, 30);
            this.lb_chuthich.TabIndex = 1;
            this.lb_chuthich.Text = "Tạo mảng để sắp xếp";
            this.lb_chuthich.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // time_tocdo
            // 
            this.time_tocdo.Enabled = true;
            this.time_tocdo.Interval = 1;
            this.time_tocdo.Tick += new System.EventHandler(this.time_tocdo_Tick);
            // 
            // sortform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 672);
            this.ControlBox = false;
            this.Controls.Add(this.p_main);
            this.Controls.Add(this.control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "sortform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình mô phỏng các thuật toán sắp xếp";
            this.Load += new System.EventHandler(this.sortform_Load);
            this.control.ResumeLayout(false);
            this.control.PerformLayout();
            this.controlgp.ResumeLayout(false);
            this.gp_tuychon.ResumeLayout(false);
            this.gp_code.ResumeLayout(false);
            this.gp_thuattoan.ResumeLayout(false);
            this.gp_thuattoan.PerformLayout();
            this.gp_khoitaomang.ResumeLayout(false);
            this.ribbonPanel1.ResumeLayout(false);
            this.group_code_tk.ResumeLayout(false);
            this.gp_timkiem.ResumeLayout(false);
            this.group_timkiem.ResumeLayout(false);
            this.group_timkiem.PerformLayout();
            this.p_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl control;
        private DevComponents.DotNetBar.RibbonPanel controlgp;
        private DevComponents.DotNetBar.Office2007StartButton bt_menu;
        private DevComponents.DotNetBar.RibbonTabItem menubar;
        private DevComponents.DotNetBar.Controls.GroupPanel gp_khoitaomang;
        private DevComponents.DotNetBar.PanelEx p_main;
        private DevComponents.DotNetBar.Controls.Slider sd_spt;
        private DevComponents.DotNetBar.ButtonX bt_taongaunhien;
        private DevComponents.DotNetBar.ButtonX bt_xoa;
        private DevComponents.DotNetBar.Controls.GroupPanel gp_thuattoan;
        private DevComponents.DotNetBar.LabelX lb_spt;
        private System.Windows.Forms.RadioButton rdo_insertion;
        private System.Windows.Forms.RadioButton rdo_shake;
        private System.Windows.Forms.RadioButton rdo_bubble;
        private System.Windows.Forms.RadioButton rdo_selection;
        private System.Windows.Forms.RadioButton rdo_interchange;
        private System.Windows.Forms.RadioButton rdo_binary;
        private System.Windows.Forms.RadioButton rdo_merge;
        private System.Windows.Forms.RadioButton rdo_heap;
        private System.Windows.Forms.RadioButton rdo_quick;
        private System.Windows.Forms.RadioButton rdo_shell;
        private DevComponents.DotNetBar.Controls.GroupPanel gp_code;
        private DevComponents.DotNetBar.Controls.GroupPanel gp_tuychon;
        private DevComponents.DotNetBar.Controls.Slider sd_tocdo;
        private DevComponents.DotNetBar.LabelX lb_tocdo;
        private DevComponents.DotNetBar.ButtonX bt_nhap;
        private DevComponents.DotNetBar.Controls.Slider sd_kickthuoc;
        private DevComponents.DotNetBar.ButtonX bt_batdau;
        private DevComponents.DotNetBar.ButtonX bt_lamlai;
        private DevComponents.DotNetBar.ButtonX bt_lamhet;
        private System.Windows.Forms.ListBox code;
        private System.Windows.Forms.Timer time_tocdo;
        private DevComponents.DotNetBar.LabelX lb_up;
        private DevComponents.DotNetBar.LabelX lb_down;
        private DevComponents.DotNetBar.LabelX lb_pointer;
        private DevComponents.DotNetBar.LabelX lb_chuthich;
        private DevComponents.DotNetBar.ButtonX bt_tamdung;
        private DevComponents.DotNetBar.LabelX lbl_c;
        private DevComponents.DotNetBar.LabelX lbl_b;
        private DevComponents.DotNetBar.LabelX lbl_a;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonTabItem rb_tools;
        private DevComponents.DotNetBar.Controls.GroupPanel gp_timkiem;
        private DevComponents.DotNetBar.LabelX lb_timkiem;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_timkiem;
        private DevComponents.DotNetBar.ButtonX bt_timkiem;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.ButtonItem btn_thongtin;
        private DevComponents.DotNetBar.ButtonItem btn_form3;
        private DevComponents.DotNetBar.ButtonItem btn_thoat;
        private DevComponents.DotNetBar.Controls.GroupPanel group_timkiem;
        private System.Windows.Forms.RadioButton rb_nhiphan;
        private System.Windows.Forms.RadioButton rb_tuyentinh;
        private DevComponents.DotNetBar.ButtonX bt_ok;
        private DevComponents.DotNetBar.Controls.GroupPanel group_code_tk;
        private System.Windows.Forms.ListBox code_tim;
    }
}