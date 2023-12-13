using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MerchShopWF
{
    abstract internal class AdditionalLogic
    {
        static public int CreateNewId(int tableNumber)
        {
            int newId = 1;;
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from performers in dbContext.Performers
                        select performers.Id;
                List<int> idList;
                switch (tableNumber)
                {
                    case 1:
                        q = from performers in dbContext.Performers
                                select performers.Id;
                        idList = q.ToList();
                        while (newId <= idList.Count)
                        {
                            if (newId != idList[newId - 1])
                            {
                                break;
                            }
                            newId++;
                        }
                        break;
                    case 2:
                        q = from albums in dbContext.Albums
                               select albums.Id;
                        idList = q.ToList() ;
                        while (newId <= idList.Count)
                        {
                            if (newId != idList[newId - 1])
                            {
                                break;
                            }
                            newId++;
                        }
                        break;
                    case 3:
                        q = from items in dbContext.Items
                            select items.Id;
                        idList = q.ToList() ;
                        while(newId <= idList.Count)
                        {
                            if (newId != idList[newId - 1])
                            {
                                break;
                            }
                            newId++;
                        }
                        break;
                    case 4:
                        q = from customers in dbContext.Customers
                            select customers.Id;
                        idList = q.ToList() ;
                        while(newId <= idList.Count)
                        {
                            if (newId != idList[newId - 1])
                            {
                                break;
                            }
                            newId++;
                        }
                        break;
                    case 5:
                        q = from orders in dbContext.Orders
                            select orders.Id;
                        idList = q.ToList() ;
                        while( newId <= idList.Count)
                        {
                            if (newId != idList[newId - 1])
                            {
                                break;
                            }
                            newId++;
                        }
                        break;
                }
                return newId;
            }
        }

        static public bool CyrillicOnly(string someString)
        {
            Regex regex = new Regex(@"^[а-яА-ЯёЁ]+$");
            return regex.IsMatch(someString);
        }
        static public bool IsANumber (string someString, out int number) 
        {
            return int.TryParse(someString, out number);
        }

        static public bool ValidEmail(string someString)
        {
            // Используем регулярное выражение для проверки валидности e-mail адреса
            Regex regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            return regex.IsMatch(someString);
        }
    }
}
