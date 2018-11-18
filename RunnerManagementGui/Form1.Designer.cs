namespace RunnerManagementGui
{
    partial class Form1
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
            this.panelMaster = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMaster = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelButtonsResults = new System.Windows.Forms.TableLayoutPanel();
            this.buttonResultConsult = new System.Windows.Forms.Button();
            this.buttonResultReset = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelMessages = new System.Windows.Forms.Panel();
            this.labelMessagesText = new System.Windows.Forms.Label();
            this.labelTitleMessages = new System.Windows.Forms.Label();
            this.tableLayoutPanelInputRegister = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelInputButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonInputAdd = new System.Windows.Forms.Button();
            this.buttonInputUpdate = new System.Windows.Forms.Button();
            this.buttonInputRemove = new System.Windows.Forms.Button();
            this.tableLayoutPanelInputRegisterData = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitleInputRegister = new System.Windows.Forms.Label();
            this.tableLayoutPanelInputData = new System.Windows.Forms.TableLayoutPanel();
            this.labelInputNumber = new System.Windows.Forms.Label();
            this.labelInputCategorie = new System.Windows.Forms.Label();
            this.labelInputTimeStart = new System.Windows.Forms.Label();
            this.labelInputTimeEnd = new System.Windows.Forms.Label();
            this.textBoxInputNumber = new System.Windows.Forms.TextBox();
            this.dateTimePickerInputEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInputStart = new System.Windows.Forms.DateTimePicker();
            this.comboBoxInputcategorie = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelRegisterRun = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitleRegisterRun = new System.Windows.Forms.Label();
            this.dataGridViewRegisterRun = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelResultsRun = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitleResultsRun = new System.Windows.Forms.Label();
            this.dataGridViewResultsRun = new System.Windows.Forms.DataGridView();
            this.panelMaster.SuspendLayout();
            this.tableLayoutPanelMaster.SuspendLayout();
            this.tableLayoutPanelButtonsResults.SuspendLayout();
            this.panelMessages.SuspendLayout();
            this.tableLayoutPanelInputRegister.SuspendLayout();
            this.tableLayoutPanelInputButtons.SuspendLayout();
            this.tableLayoutPanelInputRegisterData.SuspendLayout();
            this.tableLayoutPanelInputData.SuspendLayout();
            this.tableLayoutPanelRegisterRun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegisterRun)).BeginInit();
            this.tableLayoutPanelResultsRun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultsRun)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMaster
            // 
            this.panelMaster.Controls.Add(this.tableLayoutPanelMaster);
            this.panelMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMaster.Location = new System.Drawing.Point(0, 0);
            this.panelMaster.Name = "panelMaster";
            this.panelMaster.Size = new System.Drawing.Size(984, 561);
            this.panelMaster.TabIndex = 0;
            // 
            // tableLayoutPanelMaster
            // 
            this.tableLayoutPanelMaster.ColumnCount = 2;
            this.tableLayoutPanelMaster.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMaster.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMaster.Controls.Add(this.tableLayoutPanelButtonsResults, 1, 1);
            this.tableLayoutPanelMaster.Controls.Add(this.panelMessages, 0, 1);
            this.tableLayoutPanelMaster.Controls.Add(this.tableLayoutPanelInputRegister, 0, 0);
            this.tableLayoutPanelMaster.Controls.Add(this.tableLayoutPanelResultsRun, 1, 0);
            this.tableLayoutPanelMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMaster.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMaster.Name = "tableLayoutPanelMaster";
            this.tableLayoutPanelMaster.RowCount = 2;
            this.tableLayoutPanelMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanelMaster.Size = new System.Drawing.Size(984, 561);
            this.tableLayoutPanelMaster.TabIndex = 0;
            // 
            // tableLayoutPanelButtonsResults
            // 
            this.tableLayoutPanelButtonsResults.ColumnCount = 3;
            this.tableLayoutPanelButtonsResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtonsResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtonsResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtonsResults.Controls.Add(this.buttonResultConsult, 0, 0);
            this.tableLayoutPanelButtonsResults.Controls.Add(this.buttonResultReset, 1, 0);
            this.tableLayoutPanelButtonsResults.Controls.Add(this.buttonClose, 2, 0);
            this.tableLayoutPanelButtonsResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtonsResults.Location = new System.Drawing.Point(495, 510);
            this.tableLayoutPanelButtonsResults.Name = "tableLayoutPanelButtonsResults";
            this.tableLayoutPanelButtonsResults.RowCount = 1;
            this.tableLayoutPanelButtonsResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtonsResults.Size = new System.Drawing.Size(486, 48);
            this.tableLayoutPanelButtonsResults.TabIndex = 0;
            // 
            // buttonResultConsult
            // 
            this.buttonResultConsult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonResultConsult.Location = new System.Drawing.Point(3, 3);
            this.buttonResultConsult.Name = "buttonResultConsult";
            this.buttonResultConsult.Size = new System.Drawing.Size(156, 42);
            this.buttonResultConsult.TabIndex = 0;
            this.buttonResultConsult.Text = "button1";
            this.buttonResultConsult.UseVisualStyleBackColor = true;
            // 
            // buttonResultReset
            // 
            this.buttonResultReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonResultReset.Location = new System.Drawing.Point(165, 3);
            this.buttonResultReset.Name = "buttonResultReset";
            this.buttonResultReset.Size = new System.Drawing.Size(156, 42);
            this.buttonResultReset.TabIndex = 1;
            this.buttonResultReset.Text = "button2";
            this.buttonResultReset.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClose.Location = new System.Drawing.Point(327, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(156, 42);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "button3";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelMessages
            // 
            this.panelMessages.Controls.Add(this.labelMessagesText);
            this.panelMessages.Controls.Add(this.labelTitleMessages);
            this.panelMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMessages.Location = new System.Drawing.Point(3, 510);
            this.panelMessages.Name = "panelMessages";
            this.panelMessages.Size = new System.Drawing.Size(486, 48);
            this.panelMessages.TabIndex = 1;
            // 
            // labelMessagesText
            // 
            this.labelMessagesText.AutoSize = true;
            this.labelMessagesText.Location = new System.Drawing.Point(9, 17);
            this.labelMessagesText.Name = "labelMessagesText";
            this.labelMessagesText.Size = new System.Drawing.Size(29, 13);
            this.labelMessagesText.TabIndex = 1;
            this.labelMessagesText.Text = "label";
            // 
            // labelTitleMessages
            // 
            this.labelTitleMessages.AutoSize = true;
            this.labelTitleMessages.Location = new System.Drawing.Point(10, 4);
            this.labelTitleMessages.Name = "labelTitleMessages";
            this.labelTitleMessages.Size = new System.Drawing.Size(29, 13);
            this.labelTitleMessages.TabIndex = 0;
            this.labelTitleMessages.Text = "label";
            // 
            // tableLayoutPanelInputRegister
            // 
            this.tableLayoutPanelInputRegister.ColumnCount = 1;
            this.tableLayoutPanelInputRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelInputRegister.Controls.Add(this.tableLayoutPanelInputButtons, 0, 1);
            this.tableLayoutPanelInputRegister.Controls.Add(this.tableLayoutPanelInputRegisterData, 0, 0);
            this.tableLayoutPanelInputRegister.Controls.Add(this.tableLayoutPanelRegisterRun, 0, 2);
            this.tableLayoutPanelInputRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInputRegister.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelInputRegister.Name = "tableLayoutPanelInputRegister";
            this.tableLayoutPanelInputRegister.RowCount = 3;
            this.tableLayoutPanelInputRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanelInputRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanelInputRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelInputRegister.Size = new System.Drawing.Size(486, 501);
            this.tableLayoutPanelInputRegister.TabIndex = 2;
            // 
            // tableLayoutPanelInputButtons
            // 
            this.tableLayoutPanelInputButtons.ColumnCount = 3;
            this.tableLayoutPanelInputButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelInputButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelInputButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelInputButtons.Controls.Add(this.buttonInputAdd, 0, 0);
            this.tableLayoutPanelInputButtons.Controls.Add(this.buttonInputUpdate, 1, 0);
            this.tableLayoutPanelInputButtons.Controls.Add(this.buttonInputRemove, 2, 0);
            this.tableLayoutPanelInputButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInputButtons.Location = new System.Drawing.Point(3, 82);
            this.tableLayoutPanelInputButtons.Name = "tableLayoutPanelInputButtons";
            this.tableLayoutPanelInputButtons.RowCount = 1;
            this.tableLayoutPanelInputButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelInputButtons.Size = new System.Drawing.Size(480, 37);
            this.tableLayoutPanelInputButtons.TabIndex = 0;
            // 
            // buttonInputAdd
            // 
            this.buttonInputAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInputAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonInputAdd.Name = "buttonInputAdd";
            this.buttonInputAdd.Size = new System.Drawing.Size(154, 31);
            this.buttonInputAdd.TabIndex = 0;
            this.buttonInputAdd.Text = "button1";
            this.buttonInputAdd.UseVisualStyleBackColor = true;
            this.buttonInputAdd.Click += new System.EventHandler(this.buttonInputAdd_Click);
            // 
            // buttonInputUpdate
            // 
            this.buttonInputUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInputUpdate.Location = new System.Drawing.Point(163, 3);
            this.buttonInputUpdate.Name = "buttonInputUpdate";
            this.buttonInputUpdate.Size = new System.Drawing.Size(154, 31);
            this.buttonInputUpdate.TabIndex = 1;
            this.buttonInputUpdate.Text = "button2";
            this.buttonInputUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonInputRemove
            // 
            this.buttonInputRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInputRemove.Location = new System.Drawing.Point(323, 3);
            this.buttonInputRemove.Name = "buttonInputRemove";
            this.buttonInputRemove.Size = new System.Drawing.Size(154, 31);
            this.buttonInputRemove.TabIndex = 2;
            this.buttonInputRemove.Text = "button3";
            this.buttonInputRemove.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelInputRegisterData
            // 
            this.tableLayoutPanelInputRegisterData.ColumnCount = 1;
            this.tableLayoutPanelInputRegisterData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelInputRegisterData.Controls.Add(this.labelTitleInputRegister, 0, 0);
            this.tableLayoutPanelInputRegisterData.Controls.Add(this.tableLayoutPanelInputData, 0, 1);
            this.tableLayoutPanelInputRegisterData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInputRegisterData.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelInputRegisterData.Name = "tableLayoutPanelInputRegisterData";
            this.tableLayoutPanelInputRegisterData.RowCount = 2;
            this.tableLayoutPanelInputRegisterData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.0274F));
            this.tableLayoutPanelInputRegisterData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.9726F));
            this.tableLayoutPanelInputRegisterData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelInputRegisterData.Size = new System.Drawing.Size(480, 73);
            this.tableLayoutPanelInputRegisterData.TabIndex = 1;
            // 
            // labelTitleInputRegister
            // 
            this.labelTitleInputRegister.AutoSize = true;
            this.labelTitleInputRegister.Location = new System.Drawing.Point(3, 0);
            this.labelTitleInputRegister.Name = "labelTitleInputRegister";
            this.labelTitleInputRegister.Size = new System.Drawing.Size(35, 13);
            this.labelTitleInputRegister.TabIndex = 0;
            this.labelTitleInputRegister.Text = "label1";
            // 
            // tableLayoutPanelInputData
            // 
            this.tableLayoutPanelInputData.ColumnCount = 4;
            this.tableLayoutPanelInputData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInputData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInputData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInputData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInputData.Controls.Add(this.labelInputNumber, 0, 0);
            this.tableLayoutPanelInputData.Controls.Add(this.labelInputCategorie, 1, 0);
            this.tableLayoutPanelInputData.Controls.Add(this.labelInputTimeStart, 2, 0);
            this.tableLayoutPanelInputData.Controls.Add(this.labelInputTimeEnd, 3, 0);
            this.tableLayoutPanelInputData.Controls.Add(this.textBoxInputNumber, 0, 1);
            this.tableLayoutPanelInputData.Controls.Add(this.dateTimePickerInputEnd, 3, 1);
            this.tableLayoutPanelInputData.Controls.Add(this.dateTimePickerInputStart, 2, 1);
            this.tableLayoutPanelInputData.Controls.Add(this.comboBoxInputcategorie, 1, 1);
            this.tableLayoutPanelInputData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInputData.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanelInputData.Name = "tableLayoutPanelInputData";
            this.tableLayoutPanelInputData.RowCount = 2;
            this.tableLayoutPanelInputData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanelInputData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanelInputData.Size = new System.Drawing.Size(474, 48);
            this.tableLayoutPanelInputData.TabIndex = 1;
            this.tableLayoutPanelInputData.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // labelInputNumber
            // 
            this.labelInputNumber.AutoSize = true;
            this.labelInputNumber.Location = new System.Drawing.Point(3, 0);
            this.labelInputNumber.Name = "labelInputNumber";
            this.labelInputNumber.Size = new System.Drawing.Size(35, 13);
            this.labelInputNumber.TabIndex = 0;
            this.labelInputNumber.Text = "label1";
            // 
            // labelInputCategorie
            // 
            this.labelInputCategorie.AutoSize = true;
            this.labelInputCategorie.Location = new System.Drawing.Point(121, 0);
            this.labelInputCategorie.Name = "labelInputCategorie";
            this.labelInputCategorie.Size = new System.Drawing.Size(35, 13);
            this.labelInputCategorie.TabIndex = 1;
            this.labelInputCategorie.Text = "label2";
            // 
            // labelInputTimeStart
            // 
            this.labelInputTimeStart.AutoSize = true;
            this.labelInputTimeStart.Location = new System.Drawing.Point(239, 0);
            this.labelInputTimeStart.Name = "labelInputTimeStart";
            this.labelInputTimeStart.Size = new System.Drawing.Size(35, 13);
            this.labelInputTimeStart.TabIndex = 2;
            this.labelInputTimeStart.Text = "label3";
            // 
            // labelInputTimeEnd
            // 
            this.labelInputTimeEnd.AutoSize = true;
            this.labelInputTimeEnd.Location = new System.Drawing.Point(357, 0);
            this.labelInputTimeEnd.Name = "labelInputTimeEnd";
            this.labelInputTimeEnd.Size = new System.Drawing.Size(35, 13);
            this.labelInputTimeEnd.TabIndex = 3;
            this.labelInputTimeEnd.Text = "label4";
            // 
            // textBoxInputNumber
            // 
            this.textBoxInputNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInputNumber.Location = new System.Drawing.Point(3, 21);
            this.textBoxInputNumber.Name = "textBoxInputNumber";
            this.textBoxInputNumber.Size = new System.Drawing.Size(112, 20);
            this.textBoxInputNumber.TabIndex = 4;
            // 
            // dateTimePickerInputEnd
            // 
            this.dateTimePickerInputEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerInputEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerInputEnd.Location = new System.Drawing.Point(357, 21);
            this.dateTimePickerInputEnd.Name = "dateTimePickerInputEnd";
            this.dateTimePickerInputEnd.ShowUpDown = true;
            this.dateTimePickerInputEnd.Size = new System.Drawing.Size(114, 20);
            this.dateTimePickerInputEnd.TabIndex = 5;
            // 
            // dateTimePickerInputStart
            // 
            this.dateTimePickerInputStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerInputStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerInputStart.Location = new System.Drawing.Point(239, 21);
            this.dateTimePickerInputStart.Name = "dateTimePickerInputStart";
            this.dateTimePickerInputStart.ShowUpDown = true;
            this.dateTimePickerInputStart.Size = new System.Drawing.Size(112, 20);
            this.dateTimePickerInputStart.TabIndex = 6;
            // 
            // comboBoxInputcategorie
            // 
            this.comboBoxInputcategorie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxInputcategorie.FormattingEnabled = true;
            this.comboBoxInputcategorie.Location = new System.Drawing.Point(121, 21);
            this.comboBoxInputcategorie.Name = "comboBoxInputcategorie";
            this.comboBoxInputcategorie.Size = new System.Drawing.Size(112, 21);
            this.comboBoxInputcategorie.TabIndex = 7;
            // 
            // tableLayoutPanelRegisterRun
            // 
            this.tableLayoutPanelRegisterRun.ColumnCount = 1;
            this.tableLayoutPanelRegisterRun.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRegisterRun.Controls.Add(this.labelTitleRegisterRun, 0, 0);
            this.tableLayoutPanelRegisterRun.Controls.Add(this.dataGridViewRegisterRun, 0, 1);
            this.tableLayoutPanelRegisterRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRegisterRun.Location = new System.Drawing.Point(3, 125);
            this.tableLayoutPanelRegisterRun.Name = "tableLayoutPanelRegisterRun";
            this.tableLayoutPanelRegisterRun.RowCount = 2;
            this.tableLayoutPanelRegisterRun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelRegisterRun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRegisterRun.Size = new System.Drawing.Size(480, 373);
            this.tableLayoutPanelRegisterRun.TabIndex = 2;
            // 
            // labelTitleRegisterRun
            // 
            this.labelTitleRegisterRun.AutoSize = true;
            this.labelTitleRegisterRun.Location = new System.Drawing.Point(3, 0);
            this.labelTitleRegisterRun.Name = "labelTitleRegisterRun";
            this.labelTitleRegisterRun.Size = new System.Drawing.Size(35, 13);
            this.labelTitleRegisterRun.TabIndex = 0;
            this.labelTitleRegisterRun.Text = "label1";
            // 
            // dataGridViewRegisterRun
            // 
            this.dataGridViewRegisterRun.AllowUserToAddRows = false;
            this.dataGridViewRegisterRun.AllowUserToDeleteRows = false;
            this.dataGridViewRegisterRun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegisterRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRegisterRun.Location = new System.Drawing.Point(3, 32);
            this.dataGridViewRegisterRun.Name = "dataGridViewRegisterRun";
            this.dataGridViewRegisterRun.ReadOnly = true;
            this.dataGridViewRegisterRun.Size = new System.Drawing.Size(474, 338);
            this.dataGridViewRegisterRun.TabIndex = 1;
            // 
            // tableLayoutPanelResultsRun
            // 
            this.tableLayoutPanelResultsRun.ColumnCount = 1;
            this.tableLayoutPanelResultsRun.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelResultsRun.Controls.Add(this.labelTitleResultsRun, 0, 0);
            this.tableLayoutPanelResultsRun.Controls.Add(this.dataGridViewResultsRun, 0, 1);
            this.tableLayoutPanelResultsRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelResultsRun.Location = new System.Drawing.Point(495, 3);
            this.tableLayoutPanelResultsRun.Name = "tableLayoutPanelResultsRun";
            this.tableLayoutPanelResultsRun.RowCount = 2;
            this.tableLayoutPanelResultsRun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanelResultsRun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelResultsRun.Size = new System.Drawing.Size(486, 501);
            this.tableLayoutPanelResultsRun.TabIndex = 3;
            // 
            // labelTitleResultsRun
            // 
            this.labelTitleResultsRun.AutoSize = true;
            this.labelTitleResultsRun.Location = new System.Drawing.Point(3, 0);
            this.labelTitleResultsRun.Name = "labelTitleResultsRun";
            this.labelTitleResultsRun.Size = new System.Drawing.Size(35, 13);
            this.labelTitleResultsRun.TabIndex = 0;
            this.labelTitleResultsRun.Text = "label1";
            // 
            // dataGridViewResultsRun
            // 
            this.dataGridViewResultsRun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultsRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResultsRun.Location = new System.Drawing.Point(3, 39);
            this.dataGridViewResultsRun.Name = "dataGridViewResultsRun";
            this.dataGridViewResultsRun.Size = new System.Drawing.Size(480, 459);
            this.dataGridViewResultsRun.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelMaster);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.panelMaster.ResumeLayout(false);
            this.tableLayoutPanelMaster.ResumeLayout(false);
            this.tableLayoutPanelButtonsResults.ResumeLayout(false);
            this.panelMessages.ResumeLayout(false);
            this.panelMessages.PerformLayout();
            this.tableLayoutPanelInputRegister.ResumeLayout(false);
            this.tableLayoutPanelInputButtons.ResumeLayout(false);
            this.tableLayoutPanelInputRegisterData.ResumeLayout(false);
            this.tableLayoutPanelInputRegisterData.PerformLayout();
            this.tableLayoutPanelInputData.ResumeLayout(false);
            this.tableLayoutPanelInputData.PerformLayout();
            this.tableLayoutPanelRegisterRun.ResumeLayout(false);
            this.tableLayoutPanelRegisterRun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegisterRun)).EndInit();
            this.tableLayoutPanelResultsRun.ResumeLayout(false);
            this.tableLayoutPanelResultsRun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultsRun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMaster;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMaster;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtonsResults;
        private System.Windows.Forms.Button buttonResultConsult;
        private System.Windows.Forms.Button buttonResultReset;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelMessages;
        private System.Windows.Forms.Label labelMessagesText;
        private System.Windows.Forms.Label labelTitleMessages;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInputRegister;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInputButtons;
        private System.Windows.Forms.Button buttonInputAdd;
        private System.Windows.Forms.Button buttonInputUpdate;
        private System.Windows.Forms.Button buttonInputRemove;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInputRegisterData;
        private System.Windows.Forms.Label labelTitleInputRegister;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInputData;
        private System.Windows.Forms.Label labelInputNumber;
        private System.Windows.Forms.Label labelInputCategorie;
        private System.Windows.Forms.Label labelInputTimeStart;
        private System.Windows.Forms.Label labelInputTimeEnd;
        private System.Windows.Forms.TextBox textBoxInputNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerInputEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerInputStart;
        private System.Windows.Forms.ComboBox comboBoxInputcategorie;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRegisterRun;
        private System.Windows.Forms.Label labelTitleRegisterRun;
        private System.Windows.Forms.DataGridView dataGridViewRegisterRun;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelResultsRun;
        private System.Windows.Forms.Label labelTitleResultsRun;
        private System.Windows.Forms.DataGridView dataGridViewResultsRun;
    }
}

