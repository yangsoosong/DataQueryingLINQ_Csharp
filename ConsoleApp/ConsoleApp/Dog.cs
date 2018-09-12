using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public partial class Dog
    {
        // properties hold values
        public string Name { get; set; }
        propfull


        // only by this class
        private void Foo() { }

        // only this and derived classes
        protected void Bar() { }

        // only in this assembly
        internal void Bar() { }
    }

    class Poodle : Dog
    {
        void x() { this.Bar}
    }
}
