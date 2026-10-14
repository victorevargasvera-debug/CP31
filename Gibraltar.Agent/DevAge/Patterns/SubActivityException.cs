using System;

namespace DevAge.Patterns
{
	// Token: 0x0200027D RID: 637
	[global::System.Serializable]
	internal class SubActivityException : global::DevAge.DevAgeApplicationException
	{
		// Token: 0x0600207F RID: 8319 RVA: 0x0007413C File Offset: 0x0007233C
		public SubActivityException(string activityName, global::System.Exception innerException) : base("The activity " + activityName + " throwed an exception, " + innerException.Message, innerException)
		{
		}
	}
}
