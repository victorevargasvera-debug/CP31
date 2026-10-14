using System;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.EntityModel.DataTransferObjects;

namespace Motorola.CommonCPS.RadioManagement.ConvertorExtensions
{
	// Token: 0x02000004 RID: 4
	public static class Entity2Dto
	{
		// Token: 0x06000006 RID: 6 RVA: 0x0000255C File Offset: 0x0000075C
		public static global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO ToDto(this global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile otarProfile)
		{
			short num = (short)56885248;
			short num2 = num;
			num = (short)1737079043;
			short num3 = num;
			num = (short)1997322499;
			switch (num3 == num)
			{
			}
			num = (short)954466304;
			if (num != 0)
			{
			}
			num = (short)1249509377;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO
			{
				OtarProfileUuid = otarProfile.Uuid,
				OtarProfileName = otarProfile.Profile,
				IndependentList = otarProfile.IndependentList,
				OtarId = otarProfile.OtarID
			};
		}
	}
}
