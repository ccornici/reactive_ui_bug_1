using ReactiveUI;
using System.Reactive.Disposables;

namespace ReactiveUIBug1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {

        public MainWindow()
        {
            ViewModel = new();
            InitializeComponent();
            this.WhenActivated(d =>
            {
                this.BindCommand(ViewModel, vm => vm.DeleteMedCmd, v => v.btnCrash).DisposeWith(d);
            });
        }
    }
}
