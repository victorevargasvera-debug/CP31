using System;

namespace Gibraltar
{
	// Token: 0x020000C1 RID: 193
	internal class NameValuePair<TValue> : global::Gibraltar.IName, global::System.IComparable, global::System.IComparable<global::Gibraltar.IName>, global::System.IComparable<global::Gibraltar.NameValuePair<TValue>>
	{
		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00010E50 File Offset: 0x0000F050
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x00010E58 File Offset: 0x0000F058
		public string Name { get; set; }

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x00010E64 File Offset: 0x0000F064
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x00010E6C File Offset: 0x0000F06C
		public TValue Value { get; set; }

		// Token: 0x06000813 RID: 2067 RVA: 0x00010E78 File Offset: 0x0000F078
		public NameValuePair()
		{
			this.Name = string.Empty;
			this.Value = default(TValue);
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00010EAC File Offset: 0x0000F0AC
		public NameValuePair(string name, TValue value)
		{
			this.Name = name;
			this.Value = value;
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00010EC4 File Offset: 0x0000F0C4
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00010ECC File Offset: 0x0000F0CC
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				return int.MaxValue;
			}
			global::Gibraltar.IName name = obj as global::Gibraltar.IName;
			if (name == null)
			{
				return int.MinValue;
			}
			return this.CompareTo(name);
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00010F04 File Offset: 0x0000F104
		public int CompareTo(global::Gibraltar.IName other)
		{
			if (other == null)
			{
				return int.MaxValue;
			}
			return this.Name.CompareTo(other.Name);
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00010F24 File Offset: 0x0000F124
		public int CompareTo(global::Gibraltar.NameValuePair<TValue> other)
		{
			return this.CompareTo(other);
		}
	}
}
