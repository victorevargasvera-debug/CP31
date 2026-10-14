using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000380 RID: 896
	[global::System.Serializable]
	public class RelayPatternBCOListListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06008421 RID: 33825 RVA: 0x007AC124 File Offset: 0x007AA324
		public RelayPatternBCOListListInnerRecset() : base(global::CommonResources.AcgResources.ID_RELAYPATTERNBCOLIST)
		{
			this.SetValues();
		}

		// Token: 0x06008422 RID: 33826 RVA: 0x007AC144 File Offset: 0x007AA344
		public RelayPatternBCOListListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004340 RID: 17216
		// (get) Token: 0x06008423 RID: 33827 RVA: 0x007AC170 File Offset: 0x007AA370
		public override int MaxPool
		{
			get
			{
				short num = (short)1310457857;
				if (num != 0)
				{
				}
				num = (short)502808271;
				short num2 = num;
				num = (short)643972815;
				switch (num2 == num)
				{
				}
				num = (short)253886464;
				if (num != 0)
				{
				}
				num = (short)1035272192;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004341 RID: 17217
		// (get) Token: 0x06008424 RID: 33828 RVA: 0x007AC220 File Offset: 0x007AA420
		// (set) Token: 0x06008425 RID: 33829 RVA: 0x007AC2E0 File Offset: 0x007AA4E0
		public override int Max
		{
			get
			{
				short num;
				for (;;)
				{
					num = (short)2143617024;
					short num2 = num;
					if (this._DynMax != -1)
					{
						goto IL_AB;
					}
					num = (short)152917840;
					short num3 = num;
					num = (short)1975539536;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6A;
					}
				}
				IL_6A:
				num = (short)134938625;
				if (num != 0)
				{
				}
				num = (short)84541440;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset._Max;
				IL_AB:
				return this._DynMax;
			}
			set
			{
				short num = (short)1026876568;
				short num2 = num;
				num = (short)1006036120;
				switch (num2 == num)
				{
				}
				num = (short)642056193;
				if (num != 0)
				{
				}
				num = (short)1739980800;
				if (num != 0)
				{
				}
				num = (short)2049572864;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x17004342 RID: 17218
		// (get) Token: 0x06008426 RID: 33830 RVA: 0x007AC390 File Offset: 0x007AA590
		public override int Min
		{
			get
			{
				short num = (short)465545445;
				short num2 = num;
				num = (short)1705027813;
				switch (num2 == num)
				{
				}
				num = (short)1058275328;
				if (num != 0)
				{
				}
				num = (short)1132331009;
				if (num != 0)
				{
				}
				num = (short)572325888;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset._Min;
			}
		}

		// Token: 0x17004343 RID: 17219
		// (get) Token: 0x06008427 RID: 33831 RVA: 0x007AC440 File Offset: 0x007AA640
		// (set) Token: 0x06008428 RID: 33832 RVA: 0x007AC4F0 File Offset: 0x007AA6F0
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)500071483;
				short num2 = num;
				num = (short)18316347;
				switch (num2 == num)
				{
				}
				num = (short)1240858625;
				if (num != 0)
				{
				}
				num = (short)411566080;
				if (num != 0)
				{
				}
				num = (short)483590144;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1623615874;
				short num2 = num;
				num = (short)1097820546;
				switch (num2 == num)
				{
				}
				num = (short)444465153;
				if (num != 0)
				{
				}
				num = (short)1699282944;
				if (num != 0)
				{
				}
				num = (short)247726080;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17004344 RID: 17220
		// (get) Token: 0x06008429 RID: 33833 RVA: 0x007AC5A0 File Offset: 0x007AA7A0
		public bool HasDiffs
		{
			get
			{
				short num = (short)666575524;
				short num2 = num;
				num = (short)2106401444;
				switch (num2 == num)
				{
				}
				num = (short)1425932288;
				if (num != 0)
				{
				}
				num = (short)1478230017;
				if (num != 0)
				{
				}
				num = (short)586416128;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x0600842A RID: 33834 RVA: 0x007AC650 File Offset: 0x007AA850
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1165796415;
			short num2 = num;
			num = (short)568960063;
			switch (num2 == num)
			{
			}
			num = (short)1546584065;
			if (num != 0)
			{
			}
			num = (short)533331968;
			if (num != 0)
			{
			}
			num = (short)665518080;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner(this);
		}

		// Token: 0x0600842B RID: 33835 RVA: 0x007AC700 File Offset: 0x007AA900
		internal void SetValues()
		{
			short num = (short)677368014;
			short num2 = num;
			num = (short)875352270;
			switch (num2 == num)
			{
			}
			num = (short)295436288;
			if (num != 0)
			{
			}
			num = (short)642777089;
			if (num != 0)
			{
			}
			num = (short)1727987712;
			short num3 = num;
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_RELAYPATTERNBCOLIST;
			base.DataTransferOrder = 50;
			this.b();
		}

		// Token: 0x0600842C RID: 33836 RVA: 0x007AC7D0 File Offset: 0x007AA9D0
		private void b()
		{
			short num = (short)1133124666;
			short num2 = num;
			num = (short)838474810;
			switch (num2 == num)
			{
			}
			num = (short)973864961;
			if (num != 0)
			{
			}
			num = (short)2140930048;
			if (num != 0)
			{
			}
			num = (short)1249116160;
			short num3 = num;
			this.a();
		}

		// Token: 0x0600842D RID: 33837 RVA: 0x007AC880 File Offset: 0x007AAA80
		private void a()
		{
			short num;
			for (;;)
			{
				num = (short)442368000;
				short num2 = num;
				if (global::AcpCommonLib.AppInfoManager.AppType != global::AcpCommonLib.ApplicationType.LABTOOL)
				{
					goto IL_86;
				}
				num = (short)548231962;
				short num3 = num;
				num = (short)327637786;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_69;
				}
			}
			IL_69:
			num = (short)1432289280;
			if (num != 0)
			{
			}
			base.HiddenStatic = false;
			return;
			IL_86:
			num = (short)423886849;
			if (num != 0)
			{
			}
			base.HiddenStatic = true;
		}

		// Token: 0x0600842E RID: 33838 RVA: 0x007AC944 File Offset: 0x007AAB44
		// Note: this type is marked as 'beforefieldinit'.
		static RelayPatternBCOListListInnerRecset()
		{
			short num = (short)2021059197;
			short num2 = num;
			num = (short)1651042941;
			switch (num2 == num)
			{
			}
			num = (short)1126629376;
			if (num != 0)
			{
			}
			num = (short)1978204161;
			if (num != 0)
			{
			}
			num = (short)1392640000;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset._Min = 1;
		}

		// Token: 0x04003E6B RID: 15979
		public static int _MaxPool;

		// Token: 0x04003E6C RID: 15980
		public static int _Max;

		// Token: 0x04003E6D RID: 15981
		public int _DynMax;

		// Token: 0x04003E6E RID: 15982
		public static int _Min;

		// Token: 0x04003E6F RID: 15983
		public static int _DefaultRecordCount;
	}
}
