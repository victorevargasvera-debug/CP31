using System;

namespace NPOI.Util
{
	// Token: 0x02000271 RID: 625
	public interface IDelayableLittleEndianOutput : global::NPOI.Util.ILittleEndianOutput
	{
		// Token: 0x06001086 RID: 4230
		global::NPOI.Util.ILittleEndianOutput CreateDelayedOutput(int size);
	}
}
