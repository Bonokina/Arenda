using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arenda {
    [Serializable]
    public class Client : IEquatable<Client> {
        public string Name { get; set; }
        public string Forname { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirth { get; set; }
        public PhoneNumber PhoneNumber { get; set; }



        public Client(string name, string forname, string patronymic, DateTime dateOfBirth, PhoneNumber phoneNumber) {
            Name = name;
            Forname = forname;
            Patronymic = patronymic;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
        }



        public override string ToString() => Forname + Name[0] + '.' + Patronymic[0] + '.';
        public bool Equals(Client other) {
            return other.Forname == Forname && other.DateOfBirth == DateOfBirth && other.PhoneNumber.Equals(PhoneNumber);
        }
        
    }
}
