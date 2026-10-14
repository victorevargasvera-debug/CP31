using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000095 RID: 149
	[global::System.Serializable]
	public class ATEmergencyStatus : global::System.ICloneable
	{
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003CF RID: 975 RVA: 0x0003F430 File Offset: 0x0003D630
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x0003F4E0 File Offset: 0x0003D6E0
		public bool InEmergency
		{
			get
			{
				short num = (short)1500248733;
				short num2 = num;
				num = (short)472119965;
				switch (num2 == num)
				{
				}
				num = (short)364904448;
				short num3 = num;
				num = (short)1266417665;
				if (num != 0)
				{
				}
				num = (short)2091712512;
				if (num != 0)
				{
				}
				return this._bInEmergency;
			}
			set
			{
				short num = (short)747233581;
				short num2 = num;
				num = (short)1334698285;
				switch (num2 == num)
				{
				}
				num = (short)1209991168;
				short num3 = num;
				num = (short)432668673;
				if (num != 0)
				{
				}
				num = (short)161808384;
				if (num != 0)
				{
				}
				this._bInEmergency = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x0003F590 File Offset: 0x0003D790
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x0003F644 File Offset: 0x0003D844
		public global::Motorola.Common.Communication.CommonUtil.CommRC OperationResult
		{
			get
			{
				short num = (short)1716494368;
				short num2 = num;
				num = (short)1876205600;
				switch (num2 == num)
				{
				}
				num = (short)810090496;
				short num3 = num;
				num = (short)1019674625;
				if (num != 0)
				{
				}
				num = (short)438239232;
				if (num != 0)
				{
				}
				return this._opResult;
			}
			set
			{
				short num = (short)441719212;
				short num2 = num;
				num = (short)530586028;
				switch (num2 == num)
				{
				}
				num = (short)1794310144;
				short num3 = num;
				num = (short)360382465;
				if (num != 0)
				{
				}
				num = (short)17498112;
				if (num != 0)
				{
				}
				this._opResult = value;
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0003F6F4 File Offset: 0x0003D8F4
		public object Clone()
		{
			short num = (short)2064874536;
			short num2 = num;
			num = (short)408845352;
			switch (num2 == num)
			{
			}
			num = (short)1548943360;
			short num3 = num;
			num = (short)246415360;
			if (num != 0)
			{
			}
			num = (short)2108424193;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.ATEmergencyStatus atemergencyStatus = base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.ATEmergencyStatus;
			atemergencyStatus.InEmergency = this.InEmergency;
			atemergencyStatus.OperationResult = this.OperationResult;
			return atemergencyStatus;
		}

		// Token: 0x040004A0 RID: 1184
		private bool _bInEmergency;

		// Token: 0x040004A1 RID: 1185
		private global::Motorola.Common.Communication.CommonUtil.CommRC _opResult;
	}
}
