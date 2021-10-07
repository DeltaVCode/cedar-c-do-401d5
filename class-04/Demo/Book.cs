using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Book
    {
        // Static Field
        private static int bookCount;

        // Field = class instance variable
        private readonly string title;
        private int pageCount;

        // Constructor!
        public Book(string title)
        {
            // TODO: test this
            if (title == null) throw new ArgumentNullException(nameof(title));

            this.title = title;

            // Also update static counter for all books!
            bookCount++;
        }

        // Properties
        public string Title
        {
            get { return this.title; }
        }

        public int PageCount
        {
            get { return this.pageCount; }
            set { this.pageCount = value; }
        }

        public string ISBN
        {
            // Automatic Property - generates a hidden field
            get;
            set;
        }

        // More common formatting for auto prop
        public int PublishYear { get; private set; }

        public Author Author { get; set; }

        // Methods

        // Example that's equivalent to the Title property
        public string GetTitle()
        {
            return this.title;
        }


        // author
        // chapters
        // publish year
    }
}
