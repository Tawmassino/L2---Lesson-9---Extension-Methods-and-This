using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_9___Extension_Methods_and_This
{
    internal class ExtensionMethods
    {
        //field
        private string alias;//sjp tai fields aprasomi su underscore _alias
        private string name;

        //properties//turi get set
        public int Age { get; private set; }
        public static string Nationality { get; set; }

        //cnsrtrct
        public ExtensionMethods(string alias, string name)
        {
            //alias = alias; //neaisku kas yra kas
            this.alias = alias;//sios klases objekto instanca paimam ir jo field priskiriame kas yra uz lygyves
                               //this kai referuojame i tos klases fielda ir kita


            this.Age = 0;
            //this.Nationality//buti negali, nes static property
        }


        //method

        public void SayHello()//naudojamas per objekta maine
        {
            Console.WriteLine("HellO");
        }

        public static void SayHelloStatic()//naudojamas ne su objektu, o su klase visa
        {
            Console.WriteLine("HellO from Static");
        }
    }
}
