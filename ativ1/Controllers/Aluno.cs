using System.ComponentModel.DataAnnotations;

public class Aluno
{
    [Required(ErrorMessage = "O nome é obrigatório.")]
    [MinLength(3, ErrorMessage = "O nome deve ter pelo menos 3 caracteres.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O RA é obrigatório.")]
    [CustomRaValidation] 
    public string Ra { get; set; }

    [Required(ErrorMessage = "O e-mail é obrigatório.")]
    [EmailAddress(ErrorMessage = "O e-mail deve ser válido.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "O CPF é obrigatório.")]
    [RegularExpression(@"\d{11}", ErrorMessage = "O CPF deve conter 11 dígitos.")]
    public string Cpf { get; set; }

    [Required(ErrorMessage = "O status ativo é obrigatório.")]
    public bool Ativo { get; set; }
}
    