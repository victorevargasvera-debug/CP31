using System;

namespace MassTransit.NewIdFormatters
{
	// Token: 0x02000018 RID: 24
	public class HexFormatter : global::MassTransit.INewIdFormatter
	{
		// Token: 0x06000059 RID: 89 RVA: 0x00003660 File Offset: 0x00001860
		public HexFormatter(bool upperCase = false)
		{
			this._alpha = (upperCase ? 65 : 97);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003678 File Offset: 0x00001878
		public string Format(in byte[] bytes)
		{
			char[] array = new char[32];
			int num = 0;
			for (int i = 0; i < 16; i++)
			{
				byte b = bytes[i];
				array[num++] = global::MassTransit.NewIdFormatters.HexFormatter.HexToChar(b >> 4, this._alpha);
				array[num++] = global::MassTransit.NewIdFormatters.HexFormatter.HexToChar((int)b, this._alpha);
			}
			return new string(array, 0, 32);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000036D2 File Offset: 0x000018D2
		private static char HexToChar(int value, int alpha)
		{
			value &= 15;
			return (char)((value > 9) ? (value - 10 + alpha) : (value + 48));
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000036EC File Offset: 0x000018EC
		string global::MassTransit.INewIdFormatter.Format(in byte[] bytes)
		{
			return this.Format(bytes);
		}

		// Token: 0x0400002B RID: 43
		private readonly int _alpha;
	}
}
