using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Legado
{
    class Switch
    {
        private readonly IDispositivo device;

        public Switch(IDispositivo device)
        {
            this.device = device;
        }

        public void Press()
        {
            device.Operate();
        }
    }
}
