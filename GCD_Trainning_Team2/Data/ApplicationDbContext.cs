using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using GCD_Trainning_Team2.Models;
using Microsoft.EntityFrameworkCore;

namespace GCD_Trainning_Team2.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<AccessRes> AccessRequests { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<UpdateRes> UpdateRequests { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<CategoryDocument> Categories_Documents { get; set; }
        public virtual DbSet<Chapter> Chapters { get; set; }
    }
}
