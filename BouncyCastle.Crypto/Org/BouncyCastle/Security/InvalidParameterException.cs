using System;

namespace Org.BouncyCastle.Security
{
	// Token: 0x020001C7 RID: 455
	[global::System.Serializable]
	public class InvalidParameterException : global::Org.BouncyCastle.Security.KeyException
	{
		// Token: 0x060010FE RID: 4350 RVA: 0x00047D92 File Offset: 0x00045F92
		public InvalidParameterException()
		{
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x00047D9A File Offset: 0x00045F9A
		public InvalidParameterException(string message) : base(message)
		{
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x00047DA3 File Offset: 0x00045FA3
		public InvalidParameterException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
