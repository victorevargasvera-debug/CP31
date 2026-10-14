using System;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand
{
	// Token: 0x02000053 RID: 83
	public class CompositeCommandBuilderFactory : global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.ICompositeCommandBuilderFactory
	{
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000230 RID: 560 RVA: 0x000213E0 File Offset: 0x0001F5E0
		public global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.ICompositeCommandBuilder CreateInstance
		{
			get
			{
				short num = (short)2024214768;
				short num2 = num;
				num = (short)146215152;
				switch (num2 == num)
				{
				}
				num = (short)1238433792;
				short num3 = num;
				num = (short)2093744129;
				if (num != 0)
				{
				}
				num = (short)871497728;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilder();
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000214A4 File Offset: 0x0001F6A4
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(266122314 + A_1) + (global::System.IntPtr)65 + (global::System.IntPtr)4 + (global::System.IntPtr)31 + (global::System.IntPtr)97 + (global::System.IntPtr)8);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_6A;
			}
			IL_37:
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
			IL_6A:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_37;
		}
	}
}
