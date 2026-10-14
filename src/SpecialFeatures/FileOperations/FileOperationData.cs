namespace SpecialFeatures.FileOperations
{
    using System;
    using System.Runtime.CompilerServices;

    public class FileOperationData
    {
        [CompilerGenerated]
        private string a;
        [CompilerGenerated]
        private string b;
        [CompilerGenerated]
        private object c;
        [CompilerGenerated]
        private bool d;
        [CompilerGenerated]
        private bool e;
        [CompilerGenerated]
        private string f;
        [CompilerGenerated]
        private string g;
        [CompilerGenerated]
        private string h;
        [CompilerGenerated]
        private string i;
        [CompilerGenerated]
        private string j;
        [CompilerGenerated]
        private string k;
        [CompilerGenerated]
        private string l;

        public FileOperationData();

        public string FilePath { get; set; }

        public string InitialDirectory { get; set; }

        internal object CurrentPage { get; set; }

        internal bool OkToCancel { get; set; }

        public bool Refresh { get; set; }

        public string BrowseDialogTitleContent { get; set; }

        public string HeadingTitleContent { get; set; }

        public string Filter { get; set; }

        public string BrowseDialogActionButtonContent { get; set; }

        public string BrowseDialogHelpTopicId { get; set; }

        public string ProgressDialogTitleContent { get; set; }

        public string ProgressDialogHelpTopicId { get; set; }
    }
}

