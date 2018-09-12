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
    }
}
