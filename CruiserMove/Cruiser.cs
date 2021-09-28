using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiserMove
{
    /// <summary>
    /// Класс отрисовки крейсера
    /// </summary>
    class Cruiser
    {
        /// <summary>
        /// Левая координата отрисовки крейсера
        /// </summary>
        private float startPosX;
        /// <summary>
        /// Правая кооридната отрисовки крейсера
        /// </summary>
        private float startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int pictureHeight;
        /// <summary>
        /// Ширина отрисовки крейсера
        /// </summary>
        private readonly int cruiserWidth = 180;
        /// <summary>
        /// Высота отрисовки крейсера
        /// </summary>
        private readonly int cruiserHeight = 60;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес крейсера
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
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
        ///вспомогательные свойства для корректной генерации начальных координат
        public int CruiserWidth => cruiserWidth;
        public int CruiserHeight => cruiserHeight;
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor,
       bool locator, bool helicopterStation, bool artillery)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Locator = locator;
            HelicopterStation = helicopterStation;
            Artillery = artillery;
        }
        /// <summary>
        /// Установка позиции крейсера
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            startPosX = x;
            startPosY = y;
            pictureWidth = width;
            pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (startPosX + step < pictureWidth - CruiserWidth)
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
        /// <summary>
        /// Отрисовка крейсера
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush addcolor = new SolidBrush(DopColor);

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
            g.FillRectangle(addcolor, startPosX + 90, startPosY + 10, 20, 40);
            g.DrawRectangle(pen, startPosX + 90, startPosY + 10, 20, 40);
            //отсек для кают
            g.FillRectangle(addcolor, startPosX + 60, startPosY + 25, 30, 10);
            g.DrawRectangle(pen, startPosX + 60, startPosY + 25, 30, 10);
            g.DrawEllipse(pen, startPosX + 125, startPosY + 20, 20, 20);
            //отрисовка турбин
            Brush turb = new SolidBrush(Color.Black);
            g.FillRectangle(turb, startPosX - 5, startPosY + 10, 5, 17);
            g.FillRectangle(turb, startPosX - 5, startPosY + 33, 5, 17);
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
