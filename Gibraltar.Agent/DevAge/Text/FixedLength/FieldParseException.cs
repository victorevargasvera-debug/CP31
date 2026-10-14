using System;
using System.Runtime.Serialization;

namespace DevAge.Text.FixedLength
{
	// Token: 0x02000298 RID: 664
	[global::System.Serializable]
	internal class FieldParseException : global::DevAge.DevAgeApplicationException
	{
		// Token: 0x06002192 RID: 8594 RVA: 0x000779E4 File Offset: 0x00075BE4
		public FieldParseException(string name, string valToParse, global::System.Exception innerException) : base(string.Concat(new string[]
		{
			"Failed to parse field ",
			name,
			" '",
			valToParse,
			"' - ",
			innerException.Message
		}), innerException)
		{
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x00077A4C File Offset: 0x00075C4C
		protected FieldParseException(global::System.Runtime.Serialization.SerializationInfo p_Info, global::System.Runtime.Serialization.StreamingContext p_StreamingContext) : base(p_Info, p_StreamingContext)
		{
		}
	}
}
