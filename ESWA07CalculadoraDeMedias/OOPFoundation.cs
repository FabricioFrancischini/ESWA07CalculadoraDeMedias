namespace OOPFoundation
{
    // Interface de validação de double
    public interface IDoubleValidation
    {
        bool DoubleIsValid(double doubleToValidate, float limit);
    }

    // Classe abstrata que implementa IDoubleValidation
    public abstract class ADoubleValidation : IDoubleValidation
    {
        protected double LowerLimit;
        protected double UpperLimit;

        public ADoubleValidation(double lowerLimit, double upperLimit)
        {
            LowerLimit = lowerLimit;
            UpperLimit = upperLimit;
        }

        public bool DoubleIsValid(double doubleToValidate, float limit)
        {
            return doubleToValidate >= LowerLimit && doubleToValidate <= UpperLimit;
        }
    }

    // Subclasse concreta para validar notas de 0 a 10
    public class NoteValidation : ADoubleValidation
    {
        public NoteValidation() : base(0, 10) { }
    }

    // Interface de sanitização
    public interface ISanitization
    {
        string Sanitize(string textToSanitize);
    }

    // Interface de validação de texto
    public interface ITextValidation
    {
        bool TextIsValid(string textToValidate);
    }

    // Padrões de sanitização
    public static class SanitizationPattern
    {
        public const string CNPJ = "a-zA-Z0-9";
        public const string CPF = "0-9";
        public const string ISBN = "0-9";
        public const string ISSN = "0-9Xx";
        public const string PHONE = "0-9";
        public const string PIV = "0-9A-Z";
        public const string RG = "0-9Xx";
    }

    // Classe abstrata AText
    public abstract class AText : ISanitization, ITextValidation
    {
        protected string Text;
        protected string ValidPattern;

        public AText()
        {
            Text = string.Empty;
            ValidPattern = string.Empty;
        }

        public string GetText() => Text;

        public string ObtainHashedText() => Hash();

        private string Hash()
        {
            using var sha = System.Security.Cryptography.SHA256.Create();
            var bytes = System.Text.Encoding.UTF8.GetBytes(Text);
            var hash = sha.ComputeHash(bytes);
            return Convert.ToHexString(hash);
        }

        private string Encode()
        {
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(Text));
        }

        public string Sanitize(string textToSanitize)
        {
            return System.Text.RegularExpressions.Regex.Replace(
                textToSanitize, $"[^{ValidPattern}]", "");
        }

        public bool TextIsValid(string textToValidate)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(
                textToValidate, $"^[{ValidPattern}]+$");
        }
    }

    // Subclasse concreta Text
    public class Text : AText
    {
        public Text() : base() { }
    }
}