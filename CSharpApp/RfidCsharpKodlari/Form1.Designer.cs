namespace RfidCsharpKodlari
{
    partial class Form1
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtLog = new System.Windows.Forms.TextBox();
            this.dataGridViewCards = new System.Windows.Forms.DataGridView();
            this.txtNewUID = new System.Windows.Forms.TextBox();
            this.btnAddUID = new System.Windows.Forms.Button();
            this.btnRemoveUID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCards)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(122, 63);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(100, 20);
            this.txtLog.TabIndex = 0;
            // 
            // dataGridViewCards
            // 
            this.dataGridViewCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCards.Location = new System.Drawing.Point(241, 102);
            this.dataGridViewCards.Name = "dataGridViewCards";
            this.dataGridViewCards.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewCards.TabIndex = 1;
            // 
            // txtNewUID
            // 
            this.txtNewUID.Location = new System.Drawing.Point(149, 277);
            this.txtNewUID.Name = "txtNewUID";
            this.txtNewUID.Size = new System.Drawing.Size(100, 20);
            this.txtNewUID.TabIndex = 2;
            this.txtNewUID.Text = "write here";
            // 
            // btnAddUID
            // 
            this.btnAddUID.Location = new System.Drawing.Point(424, 292);
            this.btnAddUID.Name = "btnAddUID";
            this.btnAddUID.Size = new System.Drawing.Size(75, 23);
            this.btnAddUID.TabIndex = 3;
            this.btnAddUID.Text = "add";
            this.btnAddUID.UseVisualStyleBackColor = true;
            // 
            // btnRemoveUID
            // 
            this.btnRemoveUID.Location = new System.Drawing.Point(558, 291);
            this.btnRemoveUID.Name = "btnRemoveUID";
            this.btnRemoveUID.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveUID.TabIndex = 4;
            this.btnRemoveUID.Text = "remove";
            this.btnRemoveUID.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveUID);
            this.Controls.Add(this.btnAddUID);
            this.Controls.Add(this.txtNewUID);
            this.Controls.Add(this.dataGridViewCards);
            this.Controls.Add(this.txtLog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.DataGridView dataGridViewCards;
        private System.Windows.Forms.TextBox txtNewUID;
        private System.Windows.Forms.Button btnAddUID;
        private System.Windows.Forms.Button btnRemoveUID;
    }
}

