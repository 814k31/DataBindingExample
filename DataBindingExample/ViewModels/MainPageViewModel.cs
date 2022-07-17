using System.ComponentModel;
using System.Windows.Input;

namespace DataBindingExample.ViewModels;

public class MainPageViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    private int _incrementedIncrementedValue;
    public int IncrementedValue {
        get => _incrementedIncrementedValue;
        set
        {
            _incrementedIncrementedValue = value;
            OnPropertyChanged(nameof(IncrementedValue));
        }
    }

    public ICommand IncrementValueCommand { get; }

    public MainPageViewModel()
    {
        IncrementValueCommand = new Command(() =>
        {
            IncrementedValue++;
        });
    }

    private void OnPropertyChanged(string name = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
