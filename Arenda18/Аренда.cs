namespace Arenda18
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Аренда
    {
        [Key]
        public int ID_Аренды { get; set; }

        public int ID_Арендатора { get; set; }

        [Required]
        [StringLength(50)]
        public string НазваниеТЦ { get; set; }

        public int ID_Сотрудника { get; set; }

        [Required]
        [StringLength(50)]
        public string Номер_Павильона { get; set; }

        [Required]
        [StringLength(50)]
        public string Статус { get; set; }

        [Column(TypeName = "date")]
        public DateTime Начало_аренды { get; set; }

        [Column(TypeName = "date")]
        public DateTime Окончание_аренды { get; set; }

        public virtual Арендаторы Арендаторы { get; set; }

        public virtual Сотрудники Сотрудники { get; set; }
    }
}
