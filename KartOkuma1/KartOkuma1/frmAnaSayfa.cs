using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartOkuma1
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
           
        }
        frmSqlBaglanti bgl = new frmSqlBaglanti();

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            serialPort1.DataReceived += serialPort1_DataReceived;

            if (!serialPort1.IsOpen)
                serialPort1.Open();

            Listele();
        }

        private void Listele()
        {
            SqlCommand liste = new SqlCommand("listele", bgl.baglan());
            SqlDataAdapter da = new SqlDataAdapter(liste);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            guncelle();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string kartID = serialPort1.ReadLine();

            this.Invoke(new Action(() =>
            {
                
                txtKartID.Text = kartID;
            }));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            txtAD.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            txtSOYAD.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            txtKytTarih.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            txtKartID.Text = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            lblKontrol.Text = dataGridView1.Rows[sec].Cells[5].Value.ToString();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtAD.Text != "" && txtSOYAD.Text != "" && txtKartID.Text != "")
            {
                kaydet();
               
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kaydet()
        {
            SqlCommand kaydet = new SqlCommand("kaydet", bgl.baglan());
            kaydet.CommandType = CommandType.StoredProcedure;
            kaydet.Parameters.AddWithValue("ad", txtAD.Text);
            kaydet.Parameters.AddWithValue("soyad", txtSOYAD.Text);
            kaydet.Parameters.AddWithValue("date", DateTime.Now);
            kaydet.Parameters.AddWithValue("kid", txtKartID.Text);
            if(lblKontrol.Text == "True")
            {
                kaydet.Parameters.AddWithValue("yetki", 1);
            }
            else
            {
                kaydet.Parameters.AddWithValue("yetki", 0);
            }


            kaydet.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarıyla Eklendi", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (serialPort1.IsOpen)
            {
                string mesaj = "KAYIT:" + txtAD.Text + " " + txtSOYAD.Text;
                serialPort1.WriteLine(mesaj);
            }
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            sil();
            
        }


        private void sil()
        {
            DialogResult dr = MessageBox.Show($"{txtID.Text} Numaralı Kayıt Silinecek. Onaylıyor Musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SqlCommand sil = new SqlCommand("sil", bgl.baglan());
                sil.CommandType = CommandType.StoredProcedure;
                sil.Parameters.AddWithValue("id", int.Parse(txtID.Text));
                sil.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarıyla Silindi", "Kayıt Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (serialPort1.IsOpen)
                {
                    string mesaj = "SIL:" + txtAD.Text + " " + txtSOYAD.Text;
                    serialPort1.WriteLine(mesaj);
                }
                Listele();            
            }

        }


        private void guncelle()
        {
            DialogResult dr = MessageBox.Show($"{txtID.Text} Numaralı Kayıt Güncellenecek. Onaylıyor Musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SqlCommand guncelle = new SqlCommand("guncelle", bgl.baglan());
                guncelle.CommandType = CommandType.StoredProcedure;
                guncelle.Parameters.AddWithValue("id", int.Parse(txtID.Text));
                guncelle.Parameters.AddWithValue("ad", txtAD.Text);
                guncelle.Parameters.AddWithValue("soyad", txtSOYAD.Text);
                guncelle.Parameters.AddWithValue("date", DateTime.Now);
                guncelle.Parameters.AddWithValue("kid", txtKartID.Text);
                if (lblKontrol.Text == "True")
                {
                    guncelle.Parameters.AddWithValue("yetki", 1);
                }
                else
                {
                    guncelle.Parameters.AddWithValue("yetki", 0);
                }
                guncelle.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarıyla Güncellendi", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
        }

        private void temizle()
        {
            txtID.Text = "";
            txtAD.Text = "";
            txtSOYAD.Text = "";
            txtKartID.Text = "";
            txtKytTarih.Text = "";
            rbHayir.Checked = true;
            lblKontrol.Text = "False";
              
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            frmIstatistic fr = new frmIstatistic();
            fr.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rbEvet_CheckedChanged(object sender, EventArgs e)
        {
            if(rbEvet.Checked == true)
            {
                lblKontrol.Text = "True";
            }
            else
            {
                lblKontrol.Text = "False";
            }
        }

        private void lblKontrol_TextChanged(object sender, EventArgs e)
        {
            if(lblKontrol.Text == "True")
            {
                rbEvet.Checked = true;
            }
            else
            {
                rbHayir.Checked = true;
            }
        }
    }
}
