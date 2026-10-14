using System;
using System.IO;

namespace NPOI
{
	// Token: 0x02000002 RID: 2
	public class EmptyFileException : global::System.IO.IOException
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public EmptyFileException() : base("The supplied file was empty (zero bytes long)")
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000205D File Offset: 0x0000025D
		public EmptyFileException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x04000001 RID: 1
		private const long serialVersionUID = 1536449292174360166L;
	}
}
