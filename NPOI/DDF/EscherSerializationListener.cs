using System;

namespace NPOI.DDF
{
	// Token: 0x02000547 RID: 1351
	public interface EscherSerializationListener
	{
		// Token: 0x0600330B RID: 13067
		void BeforeRecordSerialize(int offset, short recordId, global::NPOI.DDF.EscherRecord record);

		// Token: 0x0600330C RID: 13068
		void AfterRecordSerialize(int offset, short recordId, int size, global::NPOI.DDF.EscherRecord record);
	}
}
