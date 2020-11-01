using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Autos
{
    class MisExcepciones : ApplicationException
    { 

        public MisExcepciones() : base("Error")
        {
        }

        public MisExcepciones(string meg) : base (meg){ }

        public MisExcepciones(string meg, Exception e): base(meg,e) { 
        
        
        
        }
        

    }
}
