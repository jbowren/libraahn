using System.Collections.Generic;

namespace Raahn
{
    public class ModulationSignal
    {
        public const double NO_MODULATION = 0.0;
        //-1 to obtain passive modulation from ModulationSignal.GetSignal
        public const int INVALID_INDEX = -1;

        private static List<double> modulations = new List<double>();

        //Returns the index of the signal.
        public static uint AddSignal()
        {
            modulations.Add(NO_MODULATION);
            return (uint)(modulations.Count - 1);
        }

        //Returns the index of the signal.
        public static uint AddSignal(double defaultValue)
        {
            modulations.Add(defaultValue);
            return (uint)(modulations.Count - 1);
        }

        //If the modulation does not exist, the default modulation is returnned.
        public static double GetSignal(int index)
        {
            if (index < 0 || index >= modulations.Count)
                return NO_MODULATION;
            else
                return modulations[index];
        }

        public static uint GetSignalCount()
        {
            return (uint)modulations.Count;
        }

        public static void SetSignal(uint index, double value)
        {
            if (index >= modulations.Count)
                return;

            modulations[(int)index] = value;
        }
    }
}