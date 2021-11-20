using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace CruiserMove
{
    class DockCollection
    {
        /// <summary>
        /// Словарь (хранилище) с парковками
        /// </summary>
        readonly Dictionary<string, Dock<Vehicle>> dockStages;
        /// <summary>
        /// Возвращение списка названий праковок
        /// </summary>
        public List<string> Keys => dockStages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Разделитель для записи информации в файл
        /// </summary>
        private readonly char separator = ':';
        private readonly Logger logger;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public DockCollection(int pictureWidth, int pictureHeight)
        {
            dockStages = new Dictionary<string, Dock<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            logger = LogManager.GetCurrentClassLogger();
        }
        /// <summary>
        /// Добавление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void AddDock(string name)
        {
            if (!dockStages.ContainsKey(name))
            {
                dockStages.Add(name, new Dock<Vehicle>(pictureWidth, pictureHeight));
            }
        }
        /// <summary>
        /// Удаление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void DelDock(string name)
        {
            if (dockStages.ContainsKey(name))
            {
                dockStages.Remove(name);
            }
        }
        /// <summary>
        /// Доступ к парковке
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Dock<Vehicle> this[string ind]
        {
            get
            {
                if (dockStages.ContainsKey(ind)) return dockStages[ind];
                else return null;
            }
        }

        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            else
            {
                throw new FileNotFoundException();
            }
            using (StreamWriter fs = new StreamWriter(filename))
            {
                fs.Write($"DockCollection{Environment.NewLine}", fs);
                foreach (var level in dockStages)
                {
                    fs.Write($"Dock{separator}{level.Key}{Environment.NewLine}", fs);
                    ITransport cruiser = null;
                    for (int i = 0; (cruiser = level.Value.GetNext(i)) != null; i++)
                    {
                        if (cruiser != null)
                        {
                            if (cruiser.GetType().Name == "CruiserSimp")
                            {
                                fs.Write($"Cruiser{separator}", fs);
                            }
                            if (cruiser.GetType().Name == "WarCruiser")
                            {
                                fs.Write($"WarCruiser{separator}", fs);
                            }
                            fs.Write(cruiser + Environment.NewLine, fs);
                        }
                    }
                }
            }
        }

        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader sr = new StreamReader(filename, Encoding.UTF8))
            {
                String line;
                Vehicle cruiser = null;
                string key = string.Empty;
                line = sr.ReadLine();
                if (!line.Contains("DockCollection"))
                {
                    throw new Exception("Неверный формат файла");
                }
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("Dock"))
                    {
                        try
                        {
                            key = line.Split(separator)[1];
                            dockStages.Add(key, new Dock<Vehicle>(pictureWidth, pictureHeight));
                        }
                        catch(ArgumentException ex)
                        {
                            logger.Warn($"док с именем {key} уже существует");
                            throw new DockOccupiedPlaceException();
                        }
                    }
                    else if (line.Split(separator)[0] == "Cruiser")
                    {
                        cruiser = new CruiserSimp(line.Split(separator)[1]);
                        if (!(dockStages[key] + cruiser))
                        {
                            logger.Warn($"Невозможно добавить крейсер: {cruiser}");
                            throw new DockOccupiedPlaceException();
                        }
                    }
                    else if (line.Split(separator)[0] == "WarCruiser")
                    {
                        cruiser = new WarCruiser(line.Split(separator)[1]);
                        if (!(dockStages[key] + cruiser))
                        {
                            logger.Warn($"Невозможно добавить военный крейсер: {cruiser}");
                            throw new DockOccupiedPlaceException();
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
