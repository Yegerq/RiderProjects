using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace OOPlect
{
    public class Test : IDisposable
    {
        private bool isDisposed = false;

        public void Dispose()
        {
            Console.WriteLine("Bye-bye");
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    //clear all manage resources
                }
                
                //clear all unmanage resources
                isDisposed = true;
            }
        }

        ~Test()
        {
            Dispose(false);
        }
    }
}