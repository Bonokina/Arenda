using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Arenda {
    [Serializable]
    public sealed class PhoneNumber : IEquatable<PhoneNumber> {
        public string Number { get; }



        public PhoneNumber(long number) {
            if (number > 79999999999 || number < 70000000000) {
                throw new FormatException("Неверный формат номера");
            }

            Number = "+" + number.ToString();
        }



        public bool Equals(PhoneNumber other) => Number == other.Number;

        public override string ToString() => Number.ToString();

    }
}
