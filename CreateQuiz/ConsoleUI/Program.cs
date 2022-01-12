using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            UserManager userManager = new UserManager(new IEFUserDal());
            foreach (var item in userManager.GetAll())
            {
             Console.WriteLine(item.UserName);
            }
            Console.ReadLine();
        }
    }
}
