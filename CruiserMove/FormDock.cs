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
        private readonly DockCollection dockCollection;
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        private readonly Dock<CruiserSimp> parking;
        public FormDock()
        {
            InitializeComponent();
            dockCollection = new DockCollection(parkingBox.Width, parkingBox.Height);
        }
        /// <summary>
        /// Заполнение listBoxLevels
        /// </summary>
        private void ReloadLevels()
        {
            int index = listBoxParkings.SelectedIndex;
            listBoxParkings.Items.Clear();
            for (int i = 0; i < dockCollection.Keys.Count; i++)
            {
                listBoxParkings.Items.Add(dockCollection.Keys[i]);
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
            else if(dockCollection.Keys.Count == 0)
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
                dockCollection[listBoxParkings.SelectedItem.ToString()].Draw(gr);
                parkingBox.Image = bmp;
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
                var cruiser = dockCollection[listBoxParkings.SelectedItem.ToString()] -
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
                MessageBox.Show("Введите название дока", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dockCollection.AddDock(parkingName.Text);
            ReloadLevels();
        }
        private void removeParking_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить док { listBoxParkings.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dockCollection.DelDock(listBoxParkings.SelectedItem.ToString());
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
        private void setCruiserButton_Click(object sender, EventArgs e)
        {
            var formCarConfig = new FormCruiserConfig();
            formCarConfig.AddEvent(AddCruiser);
            formCarConfig.Show();
        }
        private void AddCruiser(Vehicle cruiser)
        {
            if (cruiser != null && listBoxParkings.SelectedIndex > -1)
            {
                if (dockCollection[listBoxParkings.SelectedItem.ToString()] + cruiser > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Крейсер не удалось поставить");
                }
            }
        }
    }
}
