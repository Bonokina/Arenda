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
    public partial class ManagerForm : Form {
        private ArendaController arendaController;



        public ManagerForm(ArendaController arendaController) {
            InitializeComponent();

            this.arendaController = arendaController;
            UpdateForm();
        }



        private void UpdateForm() {
            listBox1.DataSource = arendaController.GetFlats();
            listBox2.DataSource = arendaController.GetRequests();
            listBox3.DataSource = arendaController.GetContracts();
            listBox4.DataSource = arendaController.GetClients();
        }

        private void button5_Click(object sender, EventArgs e) {
            Flat flat = listBox1.SelectedItem as Flat;
            new FlatInfoForm(flat, arendaController.GetFlatsEvaulations(flat)).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            arendaController.AcceptContract(listBox2.SelectedItem as Contract);
            MessageBox.Show("Договор одобрен.");
            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e) {
            var result = new FlatRegistration(arendaController).ShowDialog();
            
            if (result == DialogResult.OK) {
                UpdateForm();
            }
        }

        private void button6_Click(object sender, EventArgs e) {
            new ContractInfo(listBox2.SelectedItem as Contract).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) {
            new ContractInfo(listBox3.SelectedItem as Contract).ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e) {
            arendaController.Block(listBox4.SelectedItem as Client);
            MessageBox.Show("Пользователь заблокирован.");
        }
    }
}
