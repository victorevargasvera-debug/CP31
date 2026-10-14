namespace SpecialFeatures.CxfFilePassword.ViewModel
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;
    using System.Windows;
    using System.Windows.Input;

    public class CxfFileInitializePasswordPromptViewModel : INotifyPropertyChanged
    {
        private bool a;
        private string b;
        private bool c;
        private Visibility d;
        [CompilerGenerated]
        private SecureString e;
        [CompilerGenerated]
        private SecureString f;
        [CompilerGenerated]
        private bool g;
        [CompilerGenerated]
        private ICommand h;
        [CompilerGenerated]
        private ICommand i;
        [CompilerGenerated]
        private ICommand j;
        [CompilerGenerated]
        private PropertyChangedEventHandler k;
        [CompilerGenerated]
        private EventHandler l;

        internal event EventHandler OnClose;

        public event PropertyChangedEventHandler PropertyChanged;

        public CxfFileInitializePasswordPromptViewModel();
        private void a();
        private void a(object A_0);
        private void a([CallerMemberName] string A_0);
        private void b(object A_0);
        private void c(object A_0);

        public bool ShouldFocusPasswordField { get; set; }

        public string CxfFileName { get; set; }

        public bool RemeberCxfFilePassword { get; set; }

        public Visibility DataLostInfoVisibility { get; set; }

        public SecureString ProvidedPassword { get; set; }

        public SecureString ConfirmProvidedPassword { get; set; }

        public bool IsCancelled { get; private set; }

        public ICommand HelpCommand { get; set; }

        public ICommand CancelCommand { get; set; }

        public ICommand OkCommand { get; set; }
    }
}

