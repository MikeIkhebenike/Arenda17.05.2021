namespace Arenda18
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Сотрудники
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Сотрудники()
        {
            Аренда = new HashSet<Аренда>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Сотрудника { get; set; }

        [Required]
        [StringLength(50)]
        public string ФИО { get; set; }

        [Required]
        [StringLength(50)]
        public string Логин { get; set; }

        [Required]
        [StringLength(50)]
        public string Пароль { get; set; }

        [Required]
        [StringLength(50)]
        public string Роль { get; set; }

        [Required]
        [StringLength(50)]
        public string Номер { get; set; }

        [Required]
        [StringLength(2)]
        public string Пол { get; set; }

        [Column(TypeName = "image")]
        public byte[] Фото { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Аренда> Аренда { get; set; }
    }
}
