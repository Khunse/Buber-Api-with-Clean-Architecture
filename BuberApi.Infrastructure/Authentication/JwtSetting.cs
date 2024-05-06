namespace BuberApi.Infrastructure.Authentication
{
    public class JwtSetting
    {
        public const string JwtSettingName = "JwtSetting";
        public string Issuer { get; set; } = null!;         // make no nullable even set allow nullable reference
        public string Audience { get; set; }    = null!;
        public string Secret { get; set; }  = null!;
        public int ExpireTime { get; set; }
    }
}