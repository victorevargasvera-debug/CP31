using System;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter
{
	// Token: 0x0200000A RID: 10
	internal class b : global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.d
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00003BC8 File Offset: 0x00001DC8
		protected override global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense b(global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem A_0)
		{
			short num = (short)1089889781;
			short num2 = num;
			num = (short)1791649269;
			switch (num2 == num)
			{
			default:
			{
				num = (short)186449920;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1143078913;
			if (num != 0)
			{
			}
			num = (short)30146560;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.NameStyleRadioSoftwareLicense
			{
				Name = A_0.productName,
				AID = A_0.activationId,
				Notice = A_0.notice
			};
		}
	}
}
