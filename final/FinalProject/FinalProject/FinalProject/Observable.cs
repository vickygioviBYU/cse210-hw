using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Observable
    {
        private List<Observer> observadores = new List<Observer>();
        public void Agregar(Observer obs)
        {
            if (!observadores.Contains(obs))
            {
                observadores.Add(obs);
            }
        }

        public void Quitar(Observer obs)
        {
            observadores.Remove(obs);
        }

        public void Avisar(Object evento)
        {
            List<Observer> copia = new List<Observer>(observadores);
            foreach (Observer obs in copia)
            {
                obs.Actualizar(this, evento);
            }

        }
    }
}
