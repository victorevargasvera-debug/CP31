using System;
using System.Globalization;

namespace Autofac.Core
{
	// Token: 0x02000062 RID: 98
	[global::System.Serializable]
	public class DependencyResolutionException : global::System.Exception
	{
		// Token: 0x06000256 RID: 598 RVA: 0x00008776 File Offset: 0x00006976
		public DependencyResolutionException(string message) : base(message)
		{
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000877F File Offset: 0x0000697F
		public DependencyResolutionException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0000878C File Offset: 0x0000698C
		public override string Message
		{
			get
			{
				string message = base.Message;
				if (base.InnerException == null)
				{
					return message;
				}
				string message2 = base.InnerException.Message;
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Core.DependencyResolutionExceptionResources.MessageNestingFormat, new object[]
				{
					message,
					message2
				});
			}
		}
	}
}
