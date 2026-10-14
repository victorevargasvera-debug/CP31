using System;
using System.IO;

namespace TTSBridge
{
	// Token: 0x02000003 RID: 3
	public class AMRFormat : global::TTSBridge.IAudioFormat
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002164 File Offset: 0x00000364
		public AMRFormat(int sampleQuality)
		{
			this.mSamplingQuality = sampleQuality;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002173 File Offset: 0x00000373
		public virtual global::TTSBridge.IAudioWriter createAudioWriter(string filename)
		{
			return new global::TTSBridge.AMRStreamWriter(filename);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000217B File Offset: 0x0000037B
		public virtual global::TTSBridge.IAudioWriter createAudioWriter(global::System.IO.MemoryStream stream)
		{
			return new global::TTSBridge.AMRStreamWriter(stream);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002183 File Offset: 0x00000383
		public int getSampleQuality()
		{
			return this.mSamplingQuality;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000218B File Offset: 0x0000038B
		public uint getSampleRate()
		{
			return 8000U;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002192 File Offset: 0x00000392
		public uint getSampleSize()
		{
			return (uint)global::System.Math.Ceiling(440.0);
		}

		// Token: 0x04000004 RID: 4
		private int mSamplingQuality;
	}
}
