namespace Data.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CinemarData : DbContext
    {
        public CinemarData()
            : base("name=CinemarData")
        {
        }

        public virtual DbSet<Cinemaroom> Cinemarooms { get; set; }
        public virtual DbSet<Movy> Movies { get; set; }
        public virtual DbSet<movies_movitetype> movies_movitetype { get; set; }
        public virtual DbSet<Movietype> Movietypes { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }
        public virtual DbSet<Studio> Studios { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cinemaroom>()
                .HasMany(e => e.Seats)
                .WithOptional(e => e.Cinemaroom)
                .HasForeignKey(e => e.cinemaroom_id);

            modelBuilder.Entity<Movy>()
                .HasMany(e => e.movies_movitetype)
                .WithOptional(e => e.Movy)
                .HasForeignKey(e => e.movie_id);

            modelBuilder.Entity<Movy>()
                .HasMany(e => e.Schedules)
                .WithOptional(e => e.Movy)
                .HasForeignKey(e => e.movie_id);

            modelBuilder.Entity<Movy>()
                .HasMany(e => e.Studios)
                .WithOptional(e => e.Movy)
                .HasForeignKey(e => e.movie_id);

            modelBuilder.Entity<Movietype>()
                .HasMany(e => e.movies_movitetype)
                .WithOptional(e => e.Movietype)
                .HasForeignKey(e => e.movietype_id);

            modelBuilder.Entity<Schedule>()
                .HasMany(e => e.Cinemarooms)
                .WithOptional(e => e.Schedule)
                .HasForeignKey(e => e.schedule_id);

            modelBuilder.Entity<Seat>()
                .Property(e => e.num_of_row)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Seat>()
                .HasMany(e => e.Tickets)
                .WithOptional(e => e.Seat)
                .HasForeignKey(e => e.seat_id);

            modelBuilder.Entity<User>()
                .Property(e => e.phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Tickets)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.user_id);
        }
    }
}
