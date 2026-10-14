using System;
using System.CodeDom.Compiler;

namespace System.Data.Entity.SqlServer.Resources
{
	// Token: 0x02000042 RID: 66
	[global::System.CodeDom.Compiler.GeneratedCode("Resources.SqlServer.tt", "1.0.0.0")]
	internal static class Error
	{
		// Token: 0x06000600 RID: 1536 RVA: 0x0001A52D File Offset: 0x0001872D
		internal static global::System.Exception InvalidDatabaseName(object p0)
		{
			return new global::System.ArgumentException(global::System.Data.Entity.SqlServer.Resources.Strings.InvalidDatabaseName(p0));
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0001A53A File Offset: 0x0001873A
		internal static global::System.Exception SqlServerMigrationSqlGenerator_UnknownOperation(object p0, object p1)
		{
			return new global::System.InvalidOperationException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlServerMigrationSqlGenerator_UnknownOperation(p0, p1));
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0001A548 File Offset: 0x00018748
		internal static global::System.Exception ArgumentOutOfRange(string paramName)
		{
			return new global::System.ArgumentOutOfRangeException(paramName);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0001A550 File Offset: 0x00018750
		internal static global::System.Exception NotImplemented()
		{
			return new global::System.NotImplementedException();
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0001A557 File Offset: 0x00018757
		internal static global::System.Exception NotSupported()
		{
			return new global::System.NotSupportedException();
		}
	}
}
