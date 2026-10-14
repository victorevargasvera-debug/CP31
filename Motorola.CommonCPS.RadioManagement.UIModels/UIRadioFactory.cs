using System;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000048 RID: 72
	public class UIRadioFactory
	{
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0001BA58 File Offset: 0x00019C58
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase NewRadio
		{
			get
			{
				short num = (short)1867896048;
				short num2 = num;
				num = (short)1503057136;
				switch (num2 == num)
				{
				}
				num = (short)474742785;
				if (num != 0)
				{
				}
				num = (short)487587840;
				if (num != 0)
				{
				}
				num = (short)1121058816;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio();
			}
		}
	}
}
