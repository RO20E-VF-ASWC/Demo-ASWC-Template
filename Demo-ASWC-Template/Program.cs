using System;

namespace Demo_ASWC_Template
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractADT adt = new SetADT();



            adt.Add("Peter");
            adt.Add("Anders");
            adt.Add("Jens Peter");
            adt.Add("Michael");
            adt.Add("Michael");


            Console.WriteLine(adt);
        }
    }
}
