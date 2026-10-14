using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib
{
	// Token: 0x02000006 RID: 6
	[global::System.Serializable]
	public class ValueOutOfRangeException : global::ICSharpCode.SharpZipLib.StreamDecodingException
	{
		// Token: 0x06000011 RID: 17 RVA: 0x000020F3 File Offset: 0x000002F3
		public ValueOutOfRangeException(string nameOfValue) : base(nameOfValue + " out of range")
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002106 File Offset: 0x00000306
		public ValueOutOfRangeException(string nameOfValue, long value, long maxValue, long minValue = 0L) : this(nameOfValue, value.ToString(), maxValue.ToString(), minValue.ToString())
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002124 File Offset: 0x00000324
		public ValueOutOfRangeException(string nameOfValue, string value, string maxValue, string minValue = "0") : base(string.Concat(new string[]
		{
			nameOfValue,
			" out of range: ",
			value,
			", should be ",
			minValue,
			"..",
			maxValue
		}))
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002160 File Offset: 0x00000360
		private ValueOutOfRangeException()
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002168 File Offset: 0x00000368
		private ValueOutOfRangeException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002172 File Offset: 0x00000372
		protected ValueOutOfRangeException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
