using System;
using System.Xml.Serialization;
using AcpASKLib;

namespace SpecialFeatures.Security
{
	// Token: 0x02000049 RID: 73
	[global::System.Xml.Serialization.XmlType("FieldMap")]
	[global::System.Serializable]
	public class FieldMapInfo
	{
		// Token: 0x060007C4 RID: 1988 RVA: 0x0000286D File Offset: 0x00000A6D
		public FieldMapInfo()
		{
			this.cpsFldName = null;
			this.askID = global::AcpASKLib.AccessElementIDType.UNDEFINED;
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00002883 File Offset: 0x00000A83
		public FieldMapInfo(string strFldName, global::AcpASKLib.AccessElementIDType id)
		{
			this.cpsFldName = strFldName;
			this.askID = id;
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x0007A3F0 File Offset: 0x000785F0
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x0007A4A0 File Offset: 0x000786A0
		[global::System.Xml.Serialization.XmlAttribute]
		public string CPSFieldName
		{
			get
			{
				short num = (short)1162586410;
				short num2 = num;
				num = (short)1655154986;
				switch (num2 == num)
				{
				}
				num = (short)112787457;
				if (num != 0)
				{
				}
				num = (short)360120320;
				short num3 = num;
				num = (short)1826095104;
				if (num != 0)
				{
				}
				return this.cpsFldName;
			}
			set
			{
				short num = (short)252436492;
				short num2 = num;
				num = (short)1945034764;
				switch (num2 == num)
				{
				}
				num = (short)1350762497;
				if (num != 0)
				{
				}
				num = (short)550043648;
				short num3 = num;
				num = (short)860684288;
				if (num != 0)
				{
				}
				this.cpsFldName = value;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x0007A550 File Offset: 0x00078750
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x0007A604 File Offset: 0x00078804
		[global::System.Xml.Serialization.XmlAttribute]
		public global::AcpASKLib.AccessElementIDType ID
		{
			get
			{
				short num = (short)71865540;
				short num2 = num;
				num = (short)1949406404;
				switch (num2 == num)
				{
				}
				num = (short)287965185;
				if (num != 0)
				{
				}
				num = (short)273547264;
				short num3 = num;
				num = (short)43843584;
				if (num != 0)
				{
				}
				return this.askID;
			}
			set
			{
				short num = (short)1710973662;
				short num2 = num;
				num = (short)716268254;
				switch (num2 == num)
				{
				}
				num = (short)1645281281;
				if (num != 0)
				{
				}
				num = (short)1012793344;
				short num3 = num;
				num = (short)1128988672;
				if (num != 0)
				{
				}
				this.askID = value;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x0007A6B4 File Offset: 0x000788B4
		// (set) Token: 0x060007CB RID: 1995 RVA: 0x0007A764 File Offset: 0x00078964
		[global::System.Xml.Serialization.XmlIgnore]
		public global::SpecialFeatures.Security.Feature ParentFeature
		{
			get
			{
				short num = (short)1065556865;
				short num2 = num;
				num = (short)1382620033;
				switch (num2 == num)
				{
				}
				num = (short)1867644928;
				if (num != 0)
				{
				}
				num = (short)61145088;
				short num3 = num;
				num = (short)1035206657;
				if (num != 0)
				{
				}
				return this.parentFeature;
			}
			set
			{
				short num = (short)1823539200;
				short num2 = num;
				num = (short)1412792150;
				short num3 = num;
				num = (short)1612414806;
				switch (num3 == num)
				{
				}
				num = (short)1334444033;
				if (num != 0)
				{
				}
				num = (short)1749483520;
				if (num != 0)
				{
				}
				this.parentFeature = value;
			}
		}

		// Token: 0x040002FC RID: 764
		private string cpsFldName;

		// Token: 0x040002FD RID: 765
		private global::AcpASKLib.AccessElementIDType askID;

		// Token: 0x040002FE RID: 766
		private global::SpecialFeatures.Security.Feature parentFeature;
	}
}
