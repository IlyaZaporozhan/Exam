using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Garden
    {
        public string Owner { get; set; }
        public string Adress { get; set; }

        public List<Flower> Flowers = new List<Flower>();

        public Garden(string own, string add)
        {
            Owner = own;
            Adress = add;
        }
        public void ShowAll()
        {
            Console.WriteLine("Информация о саде:\n" + $"\tВладелец: {Owner}\n" + $"\tАдрес: {Adress}\n\n" + $"Цветы сада:");
            Flowers.Sort();
            foreach (Flower flower in Flowers)
            {
                flower.Show();
            }
        }
    }
    public class Flower : IComparable
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Flower(string t, string des)
        {
            Title = t;
            Description = des;
        }
        public void Show()
        {
            Console.WriteLine("Информация о цветке:\n" + $"\tНазвание: {Title}\n" + $"\tВладелец: {Description}");
        }
        public int CompareTo(object obj)
        {
            return (this.Title + this.Description).CompareTo(Title + Description);
        }
    }
}

