using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula03.Validatons
{
    public class IdValidation
    {
        public static bool IsValid(Guid id)
        {
            return (id != null && id != Guid.Empty);
        }
    }
}
