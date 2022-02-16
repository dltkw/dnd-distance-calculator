
namespace dnd_distance_calculator
{
    partial class MainForm
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
            this.btn_ExcelImport = new System.Windows.Forms.Button();
            this.cmb_From = new System.Windows.Forms.ComboBox();
            this.lbl_From = new System.Windows.Forms.Label();
            this.lbl_To = new System.Windows.Forms.Label();
            this.cmb_To = new System.Windows.Forms.ComboBox();
            this.lbl_Distance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ExcelImport
            // 
            this.btn_ExcelImport.Location = new System.Drawing.Point(44, 37);
            this.btn_ExcelImport.Name = "btn_ExcelImport";
            this.btn_ExcelImport.Size = new System.Drawing.Size(199, 328);
            this.btn_ExcelImport.TabIndex = 0;
            this.btn_ExcelImport.Text = "Import from Excel";
            this.btn_ExcelImport.UseVisualStyleBackColor = true;
            this.btn_ExcelImport.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_From
            // 
            this.cmb_From.FormattingEnabled = true;
            this.cmb_From.Location = new System.Drawing.Point(386, 47);
            this.cmb_From.Name = "cmb_From";
            this.cmb_From.Size = new System.Drawing.Size(121, 21);
            this.cmb_From.TabIndex = 1;
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Location = new System.Drawing.Point(350, 50);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(30, 13);
            this.lbl_From.TabIndex = 2;
            this.lbl_From.Text = "From";
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Location = new System.Drawing.Point(350, 88);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(20, 13);
            this.lbl_To.TabIndex = 4;
            this.lbl_To.Text = "To";
            // 
            // cmb_To
            // 
            this.cmb_To.FormattingEnabled = true;
            this.cmb_To.Location = new System.Drawing.Point(386, 85);
            this.cmb_To.Name = "cmb_To";
            this.cmb_To.Size = new System.Drawing.Size(121, 21);
            this.cmb_To.TabIndex = 3;
            // 
            // lbl_Distance
            // 
            this.lbl_Distance.AutoSize = true;
            this.lbl_Distance.Location = new System.Drawing.Point(350, 130);
            this.lbl_Distance.Name = "lbl_Distance";
            this.lbl_Distance.Size = new System.Drawing.Size(108, 13);
            this.lbl_Distance.TabIndex = 5;
            this.lbl_Distance.Text = "This journey will take...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Distance);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.cmb_To);
            this.Controls.Add(this.lbl_From);
            this.Controls.Add(this.cmb_From);
            this.Controls.Add(this.btn_ExcelImport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ExcelImport;
        private System.Windows.Forms.ComboBox cmb_From;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.ComboBox cmb_To;
        private System.Windows.Forms.Label lbl_Distance;
    }
}

