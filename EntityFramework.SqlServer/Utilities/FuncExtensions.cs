using System;

namespace System.Data.Entity.SqlServer.Utilities
{
	// Token: 0x0200001D RID: 29
	internal static class FuncExtensions
	{
		// Token: 0x06000372 RID: 882 RVA: 0x0000EAB4 File Offset: 0x0000CCB4
		internal static TResult NullIfNotImplemented<TResult>(this global::System.Func<TResult> func)
		{
			TResult result;
			try
			{
				result = func();
			}
			catch (global::System.NotImplementedException)
			{
				result = default(TResult);
			}
			return result;
		}
	}
}
