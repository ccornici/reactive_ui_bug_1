using ReactiveUI;
using System.Reactive;

namespace ReactiveUIBug1
{
    public class MainVM : ReactiveObject
    {
        SomeService someService = new SomeService();

        public ReactiveCommand<Unit, Unit> DeleteMedCmd { get; }

        public MainVM()
        {
            DeleteMedCmd = ReactiveCommand.Create(() =>
            {
                someService.DoStuff();
            });
        }
    }
}
