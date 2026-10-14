using System;
using System.IO;

namespace TTSBridge
{
	// Token: 0x02000005 RID: 5
	public interface IAudioFormat
	{
		// Token: 0x06000016 RID: 22
		uint getSampleRate();

		// Token: 0x06000017 RID: 23
		int getSampleQuality();

		// Token: 0x06000018 RID: 24
		uint getSampleSize();

		// Token: 0x06000019 RID: 25
		global::TTSBridge.IAudioWriter createAudioWriter(string filename);

		// Token: 0x0600001A RID: 26
		global::TTSBridge.IAudioWriter createAudioWriter(global::System.IO.MemoryStream stream);
	}
}
