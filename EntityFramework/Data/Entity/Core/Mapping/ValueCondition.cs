using System;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000560 RID: 1376
	internal class ValueCondition : global::System.IEquatable<global::System.Data.Entity.Core.Mapping.ValueCondition>
	{
		// Token: 0x0600434D RID: 17229 RVA: 0x000E6845 File Offset: 0x000E4A45
		private ValueCondition(string description, bool isSentinel)
		{
			this.Description = description;
			this.IsSentinel = isSentinel;
		}

		// Token: 0x0600434E RID: 17230 RVA: 0x000E685B File Offset: 0x000E4A5B
		internal ValueCondition(string description) : this(description, false)
		{
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x0600434F RID: 17231 RVA: 0x000E6865 File Offset: 0x000E4A65
		internal bool IsNotNullCondition
		{
			get
			{
				return this == global::System.Data.Entity.Core.Mapping.ValueCondition.IsNotNull;
			}
		}

		// Token: 0x06004350 RID: 17232 RVA: 0x000E686F File Offset: 0x000E4A6F
		public bool Equals(global::System.Data.Entity.Core.Mapping.ValueCondition other)
		{
			return other.IsSentinel == this.IsSentinel && other.Description == this.Description;
		}

		// Token: 0x06004351 RID: 17233 RVA: 0x000E6892 File Offset: 0x000E4A92
		public override int GetHashCode()
		{
			return this.Description.GetHashCode();
		}

		// Token: 0x06004352 RID: 17234 RVA: 0x000E689F File Offset: 0x000E4A9F
		public override string ToString()
		{
			return this.Description;
		}

		// Token: 0x040017FF RID: 6143
		internal readonly string Description;

		// Token: 0x04001800 RID: 6144
		internal readonly bool IsSentinel;

		// Token: 0x04001801 RID: 6145
		internal const string IsNullDescription = "NULL";

		// Token: 0x04001802 RID: 6146
		internal const string IsNotNullDescription = "NOT NULL";

		// Token: 0x04001803 RID: 6147
		internal const string IsOtherDescription = "OTHER";

		// Token: 0x04001804 RID: 6148
		internal static readonly global::System.Data.Entity.Core.Mapping.ValueCondition IsNull = new global::System.Data.Entity.Core.Mapping.ValueCondition("NULL", true);

		// Token: 0x04001805 RID: 6149
		internal static readonly global::System.Data.Entity.Core.Mapping.ValueCondition IsNotNull = new global::System.Data.Entity.Core.Mapping.ValueCondition("NOT NULL", true);

		// Token: 0x04001806 RID: 6150
		internal static readonly global::System.Data.Entity.Core.Mapping.ValueCondition IsOther = new global::System.Data.Entity.Core.Mapping.ValueCondition("OTHER", true);
	}
}
