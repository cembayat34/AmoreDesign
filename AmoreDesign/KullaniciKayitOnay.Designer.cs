
namespace AmoreDesign
{
    partial class KullaniciKayitOnay
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSecilenleriOnayla = new System.Windows.Forms.Button();
            this.btnTumunuOnayla = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.sec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sec});
            this.dataGridView1.Location = new System.Drawing.Point(13, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(929, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSecilenleriOnayla
            // 
            this.btnSecilenleriOnayla.Location = new System.Drawing.Point(13, 12);
            this.btnSecilenleriOnayla.Name = "btnSecilenleriOnayla";
            this.btnSecilenleriOnayla.Size = new System.Drawing.Size(175, 44);
            this.btnSecilenleriOnayla.TabIndex = 1;
            this.btnSecilenleriOnayla.Text = "Secilenleri Onayla";
            this.btnSecilenleriOnayla.UseVisualStyleBackColor = true;
            this.btnSecilenleriOnayla.Click += new System.EventHandler(this.btnSecilenleriOnayla_Click);
            // 
            // btnTumunuOnayla
            // 
            this.btnTumunuOnayla.Location = new System.Drawing.Point(194, 12);
            this.btnTumunuOnayla.Name = "btnTumunuOnayla";
            this.btnTumunuOnayla.Size = new System.Drawing.Size(175, 44);
            this.btnTumunuOnayla.TabIndex = 2;
            this.btnTumunuOnayla.Text = "Tumunu Onayla";
            this.btnTumunuOnayla.UseVisualStyleBackColor = true;
            this.btnTumunuOnayla.Click += new System.EventHandler(this.btnTumunuOnayla_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(848, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(94, 29);
            this.btnGeri.TabIndex = 3;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // sec
            // 
            this.sec.HeaderText = "sec";
            this.sec.Name = "sec";
            // 
            // KullaniciKayitOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 450);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnTumunuOnayla);
            this.Controls.Add(this.btnSecilenleriOnayla);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KullaniciKayitOnay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciKayitOnay";
            this.Load += new System.EventHandler(this.KullaniciKayitOnay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSecilenleriOnayla;
        private System.Windows.Forms.Button btnTumunuOnayla;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sec;
    }
}