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
    public partial class FormCruiserConfig : Form
    {
        ITransport cruiser = null;
        public FormCruiserConfig()
        {
            InitializeComponent();
            cancelButton.Click += (object sender, EventArgs e) => { Close(); };
        }
        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       

        private void DrawCruiser()
        {
            if (cruiser != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxCruiser.Width, pictureBoxCruiser.Height);
                Graphics gr = Graphics.FromImage(bmp);
                cruiser.SetPosition(5, 5, pictureBoxCruiser.Width, pictureBoxCruiser.Height);
                cruiser.DrawTransport(gr);
                pictureBoxCruiser.Image = bmp;
            }
        }

        private void pictureCruiserPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureCruiserPanel_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный крейсер":
                    cruiser = new CruiserSimp(100, 500, Color.White);
                    break;
                case "Военный крейсер":
                    cruiser = new WarCruiser(100, 500, Color.White, Color.Black, true, true, true);
                    break;
            }
            DrawCruiser();
        }

        private void labelCruiser_MouseDown(object sender, MouseEventArgs e)
        {
            labelCruiser.DoDragDrop(labelCruiser.Text, DragDropEffects.Move |DragDropEffects.Copy);
        }

        private void labelWarCruiser_MouseDown(object sender, MouseEventArgs e)
        {
            labelWarCruiser.DoDragDrop(labelWarCruiser.Text, DragDropEffects.Move |DragDropEffects.Copy);
        }

        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void labelAdditionColor_DragDrop(object sender, DragEventArgs e)
        {
           
        }

        private void labelAdditionColor_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
