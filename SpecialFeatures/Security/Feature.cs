using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using AcpASKLib;

namespace SpecialFeatures.Security
{
	// Token: 0x02000048 RID: 72
	[global::System.Serializable]
	public class Feature
	{
		// Token: 0x060007BB RID: 1979 RVA: 0x00002824 File Offset: 0x00000A24
		public Feature()
		{
			this.type = global::AcpASKLib.FeatureCategoryType.UNKNOWN;
			this.fldMaps = new global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.FieldMapInfo>();
			this.name = null;
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00002845 File Offset: 0x00000A45
		public Feature(string sName, global::SpecialFeatures.Security.CpsFeatureID cpsFeatId, global::AcpASKLib.FeatureCategoryType catType)
		{
			this.name = sName;
			this.cpsFeatureID = cpsFeatId;
			this.fldMaps = new global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.FieldMapInfo>();
			this.type = catType;
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x00079F18 File Offset: 0x00078118
		// (set) Token: 0x060007BE RID: 1982 RVA: 0x00079FC8 File Offset: 0x000781C8
		[global::System.Xml.Serialization.XmlAttribute]
		public string Name
		{
			get
			{
				short num = (short)659288456;
				short num2 = num;
				num = (short)967045512;
				switch (num2 == num)
				{
				}
				num = (short)188678144;
				if (num != 0)
				{
				}
				num = (short)436469760;
				short num3 = num;
				num = (short)984350721;
				if (num != 0)
				{
				}
				return this.name;
			}
			set
			{
				short num = (short)449015456;
				short num2 = num;
				num = (short)148532896;
				switch (num2 == num)
				{
				}
				num = (short)436600833;
				if (num != 0)
				{
				}
				num = (short)500695040;
				short num3 = num;
				num = (short)1541996544;
				if (num != 0)
				{
				}
				this.name = value;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x0007A078 File Offset: 0x00078278
		// (set) Token: 0x060007C0 RID: 1984 RVA: 0x0007A128 File Offset: 0x00078328
		[global::System.Xml.Serialization.XmlAttribute]
		public global::SpecialFeatures.Security.CpsFeatureID FeatureID
		{
			get
			{
				short num = (short)53539949;
				short num2 = num;
				num = (short)755299437;
				switch (num2 == num)
				{
				}
				num = (short)1597308929;
				if (num != 0)
				{
				}
				num = (short)920190976;
				short num3 = num;
				num = (short)1394606080;
				if (num != 0)
				{
				}
				return this.cpsFeatureID;
			}
			set
			{
				short num = (short)1393988296;
				short num2 = num;
				num = (short)1254003400;
				switch (num2 == num)
				{
				}
				num = (short)1861287937;
				if (num != 0)
				{
				}
				num = (short)2111569920;
				short num3 = num;
				num = (short)713293824;
				if (num != 0)
				{
				}
				this.cpsFeatureID = value;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x0007A1DC File Offset: 0x000783DC
		// (set) Token: 0x060007C2 RID: 1986 RVA: 0x0007A290 File Offset: 0x00078490
		[global::System.Xml.Serialization.XmlAttribute]
		public global::AcpASKLib.FeatureCategoryType Type
		{
			get
			{
				short num = (short)1863569472;
				short num2 = num;
				num = (short)990761024;
				switch (num2 == num)
				{
				}
				num = (short)1493762049;
				if (num != 0)
				{
				}
				num = (short)1374420992;
				short num3 = num;
				num = (short)1335558144;
				if (num != 0)
				{
				}
				return this.type;
			}
			set
			{
				short num = (short)1054644532;
				short num2 = num;
				num = (short)1066703156;
				switch (num2 == num)
				{
				}
				num = (short)815071232;
				if (num != 0)
				{
				}
				num = (short)1229389824;
				short num3 = num;
				num = (short)1216217089;
				if (num != 0)
				{
				}
				this.type = value;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x0007A340 File Offset: 0x00078540
		[global::System.Xml.Serialization.XmlElement(typeof(global::SpecialFeatures.Security.RefKeyFieldMapInfo))]
		[global::System.Xml.Serialization.XmlElement]
		[global::System.Xml.Serialization.XmlElement(typeof(global::SpecialFeatures.Security.KeyFieldMapInfo))]
		public global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.FieldMapInfo> FieldMap
		{
			get
			{
				short num = (short)2023185149;
				short num2 = num;
				num = (short)896424701;
				switch (num2 == num)
				{
				}
				num = (short)1802829825;
				if (num != 0)
				{
				}
				num = (short)384630784;
				short num3 = num;
				num = (short)1007222784;
				if (num != 0)
				{
				}
				return this.fldMaps;
			}
		}

		// Token: 0x040002F8 RID: 760
		private string name;

		// Token: 0x040002F9 RID: 761
		private global::AcpASKLib.FeatureCategoryType type;

		// Token: 0x040002FA RID: 762
		private global::SpecialFeatures.Security.CpsFeatureID cpsFeatureID;

		// Token: 0x040002FB RID: 763
		private global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Security.FieldMapInfo> fldMaps;
	}
}
