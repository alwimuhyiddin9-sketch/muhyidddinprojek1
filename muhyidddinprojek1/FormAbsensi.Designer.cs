
namespace muhyidddinprojek1
{
    partial class FormAbsensi
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
            this.cbkelas = new System.Windows.Forms.ComboBox();
            this.cbstatus = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btntampil = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnkembali = new System.Windows.Forms.Button();
            this.dgvabsensi = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvabsensi)).BeginInit();
            this.SuspendLayout();
            // 
            // cbkelas
            // 
            this.cbkelas.FormattingEnabled = true;
            this.cbkelas.Location = new System.Drawing.Point(122, 82);
            this.cbkelas.Name = "cbkelas";
            this.cbkelas.Size = new System.Drawing.Size(200, 28);
            this.cbkelas.TabIndex = 0;
            // 
            // cbstatus
            // 
            this.cbstatus.FormattingEnabled = true;
            this.cbstatus.Location = new System.Drawing.Point(122, 153);
            this.cbstatus.Name = "cbstatus";
            this.cbstatus.Size = new System.Drawing.Size(200, 28);
            this.cbstatus.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 223);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btntampil
            // 
            this.btntampil.Location = new System.Drawing.Point(49, 299);
            this.btntampil.Name = "btntampil";
            this.btntampil.Size = new System.Drawing.Size(112, 35);
            this.btntampil.TabIndex = 3;
            this.btntampil.Text = "Tampilkan";
            this.btntampil.UseVisualStyleBackColor = true;
            // 
            // btnsimpan
            // 
            this.btnsimpan.Location = new System.Drawing.Point(167, 299);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(112, 35);
            this.btnsimpan.TabIndex = 4;
            this.btnsimpan.Text = "save";
            this.btnsimpan.UseVisualStyleBackColor = true;
            // 
            // btnkembali
            // 
            this.btnkembali.Location = new System.Drawing.Point(306, 299);
            this.btnkembali.Name = "btnkembali";
            this.btnkembali.Size = new System.Drawing.Size(112, 35);
            this.btnkembali.TabIndex = 5;
            this.btnkembali.Text = "kembali";
            this.btnkembali.UseVisualStyleBackColor = true;
            // 
            // dgvabsensi
            // 
            this.dgvabsensi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvabsensi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvabsensi.Location = new System.Drawing.Point(0, 542);
            this.dgvabsensi.Name = "dgvabsensi";
            this.dgvabsensi.RowHeadersWidth = 62;
            this.dgvabsensi.RowTemplate.Height = 28;
            this.dgvabsensi.Size = new System.Drawing.Size(1200, 150);
            this.dgvabsensi.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 390);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 26);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // FormAbsensi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvabsensi);
            this.Controls.Add(this.btnkembali);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.btntampil);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbstatus);
            this.Controls.Add(this.cbkelas);
            this.Name = "FormAbsensi";
            this.Text = "FormAbsensi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvabsensi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbkelas;
        private System.Windows.Forms.ComboBox cbstatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btntampil;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnkembali;
        private System.Windows.Forms.DataGridView dgvabsensi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}