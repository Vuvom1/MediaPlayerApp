namespace Media_Player_APP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MUSIC_PLAYLIST
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? MUSIC_ID { get; set; }

        public int? PLAYLIST_ID { get; set; }

        public virtual MUSIC MUSIC { get; set; }

        public virtual PLAYLIST PLAYLIST { get; set; }
    }
}
