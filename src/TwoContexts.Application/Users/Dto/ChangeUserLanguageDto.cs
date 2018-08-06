using System.ComponentModel.DataAnnotations;

namespace TwoContexts.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}