using System.ComponentModel.DataAnnotations;

namespace Abp.React.Users.Dto;

public class ChangeUserLanguageDto
{
    [Required]
    public string LanguageName { get; set; }
}