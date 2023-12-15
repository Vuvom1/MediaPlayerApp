namespace Media_Player_APP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MUSIC")]
    public partial class MUSIC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MUSIC()
        {
            MUSIC_PLAYLIST = new HashSet<MUSIC_PLAYLIST>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(255)]
        public string FILEPATH { get; set; }

        [StringLength(255)]
        public string IMAGE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MUSIC_PLAYLIST> MUSIC_PLAYLIST { get; set; }
    }
}
