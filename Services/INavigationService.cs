using PortfolioBackend.Models;

namespace PortfolioBackend.Services
{
    public interface INavigationService
    {
        List<NavigationLink> GetNavigationLinks();
    }
}

