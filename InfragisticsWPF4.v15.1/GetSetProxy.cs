using System;

namespace Infragistics
{
	// Token: 0x02000048 RID: 72
	internal class GetSetProxy<TOwner, TProperty> : global::System.IEquatable<global::Infragistics.GetSetProxy<TOwner, TProperty>>
	{
		// Token: 0x060002C9 RID: 713 RVA: 0x0000BBB6 File Offset: 0x00009DB6
		public GetSetProxy(global::System.Func<TOwner, TProperty> getter, global::System.Action<TOwner, TProperty> setter, string name, string displayName)
		{
			this.Getter = getter;
			this.Setter = setter;
			this.Name = name;
			this.DisplayName = displayName;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000BBDB File Offset: 0x00009DDB
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Infragistics.GetSetProxy<TOwner, TProperty>);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000BBEC File Offset: 0x00009DEC
		public bool Equals(global::Infragistics.GetSetProxy<TOwner, TProperty> other)
		{
			return other != null && other.Getter == this.Getter && other.Setter == this.Setter && other.Name == this.Name && other.DisplayName == this.DisplayName;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000BC48 File Offset: 0x00009E48
		public override int GetHashCode()
		{
			int num = 0;
			if (this.Getter != null)
			{
				num ^= this.Getter.GetHashCode();
			}
			if (this.Setter != null)
			{
				num ^= this.Setter.GetHashCode();
			}
			if (this.Name != null)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.DisplayName != null)
			{
				num ^= this.DisplayName.GetHashCode();
			}
			return num;
		}

		// Token: 0x040000E2 RID: 226
		public readonly global::System.Func<TOwner, TProperty> Getter;

		// Token: 0x040000E3 RID: 227
		public readonly global::System.Action<TOwner, TProperty> Setter;

		// Token: 0x040000E4 RID: 228
		internal readonly string Name;

		// Token: 0x040000E5 RID: 229
		internal readonly string DisplayName;
	}
}
