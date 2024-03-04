using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KidKinder.Entities;
using System.Data.Entity;

namespace KidKinder.Context
{
    public class KidKinderContext : DbContext

    {
    
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutList> AboutLists { get; set; }
        public DbSet<BookASeat> BookASeats { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<Communication> Communications { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<MailSubscribe> MailSubscribes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Family> Families { get; set; }
  
        public DbSet<Gallery> Gallery { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Login> logins { get; set; }
      
       
    }
}