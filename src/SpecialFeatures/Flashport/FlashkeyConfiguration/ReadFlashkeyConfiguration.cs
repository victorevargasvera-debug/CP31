namespace SpecialFeatures.Flashport.FlashkeyConfiguration
{
    using System;

    public class ReadFlashkeyConfiguration : IDisposable
    {
        private FlashkeyConfigurationRecset a;
        private bool b;

        public ReadFlashkeyConfiguration();
        public void Dispose();
        protected virtual void Dispose(bool disposing);
        public bool ReadFlashkey();

        public FlashkeyConfigurationRecset FlashkeyRecset { get; }
    }
}

