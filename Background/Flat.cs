using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arenda {
    [Serializable]
    public sealed class Flat : IEquatable<Flat> {
        public string Adress { get; set; }
        public int Square { get; set; }
        public int Rooms { get; set; }
        public int Cost { get; set; }
        public string Info { get; set; }



        public Flat(string adress, int square, int rooms, int cost, string info) {
            Adress = adress;
            Square = square;
            Rooms = rooms;
            Cost = cost;
            Info = info;
        }



        public override string ToString() => Adress;

        public bool Equals(Flat other) => Adress == other.Adress;


    }
}
