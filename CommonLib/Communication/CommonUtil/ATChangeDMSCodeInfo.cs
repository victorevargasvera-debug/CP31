using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000097 RID: 151
	[global::System.Serializable]
	public class ATChangeDMSCodeInfo : global::System.ICloneable
	{
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060003DB RID: 987 RVA: 0x0003FCA4 File Offset: 0x0003DEA4
		// (set) Token: 0x060003DC RID: 988 RVA: 0x0003FD58 File Offset: 0x0003DF58
		public string AccessCode
		{
			get
			{
				short num = (short)2097973252;
				short num2 = num;
				num = (short)1896712196;
				switch (num2 == num)
				{
				}
				num = (short)620167169;
				if (num != 0)
				{
				}
				num = (short)1276510208;
				if (num != 0)
				{
				}
				num = (short)2111111168;
				short num3 = num;
				return this._accessCode;
			}
			set
			{
				short num = (short)1360645511;
				short num2 = num;
				num = (short)343330183;
				switch (num2 == num)
				{
				}
				num = (short)674430977;
				if (num != 0)
				{
				}
				num = (short)1505492992;
				if (num != 0)
				{
				}
				num = (short)1997078528;
				short num3 = num;
				this._accessCode = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060003DD RID: 989 RVA: 0x0003FE08 File Offset: 0x0003E008
		// (set) Token: 0x060003DE RID: 990 RVA: 0x0003FEB8 File Offset: 0x0003E0B8
		public string DefaultAccessCode
		{
			get
			{
				short num = (short)32416996;
				short num2 = num;
				num = (short)1588765924;
				switch (num2 == num)
				{
				}
				num = (short)1577058304;
				if (num != 0)
				{
				}
				num = (short)980942849;
				if (num != 0)
				{
				}
				num = (short)687931392;
				short num3 = num;
				return this._defaultAccessCode;
			}
			set
			{
				short num = (short)1331248106;
				short num2 = num;
				num = (short)77544426;
				switch (num2 == num)
				{
				}
				num = (short)31916033;
				if (num != 0)
				{
				}
				num = (short)360448000;
				if (num != 0)
				{
				}
				num = (short)405733376;
				short num3 = num;
				this._defaultAccessCode = value;
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0003FF6C File Offset: 0x0003E16C
		public object Clone()
		{
			short num = (short)1623832813;
			short num2 = num;
			num = (short)438155501;
			switch (num2 == num)
			{
			}
			num = (short)1139081217;
			if (num != 0)
			{
			}
			num = (short)1914372096;
			if (num != 0)
			{
			}
			num = (short)1033240576;
			short num3 = num;
			global::Motorola.Common.Communication.CommonUtil.ATChangeDMSCodeInfo atchangeDMSCodeInfo = base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.ATChangeDMSCodeInfo;
			atchangeDMSCodeInfo.AccessCode = this.AccessCode;
			atchangeDMSCodeInfo.DefaultAccessCode = this.DefaultAccessCode;
			return atchangeDMSCodeInfo;
		}

		// Token: 0x040004A4 RID: 1188
		private string _accessCode = string.Empty;

		// Token: 0x040004A5 RID: 1189
		private string _defaultAccessCode = string.Empty;
	}
}
