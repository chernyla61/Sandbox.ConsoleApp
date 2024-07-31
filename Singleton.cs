using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.ConsoleApp
{
    public class Singleton
    {
        private Singleton _singltonObject = null;

        public  Singleton getObject()
        {
            if(_singltonObject == null){
                _singltonObject = new Singleton();
            }
            return _singltonObject;
        }

        private Singleton() { }
    }
}
