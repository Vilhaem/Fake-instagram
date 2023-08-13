using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fake_instagram.Models;
using Microsoft.AspNetCore.Identity;

namespace Fake_instagram
{
    public class PostComments : BaseClassElements
    {
        public SubComments subComments { get; set; }

    }
}