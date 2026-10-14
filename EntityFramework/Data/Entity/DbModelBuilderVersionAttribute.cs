using System;

namespace System.Data.Entity
{
	// Token: 0x02000061 RID: 97
	[global::System.AttributeUsage(global::System.AttributeTargets.Class, AllowMultiple = false)]
	public sealed class DbModelBuilderVersionAttribute : global::System.Attribute
	{
		// Token: 0x0600032C RID: 812 RVA: 0x0000AAF2 File Offset: 0x00008CF2
		public DbModelBuilderVersionAttribute(global::System.Data.Entity.DbModelBuilderVersion version)
		{
			if (!global::System.Enum.IsDefined(typeof(global::System.Data.Entity.DbModelBuilderVersion), version))
			{
				throw new global::System.ArgumentOutOfRangeException("version");
			}
			this.Version = version;
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600032D RID: 813 RVA: 0x0000AB23 File Offset: 0x00008D23
		// (set) Token: 0x0600032E RID: 814 RVA: 0x0000AB2B File Offset: 0x00008D2B
		public global::System.Data.Entity.DbModelBuilderVersion Version { get; private set; }
	}
}
