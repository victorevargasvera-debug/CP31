using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000042 RID: 66
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class BidirectionalDictionary<[global::System.Runtime.CompilerServices.Nullable(2)] TFirst, [global::System.Runtime.CompilerServices.Nullable(2)] TSecond>
	{
		// Token: 0x06000431 RID: 1073 RVA: 0x000104E4 File Offset: 0x0000E6E4
		public BidirectionalDictionary() : this(global::System.Collections.Generic.EqualityComparer<TFirst>.Default, global::System.Collections.Generic.EqualityComparer<TSecond>.Default)
		{
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x000104F6 File Offset: 0x0000E6F6
		public BidirectionalDictionary(global::System.Collections.Generic.IEqualityComparer<TFirst> firstEqualityComparer, global::System.Collections.Generic.IEqualityComparer<TSecond> secondEqualityComparer) : this(firstEqualityComparer, secondEqualityComparer, "Duplicate item already exists for '{0}'.", "Duplicate item already exists for '{0}'.")
		{
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0001050A File Offset: 0x0000E70A
		public BidirectionalDictionary(global::System.Collections.Generic.IEqualityComparer<TFirst> firstEqualityComparer, global::System.Collections.Generic.IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage)
		{
			this._firstToSecond = new global::System.Collections.Generic.Dictionary<TFirst, TSecond>(firstEqualityComparer);
			this._secondToFirst = new global::System.Collections.Generic.Dictionary<TSecond, TFirst>(secondEqualityComparer);
			this._duplicateFirstErrorMessage = duplicateFirstErrorMessage;
			this._duplicateSecondErrorMessage = duplicateSecondErrorMessage;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0001053C File Offset: 0x0000E73C
		public void Set(TFirst first, TSecond second)
		{
			TSecond tsecond;
			if (this._firstToSecond.TryGetValue(first, out tsecond) && !tsecond.Equals(second))
			{
				throw new global::System.ArgumentException(this._duplicateFirstErrorMessage.FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, first));
			}
			TFirst tfirst;
			if (this._secondToFirst.TryGetValue(second, out tfirst) && !tfirst.Equals(first))
			{
				throw new global::System.ArgumentException(this._duplicateSecondErrorMessage.FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, second));
			}
			this._firstToSecond.Add(first, second);
			this._secondToFirst.Add(second, first);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x000105E5 File Offset: 0x0000E7E5
		public bool TryGetByFirst(TFirst first, out TSecond second)
		{
			return this._firstToSecond.TryGetValue(first, out second);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x000105F4 File Offset: 0x0000E7F4
		public bool TryGetBySecond(TSecond second, out TFirst first)
		{
			return this._secondToFirst.TryGetValue(second, out first);
		}

		// Token: 0x04000154 RID: 340
		private readonly global::System.Collections.Generic.IDictionary<TFirst, TSecond> _firstToSecond;

		// Token: 0x04000155 RID: 341
		private readonly global::System.Collections.Generic.IDictionary<TSecond, TFirst> _secondToFirst;

		// Token: 0x04000156 RID: 342
		private readonly string _duplicateFirstErrorMessage;

		// Token: 0x04000157 RID: 343
		private readonly string _duplicateSecondErrorMessage;
	}
}
