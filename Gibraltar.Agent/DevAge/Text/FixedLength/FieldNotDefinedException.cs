using System;
using System.Runtime.Serialization;

namespace DevAge.Text.FixedLength
{
	// Token: 0x0200029A RID: 666
	[global::System.Serializable]
	internal class FieldNotDefinedException : global::DevAge.DevAgeApplicationException
	{
		// Token: 0x06002197 RID: 8599 RVA: 0x00077B18 File Offset: 0x00075D18
		public FieldNotDefinedException(int fieldIndex) : base("Field " + fieldIndex.ToString() + " not defined.")
		{
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x00077B38 File Offset: 0x00075D38
		protected FieldNotDefinedException(global::System.Runtime.Serialization.SerializationInfo p_Info, global::System.Runtime.Serialization.StreamingContext p_StreamingContext) : base(p_Info, p_StreamingContext)
		{
		}
	}
}
