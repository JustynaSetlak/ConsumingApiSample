﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSample
{
    public class Post
    {        
        public int Id { get; set; }
   
        public string Title { get; set; }

        public string Body { get; set; }
    }
}
