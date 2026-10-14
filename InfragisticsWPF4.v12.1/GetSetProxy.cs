using System;

namespace Infragistics
{
	// Token: 0x02000035 RID: 53
	internal class GetSetProxy<TOwner, TProperty> : global::System.IEquatable<global::Infragistics.GetSetProxy<TOwner, TProperty>>
	{
		// Token: 0x0600023B RID: 571 RVA: 0x0000A1D7 File Offset: 0x000083D7
		public GetSetProxy(global::System.Func<TOwner, TProperty> getter, global::System.Action<TOwner, TProperty> setter, string name, string displayName)
		{
			this.Getter = getter;
			this.Setter = setter;
			this.Name = name;
			this.DisplayName = displayName;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000A1FC File Offset: 0x000083FC
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Infragistics.GetSetProxy<TOwner, TProperty>);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000A20C File Offset: 0x0000840C
		public bool Equals(global::Infragistics.GetSetProxy<TOwner, TProperty> other)
		{
			return other != null && other.Getter == this.Getter && other.Setter == this.Setter && other.Name == this.Name && other.DisplayName == this.DisplayName;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000A268 File Offset: 0x00008468
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

		// Token: 0x04000088 RID: 136
		public readonly global::System.Func<TOwner, TProperty> Getter;

		// Token: 0x04000089 RID: 137
		public readonly global::System.Action<TOwner, TProperty> Setter;

		// Token: 0x0400008A RID: 138
		internal readonly string Name;

		// Token: 0x0400008B RID: 139
		internal readonly string DisplayName;
	}
}
