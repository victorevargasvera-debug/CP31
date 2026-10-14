using System;

namespace ACPVoiceAnnouncementLib
{
	// Token: 0x02000017 RID: 23
	public class MotVoiceFileException : global::System.Exception
	{
		// Token: 0x06000040 RID: 64 RVA: 0x0000618C File Offset: 0x0000438C
		internal MotVoiceFileException(string A_0, global::ACPVoiceAnnouncementLib.MotVoiceAnnouncmentFileExceptionCodes A_1) : base(A_0)
		{
			this.ExceptionCode = A_1;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000061A8 File Offset: 0x000043A8
		internal MotVoiceFileException(string A_0, global::ACPVoiceAnnouncementLib.MotVoiceAnnouncmentFileExceptionCodes A_1, global::System.Exception A_2) : base(A_0, A_2)
		{
			this.ExceptionCode = A_1;
		}

		// Token: 0x04000045 RID: 69
		public readonly global::ACPVoiceAnnouncementLib.MotVoiceAnnouncmentFileExceptionCodes ExceptionCode;
	}
}
