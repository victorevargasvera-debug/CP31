namespace SpecialFeatures.CloneWiFi
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class WiFiRecord : INotifyPropertyChanged
    {
        private WiFiPwd a;
        private string b;
        [CompilerGenerated]
        private string c;
        [CompilerGenerated]
        private PropertyChangedEventHandler d;

        public event PropertyChangedEventHandler PropertyChanged;

        public WiFiRecord();
        public void OnPropertyChanged(PropertyChangedEventArgs e);

        public string SSID { get; set; }

        public WiFiPwd PWD { get; set; }

        public string FeatureName { get; set; }
    }
}

