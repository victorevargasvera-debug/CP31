using System;
using System.Data.Entity.Core;
using System.Security;
using System.Threading;

namespace System.Data.Entity.Utilities
{
	// Token: 0x0200007D RID: 125
	internal static class ExceptionExtensions
	{
		// Token: 0x06000444 RID: 1092 RVA: 0x0000ED18 File Offset: 0x0000CF18
		public static bool IsCatchableExceptionType(this global::System.Exception e)
		{
			global::System.Type type = e.GetType();
			return type != typeof(global::System.StackOverflowException) && type != typeof(global::System.OutOfMemoryException) && type != typeof(global::System.Threading.ThreadAbortException) && type != typeof(global::System.NullReferenceException) && type != typeof(global::System.AccessViolationException) && !typeof(global::System.Security.SecurityException).IsAssignableFrom(type);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0000ED9C File Offset: 0x0000CF9C
		public static bool IsCatchableEntityExceptionType(this global::System.Exception e)
		{
			global::System.Type type = e.GetType();
			return e.IsCatchableExceptionType() && type != typeof(global::System.Data.Entity.Core.EntityCommandExecutionException) && type != typeof(global::System.Data.Entity.Core.EntityCommandCompilationException) && type != typeof(global::System.Data.Entity.Core.EntitySqlException);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0000EDEE File Offset: 0x0000CFEE
		public static bool RequiresContext(this global::System.Exception e)
		{
			return e.IsCatchableExceptionType() && !(e is global::System.Data.Entity.Core.UpdateException) && !(e is global::System.Data.Entity.Core.ProviderIncompatibleException);
		}
	}
}
