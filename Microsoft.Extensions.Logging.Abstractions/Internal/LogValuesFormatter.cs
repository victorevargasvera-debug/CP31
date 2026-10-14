using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Microsoft.Extensions.Logging.Internal
{
	// Token: 0x0200000D RID: 13
	public class LogValuesFormatter
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00002758 File Offset: 0x00000958
		public LogValuesFormatter(string format)
		{
			this.OriginalFormat = format;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int i = 0;
			int length = format.Length;
			while (i < length)
			{
				int num = global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter.FindBraceIndex(format, '{', i, length);
				int num2 = global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter.FindBraceIndex(format, '}', num, length);
				int num3 = global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter.FindIndexOf(format, ',', num, num2);
				if (num3 == num2)
				{
					num3 = global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter.FindIndexOf(format, ':', num, num2);
				}
				if (num2 == length)
				{
					stringBuilder.Append(format, i, length - i);
					i = length;
				}
				else
				{
					stringBuilder.Append(format, i, num - i + 1);
					stringBuilder.Append(this._valueNames.Count.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					this._valueNames.Add(format.Substring(num + 1, num3 - num - 1));
					stringBuilder.Append(format, num3, num2 - num3 + 1);
					i = num2 + 1;
				}
			}
			this._format = stringBuilder.ToString();
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0000284E File Offset: 0x00000A4E
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00002856 File Offset: 0x00000A56
		public string OriginalFormat { get; private set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000285F File Offset: 0x00000A5F
		public global::System.Collections.Generic.List<string> ValueNames
		{
			get
			{
				return this._valueNames;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002868 File Offset: 0x00000A68
		private static int FindBraceIndex(string format, char brace, int startIndex, int endIndex)
		{
			int result = endIndex;
			int i = startIndex;
			int num = 0;
			while (i < endIndex)
			{
				if (num > 0 && format[i] != brace)
				{
					if (num % 2 != 0)
					{
						break;
					}
					num = 0;
					result = endIndex;
				}
				else if (format[i] == brace)
				{
					if (brace == '}')
					{
						if (num == 0)
						{
							result = i;
						}
					}
					else
					{
						result = i;
					}
					num++;
				}
				i++;
			}
			return result;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000028BC File Offset: 0x00000ABC
		private static int FindIndexOf(string format, char ch, int startIndex, int endIndex)
		{
			int num = format.IndexOf(ch, startIndex, endIndex - startIndex);
			if (num != -1)
			{
				return num;
			}
			return endIndex;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000028DC File Offset: 0x00000ADC
		public string Format(object[] values)
		{
			if (values != null)
			{
				for (int i = 0; i < values.Length; i++)
				{
					object obj = values[i];
					if (obj == null)
					{
						values[i] = "(null)";
					}
					else if (!(obj is string))
					{
						global::System.Collections.IEnumerable enumerable = obj as global::System.Collections.IEnumerable;
						if (enumerable != null)
						{
							values[i] = string.Join<object>(", ", from object o in enumerable
							select o ?? "(null)");
						}
					}
				}
			}
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, this._format, values ?? global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter.EmptyArray);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002970 File Offset: 0x00000B70
		public global::System.Collections.Generic.KeyValuePair<string, object> GetValue(object[] values, int index)
		{
			if (index < 0 || index > this._valueNames.Count)
			{
				throw new global::System.IndexOutOfRangeException("index");
			}
			if (this._valueNames.Count > index)
			{
				return new global::System.Collections.Generic.KeyValuePair<string, object>(this._valueNames[index], values[index]);
			}
			return new global::System.Collections.Generic.KeyValuePair<string, object>("{OriginalFormat}", this.OriginalFormat);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000029D0 File Offset: 0x00000BD0
		public global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>> GetValues(object[] values)
		{
			global::System.Collections.Generic.KeyValuePair<string, object>[] array = new global::System.Collections.Generic.KeyValuePair<string, object>[values.Length + 1];
			for (int num = 0; num != this._valueNames.Count; num++)
			{
				array[num] = new global::System.Collections.Generic.KeyValuePair<string, object>(this._valueNames[num], values[num]);
			}
			array[array.Length - 1] = new global::System.Collections.Generic.KeyValuePair<string, object>("{OriginalFormat}", this.OriginalFormat);
			return array;
		}

		// Token: 0x04000012 RID: 18
		private const string NullValue = "(null)";

		// Token: 0x04000013 RID: 19
		private static readonly object[] EmptyArray = new object[0];

		// Token: 0x04000014 RID: 20
		private readonly string _format;

		// Token: 0x04000015 RID: 21
		private readonly global::System.Collections.Generic.List<string> _valueNames = new global::System.Collections.Generic.List<string>();
	}
}
