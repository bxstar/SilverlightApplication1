using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace SilverlightApplication1.Model
{
    public class TwitterSearchResult
    {
        public string Author { get; set; }
        public string Tweet { get; set; }
        public DateTime PublishDate { get; set; }
        public string ID { get; set; }
        public ImageSource Avatar { get; set; }
    }
}
