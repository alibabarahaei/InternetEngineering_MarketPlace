namespace MarketPlace.Application.InterfaceServices
{
    public interface ISmsService
    {
        Task SendVerificationSms(string mobile, string activationCode);
        Task SendUserPasswordSms(string mobile, string password);
    }
}