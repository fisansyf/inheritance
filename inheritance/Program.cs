using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.InfoPerson("Syafa", 18);

            Person person2 = new Person();
            person2.InfoPerson("Homa", 17);

            //inheritance
            karyawan karyawan1 = new karyawan();
            karyawan1.InfoPerson("Fisan", 20);
            karyawan1.InfoPerson("Fisan123", "BOS");

            karyawan karyawan2 = new karyawan();
            karyawan2.InfoPerson("bambang", 19);
            karyawan2.InfoPerson("bambang123", "SPB");

            Console.ReadKey();
        }
    }
}
