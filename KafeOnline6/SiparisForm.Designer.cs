namespace KafeOnline6
{
    partial class SiparisForm
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
            label1 = new Label();
            label2 = new Label();
            dgvDetaylar = new DataGridView();
            nudAdet = new NumericUpDown();
            cboUrun = new ComboBox();
            btnDetayEkle = new Button();
            cboMasaNo = new ComboBox();
            btnMasaTasi = new Button();
            label3 = new Label();
            label4 = new Label();
            lblMasaNo = new Label();
            btnSiparisIptal = new Button();
            btnOdemeAl = new Button();
            btnAnaSayfayaDon = new Button();
            lblOdemeTutari = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 0;
            label1.Text = "Ürün";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(298, 28);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 1;
            label2.Text = "Adet";
            // 
            // dgvDetaylar
            // 
            dgvDetaylar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetaylar.Location = new Point(22, 107);
            dgvDetaylar.Margin = new Padding(3, 2, 3, 2);
            dgvDetaylar.Name = "dgvDetaylar";
            dgvDetaylar.RowHeadersWidth = 62;
            dgvDetaylar.RowTemplate.Height = 33;
            dgvDetaylar.Size = new Size(577, 476);
            dgvDetaylar.TabIndex = 8;
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(298, 58);
            nudAdet.Margin = new Padding(3, 2, 3, 2);
            nudAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(139, 31);
            nudAdet.TabIndex = 3;
            nudAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboUrun
            // 
            cboUrun.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUrun.FormattingEnabled = true;
            cboUrun.Location = new Point(22, 55);
            cboUrun.Margin = new Padding(3, 2, 3, 2);
            cboUrun.Name = "cboUrun";
            cboUrun.Size = new Size(260, 33);
            cboUrun.TabIndex = 2;
            // 
            // btnDetayEkle
            // 
            btnDetayEkle.Location = new Point(455, 58);
            btnDetayEkle.Margin = new Padding(3, 2, 3, 2);
            btnDetayEkle.Name = "btnDetayEkle";
            btnDetayEkle.Size = new Size(142, 34);
            btnDetayEkle.TabIndex = 4;
            btnDetayEkle.Text = "Ekle";
            btnDetayEkle.UseVisualStyleBackColor = true;
            // 
            // cboMasaNo
            // 
            cboMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboMasaNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMasaNo.FormattingEnabled = true;
            cboMasaNo.Location = new Point(657, 58);
            cboMasaNo.Margin = new Padding(3, 2, 3, 2);
            cboMasaNo.Name = "cboMasaNo";
            cboMasaNo.Size = new Size(186, 33);
            cboMasaNo.TabIndex = 6;
            // 
            // btnMasaTasi
            // 
            btnMasaTasi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMasaTasi.Location = new Point(862, 58);
            btnMasaTasi.Margin = new Padding(3, 2, 3, 2);
            btnMasaTasi.Name = "btnMasaTasi";
            btnMasaTasi.Size = new Size(112, 34);
            btnMasaTasi.TabIndex = 7;
            btnMasaTasi.Text = "Taşı";
            btnMasaTasi.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(657, 29);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 5;
            label3.Text = "Masa No:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(688, 372);
            label4.Name = "label4";
            label4.Size = new Size(135, 28);
            label4.TabIndex = 10;
            label4.Text = "Ödeme Tutarı:";
            // 
            // lblMasaNo
            // 
            lblMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMasaNo.BackColor = Color.Brown;
            lblMasaNo.Font = new Font("Segoe UI Black", 54F, FontStyle.Regular, GraphicsUnit.Point);
            lblMasaNo.ForeColor = SystemColors.ButtonHighlight;
            lblMasaNo.Location = new Point(661, 104);
            lblMasaNo.Name = "lblMasaNo";
            lblMasaNo.Size = new Size(317, 231);
            lblMasaNo.TabIndex = 9;
            lblMasaNo.Text = "00";
            lblMasaNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSiparisIptal
            // 
            btnSiparisIptal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiparisIptal.BackColor = Color.DarkRed;
            btnSiparisIptal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiparisIptal.ForeColor = SystemColors.ButtonFace;
            btnSiparisIptal.Location = new Point(657, 445);
            btnSiparisIptal.Margin = new Padding(3, 2, 3, 2);
            btnSiparisIptal.Name = "btnSiparisIptal";
            btnSiparisIptal.Size = new Size(168, 69);
            btnSiparisIptal.TabIndex = 12;
            btnSiparisIptal.Text = "SİPARİS İPTAL";
            btnSiparisIptal.UseVisualStyleBackColor = false;
            // 
            // btnOdemeAl
            // 
            btnOdemeAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOdemeAl.BackColor = Color.Green;
            btnOdemeAl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOdemeAl.ForeColor = SystemColors.ButtonHighlight;
            btnOdemeAl.Location = new Point(831, 445);
            btnOdemeAl.Margin = new Padding(3, 2, 3, 2);
            btnOdemeAl.Name = "btnOdemeAl";
            btnOdemeAl.Size = new Size(143, 69);
            btnOdemeAl.TabIndex = 13;
            btnOdemeAl.Text = "ÖDEME AL";
            btnOdemeAl.UseVisualStyleBackColor = false;
            // 
            // btnAnaSayfayaDon
            // 
            btnAnaSayfayaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnaSayfayaDon.BackColor = Color.BurlyWood;
            btnAnaSayfayaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnaSayfayaDon.ForeColor = Color.White;
            btnAnaSayfayaDon.Location = new Point(657, 518);
            btnAnaSayfayaDon.Margin = new Padding(3, 2, 3, 2);
            btnAnaSayfayaDon.Name = "btnAnaSayfayaDon";
            btnAnaSayfayaDon.Size = new Size(317, 65);
            btnAnaSayfayaDon.TabIndex = 14;
            btnAnaSayfayaDon.Text = "ANA SAYFAYA DÖN";
            btnAnaSayfayaDon.UseVisualStyleBackColor = false;
            // 
            // lblOdemeTutari
            // 
            lblOdemeTutari.Anchor = AnchorStyles.Right;
            lblOdemeTutari.AutoSize = true;
            lblOdemeTutari.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblOdemeTutari.Location = new Point(862, 372);
            lblOdemeTutari.Name = "lblOdemeTutari";
            lblOdemeTutari.Size = new Size(60, 28);
            lblOdemeTutari.TabIndex = 11;
            lblOdemeTutari.Text = "₺0.00";
            // 
            // SiparisForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 615);
            Controls.Add(lblOdemeTutari);
            Controls.Add(btnAnaSayfayaDon);
            Controls.Add(btnOdemeAl);
            Controls.Add(btnSiparisIptal);
            Controls.Add(lblMasaNo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnMasaTasi);
            Controls.Add(cboMasaNo);
            Controls.Add(btnDetayEkle);
            Controls.Add(cboUrun);
            Controls.Add(nudAdet);
            Controls.Add(dgvDetaylar);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1069, 671);
            Name = "SiparisForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Masa 0";
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvDetaylar;
        private NumericUpDown nudAdet;
        private ComboBox cboUrun;
        private Button btnDetayEkle;
        private ComboBox cboMasaNo;
        private Button btnMasaTasi;
        private Label label3;
        private Label label4;
        private Label lblMasaNo;
        private Button btnSiparisIptal;
        private Button btnOdemeAl;
        private Button btnAnaSayfayaDon;
        private Label lblOdemeTutari;
    }
}