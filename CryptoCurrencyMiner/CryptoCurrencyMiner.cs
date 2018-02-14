using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoCurrencyMiner
{
    public partial class CryptoCurrencyMiner : Form
    {
        public CryptoCurrencyMiner()
        {
            InitializeComponent();
        }

        private void CryptoCurrencyMiner_Load(object sender, EventArgs e)
        {
            // https://msdn.microsoft.com/en-us/library/system.windows.forms.contextmenu(v=vs.110).aspx
            // Set the dataGridView's context menu
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Start Mining");
            cm.MenuItems.Add("Stop Mining");
            cm.MenuItems.Add("Client Settings");
            cm.MenuItems.Add("Disconnect"); // Make sure it asks "Are you sure?"

            dataGridView1.ContextMenu = cm;

            // Add test data
            dataGridView1.Rows.Add("127.0.0.1", "Test", "240");

            // Start Server
            
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Show the context menu at current mouse position
            dataGridView1.ContextMenu.Show(this, new Point(MousePosition.X, MousePosition.Y));
        }

        private void Stopserver_Click(object sender, EventArgs e)
        {
            // Stop the server
        }

        private void Builderbutton_Click(object sender, EventArgs e)
        {
            // Open builder window
        }
    }
}

