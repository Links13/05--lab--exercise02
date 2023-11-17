namespace RegShowRecords
{
    partial class FrmStudentRecords
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
            this.btnUploadSt = new System.Windows.Forms.Button();
            this.btnFindSt = new System.Windows.Forms.Button();
            this.btnRegisterSt = new System.Windows.Forms.Button();
            this.lvShowText = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnUploadSt
            // 
            this.btnUploadSt.BackColor = System.Drawing.SystemColors.Info;
            this.btnUploadSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadSt.Location = new System.Drawing.Point(593, 217);
            this.btnUploadSt.Name = "btnUploadSt";
            this.btnUploadSt.Size = new System.Drawing.Size(131, 36);
            this.btnUploadSt.TabIndex = 7;
            this.btnUploadSt.Text = "Upload";
            this.btnUploadSt.UseVisualStyleBackColor = false;
            this.btnUploadSt.Click += new System.EventHandler(this.btnUploadSt_Click);
            // 
            // btnFindSt
            // 
            this.btnFindSt.BackColor = System.Drawing.Color.GreenYellow;
            this.btnFindSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindSt.Location = new System.Drawing.Point(593, 146);
            this.btnFindSt.Name = "btnFindSt";
            this.btnFindSt.Size = new System.Drawing.Size(131, 37);
            this.btnFindSt.TabIndex = 6;
            this.btnFindSt.Text = "Find";
            this.btnFindSt.UseVisualStyleBackColor = false;
            this.btnFindSt.Click += new System.EventHandler(this.btnFindSt_Click);
            // 
            // btnRegisterSt
            // 
            this.btnRegisterSt.BackColor = System.Drawing.Color.Gold;
            this.btnRegisterSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterSt.Location = new System.Drawing.Point(593, 79);
            this.btnRegisterSt.Name = "btnRegisterSt";
            this.btnRegisterSt.Size = new System.Drawing.Size(131, 38);
            this.btnRegisterSt.TabIndex = 5;
            this.btnRegisterSt.Text = "Register";
            this.btnRegisterSt.UseVisualStyleBackColor = false;
            this.btnRegisterSt.Click += new System.EventHandler(this.btnRegisterSt_Click);
            // 
            // lvShowText
            // 
            this.lvShowText.HideSelection = false;
            this.lvShowText.Location = new System.Drawing.Point(22, 49);
            this.lvShowText.Name = "lvShowText";
            this.lvShowText.Size = new System.Drawing.Size(552, 255);
            this.lvShowText.TabIndex = 4;
            this.lvShowText.UseCompatibleStateImageBehavior = false;
            this.lvShowText.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "View Records";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmStudentRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(736, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUploadSt);
            this.Controls.Add(this.btnFindSt);
            this.Controls.Add(this.btnRegisterSt);
            this.Controls.Add(this.lvShowText);
            this.Name = "FrmStudentRecords";
            this.Text = "FrmStudentRecords";
            this.Load += new System.EventHandler(this.FrmStudentRecords_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUploadSt;
        private System.Windows.Forms.Button btnFindSt;
        private System.Windows.Forms.Button btnRegisterSt;
        private System.Windows.Forms.ListView lvShowText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}