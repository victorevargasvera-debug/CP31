using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000182 RID: 386
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class SecurityFieldRequest
	{
		// Token: 0x060014E9 RID: 5353 RVA: 0x000DE6A4 File Offset: 0x000DC8A4
		public SecurityFieldRequest()
		{
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x000DE6B8 File Offset: 0x000DC8B8
		public SecurityFieldRequest(global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug) : this()
		{
			if (codeplug is global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)
			{
				global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug = codeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug;
				this.DisableWriteProtect = apxcodeplug.DisableWriteProtect;
				this.OwnerAdvKeyType = apxcodeplug.OwnerAdvKeyType;
				this.OwnerWacnId = apxcodeplug.OwnerWacnId;
				this.HomeSystemId = apxcodeplug.HomeSystemId;
				this.AskRequired = apxcodeplug.AskRequired;
				this.APXRadioSystems = apxcodeplug.APXRadioSystems;
				this.AstroSysKeyLog = apxcodeplug.AstroSysKeyLog;
				this.RadWideLabtoolRadioPassword_A8837 = null;
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x060014EB RID: 5355 RVA: 0x000DE73C File Offset: 0x000DC93C
		// (set) Token: 0x060014EC RID: 5356 RVA: 0x000DE7EC File Offset: 0x000DC9EC
		[global::System.Runtime.Serialization.DataMember]
		public bool? DisableWriteProtect
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1739390977;
				if (num != 0)
				{
				}
				num = (short)68502722;
				short num2 = num;
				num = (short)884360386;
				switch (num2 == num)
				{
				}
				num = (short)945881088;
				if (num != 0)
				{
				}
				num = (short)515506176;
				short num3 = num;
				return this.<DisableWriteProtect>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)488981978;
				short num2 = num;
				num = (short)630015450;
				switch (num2 == num)
				{
				}
				num = (short)1650982912;
				if (num != 0)
				{
				}
				num = (short)1001062401;
				if (num != 0)
				{
				}
				num = (short)119930880;
				short num3 = num;
				this.<DisableWriteProtect>k__BackingField = value;
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x000DE89C File Offset: 0x000DCA9C
		// (set) Token: 0x060014EE RID: 5358 RVA: 0x000DE94C File Offset: 0x000DCB4C
		[global::System.Runtime.Serialization.DataMember]
		public int? OwnerAdvKeyType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)962333950;
				short num2 = num;
				num = (short)921242878;
				switch (num2 == num)
				{
				}
				num = (short)345833472;
				if (num != 0)
				{
				}
				num = (short)1554710529;
				if (num != 0)
				{
				}
				num = (short)498139136;
				short num3 = num;
				return this.<OwnerAdvKeyType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)810323027;
				short num2 = num;
				num = (short)1675070547;
				switch (num2 == num)
				{
				}
				num = (short)428212224;
				if (num != 0)
				{
				}
				num = (short)1762263041;
				if (num != 0)
				{
				}
				num = (short)1289682944;
				short num3 = num;
				this.<OwnerAdvKeyType>k__BackingField = value;
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x000DE9FC File Offset: 0x000DCBFC
		// (set) Token: 0x060014F0 RID: 5360 RVA: 0x000DEAAC File Offset: 0x000DCCAC
		[global::System.Runtime.Serialization.DataMember]
		public int? OwnerWacnId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1044786942;
				short num2 = num;
				num = (short)1343565566;
				switch (num2 == num)
				{
				}
				num = (short)727973889;
				if (num != 0)
				{
				}
				num = (short)714342400;
				if (num != 0)
				{
				}
				num = (short)1383268352;
				short num3 = num;
				return this.<OwnerWacnId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1399914497;
				if (num != 0)
				{
				}
				num = (short)1408454326;
				short num2 = num;
				num = (short)556027574;
				switch (num2 == num)
				{
				}
				num = (short)1591541760;
				if (num != 0)
				{
				}
				num = (short)838008832;
				short num3 = num;
				this.<OwnerWacnId>k__BackingField = value;
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x000DEB60 File Offset: 0x000DCD60
		// (set) Token: 0x060014F2 RID: 5362 RVA: 0x000DEC0C File Offset: 0x000DCE0C
		[global::System.Runtime.Serialization.DataMember]
		public int? HomeSystemId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1981811002;
				short num2 = num;
				num = (short)1561004346;
				switch (num2 == num)
				{
				}
				num = (short)1609957377;
				if (num != 0)
				{
				}
				num = (short)1398013952;
				if (num != 0)
				{
				}
				num = (short)2044198912;
				short num3 = num;
				return this.<HomeSystemId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1574827525;
				short num2 = num;
				num = (short)836892165;
				switch (num2 == num)
				{
				}
				num = (short)1621884928;
				if (num != 0)
				{
				}
				num = (short)589758465;
				if (num != 0)
				{
				}
				num = (short)810876928;
				short num3 = num;
				this.<HomeSystemId>k__BackingField = value;
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x000DECBC File Offset: 0x000DCEBC
		// (set) Token: 0x060014F4 RID: 5364 RVA: 0x000DED68 File Offset: 0x000DCF68
		[global::System.Runtime.Serialization.DataMember]
		public bool? AskRequired
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1421017089;
				if (num != 0)
				{
				}
				num = (short)669569310;
				short num2 = num;
				num = (short)469750046;
				switch (num2 == num)
				{
				}
				num = (short)1394999296;
				if (num != 0)
				{
				}
				num = (short)1417084928;
				short num3 = num;
				return this.<AskRequired>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1367967437;
				short num2 = num;
				num = (short)1399490253;
				switch (num2 == num)
				{
				}
				num = (short)2097479681;
				if (num != 0)
				{
				}
				num = (short)1134690304;
				if (num != 0)
				{
				}
				num = (short)1784086528;
				short num3 = num;
				this.<AskRequired>k__BackingField = value;
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x000DEE18 File Offset: 0x000DD018
		// (set) Token: 0x060014F6 RID: 5366 RVA: 0x000DEECC File Offset: 0x000DD0CC
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> APXRadioSystems
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1942719113;
				short num2 = num;
				num = (short)121801353;
				switch (num2 == num)
				{
				}
				num = (short)1774911489;
				if (num != 0)
				{
				}
				num = (short)1699807232;
				if (num != 0)
				{
				}
				num = (short)1725431808;
				short num3 = num;
				return this.<APXRadioSystems>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)73417884;
				short num2 = num;
				num = (short)719733916;
				switch (num2 == num)
				{
				}
				num = (short)1953431553;
				if (num != 0)
				{
				}
				num = (short)1037434880;
				if (num != 0)
				{
				}
				num = (short)822804480;
				short num3 = num;
				this.<APXRadioSystems>k__BackingField = value;
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x000DEF7C File Offset: 0x000DD17C
		// (set) Token: 0x060014F8 RID: 5368 RVA: 0x000DF02C File Offset: 0x000DD22C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.DateTime? LastProgrammedDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1032843898;
				short num2 = num;
				num = (short)153350778;
				switch (num2 == num)
				{
				}
				num = (short)128188417;
				if (num != 0)
				{
				}
				num = (short)358744064;
				if (num != 0)
				{
				}
				num = (short)1022623744;
				short num3 = num;
				return this.<LastProgrammedDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2131575690;
				short num2 = num;
				num = (short)1490305930;
				switch (num2 == num)
				{
				}
				num = (short)6029313;
				if (num != 0)
				{
				}
				num = (short)1550516224;
				if (num != 0)
				{
				}
				num = (short)318636032;
				short num3 = num;
				this.<LastProgrammedDate>k__BackingField = value;
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x000DF0DC File Offset: 0x000DD2DC
		// (set) Token: 0x060014FA RID: 5370 RVA: 0x000DF18C File Offset: 0x000DD38C
		[global::System.Runtime.Serialization.DataMember]
		public string AstroSysKeyLog
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1445716317;
				short num2 = num;
				num = (short)1069801821;
				switch (num2 == num)
				{
				}
				num = (short)2002124800;
				if (num != 0)
				{
				}
				num = (short)1090322433;
				if (num != 0)
				{
				}
				num = (short)199753728;
				short num3 = num;
				return this.<AstroSysKeyLog>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1147682402;
				short num2 = num;
				num = (short)1715879522;
				switch (num2 == num)
				{
				}
				num = (short)372572160;
				if (num != 0)
				{
				}
				num = (short)1595670529;
				if (num != 0)
				{
				}
				num = (short)1253244928;
				short num3 = num;
				this.<AstroSysKeyLog>k__BackingField = value;
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x000DF23C File Offset: 0x000DD43C
		// (set) Token: 0x060014FC RID: 5372 RVA: 0x000DF2EC File Offset: 0x000DD4EC
		[global::System.Runtime.Serialization.DataMember]
		public string RadWideLabtoolRadioPassword_A8837
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1557243320;
				short num2 = num;
				num = (short)546022840;
				switch (num2 == num)
				{
				}
				num = (short)1520762880;
				if (num != 0)
				{
				}
				num = (short)1215823873;
				if (num != 0)
				{
				}
				num = (short)695402496;
				short num3 = num;
				return this.<RadWideLabtoolRadioPassword_A8837>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)544361155;
				short num2 = num;
				num = (short)292833987;
				switch (num2 == num)
				{
				}
				num = (short)1427243009;
				if (num != 0)
				{
				}
				num = (short)1755316224;
				if (num != 0)
				{
				}
				num = (short)1052180480;
				short num3 = num;
				this.<RadWideLabtoolRadioPassword_A8837>k__BackingField = value;
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x000DF3A0 File Offset: 0x000DD5A0
		// (set) Token: 0x060014FE RID: 5374 RVA: 0x000DF450 File Offset: 0x000DD650
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy ASTROPasswordPolicy
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)571080705;
				if (num != 0)
				{
				}
				num = (short)69001758;
				short num2 = num;
				num = (short)608625182;
				switch (num2 == num)
				{
				}
				num = (short)461635584;
				if (num != 0)
				{
				}
				num = (short)94765056;
				short num3 = num;
				return this.<ASTROPasswordPolicy>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1101970513;
				short num2 = num;
				num = (short)407223377;
				switch (num2 == num)
				{
				}
				num = (short)1703870465;
				if (num != 0)
				{
				}
				num = (short)121962496;
				if (num != 0)
				{
				}
				num = (short)1885077504;
				short num3 = num;
				this.<ASTROPasswordPolicy>k__BackingField = value;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x060014FF RID: 5375 RVA: 0x000DF500 File Offset: 0x000DD700
		// (set) Token: 0x06001500 RID: 5376 RVA: 0x000DF5B0 File Offset: 0x000DD7B0
		[global::System.Runtime.Serialization.DataMember]
		public string PCRKeysIdAndValue
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1271681985;
				short num2 = num;
				num = (short)343823297;
				switch (num2 == num)
				{
				}
				num = (short)1815543809;
				if (num != 0)
				{
				}
				num = (short)215547904;
				if (num != 0)
				{
				}
				num = (short)924450816;
				short num3 = num;
				return this.<PCRKeysIdAndValue>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1557194486;
				short num2 = num;
				num = (short)72279798;
				switch (num2 == num)
				{
				}
				num = (short)1259405313;
				if (num != 0)
				{
				}
				num = (short)1090322432;
				if (num != 0)
				{
				}
				num = (short)736493568;
				short num3 = num;
				this.<PCRKeysIdAndValue>k__BackingField = value;
			}
		}
	}
}
