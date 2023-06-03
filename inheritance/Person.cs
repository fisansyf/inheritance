using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Person
    {
        //property
        public string Name { get; set; }
        public int Age { get; set; }

        //constructor
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public Person()
        {

        }

        //fungsi
        public void InfoPerson(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
            Console.WriteLine("Nama saya {0}, dan berumur {1} tahun\n", this.Name, this.Age);
        }
    }
    //class turunan
    public class karyawan : Person
    {
        //property
        public string karyawanID { get; set; }
        public string subject { get; set; }

        //constructor
        public karyawan(string karyawanID, string subject)
        {
            this.karyawanID = karyawanID;
            this.subject = subject;
        }

        public karyawan()
        {

        }

        //override
        public void InfoPerson(string karyawanID, string subject)
        {
            this.karyawanID = karyawanID;
            this.subject = subject;
            Console.WriteLine("saya memiliki ID {0}, dan saya disini sebagai {1}\n", this.karyawanID, this.subject);
        }
    }
}