using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000033 RID: 51
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate))]
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class Template : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x060004BD RID: 1213 RVA: 0x000363D0 File Offset: 0x000345D0
		public Template()
		{
			this.Codeplugs = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Codeplug>();
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x000363F0 File Offset: 0x000345F0
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x000364A0 File Offset: 0x000346A0
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? FileUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1839156951;
				short num2 = num;
				num = (short)131157719;
				switch (num2 == num)
				{
				}
				num = (short)192348160;
				short num3 = num;
				num = (short)96731137;
				if (num != 0)
				{
				}
				num = (short)1163132928;
				if (num != 0)
				{
				}
				return this.<FileUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)716113796;
				short num2 = num;
				num = (short)939657092;
				switch (num2 == num)
				{
				}
				num = (short)1995702272;
				short num3 = num;
				num = (short)2027880449;
				if (num != 0)
				{
				}
				num = (short)1582104576;
				if (num != 0)
				{
				}
				this.<FileUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00036554 File Offset: 0x00034754
		// (set) Token: 0x060004C1 RID: 1217 RVA: 0x00036604 File Offset: 0x00034804
		[global::System.Runtime.Serialization.DataMember]
		public global::System.DateTime? CreatedDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1396665740;
				short num2 = num;
				num = (short)356937100;
				switch (num2 == num)
				{
				}
				num = (short)839909376;
				short num3 = num;
				num = (short)427491329;
				if (num != 0)
				{
				}
				num = (short)1232863232;
				if (num != 0)
				{
				}
				return this.<CreatedDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1414834843;
				short num2 = num;
				num = (short)2114890395;
				switch (num2 == num)
				{
				}
				num = (short)474152960;
				short num3 = num;
				num = (short)1554710529;
				if (num != 0)
				{
				}
				num = (short)1433206784;
				if (num != 0)
				{
				}
				this.<CreatedDate>k__BackingField = value;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x000366B4 File Offset: 0x000348B4
		// (set) Token: 0x060004C3 RID: 1219 RVA: 0x00036764 File Offset: 0x00034964
		[global::System.Runtime.Serialization.DataMember]
		public global::System.DateTime? ModifiedDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)843084518;
				short num2 = num;
				num = (short)1963422438;
				switch (num2 == num)
				{
				}
				num = (short)1773142016;
				short num3 = num;
				num = (short)333185025;
				if (num != 0)
				{
				}
				num = (short)1076822016;
				if (num != 0)
				{
				}
				return this.<ModifiedDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)385166571;
				short num2 = num;
				num = (short)2145660139;
				switch (num2 == num)
				{
				}
				num = (short)1313013760;
				short num3 = num;
				num = (short)243400705;
				if (num != 0)
				{
				}
				num = (short)1474166784;
				if (num != 0)
				{
				}
				this.<ModifiedDate>k__BackingField = value;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00036814 File Offset: 0x00034A14
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x000368C4 File Offset: 0x00034AC4
		[global::System.Runtime.Serialization.DataMember]
		public string Comment
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1647656071;
				short num2 = num;
				num = (short)900217991;
				switch (num2 == num)
				{
				}
				num = (short)54132736;
				short num3 = num;
				num = (short)474611713;
				if (num != 0)
				{
				}
				num = (short)1348009984;
				if (num != 0)
				{
				}
				return this.<Comment>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)886308865;
				if (num != 0)
				{
				}
				num = (short)637827145;
				short num2 = num;
				num = (short)146176073;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1068367872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1940520960;
				if (num != 0)
				{
				}
				this.<Comment>k__BackingField = value;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00036974 File Offset: 0x00034B74
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x00036A28 File Offset: 0x00034C28
		[global::System.Runtime.Serialization.DataMember]
		public string Name
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)217665741;
				short num2 = num;
				num = (short)538202317;
				switch (num2 == num)
				{
				}
				num = (short)1175126016;
				short num3 = num;
				num = (short)60227585;
				if (num != 0)
				{
				}
				num = (short)1297940480;
				if (num != 0)
				{
				}
				return this.<Name>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1864630273;
				if (num != 0)
				{
				}
				num = (short)1137366248;
				short num2 = num;
				num = (short)538170600;
				switch (num2 == num)
				{
				default:
				{
					num = (short)47710208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)391512064;
				if (num != 0)
				{
				}
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00036AD8 File Offset: 0x00034CD8
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x00036B88 File Offset: 0x00034D88
		[global::System.Runtime.Serialization.DataMember]
		public string TemplateBaseName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1446485925;
				short num2 = num;
				num = (short)1220452261;
				switch (num2 == num)
				{
				}
				num = (short)1983905792;
				short num3 = num;
				num = (short)180355072;
				if (num != 0)
				{
				}
				num = (short)233177089;
				if (num != 0)
				{
				}
				return this.<TemplateBaseName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1952450592;
				short num2 = num;
				num = (short)982648864;
				switch (num2 == num)
				{
				}
				num = (short)1418723328;
				short num3 = num;
				num = (short)1976827904;
				if (num != 0)
				{
				}
				num = (short)963575809;
				if (num != 0)
				{
				}
				this.<TemplateBaseName>k__BackingField = value;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x00036C38 File Offset: 0x00034E38
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x00036CE8 File Offset: 0x00034EE8
		[global::System.Runtime.Serialization.DataMember]
		public int? ProductFamily
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1725833740;
				short num2 = num;
				num = (short)1392386572;
				switch (num2 == num)
				{
				}
				num = (short)1071185920;
				short num3 = num;
				num = (short)1934229505;
				if (num != 0)
				{
				}
				num = (short)1105002496;
				if (num != 0)
				{
				}
				return this.<ProductFamily>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1729935889;
				short num2 = num;
				num = (short)633518609;
				switch (num2 == num)
				{
				}
				num = (short)345702400;
				short num3 = num;
				num = (short)645922817;
				if (num != 0)
				{
				}
				num = (short)1998061568;
				if (num != 0)
				{
				}
				this.<ProductFamily>k__BackingField = value;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x00036D98 File Offset: 0x00034F98
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x00036E48 File Offset: 0x00035048
		[global::System.Runtime.Serialization.DataMember]
		public string ModelNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)98822520;
				short num2 = num;
				num = (short)1907616120;
				switch (num2 == num)
				{
				}
				num = (short)2034630656;
				short num3 = num;
				num = (short)630849537;
				if (num != 0)
				{
				}
				num = (short)1441988608;
				if (num != 0)
				{
				}
				return this.<ModelNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)260373218;
				short num2 = num;
				num = (short)1889204962;
				switch (num2 == num)
				{
				}
				num = (short)1196032000;
				short num3 = num;
				num = (short)335872001;
				if (num != 0)
				{
				}
				num = (short)60948480;
				if (num != 0)
				{
				}
				this.<ModelNumber>k__BackingField = value;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x00036EF8 File Offset: 0x000350F8
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x00036FA8 File Offset: 0x000351A8
		[global::System.Runtime.Serialization.DataMember]
		public string FirmwareVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)490306774;
				short num2 = num;
				num = (short)1504017622;
				switch (num2 == num)
				{
				}
				num = (short)582418433;
				if (num != 0)
				{
				}
				num = (short)152371200;
				if (num != 0)
				{
				}
				num = (short)408616960;
				short num3 = num;
				return this.<FirmwareVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2047845680;
				short num2 = num;
				num = (short)609789232;
				switch (num2 == num)
				{
				}
				num = (short)1842610177;
				if (num != 0)
				{
				}
				num = (short)577503232;
				if (num != 0)
				{
				}
				num = (short)1442316288;
				short num3 = num;
				this.<FirmwareVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x0003705C File Offset: 0x0003525C
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x0003710C File Offset: 0x0003530C
		[global::System.Runtime.Serialization.DataMember]
		public string BBFBundleVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)792146862;
				short num2 = num;
				num = (short)1313158062;
				switch (num2 == num)
				{
				}
				num = (short)1488257025;
				if (num != 0)
				{
				}
				num = (short)1592590336;
				if (num != 0)
				{
				}
				num = (short)212467712;
				short num3 = num;
				return this.<BBFBundleVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1748528345;
				short num2 = num;
				num = (short)554986713;
				switch (num2 == num)
				{
				}
				num = (short)1626537985;
				if (num != 0)
				{
				}
				num = (short)2109079552;
				if (num != 0)
				{
				}
				num = (short)1581514752;
				short num3 = num;
				this.<BBFBundleVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x000371BC File Offset: 0x000353BC
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x0003726C File Offset: 0x0003546C
		[global::System.Runtime.Serialization.DataMember]
		public string CodeplugVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1666197388;
				short num2 = num;
				num = (short)686040972;
				switch (num2 == num)
				{
				}
				num = (short)2005598209;
				if (num != 0)
				{
				}
				num = (short)1221066752;
				if (num != 0)
				{
				}
				num = (short)1293615104;
				short num3 = num;
				return this.<CodeplugVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1560699067;
				short num2 = num;
				num = (short)499605691;
				switch (num2 == num)
				{
				}
				num = (short)999620609;
				if (num != 0)
				{
				}
				num = (short)914554880;
				if (num != 0)
				{
				}
				num = (short)473169920;
				short num3 = num;
				this.<CodeplugVersion>k__BackingField = value;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x0003731C File Offset: 0x0003551C
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x000373CC File Offset: 0x000355CC
		[global::System.Runtime.Serialization.DataMember]
		public string HardwareUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)772131728;
				short num2 = num;
				num = (short)243518352;
				switch (num2 == num)
				{
				}
				num = (short)159776769;
				if (num != 0)
				{
				}
				num = (short)1659240448;
				if (num != 0)
				{
				}
				num = (short)2112094208;
				short num3 = num;
				return this.<HardwareUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1826195401;
				short num2 = num;
				num = (short)638945225;
				switch (num2 == num)
				{
				}
				num = (short)756744193;
				if (num != 0)
				{
				}
				num = (short)476905472;
				if (num != 0)
				{
				}
				num = (short)1658060800;
				short num3 = num;
				this.<HardwareUuid>k__BackingField = value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x0003747C File Offset: 0x0003567C
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x0003752C File Offset: 0x0003572C
		[global::System.Runtime.Serialization.DataMember]
		public int ReservedStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)794222751;
				short num2 = num;
				num = (short)313254047;
				switch (num2 == num)
				{
				}
				num = (short)1977155584;
				if (num != 0)
				{
				}
				num = (short)1023934465;
				if (num != 0)
				{
				}
				num = (short)591593472;
				short num3 = num;
				return this.<ReservedStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)409206785;
				if (num != 0)
				{
				}
				num = (short)2028216448;
				short num2 = num;
				num = (short)502014080;
				switch (num2 == num)
				{
				}
				num = (short)1317076992;
				if (num != 0)
				{
				}
				num = (short)803340288;
				short num3 = num;
				this.<ReservedStatus>k__BackingField = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x000375DC File Offset: 0x000357DC
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x0003768C File Offset: 0x0003588C
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.RMFile RMFile
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1608952947;
				short num2 = num;
				num = (short)1262660723;
				switch (num2 == num)
				{
				}
				num = (short)116523009;
				if (num != 0)
				{
				}
				num = (short)1806434304;
				if (num != 0)
				{
				}
				num = (short)1675427840;
				short num3 = num;
				return this.<RMFile>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)699004863;
				short num2 = num;
				num = (short)1511978943;
				switch (num2 == num)
				{
				}
				num = (short)200540161;
				if (num != 0)
				{
				}
				num = (short)1675689984;
				if (num != 0)
				{
				}
				num = (short)69599232;
				short num3 = num;
				this.<RMFile>k__BackingField = value;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x0003773C File Offset: 0x0003593C
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x000377EC File Offset: 0x000359EC
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Codeplug> Codeplugs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1370008470;
				short num2 = num;
				num = (short)1924049814;
				switch (num2 == num)
				{
				}
				num = (short)299368448;
				if (num != 0)
				{
				}
				num = (short)761266177;
				if (num != 0)
				{
				}
				num = (short)228917248;
				short num3 = num;
				return this.<Codeplugs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1782454557;
				short num2 = num;
				num = (short)367008029;
				switch (num2 == num)
				{
				}
				num = (short)1286275073;
				if (num != 0)
				{
				}
				num = (short)2073427968;
				if (num != 0)
				{
				}
				num = (short)1580597248;
				short num3 = num;
				this.<Codeplugs>k__BackingField = value;
			}
		}
	}
}
