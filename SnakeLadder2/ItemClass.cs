using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeLadder2
{
    class ItemClass
    {
        private string p;
        private int p1;
        private int p2;
        private int p3;
        private int p4;

        public ItemClass(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }

        public ItemClass(int p1)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
        }

        public ItemClass(int p1, int p2)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
        }

        public ItemClass(int p1, int p2, int p3)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public ItemClass(int p1, int p2, int p3, int p4)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }
    }
}
