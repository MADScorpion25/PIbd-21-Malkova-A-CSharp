using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiserMove
{
    public class WarCruiser : CruiserSimp
    {
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак локатора
        /// </summary>
        public bool Locator { private set; get; }
        /// <summary>
        /// Признак наличия вертолетной площадки
        /// </summary>
        public bool HelicopterStation { private set; get; }
        /// <summary>
        /// Признак наличия артиллерийского орудия
        /// </summary>
        public bool Artillery { private set; get; }
        public WarCruiser(int maxSpeed, float weight, Color mainColor, Color dopColor,
       bool locator, bool helicopterStation, bool artillery) : base(maxSpeed, weight, mainColor, 180, 60)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Locator = locator;
            HelicopterStation = helicopterStation;
            Artillery = artillery;
        }

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush addcolor = new SolidBrush(DopColor);
            Brush br = new SolidBrush(MainColor);
            base.DrawTransport(g);
            //рисуем артиллерийские орудия
            if (Artillery)
            {
                br = new SolidBrush(DopColor);
                pen = new Pen(Color.Black, 3);
                g.DrawLine(pen, startPosX + 61, startPosY + 5, startPosX + 65, startPosY - 5);
                g.DrawLine(pen, startPosX + 65, startPosY + 5, startPosX + 69, startPosY - 5);
                g.DrawLine(pen, startPosX + 69, startPosY + 5, startPosX + 73, startPosY - 5);
                g.DrawLine(pen, startPosX + 73, startPosY + 5, startPosX + 77, startPosY - 5);
                g.FillRectangle(addcolor, startPosX + 60, startPosY + 5, 20, 15);
                g.DrawRectangle(pen, startPosX + 60, startPosY + 5, 20, 15);
                g.DrawLine(pen, startPosX + 61, startPosY + 55, startPosX + 65, startPosY + 65);
                g.DrawLine(pen, startPosX + 65, startPosY + 55, startPosX + 69, startPosY + 65);
                g.DrawLine(pen, startPosX + 69, startPosY + 55, startPosX + 73, startPosY + 65);
                g.DrawLine(pen, startPosX + 73, startPosY + 55, startPosX + 77, startPosY + 65);
                g.FillRectangle(addcolor, startPosX + 60, startPosY + 40, 20, 15);
                g.DrawRectangle(pen, startPosX + 60, startPosY + 40, 20, 15);
            }
            //отрисовка локатора
            if (Locator)
            {
                pen = new Pen(Color.Black, 2);
                g.DrawRectangle(pen, startPosX + 100, startPosY + 20, 15, 20);
                g.DrawLine(pen, startPosX + 105, startPosY + 20, startPosX + 105, startPosY + 40);
                g.DrawLine(pen, startPosX + 110, startPosY + 20, startPosX + 110, startPosY + 40);
                g.DrawLine(pen, startPosX + 105, startPosY + 20, startPosX + 105, startPosY + 40);
                g.DrawLine(pen, startPosX + 100, startPosY + 25, startPosX + 115, startPosY + 25);
                g.DrawLine(pen, startPosX + 100, startPosY + 30, startPosX + 115, startPosY + 30);
                g.DrawLine(pen, startPosX + 100, startPosY + 35, startPosX + 115, startPosY + 35);

            }
            // вертолетная станция
            if (HelicopterStation)
            {
                g.FillRectangle(addcolor, startPosX, startPosY, 50, 60);
                Pen parking = new Pen(Color.White, 3);
                g.DrawEllipse(parking, startPosX + 10, startPosY + 15, 30, 30);
            }
        }
        
    }
}
