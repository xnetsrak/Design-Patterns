using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Models
{
    interface ICar
    {
        void Start();
        CarStatus Status();
        void Stop();

        abstract string Make();
    }
}
