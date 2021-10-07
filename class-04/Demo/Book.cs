using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Book
    {
        // Field = class instance variable
        private readonly string title;

        // Constructor!
        public Book(string title)
        {
            // TODO: test this
            if (title == null) throw new ArgumentNullException(nameof(title));

            this.title = title;
        }

        // Properties
        public string Title
        {
            get { return this.title; }
        }


        // Methods

        // Example that's equivalent to the Title property
        public string GetTitle()
        {
            return this.title;
        }


        // author
        // chapters
        // publish year
        // page count
        // isbn
    }
}
