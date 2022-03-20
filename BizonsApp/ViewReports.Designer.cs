
namespace BizonsApp
{
    partial class ViewReports
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
            this.Participant = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sETTINGSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWREPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUMMARYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bYAGEGROUPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bYRACENRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblracenr = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Participant
            // 
            this.Participant.AutoSize = true;
            this.Participant.BackColor = System.Drawing.Color.White;
            this.Participant.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Participant.ForeColor = System.Drawing.Color.RosyBrown;
            this.Participant.Location = new System.Drawing.Point(12, 62);
            this.Participant.Name = "Participant";
            this.Participant.Size = new System.Drawing.Size(580, 46);
            this.Participant.TabIndex = 1;
            this.Participant.Text = "Participant Report Information";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PeachPuff;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.sETTINGSToolStripMenuItem,
            this.vIEWREPORTSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // sETTINGSToolStripMenuItem
            // 
            this.sETTINGSToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.sETTINGSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGOUTToolStripMenuItem});
            this.sETTINGSToolStripMenuItem.ForeColor = System.Drawing.Color.RosyBrown;
            this.sETTINGSToolStripMenuItem.Name = "sETTINGSToolStripMenuItem";
            this.sETTINGSToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.sETTINGSToolStripMenuItem.Text = "SETTINGS";
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.lOGOUTToolStripMenuItem.ForeColor = System.Drawing.Color.RosyBrown;
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // vIEWREPORTSToolStripMenuItem
            // 
            this.vIEWREPORTSToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.vIEWREPORTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sUMMARYToolStripMenuItem,
            this.bYAGEGROUPToolStripMenuItem,
            this.bYRACENRToolStripMenuItem});
            this.vIEWREPORTSToolStripMenuItem.ForeColor = System.Drawing.Color.RosyBrown;
            this.vIEWREPORTSToolStripMenuItem.Name = "vIEWREPORTSToolStripMenuItem";
            this.vIEWREPORTSToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.vIEWREPORTSToolStripMenuItem.Text = "VIEW REPORTS";
            // 
            // sUMMARYToolStripMenuItem
            // 
            this.sUMMARYToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.sUMMARYToolStripMenuItem.ForeColor = System.Drawing.Color.RosyBrown;
            this.sUMMARYToolStripMenuItem.Name = "sUMMARYToolStripMenuItem";
            this.sUMMARYToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sUMMARYToolStripMenuItem.Text = "SUMMARY";
            this.sUMMARYToolStripMenuItem.Click += new System.EventHandler(this.sUMMARYToolStripMenuItem_Click);
            // 
            // bYAGEGROUPToolStripMenuItem
            // 
            this.bYAGEGROUPToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.bYAGEGROUPToolStripMenuItem.ForeColor = System.Drawing.Color.RosyBrown;
            this.bYAGEGROUPToolStripMenuItem.Name = "bYAGEGROUPToolStripMenuItem";
            this.bYAGEGROUPToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bYAGEGROUPToolStripMenuItem.Text = "BY AGE GROUP";
            this.bYAGEGROUPToolStripMenuItem.Click += new System.EventHandler(this.bYAGEGROUPToolStripMenuItem_Click);
            // 
            // bYRACENRToolStripMenuItem
            // 
            this.bYRACENRToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.bYRACENRToolStripMenuItem.ForeColor = System.Drawing.Color.RosyBrown;
            this.bYRACENRToolStripMenuItem.Name = "bYRACENRToolStripMenuItem";
            this.bYRACENRToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bYRACENRToolStripMenuItem.Text = "BY RACE NR.";
            this.bYRACENRToolStripMenuItem.Click += new System.EventHandler(this.bYRACENRToolStripMenuItem_Click);
            // 
            // lblracenr
            // 
            this.lblracenr.AutoSize = true;
            this.lblracenr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblracenr.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblracenr.Location = new System.Drawing.Point(31, 120);
            this.lblracenr.Name = "lblracenr";
            this.lblracenr.Size = new System.Drawing.Size(133, 32);
            this.lblracenr.TabIndex = 3;
            this.lblracenr.Text = "Race Nr.:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Select race nr.",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox1.Location = new System.Drawing.Point(170, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 37);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(20, 163);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1009, 439);
            this.reportViewer1.TabIndex = 28;
            // 
            // ViewReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 642);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblracenr);
            this.Controls.Add(this.Participant);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewReports";
            this.Text = "ViewReports";
            this.Load += new System.EventHandler(this.ViewReports_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Participant;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sETTINGSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWREPORTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUMMARYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bYAGEGROUPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bYRACENRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.Label lblracenr;
        private System.Windows.Forms.ComboBox comboBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}