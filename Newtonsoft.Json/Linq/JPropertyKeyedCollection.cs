using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000C0 RID: 192
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(new byte[]
	{
		0,
		1
	})]
	internal class JPropertyKeyedCollection : global::System.Collections.ObjectModel.Collection<global::Newtonsoft.Json.Linq.JToken>
	{
		// Token: 0x06000A96 RID: 2710 RVA: 0x0002A733 File Offset: 0x00028933
		public JPropertyKeyedCollection() : base(new global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JToken>())
		{
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x0002A740 File Offset: 0x00028940
		private void AddKey(string key, global::Newtonsoft.Json.Linq.JToken item)
		{
			this.EnsureDictionary();
			this._dictionary[key] = item;
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x0002A758 File Offset: 0x00028958
		protected void ChangeItemKey(global::Newtonsoft.Json.Linq.JToken item, string newKey)
		{
			if (!this.ContainsItem(item))
			{
				throw new global::System.ArgumentException("The specified item does not exist in this KeyedCollection.");
			}
			string keyForItem = this.GetKeyForItem(item);
			if (!global::Newtonsoft.Json.Linq.JPropertyKeyedCollection.Comparer.Equals(keyForItem, newKey))
			{
				if (newKey != null)
				{
					this.AddKey(newKey, item);
				}
				if (keyForItem != null)
				{
					this.RemoveKey(keyForItem);
				}
			}
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x0002A7A4 File Offset: 0x000289A4
		protected override void ClearItems()
		{
			base.ClearItems();
			global::System.Collections.Generic.Dictionary<string, global::Newtonsoft.Json.Linq.JToken> dictionary = this._dictionary;
			if (dictionary == null)
			{
				return;
			}
			dictionary.Clear();
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x0002A7BC File Offset: 0x000289BC
		public bool Contains(string key)
		{
			if (key == null)
			{
				throw new global::System.ArgumentNullException("key");
			}
			return this._dictionary != null && this._dictionary.ContainsKey(key);
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x0002A7E4 File Offset: 0x000289E4
		private bool ContainsItem(global::Newtonsoft.Json.Linq.JToken item)
		{
			if (this._dictionary == null)
			{
				return false;
			}
			string keyForItem = this.GetKeyForItem(item);
			global::Newtonsoft.Json.Linq.JToken jtoken;
			return this._dictionary.TryGetValue(keyForItem, out jtoken);
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x0002A811 File Offset: 0x00028A11
		private void EnsureDictionary()
		{
			if (this._dictionary == null)
			{
				this._dictionary = new global::System.Collections.Generic.Dictionary<string, global::Newtonsoft.Json.Linq.JToken>(global::Newtonsoft.Json.Linq.JPropertyKeyedCollection.Comparer);
			}
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x0002A82B File Offset: 0x00028A2B
		private string GetKeyForItem(global::Newtonsoft.Json.Linq.JToken item)
		{
			return ((global::Newtonsoft.Json.Linq.JProperty)item).Name;
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x0002A838 File Offset: 0x00028A38
		protected override void InsertItem(int index, global::Newtonsoft.Json.Linq.JToken item)
		{
			this.AddKey(this.GetKeyForItem(item), item);
			base.InsertItem(index, item);
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0002A850 File Offset: 0x00028A50
		public bool Remove(string key)
		{
			if (key == null)
			{
				throw new global::System.ArgumentNullException("key");
			}
			global::Newtonsoft.Json.Linq.JToken item;
			return this._dictionary != null && this._dictionary.TryGetValue(key, out item) && base.Remove(item);
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0002A890 File Offset: 0x00028A90
		protected override void RemoveItem(int index)
		{
			string keyForItem = this.GetKeyForItem(base.Items[index]);
			this.RemoveKey(keyForItem);
			base.RemoveItem(index);
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0002A8BE File Offset: 0x00028ABE
		private void RemoveKey(string key)
		{
			global::System.Collections.Generic.Dictionary<string, global::Newtonsoft.Json.Linq.JToken> dictionary = this._dictionary;
			if (dictionary == null)
			{
				return;
			}
			dictionary.Remove(key);
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0002A8D4 File Offset: 0x00028AD4
		protected override void SetItem(int index, global::Newtonsoft.Json.Linq.JToken item)
		{
			string keyForItem = this.GetKeyForItem(item);
			string keyForItem2 = this.GetKeyForItem(base.Items[index]);
			if (global::Newtonsoft.Json.Linq.JPropertyKeyedCollection.Comparer.Equals(keyForItem2, keyForItem))
			{
				if (this._dictionary != null)
				{
					this._dictionary[keyForItem] = item;
				}
			}
			else
			{
				this.AddKey(keyForItem, item);
				if (keyForItem2 != null)
				{
					this.RemoveKey(keyForItem2);
				}
			}
			base.SetItem(index, item);
		}

		// Token: 0x170001E9 RID: 489
		public global::Newtonsoft.Json.Linq.JToken this[string key]
		{
			get
			{
				if (key == null)
				{
					throw new global::System.ArgumentNullException("key");
				}
				if (this._dictionary != null)
				{
					return this._dictionary[key];
				}
				throw new global::System.Collections.Generic.KeyNotFoundException();
			}
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0002A965 File Offset: 0x00028B65
		public bool TryGetValue(string key, [global::System.Runtime.CompilerServices.Nullable(2)] [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out global::Newtonsoft.Json.Linq.JToken value)
		{
			if (this._dictionary == null)
			{
				value = null;
				return false;
			}
			return this._dictionary.TryGetValue(key, out value);
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x0002A981 File Offset: 0x00028B81
		public global::System.Collections.Generic.ICollection<string> Keys
		{
			get
			{
				this.EnsureDictionary();
				return this._dictionary.Keys;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x0002A994 File Offset: 0x00028B94
		public global::System.Collections.Generic.ICollection<global::Newtonsoft.Json.Linq.JToken> Values
		{
			get
			{
				this.EnsureDictionary();
				return this._dictionary.Values;
			}
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0002A9A7 File Offset: 0x00028BA7
		public int IndexOfReference(global::Newtonsoft.Json.Linq.JToken t)
		{
			return ((global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JToken>)base.Items).IndexOfReference(t);
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0002A9BC File Offset: 0x00028BBC
		public bool Compare(global::Newtonsoft.Json.Linq.JPropertyKeyedCollection other)
		{
			if (this == other)
			{
				return true;
			}
			global::System.Collections.Generic.Dictionary<string, global::Newtonsoft.Json.Linq.JToken> dictionary = this._dictionary;
			global::System.Collections.Generic.Dictionary<string, global::Newtonsoft.Json.Linq.JToken> dictionary2 = other._dictionary;
			if (dictionary == null && dictionary2 == null)
			{
				return true;
			}
			if (dictionary == null)
			{
				return dictionary2.Count == 0;
			}
			if (dictionary2 == null)
			{
				return dictionary.Count == 0;
			}
			if (dictionary.Count != dictionary2.Count)
			{
				return false;
			}
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken> keyValuePair in dictionary)
			{
				global::Newtonsoft.Json.Linq.JToken jtoken;
				if (!dictionary2.TryGetValue(keyValuePair.Key, out jtoken))
				{
					return false;
				}
				global::Newtonsoft.Json.Linq.JProperty jproperty = (global::Newtonsoft.Json.Linq.JProperty)keyValuePair.Value;
				global::Newtonsoft.Json.Linq.JProperty jproperty2 = (global::Newtonsoft.Json.Linq.JProperty)jtoken;
				if (jproperty.Value == null)
				{
					return jproperty2.Value == null;
				}
				if (!jproperty.Value.DeepEquals(jproperty2.Value))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0400036D RID: 877
		private static readonly global::System.Collections.Generic.IEqualityComparer<string> Comparer = global::System.StringComparer.Ordinal;

		// Token: 0x0400036E RID: 878
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private global::System.Collections.Generic.Dictionary<string, global::Newtonsoft.Json.Linq.JToken> _dictionary;
	}
}
