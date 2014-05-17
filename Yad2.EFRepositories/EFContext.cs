using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Security.Model;
using Yad2.Model.Entities;
using Yad2.Model.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;


namespace Yad2.EFRepositories
{
    public class EFContext : DbContext
    {

        private static EFContext _efContext = null;

        private EFContext(string name) : base(name)
        {

        }

        public static EFContext Get()
        {
            if (_efContext == null)
            {
                _efContext = new EFContext("GeviaYad2DB");
                _efContext.Cars
                        .Include(i => i.Manufacturer)
                        .Include(i => i.Model)
                        .Include(i => i.Category)
                        .Include(i => i.City)
                        .Include(i => i.GearType)
                        .Include(i => i.Pics)
                        .Include(i => i.Region)
                        .Include(i => i.Seller)
                        .ToList();


                _efContext.SecondHandItems
                        .Include(i => i.Category)
                        .Include(i => i.City)
                    //    .Include(i => i.Pics)
                        .Include(i => i.Region)
                        .Include(i => i.Seller)
                        .Include(i => i.State)
                        .Include(i => i.Type)
                        .Include(i => i.SubType)
                        .ToList();

                _efContext.SecondHandTypes
                        .Include(i => i.ParentType)
                        .Include(i => i.ChildTypes)
                        .ToList();


                _efContext.Jeeps
                       .Include(i => i.Manufacturer)
                       .Include(i => i.Model)
                       .Include(i => i.Category)
                       .Include(i => i.City)
                       .Include(i => i.GearType)
                       .Include(i => i.Pics)
                       .Include(i => i.Region)
                       .Include(i => i.Seller)
                       .ToList();

                         _efContext.Commercials
                       .Include(i => i.Manufacturer)
                       .Include(i => i.Model)
                       .Include(i => i.Category)
                       .Include(i => i.City)
                       .Include(i => i.GearType)
                       .Include(i => i.Pics)
                       .Include(i => i.Region)
                       .Include(i => i.Seller)
                       .ToList();

                _efContext.Categories
                    .Include(i => i.Parent)
                    .Include(i => i.ChildCategories);

                _efContext.Cities.Include(i => i.Region);

               

                _efContext.Motorcycles
                     .Include(i => i.Manufacturer)
                        .Include(i => i.Model)
                        .Include(i => i.Category)
                        .Include(i => i.City)
                        .Include(i => i.Pics)
                        .Include(i => i.Region)
                        .Include(i => i.Seller)
                        .ToList();

                _efContext.Scooter
                   .Include(i => i.Manufacturer)
                      .Include(i => i.Model)
                      .Include(i => i.Category)
                      .Include(i => i.City)
                      .Include(i => i.Pics)
                      .Include(i => i.Region)
                      .Include(i => i.Seller)
                      .ToList();

                _efContext.Regions
                    .Include(i => i.Parent)
                    .Include(i => i.ChildRegions)
                    .ToList();

                _efContext.Sellers
                    .Include(i => i.User)
                    .ToList();

                _efContext.Users
                    .Include(i => i.UserGroups)
                    .ToList();

                _efContext.UsersGroups
                    .Include(i => i.Users)
                    .ToList();

                _efContext.VehicleManufacturers
                    .Include(i => i.Models)
                    .ToList();

                _efContext.VehicleModels
                    .Include(i => i.Manufacturer)
                    .ToList();

            }

            return _efContext;
        }


        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Scooter> Scooter { get; set; }
        public DbSet<PicOfPost> Pics { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<SecondHand> SecondHandItems { get; set; }
        public DbSet<SecondHandType> SecondHandTypes { get; set; }
        public DbSet<SecondHandState> SecondHandStates { get; set; }
      

        // posts
        public DbSet<Car> Cars { get; set; }
        public DbSet<Jeep> Jeeps { get; set; }
        public DbSet<Commercial> Commercials { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Motorcycle> Motorcycles { get; set; }
        public DbSet<Trucks> Trucks { get; set; }

        

        public DbSet<VehicleManufacturer> VehicleManufacturers { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }
        public DbSet<CarGearType> CarsGearTypes { get; set; }

        public DbSet<Region> Regions { get; set; }
        public DbSet<City> Cities { get; set; }

        public DbSet<UserBase> Users { get; set; }
        public DbSet<UsersGroupBase> UsersGroups { get; set; }

     //   public DbSet<UserInGroup> UsersInGroups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            Database.SetInitializer<EFContext>(new DropCreateDatabaseIfModelChanges<EFContext>());

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Car>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Cars");
            });

            modelBuilder.Entity<Jeep>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Jeeps");
            });

            modelBuilder.Entity<Commercial>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Commercials");
            });
            modelBuilder.Entity<Scooter>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("scooter");
            });

            modelBuilder.Entity<Motorcycle>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Motorcycles");
            });

            modelBuilder.Entity<SecondHand>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("SecondHandItems");
            });

            modelBuilder.Entity<Trucks>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Trucks");
            });

           

            modelBuilder.Entity<UserBase>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Users");
            });

            modelBuilder.Entity<UsersGroupBase>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("UsersGroups");
            }); 

            //modelBuilder.Entity<UserInGroup>().Map(m =>
            //{
            //    m.MapInheritedProperties();
            //    m.ToTable("UsersInGroups");
            //});


            modelBuilder.Entity<Seller>().HasKey(s => s.Id).Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //modelBuilder.Entity<Scooter>().HasKey(s => s.Id).Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<PicOfPost>().HasKey(s => s.Id).Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Category>().HasKey(s => s.Id).Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Car>().HasKey(s => new { s.Id, s.CategoryId }).Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Jeep>().HasKey(s => new { s.Id, s.CategoryId }).Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Commercial>().HasKey(s => new { s.Id, s.CategoryId }).Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<CarGearType>().HasKey(s => s.Id).Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Trucks>().HasKey(s => new { s.Id, s.CategoryId }).Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Motorcycle>().HasKey(s => new { s.Id, s.CategoryId }).Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Scooter>().HasKey(s => new { s.Id, s.CategoryId }).Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
           // modelBuilder.Entity<SecondHand>().HasKey(s => new { s.Id, s.CategoryId }).Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<VehicleManufacturer>().HasKey(s => s.Id).Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<VehicleModel>().HasKey(s => s.Id).Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Region>().HasKey(s => s.Id).Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<City>().HasKey(s => s.Id).Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Color>().HasKey(s => s.Id).Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<UserBase>().HasKey(s => s.Id).Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<UsersGroupBase>().HasKey(s => s.Id).Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
           // modelBuilder.Entity<UserInGroup>().HasKey(s => new {s.UserId , s.GroupId});
            modelBuilder.Entity<SecondHand>().HasKey(s => s.Id).Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<SecondHandState>().HasKey(s => s.Id).Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<SecondHandType>().HasKey(s => s.Id).Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<UserBase>()
                .HasMany(c => c.UserGroups)
                .WithMany(r => r.Users)
                .Map(x =>
                {
                    x.MapLeftKey("UserId");
                    x.MapRightKey("GroupId");
                    x.ToTable("UsersInGroups");
                });


            modelBuilder.Entity<Seller>()
                .HasRequired(s => s.User)
                .WithMany()
                .HasForeignKey(s => s.UserId);
                
                

            modelBuilder.Entity<City>()
                .HasRequired(c => c.Region)
                .WithMany(r => r.Cities)
                .HasForeignKey(c => c.RegionId)
                .WillCascadeOnDelete(false);

            
                
            modelBuilder.Entity<VehicleModel>()
                .HasRequired(m => m.Manufacturer)
                .WithMany(r => r.Models)
                .HasForeignKey(m => m.ManufacturerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasOptional(p => p.Parent)
                .WithMany(c => c.ChildCategories)
                .HasForeignKey(m => m.ParentId)
                .WillCascadeOnDelete(false);

            //car 
            modelBuilder.Entity<Car>()
                .HasRequired(p => p.Category)
                .WithMany()
                .HasForeignKey(m => m.CategoryId);

            modelBuilder.Entity<Car>()
                .HasRequired(c => c.GearType)
                .WithMany()
                .HasForeignKey(c => c.GearTypeId);

            modelBuilder.Entity<Car>()
                .HasOptional(p => p.City)
                .WithMany()
                .HasForeignKey(m => m.CityId);

            modelBuilder.Entity<Car>()
                .HasRequired(p => p.Manufacturer)
                .WithMany()
                .HasForeignKey(m => m.ManufacturerId);

            modelBuilder.Entity<Car>()
                .HasRequired(p => p.Model)
                .WithMany()
                .HasForeignKey(m => m.ModelId);

            modelBuilder.Entity<Car>()
                .HasRequired(p => p.Region)
                .WithMany()
                .HasForeignKey(m => m.RegionId);

            modelBuilder.Entity<Car>()
                .HasRequired(p => p.Seller)
                .WithMany()
                .HasForeignKey(m => m.SellerId);

            modelBuilder.Entity<Car>()
                .HasMany(u => u.Pics)
                .WithRequired()
                .HasForeignKey(m => new { m.PostId, m.CategoryId });


            ////

            modelBuilder.Entity<Jeep>()
              .HasRequired(p => p.Category)
              .WithMany()
              .HasForeignKey(m => m.CategoryId);

            modelBuilder.Entity<Jeep>()
                .HasRequired(c => c.GearType)
                .WithMany()
                .HasForeignKey(c => c.GearTypeId);

            modelBuilder.Entity<Jeep>()
                .HasOptional(p => p.City)
                .WithMany()
                .HasForeignKey(m => m.CityId);

            modelBuilder.Entity<Jeep>()
                .HasRequired(p => p.Manufacturer)
                .WithMany()
                .HasForeignKey(m => m.ManufacturerId);

            modelBuilder.Entity<Jeep>()
                .HasRequired(p => p.Model)
                .WithMany()
                .HasForeignKey(m => m.ModelId);

            modelBuilder.Entity<Jeep>()
                .HasRequired(p => p.Region)
                .WithMany()
                .HasForeignKey(m => m.RegionId);

            modelBuilder.Entity<Jeep>()
                .HasRequired(p => p.Seller)
                .WithMany()
                .HasForeignKey(m => m.SellerId);

            modelBuilder.Entity<Jeep>()
                .HasMany(u => u.Pics)
                .WithRequired()
                .HasForeignKey(m => new { m.PostId, m.CategoryId });
            //מסחרי

            modelBuilder.Entity<Commercial>()
              .HasRequired(p => p.Category)
              .WithMany()
              .HasForeignKey(m => m.CategoryId);

            modelBuilder.Entity<Commercial>()
                .HasRequired(c => c.GearType)
                .WithMany()
                .HasForeignKey(c => c.GearTypeId);

            modelBuilder.Entity<Commercial>()
                .HasOptional(p => p.City)
                .WithMany()
                .HasForeignKey(m => m.CityId);

            modelBuilder.Entity<Commercial>()
                .HasRequired(p => p.Manufacturer)
                .WithMany()
                .HasForeignKey(m => m.ManufacturerId);

            modelBuilder.Entity<Commercial>()
                .HasRequired(p => p.Model)
                .WithMany()
                .HasForeignKey(m => m.ModelId);

            modelBuilder.Entity<Commercial>()
                .HasRequired(p => p.Region)
                .WithMany()
                .HasForeignKey(m => m.RegionId);

            modelBuilder.Entity<Commercial>()
                .HasRequired(p => p.Seller)
                .WithMany()
                .HasForeignKey(m => m.SellerId);

            modelBuilder.Entity<Commercial>()
                .HasMany(u => u.Pics)
                .WithRequired()
                .HasForeignKey(m => new { m.PostId, m.CategoryId });

            //Scooter

            modelBuilder.Entity<Scooter>()
               .HasRequired(p => p.Category)
               .WithMany()
               .HasForeignKey(m => m.CategoryId);

            modelBuilder.Entity<Scooter>()
                .HasOptional(p => p.City)
                .WithMany()
                .HasForeignKey(m => m.CityId);

            modelBuilder.Entity<Scooter>()
                .HasRequired(p => p.Manufacturer)
                .WithMany()
                .HasForeignKey(m => m.ManufacturerId);

            modelBuilder.Entity<Scooter>()
                .HasRequired(p => p.Model)
                .WithMany()
                .HasForeignKey(m => m.ModelId);

            modelBuilder.Entity<Scooter>()
                .HasRequired(p => p.Region)
                .WithMany()
                .HasForeignKey(m => m.RegionId);

            modelBuilder.Entity<Scooter>()
                .HasRequired(p => p.Seller)
                .WithMany()
                .HasForeignKey(m => m.SellerId);

            modelBuilder.Entity<Scooter>()
                   .HasMany(u => u.Pics)
                   .WithRequired()
                   .HasForeignKey(m => new { m.PostId, m.CategoryId });
         
              
            
            // motorcycle

            modelBuilder.Entity<Motorcycle>()
                 .HasRequired(p => p.Category)
                 .WithMany()
                 .HasForeignKey(m => m.CategoryId);

            modelBuilder.Entity<Motorcycle>()
                .HasOptional(p => p.City)
                .WithMany()
                .HasForeignKey(m => m.CityId);

            modelBuilder.Entity<Motorcycle>()
                .HasRequired(p => p.Manufacturer)
                .WithMany()
                .HasForeignKey(m => m.ManufacturerId);

            modelBuilder.Entity<Motorcycle>()
                .HasRequired(p => p.Model)
                .WithMany()
                .HasForeignKey(m => m.ModelId);

            modelBuilder.Entity<Motorcycle>()
                .HasRequired(p => p.Region)
                .WithMany()
                .HasForeignKey(m => m.RegionId);

            modelBuilder.Entity<Motorcycle>()
                .HasRequired(p => p.Seller)
                .WithMany()
                .HasForeignKey(m => m.SellerId);

            modelBuilder.Entity<Motorcycle>()
                   .HasMany(u => u.Pics)
                   .WithRequired()
                   .HasForeignKey(m => new { m.PostId, m.CategoryId });


            //Trucks

            modelBuilder.Entity<Trucks>()
                .HasRequired(p => p.Category)
                .WithMany()
                .HasForeignKey(m => m.CategoryId);

            modelBuilder.Entity<Trucks>()
                .HasOptional(p => p.City)
                .WithMany()
                .HasForeignKey(m => m.CityId);

            modelBuilder.Entity<Trucks>()
                .HasRequired(p => p.Manufacturer)
                .WithMany()
                .HasForeignKey(m => m.ManufacturerId);

            modelBuilder.Entity<Trucks>()
                .HasRequired(p => p.Model)
                .WithMany()
                .HasForeignKey(m => m.ModelId);

            modelBuilder.Entity<Trucks>()
                .HasRequired(p => p.Region)
                .WithMany()
                .HasForeignKey(m => m.RegionId);

            modelBuilder.Entity<Trucks>()
                .HasRequired(p => p.Seller)
                .WithMany()
                .HasForeignKey(m => m.SellerId);

            modelBuilder.Entity<Trucks>()
                   .HasMany(u => u.Pics)
                   .WithRequired()
                   .HasForeignKey(m => new { m.PostId, m.CategoryId });




            //furniture


           


            //SecondHand

            modelBuilder.Entity<SecondHandType>()
            .HasOptional(p => p.ParentType)
            .WithMany(m => m.ChildTypes)
            .HasForeignKey(m => m.ParentTypeId)
            .WillCascadeOnDelete(false);

            // secondhand

            modelBuilder.Entity<SecondHand>()
                 .HasRequired(p => p.Category)
                 .WithMany()
                 .HasForeignKey(m => m.CategoryId);

            modelBuilder.Entity<SecondHand>()
                .HasOptional(p => p.City)
                .WithMany()
                .HasForeignKey(m => m.CityId);

            modelBuilder.Entity<SecondHand>()
                .HasRequired(p => p.Type)
                .WithMany()
                .HasForeignKey(m => m.TypeId);

            modelBuilder.Entity<SecondHand>()
                .HasRequired(p => p.SubType)
                .WithMany()
                .HasForeignKey(m => m.SubTypeId);

            modelBuilder.Entity<SecondHand>()
                .HasRequired(p => p.State)
                .WithMany()
                .HasForeignKey(m => m.StateId);

            modelBuilder.Entity<SecondHand>()
                .HasRequired(p => p.Region)
                .WithMany()
                .HasForeignKey(m => m.RegionId);

            modelBuilder.Entity<SecondHand>()
                .HasRequired(p => p.Seller)
                .WithMany()
                .HasForeignKey(m => m.SellerId);





            //modelBuilder.Entity<SecondHand>()
            //   .HasRequired(p => p.Category)
            //   .WithMany()
            //   .HasForeignKey(m => m.CategoryId);

            //modelBuilder.Entity<SecondHand>()
            //    .HasOptional(p => p.City)
            //    .WithMany()
            //    .HasForeignKey(m => m.CityId);

            //modelBuilder.Entity<SecondHand>()
            //    .HasRequired(p => p.Region)
            //    .WithMany()
            //    .HasForeignKey(m => m.RegionId);

            //modelBuilder.Entity<SecondHand>()
            //    .HasRequired(p => p.Seller)
            //    .WithMany()
            //    .HasForeignKey(m => m.SellerId);
            //modelBuilder.Entity<SecondHand>()
            //    .HasRequired(p => p.)
            //    .WithMany()
            //    .HasForeignKey(m => m.SubParentId);

            //modelBuilder.Entity<SecondHand>()
            //.HasRequired(p => p.Seller)
            //.WithMany()
            //.HasForeignKey(m => m.SubCategory);




            //modelBuilder.Entity<Furniture>()
            //    .HasMany<PicOfPost>(m => m.Pics)
            //    .WithMany()
            //    .Map(m => m.MapLeftKey("PostId", "CategoryId"))
            //    .Map(m => m.MapRightKey("Id", "CategoryId"));

            //modelBuilder.Entity<Attendance>()
            //            .HasKey(a => new { a.StudentId, a.Datetime });

            //modelBuilder.Entity<Attendance>()
            //    .Ignore(a => a.Id);

            //modelBuilder.Entity<Student>()
            //            .HasKey(s => s.Id);

            //modelBuilder.Entity<Course>()
            //        .Property(t => t.Id)
            //        .HasColumnName("CourseId");

            //modelBuilder.Entity<Course>()
            //            .HasKey(s => s.Id);

            //modelBuilder.Entity<Attendance>()
            //    .HasRequired(c => c.Student)
            //    .WithMany(d => d.Attendances)
            //    .HasForeignKey(s => s.StudentId);

            
            base.OnModelCreating(modelBuilder);
        }

    }
}
