using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arenda {
    [Serializable]
    public sealed class ClientRequest {
        public Client Client { get; set; }
        public Flat Flat { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }



        public ClientRequest(Client client, Flat flat, DateTime start, DateTime end) {
            Client = client;
            Flat = flat;
            Start = start;
            End = end;
        }



        public override string ToString() => Client.ToString() + " " + Flat.ToString();

    }
}
