using System;
using System.Runtime.Serialization;

namespace DevAge.Text.FixedLength
{
	// Token: 0x02000297 RID: 663
	[global::System.Serializable]
	internal class RegExException : global::DevAge.DevAgeApplicationException
	{
		// Token: 0x06002190 RID: 8592 RVA: 0x000779C0 File Offset: 0x00075BC0
		public RegExException(string group) : base("Regular expression group " + group + " not valid")
		{
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x000779D8 File Offset: 0x00075BD8
		protected RegExException(global::System.Runtime.Serialization.SerializationInfo p_Info, global::System.Runtime.Serialization.StreamingContext p_StreamingContext) : base(p_Info, p_StreamingContext)
		{
		}
	}
}
