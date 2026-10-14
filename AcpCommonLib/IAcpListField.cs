using System;

namespace AcpCommonLib
{
	// Token: 0x0200002B RID: 43
	public interface IAcpListField
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001CE RID: 462
		bool SerializeItems { get; }

		// Token: 0x060001CF RID: 463
		string BuildReportString();
	}
}
