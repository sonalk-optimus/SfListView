using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SfListView
{
    public class BookInfo
    {
        private string bookName;

        public string BookName
        {
            get { return bookName; }
            set
            {
                bookName = value;
            }
        }
    }
}
