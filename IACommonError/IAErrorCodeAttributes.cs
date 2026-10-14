using System;
using System.Runtime.CompilerServices;

namespace IACustomException
{
	// Token: 0x02000006 RID: 6
	[global::System.AttributeUsage(global::System.AttributeTargets.Field, AllowMultiple = false)]
	public sealed class IAErrorCodeAttributes : global::System.Attribute
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002A6C File Offset: 0x00000C6C
		public IAErrorCodeAttributes()
		{
			this.Retriable = false;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002A88 File Offset: 0x00000C88
		public IAErrorCodeAttributes(bool retriable)
		{
			this.Retriable = retriable;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002AA4 File Offset: 0x00000CA4
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002B54 File Offset: 0x00000D54
		public bool Retriable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1667235841;
				if (num != 0)
				{
				}
				num = (short)502726656;
				short num2 = num;
				num = (short)1981471913;
				short num3 = num;
				num = (short)1405738153;
				switch (num3 == num)
				{
				}
				num = (short)1387134976;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1900937217;
				if (num != 0)
				{
				}
				num = (short)1914372096;
				short num2 = num;
				num = (short)1424132144;
				short num3 = num;
				num = (short)95651888;
				switch (num3 == num)
				{
				}
				num = (short)586809344;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002C00 File Offset: 0x00000E00
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1600199221 + A_1) + (global::System.IntPtr)88 + (global::System.IntPtr)69);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_55;
			}
			IL_22:
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
			IL_55:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_22;
		}

		// Token: 0x04000031 RID: 49
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a;
	}
}
