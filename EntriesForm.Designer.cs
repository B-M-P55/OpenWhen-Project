using System;

namespace OpenWhen
{
    partial class EntriesForm
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
            this.txtEntries = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEntries
            // 
            this.txtEntries.Location = new System.Drawing.Point(27, 25);
            this.txtEntries.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEntries.Multiline = true;
            this.txtEntries.Name = "txtEntries";
            this.txtEntries.ReadOnly = true;
            this.txtEntries.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEntries.Size = new System.Drawing.Size(612, 590);
            this.txtEntries.TabIndex = 0;
            this.txtEntries.TextChanged += new System.EventHandler(this.txtEntries_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(27, 628);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(240, 37);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // EntriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(667, 738);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtEntries);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EntriesForm";
            this.Text = "View All Entries";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntries;
        private System.Windows.Forms.Button btnClose;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}