using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBookGalery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public Artist[] DescriptionHTML { get; set; }
        public string[] Artists { get; set; }
        public bool Favorite { get; set; }

    }
}
