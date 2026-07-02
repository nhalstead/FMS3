namespace FMS3
{
	partial class MainWindow
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
            components = new System.ComponentModel.Container();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabSetup = new System.Windows.Forms.TabPage();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            checkBeepForButtonPressed = new System.Windows.Forms.CheckBox();
            buttonToggleFreeDrive = new System.Windows.Forms.Button();
            comboBrick3 = new System.Windows.Forms.ComboBox();
            comboType3 = new System.Windows.Forms.ComboBox();
            textJoystickAlias3 = new System.Windows.Forms.TextBox();
            guidLabel3 = new System.Windows.Forms.Label();
            comboBrick2 = new System.Windows.Forms.ComboBox();
            comboType2 = new System.Windows.Forms.ComboBox();
            textJoystickAlias2 = new System.Windows.Forms.TextBox();
            guidLabel2 = new System.Windows.Forms.Label();
            comboBrick1 = new System.Windows.Forms.ComboBox();
            comboType1 = new System.Windows.Forms.ComboBox();
            textJoystickAlias1 = new System.Windows.Forms.TextBox();
            guidLabel1 = new System.Windows.Forms.Label();
            comboBrick0 = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            buttonUpdateBricks = new System.Windows.Forms.Button();
            spacer1 = new System.Windows.Forms.Label();
            comboAllBrick = new System.Windows.Forms.ComboBox();
            buttonConnectBrick = new System.Windows.Forms.Button();
            guidLabel0 = new System.Windows.Forms.Label();
            textJoystickAlias0 = new System.Windows.Forms.TextBox();
            comboType0 = new System.Windows.Forms.ComboBox();
            buttonUpdateJoysticks = new System.Windows.Forms.Button();
            buttonClearBricksFromPairs = new System.Windows.Forms.Button();
            tabMatch = new System.Windows.Forms.TabPage();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            checkShowChildWindow = new System.Windows.Forms.CheckBox();
            textTeleTime = new System.Windows.Forms.TextBox();
            textAutoTime = new System.Windows.Forms.TextBox();
            checkPauseBetween = new System.Windows.Forms.CheckBox();
            checkTeleoperated = new System.Windows.Forms.CheckBox();
            checkAutonomous = new System.Windows.Forms.CheckBox();
            buttonAbort = new System.Windows.Forms.Button();
            buttonStartPause = new System.Windows.Forms.Button();
            timerLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            modeLabel = new System.Windows.Forms.Label();
            timer = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabSetup.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tabMatch.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabSetup);
            tabControl1.Controls.Add(tabMatch);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(731, 629);
            tabControl1.TabIndex = 0;
            // 
            // tabSetup
            // 
            tabSetup.Controls.Add(tableLayoutPanel1);
            tabSetup.Location = new System.Drawing.Point(4, 29);
            tabSetup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabSetup.Name = "tabSetup";
            tabSetup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabSetup.Size = new System.Drawing.Size(723, 596);
            tabSetup.TabIndex = 0;
            tabSetup.Text = "Setup";
            tabSetup.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(label4, 2, 3);
            tableLayoutPanel1.Controls.Add(label3, 1, 3);
            tableLayoutPanel1.Controls.Add(checkBeepForButtonPressed, 0, 8);
            tableLayoutPanel1.Controls.Add(buttonToggleFreeDrive, 3, 8);
            tableLayoutPanel1.Controls.Add(comboBrick3, 3, 7);
            tableLayoutPanel1.Controls.Add(comboType3, 2, 7);
            tableLayoutPanel1.Controls.Add(textJoystickAlias3, 1, 7);
            tableLayoutPanel1.Controls.Add(guidLabel3, 0, 7);
            tableLayoutPanel1.Controls.Add(comboBrick2, 3, 6);
            tableLayoutPanel1.Controls.Add(comboType2, 2, 6);
            tableLayoutPanel1.Controls.Add(textJoystickAlias2, 1, 6);
            tableLayoutPanel1.Controls.Add(guidLabel2, 0, 6);
            tableLayoutPanel1.Controls.Add(comboBrick1, 3, 5);
            tableLayoutPanel1.Controls.Add(comboType1, 2, 5);
            tableLayoutPanel1.Controls.Add(textJoystickAlias1, 1, 5);
            tableLayoutPanel1.Controls.Add(guidLabel1, 0, 5);
            tableLayoutPanel1.Controls.Add(comboBrick0, 3, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(guidLabel0, 0, 4);
            tableLayoutPanel1.Controls.Add(textJoystickAlias0, 1, 4);
            tableLayoutPanel1.Controls.Add(comboType0, 2, 4);
            tableLayoutPanel1.Controls.Add(buttonUpdateJoysticks, 0, 3);
            tableLayoutPanel1.Controls.Add(buttonClearBricksFromPairs, 3, 3);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new System.Drawing.Size(717, 588);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(368, 204);
            label4.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(159, 16);
            label4.TabIndex = 37;
            label4.Text = "Joystick types";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(189, 204);
            label3.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(159, 16);
            label3.TabIndex = 36;
            label3.Text = "Joystick labels";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBeepForButtonPressed
            // 
            checkBeepForButtonPressed.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            checkBeepForButtonPressed.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(checkBeepForButtonPressed, 2);
            checkBeepForButtonPressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBeepForButtonPressed.Location = new System.Drawing.Point(10, 476);
            checkBeepForButtonPressed.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            checkBeepForButtonPressed.Name = "checkBeepForButtonPressed";
            checkBeepForButtonPressed.Size = new System.Drawing.Size(338, 34);
            checkBeepForButtonPressed.TabIndex = 35;
            checkBeepForButtonPressed.Text = "Beep for button presses";
            checkBeepForButtonPressed.UseVisualStyleBackColor = true;
            checkBeepForButtonPressed.CheckedChanged += checkBox_beepWhenButtonPressed;
            // 
            // buttonToggleFreeDrive
            // 
            buttonToggleFreeDrive.AutoSize = true;
            buttonToggleFreeDrive.Dock = System.Windows.Forms.DockStyle.Top;
            buttonToggleFreeDrive.Location = new System.Drawing.Point(540, 468);
            buttonToggleFreeDrive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonToggleFreeDrive.Name = "buttonToggleFreeDrive";
            buttonToggleFreeDrive.Size = new System.Drawing.Size(174, 40);
            buttonToggleFreeDrive.TabIndex = 34;
            buttonToggleFreeDrive.Text = "Toggle free-drive mode";
            buttonToggleFreeDrive.UseVisualStyleBackColor = true;
            buttonToggleFreeDrive.Click += buttonToggleFreeDrive_Click;
            // 
            // comboBrick3
            // 
            comboBrick3.Dock = System.Windows.Forms.DockStyle.Fill;
            comboBrick3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBrick3.FormattingEnabled = true;
            comboBrick3.Location = new System.Drawing.Point(547, 418);
            comboBrick3.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            comboBrick3.Name = "comboBrick3";
            comboBrick3.Size = new System.Drawing.Size(160, 28);
            comboBrick3.TabIndex = 21;
            comboBrick3.SelectedIndexChanged += comboBrick3_SelectedIndexChanged;
            // 
            // comboType3
            // 
            comboType3.Dock = System.Windows.Forms.DockStyle.Fill;
            comboType3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboType3.FormattingEnabled = true;
            comboType3.Location = new System.Drawing.Point(368, 418);
            comboType3.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            comboType3.Name = "comboType3";
            comboType3.Size = new System.Drawing.Size(159, 28);
            comboType3.TabIndex = 20;
            comboType3.SelectedIndexChanged += comboType3_SelectedIndexChanged;
            // 
            // textJoystickAlias3
            // 
            textJoystickAlias3.Dock = System.Windows.Forms.DockStyle.Fill;
            textJoystickAlias3.Location = new System.Drawing.Point(189, 418);
            textJoystickAlias3.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            textJoystickAlias3.Name = "textJoystickAlias3";
            textJoystickAlias3.Size = new System.Drawing.Size(159, 27);
            textJoystickAlias3.TabIndex = 19;
            textJoystickAlias3.Text = "4";
            textJoystickAlias3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guidLabel3
            // 
            guidLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            guidLabel3.AutoSize = true;
            guidLabel3.BackColor = System.Drawing.Color.Gold;
            guidLabel3.Location = new System.Drawing.Point(10, 418);
            guidLabel3.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            guidLabel3.Name = "guidLabel3";
            guidLabel3.Size = new System.Drawing.Size(159, 34);
            guidLabel3.TabIndex = 18;
            guidLabel3.Text = "GUID";
            guidLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBrick2
            // 
            comboBrick2.Dock = System.Windows.Forms.DockStyle.Fill;
            comboBrick2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBrick2.FormattingEnabled = true;
            comboBrick2.Location = new System.Drawing.Point(547, 360);
            comboBrick2.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            comboBrick2.Name = "comboBrick2";
            comboBrick2.Size = new System.Drawing.Size(160, 28);
            comboBrick2.TabIndex = 17;
            comboBrick2.SelectedIndexChanged += comboBrick2_SelectedIndexChanged;
            // 
            // comboType2
            // 
            comboType2.Dock = System.Windows.Forms.DockStyle.Fill;
            comboType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboType2.FormattingEnabled = true;
            comboType2.Location = new System.Drawing.Point(368, 360);
            comboType2.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            comboType2.Name = "comboType2";
            comboType2.Size = new System.Drawing.Size(159, 28);
            comboType2.TabIndex = 16;
            comboType2.SelectedIndexChanged += comboType2_SelectedIndexChanged;
            // 
            // textJoystickAlias2
            // 
            textJoystickAlias2.Dock = System.Windows.Forms.DockStyle.Fill;
            textJoystickAlias2.Location = new System.Drawing.Point(189, 360);
            textJoystickAlias2.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            textJoystickAlias2.Name = "textJoystickAlias2";
            textJoystickAlias2.Size = new System.Drawing.Size(159, 27);
            textJoystickAlias2.TabIndex = 15;
            textJoystickAlias2.Text = "3";
            textJoystickAlias2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guidLabel2
            // 
            guidLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            guidLabel2.AutoSize = true;
            guidLabel2.BackColor = System.Drawing.Color.Gold;
            guidLabel2.Location = new System.Drawing.Point(10, 360);
            guidLabel2.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            guidLabel2.Name = "guidLabel2";
            guidLabel2.Size = new System.Drawing.Size(159, 34);
            guidLabel2.TabIndex = 14;
            guidLabel2.Text = "GUID";
            guidLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBrick1
            // 
            comboBrick1.Dock = System.Windows.Forms.DockStyle.Fill;
            comboBrick1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBrick1.FormattingEnabled = true;
            comboBrick1.Location = new System.Drawing.Point(547, 302);
            comboBrick1.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            comboBrick1.Name = "comboBrick1";
            comboBrick1.Size = new System.Drawing.Size(160, 28);
            comboBrick1.TabIndex = 13;
            comboBrick1.SelectedIndexChanged += comboBrick1_SelectedIndexChanged;
            // 
            // comboType1
            // 
            comboType1.Dock = System.Windows.Forms.DockStyle.Fill;
            comboType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboType1.FormattingEnabled = true;
            comboType1.Location = new System.Drawing.Point(368, 302);
            comboType1.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            comboType1.Name = "comboType1";
            comboType1.Size = new System.Drawing.Size(159, 28);
            comboType1.TabIndex = 12;
            comboType1.SelectedIndexChanged += comboType1_SelectedIndexChanged;
            // 
            // textJoystickAlias1
            // 
            textJoystickAlias1.Dock = System.Windows.Forms.DockStyle.Fill;
            textJoystickAlias1.Location = new System.Drawing.Point(189, 302);
            textJoystickAlias1.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            textJoystickAlias1.Name = "textJoystickAlias1";
            textJoystickAlias1.Size = new System.Drawing.Size(159, 27);
            textJoystickAlias1.TabIndex = 11;
            textJoystickAlias1.Text = "2";
            textJoystickAlias1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guidLabel1
            // 
            guidLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            guidLabel1.AutoSize = true;
            guidLabel1.BackColor = System.Drawing.Color.Gold;
            guidLabel1.Location = new System.Drawing.Point(10, 302);
            guidLabel1.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            guidLabel1.Name = "guidLabel1";
            guidLabel1.Size = new System.Drawing.Size(159, 34);
            guidLabel1.TabIndex = 10;
            guidLabel1.Text = "GUID";
            guidLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBrick0
            // 
            comboBrick0.Dock = System.Windows.Forms.DockStyle.Fill;
            comboBrick0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBrick0.FormattingEnabled = true;
            comboBrick0.Location = new System.Drawing.Point(547, 244);
            comboBrick0.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            comboBrick0.Name = "comboBrick0";
            comboBrick0.Size = new System.Drawing.Size(160, 28);
            comboBrick0.TabIndex = 9;
            comboBrick0.SelectedIndexChanged += comboBrick0_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label2, 4);
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(3, 116);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(711, 58);
            label2.TabIndex = 4;
            label2.Text = "USB Joysticks and Teams";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 4);
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(711, 58);
            label1.TabIndex = 0;
            label1.Text = "Bluetooth-Connected Bricks";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 4);
            flowLayoutPanel1.Controls.Add(buttonUpdateBricks);
            flowLayoutPanel1.Controls.Add(spacer1);
            flowLayoutPanel1.Controls.Add(comboAllBrick);
            flowLayoutPanel1.Controls.Add(buttonConnectBrick);
            flowLayoutPanel1.Location = new System.Drawing.Point(3, 62);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(709, 49);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // buttonUpdateBricks
            // 
            buttonUpdateBricks.AutoSize = true;
            buttonUpdateBricks.Location = new System.Drawing.Point(3, 4);
            buttonUpdateBricks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonUpdateBricks.Name = "buttonUpdateBricks";
            buttonUpdateBricks.Size = new System.Drawing.Size(126, 40);
            buttonUpdateBricks.TabIndex = 1;
            buttonUpdateBricks.Text = "Update bricks";
            buttonUpdateBricks.UseVisualStyleBackColor = true;
            buttonUpdateBricks.Click += buttonUpdateBricks_Click;
            // 
            // spacer1
            // 
            spacer1.AutoSize = true;
            spacer1.Location = new System.Drawing.Point(135, 0);
            spacer1.Name = "spacer1";
            spacer1.Size = new System.Drawing.Size(21, 20);
            spacer1.TabIndex = 4;
            spacer1.Text = "   ";
            // 
            // comboAllBrick
            // 
            comboAllBrick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboAllBrick.FormattingEnabled = true;
            comboAllBrick.Location = new System.Drawing.Point(162, 4);
            comboAllBrick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboAllBrick.MaxDropDownItems = 20;
            comboAllBrick.Name = "comboAllBrick";
            comboAllBrick.Size = new System.Drawing.Size(217, 28);
            comboAllBrick.Sorted = true;
            comboAllBrick.TabIndex = 2;
            comboAllBrick.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonConnectBrick
            // 
            buttonConnectBrick.AutoSize = true;
            buttonConnectBrick.Location = new System.Drawing.Point(385, 4);
            buttonConnectBrick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonConnectBrick.Name = "buttonConnectBrick";
            buttonConnectBrick.Size = new System.Drawing.Size(105, 40);
            buttonConnectBrick.TabIndex = 3;
            buttonConnectBrick.Text = "Connect...";
            buttonConnectBrick.UseVisualStyleBackColor = true;
            buttonConnectBrick.Click += buttonConnectBrick_Click;
            // 
            // guidLabel0
            // 
            guidLabel0.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            guidLabel0.AutoSize = true;
            guidLabel0.BackColor = System.Drawing.Color.Gold;
            guidLabel0.Location = new System.Drawing.Point(10, 244);
            guidLabel0.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            guidLabel0.Name = "guidLabel0";
            guidLabel0.Size = new System.Drawing.Size(159, 34);
            guidLabel0.TabIndex = 5;
            guidLabel0.Text = "GUID";
            guidLabel0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textJoystickAlias0
            // 
            textJoystickAlias0.Dock = System.Windows.Forms.DockStyle.Fill;
            textJoystickAlias0.Location = new System.Drawing.Point(189, 244);
            textJoystickAlias0.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            textJoystickAlias0.Name = "textJoystickAlias0";
            textJoystickAlias0.Size = new System.Drawing.Size(159, 27);
            textJoystickAlias0.TabIndex = 7;
            textJoystickAlias0.Text = "1";
            textJoystickAlias0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboType0
            // 
            comboType0.Dock = System.Windows.Forms.DockStyle.Fill;
            comboType0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboType0.FormattingEnabled = true;
            comboType0.Location = new System.Drawing.Point(368, 244);
            comboType0.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            comboType0.Name = "comboType0";
            comboType0.Size = new System.Drawing.Size(159, 28);
            comboType0.TabIndex = 8;
            comboType0.SelectedIndexChanged += comboType0_SelectedIndexChanged;
            // 
            // buttonUpdateJoysticks
            // 
            buttonUpdateJoysticks.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            buttonUpdateJoysticks.AutoSize = true;
            buttonUpdateJoysticks.Location = new System.Drawing.Point(3, 188);
            buttonUpdateJoysticks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonUpdateJoysticks.Name = "buttonUpdateJoysticks";
            buttonUpdateJoysticks.Size = new System.Drawing.Size(173, 40);
            buttonUpdateJoysticks.TabIndex = 2;
            buttonUpdateJoysticks.Text = "Update joysticks";
            buttonUpdateJoysticks.UseVisualStyleBackColor = true;
            buttonUpdateJoysticks.Click += buttonUpdateJoysticks_Click;
            // 
            // buttonClearBricksFromPairs
            // 
            buttonClearBricksFromPairs.AutoSize = true;
            buttonClearBricksFromPairs.Dock = System.Windows.Forms.DockStyle.Bottom;
            buttonClearBricksFromPairs.Location = new System.Drawing.Point(540, 188);
            buttonClearBricksFromPairs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonClearBricksFromPairs.Name = "buttonClearBricksFromPairs";
            buttonClearBricksFromPairs.Size = new System.Drawing.Size(174, 40);
            buttonClearBricksFromPairs.TabIndex = 3;
            buttonClearBricksFromPairs.Text = "Clear brick selections";
            buttonClearBricksFromPairs.UseVisualStyleBackColor = true;
            buttonClearBricksFromPairs.Click += buttonClearBricksFromPairs_Click;
            // 
            // tabMatch
            // 
            tabMatch.Controls.Add(tableLayoutPanel2);
            tabMatch.Location = new System.Drawing.Point(4, 29);
            tabMatch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabMatch.Name = "tabMatch";
            tabMatch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabMatch.Size = new System.Drawing.Size(723, 596);
            tabMatch.TabIndex = 1;
            tabMatch.Text = "Match";
            tabMatch.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(checkShowChildWindow, 2, 9);
            tableLayoutPanel2.Controls.Add(textTeleTime, 2, 8);
            tableLayoutPanel2.Controls.Add(textAutoTime, 2, 7);
            tableLayoutPanel2.Controls.Add(checkPauseBetween, 0, 9);
            tableLayoutPanel2.Controls.Add(checkTeleoperated, 0, 8);
            tableLayoutPanel2.Controls.Add(checkAutonomous, 0, 7);
            tableLayoutPanel2.Controls.Add(buttonAbort, 2, 6);
            tableLayoutPanel2.Controls.Add(buttonStartPause, 1, 6);
            tableLayoutPanel2.Controls.Add(timerLabel, 0, 2);
            tableLayoutPanel2.Controls.Add(label5, 1, 0);
            tableLayoutPanel2.Controls.Add(modeLabel, 1, 1);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 4);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel2.Size = new System.Drawing.Size(717, 588);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // checkShowChildWindow
            // 
            checkShowChildWindow.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            checkShowChildWindow.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(checkShowChildWindow, 2);
            checkShowChildWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            checkShowChildWindow.Location = new System.Drawing.Point(368, 534);
            checkShowChildWindow.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            checkShowChildWindow.Name = "checkShowChildWindow";
            checkShowChildWindow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            checkShowChildWindow.Size = new System.Drawing.Size(339, 42);
            checkShowChildWindow.TabIndex = 42;
            checkShowChildWindow.Text = "Show/hide 2nd window";
            checkShowChildWindow.UseVisualStyleBackColor = true;
            checkShowChildWindow.CheckedChanged += checkShowChildWindow_CheckedChanged;
            // 
            // textTeleTime
            // 
            textTeleTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textTeleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textTeleTime.Location = new System.Drawing.Point(368, 480);
            textTeleTime.Margin = new System.Windows.Forms.Padding(10, 12, 80, 12);
            textTeleTime.Name = "textTeleTime";
            textTeleTime.Size = new System.Drawing.Size(87, 26);
            textTeleTime.TabIndex = 41;
            textTeleTime.Text = "Y:YY";
            textTeleTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textTeleTime.TextChanged += textTeleTime_TextChanged;
            textTeleTime.Leave += textTeleTime_Leave;
            // 
            // textAutoTime
            // 
            textAutoTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textAutoTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textAutoTime.Location = new System.Drawing.Point(368, 422);
            textAutoTime.Margin = new System.Windows.Forms.Padding(10, 12, 80, 12);
            textAutoTime.Name = "textAutoTime";
            textAutoTime.Size = new System.Drawing.Size(87, 26);
            textAutoTime.TabIndex = 40;
            textAutoTime.Text = "X:XX";
            textAutoTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textAutoTime.TextChanged += textAutoTime_TextChanged;
            textAutoTime.Leave += textAutoTime_Leave;
            // 
            // checkPauseBetween
            // 
            checkPauseBetween.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            checkPauseBetween.AutoSize = true;
            checkPauseBetween.Checked = true;
            checkPauseBetween.CheckState = System.Windows.Forms.CheckState.Checked;
            tableLayoutPanel2.SetColumnSpan(checkPauseBetween, 2);
            checkPauseBetween.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkPauseBetween.Location = new System.Drawing.Point(10, 534);
            checkPauseBetween.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            checkPauseBetween.Name = "checkPauseBetween";
            checkPauseBetween.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            checkPauseBetween.Size = new System.Drawing.Size(338, 42);
            checkPauseBetween.TabIndex = 39;
            checkPauseBetween.Text = "?Pause between periods";
            checkPauseBetween.UseVisualStyleBackColor = true;
            // 
            // checkTeleoperated
            // 
            checkTeleoperated.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            checkTeleoperated.AutoSize = true;
            checkTeleoperated.Checked = true;
            checkTeleoperated.CheckState = System.Windows.Forms.CheckState.Checked;
            tableLayoutPanel2.SetColumnSpan(checkTeleoperated, 2);
            checkTeleoperated.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkTeleoperated.Location = new System.Drawing.Point(10, 476);
            checkTeleoperated.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            checkTeleoperated.Name = "checkTeleoperated";
            checkTeleoperated.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            checkTeleoperated.Size = new System.Drawing.Size(338, 34);
            checkTeleoperated.TabIndex = 38;
            checkTeleoperated.Text = "Tele-operated time period";
            checkTeleoperated.UseVisualStyleBackColor = true;
            // 
            // checkAutonomous
            // 
            checkAutonomous.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            checkAutonomous.AutoSize = true;
            checkAutonomous.Checked = true;
            checkAutonomous.CheckState = System.Windows.Forms.CheckState.Checked;
            tableLayoutPanel2.SetColumnSpan(checkAutonomous, 2);
            checkAutonomous.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkAutonomous.Location = new System.Drawing.Point(10, 418);
            checkAutonomous.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            checkAutonomous.Name = "checkAutonomous";
            checkAutonomous.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            checkAutonomous.Size = new System.Drawing.Size(338, 34);
            checkAutonomous.TabIndex = 37;
            checkAutonomous.Text = "Autonomous time period";
            checkAutonomous.UseVisualStyleBackColor = true;
            // 
            // buttonAbort
            // 
            buttonAbort.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            buttonAbort.AutoSize = true;
            buttonAbort.Location = new System.Drawing.Point(366, 359);
            buttonAbort.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            buttonAbort.Name = "buttonAbort";
            buttonAbort.Size = new System.Drawing.Size(163, 36);
            buttonAbort.TabIndex = 36;
            buttonAbort.Text = "ABORT";
            buttonAbort.UseVisualStyleBackColor = true;
            buttonAbort.Click += buttonAbort_Click;
            // 
            // buttonStartPause
            // 
            buttonStartPause.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            buttonStartPause.AutoSize = true;
            buttonStartPause.Location = new System.Drawing.Point(187, 359);
            buttonStartPause.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            buttonStartPause.Name = "buttonStartPause";
            buttonStartPause.Size = new System.Drawing.Size(163, 36);
            buttonStartPause.TabIndex = 35;
            buttonStartPause.Text = "Start / Pause";
            buttonStartPause.UseVisualStyleBackColor = true;
            buttonStartPause.Click += buttonStartPause_Click;
            // 
            // timerLabel
            // 
            timerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            timerLabel.AutoSize = true;
            timerLabel.BackColor = System.Drawing.Color.White;
            timerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tableLayoutPanel2.SetColumnSpan(timerLabel, 4);
            timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 84F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            timerLabel.Location = new System.Drawing.Point(50, 128);
            timerLabel.Margin = new System.Windows.Forms.Padding(50, 12, 50, 12);
            timerLabel.Name = "timerLabel";
            timerLabel.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            tableLayoutPanel2.SetRowSpan(timerLabel, 4);
            timerLabel.Size = new System.Drawing.Size(617, 208);
            timerLabel.TabIndex = 2;
            timerLabel.Text = "0:00";
            timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(label5, 2);
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(182, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(352, 58);
            label5.TabIndex = 0;
            label5.Text = "Current Mode";
            label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // modeLabel
            // 
            modeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            modeLabel.AutoSize = true;
            modeLabel.BackColor = System.Drawing.Color.DimGray;
            tableLayoutPanel2.SetColumnSpan(modeLabel, 2);
            modeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            modeLabel.Location = new System.Drawing.Point(184, 65);
            modeLabel.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            modeLabel.Name = "modeLabel";
            modeLabel.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            modeLabel.Size = new System.Drawing.Size(348, 44);
            modeLabel.TabIndex = 1;
            modeLabel.Text = "MODE";
            modeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            timer.Interval = 50;
            timer.Tick += timer1_Tick;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(731, 629);
            Controls.Add(tabControl1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "MainWindow";
            Text = "FMS v3 0.014";
            Load += MainWindow_Load;
            tabControl1.ResumeLayout(false);
            tabSetup.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tabMatch.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabSetup;
		private System.Windows.Forms.TabPage tabMatch;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonUpdateBricks;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label spacer1;
		private System.Windows.Forms.Button buttonConnectBrick;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label guidLabel0;
		private System.Windows.Forms.ComboBox comboType2;
		private System.Windows.Forms.TextBox textJoystickAlias2;
		private System.Windows.Forms.Label guidLabel2;
		private System.Windows.Forms.ComboBox comboBrick1;
		private System.Windows.Forms.ComboBox comboType1;
		private System.Windows.Forms.TextBox textJoystickAlias1;
		private System.Windows.Forms.Label guidLabel1;
		private System.Windows.Forms.ComboBox comboBrick0;
		private System.Windows.Forms.ComboBox comboAllBrick;
		private System.Windows.Forms.Button buttonUpdateJoysticks;
		private System.Windows.Forms.Button buttonClearBricksFromPairs;
		private System.Windows.Forms.TextBox textJoystickAlias0;
		private System.Windows.Forms.ComboBox comboType0;
		private System.Windows.Forms.ComboBox comboBrick3;
		private System.Windows.Forms.ComboBox comboType3;
		private System.Windows.Forms.TextBox textJoystickAlias3;
		private System.Windows.Forms.Label guidLabel3;
		private System.Windows.Forms.ComboBox comboBrick2;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Button buttonToggleFreeDrive;
		private System.Windows.Forms.CheckBox checkBeepForButtonPressed;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label timerLabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label modeLabel;
		private System.Windows.Forms.Button buttonAbort;
		private System.Windows.Forms.Button buttonStartPause;
		private System.Windows.Forms.TextBox textTeleTime;
		private System.Windows.Forms.TextBox textAutoTime;
		private System.Windows.Forms.CheckBox checkPauseBetween;
		private System.Windows.Forms.CheckBox checkTeleoperated;
		private System.Windows.Forms.CheckBox checkAutonomous;
		private System.Windows.Forms.CheckBox checkShowChildWindow;
	}
}

