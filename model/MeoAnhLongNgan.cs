using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP.model
{
    internal class MeoAnhLongNgan : IMeo
    {
        public MeoAnhLongNgan()
        {
            Sound = "meo meo meo";
        }

        public override void show()
        {
             Console.WriteLine("meo anh long ngan");
             Console.WriteLine($"ID: {this.ID}, ten {this.Ten}, Tuoi: {this.Tuoi}, gioi tinh: {GioiTinh}, tieng meo {Sound} ");
            
        }
        
    }
}
