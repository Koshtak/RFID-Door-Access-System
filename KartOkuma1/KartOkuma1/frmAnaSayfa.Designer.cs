namespace KartOkuma1
{
    partial class frmAnaSayfa
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtKartID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKytTarih = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSOYAD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.rbEvet = new System.Windows.Forms.RadioButton();
            this.rbHayir = new System.Windows.Forms.RadioButton();
            this.lblKontrol = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(925, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 50);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel2.Controls.Add(this.txtKartID, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtKytTarih, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSOYAD, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtAD, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(919, 50);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtKartID
            // 
            this.txtKartID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKartID.Location = new System.Drawing.Point(796, 3);
            this.txtKartID.Multiline = true;
            this.txtKartID.Name = "txtKartID";
            this.txtKartID.Size = new System.Drawing.Size(120, 44);
            this.txtKartID.TabIndex = 9;
            this.txtKartID.TextChanged += new System.EventHandler(this.txtKartID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(735, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 50);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kart ID";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKytTarih
            // 
            this.txtKytTarih.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKytTarih.Enabled = false;
            this.txtKytTarih.Location = new System.Drawing.Point(613, 3);
            this.txtKytTarih.Multiline = true;
            this.txtKytTarih.Name = "txtKytTarih";
            this.txtKytTarih.Size = new System.Drawing.Size(116, 44);
            this.txtKytTarih.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(552, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 50);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kayıt Tarihi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSOYAD
            // 
            this.txtSOYAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSOYAD.Location = new System.Drawing.Point(430, 3);
            this.txtSOYAD.Multiline = true;
            this.txtSOYAD.Name = "txtSOYAD";
            this.txtSOYAD.Size = new System.Drawing.Size(116, 44);
            this.txtSOYAD.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(369, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAD
            // 
            this.txtAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAD.Location = new System.Drawing.Point(247, 3);
            this.txtAD.Multiline = true;
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(116, 44);
            this.txtAD.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(186, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kişi ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtID
            // 
            this.txtID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(64, 3);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(116, 44);
            this.txtID.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(919, 256);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.btnIstatistik, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnTemizle, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnGüncelle, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnSil, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnKaydet, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnListele, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 358);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(919, 89);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIstatistik.Image = global::KartOkuma1.Properties.Resources.statistics;
            this.btnIstatistik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIstatistik.Location = new System.Drawing.Point(615, 47);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(301, 39);
            this.btnIstatistik.TabIndex = 6;
            this.btnIstatistik.Text = "İSTATİSTİKLER";
            this.btnIstatistik.UseVisualStyleBackColor = true;
            this.btnIstatistik.UseWaitCursor = true;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTemizle.Image = global::KartOkuma1.Properties.Resources.archeology;
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.Location = new System.Drawing.Point(309, 47);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(300, 39);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.UseWaitCursor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGüncelle.Image = global::KartOkuma1.Properties.Resources.refresh__1_;
            this.btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGüncelle.Location = new System.Drawing.Point(3, 47);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(300, 39);
            this.btnGüncelle.TabIndex = 4;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.UseWaitCursor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSil.Image = global::KartOkuma1.Properties.Resources.remove;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(615, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(301, 38);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.UseWaitCursor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKaydet.Image = global::KartOkuma1.Properties.Resources.save;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(309, 3);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(300, 38);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.UseWaitCursor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnListele
            // 
            this.btnListele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnListele.Image = global::KartOkuma1.Properties.Resources.bullet_list;
            this.btnListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListele.Location = new System.Drawing.Point(3, 3);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(300, 38);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.UseWaitCursor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.rbEvet, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.rbHayir, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblKontrol, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 59);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(919, 31);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Yetki:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbEvet
            // 
            this.rbEvet.AutoSize = true;
            this.rbEvet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbEvet.Location = new System.Drawing.Point(302, 3);
            this.rbEvet.Name = "rbEvet";
            this.rbEvet.Size = new System.Drawing.Size(293, 25);
            this.rbEvet.TabIndex = 1;
            this.rbEvet.TabStop = true;
            this.rbEvet.Text = "EVET";
            this.rbEvet.UseVisualStyleBackColor = true;
            this.rbEvet.CheckedChanged += new System.EventHandler(this.rbEvet_CheckedChanged);
            // 
            // rbHayir
            // 
            this.rbHayir.AutoSize = true;
            this.rbHayir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbHayir.Location = new System.Drawing.Point(601, 3);
            this.rbHayir.Name = "rbHayir";
            this.rbHayir.Size = new System.Drawing.Size(293, 25);
            this.rbHayir.TabIndex = 2;
            this.rbHayir.TabStop = true;
            this.rbHayir.Text = "HAYIR";
            this.rbHayir.UseVisualStyleBackColor = true;
            // 
            // lblKontrol
            // 
            this.lblKontrol.AutoSize = true;
            this.lblKontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKontrol.Location = new System.Drawing.Point(900, 0);
            this.lblKontrol.Name = "lblKontrol";
            this.lblKontrol.Size = new System.Drawing.Size(16, 31);
            this.lblKontrol.TabIndex = 3;
            this.lblKontrol.Text = "label7";
            this.lblKontrol.Visible = false;
            this.lblKontrol.TextChanged += new System.EventHandler(this.lblKontrol_TextChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAnaSayfa";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtKartID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKytTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSOYAD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbEvet;
        private System.Windows.Forms.RadioButton rbHayir;
        private System.Windows.Forms.Label lblKontrol;
    }
}