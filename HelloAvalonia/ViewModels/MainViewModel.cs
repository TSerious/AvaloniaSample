using ReactiveUI;

namespace HelloAvalonia.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string greeting = "Welcome to Avalonia!";
        private int clickCounter = 0;

        public MainViewModel()
        {

        }

        public string Greeting
        {
            get => this.greeting;
            set => this.RaiseAndSetIfChanged(ref this.greeting, value);
        }

        public void GreetWithClickCounter()
        {
            this.Greeting = $"Hello, you clicked the buttin {++clickCounter} times.";
        }
    }
}
