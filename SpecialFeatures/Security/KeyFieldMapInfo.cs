using System;
using System.Xml.Serialization;
using AcpASKLib;

namespace SpecialFeatures.Security
{
	// Token: 0x0200004A RID: 74
	[global::System.Xml.Serialization.XmlType("KeyFieldMap")]
	[global::System.Serializable]
	public class KeyFieldMapInfo : global::SpecialFeatures.Security.FieldMapInfo
	{
		// Token: 0x060007CC RID: 1996 RVA: 0x00002899 File Offset: 0x00000A99
		public KeyFieldMapInfo()
		{
			this.keyType = global::AcpASKLib.KeyType.UNDEFINED_KEY;
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x000028AC File Offset: 0x00000AAC
		public KeyFieldMapInfo(string strFldName, global::AcpASKLib.AccessElementIDType id, global::AcpASKLib.KeyType uKeyType) : base(strFldName, id)
		{
			this.keyType = uKeyType;
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x0007A818 File Offset: 0x00078A18
		// (set) Token: 0x060007CF RID: 1999 RVA: 0x0007A8CC File Offset: 0x00078ACC
		[global::System.Xml.Serialization.XmlAttribute]
		public global::AcpASKLib.KeyType Type
		{
			get
			{
				short num = (short)1662124032;
				short num2 = num;
				num = (short)1239226174;
				short num3 = num;
				num = (short)2066749246;
				switch (num3 == num)
				{
				}
				num = (short)552992768;
				if (num != 0)
				{
				}
				num = (short)133038081;
				if (num != 0)
				{
				}
				return this.keyType;
			}
			set
			{
				short num = (short)1497890816;
				short num2 = num;
				num = (short)1071428139;
				short num3 = num;
				num = (short)1221177899;
				switch (num3 == num)
				{
				}
				num = (short)1227620353;
				if (num != 0)
				{
				}
				num = (short)281673728;
				if (num != 0)
				{
				}
				this.keyType = value;
			}
		}

		// Token: 0x040002FF RID: 767
		private global::AcpASKLib.KeyType keyType;
	}
}
