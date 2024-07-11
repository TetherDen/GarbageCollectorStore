using GarbageCollectorStore.Users.Customer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorStore
{
    public class Cart
    {
        private List<Product> _itemsCart = new List<Product>();
        public List<Product> ItemCart { get { return _itemsCart; }}
        public void AddProductToCart()
        {
            int ID;
            int HowMany;
            bool isWorked = true;
            Console.WriteLine("Напиши номер продукта");
            int.TryParse(Console.ReadLine(), out ID);
            _itemsCart.Add(ProductManager.ProductList[ID - 1]);

            while (isWorked)
            {
            Console.WriteLine("Напиши сколько тебе нужно {0}", ProductManager.ProductList[ID - 1].Name);
            int.TryParse(Console.ReadLine(), out HowMany);
                if (HowMany <= _itemsCart[_itemsCart.Count - 1].Quantity)
                {
                    ItemCart[_itemsCart.Count - 1].Quantity = HowMany;
                    isWorked = false;
                }
                else
                {
                    Console.WriteLine(TextColor.ErrorText("Ошибка: Введите правильное количество"));
                }

            }

        }
        public void RemoveProductFromCart(int index) 
        {
            if (index > 0 && index <= _itemsCart.Count)
            { 
                Console.WriteLine(TextColor.SuccessfulText($" {_itemsCart[index - 1].Name} успешно удалено."));
                _itemsCart.RemoveAt(index - 1);
            }
            else
            {
                Console.WriteLine(TextColor.ErrorText("Неправильный ID. пожалуйста введите правильный ID."));
            }
        }
        public void ViewCart() 
        {
            Console.WriteLine("Содержимое корзины:");
            if (_itemsCart.Count == 0)
            {
                Console.WriteLine("Товара нет в корзине");
            }
            else
            {
                foreach (Product item in _itemsCart)
                {
                    Console.WriteLine($"ID: {item.Id} Продукт: {item.Name}, Количество: {item.Quantity}\n");
                    //Console.WriteLine($"ID: {(item as Product).Id} Продукт: {(item as Product).Name}, Количество: {(item as Product).Quantity}\n");
                }
            }
        }
        public void Checkout()
        {
            if (_itemsCart.Count != 0)
            {
                Console.WriteLine("Вы точно хотите оплатить товар ?\n1) да\n2) нет");
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Заказ оформлен и оплачен.");
                            _itemsCart.Clear();

                            break;
                        case 2:
                            Console.WriteLine("Оплата отменена.");
                            break;
                        default:
                            Console.WriteLine("Неверный выбор.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
                }
            }
            else
            {
                Console.WriteLine("Товара нет в корзине");

            }
        }

        private static void deleteFromProdList()
        {
            foreach (var cartProduct in (UserManager.CurrentUser as Customer).Cart.ItemCart)
            {
                foreach (var ProdList in ProductManager.ProductList)
                {
                    if (cartProduct.Id == ProdList.Id)
                    {
                        ProdList.Quantity -= cartProduct.Quantity;
                        break;
                    }
                }
            }
        }
    }


}
