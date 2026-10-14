using System;
using System.Collections.Generic;
using System.Globalization;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000073 RID: 115
	internal class ASTRORadioLicenseService : global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioLicenseServiceBase
	{
		// Token: 0x060007BC RID: 1980 RVA: 0x0005D4AC File Offset: 0x0005B6AC
		public ASTRORadioLicenseService(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor, global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROValidationService astroValidationService) : base(serverAccessor, astroValidationService)
		{
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x0005D4C4 File Offset: 0x0005B6C4
		public override global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase ConvertLicenseSummaryToLicense(global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary summary)
		{
			short num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase result;
			try
			{
				num = (short)430057632;
				short num2 = num;
				num = (short)1559570592;
				switch (num2 == num)
				{
				}
				num = (short)2114125825;
				if (num != 0)
				{
				}
				num = (short)454819840;
				if (num != 0)
				{
				}
				result = new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense
				{
					FeatureName = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().ParseFeatureCode(summary.FeatureName, summary.ModelNumber),
					FlashCode = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroDecodeFlashCode(summary.FlashCode),
					ModelNumber = summary.ModelNumber,
					SerialNumber = summary.SerialNumber,
					RadioAlias = summary.RadioAlias,
					FeatureStatus = this.ParseFeatureStatus((global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus)summary.FeatureStatus),
					DeviceUuid = summary.DeviceUuid,
					RadioLicenseUuid = summary.RadioFeatureUuid,
					RawData = summary,
					Comments = summary.Comments
				};
			}
			catch
			{
				result = null;
			}
			num = (short)1992622080;
			short num3 = num;
			return result;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x0005D62C File Offset: 0x0005B82C
		public override global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase ConvertLicenseSummaryToLicenseFeatureViewBase(global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary summary)
		{
			short num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase result;
			try
			{
				num = (short)1722292519;
				short num2 = num;
				num = (short)575936807;
				switch (num2 == num)
				{
				}
				num = (short)75366400;
				if (num != 0)
				{
				}
				result = new global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase
				{
					FeatureID = summary.FeatureName.ToString(global::System.Globalization.CultureInfo.CurrentCulture),
					FeatureName = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().ParseFeatureCode(summary.FeatureName, summary.ModelNumber),
					RadioCount = summary.ReferenceCount.ToString(global::System.Globalization.CultureInfo.CurrentCulture),
					ModelNumber = summary.ModelNumber
				};
			}
			catch
			{
				result = null;
			}
			num = (short)1757282305;
			if (num != 0)
			{
			}
			num = (short)1807482880;
			short num3 = num;
			return result;
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x0005D754 File Offset: 0x0005B954
		public override global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase ConvertLicenseSummaryToLicenseRadioViewBase(global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary summary)
		{
			short num = (short)298916835;
			short num2 = num;
			num = (short)408493027;
			switch (num2 == num)
			{
			}
			num = (short)1672413185;
			if (num != 0)
			{
			}
			num = (short)56688640;
			if (num != 0)
			{
			}
			num = (short)1308557312;
			short num3 = num;
			return new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicenseRadioView
			{
				FlashCode = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroDecodeFlashCode(summary.FlashCode),
				FeatureCount = summary.ReferenceCount.ToString(global::System.Globalization.CultureInfo.CurrentCulture),
				ModelNumber = summary.ModelNumber,
				RadioAlias = summary.RadioAlias,
				SerialNumber = summary.SerialNumber,
				RadioGUID = summary.DeviceUuid
			};
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0005D860 File Offset: 0x0005BA60
		public override string ParseFeatureStatus(global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus featureStatus)
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num;
			short num2;
			string result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1439563782;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)648806410;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (featureStatus <= global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus.Registered)
					{
						num2 = (short)883032072;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)938803214;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return result;
				case 4:
					return result;
				case 5:
					return result;
				case 6:
					return result;
				case 7:
					num2 = (short)873725953;
					if (num2 != 0)
					{
					}
					num2 = (short)1163460611;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)1072103439;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					return result;
				case 10:
					if (featureStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus.ScheduledActivation)
					{
						num2 = (short)354156544;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::Motorola.CommonCPS.ResourceRepository.Resources.License_Status_ScheduledActivation;
					num2 = (short)203882505;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (featureStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus.Registered)
					{
						num2 = (short)1110376455;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::Motorola.CommonCPS.ResourceRepository.Resources.License_Status_Registered;
					num2 = (short)1552941069;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					num2 = (short)288227339;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					return result;
				case 14:
					if (featureStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus.PendingActive)
					{
						num2 = (short)1277558785;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::Motorola.CommonCPS.ResourceRepository.Resources.License_Status_PendingActive;
					num2 = (short)1422589957;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					while (featureStatus == global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus.Active)
					{
						num2 = (short)1897791488;
						short num3 = num2;
						result = global::Motorola.CommonCPS.ResourceRepository.Resources.License_Status_Astro_Active;
						num2 = (short)886081974;
						short num4 = num2;
						num2 = (short)1673234870;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)1773142016;
							if (num2 != 0)
							{
							}
							num2 = (short)92602372;
							num = (int)((global::System.IntPtr)num2);
							goto IL_0A;
						}
					}
					num2 = (short)1341587468;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_50;
			}
			return result;
			IL_50:
			result = string.Empty;
			num2 = (short)586285058;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0005DB40 File Offset: 0x0005BD40
		public override global::Motorola.CommonCPS.Server.EntityModel.FeatureList GetFeatureIDs(string serialNumber, byte[] featureList)
		{
			short num = (short)1522073601;
			if (num != 0)
			{
			}
			num = (short)1723839327;
			short num2 = num;
			num = (short)2136060767;
			switch (num2 == num)
			{
			}
			num = (short)683933696;
			if (num != 0)
			{
			}
			num = (short)1807155200;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x0005DBEC File Offset: 0x0005BDEC
		public override global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.CpsFeatureItem> RecoverDeviceLicenses(string radioSerialNumber, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer parentMeasure)
		{
			short num = (short)742124980;
			short num2 = num;
			num = (short)950988212;
			switch (num2 == num)
			{
			}
			num = (short)945946625;
			if (num != 0)
			{
			}
			num = (short)1274413056;
			if (num != 0)
			{
			}
			num = (short)199294976;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
