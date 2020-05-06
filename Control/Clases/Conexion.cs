using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.Clases
{
   public class Conexion:SerialPort
    {
        public Conexion()
        {
            PortName = "COM1";
        }

        public bool Validar(String puerto)
        {
            return true;
            PortName = puerto;
            if (!IsOpen)
            {
 
            Open();
            Write("x");
            if (ReadChar() == 'y')
            {
                Close();
                return true;
            }
            Close();
            }
            return false;
        }
    }
}
