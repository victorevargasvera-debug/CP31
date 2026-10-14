using System;

namespace ACPVoiceAnnouncementLib
{
	// Token: 0x0200001D RID: 29
	public class dataChunk
	{
		// Token: 0x04000077 RID: 119
		public string sChunkID;

		// Token: 0x04000078 RID: 120
		public uint dwChunkSize;

		// Token: 0x04000079 RID: 121
		public long lFilePosition;

		// Token: 0x0400007A RID: 122
		public uint dwMinLength;

		// Token: 0x0400007B RID: 123
		public double dSecLength;

		// Token: 0x0400007C RID: 124
		public uint dwNumSamples;

		// Token: 0x0400007D RID: 125
		public byte[] pcmData;
	}
}
