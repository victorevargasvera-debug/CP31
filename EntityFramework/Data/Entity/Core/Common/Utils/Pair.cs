using System;
using System.Collections.Generic;
using System.Text;

namespace System.Data.Entity.Core.Common.Utils
{
	// Token: 0x020005FC RID: 1532
	internal class Pair<TFirst, TSecond> : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x06004B0C RID: 19212 RVA: 0x00109027 File Offset: 0x00107227
		internal Pair(TFirst first, TSecond second)
		{
			this.first = first;
			this.second = second;
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06004B0D RID: 19213 RVA: 0x0010903D File Offset: 0x0010723D
		internal TFirst First
		{
			get
			{
				return this.first;
			}
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06004B0E RID: 19214 RVA: 0x00109045 File Offset: 0x00107245
		internal TSecond Second
		{
			get
			{
				return this.second;
			}
		}

		// Token: 0x06004B0F RID: 19215 RVA: 0x00109050 File Offset: 0x00107250
		public override int GetHashCode()
		{
			TFirst tfirst = this.first;
			int num = tfirst.GetHashCode() << 5;
			TSecond tsecond = this.second;
			return num ^ tsecond.GetHashCode();
		}

		// Token: 0x06004B10 RID: 19216 RVA: 0x00109088 File Offset: 0x00107288
		public bool Equals(global::System.Data.Entity.Core.Common.Utils.Pair<TFirst, TSecond> other)
		{
			TFirst tfirst = this.first;
			if (tfirst.Equals(other.first))
			{
				TSecond tsecond = this.second;
				return tsecond.Equals(other.second);
			}
			return false;
		}

		// Token: 0x06004B11 RID: 19217 RVA: 0x001090D8 File Offset: 0x001072D8
		public override bool Equals(object other)
		{
			global::System.Data.Entity.Core.Common.Utils.Pair<TFirst, TSecond> pair = other as global::System.Data.Entity.Core.Common.Utils.Pair<TFirst, TSecond>;
			return pair != null && this.Equals(pair);
		}

		// Token: 0x06004B12 RID: 19218 RVA: 0x001090F8 File Offset: 0x001072F8
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			builder.Append("<");
			builder.Append(this.first);
			string str = ", ";
			TSecond tsecond = this.second;
			builder.Append(str + ((tsecond != null) ? tsecond.ToString() : null));
			builder.Append(">");
		}

		// Token: 0x04001A4C RID: 6732
		private readonly TFirst first;

		// Token: 0x04001A4D RID: 6733
		private readonly TSecond second;

		// Token: 0x02000C46 RID: 3142
		internal class PairComparer : global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Common.Utils.Pair<TFirst, TSecond>>
		{
			// Token: 0x06006A6B RID: 27243 RVA: 0x0016B3BB File Offset: 0x001695BB
			private PairComparer()
			{
			}

			// Token: 0x06006A6C RID: 27244 RVA: 0x0016B3C3 File Offset: 0x001695C3
			public bool Equals(global::System.Data.Entity.Core.Common.Utils.Pair<TFirst, TSecond> x, global::System.Data.Entity.Core.Common.Utils.Pair<TFirst, TSecond> y)
			{
				return global::System.Data.Entity.Core.Common.Utils.Pair<TFirst, TSecond>.PairComparer._firstComparer.Equals(x.First, y.First) && global::System.Data.Entity.Core.Common.Utils.Pair<TFirst, TSecond>.PairComparer._secondComparer.Equals(x.Second, y.Second);
			}

			// Token: 0x06006A6D RID: 27245 RVA: 0x0016B3F5 File Offset: 0x001695F5
			public int GetHashCode(global::System.Data.Entity.Core.Common.Utils.Pair<TFirst, TSecond> source)
			{
				return source.GetHashCode();
			}

			// Token: 0x040030B6 RID: 12470
			internal static readonly global::System.Data.Entity.Core.Common.Utils.Pair<TFirst, TSecond>.PairComparer Instance = new global::System.Data.Entity.Core.Common.Utils.Pair<TFirst, TSecond>.PairComparer();

			// Token: 0x040030B7 RID: 12471
			private static readonly global::System.Collections.Generic.EqualityComparer<TFirst> _firstComparer = global::System.Collections.Generic.EqualityComparer<TFirst>.Default;

			// Token: 0x040030B8 RID: 12472
			private static readonly global::System.Collections.Generic.EqualityComparer<TSecond> _secondComparer = global::System.Collections.Generic.EqualityComparer<TSecond>.Default;
		}
	}
}
