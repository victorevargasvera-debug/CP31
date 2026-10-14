using System;
using System.Runtime.Serialization;

namespace DevAge.Text.FixedLength
{
	// Token: 0x02000299 RID: 665
	[global::System.Serializable]
	internal class FieldStringConvertException : global::DevAge.DevAgeApplicationException
	{
		// Token: 0x06002194 RID: 8596 RVA: 0x00077A58 File Offset: 0x00075C58
		public FieldStringConvertException(string name, object value, global::System.Exception innerException) : base(string.Concat(new string[]
		{
			"Failed to convert to string field ",
			name,
			" '",
			global::DevAge.Text.FixedLength.FieldStringConvertException.ObjectToStringForError(value),
			"' - ",
			innerException.Message
		}), innerException)
		{
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x00077AC4 File Offset: 0x00075CC4
		protected FieldStringConvertException(global::System.Runtime.Serialization.SerializationInfo p_Info, global::System.Runtime.Serialization.StreamingContext p_StreamingContext) : base(p_Info, p_StreamingContext)
		{
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x00077AD0 File Offset: 0x00075CD0
		private static string ObjectToStringForError(object val)
		{
			string result;
			try
			{
				if (val == null)
				{
					result = "<null>";
				}
				else
				{
					result = val.ToString();
				}
			}
			catch (global::System.Exception)
			{
				result = "<object>";
			}
			return result;
		}
	}
}
