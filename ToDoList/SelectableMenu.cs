using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class SelectableMenu: IPrintableMenu
    {
        ConsoleKeyInfo ki;
        private Coord _startCoord;
        private int _cursorPosition = 0;
        private readonly string _title;
        private readonly List<string> _menuItems;
        public SelectableMenu(string title, List<string> items)
        {
            _title = title;
            _menuItems = items;
        }
        private void PrintTitle()
        {
            Console.WriteLine(_title);
            Console.WriteLine("Выберите пункт \"<\"|\">\" и нажмите Enter");
        }
        private void PrintItems()
        {
            for (int i = 0; i < _menuItems.Count; i++)
            {
                var marker = i == _cursorPosition ? ">" : " ";
                Console.WriteLine($"{marker}{_menuItems[i]}  ");
            }
        }
        public void PrintMenu()
        {
            _startCoord.SetCoordPos();
            PrintTitle();
            PrintItems();
        }
        public int MoveNextStep()
        {
            _startCoord = new Coord();
            do
            {
                PrintMenu();
                ki = Console.ReadKey();
                switch (ki.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (_cursorPosition > 0)
                        {
                            _cursorPosition--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (_cursorPosition < _menuItems.Count - 1)
                        {
                            _cursorPosition++;
                        }
                        break;
                }
            } while (ConsoleKey.Enter != ki.Key);
            return _cursorPosition;
        }
    }
}
