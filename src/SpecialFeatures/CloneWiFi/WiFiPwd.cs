namespace SpecialFeatures.CloneWiFi
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class WiFiPwd : INotifyPropertyChanged
    {
        private string a;
        private bool b;
        [CompilerGenerated]
        private PropertyChangedEventHandler c;

        public event PropertyChangedEventHandler PropertyChanged;

        public WiFiPwd();
        public void OnPropertyChanged(PropertyChangedEventArgs e);

        public bool IsValid { get; set; }

        public string Content { get; set; }
    }
}

