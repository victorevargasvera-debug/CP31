using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication
{
	// Token: 0x02000011 RID: 17
	public interface IDifferentialWritable
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004A RID: 74
		// (set) Token: 0x0600004B RID: 75
		bool DifferentialWriteCapableRadio { get; set; }

		// Token: 0x0600004C RID: 76
		bool DifferentialWriteSupported(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation);
	}
}
