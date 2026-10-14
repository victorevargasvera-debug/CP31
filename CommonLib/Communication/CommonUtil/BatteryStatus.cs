using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000092 RID: 146
	[global::System.Serializable]
	public class BatteryStatus : global::System.ICloneable
	{
		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060003BB RID: 955 RVA: 0x0003E7B8 File Offset: 0x0003C9B8
		// (set) Token: 0x060003BC RID: 956 RVA: 0x0003E868 File Offset: 0x0003CA68
		public int BCS
		{
			get
			{
				short num = (short)162876800;
				short num2 = num;
				num = (short)279858560;
				switch (num2 == num)
				{
				}
				num = (short)910819328;
				short num3 = num;
				num = (short)881328129;
				if (num != 0)
				{
				}
				num = (short)2104426496;
				if (num != 0)
				{
				}
				return this._bcs;
			}
			set
			{
				short num = (short)170819784;
				short num2 = num;
				num = (short)80904392;
				switch (num2 == num)
				{
				}
				num = (short)263061504;
				short num3 = num;
				num = (short)575209473;
				if (num != 0)
				{
				}
				num = (short)1918369792;
				if (num != 0)
				{
				}
				this._bcs = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0003E918 File Offset: 0x0003CB18
		// (set) Token: 0x060003BE RID: 958 RVA: 0x0003E9C8 File Offset: 0x0003CBC8
		public int BCL
		{
			get
			{
				short num = (short)575340545;
				if (num != 0)
				{
				}
				num = (short)1157513361;
				short num2 = num;
				num = (short)1075855505;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1846083584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1891500032;
				if (num != 0)
				{
				}
				return this._bcl;
			}
			set
			{
				short num = (short)1414173636;
				short num2 = num;
				num = (short)117347268;
				switch (num2 == num)
				{
				}
				num = (short)563150848;
				short num3 = num;
				num = (short)798162945;
				if (num != 0)
				{
				}
				num = (short)556531712;
				if (num != 0)
				{
				}
				this._bcl = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0003EA7C File Offset: 0x0003CC7C
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x0003EB2C File Offset: 0x0003CD2C
		public global::Motorola.Common.Communication.CommonUtil.CommRC OperationResult
		{
			get
			{
				short num = (short)899246117;
				short num2 = num;
				num = (short)1221617701;
				switch (num2 == num)
				{
				}
				num = (short)501612544;
				short num3 = num;
				num = (short)697499649;
				if (num != 0)
				{
				}
				num = (short)619708416;
				if (num != 0)
				{
				}
				return this._opResult;
			}
			set
			{
				short num = (short)1828323329;
				if (num != 0)
				{
				}
				num = (short)99001853;
				short num2 = num;
				num = (short)13870589;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1191182336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)305266688;
				if (num != 0)
				{
				}
				this._opResult = value;
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0003EBE0 File Offset: 0x0003CDE0
		public object Clone()
		{
			short num = (short)228001267;
			short num2 = num;
			num = (short)2093745651;
			switch (num2 == num)
			{
			}
			num = (short)1720582144;
			short num3 = num;
			num = (short)1865809921;
			if (num != 0)
			{
			}
			num = (short)1501233152;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.BatteryStatus batteryStatus = base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.BatteryStatus;
			batteryStatus.BCS = this.BCS;
			batteryStatus.BCL = this.BCL;
			batteryStatus.OperationResult = this.OperationResult;
			return batteryStatus;
		}

		// Token: 0x04000499 RID: 1177
		private int _bcs;

		// Token: 0x0400049A RID: 1178
		private int _bcl;

		// Token: 0x0400049B RID: 1179
		private global::Motorola.Common.Communication.CommonUtil.CommRC _opResult;
	}
}
