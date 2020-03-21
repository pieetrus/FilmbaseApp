namespace JakubPietrusLab4Zadanie.Models
{
    using System.Data.Entity;

    public partial class FilmBaseContext : DbContext
    {
        public FilmBaseContext()
            : base("name=FilmBaseContext")
        {
        }

        public virtual DbSet<Director> Directors { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Director>()
                .Property(d => d.Name)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(60);

            modelBuilder.Entity<Genre>()
                .Property(g => g.Name)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(30);

            modelBuilder.Entity<Review>()
                .Property(r => r.Contest)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(200);

            modelBuilder.Entity<UserLogin>()
                .Property(u => u.UserName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(30);

            modelBuilder.Entity<UserLogin>()
                .Property(u => u.Password)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(30);

            modelBuilder.Entity<Movie>()
                .Property(m => m.Title)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(30);

            modelBuilder.Entity<Movie>()
                .Property(m => m.YearOfRelease)
                .IsRequired();




            //Relacja tabeli movies director
            modelBuilder.Entity<Movie>()
                .HasRequired(m => m.Director)
                .WithMany(d => d.Movies)
                .HasForeignKey(m => m.DirectorId);
           //Relacja tabeli movie genre
            modelBuilder.Entity<Movie>()
                .HasRequired(m => m.Genre)
                .WithMany(g => g.Movies)
                .HasForeignKey(m => m.GenreId);
            //Relacja tabeli movie review
            modelBuilder.Entity<Movie>()
                .HasMany(m => m.Reviews)
                .WithRequired(r => r.Movie)
                .HasForeignKey(r => r.MovieId);
            //Relacja tabeli review userlogin
            modelBuilder.Entity<UserLogin>()
                .HasMany(u => u.Reviews)
                .WithRequired(r => r.UserLogin)
                .HasForeignKey(r => r.UserLoginId);


        }
    }
}
