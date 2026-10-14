using System;
using Microsoft.Practices.Prism.Events;

namespace Motorola.CommonCPS.RadioManagement.InteractionHelper
{
	// Token: 0x02000005 RID: 5
	public class InteractionFactory
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x0000A450 File Offset: 0x00008650
		public static global::Motorola.CommonCPS.RadioManagement.InteractionHelper.IInteraction GetInstance()
		{
			short num = (short)1061552130;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)623443969;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_E7;
				case 1:
					global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.a = new global::Motorola.CommonCPS.RadioManagement.InteractionHelper.a();
					num = (short)233111552;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				}
				IL_58:
				num = (short)800326944;
				short num3 = num;
				num = (short)677709088;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_E9;
				default:
					num = (short)1269497856;
					if (num != 0)
					{
					}
					if (global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.a != null)
					{
						goto IL_E9;
					}
					num = (short)604635137;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_E7:
			IL_E9:
			num = (short)579010560;
			short num4 = num;
			return global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.a;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000A578 File Offset: 0x00008778
		public static void CreateInstance(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			short num = (short)18287400;
			short num2 = num;
			num = (short)1038027560;
			switch (num2 == num)
			{
			}
			num = (short)314900481;
			if (num != 0)
			{
			}
			num = (short)1666514944;
			short num3 = num;
			num = (short)1024917504;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.a = new global::Motorola.CommonCPS.RadioManagement.InteractionHelper.a(eventAggregator);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000A62C File Offset: 0x0000882C
		public static void SetInteraction(global::Motorola.CommonCPS.RadioManagement.InteractionHelper.IInteraction value)
		{
			short num = (short)93650945;
			if (num != 0)
			{
			}
			num = (short)1449265589;
			short num2 = num;
			num = (short)727845301;
			switch (num2 == num)
			{
			}
			num = (short)695140352;
			short num3 = num;
			num = (short)527958016;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.a = value;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000A6F4 File Offset: 0x000088F4
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1653442234 + A_1) + (global::System.IntPtr)93 + (global::System.IntPtr)75 + (global::System.IntPtr)59 + (global::System.IntPtr)41 + (global::System.IntPtr)60);
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

		// Token: 0x04000004 RID: 4
		private static global::Motorola.CommonCPS.RadioManagement.InteractionHelper.IInteraction a;
	}
}
