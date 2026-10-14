using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Globalization;
using System.Text.RegularExpressions;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x0200030F RID: 783
	internal sealed class ScalarType : global::System.Data.Entity.Core.SchemaObjectModel.SchemaType
	{
		// Token: 0x06002518 RID: 9496 RVA: 0x00068806 File Offset: 0x00066A06
		internal ScalarType(global::System.Data.Entity.Core.SchemaObjectModel.Schema parentElement, string typeName, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType) : base(parentElement)
		{
			this.Name = typeName;
			this._primitiveType = primitiveType;
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x00068820 File Offset: 0x00066A20
		public bool TryParse(string text, out object value)
		{
			switch (this._primitiveType.PrimitiveTypeKind)
			{
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary:
				return global::System.Data.Entity.Core.SchemaObjectModel.ScalarType.TryParseBinary(text, out value);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean:
				return global::System.Data.Entity.Core.SchemaObjectModel.ScalarType.TryParseBoolean(text, out value);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte:
				return global::System.Data.Entity.Core.SchemaObjectModel.ScalarType.TryParseByte(text, out value);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime:
				return global::System.Data.Entity.Core.SchemaObjectModel.ScalarType.TryParseDateTime(text, out value);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal:
				return global::System.Data.Entity.Core.SchemaObjectModel.ScalarType.TryParseDecimal(text, out value);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double:
				return global::System.Data.Entity.Core.SchemaObjectModel.ScalarType.TryParseDouble(text, out value);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid:
				return global::System.Data.Entity.Core.SchemaObjectModel.ScalarType.TryParseGuid(text, out value);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single:
				return global::System.Data.Entity.Core.SchemaObjectModel.ScalarType.TryParseSingle(text, out value);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.SByte:
				return global::System.Data.Entity.Core.SchemaObjectModel.ScalarType.TryParseSByte(text, out value);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16:
				return global::System.Data.Entity.Core.SchemaObjectModel.ScalarType.TryParseInt16(text, out value);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32:
				return global::System.Data.Entity.Core.SchemaObjectModel.ScalarType.TryParseInt32(text, out value);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64:
				return global::System.Data.Entity.Core.SchemaObjectModel.ScalarType.TryParseInt64(text, out value);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String:
				return global::System.Data.Entity.Core.SchemaObjectModel.ScalarType.TryParseString(text, out value);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time:
				return global::System.Data.Entity.Core.SchemaObjectModel.ScalarType.TryParseTime(text, out value);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset:
				return global::System.Data.Entity.Core.SchemaObjectModel.ScalarType.TryParseDateTimeOffset(text, out value);
			default:
				throw new global::System.NotSupportedException(this._primitiveType.FullName);
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x0600251A RID: 9498 RVA: 0x00068905 File Offset: 0x00066B05
		public global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind TypeKind
		{
			get
			{
				return this._primitiveType.PrimitiveTypeKind;
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x0600251B RID: 9499 RVA: 0x00068912 File Offset: 0x00066B12
		public global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType Type
		{
			get
			{
				return this._primitiveType;
			}
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x0006891C File Offset: 0x00066B1C
		private static bool TryParseBoolean(string text, out object value)
		{
			bool flag;
			if (!bool.TryParse(text, out flag))
			{
				value = null;
				return false;
			}
			value = flag;
			return true;
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x00068944 File Offset: 0x00066B44
		private static bool TryParseByte(string text, out object value)
		{
			byte b;
			if (!byte.TryParse(text, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out b))
			{
				value = null;
				return false;
			}
			value = b;
			return true;
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x00068970 File Offset: 0x00066B70
		private static bool TryParseSByte(string text, out object value)
		{
			sbyte b;
			if (!sbyte.TryParse(text, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out b))
			{
				value = null;
				return false;
			}
			value = b;
			return true;
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x0006899C File Offset: 0x00066B9C
		private static bool TryParseInt16(string text, out object value)
		{
			short num;
			if (!short.TryParse(text, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out num))
			{
				value = null;
				return false;
			}
			value = num;
			return true;
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x000689C8 File Offset: 0x00066BC8
		private static bool TryParseInt32(string text, out object value)
		{
			int num;
			if (!int.TryParse(text, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out num))
			{
				value = null;
				return false;
			}
			value = num;
			return true;
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x000689F4 File Offset: 0x00066BF4
		private static bool TryParseInt64(string text, out object value)
		{
			long num;
			if (!long.TryParse(text, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out num))
			{
				value = null;
				return false;
			}
			value = num;
			return true;
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x00068A20 File Offset: 0x00066C20
		private static bool TryParseDouble(string text, out object value)
		{
			double num;
			if (!double.TryParse(text, global::System.Globalization.NumberStyles.Float, global::System.Globalization.CultureInfo.InvariantCulture, out num))
			{
				value = null;
				return false;
			}
			value = num;
			return true;
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x00068A50 File Offset: 0x00066C50
		private static bool TryParseDecimal(string text, out object value)
		{
			decimal num;
			if (!decimal.TryParse(text, global::System.Globalization.NumberStyles.Float, global::System.Globalization.CultureInfo.InvariantCulture, out num))
			{
				value = null;
				return false;
			}
			value = num;
			return true;
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x00068A80 File Offset: 0x00066C80
		private static bool TryParseDateTime(string text, out object value)
		{
			global::System.DateTime dateTime;
			if (!global::System.DateTime.TryParseExact(text, "yyyy-MM-dd HH\\:mm\\:ss.fffZ", global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal | global::System.Globalization.DateTimeStyles.AssumeUniversal, out dateTime))
			{
				value = null;
				return false;
			}
			value = dateTime;
			return true;
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x00068AB4 File Offset: 0x00066CB4
		private static bool TryParseTime(string text, out object value)
		{
			global::System.DateTime dateTime;
			if (!global::System.DateTime.TryParseExact(text, "HH\\:mm\\:ss.fffffffZ", global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.NoCurrentDateDefault | global::System.Globalization.DateTimeStyles.AdjustToUniversal | global::System.Globalization.DateTimeStyles.AssumeUniversal, out dateTime))
			{
				value = null;
				return false;
			}
			value = new global::System.TimeSpan(dateTime.Ticks);
			return true;
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x00068AF0 File Offset: 0x00066CF0
		private static bool TryParseDateTimeOffset(string text, out object value)
		{
			global::System.DateTimeOffset dateTimeOffset;
			if (!global::System.DateTimeOffset.TryParse(text, out dateTimeOffset))
			{
				value = null;
				return false;
			}
			value = dateTimeOffset;
			return true;
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x00068B15 File Offset: 0x00066D15
		private static bool TryParseGuid(string text, out object value)
		{
			if (!global::System.Data.Entity.Core.SchemaObjectModel.ScalarType._guidValueValidator.IsMatch(text))
			{
				value = null;
				return false;
			}
			value = new global::System.Guid(text);
			return true;
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x00068B37 File Offset: 0x00066D37
		private static bool TryParseString(string text, out object value)
		{
			value = text;
			return true;
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x00068B40 File Offset: 0x00066D40
		private static bool TryParseBinary(string text, out object value)
		{
			if (!global::System.Data.Entity.Core.SchemaObjectModel.ScalarType._binaryValueValidator.IsMatch(text))
			{
				value = null;
				return false;
			}
			string text2 = text.Substring(2);
			value = global::System.Data.Entity.Core.SchemaObjectModel.ScalarType.ConvertToByteArray(text2);
			return true;
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x00068B70 File Offset: 0x00066D70
		internal static byte[] ConvertToByteArray(string text)
		{
			int num = 2;
			int num2 = text.Length / 2;
			if (text.Length % 2 == 1)
			{
				num = 1;
				num2++;
			}
			byte[] array = new byte[num2];
			int i = 0;
			int num3 = 0;
			while (i < text.Length)
			{
				array[num3] = byte.Parse(text.Substring(i, num), global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
				i += num;
				num = 2;
				num3++;
			}
			return array;
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x00068BD8 File Offset: 0x00066DD8
		private static bool TryParseSingle(string text, out object value)
		{
			float num;
			if (!float.TryParse(text, global::System.Globalization.NumberStyles.Float, global::System.Globalization.CultureInfo.InvariantCulture, out num))
			{
				value = null;
				return false;
			}
			value = num;
			return true;
		}

		// Token: 0x04000D19 RID: 3353
		internal const string DateTimeFormat = "yyyy-MM-dd HH\\:mm\\:ss.fffZ";

		// Token: 0x04000D1A RID: 3354
		internal const string TimeFormat = "HH\\:mm\\:ss.fffffffZ";

		// Token: 0x04000D1B RID: 3355
		internal const string DateTimeOffsetFormat = "yyyy-MM-dd HH\\:mm\\:ss.fffffffz";

		// Token: 0x04000D1C RID: 3356
		private static readonly global::System.Text.RegularExpressions.Regex _binaryValueValidator = new global::System.Text.RegularExpressions.Regex("^0[xX][0-9a-fA-F]+$", global::System.Text.RegularExpressions.RegexOptions.Compiled);

		// Token: 0x04000D1D RID: 3357
		private static readonly global::System.Text.RegularExpressions.Regex _guidValueValidator = new global::System.Text.RegularExpressions.Regex("[0-9a-fA-F]{8,8}(-[0-9a-fA-F]{4,4}){3,3}-[0-9a-fA-F]{12,12}", global::System.Text.RegularExpressions.RegexOptions.Compiled);

		// Token: 0x04000D1E RID: 3358
		private readonly global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType _primitiveType;
	}
}
