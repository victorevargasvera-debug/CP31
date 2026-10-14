using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioInformation
{
	// Token: 0x02000197 RID: 407
	[global::System.Serializable]
	public class ASKProgrammingHistoryInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060044C4 RID: 17604 RVA: 0x003FBD24 File Offset: 0x003F9F24
		public ASKProgrammingHistoryInnerRecset() : base(global::CommonResources.AcgResources.ID_PROGRAMMINGHISTORY)
		{
			this.SetValues();
		}

		// Token: 0x060044C5 RID: 17605 RVA: 0x003FBD44 File Offset: 0x003F9F44
		public ASKProgrammingHistoryInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x1700235A RID: 9050
		// (get) Token: 0x060044C6 RID: 17606 RVA: 0x003FBD70 File Offset: 0x003F9F70
		public override int MaxPool
		{
			get
			{
				short num = (short)1215494799;
				short num2 = num;
				num = (short)1267792527;
				switch (num2 == num)
				{
				}
				num = (short)161939456;
				if (num != 0)
				{
				}
				num = (short)1146421249;
				if (num != 0)
				{
				}
				num = (short)1872035840;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset._MaxPool;
			}
		}

		// Token: 0x1700235B RID: 9051
		// (get) Token: 0x060044C7 RID: 17607 RVA: 0x003FBE24 File Offset: 0x003FA024
		// (set) Token: 0x060044C8 RID: 17608 RVA: 0x003FBEE8 File Offset: 0x003FA0E8
		public override int Max
		{
			get
			{
				while (this._DynMax != -1)
				{
					short num = (short)1564737536;
					short num2 = num;
					num = (short)578813948;
					short num3 = num;
					num = (short)1118830588;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)215678977;
						if (num != 0)
						{
						}
						num = (short)1540685824;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset._Max;
			}
			set
			{
				short num = (short)609945430;
				short num2 = num;
				num = (short)1148389206;
				switch (num2 == num)
				{
				}
				num = (short)1852833792;
				if (num != 0)
				{
				}
				num = (short)64946177;
				if (num != 0)
				{
				}
				num = (short)494993408;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x1700235C RID: 9052
		// (get) Token: 0x060044C9 RID: 17609 RVA: 0x003FBF98 File Offset: 0x003FA198
		public override int Min
		{
			get
			{
				short num = (short)2076717586;
				short num2 = num;
				num = (short)2048799250;
				switch (num2 == num)
				{
				}
				num = (short)1010958336;
				if (num != 0)
				{
				}
				num = (short)795017217;
				if (num != 0)
				{
				}
				num = (short)2138636288;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset._Min;
			}
		}

		// Token: 0x1700235D RID: 9053
		// (get) Token: 0x060044CA RID: 17610 RVA: 0x003FC04C File Offset: 0x003FA24C
		// (set) Token: 0x060044CB RID: 17611 RVA: 0x003FC0FC File Offset: 0x003FA2FC
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)480327090;
				short num2 = num;
				num = (short)814495154;
				switch (num2 == num)
				{
				}
				num = (short)1892679681;
				if (num != 0)
				{
				}
				num = (short)406519808;
				if (num != 0)
				{
				}
				num = (short)1835532288;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)273920197;
				short num2 = num;
				num = (short)271823045;
				switch (num2 == num)
				{
				}
				num = (short)1743847424;
				if (num != 0)
				{
				}
				num = (short)1635516417;
				if (num != 0)
				{
				}
				num = (short)524419072;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700235E RID: 9054
		// (get) Token: 0x060044CC RID: 17612 RVA: 0x003FC1AC File Offset: 0x003FA3AC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1255888198;
				short num2 = num;
				num = (short)592598342;
				switch (num2 == num)
				{
				}
				num = (short)2060255232;
				if (num != 0)
				{
				}
				num = (short)918290433;
				if (num != 0)
				{
				}
				num = (short)67633152;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x060044CD RID: 17613 RVA: 0x003FC25C File Offset: 0x003FA45C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1023858953;
			short num2 = num;
			num = (short)1885460745;
			switch (num2 == num)
			{
			}
			num = (short)1045299201;
			if (num != 0)
			{
			}
			num = (short)1220870144;
			if (num != 0)
			{
			}
			num = (short)362807296;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInner(this);
		}

		// Token: 0x060044CE RID: 17614 RVA: 0x003FC310 File Offset: 0x003FA510
		internal void SetValues()
		{
			short num = (short)1752718231;
			short num2 = num;
			num = (short)360143767;
			switch (num2 == num)
			{
			}
			num = (short)437059585;
			if (num != 0)
			{
			}
			num = (short)1794703360;
			if (num != 0)
			{
			}
			num = (short)449445888;
			short num3 = num;
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_PROGRAMMINGHISTORY;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060044CF RID: 17615 RVA: 0x003FC3DC File Offset: 0x003FA5DC
		// Note: this type is marked as 'beforefieldinit'.
		static ASKProgrammingHistoryInnerRecset()
		{
			short num = (short)604488246;
			short num2 = num;
			num = (short)62505526;
			switch (num2 == num)
			{
			}
			num = (short)1642332160;
			if (num != 0)
			{
			}
			num = (short)1312686081;
			if (num != 0)
			{
			}
			num = (short)1057816576;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset._Min = 1;
		}

		// Token: 0x04001A3F RID: 6719
		public static int _MaxPool;

		// Token: 0x04001A40 RID: 6720
		public static int _Max;

		// Token: 0x04001A41 RID: 6721
		public int _DynMax;

		// Token: 0x04001A42 RID: 6722
		public static int _Min;

		// Token: 0x04001A43 RID: 6723
		public static int _DefaultRecordCount;
	}
}
