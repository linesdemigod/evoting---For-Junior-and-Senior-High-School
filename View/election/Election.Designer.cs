namespace Evoting.View.election
{
    partial class Election
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
            this.dataGridViewElection = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ElectionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElectionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElectionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElectionCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElectionUpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElectionUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ElectionDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateElection = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lblID = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtPosition = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSubmit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewElection);
            this.panel1.Controls.Add(this.kryptonGroupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 620);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewElection
            // 
            this.dataGridViewElection.AllowUserToAddRows = false;
            this.dataGridViewElection.AllowUserToDeleteRows = false;
            this.dataGridViewElection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewElection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewElection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ElectionID,
            this.ElectionType,
            this.ElectionDate,
            this.ElectionCreatedAt,
            this.ElectionUpdatedAt,
            this.ElectionUpdate,
            this.ElectionDelete});
            this.dataGridViewElection.Location = new System.Drawing.Point(28, 289);
            this.dataGridViewElection.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dataGridViewElection.Name = "dataGridViewElection";
            this.dataGridViewElection.ReadOnly = true;
            this.dataGridViewElection.RowHeadersVisible = false;
            this.dataGridViewElection.RowHeadersWidth = 51;
            this.dataGridViewElection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewElection.Size = new System.Drawing.Size(827, 313);
            this.dataGridViewElection.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridViewElection.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.dataGridViewElection.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.dataGridViewElection.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dataGridViewElection.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.dataGridViewElection.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewElection.TabIndex = 233;
            this.dataGridViewElection.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewElection_CellContentClick);
            // 
            // ElectionID
            // 
            this.ElectionID.DataPropertyName = "id";
            this.ElectionID.HeaderText = "ID";
            this.ElectionID.MinimumWidth = 6;
            this.ElectionID.Name = "ElectionID";
            this.ElectionID.ReadOnly = true;
            this.ElectionID.Visible = false;
            this.ElectionID.Width = 125;
            // 
            // ElectionType
            // 
            this.ElectionType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ElectionType.DataPropertyName = "type";
            this.ElectionType.HeaderText = "Position";
            this.ElectionType.Name = "ElectionType";
            this.ElectionType.ReadOnly = true;
            // 
            // ElectionDate
            // 
            this.ElectionDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ElectionDate.DataPropertyName = "date";
            this.ElectionDate.HeaderText = "Date";
            this.ElectionDate.Name = "ElectionDate";
            this.ElectionDate.ReadOnly = true;
            this.ElectionDate.Width = 64;
            // 
            // ElectionCreatedAt
            // 
            this.ElectionCreatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ElectionCreatedAt.DataPropertyName = "created_at";
            this.ElectionCreatedAt.HeaderText = "Created At";
            this.ElectionCreatedAt.MinimumWidth = 6;
            this.ElectionCreatedAt.Name = "ElectionCreatedAt";
            this.ElectionCreatedAt.ReadOnly = true;
            this.ElectionCreatedAt.Width = 92;
            // 
            // ElectionUpdatedAt
            // 
            this.ElectionUpdatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ElectionUpdatedAt.DataPropertyName = "updated_at";
            this.ElectionUpdatedAt.HeaderText = "Updated At";
            this.ElectionUpdatedAt.Name = "ElectionUpdatedAt";
            this.ElectionUpdatedAt.ReadOnly = true;
            this.ElectionUpdatedAt.Width = 95;
            // 
            // ElectionUpdate
            // 
            this.ElectionUpdate.HeaderText = "Update";
            this.ElectionUpdate.MinimumWidth = 6;
            this.ElectionUpdate.Name = "ElectionUpdate";
            this.ElectionUpdate.ReadOnly = true;
            this.ElectionUpdate.Text = "Update";
            this.ElectionUpdate.UseColumnTextForButtonValue = true;
            this.ElectionUpdate.Width = 125;
            // 
            // ElectionDelete
            // 
            this.ElectionDelete.HeaderText = "Delete";
            this.ElectionDelete.MinimumWidth = 6;
            this.ElectionDelete.Name = "ElectionDelete";
            this.ElectionDelete.ReadOnly = true;
            this.ElectionDelete.Text = "Delete";
            this.ElectionDelete.UseColumnTextForButtonValue = true;
            this.ElectionDelete.Width = 125;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(26, 19);
            this.kryptonGroupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.panel2);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(829, 229);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonGroupBox1.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.TabIndex = 232;
            this.kryptonGroupBox1.Values.Heading = "Election";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateElection);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Controls.Add(this.kryptonLabel1);
            this.panel2.Controls.Add(this.kryptonLabel2);
            this.panel2.Controls.Add(this.txtPosition);
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 197);
            this.panel2.TabIndex = 305;
            // 
            // dateElection
            // 
            this.dateElection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateElection.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateElection.Location = new System.Drawing.Point(311, 61);
            this.dateElection.Margin = new System.Windows.Forms.Padding(5);
            this.dateElection.Name = "dateElection";
            this.dateElection.Size = new System.Drawing.Size(198, 29);
            this.dateElection.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dateElection.StateCommon.Border.Rounding = 12;
            this.dateElection.TabIndex = 277;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.Location = new System.Drawing.Point(5, 168);
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
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel1.Location = new System.Drawing.Point(181, 61);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(119, 24);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 231;
            this.kryptonLabel1.Values.Text = "Election Date";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel2.Location = new System.Drawing.Point(228, 22);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(72, 24);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.kryptonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 229;
            this.kryptonLabel2.Values.Text = "Position";
            // 
            // txtPosition
            // 
            this.txtPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPosition.Location = new System.Drawing.Point(310, 15);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(4);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(199, 31);
            this.txtPosition.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(189)))), ((int)(((byte)(203)))));
            this.txtPosition.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(189)))), ((int)(((byte)(203)))));
            this.txtPosition.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPosition.StateCommon.Border.Rounding = 12;
            this.txtPosition.TabIndex = 228;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Location = new System.Drawing.Point(254, 134);
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
            this.btnCancel.Location = new System.Drawing.Point(445, 133);
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
            // Election
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 620);
            this.Controls.Add(this.panel1);
            this.Name = "Election";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Election";
            this.Load += new System.EventHandler(this.Election_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridViewElection;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblID;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPosition;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubmit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElectionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElectionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElectionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElectionCreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElectionUpdatedAt;
        private System.Windows.Forms.DataGridViewButtonColumn ElectionUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn ElectionDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dateElection;
    }
}