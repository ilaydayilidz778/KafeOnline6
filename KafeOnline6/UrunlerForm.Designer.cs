namespace KafeOnline6
{
    partial class UrunlerForm
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
            btnEkle = new Button();
            nudBirimFiyat = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            dgvUrunler = new DataGridView();
            txtUrunAd = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(418, 43);
            btnEkle.Margin = new Padding(3, 2, 3, 2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(112, 34);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // nudBirimFiyat
            // 
            nudBirimFiyat.Location = new Point(230, 44);
            nudBirimFiyat.Margin = new Padding(3, 2, 3, 2);
            nudBirimFiyat.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudBirimFiyat.Name = "nudBirimFiyat";
            nudBirimFiyat.Size = new Size(172, 31);
            nudBirimFiyat.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 16);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 7;
            label2.Text = "Birim Fiyatı(₺)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 6;
            label1.Text = "Ürün Adı";
            // 
            // dgvUrunler
            // 
            dgvUrunler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(12, 90);
            dgvUrunler.Margin = new Padding(3, 2, 3, 2);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.RowHeadersWidth = 62;
            dgvUrunler.RowTemplate.Height = 33;
            dgvUrunler.Size = new Size(518, 500);
            dgvUrunler.TabIndex = 11;
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(12, 43);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(201, 31);
            txtUrunAd.TabIndex = 12;
            // 
            // UrunlerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 613);
            Controls.Add(txtUrunAd);
            Controls.Add(dgvUrunler);
            Controls.Add(btnEkle);
            Controls.Add(nudBirimFiyat);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UrunlerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private NumericUpDown nudBirimFiyat;
        private Label label2;
        private Label label1;
        private DataGridView dgvUrunler;
        private TextBox txtUrunAd;
    }
}