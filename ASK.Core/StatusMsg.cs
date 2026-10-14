using System;
using System.Runtime.CompilerServices;

namespace ASK.Core
{
	// Token: 0x02000028 RID: 40
	public class StatusMsg
	{
		// Token: 0x06000175 RID: 373 RVA: 0x0002A1B8 File Offset: 0x000283B8
		public StatusMsg(global::ASK.Core.AskStatusType type, string message, uint retCode)
		{
			this.Type = type;
			this.Message = message;
			this.RetCode = retCode;
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000176 RID: 374 RVA: 0x0002A1E0 File Offset: 0x000283E0
		// (set) Token: 0x06000177 RID: 375 RVA: 0x0002A290 File Offset: 0x00028490
		public uint RetCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1242628788;
				short num2 = num;
				num = (short)942867124;
				switch (num2 == num)
				{
				}
				num = (short)867172353;
				if (num != 0)
				{
				}
				num = (short)546570240;
				short num3 = num;
				num = (short)843317248;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)739291907;
				short num2 = num;
				num = (short)881177347;
				switch (num2 == num)
				{
				}
				num = (short)605421568;
				if (num != 0)
				{
				}
				num = (short)1950285824;
				short num3 = num;
				num = (short)1007943681;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000178 RID: 376 RVA: 0x0002A340 File Offset: 0x00028540
		// (set) Token: 0x06000179 RID: 377 RVA: 0x0002A3F0 File Offset: 0x000285F0
		public global::ASK.Core.AskStatusType Type
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)391884520;
				short num2 = num;
				num = (short)969322216;
				switch (num2 == num)
				{
				}
				num = (short)697237504;
				if (num != 0)
				{
				}
				num = (short)1811742720;
				short num3 = num;
				num = (short)1301151745;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)936400250;
				short num2 = num;
				num = (short)78534010;
				switch (num2 == num)
				{
				}
				num = (short)1005256705;
				if (num != 0)
				{
				}
				num = (short)576651264;
				short num3 = num;
				num = (short)274333696;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0002A4A4 File Offset: 0x000286A4
		// (set) Token: 0x0600017B RID: 379 RVA: 0x0002A554 File Offset: 0x00028754
		public string Message
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)778876615;
				short num2 = num;
				num = (short)1164293831;
				switch (num2 == num)
				{
				}
				num = (short)1140719616;
				if (num != 0)
				{
				}
				num = (short)1009188864;
				short num3 = num;
				num = (short)2126118913;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1535983111;
				short num2 = num;
				num = (short)1667972615;
				switch (num2 == num)
				{
				}
				num = (short)1625161729;
				if (num != 0)
				{
				}
				num = (short)36306944;
				short num3 = num;
				num = (short)1806434304;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0002A604 File Offset: 0x00028804
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1196886696 + A_1) + (global::System.IntPtr)64 + (global::System.IntPtr)43 + (global::System.IntPtr)40);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_5C;
			}
			IL_29:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_5C:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_29;
		}

		// Token: 0x040000D3 RID: 211
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private uint a;

		// Token: 0x040000D4 RID: 212
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::ASK.Core.AskStatusType b;

		// Token: 0x040000D5 RID: 213
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;
	}
}
