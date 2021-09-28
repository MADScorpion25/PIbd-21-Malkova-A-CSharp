using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CruiserMove
{
    public partial class cruiserMove : Form
    {
        private Cruiser cruiser;
        public cruiserMove()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод отрисовки крейсера
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCruiser.Width, pictureBoxCruiser.Height);
            Graphics gr = Graphics.FromImage(bmp);
            cruiser.DrawTransport(gr);
            pictureBoxCruiser.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        private void create_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            cruiser = new Cruiser();
            cruiser.Init(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Gray,
           Color.LightGray, true, true, true); cruiser.SetPosition(rnd.Next(0, pictureBoxCruiser.Width - cruiser.CruiserWidth),
           rnd.Next(0, pictureBoxCruiser.Height - cruiser.CruiserHeight), pictureBoxCruiser.Width, pictureBoxCruiser.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void moveButtons_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    cruiser.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    cruiser.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    cruiser.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    cruiser.MoveTransport(Direction.Right);
                    break;
            }
            Draw();

        }
    }
}
