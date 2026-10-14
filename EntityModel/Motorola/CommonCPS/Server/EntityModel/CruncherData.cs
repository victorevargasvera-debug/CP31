using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000F9 RID: 249
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class CruncherData
	{
		// Token: 0x06000F19 RID: 3865 RVA: 0x000A04D0 File Offset: 0x0009E6D0
		public CruncherData()
		{
			this.arvFile = null;
			this.pbaFile = null;
			this.ctFile = null;
			this.InternalUpData = null;
			this.IsMigrationJob = false;
			this.IsSROJob = false;
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06000F1A RID: 3866 RVA: 0x000A0510 File Offset: 0x0009E710
		public bool IsRestoreJob
		{
			get
			{
				short num = (short)133233333;
				short num2 = num;
				num = (short)1794177717;
				switch (num2 == num)
				{
				}
				num = (short)1551171585;
				if (num != 0)
				{
				}
				num = (short)602996736;
				short num3 = num;
				num = (short)357826560;
				if (num != 0)
				{
				}
				return this.RestoreTargetPbaFile != null;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06000F1B RID: 3867 RVA: 0x000A05C4 File Offset: 0x0009E7C4
		// (set) Token: 0x06000F1C RID: 3868 RVA: 0x000A0670 File Offset: 0x0009E870
		[global::System.Runtime.Serialization.DataMember]
		public string PCRKeysIdAndValue_ForRestore
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1687071732;
				short num2 = num;
				num = (short)245214196;
				switch (num2 == num)
				{
				}
				num = (short)1705639936;
				short num3 = num;
				num = (short)593362945;
				if (num != 0)
				{
				}
				num = (short)264044544;
				if (num != 0)
				{
				}
				return this.<PCRKeysIdAndValue_ForRestore>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1642155606;
				short num2 = num;
				num = (short)22236758;
				switch (num2 == num)
				{
				}
				num = (short)2096758784;
				short num3 = num;
				num = (short)716242945;
				if (num != 0)
				{
				}
				num = (short)887029760;
				if (num != 0)
				{
				}
				this.<PCRKeysIdAndValue_ForRestore>k__BackingField = value;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x000A0720 File Offset: 0x0009E920
		// (set) Token: 0x06000F1E RID: 3870 RVA: 0x000A07D0 File Offset: 0x0009E9D0
		[global::System.Runtime.Serialization.DataMember]
		public bool IsMigrationJob
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1105441283;
				short num2 = num;
				num = (short)381858307;
				switch (num2 == num)
				{
				}
				num = (short)1012465664;
				short num3 = num;
				num = (short)1361641472;
				if (num != 0)
				{
				}
				num = (short)845611009;
				if (num != 0)
				{
				}
				return this.<IsMigrationJob>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)52465517;
				short num2 = num;
				num = (short)789155693;
				switch (num2 == num)
				{
				}
				num = (short)569114624;
				short num3 = num;
				num = (short)1473708033;
				if (num != 0)
				{
				}
				num = (short)1799684096;
				if (num != 0)
				{
				}
				this.<IsMigrationJob>k__BackingField = value;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x000A0884 File Offset: 0x0009EA84
		// (set) Token: 0x06000F20 RID: 3872 RVA: 0x000A0934 File Offset: 0x0009EB34
		[global::System.Runtime.Serialization.DataMember]
		public bool IsSROJob
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1237516289;
				if (num != 0)
				{
				}
				num = (short)1338369654;
				short num2 = num;
				num = (short)1776084598;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1624309760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)154337280;
				if (num != 0)
				{
				}
				return this.<IsSROJob>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1728588271;
				short num2 = num;
				num = (short)1829054959;
				switch (num2 == num)
				{
				}
				num = (short)1027932160;
				short num3 = num;
				num = (short)1874657281;
				if (num != 0)
				{
				}
				num = (short)1593049088;
				if (num != 0)
				{
				}
				this.<IsSROJob>k__BackingField = value;
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x000A09E0 File Offset: 0x0009EBE0
		// (set) Token: 0x06000F22 RID: 3874 RVA: 0x000A0A90 File Offset: 0x0009EC90
		[global::System.Runtime.Serialization.DataMember]
		public byte[] ProvTables
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1767511708;
				short num2 = num;
				num = (short)434247324;
				switch (num2 == num)
				{
				}
				num = (short)1238368256;
				short num3 = num;
				num = (short)602603521;
				if (num != 0)
				{
				}
				num = (short)2118385664;
				if (num != 0)
				{
				}
				return this.<ProvTables>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)765132801;
				if (num != 0)
				{
				}
				num = (short)1484327087;
				short num2 = num;
				num = (short)294324399;
				switch (num2 == num)
				{
				default:
				{
					num = (short)800522240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)278986752;
				if (num != 0)
				{
				}
				this.<ProvTables>k__BackingField = value;
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x000A0B44 File Offset: 0x0009ED44
		// (set) Token: 0x06000F24 RID: 3876 RVA: 0x000A0BF4 File Offset: 0x0009EDF4
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.PackageCheckResult TemplateLinkedPackageStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)231306482;
				short num2 = num;
				num = (short)1506374898;
				switch (num2 == num)
				{
				}
				num = (short)1806565376;
				short num3 = num;
				num = (short)166133760;
				if (num != 0)
				{
				}
				num = (short)1603862529;
				if (num != 0)
				{
				}
				return this.<TemplateLinkedPackageStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2022743202;
				short num2 = num;
				num = (short)1788189858;
				switch (num2 == num)
				{
				}
				num = (short)203882496;
				short num3 = num;
				num = (short)1354104833;
				if (num != 0)
				{
				}
				num = (short)1293352960;
				if (num != 0)
				{
				}
				this.<TemplateLinkedPackageStatus>k__BackingField = value;
			}
		}

		// Token: 0x0400070A RID: 1802
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily, global::System.Collections.Generic.IList<global::System.Version>> ProductVersionMap;

		// Token: 0x0400070B RID: 1803
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.InternalUpgradeData InternalUpData;

		// Token: 0x0400070C RID: 1804
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Radio Radio;

		// Token: 0x0400070D RID: 1805
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Codeplug Codeplug;

		// Token: 0x0400070E RID: 1806
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Template Template;

		// Token: 0x0400070F RID: 1807
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Codeplug LastCodeplug;

		// Token: 0x04000710 RID: 1808
		[global::System.Runtime.Serialization.DataMember]
		public int? ErrorCode;

		// Token: 0x04000711 RID: 1809
		[global::System.Runtime.Serialization.DataMember]
		public byte[] arvFile;

		// Token: 0x04000712 RID: 1810
		[global::System.Runtime.Serialization.DataMember]
		public byte[] pbaFile;

		// Token: 0x04000713 RID: 1811
		[global::System.Runtime.Serialization.DataMember]
		public byte[] ctFile;

		// Token: 0x04000714 RID: 1812
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Configuration Configuration;

		// Token: 0x04000715 RID: 1813
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Package[] VAPackages;

		// Token: 0x04000716 RID: 1814
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Package[] TTSVAPackages;

		// Token: 0x04000717 RID: 1815
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Package[] TTSPackages;

		// Token: 0x04000718 RID: 1816
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Task> Tasks;

		// Token: 0x04000719 RID: 1817
		[global::System.Runtime.Serialization.DataMember]
		public string FeaturesExchangeData;

		// Token: 0x0400071A RID: 1818
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.JPWriteJobUpdateData WriteJobUpdateData;

		// Token: 0x0400071B RID: 1819
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.Package, byte[]> VAPackagesContent;

		// Token: 0x0400071C RID: 1820
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.Package, byte[]> TTSVAPackagesContent;

		// Token: 0x0400071D RID: 1821
		[global::System.Runtime.Serialization.DataMember]
		public byte[] RestoreTargetPbaFile;

		// Token: 0x04000723 RID: 1827
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Package[] CACertificatePackages;

		// Token: 0x04000724 RID: 1828
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.Package, byte[]> CACertificatesPackagesContent;

		// Token: 0x04000725 RID: 1829
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Package[] DVRSFilesPackages;

		// Token: 0x04000726 RID: 1830
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.Package, byte[]> DVRSFilesContent;
	}
}
