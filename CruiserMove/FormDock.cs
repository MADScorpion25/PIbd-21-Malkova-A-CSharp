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
    public partial class FormDock : Form
    {
        private readonly ParkingCollection parkingCollection;
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        private readonly Parking<CruiserSimp> parking;
        public FormDock()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(parkingBox.Width,
           parkingBox.Height);
        }
        /// <summary>
        /// Заполнение listBoxLevels
        /// </summary>
        private void ReloadLevels()
        {
            int index = listBoxParkings.SelectedIndex;
            listBoxParkings.Items.Clear();
            for (int i = 0; i < parkingCollection.Keys.Count; i++)
            {
                listBoxParkings.Items.Add(parkingCollection.Keys[i]);
            }
            if (listBoxParkings.Items.Count > 0 && (index == -1 || index >=
           listBoxParkings.Items.Count))
            {
                listBoxParkings.SelectedIndex = 0;
            }
            else if (listBoxParkings.Items.Count > 0 && index > -1 && index <
           listBoxParkings.Items.Count)
            {
                listBoxParkings.SelectedIndex = index;
            }
            else if(parkingCollection.Keys.Count == 0)
            {
                Draw();
            }
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            if (listBoxParkings.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементуlistBox)
                Bitmap bmp = new Bitmap(parkingBox.Width,
               parkingBox.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parkingCollection[listBoxParkings.SelectedItem.ToString()].Draw(gr);
                parkingBox.Image = bmp;
            }

        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать крейсер"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setSimpleCruiser_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var cruiser = new CruiserSimp(100, 1000, dialog.Color);
                    if (parkingCollection[listBoxParkings.SelectedItem.ToString()] + cruiser > -1)
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
        /// Обработка нажатия кнопки "Припарковать военный крейсер"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setWarCruiser_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var cruiser = new WarCruiser(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
                        if (parkingCollection[listBoxParkings.SelectedItem.ToString()] + cruiser > -1)
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
        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getCruiser_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1 && parkingPlace.Text != "")
            {
                var cruiser = parkingCollection[listBoxParkings.SelectedItem.ToString()] -
               Convert.ToInt32(parkingPlace.Text);
                if (cruiser != null)
                {
                    FormCruiser form = new FormCruiser();
                    form.SetCruiser(cruiser, 100, 100);
                    form.ShowDialog();
                }
                Draw();
            }
        }
        private void addParking_Click(object sender, EventArgs e)
        {
            parkingBox.Visible = true;
            if (string.IsNullOrEmpty(parkingName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            parkingCollection.AddParking(parkingName.Text);
            ReloadLevels();
        }

        private void removeParking_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку { listBoxParkings.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    parkingCollection.DelParking(listBoxParkings.SelectedItem.ToString());
                    if (listBoxParkings.Items.Count == 1)
                    {
                        parkingBox.Visible = false;
                    }
                    ReloadLevels();
                }
                
            }
        }
        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
