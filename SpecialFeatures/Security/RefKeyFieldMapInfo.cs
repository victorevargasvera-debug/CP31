using System;
using System.Xml.Serialization;
using AcpASKLib;

namespace SpecialFeatures.Security
{
	// Token: 0x0200004B RID: 75
	[global::System.Xml.Serialization.XmlType("RefKeyFieldMap")]
	[global::System.Serializable]
	public class RefKeyFieldMapInfo : global::SpecialFeatures.Security.FieldMapInfo
	{
		// Token: 0x060007D0 RID: 2000 RVA: 0x000028BD File Offset: 0x00000ABD
		public RefKeyFieldMapInfo()
		{
			this.refFeatureName = null;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x000028CC File Offset: 0x00000ACC
		public RefKeyFieldMapInfo(string strFldName, global::AcpASKLib.AccessElementIDType id, string refFeatName) : base(strFldName, id)
		{
			this.refFeatureName = refFeatName;
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x0007A97C File Offset: 0x00078B7C
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x0007AA2C File Offset: 0x00078C2C
		[global::System.Xml.Serialization.XmlAttribute]
		public string ReferencedFeatureName
		{
			get
			{
				short num = (short)1798176768;
				short num2 = num;
				num = (short)148245494;
				short num3 = num;
				num = (short)381029366;
				switch (num3 == num)
				{
				}
				num = (short)1396899840;
				if (num != 0)
				{
				}
				num = (short)2090926081;
				if (num != 0)
				{
				}
				return this.refFeatureName;
			}
			set
			{
				short num = (short)23330816;
				short num2 = num;
				num = (short)248963722;
				short num3 = num;
				num = (short)384098954;
				switch (num3 == num)
				{
				}
				num = (short)691273729;
				if (num != 0)
				{
				}
				num = (short)256638976;
				if (num != 0)
				{
				}
				this.refFeatureName = value;
			}
		}

		// Token: 0x04000300 RID: 768
		private string refFeatureName;
	}
}
