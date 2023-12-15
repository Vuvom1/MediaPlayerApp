using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Media_Player_APP.Model
{
    public partial class MediaPlayer : DbContext
    {
        public MediaPlayer()
            : base("name=MediaPlayer")
        {
        }

        public virtual DbSet<MUSIC> MUSICs { get; set; }
        public virtual DbSet<MUSIC_PLAYLIST> MUSIC_PLAYLIST { get; set; }
        public virtual DbSet<PLAYLIST> PLAYLISTs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MUSIC>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MUSIC>()
                .Property(e => e.FILEPATH)
                .IsUnicode(false);

            modelBuilder.Entity<MUSIC>()
                .HasMany(e => e.MUSIC_PLAYLIST)
                .WithOptional(e => e.MUSIC)
                .HasForeignKey(e => e.MUSIC_ID);

            modelBuilder.Entity<PLAYLIST>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PLAYLIST>()
                .HasMany(e => e.MUSIC_PLAYLIST)
                .WithOptional(e => e.PLAYLIST)
                .HasForeignKey(e => e.PLAYLIST_ID);
        }
    }
}
