using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace System.Data.Entity.Core.Common.Utils
{
	// Token: 0x020005F8 RID: 1528
	internal class KeyToListMap<TKey, TValue> : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x06004AC0 RID: 19136 RVA: 0x00107FEC File Offset: 0x001061EC
		internal KeyToListMap(global::System.Collections.Generic.IEqualityComparer<TKey> comparer)
		{
			this.m_map = new global::System.Collections.Generic.Dictionary<TKey, global::System.Collections.Generic.List<TValue>>(comparer);
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06004AC1 RID: 19137 RVA: 0x00108000 File Offset: 0x00106200
		internal global::System.Collections.Generic.IEnumerable<TKey> Keys
		{
			get
			{
				return this.m_map.Keys;
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06004AC2 RID: 19138 RVA: 0x0010800D File Offset: 0x0010620D
		internal global::System.Collections.Generic.IEnumerable<TValue> AllValues
		{
			get
			{
				foreach (TKey key in this.Keys)
				{
					foreach (TValue tvalue in this.ListForKey(key))
					{
						yield return tvalue;
					}
					global::System.Collections.Generic.IEnumerator<TValue> enumerator2 = null;
				}
				global::System.Collections.Generic.IEnumerator<TKey> enumerator = null;
				yield break;
				yield break;
			}
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06004AC3 RID: 19139 RVA: 0x0010801D File Offset: 0x0010621D
		internal global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<TKey, global::System.Collections.Generic.List<TValue>>> KeyValuePairs
		{
			get
			{
				return this.m_map;
			}
		}

		// Token: 0x06004AC4 RID: 19140 RVA: 0x00108025 File Offset: 0x00106225
		internal bool ContainsKey(TKey key)
		{
			return this.m_map.ContainsKey(key);
		}

		// Token: 0x06004AC5 RID: 19141 RVA: 0x00108034 File Offset: 0x00106234
		internal void Add(TKey key, TValue value)
		{
			global::System.Collections.Generic.List<TValue> list;
			if (!this.m_map.TryGetValue(key, out list))
			{
				list = new global::System.Collections.Generic.List<TValue>();
				this.m_map[key] = list;
			}
			list.Add(value);
		}

		// Token: 0x06004AC6 RID: 19142 RVA: 0x0010806C File Offset: 0x0010626C
		internal void AddRange(TKey key, global::System.Collections.Generic.IEnumerable<TValue> values)
		{
			foreach (TValue value in values)
			{
				this.Add(key, value);
			}
		}

		// Token: 0x06004AC7 RID: 19143 RVA: 0x001080B8 File Offset: 0x001062B8
		internal bool RemoveKey(TKey key)
		{
			return this.m_map.Remove(key);
		}

		// Token: 0x06004AC8 RID: 19144 RVA: 0x001080C6 File Offset: 0x001062C6
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<TValue> ListForKey(TKey key)
		{
			return new global::System.Collections.ObjectModel.ReadOnlyCollection<TValue>(this.m_map[key]);
		}

		// Token: 0x06004AC9 RID: 19145 RVA: 0x001080DC File Offset: 0x001062DC
		internal bool TryGetListForKey(TKey key, out global::System.Collections.ObjectModel.ReadOnlyCollection<TValue> valueCollection)
		{
			valueCollection = null;
			global::System.Collections.Generic.List<TValue> list;
			if (this.m_map.TryGetValue(key, out list))
			{
				valueCollection = new global::System.Collections.ObjectModel.ReadOnlyCollection<TValue>(list);
				return true;
			}
			return false;
		}

		// Token: 0x06004ACA RID: 19146 RVA: 0x00108107 File Offset: 0x00106307
		internal global::System.Collections.Generic.IEnumerable<TValue> EnumerateValues(TKey key)
		{
			global::System.Collections.Generic.List<TValue> list;
			if (this.m_map.TryGetValue(key, out list))
			{
				foreach (TValue tvalue in list)
				{
					yield return tvalue;
				}
				global::System.Collections.Generic.List<TValue>.Enumerator enumerator = default(global::System.Collections.Generic.List<TValue>.Enumerator);
			}
			yield break;
			yield break;
		}

		// Token: 0x06004ACB RID: 19147 RVA: 0x00108120 File Offset: 0x00106320
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			foreach (TKey tkey in this.Keys)
			{
				global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatStringBuilder(builder, "{0}", new object[]
				{
					tkey
				});
				builder.Append(": ");
				global::System.Collections.Generic.IEnumerable<TValue> list = this.ListForKey(tkey);
				global::System.Data.Entity.Core.Common.Utils.StringUtil.ToSeparatedString(builder, list, ",", "null");
				builder.Append("; ");
			}
		}

		// Token: 0x04001A46 RID: 6726
		private readonly global::System.Collections.Generic.Dictionary<TKey, global::System.Collections.Generic.List<TValue>> m_map;
	}
}
