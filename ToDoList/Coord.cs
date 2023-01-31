using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Coord
    {
        private int _left;
        private int _top;
        public Coord() {
            _left = Console.GetCursorPosition().Left;
            _top = Console.GetCursorPosition().Top;
        }
        public void SetCoordPos()
        {
            Console.SetCursorPosition(_left, _top);
        }
    }
}
