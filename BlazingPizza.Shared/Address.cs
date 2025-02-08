namespace BlazingPizza
{
    public class Address
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "La dirección es obligatoria")]
        [MaxLength(100, ErrorMessage = "La dirección no puede exceder los 100 caracteres")]
        public string Line1 { get; set; } = string.Empty;

        [MaxLength(100, ErrorMessage = "La segunda línea de dirección no puede exceder los 100 caracteres")]
        public string Line2 { get; set; } = string.Empty;

        [Required(ErrorMessage = "La ciudad es obligatoria")]
        [MaxLength(50, ErrorMessage = "La ciudad no puede exceder los 50 caracteres")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "La región es obligatoria")]
        [MaxLength(20, ErrorMessage = "La región no puede exceder los 20 caracteres")]
        public string Region { get; set; } = string.Empty;

        [Required(ErrorMessage = "El código postal es obligatorio")]
        [MaxLength(5, ErrorMessage = "El código postal debe contener 5 dígitos")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "El código postal debe contener exactamente 5 dígitos.")]
        public string PostalCode { get; set; } = string.Empty;
    }
}
