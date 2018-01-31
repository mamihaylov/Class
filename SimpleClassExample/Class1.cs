using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Books
    {
        public string bookname;
        public int bookprace;
        // Получение стандартного значение int для bookprace.
        public Books(string bp)
        {
            bookname = bp;
        }
        // Установливает полное состояние Books.
        public Books(string bp, int cs)
        {
            bookname = bp;
            bookprace = cs;

        }
        public Books(int cs)
        {
            bookprace = cs;
        }
        // Функционал.
        public void PrintState()
        {
            Console.WriteLine("{0} Buy {1} $.", bookname, bookprace);
        }
    }

}
