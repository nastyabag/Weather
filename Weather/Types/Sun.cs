﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Types
{
    public class Sun : Weathers
    {
        private readonly string _freshBreeze;
        private readonly ushort _heightHorizon;
        private static ushort _count = 0;

        public Sun(float temperature, bool freshBreeze, ushort heightHorizon)
        {
            _temperature = temperature;
            _freshBreeze = freshBreeze ? "Есть" : "Нет";
            _heightHorizon = heightHorizon;
            _count++;
        }

        ~Sun()
        {
            _count--;
        }

        public static uint Count => _count;

        protected override string GetInformation()
        {
            return $"Температура: {_temperature}°С\n" +
                   $"Высота над горизонтом: {_heightHorizon}°\n" +
                   $"Наличие свежего ветра: {_freshBreeze}";
        }
    }
}