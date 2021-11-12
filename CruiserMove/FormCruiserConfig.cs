using System;
using System.Drawing;
using System.Windows.Forms;

namespace CruiserMove
{
    public partial class FormCruiserConfig : Form
    {
        private ITransport cruiser = null;
        private Action<Vehicle> eventAddCruiser;
        public FormCruiserConfig()
        {
            InitializeComponent();
            panelActiveBorder.MouseDown += panelColor_MouseDown;
            panelActiveCaption.MouseDown += panelColor_MouseDown;
            panelControlDark.MouseDown += panelColor_MouseDown;
            panelGradientActiveCaption.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelMediumPurple.MouseDown += panelColor_MouseDown;
            panelActiveCaptionText.MouseDown += panelColor_MouseDown;
            panelPaleTurquoise.MouseDown += panelColor_MouseDown;
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
                    cruiser = new CruiserSimp(Convert.ToInt32(numericMaxSpeed.Value), Convert.ToInt32(numericWeight.Value), Color.White);
                    break;
                case "Военный крейсер":
                    cruiser = new WarCruiser(Convert.ToInt32(numericMaxSpeed.Value), Convert.ToInt32(numericWeight.Value), Color.White, Color.Black, setLocator.Checked, setHelicopterStation.Checked, setWeapons.Checked);
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
            Color mainColor = (Color)e.Data.GetData(typeof(Color));
            cruiser.SetMainColor(mainColor);
            DrawCruiser();
        }
        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void labelAdditionColor_DragDrop(object sender, DragEventArgs e)
        {
            if (cruiser.GetType() != typeof(WarCruiser)) return;
            Color additionColor = (Color) e.Data.GetData(typeof(Color));
            WarCruiser warCruiser = (WarCruiser)cruiser;
            warCruiser.SetDopColor(additionColor);
            DrawCruiser();
        }
        private void labelAdditionColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
            DrawCruiser();
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.DoDragDrop(panel.BackColor, DragDropEffects.Move |DragDropEffects.Copy);
        }
        internal void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddCruiser == null)
            {
                eventAddCruiser = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddCruiser += ev;
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            eventAddCruiser?.Invoke((Vehicle) cruiser);
            Close();
        }
    }
}
