using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000070 RID: 112
	internal static class ValidationUtils
	{
		// Token: 0x06000606 RID: 1542 RVA: 0x000195CC File Offset: 0x000177CC
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public static void ArgumentNotNull([global::System.Runtime.CompilerServices.Nullable(2)] [global::System.Diagnostics.CodeAnalysis.NotNull] object value, string parameterName)
		{
			if (value == null)
			{
				throw new global::System.ArgumentNullException(parameterName);
			}
		}
	}
}
