using System.Threading.Tasks;

namespace cleardrive.desktop.ViewModels.Base
{
    public interface IAsyncInitialization
    {
        public Task InitializeAsync();
    }
}
