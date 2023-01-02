using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arenda {
    [Serializable]
    public struct FlatEvaluation {
        public Flat Flat { get; set; }
        public Client Client { get; set; }
        public int Evaluation { get; set; }



        public FlatEvaluation(Flat flat, Client client, int evaulation) {
            Flat = flat;
            Client = client;
            Evaluation = evaulation;
        }



        public override string ToString() => Client.ToString() + " : " + Evaluation.ToString();

    }
}
