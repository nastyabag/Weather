using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Types
{
    public class Snow : Weathers
    {
        private readonly string _type;
        private readonly ushort _heighSnowdrifts;
        private static ushort _count = 0;

        public Snow(float temperature, string heighSnowdrift, ushort heighSnowdrifts)
        {
            _temperature = temperature;
            _type = heighSnowdrift;
            _heighSnowdrifts = heighSnowdrifts;
            _count++;
        }

        ~Snow()
        {
            _count--;
        }

        public static ushort Count => _count;

        public override string GetInformation()
        {
            return $"Выбрано: Снег\n" +
                   $"Температура: {String.Format("{0:N1}", _temperature)}°С\n" +
                   $"Тип снега: {_type}\n" +
                   $"Высота сугробов: {_heighSnowdrifts} см";
        }
    }
}
