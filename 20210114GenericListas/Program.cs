using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210114GenericListas
{
    class Program
    {
        static void Main(string[] args)
        {
            ListOfNumbers skaiciai = new ListOfNumbers();
            skaiciai.AddNumber(8523);
            skaiciai.AddNumber(53);
            skaiciai.AddNumber(0);
            skaiciai.AddNumber(888);
            skaiciai.AddNumber(1);


            List objektai = new List();
            objektai.Add(55516);
            objektai.Add("sfalijfaso");
            objektai.Add(2.5);
            objektai.Add(new Program());
            objektai.Add(new List());

            List<int> skaiciaiReal = new List<int>();

            PracticeList<string> eilutes = new PracticeList<string>();
            eilutes.Add("sveiki");
            eilutes.Add("pasauli");

            Console.WriteLine(skaiciai.GetNumber(2));
            Console.ReadLine();
        }
    }

    public class ListOfNumbers
    {
        private int[] numbers { get; set; }
        public ListOfNumbers()
        {
            numbers = new int[0];
        }
        public void AddNumber(int sk)
        {
            int[] temp = numbers;
            numbers = new int[numbers.Length + 1];
            for(int i = 0; i<temp.Length; i++)
            {
                numbers[i] = temp[i];
            }
            numbers[numbers.Length-1] = sk;
        }

        public int GetNumber(int idx)
        {
            return numbers[idx];
        }
    }

    public class List
    {
        private object[] objects { get; set; }
        public List()
        {
            objects = new object[0];
        }

        public void Add(object obj)
        {
            object[] temp = objects;
            objects = new object[objects.Length + 1];
            for(var i = 0; i<temp.Length; i++)
            {
                objects[i] = temp[i];
            }
            objects[objects.Length - 1] = obj;
        }
    }

    public class PracticeList<Tipas>
    {
        private Tipas[] masyvas { get; set; }

        public PracticeList()
        {
            masyvas = new Tipas[0];
        }

        public void Add(Tipas elementas)
        {
            Tipas[] temp = masyvas;
            masyvas = new Tipas[masyvas.Length + 1];

            for(int i = 0; i<temp.Length; i++)
            {
                masyvas[i] = temp[i];
            }
            masyvas[masyvas.Length - 1] = elementas;
        }
    }
}
