using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //child of eventargs type
    public class CustomerEventArgs : EventArgs
    {
        public int a { get; set; }
        public int b { get; set; }
    }
    //delegate type
    //public delegate int  MyDelegate(int a, int b);
    public class Publisher
    {
        //private delegate creation
      //  private MyDelegate myDelegate;
        //step 1:create an event

        //162)Func data 
        //public event Action<int,int> myEvent;

        //164)predicate
        public event EventHandler<CustomerEventArgs> myEvent;


        public void RaiseEvent(object sender,int a,int b)
        {
            //step2:raise event
            if(this.myEvent != null)
            {
                CustomerEventArgs cus=new CustomerEventArgs() { a=a,b=b};
              this.myEvent(sender,cus);
               
            
            }

           
        }
    }
}
