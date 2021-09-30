using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiserMove
{
    public abstract class Vehicle : ICruiser
    {
        /// <summary>
        /// Левая координата отрисовки крейсера
        /// </summary>
        protected float startPosX;
        /// <summary>
        /// Правая кооридната отрисовки крейсера
        /// </summary>
        protected float startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        protected int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        protected int pictureHeight;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { protected set; get; }
        /// <summary>
        /// Вес крейсера
        /// </summary>
        public float Weight { protected set; get; }
        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        public Color MainColor { protected set; get; }
        public void SetPosition(int x, int y, int width, int height)
        {
            startPosX = x;
            startPosY = y;
            pictureWidth = width;
            pictureHeight = height;
        }
        public abstract void MoveTransport(Direction direction);
        public abstract void DrawTransport(Graphics g);
    }
}
