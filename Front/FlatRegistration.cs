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
    public partial class FlatRegistration : Form {
        private ArendaController arendaController;



        public FlatRegistration(ArendaController arendaController) {
            InitializeComponent();
            this.arendaController = arendaController;
        }



        private void button1_Click(object sender, EventArgs e) {
            arendaController.RegisterFlat(new Flat(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text), textBox5.Text));
            MessageBox.Show("Квартира зарегистрирована!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
