using Arenda;
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
    public partial class LoginForm : Form {
        private ArendaController arendaController;
        public LoginForm(ArendaController arendaController) {
            InitializeComponent();
            this.arendaController = arendaController;
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Hide();
            new ManagerForm(arendaController).ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Hide();
            new ClientLogin(arendaController).ShowDialog();
            this.Close();
        }
    }
}
