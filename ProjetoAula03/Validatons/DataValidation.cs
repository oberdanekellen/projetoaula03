using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula03.Validatons
{
    public class DataValidation
    {

        public static bool IsValid(DateTime data)
        {
            return (data != null && data != DateTime.MinValue);
        }

    }
}
