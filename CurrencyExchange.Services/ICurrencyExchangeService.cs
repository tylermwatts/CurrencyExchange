using System.Threading.Tasks;

namespace CurrencyExchange.Services
{
    public interface ICurrencyExchangeService
    {
        Task<ExchangeData> GetExchangeDataAsync(double initialAmount, CurrencyType initialType, CurrencyType returnType);
    }
}