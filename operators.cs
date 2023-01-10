using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session2
{
    internal class operators
    {
        public bool esMayorIgualQueDieciocho(int number) {
            return number >= 18;
        }

        public bool esMinusA(char letter) {
            return letter == 'a';
        }

        public bool sonAmbasVerdaderas(bool condition1, bool condition2) {
            return condition1 && condition2;
        }

        public bool esUnaVerdadera(bool condition1, bool condition2) {
            return condition1 || condition2;
        }
        
    }
}
