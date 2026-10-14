using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000034 RID: 52
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ASTROCACertificates : global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage
	{
		// Token: 0x060004DC RID: 1244 RVA: 0x000378A0 File Offset: 0x00035AA0
		public ASTROCACertificates()
		{
			this.APXTemplates = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXTemplate>();
			this.APXCodeplugs = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug>();
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x000378CC File Offset: 0x00035ACC
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00037978 File Offset: 0x00035B78
		[global::System.Runtime.Serialization.DataMember]
		public string PackageName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)470489514;
				short num2 = num;
				num = (short)1967397290;
				switch (num2 == num)
				{
				default:
				{
					num = (short)188481536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)480313345;
				if (num != 0)
				{
				}
				num = (short)158990336;
				if (num != 0)
				{
				}
				return this.<PackageName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1744633857;
				if (num != 0)
				{
				}
				num = (short)1476984832;
				short num2 = num;
				num = (short)1399534219;
				short num3 = num;
				num = (short)426128011;
				switch (num3 == num)
				{
				}
				num = (short)1974730752;
				if (num != 0)
				{
				}
				this.<PackageName>k__BackingField = value;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00037A28 File Offset: 0x00035C28
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x00037AD8 File Offset: 0x00035CD8
		[global::System.Runtime.Serialization.DataMember]
		public string PackageVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1302389539;
				short num2 = num;
				num = (short)800908067;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2136801280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)624164865;
				if (num != 0)
				{
				}
				num = (short)378798080;
				if (num != 0)
				{
				}
				return this.<PackageVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)684195841;
				if (num != 0)
				{
				}
				num = (short)1141833728;
				short num2 = num;
				num = (short)425288202;
				short num3 = num;
				num = (short)2136826378;
				switch (num3 == num)
				{
				}
				num = (short)510132224;
				if (num != 0)
				{
				}
				this.<PackageVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00037B88 File Offset: 0x00035D88
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00037C34 File Offset: 0x00035E34
		[global::System.Runtime.Serialization.DataMember]
		public int? ReferenceCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1411518012;
				short num2 = num;
				num = (short)1886326332;
				switch (num2 == num)
				{
				default:
				{
					num = (short)892862464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)189923329;
				if (num != 0)
				{
				}
				num = (short)285736960;
				if (num != 0)
				{
				}
				return this.<ReferenceCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)501734435;
				short num2 = num;
				num = (short)1920719907;
				switch (num2 == num)
				{
				default:
				{
					num = (short)919863296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)129826817;
				if (num != 0)
				{
				}
				num = (short)590020608;
				if (num != 0)
				{
				}
				this.<ReferenceCount>k__BackingField = value;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00037CE4 File Offset: 0x00035EE4
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00037D94 File Offset: 0x00035F94
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXTemplate> APXTemplates
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1277412490;
				short num2 = num;
				num = (short)713606282;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1279459328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1827471361;
				if (num != 0)
				{
				}
				num = (short)890503168;
				if (num != 0)
				{
				}
				return this.<APXTemplates>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2043902133;
				short num2 = num;
				num = (short)1339717813;
				switch (num2 == num)
				{
				default:
				{
					num = (short)337182720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1616052225;
				if (num != 0)
				{
				}
				num = (short)1740242944;
				if (num != 0)
				{
				}
				this.<APXTemplates>k__BackingField = value;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00037E44 File Offset: 0x00036044
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x00037EF4 File Offset: 0x000360F4
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug> APXCodeplugs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1976303617;
				if (num != 0)
				{
				}
				num = (short)1073414144;
				short num2 = num;
				num = (short)824858929;
				short num3 = num;
				num = (short)2079873329;
				switch (num3 == num)
				{
				}
				num = (short)1678245888;
				if (num != 0)
				{
				}
				return this.<APXCodeplugs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1606496096;
				short num2 = num;
				num = (short)596455264;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1960706048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2056978433;
				if (num != 0)
				{
				}
				num = (short)863043584;
				if (num != 0)
				{
				}
				this.<APXCodeplugs>k__BackingField = value;
			}
		}
	}
}
