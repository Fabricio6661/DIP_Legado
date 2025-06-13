using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Legado
{
    public class Lamp : IDispositivo
    {
        private State State;

        public Lamp(State State)
        {
            this.State = State.Off;
        }

        public void Operate()
        {
            State = State == State.On ? State.Off : State.On;
            Console.WriteLine("Luz " + (State == State.On ? "Ligada" : "Desligada"));
        }
    }
}
