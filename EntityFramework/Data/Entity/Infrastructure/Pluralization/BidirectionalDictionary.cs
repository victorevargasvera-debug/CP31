using System;
using System.Collections.Generic;

namespace System.Data.Entity.Infrastructure.Pluralization
{
	// Token: 0x02000269 RID: 617
	internal class BidirectionalDictionary<TFirst, TSecond>
	{
		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06001F57 RID: 8023 RVA: 0x00055D6B File Offset: 0x00053F6B
		// (set) Token: 0x06001F58 RID: 8024 RVA: 0x00055D73 File Offset: 0x00053F73
		internal global::System.Collections.Generic.Dictionary<TFirst, TSecond> FirstToSecondDictionary { get; set; }

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06001F59 RID: 8025 RVA: 0x00055D7C File Offset: 0x00053F7C
		// (set) Token: 0x06001F5A RID: 8026 RVA: 0x00055D84 File Offset: 0x00053F84
		internal global::System.Collections.Generic.Dictionary<TSecond, TFirst> SecondToFirstDictionary { get; set; }

		// Token: 0x06001F5B RID: 8027 RVA: 0x00055D8D File Offset: 0x00053F8D
		internal BidirectionalDictionary()
		{
			this.FirstToSecondDictionary = new global::System.Collections.Generic.Dictionary<TFirst, TSecond>();
			this.SecondToFirstDictionary = new global::System.Collections.Generic.Dictionary<TSecond, TFirst>();
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x00055DAC File Offset: 0x00053FAC
		internal BidirectionalDictionary(global::System.Collections.Generic.Dictionary<TFirst, TSecond> firstToSecondDictionary) : this()
		{
			foreach (TFirst tfirst in firstToSecondDictionary.Keys)
			{
				this.AddValue(tfirst, firstToSecondDictionary[tfirst]);
			}
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x00055E0C File Offset: 0x0005400C
		internal virtual bool ExistsInFirst(TFirst value)
		{
			return this.FirstToSecondDictionary.ContainsKey(value);
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x00055E1F File Offset: 0x0005401F
		internal virtual bool ExistsInSecond(TSecond value)
		{
			return this.SecondToFirstDictionary.ContainsKey(value);
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x00055E34 File Offset: 0x00054034
		internal virtual TSecond GetSecondValue(TFirst value)
		{
			if (this.ExistsInFirst(value))
			{
				return this.FirstToSecondDictionary[value];
			}
			return default(TSecond);
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x00055E60 File Offset: 0x00054060
		internal virtual TFirst GetFirstValue(TSecond value)
		{
			if (this.ExistsInSecond(value))
			{
				return this.SecondToFirstDictionary[value];
			}
			return default(TFirst);
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x00055E8C File Offset: 0x0005408C
		internal void AddValue(TFirst firstValue, TSecond secondValue)
		{
			this.FirstToSecondDictionary.Add(firstValue, secondValue);
			if (!this.SecondToFirstDictionary.ContainsKey(secondValue))
			{
				this.SecondToFirstDictionary.Add(secondValue, firstValue);
			}
		}
	}
}
