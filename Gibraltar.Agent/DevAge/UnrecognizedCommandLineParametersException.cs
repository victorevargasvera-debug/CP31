using System;

namespace DevAge
{
	// Token: 0x020002B6 RID: 694
	[global::System.Serializable]
	internal class UnrecognizedCommandLineParametersException : global::DevAge.DevAgeApplicationException
	{
		// Token: 0x0600226C RID: 8812 RVA: 0x0007986C File Offset: 0x00077A6C
		public UnrecognizedCommandLineParametersException(string parameter) : base("Unrecognized command line parameter " + parameter + ".")
		{
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x00079884 File Offset: 0x00077A84
		public UnrecognizedCommandLineParametersException(string parameter, global::System.Exception p_InnerException) : base("Unrecognized command line parameter " + parameter + ".", p_InnerException)
		{
		}
	}
}
