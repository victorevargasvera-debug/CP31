using System;

namespace MassTransit.NewIdFormatters
{
	// Token: 0x02000017 RID: 23
	public class DashedHexFormatter : global::MassTransit.INewIdFormatter
	{
		// Token: 0x06000055 RID: 85 RVA: 0x00003468 File Offset: 0x00001668
		public DashedHexFormatter(char prefix = '\0', char suffix = '\0', bool upperCase = false)
		{
			if (prefix == '\0' || suffix == '\0')
			{
				this._length = 36;
			}
			else
			{
				this._prefix = prefix;
				this._suffix = suffix;
				this._length = 38;
			}
			this._alpha = (upperCase ? 65 : 97);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000034A8 File Offset: 0x000016A8
		public string Format(in byte[] bytes)
		{
			char[] array = new char[this._length];
			int i = 0;
			int num = 0;
			if (this._prefix != '\0')
			{
				array[num++] = this._prefix;
			}
			while (i < 4)
			{
				int num2 = (int)bytes[i];
				array[num++] = global::MassTransit.NewIdFormatters.DashedHexFormatter.HexToChar(num2 >> 4, this._alpha);
				array[num++] = global::MassTransit.NewIdFormatters.DashedHexFormatter.HexToChar(num2, this._alpha);
				i++;
			}
			array[num++] = '-';
			while (i < 6)
			{
				int num3 = (int)bytes[i];
				array[num++] = global::MassTransit.NewIdFormatters.DashedHexFormatter.HexToChar(num3 >> 4, this._alpha);
				array[num++] = global::MassTransit.NewIdFormatters.DashedHexFormatter.HexToChar(num3, this._alpha);
				i++;
			}
			array[num++] = '-';
			while (i < 8)
			{
				int num4 = (int)bytes[i];
				array[num++] = global::MassTransit.NewIdFormatters.DashedHexFormatter.HexToChar(num4 >> 4, this._alpha);
				array[num++] = global::MassTransit.NewIdFormatters.DashedHexFormatter.HexToChar(num4, this._alpha);
				i++;
			}
			array[num++] = '-';
			while (i < 10)
			{
				int num5 = (int)bytes[i];
				array[num++] = global::MassTransit.NewIdFormatters.DashedHexFormatter.HexToChar(num5 >> 4, this._alpha);
				array[num++] = global::MassTransit.NewIdFormatters.DashedHexFormatter.HexToChar(num5, this._alpha);
				i++;
			}
			array[num++] = '-';
			while (i < 16)
			{
				int num6 = (int)bytes[i];
				array[num++] = global::MassTransit.NewIdFormatters.DashedHexFormatter.HexToChar(num6 >> 4, this._alpha);
				array[num++] = global::MassTransit.NewIdFormatters.DashedHexFormatter.HexToChar(num6, this._alpha);
				i++;
			}
			if (this._suffix != '\0')
			{
				array[num] = this._suffix;
			}
			return new string(array, 0, this._length);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000363D File Offset: 0x0000183D
		private static char HexToChar(int value, int alpha)
		{
			value &= 15;
			return (char)((value > 9) ? (value - 10 + alpha) : (value + 48));
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003657 File Offset: 0x00001857
		string global::MassTransit.INewIdFormatter.Format(in byte[] bytes)
		{
			return this.Format(bytes);
		}

		// Token: 0x04000027 RID: 39
		private readonly int _alpha;

		// Token: 0x04000028 RID: 40
		private readonly int _length;

		// Token: 0x04000029 RID: 41
		private readonly char _prefix;

		// Token: 0x0400002A RID: 42
		private readonly char _suffix;
	}
}
