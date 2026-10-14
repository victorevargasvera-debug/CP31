using System;
using System.Runtime.CompilerServices;

namespace Motorola.Common.CustomException
{
	// Token: 0x0200000E RID: 14
	[global::System.AttributeUsage(global::System.AttributeTargets.Field, AllowMultiple = false)]
	public sealed class ErrorCodeAttributes : global::System.Attribute
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00004A98 File Offset: 0x00002C98
		public ErrorCodeAttributes()
		{
			this.Retriable = false;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004AB4 File Offset: 0x00002CB4
		public ErrorCodeAttributes(bool retriable)
		{
			this.Retriable = retriable;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00004AD0 File Offset: 0x00002CD0
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00004B80 File Offset: 0x00002D80
		public bool Retriable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)104331515;
				short num2 = num;
				num = (short)925038843;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1536753664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1633091585;
				if (num != 0)
				{
				}
				num = (short)671547392;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)466820648;
				short num2 = num;
				num = (short)639442472;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1977352192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)149225472;
				if (num != 0)
				{
				}
				num = (short)2060845057;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00004C30 File Offset: 0x00002E30
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1770733638 + A_1) + (global::System.IntPtr)99 + (global::System.IntPtr)39);
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

		// Token: 0x04001454 RID: 5204
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a;
	}
}
