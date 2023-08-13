using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Fake_instagram.Models
{
    public class BaseClassElements
    {
        public string Id { get; set;}
        public string UserName { get; set;}
        public int LikeCount { get; set;}
    }
}