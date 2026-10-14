using System;

namespace ACPVoiceAnnouncementLib
{
	// Token: 0x0200001F RID: 31
	public class WaveFileException : global::System.Exception
	{
		// Token: 0x06000071 RID: 113 RVA: 0x00009930 File Offset: 0x00007B30
		public WaveFileException(global::ACPVoiceAnnouncementLib.WaveFileExceptionCodes code)
		{
			this.ExceptionCode = code;
		}

		// Token: 0x04000087 RID: 135
		public readonly global::ACPVoiceAnnouncementLib.WaveFileExceptionCodes ExceptionCode;
	}
}
