using System.Net.Mime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Identity;
using Fake_instagram.Models;

namespace Fake_instagram
{
    public class Post: BaseClassElements
    {
        public string PostPhoto { get; set;}
        public PostComments? Comments { get; set; }
    }
}