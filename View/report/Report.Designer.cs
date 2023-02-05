namespace Evoting.View.report
{
    partial class Report
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblTotalVoter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblTotalVoteCast = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblRemainingVoters = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRemainingVoters);
            this.panel1.Controls.Add(this.kryptonLabel5);
            this.panel1.Controls.Add(this.lblTotalVoteCast);
            this.panel1.Controls.Add(this.kryptonLabel3);
            this.panel1.Controls.Add(this.lblTotalVoter);
            this.panel1.Controls.Add(this.kryptonLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 130);
            this.panel1.TabIndex = 0;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel2.Location = new System.Drawing.Point(223, 91);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(182, 22);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.kryptonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 197;
            this.kryptonLabel2.Values.Text = "Total Number of Voters";
            // 
            // lblTotalVoter
            // 
            this.lblTotalVoter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalVoter.Location = new System.Drawing.Point(285, 31);
            this.lblTotalVoter.Margin = new System.Windows.Forms.Padding(4);
            this.lblTotalVoter.Name = "lblTotalVoter";
            this.lblTotalVoter.Size = new System.Drawing.Size(40, 52);
            this.lblTotalVoter.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.lblTotalVoter.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.lblTotalVoter.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVoter.StateNormal.ShortText.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVoter.TabIndex = 198;
            this.lblTotalVoter.Values.Text = "0";
            // 
            // lblTotalVoteCast
            // 
            this.lblTotalVoteCast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalVoteCast.Location = new System.Drawing.Point(492, 31);
            this.lblTotalVoteCast.Margin = new System.Windows.Forms.Padding(4);
            this.lblTotalVoteCast.Name = "lblTotalVoteCast";
            this.lblTotalVoteCast.Size = new System.Drawing.Size(40, 52);
            this.lblTotalVoteCast.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.lblTotalVoteCast.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.lblTotalVoteCast.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVoteCast.StateNormal.ShortText.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVoteCast.TabIndex = 200;
            this.lblTotalVoteCast.Values.Text = "0";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel3.Location = new System.Drawing.Point(450, 91);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(126, 22);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.kryptonLabel3.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 199;
            this.kryptonLabel3.Values.Text = "Total Vote Cast";
            // 
            // lblRemainingVoters
            // 
            this.lblRemainingVoters.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRemainingVoters.Location = new System.Drawing.Point(729, 31);
            this.lblRemainingVoters.Margin = new System.Windows.Forms.Padding(4);
            this.lblRemainingVoters.Name = "lblRemainingVoters";
            this.lblRemainingVoters.Size = new System.Drawing.Size(40, 52);
            this.lblRemainingVoters.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.lblRemainingVoters.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.lblRemainingVoters.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingVoters.StateNormal.ShortText.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingVoters.TabIndex = 202;
            this.lblRemainingVoters.Values.Text = "0";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel5.Location = new System.Drawing.Point(667, 91);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(182, 22);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.kryptonLabel5.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 201;
            this.kryptonLabel5.Values.Text = "Total Remaining Voters";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 136);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(125, 487);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.chart1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(155, 136);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(762, 487);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(759, 484);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 635);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblRemainingVoters;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTotalVoteCast;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTotalVoter;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}