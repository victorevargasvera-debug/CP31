using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using ASK.Interface;

namespace ASK.Core
{
	// Token: 0x02000016 RID: 22
	[global::System.Serializable]
	public class FeatureCategory
	{
		// Token: 0x060000B6 RID: 182 RVA: 0x000126A0 File Offset: 0x000108A0
		public FeatureCategory()
		{
			this.type = global::ASK.Interface.FeatureCategoryType.UNKNOWN;
			this.features = new global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessNode>();
			this.functions = new global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessNode>();
			this.radioType = global::ASK.Interface.FeatureCategoryRadioType.XTSXTLRadios;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000126D8 File Offset: 0x000108D8
		public FeatureCategory(string sName, global::ASK.Interface.FeatureCategoryType catType)
		{
			this.name = sName;
			this.features = new global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessNode>();
			this.functions = new global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessNode>();
			this.type = catType;
			this.radioType = global::ASK.Interface.FeatureCategoryRadioType.XTSXTLRadios;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00012718 File Offset: 0x00010918
		public FeatureCategory(string sName, global::ASK.Interface.FeatureCategoryType catType, global::ASK.Interface.FeatureCategoryRadioType radType)
		{
			this.name = sName;
			this.features = new global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessNode>();
			this.functions = new global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessNode>();
			this.type = catType;
			this.radioType = radType;
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00012758 File Offset: 0x00010958
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00012808 File Offset: 0x00010A08
		[global::System.Xml.Serialization.XmlAttribute]
		public string Name
		{
			get
			{
				short num = (short)50488192;
				short num2 = num;
				num = (short)369320832;
				switch (num2 == num)
				{
				}
				num = (short)1993998336;
				short num3 = num;
				num = (short)1668284417;
				if (num != 0)
				{
				}
				num = (short)2054291456;
				if (num != 0)
				{
				}
				return this.name;
			}
			set
			{
				short num = (short)1178765073;
				short num2 = num;
				num = (short)1040484113;
				switch (num2 == num)
				{
				}
				num = (short)1291059200;
				short num3 = num;
				num = (short)1057226752;
				if (num != 0)
				{
				}
				num = (short)209321985;
				if (num != 0)
				{
				}
				this.name = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000128B8 File Offset: 0x00010AB8
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00012968 File Offset: 0x00010B68
		[global::System.Xml.Serialization.XmlAttribute]
		public global::ASK.Interface.FeatureCategoryType Type
		{
			get
			{
				short num = (short)407430643;
				short num2 = num;
				num = (short)2004149747;
				switch (num2 == num)
				{
				}
				num = (short)659947520;
				short num3 = num;
				num = (short)370540545;
				if (num != 0)
				{
				}
				num = (short)142213120;
				if (num != 0)
				{
				}
				return this.type;
			}
			set
			{
				short num = (short)1714862162;
				short num2 = num;
				num = (short)676247634;
				switch (num2 == num)
				{
				}
				num = (short)1794768896;
				short num3 = num;
				num = (short)79036416;
				if (num != 0)
				{
				}
				num = (short)2028797953;
				if (num != 0)
				{
				}
				this.type = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00012A18 File Offset: 0x00010C18
		[global::System.Xml.Serialization.XmlElement("Feature")]
		public global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessNode> Features
		{
			get
			{
				short num = (short)1963003056;
				short num2 = num;
				num = (short)607063216;
				switch (num2 == num)
				{
				}
				num = (short)1572012032;
				short num3 = num;
				num = (short)639434753;
				if (num != 0)
				{
				}
				num = (short)131137536;
				if (num != 0)
				{
				}
				return this.features;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00012AC8 File Offset: 0x00010CC8
		[global::System.Xml.Serialization.XmlElement("Function")]
		public global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessNode> Functions
		{
			get
			{
				short num = (short)826081281;
				if (num != 0)
				{
				}
				num = (short)504346732;
				short num2 = num;
				num = (short)616937580;
				switch (num2 == num)
				{
				default:
				{
					num = (short)943063040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)424148992;
				if (num != 0)
				{
				}
				return this.functions;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00012B78 File Offset: 0x00010D78
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00012C28 File Offset: 0x00010E28
		[global::System.Xml.Serialization.XmlAttribute("RadioType")]
		public global::ASK.Interface.FeatureCategoryRadioType RadioType
		{
			get
			{
				short num = (short)507319704;
				short num2 = num;
				num = (short)248059288;
				switch (num2 == num)
				{
				}
				num = (short)1247805440;
				short num3 = num;
				num = (short)1198194689;
				if (num != 0)
				{
				}
				num = (short)1062207488;
				if (num != 0)
				{
				}
				return this.radioType;
			}
			set
			{
				short num = (short)220526208;
				short num2 = num;
				num = (short)2110584448;
				switch (num2 == num)
				{
				}
				num = (short)678035456;
				short num3 = num;
				num = (short)1906049025;
				if (num != 0)
				{
				}
				num = (short)606011392;
				if (num != 0)
				{
				}
				this.radioType = value;
			}
		}

		// Token: 0x0400005B RID: 91
		private string name;

		// Token: 0x0400005C RID: 92
		private global::ASK.Interface.FeatureCategoryType type;

		// Token: 0x0400005D RID: 93
		private global::ASK.Interface.FeatureCategoryRadioType radioType;

		// Token: 0x0400005E RID: 94
		private global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessNode> features;

		// Token: 0x0400005F RID: 95
		private global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessNode> functions;
	}
}
