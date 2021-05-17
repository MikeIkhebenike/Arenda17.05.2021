namespace Arenda18
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Павильоны
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Павильона { get; set; }

        [Required]
        [StringLength(50)]
        public string Название_ТЦ { get; set; }

        [Required]
        [StringLength(50)]
        public string Номер_павильона { get; set; }

        public int Этаж { get; set; }

        [Required]
        [StringLength(50)]
        public string Статус { get; set; }

        [Column("Площадь м.кв.")]
        public double Площадь_м_кв_ { get; set; }

        [Column("Стоимость за кв.м", TypeName = "money")]
        public decimal Стоимость_за_кв_м { get; set; }

        [Column("Коэфф. Добав.ст.")]
        public double Коэфф__Добав_ст_ { get; set; }
    }
}
