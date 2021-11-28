using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Weather.Types;

namespace Weather
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //список объектов
        private readonly List<Weathers> _listWeather = new();
        //список типов объектов, для отображения очереди
        private readonly List<string> _listTypes = new();

        //форматированый вывод количетсва объектов на форму
        private string _count;
        //вывод информации об объекте на форму
        private string _information;

        //событие загрузки формы: при загрузке создание списка и вывод информации и очередь на форму
        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateList();

            _count = $"Солнце: {Sun.Count}   Дождь: {Rain.Count}   Снег: {Snow.Count}";
            listBox.DataSource = _listTypes;
            label_count.Text = _count;
            label_info.Text = "";
            pictureBox.Image = Properties.Resources.empty;
        }

        //метод создания списка
        private void CreateList()
        {
            _listWeather.Clear();
            _listTypes.Clear();

            var random = new Random();

            int length = random.Next() % 29 + 1;
            for (int i = 0; i < length; i++)
            {
                switch (random.Next() % 3)
                {
                    case 0:
                        _listWeather.Add(new Sun((float)(random.Next() % 10) / 10 + random.Next() % 45 - 10, random.Next() % 2 != 0, (ushort)(random.Next() % 90)));
                        _listTypes.Add("солнце");
                        break;
                    case 1:
                        _listWeather.Add(new Rain((float)(random.Next() % 10) / 10 + random.Next() % 20, (ushort)(random.Next() % 200), random.Next() % 2 != 0, random.Next() % 2 != 0));
                        _listTypes.Add("дождь");
                        break;
                    case 2:
                        _listWeather.Add(new Snow(-(random.Next() % 25 + (float)(random.Next() % 10) / 10), random.Next() % 2 != 0 ? "мелкий" : "хлопьями",
                            (ushort)(random.Next() % 120)));
                        _listTypes.Add("снег");
                        break;
                }
            }
        }

        //метод взятия объекта из очереди
        private void TakeWeather()
        {
            if (_listWeather.Any())
            {
                _information = _listWeather[0].GetInformation();

                if (_listWeather[0] is Sun)
                    pictureBox.Image = Properties.Resources.sun;
                else if (_listWeather[0] is Snow)
                    pictureBox.Image = Properties.Resources.snow;
                else if (_listWeather[0] is Rain)
                    pictureBox.Image = Properties.Resources.rain;

                _listWeather.RemoveAt(0);
                _listTypes.RemoveAt(0);
            }
            else
            {
                _information = "Автомат пуст";
                pictureBox.Image = Properties.Resources.empty;
            }
        }

        //событие нажатия на кнопку перезаполнения списка
        private void button_refill_Click(object sender, EventArgs e)
        {
            CreateList();
            GC.Collect();

            _count = $"Солнце: {Sun.Count}   Дождь: {Rain.Count}   Снег: {Snow.Count}";
            listBox.DataSource = null;
            listBox.DataSource = _listTypes;
            label_count.Text = _count;
            label_info.Text = "";
            pictureBox.Image = Properties.Resources.empty;
        }

        //событие нажатия на кнопку взятия объекта
        private void button_take_Click(object sender, EventArgs e)
        {
            TakeWeather();
            GC.Collect();

            _count = $"Солнце: {Sun.Count}   Дождь: {Rain.Count}   Снег: {Snow.Count}";
            listBox.DataSource = null;
            listBox.DataSource = _listTypes;
            label_count.Text = _count;
            label_info.Text = _information;
        }
    }
}