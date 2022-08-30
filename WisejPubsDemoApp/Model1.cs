using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WisejWebApplication
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=PubsEFModel")
        {
        }

        public virtual DbSet<authors> authors { get; set; }
        public virtual DbSet<employee> employee { get; set; }
        public virtual DbSet<jobs> jobs { get; set; }
        public virtual DbSet<pub_info> pub_info { get; set; }
        public virtual DbSet<publishers> publishers { get; set; }
        public virtual DbSet<sales> sales { get; set; }
        public virtual DbSet<stores> stores { get; set; }
        public virtual DbSet<titleauthor> titleauthor { get; set; }
        public virtual DbSet<titles> titles { get; set; }
        public virtual DbSet<discounts> discounts { get; set; }
        public virtual DbSet<roysched> roysched { get; set; }
        public virtual DbSet<titleview> titleview { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<authors>()
                .Property(e => e.au_id)
                .IsUnicode(false);

            modelBuilder.Entity<authors>()
                .Property(e => e.au_lname)
                .IsUnicode(false);

            modelBuilder.Entity<authors>()
                .Property(e => e.au_fname)
                .IsUnicode(false);

            modelBuilder.Entity<authors>()
                .Property(e => e.phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<authors>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<authors>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<authors>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<authors>()
                .Property(e => e.zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<authors>()
                .HasMany(e => e.titleauthor)
                .WithRequired(e => e.authors)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.emp_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.fname)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.minit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.lname)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.pub_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<jobs>()
                .Property(e => e.job_desc)
                .IsUnicode(false);

            modelBuilder.Entity<jobs>()
                .HasMany(e => e.employee)
                .WithRequired(e => e.jobs)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<pub_info>()
                .Property(e => e.pub_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pub_info>()
                .Property(e => e.pr_info)
                .IsUnicode(false);

            modelBuilder.Entity<publishers>()
                .Property(e => e.pub_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<publishers>()
                .Property(e => e.pub_name)
                .IsUnicode(false);

            modelBuilder.Entity<publishers>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<publishers>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<publishers>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<publishers>()
                .HasMany(e => e.employee)
                .WithRequired(e => e.publishers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<publishers>()
                .HasOptional(e => e.pub_info)
                .WithRequired(e => e.publishers);

            modelBuilder.Entity<sales>()
                .Property(e => e.stor_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<sales>()
                .Property(e => e.ord_num)
                .IsUnicode(false);

            modelBuilder.Entity<sales>()
                .Property(e => e.payterms)
                .IsUnicode(false);

            modelBuilder.Entity<sales>()
                .Property(e => e.title_id)
                .IsUnicode(false);

            modelBuilder.Entity<stores>()
                .Property(e => e.stor_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stores>()
                .Property(e => e.stor_name)
                .IsUnicode(false);

            modelBuilder.Entity<stores>()
                .Property(e => e.stor_address)
                .IsUnicode(false);

            modelBuilder.Entity<stores>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<stores>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stores>()
                .Property(e => e.zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stores>()
                .HasMany(e => e.sales)
                .WithRequired(e => e.stores)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<titleauthor>()
                .Property(e => e.au_id)
                .IsUnicode(false);

            modelBuilder.Entity<titleauthor>()
                .Property(e => e.title_id)
                .IsUnicode(false);

            modelBuilder.Entity<titles>()
                .Property(e => e.title_id)
                .IsUnicode(false);

            modelBuilder.Entity<titles>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<titles>()
                .Property(e => e.type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<titles>()
                .Property(e => e.pub_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<titles>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<titles>()
                .Property(e => e.advance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<titles>()
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<titles>()
                .HasMany(e => e.sales)
                .WithRequired(e => e.titles)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<titles>()
                .HasMany(e => e.titleauthor)
                .WithRequired(e => e.titles)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<titles>()
                .HasOptional(e => e.roysched)
                .WithRequired(e => e.titles);

            modelBuilder.Entity<discounts>()
                .Property(e => e.discounttype)
                .IsUnicode(false);

            modelBuilder.Entity<discounts>()
                .Property(e => e.stor_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<discounts>()
                .Property(e => e.discount)
                .HasPrecision(4, 2);

            modelBuilder.Entity<roysched>()
                .Property(e => e.title_id)
                .IsUnicode(false);

            modelBuilder.Entity<titleview>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<titleview>()
                .Property(e => e.au_lname)
                .IsUnicode(false);

            modelBuilder.Entity<titleview>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<titleview>()
                .Property(e => e.pub_id)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
