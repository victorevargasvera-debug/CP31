using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000077 RID: 119
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class PBBApplicationShortcut : global::Motorola.CommonCPS.Server.EntityModel.PBBPackage
	{
		// Token: 0x0600090B RID: 2315 RVA: 0x00061A98 File Offset: 0x0005FC98
		public PBBApplicationShortcut()
		{
			this.PBBCodeplugs = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug>();
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00061AB8 File Offset: 0x0005FCB8
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x00061B68 File Offset: 0x0005FD68
		[global::System.Runtime.Serialization.DataMember]
		public string PackageName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1872232449;
				if (num != 0)
				{
				}
				num = (short)1584392093;
				short num2 = num;
				num = (short)24438685;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2022244352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)578420736;
				if (num != 0)
				{
				}
				return this.<PackageName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)466740167;
				short num2 = num;
				num = (short)151905223;
				switch (num2 == num)
				{
				}
				num = (short)395378688;
				short num3 = num;
				num = (short)428867584;
				if (num != 0)
				{
				}
				num = (short)261292033;
				if (num != 0)
				{
				}
				this.<PackageName>k__BackingField = value;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x00061C14 File Offset: 0x0005FE14
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x00061CC4 File Offset: 0x0005FEC4
		[global::System.Runtime.Serialization.DataMember]
		public string PackageVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)757727233;
				if (num != 0)
				{
				}
				num = (short)483805468;
				short num2 = num;
				num = (short)223168796;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1722613760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)127795200;
				if (num != 0)
				{
				}
				return this.<PackageVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)440896742;
				short num2 = num;
				num = (short)725585126;
				switch (num2 == num)
				{
				}
				num = (short)1383989248;
				short num3 = num;
				num = (short)798621697;
				if (num != 0)
				{
				}
				num = (short)436600832;
				if (num != 0)
				{
				}
				this.<PackageVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x00061D78 File Offset: 0x0005FF78
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x00061E2C File Offset: 0x0006002C
		[global::System.Runtime.Serialization.DataMember]
		public string ManifestVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1496449114;
				short num2 = num;
				num = (short)1722155098;
				switch (num2 == num)
				{
				}
				num = (short)774504448;
				short num3 = num;
				num = (short)837287936;
				if (num != 0)
				{
				}
				num = (short)2058878977;
				if (num != 0)
				{
				}
				return this.<ManifestVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1946774152;
				short num2 = num;
				num = (short)54028936;
				switch (num2 == num)
				{
				}
				num = (short)2034892800;
				short num3 = num;
				num = (short)413466624;
				if (num != 0)
				{
				}
				num = (short)1719271425;
				if (num != 0)
				{
				}
				this.<ManifestVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x00061EDC File Offset: 0x000600DC
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x00061F8C File Offset: 0x0006018C
		[global::System.Runtime.Serialization.DataMember]
		public string ApplicationUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)50258934;
				short num2 = num;
				num = (short)1052500982;
				switch (num2 == num)
				{
				}
				num = (short)1284505600;
				short num3 = num;
				num = (short)1805058049;
				if (num != 0)
				{
				}
				num = (short)1120337920;
				if (num != 0)
				{
				}
				return this.<ApplicationUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1087314615;
				short num2 = num;
				num = (short)1070865079;
				switch (num2 == num)
				{
				}
				num = (short)2014707712;
				short num3 = num;
				num = (short)530055168;
				if (num != 0)
				{
				}
				num = (short)205717505;
				if (num != 0)
				{
				}
				this.<ApplicationUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x0006203C File Offset: 0x0006023C
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x000620EC File Offset: 0x000602EC
		[global::System.Runtime.Serialization.DataMember]
		public string ApplicationName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1265085583;
				short num2 = num;
				num = (short)1271573647;
				switch (num2 == num)
				{
				}
				num = (short)730136576;
				short num3 = num;
				num = (short)1619984385;
				if (num != 0)
				{
				}
				num = (short)93454336;
				if (num != 0)
				{
				}
				return this.<ApplicationName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1980047042;
				short num2 = num;
				num = (short)1530404546;
				switch (num2 == num)
				{
				}
				num = (short)220004352;
				short num3 = num;
				num = (short)1364328449;
				if (num != 0)
				{
				}
				num = (short)324993024;
				if (num != 0)
				{
				}
				this.<ApplicationName>k__BackingField = value;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x0006219C File Offset: 0x0006039C
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x0006224C File Offset: 0x0006044C
		[global::System.Runtime.Serialization.DataMember]
		public string ApplicationPackageName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)267497795;
				short num2 = num;
				num = (short)1076146499;
				switch (num2 == num)
				{
				}
				num = (short)2138243072;
				short num3 = num;
				num = (short)285736961;
				if (num != 0)
				{
				}
				num = (short)704446464;
				if (num != 0)
				{
				}
				return this.<ApplicationPackageName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)270269663;
				short num2 = num;
				num = (short)1235942623;
				switch (num2 == num)
				{
				}
				num = (short)172752896;
				short num3 = num;
				num = (short)1027080193;
				if (num != 0)
				{
				}
				num = (short)538574848;
				if (num != 0)
				{
				}
				this.<ApplicationPackageName>k__BackingField = value;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x00062300 File Offset: 0x00060500
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x000623B0 File Offset: 0x000605B0
		[global::System.Runtime.Serialization.DataMember]
		public string ApplicationClassName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)318647008;
				short num2 = num;
				num = (short)1732324064;
				switch (num2 == num)
				{
				}
				num = (short)134676480;
				short num3 = num;
				num = (short)157024256;
				if (num != 0)
				{
				}
				num = (short)559742977;
				if (num != 0)
				{
				}
				return this.<ApplicationClassName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1919704894;
				short num2 = num;
				num = (short)382033726;
				switch (num2 == num)
				{
				}
				num = (short)177405952;
				short num3 = num;
				num = (short)226557953;
				if (num != 0)
				{
				}
				num = (short)1436614656;
				if (num != 0)
				{
				}
				this.<ApplicationClassName>k__BackingField = value;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x00062460 File Offset: 0x00060660
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x00062510 File Offset: 0x00060710
		[global::System.Runtime.Serialization.DataMember]
		public int? ReferenceCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1477771265;
				if (num != 0)
				{
				}
				num = (short)609407661;
				short num2 = num;
				num = (short)976868013;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1127284736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1106771968;
				if (num != 0)
				{
				}
				return this.<ReferenceCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1651897167;
				short num2 = num;
				num = (short)1339028303;
				switch (num2 == num)
				{
				}
				num = (short)1939734528;
				short num3 = num;
				num = (short)179568640;
				if (num != 0)
				{
				}
				num = (short)242614273;
				if (num != 0)
				{
				}
				this.<ReferenceCount>k__BackingField = value;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x000625C0 File Offset: 0x000607C0
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x00062670 File Offset: 0x00060870
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug> PBBCodeplugs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1428881409;
				if (num != 0)
				{
				}
				num = (short)1418553263;
				short num2 = num;
				num = (short)501180335;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1297809408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)298713088;
				if (num != 0)
				{
				}
				return this.<PBBCodeplugs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1566082307;
				short num2 = num;
				num = (short)1754891523;
				switch (num2 == num)
				{
				}
				num = (short)107937792;
				short num3 = num;
				num = (short)424804352;
				if (num != 0)
				{
				}
				num = (short)588578817;
				if (num != 0)
				{
				}
				this.<PBBCodeplugs>k__BackingField = value;
			}
		}
	}
}
