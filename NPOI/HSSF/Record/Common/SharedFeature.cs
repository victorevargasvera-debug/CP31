using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Common
{
	// Token: 0x02000462 RID: 1122
	public interface SharedFeature
	{
		// Token: 0x06002983 RID: 10627
		string ToString();

		// Token: 0x06002984 RID: 10628
		void Serialize(global::NPOI.Util.ILittleEndianOutput out1);

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06002985 RID: 10629
		int DataSize { get; }
	}
}
