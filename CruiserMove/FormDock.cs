using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using System.Windows.Forms;
using System.IO;

namespace CruiserMove
{
    public partial class FormDock : Form
    {
        private readonly DockCollection dockCollection;
        private readonly Logger logger;

        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        private readonly Dock<CruiserSimp> parking;
        public FormDock()
        {
            InitializeComponent();
            dockCollection = new DockCollection(dockBox.Width,
           dockBox.Height);
            logger = LogManager.GetCurrentClassLogger();
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
                try
                {
                    var cruiser = dockCollection[listBoxDocks.SelectedItem.ToString()] - Convert.ToInt32(dockPlace.Text);
                    if (cruiser != null)
                    {
                        FormCruiser form = new FormCruiser();
                        form.SetCruiser(cruiser, 100, 100);
                        form.ShowDialog();
                        logger.Info($"Изъят крейсер {cruiser} с места { dockPlace.Text}");
                    }
                    Draw();
                }
                catch(DockNotFoundException ex)
                {
                    logger.Warn($"Док {dockPlace.Text} не найден");
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            logger.Info($"Добавили парковку {dockName.Text}");
            dockCollection.AddDock(dockName.Text);
            ReloadLevels();
        }
        private void removeDock_Click(object sender, EventArgs e)
        {
            if (listBoxDocks.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить док { listBoxDocks.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили парковку { listBoxDocks.SelectedItem.ToString()}");

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
            logger.Info($"Перешли на парковку { listBoxDocks.SelectedItem.ToString()} ");
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
                try
                {
                    if (dockCollection[listBoxDocks.SelectedItem.ToString()] + cruiser)
                    {
                        Draw();
                        logger.Info($"Добавлен крейсер {cruiser}");
                    }
                }
                catch(DockOverflowException ex)
                {
                    logger.Warn($"Док переполнен, невозможно добавить крейсер {cruiser}");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dockCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch(FileNotFoundException ex)
                {
                    logger.Warn("Файл не найден");
                    MessageBox.Show(ex.Message, "Файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dockCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                catch(DockOccupiedPlaceException ex)
                {
                    logger.Warn("Док занят, невозможно добавить крейсер");
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (DockOverflowException ex)
                {
                    logger.Warn($"Док переполнен, невозможно добавить крейсер");
                    MessageBox.Show(ex.Message, "Док переполнен", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FileNotFoundException ex)
                {
                    logger.Warn("Файл не найден");
                    MessageBox.Show(ex.Message, "Файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
