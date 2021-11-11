using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
     public class Operations
    {
        public Operations()
        {

        }
        
        #region Operations
        public float Sum(float n1, float n2)
        {
            return n1 + n2;
        }

        public float Rest(float n1, float n2)
        {
            return n1 - n2;
        }

        public float Mult(float n1, float n2)
        {
            return n1 * n2;
        }

        public float Div(float n1, float n2)
        {
            return n1 / n2;
        }
        #endregion
    }
}
