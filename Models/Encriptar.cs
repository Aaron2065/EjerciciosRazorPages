namespace EjerciciosRazorPages.Models
{
    public class Encriptar
    {
        public string? Input { get; set; }
        public int Shift { get; set; }
        public string? Output { get; set; }

        private const string abecedario = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public string EncriptarMsj(string message, int shift)
        {
            return Transformar(message, shift);
        }

        public string Desencriptar(string message, int shift)
        {
            return Transformar(message, -shift);
        }

        private string Transformar(string message, int shift)
        {
            char[] buffer = message.ToUpper().ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];

                if (char.IsLetter(letter))
                {
                    int letterPosition = abecedario.IndexOf(letter);
                    int newPosition = (letterPosition + shift) % abecedario.Length;
                    if (newPosition < 0)
                    {
                        newPosition += abecedario.Length;
                    }
                    buffer[i] = abecedario[newPosition];
                }
            }

            return new string(buffer);
        }
    }
}
