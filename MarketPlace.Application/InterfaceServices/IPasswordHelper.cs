namespace MarketPlace.Application.InterfaceServices
{
    public interface IPasswordHelper
    {
        string EncodePasswordMd5(string pass);
    }
}