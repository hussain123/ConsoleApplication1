using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void StringProcessor (string input);
namespace ConsoleApplication1
{
    class Person
    {
        string name;

        public Person(string name)
        {
            this.name = name;

        }
        public void Say(String message)
        {
            Console.WriteLine("{0}, says: {1}", name, message);
        }
    }

    class Background
    {
        public static void Note(string note)
        {
            Console.WriteLine("({0})", note);
        }
    }

    class Program
    {
        //static void Main(string[] args)
        //{
        //    Person jon = new Person("jon");
        //    Person tom = new Person("tom");

        //    StringProcessor JonsVoice, tomsVoice, background;


        //    JonsVoice = new StringProcessor(jon.Say);
        //    tomsVoice = new StringProcessor(tom.Say);
        //    background = new StringProcessor(Background.Note);


        //    JonsVoice("hello son.");
        //    tomsVoice.Invoke("hello daddy");
        //    background("an airplane fliees past ");




        //    Console.ReadLine();
        //}
    }



}
