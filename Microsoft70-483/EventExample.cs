﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft70_483
{
    public class EventExample
    {

        public class Pub
        {
            public event EventHandler<MyArgs> OnChange = delegate { };
            public void Raise()
            {
                OnChange(this, new MyArgs(42));
            }
        }
        public static void CreateAndRaise()
        {
            Pub p = new Pub();
            p.OnChange += (sender, e)
                => Console.WriteLine("Event raised: {0}", e.Value);
            p.Raise();
        }

    }

    public class MyArgs : EventArgs
    {
        public MyArgs(int value)
        {
            Value = value;
        }
        public int Value { get; set; }
    }
}
