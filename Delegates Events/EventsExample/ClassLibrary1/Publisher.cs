using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //delegate type
    public delegate int  MyDelegate(int a, int b);
    public class Publisher
    {
        //private delegate creation
      //  private MyDelegate myDelegate;
        //step 1:create an event
        public event MyDelegate myEvent;
        

        public int RaiseEvent(int a,int b)
        {
            //step2:raise event
            if(this.myEvent != null)
            {
             int x=   this.myEvent(a, b);
                return x;
            }
            else
            {
                return 0;
            }
           
        }
    }
}
