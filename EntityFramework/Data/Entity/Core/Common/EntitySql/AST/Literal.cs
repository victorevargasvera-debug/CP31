using System;
using System.Data.Entity.Resources;
using System.Globalization;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x0200068C RID: 1676
	internal sealed class Literal : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F65 RID: 20325 RVA: 0x0011F4F1 File Offset: 0x0011D6F1
		internal Literal(string originalValue, global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind kind, string query, int inputPos) : base(query, inputPos)
		{
			this._originalValue = originalValue;
			this._literalKind = kind;
		}

		// Token: 0x06004F66 RID: 20326 RVA: 0x0011F50A File Offset: 0x0011D70A
		internal static global::System.Data.Entity.Core.Common.EntitySql.AST.Literal NewBooleanLiteral(bool value)
		{
			return new global::System.Data.Entity.Core.Common.EntitySql.AST.Literal(value);
		}

		// Token: 0x06004F67 RID: 20327 RVA: 0x0011F512 File Offset: 0x0011D712
		private Literal(bool boolLiteral) : base(null, 0)
		{
			this._wasValueComputed = true;
			this._originalValue = string.Empty;
			this._computedValue = boolLiteral;
			this._type = typeof(bool);
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06004F68 RID: 20328 RVA: 0x0011F54A File Offset: 0x0011D74A
		internal bool IsNumber
		{
			get
			{
				return this._literalKind == global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.Number;
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06004F69 RID: 20329 RVA: 0x0011F555 File Offset: 0x0011D755
		internal bool IsSignedNumber
		{
			get
			{
				return this.IsNumber && (this._originalValue[0] == '-' || this._originalValue[0] == '+');
			}
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x06004F6A RID: 20330 RVA: 0x0011F583 File Offset: 0x0011D783
		internal bool IsString
		{
			get
			{
				return this._literalKind == global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.String || this._literalKind == global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.UnicodeString;
			}
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06004F6B RID: 20331 RVA: 0x0011F599 File Offset: 0x0011D799
		internal bool IsUnicodeString
		{
			get
			{
				return this._literalKind == global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.UnicodeString;
			}
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x06004F6C RID: 20332 RVA: 0x0011F5A4 File Offset: 0x0011D7A4
		internal bool IsNullLiteral
		{
			get
			{
				return this._literalKind == global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.Null;
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06004F6D RID: 20333 RVA: 0x0011F5B0 File Offset: 0x0011D7B0
		internal string OriginalValue
		{
			get
			{
				return this._originalValue;
			}
		}

		// Token: 0x06004F6E RID: 20334 RVA: 0x0011F5B8 File Offset: 0x0011D7B8
		internal void PrefixSign(string sign)
		{
			this._originalValue = sign + this._originalValue;
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06004F6F RID: 20335 RVA: 0x0011F5CC File Offset: 0x0011D7CC
		internal object Value
		{
			get
			{
				this.ComputeValue();
				return this._computedValue;
			}
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06004F70 RID: 20336 RVA: 0x0011F5DA File Offset: 0x0011D7DA
		internal global::System.Type Type
		{
			get
			{
				this.ComputeValue();
				return this._type;
			}
		}

		// Token: 0x06004F71 RID: 20337 RVA: 0x0011F5E8 File Offset: 0x0011D7E8
		private void ComputeValue()
		{
			if (!this._wasValueComputed)
			{
				this._wasValueComputed = true;
				switch (this._literalKind)
				{
				case global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.Number:
					this._computedValue = global::System.Data.Entity.Core.Common.EntitySql.AST.Literal.ConvertNumericLiteral(base.ErrCtx, this._originalValue);
					break;
				case global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.String:
					this._computedValue = global::System.Data.Entity.Core.Common.EntitySql.AST.Literal.GetStringLiteralValue(this._originalValue, false);
					break;
				case global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.UnicodeString:
					this._computedValue = global::System.Data.Entity.Core.Common.EntitySql.AST.Literal.GetStringLiteralValue(this._originalValue, true);
					break;
				case global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.Boolean:
					this._computedValue = global::System.Data.Entity.Core.Common.EntitySql.AST.Literal.ConvertBooleanLiteralValue(base.ErrCtx, this._originalValue);
					break;
				case global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.Binary:
					this._computedValue = global::System.Data.Entity.Core.Common.EntitySql.AST.Literal.ConvertBinaryLiteralValue(this._originalValue);
					break;
				case global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.DateTime:
					this._computedValue = global::System.Data.Entity.Core.Common.EntitySql.AST.Literal.ConvertDateTimeLiteralValue(this._originalValue);
					break;
				case global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.Time:
					this._computedValue = global::System.Data.Entity.Core.Common.EntitySql.AST.Literal.ConvertTimeLiteralValue(this._originalValue);
					break;
				case global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.DateTimeOffset:
					this._computedValue = global::System.Data.Entity.Core.Common.EntitySql.AST.Literal.ConvertDateTimeOffsetLiteralValue(base.ErrCtx, this._originalValue);
					break;
				case global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.Guid:
					this._computedValue = global::System.Data.Entity.Core.Common.EntitySql.AST.Literal.ConvertGuidLiteralValue(this._originalValue);
					break;
				case global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.Null:
					this._computedValue = null;
					break;
				default:
					throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.LiteralTypeNotSupported(this._literalKind.ToString()));
				}
				this._type = (this.IsNullLiteral ? null : this._computedValue.GetType());
			}
		}

		// Token: 0x06004F72 RID: 20338 RVA: 0x0011F76C File Offset: 0x0011D96C
		private static object ConvertNumericLiteral(global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx, string numericString)
		{
			int num = numericString.IndexOfAny(global::System.Data.Entity.Core.Common.EntitySql.AST.Literal._numberSuffixes);
			if (-1 != num)
			{
				string text = numericString.Substring(num).ToUpperInvariant();
				string s = numericString.Substring(0, numericString.Length - text.Length);
				if (text != null)
				{
					uint num2 = global::<PrivateImplementationDetails>.ComputeStringHash(text);
					if (num2 <= 3238785555U)
					{
						if (num2 != 2078435802U)
						{
							if (num2 != 2129901492U)
							{
								if (num2 != 3238785555U)
								{
									goto IL_256;
								}
								if (!(text == "D"))
								{
									goto IL_256;
								}
								double num3;
								if (!double.TryParse(s, global::System.Globalization.NumberStyles.Float, global::System.Globalization.CultureInfo.InvariantCulture, out num3))
								{
									string errorMessage = global::System.Data.Entity.Resources.Strings.CannotConvertNumericLiteral(numericString, "double");
									throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
								}
								return num3;
							}
							else if (!(text == "UL"))
							{
								goto IL_256;
							}
						}
						else if (!(text == "LU"))
						{
							goto IL_256;
						}
						ulong num4;
						if (!ulong.TryParse(s, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out num4))
						{
							string errorMessage2 = global::System.Data.Entity.Resources.Strings.CannotConvertNumericLiteral(numericString, "unsigned long");
							throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage2, null);
						}
						return num4;
					}
					else if (num2 <= 3356228888U)
					{
						if (num2 != 3272340793U)
						{
							if (num2 == 3356228888U)
							{
								if (text == "M")
								{
									decimal num5;
									if (!decimal.TryParse(s, global::System.Globalization.NumberStyles.AllowLeadingSign | global::System.Globalization.NumberStyles.AllowDecimalPoint, global::System.Globalization.CultureInfo.InvariantCulture, out num5))
									{
										string errorMessage3 = global::System.Data.Entity.Resources.Strings.CannotConvertNumericLiteral(numericString, "decimal");
										throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage3, null);
									}
									return num5;
								}
							}
						}
						else if (text == "F")
						{
							float num6;
							if (!float.TryParse(s, global::System.Globalization.NumberStyles.Float, global::System.Globalization.CultureInfo.InvariantCulture, out num6))
							{
								string errorMessage4 = global::System.Data.Entity.Resources.Strings.CannotConvertNumericLiteral(numericString, "float");
								throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage4, null);
							}
							return num6;
						}
					}
					else if (num2 != 3373006507U)
					{
						if (num2 == 3490449840U)
						{
							if (text == "U")
							{
								uint num7;
								if (!uint.TryParse(s, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out num7))
								{
									string errorMessage5 = global::System.Data.Entity.Resources.Strings.CannotConvertNumericLiteral(numericString, "unsigned int");
									throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage5, null);
								}
								return num7;
							}
						}
					}
					else if (text == "L")
					{
						long num8;
						if (!long.TryParse(s, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out num8))
						{
							string errorMessage6 = global::System.Data.Entity.Resources.Strings.CannotConvertNumericLiteral(numericString, "long");
							throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage6, null);
						}
						return num8;
					}
				}
			}
			IL_256:
			return global::System.Data.Entity.Core.Common.EntitySql.AST.Literal.DefaultNumericConversion(numericString, errCtx);
		}

		// Token: 0x06004F73 RID: 20339 RVA: 0x0011F9D8 File Offset: 0x0011DBD8
		private static object DefaultNumericConversion(string numericString, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx)
		{
			if (-1 != numericString.IndexOfAny(global::System.Data.Entity.Core.Common.EntitySql.AST.Literal._floatTokens))
			{
				double num;
				if (!double.TryParse(numericString, global::System.Globalization.NumberStyles.Float, global::System.Globalization.CultureInfo.InvariantCulture, out num))
				{
					string errorMessage = global::System.Data.Entity.Resources.Strings.CannotConvertNumericLiteral(numericString, "double");
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
				}
				return num;
			}
			else
			{
				int num2;
				if (int.TryParse(numericString, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out num2))
				{
					return num2;
				}
				long num3;
				if (!long.TryParse(numericString, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out num3))
				{
					string errorMessage2 = global::System.Data.Entity.Resources.Strings.CannotConvertNumericLiteral(numericString, "long");
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage2, null);
				}
				return num3;
			}
		}

		// Token: 0x06004F74 RID: 20340 RVA: 0x0011FA68 File Offset: 0x0011DC68
		private static bool ConvertBooleanLiteralValue(global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx, string booleanLiteralValue)
		{
			bool result = false;
			if (!bool.TryParse(booleanLiteralValue, out result))
			{
				string errorMessage = global::System.Data.Entity.Resources.Strings.InvalidLiteralFormat("Boolean", booleanLiteralValue);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
			return result;
		}

		// Token: 0x06004F75 RID: 20341 RVA: 0x0011FA98 File Offset: 0x0011DC98
		private static string GetStringLiteralValue(string stringLiteralValue, bool isUnicode)
		{
			int num = isUnicode ? 2 : 1;
			char c = stringLiteralValue[num - 1];
			if (c != '\'' && c != '"')
			{
				throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.MalformedStringLiteralPayload);
			}
			int num2 = stringLiteralValue.Split(new char[]
			{
				c
			}).Length - 1;
			if (num2 % 2 != 0)
			{
				throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.MalformedStringLiteralPayload);
			}
			string text = stringLiteralValue.Substring(num, stringLiteralValue.Length - (1 + num));
			text = text.Replace(new string(c, 2), new string(c, 1));
			if (text.Split(new char[]
			{
				c
			}).Length - 1 != (num2 - 2) / 2)
			{
				throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.MalformedStringLiteralPayload);
			}
			return text;
		}

		// Token: 0x06004F76 RID: 20342 RVA: 0x0011FB48 File Offset: 0x0011DD48
		private static byte[] ConvertBinaryLiteralValue(string binaryLiteralValue)
		{
			if (string.IsNullOrEmpty(binaryLiteralValue))
			{
				return global::System.Data.Entity.Core.Common.EntitySql.AST.Literal._emptyByteArray;
			}
			int i = 0;
			int num = binaryLiteralValue.Length - 1;
			int num2 = num - i + 1;
			int num3 = num2 / 2;
			bool flag = num2 % 2 != 0;
			if (flag)
			{
				num3++;
			}
			byte[] array = new byte[num3];
			int num4 = 0;
			if (flag)
			{
				array[num4++] = (byte)global::System.Data.Entity.Core.Common.EntitySql.AST.Literal.HexDigitToBinaryValue(binaryLiteralValue[i++]);
			}
			while (i < num)
			{
				array[num4++] = (byte)(global::System.Data.Entity.Core.Common.EntitySql.AST.Literal.HexDigitToBinaryValue(binaryLiteralValue[i++]) << 4 | global::System.Data.Entity.Core.Common.EntitySql.AST.Literal.HexDigitToBinaryValue(binaryLiteralValue[i++]));
			}
			return array;
		}

		// Token: 0x06004F77 RID: 20343 RVA: 0x0011FBE3 File Offset: 0x0011DDE3
		private static int HexDigitToBinaryValue(char hexChar)
		{
			if (hexChar >= '0' && hexChar <= '9')
			{
				return (int)(hexChar - '0');
			}
			if (hexChar >= 'A' && hexChar <= 'F')
			{
				return (int)(hexChar - 'A' + '\n');
			}
			if (hexChar >= 'a' && hexChar <= 'f')
			{
				return (int)(hexChar - 'a' + '\n');
			}
			throw new global::System.ArgumentOutOfRangeException("hexChar");
		}

		// Token: 0x06004F78 RID: 20344 RVA: 0x0011FC24 File Offset: 0x0011DE24
		private static global::System.DateTime ConvertDateTimeLiteralValue(string datetimeLiteralValue)
		{
			string[] datetimeParts = datetimeLiteralValue.Split(global::System.Data.Entity.Core.Common.EntitySql.AST.Literal._datetimeSeparators, global::System.StringSplitOptions.RemoveEmptyEntries);
			int year;
			int month;
			int day;
			global::System.Data.Entity.Core.Common.EntitySql.AST.Literal.GetDateParts(datetimeLiteralValue, datetimeParts, out year, out month, out day);
			int hour;
			int minute;
			int second;
			int num;
			global::System.Data.Entity.Core.Common.EntitySql.AST.Literal.GetTimeParts(datetimeLiteralValue, datetimeParts, 3, out hour, out minute, out second, out num);
			global::System.DateTime result = new global::System.DateTime(year, month, day, hour, minute, second, 0);
			result = result.AddTicks((long)num);
			return result;
		}

		// Token: 0x06004F79 RID: 20345 RVA: 0x0011FC7C File Offset: 0x0011DE7C
		private static global::System.DateTimeOffset ConvertDateTimeOffsetLiteralValue(global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx, string datetimeLiteralValue)
		{
			string[] array = datetimeLiteralValue.Split(global::System.Data.Entity.Core.Common.EntitySql.AST.Literal._datetimeOffsetSeparators, global::System.StringSplitOptions.RemoveEmptyEntries);
			int year;
			int month;
			int day;
			global::System.Data.Entity.Core.Common.EntitySql.AST.Literal.GetDateParts(datetimeLiteralValue, array, out year, out month, out day);
			string[] array2 = new string[array.Length - 2];
			global::System.Array.Copy(array, array2, array.Length - 2);
			int hour;
			int minute;
			int second;
			int num;
			global::System.Data.Entity.Core.Common.EntitySql.AST.Literal.GetTimeParts(datetimeLiteralValue, array2, 3, out hour, out minute, out second, out num);
			int hours = int.Parse(array[array.Length - 2], global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
			int minutes = int.Parse(array[array.Length - 1], global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
			global::System.TimeSpan offset = new global::System.TimeSpan(hours, minutes, 0);
			if (datetimeLiteralValue.IndexOf('+') == -1)
			{
				offset = offset.Negate();
			}
			global::System.DateTime dateTime = new global::System.DateTime(year, month, day, hour, minute, second, 0);
			dateTime = dateTime.AddTicks((long)num);
			global::System.DateTimeOffset result;
			try
			{
				result = new global::System.DateTimeOffset(dateTime, offset);
			}
			catch (global::System.ArgumentOutOfRangeException innerException)
			{
				string errorMessage = global::System.Data.Entity.Resources.Strings.InvalidDateTimeOffsetLiteral(datetimeLiteralValue);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, innerException);
			}
			return result;
		}

		// Token: 0x06004F7A RID: 20346 RVA: 0x0011FD68 File Offset: 0x0011DF68
		private static global::System.TimeSpan ConvertTimeLiteralValue(string datetimeLiteralValue)
		{
			string[] datetimeParts = datetimeLiteralValue.Split(global::System.Data.Entity.Core.Common.EntitySql.AST.Literal._datetimeSeparators, global::System.StringSplitOptions.RemoveEmptyEntries);
			int hours;
			int minutes;
			int seconds;
			int num;
			global::System.Data.Entity.Core.Common.EntitySql.AST.Literal.GetTimeParts(datetimeLiteralValue, datetimeParts, 0, out hours, out minutes, out seconds, out num);
			global::System.TimeSpan result = new global::System.TimeSpan(hours, minutes, seconds);
			result = result.Add(new global::System.TimeSpan((long)num));
			return result;
		}

		// Token: 0x06004F7B RID: 20347 RVA: 0x0011FDB0 File Offset: 0x0011DFB0
		private static void GetTimeParts(string datetimeLiteralValue, string[] datetimeParts, int timePartStartIndex, out int hour, out int minute, out int second, out int ticks)
		{
			hour = int.Parse(datetimeParts[timePartStartIndex], global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
			if (hour > 23)
			{
				throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.InvalidHour(datetimeParts[timePartStartIndex], datetimeLiteralValue));
			}
			minute = int.Parse(datetimeParts[++timePartStartIndex], global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
			if (minute > 59)
			{
				throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.InvalidMinute(datetimeParts[timePartStartIndex], datetimeLiteralValue));
			}
			second = 0;
			ticks = 0;
			timePartStartIndex++;
			if (datetimeParts.Length > timePartStartIndex)
			{
				second = int.Parse(datetimeParts[timePartStartIndex], global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
				if (second > 59)
				{
					throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.InvalidSecond(datetimeParts[timePartStartIndex], datetimeLiteralValue));
				}
				timePartStartIndex++;
				if (datetimeParts.Length > timePartStartIndex)
				{
					string s = datetimeParts[timePartStartIndex].PadRight(7, '0');
					ticks = int.Parse(s, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
				}
			}
		}

		// Token: 0x06004F7C RID: 20348 RVA: 0x0011FE70 File Offset: 0x0011E070
		private static void GetDateParts(string datetimeLiteralValue, string[] datetimeParts, out int year, out int month, out int day)
		{
			year = int.Parse(datetimeParts[0], global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
			if (year < 1 || year > 9999)
			{
				throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.InvalidYear(datetimeParts[0], datetimeLiteralValue));
			}
			month = int.Parse(datetimeParts[1], global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
			if (month < 1 || month > 12)
			{
				throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.InvalidMonth(datetimeParts[1], datetimeLiteralValue));
			}
			day = int.Parse(datetimeParts[2], global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
			if (day < 1)
			{
				throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.InvalidDay(datetimeParts[2], datetimeLiteralValue));
			}
			if (day > global::System.DateTime.DaysInMonth(year, month))
			{
				throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.InvalidDayInMonth(datetimeParts[2], datetimeParts[1], datetimeLiteralValue));
			}
		}

		// Token: 0x06004F7D RID: 20349 RVA: 0x0011FF1A File Offset: 0x0011E11A
		private static global::System.Guid ConvertGuidLiteralValue(string guidLiteralValue)
		{
			return new global::System.Guid(guidLiteralValue);
		}

		// Token: 0x04001CF9 RID: 7417
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind _literalKind;

		// Token: 0x04001CFA RID: 7418
		private string _originalValue;

		// Token: 0x04001CFB RID: 7419
		private bool _wasValueComputed;

		// Token: 0x04001CFC RID: 7420
		private object _computedValue;

		// Token: 0x04001CFD RID: 7421
		private global::System.Type _type;

		// Token: 0x04001CFE RID: 7422
		private static readonly byte[] _emptyByteArray = new byte[0];

		// Token: 0x04001CFF RID: 7423
		private static readonly char[] _numberSuffixes = new char[]
		{
			'U',
			'u',
			'L',
			'l',
			'F',
			'f',
			'M',
			'm',
			'D',
			'd'
		};

		// Token: 0x04001D00 RID: 7424
		private static readonly char[] _floatTokens = new char[]
		{
			'.',
			'E',
			'e'
		};

		// Token: 0x04001D01 RID: 7425
		private static readonly char[] _datetimeSeparators = new char[]
		{
			' ',
			':',
			'-',
			'.'
		};

		// Token: 0x04001D02 RID: 7426
		private static readonly char[] _datetimeOffsetSeparators = new char[]
		{
			' ',
			':',
			'-',
			'.',
			'+',
			'-'
		};
	}
}
