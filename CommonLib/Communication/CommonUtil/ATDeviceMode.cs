using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000094 RID: 148
	[global::System.Serializable]
	public class ATDeviceMode : global::System.ICloneable
	{
		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x0003F084 File Offset: 0x0003D284
		// (set) Token: 0x060003CA RID: 970 RVA: 0x0003F134 File Offset: 0x0003D334
		public global::Motorola.Common.Communication.CommonUtil.DeviceMode DevMode
		{
			get
			{
				short num = (short)274819036;
				short num2 = num;
				num = (short)416049116;
				switch (num2 == num)
				{
				}
				num = (short)384434176;
				short num3 = num;
				num = (short)1569062913;
				if (num != 0)
				{
				}
				num = (short)1144717312;
				if (num != 0)
				{
				}
				return this._devMode;
			}
			set
			{
				short num = (short)1628079194;
				short num2 = num;
				num = (short)273908826;
				switch (num2 == num)
				{
				}
				num = (short)1503199232;
				short num3 = num;
				num = (short)1546125313;
				if (num != 0)
				{
				}
				num = (short)1266286592;
				if (num != 0)
				{
				}
				this._devMode = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060003CB RID: 971 RVA: 0x0003F1E8 File Offset: 0x0003D3E8
		// (set) Token: 0x060003CC RID: 972 RVA: 0x0003F298 File Offset: 0x0003D498
		public global::Motorola.Common.Communication.CommonUtil.CommRC OperationResult
		{
			get
			{
				short num = (short)519716107;
				short num2 = num;
				num = (short)1344945419;
				switch (num2 == num)
				{
				}
				num = (short)1299382272;
				short num3 = num;
				num = (short)1178927104;
				if (num != 0)
				{
				}
				num = (short)1048182785;
				if (num != 0)
				{
				}
				return this._opResult;
			}
			set
			{
				short num = (short)2019796409;
				short num2 = num;
				num = (short)506897849;
				switch (num2 == num)
				{
				}
				num = (short)1272250368;
				short num3 = num;
				num = (short)253493249;
				if (num != 0)
				{
				}
				num = (short)1073086464;
				if (num != 0)
				{
				}
				this._opResult = value;
			}
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0003F348 File Offset: 0x0003D548
		public object Clone()
		{
			short num = (short)400937958;
			short num2 = num;
			num = (short)1453052902;
			switch (num2 == num)
			{
			}
			num = (short)1138753536;
			short num3 = num;
			num = (short)54657025;
			if (num != 0)
			{
			}
			num = (short)684851200;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.ATDeviceMode atdeviceMode = base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.ATDeviceMode;
			atdeviceMode.DevMode = this.DevMode;
			atdeviceMode.OperationResult = this.OperationResult;
			return atdeviceMode;
		}

		// Token: 0x0400049E RID: 1182
		private global::Motorola.Common.Communication.CommonUtil.DeviceMode _devMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;

		// Token: 0x0400049F RID: 1183
		private global::Motorola.Common.Communication.CommonUtil.CommRC _opResult;
	}
}
