using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiserMove
{
    public class CruiserSimp : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки крейсера
        /// </summary>
        protected readonly int cruiserWidth = 180;
        /// <summary>
        /// Высота отрисовки крейсера
        /// </summary>
        protected readonly int cruiserHeight = 60;
        protected readonly char separator = ';';
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес крейсера</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public CruiserSimp(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        /// <summary>
        /// Конструкторс изменением размеров крейсера
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес крейсера</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="cruiserWidth">Ширина отрисовки крейсера</param>
        /// <param name="cruiserHeight">Высота отрисовки крейсера</param>
        protected CruiserSimp(int maxSpeed, float weight, Color mainColor, int cruiserWidth, int cruiserHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.cruiserWidth = cruiserWidth;
            this.cruiserHeight = cruiserHeight;
        }
        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info">Информация по объекту</param>
        public CruiserSimp(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            // теперь отрисуем основной кузов крейсера
            //границы крейсера и кузов
            Brush br = new SolidBrush(MainColor);
            PointF point1 = new PointF(startPosX, startPosY);
            PointF point2 = new PointF(startPosX + 130, startPosY);
            PointF point3 = new PointF(startPosX + 180, startPosY + 30);
            PointF point4 = new PointF(startPosX + 130, startPosY + 60);
            PointF point5 = new PointF(startPosX, startPosY + 60);
            PointF[] carcass =
            {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5
             };
            g.FillPolygon(br, carcass);
            g.DrawPolygon(pen, carcass);
            //рубка капитана
            g.FillRectangle(br, startPosX + 90, startPosY + 10, 20, 40);
            g.DrawRectangle(pen, startPosX + 90, startPosY + 10, 20, 40);
            //отсек для кают
            g.FillRectangle(br, startPosX + 60, startPosY + 25, 30, 10);
            g.DrawRectangle(pen, startPosX + 60, startPosY + 25, 30, 10);
            g.DrawEllipse(pen, startPosX + 125, startPosY + 20, 20, 20);
            //отрисовка турбин
            Brush turb = new SolidBrush(Color.Black);
            g.FillRectangle(turb, startPosX - 5, startPosY + 10, 5, 17);
            g.FillRectangle(turb, startPosX - 5, startPosY + 33, 5, 17);
        }
       

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (startPosX + step < pictureWidth - cruiserWidth)
                    {
                        startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (startPosX > 0)
                    {
                        startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (startPosY > 0)
                    {
                        startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (startPosY + step < pictureHeight - cruiserHeight)
                    {
                        startPosY += step;
                    }
                    break;
            }
        }
        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }
    }
}
