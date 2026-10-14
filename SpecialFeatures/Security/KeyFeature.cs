using System;
using System.Xml.Serialization;
using AcpASKLib;

namespace SpecialFeatures.Security
{
	// Token: 0x02000047 RID: 71
	[global::System.Serializable]
	public class KeyFeature : global::SpecialFeatures.Security.Feature
	{
		// Token: 0x060007B7 RID: 1975 RVA: 0x00002802 File Offset: 0x00000A02
		public KeyFeature()
		{
			this.keyTypeFieldName = null;
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00002811 File Offset: 0x00000A11
		public KeyFeature(string sName, global::SpecialFeatures.Security.CpsFeatureID cpsFeatId, global::AcpASKLib.FeatureCategoryType catType, string keyTypeFld) : base(sName, cpsFeatId, catType)
		{
			this.keyTypeFieldName = keyTypeFld;
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x00079DB8 File Offset: 0x00077FB8
		// (set) Token: 0x060007BA RID: 1978 RVA: 0x00079E68 File Offset: 0x00078068
		[global::System.Xml.Serialization.XmlAttribute]
		public string KeyTypeFieldName
		{
			get
			{
				short num = (short)1246285293;
				short num2 = num;
				num = (short)1895353837;
				switch (num2 == num)
				{
				}
				num = (short)2109603841;
				if (num != 0)
				{
				}
				num = (short)1091698688;
				short num3 = num;
				num = (short)1266417664;
				if (num != 0)
				{
				}
				return this.keyTypeFieldName;
			}
			set
			{
				short num = (short)1407895628;
				short num2 = num;
				num = (short)998950988;
				switch (num2 == num)
				{
				}
				num = (short)1548419073;
				if (num != 0)
				{
				}
				num = (short)1742798848;
				short num3 = num;
				num = (short)567607296;
				if (num != 0)
				{
				}
				this.keyTypeFieldName = value;
			}
		}

		// Token: 0x040002F7 RID: 759
		private string keyTypeFieldName;
	}
}
