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

        public override string GetInformation()
        {
            return $"Выбрано: Солнце\n" +
                   $"Температура: {_temperature}°С\n" +
                   $"Высота над горизонтом: {_heightHorizon}°\n" +
                   $"Наличие свежего ветра: {_freshBreeze}";
        }
    }
}
