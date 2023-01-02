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
    public partial class ClientForm : Form {
        private readonly Client client;
        private ArendaController arendaController;

        public ClientForm(Client currentClient, ArendaController arendaController) {
            InitializeComponent();
            client = currentClient;
            this.arendaController = arendaController;

            UpdateForm();
        }



        private void UpdateForm() {
            listBox1.DataSource = arendaController.GetFlats();
            listBox2.DataSource = arendaController.GetRequests(client);
        }

        private void button4_Click(object sender, EventArgs e) {
            Flat flat = listBox1.SelectedItem as Flat;
            new FlatInfoForm(flat, arendaController.GetFlatsEvaulations(flat)).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            new FlatEvaulationForm(arendaController, listBox1.SelectedItem as Flat, client).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) {
            var result = new ContractRequest(arendaController, listBox1.SelectedItem as Flat, client).ShowDialog();
            
            if (result == DialogResult.OK) {
                UpdateForm();
            }
        }
    }
}
