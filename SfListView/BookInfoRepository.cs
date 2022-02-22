using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SfListView
{
    public class BookInfoRepository
    {
        private ObservableCollection<BookInfo> bookInfo;

        public ObservableCollection<BookInfo> BookInfo
        {
            get { return bookInfo; }
            set { this.bookInfo = value; }
        }

        public BookInfoRepository()
        {
            GenerateBookInfo();
        }

        internal void GenerateBookInfo()
        {
            bookInfo = new ObservableCollection<BookInfo>();
            bookInfo.Add(new BookInfo() { BookName = "Object-Oriented Programming in C#"});
            bookInfo.Add(new BookInfo() { BookName = "C# Code Contracts"});
            bookInfo.Add(new BookInfo() { BookName = "Machine Learning Using C#" });
            bookInfo.Add(new BookInfo() { BookName = "Neural Networks Using C#"});
        }
    }
}
