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
    public partial class FlatEvaulationForm : Form {
        private ArendaController arendaController;
        private Flat flat;
        private Client client;



        public FlatEvaulationForm(ArendaController arendaController, Flat flat, Client client) {
            InitializeComponent();
            this.arendaController = arendaController;
            this.flat = flat;
            this.client = client;

            textBox1.Text = flat.Adress;
            textBox2.Text = flat.Square.ToString();
            textBox3.Text = flat.Rooms.ToString();
            textBox4.Text = flat.Cost.ToString();
            textBox5.Text = flat.Info;
        }



        private void button1_Click(object sender, EventArgs e) {
            arendaController.Evaulate(flat, client, ((int)numericUpDown1.Value));
            MessageBox.Show("Спасибо за отзыв!");
            this.Close();
        }

    }
}
