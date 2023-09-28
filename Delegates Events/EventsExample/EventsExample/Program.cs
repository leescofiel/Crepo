﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace EventsExample
{
    internal class Program
    {
        static void Main()
        {
            Program p= new Program();
            p.DoWork();
        }

        public void DoWork(){

            //create obj of sub class
            //Subscriber subscriber = new Subscriber();

            //create obj for publsiher class
            Publisher publisher = new Publisher();

            //handle evet
            // publisher.myEvent += subscriber.Add;

            //159)1ananymous method 
            //publisher.myEvent += delegate (int a, int b)
            //{
            //    Console.WriteLine(a + b);
            //};

            //160)lambada expression
            //161)INLINE LAMBDA FUNCTION
            publisher.myEvent += (sender, e) =>
            {
                int c = e.a + e.b;
                Console.WriteLine(c);

            };
            //{
            //    // int c = a + b;
            //    // Console.WriteLine(c);
            //    return a + b;
            //   // return c;
            //};


            //invoke the ev
           publisher.RaiseEvent(this, 10, 18);
            publisher.RaiseEvent(this,5,9);

            Console.ReadKey();
        } 
    }
}
