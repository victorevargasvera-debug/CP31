using System;
using System.Globalization;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001C8 RID: 456
	public class InvalidColumnTypeMappingException : global::System.Exception
	{
		// Token: 0x06000C31 RID: 3121 RVA: 0x0002B606 File Offset: 0x00029806
		public InvalidColumnTypeMappingException() : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Infragistics.SRGrid.GetString("InvalidColumnTypeMappingException"), new object[0]))
		{
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x0002B628 File Offset: 0x00029828
		public InvalidColumnTypeMappingException(string message) : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, message, new object[0]))
		{
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x0002B641 File Offset: 0x00029841
		public InvalidColumnTypeMappingException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
