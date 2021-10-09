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
    public partial class FormCruiser : Form
    {
        private ICruiser cruiser;
        public FormCruiser()
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
            cruiser?.DrawTransport(gr);
            pictureBoxCruiser.Image = bmp;

        }
        /// <summary>
        /// Передача крейсера на форму
        /// </summary>
        /// <param name="cruiser"></param>
        public void SetCruiser(ICruiser cruiser, int posX, int posY)
        {
            this.cruiser = cruiser;
            cruiser.SetPosition(posX, posY, pictureBoxCruiser.Width, pictureBoxCruiser.Height);
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
                    cruiser?.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    cruiser?.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    cruiser?.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    cruiser?.MoveTransport(Direction.Right);
                    break;
            }
            Draw();

        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>

    }
}
