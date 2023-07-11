using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public interface Observer
    {
        void Actualizar(Observable origen, Object evento);
    }
}
