using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Models
{
    public class Peoguet : ICar
    {
        private CarStatus _status = CarStatus.Stopped;

        public void Start()
        {
            _status = CarStatus.Started;
        }

        public CarStatus Status()
        {
            return _status;
        }

        public void Stop()
        {
            _status = CarStatus.Stopped;
        }

        public string Make()
        {
            return "Peoguet";
        }
    }
}
