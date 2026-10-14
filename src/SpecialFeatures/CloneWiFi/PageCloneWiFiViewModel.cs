namespace SpecialFeatures.CloneWiFi
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows.Input;

    public class PageCloneWiFiViewModel : INotifyPropertyChanged
    {
        private readonly List<KeyValuePair<string, string>> a;
        private readonly PageCloneWiFiView b;
        [CompilerGenerated]
        private ObservableCollection<WiFiRecord> c;
        [CompilerGenerated]
        private PropertyChangedEventHandler d;
        [CompilerGenerated]
        private ICommand e;
        [CompilerGenerated]
        private ICommand f;
        [CompilerGenerated]
        private ICommand g;

        public event PropertyChangedEventHandler PropertyChanged;

        public PageCloneWiFiViewModel(PageCloneWiFiView view);
        private void a();
        private void a(object A_0);
        private void b();
        private void b(object A_0);
        private void c(object A_0);
        public void OnPropertyChanged(PropertyChangedEventArgs e);

        public ObservableCollection<WiFiRecord> ItemSource { get; set; }

        public ICommand OKCommand { get; set; }

        public ICommand CancelCommand { get; set; }

        public ICommand HelpCommand { get; set; }
    }
}

