using System;
using System.Collections.Generic;
using System.Text;

using TheNextCar.Model;

namespace TheNextCar.Controller
{
    class AccubatteryController
    {
        private Accubattery accubattery;
        private OnPowerChanged callBackOnPowerChanged;

        public AccubatteryController(OnPowerChanged callBackOnPowerChanged)
        {
            this.accubattery = new Accubattery(12);
            this.callBackOnPowerChanged = callBackOnPowerChanged;
        }

        public bool accubatteryIsOn()
        {
            return this.accubattery.isOn();
        }

        public void turnOn()
        {
            this.accubattery.turnOn();
        }

        public void turnOff()
        {
            this.accubattery.turnOff();
        }
    }

    interface OnPowerChanged
    {
        void onPowerChangedStatus(string value, string message);
    }
}
