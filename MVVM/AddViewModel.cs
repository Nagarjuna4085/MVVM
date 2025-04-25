using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MVVM
{
   public partial class AddViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Total))]
        private int firstNumber;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Total))]
        private int secondNumber;

       public int Total => FirstNumber + SecondNumber;

        [RelayCommand]
        void Reset()
        {
            FirstNumber = 0;
            SecondNumber = 0;
        }


    }
}
