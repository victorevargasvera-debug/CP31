using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles
{
	// Token: 0x02000481 RID: 1153
	[global::System.Serializable]
	public class TrunkingEmergencyToneTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060097EA RID: 38890 RVA: 0x008E9D60 File Offset: 0x008E7F60
		public TrunkingEmergencyToneTableInnerRecset() : base(global::CommonResources.AcgResources.ID_EMERGENCYTONETABLE, global::CommonResources.AcgResources.ID_TONE)
		{
			this.SetValues();
		}

		// Token: 0x060097EB RID: 38891 RVA: 0x008E9D84 File Offset: 0x008E7F84
		public TrunkingEmergencyToneTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004C4A RID: 19530
		// (get) Token: 0x060097EC RID: 38892 RVA: 0x008E9DB0 File Offset: 0x008E7FB0
		public override int MaxPool
		{
			get
			{
				short num = (short)2068120142;
				short num2 = num;
				num = (short)378929742;
				switch (num2 == num)
				{
				}
				num = (short)185401345;
				if (num != 0)
				{
				}
				num = (short)1030619136;
				short num3 = num;
				num = (short)575995904;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004C4B RID: 19531
		// (get) Token: 0x060097ED RID: 38893 RVA: 0x008E9E5C File Offset: 0x008E805C
		// (set) Token: 0x060097EE RID: 38894 RVA: 0x008E9F1C File Offset: 0x008E811C
		public override int Max
		{
			get
			{
				short num;
				while (this._DynMax != -1)
				{
					num = (short)1706929275;
					short num2 = num;
					num = (short)1302506619;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1450639360;
						short num3 = num;
						num = (short)764346368;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
					}
				}
				num = (short)2068840449;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInnerRecset._Max;
			}
			set
			{
				short num = (short)214433793;
				if (num != 0)
				{
				}
				num = (short)823814106;
				short num2 = num;
				num = (short)1863149530;
				switch (num2 == num)
				{
				}
				num = (short)1691156480;
				short num3 = num;
				num = (short)1798242304;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004C4C RID: 19532
		// (get) Token: 0x060097EF RID: 38895 RVA: 0x008E9FD0 File Offset: 0x008E81D0
		public override int Min
		{
			get
			{
				short num = (short)827479756;
				short num2 = num;
				num = (short)1051088588;
				switch (num2 == num)
				{
				}
				num = (short)1131216897;
				if (num != 0)
				{
				}
				num = (short)639303680;
				short num3 = num;
				num = (short)1578237952;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInnerRecset._Min;
			}
		}

		// Token: 0x17004C4D RID: 19533
		// (get) Token: 0x060097F0 RID: 38896 RVA: 0x008EA080 File Offset: 0x008E8280
		// (set) Token: 0x060097F1 RID: 38897 RVA: 0x008EA12C File Offset: 0x008E832C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1452212225;
				if (num != 0)
				{
				}
				num = (short)775012718;
				short num2 = num;
				num = (short)976142702;
				switch (num2 == num)
				{
				}
				num = (short)309264384;
				short num3 = num;
				num = (short)1917976576;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1807351809;
				if (num != 0)
				{
				}
				num = (short)173694713;
				short num2 = num;
				num = (short)468868857;
				switch (num2 == num)
				{
				}
				num = (short)1884553216;
				short num3 = num;
				num = (short)339542016;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17004C4E RID: 19534
		// (get) Token: 0x060097F2 RID: 38898 RVA: 0x008EA1D8 File Offset: 0x008E83D8
		public bool HasDiffs
		{
			get
			{
				short num = (short)95792189;
				short num2 = num;
				num = (short)1534241853;
				switch (num2 == num)
				{
				}
				num = (short)128385024;
				if (num != 0)
				{
				}
				num = (short)219873280;
				short num3 = num;
				num = (short)2044657665;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060097F3 RID: 38899 RVA: 0x008EA288 File Offset: 0x008E8488
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1055633805;
			short num2 = num;
			num = (short)76591501;
			switch (num2 == num)
			{
			}
			num = (short)855375873;
			if (num != 0)
			{
			}
			num = (short)1173684224;
			short num3 = num;
			num = (short)315424768;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInner(this);
		}

		// Token: 0x060097F4 RID: 38900 RVA: 0x008EA334 File Offset: 0x008E8534
		internal void SetValues()
		{
			short num = (short)1490878465;
			if (num != 0)
			{
			}
			num = (short)875942606;
			short num2 = num;
			num = (short)1109185230;
			switch (num2 == num)
			{
			}
			num = (short)692912128;
			short num3 = num;
			num = (short)766312448;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_EMERGENCYTONETABLE;
			base.KeySeed = global::CommonResources.AcgResources.ID_TONE;
			base.DataTransferOrder = 30;
		}

		// Token: 0x060097F5 RID: 38901 RVA: 0x008EA40C File Offset: 0x008E860C
		// Note: this type is marked as 'beforefieldinit'.
		static TrunkingEmergencyToneTableInnerRecset()
		{
			short num = (short)24370563;
			short num2 = num;
			num = (short)957013379;
			switch (num2 == num)
			{
			}
			num = (short)659488769;
			if (num != 0)
			{
			}
			num = (short)304414720;
			short num3 = num;
			num = (short)1446445056;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInnerRecset._Min = 1;
		}

		// Token: 0x04004B0F RID: 19215
		public static int _MaxPool;

		// Token: 0x04004B10 RID: 19216
		public static int _Max;

		// Token: 0x04004B11 RID: 19217
		public int _DynMax;

		// Token: 0x04004B12 RID: 19218
		public static int _Min;

		// Token: 0x04004B13 RID: 19219
		public static int _DefaultRecordCount;
	}
}
