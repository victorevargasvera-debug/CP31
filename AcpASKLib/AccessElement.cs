using System;
using System.Xml.Serialization;

namespace AcpASKLib
{
	// Token: 0x02000003 RID: 3
	[global::System.Serializable]
	public class AccessElement
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002124 File Offset: 0x00000324
		public AccessElement()
		{
			this.name = null;
			this.uiName = null;
			this.bitID = 0;
			this.elementID = global::AcpASKLib.AccessElementIDType.UNDEFINED;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002154 File Offset: 0x00000354
		public AccessElement(string strName, string strUiName, int id, global::AcpASKLib.AccessElementIDType elemId)
		{
			this.name = strName;
			this.uiName = strUiName;
			this.bitID = id;
			this.elementID = elemId;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002184 File Offset: 0x00000384
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002238 File Offset: 0x00000438
		[global::System.Xml.Serialization.XmlAttribute]
		public int ID
		{
			get
			{
				short num = (short)836651985;
				short num2 = num;
				num = (short)1056787409;
				switch (num2 == num)
				{
				}
				num = (short)62390273;
				if (num != 0)
				{
				}
				num = (short)1683816448;
				if (num != 0)
				{
				}
				num = (short)280297472;
				short num3 = num;
				return this.bitID;
			}
			set
			{
				short num = (short)1773652600;
				short num2 = num;
				num = (short)894945912;
				switch (num2 == num)
				{
				}
				num = (short)2036858881;
				if (num != 0)
				{
				}
				num = (short)315097088;
				if (num != 0)
				{
				}
				num = (short)1908015104;
				short num3 = num;
				this.bitID = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000022E8 File Offset: 0x000004E8
		// (set) Token: 0x06000009 RID: 9 RVA: 0x0000239C File Offset: 0x0000059C
		[global::System.Xml.Serialization.XmlAttribute]
		public string Name
		{
			get
			{
				short num = (short)1226888201;
				short num2 = num;
				num = (short)558027785;
				switch (num2 == num)
				{
				}
				num = (short)405274624;
				if (num != 0)
				{
				}
				num = (short)564985857;
				if (num != 0)
				{
				}
				num = (short)1130037248;
				short num3 = num;
				return this.name;
			}
			set
			{
				short num = (short)1431437313;
				if (num != 0)
				{
				}
				num = (short)1766837179;
				short num2 = num;
				num = (short)732810171;
				switch (num2 == num)
				{
				}
				num = (short)1372127232;
				if (num != 0)
				{
				}
				num = (short)581632000;
				short num3 = num;
				this.name = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x0000244C File Offset: 0x0000064C
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000024FC File Offset: 0x000006FC
		[global::System.Xml.Serialization.XmlAttribute]
		public string UIName
		{
			get
			{
				short num = (short)2143379228;
				short num2 = num;
				num = (short)855727900;
				switch (num2 == num)
				{
				}
				num = (short)713687041;
				if (num != 0)
				{
				}
				num = (short)1531838464;
				if (num != 0)
				{
				}
				num = (short)1882652672;
				short num3 = num;
				return this.uiName;
			}
			set
			{
				short num = (short)1027572305;
				short num2 = num;
				num = (short)307528273;
				switch (num2 == num)
				{
				}
				num = (short)1887240193;
				if (num != 0)
				{
				}
				num = (short)1537474560;
				if (num != 0)
				{
				}
				num = (short)340983808;
				short num3 = num;
				this.uiName = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000025B0 File Offset: 0x000007B0
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002660 File Offset: 0x00000860
		[global::System.Xml.Serialization.XmlAttribute]
		public global::AcpASKLib.AccessElementIDType ElemID
		{
			get
			{
				short num = (short)178628030;
				short num2 = num;
				num = (short)1262527934;
				switch (num2 == num)
				{
				}
				num = (short)1023672321;
				if (num != 0)
				{
				}
				num = (short)1246298112;
				if (num != 0)
				{
				}
				num = (short)45678592;
				short num3 = num;
				return this.elementID;
			}
			set
			{
				short num = (short)1577258477;
				short num2 = num;
				num = (short)391122413;
				switch (num2 == num)
				{
				}
				num = (short)1596260353;
				if (num != 0)
				{
				}
				num = (short)1812987904;
				if (num != 0)
				{
				}
				num = (short)1750728704;
				short num3 = num;
				this.elementID = value;
			}
		}

		// Token: 0x04000003 RID: 3
		private string name;

		// Token: 0x04000004 RID: 4
		private string uiName;

		// Token: 0x04000005 RID: 5
		private int bitID;

		// Token: 0x04000006 RID: 6
		private global::AcpASKLib.AccessElementIDType elementID;
	}
}
