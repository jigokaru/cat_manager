using C__OOP.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP.model
{
    internal class MeoNga : IMeo
    {
        public MeoNga()
        {
            Sound= "meo";
        }
        public override  void show()
        {

            
            Console.WriteLine("meo nga");
            Console.WriteLine($"ID: {this.ID}, ten {this.Ten}, Tuoi: {this.Tuoi}, gioi tinh: {GioiTinh}, tieng meo {Sound} ");
            
        }
        
    }
}
