using System;
using System.Collections.Generic;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000074 RID: 116
	internal abstract class RadioLicenseServiceBase : global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceBase, global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioLicenseService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x060007C3 RID: 1987 RVA: 0x0005DC9C File Offset: 0x0005BE9C
		public RadioLicenseServiceBase(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor, global::Motorola.CommonCPS.RadioManagement.SharedServices.IValidationServiceBase validationServiceBase) : base(serverAccessor, validationServiceBase)
		{
		}

		// Token: 0x060007C4 RID: 1988
		public abstract global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase ConvertLicenseSummaryToLicense(global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary summary);

		// Token: 0x060007C5 RID: 1989
		public abstract global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase ConvertLicenseSummaryToLicenseFeatureViewBase(global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary summary);

		// Token: 0x060007C6 RID: 1990
		public abstract global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase ConvertLicenseSummaryToLicenseRadioViewBase(global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary summary);

		// Token: 0x060007C7 RID: 1991
		public abstract string ParseFeatureStatus(global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus featureStatus);

		// Token: 0x060007C8 RID: 1992
		public abstract global::Motorola.CommonCPS.Server.EntityModel.FeatureList GetFeatureIDs(string serialNumber, byte[] featureList);

		// Token: 0x060007C9 RID: 1993
		public abstract global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.CpsFeatureItem> RecoverDeviceLicenses(string radioSerialNumber, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer parentMeasure);

		// Token: 0x060007CA RID: 1994 RVA: 0x0005DCB4 File Offset: 0x0005BEB4
		public void UpdateRadioFeatureComments(global::System.Guid radioFeatureUuid, string comments)
		{
			short num = (short)1640169472;
			short num2 = num;
			num = (short)448657617;
			short num3 = num;
			num = (short)263256273;
			switch (num3 == num)
			{
			}
			num = (short)776863745;
			if (num != 0)
			{
			}
			num = (short)1806434304;
			if (num != 0)
			{
			}
			base.ServerAccessor.UpdateRadioFeatureComments(radioFeatureUuid, comments);
		}
	}
}
