using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concreate
{
    public class Category
    {
        /*
        int x; // field
        public int y { get; set; } // property

        public void Test()
        {
            int z; // variable
        }
        */


        public int CategoryId { get; set; } //Otomatik artan olduğunu anlaması için Class'ın isminin aynısı+Id kuralına uyulması gerekiyor.
        public string CategoryName { get; set; }
        public int CategoryStatus { get; set; }
    }
}
/*
 Field- variable- property


int x; // field
public int X { get; set; } // property

 
 */