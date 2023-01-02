using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arenda {
    [Serializable]
    public sealed class Contract {
        public Client Client { get; set; }
        public Flat Flat { get; set; }
        public DateTime RentStartDate { get; set; }
        public DateTime RentEndDate { get; set; }



        public Contract(Client client, Flat flat, DateTime rentStartDate, DateTime rentEndDate) {
            Client = client;
            Flat = flat;
            RentStartDate = rentStartDate;
            RentEndDate = rentEndDate;
        }



        public override string ToString() => Client.ToString() + " " + Flat.ToString();

    }
}
