using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBookGalery.Models
{ 
    public class ComicBookRepository
    {
        private static ComicBook[] _comicBooks = new ComicBook[]
    {
        new ComicBook()
            {
                Id = 1,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHTML = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Favorite = true,
                CoverImageFileName = "https://images-na.ssl-images-amazon.com/images/I/91l6A1h%2BsTL.jpg",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist() { Name = "Victor Olazaba", Role = "Links" },
                    new Artist() { Name = "Edgar Delgado", Role = "Colors" },
                    new Artist() { Name = "Chris Eliopoulos", Role = "Letters" }
                },
            },
        new ComicBook()
            {
                Id = 2,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 657,
                DescriptionHTML = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
                CoverImageFileName = "https://vignette.wikia.nocookie.net/marveldatabase/images/7/70/Amazing_Spider-Man_Vol_1_657.jpg/revision/latest?cb=20110331050922",
                Artists = new Artist[]
                    {
                        new Artist() { Name = "Dan Slott", Role = "Script" },
                        new Artist() { Name = "Marcos Martin", Role = "Pencils" },
                        new Artist() { Name = "Marcos Martin", Role = "Inks" },
                        new Artist() { Name = "Muntsa Vicente", Role = "Colors" },
                        new Artist() { Name = "Joe Caramagna", Role = "Letters" }
                    },
                    Favorite = false,
                
        },
            new ComicBook()
            {
                Id = 3,
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHTML = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
                CoverImageFileName = "http://2.bp.blogspot.com/07mwGaaMUn76Ae_705NP-MGV1WplLMYe-SlvNew-GZMM8s0wdHW7v6HcNAht8kxQdJKOBn_bt3Lk=s1600",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Jeff Smith", Role = "Script" },
                    new Artist() { Name = "Jeff Smith", Role = "Pencils" },
                    new Artist() { Name = "Jeff Smith", Role = "Inks" },
                    new Artist() { Name = "Jeff Smith", Role = "Letters" }
                },
                Favorite = false,
                }
            };
            public ComicBook GetComicBook(int id)
            {
                ComicBook comicBookToReturn = null;
                foreach (var comicBook in _comicBooks)
                {
                    if (comicBook.Id == id)
                    {
                        comicBookToReturn = comicBook;

                        break;
                    }
                }
                return comicBookToReturn;
            }
            public ComicBook[] GetComicBooks()
            {
                return _comicBooks;
            }
    }
}
