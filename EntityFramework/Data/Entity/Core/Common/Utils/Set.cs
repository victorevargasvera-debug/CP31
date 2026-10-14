using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Common.Utils
{
	// Token: 0x020005FD RID: 1533
	internal class Set<TElement> : global::System.Data.Entity.Core.Common.Utils.InternalBase, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable
	{
		// Token: 0x06004B13 RID: 19219 RVA: 0x0010915F File Offset: 0x0010735F
		internal Set(global::System.Data.Entity.Core.Common.Utils.Set<TElement> other) : this(other._values, other.Comparer)
		{
		}

		// Token: 0x06004B14 RID: 19220 RVA: 0x00109173 File Offset: 0x00107373
		internal Set() : this(null, null)
		{
		}

		// Token: 0x06004B15 RID: 19221 RVA: 0x0010917D File Offset: 0x0010737D
		internal Set(global::System.Collections.Generic.IEnumerable<TElement> elements) : this(elements, null)
		{
		}

		// Token: 0x06004B16 RID: 19222 RVA: 0x00109187 File Offset: 0x00107387
		internal Set(global::System.Collections.Generic.IEqualityComparer<TElement> comparer) : this(null, comparer)
		{
		}

		// Token: 0x06004B17 RID: 19223 RVA: 0x00109191 File Offset: 0x00107391
		internal Set(global::System.Collections.Generic.IEnumerable<TElement> elements, global::System.Collections.Generic.IEqualityComparer<TElement> comparer)
		{
			this._values = new global::System.Collections.Generic.HashSet<TElement>(elements ?? global::System.Linq.Enumerable.Empty<TElement>(), comparer ?? global::System.Collections.Generic.EqualityComparer<TElement>.Default);
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06004B18 RID: 19224 RVA: 0x001091B8 File Offset: 0x001073B8
		internal int Count
		{
			get
			{
				return this._values.Count;
			}
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06004B19 RID: 19225 RVA: 0x001091C5 File Offset: 0x001073C5
		internal global::System.Collections.Generic.IEqualityComparer<TElement> Comparer
		{
			get
			{
				return this._values.Comparer;
			}
		}

		// Token: 0x06004B1A RID: 19226 RVA: 0x001091D2 File Offset: 0x001073D2
		internal bool Contains(TElement element)
		{
			return this._values.Contains(element);
		}

		// Token: 0x06004B1B RID: 19227 RVA: 0x001091E0 File Offset: 0x001073E0
		internal void Add(TElement element)
		{
			this._values.Add(element);
		}

		// Token: 0x06004B1C RID: 19228 RVA: 0x001091F0 File Offset: 0x001073F0
		internal void AddRange(global::System.Collections.Generic.IEnumerable<TElement> elements)
		{
			foreach (TElement element in elements)
			{
				this.Add(element);
			}
		}

		// Token: 0x06004B1D RID: 19229 RVA: 0x00109238 File Offset: 0x00107438
		internal void Remove(TElement element)
		{
			this._values.Remove(element);
		}

		// Token: 0x06004B1E RID: 19230 RVA: 0x00109247 File Offset: 0x00107447
		internal void Clear()
		{
			this._values.Clear();
		}

		// Token: 0x06004B1F RID: 19231 RVA: 0x00109254 File Offset: 0x00107454
		internal TElement[] ToArray()
		{
			return this._values.ToArray<TElement>();
		}

		// Token: 0x06004B20 RID: 19232 RVA: 0x00109261 File Offset: 0x00107461
		internal bool SetEquals(global::System.Data.Entity.Core.Common.Utils.Set<TElement> other)
		{
			return this._values.Count == other._values.Count && this._values.IsSubsetOf(other._values);
		}

		// Token: 0x06004B21 RID: 19233 RVA: 0x0010928E File Offset: 0x0010748E
		internal bool IsSubsetOf(global::System.Data.Entity.Core.Common.Utils.Set<TElement> other)
		{
			return this._values.IsSubsetOf(other._values);
		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x001092A1 File Offset: 0x001074A1
		internal bool Overlaps(global::System.Data.Entity.Core.Common.Utils.Set<TElement> other)
		{
			return this._values.Overlaps(other._values);
		}

		// Token: 0x06004B23 RID: 19235 RVA: 0x001092B4 File Offset: 0x001074B4
		internal void Subtract(global::System.Collections.Generic.IEnumerable<TElement> other)
		{
			this._values.ExceptWith(other);
		}

		// Token: 0x06004B24 RID: 19236 RVA: 0x001092C2 File Offset: 0x001074C2
		internal global::System.Data.Entity.Core.Common.Utils.Set<TElement> Difference(global::System.Collections.Generic.IEnumerable<TElement> other)
		{
			global::System.Data.Entity.Core.Common.Utils.Set<TElement> set = new global::System.Data.Entity.Core.Common.Utils.Set<TElement>(this);
			set.Subtract(other);
			return set;
		}

		// Token: 0x06004B25 RID: 19237 RVA: 0x001092D1 File Offset: 0x001074D1
		internal void Unite(global::System.Collections.Generic.IEnumerable<TElement> other)
		{
			this._values.UnionWith(other);
		}

		// Token: 0x06004B26 RID: 19238 RVA: 0x001092DF File Offset: 0x001074DF
		internal global::System.Data.Entity.Core.Common.Utils.Set<TElement> Union(global::System.Collections.Generic.IEnumerable<TElement> other)
		{
			global::System.Data.Entity.Core.Common.Utils.Set<TElement> set = new global::System.Data.Entity.Core.Common.Utils.Set<TElement>(this);
			set.Unite(other);
			return set;
		}

		// Token: 0x06004B27 RID: 19239 RVA: 0x001092EE File Offset: 0x001074EE
		internal void Intersect(global::System.Data.Entity.Core.Common.Utils.Set<TElement> other)
		{
			this._values.IntersectWith(other._values);
		}

		// Token: 0x06004B28 RID: 19240 RVA: 0x00109301 File Offset: 0x00107501
		internal global::System.Data.Entity.Core.Common.Utils.Set<TElement> AsReadOnly()
		{
			if (this._isReadOnly)
			{
				return this;
			}
			return new global::System.Data.Entity.Core.Common.Utils.Set<TElement>(this)
			{
				_isReadOnly = true
			};
		}

		// Token: 0x06004B29 RID: 19241 RVA: 0x0010931A File Offset: 0x0010751A
		internal global::System.Data.Entity.Core.Common.Utils.Set<TElement> MakeReadOnly()
		{
			this._isReadOnly = true;
			return this;
		}

		// Token: 0x06004B2A RID: 19242 RVA: 0x00109324 File Offset: 0x00107524
		internal int GetElementsHashCode()
		{
			int num = 0;
			foreach (TElement obj in this)
			{
				num ^= this.Comparer.GetHashCode(obj);
			}
			return num;
		}

		// Token: 0x06004B2B RID: 19243 RVA: 0x00109380 File Offset: 0x00107580
		public global::System.Collections.Generic.HashSet<TElement>.Enumerator GetEnumerator()
		{
			return this._values.GetEnumerator();
		}

		// Token: 0x06004B2C RID: 19244 RVA: 0x0010938D File Offset: 0x0010758D
		[global::System.Diagnostics.Conditional("DEBUG")]
		private void AssertReadWrite()
		{
		}

		// Token: 0x06004B2D RID: 19245 RVA: 0x0010938F File Offset: 0x0010758F
		[global::System.Diagnostics.Conditional("DEBUG")]
		private void AssertSetCompatible(global::System.Data.Entity.Core.Common.Utils.Set<TElement> other)
		{
		}

		// Token: 0x06004B2E RID: 19246 RVA: 0x00109391 File Offset: 0x00107591
		global::System.Collections.Generic.IEnumerator<TElement> global::System.Collections.Generic.IEnumerable<!0>.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06004B2F RID: 19247 RVA: 0x0010939E File Offset: 0x0010759E
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06004B30 RID: 19248 RVA: 0x001093AB File Offset: 0x001075AB
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedStringSorted(builder, this);
		}

		// Token: 0x04001A4E RID: 6734
		internal static readonly global::System.Data.Entity.Core.Common.Utils.Set<TElement> Empty = new global::System.Data.Entity.Core.Common.Utils.Set<TElement>().MakeReadOnly();

		// Token: 0x04001A4F RID: 6735
		private readonly global::System.Collections.Generic.HashSet<TElement> _values;

		// Token: 0x04001A50 RID: 6736
		private bool _isReadOnly;

		// Token: 0x02000C47 RID: 3143
		public class Enumerator : global::System.Collections.Generic.IEnumerator<!0>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06006A6F RID: 27247 RVA: 0x0016B41D File Offset: 0x0016961D
			internal Enumerator(global::System.Collections.Generic.Dictionary<TElement, bool>.KeyCollection.Enumerator keys)
			{
				this.keys = keys;
			}

			// Token: 0x17001176 RID: 4470
			// (get) Token: 0x06006A70 RID: 27248 RVA: 0x0016B42C File Offset: 0x0016962C
			public TElement Current
			{
				get
				{
					return this.keys.Current;
				}
			}

			// Token: 0x06006A71 RID: 27249 RVA: 0x0016B439 File Offset: 0x00169639
			public void Dispose()
			{
				this.keys.Dispose();
			}

			// Token: 0x17001177 RID: 4471
			// (get) Token: 0x06006A72 RID: 27250 RVA: 0x0016B446 File Offset: 0x00169646
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return ((global::System.Collections.IEnumerator)this.keys).Current;
				}
			}

			// Token: 0x06006A73 RID: 27251 RVA: 0x0016B458 File Offset: 0x00169658
			public bool MoveNext()
			{
				return this.keys.MoveNext();
			}

			// Token: 0x06006A74 RID: 27252 RVA: 0x0016B465 File Offset: 0x00169665
			void global::System.Collections.IEnumerator.Reset()
			{
				((global::System.Collections.IEnumerator)this.keys).Reset();
			}

			// Token: 0x040030B9 RID: 12473
			private global::System.Collections.Generic.Dictionary<TElement, bool>.KeyCollection.Enumerator keys;
		}
	}
}
