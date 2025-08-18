using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace KartOkuma1
{
    public partial class frmKyt : Form
    {
        public frmKyt()
        {
            InitializeComponent();
        }
        frmSqlBaglanti bgl = new frmSqlBaglanti();

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            if(txtKulAdi.Text != "" && txtSifre.Text != "")
            {
                SqlCommand kayit = new SqlCommand("kayitOl", bgl.baglan());
                kayit.CommandType = CommandType.StoredProcedure;
                kayit.Parameters.AddWithValue("kulname", txtKulAdi.Text);
                kayit.Parameters.AddWithValue("sifre", txtSifre.Text);
                kayit.ExecuteNonQuery();
                MessageBox.Show("Kayıt İşlemi Başarılı", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmKyt_Load(object sender, EventArgs e)
        {
            {
                this.AcceptButton = btnKayıtOl;
                txtSifre.Multiline = false;
            }
        }
    }
}
