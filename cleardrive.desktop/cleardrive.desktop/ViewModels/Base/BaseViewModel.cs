using CommunityToolkit.Mvvm.ComponentModel;

namespace cleardrive.desktop.ViewModels.Base
{
    public class BaseViewModel : ObservableObject, IAsyncInitialization
    {
        public virtual Task InitializeAsync()
        {
            return Task.CompletedTask;
        }
    }
}
