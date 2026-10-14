using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace AcpASKLib
{
	// Token: 0x02000024 RID: 36
	[global::System.Serializable]
	public class FeatureCategory
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x00011830 File Offset: 0x0000FA30
		public FeatureCategory()
		{
			this.type = global::AcpASKLib.FeatureCategoryType.UNKNOWN;
			this.features = new global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessNode>();
			this.functions = new global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessNode>();
			this.radioType = global::AcpASKLib.FeatureCategoryRadioType.XTSXTLRadios;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00011868 File Offset: 0x0000FA68
		public FeatureCategory(string sName, global::AcpASKLib.FeatureCategoryType catType)
		{
			this.name = sName;
			this.features = new global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessNode>();
			this.functions = new global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessNode>();
			this.type = catType;
			this.radioType = global::AcpASKLib.FeatureCategoryRadioType.XTSXTLRadios;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000118A8 File Offset: 0x0000FAA8
		public FeatureCategory(string sName, global::AcpASKLib.FeatureCategoryType catType, global::AcpASKLib.FeatureCategoryRadioType radType)
		{
			this.name = sName;
			this.features = new global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessNode>();
			this.functions = new global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessNode>();
			this.type = catType;
			this.radioType = radType;
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000118E8 File Offset: 0x0000FAE8
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00011998 File Offset: 0x0000FB98
		[global::System.Xml.Serialization.XmlAttribute]
		public string Name
		{
			get
			{
				short num = (short)1506934784;
				short num2 = num;
				num = (short)973289602;
				short num3 = num;
				num = (short)1662400642;
				switch (num3 == num)
				{
				}
				num = (short)51183616;
				if (num != 0)
				{
				}
				num = (short)705167361;
				if (num != 0)
				{
				}
				return this.name;
			}
			set
			{
				short num = (short)1138098176;
				short num2 = num;
				num = (short)1254354310;
				short num3 = num;
				num = (short)1541533062;
				switch (num3 == num)
				{
				}
				num = (short)1368719361;
				if (num != 0)
				{
				}
				num = (short)1743978496;
				if (num != 0)
				{
				}
				this.name = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00011A4C File Offset: 0x0000FC4C
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00011AF8 File Offset: 0x0000FCF8
		[global::System.Xml.Serialization.XmlAttribute]
		public global::AcpASKLib.FeatureCategoryType Type
		{
			get
			{
				short num = (short)1648361472;
				short num2 = num;
				num = (short)904936294;
				short num3 = num;
				num = (short)1558985574;
				switch (num3 == num)
				{
				}
				num = (short)921501697;
				if (num != 0)
				{
				}
				num = (short)1161101312;
				if (num != 0)
				{
				}
				return this.type;
			}
			set
			{
				short num = (short)1179516928;
				short num2 = num;
				num = (short)985326507;
				short num3 = num;
				num = (short)365683627;
				switch (num3 == num)
				{
				}
				num = (short)1946877952;
				if (num != 0)
				{
				}
				num = (short)619839489;
				if (num != 0)
				{
				}
				this.type = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00011BA4 File Offset: 0x0000FDA4
		[global::System.Xml.Serialization.XmlElement("Feature")]
		public global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessNode> Features
		{
			get
			{
				short num = (short)1770848256;
				short num2 = num;
				num = (short)1073978175;
				short num3 = num;
				num = (short)580098879;
				switch (num3 == num)
				{
				}
				num = (short)1170538497;
				if (num != 0)
				{
				}
				num = (short)1872756736;
				if (num != 0)
				{
				}
				return this.features;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00011C54 File Offset: 0x0000FE54
		[global::System.Xml.Serialization.XmlElement("Function")]
		public global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessNode> Functions
		{
			get
			{
				short num = (short)464519168;
				short num2 = num;
				num = (short)340029965;
				short num3 = num;
				num = (short)1731949069;
				switch (num3 == num)
				{
				}
				num = (short)1370816512;
				if (num != 0)
				{
				}
				num = (short)12779521;
				if (num != 0)
				{
				}
				return this.functions;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00011D04 File Offset: 0x0000FF04
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00011DB4 File Offset: 0x0000FFB4
		[global::System.Xml.Serialization.XmlAttribute("RadioType")]
		public global::AcpASKLib.FeatureCategoryRadioType RadioType
		{
			get
			{
				short num = (short)1931542528;
				short num2 = num;
				num = (short)896978535;
				short num3 = num;
				num = (short)2131021415;
				switch (num3 == num)
				{
				}
				num = (short)824377345;
				if (num != 0)
				{
				}
				num = (short)1154940928;
				if (num != 0)
				{
				}
				return this.radioType;
			}
			set
			{
				short num = (short)1216872448;
				short num2 = num;
				num = (short)1712062465;
				if (num != 0)
				{
				}
				num = (short)1807637544;
				short num3 = num;
				num = (short)872176680;
				switch (num3 == num)
				{
				}
				num = (short)254148608;
				if (num != 0)
				{
				}
				this.radioType = value;
			}
		}

		// Token: 0x04000169 RID: 361
		private string name;

		// Token: 0x0400016A RID: 362
		private global::AcpASKLib.FeatureCategoryType type;

		// Token: 0x0400016B RID: 363
		private global::AcpASKLib.FeatureCategoryRadioType radioType;

		// Token: 0x0400016C RID: 364
		private global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessNode> features;

		// Token: 0x0400016D RID: 365
		private global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessNode> functions;
	}
}
