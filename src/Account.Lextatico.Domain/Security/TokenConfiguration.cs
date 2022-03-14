namespace Account.Lextatico.Domain.Security
{
    public class TokenConfiguration
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int Seconds { get; set; }
        public int SecondsRefresh { get; set; }
    }
}
