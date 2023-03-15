using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fake_instagram.Models.Enum;
namespace Fake_instagram.Models
{
    public class Photo
    {
        public string Id { get; set; }
        public string Source { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public Formats Format { get; set; }
    }
}