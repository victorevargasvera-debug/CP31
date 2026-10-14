namespace SpecialFeatures.Flashport
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    public abstract class Recordset : ObservableCollection<FeatureNode>
    {
        [CompilerGenerated]
        private int a;
        [CompilerGenerated]
        private string b;
        [CompilerGenerated]
        private bool c;
        [CompilerGenerated]
        private string d;
        [CompilerGenerated]
        private bool e;
        [CompilerGenerated]
        private bool f;
        [CompilerGenerated]
        private FeatureSection g;
        [CompilerGenerated]
        private string h;
        private int i;
        private int j;

        protected Recordset();
        protected Recordset(string name);
        private void a(FeatureNode A_0);
        public FeatureNode AddDefaultRecord();
        public int AddMultipleDefaultRecords(int count);
        public void AddRecord(FeatureNode record);
        private void b(FeatureNode A_0);
        public void Clear();
        public abstract FeatureNode CreateDefaultRecord();
        public int IndexOf(FeatureNode record);
        public void Initialize();
        internal void InsertRecord(int index, FeatureNode record);
        internal FeatureNode InternalAddRecord();
        public FeatureNode NodeFromId(int nodeId);
        internal void RemoveRecord(FeatureNode record);
        public void RemoveRecordAt(int index);
        [IteratorStateMachine(typeof(Recordset.<Search>d__50))]
        public IEnumerable<Field> Search(string token);

        protected int Id { get; set; }

        public string RecordsetName { get; private set; }

        public int RecsetId { get; }

        public int Count { get; }

        public FeatureNode this[int index] { get; }

        public bool SingleInstance { get; protected set; }

        public string UIPagePath { get; protected set; }

        public bool HasEmbeddedRecset { get; private set; }

        public bool IsEmbeddedRecset { get; internal set; }

        public FeatureSection ParentSection { get; set; }

        public string UIName { get; set; }

        public virtual int Min { get; set; }

        public virtual int Max { get; set; }

        [CompilerGenerated]
        private sealed class <Search>d__50 : IEnumerable<Field>, IEnumerable, IEnumerator<Field>, IDisposable, IEnumerator
        {
            private int a;
            private Field b;
            private int c;
            public Recordset <>4__this;
            private string d;
            public string <>3__token;
            private IEnumerator<FeatureNode> e;
            private IEnumerator<Field> f;

            [DebuggerHidden]
            public <Search>d__50(int <>1__state);
            private void a();
            private void b();
            private bool MoveNext();
            [DebuggerHidden]
            IEnumerator<Field> IEnumerable<Field>.GetEnumerator();
            [DebuggerHidden]
            IEnumerator IEnumerable.GetEnumerator();
            [DebuggerHidden]
            void IEnumerator.Reset();
            [DebuggerHidden]
            void IDisposable.Dispose();

            Field IEnumerator<Field>.Current { [DebuggerHidden] get; }

            object IEnumerator.Current { [DebuggerHidden] get; }
        }
    }
}

