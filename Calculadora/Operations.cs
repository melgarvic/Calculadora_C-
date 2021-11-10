using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
     public class Operations
    {
        #region Operations
        public static float Sum(float n1, float n2)
        {
            return n1 + n2;
        }

        public static float Rest(float n1, float n2)
        {
            return n1 - n2;        }

        public static float Mult(float n1, float n2)
        {
            return n1 * n2;
        }

        public static float Div(float n1, float n2)
        {
            return n1 / n2;
        }
        #endregion
    }
}
