using PizzaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace PizzaLibrary.Models
{
    public class MenuItem : IMenuItem
    {
        private static int counter = 0;
        public MenuItem(string name, double price, string description, MenuType menuType)
        {
            No = counter++;
            Name = name;
            Price = price;
            Description = description;
            TheMenuType = menuType;
        }
        

        public string Description { get ; set ; }
        public string Name { get ; set ; }

        public int No { get; private set; }

        public double Price { get ; set ; }
        public MenuType TheMenuType { get ; set ; }

        public override string ToString()
        {
            return $"{No} {Name} {Price} {Description} {TheMenuType}";
        }
    }
}
