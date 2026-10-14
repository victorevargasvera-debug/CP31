namespace SpecialFeatures.Flashport.FlashRadio.ApxNext
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class ProgressUpdater
    {
        private BackgroundWorker a;
        [CompilerGenerated]
        private int b;
        [CompilerGenerated]
        private int c;

        public ProgressUpdater(BackgroundWorker backgroundWorker);
        public void UpdateRadioProgress(object sender, ProgressChangedEventArgs e);
        public void UpdateWorker(ProgressStage progressStage, object objectToShow);

        public int MaxSteps { get; set; }

        public int CurrentStep { get; set; }
    }
}

