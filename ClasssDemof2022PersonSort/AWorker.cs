using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using ClasssDemof2022PersonSort.model;

namespace ClasssDemof2022PersonSort
{
    public class AWorker
    {
        // instans felt
        private List<Employee> _employees;


        public AWorker()
        {
            _employees = new List<Employee>()
            {
                new Employee("Alfred", "Lærkevej", "Roskilde", "22334455", 34000),
                new Employee("Noah", "Solsortevej", "Hedehusene", "78263876", 34500),
                new Employee("Oliver", "Drosselvej", "Roskilde", "21662293", 26900),
                new Employee("Oscar", "Vibevej", "København", "92717722", 34600),
                new Employee("Arthur", "Spurvevej", "Roskilde", "24739930", 24500),
                new Employee("Karl", "Musvitvej", "Holbæk", "21427301", 34000),
                new Employee("Aksel", "Skadevej", "Roskilde", "41424532", 33000),
                new Employee("William", "Kragevej", "Sorø", "28338846", 34200),
                new Employee("Malte", "Uglevej", "Hedehusene", "55227733", 34300),
                new Employee("Karla", "Falkevej", "Helsingør", "18295372", 25000),
                new Employee("Valdemar", "Høgevej", "Roskilde", "11223539", 27800),
                new Employee("Alma", "Ørnevej", "Svorgerslev", "28242326", 25000),
                new Employee("Lucas", "Stilitsvej", "København", "22993374", 29600),
                new Employee("Clara", "Blåmejsevej", "Holbæk", "52667722", 27600),
                new Employee("Victor", "Rødkælkevej", "Hedehusene", "21212121", 31000),
                new Employee("Alma", "Svalevej", "Greve", "28384858", 30100),
                new Employee("Lucas", "Dumpapvej", "Holbæk", "66225533", 30100),
                new Employee("Clara", "Violvej", "København", "21232425", 32900),
                new Employee("Victor", "Krokusvej", "Roskilde", "23242662", 33200),
                new Employee("Agnes", "Liljevej", "Hedehusene", "54239022", 35000),
                new Employee("August", "Tulipanvej", "Holbæk", "72737475", 31000),
                new Employee("Emma", "Mælkebøttevej", "Roskilde", "11227773", 31100),
                new Employee("Elias", "Timianvej", "Greve", "14272022", 32900),
                new Employee("Freja", "Salvievej", "København", "36261923", 27000),
                new Employee("Olivia", "Rosmarinvej", "Hedehusene", "43435261", 25600),
                new Employee("Karla", "Purløgvej", "Holbæk", "22334481", 28800),
                new Employee("Josefine", "Persillevej", "Roskilde", "13151819", 29600),
                new Employee("Sofia", "Estragonvej", "København", "22993388", 30100),
                new Employee("Nora", "Lærkevej", "Greve", "17161151", 35200),
                new Employee("Ella", "Solsortevej", "Greve", "32425262", 34400),
                new Employee("Ellie", "Violvej", "København", "12345678", 34100),
                new Employee("Anna", "Svalevej", "Hedehusene", "81828384", 25000)
            };
        }

        public void Start()
        {
            /*
            Employee e1 = new Employee("Peter", "Lærkevej", "Roskilde", "11223344", 1000000);
            Employee e2 = new Employee("Peter", "Lærkevej", "Roskilde", "11223344", 1000000);
            Employee e3 = e2;

            Console.WriteLine("Ens værdier i to forskellige objekter");
            Console.WriteLine("e1 og e2 er ens " + (e1.Equals(e2)));
            Console.WriteLine("e2 og e1 er ens " + (e2.Equals(e1)));
            Console.WriteLine("e1 hashcode = " + e1.GetHashCode());
            Console.WriteLine("e2 hashcode = " + e2.GetHashCode());

            Console.WriteLine("Ens værdier i samme objekt");
            Console.WriteLine("e2 og e3 er ens " + (e2.Equals(e3)));
            Console.WriteLine("e2 hashcode = " + e2.GetHashCode());
            Console.WriteLine("e3 hashcode = " + e3.GetHashCode());
            */


            //PrintListe("Original Liste", _employees);

            //List<Employee> nyliste = new List<Employee>(_employees);
            //nyliste.Sort(new SortByNames());
            //PrintListe("Sorteret navne", nyliste);


            //List<Employee> enAndenListe = new List<Employee>(_employees);
            //enAndenListe.Sort((e1, e2) => e1.Salery - e2.Salery);
            //PrintListe("Sorteret Løn", enAndenListe);

            //List<Employee> endnuEnListe = new List<Employee>(_employees);
            //endnuEnListe.Sort();
            //PrintListe("Sorteret efter default dvs TLF", endnuEnListe);

            // LINQ
            List<Employee> list = _employees.Where(e => e.City == "Roskilde").ToList();
            PrintListe("Bor i roskilde", list);

            var res = 
                from e in _employees
                where e.Salery > 30000
                select e;
            PrintListe("Højt lønnet ", res.ToList());


            
        }















        private void PrintListe(String overskrift, List<Employee> liste)
        {
            Console.WriteLine();
            Console.WriteLine($" ====== {overskrift} ======");
            Console.WriteLine();

            foreach (Employee e in liste)
            {
                Console.WriteLine($"Navn: {e.Name}\tTlf: {e.Phone}\tLøn: {e.Salery}\tBy: {e.City}\tVej: {e.Street}");
            }
        }
    }
}