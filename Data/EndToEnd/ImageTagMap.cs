﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Sandwich_King_DB.Data.EndToEnd
{
    public partial class ImageTagMap
    {
        public string ImageId { get; set; }
        public string TagId { get; set; }

        public virtual Image Image { get; set; }
        public virtual ImageTags Tag { get; set; }
    }
}