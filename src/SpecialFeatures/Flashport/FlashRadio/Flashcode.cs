namespace SpecialFeatures.Flashport.FlashRadio
{
    using AcpCommonLib;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    public class Flashcode : ICollection<Option>, IEnumerable<Option>, IEnumerable
    {
        private IList<Option> a;
        private bool b;

        public Flashcode();
        internal Flashcode(bool ordered);
        public void Add(Option item);
        public void Clear();
        public bool Contains(Option item);
        public void CopyTo(Option[] array, int arrayIndex);
        [IteratorStateMachine(typeof(Flashcode.<GetEnumerator>d__22))]
        public IEnumerator<Option> GetEnumerator();
        public int GetOptionBitPosition(string optName);
        public Option GetOptionByField(IAcpField field);
        public Option GetOptionByName(string name);
        public Option GetOptionByPosition(int position);
        public int GetOptionBytePosition(string optName);
        public int GetOptionMask(string optName);
        public IList<Option> GetOptionsByField(IAcpField field);
        public IList<Option> GetOptionsByOffset(int bytePos, int bitPos);
        public IList<Option> GetOptionsByPosition(int position);
        public bool Remove(Option item);
        IEnumerator IEnumerable.GetEnumerator();

        public int Count { get; }

        public bool IsReadOnly { get; }

        [CompilerGenerated]
        private sealed class <GetEnumerator>d__22 : IEnumerator<Option>, IDisposable, IEnumerator
        {
            private int a;
            private Option b;
            public Flashcode <>4__this;
            private IEnumerator<Option> c;

            [DebuggerHidden]
            public <GetEnumerator>d__22(int <>1__state);
            private void a();
            private bool MoveNext();
            [DebuggerHidden]
            void IEnumerator.Reset();
            [DebuggerHidden]
            void IDisposable.Dispose();

            Option IEnumerator<Option>.Current { [DebuggerHidden] get; }

            object IEnumerator.Current { [DebuggerHidden] get; }
        }
    }
}

