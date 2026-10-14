using System;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x0200002B RID: 43
	public class DefinedPACTypeAttribute : global::System.Attribute
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00003170 File Offset: 0x00001370
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00003220 File Offset: 0x00001420
		public global::Motorola.CommonCPS.Server.CommonDBConstants.PACType PacType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1588003253;
				short num2 = num;
				num = (short)513278389;
				switch (num2 == num)
				{
				}
				num = (short)1321271297;
				if (num != 0)
				{
				}
				num = (short)1307770880;
				short num3 = num;
				num = (short)794820608;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)453626380;
				short num2 = num;
				num = (short)1450953228;
				switch (num2 == num)
				{
				}
				num = (short)1098973185;
				if (num != 0)
				{
				}
				num = (short)581042176;
				short num3 = num;
				num = (short)1474822144;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000032D4 File Offset: 0x000014D4
		public DefinedPACTypeAttribute(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType pacType)
		{
			this.PacType = pacType;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000032F0 File Offset: 0x000014F0
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(674866551 + A_1) + (global::System.IntPtr)86 + (global::System.IntPtr)13 + (global::System.IntPtr)37 + (global::System.IntPtr)43);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_63;
			}
			IL_30:
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
			IL_63:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_30;
		}

		// Token: 0x0400013E RID: 318
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.CommonDBConstants.PACType a;
	}
}
