using AccelaTest.Config;
using AccelaTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccelaTest.Data.Context
{
    public class AccelaDBContext : DbContext
    {
        #region Creating Context for the Code First
        //Creating Context for the Code First
        DbContextOptions<AccelaDBContext> _connInfo = null;
        public AccelaDBContext(DbContextOptions<AccelaDBContext> connInfo) : base(connInfo)
        {
            _connInfo = connInfo;
        }
        public AccelaDBContext(string connInfo)
        {
            _connInfo = GetConnection(connInfo).Options;
        }

        public DbContextOptionsBuilder<AccelaDBContext> GetConnection(string conn)
        {
            DbContextOptionsBuilder<AccelaDBContext> connBuilder = new DbContextOptionsBuilder<AccelaDBContext>();
            connBuilder.UseSqlServer(conn);
            return connBuilder;
        }

        #endregion

        #region Singleton

        //Singleton
        private static AccelaDBContext _instance = null;
        public static AccelaDBContext GetInstance
        {
            get {
                if (_instance==null)
                {
                    return new AccelaDBContext(ConnConfig.GetConnection());
                }
                return _instance;
            }
        }

        #endregion


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(ConnConfig.GetConnection());
        }

        #region DBSets

        public DbSet<Person> Person { get; set; }
        public DbSet<Address> Address { get; set; }

        #endregion




        #region Relationship

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Table Person
            builder.Entity<Person>().ToTable("Person");
            builder.Entity<Person>()
                .HasMany(x => x.Address)
                .WithOne(x => x.Person)
                .IsRequired(false);

            //Table Address
            builder.Entity<Address>().ToTable("Address");
            builder.Entity<Address>()
                .HasOne(x => x.Person)
                .WithMany(x => x.Address)
                .HasForeignKey("IdPerson")
                .IsRequired(true);
        }


        #endregion


    }
}
