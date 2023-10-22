using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220063
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Ethereum ethereumToken = new Ethereum("Vitalik Buterin", "Ethereum", 120265828, 4878.26, 0.432979, 1632.86, 195825956734, "ethereum.org");

                ethereumToken.DisplayInfo();


                FieldProperty fieldProperty = new FieldProperty();
                fieldProperty.Field = new DateTime(2015, 7, 30);
                fieldProperty.DisplayField();


                Constructor constructor = new Constructor();
                constructor.ExampleMethod(ethereumToken);
            }
        }
    }
}
        
