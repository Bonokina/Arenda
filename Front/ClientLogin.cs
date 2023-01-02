using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arenda {
    public partial class ClientLogin : Form {
        private ArendaController arendaController;
        public ClientLogin(ArendaController arendaController) {
            InitializeComponent();
            this.arendaController = arendaController;
            listBox1.DataSource = arendaController.GetClients();
        }

        private void button1_Click(object sender, EventArgs e) {
            bool blocked = arendaController.IsBlocked(listBox1.SelectedItem as Client);
            if (blocked) {
                MessageBox.Show("Пользователь заблокирован.");
                return;
            }

            this.Hide();
            new ClientForm(listBox1.SelectedItem as Client, arendaController).ShowDialog();
            this.Close();
        }
    }
}
