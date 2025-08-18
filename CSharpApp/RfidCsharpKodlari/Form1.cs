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
using System.Net.Http;
using System.Net.Http.Json; // for convenient JSON methods


namespace RfidCsharpKodlari
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient http = new HttpClient();

        private readonly string apiBase = "https://localhost:7168/api/cards";

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            InitializeSerialPort();
            await LoadAuthorizedCardsAsync();
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

        private async Task LoadAuthorizedCardsAsync()
        {
            try
            {
                var list = await http.GetFromJsonAsync<List<AuthorizedCardDto>>(apiBase);
                // Show in grid
                dataGridViewCards.DataSource = list;
                Log("Cards loaded from API.");
            }
            catch (Exception ex)
            {
                Log("Error loading cards from API: " + ex.Message);
            }
        }

        // Small DTO just for the grid (you can also reuse your model shape)
        private class AuthorizedCardDto
        {
            public int Id { get; set; }
            public string CardUID { get; set; }
            public string UserName { get; set; }
            public DateTime CreatedAt { get; set; }
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string uid = serialPort1.ReadLine().Trim();
            BeginInvoke(new Action(async () =>
            {
                txtNewUID.Text = uid;

                bool isAuthorized = await CheckAuthorizationAsync(uid);
                string response = isAuthorized ? "ACCESS_GRANTED" : "ACCESS_DENIED";

                serialPort1.WriteLine(response);
                Log($"Card Read: {uid} → {response}");
            }));
        }


        private async Task<bool> CheckAuthorizationAsync(string uid)
        {
            try
            {
                var result = await http.GetFromJsonAsync<AuthResult>($"{apiBase}/check/{Uri.EscapeDataString(uid)}");
                return result?.authorized ?? false;
            }
            catch (Exception ex)
            {
                Log("Error checking UID via API: " + ex.Message);
                return false;
            }
        }

        private class AuthResult { public bool authorized { get; set; } }


        private async void btnAddUID_Click(object sender, EventArgs e)
        {
            string newUID = txtNewUID.Text.Trim();
            if (string.IsNullOrEmpty(newUID)) return;

            try
            {
                var payload = new { CardUID = newUID, UserName = "" };
                var res = await http.PostAsJsonAsync(apiBase, payload);
                if (res.IsSuccessStatusCode)
                {
                    Log($"Added UID via API: {newUID}");
                    txtNewUID.Clear();
                    await LoadAuthorizedCardsAsync();
                }
                else if (res.StatusCode == System.Net.HttpStatusCode.Conflict)
                {
                    Log("UID already exists.");
                }
                else
                {
                    Log("Add failed: " + res.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Log("Error adding UID via API: " + ex.Message);
            }
        }


        private async void btnRemoveUID_Click(object sender, EventArgs e)
        {
            if (dataGridViewCards.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridViewCards.CurrentRow.Cells["Id"].Value);
            try
            {
                var res = await http.DeleteAsync($"{apiBase}/{id}");
                if (res.IsSuccessStatusCode || res.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    Log($"Removed card Id={id} via API");
                    await LoadAuthorizedCardsAsync();
                }
                else
                {
                    Log("Delete failed: " + res.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Log("Error removing UID via API: " + ex.Message);
            }
        }

        private void Log(string message)
        {
            txtLog.AppendText($"{DateTime.Now}: {message}{Environment.NewLine}");
        }

       
    }
}
