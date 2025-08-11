using System.Data.SqlClient;
namespace KartOkuma1
{
    internal class frmSqlBaglanti
    {
        string adres = @"Data Source=Berkay\SQLEXPRESS;Initial Catalog=KayıtSistemiDB;Integrated Security=True;Encrypt=False;";

        
        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection(adres);
            baglanti.Open();    
            return baglanti;

        }


    }
}
