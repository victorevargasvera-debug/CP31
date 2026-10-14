using System;
using System.Collections.Generic;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200005E RID: 94
	internal class DataProviderService : global::Motorola.CommonCPS.RadioManagement.SharedServices.IDataProviderService
	{
		// Token: 0x060006CA RID: 1738 RVA: 0x00046678 File Offset: 0x00044878
		public int GetReferencedRadiosCount(global::System.Collections.Generic.List<global::System.Guid> templateUuidList)
		{
			short num = (short)1058750052;
			short num2 = num;
			num = (short)1837383268;
			switch (num2 == num)
			{
			}
			num = (short)347930624;
			if (num != 0)
			{
			}
			num = (short)1734017025;
			if (num != 0)
			{
			}
			num = (short)1912668160;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetReferencedRadiosCount(templateUuidList, false, true);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00046730 File Offset: 0x00044930
		public global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary, global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> GetReferencedRadios(global::System.Collections.Generic.List<global::System.Guid> templateUuidList, int startIndex, int count)
		{
			short num = (short)2042298369;
			if (num != 0)
			{
			}
			num = (short)364077485;
			short num2 = num;
			num = (short)1988256173;
			switch (num2 == num)
			{
			}
			num = (short)386924544;
			if (num != 0)
			{
			}
			num = (short)1458831360;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetReferencedRadiosbyTemplateList(templateUuidList, startIndex, count);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x000467EC File Offset: 0x000449EC
		public global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary, global::Motorola.CommonCPS.Server.EntityModel.MatrixRadioSummary> GetMatchedReferenceRadiosForUpgrade(global::System.Collections.Generic.List<global::System.Guid> matrixTemplateUuidList, global::System.Guid PCRFirmwareCodeplugGroupUuid, bool isAllowDowngrade, int startIndex, int count)
		{
			short num = (short)600017279;
			short num2 = num;
			num = (short)1773767039;
			switch (num2 == num)
			{
			}
			num = (short)1713700865;
			if (num != 0)
			{
			}
			num = (short)194248704;
			if (num != 0)
			{
			}
			num = (short)46923776;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetMatchedReferenceRadiosForUpgrade(matrixTemplateUuidList, PCRFirmwareCodeplugGroupUuid, isAllowDowngrade, startIndex, count);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x000468A4 File Offset: 0x00044AA4
		public int GetUpgradeMatchedMatrixRadiosCount(global::System.Collections.Generic.List<global::System.Guid> matrixTemplateUuidList, global::System.Guid pcrFWGroupUuid, bool isAllowDowngrade)
		{
			short num = (short)1547573972;
			short num2 = num;
			num = (short)1849629396;
			switch (num2 == num)
			{
			}
			num = (short)1931476993;
			if (num != 0)
			{
			}
			num = (short)1521090560;
			if (num != 0)
			{
			}
			num = (short)2135359488;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetUpgradeMatchedMatrixRadiosCount(matrixTemplateUuidList, pcrFWGroupUuid, isAllowDowngrade);
		}
	}
}
