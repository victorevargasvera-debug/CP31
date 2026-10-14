using System;

namespace Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository
{
	// Token: 0x02000053 RID: 83
	public interface ISampleGenerator<T> : global::System.IDisposable
	{
		// Token: 0x06000400 RID: 1024
		T GenerateAudioSample(string tts);
	}
}
