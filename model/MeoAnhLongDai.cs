using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP.model
{
    internal class MeoAnhLongDai : IMeo
    {
        string MeoAnhLongDais = "meo anh long dai";
        public MeoAnhLongDai()
        {
            Sound = "meo meo";
        }
        public override void show()
        {
             Console.WriteLine("meo anh long dai");
             Console.WriteLine($"ID: {this.ID}, ten {this.Ten}, Tuoi: {this.Tuoi}, gioi tinh: {GioiTinh}, tieng meo {Sound} ");
            
                
        }
        
    }
}
