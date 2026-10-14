using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x02000042 RID: 66
	[global::System.Serializable]
	public class InvalidHeaderException : global::ICSharpCode.SharpZipLib.Tar.TarException
	{
		// Token: 0x060002D6 RID: 726 RVA: 0x0000E91A File Offset: 0x0000CB1A
		public InvalidHeaderException()
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000E922 File Offset: 0x0000CB22
		public InvalidHeaderException(string message) : base(message)
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000E92B File Offset: 0x0000CB2B
		public InvalidHeaderException(string message, global::System.Exception exception) : base(message, exception)
		{
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000E935 File Offset: 0x0000CB35
		protected InvalidHeaderException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
