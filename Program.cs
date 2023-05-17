using C__OOP.model;
using C__OOP.view;

namespace C__OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CatView catView = new CatView();
            catView.Menu();
        }
    }
}