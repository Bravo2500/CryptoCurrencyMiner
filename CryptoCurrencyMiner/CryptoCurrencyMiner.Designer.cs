namespace CryptoCurrencyMiner
{
    partial class CryptoCurrencyMiner
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IpColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HashColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Builderbutton = new System.Windows.Forms.Button();
            this.Stopserver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crypto Currency Miner Server Alpha";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IpColumn,
            this.NameColumn,
            this.HashColumn});
            this.dataGridView1.Location = new System.Drawing.Point(16, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(593, 290);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // IpColumn
            // 
            this.IpColumn.HeaderText = "IP";
            this.IpColumn.Name = "IpColumn";
            this.IpColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Host Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 200;
            // 
            // HashColumn
            // 
            this.HashColumn.HeaderText = "Hash Rate";
            this.HashColumn.Name = "HashColumn";
            this.HashColumn.ReadOnly = true;
            // 
            // Builderbutton
            // 
            this.Builderbutton.Location = new System.Drawing.Point(16, 334);
            this.Builderbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Builderbutton.Name = "Builderbutton";
            this.Builderbutton.Size = new System.Drawing.Size(100, 28);
            this.Builderbutton.TabIndex = 2;
            this.Builderbutton.Text = "Builder";
            this.Builderbutton.UseVisualStyleBackColor = true;
            this.Builderbutton.Click += new System.EventHandler(this.Builderbutton_Click);
            // 
            // Stopserver
            // 
            this.Stopserver.Location = new System.Drawing.Point(509, 334);
            this.Stopserver.Margin = new System.Windows.Forms.Padding(4);
            this.Stopserver.Name = "Stopserver";
            this.Stopserver.Size = new System.Drawing.Size(100, 28);
            this.Stopserver.TabIndex = 3;
            this.Stopserver.Text = "Stop Server";
            this.Stopserver.UseVisualStyleBackColor = true;
            this.Stopserver.Click += new System.EventHandler(this.Stopserver_Click);
            // 
            // CryptoCurrencyMiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(625, 377);
            this.Controls.Add(this.Stopserver);
            this.Controls.Add(this.Builderbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CryptoCurrencyMiner";
            this.Text = "Crypto Currency Miner Server";
            this.Load += new System.EventHandler(this.CryptoCurrencyMiner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Builderbutton;
        private System.Windows.Forms.Button Stopserver;
        private System.Windows.Forms.DataGridViewTextBoxColumn IpColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HashColumn;
    }
}

