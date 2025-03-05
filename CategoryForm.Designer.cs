using System;

namespace OpenWhen
{
    partial class CategoryForm
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
            this.label = new System.Windows.Forms.Label();
            this.txtBeforeReading = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.txtAfterReading = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.PeachPuff;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label.Location = new System.Drawing.Point(12, 21);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(379, 25);
            this.label.TabIndex = 0;
            this.label.Text = "Feel free to write it down how you feel.";
            // 
            // txtBeforeReading
            // 
            this.txtBeforeReading.BackColor = System.Drawing.Color.White;
            this.txtBeforeReading.Location = new System.Drawing.Point(25, 68);
            this.txtBeforeReading.Multiline = true;
            this.txtBeforeReading.Name = "txtBeforeReading";
            this.txtBeforeReading.Size = new System.Drawing.Size(426, 115);
            this.txtBeforeReading.TabIndex = 1;
            this.txtBeforeReading.Text = "Before Reading";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxMessage.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxMessage.Location = new System.Drawing.Point(25, 199);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ReadOnly = true;
            this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessage.Size = new System.Drawing.Size(426, 100);
            this.textBoxMessage.TabIndex = 2;
            // 
            // txtAfterReading
            // 
            this.txtAfterReading.BackColor = System.Drawing.Color.White;
            this.txtAfterReading.Location = new System.Drawing.Point(25, 319);
            this.txtAfterReading.Multiline = true;
            this.txtAfterReading.Name = "txtAfterReading";
            this.txtAfterReading.Size = new System.Drawing.Size(426, 104);
            this.txtAfterReading.TabIndex = 3;
            this.txtAfterReading.Text = "After Reading";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(36, 460);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 38);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(315, 460);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 38);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(482, 550);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAfterReading);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.txtBeforeReading);
            this.Controls.Add(this.label);
            this.Name = "CategoryForm";
            this.Text = "Category_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtBeforeReading;
        private System.Windows.Forms.TextBox textBoxMessage; // Replace label2 with TextBox
        private System.Windows.Forms.TextBox txtAfterReading;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        private void btnSave_Click(object sender, EventArgs e)
        {
            (this as CategoryForm).SaveEntry();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}