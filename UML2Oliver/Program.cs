using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
using PizzaLibrary.Services;

Console.WriteLine("Hello, World!");

Customer c1 = new Customer("Poul", "232323", "Gade 123", "Roskilde", true);
Customer c2 = new Customer("Oliver", "121212", "Gade 321", "Helsinge", false);
ICustomerRepository cusRepo = new CustomerRepository();
cusRepo.AddCustomer(c1);
cusRepo.AddCustomer(c2);

cusRepo.GetAll();
cusRepo.PrintAllCustomers();
cusRepo.GetCustomerByMobile("12121212");
cusRepo.RemoveCustomer("14141414");
cusRepo.GetAllClubmembers();
cusRepo.CustomerFromRoskilde();

MenuItem m1 = new MenuItem("Capricciosa", 98, "Tomat, ost, skinke & champignon", MenuType.PIZZECLASSSICHE);
IMenuItemRepository menuRepo = new MenuItemRepository();
menuRepo.AddMenuItem(m1);
menuRepo.GetAll();
menuRepo.GetMenuItemByNo(1);
menuRepo.PrintAllMenuItems();
menuRepo.RemoveMenuItem(2);
menuRepo.GetMenuItemType(MenuType.PIZZECLASSSICHE);

