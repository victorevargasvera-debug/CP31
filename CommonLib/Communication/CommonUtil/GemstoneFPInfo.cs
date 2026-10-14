using System;
using System.Collections.Generic;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000091 RID: 145
	[global::System.Serializable]
	public class GemstoneFPInfo
	{
		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x0003E4E4 File Offset: 0x0003C6E4
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x0003E594 File Offset: 0x0003C794
		public global::System.Collections.Generic.List<uint> EmptySlots
		{
			get
			{
				short num = (short)2126986886;
				short num2 = num;
				num = (short)693649030;
				switch (num2 == num)
				{
				}
				num = (short)598605824;
				short num3 = num;
				num = (short)190119937;
				if (num != 0)
				{
				}
				num = (short)132448256;
				if (num != 0)
				{
				}
				return this._emptySlots;
			}
			set
			{
				short num = (short)279282833;
				short num2 = num;
				num = (short)298288273;
				switch (num2 == num)
				{
				}
				num = (short)1578762240;
				short num3 = num;
				num = (short)109182976;
				if (num != 0)
				{
				}
				num = (short)761397249;
				if (num != 0)
				{
				}
				this._emptySlots = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x0003E644 File Offset: 0x0003C844
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x0003E6F4 File Offset: 0x0003C8F4
		public global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> RadioInfo
		{
			get
			{
				short num = (short)791378027;
				short num2 = num;
				num = (short)161904747;
				switch (num2 == num)
				{
				}
				num = (short)1600782336;
				short num3 = num;
				num = (short)1274019841;
				if (num != 0)
				{
				}
				num = (short)725614592;
				if (num != 0)
				{
				}
				return this._radioInfo;
			}
			set
			{
				short num = (short)2081209212;
				short num2 = num;
				num = (short)750369660;
				switch (num2 == num)
				{
				}
				num = (short)1526923264;
				short num3 = num;
				num = (short)1622081536;
				if (num != 0)
				{
				}
				num = (short)1389756417;
				if (num != 0)
				{
				}
				this._radioInfo = value;
			}
		}

		// Token: 0x04000497 RID: 1175
		private global::System.Collections.Generic.List<uint> _emptySlots;

		// Token: 0x04000498 RID: 1176
		private global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> _radioInfo;
	}
}
