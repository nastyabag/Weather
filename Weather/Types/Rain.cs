namespace Weather.Types
{
    public class Rain : Weathers
    {
        private readonly ushort _precipitation;
        private readonly string _rainbows;
        private readonly string _thunderstorm;
        private static ushort _count = 0;

        public Rain(float temperature, ushort precipitation, bool rainbows, bool thunderstorm)
        {
            _temperature = temperature;
            _precipitation = precipitation;
            _rainbows = rainbows ? "Есть" : "Нет";
            _thunderstorm = thunderstorm ? "Есть" : "Нет";
            _count++;
        }

        ~Rain()
        {
            _count--;
        }

        public static ushort Count => _count;

        public override string GetInformation()
        {
            return $"Выбрано: Дождь\n" +
                   $"Температура: {_temperature}°С\n" +
                   $"Величина осадков: {_precipitation} мм\n" +
                   $"Наличие радуги: {_rainbows}\n" +
                   $"Наличие грозы: {_thunderstorm}";
        }
    }
}
