namespace SpecialFeatures.VoiceAnnouncements.List
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class VAFileItem : INotifyPropertyChanged
    {
        [CompilerGenerated]
        private PropertyChangedEventHandler a;
        private string b;
        private Guid c;
        private TheDownloadStatuses d;
        [CompilerGenerated]
        private string e;

        public event PropertyChangedEventHandler PropertyChanged;

        public VAFileItem(string fileName, Guid uuid);
        protected void OnPropertyChanged(string name);

        public string FileName { get; set; }

        public Guid SoftwareUuid { get; set; }

        public TheDownloadStatuses DownloadStatus { get; set; }

        internal string FullPathAndName { get; set; }
    }
}

