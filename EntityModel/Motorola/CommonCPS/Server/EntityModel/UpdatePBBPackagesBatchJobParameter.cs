using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000E9 RID: 233
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class UpdatePBBPackagesBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x00097304 File Offset: 0x00095504
		// (set) Token: 0x06000E33 RID: 3635 RVA: 0x000973B4 File Offset: 0x000955B4
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid RadioUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)568198839;
				short num2 = num;
				num = (short)13895351;
				switch (num2 == num)
				{
				}
				num = (short)515244032;
				short num3 = num;
				num = (short)1186791424;
				if (num != 0)
				{
				}
				num = (short)365756417;
				if (num != 0)
				{
				}
				return this.<RadioUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1988405853;
				short num2 = num;
				num = (short)512010845;
				switch (num2 == num)
				{
				}
				num = (short)1378942976;
				short num3 = num;
				num = (short)519176193;
				if (num != 0)
				{
				}
				num = (short)1198325760;
				if (num != 0)
				{
				}
				this.<RadioUuid>k__BackingField = value;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x00097464 File Offset: 0x00095664
		// (set) Token: 0x06000E35 RID: 3637 RVA: 0x00097518 File Offset: 0x00095718
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType PackageType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)861493335;
				short num2 = num;
				num = (short)807819351;
				switch (num2 == num)
				{
				}
				num = (short)2013986816;
				short num3 = num;
				num = (short)1875050497;
				if (num != 0)
				{
				}
				num = (short)411369472;
				if (num != 0)
				{
				}
				return this.<PackageType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)537843799;
				short num2 = num;
				num = (short)961009751;
				switch (num2 == num)
				{
				}
				num = (short)1528823808;
				short num3 = num;
				num = (short)1660682240;
				if (num != 0)
				{
				}
				num = (short)220594177;
				if (num != 0)
				{
				}
				this.<PackageType>k__BackingField = value;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x000975CC File Offset: 0x000957CC
		// (set) Token: 0x06000E37 RID: 3639 RVA: 0x00097678 File Offset: 0x00095878
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::System.Guid> PackageUuids
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1488696667;
				short num2 = num;
				num = (short)1851831643;
				switch (num2 == num)
				{
				}
				num = (short)935854080;
				short num3 = num;
				num = (short)749797376;
				if (num != 0)
				{
				}
				num = (short)1501954049;
				if (num != 0)
				{
				}
				return this.<PackageUuids>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1488011596;
				short num2 = num;
				num = (short)2046574924;
				switch (num2 == num)
				{
				}
				num = (short)88670208;
				short num3 = num;
				num = (short)1734344705;
				if (num != 0)
				{
				}
				num = (short)886243328;
				if (num != 0)
				{
				}
				this.<PackageUuids>k__BackingField = value;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x0009772C File Offset: 0x0009592C
		// (set) Token: 0x06000E39 RID: 3641 RVA: 0x000977DC File Offset: 0x000959DC
		[global::System.Runtime.Serialization.DataMember]
		public string PackageVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)665744448;
				short num2 = num;
				num = (short)2040034368;
				switch (num2 == num)
				{
				}
				num = (short)1178206208;
				short num3 = num;
				num = (short)525664256;
				if (num != 0)
				{
				}
				num = (short)1700397057;
				if (num != 0)
				{
				}
				return this.<PackageVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)619644840;
				short num2 = num;
				num = (short)2084505512;
				switch (num2 == num)
				{
				}
				num = (short)1975648256;
				short num3 = num;
				num = (short)1263271936;
				if (num != 0)
				{
				}
				num = (short)528678913;
				if (num != 0)
				{
				}
				this.<PackageVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x00097890 File Offset: 0x00095A90
		// (set) Token: 0x06000E3B RID: 3643 RVA: 0x00097940 File Offset: 0x00095B40
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateSet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1234273967;
				short num2 = num;
				num = (short)1246004911;
				switch (num2 == num)
				{
				}
				num = (short)1441202176;
				short num3 = num;
				num = (short)773259264;
				if (num != 0)
				{
				}
				num = (short)717881345;
				if (num != 0)
				{
				}
				return this.<ValidateSet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)689501694;
				short num2 = num;
				num = (short)1587410430;
				switch (num2 == num)
				{
				}
				num = (short)715325440;
				short num3 = num;
				num = (short)1355612161;
				if (num != 0)
				{
				}
				num = (short)408420352;
				if (num != 0)
				{
				}
				this.<ValidateSet>k__BackingField = value;
			}
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x000979F4 File Offset: 0x00095BF4
		public UpdatePBBPackagesBatchJobParameter(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType type, global::System.Collections.Generic.List<global::System.Guid> packageUuids, string packageVersion, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet)
		{
			int a_ = 1;
			base..ctor(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any);
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.RadioUuid = radioUuid;
			this.PackageType = type;
			if (packageUuids == null)
			{
				throw new global::System.InvalidOperationException(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("ꣾ猀氂欄怆⤈嬊氌紎瀐縒瀔挖簘椚㴜㈞Ġ匢䐤䐦䈨䨪䨬䨮搰䘲尴匶䨸", a_));
			}
			this.PackageUuids = packageUuids;
			this.PackageVersion = packageVersion;
			this.ValidateSet = validateSet;
			if (type == global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.HomeSetPackage)
			{
				base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.UpdatePBBHomeSetPackage;
				return;
			}
			throw new global::System.NotSupportedException();
		}
	}
}
