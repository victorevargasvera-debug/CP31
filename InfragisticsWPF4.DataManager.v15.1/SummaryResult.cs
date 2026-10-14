using System;

namespace Infragistics
{
	// Token: 0x02000044 RID: 68
	public class SummaryResult
	{
		// Token: 0x060002DA RID: 730 RVA: 0x0000E149 File Offset: 0x0000C349
		public SummaryResult(global::Infragistics.SummaryDefinition definition, object value)
		{
			this.Value = value;
			this.SummaryDefinition = definition;
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002DB RID: 731 RVA: 0x0000E15F File Offset: 0x0000C35F
		// (set) Token: 0x060002DC RID: 732 RVA: 0x0000E167 File Offset: 0x0000C367
		public global::Infragistics.SummaryDefinition SummaryDefinition { get; private set; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002DD RID: 733 RVA: 0x0000E170 File Offset: 0x0000C370
		// (set) Token: 0x060002DE RID: 734 RVA: 0x0000E178 File Offset: 0x0000C378
		public object Value { get; private set; }
	}
}
