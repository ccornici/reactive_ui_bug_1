using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;

namespace ReactiveUIBug1
{
    public class MainVM
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
