using C__OOP.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__OOP.Helper;
namespace C__OOP.model
{
    public abstract class IMeo 
    {
        private int _id;
        public int ID 
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public string GioiTinh { get; set; }
        public string Sound{ get; set; }

        public IMeo()
        {
            
                
                bool check = true;
                
                ID = InputHelper.InputINT(Res.InputID, Res.ErrorID);
                Ten = InputHelper.InputSTR(Res.InputTen, Res.ErrorTen, 1, 30);
                Tuoi = InputHelper.InputINT(Res.InputTuoi, Res.ErrorTuoi);
                GioiTinh = InputHelper.InputSTR(Res.InputGioiTinh, Res.ErrorGioiTinh, 1, 20);
                
                
        }

        public abstract void show();
        
        
    }
}
