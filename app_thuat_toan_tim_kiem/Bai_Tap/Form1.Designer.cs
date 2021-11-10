namespace Bai_Tap
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
            this.LinerSearch = new System.Windows.Forms.RadioButton();
            this.BinarySearch = new System.Windows.Forms.RadioButton();
            this.TiepTuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LinerSearch
            // 
            this.LinerSearch.AutoSize = true;
            this.LinerSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinerSearch.Location = new System.Drawing.Point(72, 40);
            this.LinerSearch.Name = "LinerSearch";
            this.LinerSearch.Size = new System.Drawing.Size(164, 26);
            this.LinerSearch.TabIndex = 0;
            this.LinerSearch.TabStop = true;
            this.LinerSearch.Text = "Tìm kiếm tuần tự";
            this.LinerSearch.UseVisualStyleBackColor = true;
            // 
            // BinarySearch
            // 
            this.BinarySearch.AutoSize = true;
            this.BinarySearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinarySearch.Location = new System.Drawing.Point(72, 88);
            this.BinarySearch.Name = "BinarySearch";
            this.BinarySearch.Size = new System.Drawing.Size(177, 26);
            this.BinarySearch.TabIndex = 1;
            this.BinarySearch.TabStop = true;
            this.BinarySearch.Text = "Tìm kiếm nhị phân";
            this.BinarySearch.UseVisualStyleBackColor = true;
            // 
            // TiepTuc
            // 
            this.TiepTuc.AllowDrop = true;
            this.TiepTuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TiepTuc.Location = new System.Drawing.Point(104, 144);
            this.TiepTuc.Name = "TiepTuc";
            this.TiepTuc.Size = new System.Drawing.Size(112, 32);
            this.TiepTuc.TabIndex = 2;
            this.TiepTuc.Text = "Tiếp tục";
            this.TiepTuc.UseVisualStyleBackColor = true;
            this.TiepTuc.Click += new System.EventHandler(this.TiepTuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 207);
            this.Controls.Add(this.TiepTuc);
            this.Controls.Add(this.BinarySearch);
            this.Controls.Add(this.LinerSearch);
            this.Name = "Form1";
            this.Text = "Tìm kiếm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton LinerSearch;
        private System.Windows.Forms.RadioButton BinarySearch;
        private System.Windows.Forms.Button TiepTuc;
    }
}