using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000093 RID: 147
	[global::System.Serializable]
	public class CustomerATMsg : global::System.ICloneable
	{
		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x0003ECD0 File Offset: 0x0003CED0
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x0003ED80 File Offset: 0x0003CF80
		public string CustomerMsg
		{
			get
			{
				short num = (short)760637357;
				short num2 = num;
				num = (short)1615816621;
				switch (num2 == num)
				{
				}
				num = (short)1378549760;
				short num3 = num;
				num = (short)1809055744;
				if (num != 0)
				{
				}
				num = (short)979369985;
				if (num != 0)
				{
				}
				return this._customerMsg;
			}
			set
			{
				short num = (short)1331564114;
				short num2 = num;
				num = (short)864489042;
				switch (num2 == num)
				{
				}
				num = (short)1505558528;
				short num3 = num;
				num = (short)1795227649;
				if (num != 0)
				{
				}
				num = (short)1995898880;
				if (num != 0)
				{
				}
				this._customerMsg = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x0003EE34 File Offset: 0x0003D034
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x0003EEE4 File Offset: 0x0003D0E4
		public global::Motorola.Common.Communication.CommonUtil.CommRC OperationResult
		{
			get
			{
				short num = (short)1203625586;
				short num2 = num;
				num = (short)1335811698;
				switch (num2 == num)
				{
				}
				num = (short)723714048;
				short num3 = num;
				num = (short)579731456;
				if (num != 0)
				{
				}
				num = (short)578879489;
				if (num != 0)
				{
				}
				return this._opResult;
			}
			set
			{
				short num = (short)1893344782;
				short num2 = num;
				num = (short)640755214;
				switch (num2 == num)
				{
				}
				num = (short)1271922688;
				short num3 = num;
				num = (short)259325953;
				if (num != 0)
				{
				}
				num = (short)1448411136;
				if (num != 0)
				{
				}
				this._opResult = value;
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0003EF94 File Offset: 0x0003D194
		public object Clone()
		{
			short num = (short)1454373676;
			short num2 = num;
			num = (short)418839340;
			switch (num2 == num)
			{
			}
			num = (short)470286336;
			short num3 = num;
			num = (short)293928961;
			if (num != 0)
			{
			}
			num = (short)10747904;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.CustomerATMsg customerATMsg = base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.CustomerATMsg;
			customerATMsg.CustomerMsg = this.CustomerMsg;
			customerATMsg.OperationResult = this.OperationResult;
			return customerATMsg;
		}

		// Token: 0x0400049C RID: 1180
		private string _customerMsg = string.Empty;

		// Token: 0x0400049D RID: 1181
		private global::Motorola.Common.Communication.CommonUtil.CommRC _opResult;
	}
}
