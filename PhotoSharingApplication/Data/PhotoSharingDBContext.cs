using PhotoSharingApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhotoSharingApplication.Data
{
    public class PhotoSharingDBContext : DbContext
    {
        public PhotoSharingDBContext() : base("keyPhotoSharingDB") { }

        public DbSet<Photo> Photos { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}