namespace SpecialFeatures.Flashport
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    public abstract class FeatureSection
    {
        [CompilerGenerated]
        private int a;
        private Dictionary<string, Field> b;
        private Recordset c;
        private string d;
        [CompilerGenerated]
        private FeatureNode e;
        [CompilerGenerated]
        private string f;

        protected FeatureSection();
        protected FeatureSection(FeatureNode parent);
        public abstract void Init();
        [IteratorStateMachine(typeof(FeatureSection.<Search>d__32))]
        public IEnumerable<Field> Search(string token);

        protected int Id { get; set; }

        public FeatureNode Parent { get; set; }

        public Recordset ParentRecset { get; }

        public int FeatureSectionId { get; }

        public string FeatureSectionName { get; set; }

        public Field this[string name] { get; set; }

        public IEnumerable<Field> FieldsCollection { [IteratorStateMachine(typeof(FeatureSection.<get_FieldsCollection>d__26))] get; }

        public bool HasEmbeddedRecset { get; }

        public Recordset EmbeddedRecset { get; set; }

        public string UIName { get; set; }

        [CompilerGenerated]
        private sealed class <get_FieldsCollection>d__26 : IEnumerable<Field>, IEnumerable, IEnumerator<Field>, IDisposable, IEnumerator
        {
            private int a;
            private Field b;
            private int c;
            public FeatureSection <>4__this;
            private Dictionary<string, Field>.ValueCollection.Enumerator d;

            [DebuggerHidden]
            public <get_FieldsCollection>d__26(int <>1__state);
            private void a();
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

        [CompilerGenerated]
        private sealed class <Search>d__32 : IEnumerable<Field>, IEnumerable, IEnumerator<Field>, IDisposable, IEnumerator
        {
            private int a;
            private Field b;
            private int c;
            public FeatureSection <>4__this;
            private string d;
            public string <>3__token;
            private Dictionary<string, Field>.ValueCollection.Enumerator e;

            [DebuggerHidden]
            public <Search>d__32(int <>1__state);
            private void a();
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

