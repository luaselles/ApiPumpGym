namespace Pump.Apllication.Validators
{
    public class ValidationException : Exception
    {
        public List<ValidationErrorViewModel> Errors { get; } = new List<ValidationErrorViewModel>();

        public ValidationException(IEnumerable<ValidationErrorViewModel> failures) : base("Erro de validação")
        {
            Errors.AddRange(failures);
        }
    }

    public class ValidationErrorViewModel
    {
        public ValidationErrorViewModel() : this("", new string[] { })
        {
        }

        public ValidationErrorViewModel(string field, string[] message)
        {
            Field = field;
            Message = message;
        }

        public virtual string Field { get; set; }

        public virtual string[] Message { get; set; }
    }
}