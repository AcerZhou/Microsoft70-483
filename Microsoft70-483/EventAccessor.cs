using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft70_483
{
    public class EventAccessor
    {
            private event EventHandler<MyArgs> onChange = delegate { };

            public event EventHandler<MyArgs> OnChange
            {
                add
                {
                    lock (onChange)
                    {
                        onChange += value;
                    }
                }
                remove
                {
                    lock (onChange)
                    {
                        onChange -= value;
                    }
                }
            }

            public void Raise()
            {
                onChange(this, new MyArgs(42));
            }

        public static void CreateAndRaise()
        {
            EventAccessor p = new EventAccessor();
            p.OnChange += (sender, e)
                => Console.WriteLine("Event raised: {0}", e.Value);
            p.Raise();
        }



    }
}
