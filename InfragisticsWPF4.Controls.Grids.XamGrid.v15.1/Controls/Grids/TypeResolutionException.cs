using System;
using System.Globalization;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001C7 RID: 455
	public class TypeResolutionException : global::System.Exception
	{
		// Token: 0x06000C2D RID: 3117 RVA: 0x0002B5A1 File Offset: 0x000297A1
		public TypeResolutionException()
		{
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x0002B5A9 File Offset: 0x000297A9
		public TypeResolutionException(string message) : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, message, new object[0]))
		{
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x0002B5C4 File Offset: 0x000297C4
		public TypeResolutionException(global::System.Type type) : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Infragistics.SRGrid.GetString("TypeResolutionException"), new object[]
		{
			type.ToString()
		}))
		{
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x0002B5FC File Offset: 0x000297FC
		public TypeResolutionException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
