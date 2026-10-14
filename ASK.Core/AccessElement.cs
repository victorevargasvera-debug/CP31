using System;
using System.Xml.Serialization;
using ASK.Interface;

namespace ASK.Core
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
			this.elementID = global::ASK.Interface.AccessElementIDType.UNDEFINED;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002154 File Offset: 0x00000354
		public AccessElement(string strName, string strUiName, int id, global::ASK.Interface.AccessElementIDType elemId)
		{
			this.name = strName;
			this.uiName = strUiName;
			this.bitID = id;
			this.elementID = elemId;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002184 File Offset: 0x00000384
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002234 File Offset: 0x00000434
		[global::System.Xml.Serialization.XmlAttribute]
		public int ID
		{
			get
			{
				short num = (short)1239379221;
				short num2 = num;
				num = (short)185888021;
				switch (num2 == num)
				{
				}
				num = (short)2030370816;
				if (num != 0)
				{
				}
				num = (short)959774721;
				if (num != 0)
				{
				}
				num = (short)2003435520;
				short num3 = num;
				return this.bitID;
			}
			set
			{
				short num = (short)1564213249;
				if (num != 0)
				{
				}
				num = (short)1634282594;
				short num2 = num;
				num = (short)1858677858;
				switch (num2 == num)
				{
				}
				num = (short)1165033472;
				if (num != 0)
				{
				}
				num = (short)287899648;
				short num3 = num;
				this.bitID = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000022E4 File Offset: 0x000004E4
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002394 File Offset: 0x00000594
		[global::System.Xml.Serialization.XmlAttribute]
		public string Name
		{
			get
			{
				short num = (short)1453624159;
				short num2 = num;
				num = (short)1628998495;
				switch (num2 == num)
				{
				}
				num = (short)137297921;
				if (num != 0)
				{
				}
				num = (short)104202240;
				if (num != 0)
				{
				}
				num = (short)1183711232;
				short num3 = num;
				return this.name;
			}
			set
			{
				short num = (short)1598774788;
				short num2 = num;
				num = (short)613309956;
				switch (num2 == num)
				{
				}
				num = (short)318242817;
				if (num != 0)
				{
				}
				num = (short)961150976;
				if (num != 0)
				{
				}
				num = (short)1554448384;
				short num3 = num;
				this.name = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002444 File Offset: 0x00000644
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000024F4 File Offset: 0x000006F4
		[global::System.Xml.Serialization.XmlAttribute]
		public string UIName
		{
			get
			{
				short num = (short)361534469;
				short num2 = num;
				num = (short)1230148613;
				switch (num2 == num)
				{
				}
				num = (short)1816133633;
				if (num != 0)
				{
				}
				num = (short)94044160;
				if (num != 0)
				{
				}
				num = (short)196673536;
				short num3 = num;
				return this.uiName;
			}
			set
			{
				short num = (short)435510002;
				short num2 = num;
				num = (short)1921014514;
				switch (num2 == num)
				{
				}
				num = (short)1159069697;
				if (num != 0)
				{
				}
				num = (short)1227685888;
				if (num != 0)
				{
				}
				num = (short)577634304;
				short num3 = num;
				this.uiName = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000025A8 File Offset: 0x000007A8
		// (set) Token: 0x0600000D RID: 13 RVA: 0x0000265C File Offset: 0x0000085C
		[global::System.Xml.Serialization.XmlAttribute]
		public global::ASK.Interface.AccessElementIDType ElemID
		{
			get
			{
				short num = (short)1202847745;
				if (num != 0)
				{
				}
				num = (short)461821052;
				short num2 = num;
				num = (short)193254524;
				switch (num2 == num)
				{
				}
				num = (short)1157562368;
				if (num != 0)
				{
				}
				num = (short)1107558400;
				short num3 = num;
				return this.elementID;
			}
			set
			{
				short num = (short)829531973;
				short num2 = num;
				num = (short)1353361221;
				switch (num2 == num)
				{
				}
				num = (short)141099008;
				if (num != 0)
				{
				}
				num = (short)1920925697;
				if (num != 0)
				{
				}
				num = (short)2098790400;
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
		private global::ASK.Interface.AccessElementIDType elementID;
	}
}
