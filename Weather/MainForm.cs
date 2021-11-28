using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private List<Weathers> _listWeather = new List<Weathers>();
        //список типов объектов, для отображения очереди
        private List<string> _listTypes = new List<string>();

        //форматированый вывод количетсва объектов на форму
        private string _count;
        //вывод информации об объекте на форму
        private string _information;

        //событие загрузки формы: при загрузке создание списка и вывод информации и очередь на форму
        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateList();

            listBox.DataSource = _listTypes;
            label_count.Text = _count;
            label_info.Text = "";
        }

        //метод создания списка
        private void CreateList()
        {
            _listWeather.Clear();
            _listTypes.Clear();

            var random = new Random();

            int length = random.Next() % 30;
            for (int i = 0; i < length; i++)
            {
                switch (random.Next() % 3)
                {
                    case 0:
                        //_listSweets.Add(new Sun());
                        _listTypes.Add("солнце");
                        break;
                    case 1:
                        //_listSweets.Add(new Rain());
                        _listTypes.Add("дождь");
                        break;
                    case 2:
                        //_listSweets.Add(new Snow());
                        _listTypes.Add("снег");
                        break;
                }
            }

            _count = $"Солнце: {Sun.Count}   Дождь: {Rain.Count}   Снег: {Snow.Count}";
        }

        //метод взятия объекта из очереди
        private void TakeWeather()
        {
            if (_listWeather.Any())
            {
                _information = _listWeather[0].GetInformation();

                _listWeather.RemoveAt(0);
                _listTypes.RemoveAt(0);
            }
            else
            {
                _information = "Автомат пуст";
            }

            _count = $"Солнце: {Sun.Count}   Дождь: {Rain.Count}   Снег: {Snow.Count}";
        }

        //событие нажатия на кнопку перезаполнения списка
        private void button_refill_Click(object sender, EventArgs e)
        {
            CreateList();

            listBox.DataSource = null;
            listBox.DataSource = _listTypes;
            label_count.Text = _count;
            label_info.Text = "";
        }

        //событие нажатия на кнопку взятия объекта
        private void button_take_Click(object sender, EventArgs e)
        {
            TakeWeather();

            listBox.DataSource = null;
            listBox.DataSource = _listTypes;
            label_count.Text = _count;
            label_info.Text = _information;
        }
    }
}