using System;

namespace ograniczenia
{
    public class DataStore<T> where T : struct
    {

        public T Data { get; set; }

    }
    public struct Mystr
    {

    }
    class Program
    {

        static void Main(string[] args)
        {
            DataStore<int> store = new DataStore<int>();
            Console.WriteLine(store.Data);
            DataStore<char> chstore = new DataStore<char>();
            Console.WriteLine(chstore.Data);
            DataStore<Mystr> mst = new DataStore<Mystr>();

            //DataStore<string> str1 = new DataStore<string>();







        }
    }
}