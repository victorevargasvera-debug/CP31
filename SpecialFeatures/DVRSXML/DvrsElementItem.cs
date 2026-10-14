using System;
using System.Collections.Generic;

namespace SpecialFeatures.DVRSXML
{
	// Token: 0x02000120 RID: 288
	public class DvrsElementItem
	{
		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x00153800 File Offset: 0x00151A00
		internal string ElementName
		{
			get
			{
				short num = (short)1154155965;
				short num2 = num;
				num = (short)882836925;
				switch (num2 == num)
				{
				}
				num = (short)1138163712;
				if (num != 0)
				{
				}
				num = (short)1714552833;
				if (num != 0)
				{
				}
				num = (short)1766719488;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x001538B0 File Offset: 0x00151AB0
		internal string AttrValue
		{
			get
			{
				short num = (short)1241735798;
				short num2 = num;
				num = (short)1720279670;
				switch (num2 == num)
				{
				}
				num = (short)557776897;
				if (num != 0)
				{
				}
				num = (short)1960574976;
				if (num != 0)
				{
				}
				num = (short)346554368;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x00153960 File Offset: 0x00151B60
		internal string ElementValue
		{
			get
			{
				short num = (short)1717312542;
				short num2 = num;
				num = (short)884743198;
				switch (num2 == num)
				{
				}
				num = (short)1034485761;
				if (num != 0)
				{
				}
				num = (short)1261240320;
				if (num != 0)
				{
				}
				num = (short)1018691584;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000F5D RID: 3933 RVA: 0x00153A10 File Offset: 0x00151C10
		internal global::System.Collections.Generic.List<global::SpecialFeatures.DVRSXML.DvrsElementItem> ChildList
		{
			get
			{
				short num = (short)1259321388;
				short num2 = num;
				num = (short)1219606572;
				switch (num2 == num)
				{
				}
				num = (short)1367867393;
				if (num != 0)
				{
				}
				num = (short)1080492032;
				if (num != 0)
				{
				}
				num = (short)557121536;
				short num3 = num;
				return this.d;
			}
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00003474 File Offset: 0x00001674
		internal DvrsElementItem(string elementName, string attrValue = null, string elementValue = null)
		{
			this.a = elementName;
			this.b = attrValue;
			this.c = elementValue;
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x00153AC0 File Offset: 0x00151CC0
		internal void Add(global::SpecialFeatures.DVRSXML.DvrsElementItem item)
		{
			short num = (short)1455030273;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1754071040;
					short num3 = num;
					this.d = new global::System.Collections.Generic.List<global::SpecialFeatures.DVRSXML.DvrsElementItem>();
					num = (short)1869545474;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					goto IL_9B;
				}
				IL_30:
				if (this.d == null)
				{
					num = (short)940769280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9B:
				num = (short)1989093010;
				short num4 = num;
				num = (short)1996301970;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_D1;
				}
			}
			IL_D1:
			num = (short)931463169;
			if (num != 0)
			{
			}
			num = (short)1314062336;
			if (num != 0)
			{
			}
			this.d.Add(item);
		}

		// Token: 0x04000805 RID: 2053
		private string a;

		// Token: 0x04000806 RID: 2054
		private string b;

		// Token: 0x04000807 RID: 2055
		private string c;

		// Token: 0x04000808 RID: 2056
		private global::System.Collections.Generic.List<global::SpecialFeatures.DVRSXML.DvrsElementItem> d;
	}
}
