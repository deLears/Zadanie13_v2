using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Zadanie13
    {
        static void Main(string[] args)
        {
            Building b1 = new Building("NewWay3",5,3,8);
            Console.WriteLine("New building is:");
            b1.Print();
            MultiBuilding mb1 = new MultiBuilding("OldWay4",5,8,8,6);
            Console.WriteLine("New multibuilding is:");
            mb1.Print();

            Console.ReadKey();
            
        }
    }

        
        class Building
        {
            
            string address;
            double length;
            double width;
            double heigth;


        public Building(string _address = "", double _length = 0, double _width = 0, double _heigth = 0)
        {
            this.address = _address;
            this.length = _length;
            this.heigth = _heigth;
            this.width = _width;
        }
            public string Address
            {
                get { return address; }
                set { address = value; }
            }

            public double Length
            {
                get { return length; }
                set {length = value; }
            }

            public double Width
            {
                get { return width; }
                set { width = value; }
            }

            public double Heigth
            {
                get { return heigth; }
                set { width = value; }
            }

        public void Print()
            {
                Console.WriteLine("address = {0}, length = {1}, width = {2}, heigth={3}", address, length, width, heigth);
            }
        }

        sealed class MultiBuilding : Building
        {
            int level;

            public MultiBuilding(string _address = "", double _length = 0, double _width = 0, double _heigth = 0, int _level=1) :
            base(_address, _length, _width, _heigth)
            {
                this.level=_level;
            }

            public int Level
            {
                get { return level; }
                set { level = value; }
            }

            public new void Print()
            {
                base.Print(); 
                Console.WriteLine("level = {0}", level);
            }
        }

        
        
    }


        
         
    


