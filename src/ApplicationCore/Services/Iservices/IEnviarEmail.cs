namespace ApplicationCore.Services.IServices
{
    public interface IEnviarEmail
    {
        void enviar(string titulo, string corpo, string para, string copia);
    }
}
