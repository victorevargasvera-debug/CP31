using System;
using System.Globalization;
using System.IO;
using System.Text;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000104 RID: 260
	internal class BsonBinaryWriter
	{
		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x000353FF File Offset: 0x000335FF
		// (set) Token: 0x06000D54 RID: 3412 RVA: 0x00035407 File Offset: 0x00033607
		public global::System.DateTimeKind DateTimeKindHandling { get; set; }

		// Token: 0x06000D55 RID: 3413 RVA: 0x00035410 File Offset: 0x00033610
		public BsonBinaryWriter(global::System.IO.BinaryWriter writer)
		{
			this.DateTimeKindHandling = global::System.DateTimeKind.Utc;
			this._writer = writer;
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x00035426 File Offset: 0x00033626
		public void Flush()
		{
			this._writer.Flush();
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00035433 File Offset: 0x00033633
		public void Close()
		{
			this._writer.Close();
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00035440 File Offset: 0x00033640
		public void WriteToken(global::Newtonsoft.Json.Bson.BsonToken t)
		{
			this.CalculateSize(t);
			this.WriteTokenInternal(t);
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00035454 File Offset: 0x00033654
		private void WriteTokenInternal(global::Newtonsoft.Json.Bson.BsonToken t)
		{
			switch (t.Type)
			{
			case global::Newtonsoft.Json.Bson.BsonType.Number:
			{
				global::Newtonsoft.Json.Bson.BsonValue bsonValue = (global::Newtonsoft.Json.Bson.BsonValue)t;
				this._writer.Write(global::System.Convert.ToDouble(bsonValue.Value, global::System.Globalization.CultureInfo.InvariantCulture));
				return;
			}
			case global::Newtonsoft.Json.Bson.BsonType.String:
			{
				global::Newtonsoft.Json.Bson.BsonString bsonString = (global::Newtonsoft.Json.Bson.BsonString)t;
				this.WriteString((string)bsonString.Value, bsonString.ByteCount, new int?(bsonString.CalculatedSize - 4));
				return;
			}
			case global::Newtonsoft.Json.Bson.BsonType.Object:
			{
				global::Newtonsoft.Json.Bson.BsonObject bsonObject = (global::Newtonsoft.Json.Bson.BsonObject)t;
				this._writer.Write(bsonObject.CalculatedSize);
				foreach (global::Newtonsoft.Json.Bson.BsonProperty bsonProperty in bsonObject)
				{
					this._writer.Write((sbyte)bsonProperty.Value.Type);
					this.WriteString((string)bsonProperty.Name.Value, bsonProperty.Name.ByteCount, null);
					this.WriteTokenInternal(bsonProperty.Value);
				}
				this._writer.Write(0);
				return;
			}
			case global::Newtonsoft.Json.Bson.BsonType.Array:
			{
				global::Newtonsoft.Json.Bson.BsonArray bsonArray = (global::Newtonsoft.Json.Bson.BsonArray)t;
				this._writer.Write(bsonArray.CalculatedSize);
				ulong num = 0UL;
				foreach (global::Newtonsoft.Json.Bson.BsonToken bsonToken in bsonArray)
				{
					this._writer.Write((sbyte)bsonToken.Type);
					this.WriteString(num.ToString(global::System.Globalization.CultureInfo.InvariantCulture), global::Newtonsoft.Json.Utilities.MathUtils.IntLength(num), null);
					this.WriteTokenInternal(bsonToken);
					num += 1UL;
				}
				this._writer.Write(0);
				return;
			}
			case global::Newtonsoft.Json.Bson.BsonType.Binary:
			{
				global::Newtonsoft.Json.Bson.BsonBinary bsonBinary = (global::Newtonsoft.Json.Bson.BsonBinary)t;
				byte[] array = (byte[])bsonBinary.Value;
				this._writer.Write(array.Length);
				this._writer.Write((byte)bsonBinary.BinaryType);
				this._writer.Write(array);
				return;
			}
			case global::Newtonsoft.Json.Bson.BsonType.Undefined:
			case global::Newtonsoft.Json.Bson.BsonType.Null:
				return;
			case global::Newtonsoft.Json.Bson.BsonType.Oid:
			{
				byte[] buffer = (byte[])((global::Newtonsoft.Json.Bson.BsonValue)t).Value;
				this._writer.Write(buffer);
				return;
			}
			case global::Newtonsoft.Json.Bson.BsonType.Boolean:
				this._writer.Write(t == global::Newtonsoft.Json.Bson.BsonBoolean.True);
				return;
			case global::Newtonsoft.Json.Bson.BsonType.Date:
			{
				global::Newtonsoft.Json.Bson.BsonValue bsonValue2 = (global::Newtonsoft.Json.Bson.BsonValue)t;
				object value = bsonValue2.Value;
				long value2;
				if (value is global::System.DateTime)
				{
					global::System.DateTime dateTime = (global::System.DateTime)value;
					if (this.DateTimeKindHandling == global::System.DateTimeKind.Utc)
					{
						dateTime = dateTime.ToUniversalTime();
					}
					else if (this.DateTimeKindHandling == global::System.DateTimeKind.Local)
					{
						dateTime = dateTime.ToLocalTime();
					}
					value2 = global::Newtonsoft.Json.Utilities.DateTimeUtils.ConvertDateTimeToJavaScriptTicks(dateTime, false);
				}
				else
				{
					global::System.DateTimeOffset dateTimeOffset = (global::System.DateTimeOffset)bsonValue2.Value;
					value2 = global::Newtonsoft.Json.Utilities.DateTimeUtils.ConvertDateTimeToJavaScriptTicks(dateTimeOffset.UtcDateTime, dateTimeOffset.Offset);
				}
				this._writer.Write(value2);
				return;
			}
			case global::Newtonsoft.Json.Bson.BsonType.Regex:
			{
				global::Newtonsoft.Json.Bson.BsonRegex bsonRegex = (global::Newtonsoft.Json.Bson.BsonRegex)t;
				this.WriteString((string)bsonRegex.Pattern.Value, bsonRegex.Pattern.ByteCount, null);
				this.WriteString((string)bsonRegex.Options.Value, bsonRegex.Options.ByteCount, null);
				return;
			}
			case global::Newtonsoft.Json.Bson.BsonType.Integer:
			{
				global::Newtonsoft.Json.Bson.BsonValue bsonValue3 = (global::Newtonsoft.Json.Bson.BsonValue)t;
				this._writer.Write(global::System.Convert.ToInt32(bsonValue3.Value, global::System.Globalization.CultureInfo.InvariantCulture));
				return;
			}
			case global::Newtonsoft.Json.Bson.BsonType.Long:
			{
				global::Newtonsoft.Json.Bson.BsonValue bsonValue4 = (global::Newtonsoft.Json.Bson.BsonValue)t;
				this._writer.Write(global::System.Convert.ToInt64(bsonValue4.Value, global::System.Globalization.CultureInfo.InvariantCulture));
				return;
			}
			}
			throw new global::System.ArgumentOutOfRangeException("t", "Unexpected token when writing BSON: {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, t.Type));
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00035834 File Offset: 0x00033A34
		private void WriteString(string s, int byteCount, int? calculatedlengthPrefix)
		{
			if (calculatedlengthPrefix != null)
			{
				this._writer.Write(calculatedlengthPrefix.GetValueOrDefault());
			}
			this.WriteUtf8Bytes(s, byteCount);
			this._writer.Write(0);
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00035868 File Offset: 0x00033A68
		public void WriteUtf8Bytes(string s, int byteCount)
		{
			if (s != null)
			{
				if (byteCount <= 256)
				{
					if (this._largeByteBuffer == null)
					{
						this._largeByteBuffer = new byte[256];
					}
					global::Newtonsoft.Json.Bson.BsonBinaryWriter.Encoding.GetBytes(s, 0, s.Length, this._largeByteBuffer, 0);
					this._writer.Write(this._largeByteBuffer, 0, byteCount);
					return;
				}
				byte[] bytes = global::Newtonsoft.Json.Bson.BsonBinaryWriter.Encoding.GetBytes(s);
				this._writer.Write(bytes);
			}
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x000358DE File Offset: 0x00033ADE
		private int CalculateSize(int stringByteCount)
		{
			return stringByteCount + 1;
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x000358E3 File Offset: 0x00033AE3
		private int CalculateSizeWithLength(int stringByteCount, bool includeSize)
		{
			return (includeSize ? 5 : 1) + stringByteCount;
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x000358F0 File Offset: 0x00033AF0
		private int CalculateSize(global::Newtonsoft.Json.Bson.BsonToken t)
		{
			switch (t.Type)
			{
			case global::Newtonsoft.Json.Bson.BsonType.Number:
				return 8;
			case global::Newtonsoft.Json.Bson.BsonType.String:
			{
				global::Newtonsoft.Json.Bson.BsonString bsonString = (global::Newtonsoft.Json.Bson.BsonString)t;
				string text = (string)bsonString.Value;
				bsonString.ByteCount = ((text != null) ? global::Newtonsoft.Json.Bson.BsonBinaryWriter.Encoding.GetByteCount(text) : 0);
				bsonString.CalculatedSize = this.CalculateSizeWithLength(bsonString.ByteCount, bsonString.IncludeLength);
				return bsonString.CalculatedSize;
			}
			case global::Newtonsoft.Json.Bson.BsonType.Object:
			{
				global::Newtonsoft.Json.Bson.BsonObject bsonObject = (global::Newtonsoft.Json.Bson.BsonObject)t;
				int num = 4;
				foreach (global::Newtonsoft.Json.Bson.BsonProperty bsonProperty in bsonObject)
				{
					int num2 = 1;
					num2 += this.CalculateSize(bsonProperty.Name);
					num2 += this.CalculateSize(bsonProperty.Value);
					num += num2;
				}
				num++;
				bsonObject.CalculatedSize = num;
				return num;
			}
			case global::Newtonsoft.Json.Bson.BsonType.Array:
			{
				global::Newtonsoft.Json.Bson.BsonArray bsonArray = (global::Newtonsoft.Json.Bson.BsonArray)t;
				int num3 = 4;
				ulong num4 = 0UL;
				foreach (global::Newtonsoft.Json.Bson.BsonToken t2 in bsonArray)
				{
					num3++;
					num3 += this.CalculateSize(global::Newtonsoft.Json.Utilities.MathUtils.IntLength(num4));
					num3 += this.CalculateSize(t2);
					num4 += 1UL;
				}
				num3++;
				bsonArray.CalculatedSize = num3;
				return bsonArray.CalculatedSize;
			}
			case global::Newtonsoft.Json.Bson.BsonType.Binary:
			{
				global::Newtonsoft.Json.Bson.BsonBinary bsonBinary = (global::Newtonsoft.Json.Bson.BsonBinary)t;
				byte[] array = (byte[])bsonBinary.Value;
				bsonBinary.CalculatedSize = 5 + array.Length;
				return bsonBinary.CalculatedSize;
			}
			case global::Newtonsoft.Json.Bson.BsonType.Undefined:
			case global::Newtonsoft.Json.Bson.BsonType.Null:
				return 0;
			case global::Newtonsoft.Json.Bson.BsonType.Oid:
				return 12;
			case global::Newtonsoft.Json.Bson.BsonType.Boolean:
				return 1;
			case global::Newtonsoft.Json.Bson.BsonType.Date:
				return 8;
			case global::Newtonsoft.Json.Bson.BsonType.Regex:
			{
				global::Newtonsoft.Json.Bson.BsonRegex bsonRegex = (global::Newtonsoft.Json.Bson.BsonRegex)t;
				int num5 = 0;
				num5 += this.CalculateSize(bsonRegex.Pattern);
				num5 += this.CalculateSize(bsonRegex.Options);
				bsonRegex.CalculatedSize = num5;
				return bsonRegex.CalculatedSize;
			}
			case global::Newtonsoft.Json.Bson.BsonType.Integer:
				return 4;
			case global::Newtonsoft.Json.Bson.BsonType.Long:
				return 8;
			}
			throw new global::System.ArgumentOutOfRangeException("t", "Unexpected token when writing BSON: {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, t.Type));
		}

		// Token: 0x04000408 RID: 1032
		private static readonly global::System.Text.Encoding Encoding = new global::System.Text.UTF8Encoding(false);

		// Token: 0x04000409 RID: 1033
		private readonly global::System.IO.BinaryWriter _writer;

		// Token: 0x0400040A RID: 1034
		private byte[] _largeByteBuffer;
	}
}
