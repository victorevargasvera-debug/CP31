using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000166 RID: 358
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class QueryNode
	{
		// Token: 0x06001398 RID: 5016 RVA: 0x000D0400 File Offset: 0x000CE600
		public QueryNode()
		{
			this.Index = -1;
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x000D041C File Offset: 0x000CE61C
		public QueryNode(string setType, global::Motorola.CommonCPS.Server.CommonDBConstants.AndOR andOr, global::Motorola.CommonCPS.Server.CommonDBConstants.Operator op, string fieldDBName, string fieldUIName, global::Motorola.CommonCPS.Server.CommonDBConstants.FieldLocation fieldLocation, global::Motorola.CommonCPS.Server.CommonDBConstants.DBFieldType fieldDataType, string value)
		{
			this.SetType = setType;
			this.AndOr = andOr;
			this.Operator = op;
			this.FieldDBName = fieldDBName;
			this.FieldUIName = fieldUIName;
			this.FieldLocation = fieldLocation;
			this.FieldDataType = fieldDataType;
			this.Value = value;
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x000D046C File Offset: 0x000CE66C
		// (set) Token: 0x0600139B RID: 5019 RVA: 0x000D051C File Offset: 0x000CE71C
		[global::System.Xml.Serialization.XmlElement("QueryNode")]
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.QueryNode> ChildNodeList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1539642701;
				short num2 = num;
				num = (short)1506678093;
				switch (num2 == num)
				{
				}
				num = (short)894042112;
				if (num != 0)
				{
				}
				num = (short)1631780864;
				short num3 = num;
				num = (short)942800897;
				if (num != 0)
				{
				}
				return this.<ChildNodeList>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1088842473;
				short num2 = num;
				num = (short)1868065513;
				switch (num2 == num)
				{
				}
				num = (short)1179649;
				if (num != 0)
				{
				}
				num = (short)842399744;
				short num3 = num;
				num = (short)1746141184;
				if (num != 0)
				{
				}
				this.<ChildNodeList>k__BackingField = value;
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x000D05CC File Offset: 0x000CE7CC
		// (set) Token: 0x0600139D RID: 5021 RVA: 0x000D067C File Offset: 0x000CE87C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::System.Guid> ResultSet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1733493675;
				short num2 = num;
				num = (short)1900807083;
				switch (num2 == num)
				{
				}
				num = (short)694026240;
				if (num != 0)
				{
				}
				num = (short)336199680;
				short num3 = num;
				num = (short)776601601;
				if (num != 0)
				{
				}
				return this.<ResultSet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1935110076;
				short num2 = num;
				num = (short)1359114172;
				switch (num2 == num)
				{
				}
				num = (short)1396703233;
				if (num != 0)
				{
				}
				num = (short)1143472128;
				short num3 = num;
				num = (short)1350828032;
				if (num != 0)
				{
				}
				this.<ResultSet>k__BackingField = value;
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x000D072C File Offset: 0x000CE92C
		public bool IsParentNode
		{
			get
			{
				short num = (short)1032219763;
				short num2 = num;
				num = (short)325086323;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2000027649;
					if (num != 0)
					{
					}
					num = (short)945356800;
					if (num != 0)
					{
					}
					if (this.ChildNodeList == null)
					{
						return false;
					}
					num = (short)2123300864;
					short num3 = num;
					break;
				}
				}
				return this.ChildNodeList.Count > 0;
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x0600139F RID: 5023 RVA: 0x000D07F0 File Offset: 0x000CE9F0
		// (set) Token: 0x060013A0 RID: 5024 RVA: 0x000D08A4 File Offset: 0x000CEAA4
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.Runtime.Serialization.DataMember]
		public string TargetSetType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2110763652;
				short num2 = num;
				num = (short)993374852;
				switch (num2 == num)
				{
				}
				num = (short)1982332928;
				if (num != 0)
				{
				}
				num = (short)1570045952;
				short num3 = num;
				num = (short)1254752257;
				if (num != 0)
				{
				}
				return this.<TargetSetType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)422616642;
				short num2 = num;
				num = (short)612539970;
				switch (num2 == num)
				{
				}
				num = (short)1419378689;
				if (num != 0)
				{
				}
				num = (short)1449066496;
				short num3 = num;
				num = (short)1988427776;
				if (num != 0)
				{
				}
				this.<TargetSetType>k__BackingField = value;
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x000D0954 File Offset: 0x000CEB54
		// (set) Token: 0x060013A2 RID: 5026 RVA: 0x000D0A04 File Offset: 0x000CEC04
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlAttribute]
		public string SetType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)114282500;
				short num2 = num;
				num = (short)1850658820;
				switch (num2 == num)
				{
				}
				num = (short)1645608960;
				if (num != 0)
				{
				}
				num = (short)735051776;
				short num3 = num;
				num = (short)37552129;
				if (num != 0)
				{
				}
				return this.<SetType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)695677257;
				short num2 = num;
				num = (short)750072137;
				switch (num2 == num)
				{
				}
				num = (short)157876225;
				if (num != 0)
				{
				}
				num = (short)1668939776;
				short num3 = num;
				num = (short)1544617984;
				if (num != 0)
				{
				}
				this.<SetType>k__BackingField = value;
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x060013A3 RID: 5027 RVA: 0x000D0AB4 File Offset: 0x000CECB4
		// (set) Token: 0x060013A4 RID: 5028 RVA: 0x000D0B60 File Offset: 0x000CED60
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.Runtime.Serialization.DataMember]
		public int Index
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1806584727;
				short num2 = num;
				num = (short)1551649687;
				switch (num2 == num)
				{
				}
				num = (short)1746534400;
				if (num != 0)
				{
				}
				num = (short)2039873536;
				short num3 = num;
				num = (short)1457979393;
				if (num != 0)
				{
				}
				return this.<Index>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1033554599;
				short num2 = num;
				num = (short)1323092647;
				switch (num2 == num)
				{
				}
				num = (short)1313013760;
				if (num != 0)
				{
				}
				num = (short)1112604672;
				short num3 = num;
				num = (short)2139291649;
				if (num != 0)
				{
				}
				this.<Index>k__BackingField = value;
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x060013A5 RID: 5029 RVA: 0x000D0C10 File Offset: 0x000CEE10
		// (set) Token: 0x060013A6 RID: 5030 RVA: 0x000D0CC0 File Offset: 0x000CEEC0
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlAttribute]
		public string UISetType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)68304472;
				short num2 = num;
				num = (short)1560231512;
				switch (num2 == num)
				{
				}
				num = (short)1655242753;
				if (num != 0)
				{
				}
				num = (short)516620288;
				short num3 = num;
				num = (short)864813056;
				if (num != 0)
				{
				}
				return this.<UISetType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)778092261;
				short num2 = num;
				num = (short)1965276901;
				switch (num2 == num)
				{
				}
				num = (short)786890752;
				if (num != 0)
				{
				}
				num = (short)763559936;
				short num3 = num;
				num = (short)413663233;
				if (num != 0)
				{
				}
				this.<UISetType>k__BackingField = value;
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x060013A7 RID: 5031 RVA: 0x000D0D70 File Offset: 0x000CEF70
		// (set) Token: 0x060013A8 RID: 5032 RVA: 0x000D0E20 File Offset: 0x000CF020
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlAttribute]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.AndOR AndOr
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)260418793;
				short num2 = num;
				num = (short)236104937;
				switch (num2 == num)
				{
				}
				num = (short)321650688;
				if (num != 0)
				{
				}
				num = (short)591986688;
				short num3 = num;
				num = (short)692977665;
				if (num != 0)
				{
				}
				return this.<AndOr>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)149322620;
				short num2 = num;
				num = (short)1514896252;
				switch (num2 == num)
				{
				}
				num = (short)1230372864;
				if (num != 0)
				{
				}
				num = (short)104464384;
				short num3 = num;
				num = (short)454557697;
				if (num != 0)
				{
				}
				this.<AndOr>k__BackingField = value;
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x000D0ED4 File Offset: 0x000CF0D4
		// (set) Token: 0x060013AA RID: 5034 RVA: 0x000D0F80 File Offset: 0x000CF180
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlAttribute]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.Operator Operator
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1239547583;
				short num2 = num;
				num = (short)1960050367;
				switch (num2 == num)
				{
				}
				num = (short)247136257;
				if (num != 0)
				{
				}
				num = (short)1145634816;
				short num3 = num;
				num = (short)575275008;
				if (num != 0)
				{
				}
				return this.<Operator>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)481152866;
				short num2 = num;
				num = (short)586338146;
				switch (num2 == num)
				{
				}
				num = (short)1126694913;
				if (num != 0)
				{
				}
				num = (short)2118320128;
				short num3 = num;
				num = (short)2035286016;
				if (num != 0)
				{
				}
				this.<Operator>k__BackingField = value;
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x000D1030 File Offset: 0x000CF230
		// (set) Token: 0x060013AC RID: 5036 RVA: 0x000D10E0 File Offset: 0x000CF2E0
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlAttribute]
		public string FieldDBName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)19398657;
				if (num != 0)
				{
				}
				num = (short)1916052438;
				short num2 = num;
				num = (short)1770824662;
				switch (num2 == num)
				{
				}
				num = (short)480641024;
				short num3 = num;
				num = (short)1981743104;
				if (num != 0)
				{
				}
				return this.<FieldDBName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1072995143;
				short num2 = num;
				num = (short)1535810375;
				switch (num2 == num)
				{
				}
				num = (short)645660672;
				if (num != 0)
				{
				}
				num = (short)1812791296;
				short num3 = num;
				num = (short)430768129;
				if (num != 0)
				{
				}
				this.<FieldDBName>k__BackingField = value;
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x000D1190 File Offset: 0x000CF390
		// (set) Token: 0x060013AE RID: 5038 RVA: 0x000D1244 File Offset: 0x000CF444
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlAttribute]
		public string FieldUIName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1668284417;
				if (num != 0)
				{
				}
				num = (short)915746627;
				short num2 = num;
				num = (short)975515459;
				switch (num2 == num)
				{
				}
				num = (short)319291392;
				short num3 = num;
				num = (short)1525219328;
				if (num != 0)
				{
				}
				return this.<FieldUIName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1478511879;
				short num2 = num;
				num = (short)1127238919;
				switch (num2 == num)
				{
				}
				num = (short)1686634497;
				if (num != 0)
				{
				}
				num = (short)1762918400;
				short num3 = num;
				num = (short)1877344256;
				if (num != 0)
				{
				}
				this.<FieldUIName>k__BackingField = value;
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x060013AF RID: 5039 RVA: 0x000D12F4 File Offset: 0x000CF4F4
		// (set) Token: 0x060013B0 RID: 5040 RVA: 0x000D13A4 File Offset: 0x000CF5A4
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.DBFieldType FieldDataType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)712053394;
				short num2 = num;
				num = (short)1903104658;
				switch (num2 == num)
				{
				}
				num = (short)310444033;
				if (num != 0)
				{
				}
				num = (short)1987969024;
				short num3 = num;
				num = (short)846462976;
				if (num != 0)
				{
				}
				return this.<FieldDataType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1440397041;
				short num2 = num;
				num = (short)2077079281;
				switch (num2 == num)
				{
				}
				num = (short)432537600;
				if (num != 0)
				{
				}
				num = (short)381943808;
				short num3 = num;
				num = (short)577110017;
				if (num != 0)
				{
				}
				this.<FieldDataType>k__BackingField = value;
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x060013B1 RID: 5041 RVA: 0x000D1454 File Offset: 0x000CF654
		// (set) Token: 0x060013B2 RID: 5042 RVA: 0x000D1504 File Offset: 0x000CF704
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlAttribute]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.FieldLocation FieldLocation
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1987706880;
				short num2 = num;
				num = (short)760152065;
				if (num != 0)
				{
				}
				num = (short)400594695;
				short num3 = num;
				num = (short)326080263;
				switch (num3 == num)
				{
				}
				num = (short)1493696512;
				if (num != 0)
				{
				}
				return this.<FieldLocation>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2080178176;
				short num2 = num;
				num = (short)521280915;
				short num3 = num;
				num = (short)1973165459;
				switch (num3 == num)
				{
				}
				num = (short)830275585;
				if (num != 0)
				{
				}
				num = (short)1679622144;
				if (num != 0)
				{
				}
				this.<FieldLocation>k__BackingField = value;
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x060013B3 RID: 5043 RVA: 0x000D15B4 File Offset: 0x000CF7B4
		// (set) Token: 0x060013B4 RID: 5044 RVA: 0x000D1664 File Offset: 0x000CF864
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlAttribute]
		public string Value
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1093533696;
				short num2 = num;
				num = (short)1770060005;
				short num3 = num;
				num = (short)1971517669;
				switch (num3 == num)
				{
				}
				num = (short)803733505;
				if (num != 0)
				{
				}
				num = (short)1029767168;
				if (num != 0)
				{
				}
				return this.<Value>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1620705280;
				short num2 = num;
				num = (short)1381481418;
				short num3 = num;
				num = (short)44022730;
				switch (num3 == num)
				{
				}
				num = (short)777912320;
				if (num != 0)
				{
				}
				num = (short)1766719489;
				if (num != 0)
				{
				}
				this.<Value>k__BackingField = value;
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x000D1718 File Offset: 0x000CF918
		// (set) Token: 0x060013B6 RID: 5046 RVA: 0x000D17C4 File Offset: 0x000CF9C4
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.Runtime.Serialization.DataMember]
		public string UIValue
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)7340032;
				short num2 = num;
				num = (short)975576556;
				short num3 = num;
				num = (short)780934636;
				switch (num3 == num)
				{
				}
				num = (short)1398013953;
				if (num != 0)
				{
				}
				num = (short)1237843968;
				if (num != 0)
				{
				}
				return this.<UIValue>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1832779776;
				short num2 = num;
				num = (short)1153900279;
				short num3 = num;
				num = (short)1036787447;
				switch (num3 == num)
				{
				}
				num = (short)1809186816;
				if (num != 0)
				{
				}
				num = (short)853409793;
				if (num != 0)
				{
				}
				this.<UIValue>k__BackingField = value;
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x000D1874 File Offset: 0x000CFA74
		public object DBValue
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::Motorola.CommonCPS.Server.CommonDBConstants.DBFieldType fieldDataType;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						num2 = (short)866254849;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_D6;
					case 2:
						switch (fieldDataType)
						{
						case global::Motorola.CommonCPS.Server.CommonDBConstants.DBFieldType.Int:
							goto IL_92;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.DBFieldType.Numeric:
							goto IL_DB;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.DBFieldType.Binary:
							goto IL_164;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.DBFieldType.DataTime:
							goto IL_A8;
						default:
							num2 = (short)2098462720;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					goto IL_1C;
				}
				IL_92:
				return int.Parse(this.Value, global::System.Globalization.CultureInfo.InvariantCulture);
				IL_A8:
				return global::System.DateTime.Parse(this.Value, global::System.Globalization.CultureInfo.InvariantCulture);
				IL_D6:
				goto IL_164;
				IL_DB:
				num2 = (short)741021207;
				short num3 = num2;
				num2 = (short)226301463;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num2 = (short)156041217;
					if (num2 != 0)
					{
					}
					num2 = (short)1651769344;
					if (num2 != 0)
					{
					}
					return decimal.Parse(this.Value, global::System.Globalization.CultureInfo.InvariantCulture);
				}
				IL_164:
				return this.Value;
				IL_1C:
				fieldDataType = this.FieldDataType;
				num2 = (short)491520000;
				short num4 = num2;
				num2 = (short)1271201794;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x000D19EC File Offset: 0x000CFBEC
		public string DBOperator
		{
			get
			{
				int a_ = 13;
				switch (0)
				{
				case 0:
					goto IL_25;
				}
				int num;
				short num2;
				global::Motorola.CommonCPS.Server.CommonDBConstants.Operator @operator;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1997471744;
						short num3 = num2;
						num2 = (short)547422209;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						goto IL_123;
					case 2:
						num2 = (short)335347713;
						if (num2 != 0)
						{
						}
						switch (@operator)
						{
						case global::Motorola.CommonCPS.Server.CommonDBConstants.Operator.LessThan:
							goto IL_19F;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.Operator.LessEqual:
							goto IL_190;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.Operator.Equal:
							goto IL_C5;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.Operator.MoreEqual:
						{
							num2 = (short)509214271;
							short num4 = num2;
							num2 = (short)187891263;
							switch ((num4 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								goto IL_15D;
							}
							break;
						}
						case global::Motorola.CommonCPS.Server.CommonDBConstants.Operator.MoreThan:
							goto IL_B6;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.Operator.Unequal:
							goto IL_A7;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.Operator.Contains:
							goto IL_D4;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.Operator.NotContains:
							goto IL_181;
						default:
							num2 = (short)1671430144;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					goto IL_25;
				}
				IL_A7:
				return global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("⨊「", a_);
				IL_B6:
				return global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("㔊", a_);
				IL_C5:
				return global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("㘊", a_);
				IL_D4:
				return global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䜊䐌䐎吐", a_);
				IL_123:
				return global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("㘊", a_);
				IL_15D:
				num2 = (short)1302659072;
				if (num2 != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("㔊「", a_);
				IL_181:
				return global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䔊䈌嬎ㄐ弒尔尖尘", a_);
				IL_190:
				return global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("㜊「", a_);
				IL_19F:
				return global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("㜊", a_);
				IL_25:
				@operator = this.Operator;
				num2 = (short)1293090818;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
		}
	}
}
