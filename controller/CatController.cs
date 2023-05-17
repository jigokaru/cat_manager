using C__OOP.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__OOP.Helper;
using C__OOP.model;
namespace C__OOP.controller
{
    internal class CatController
    {
        
        List<IMeo> cat = new List<IMeo>();
        public ErrorType Insert(IMeo meos)
        {
            if(cat.Count == 0)
            {
                cat.Add(meos);
                return ErrorType.ThanhCong;
            }
            else
            {
                int pos = cat.FindIndex(x => x.ID == meos.ID);
                if (pos == -1)
                {
                    cat.Add(meos);
                    return ErrorType.ThanhCong;
                }
                else return ErrorType.MeoDaTonTai;
            }
        }
        public ErrorType Delete()
        {
            int IDMeo = InputHelper.InputINT(Res.InputID, Res.ErrorID);
            int pos = cat.FindIndex(x => x.ID == IDMeo);
               if (pos == -1)
                {
                    return ErrorType.MeoChuaTonTai;
                }
                else
                {
                    cat.RemoveAt(pos);
                    return ErrorType.ThanhCong;
                }
            
        }
        public ErrorType Update()
        {
            int IDMeo = InputHelper.InputINT(Res.InputID, Res.ErrorID);
            int pos = cat.FindIndex(x => x.ID == IDMeo);
            if (pos == -1)
            {
                return ErrorType.MeoChuaTonTai;
            }
            else
            {
                cat[pos].Sound = InputHelper.InputSTR("nhap tieng meo moi", "loi , yeu cau nhap lai", 1, 30);
                return ErrorType.ThanhCong;
            }
        }
           
        public ErrorType ViewAll()
        {
            if( cat.Count == 0)
            {
                return ErrorType.DanhSachTrong;
            }
            else
            {
                cat.ForEach(x => x.show());
                return ErrorType.ThanhCong;
            }
        }
        public ErrorType ViewID()
        {
            int IDMeo = InputHelper.InputINT(Res.InputID, Res.ErrorID);
            int pos = cat.FindIndex(x => x.ID == IDMeo);
            if (pos == -1)
            {
                return ErrorType.MeoChuaTonTai;
            }
            else
            {
                cat[pos].show();
                return ErrorType.ThanhCong;
            }

        }

    }
}
