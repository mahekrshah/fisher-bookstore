using System;
namespace Fisher.Bookstore.Models

{
    public class Book{
        public String Title { get; set; }

        public Author Author { get; set; }

        public String ISBN { get; set; }

        public int Id { get; set; }

        public DateTime PublishDate {get; set;}
        public string Publisher { get; set;}

        public void ChangePublicationDate(DateTime dateTime)
        {
            this.PublishDate = dateTime;
        }

        public void ChangePublisher(string newPublisher)
        {
            this.Publisher = newPublisher;
        }

        public void ChangeTitle(string NewTitle)
        {
            this.Title = NewTitle;
        }
    }

}