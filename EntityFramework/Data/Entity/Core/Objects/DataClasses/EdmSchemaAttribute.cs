using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Objects.DataClasses
{
	// Token: 0x02000474 RID: 1140
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly | global::System.AttributeTargets.Class, AllowMultiple = true)]
	public sealed class EdmSchemaAttribute : global::System.Attribute
	{
		// Token: 0x060037C5 RID: 14277 RVA: 0x000B5A25 File Offset: 0x000B3C25
		public EdmSchemaAttribute()
		{
		}

		// Token: 0x060037C6 RID: 14278 RVA: 0x000B5A2D File Offset: 0x000B3C2D
		public EdmSchemaAttribute(string assemblyGuid)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(assemblyGuid, "assemblyGuid");
		}
	}
}
