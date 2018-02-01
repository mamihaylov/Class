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
       // Конструктор необязательных аргументов.
       public Books (int prace =0, string name = "")
        {
            if (prace > 12)
            { prace = 12; }
            bookprace = prace;
            bookname = name;
        }
        /*public Books () { }
        public Books(int bookprace)
            : this("", bookprace) { }
        public Books (string bookname)
            : this(bookname ,0) { }
        
        // Главный констуктор.
        public Books (string bookname, int bookprase)
        {
            // Акция все книги не дороже 12$
            if (bookprace > 12)
            { bookprace = 12; }


            this.bookname = bookname;
           }*/
        // Функционал.
        public void PrintState()
        {
            Console.WriteLine("{0} Buy {1} $.", bookname, bookprace);
        }
    }

}
