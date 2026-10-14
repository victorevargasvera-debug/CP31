using System;
using System.IO;

namespace TTSBridge
{
	// Token: 0x0200000D RID: 13
	public class WaveFormat : global::TTSBridge.IAudioFormat
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00002DEB File Offset: 0x00000FEB
		public WaveFormat(uint samplingRate, int samplingQuality)
		{
			this.mSamplingQuality = samplingQuality;
			this.mSamplingRate = samplingRate;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002E01 File Offset: 0x00001001
		public global::TTSBridge.IAudioWriter createAudioWriter(string filename)
		{
			return new global::TTSBridge.WaveStreamWriter(this.mSamplingRate, 1, 16, filename);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002E12 File Offset: 0x00001012
		public global::TTSBridge.IAudioWriter createAudioWriter(global::System.IO.MemoryStream stream)
		{
			return new global::TTSBridge.WaveStreamWriter(this.mSamplingRate, 1, 16, stream);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002E23 File Offset: 0x00001023
		public int getSampleQuality()
		{
			return this.mSamplingQuality;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002E2B File Offset: 0x0000102B
		public uint getSampleRate()
		{
			return this.mSamplingRate;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002E33 File Offset: 0x00001033
		public uint getSampleSize()
		{
			return 2048U;
		}

		// Token: 0x04000024 RID: 36
		private uint mSamplingRate;

		// Token: 0x04000025 RID: 37
		private int mSamplingQuality;
	}
}
