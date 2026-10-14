using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000CA RID: 202
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class JValue : global::Newtonsoft.Json.Linq.JToken, global::System.IEquatable<global::Newtonsoft.Json.Linq.JValue>, global::System.IFormattable, global::System.IComparable, global::System.IComparable<global::Newtonsoft.Json.Linq.JValue>, global::System.IConvertible
	{
		// Token: 0x06000B9E RID: 2974 RVA: 0x0002DCD8 File Offset: 0x0002BED8
		public override global::System.Threading.Tasks.Task WriteToAsync(global::Newtonsoft.Json.JsonWriter writer, global::System.Threading.CancellationToken cancellationToken, params global::Newtonsoft.Json.JsonConverter[] converters)
		{
			if (converters != null && converters.Length != 0 && this._value != null)
			{
				global::Newtonsoft.Json.JsonConverter matchingConverter = global::Newtonsoft.Json.JsonSerializer.GetMatchingConverter(converters, this._value.GetType());
				if (matchingConverter != null && matchingConverter.CanWrite)
				{
					matchingConverter.WriteJson(writer, this._value, global::Newtonsoft.Json.JsonSerializer.CreateDefault());
					return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
				}
			}
			switch (this._valueType)
			{
			case global::Newtonsoft.Json.Linq.JTokenType.Comment:
			{
				object value = this._value;
				return writer.WriteCommentAsync((value != null) ? value.ToString() : null, cancellationToken);
			}
			case global::Newtonsoft.Json.Linq.JTokenType.Integer:
			{
				object value2 = this._value;
				if (value2 is int)
				{
					int value3 = (int)value2;
					return writer.WriteValueAsync(value3, cancellationToken);
				}
				value2 = this._value;
				if (value2 is long)
				{
					long value4 = (long)value2;
					return writer.WriteValueAsync(value4, cancellationToken);
				}
				value2 = this._value;
				if (value2 is ulong)
				{
					ulong value5 = (ulong)value2;
					return writer.WriteValueAsync(value5, cancellationToken);
				}
				value2 = this._value;
				if (value2 is global::System.Numerics.BigInteger)
				{
					global::System.Numerics.BigInteger bigInteger = (global::System.Numerics.BigInteger)value2;
					return writer.WriteValueAsync(bigInteger, cancellationToken);
				}
				return writer.WriteValueAsync(global::System.Convert.ToInt64(this._value, global::System.Globalization.CultureInfo.InvariantCulture), cancellationToken);
			}
			case global::Newtonsoft.Json.Linq.JTokenType.Float:
			{
				object value2 = this._value;
				if (value2 is decimal)
				{
					decimal value6 = (decimal)value2;
					return writer.WriteValueAsync(value6, cancellationToken);
				}
				value2 = this._value;
				if (value2 is double)
				{
					double value7 = (double)value2;
					return writer.WriteValueAsync(value7, cancellationToken);
				}
				value2 = this._value;
				if (value2 is float)
				{
					float value8 = (float)value2;
					return writer.WriteValueAsync(value8, cancellationToken);
				}
				return writer.WriteValueAsync(global::System.Convert.ToDouble(this._value, global::System.Globalization.CultureInfo.InvariantCulture), cancellationToken);
			}
			case global::Newtonsoft.Json.Linq.JTokenType.String:
			{
				object value9 = this._value;
				return writer.WriteValueAsync((value9 != null) ? value9.ToString() : null, cancellationToken);
			}
			case global::Newtonsoft.Json.Linq.JTokenType.Boolean:
				return writer.WriteValueAsync(global::System.Convert.ToBoolean(this._value, global::System.Globalization.CultureInfo.InvariantCulture), cancellationToken);
			case global::Newtonsoft.Json.Linq.JTokenType.Null:
				return writer.WriteNullAsync(cancellationToken);
			case global::Newtonsoft.Json.Linq.JTokenType.Undefined:
				return writer.WriteUndefinedAsync(cancellationToken);
			case global::Newtonsoft.Json.Linq.JTokenType.Date:
			{
				object value2 = this._value;
				if (value2 is global::System.DateTimeOffset)
				{
					global::System.DateTimeOffset value10 = (global::System.DateTimeOffset)value2;
					return writer.WriteValueAsync(value10, cancellationToken);
				}
				return writer.WriteValueAsync(global::System.Convert.ToDateTime(this._value, global::System.Globalization.CultureInfo.InvariantCulture), cancellationToken);
			}
			case global::Newtonsoft.Json.Linq.JTokenType.Raw:
			{
				object value11 = this._value;
				return writer.WriteRawValueAsync((value11 != null) ? value11.ToString() : null, cancellationToken);
			}
			case global::Newtonsoft.Json.Linq.JTokenType.Bytes:
				return writer.WriteValueAsync((byte[])this._value, cancellationToken);
			case global::Newtonsoft.Json.Linq.JTokenType.Guid:
				return writer.WriteValueAsync((this._value != null) ? ((global::System.Guid?)this._value) : null, cancellationToken);
			case global::Newtonsoft.Json.Linq.JTokenType.Uri:
				return writer.WriteValueAsync((global::System.Uri)this._value, cancellationToken);
			case global::Newtonsoft.Json.Linq.JTokenType.TimeSpan:
				return writer.WriteValueAsync((this._value != null) ? ((global::System.TimeSpan?)this._value) : null, cancellationToken);
			default:
				throw global::Newtonsoft.Json.Utilities.MiscellaneousUtils.CreateArgumentOutOfRangeException("Type", this._valueType, "Unexpected token type.");
			}
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0002DFDE File Offset: 0x0002C1DE
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		internal JValue(object value, global::Newtonsoft.Json.Linq.JTokenType type)
		{
			this._value = value;
			this._valueType = type;
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0002DFF4 File Offset: 0x0002C1F4
		public JValue(global::Newtonsoft.Json.Linq.JValue other) : this(other.Value, other.Type)
		{
			base.CopyAnnotations(this, other);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0002E010 File Offset: 0x0002C210
		public JValue(long value) : this(value, global::Newtonsoft.Json.Linq.JTokenType.Integer)
		{
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x0002E01F File Offset: 0x0002C21F
		public JValue(decimal value) : this(value, global::Newtonsoft.Json.Linq.JTokenType.Float)
		{
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x0002E02E File Offset: 0x0002C22E
		public JValue(char value) : this(value, global::Newtonsoft.Json.Linq.JTokenType.String)
		{
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0002E03D File Offset: 0x0002C23D
		[global::System.CLSCompliant(false)]
		public JValue(ulong value) : this(value, global::Newtonsoft.Json.Linq.JTokenType.Integer)
		{
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0002E04C File Offset: 0x0002C24C
		public JValue(double value) : this(value, global::Newtonsoft.Json.Linq.JTokenType.Float)
		{
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x0002E05B File Offset: 0x0002C25B
		public JValue(float value) : this(value, global::Newtonsoft.Json.Linq.JTokenType.Float)
		{
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0002E06A File Offset: 0x0002C26A
		public JValue(global::System.DateTime value) : this(value, global::Newtonsoft.Json.Linq.JTokenType.Date)
		{
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x0002E07A File Offset: 0x0002C27A
		public JValue(global::System.DateTimeOffset value) : this(value, global::Newtonsoft.Json.Linq.JTokenType.Date)
		{
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x0002E08A File Offset: 0x0002C28A
		public JValue(bool value) : this(value, global::Newtonsoft.Json.Linq.JTokenType.Boolean)
		{
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0002E09A File Offset: 0x0002C29A
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public JValue(string value) : this(value, global::Newtonsoft.Json.Linq.JTokenType.String)
		{
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x0002E0A4 File Offset: 0x0002C2A4
		public JValue(global::System.Guid value) : this(value, global::Newtonsoft.Json.Linq.JTokenType.Guid)
		{
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x0002E0B4 File Offset: 0x0002C2B4
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public JValue(global::System.Uri value) : this(value, (value != null) ? global::Newtonsoft.Json.Linq.JTokenType.Uri : global::Newtonsoft.Json.Linq.JTokenType.Null)
		{
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0002E0CC File Offset: 0x0002C2CC
		public JValue(global::System.TimeSpan value) : this(value, global::Newtonsoft.Json.Linq.JTokenType.TimeSpan)
		{
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0002E0DC File Offset: 0x0002C2DC
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public JValue(object value) : this(value, global::Newtonsoft.Json.Linq.JValue.GetValueType(null, value))
		{
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0002E100 File Offset: 0x0002C300
		internal override bool DeepEquals(global::Newtonsoft.Json.Linq.JToken node)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = node as global::Newtonsoft.Json.Linq.JValue;
			return jvalue != null && (jvalue == this || global::Newtonsoft.Json.Linq.JValue.ValuesEquals(this, jvalue));
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x0002E126 File Offset: 0x0002C326
		public override bool HasValues
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0002E12C File Offset: 0x0002C32C
		private static int CompareBigInteger(global::System.Numerics.BigInteger i1, object i2)
		{
			int num = i1.CompareTo(global::Newtonsoft.Json.Utilities.ConvertUtils.ToBigInteger(i2));
			if (num != 0)
			{
				return num;
			}
			if (i2 is decimal)
			{
				decimal num2 = (decimal)i2;
				return 0m.CompareTo(global::System.Math.Abs(num2 - global::System.Math.Truncate(num2)));
			}
			if (i2 is double || i2 is float)
			{
				double num3 = global::System.Convert.ToDouble(i2, global::System.Globalization.CultureInfo.InvariantCulture);
				return 0.0.CompareTo(global::System.Math.Abs(num3 - global::System.Math.Truncate(num3)));
			}
			return num;
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0002E1B8 File Offset: 0x0002C3B8
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		internal static int Compare(global::Newtonsoft.Json.Linq.JTokenType valueType, object objA, object objB)
		{
			if (objA == objB)
			{
				return 0;
			}
			if (objB == null)
			{
				return 1;
			}
			if (objA == null)
			{
				return -1;
			}
			switch (valueType)
			{
			case global::Newtonsoft.Json.Linq.JTokenType.Comment:
			case global::Newtonsoft.Json.Linq.JTokenType.String:
			case global::Newtonsoft.Json.Linq.JTokenType.Raw:
			{
				string strA = global::System.Convert.ToString(objA, global::System.Globalization.CultureInfo.InvariantCulture);
				string strB = global::System.Convert.ToString(objB, global::System.Globalization.CultureInfo.InvariantCulture);
				return string.CompareOrdinal(strA, strB);
			}
			case global::Newtonsoft.Json.Linq.JTokenType.Integer:
				if (objA is global::System.Numerics.BigInteger)
				{
					global::System.Numerics.BigInteger i = (global::System.Numerics.BigInteger)objA;
					return global::Newtonsoft.Json.Linq.JValue.CompareBigInteger(i, objB);
				}
				if (objB is global::System.Numerics.BigInteger)
				{
					global::System.Numerics.BigInteger i2 = (global::System.Numerics.BigInteger)objB;
					return -global::Newtonsoft.Json.Linq.JValue.CompareBigInteger(i2, objA);
				}
				if (objA is ulong || objB is ulong || objA is decimal || objB is decimal)
				{
					return global::System.Convert.ToDecimal(objA, global::System.Globalization.CultureInfo.InvariantCulture).CompareTo(global::System.Convert.ToDecimal(objB, global::System.Globalization.CultureInfo.InvariantCulture));
				}
				if (objA is float || objB is float || objA is double || objB is double)
				{
					return global::Newtonsoft.Json.Linq.JValue.CompareFloat(objA, objB);
				}
				return global::System.Convert.ToInt64(objA, global::System.Globalization.CultureInfo.InvariantCulture).CompareTo(global::System.Convert.ToInt64(objB, global::System.Globalization.CultureInfo.InvariantCulture));
			case global::Newtonsoft.Json.Linq.JTokenType.Float:
				if (objA is global::System.Numerics.BigInteger)
				{
					global::System.Numerics.BigInteger i3 = (global::System.Numerics.BigInteger)objA;
					return global::Newtonsoft.Json.Linq.JValue.CompareBigInteger(i3, objB);
				}
				if (objB is global::System.Numerics.BigInteger)
				{
					global::System.Numerics.BigInteger i4 = (global::System.Numerics.BigInteger)objB;
					return -global::Newtonsoft.Json.Linq.JValue.CompareBigInteger(i4, objA);
				}
				if (objA is ulong || objB is ulong || objA is decimal || objB is decimal)
				{
					return global::System.Convert.ToDecimal(objA, global::System.Globalization.CultureInfo.InvariantCulture).CompareTo(global::System.Convert.ToDecimal(objB, global::System.Globalization.CultureInfo.InvariantCulture));
				}
				return global::Newtonsoft.Json.Linq.JValue.CompareFloat(objA, objB);
			case global::Newtonsoft.Json.Linq.JTokenType.Boolean:
			{
				bool flag = global::System.Convert.ToBoolean(objA, global::System.Globalization.CultureInfo.InvariantCulture);
				bool value = global::System.Convert.ToBoolean(objB, global::System.Globalization.CultureInfo.InvariantCulture);
				return flag.CompareTo(value);
			}
			case global::Newtonsoft.Json.Linq.JTokenType.Date:
			{
				if (objA is global::System.DateTime)
				{
					global::System.DateTime dateTime = (global::System.DateTime)objA;
					global::System.DateTime value2;
					if (objB is global::System.DateTimeOffset)
					{
						value2 = ((global::System.DateTimeOffset)objB).DateTime;
					}
					else
					{
						value2 = global::System.Convert.ToDateTime(objB, global::System.Globalization.CultureInfo.InvariantCulture);
					}
					return dateTime.CompareTo(value2);
				}
				global::System.DateTimeOffset dateTimeOffset = (global::System.DateTimeOffset)objA;
				global::System.DateTimeOffset other;
				if (objB is global::System.DateTimeOffset)
				{
					other = (global::System.DateTimeOffset)objB;
				}
				else
				{
					other = new global::System.DateTimeOffset(global::System.Convert.ToDateTime(objB, global::System.Globalization.CultureInfo.InvariantCulture));
				}
				return dateTimeOffset.CompareTo(other);
			}
			case global::Newtonsoft.Json.Linq.JTokenType.Bytes:
			{
				byte[] array = objB as byte[];
				if (array == null)
				{
					throw new global::System.ArgumentException("Object must be of type byte[].");
				}
				return global::Newtonsoft.Json.Utilities.MiscellaneousUtils.ByteArrayCompare(objA as byte[], array);
			}
			case global::Newtonsoft.Json.Linq.JTokenType.Guid:
			{
				if (!(objB is global::System.Guid))
				{
					throw new global::System.ArgumentException("Object must be of type Guid.");
				}
				global::System.Guid guid = (global::System.Guid)objA;
				global::System.Guid value3 = (global::System.Guid)objB;
				return guid.CompareTo(value3);
			}
			case global::Newtonsoft.Json.Linq.JTokenType.Uri:
			{
				global::System.Uri uri = objB as global::System.Uri;
				if (uri == null)
				{
					throw new global::System.ArgumentException("Object must be of type Uri.");
				}
				global::System.Uri uri2 = (global::System.Uri)objA;
				return global::System.Collections.Generic.Comparer<string>.Default.Compare(uri2.ToString(), uri.ToString());
			}
			case global::Newtonsoft.Json.Linq.JTokenType.TimeSpan:
			{
				if (!(objB is global::System.TimeSpan))
				{
					throw new global::System.ArgumentException("Object must be of type TimeSpan.");
				}
				global::System.TimeSpan timeSpan = (global::System.TimeSpan)objA;
				global::System.TimeSpan value4 = (global::System.TimeSpan)objB;
				return timeSpan.CompareTo(value4);
			}
			}
			throw global::Newtonsoft.Json.Utilities.MiscellaneousUtils.CreateArgumentOutOfRangeException("valueType", valueType, "Unexpected value type: {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, valueType));
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0002E4E4 File Offset: 0x0002C6E4
		private static int CompareFloat(object objA, object objB)
		{
			double d = global::System.Convert.ToDouble(objA, global::System.Globalization.CultureInfo.InvariantCulture);
			double num = global::System.Convert.ToDouble(objB, global::System.Globalization.CultureInfo.InvariantCulture);
			if (global::Newtonsoft.Json.Utilities.MathUtils.ApproxEquals(d, num))
			{
				return 0;
			}
			return d.CompareTo(num);
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x0002E51C File Offset: 0x0002C71C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private static bool Operation(global::System.Linq.Expressions.ExpressionType operation, object objA, object objB, out object result)
		{
			if ((objA is string || objB is string) && (operation == global::System.Linq.Expressions.ExpressionType.Add || operation == global::System.Linq.Expressions.ExpressionType.AddAssign))
			{
				result = ((objA != null) ? objA.ToString() : null) + ((objB != null) ? objB.ToString() : null);
				return true;
			}
			if (objA is global::System.Numerics.BigInteger || objB is global::System.Numerics.BigInteger)
			{
				if (objA == null || objB == null)
				{
					result = null;
					return true;
				}
				global::System.Numerics.BigInteger bigInteger = global::Newtonsoft.Json.Utilities.ConvertUtils.ToBigInteger(objA);
				global::System.Numerics.BigInteger bigInteger2 = global::Newtonsoft.Json.Utilities.ConvertUtils.ToBigInteger(objB);
				if (operation <= global::System.Linq.Expressions.ExpressionType.Subtract)
				{
					if (operation <= global::System.Linq.Expressions.ExpressionType.Divide)
					{
						if (operation != global::System.Linq.Expressions.ExpressionType.Add)
						{
							if (operation != global::System.Linq.Expressions.ExpressionType.Divide)
							{
								goto IL_393;
							}
							goto IL_DE;
						}
					}
					else
					{
						if (operation == global::System.Linq.Expressions.ExpressionType.Multiply)
						{
							goto IL_CE;
						}
						if (operation != global::System.Linq.Expressions.ExpressionType.Subtract)
						{
							goto IL_393;
						}
						goto IL_BE;
					}
				}
				else if (operation <= global::System.Linq.Expressions.ExpressionType.DivideAssign)
				{
					if (operation != global::System.Linq.Expressions.ExpressionType.AddAssign)
					{
						if (operation != global::System.Linq.Expressions.ExpressionType.DivideAssign)
						{
							goto IL_393;
						}
						goto IL_DE;
					}
				}
				else
				{
					if (operation == global::System.Linq.Expressions.ExpressionType.MultiplyAssign)
					{
						goto IL_CE;
					}
					if (operation != global::System.Linq.Expressions.ExpressionType.SubtractAssign)
					{
						goto IL_393;
					}
					goto IL_BE;
				}
				result = bigInteger + bigInteger2;
				return true;
				IL_BE:
				result = bigInteger - bigInteger2;
				return true;
				IL_CE:
				result = bigInteger * bigInteger2;
				return true;
				IL_DE:
				result = bigInteger / bigInteger2;
				return true;
			}
			else if (objA is ulong || objB is ulong || objA is decimal || objB is decimal)
			{
				if (objA == null || objB == null)
				{
					result = null;
					return true;
				}
				decimal d = global::System.Convert.ToDecimal(objA, global::System.Globalization.CultureInfo.InvariantCulture);
				decimal d2 = global::System.Convert.ToDecimal(objB, global::System.Globalization.CultureInfo.InvariantCulture);
				if (operation <= global::System.Linq.Expressions.ExpressionType.Subtract)
				{
					if (operation <= global::System.Linq.Expressions.ExpressionType.Divide)
					{
						if (operation != global::System.Linq.Expressions.ExpressionType.Add)
						{
							if (operation != global::System.Linq.Expressions.ExpressionType.Divide)
							{
								goto IL_393;
							}
							goto IL_1AD;
						}
					}
					else
					{
						if (operation == global::System.Linq.Expressions.ExpressionType.Multiply)
						{
							goto IL_19D;
						}
						if (operation != global::System.Linq.Expressions.ExpressionType.Subtract)
						{
							goto IL_393;
						}
						goto IL_18D;
					}
				}
				else if (operation <= global::System.Linq.Expressions.ExpressionType.DivideAssign)
				{
					if (operation != global::System.Linq.Expressions.ExpressionType.AddAssign)
					{
						if (operation != global::System.Linq.Expressions.ExpressionType.DivideAssign)
						{
							goto IL_393;
						}
						goto IL_1AD;
					}
				}
				else
				{
					if (operation == global::System.Linq.Expressions.ExpressionType.MultiplyAssign)
					{
						goto IL_19D;
					}
					if (operation != global::System.Linq.Expressions.ExpressionType.SubtractAssign)
					{
						goto IL_393;
					}
					goto IL_18D;
				}
				result = d + d2;
				return true;
				IL_18D:
				result = d - d2;
				return true;
				IL_19D:
				result = d * d2;
				return true;
				IL_1AD:
				result = d / d2;
				return true;
			}
			else if (objA is float || objB is float || objA is double || objB is double)
			{
				if (objA == null || objB == null)
				{
					result = null;
					return true;
				}
				double num = global::System.Convert.ToDouble(objA, global::System.Globalization.CultureInfo.InvariantCulture);
				double num2 = global::System.Convert.ToDouble(objB, global::System.Globalization.CultureInfo.InvariantCulture);
				if (operation <= global::System.Linq.Expressions.ExpressionType.Subtract)
				{
					if (operation <= global::System.Linq.Expressions.ExpressionType.Divide)
					{
						if (operation != global::System.Linq.Expressions.ExpressionType.Add)
						{
							if (operation != global::System.Linq.Expressions.ExpressionType.Divide)
							{
								goto IL_393;
							}
							goto IL_278;
						}
					}
					else
					{
						if (operation == global::System.Linq.Expressions.ExpressionType.Multiply)
						{
							goto IL_26A;
						}
						if (operation != global::System.Linq.Expressions.ExpressionType.Subtract)
						{
							goto IL_393;
						}
						goto IL_25C;
					}
				}
				else if (operation <= global::System.Linq.Expressions.ExpressionType.DivideAssign)
				{
					if (operation != global::System.Linq.Expressions.ExpressionType.AddAssign)
					{
						if (operation != global::System.Linq.Expressions.ExpressionType.DivideAssign)
						{
							goto IL_393;
						}
						goto IL_278;
					}
				}
				else
				{
					if (operation == global::System.Linq.Expressions.ExpressionType.MultiplyAssign)
					{
						goto IL_26A;
					}
					if (operation != global::System.Linq.Expressions.ExpressionType.SubtractAssign)
					{
						goto IL_393;
					}
					goto IL_25C;
				}
				result = num + num2;
				return true;
				IL_25C:
				result = num - num2;
				return true;
				IL_26A:
				result = num * num2;
				return true;
				IL_278:
				result = num / num2;
				return true;
			}
			else if (objA is int || objA is uint || objA is long || objA is short || objA is ushort || objA is sbyte || objA is byte || objB is int || objB is uint || objB is long || objB is short || objB is ushort || objB is sbyte || objB is byte)
			{
				if (objA == null || objB == null)
				{
					result = null;
					return true;
				}
				long num3 = global::System.Convert.ToInt64(objA, global::System.Globalization.CultureInfo.InvariantCulture);
				long num4 = global::System.Convert.ToInt64(objB, global::System.Globalization.CultureInfo.InvariantCulture);
				if (operation <= global::System.Linq.Expressions.ExpressionType.Subtract)
				{
					if (operation <= global::System.Linq.Expressions.ExpressionType.Divide)
					{
						if (operation != global::System.Linq.Expressions.ExpressionType.Add)
						{
							if (operation != global::System.Linq.Expressions.ExpressionType.Divide)
							{
								goto IL_393;
							}
							goto IL_385;
						}
					}
					else
					{
						if (operation == global::System.Linq.Expressions.ExpressionType.Multiply)
						{
							goto IL_377;
						}
						if (operation != global::System.Linq.Expressions.ExpressionType.Subtract)
						{
							goto IL_393;
						}
						goto IL_369;
					}
				}
				else if (operation <= global::System.Linq.Expressions.ExpressionType.DivideAssign)
				{
					if (operation != global::System.Linq.Expressions.ExpressionType.AddAssign)
					{
						if (operation != global::System.Linq.Expressions.ExpressionType.DivideAssign)
						{
							goto IL_393;
						}
						goto IL_385;
					}
				}
				else
				{
					if (operation == global::System.Linq.Expressions.ExpressionType.MultiplyAssign)
					{
						goto IL_377;
					}
					if (operation != global::System.Linq.Expressions.ExpressionType.SubtractAssign)
					{
						goto IL_393;
					}
					goto IL_369;
				}
				result = num3 + num4;
				return true;
				IL_369:
				result = num3 - num4;
				return true;
				IL_377:
				result = num3 * num4;
				return true;
				IL_385:
				result = num3 / num4;
				return true;
			}
			IL_393:
			result = null;
			return false;
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0002E8C0 File Offset: 0x0002CAC0
		internal override global::Newtonsoft.Json.Linq.JToken CloneToken()
		{
			return new global::Newtonsoft.Json.Linq.JValue(this);
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x0002E8C8 File Offset: 0x0002CAC8
		public static global::Newtonsoft.Json.Linq.JValue CreateComment([global::System.Runtime.CompilerServices.Nullable(2)] string value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value, global::Newtonsoft.Json.Linq.JTokenType.Comment);
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0002E8D1 File Offset: 0x0002CAD1
		public static global::Newtonsoft.Json.Linq.JValue CreateString([global::System.Runtime.CompilerServices.Nullable(2)] string value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value, global::Newtonsoft.Json.Linq.JTokenType.String);
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x0002E8DA File Offset: 0x0002CADA
		public static global::Newtonsoft.Json.Linq.JValue CreateNull()
		{
			return new global::Newtonsoft.Json.Linq.JValue(null, global::Newtonsoft.Json.Linq.JTokenType.Null);
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x0002E8E4 File Offset: 0x0002CAE4
		public static global::Newtonsoft.Json.Linq.JValue CreateUndefined()
		{
			return new global::Newtonsoft.Json.Linq.JValue(null, global::Newtonsoft.Json.Linq.JTokenType.Undefined);
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x0002E8F0 File Offset: 0x0002CAF0
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private static global::Newtonsoft.Json.Linq.JTokenType GetValueType(global::Newtonsoft.Json.Linq.JTokenType? current, object value)
		{
			if (value == null)
			{
				return global::Newtonsoft.Json.Linq.JTokenType.Null;
			}
			if (value == global::System.DBNull.Value)
			{
				return global::Newtonsoft.Json.Linq.JTokenType.Null;
			}
			if (value is string)
			{
				return global::Newtonsoft.Json.Linq.JValue.GetStringValueType(current);
			}
			if (value is long || value is int || value is short || value is sbyte || value is ulong || value is uint || value is ushort || value is byte)
			{
				return global::Newtonsoft.Json.Linq.JTokenType.Integer;
			}
			if (value is global::System.Enum)
			{
				return global::Newtonsoft.Json.Linq.JTokenType.Integer;
			}
			if (value is global::System.Numerics.BigInteger)
			{
				return global::Newtonsoft.Json.Linq.JTokenType.Integer;
			}
			if (value is double || value is float || value is decimal)
			{
				return global::Newtonsoft.Json.Linq.JTokenType.Float;
			}
			if (value is global::System.DateTime)
			{
				return global::Newtonsoft.Json.Linq.JTokenType.Date;
			}
			if (value is global::System.DateTimeOffset)
			{
				return global::Newtonsoft.Json.Linq.JTokenType.Date;
			}
			if (value is byte[])
			{
				return global::Newtonsoft.Json.Linq.JTokenType.Bytes;
			}
			if (value is bool)
			{
				return global::Newtonsoft.Json.Linq.JTokenType.Boolean;
			}
			if (value is global::System.Guid)
			{
				return global::Newtonsoft.Json.Linq.JTokenType.Guid;
			}
			if (value is global::System.Uri)
			{
				return global::Newtonsoft.Json.Linq.JTokenType.Uri;
			}
			if (value is global::System.TimeSpan)
			{
				return global::Newtonsoft.Json.Linq.JTokenType.TimeSpan;
			}
			throw new global::System.ArgumentException("Could not determine JSON object type for type {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, value.GetType()));
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x0002E9F4 File Offset: 0x0002CBF4
		private static global::Newtonsoft.Json.Linq.JTokenType GetStringValueType(global::Newtonsoft.Json.Linq.JTokenType? current)
		{
			if (current == null)
			{
				return global::Newtonsoft.Json.Linq.JTokenType.String;
			}
			global::Newtonsoft.Json.Linq.JTokenType valueOrDefault = current.GetValueOrDefault();
			if (valueOrDefault == global::Newtonsoft.Json.Linq.JTokenType.Comment || valueOrDefault == global::Newtonsoft.Json.Linq.JTokenType.String || valueOrDefault == global::Newtonsoft.Json.Linq.JTokenType.Raw)
			{
				return current.GetValueOrDefault();
			}
			return global::Newtonsoft.Json.Linq.JTokenType.String;
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x0002EA2A File Offset: 0x0002CC2A
		public override global::Newtonsoft.Json.Linq.JTokenType Type
		{
			get
			{
				return this._valueType;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x0002EA32 File Offset: 0x0002CC32
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x0002EA3C File Offset: 0x0002CC3C
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public new object Value
		{
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				return this._value;
			}
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			set
			{
				object value2 = this._value;
				global::System.Type left = (value2 != null) ? value2.GetType() : null;
				global::System.Type right = (value != null) ? value.GetType() : null;
				if (left != right)
				{
					this._valueType = global::Newtonsoft.Json.Linq.JValue.GetValueType(new global::Newtonsoft.Json.Linq.JTokenType?(this._valueType), value);
				}
				this._value = value;
			}
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0002EA90 File Offset: 0x0002CC90
		public override void WriteTo(global::Newtonsoft.Json.JsonWriter writer, params global::Newtonsoft.Json.JsonConverter[] converters)
		{
			if (converters != null && converters.Length != 0 && this._value != null)
			{
				global::Newtonsoft.Json.JsonConverter matchingConverter = global::Newtonsoft.Json.JsonSerializer.GetMatchingConverter(converters, this._value.GetType());
				if (matchingConverter != null && matchingConverter.CanWrite)
				{
					matchingConverter.WriteJson(writer, this._value, global::Newtonsoft.Json.JsonSerializer.CreateDefault());
					return;
				}
			}
			switch (this._valueType)
			{
			case global::Newtonsoft.Json.Linq.JTokenType.Comment:
			{
				object value = this._value;
				writer.WriteComment((value != null) ? value.ToString() : null);
				return;
			}
			case global::Newtonsoft.Json.Linq.JTokenType.Integer:
			{
				object value2 = this._value;
				if (value2 is int)
				{
					int value3 = (int)value2;
					writer.WriteValue(value3);
					return;
				}
				value2 = this._value;
				if (value2 is long)
				{
					long value4 = (long)value2;
					writer.WriteValue(value4);
					return;
				}
				value2 = this._value;
				if (value2 is ulong)
				{
					ulong value5 = (ulong)value2;
					writer.WriteValue(value5);
					return;
				}
				value2 = this._value;
				if (value2 is global::System.Numerics.BigInteger)
				{
					global::System.Numerics.BigInteger bigInteger = (global::System.Numerics.BigInteger)value2;
					writer.WriteValue(bigInteger);
					return;
				}
				writer.WriteValue(global::System.Convert.ToInt64(this._value, global::System.Globalization.CultureInfo.InvariantCulture));
				return;
			}
			case global::Newtonsoft.Json.Linq.JTokenType.Float:
			{
				object value2 = this._value;
				if (value2 is decimal)
				{
					decimal value6 = (decimal)value2;
					writer.WriteValue(value6);
					return;
				}
				value2 = this._value;
				if (value2 is double)
				{
					double value7 = (double)value2;
					writer.WriteValue(value7);
					return;
				}
				value2 = this._value;
				if (value2 is float)
				{
					float value8 = (float)value2;
					writer.WriteValue(value8);
					return;
				}
				writer.WriteValue(global::System.Convert.ToDouble(this._value, global::System.Globalization.CultureInfo.InvariantCulture));
				return;
			}
			case global::Newtonsoft.Json.Linq.JTokenType.String:
			{
				object value9 = this._value;
				writer.WriteValue((value9 != null) ? value9.ToString() : null);
				return;
			}
			case global::Newtonsoft.Json.Linq.JTokenType.Boolean:
				writer.WriteValue(global::System.Convert.ToBoolean(this._value, global::System.Globalization.CultureInfo.InvariantCulture));
				return;
			case global::Newtonsoft.Json.Linq.JTokenType.Null:
				writer.WriteNull();
				return;
			case global::Newtonsoft.Json.Linq.JTokenType.Undefined:
				writer.WriteUndefined();
				return;
			case global::Newtonsoft.Json.Linq.JTokenType.Date:
			{
				object value2 = this._value;
				if (value2 is global::System.DateTimeOffset)
				{
					global::System.DateTimeOffset value10 = (global::System.DateTimeOffset)value2;
					writer.WriteValue(value10);
					return;
				}
				writer.WriteValue(global::System.Convert.ToDateTime(this._value, global::System.Globalization.CultureInfo.InvariantCulture));
				return;
			}
			case global::Newtonsoft.Json.Linq.JTokenType.Raw:
			{
				object value11 = this._value;
				writer.WriteRawValue((value11 != null) ? value11.ToString() : null);
				return;
			}
			case global::Newtonsoft.Json.Linq.JTokenType.Bytes:
				writer.WriteValue((byte[])this._value);
				return;
			case global::Newtonsoft.Json.Linq.JTokenType.Guid:
				writer.WriteValue((this._value != null) ? ((global::System.Guid?)this._value) : null);
				return;
			case global::Newtonsoft.Json.Linq.JTokenType.Uri:
				writer.WriteValue((global::System.Uri)this._value);
				return;
			case global::Newtonsoft.Json.Linq.JTokenType.TimeSpan:
				writer.WriteValue((this._value != null) ? ((global::System.TimeSpan?)this._value) : null);
				return;
			default:
				throw global::Newtonsoft.Json.Utilities.MiscellaneousUtils.CreateArgumentOutOfRangeException("Type", this._valueType, "Unexpected token type.");
			}
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0002ED7C File Offset: 0x0002CF7C
		internal override int GetDeepHashCode()
		{
			int num = (this._value != null) ? this._value.GetHashCode() : 0;
			int valueType = (int)this._valueType;
			return valueType.GetHashCode() ^ num;
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0002EDB0 File Offset: 0x0002CFB0
		private static bool ValuesEquals(global::Newtonsoft.Json.Linq.JValue v1, global::Newtonsoft.Json.Linq.JValue v2)
		{
			return v1 == v2 || (v1._valueType == v2._valueType && global::Newtonsoft.Json.Linq.JValue.Compare(v1._valueType, v1._value, v2._value) == 0);
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x0002EDE2 File Offset: 0x0002CFE2
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public bool Equals(global::Newtonsoft.Json.Linq.JValue other)
		{
			return other != null && global::Newtonsoft.Json.Linq.JValue.ValuesEquals(this, other);
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x0002EDF0 File Offset: 0x0002CFF0
		public override bool Equals(object obj)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = obj as global::Newtonsoft.Json.Linq.JValue;
			return jvalue != null && this.Equals(jvalue);
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x0002EE10 File Offset: 0x0002D010
		public override int GetHashCode()
		{
			if (this._value == null)
			{
				return 0;
			}
			return this._value.GetHashCode();
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0002EE27 File Offset: 0x0002D027
		public override string ToString()
		{
			if (this._value == null)
			{
				return string.Empty;
			}
			return this._value.ToString();
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0002EE42 File Offset: 0x0002D042
		public string ToString(string format)
		{
			return this.ToString(format, global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0002EE50 File Offset: 0x0002D050
		public string ToString(global::System.IFormatProvider formatProvider)
		{
			return this.ToString(null, formatProvider);
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0002EE5C File Offset: 0x0002D05C
		public string ToString([global::System.Runtime.CompilerServices.Nullable(2)] string format, global::System.IFormatProvider formatProvider)
		{
			if (this._value == null)
			{
				return string.Empty;
			}
			global::System.IFormattable formattable = this._value as global::System.IFormattable;
			if (formattable != null)
			{
				return formattable.ToString(format, formatProvider);
			}
			return this._value.ToString();
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0002EE9A File Offset: 0x0002D09A
		protected override global::System.Dynamic.DynamicMetaObject GetMetaObject(global::System.Linq.Expressions.Expression parameter)
		{
			return new global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<global::Newtonsoft.Json.Linq.JValue>(parameter, this, new global::Newtonsoft.Json.Linq.JValue.JValueDynamicProxy());
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x0002EEA8 File Offset: 0x0002D0A8
		int global::System.IComparable.CompareTo(object obj)
		{
			if (obj == null)
			{
				return 1;
			}
			global::Newtonsoft.Json.Linq.JValue jvalue = obj as global::Newtonsoft.Json.Linq.JValue;
			object objB;
			global::Newtonsoft.Json.Linq.JTokenType valueType;
			if (jvalue != null)
			{
				objB = jvalue.Value;
				valueType = ((this._valueType == global::Newtonsoft.Json.Linq.JTokenType.String && this._valueType != jvalue._valueType) ? jvalue._valueType : this._valueType);
			}
			else
			{
				objB = obj;
				valueType = this._valueType;
			}
			return global::Newtonsoft.Json.Linq.JValue.Compare(valueType, this._value, objB);
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x0002EF09 File Offset: 0x0002D109
		public int CompareTo(global::Newtonsoft.Json.Linq.JValue obj)
		{
			if (obj == null)
			{
				return 1;
			}
			return global::Newtonsoft.Json.Linq.JValue.Compare((this._valueType == global::Newtonsoft.Json.Linq.JTokenType.String && this._valueType != obj._valueType) ? obj._valueType : this._valueType, this._value, obj._value);
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x0002EF48 File Offset: 0x0002D148
		global::System.TypeCode global::System.IConvertible.GetTypeCode()
		{
			if (this._value == null)
			{
				return global::System.TypeCode.Empty;
			}
			global::System.IConvertible convertible = this._value as global::System.IConvertible;
			if (convertible != null)
			{
				return convertible.GetTypeCode();
			}
			return global::System.TypeCode.Object;
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x0002EF76 File Offset: 0x0002D176
		bool global::System.IConvertible.ToBoolean(global::System.IFormatProvider provider)
		{
			return (bool)this;
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0002EF7E File Offset: 0x0002D17E
		char global::System.IConvertible.ToChar(global::System.IFormatProvider provider)
		{
			return (char)this;
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x0002EF86 File Offset: 0x0002D186
		sbyte global::System.IConvertible.ToSByte(global::System.IFormatProvider provider)
		{
			return (sbyte)this;
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x0002EF8E File Offset: 0x0002D18E
		byte global::System.IConvertible.ToByte(global::System.IFormatProvider provider)
		{
			return (byte)this;
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0002EF96 File Offset: 0x0002D196
		short global::System.IConvertible.ToInt16(global::System.IFormatProvider provider)
		{
			return (short)this;
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x0002EF9E File Offset: 0x0002D19E
		ushort global::System.IConvertible.ToUInt16(global::System.IFormatProvider provider)
		{
			return (ushort)this;
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0002EFA6 File Offset: 0x0002D1A6
		int global::System.IConvertible.ToInt32(global::System.IFormatProvider provider)
		{
			return (int)this;
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x0002EFAE File Offset: 0x0002D1AE
		uint global::System.IConvertible.ToUInt32(global::System.IFormatProvider provider)
		{
			return (uint)this;
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x0002EFB6 File Offset: 0x0002D1B6
		long global::System.IConvertible.ToInt64(global::System.IFormatProvider provider)
		{
			return (long)this;
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x0002EFBE File Offset: 0x0002D1BE
		ulong global::System.IConvertible.ToUInt64(global::System.IFormatProvider provider)
		{
			return (ulong)this;
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x0002EFC6 File Offset: 0x0002D1C6
		float global::System.IConvertible.ToSingle(global::System.IFormatProvider provider)
		{
			return (float)this;
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x0002EFCF File Offset: 0x0002D1CF
		double global::System.IConvertible.ToDouble(global::System.IFormatProvider provider)
		{
			return (double)this;
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x0002EFD8 File Offset: 0x0002D1D8
		decimal global::System.IConvertible.ToDecimal(global::System.IFormatProvider provider)
		{
			return (decimal)this;
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x0002EFE0 File Offset: 0x0002D1E0
		global::System.DateTime global::System.IConvertible.ToDateTime(global::System.IFormatProvider provider)
		{
			return (global::System.DateTime)this;
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x0002EFE8 File Offset: 0x0002D1E8
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		object global::System.IConvertible.ToType(global::System.Type conversionType, global::System.IFormatProvider provider)
		{
			return base.ToObject(conversionType);
		}

		// Token: 0x040003A1 RID: 929
		private global::Newtonsoft.Json.Linq.JTokenType _valueType;

		// Token: 0x040003A2 RID: 930
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private object _value;

		// Token: 0x020001D3 RID: 467
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			0,
			1
		})]
		private class JValueDynamicProxy : global::Newtonsoft.Json.Utilities.DynamicProxy<global::Newtonsoft.Json.Linq.JValue>
		{
			// Token: 0x06000FDF RID: 4063 RVA: 0x00045D3C File Offset: 0x00043F3C
			public override bool TryConvert(global::Newtonsoft.Json.Linq.JValue instance, global::System.Dynamic.ConvertBinder binder, [global::System.Runtime.CompilerServices.Nullable(2)] [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out object result)
			{
				if (binder.Type == typeof(global::Newtonsoft.Json.Linq.JValue) || binder.Type == typeof(global::Newtonsoft.Json.Linq.JToken))
				{
					result = instance;
					return true;
				}
				object value = instance.Value;
				if (value == null)
				{
					result = null;
					return global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullable(binder.Type);
				}
				result = global::Newtonsoft.Json.Utilities.ConvertUtils.Convert(value, global::System.Globalization.CultureInfo.InvariantCulture, binder.Type);
				return true;
			}

			// Token: 0x06000FE0 RID: 4064 RVA: 0x00045DAC File Offset: 0x00043FAC
			public override bool TryBinaryOperation(global::Newtonsoft.Json.Linq.JValue instance, global::System.Dynamic.BinaryOperationBinder binder, object arg, [global::System.Runtime.CompilerServices.Nullable(2)] [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out object result)
			{
				global::Newtonsoft.Json.Linq.JValue jvalue = arg as global::Newtonsoft.Json.Linq.JValue;
				object objB = (jvalue != null) ? jvalue.Value : arg;
				global::System.Linq.Expressions.ExpressionType operation = binder.Operation;
				if (operation <= global::System.Linq.Expressions.ExpressionType.NotEqual)
				{
					if (operation <= global::System.Linq.Expressions.ExpressionType.LessThanOrEqual)
					{
						if (operation != global::System.Linq.Expressions.ExpressionType.Add)
						{
							switch (operation)
							{
							case global::System.Linq.Expressions.ExpressionType.Divide:
								break;
							case global::System.Linq.Expressions.ExpressionType.Equal:
								result = (global::Newtonsoft.Json.Linq.JValue.Compare(instance.Type, instance.Value, objB) == 0);
								return true;
							case global::System.Linq.Expressions.ExpressionType.ExclusiveOr:
							case global::System.Linq.Expressions.ExpressionType.Invoke:
							case global::System.Linq.Expressions.ExpressionType.Lambda:
							case global::System.Linq.Expressions.ExpressionType.LeftShift:
								goto IL_18D;
							case global::System.Linq.Expressions.ExpressionType.GreaterThan:
								result = (global::Newtonsoft.Json.Linq.JValue.Compare(instance.Type, instance.Value, objB) > 0);
								return true;
							case global::System.Linq.Expressions.ExpressionType.GreaterThanOrEqual:
								result = (global::Newtonsoft.Json.Linq.JValue.Compare(instance.Type, instance.Value, objB) >= 0);
								return true;
							case global::System.Linq.Expressions.ExpressionType.LessThan:
								result = (global::Newtonsoft.Json.Linq.JValue.Compare(instance.Type, instance.Value, objB) < 0);
								return true;
							case global::System.Linq.Expressions.ExpressionType.LessThanOrEqual:
								result = (global::Newtonsoft.Json.Linq.JValue.Compare(instance.Type, instance.Value, objB) <= 0);
								return true;
							default:
								goto IL_18D;
							}
						}
					}
					else if (operation != global::System.Linq.Expressions.ExpressionType.Multiply)
					{
						if (operation != global::System.Linq.Expressions.ExpressionType.NotEqual)
						{
							goto IL_18D;
						}
						result = (global::Newtonsoft.Json.Linq.JValue.Compare(instance.Type, instance.Value, objB) != 0);
						return true;
					}
				}
				else if (operation <= global::System.Linq.Expressions.ExpressionType.AddAssign)
				{
					if (operation != global::System.Linq.Expressions.ExpressionType.Subtract && operation != global::System.Linq.Expressions.ExpressionType.AddAssign)
					{
						goto IL_18D;
					}
				}
				else if (operation != global::System.Linq.Expressions.ExpressionType.DivideAssign && operation != global::System.Linq.Expressions.ExpressionType.MultiplyAssign && operation != global::System.Linq.Expressions.ExpressionType.SubtractAssign)
				{
					goto IL_18D;
				}
				if (global::Newtonsoft.Json.Linq.JValue.Operation(binder.Operation, instance.Value, objB, out result))
				{
					result = new global::Newtonsoft.Json.Linq.JValue(result);
					return true;
				}
				IL_18D:
				result = null;
				return false;
			}
		}
	}
}
