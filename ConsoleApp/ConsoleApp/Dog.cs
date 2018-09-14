using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{

    //void Breakfast()
    //{
    //    var bird = new Animal<Egg>();
    //    var pig = new Animal<Piglet>();
    //}
    public class Animal<T> where T : Offspring
    {
        public T Offspring { get; set; }
    }

    public abstract class Offspring { }
    public class Egg : Offspring { }
    public class Piglet : Offspring { }

    public class Trainer
    {
        void Operate()
        {
            var dog = new Poodle();
            dog.HasSpoken += Dog_HasSpoken;
        }

        private void Dog_HasSpoken(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }


    public partial class Dog
    {
        // properties hold values
        public string Name { get; set; }
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            private set { myVar = value; }
        }

        public event EventHandler HasSpoken;

        // Set default value for string input variable
        public void Speak(string what = "bark")
        {
            // TODO
            if (HasSpoken != null)
                HasSpoken(this, EventArgs.Empty);
        }

        public void Speak(int times, string what = "bark")
        {
            // TODO
        }

        public void Speak(int times, string what = "bark", Boolean sit = true)
        {

        }

        // only by this class
        private void Foo() { }

        // only this and derived classes
        protected void Bar() { }

        // only in this assembly
        internal void Bar2() { }
    }

    class Poodle : Dog
    {
        void x()
        {
            this.Speak(2, sit:true);
        }

        void tenarySample()
        { var value = 0;
            if (value ==1)
            {
                Console.WriteLine("one");
            }
            else
            {
                Console.WriteLine("Not one");
            }

            // code above is equal as
            // tenary
            Console.WriteLine(value == 1 ? "one" : "Not one");
        }
    }
    
    class Class1
    {
        enum Dogs { Lassie, Snoopy, Yeller }

        void x()
        {
            var snoopy = Dogs.Snoopy;
            switch (snoopy)
            {
                case Dogs.Lassie:
                    Console.WriteLine("Hi");
                    break;
                case Dogs.Snoopy:
                    Console.WriteLine("Hi");
                    break;
                case Dogs.Yeller:
                    break;
                default:
                    throw new NotSupportedException();
                    break;
            }

        }
    }
}

// About inheritance
namespace ConsoleApp2
{
    public class y
    {
        public void x()
        {
            var animal = new Animal();
            var dog = new Dog();
            var poodle = new Poodle();

            TakeAnmial(animal);
        }
        public void TakeAnmial(Animal a)
        {
            a.Temp = 10;
            //var dog = (Dog)a;

            if (a is Dog)
            {
                var dog = a as Dog;
                if (dog != null)
                    dog.Name = "Daren";
            }
        }
    }
    public class Animal { public int Temp { get; set; }}
    public class Dog : Animal { public string Name { get; set; }}
    public class Poodle : Dog { public string Groomer { get; set; }}
}
