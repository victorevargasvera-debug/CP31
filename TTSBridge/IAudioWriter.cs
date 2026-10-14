using System;

namespace TTSBridge
{
	// Token: 0x02000006 RID: 6
	public interface IAudioWriter
	{
		// Token: 0x0600001B RID: 27
		void writePCMChunk(short[] buffer, int offset, int size);

		// Token: 0x0600001C RID: 28
		void finish();
	}
}
