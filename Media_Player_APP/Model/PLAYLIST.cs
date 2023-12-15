namespace Media_Player_APP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PLAYLIST")]
    public partial class PLAYLIST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PLAYLIST()
        {
            MUSIC_PLAYLIST = new HashSet<MUSIC_PLAYLIST>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MUSIC_PLAYLIST> MUSIC_PLAYLIST { get; set; }
    }
}
