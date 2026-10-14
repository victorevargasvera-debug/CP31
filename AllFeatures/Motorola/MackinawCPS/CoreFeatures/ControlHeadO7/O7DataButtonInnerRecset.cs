using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO7
{
	// Token: 0x0200039A RID: 922
	[global::System.Serializable]
	public class O7DataButtonInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060086CA RID: 34506 RVA: 0x007DB200 File Offset: 0x007D9400
		public O7DataButtonInnerRecset() : base(global::CommonResources.AcgResources.ID_DATABUTTON_1)
		{
			this.SetValues();
		}

		// Token: 0x060086CB RID: 34507 RVA: 0x007DB220 File Offset: 0x007D9420
		public O7DataButtonInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x1700448D RID: 17549
		// (get) Token: 0x060086CC RID: 34508 RVA: 0x007DB24C File Offset: 0x007D944C
		public override int MaxPool
		{
			get
			{
				short num = (short)1707962248;
				short num2 = num;
				num = (short)1234464648;
				switch (num2 == num)
				{
				}
				num = (short)158924801;
				if (num != 0)
				{
				}
				num = (short)968491008;
				if (num != 0)
				{
				}
				num = (short)691929088;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset._MaxPool;
			}
		}

		// Token: 0x1700448E RID: 17550
		// (get) Token: 0x060086CD RID: 34509 RVA: 0x007DB2FC File Offset: 0x007D94FC
		// (set) Token: 0x060086CE RID: 34510 RVA: 0x007DB3C0 File Offset: 0x007D95C0
		public override int Max
		{
			get
			{
				short num;
				for (;;)
				{
					num = (short)509018112;
					short num2 = num;
					if (this._DynMax == -1)
					{
						break;
					}
					num = (short)1219496298;
					short num3 = num;
					num = (short)2084505962;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_71;
					}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset._Max;
				IL_71:
				num = (short)444530688;
				if (num != 0)
				{
				}
				num = (short)1082261505;
				if (num != 0)
				{
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)415662763;
				short num2 = num;
				num = (short)1115325099;
				switch (num2 == num)
				{
				}
				num = (short)1406009344;
				if (num != 0)
				{
				}
				num = (short)1748041729;
				if (num != 0)
				{
				}
				num = (short)954990592;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x1700448F RID: 17551
		// (get) Token: 0x060086CF RID: 34511 RVA: 0x007DB478 File Offset: 0x007D9678
		public override int Min
		{
			get
			{
				short num = (short)1343787353;
				short num2 = num;
				num = (short)1255706969;
				switch (num2 == num)
				{
				}
				num = (short)1362558977;
				if (num != 0)
				{
				}
				num = (short)1667301376;
				if (num != 0)
				{
				}
				num = (short)1282801664;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset._Min;
			}
		}

		// Token: 0x17004490 RID: 17552
		// (get) Token: 0x060086D0 RID: 34512 RVA: 0x007DB524 File Offset: 0x007D9724
		// (set) Token: 0x060086D1 RID: 34513 RVA: 0x007DB5D0 File Offset: 0x007D97D0
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1331628439;
				short num2 = num;
				num = (short)2000554391;
				switch (num2 == num)
				{
				}
				num = (short)677380097;
				if (num != 0)
				{
				}
				num = (short)1738539008;
				if (num != 0)
				{
				}
				num = (short)1038876672;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1049952256;
				short num2 = num;
				num = (short)434513608;
				short num3 = num;
				num = (short)450307784;
				switch (num3 == num)
				{
				}
				num = (short)1715011584;
				if (num != 0)
				{
				}
				num = (short)1268711425;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17004491 RID: 17553
		// (get) Token: 0x060086D2 RID: 34514 RVA: 0x007DB680 File Offset: 0x007D9880
		public bool HasDiffs
		{
			get
			{
				short num = (short)417595392;
				short num2 = num;
				num = (short)480453558;
				short num3 = num;
				num = (short)2066097078;
				switch (num3 == num)
				{
				}
				num = (short)1535967233;
				if (num != 0)
				{
				}
				num = (short)1219166208;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060086D3 RID: 34515 RVA: 0x007DB730 File Offset: 0x007D9930
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1022230528;
			short num2 = num;
			num = (short)1703937;
			if (num != 0)
			{
			}
			num = (short)965469398;
			short num3 = num;
			num = (short)946726102;
			switch (num3 == num)
			{
			}
			num = (short)2118975488;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInner(this);
		}

		// Token: 0x060086D4 RID: 34516 RVA: 0x007DB7E4 File Offset: 0x007D99E4
		internal void SetValues()
		{
			short num = (short)1027342336;
			short num2 = num;
			num = (short)216474450;
			short num3 = num;
			num = (short)852697938;
			switch (num3 == num)
			{
			}
			num = (short)168034304;
			if (num != 0)
			{
			}
			num = (short)922419201;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_DATABUTTON_1;
			base.DataTransferOrder = 65;
		}

		// Token: 0x060086D5 RID: 34517 RVA: 0x007DB8B4 File Offset: 0x007D9AB4
		// Note: this type is marked as 'beforefieldinit'.
		static O7DataButtonInnerRecset()
		{
			short num = (short)1104150528;
			short num2 = num;
			num = (short)1587687353;
			short num3 = num;
			num = (short)653078457;
			switch (num3 == num)
			{
			}
			num = (short)1827667968;
			if (num != 0)
			{
			}
			num = (short)1125908481;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset._Min = 1;
		}

		// Token: 0x04003FE2 RID: 16354
		public static int _MaxPool;

		// Token: 0x04003FE3 RID: 16355
		public static int _Max;

		// Token: 0x04003FE4 RID: 16356
		public int _DynMax;

		// Token: 0x04003FE5 RID: 16357
		public static int _Min;

		// Token: 0x04003FE6 RID: 16358
		public static int _DefaultRecordCount;
	}
}
