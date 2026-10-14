using System;

namespace Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository
{
	// Token: 0x02000054 RID: 84
	internal interface ITTSAudioRepository<T> : global::System.IDisposable
	{
		// Token: 0x06000401 RID: 1025
		void AddOrReplaceAudio(string tts, T audioSample);

		// Token: 0x06000402 RID: 1026
		T GetAudio(string tts);

		// Token: 0x06000403 RID: 1027
		long GetCount();
	}
}
