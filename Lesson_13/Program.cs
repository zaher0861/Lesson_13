using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Building
    {
        public string Adress { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Building(string adr, int len, int wid, int hei)
        {
            Adress = adr;
            Length = len;
            Width = wid;
            Height = hei;
        }
        public void Print()
        {
            Console.WriteLine("Дом по адресу , длиной {1} м, шириной {2} м, высотой {3} м.", Adress, Length, Width, Height);
        }
    }
    sealed class MultiBuilding : Building
    {
        public int Floor { get; set; }
        public MultiBuilding(string adr, int len, int wid, int hei, int floor)
            : base(adr, len, wid, hei)
        {
            Floor = floor;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("Количество этажей - {0}", Floor);
        }
    }
}
