using System;
using System.Runtime.Serialization;

namespace DevAge.Text.FixedLength
{
	// Token: 0x02000295 RID: 661
	[global::System.Serializable]
	internal class ValueNotSupportedException : global::DevAge.DevAgeApplicationException
	{
		// Token: 0x0600218C RID: 8588 RVA: 0x00077968 File Offset: 0x00075B68
		public ValueNotSupportedException(string value, global::System.Type type) : base("Value " + value + " not supported, type is " + type.Name)
		{
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x00077988 File Offset: 0x00075B88
		protected ValueNotSupportedException(global::System.Runtime.Serialization.SerializationInfo p_Info, global::System.Runtime.Serialization.StreamingContext p_StreamingContext) : base(p_Info, p_StreamingContext)
		{
		}
	}
}
