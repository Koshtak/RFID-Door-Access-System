using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RfidCsharpKodlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.DataReceived += SerialPort1_DataReceived;
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string uid = serialPort1.ReadLine().Trim();//arduinodan id al, boşlukları temizle.
            bool isAuthorized = false;
            string connectionString = "server=localhost;Database=rfidsystem;Trusted_Connection=True;";
        }

        using(SqlConnection conn = new SqlConnection(string connectionString) )
        {
        conn.Open();
        
        SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM authorizedCards WHERE CardUID=@uid", conn);
        cmd.Parameters.AddWithValue("@uid", uid);

        int count = (int).cmd.ExecuteScalar();
        isAuthorized = (Count > 0);
        }

if (isAuthorized)
    serialPort1.WriteLine("ACCESS_GRANTED");
else
    serialPort1.WriteLine("ACCESS_DENIED"); 



    }
}
