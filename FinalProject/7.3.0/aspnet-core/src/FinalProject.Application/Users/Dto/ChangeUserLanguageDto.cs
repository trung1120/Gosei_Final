using System.ComponentModel.DataAnnotations;

namespace FinalProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}