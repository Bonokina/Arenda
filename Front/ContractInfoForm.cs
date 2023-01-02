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
    public partial class ContractInfo : Form {


        public ContractInfo(Contract contract) {
            InitializeComponent();
            textBox9.Text = contract.Client.Name;
            textBox8.Text = contract.Client.Forname;
            textBox7.Text = contract.Client.Patronymic;
            textBox10.Text = contract.Client.DateOfBirth.ToShortDateString();
            textBox6.Text = contract.Client.PhoneNumber.ToString();

            textBox13.Text = contract.Flat.Adress;
            textBox12.Text = contract.Flat.Square.ToString();
            textBox3.Text = contract.Flat.Rooms.ToString();
            textBox4.Text = contract.Flat.Cost.ToString();
            textBox5.Text = contract.Flat.Info;

            textBox1.Text = contract.RentStartDate.ToShortDateString();
            textBox2.Text = contract.RentEndDate.ToShortDateString();
            textBox11.Text = (contract.Flat.Cost * ((contract.RentEndDate - contract.RentStartDate).Days + 1)).ToString();
        }


    }
}
