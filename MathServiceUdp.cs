﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12_Client.server
{
    class MathServiceUdp: UdpClient, IMathService
    {

        public double Add(double firstValue, double secondValue)
        {
            return firstValue + secondValue;

        }

        public double Div(double firstValue, double secondValue)
        {
            return firstValue / secondValue;
        }

        public double Mult(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }

        public double Sub(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }


    }
}
