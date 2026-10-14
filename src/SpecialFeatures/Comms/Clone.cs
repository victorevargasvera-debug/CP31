namespace SpecialFeatures.Comms
{
    using SpecialFeatures.ReadWritePassword;
    using System;
    using System.Runtime.InteropServices;
    using System.Windows;

    internal class Clone : SpecialFeatures.Comms.Comms
    {
        private static bool a;
        private static bool b;
        private bool c;
        private bool d;
        private bool e;
        private string f;
        private readonly ReadWritePasswordApp g;
        private Window h;

        public Clone();
        internal bool CloneRadio(bool ReadRadioIds, COMMS_OP WriteType, bool inbatchMode);
        internal bool CloneRadio(bool ReadRadioIds, COMMS_OP WriteType, object lastCommsUserState, Window win, bool inbatchMode);
        internal void FileCloneForceClose();
        internal RadioIdInfo ReadRadioIds(COMMS_OP WriteType, int Headless, string HeadlessAddr, bool WriteProtecWriteProtectedRadio, bool otapBatchProgramming);
    }
}

