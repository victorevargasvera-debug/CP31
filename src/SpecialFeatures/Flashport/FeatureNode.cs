namespace SpecialFeatures.Flashport
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    public abstract class FeatureNode
    {
        private Recordset a;
        private int b;
        [CompilerGenerated]
        private bool c;
        private Dictionary<int, FeatureSection> d;
        internal static int NodeIdCounter;
        private string e;
        [CompilerGenerated]
        private string f;
        [CompilerGenerated]
        private string g;

        private FeatureNode();
        protected FeatureNode(Recordset parent);
        internal void AddFeatureSection(FeatureSection section);
        internal void Initialize();
        [IteratorStateMachine(typeof(FeatureNode.<Search>d__30))]
        internal IEnumerable<Field> Search(string token);

        public bool HasEmbeddedRecset { get; private set; }

        internal Recordset Parent { get; set; }

        public string FeatureName { get; set; }

        internal int NodeId { get; }

        public string UIPagePath { get; protected set; }

        internal FeatureSection this[int id] { get; }

        internal IEnumerable<FeatureSection> FeatureSectionsCollection { [IteratorStateMachine(typeof(FeatureNode.<get_FeatureSectionsCollection>d__29))] get; }

        internal string UIName { get; set; }

        internal IEnumerable<Field> AllFields { [IteratorStateMachine(typeof(FeatureNode.<get_AllFields>d__35))] get; }

        [CompilerGenerated]
        private sealed class <get_AllFields>d__35 : IEnumerable<Field>, IEnumerable, IEnumerator<Field>, IDisposable, IEnumerator
        {
            private int a;
            private Field b;
            private int c;
            public FeatureNode <>4__this;
            private IEnumerator<FeatureSection> d;
            private IEnumerator<Field> e;

            [DebuggerHidden]
            public <get_AllFields>d__35(int <>1__state);
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

        [CompilerGenerated]
        private sealed class <get_FeatureSectionsCollection>d__29 : IEnumerable<FeatureSection>, IEnumerable, IEnumerator<FeatureSection>, IDisposable, IEnumerator
        {
            private int a;
            private FeatureSection b;
            private int c;
            public FeatureNode <>4__this;
            private Dictionary<int, FeatureSection>.ValueCollection.Enumerator d;

            [DebuggerHidden]
            public <get_FeatureSectionsCollection>d__29(int <>1__state);
            private void a();
            private bool MoveNext();
            [DebuggerHidden]
            IEnumerator<FeatureSection> IEnumerable<FeatureSection>.GetEnumerator();
            [DebuggerHidden]
            IEnumerator IEnumerable.GetEnumerator();
            [DebuggerHidden]
            void IEnumerator.Reset();
            [DebuggerHidden]
            void IDisposable.Dispose();

            FeatureSection IEnumerator<FeatureSection>.Current { [DebuggerHidden] get; }

            object IEnumerator.Current { [DebuggerHidden] get; }
        }

        [CompilerGenerated]
        private sealed class <Search>d__30 : IEnumerable<Field>, IEnumerable, IEnumerator<Field>, IDisposable, IEnumerator
        {
            private int a;
            private Field b;
            private int c;
            public FeatureNode <>4__this;
            private string d;
            public string <>3__token;
            private IEnumerator<FeatureSection> e;
            private IEnumerator<Field> f;

            [DebuggerHidden]
            public <Search>d__30(int <>1__state);
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

