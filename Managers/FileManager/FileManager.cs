using GarbageCollectorStore.Users.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GarbageCollectorStore
{
    internal static class FileManager
    {
        public static  void SaveUsers()
        {
            if(!Directory.Exists(Config.usersPathToDir))
            {
                Directory.CreateDirectory(Config.usersPathToDir);
            }
            using (FileStream fs = new FileStream(Config.usersPathToFile, FileMode.Create))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    foreach ( User user in UserManager.UsersList)
                    {
                        if(user is Customer)
                        {
                            bw.Write("Customer");
                        }
                        else if (user is Admin)
                        {
                            bw.Write("Admin");
                        }
                        bw.Write(user.Login);
                        bw.Write(user.Password);
                        if(user is Customer customer)
                        {
                            bw.Write(customer.Name);
                            bw.Write(customer.Address);
                            bw.Write(customer.Email);
                        }
                    }
                }
            }
        }

        public static void LoadUsers()
        {
            if(File.Exists(Config.usersPathToFile))
            {
                using (FileStream fs = new FileStream(Config.usersPathToFile, FileMode.Open))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        while(fs.Length >br.BaseStream.Position)
                        {
                            string userType = br.ReadString();
                            string login = br.ReadString();
                            string password = br.ReadString();
                            if (userType == "Customer")
                            {
                                string name = br.ReadString();
                                string address = br.ReadString();
                                string email = br.ReadString();
                                Customer customer = new Customer(login, password, name, address, email);
                                UserManager.UsersList.Add(customer);
                            }
                            else if (userType == "Admin")
                            {
                                Admin admin = new Admin(login, password);
                                UserManager.UsersList.Insert(0, admin);
                            }
                        }
                    }
                }
            }
        }
        public static void SaveProducts()
        {
            if (!Directory.Exists(Config.productsPathToDir))
            {
                Directory.CreateDirectory(Config.productsPathToDir);
            }
            string jsonStr = JsonConvert.SerializeObject(ProductManager.ProductList, Formatting.Indented);
            if(jsonStr.Length >0)
            {
                File.WriteAllText(Config.productsPathToFile, jsonStr);
            }
        }

        public static void LoadProducts()  // TODO: not working yeat
        {
            if(File.Exists(Config.productsPathToFile))
            {
                ProductManager.ProductList = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(Config.productsPathToFile));
                //string jsonStr = File.ReadAllText(Config.ProductsPathToFile);
                //ProductManager.ProductList = JsonConvert.DeserializeObject<List<Product>>(jsonStr);
            }
        }

        public static void SaveReviews()
        {
            if(!Directory.Exists(Config.reviewsPathToDir))
            {
                Directory.CreateDirectory(Config.reviewsPathToDir);
            }
            string jsonStr = JsonConvert.SerializeObject(Review.AllReviews, Formatting.Indented);
            if(jsonStr.Length >0)
            {
                File.WriteAllText(Config.reviewsPathToFile, jsonStr);
            }
        }
        public static void LoadReviews()
        {
            if(File.Exists(Config.reviewsPathToFile))
            {
                Review.AllReviews = JsonConvert.DeserializeObject<List<Review>>(File.ReadAllText(Config.reviewsPathToFile));
            }
        }


    }
}
