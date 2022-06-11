using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeWork2
{
    class Garden
    {
        public List<IGardenItem> gardenItems = new List<IGardenItem>();
        public IEnumerable<IGardenItem> Foods { get { return gardenItems.Where(gardenItem => gardenItem.GetType().BaseType.GetInterfaces().ElementAt(1).ToString().Equals("OOPHomeWork2.IFood")).ToList(); } }
        public IEnumerable<IGardenItem> Beautys { get { return gardenItems.Where(gardenItem => gardenItem.GetType().BaseType.GetInterfaces().ElementAt(1).ToString().Equals("OOPHomeWork2.IBeauty")); } }

        public void AddToList(IGardenItem gardenItem)
        {
            gardenItems.Add(gardenItem);
        }
        public string WaterRequired()
        {
            double result = 0;
            IEnumerable<double> waterRequireds = gardenItems.Select(gardenItem => gardenItem.WaterRequired);
            foreach(var waterRequired in waterRequireds)
            {
                result += waterRequired;
            }
            return $"WaterRequired: {result}";
        }
        public string Energy()
        {
            double result = 0;
            List<IFood> foods = new List<IFood>();
            foreach(var food in Foods)
            {
                foods.Add((IFood)food);
            }
            IEnumerable<double> energys = foods.Select(food => food.Energy);
            foreach (var energy in energys)
            {
                result += energy;
            }
            return $"Energy: {result}";
        }
        public string BeautyScore()
        {
            double result = 0;
            List<IBeauty> beautys = new List<IBeauty>();
            foreach (var beauty in Beautys)
            {
                beautys.Add((IBeauty)beauty);
            }
            IEnumerable<double> beautyScores = beautys.Select(beauty => beauty.BeautyScore);
            foreach (var beautyScore in beautyScores)
            {
                result += beautyScore;
            }
            return $"Beauty score: {result}";
        }
    }
}
