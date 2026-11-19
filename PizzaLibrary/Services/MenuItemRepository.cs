using PizzaLibrary.Data;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLibrary.Services
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private List<IMenuItem> _menuItemList;

        public MenuItemRepository()
        {
            _menuItemList = MockData.MenuItemData;
        }

        public int Count => _menuItemList.Count;

        public void AddMenuItem(IMenuItem menuItem)
        {
            _menuItemList.Add(menuItem);
        }

        public List<IMenuItem> GetAll()
        {
            return _menuItemList;
        }

        public IMenuItem GetMenuItemByNo(int no)
        {
            foreach(IMenuItem item in _menuItemList)
            {
                if(item.No == no)
                {
                    return item;
                }
            }
            return null;
        }

        public void PrintAllMenuItems()
        {
            foreach(IMenuItem item in _menuItemList)
            {
                Console.WriteLine(item);
            }
        }

        public void RemoveMenuItem(int no)
        {
            IMenuItem item = GetMenuItemByNo(no);

            if (item != null)
            {
                _menuItemList.Remove(item);
            }
        }

        public List<IMenuItem> GetMenuItemType(MenuType type)
        {
            List<IMenuItem> getItem = new List<IMenuItem>();

            foreach (IMenuItem item in _menuItemList)
            {
                if(item.TheMenuType == type)
                {
                    getItem.Add(item);
                }
            }
            return getItem;
        }
        /*
        public IMenuItem GetPriciestItemByType(MenuType type)
        {

        
        

        }
        */
    }
}
