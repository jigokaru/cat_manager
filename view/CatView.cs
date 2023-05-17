using C__OOP.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__OOP.controller;
using C__OOP.Helper;
using C__OOP.model;
namespace C__OOP.view
{
    internal class CatView
    {
        CatController cc = new CatController();
        
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("--------------Quan Ly Meo-----------------");
            Console.WriteLine("1. Them meo");
            Console.WriteLine("2. Xoa meo theo ID");
            Console.WriteLine("3. Hien thi toan bo meo");
            Console.WriteLine("4. Hien thi meo theo ID");
            Console.WriteLine("5. Thay doi tieng meo keu theo ID");
            Console.WriteLine("6. Thoat chuong trinh");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            RequestController(c);

        }
        public void RequestController(char c)
        {
            
            switch (c)
            {
                case '1':
                    Console.WriteLine("a. Meo Nga");
                    Console.WriteLine("b. Meo Ba Tu");
                    Console.WriteLine("c. Meo Anh Long Ngan");
                    Console.WriteLine("d. Meo Anh Long Dai");
                    Console.WriteLine();
                    
                    switch (Console.ReadKey().KeyChar)
                    {
                        case 'a':
                            Error.log(cc.Insert(new MeoNga()));
                            break;
                        case 'b':
                            Error.log(cc.Insert(new MeoBaTu()));
                            break;
                        case 'c':
                            Error.log(cc.Insert(new MeoAnhLongNgan()));
                            break;
                        case 'd':
                            Error.log(cc.Insert(new MeoAnhLongDai()));
                            break;
                    }
                    Console.ReadLine();
                    break;
                case '2':
                    Error.log(cc.Delete());
                    break;
                case '3':
                    Error.log(cc.ViewAll());
                    break;
                case '4':
                    Error.log(cc.ViewID());
                    break;
                case '5':
                    Error.log(cc.Update());
                    break;
                case '6':
                    return;
            }
            Console.ReadKey();
            Menu();
        }
    }
}
