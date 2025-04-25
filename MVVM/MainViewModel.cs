using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MVVM
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        string firstName;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        string lastName;

        public string FullName => $"{firstName} {lastName}";

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool isBusy;

        public bool IsNotBusy => !IsBusy;

        [RelayCommand]
        void Tap()
        { 
            IsBusy = false;
            Console.WriteLine(FullName);
            IsBusy = true;
        }

    }
}
