using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace Gibraltar
{
	// Token: 0x02000160 RID: 352
	internal class DistinctValueList<TItem, TValue> : global::System.ComponentModel.BindingList<global::Gibraltar.NameValuePair<TValue>>, global::Gibraltar.IBindingListListener<TItem>, global::System.IDisposable where TValue : class, global::System.IEquatable<TValue>, global::System.IComparable<TValue>
	{
		// Token: 0x06000EAB RID: 3755 RVA: 0x000256CC File Offset: 0x000238CC
		public DistinctValueList(string valuePropertyName, bool includeAll, bool includeNull = true, global::System.Collections.Generic.IEqualityComparer<TValue> comparer = null, global::Gibraltar.DistinctValueList<TItem, TValue>.FormatCaption formatCaption = null)
		{
			global::System.Type typeFromHandle = typeof(TItem);
			global::System.Type typeFromHandle2 = typeof(TValue);
			this.m_PropertyInfo = typeFromHandle.GetProperty(valuePropertyName);
			if (this.m_PropertyInfo == null)
			{
				throw new global::System.ArgumentException(string.Format("Could not find a public property {0}.{1}", typeFromHandle.Name, valuePropertyName));
			}
			if (!typeFromHandle2.IsAssignableFrom(this.m_PropertyInfo.PropertyType))
			{
				throw new global::System.ArgumentException(string.Format("Expected {0}.{1} to return type {2}", typeFromHandle.Name, valuePropertyName, typeFromHandle2.Name));
			}
			this.m_Comparer = (comparer ?? global::System.Collections.Generic.EqualityComparer<TValue>.Default);
			this.m_Lookup = new global::System.Collections.Generic.Dictionary<TValue, global::Gibraltar.DistinctValueList<TItem, TValue>.LookupEntry<TValue>>(this.m_Comparer);
			this.m_FormatCaption = formatCaption;
			this.m_IncludeAll = includeAll;
			this.m_IncludeNull = includeNull;
			this.m_NullCount = 0;
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x000257A0 File Offset: 0x000239A0
		public void Dispose()
		{
			base.RaiseListChangedEvents = false;
			base.Clear();
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x000257B0 File Offset: 0x000239B0
		public void BeginUpdate()
		{
			this.m_Updating = true;
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x000257BC File Offset: 0x000239BC
		public void EndUpdate()
		{
			global::System.Collections.Generic.List<global::Gibraltar.NameValuePair<TValue>> list = new global::System.Collections.Generic.List<global::Gibraltar.NameValuePair<TValue>>(this.m_Lookup.Count);
			foreach (global::Gibraltar.DistinctValueList<TItem, TValue>.LookupEntry<TValue> lookupEntry in this.m_Lookup.Values)
			{
				list.Add(lookupEntry.NameValue);
			}
			if (typeof(TValue) == typeof(string))
			{
				list.Sort((global::Gibraltar.NameValuePair<TValue> a, global::Gibraltar.NameValuePair<TValue> b) => this.CompareValues(a.Name, b.Name));
			}
			else
			{
				list.Sort((global::Gibraltar.NameValuePair<TValue> a, global::Gibraltar.NameValuePair<TValue> b) => this.CompareValues(a.Value, b.Value));
			}
			if (this.m_IncludeNull && this.m_NullCount > 0)
			{
				list.Insert(0, new global::Gibraltar.NameValuePair<TValue>("(None)", default(TValue)));
			}
			if (this.m_IncludeAll)
			{
				list.Insert(0, new global::Gibraltar.NameValuePair<TValue>("(All)", default(TValue)));
			}
			this.Synchronize(list);
			this.m_Updating = false;
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x000258D8 File Offset: 0x00023AD8
		private int CompareValues(string left, string right)
		{
			return string.Compare(left, right, global::System.StringComparison.CurrentCultureIgnoreCase);
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x000258E4 File Offset: 0x00023AE4
		private int CompareValues(TValue target, TValue other)
		{
			int result;
			if (target == null)
			{
				if (other == null)
				{
					result = 0;
				}
				else
				{
					result = -1;
				}
			}
			else
			{
				result = target.CompareTo(other);
			}
			return result;
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00025928 File Offset: 0x00023B28
		public void Reset()
		{
			this.m_Lookup.Clear();
			this.m_NullCount = 0;
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x0002593C File Offset: 0x00023B3C
		public void Add(TItem item)
		{
			TValue tvalue = (TValue)((object)this.m_PropertyInfo.GetValue(item, null));
			if (this.m_Comparer.Equals(tvalue, default(TValue)))
			{
				this.m_NullCount++;
				return;
			}
			global::Gibraltar.DistinctValueList<TItem, TValue>.LookupEntry<TValue> lookupEntry;
			if (this.m_Lookup.TryGetValue(tvalue, out lookupEntry))
			{
				global::Gibraltar.DistinctValueList<TItem, TValue>.LookupEntry<TValue> lookupEntry2 = lookupEntry;
				int count = lookupEntry2.Count;
				lookupEntry2.Count = count + 1;
				return;
			}
			global::Gibraltar.NameValuePair<TValue> nameValue = new global::Gibraltar.NameValuePair<TValue>((this.m_FormatCaption == null) ? tvalue.ToString() : this.m_FormatCaption(item, tvalue), tvalue);
			lookupEntry = new global::Gibraltar.DistinctValueList<TItem, TValue>.LookupEntry<TValue>
			{
				Count = 1,
				NameValue = nameValue
			};
			this.m_Lookup.Add(tvalue, lookupEntry);
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00025A04 File Offset: 0x00023C04
		public bool Contains(TValue value)
		{
			return this.m_Lookup.ContainsKey(value);
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x00025A14 File Offset: 0x00023C14
		public void Remove(TItem item)
		{
			TValue tvalue = (TValue)((object)this.m_PropertyInfo.GetValue(item, null));
			if (tvalue == null)
			{
				this.m_NullCount--;
				return;
			}
			global::Gibraltar.DistinctValueList<TItem, TValue>.LookupEntry<TValue> lookupEntry;
			if (this.m_Lookup.TryGetValue(tvalue, out lookupEntry))
			{
				global::Gibraltar.DistinctValueList<TItem, TValue>.LookupEntry<TValue> lookupEntry2 = lookupEntry;
				int count = lookupEntry2.Count;
				lookupEntry2.Count = count - 1;
				if (lookupEntry.Count <= 0)
				{
					this.m_Lookup.Remove(tvalue);
					return;
				}
			}
			else
			{
				if (this.m_FormatCaption != null)
				{
					this.m_FormatCaption(item, tvalue);
					return;
				}
				tvalue.ToString();
			}
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00025ABC File Offset: 0x00023CBC
		public void Change(TItem item)
		{
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00025AC0 File Offset: 0x00023CC0
		public void Synchronize(global::System.Collections.Generic.List<global::Gibraltar.NameValuePair<TValue>> list)
		{
			bool flag = false;
			int num = 0;
			int num2 = 0;
			while (!flag)
			{
				if (num < list.Count)
				{
					if (num2 < base.Count)
					{
						global::Gibraltar.NameValuePair<TValue> nameValuePair = list[num];
						global::Gibraltar.NameValuePair<TValue> nameValuePair2 = base[num2];
						int num3;
						if (typeof(TValue) == typeof(string))
						{
							num3 = this.CompareValues(nameValuePair.Name, nameValuePair2.Name);
						}
						else
						{
							num3 = this.CompareValues(nameValuePair.Value, nameValuePair2.Value);
						}
						if (num3 == 0)
						{
							num++;
							num2++;
						}
						else if (num3 < 0)
						{
							base.Insert(num2, nameValuePair);
							num++;
							num2++;
						}
						else
						{
							base.RemoveAt(num2);
						}
					}
					else
					{
						base.Insert(base.Count, list[num]);
						num++;
						num2++;
					}
				}
				else if (num2 < base.Count)
				{
					base.RemoveAt(num2);
				}
				else
				{
					flag = true;
				}
			}
		}

		// Token: 0x040004E3 RID: 1251
		private readonly global::System.Reflection.PropertyInfo m_PropertyInfo;

		// Token: 0x040004E4 RID: 1252
		private readonly global::Gibraltar.DistinctValueList<TItem, TValue>.FormatCaption m_FormatCaption;

		// Token: 0x040004E5 RID: 1253
		private readonly global::System.Collections.Generic.Dictionary<TValue, global::Gibraltar.DistinctValueList<TItem, TValue>.LookupEntry<TValue>> m_Lookup;

		// Token: 0x040004E6 RID: 1254
		private readonly bool m_IncludeAll;

		// Token: 0x040004E7 RID: 1255
		private readonly bool m_IncludeNull;

		// Token: 0x040004E8 RID: 1256
		private readonly global::System.Collections.Generic.IEqualityComparer<TValue> m_Comparer;

		// Token: 0x040004E9 RID: 1257
		private int m_NullCount;

		// Token: 0x040004EA RID: 1258
		private bool m_Updating;

		// Token: 0x0200049B RID: 1179
		private class LookupEntry<TValue1>
		{
			// Token: 0x17000EBD RID: 3773
			// (get) Token: 0x06003335 RID: 13109 RVA: 0x000B9F7C File Offset: 0x000B817C
			// (set) Token: 0x06003336 RID: 13110 RVA: 0x000B9F84 File Offset: 0x000B8184
			public int Count { get; set; }

			// Token: 0x17000EBE RID: 3774
			// (get) Token: 0x06003337 RID: 13111 RVA: 0x000B9F90 File Offset: 0x000B8190
			// (set) Token: 0x06003338 RID: 13112 RVA: 0x000B9F98 File Offset: 0x000B8198
			public global::Gibraltar.NameValuePair<TValue1> NameValue { get; set; }
		}

		// Token: 0x0200049C RID: 1180
		// (Invoke) Token: 0x0600333B RID: 13115
		public delegate string FormatCaption(TItem item, TValue value);
	}
}
