using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP.Helper
{
    enum ErrorType
    {
        MeoDaTonTai,
        MeoChuaTonTai,
        DanhSachTrong,
        ThanhCong
    }
    internal class Error
    {
        public static void log(ErrorType type)
        {
            switch (type)
            {
                case ErrorType.MeoDaTonTai:
                    Console.WriteLine("Meo da ton tai");
                    break;
                case ErrorType.MeoChuaTonTai:
                    Console.WriteLine("Meo chua ton tai");
                    break;
                case ErrorType.DanhSachTrong:
                    Console.WriteLine("danh sach trong");
                    break;
                case ErrorType.ThanhCong:
                    Console.WriteLine("thanh cong");
                    break;
            }
        }
    }
}
