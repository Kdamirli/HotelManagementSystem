namespace HotelManagementSystem
{
    partial class MainForm
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_hide = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_show = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_Employee = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_CustInfo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_CheckOut = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_CustReg = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_AddRoom = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.ucCheckOut1 = new HotelManagementSystem.UserControls.UCCheckOut();
            this.ucCustomerRegistration1 = new HotelManagementSystem.UserControls.UCCustomerRegistration();
            this.ucAddRoom1 = new HotelManagementSystem.UserControls.UCAddRoom();
            this.ucCustDetails1 = new HotelManagementSystem.UserControls.UCCustDetails();
            this.ucEmployee1 = new HotelManagementSystem.UserControls.UCEmployee();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.guna2Panel1.Controls.Add(this.btn_hide);
            this.guna2Panel1.Controls.Add(this.btn_show);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.btn_Employee);
            this.guna2Panel1.Controls.Add(this.btn_CustInfo);
            this.guna2Panel1.Controls.Add(this.btn_CheckOut);
            this.guna2Panel1.Controls.Add(this.btn_CustReg);
            this.guna2Panel1.Controls.Add(this.btn_AddRoom);
            this.guna2Transition1.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(237, 624);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btn_hide
            // 
            this.btn_hide.Animated = true;
            this.btn_hide.BackColor = System.Drawing.Color.Transparent;
            this.btn_hide.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_hide.CheckedState.Parent = this.btn_hide;
            this.btn_hide.CustomImages.Parent = this.btn_hide;
            this.guna2Transition1.SetDecoration(this.btn_hide, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_hide.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btn_hide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_hide.ForeColor = System.Drawing.Color.White;
            this.btn_hide.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btn_hide.HoverState.Parent = this.btn_hide;
            this.btn_hide.Image = ((System.Drawing.Image)(resources.GetObject("btn_hide.Image")));
            this.btn_hide.ImageSize = new System.Drawing.Size(15, 15);
            this.btn_hide.Location = new System.Drawing.Point(215, 521);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_hide.ShadowDecoration.Parent = this.btn_hide;
            this.btn_hide.Size = new System.Drawing.Size(40, 40);
            this.btn_hide.TabIndex = 26;
            this.btn_hide.UseTransparentBackground = true;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // btn_show
            // 
            this.btn_show.Animated = true;
            this.btn_show.BackColor = System.Drawing.Color.Transparent;
            this.btn_show.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_show.CheckedState.Parent = this.btn_show;
            this.btn_show.CustomImages.Parent = this.btn_show;
            this.guna2Transition1.SetDecoration(this.btn_show, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_show.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btn_show.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_show.ForeColor = System.Drawing.Color.White;
            this.btn_show.HoverState.Parent = this.btn_show;
            this.btn_show.Image = ((System.Drawing.Image)(resources.GetObject("btn_show.Image")));
            this.btn_show.ImageSize = new System.Drawing.Size(15, 15);
            this.btn_show.Location = new System.Drawing.Point(34, 521);
            this.btn_show.Name = "btn_show";
            this.btn_show.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_show.ShadowDecoration.Parent = this.btn_show;
            this.btn_show.Size = new System.Drawing.Size(40, 40);
            this.btn_show.TabIndex = 25;
            this.btn_show.UseTransparentBackground = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Transition1.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator1.FillColor = System.Drawing.Color.Gray;
            this.guna2Separator1.Location = new System.Drawing.Point(12, 535);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(193, 10);
            this.guna2Separator1.TabIndex = 6;
            // 
            // guna2PictureBox1
            // 
            this.guna2Transition1.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(34, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(165, 132);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btn_Employee
            // 
            this.btn_Employee.Animated = true;
            this.btn_Employee.BackColor = System.Drawing.Color.Transparent;
            this.btn_Employee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Employee.CheckedState.Parent = this.btn_Employee;
            this.btn_Employee.CustomImages.Image = global::HotelManagementSystem.Properties.Resources.Employee;
            this.btn_Employee.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Employee.CustomImages.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Employee.CustomImages.Parent = this.btn_Employee;
            this.guna2Transition1.SetDecoration(this.btn_Employee, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_Employee.FillColor = System.Drawing.Color.Empty;
            this.btn_Employee.FillColor2 = System.Drawing.Color.Empty;
            this.btn_Employee.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Employee.ForeColor = System.Drawing.Color.White;
            this.btn_Employee.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btn_Employee.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btn_Employee.HoverState.Parent = this.btn_Employee;
            this.btn_Employee.Location = new System.Drawing.Point(0, 391);
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.ShadowDecoration.Parent = this.btn_Employee;
            this.btn_Employee.Size = new System.Drawing.Size(213, 45);
            this.btn_Employee.TabIndex = 4;
            this.btn_Employee.Text = "Работники";
            this.btn_Employee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Employee.TextOffset = new System.Drawing.Point(50, 0);
            this.btn_Employee.UseTransparentBackground = true;
            this.btn_Employee.Click += new System.EventHandler(this.btn_Employee_Click);
            // 
            // btn_CustInfo
            // 
            this.btn_CustInfo.Animated = true;
            this.btn_CustInfo.BackColor = System.Drawing.Color.Transparent;
            this.btn_CustInfo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_CustInfo.CheckedState.Parent = this.btn_CustInfo;
            this.btn_CustInfo.CustomImages.Image = global::HotelManagementSystem.Properties.Resources.customer_Details1;
            this.btn_CustInfo.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_CustInfo.CustomImages.ImageSize = new System.Drawing.Size(38, 38);
            this.btn_CustInfo.CustomImages.Parent = this.btn_CustInfo;
            this.guna2Transition1.SetDecoration(this.btn_CustInfo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_CustInfo.FillColor = System.Drawing.Color.Empty;
            this.btn_CustInfo.FillColor2 = System.Drawing.Color.Empty;
            this.btn_CustInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CustInfo.ForeColor = System.Drawing.Color.White;
            this.btn_CustInfo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btn_CustInfo.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btn_CustInfo.HoverState.Parent = this.btn_CustInfo;
            this.btn_CustInfo.Location = new System.Drawing.Point(0, 340);
            this.btn_CustInfo.Name = "btn_CustInfo";
            this.btn_CustInfo.ShadowDecoration.Parent = this.btn_CustInfo;
            this.btn_CustInfo.Size = new System.Drawing.Size(213, 45);
            this.btn_CustInfo.TabIndex = 3;
            this.btn_CustInfo.Text = "Информация о гостях";
            this.btn_CustInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_CustInfo.TextOffset = new System.Drawing.Point(50, 0);
            this.btn_CustInfo.UseTransparentBackground = true;
            this.btn_CustInfo.Click += new System.EventHandler(this.btn_CustInfo_Click);
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.Animated = true;
            this.btn_CheckOut.BackColor = System.Drawing.Color.Transparent;
            this.btn_CheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_CheckOut.CheckedState.Parent = this.btn_CheckOut;
            this.btn_CheckOut.CustomImages.Image = global::HotelManagementSystem.Properties.Resources.check_out1;
            this.btn_CheckOut.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_CheckOut.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_CheckOut.CustomImages.Parent = this.btn_CheckOut;
            this.guna2Transition1.SetDecoration(this.btn_CheckOut, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_CheckOut.FillColor = System.Drawing.Color.Empty;
            this.btn_CheckOut.FillColor2 = System.Drawing.Color.Empty;
            this.btn_CheckOut.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CheckOut.ForeColor = System.Drawing.Color.White;
            this.btn_CheckOut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btn_CheckOut.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btn_CheckOut.HoverState.Parent = this.btn_CheckOut;
            this.btn_CheckOut.Location = new System.Drawing.Point(0, 289);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.ShadowDecoration.Parent = this.btn_CheckOut;
            this.btn_CheckOut.Size = new System.Drawing.Size(213, 45);
            this.btn_CheckOut.TabIndex = 2;
            this.btn_CheckOut.Text = "Выселение";
            this.btn_CheckOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_CheckOut.TextOffset = new System.Drawing.Point(50, 0);
            this.btn_CheckOut.UseTransparentBackground = true;
            this.btn_CheckOut.Click += new System.EventHandler(this.btn_CheckOut_Click);
            // 
            // btn_CustReg
            // 
            this.btn_CustReg.Animated = true;
            this.btn_CustReg.BackColor = System.Drawing.Color.Transparent;
            this.btn_CustReg.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_CustReg.CheckedState.Parent = this.btn_CustReg;
            this.btn_CustReg.CustomImages.Image = global::HotelManagementSystem.Properties.Resources.customer_registration1;
            this.btn_CustReg.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_CustReg.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_CustReg.CustomImages.Parent = this.btn_CustReg;
            this.guna2Transition1.SetDecoration(this.btn_CustReg, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_CustReg.FillColor = System.Drawing.Color.Empty;
            this.btn_CustReg.FillColor2 = System.Drawing.Color.Empty;
            this.btn_CustReg.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btn_CustReg.ForeColor = System.Drawing.Color.White;
            this.btn_CustReg.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btn_CustReg.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btn_CustReg.HoverState.Parent = this.btn_CustReg;
            this.btn_CustReg.Location = new System.Drawing.Point(0, 238);
            this.btn_CustReg.Name = "btn_CustReg";
            this.btn_CustReg.ShadowDecoration.Parent = this.btn_CustReg;
            this.btn_CustReg.Size = new System.Drawing.Size(213, 45);
            this.btn_CustReg.TabIndex = 1;
            this.btn_CustReg.Text = "Регистрация гостей";
            this.btn_CustReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_CustReg.TextOffset = new System.Drawing.Point(50, 0);
            this.btn_CustReg.UseTransparentBackground = true;
            this.btn_CustReg.Click += new System.EventHandler(this.btn_CustReg_Click);
            // 
            // btn_AddRoom
            // 
            this.btn_AddRoom.Animated = true;
            this.btn_AddRoom.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_AddRoom.CheckedState.Parent = this.btn_AddRoom;
            this.btn_AddRoom.CustomImages.Image = global::HotelManagementSystem.Properties.Resources.add_room1;
            this.btn_AddRoom.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AddRoom.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_AddRoom.CustomImages.Parent = this.btn_AddRoom;
            this.guna2Transition1.SetDecoration(this.btn_AddRoom, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_AddRoom.FillColor = System.Drawing.Color.Empty;
            this.btn_AddRoom.FillColor2 = System.Drawing.Color.Empty;
            this.btn_AddRoom.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btn_AddRoom.ForeColor = System.Drawing.Color.White;
            this.btn_AddRoom.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btn_AddRoom.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btn_AddRoom.HoverState.Parent = this.btn_AddRoom;
            this.btn_AddRoom.Location = new System.Drawing.Point(0, 187);
            this.btn_AddRoom.Name = "btn_AddRoom";
            this.btn_AddRoom.ShadowDecoration.Parent = this.btn_AddRoom;
            this.btn_AddRoom.Size = new System.Drawing.Size(213, 45);
            this.btn_AddRoom.TabIndex = 0;
            this.btn_AddRoom.Text = "Добавить комнату";
            this.btn_AddRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AddRoom.TextOffset = new System.Drawing.Point(50, 0);
            this.btn_AddRoom.UseTransparentBackground = true;
            this.btn_AddRoom.Click += new System.EventHandler(this.btn_AddRoom_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.guna2Transition1.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1244, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 29);
            this.guna2ControlBox1.TabIndex = 25;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2Transition1.SetDecoration(this.guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1204, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(34, 29);
            this.guna2ControlBox2.TabIndex = 24;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizBlind;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            this.guna2Transition1.MaxAnimationTime = 2500;
            // 
            // ucCheckOut1
            // 
            this.ucCheckOut1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.guna2Transition1.SetDecoration(this.ucCheckOut1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ucCheckOut1.Location = new System.Drawing.Point(246, 47);
            this.ucCheckOut1.Name = "ucCheckOut1";
            this.ucCheckOut1.Size = new System.Drawing.Size(1032, 567);
            this.ucCheckOut1.TabIndex = 28;
            // 
            // ucCustomerRegistration1
            // 
            this.ucCustomerRegistration1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.guna2Transition1.SetDecoration(this.ucCustomerRegistration1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ucCustomerRegistration1.Location = new System.Drawing.Point(246, 47);
            this.ucCustomerRegistration1.Name = "ucCustomerRegistration1";
            this.ucCustomerRegistration1.Size = new System.Drawing.Size(1032, 567);
            this.ucCustomerRegistration1.TabIndex = 27;
            // 
            // ucAddRoom1
            // 
            this.ucAddRoom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.guna2Transition1.SetDecoration(this.ucAddRoom1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ucAddRoom1.ForeColor = System.Drawing.Color.White;
            this.ucAddRoom1.Location = new System.Drawing.Point(246, 47);
            this.ucAddRoom1.Name = "ucAddRoom1";
            this.ucAddRoom1.Size = new System.Drawing.Size(1032, 567);
            this.ucAddRoom1.TabIndex = 26;
            // 
            // ucCustDetails1
            // 
            this.ucCustDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.guna2Transition1.SetDecoration(this.ucCustDetails1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ucCustDetails1.Location = new System.Drawing.Point(246, 47);
            this.ucCustDetails1.Name = "ucCustDetails1";
            this.ucCustDetails1.Size = new System.Drawing.Size(1032, 567);
            this.ucCustDetails1.TabIndex = 29;
            // 
            // ucEmployee1
            // 
            this.ucEmployee1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.guna2Transition1.SetDecoration(this.ucEmployee1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ucEmployee1.Location = new System.Drawing.Point(246, 47);
            this.ucEmployee1.Name = "ucEmployee1";
            this.ucEmployee1.Size = new System.Drawing.Size(1032, 567);
            this.ucEmployee1.TabIndex = 30;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1290, 624);
            this.Controls.Add(this.ucEmployee1);
            this.Controls.Add(this.ucCustDetails1);
            this.Controls.Add(this.ucCheckOut1);
            this.Controls.Add(this.ucCustomerRegistration1);
            this.Controls.Add(this.ucAddRoom1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2Panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btn_show;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Employee;
        private Guna.UI2.WinForms.Guna2GradientButton btn_CustInfo;
        private Guna.UI2.WinForms.Guna2GradientButton btn_CheckOut;
        private Guna.UI2.WinForms.Guna2GradientButton btn_CustReg;
        private Guna.UI2.WinForms.Guna2GradientButton btn_AddRoom;
        private Guna.UI2.WinForms.Guna2CircleButton btn_hide;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private UserControls.UCAddRoom ucAddRoom1;
        private UserControls.UCCustomerRegistration ucCustomerRegistration1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private UserControls.UCCheckOut ucCheckOut1;
        private UserControls.UCCustDetails ucCustDetails1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private UserControls.UCEmployee ucEmployee1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
    }
}