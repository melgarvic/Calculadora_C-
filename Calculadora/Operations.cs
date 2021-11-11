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
        public decimal Sum(decimal n1, decimal n2)
        {
            return n1 + n2;
        }

        public decimal Rest(decimal n1, decimal n2)
        {
            return n1 - n2;
        }

        public decimal Mult(decimal n1, decimal n2)
        {
            return n1 * n2;
        }

        public decimal Div(decimal n1, decimal n2)
        {
            return n1 / n2;
        }
        #endregion
    }
}
