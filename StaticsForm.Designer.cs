namespace Catalog
{
    partial class StaticsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaticsForm));
            this.panelTotal = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panelMale = new System.Windows.Forms.Panel();
            this.labelMale = new System.Windows.Forms.Label();
            this.panelFemale = new System.Windows.Forms.Panel();
            this.labelFemale = new System.Windows.Forms.Label();
            this.panelTotal.SuspendLayout();
            this.panelMale.SuspendLayout();
            this.panelFemale.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.Orange;
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.ForeColor = System.Drawing.Color.Orange;
            this.panelTotal.Location = new System.Drawing.Point(-1, -1);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(745, 163);
            this.panelTotal.TabIndex = 0;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(173, 61);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(437, 55);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "Total studenți: 100";
            this.labelTotal.MouseEnter += new System.EventHandler(this.labelTotal_MouseEnter);
            this.labelTotal.MouseLeave += new System.EventHandler(this.labelTotal_MouseLeave);
            // 
            // panelMale
            // 
            this.panelMale.BackColor = System.Drawing.Color.Navy;
            this.panelMale.Controls.Add(this.labelMale);
            this.panelMale.Location = new System.Drawing.Point(-1, 156);
            this.panelMale.Name = "panelMale";
            this.panelMale.Size = new System.Drawing.Size(373, 200);
            this.panelMale.TabIndex = 2;
            // 
            // labelMale
            // 
            this.labelMale.AutoSize = true;
            this.labelMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMale.ForeColor = System.Drawing.Color.White;
            this.labelMale.Location = new System.Drawing.Point(43, 75);
            this.labelMale.Name = "labelMale";
            this.labelMale.Size = new System.Drawing.Size(260, 55);
            this.labelMale.TabIndex = 3;
            this.labelMale.Text = "Elevi: 50%";
            this.labelMale.Click += new System.EventHandler(this.label2_Click);
            this.labelMale.MouseEnter += new System.EventHandler(this.labelMale_MouseEnter);
            this.labelMale.MouseLeave += new System.EventHandler(this.labelMale_MouseLeave);
            // 
            // panelFemale
            // 
            this.panelFemale.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panelFemale.Controls.Add(this.labelFemale);
            this.panelFemale.Location = new System.Drawing.Point(371, 156);
            this.panelFemale.Name = "panelFemale";
            this.panelFemale.Size = new System.Drawing.Size(373, 200);
            this.panelFemale.TabIndex = 3;
            // 
            // labelFemale
            // 
            this.labelFemale.AutoSize = true;
            this.labelFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFemale.ForeColor = System.Drawing.Color.White;
            this.labelFemale.Location = new System.Drawing.Point(37, 75);
            this.labelFemale.Name = "labelFemale";
            this.labelFemale.Size = new System.Drawing.Size(277, 55);
            this.labelFemale.TabIndex = 4;
            this.labelFemale.Text = "Eleve: 50%";
            this.labelFemale.MouseEnter += new System.EventHandler(this.labelFemale_MouseEnter);
            this.labelFemale.MouseLeave += new System.EventHandler(this.labelFemale_MouseLeave);
            // 
            // StaticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 353);
            this.Controls.Add(this.panelTotal);
            this.Controls.Add(this.panelFemale);
            this.Controls.Add(this.panelMale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StaticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnyDesk";
            this.Load += new System.EventHandler(this.StaticsForm_Load);
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.panelMale.ResumeLayout(false);
            this.panelMale.PerformLayout();
            this.panelFemale.ResumeLayout(false);
            this.panelFemale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Panel panelMale;
        private System.Windows.Forms.Label labelMale;
        private System.Windows.Forms.Panel panelFemale;
        private System.Windows.Forms.Label labelFemale;
    }
}