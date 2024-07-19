namespace MyFirstApi.Communication.Requests
{
    public class RequestChangePasswordJson
    {
        public string CurrentPassword {  get; set; } = string.Empty;
        public string NewPasswordd { get; set; } = string.Empty;
        
    }
}
