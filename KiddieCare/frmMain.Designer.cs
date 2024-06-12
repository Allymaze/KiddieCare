namespace KiddieCare
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statementOfAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDiscount = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDownpay = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMaintenance = new System.Windows.Forms.TabPage();
            this.toolMain = new System.Windows.Forms.ToolStrip();
            this.btnUserSetting = new System.Windows.Forms.ToolStripButton();
            this.btnAddSecurity = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddYear = new System.Windows.Forms.ToolStripButton();
            this.btnAddLvl = new System.Windows.Forms.ToolStripButton();
            this.btnAddSection = new System.Windows.Forms.ToolStripButton();
            this.btnFee = new System.Windows.Forms.ToolStripButton();
            this.btnAddRoom = new System.Windows.Forms.ToolStripButton();
            this.btnTime = new System.Windows.Forms.ToolStripButton();
            this.btnAddSubject = new System.Windows.Forms.ToolStripButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddStudent = new System.Windows.Forms.ToolStripButton();
            this.btnAddTeacher = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEnroll = new System.Windows.Forms.ToolStripButton();
            this.btnBill = new System.Windows.Forms.ToolStripButton();
            this.btnSAccount = new System.Windows.Forms.ToolStripButton();
            this.Enrollment = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabMaintenance.SuspendLayout();
            this.toolMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.Enrollment.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.HotPink;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.systemUserToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.viewRecordsToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            this.fileToolStripMenuItem.MouseEnter += new System.EventHandler(this.fileToolStripMenuItem_MouseEnter);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("signOutToolStripMenuItem.Image")));
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.signOutToolStripMenuItem.Text = "Sign out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::KiddieCare.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // systemUserToolStripMenuItem
            // 
            this.systemUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userSettingsToolStripMenuItem});
            this.systemUserToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemUserToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.systemUserToolStripMenuItem.Name = "systemUserToolStripMenuItem";
            this.systemUserToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.systemUserToolStripMenuItem.Text = "System user";
            // 
            // userSettingsToolStripMenuItem
            // 
            this.userSettingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userSettingsToolStripMenuItem.Image")));
            this.userSettingsToolStripMenuItem.Name = "userSettingsToolStripMenuItem";
            this.userSettingsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.userSettingsToolStripMenuItem.Text = "User Settings";
            this.userSettingsToolStripMenuItem.Click += new System.EventHandler(this.userSettingsToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentEntryToolStripMenuItem,
            this.teacherEntryToolStripMenuItem,
            this.scheduleToolStripMenuItem,
            this.billingToolStripMenuItem,
            this.statementOfAccountToolStripMenuItem});
            this.transactionToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // studentEntryToolStripMenuItem
            // 
            this.studentEntryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentEntryToolStripMenuItem.Image")));
            this.studentEntryToolStripMenuItem.Name = "studentEntryToolStripMenuItem";
            this.studentEntryToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.studentEntryToolStripMenuItem.Text = "Add student";
            this.studentEntryToolStripMenuItem.Click += new System.EventHandler(this.studentEntryToolStripMenuItem_Click);
            // 
            // teacherEntryToolStripMenuItem
            // 
            this.teacherEntryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("teacherEntryToolStripMenuItem.Image")));
            this.teacherEntryToolStripMenuItem.Name = "teacherEntryToolStripMenuItem";
            this.teacherEntryToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.teacherEntryToolStripMenuItem.Text = "Add teacher";
            this.teacherEntryToolStripMenuItem.Click += new System.EventHandler(this.teacherEntryToolStripMenuItem_Click);
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("scheduleToolStripMenuItem.Image")));
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.scheduleToolStripMenuItem.Text = "Enroll";
            this.scheduleToolStripMenuItem.Click += new System.EventHandler(this.scheduleToolStripMenuItem_Click);
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("billingToolStripMenuItem.Image")));
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.billingToolStripMenuItem.Text = "Billing";
            this.billingToolStripMenuItem.Click += new System.EventHandler(this.billingToolStripMenuItem_Click);
            // 
            // statementOfAccountToolStripMenuItem
            // 
            this.statementOfAccountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("statementOfAccountToolStripMenuItem.Image")));
            this.statementOfAccountToolStripMenuItem.Name = "statementOfAccountToolStripMenuItem";
            this.statementOfAccountToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.statementOfAccountToolStripMenuItem.Text = "Statement of Account";
            this.statementOfAccountToolStripMenuItem.Click += new System.EventHandler(this.statementOfAccountToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDiscount,
            this.toolDownpay,
            this.schoolYearToolStripMenuItem});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // toolDiscount
            // 
            this.toolDiscount.Image = ((System.Drawing.Image)(resources.GetObject("toolDiscount.Image")));
            this.toolDiscount.Name = "toolDiscount";
            this.toolDiscount.Size = new System.Drawing.Size(224, 26);
            this.toolDiscount.Text = "Discount";
            this.toolDiscount.Click += new System.EventHandler(this.discountToolStripMenuItem_Click);
            // 
            // toolDownpay
            // 
            this.toolDownpay.Image = ((System.Drawing.Image)(resources.GetObject("toolDownpay.Image")));
            this.toolDownpay.Name = "toolDownpay";
            this.toolDownpay.Size = new System.Drawing.Size(224, 26);
            this.toolDownpay.Text = "Downpayment";
            this.toolDownpay.Click += new System.EventHandler(this.downpaymentToolStripMenuItem_Click);
            // 
            // schoolYearToolStripMenuItem
            // 
            this.schoolYearToolStripMenuItem.Name = "schoolYearToolStripMenuItem";
            this.schoolYearToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.schoolYearToolStripMenuItem.Text = "School Year";
            this.schoolYearToolStripMenuItem.Click += new System.EventHandler(this.schoolYearToolStripMenuItem_Click);
            // 
            // viewRecordsToolStripMenuItem
            // 
            this.viewRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentRecordsToolStripMenuItem,
            this.studentScheduleToolStripMenuItem});
            this.viewRecordsToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRecordsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewRecordsToolStripMenuItem.Name = "viewRecordsToolStripMenuItem";
            this.viewRecordsToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.viewRecordsToolStripMenuItem.Text = "View";
            // 
            // studentRecordsToolStripMenuItem
            // 
            this.studentRecordsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentRecordsToolStripMenuItem.Image")));
            this.studentRecordsToolStripMenuItem.Name = "studentRecordsToolStripMenuItem";
            this.studentRecordsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.studentRecordsToolStripMenuItem.Text = "View enrollees";
            this.studentRecordsToolStripMenuItem.Click += new System.EventHandler(this.studentRecordsToolStripMenuItem_Click);
            // 
            // studentScheduleToolStripMenuItem
            // 
            this.studentScheduleToolStripMenuItem.Image = global::KiddieCare.Properties.Resources.aboutus;
            this.studentScheduleToolStripMenuItem.Name = "studentScheduleToolStripMenuItem";
            this.studentScheduleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.studentScheduleToolStripMenuItem.Text = "About us";
            this.studentScheduleToolStripMenuItem.Click += new System.EventHandler(this.studentScheduleToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentListToolStripMenuItem});
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // studentListToolStripMenuItem
            // 
            this.studentListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentListToolStripMenuItem.Image")));
            this.studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            this.studentListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.studentListToolStripMenuItem.Text = "Student list";
            this.studentListToolStripMenuItem.Click += new System.EventHandler(this.studentListToolStripMenuItem_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Location = new System.Drawing.Point(16, 374);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(272, 40);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "mm/dd/yy Time";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.Enrollment);
            this.panel2.Location = new System.Drawing.Point(-231, -121);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1208, 774);
            this.panel2.TabIndex = 15;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Location = new System.Drawing.Point(109, 421);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(72, 32);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 421);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Time:";
            // 
            // tabMaintenance
            // 
            this.tabMaintenance.Controls.Add(this.toolMain);
            this.tabMaintenance.Location = new System.Drawing.Point(4, 30);
            this.tabMaintenance.Margin = new System.Windows.Forms.Padding(4);
            this.tabMaintenance.Name = "tabMaintenance";
            this.tabMaintenance.Padding = new System.Windows.Forms.Padding(4);
            this.tabMaintenance.Size = new System.Drawing.Size(866, 110);
            this.tabMaintenance.TabIndex = 1;
            this.tabMaintenance.Text = "Maintenance";
            this.tabMaintenance.UseVisualStyleBackColor = true;
            // 
            // toolMain
            // 
            this.toolMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolMain.GripMargin = new System.Windows.Forms.Padding(3);
            this.toolMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUserSetting,
            this.btnAddSecurity,
            this.toolStripSeparator5,
            this.btnAddYear,
            this.btnAddLvl,
            this.btnAddSection,
            this.btnFee,
            this.btnAddRoom,
            this.btnTime,
            this.btnAddSubject});
            this.toolMain.Location = new System.Drawing.Point(4, 4);
            this.toolMain.Name = "toolMain";
            this.toolMain.Size = new System.Drawing.Size(858, 102);
            this.toolMain.TabIndex = 1;
            this.toolMain.Text = "toolStrip3";
            // 
            // btnUserSetting
            // 
            this.btnUserSetting.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnUserSetting.Image")));
            this.btnUserSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUserSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUserSetting.Name = "btnUserSetting";
            this.btnUserSetting.Size = new System.Drawing.Size(103, 99);
            this.btnUserSetting.Text = "User settings";
            this.btnUserSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUserSetting.Click += new System.EventHandler(this.btnUserSetting_Click);
            // 
            // btnAddSecurity
            // 
            this.btnAddSecurity.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSecurity.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSecurity.Image")));
            this.btnAddSecurity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddSecurity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddSecurity.Name = "btnAddSecurity";
            this.btnAddSecurity.Size = new System.Drawing.Size(76, 99);
            this.btnAddSecurity.Text = "Security";
            this.btnAddSecurity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddSecurity.Click += new System.EventHandler(this.btnAddSecurity_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 102);
            // 
            // btnAddYear
            // 
            this.btnAddYear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddYear.Image = ((System.Drawing.Image)(resources.GetObject("btnAddYear.Image")));
            this.btnAddYear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddYear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddYear.Name = "btnAddYear";
            this.btnAddYear.Size = new System.Drawing.Size(98, 99);
            this.btnAddYear.Text = "School Year";
            this.btnAddYear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddYear.Click += new System.EventHandler(this.btnAddYear_Click);
            // 
            // btnAddLvl
            // 
            this.btnAddLvl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLvl.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLvl.Image")));
            this.btnAddLvl.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddLvl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddLvl.Name = "btnAddLvl";
            this.btnAddLvl.Size = new System.Drawing.Size(101, 99);
            this.btnAddLvl.Text = "Grade level";
            this.btnAddLvl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddLvl.Click += new System.EventHandler(this.btnAddLvl_Click);
            // 
            // btnAddSection
            // 
            this.btnAddSection.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSection.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSection.Image")));
            this.btnAddSection.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddSection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(76, 99);
            this.btnAddSection.Text = "Section";
            this.btnAddSection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddSection.Click += new System.EventHandler(this.btnAddSection_Click);
            // 
            // btnFee
            // 
            this.btnFee.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFee.Image = ((System.Drawing.Image)(resources.GetObject("btnFee.Image")));
            this.btnFee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFee.Name = "btnFee";
            this.btnFee.Size = new System.Drawing.Size(83, 99);
            this.btnFee.Text = "Tution fee";
            this.btnFee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFee.Click += new System.EventHandler(this.btnFee_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.Image")));
            this.btnAddRoom.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddRoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(76, 99);
            this.btnAddRoom.Text = "Room";
            this.btnAddRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnTime
            // 
            this.btnTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTime.Image = ((System.Drawing.Image)(resources.GetObject("btnTime.Image")));
            this.btnTime.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(115, 99);
            this.btnTime.Text = "Time schedule";
            this.btnTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSubject.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSubject.Image")));
            this.btnAddSubject.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddSubject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(76, 99);
            this.btnAddSubject.Text = "Subject";
            this.btnAddSubject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddSubject.Visible = false;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(866, 110);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Transaction";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.White;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.GripMargin = new System.Windows.Forms.Padding(3);
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btnAddStudent,
            this.btnAddTeacher,
            this.toolStripSeparator3,
            this.btnEnroll,
            this.btnBill,
            this.btnSAccount});
            this.toolStrip2.Location = new System.Drawing.Point(4, 4);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(517, 99);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 99);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.Image")));
            this.btnAddStudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(76, 96);
            this.btnAddStudent.Text = "Student";
            this.btnAddStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeacher.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTeacher.Image")));
            this.btnAddTeacher.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddTeacher.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(76, 96);
            this.btnAddTeacher.Text = "Teacher";
            this.btnAddTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.Color.RoyalBlue;
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 99);
            // 
            // btnEnroll
            // 
            this.btnEnroll.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.Image = ((System.Drawing.Image)(resources.GetObject("btnEnroll.Image")));
            this.btnEnroll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEnroll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(88, 96);
            this.btnEnroll.Text = "Enrollment";
            this.btnEnroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // btnBill
            // 
            this.btnBill.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Image = ((System.Drawing.Image)(resources.GetObject("btnBill.Image")));
            this.btnBill.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(76, 96);
            this.btnBill.Text = "Bill";
            this.btnBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnSAccount
            // 
            this.btnSAccount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnSAccount.Image")));
            this.btnSAccount.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSAccount.Name = "btnSAccount";
            this.btnSAccount.Size = new System.Drawing.Size(174, 96);
            this.btnSAccount.Text = "Statement of Account";
            this.btnSAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSAccount.Click += new System.EventHandler(this.btnSAccount_Click);
            // 
            // Enrollment
            // 
            this.Enrollment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Enrollment.Controls.Add(this.tabPage1);
            this.Enrollment.Controls.Add(this.tabMaintenance);
            this.Enrollment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enrollment.Location = new System.Drawing.Point(231, 153);
            this.Enrollment.Margin = new System.Windows.Forms.Padding(4);
            this.Enrollment.Multiline = true;
            this.Enrollment.Name = "Enrollment";
            this.Enrollment.SelectedIndex = 0;
            this.Enrollment.Size = new System.Drawing.Size(874, 144);
            this.Enrollment.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 664);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Frame";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabMaintenance.ResumeLayout(false);
            this.tabMaintenance.PerformLayout();
            this.toolMain.ResumeLayout(false);
            this.toolMain.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.Enrollment.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentScheduleToolStripMenuItem;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem userSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statementOfAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem toolDiscount;
        public System.Windows.Forms.ToolStripMenuItem toolDownpay;
        private System.Windows.Forms.ToolStripMenuItem schoolYearToolStripMenuItem;
        private System.Windows.Forms.TabControl Enrollment;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAddStudent;
        private System.Windows.Forms.ToolStripButton btnAddTeacher;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnEnroll;
        private System.Windows.Forms.ToolStripButton btnBill;
        private System.Windows.Forms.ToolStripButton btnSAccount;
        public System.Windows.Forms.TabPage tabMaintenance;
        public System.Windows.Forms.ToolStrip toolMain;
        private System.Windows.Forms.ToolStripButton btnUserSetting;
        public System.Windows.Forms.ToolStripButton btnAddSecurity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripButton btnAddYear;
        public System.Windows.Forms.ToolStripButton btnAddLvl;
        public System.Windows.Forms.ToolStripButton btnAddSection;
        public System.Windows.Forms.ToolStripButton btnFee;
        public System.Windows.Forms.ToolStripButton btnAddRoom;
        public System.Windows.Forms.ToolStripButton btnTime;
        public System.Windows.Forms.ToolStripButton btnAddSubject;
    }
}