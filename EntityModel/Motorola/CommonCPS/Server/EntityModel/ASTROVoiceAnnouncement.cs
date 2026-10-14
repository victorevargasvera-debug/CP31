using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200003B RID: 59
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ASTROVoiceAnnouncement : global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage
	{
		// Token: 0x0600055D RID: 1373 RVA: 0x0003CD98 File Offset: 0x0003AF98
		public ASTROVoiceAnnouncement()
		{
			this.APXTemplates = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXTemplate>();
			this.APXCodeplugs = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug>();
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x0003CDC4 File Offset: 0x0003AFC4
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x0003CE70 File Offset: 0x0003B070
		[global::System.Runtime.Serialization.DataMember]
		public string PackageName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)278396929;
				if (num != 0)
				{
				}
				num = (short)720044032;
				short num2 = num;
				num = (short)1461439613;
				short num3 = num;
				num = (short)1522060413;
				switch (num3 == num)
				{
				}
				num = (short)410124288;
				if (num != 0)
				{
				}
				return this.<PackageName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)499045119;
				short num2 = num;
				num = (short)1625019135;
				switch (num2 == num)
				{
				default:
				{
					num = (short)89063424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)758448128;
				if (num != 0)
				{
				}
				num = (short)1507655681;
				if (num != 0)
				{
				}
				this.<PackageName>k__BackingField = value;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x0003CF20 File Offset: 0x0003B120
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x0003CFCC File Offset: 0x0003B1CC
		[global::System.Runtime.Serialization.DataMember]
		public string PackageVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1270803053;
				short num2 = num;
				num = (short)1165879917;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2047344640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1047920641;
				if (num != 0)
				{
				}
				num = (short)82903040;
				if (num != 0)
				{
				}
				return this.<PackageVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1325538404;
				short num2 = num;
				num = (short)1849629796;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1827471360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)560201728;
				if (num != 0)
				{
				}
				num = (short)1573060609;
				if (num != 0)
				{
				}
				this.<PackageVersion>k__BackingField = value;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x0003D07C File Offset: 0x0003B27C
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x0003D12C File Offset: 0x0003B32C
		[global::System.Runtime.Serialization.DataMember]
		public int? ReferenceCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)99912728;
				short num2 = num;
				num = (short)793349144;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2006581248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1601699841;
				if (num != 0)
				{
				}
				num = (short)1015218176;
				if (num != 0)
				{
				}
				return this.<ReferenceCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)649429180;
				short num2 = num;
				num = (short)128155836;
				switch (num2 == num)
				{
				default:
				{
					num = (short)688128000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1074331649;
				if (num != 0)
				{
				}
				num = (short)250937344;
				if (num != 0)
				{
				}
				this.<ReferenceCount>k__BackingField = value;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x0003D1D8 File Offset: 0x0003B3D8
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x0003D288 File Offset: 0x0003B488
		[global::System.Runtime.Serialization.DataMember]
		public int? Duration
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)702805699;
				short num2 = num;
				num = (short)1961359043;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1734934528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1717829632;
				if (num != 0)
				{
				}
				num = (short)1696792577;
				if (num != 0)
				{
				}
				return this.<Duration>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2043775450;
				short num2 = num;
				num = (short)497322458;
				switch (num2 == num)
				{
				default:
				{
					num = (short)634519552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1617035265;
				if (num != 0)
				{
				}
				num = (short)1611726848;
				if (num != 0)
				{
				}
				this.<Duration>k__BackingField = value;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x0003D338 File Offset: 0x0003B538
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x0003D3E8 File Offset: 0x0003B5E8
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXTemplate> APXTemplates
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)958674785;
				short num2 = num;
				num = (short)801126241;
				switch (num2 == num)
				{
				default:
				{
					num = (short)696778752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)842137601;
				if (num != 0)
				{
				}
				num = (short)1272578048;
				if (num != 0)
				{
				}
				return this.<APXTemplates>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)976681258;
				short num2 = num;
				num = (short)1992554794;
				switch (num2 == num)
				{
				default:
				{
					num = (short)601817088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2067857409;
				if (num != 0)
				{
				}
				num = (short)202178560;
				if (num != 0)
				{
				}
				this.<APXTemplates>k__BackingField = value;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x0003D49C File Offset: 0x0003B69C
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x0003D54C File Offset: 0x0003B74C
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug> APXCodeplugs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)645909473;
				short num2 = num;
				num = (short)592366561;
				switch (num2 == num)
				{
				default:
				{
					num = (short)537067520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)729939968;
				if (num != 0)
				{
				}
				num = (short)823263233;
				if (num != 0)
				{
				}
				return this.<APXCodeplugs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)992735604;
				short num2 = num;
				num = (short)1439953268;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1188233216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)386924545;
				if (num != 0)
				{
				}
				num = (short)2013986816;
				if (num != 0)
				{
				}
				this.<APXCodeplugs>k__BackingField = value;
			}
		}
	}
}
