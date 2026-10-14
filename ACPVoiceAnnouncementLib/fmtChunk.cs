using System;

namespace ACPVoiceAnnouncementLib
{
	// Token: 0x0200001B RID: 27
	public class fmtChunk
	{
		// Token: 0x0400006C RID: 108
		public string sChunkID;

		// Token: 0x0400006D RID: 109
		public uint dwChunkSize;

		// Token: 0x0400006E RID: 110
		public ushort wFormatTag;

		// Token: 0x0400006F RID: 111
		public ushort wChannels;

		// Token: 0x04000070 RID: 112
		public uint dwSamplesPerSec;

		// Token: 0x04000071 RID: 113
		public uint dwAvgBytesPerSec;

		// Token: 0x04000072 RID: 114
		public ushort wBlockAlign;

		// Token: 0x04000073 RID: 115
		public uint dwBitsPerSample;
	}
}
