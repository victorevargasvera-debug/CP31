using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000B2 RID: 178
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ApplyGeneralPackagesBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x0008AAFC File Offset: 0x00088CFC
		// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x0008ABAC File Offset: 0x00088DAC
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid RadioUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1505755137;
				if (num != 0)
				{
				}
				num = (short)349748444;
				short num2 = num;
				num = (short)1778629852;
				switch (num2 == num)
				{
				default:
				{
					num = (short)363134976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2126512128;
				if (num != 0)
				{
				}
				return this.<RadioUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2143748097;
				if (num != 0)
				{
				}
				num = (short)916344671;
				short num2 = num;
				num = (short)1803898719;
				switch (num2 == num)
				{
				default:
				{
					num = (short)418119680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1860173824;
				if (num != 0)
				{
				}
				this.<RadioUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x0008AC5C File Offset: 0x00088E5C
		// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x0008AD08 File Offset: 0x00088F08
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType PackageType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1445702671;
				short num2 = num;
				num = (short)1436199951;
				switch (num2 == num)
				{
				}
				num = (short)1497104384;
				short num3 = num;
				num = (short)742195200;
				if (num != 0)
				{
				}
				num = (short)27131905;
				if (num != 0)
				{
				}
				return this.<PackageType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)634519553;
				if (num != 0)
				{
				}
				num = (short)806760577;
				short num2 = num;
				num = (short)709636225;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1293484032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)130613248;
				if (num != 0)
				{
				}
				this.<PackageType>k__BackingField = value;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x0008ADB8 File Offset: 0x00088FB8
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x0008AE68 File Offset: 0x00089068
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::System.Guid> PackageUuids
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1237398224;
				short num2 = num;
				num = (short)424162000;
				switch (num2 == num)
				{
				}
				num = (short)768933888;
				short num3 = num;
				num = (short)1124532225;
				if (num != 0)
				{
				}
				num = (short)693764096;
				if (num != 0)
				{
				}
				return this.<PackageUuids>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1485256294;
				short num2 = num;
				num = (short)1897412198;
				switch (num2 == num)
				{
				}
				num = (short)1957888000;
				short num3 = num;
				num = (short)740360193;
				if (num != 0)
				{
				}
				num = (short)1496252416;
				if (num != 0)
				{
				}
				this.<PackageUuids>k__BackingField = value;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x0008AF18 File Offset: 0x00089118
		// (set) Token: 0x06000CED RID: 3309 RVA: 0x0008AFC8 File Offset: 0x000891C8
		[global::System.Runtime.Serialization.DataMember]
		public string PackageVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1851744134;
				short num2 = num;
				num = (short)1814454150;
				switch (num2 == num)
				{
				}
				num = (short)91291648;
				short num3 = num;
				num = (short)1790181377;
				if (num != 0)
				{
				}
				num = (short)1750728704;
				if (num != 0)
				{
				}
				return this.<PackageVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)685285169;
				short num2 = num;
				num = (short)2036703025;
				switch (num2 == num)
				{
				}
				num = (short)330498048;
				short num3 = num;
				num = (short)897646592;
				if (num != 0)
				{
				}
				num = (short)1632763905;
				if (num != 0)
				{
				}
				this.<PackageVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x0008B078 File Offset: 0x00089278
		// (set) Token: 0x06000CEF RID: 3311 RVA: 0x0008B128 File Offset: 0x00089328
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateSet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1210665070;
				short num2 = num;
				num = (short)854935662;
				switch (num2 == num)
				{
				}
				num = (short)2095644672;
				short num3 = num;
				num = (short)1994129409;
				if (num != 0)
				{
				}
				num = (short)1948385280;
				if (num != 0)
				{
				}
				return this.<ValidateSet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)844209694;
				short num2 = num;
				num = (short)1863097886;
				switch (num2 == num)
				{
				}
				num = (short)1414070272;
				short num3 = num;
				num = (short)585760769;
				if (num != 0)
				{
				}
				num = (short)1652555776;
				if (num != 0)
				{
				}
				this.<ValidateSet>k__BackingField = value;
			}
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x0008B1D8 File Offset: 0x000893D8
		public ApplyGeneralPackagesBatchJobParameter(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType type, global::System.Collections.Generic.List<global::System.Guid> packageUuids, string packageVersion, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet)
		{
			int a_ = 19;
			base..ctor(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any);
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.RadioUuid = radioUuid;
			this.PackageType = type;
			if (packageUuids == null)
			{
				throw new global::System.InvalidOperationException(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䘐愒稔礖縘㬚䴜縞匠䈢䠤䈦崨个弬༮ᰰጲ䔴嘶娸债尼堾⑀ᙂい⹆ⵈ㡊", a_));
			}
			this.PackageUuids = packageUuids;
			this.PackageVersion = packageVersion;
			this.ValidateSet = validateSet;
			if (type == global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.GeneralPackage)
			{
				base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SelectGeneralPackage;
			}
		}
	}
}
