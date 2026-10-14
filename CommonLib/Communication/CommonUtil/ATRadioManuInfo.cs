using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000096 RID: 150
	[global::System.Serializable]
	public class ATRadioManuInfo : global::System.ICloneable
	{
		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x0003F7D4 File Offset: 0x0003D9D4
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x0003F880 File Offset: 0x0003DA80
		public global::Motorola.Common.Communication.CommonUtil.RadioManuInfo RadioATInfo
		{
			get
			{
				short num = (short)1512130660;
				short num2 = num;
				num = (short)684869732;
				switch (num2 == num)
				{
				}
				num = (short)2096168960;
				short num3 = num;
				num = (short)1660813312;
				if (num != 0)
				{
				}
				num = (short)1619197953;
				if (num != 0)
				{
				}
				return this._info;
			}
			set
			{
				short num = (short)1077631277;
				short num2 = num;
				num = (short)2005555501;
				switch (num2 == num)
				{
				}
				num = (short)38731776;
				short num3 = num;
				num = (short)217972736;
				if (num != 0)
				{
				}
				num = (short)274989057;
				if (num != 0)
				{
				}
				this._info = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x0003F930 File Offset: 0x0003DB30
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x0003F9DC File Offset: 0x0003DBDC
		public global::Motorola.Common.Communication.CommonUtil.CommRC OperationResult
		{
			get
			{
				short num = (short)1966430402;
				short num2 = num;
				num = (short)2041469122;
				switch (num2 == num)
				{
				}
				num = (short)1983709184;
				short num3 = num;
				num = (short)1070137344;
				if (num != 0)
				{
				}
				num = (short)1927938049;
				if (num != 0)
				{
				}
				return this._opResult;
			}
			set
			{
				short num = (short)1616686836;
				short num2 = num;
				num = (short)799649524;
				switch (num2 == num)
				{
				}
				num = (short)1802829824;
				short num3 = num;
				num = (short)1120337921;
				if (num != 0)
				{
				}
				num = (short)828375040;
				if (num != 0)
				{
				}
				this._opResult = value;
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0003FA8C File Offset: 0x0003DC8C
		public object Clone()
		{
			short num = (short)277469315;
			short num2 = num;
			num = (short)623892611;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_E5:
				num = (short)235143169;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)226426880;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				break;
			}
			global::Motorola.Common.Communication.CommonUtil.ATRadioManuInfo atradioManuInfo;
			for (;;)
			{
				IL_54:
				switch (num3)
				{
				case 0:
					goto IL_1E8;
				case 1:
					atradioManuInfo.RadioATInfo = new global::Motorola.Common.Communication.CommonUtil.RadioManuInfo();
					atradioManuInfo.RadioATInfo.chVer = this.RadioATInfo.chVer;
					atradioManuInfo.RadioATInfo.cpuID = this.RadioATInfo.cpuID;
					atradioManuInfo.RadioATInfo.GSSI = this.RadioATInfo.GSSI;
					atradioManuInfo.RadioATInfo.ISSI = this.RadioATInfo.ISSI;
					atradioManuInfo.RadioATInfo.Manufacturer = this.RadioATInfo.Manufacturer;
					atradioManuInfo.RadioATInfo.ModelType = this.RadioATInfo.ModelType;
					atradioManuInfo.RadioATInfo.OPTA = this.RadioATInfo.OPTA;
					atradioManuInfo.RadioATInfo.swVer = this.RadioATInfo.swVer;
					atradioManuInfo.RadioATInfo.TEI = this.RadioATInfo.TEI;
					num = (short)303169536;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_87;
				}
				goto IL_66;
			}
			IL_87:
			num = (short)628228096;
			short num4 = num;
			num = (short)1770127361;
			if (num != 0)
			{
			}
			if (this.RadioATInfo != null)
			{
				goto IL_E5;
			}
			IL_1E8:
			atradioManuInfo.OperationResult = this.OperationResult;
			return atradioManuInfo;
			IL_66:
			atradioManuInfo = (base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.ATRadioManuInfo);
			num = (short)1061224450;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_54;
		}

		// Token: 0x040004A2 RID: 1186
		private global::Motorola.Common.Communication.CommonUtil.RadioManuInfo _info;

		// Token: 0x040004A3 RID: 1187
		private global::Motorola.Common.Communication.CommonUtil.CommRC _opResult;
	}
}
