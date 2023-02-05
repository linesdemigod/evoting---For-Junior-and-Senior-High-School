namespace Evoting.View.voter
{
    partial class Voter
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewVoter = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.VoterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoterClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoterGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndexNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoterToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoterStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassUpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoterUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.VoterDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPDF = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblID = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnImportExcel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnExportExcel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtToken = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtVoterID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.comboGender = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.comboClass = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnSubmit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboClass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewVoter);
            this.panel1.Controls.Add(this.kryptonGroupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 620);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewVoter
            // 
            this.dataGridViewVoter.AllowUserToAddRows = false;
            this.dataGridViewVoter.AllowUserToDeleteRows = false;
            this.dataGridViewVoter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewVoter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVoter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VoterID,
            this.VoterClass,
            this.VoterName,
            this.VoterGender,
            this.IndexNumber,
            this.VoterToken,
            this.VoterStatus,
            this.ClassCreatedAt,
            this.ClassUpdatedAt,
            this.VoterUpdate,
            this.VoterDelete});
            this.dataGridViewVoter.Location = new System.Drawing.Point(28, 296);
            this.dataGridViewVoter.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dataGridViewVoter.Name = "dataGridViewVoter";
            this.dataGridViewVoter.ReadOnly = true;
            this.dataGridViewVoter.RowHeadersVisible = false;
            this.dataGridViewVoter.RowHeadersWidth = 51;
            this.dataGridViewVoter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVoter.Size = new System.Drawing.Size(827, 301);
            this.dataGridViewVoter.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridViewVoter.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.dataGridViewVoter.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.dataGridViewVoter.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dataGridViewVoter.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.dataGridViewVoter.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewVoter.TabIndex = 231;
            this.dataGridViewVoter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVoter_CellContentClick);
            // 
            // VoterID
            // 
            this.VoterID.DataPropertyName = "id";
            this.VoterID.HeaderText = "ID";
            this.VoterID.MinimumWidth = 6;
            this.VoterID.Name = "VoterID";
            this.VoterID.ReadOnly = true;
            this.VoterID.Visible = false;
            this.VoterID.Width = 125;
            // 
            // VoterClass
            // 
            this.VoterClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.VoterClass.DataPropertyName = "class_id";
            this.VoterClass.HeaderText = "Class";
            this.VoterClass.MinimumWidth = 6;
            this.VoterClass.Name = "VoterClass";
            this.VoterClass.ReadOnly = true;
            this.VoterClass.Width = 67;
            // 
            // VoterName
            // 
            this.VoterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.VoterName.DataPropertyName = "name";
            this.VoterName.HeaderText = "Name";
            this.VoterName.Name = "VoterName";
            this.VoterName.ReadOnly = true;
            this.VoterName.Width = 73;
            // 
            // VoterGender
            // 
            this.VoterGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.VoterGender.DataPropertyName = "gender";
            this.VoterGender.HeaderText = "Gender";
            this.VoterGender.Name = "VoterGender";
            this.VoterGender.ReadOnly = true;
            this.VoterGender.Width = 82;
            // 
            // IndexNumber
            // 
            this.IndexNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IndexNumber.DataPropertyName = "index_number";
            this.IndexNumber.HeaderText = "Voter ID";
            this.IndexNumber.Name = "IndexNumber";
            this.IndexNumber.ReadOnly = true;
            this.IndexNumber.Width = 83;
            // 
            // VoterToken
            // 
            this.VoterToken.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.VoterToken.DataPropertyName = "token";
            this.VoterToken.HeaderText = "Token";
            this.VoterToken.Name = "VoterToken";
            this.VoterToken.ReadOnly = true;
            this.VoterToken.Width = 73;
            // 
            // VoterStatus
            // 
            this.VoterStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.VoterStatus.DataPropertyName = "status";
            this.VoterStatus.HeaderText = "Vote Status";
            this.VoterStatus.Name = "VoterStatus";
            this.VoterStatus.ReadOnly = true;
            this.VoterStatus.Width = 99;
            // 
            // ClassCreatedAt
            // 
            this.ClassCreatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassCreatedAt.DataPropertyName = "created_at";
            this.ClassCreatedAt.HeaderText = "Created At";
            this.ClassCreatedAt.MinimumWidth = 6;
            this.ClassCreatedAt.Name = "ClassCreatedAt";
            this.ClassCreatedAt.ReadOnly = true;
            // 
            // ClassUpdatedAt
            // 
            this.ClassUpdatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassUpdatedAt.DataPropertyName = "updated_at";
            this.ClassUpdatedAt.HeaderText = "Updated At";
            this.ClassUpdatedAt.Name = "ClassUpdatedAt";
            this.ClassUpdatedAt.ReadOnly = true;
            this.ClassUpdatedAt.Width = 103;
            // 
            // VoterUpdate
            // 
            this.VoterUpdate.HeaderText = "Update";
            this.VoterUpdate.MinimumWidth = 6;
            this.VoterUpdate.Name = "VoterUpdate";
            this.VoterUpdate.ReadOnly = true;
            this.VoterUpdate.Text = "Update";
            this.VoterUpdate.UseColumnTextForButtonValue = true;
            this.VoterUpdate.Width = 125;
            // 
            // VoterDelete
            // 
            this.VoterDelete.HeaderText = "Delete";
            this.VoterDelete.MinimumWidth = 6;
            this.VoterDelete.Name = "VoterDelete";
            this.VoterDelete.ReadOnly = true;
            this.VoterDelete.Text = "Delete";
            this.VoterDelete.UseColumnTextForButtonValue = true;
            this.VoterDelete.Width = 125;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(26, 14);
            this.kryptonGroupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.panel2);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(829, 259);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonGroupBox1.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.TabIndex = 230;
            this.kryptonGroupBox1.Values.Heading = "Voters";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPDF);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Controls.Add(this.progressBar);
            this.panel2.Controls.Add(this.btnImportExcel);
            this.panel2.Controls.Add(this.btnExportExcel);
            this.panel2.Controls.Add(this.kryptonLabel5);
            this.panel2.Controls.Add(this.txtToken);
            this.panel2.Controls.Add(this.kryptonLabel3);
            this.panel2.Controls.Add(this.txtVoterID);
            this.panel2.Controls.Add(this.kryptonLabel1);
            this.panel2.Controls.Add(this.comboGender);
            this.panel2.Controls.Add(this.kryptonLabel2);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.kryptonLabel4);
            this.panel2.Controls.Add(this.comboClass);
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 227);
            this.panel2.TabIndex = 305;
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDF.Location = new System.Drawing.Point(669, 64);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(4);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPDF.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPDF.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPDF.OverrideDefault.Border.Rounding = 6;
            this.btnPDF.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnPDF.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnPDF.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPDF.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPDF.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPDF.OverrideFocus.Border.Rounding = 6;
            this.btnPDF.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnPDF.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnPDF.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.Size = new System.Drawing.Size(135, 39);
            this.btnPDF.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPDF.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPDF.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPDF.StateCommon.Border.Rounding = 6;
            this.btnPDF.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnPDF.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnPDF.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPDF.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPDF.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPDF.StatePressed.Border.Rounding = 6;
            this.btnPDF.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnPDF.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnPDF.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.TabIndex = 276;
            this.btnPDF.Values.Text = "Export PDF";
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.Location = new System.Drawing.Point(3, 198);
            this.lblID.Margin = new System.Windows.Forms.Padding(5);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 24);
            this.lblID.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.lblID.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.lblID.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.TabIndex = 262;
            this.lblID.Values.Text = "ID";
            this.lblID.Visible = false;
            this.lblID.TextChanged += new System.EventHandler(this.lblID_TextChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(637, 183);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(184, 28);
            this.progressBar.TabIndex = 261;
            this.progressBar.Visible = false;
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportExcel.Location = new System.Drawing.Point(669, 15);
            this.btnImportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnImportExcel.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnImportExcel.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnImportExcel.OverrideDefault.Border.Rounding = 6;
            this.btnImportExcel.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnImportExcel.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnImportExcel.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportExcel.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnImportExcel.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnImportExcel.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnImportExcel.OverrideFocus.Border.Rounding = 6;
            this.btnImportExcel.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnImportExcel.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnImportExcel.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportExcel.Size = new System.Drawing.Size(135, 39);
            this.btnImportExcel.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnImportExcel.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnImportExcel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnImportExcel.StateCommon.Border.Rounding = 6;
            this.btnImportExcel.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnImportExcel.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnImportExcel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportExcel.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnImportExcel.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnImportExcel.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnImportExcel.StatePressed.Border.Rounding = 6;
            this.btnImportExcel.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnImportExcel.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnImportExcel.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportExcel.TabIndex = 260;
            this.btnImportExcel.Values.Text = "Import Excel";
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.Location = new System.Drawing.Point(669, 113);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnExportExcel.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnExportExcel.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExportExcel.OverrideDefault.Border.Rounding = 6;
            this.btnExportExcel.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnExportExcel.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnExportExcel.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnExportExcel.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnExportExcel.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExportExcel.OverrideFocus.Border.Rounding = 6;
            this.btnExportExcel.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnExportExcel.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnExportExcel.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Size = new System.Drawing.Size(135, 39);
            this.btnExportExcel.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnExportExcel.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnExportExcel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExportExcel.StateCommon.Border.Rounding = 6;
            this.btnExportExcel.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnExportExcel.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnExportExcel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnExportExcel.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnExportExcel.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExportExcel.StatePressed.Border.Rounding = 6;
            this.btnExportExcel.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnExportExcel.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnExportExcel.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.TabIndex = 259;
            this.btnExportExcel.Values.Text = "Export Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel5.Location = new System.Drawing.Point(318, 63);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(59, 24);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.kryptonLabel5.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 235;
            this.kryptonLabel5.Values.Text = "Token";
            // 
            // txtToken
            // 
            this.txtToken.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtToken.Location = new System.Drawing.Point(402, 56);
            this.txtToken.Margin = new System.Windows.Forms.Padding(4);
            this.txtToken.Name = "txtToken";
            this.txtToken.ReadOnly = true;
            this.txtToken.Size = new System.Drawing.Size(199, 31);
            this.txtToken.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(189)))), ((int)(((byte)(203)))));
            this.txtToken.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(189)))), ((int)(((byte)(203)))));
            this.txtToken.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtToken.StateCommon.Border.Rounding = 12;
            this.txtToken.TabIndex = 234;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel3.Location = new System.Drawing.Point(318, 22);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(76, 24);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.kryptonLabel3.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 233;
            this.kryptonLabel3.Values.Text = "Voter ID";
            // 
            // txtVoterID
            // 
            this.txtVoterID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVoterID.Location = new System.Drawing.Point(402, 15);
            this.txtVoterID.Margin = new System.Windows.Forms.Padding(4);
            this.txtVoterID.Name = "txtVoterID";
            this.txtVoterID.ReadOnly = true;
            this.txtVoterID.Size = new System.Drawing.Size(199, 31);
            this.txtVoterID.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(189)))), ((int)(((byte)(203)))));
            this.txtVoterID.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(189)))), ((int)(((byte)(203)))));
            this.txtVoterID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtVoterID.StateCommon.Border.Rounding = 12;
            this.txtVoterID.TabIndex = 232;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 102);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(74, 24);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 231;
            this.kryptonLabel1.Values.Text = "Gender";
            // 
            // comboGender
            // 
            this.comboGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGender.DropDownWidth = 222;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboGender.Location = new System.Drawing.Point(85, 97);
            this.comboGender.Margin = new System.Windows.Forms.Padding(4);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(199, 29);
            this.comboGender.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboGender.StateCommon.ComboBox.Border.Rounding = 12;
            this.comboGender.TabIndex = 230;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel2.Location = new System.Drawing.Point(16, 63);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(61, 24);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.kryptonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 229;
            this.kryptonLabel2.Values.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(85, 56);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 31);
            this.txtName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(189)))), ((int)(((byte)(203)))));
            this.txtName.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(189)))), ((int)(((byte)(203)))));
            this.txtName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtName.StateCommon.Border.Rounding = 12;
            this.txtName.TabIndex = 228;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel4.Location = new System.Drawing.Point(24, 22);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(53, 24);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.kryptonLabel4.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 227;
            this.kryptonLabel4.Values.Text = "Class";
            // 
            // comboClass
            // 
            this.comboClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClass.DropDownWidth = 222;
            this.comboClass.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboClass.Location = new System.Drawing.Point(85, 17);
            this.comboClass.Margin = new System.Windows.Forms.Padding(4);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(199, 29);
            this.comboClass.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboClass.StateCommon.ComboBox.Border.Rounding = 12;
            this.comboClass.TabIndex = 226;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Location = new System.Drawing.Point(163, 161);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.btnSubmit.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.btnSubmit.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnSubmit.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSubmit.OverrideDefault.Border.Rounding = 6;
            this.btnSubmit.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubmit.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.btnSubmit.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.btnSubmit.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnSubmit.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.btnSubmit.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSubmit.OverrideFocus.Border.Rounding = 6;
            this.btnSubmit.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubmit.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Size = new System.Drawing.Size(137, 38);
            this.btnSubmit.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.btnSubmit.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.btnSubmit.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnSubmit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSubmit.StateCommon.Border.Rounding = 6;
            this.btnSubmit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubmit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.btnSubmit.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.btnSubmit.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSubmit.StatePressed.Border.Rounding = 6;
            this.btnSubmit.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubmit.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.btnSubmit.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.btnSubmit.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnSubmit.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnSubmit.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSubmit.StateTracking.Border.Rounding = 6;
            this.btnSubmit.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubmit.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.TabIndex = 225;
            this.btnSubmit.Values.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(354, 160);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OverrideDefault.Back.Color1 = System.Drawing.Color.Maroon;
            this.btnCancel.OverrideDefault.Back.Color2 = System.Drawing.Color.Maroon;
            this.btnCancel.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.OverrideDefault.Border.Rounding = 6;
            this.btnCancel.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCancel.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCancel.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.OverrideFocus.Back.Color1 = System.Drawing.Color.Maroon;
            this.btnCancel.OverrideFocus.Back.Color2 = System.Drawing.Color.Maroon;
            this.btnCancel.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.OverrideFocus.Border.Rounding = 6;
            this.btnCancel.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCancel.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCancel.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Size = new System.Drawing.Size(137, 39);
            this.btnCancel.StateCommon.Back.Color1 = System.Drawing.Color.Maroon;
            this.btnCancel.StateCommon.Back.Color2 = System.Drawing.Color.Maroon;
            this.btnCancel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StateCommon.Border.Rounding = 6;
            this.btnCancel.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCancel.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.btnCancel.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.btnCancel.StatePressed.Back.Color1 = System.Drawing.Color.Maroon;
            this.btnCancel.StatePressed.Back.Color2 = System.Drawing.Color.Maroon;
            this.btnCancel.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StatePressed.Border.Rounding = 6;
            this.btnCancel.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCancel.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCancel.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.TabIndex = 222;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Voter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 620);
            this.Controls.Add(this.panel1);
            this.Name = "Voter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voter";
            this.Load += new System.EventHandler(this.Voter_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridViewVoter;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubmit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboClass;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtName;
        private System.Windows.Forms.ProgressBar progressBar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnImportExcel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExportExcel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtToken;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtVoterID;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoterClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoterGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoterToken;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoterStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassCreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassUpdatedAt;
        private System.Windows.Forms.DataGridViewButtonColumn VoterUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn VoterDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblID;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPDF;
    }
}