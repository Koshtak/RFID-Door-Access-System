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
    public partial class frmIstatistic : Form
    {
        public frmIstatistic()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        frmSqlBaglanti bgl = new frmSqlBaglanti();
        private void frmIstatistic_Load(object sender, EventArgs e)
        {
            toplamKayit();
            bgnKayit();
            toplamYetkiliSay();
            toplamYetkisizSay();
                
        }


        private void toplamKayit()
        {
            SqlCommand toplam = new SqlCommand("select COUNT(*) from Kayıt", bgl.baglan());
            SqlDataReader dr = toplam.ExecuteReader();
            while (dr.Read())
            {
                lblToplamKayit.Text = dr[0].ToString();
            }
            
        }


        private void bgnKayit()
        {
            SqlCommand bgntop = new SqlCommand("select COUNT(*) from Kayıt WHERE CAST(date AS DATE) = CAST(GETDATE() AS DATE);", bgl.baglan());
            SqlDataReader dr = bgntop.ExecuteReader();
            while (dr.Read())
            {
                lblBgnKayit.Text = dr[0].ToString();
            }

        }

        private void toplamYetkiliSay()
        {
            SqlCommand toplamYetkiliSay = new SqlCommand("select COUNT(*) from Kayıt WHERE yetki = 1", bgl.baglan());
            SqlDataReader dr = toplamYetkiliSay.ExecuteReader();
            while (dr.Read())
            {
                lblYetkiliSay.Text = dr[0].ToString();
            }
        }

        private void toplamYetkisizSay()
        {
            SqlCommand toplamYetkisizSay = new SqlCommand("select COUNT(*) from Kayıt WHERE yetki = 0", bgl.baglan());
            SqlDataReader dr = toplamYetkisizSay.ExecuteReader();
            while (dr.Read())
            {
                lblYetkisizSay.Text = dr[0].ToString();
            }
        }


    }
}
