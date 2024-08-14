namespace Mechanic_Maestro
{
    partial class MechanicMaestro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MechanicMaestro));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.corvetteOnOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl1CustomerInfo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblChooseService = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCustomItem = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxMake = new System.Windows.Forms.TextBox();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.tbxColor = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbxServiceLvl = new System.Windows.Forms.ComboBox();
            this.tbxCustomOpt = new System.Windows.Forms.TextBox();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.lblItemsList = new System.Windows.Forms.Label();
            this.lbxItems = new System.Windows.Forms.ListBox();
            this.buttonRemoveItem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAmountFinance = new System.Windows.Forms.Label();
            this.lblMonthFinance = new System.Windows.Forms.Label();
            this.tbxAmountFinance = new System.Windows.Forms.TextBox();
            this.tbxMonthFinance = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.lbxFinance = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pbxCorvette = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCorvette)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.toolStripSeparator3,
            this.corvetteOnOffToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowColorToolStripMenuItem,
            this.textColorToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // windowColorToolStripMenuItem
            // 
            this.windowColorToolStripMenuItem.Name = "windowColorToolStripMenuItem";
            this.windowColorToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.windowColorToolStripMenuItem.Text = "Window Color";
            this.windowColorToolStripMenuItem.Click += new System.EventHandler(this.windowColorToolStripMenuItem_Click);
            // 
            // textColorToolStripMenuItem
            // 
            this.textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            this.textColorToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.textColorToolStripMenuItem.Text = "Text Color";
            this.textColorToolStripMenuItem.Click += new System.EventHandler(this.textColorToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.fontToolStripMenuItem.Text = "Change Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
            // 
            // corvetteOnOffToolStripMenuItem
            // 
            this.corvetteOnOffToolStripMenuItem.CheckOnClick = true;
            this.corvetteOnOffToolStripMenuItem.Name = "corvetteOnOffToolStripMenuItem";
            this.corvetteOnOffToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.corvetteOnOffToolStripMenuItem.Text = "Corvette On/Off";
            this.corvetteOnOffToolStripMenuItem.CheckedChanged += new System.EventHandler(this.corvetteOnOffToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lbl1CustomerInfo
            // 
            this.lbl1CustomerInfo.AutoSize = true;
            this.lbl1CustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1CustomerInfo.Location = new System.Drawing.Point(12, 55);
            this.lbl1CustomerInfo.Name = "lbl1CustomerInfo";
            this.lbl1CustomerInfo.Size = new System.Drawing.Size(287, 24);
            this.lbl1CustomerInfo.TabIndex = 2;
            this.lbl1CustomerInfo.Text = "1. Enter Customer Information";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "&Name:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(12, 223);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(50, 20);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "&Color:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(12, 182);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(56, 20);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "M&odel:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(12, 141);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(52, 20);
            this.lblMake.TabIndex = 6;
            this.lblMake.Text = "&Make:";
            // 
            // lblChooseService
            // 
            this.lblChooseService.AutoSize = true;
            this.lblChooseService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseService.Location = new System.Drawing.Point(12, 306);
            this.lblChooseService.Name = "lblChooseService";
            this.lblChooseService.Size = new System.Drawing.Size(254, 24);
            this.lblChooseService.TabIndex = 7;
            this.lblChooseService.Text = "2. Choose a Service Level";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 264);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date:";
            // 
            // lblCustomItem
            // 
            this.lblCustomItem.AutoSize = true;
            this.lblCustomItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomItem.Location = new System.Drawing.Point(12, 412);
            this.lblCustomItem.Name = "lblCustomItem";
            this.lblCustomItem.Size = new System.Drawing.Size(231, 24);
            this.lblCustomItem.TabIndex = 9;
            this.lblCustomItem.Text = "3. Add Customized Item";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(69, 102);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(230, 20);
            this.tbxName.TabIndex = 10;
            // 
            // tbxMake
            // 
            this.tbxMake.Location = new System.Drawing.Point(69, 143);
            this.tbxMake.Name = "tbxMake";
            this.tbxMake.Size = new System.Drawing.Size(230, 20);
            this.tbxMake.TabIndex = 11;
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(69, 182);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(230, 20);
            this.tbxModel.TabIndex = 12;
            // 
            // tbxColor
            // 
            this.tbxColor.Location = new System.Drawing.Point(69, 223);
            this.tbxColor.Name = "tbxColor";
            this.tbxColor.Size = new System.Drawing.Size(230, 20);
            this.tbxColor.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 263);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // cbxServiceLvl
            // 
            this.cbxServiceLvl.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "Basic",
            "Bronze",
            "Silver",
            "Gold"});
            this.cbxServiceLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxServiceLvl.FormattingEnabled = true;
            this.cbxServiceLvl.Items.AddRange(new object[] {
            "None",
            "Basic",
            "Bronze",
            "Silver",
            "Gold"});
            this.cbxServiceLvl.Location = new System.Drawing.Point(16, 357);
            this.cbxServiceLvl.Name = "cbxServiceLvl";
            this.cbxServiceLvl.Size = new System.Drawing.Size(283, 21);
            this.cbxServiceLvl.TabIndex = 15;
            this.cbxServiceLvl.SelectedIndexChanged += new System.EventHandler(this.cbxServiceLvl_SelectedIndexChanged);
            // 
            // tbxCustomOpt
            // 
            this.tbxCustomOpt.Location = new System.Drawing.Point(16, 464);
            this.tbxCustomOpt.Multiline = true;
            this.tbxCustomOpt.Name = "tbxCustomOpt";
            this.tbxCustomOpt.Size = new System.Drawing.Size(283, 22);
            this.tbxCustomOpt.TabIndex = 16;
            this.tbxCustomOpt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(16, 532);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(283, 33);
            this.buttonAddItem.TabIndex = 17;
            this.buttonAddItem.Text = "Add Item";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            this.buttonAddItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buttonAddItem_KeyUp);
            // 
            // lblItemsList
            // 
            this.lblItemsList.AutoSize = true;
            this.lblItemsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsList.Location = new System.Drawing.Point(411, 55);
            this.lblItemsList.Name = "lblItemsList";
            this.lblItemsList.Size = new System.Drawing.Size(216, 24);
            this.lblItemsList.TabIndex = 18;
            this.lblItemsList.Text = "Items Left to Complete";
            // 
            // lbxItems
            // 
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.Location = new System.Drawing.Point(360, 102);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.Size = new System.Drawing.Size(311, 407);
            this.lbxItems.TabIndex = 19;
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveItem.ForeColor = System.Drawing.Color.Green;
            this.buttonRemoveItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveItem.Image")));
            this.buttonRemoveItem.Location = new System.Drawing.Point(360, 532);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(311, 33);
            this.buttonRemoveItem.TabIndex = 20;
            this.buttonRemoveItem.Text = "Remove Item From List";
            this.buttonRemoveItem.UseVisualStyleBackColor = true;
            this.buttonRemoveItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.Location = new System.Drawing.Point(318, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 510);
            this.button2.TabIndex = 21;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SeaGreen;
            this.button3.Location = new System.Drawing.Point(692, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 510);
            this.button3.TabIndex = 22;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(837, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Financing";
            // 
            // lblAmountFinance
            // 
            this.lblAmountFinance.AutoSize = true;
            this.lblAmountFinance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountFinance.Location = new System.Drawing.Point(720, 102);
            this.lblAmountFinance.Name = "lblAmountFinance";
            this.lblAmountFinance.Size = new System.Drawing.Size(148, 20);
            this.lblAmountFinance.TabIndex = 24;
            this.lblAmountFinance.Text = "&Amount to Finance:";
            // 
            // lblMonthFinance
            // 
            this.lblMonthFinance.AutoSize = true;
            this.lblMonthFinance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthFinance.Location = new System.Drawing.Point(723, 141);
            this.lblMonthFinance.Name = "lblMonthFinance";
            this.lblMonthFinance.Size = new System.Drawing.Size(145, 20);
            this.lblMonthFinance.TabIndex = 25;
            this.lblMonthFinance.Text = "Months to &Finance:";
            // 
            // tbxAmountFinance
            // 
            this.tbxAmountFinance.Location = new System.Drawing.Point(874, 102);
            this.tbxAmountFinance.Name = "tbxAmountFinance";
            this.tbxAmountFinance.Size = new System.Drawing.Size(173, 20);
            this.tbxAmountFinance.TabIndex = 26;
            // 
            // tbxMonthFinance
            // 
            this.tbxMonthFinance.Location = new System.Drawing.Point(874, 141);
            this.tbxMonthFinance.Name = "tbxMonthFinance";
            this.tbxMonthFinance.Size = new System.Drawing.Size(173, 20);
            this.tbxMonthFinance.TabIndex = 27;
            // 
            // buttonClear
            // 
            this.buttonClear.ForeColor = System.Drawing.Color.Red;
            this.buttonClear.Location = new System.Drawing.Point(727, 182);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 28;
            this.buttonClear.Text = "Clear";
            this.buttonClear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(874, 174);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(173, 38);
            this.buttonCalculate.TabIndex = 29;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // lbxFinance
            // 
            this.lbxFinance.FormattingEnabled = true;
            this.lbxFinance.Location = new System.Drawing.Point(727, 223);
            this.lbxFinance.Name = "lbxFinance";
            this.lbxFinance.Size = new System.Drawing.Size(320, 342);
            this.lbxFinance.TabIndex = 30;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "mech";
            this.saveFileDialog1.Filter = "Text File (*.txt)|*.txt|All Files|*.*";
            this.saveFileDialog1.Title = "Save As...";
            // 
            // pbxCorvette
            // 
            this.pbxCorvette.Image = ((System.Drawing.Image)(resources.GetObject("pbxCorvette.Image")));
            this.pbxCorvette.Location = new System.Drawing.Point(0, 27);
            this.pbxCorvette.Name = "pbxCorvette";
            this.pbxCorvette.Size = new System.Drawing.Size(1066, 571);
            this.pbxCorvette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCorvette.TabIndex = 31;
            this.pbxCorvette.TabStop = false;
            // 
            // MechanicMaestro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 599);
            this.Controls.Add(this.lbxFinance);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.tbxMonthFinance);
            this.Controls.Add(this.tbxAmountFinance);
            this.Controls.Add(this.lblMonthFinance);
            this.Controls.Add(this.lblAmountFinance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonRemoveItem);
            this.Controls.Add(this.lbxItems);
            this.Controls.Add(this.lblItemsList);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.tbxCustomOpt);
            this.Controls.Add(this.cbxServiceLvl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbxColor);
            this.Controls.Add(this.tbxModel);
            this.Controls.Add(this.tbxMake);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblCustomItem);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblChooseService);
            this.Controls.Add(this.lbl1CustomerInfo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbxCorvette);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MechanicMaestro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mechanic Maestro v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MechanicMaestro_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MechanicMaestro_FormClosed);
            this.Load += new System.EventHandler(this.MechanicMaestro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCorvette)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lbl1CustomerInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblChooseService;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCustomItem;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxMake;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.TextBox tbxColor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbxServiceLvl;
        private System.Windows.Forms.TextBox tbxCustomOpt;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Label lblItemsList;
        private System.Windows.Forms.ListBox lbxItems;
        private System.Windows.Forms.Button buttonRemoveItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAmountFinance;
        private System.Windows.Forms.Label lblMonthFinance;
        private System.Windows.Forms.TextBox tbxAmountFinance;
        private System.Windows.Forms.TextBox tbxMonthFinance;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ListBox lbxFinance;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PictureBox pbxCorvette;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem corvetteOnOffToolStripMenuItem;
    }
}

