using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003FC RID: 1020
	internal class VarMap : global::System.Collections.Generic.IDictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var>, global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var>>, global::System.Collections.IEnumerable
	{
		// Token: 0x06002F7B RID: 12155 RVA: 0x00094F20 File Offset: 0x00093120
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarMap GetReverseMap()
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.VarMap(this.reverseMap, this.map);
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x00094F33 File Offset: 0x00093133
		public bool ContainsValue(global::System.Data.Entity.Core.Query.InternalTrees.Var value)
		{
			return this.reverseMap.ContainsKey(value);
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x00094F44 File Offset: 0x00093144
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string text = string.Empty;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in this.map.Keys)
			{
				stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "{0}({1},{2})", new object[]
				{
					text,
					var.Id,
					this[var].Id
				});
				text = ",";
			}
			return stringBuilder.ToString();
		}

		// Token: 0x17000962 RID: 2402
		public global::System.Data.Entity.Core.Query.InternalTrees.Var this[global::System.Data.Entity.Core.Query.InternalTrees.Var key]
		{
			get
			{
				return this.map[key];
			}
			set
			{
				this.map[key] = value;
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06002F80 RID: 12160 RVA: 0x00095009 File Offset: 0x00093209
		public global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Query.InternalTrees.Var> Keys
		{
			get
			{
				return this.map.Keys;
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06002F81 RID: 12161 RVA: 0x00095016 File Offset: 0x00093216
		public global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Query.InternalTrees.Var> Values
		{
			get
			{
				return this.map.Values;
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06002F82 RID: 12162 RVA: 0x00095023 File Offset: 0x00093223
		public int Count
		{
			get
			{
				return this.map.Count;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06002F83 RID: 12163 RVA: 0x00095030 File Offset: 0x00093230
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x00095033 File Offset: 0x00093233
		public void Add(global::System.Data.Entity.Core.Query.InternalTrees.Var key, global::System.Data.Entity.Core.Query.InternalTrees.Var value)
		{
			if (!this.reverseMap.ContainsKey(value))
			{
				this.reverseMap.Add(value, key);
			}
			this.map.Add(key, value);
		}

		// Token: 0x06002F85 RID: 12165 RVA: 0x0009505D File Offset: 0x0009325D
		public void Add(global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> item)
		{
			if (!this.reverseMap.ContainsKey(item.Value))
			{
				((global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var>>)this.reverseMap).Add(new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var>(item.Value, item.Key));
			}
			((global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var>>)this.map).Add(item);
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x0009509D File Offset: 0x0009329D
		public void Clear()
		{
			this.map.Clear();
			this.reverseMap.Clear();
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x000950B5 File Offset: 0x000932B5
		public bool Contains(global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> item)
		{
			return ((global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var>>)this.map).Contains(item);
		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x000950C3 File Offset: 0x000932C3
		public bool ContainsKey(global::System.Data.Entity.Core.Query.InternalTrees.Var key)
		{
			return this.map.ContainsKey(key);
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x000950D1 File Offset: 0x000932D1
		public void CopyTo(global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var>[] array, int arrayIndex)
		{
			((global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var>>)this.map).CopyTo(array, arrayIndex);
		}

		// Token: 0x06002F8A RID: 12170 RVA: 0x000950E0 File Offset: 0x000932E0
		public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var>> GetEnumerator()
		{
			return this.map.GetEnumerator();
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x000950F2 File Offset: 0x000932F2
		public bool Remove(global::System.Data.Entity.Core.Query.InternalTrees.Var key)
		{
			this.reverseMap.Remove(this.map[key]);
			return this.map.Remove(key);
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x00095118 File Offset: 0x00093318
		public bool Remove(global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> item)
		{
			this.reverseMap.Remove(this.map[item.Value]);
			return ((global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var>>)this.map).Remove(item);
		}

		// Token: 0x06002F8D RID: 12173 RVA: 0x00095144 File Offset: 0x00093344
		public bool TryGetValue(global::System.Data.Entity.Core.Query.InternalTrees.Var key, out global::System.Data.Entity.Core.Query.InternalTrees.Var value)
		{
			return ((global::System.Collections.Generic.IDictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var>)this.map).TryGetValue(key, out value);
		}

		// Token: 0x06002F8E RID: 12174 RVA: 0x00095153 File Offset: 0x00093353
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.map.GetEnumerator();
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x00095165 File Offset: 0x00093365
		public VarMap()
		{
			this.map = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var>();
			this.reverseMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var>();
		}

		// Token: 0x06002F90 RID: 12176 RVA: 0x00095183 File Offset: 0x00093383
		private VarMap(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> map, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> reverseMap)
		{
			this.map = map;
			this.reverseMap = reverseMap;
		}

		// Token: 0x04001007 RID: 4103
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> map;

		// Token: 0x04001008 RID: 4104
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> reverseMap;
	}
}
