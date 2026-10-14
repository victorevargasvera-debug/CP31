using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000E8 RID: 232
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class SubmitRadioFeatureBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x000968C4 File Offset: 0x00094AC4
		// (set) Token: 0x06000E23 RID: 3619 RVA: 0x00096974 File Offset: 0x00094B74
		[global::System.Runtime.Serialization.DataMember]
		public bool IsSubmit
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1951639725;
				short num2 = num;
				num = (short)136489133;
				switch (num2 == num)
				{
				}
				num = (short)723910656;
				short num3 = num;
				num = (short)1573519361;
				if (num != 0)
				{
				}
				num = (short)1882259456;
				if (num != 0)
				{
				}
				return this.<IsSubmit>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)116653319;
				short num2 = num;
				num = (short)628555015;
				switch (num2 == num)
				{
				}
				num = (short)1854275584;
				short num3 = num;
				num = (short)1564868608;
				if (num != 0)
				{
				}
				num = (short)1006174209;
				if (num != 0)
				{
				}
				this.<IsSubmit>k__BackingField = value;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x00096A24 File Offset: 0x00094C24
		// (set) Token: 0x06000E25 RID: 3621 RVA: 0x00096AD4 File Offset: 0x00094CD4
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid RadioUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1437663233;
				if (num != 0)
				{
				}
				num = (short)1639973999;
				short num2 = num;
				num = (short)681444463;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1659371520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)649461760;
				if (num != 0)
				{
				}
				return this.<RadioUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1063556683;
				short num2 = num;
				num = (short)555325003;
				switch (num2 == num)
				{
				}
				num = (short)1157890048;
				short num3 = num;
				num = (short)1011744768;
				if (num != 0)
				{
				}
				num = (short)1772421121;
				if (num != 0)
				{
				}
				this.<RadioUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06000E26 RID: 3622 RVA: 0x00096B84 File Offset: 0x00094D84
		// (set) Token: 0x06000E27 RID: 3623 RVA: 0x00096C30 File Offset: 0x00094E30
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid TemplateUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1815428963;
				short num2 = num;
				num = (short)1713782627;
				switch (num2 == num)
				{
				}
				num = (short)78053376;
				short num3 = num;
				num = (short)202375169;
				if (num != 0)
				{
				}
				num = (short)672268288;
				if (num != 0)
				{
				}
				return this.<TemplateUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)818458853;
				short num2 = num;
				num = (short)244035813;
				switch (num2 == num)
				{
				}
				num = (short)823328768;
				short num3 = num;
				num = (short)140640257;
				if (num != 0)
				{
				}
				num = (short)547094528;
				if (num != 0)
				{
				}
				this.<TemplateUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x00096CE0 File Offset: 0x00094EE0
		// (set) Token: 0x06000E29 RID: 3625 RVA: 0x00096D90 File Offset: 0x00094F90
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> FeatureList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)550109196;
				short num2 = num;
				num = (short)665845772;
				switch (num2 == num)
				{
				}
				num = (short)1255604224;
				short num3 = num;
				num = (short)1111687169;
				if (num != 0)
				{
				}
				num = (short)1832058880;
				if (num != 0)
				{
				}
				return this.<FeatureList>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)711224242;
				short num2 = num;
				num = (short)1603890098;
				switch (num2 == num)
				{
				}
				num = (short)1136001024;
				short num3 = num;
				num = (short)1583349760;
				if (num != 0)
				{
				}
				num = (short)619118593;
				if (num != 0)
				{
				}
				this.<FeatureList>k__BackingField = value;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x00096E40 File Offset: 0x00095040
		// (set) Token: 0x06000E2B RID: 3627 RVA: 0x00096EF0 File Offset: 0x000950F0
		[global::System.Runtime.Serialization.DataMember]
		public byte[] Response
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)785645569;
				if (num != 0)
				{
				}
				num = (short)1160183511;
				short num2 = num;
				num = (short)2014510807;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1226244096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1373765632;
				if (num != 0)
				{
				}
				return this.<Response>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)43211758;
				short num2 = num;
				num = (short)10378222;
				switch (num2 == num)
				{
				}
				num = (short)344588288;
				short num3 = num;
				num = (short)754647040;
				if (num != 0)
				{
				}
				num = (short)2082471937;
				if (num != 0)
				{
				}
				this.<Response>k__BackingField = value;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x00096FA0 File Offset: 0x000951A0
		// (set) Token: 0x06000E2D RID: 3629 RVA: 0x0009704C File Offset: 0x0009524C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.Dictionary<string, object> SyncDataToCP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1709528465;
				short num2 = num;
				num = (short)220353937;
				switch (num2 == num)
				{
				}
				num = (short)2024996864;
				short num3 = num;
				num = (short)226623489;
				if (num != 0)
				{
				}
				num = (short)445317120;
				if (num != 0)
				{
				}
				return this.<SyncDataToCP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1574502401;
				if (num != 0)
				{
				}
				num = (short)47252476;
				short num2 = num;
				num = (short)58786812;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1099497472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)449773568;
				if (num != 0)
				{
				}
				this.<SyncDataToCP>k__BackingField = value;
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x00097100 File Offset: 0x00095300
		// (set) Token: 0x06000E2F RID: 3631 RVA: 0x000971B0 File Offset: 0x000953B0
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateEntitySets
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)542143907;
				short num2 = num;
				num = (short)1964799395;
				switch (num2 == num)
				{
				}
				num = (short)1917321216;
				short num3 = num;
				num = (short)299237376;
				if (num != 0)
				{
				}
				num = (short)35258369;
				if (num != 0)
				{
				}
				return this.<ValidateEntitySets>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1678843366;
				short num2 = num;
				num = (short)1044782566;
				switch (num2 == num)
				{
				}
				num = (short)1791492096;
				short num3 = num;
				num = (short)203030529;
				if (num != 0)
				{
				}
				num = (short)1789198336;
				if (num != 0)
				{
				}
				this.<ValidateEntitySets>k__BackingField = value;
			}
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00097264 File Offset: 0x00095464
		public SubmitRadioFeatureBatchJobParameter(global::System.Guid radioUuid, global::System.Guid templateUuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> featureList, byte[] response, global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet, global::System.Collections.Generic.Dictionary<string, object> syncDataToCP) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.RadioUuid = radioUuid;
			this.TemplateUuid = templateUuid;
			this.FeatureList = featureList;
			this.Response = response;
			this.SyncDataToCP = syncDataToCP;
			this.ValidateEntitySets = entitySet;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SubmitAppLicense;
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x000972BC File Offset: 0x000954BC
		public SubmitRadioFeatureBatchJobParameter(global::System.Guid radioUuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> featureList, bool isSubmit, byte[] response, global::System.Guid batchJobContainerUuid) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.RadioUuid = radioUuid;
			this.FeatureList = featureList;
			this.IsSubmit = isSubmit;
			this.Response = response;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SubmitAppLicense;
		}
	}
}
