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
    public partial class FormParking : Form
    {
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        private readonly Parking<CruiserSimp> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<CruiserSimp>(parkingBox.Width, parkingBox.Height);
            Draw();
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(parkingBox.Width, parkingBox.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            parkingBox.Image = bmp;
        }

        /// <summary>
        /// Обработка нажатия кнопки "Припарковать крейсер"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setSimpleCruiser_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var cruiser = new CruiserSimp(100, 1000, dialog.Color);
                if (parking + cruiser > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать военный крейсер"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void setWarCruiser_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var cruiser = new WarCruiser(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
                    if (parking + cruiser > -1)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }

        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getCruiser_Click(object sender, EventArgs e)
        {
            if (takeCruiser.Text != "")
            {
                var cruiser = parking - Convert.ToInt32(parkingPlace.Text);
                if (cruiser != null)
                {
                    FormCruiser form = new FormCruiser();
                    form.SetCruiser(cruiser, 10, 10);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
