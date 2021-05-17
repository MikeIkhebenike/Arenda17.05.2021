namespace Arenda18
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ТЦ
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_ТЦ { get; set; }

        [Required]
        [StringLength(50)]
        public string Название { get; set; }

        [Required]
        [StringLength(50)]
        public string Статус { get; set; }

        [Column("Кол-во павильонов")]
        [Required]
        [StringLength(50)]
        public string Кол_во_павильонов { get; set; }

        [Required]
        [StringLength(50)]
        public string Город { get; set; }

        [Column(TypeName = "money")]
        public decimal Стоимость { get; set; }

        [Column("Коэфф добав.ст.")]
        public double Коэфф_добав_ст_ { get; set; }

        public int Этажность { get; set; }

        [Column(TypeName = "image")]
        public byte[] Изображение { get; set; }
    }
}
