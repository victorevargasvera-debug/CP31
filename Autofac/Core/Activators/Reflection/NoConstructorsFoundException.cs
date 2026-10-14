using System;
using System.Globalization;

namespace Autofac.Core.Activators.Reflection
{
	// Token: 0x020000B0 RID: 176
	public class NoConstructorsFoundException : global::System.Exception
	{
		// Token: 0x06000405 RID: 1029 RVA: 0x0000C18F File Offset: 0x0000A38F
		public NoConstructorsFoundException(global::System.Type offendingType) : this(offendingType, global::Autofac.Core.Activators.Reflection.NoConstructorsFoundException.FormatMessage(offendingType))
		{
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000C19E File Offset: 0x0000A39E
		public NoConstructorsFoundException(global::System.Type offendingType, string message) : base(message)
		{
			if (offendingType == null)
			{
				throw new global::System.ArgumentNullException("offendingType");
			}
			this.OffendingType = offendingType;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000C1C2 File Offset: 0x0000A3C2
		public NoConstructorsFoundException(global::System.Type offendingType, global::System.Exception innerException) : this(offendingType, global::Autofac.Core.Activators.Reflection.NoConstructorsFoundException.FormatMessage(offendingType), innerException)
		{
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0000C1D2 File Offset: 0x0000A3D2
		public NoConstructorsFoundException(global::System.Type offendingType, string message, global::System.Exception innerException) : base(message, innerException)
		{
			if (offendingType == null)
			{
				throw new global::System.ArgumentNullException("offendingType");
			}
			this.OffendingType = offendingType;
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0000C1F7 File Offset: 0x0000A3F7
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x0000C1FF File Offset: 0x0000A3FF
		public global::System.Type OffendingType { get; private set; }

		// Token: 0x0600040B RID: 1035 RVA: 0x0000C208 File Offset: 0x0000A408
		private static string FormatMessage(global::System.Type offendingType)
		{
			if (offendingType == null)
			{
				throw new global::System.ArgumentNullException("offendingType");
			}
			return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Core.Activators.Reflection.NoConstructorsFoundExceptionResources.Message, new object[]
			{
				offendingType.FullName
			});
		}
	}
}
