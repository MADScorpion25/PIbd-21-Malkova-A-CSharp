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
            dockCollection = new DockCollection(dockBox.Width,
           dockBox.Height);
        }
        /// <summary>
        /// Заполнение listBoxLevels
        /// </summary>
        private void ReloadLevels()
        {
            int index = listBoxDocks.SelectedIndex;
            listBoxDocks.Items.Clear();
            for (int i = 0; i < dockCollection.Keys.Count; i++)
            {
                listBoxDocks.Items.Add( dockCollection.Keys[i]);
            }
            if (listBoxDocks.Items.Count > 0 && (index == -1 || index >=
           listBoxDocks.Items.Count))
            {
                listBoxDocks.SelectedIndex = 0;
            }
            else if (listBoxDocks.Items.Count > 0 && index > -1 && index <
           listBoxDocks.Items.Count)
            {
                listBoxDocks.SelectedIndex = index;
            }
            else if( dockCollection.Keys.Count == 0)
            {
                Draw();
            }
        }
        private void Draw()
        {
            if (listBoxDocks.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементуlistBox)
                Bitmap bmp = new Bitmap(dockBox.Width,
               dockBox.Height);
                Graphics gr = Graphics.FromImage(bmp);
                dockCollection[listBoxDocks.SelectedItem.ToString()].Draw(gr);
                dockBox.Image = bmp;
            }

        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getCruiser_Click(object sender, EventArgs e)
        {
            if (listBoxDocks.SelectedIndex > -1 && dockPlace.Text != "")
            {
                var cruiser = dockCollection[listBoxDocks.SelectedItem.ToString()] -
               Convert.ToInt32(dockPlace.Text);
                if (cruiser != null)
                {
                    FormCruiser form = new FormCruiser();
                    form.SetCruiser(cruiser, 100, 100);
                    form.ShowDialog();
                }
                Draw();
            }
        }
        private void addDock_Click(object sender, EventArgs e)
        {
            dockBox.Visible = true;
            if (string.IsNullOrEmpty(dockName.Text))
            {
                MessageBox.Show("Введите название дока", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dockCollection.AddDock(dockName.Text);
            ReloadLevels();
        }
        private void removeDock_Click(object sender, EventArgs e)
        {
            if (listBoxDocks.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить док { listBoxDocks.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dockCollection.DelDock(listBoxDocks.SelectedItem.ToString());
                    if (listBoxDocks.Items.Count == 1)
                    {
                        dockBox.Visible = false;
                    }
                    ReloadLevels();
                }

            }
        }
        private void listBoxDocks_SelectedIndexChanged(object sender, EventArgs e)
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
            if (cruiser != null && listBoxDocks.SelectedIndex > -1)
            {
                if ( dockCollection[listBoxDocks.SelectedItem.ToString()] + cruiser > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Крейсер не удалось поставить");
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (dockCollection.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (dockCollection.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
    }
}
