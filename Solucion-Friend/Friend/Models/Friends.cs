namespace Lab2.Models
{
    using System.ComponentModel.DataAnnotations;
    public enum TypeList
    {
        Michehl,
        Maria,
        Marcos,
        Mason,
        Moises
    }
    public class Friend
    {
        [Key]
        public int FriendId { get; set; }
        [Required]
        [Display(Name = "Nombre Completo")]
        [StringLength(50, MinimumLength = 5)]
        public string Name { get; set; }
        public TypeList List { get; set; }
        [Required]
        public string Email { get; set; }
        [Display]
        [dataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public int Birthdate { get; set; }

    }
}