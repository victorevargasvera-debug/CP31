using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200012F RID: 303
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MigrationRadioTemplateInfo
	{
		// Token: 0x0600116C RID: 4460 RVA: 0x000BA40C File Offset: 0x000B860C
		public MigrationRadioTemplateInfo()
		{
			this.IsTemplateExist = false;
			this.ApplyTemplateDone = false;
			this.HasScheduleJob = false;
			this.NeedResetPassword = false;
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x000BA43C File Offset: 0x000B863C
		// (set) Token: 0x0600116E RID: 4462 RVA: 0x000BA4EC File Offset: 0x000B86EC
		[global::System.Runtime.Serialization.DataMember]
		[global::System.ComponentModel.DataAnnotations.Key]
		public global::System.Guid Uuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1521338083;
				short num2 = num;
				num = (short)1341507299;
				switch (num2 == num)
				{
				}
				num = (short)672464897;
				if (num != 0)
				{
				}
				num = (short)1762459648;
				short num3 = num;
				num = (short)1082327040;
				if (num != 0)
				{
				}
				return this.<Uuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)347013121;
				if (num != 0)
				{
				}
				num = (short)2017580180;
				short num2 = num;
				num = (short)847500436;
				switch (num2 == num)
				{
				}
				num = (short)786628608;
				short num3 = num;
				num = (short)1946419200;
				if (num != 0)
				{
				}
				this.<Uuid>k__BackingField = value;
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x000BA59C File Offset: 0x000B879C
		// (set) Token: 0x06001170 RID: 4464 RVA: 0x000BA64C File Offset: 0x000B884C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? RadioUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)909522096;
				short num2 = num;
				num = (short)1777349808;
				switch (num2 == num)
				{
				}
				num = (short)2120089600;
				if (num != 0)
				{
				}
				num = (short)948633600;
				short num3 = num;
				num = (short)993329153;
				if (num != 0)
				{
				}
				return this.<RadioUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)53510472;
				short num2 = num;
				num = (short)792625480;
				switch (num2 == num)
				{
				}
				num = (short)1715666944;
				if (num != 0)
				{
				}
				num = (short)1581383680;
				short num3 = num;
				num = (short)1443495937;
				if (num != 0)
				{
				}
				this.<RadioUuid>k__BackingField = value;
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x000BA6FC File Offset: 0x000B88FC
		// (set) Token: 0x06001172 RID: 4466 RVA: 0x000BA7AC File Offset: 0x000B89AC
		[global::System.Runtime.Serialization.DataMember]
		public string DeviceID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)754509715;
				short num2 = num;
				num = (short)1092806547;
				switch (num2 == num)
				{
				}
				num = (short)564658177;
				if (num != 0)
				{
				}
				num = (short)1913520128;
				short num3 = num;
				num = (short)482803712;
				if (num != 0)
				{
				}
				return this.<DeviceID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1276252151;
				short num2 = num;
				num = (short)1497829367;
				switch (num2 == num)
				{
				}
				num = (short)879296513;
				if (num != 0)
				{
				}
				num = (short)1516699648;
				short num3 = num;
				num = (short)1185873920;
				if (num != 0)
				{
				}
				this.<DeviceID>k__BackingField = value;
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x000BA85C File Offset: 0x000B8A5C
		// (set) Token: 0x06001174 RID: 4468 RVA: 0x000BA90C File Offset: 0x000B8B0C
		[global::System.Runtime.Serialization.DataMember]
		public string SerialNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1354738276;
				short num2 = num;
				num = (short)1022274148;
				switch (num2 == num)
				{
				}
				num = (short)911605761;
				if (num != 0)
				{
				}
				num = (short)227409920;
				short num3 = num;
				num = (short)393543680;
				if (num != 0)
				{
				}
				return this.<SerialNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)369001114;
				short num2 = num;
				num = (short)913212058;
				switch (num2 == num)
				{
				}
				num = (short)1125646336;
				if (num != 0)
				{
				}
				num = (short)543096832;
				short num3 = num;
				num = (short)1370947585;
				if (num != 0)
				{
				}
				this.<SerialNumber>k__BackingField = value;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x000BA9BC File Offset: 0x000B8BBC
		// (set) Token: 0x06001176 RID: 4470 RVA: 0x000BAA6C File Offset: 0x000B8C6C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? ProductFamily
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1844463777;
				short num2 = num;
				num = (short)497895585;
				switch (num2 == num)
				{
				}
				num = (short)1412038657;
				if (num != 0)
				{
				}
				num = (short)1200422912;
				short num3 = num;
				num = (short)1239220224;
				if (num != 0)
				{
				}
				return this.<ProductFamily>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2099191091;
				short num2 = num;
				num = (short)578297139;
				switch (num2 == num)
				{
				}
				num = (short)959512577;
				if (num != 0)
				{
				}
				num = (short)1019543552;
				short num3 = num;
				num = (short)160628736;
				if (num != 0)
				{
				}
				this.<ProductFamily>k__BackingField = value;
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x000BAB1C File Offset: 0x000B8D1C
		// (set) Token: 0x06001178 RID: 4472 RVA: 0x000BABCC File Offset: 0x000B8DCC
		[global::System.Runtime.Serialization.DataMember]
		public bool? HasPBA
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)993599276;
				short num2 = num;
				num = (short)159129388;
				switch (num2 == num)
				{
				}
				num = (short)1880948737;
				if (num != 0)
				{
				}
				num = (short)979369984;
				short num3 = num;
				num = (short)1651179520;
				if (num != 0)
				{
				}
				return this.<HasPBA>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1275815058;
				short num2 = num;
				num = (short)1538679954;
				switch (num2 == num)
				{
				}
				num = (short)990969856;
				if (num != 0)
				{
				}
				num = (short)186318848;
				short num3 = num;
				num = (short)1584529409;
				if (num != 0)
				{
				}
				this.<HasPBA>k__BackingField = value;
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06001179 RID: 4473 RVA: 0x000BAC80 File Offset: 0x000B8E80
		// (set) Token: 0x0600117A RID: 4474 RVA: 0x000BAD30 File Offset: 0x000B8F30
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? PBAFileUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)998534858;
				short num2 = num;
				num = (short)1609658058;
				switch (num2 == num)
				{
				}
				num = (short)1874657280;
				if (num != 0)
				{
				}
				num = (short)975831040;
				short num3 = num;
				num = (short)899940353;
				if (num != 0)
				{
				}
				return this.<PBAFileUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)223081081;
				short num2 = num;
				num = (short)1797583481;
				switch (num2 == num)
				{
				}
				num = (short)648347649;
				if (num != 0)
				{
				}
				num = (short)1890058240;
				short num3 = num;
				num = (short)1581711360;
				if (num != 0)
				{
				}
				this.<PBAFileUuid>k__BackingField = value;
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x000BADE0 File Offset: 0x000B8FE0
		// (set) Token: 0x0600117C RID: 4476 RVA: 0x000BAE94 File Offset: 0x000B9094
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? TemplateUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)209574090;
				short num2 = num;
				num = (short)1307236554;
				switch (num2 == num)
				{
				}
				num = (short)530186241;
				if (num != 0)
				{
				}
				num = (short)160104448;
				short num3 = num;
				num = (short)158793728;
				if (num != 0)
				{
				}
				return this.<TemplateUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2019018394;
				short num2 = num;
				num = (short)1436468890;
				switch (num2 == num)
				{
				}
				num = (short)548798465;
				if (num != 0)
				{
				}
				num = (short)587268096;
				short num3 = num;
				num = (short)805109760;
				if (num != 0)
				{
				}
				this.<TemplateUuid>k__BackingField = value;
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x000BAF44 File Offset: 0x000B9144
		// (set) Token: 0x0600117E RID: 4478 RVA: 0x000BAFF4 File Offset: 0x000B91F4
		[global::System.Runtime.Serialization.DataMember]
		public string TemplateName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)641175528;
				short num2 = num;
				num = (short)1663209448;
				switch (num2 == num)
				{
				}
				num = (short)105054209;
				if (num != 0)
				{
				}
				num = (short)398196736;
				short num3 = num;
				num = (short)1747714048;
				if (num != 0)
				{
				}
				return this.<TemplateName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1831815961;
				short num2 = num;
				num = (short)1880967961;
				switch (num2 == num)
				{
				}
				num = (short)383385600;
				if (num != 0)
				{
				}
				num = (short)732037120;
				short num3 = num;
				num = (short)1174405121;
				if (num != 0)
				{
				}
				this.<TemplateName>k__BackingField = value;
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x000BB0A4 File Offset: 0x000B92A4
		// (set) Token: 0x06001180 RID: 4480 RVA: 0x000BB154 File Offset: 0x000B9354
		[global::System.Runtime.Serialization.DataMember]
		public string TemplateComments
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1028909837;
				short num2 = num;
				num = (short)1196157709;
				switch (num2 == num)
				{
				}
				num = (short)1443102721;
				if (num != 0)
				{
				}
				num = (short)1124335616;
				short num3 = num;
				num = (short)1658847232;
				if (num != 0)
				{
				}
				return this.<TemplateComments>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)715173368;
				short num2 = num;
				num = (short)1566617080;
				switch (num2 == num)
				{
				}
				num = (short)1360330753;
				if (num != 0)
				{
				}
				num = (short)1182007296;
				short num3 = num;
				num = (short)916455424;
				if (num != 0)
				{
				}
				this.<TemplateComments>k__BackingField = value;
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x000BB204 File Offset: 0x000B9404
		// (set) Token: 0x06001182 RID: 4482 RVA: 0x000BB2B0 File Offset: 0x000B94B0
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? ArchiveFileUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)165860133;
				short num2 = num;
				num = (short)696767269;
				switch (num2 == num)
				{
				}
				num = (short)364052480;
				if (num != 0)
				{
				}
				num = (short)576978944;
				short num3 = num;
				num = (short)370802689;
				if (num != 0)
				{
				}
				return this.<ArchiveFileUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1961692219;
				short num2 = num;
				num = (short)1514409019;
				switch (num2 == num)
				{
				}
				num = (short)1806958593;
				if (num != 0)
				{
				}
				num = (short)99876864;
				short num3 = num;
				num = (short)433782784;
				if (num != 0)
				{
				}
				this.<ArchiveFileUuid>k__BackingField = value;
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x000BB35C File Offset: 0x000B955C
		// (set) Token: 0x06001184 RID: 4484 RVA: 0x000BB408 File Offset: 0x000B9608
		[global::System.Runtime.Serialization.DataMember]
		public string LanguagePackUuids
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)285671425;
				if (num != 0)
				{
				}
				num = (short)850160502;
				short num2 = num;
				num = (short)1074293622;
				switch (num2 == num)
				{
				}
				num = (short)1356398592;
				short num3 = num;
				num = (short)638189568;
				if (num != 0)
				{
				}
				return this.<LanguagePackUuids>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1623536462;
				short num2 = num;
				num = (short)1928409934;
				switch (num2 == num)
				{
				}
				num = (short)1706164225;
				if (num != 0)
				{
				}
				num = (short)1491599360;
				short num3 = num;
				num = (short)1917124608;
				if (num != 0)
				{
				}
				this.<LanguagePackUuids>k__BackingField = value;
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x000BB4B8 File Offset: 0x000B96B8
		// (set) Token: 0x06001186 RID: 4486 RVA: 0x000BB568 File Offset: 0x000B9768
		[global::System.Runtime.Serialization.DataMember]
		public bool? HasArchive
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1675253920;
				short num2 = num;
				num = (short)359880864;
				switch (num2 == num)
				{
				}
				num = (short)548077569;
				if (num != 0)
				{
				}
				num = (short)16711680;
				short num3 = num;
				num = (short)1267466240;
				if (num != 0)
				{
				}
				return this.<HasArchive>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)470227475;
				short num2 = num;
				num = (short)1430395411;
				switch (num2 == num)
				{
				}
				num = (short)2099052545;
				if (num != 0)
				{
				}
				num = (short)1568210944;
				short num3 = num;
				num = (short)729153536;
				if (num != 0)
				{
				}
				this.<HasArchive>k__BackingField = value;
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x000BB618 File Offset: 0x000B9818
		// (set) Token: 0x06001188 RID: 4488 RVA: 0x000BB6C8 File Offset: 0x000B98C8
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RadioProcessCategory? RadioProcessCategory
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)397547291;
				short num2 = num;
				num = (short)954603291;
				switch (num2 == num)
				{
				}
				num = (short)856555520;
				if (num != 0)
				{
				}
				num = (short)476774400;
				short num3 = num;
				num = (short)665387009;
				if (num != 0)
				{
				}
				return this.<RadioProcessCategory>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1485565892;
				short num2 = num;
				num = (short)827781060;
				switch (num2 == num)
				{
				}
				num = (short)1109917697;
				if (num != 0)
				{
				}
				num = (short)738787328;
				short num3 = num;
				num = (short)1105723392;
				if (num != 0)
				{
				}
				this.<RadioProcessCategory>k__BackingField = value;
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x000BB778 File Offset: 0x000B9978
		// (set) Token: 0x0600118A RID: 4490 RVA: 0x000BB824 File Offset: 0x000B9A24
		[global::System.Runtime.Serialization.DataMember]
		public bool IsTemplateExist
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1286340609;
				if (num != 0)
				{
				}
				num = (short)1043084296;
				short num2 = num;
				num = (short)2012361736;
				switch (num2 == num)
				{
				}
				num = (short)1496252416;
				short num3 = num;
				num = (short)529530880;
				if (num != 0)
				{
				}
				return this.<IsTemplateExist>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1206284601;
				short num2 = num;
				num = (short)1048211769;
				switch (num2 == num)
				{
				}
				num = (short)242810881;
				if (num != 0)
				{
				}
				num = (short)1141506048;
				short num3 = num;
				num = (short)772866048;
				if (num != 0)
				{
				}
				this.<IsTemplateExist>k__BackingField = value;
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x000BB8D8 File Offset: 0x000B9AD8
		// (set) Token: 0x0600118C RID: 4492 RVA: 0x000BB98C File Offset: 0x000B9B8C
		[global::System.Runtime.Serialization.DataMember]
		public bool ApplyTemplateDone
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)974702106;
				short num2 = num;
				num = (short)1718339098;
				switch (num2 == num)
				{
				}
				num = (short)1621164033;
				if (num != 0)
				{
				}
				num = (short)858783744;
				short num3 = num;
				num = (short)384827392;
				if (num != 0)
				{
				}
				return this.<ApplyTemplateDone>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1370662260;
				short num2 = num;
				num = (short)1856873844;
				switch (num2 == num)
				{
				}
				num = (short)709951489;
				if (num != 0)
				{
				}
				num = (short)688521216;
				short num3 = num;
				num = (short)214695936;
				if (num != 0)
				{
				}
				this.<ApplyTemplateDone>k__BackingField = value;
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x000BBA3C File Offset: 0x000B9C3C
		// (set) Token: 0x0600118E RID: 4494 RVA: 0x000BBAEC File Offset: 0x000B9CEC
		[global::System.Runtime.Serialization.DataMember]
		public bool HasScheduleJob
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)745078785;
				if (num != 0)
				{
				}
				num = (short)1432699723;
				short num2 = num;
				num = (short)1827357515;
				switch (num2 == num)
				{
				}
				num = (short)1731067904;
				short num3 = num;
				num = (short)557383680;
				if (num != 0)
				{
				}
				return this.<HasScheduleJob>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1208540336;
				short num2 = num;
				num = (short)1278794928;
				switch (num2 == num)
				{
				}
				num = (short)1138425857;
				if (num != 0)
				{
				}
				num = (short)132841472;
				short num3 = num;
				num = (short)923205632;
				if (num != 0)
				{
				}
				this.<HasScheduleJob>k__BackingField = value;
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x000BBBA0 File Offset: 0x000B9DA0
		// (set) Token: 0x06001190 RID: 4496 RVA: 0x000BBC50 File Offset: 0x000B9E50
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.PacIdentifier Pac
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)373900655;
				short num2 = num;
				num = (short)2075084143;
				switch (num2 == num)
				{
				}
				num = (short)878968833;
				if (num != 0)
				{
				}
				num = (short)1817182208;
				short num3 = num;
				num = (short)1901592576;
				if (num != 0)
				{
				}
				return this.<Pac>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)277544961;
				if (num != 0)
				{
				}
				num = (short)1386563531;
				short num2 = num;
				num = (short)2063026123;
				switch (num2 == num)
				{
				}
				num = (short)35651584;
				short num3 = num;
				num = (short)372375552;
				if (num != 0)
				{
				}
				this.<Pac>k__BackingField = value;
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x000BBD04 File Offset: 0x000B9F04
		// (set) Token: 0x06001192 RID: 4498 RVA: 0x000BBDB8 File Offset: 0x000B9FB8
		[global::System.Runtime.Serialization.DataMember]
		public bool NeedResetPassword
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2144927745;
				if (num != 0)
				{
				}
				num = (short)1529814827;
				short num2 = num;
				num = (short)1366957867;
				switch (num2 == num)
				{
				}
				num = (short)782827520;
				short num3 = num;
				num = (short)2004025344;
				if (num != 0)
				{
				}
				return this.<NeedResetPassword>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)660974447;
				short num2 = num;
				num = (short)1627630447;
				switch (num2 == num)
				{
				}
				num = (short)117506048;
				if (num != 0)
				{
				}
				num = (short)576192512;
				short num3 = num;
				num = (short)1173159937;
				if (num != 0)
				{
				}
				this.<NeedResetPassword>k__BackingField = value;
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x000BBE68 File Offset: 0x000BA068
		// (set) Token: 0x06001194 RID: 4500 RVA: 0x000BBF14 File Offset: 0x000BA114
		[global::System.Runtime.Serialization.DataMember]
		[global::System.ComponentModel.DataAnnotations.Schema.Column("XmlData", TypeName = "XML")]
		public string XmlData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1482162177;
				if (num != 0)
				{
				}
				num = (short)1278959285;
				short num2 = num;
				num = (short)571629237;
				switch (num2 == num)
				{
				}
				num = (short)806420480;
				short num3 = num;
				num = (short)1880948736;
				if (num != 0)
				{
				}
				return this.<XmlData>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1735630835;
				short num2 = num;
				num = (short)1703124979;
				switch (num2 == num)
				{
				}
				num = (short)1685979136;
				if (num != 0)
				{
				}
				num = (short)991035392;
				short num3 = num;
				num = (short)1286930433;
				if (num != 0)
				{
				}
				this.<XmlData>k__BackingField = value;
			}
		}
	}
}
