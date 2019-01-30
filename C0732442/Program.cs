using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732442
{
    class Program
    {
        static void Main(string[] args)
        {
            Lakeshore blue = new Lakeshore();
            blue.Launch();
        }

    }

    class Village
    {
        public Village nextVillage;
        public string VillageName;
        public bool isAstrildeHere = false;
        public Village previous;
    }
    class Lakeshore
    {
        Village Maple = new Village();
        Village Toronto = new Village();
        Village Ajax = new Village();
        Village temp;
        Village First;
        Village Last;


        public void Launch()
        {
            Village temp;
            Village First = Maple;
            Village Last = Ajax;
            Maple.VillageName = "Maple";
            Maple.nextVillage = Toronto;
            Maple.previous = null;
            Toronto.VillageName = "Toronto";
            Toronto.nextVillage = Ajax;
            Toronto.previous = Maple;
            Ajax.VillageName = "Ajax";
            Ajax.nextVillage = null;
            Ajax.previous = Toronto;
            Console.WriteLine(this.displayMap());
            Console.ReadLine();
        }

        public string displayMap()
        {
            string listOfCities = " ";
            
            
          listOfCities = listOfCities + First.VillageName;
          temp = First.nextVillage;
          listOfCities = listOfCities + temp.VillageName;

            return listOfCities;
        }
        
        
     
        
    }
}
