using System;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000039 RID: 57
	public static class RadioFeatureOperationFactory
	{
		// Token: 0x0600058F RID: 1423 RVA: 0x0003C138 File Offset: 0x0003A338
		public static global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioFeatureOperation GetInstance()
		{
			short num = (short)642965214;
			short num2 = num;
			num = (short)666164958;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_E8:
				global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.a = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROTemplateOperation();
				num = (short)996868098;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)2088435713;
				if (num != 0)
				{
				}
				num = (short)1885798400;
				if (num != 0)
				{
				}
				num = (short)1608318977;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_E8;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_A2;
					}
					continue;
				case 2:
					goto IL_109;
				}
				IL_A2:
				if (global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.a != null)
				{
					break;
				}
				num = (short)1719861248;
				short num4 = num;
				num = (short)1167261696;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_109:
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.a;
		}

		// Token: 0x04000062 RID: 98
		private static global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioFeatureOperation a;
	}
}
