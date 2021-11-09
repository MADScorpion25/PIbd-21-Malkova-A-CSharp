using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiserMove
{
    class DockCollection
    {
        /// <summary>
        /// Словарь (хранилище) с парковками
        /// </summary>
        readonly Dictionary<string, Parking<Vehicle>> parkingStages;
        /// <summary>
        /// Возвращение списка названий праковок
        /// </summary>
        public List<string> Keys => parkingStages.Keys.ToList();
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

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public DockCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        /// <summary>
        /// Добавление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void AddParking(string name)
        {
            if (!parkingStages.ContainsKey(name))
            {
                parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));
            }
        }
        /// <summary>
        /// Удаление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }
        /// <summary>
        /// Доступ к парковке
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Parking<Vehicle> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind)) return parkingStages[ind];
                else return null;
            }
        }
        /// <summary>
        /// Сохранение информации по автомобилям на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter fs = new StreamWriter(filename))
            {
                fs.Write($"DockCollection{Environment.NewLine}", fs);
                foreach (var level in parkingStages)
                {
                    fs.Write($"Dock{separator}{level.Key}{Environment.NewLine}", fs);
                    ITransport cruiser = null;
                    for (int i = 0; (cruiser = level.Value.GetNext(i)) != null; i++)
                    {
                        if (cruiser != null)
                        {
                            //если место не пустое
                            //Записываем тип крейсера
                            if (cruiser.GetType().Name == "CruiserSimp")
                            {
                                fs.Write($"Cruiser{separator}", fs);
                            }
                            if (cruiser.GetType().Name == "WarCruiser")
                            {
                                fs.Write($"WarCruiser{separator}", fs);
                            }
                            //Записываемые параметры
                            fs.Write(cruiser + Environment.NewLine, fs);
                        }
                    }
                }
                return true;
            }
        }
        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            parkingStages.Clear();
         
            using (StreamReader sr = new StreamReader(filename, Encoding.UTF8))
            {
                String line;
                Vehicle cruiser = null;
                string key = string.Empty;
                line = sr.ReadLine();
                if (!line.Contains("DockCollection"))
                {
                    return false;
                }
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("Dock"))
                    {
                        key = line.Split(separator)[1];
                        parkingStages.Add(key, new Parking<Vehicle>(pictureWidth, pictureHeight));
                    }
                    else if(line.Split(separator)[0] == "Cruiser")
                    {
                        cruiser = new CruiserSimp(line.Split(separator)[1]);
                        var result = parkingStages[key] + cruiser;
                        if (result < 0)
                        {
                            return false;
                        }
                    }
                    else if (line.Split(separator)[0] == "WarCruiser")
                    {
                        cruiser = new WarCruiser(line.Split(separator)[1]);
                        var result = parkingStages[key] + cruiser;
                        if (result < 0)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return true;
        }
    }
}
