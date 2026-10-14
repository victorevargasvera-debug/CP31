using System;
using System.IO;

namespace TTSBridge
{
	// Token: 0x02000007 RID: 7
	public class MVAFormat : global::TTSBridge.AMRFormat
	{
		// Token: 0x0600001D RID: 29 RVA: 0x000022B2 File Offset: 0x000004B2
		public MVAFormat(int sampleQuality) : base(sampleQuality)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000022BB File Offset: 0x000004BB
		public override global::TTSBridge.IAudioWriter createAudioWriter(string filename)
		{
			return new global::TTSBridge.MVAStreamWriter(filename);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000022C3 File Offset: 0x000004C3
		public override global::TTSBridge.IAudioWriter createAudioWriter(global::System.IO.MemoryStream stream)
		{
			return new global::TTSBridge.MVAStreamWriter(stream);
		}
	}
}
