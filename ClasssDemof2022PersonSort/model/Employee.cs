using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasssDemof2022PersonSort.model
{
    public class Employee : IComparable<Employee>
    {
        public String Name { get; set; }
        public String Street { get; set; }
        public String City { get; set; }
        public String Phone { get; set; }
        public int Salery { get; set; }

        public Employee():this("NoName", "","","",0)
        {
        }

        public Employee(string name, string street, string city, string phone, int salery)
        {
            Name = name;
            Street = street;
            City = city;
            Phone = phone;
            Salery = salery;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Phone)}: {Phone}, {nameof(Street)}: {Street}, {nameof(City)}: {City}, {nameof(Salery)}: {Salery}";
        }


        //public override bool Equals(object? obj)
        //{
        //    if (obj == null)
        //    {
        //        return false;
        //    }

        //    if (!(obj is Employee))
        //    {
        //        return false;
        //    }

        //    Employee e = obj as Employee;

        //    if (e.Name == Name && e.City == City && e.Phone == Phone && e.Street == Street && e.Salery == Salery)
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        //public override int GetHashCode()
        //{
        //    return Name.GetHashCode()*137 + Phone.GetHashCode();
        //}


        protected bool Equals(Employee other)
        {
            return Name == other.Name && Phone == other.Phone;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Employee)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Phone);
        }


        public int CompareTo(Employee other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return string.Compare(Phone, other.Phone, StringComparison.Ordinal);
        }
    }
}
