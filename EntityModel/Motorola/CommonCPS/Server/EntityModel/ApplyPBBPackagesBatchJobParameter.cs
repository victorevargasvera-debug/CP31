using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000B5 RID: 181
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ApplyPBBPackagesBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.ApplyGeneralPackagesBatchJobParameter
	{
		// Token: 0x06000D00 RID: 3328 RVA: 0x0008BB28 File Offset: 0x00089D28
		public ApplyPBBPackagesBatchJobParameter(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType type, global::System.Collections.Generic.List<global::System.Guid> packageUuids, string packageVersion, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet)
		{
			int a_ = 11;
			base..ctor(batchJobContainerUuid, radioUuid, type, packageUuids, packageVersion, validateSet);
			base.BatchJobContainerUuid = batchJobContainerUuid;
			base.RadioUuid = radioUuid;
			base.PackageType = type;
			if (packageUuids == null)
			{
				throw new global::System.InvalidOperationException(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("师礊戌愎瘐㌒䔔瘖欘稚瀜稞唠䘢圤ܦШପ崬丮到堲吴倶尸渺䠼嘾╀あ", a_));
			}
			base.PackageUuids = packageUuids;
			base.PackageVersion = packageVersion;
			base.ValidateSet = validateSet;
			if (type == global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.Firmware)
			{
				base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SelectPBBFirmware;
				return;
			}
			if (type == global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.GeneralPackage)
			{
				base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SelectGeneralPackage;
				return;
			}
			if (type == global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.HomeSetPackage)
			{
				base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SelectPBBHomeSetPackage;
				return;
			}
			if (type == global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.Application)
			{
				base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SelectPBBAPKApplication;
				return;
			}
			if (type == global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.Certificate)
			{
				base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SelectPBBCertificate;
				return;
			}
			throw new global::System.NotSupportedException();
		}
	}
}
