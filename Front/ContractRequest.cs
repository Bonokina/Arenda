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
    public partial class ContractRequest : Form {
        private ArendaController arendaController;
        private Flat flat;
        private Client client;



        public ContractRequest(ArendaController arendaController, Flat flat, Client client) {
            InitializeComponent();
            textBox2.Text = flat.ToString();
            textBox1.Text = client.ToString();
            this.arendaController = arendaController;
            this.flat = flat;
            this.client = client;
        }



        private void button1_Click(object sender, EventArgs e) {
            arendaController.TakeRequest(client, flat, dateTimePicker1.Value, dateTimePicker2.Value);
            MessageBox.Show("Запрос подан успешно!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
