namespace Application.Services.Cryptography
{
    public interface ICriptography  
    {
        public string Hash(string password);
    }
}
