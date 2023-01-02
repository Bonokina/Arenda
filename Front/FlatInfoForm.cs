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
    public partial class FlatInfoForm : Form {
        public FlatInfoForm(Flat flat, IEnumerable<FlatEvaluation> flatEvaluations) {
            InitializeComponent();

            textBox1.Text = flat.Adress;
            textBox2.Text = flat.Square.ToString();
            textBox3.Text = flat.Rooms.ToString();
            textBox4.Text = flat.Cost.ToString();
            textBox5.Text = flat.Info;
            listBox1.DataSource = flatEvaluations;
        }
    }
}
