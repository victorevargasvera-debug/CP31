using System;
using System.Collections.Generic;

namespace Microsoft.Practices.Prism
{
	// Token: 0x02000091 RID: 145
	public static class ExceptionExtensions
	{
		// Token: 0x060003D2 RID: 978 RVA: 0x0000AB7C File Offset: 0x00008D7C
		public static void RegisterFrameworkExceptionType(global::System.Type frameworkExceptionType)
		{
			if (frameworkExceptionType == null)
			{
				throw new global::System.ArgumentNullException("frameworkExceptionType");
			}
			if (!global::Microsoft.Practices.Prism.ExceptionExtensions.frameworkExceptionTypes.Contains(frameworkExceptionType))
			{
				global::Microsoft.Practices.Prism.ExceptionExtensions.frameworkExceptionTypes.Add(frameworkExceptionType);
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000ABAA File Offset: 0x00008DAA
		public static bool IsFrameworkExceptionRegistered(global::System.Type frameworkExceptionType)
		{
			return global::Microsoft.Practices.Prism.ExceptionExtensions.frameworkExceptionTypes.Contains(frameworkExceptionType);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000ABB8 File Offset: 0x00008DB8
		public static global::System.Exception GetRootException(this global::System.Exception exception)
		{
			global::System.Exception ex = exception;
			try
			{
				while (ex != null)
				{
					if (!global::Microsoft.Practices.Prism.ExceptionExtensions.IsFrameworkException(ex))
					{
						return ex;
					}
					ex = ex.InnerException;
				}
				ex = exception;
			}
			catch (global::System.Exception)
			{
				ex = exception;
			}
			return ex;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000ABF8 File Offset: 0x00008DF8
		private static bool IsFrameworkException(global::System.Exception exception)
		{
			bool flag = global::Microsoft.Practices.Prism.ExceptionExtensions.frameworkExceptionTypes.Contains(exception.GetType());
			bool flag2 = false;
			if (exception.InnerException != null)
			{
				flag2 = global::Microsoft.Practices.Prism.ExceptionExtensions.frameworkExceptionTypes.Contains(exception.InnerException.GetType());
			}
			return flag || flag2;
		}

		// Token: 0x040000E0 RID: 224
		private static global::System.Collections.Generic.List<global::System.Type> frameworkExceptionTypes = new global::System.Collections.Generic.List<global::System.Type>();
	}
}
