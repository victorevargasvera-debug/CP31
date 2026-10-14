using System;
using System.Globalization;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001D2 RID: 466
	public class NullConditionalFormatEvaluationValueException : global::System.Exception
	{
		// Token: 0x06000C4F RID: 3151 RVA: 0x0002B89E File Offset: 0x00029A9E
		public NullConditionalFormatEvaluationValueException() : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Infragistics.SRGrid.GetString("NullConditionalFormatEvaluationValueException"), new object[0]))
		{
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x0002B8C0 File Offset: 0x00029AC0
		public NullConditionalFormatEvaluationValueException(string message) : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, message, new object[0]))
		{
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x0002B8D9 File Offset: 0x00029AD9
		public NullConditionalFormatEvaluationValueException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
