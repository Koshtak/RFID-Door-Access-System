using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
        private readonly string connectionString = "server=localhost;Database=rfidsystem;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeSerialPort();
            LoadAuthorizedCards();
        }

       
        private void InitializeSerialPort()
        {
            try
            {
                serialPort1.DataReceived += SerialPort1_DataReceived;
                serialPort1.Open();
                Log("Serial port open.");
            }
            catch (Exception ex)
            {
                Log("opening serial port error " + ex.Message);
            }

        }

        private void LoadAuthorizedCards()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM authorizedCards";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    System.Data.DataTable dt = new System.Data.DataTable();
                    adapter.Fill(dt);
                    dataGridViewCards.DataSource = dt;

                    Log("Cards loaded from database.");
                }
            }
            catch (Exception ex)
            {
                Log("Error loading cards: " + ex.Message);
            }
        }
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string uid = serialPort1.ReadLine().Trim();
            // Debug output to verify what's being received
            Debug.WriteLine($"Received UID: {uid}");

            bool isAuthorized = CheckAuthorization(uid);
            string response = isAuthorized ? "ACCESS_GRANTED" : "ACCESS_DENIED";

            serialPort1.WriteLine(response);
            Invoke(new Action(() => Log($"Card Read: {uid} → {response}")));
        }

        private bool CheckAuthorization(string uid)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM authorizedCards WHERE CardUID = @uid";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@uid", uid);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>{Log("Error checking UID: " + ex.Message);}));
                return false;
            }
        }

        private void btnAddUID_Click(object sender, EventArgs e)
        {
            string newUID = txtNewUID.Text.Trim();
            if (string.IsNullOrEmpty(newUID)) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO authorizedCards (CardUID) VALUES (@uid)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@uid", newUID);
                    cmd.ExecuteNonQuery();
                }

                Log($"Added UID: {newUID}");
                txtNewUID.Clear();
                LoadAuthorizedCards();
            }
            catch (Exception ex)
            {
                Log("Error adding UID: " + ex.Message);
            }
        }

        private void btnRemoveUID_Click(object sender, EventArgs e)
        {
            if (dataGridViewCards.CurrentRow == null) return;

            string uidToRemove = dataGridViewCards.CurrentRow.Cells["CardUID"].Value.ToString();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "DELETE FROM authorizedCards WHERE CardUID = @uid";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@uid", uidToRemove);
                    cmd.ExecuteNonQuery();
                }

                Log($"Removed UID: {uidToRemove}");
                LoadAuthorizedCards();
            }
            catch (Exception ex)
            {
                Log("Error removing UID: " + ex.Message);
            }
        }
        private void Log(string message)
        {
            txtLog.AppendText($"{DateTime.Now}: {message}{Environment.NewLine}");
        }

       
    }
}
