using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories
{
	// Token: 0x02000309 RID: 777
	[global::System.Serializable]
	public class DataButtonInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06007B58 RID: 31576 RVA: 0x00710CFC File Offset: 0x0070EEFC
		public DataButtonInnerRecset() : base(global::CommonResources.AcgResources.ID_KPMDATABUTTON, global::CommonResources.AcgResources.ID_DATABUTTON_2)
		{
			this.SetValues();
		}

		// Token: 0x06007B59 RID: 31577 RVA: 0x00710D20 File Offset: 0x0070EF20
		public DataButtonInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17003F3C RID: 16188
		// (get) Token: 0x06007B5A RID: 31578 RVA: 0x00710D4C File Offset: 0x0070EF4C
		public override int MaxPool
		{
			get
			{
				short num = (short)1605042177;
				if (num != 0)
				{
				}
				num = (short)393075011;
				short num2 = num;
				num = (short)1680791875;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1635778560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)371851264;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset._MaxPool;
			}
		}

		// Token: 0x17003F3D RID: 16189
		// (get) Token: 0x06007B5B RID: 31579 RVA: 0x00710DFC File Offset: 0x0070EFFC
		// (set) Token: 0x06007B5C RID: 31580 RVA: 0x00710EBC File Offset: 0x0070F0BC
		public override int Max
		{
			get
			{
				short num = (short)1925770918;
				short num2 = num;
				num = (short)685502118;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AB;
				case 1:
					break;
				default:
				{
					num = (short)1605369856;
					short num3 = num;
					break;
				}
				}
				num = (short)1374355457;
				if (num != 0)
				{
				}
				num = (short)1450246144;
				if (num != 0)
				{
				}
				if (this._DynMax == -1)
				{
					return global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset._Max;
				}
				IL_AB:
				return this._DynMax;
			}
			set
			{
				short num = (short)1730150401;
				if (num != 0)
				{
				}
				num = (short)987389670;
				short num2 = num;
				num = (short)1607491302;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1301741568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1529020416;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17003F3E RID: 16190
		// (get) Token: 0x06007B5D RID: 31581 RVA: 0x00710F6C File Offset: 0x0070F16C
		public override int Min
		{
			get
			{
				short num = (short)62097187;
				short num2 = num;
				num = (short)541558563;
				switch (num2 == num)
				{
				}
				num = (short)786956288;
				short num3 = num;
				num = (short)774176769;
				if (num != 0)
				{
				}
				num = (short)1037893632;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset._Min;
			}
		}

		// Token: 0x17003F3F RID: 16191
		// (get) Token: 0x06007B5E RID: 31582 RVA: 0x0071101C File Offset: 0x0070F21C
		// (set) Token: 0x06007B5F RID: 31583 RVA: 0x007110CC File Offset: 0x0070F2CC
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1501435683;
				short num2 = num;
				num = (short)765663011;
				switch (num2 == num)
				{
				}
				num = (short)503906304;
				short num3 = num;
				num = (short)1580662785;
				if (num != 0)
				{
				}
				num = (short)368508928;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1148686146;
				short num2 = num;
				num = (short)803245890;
				switch (num2 == num)
				{
				}
				num = (short)1446838272;
				short num3 = num;
				num = (short)877854720;
				if (num != 0)
				{
				}
				num = (short)965017601;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17003F40 RID: 16192
		// (get) Token: 0x06007B60 RID: 31584 RVA: 0x0071117C File Offset: 0x0070F37C
		public bool HasDiffs
		{
			get
			{
				short num = (short)207936676;
				short num2 = num;
				num = (short)189455524;
				switch (num2 == num)
				{
				}
				num = (short)618528768;
				short num3 = num;
				num = (short)561184768;
				if (num != 0)
				{
				}
				num = (short)1323040769;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007B61 RID: 31585 RVA: 0x0071122C File Offset: 0x0070F42C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)855603985;
			short num2 = num;
			num = (short)2093054737;
			switch (num2 == num)
			{
			}
			num = (short)1935998976;
			short num3 = num;
			num = (short)1848115201;
			if (num != 0)
			{
			}
			num = (short)640221184;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInner(this);
		}

		// Token: 0x06007B62 RID: 31586 RVA: 0x007112D8 File Offset: 0x0070F4D8
		internal void SetValues()
		{
			short num = (short)312829434;
			short num2 = num;
			num = (short)1112368634;
			switch (num2 == num)
			{
			}
			num = (short)404881408;
			short num3 = num;
			num = (short)43057153;
			if (num != 0)
			{
			}
			num = (short)1557987328;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_KPMDATABUTTON;
			base.KeySeed = global::CommonResources.AcgResources.ID_DATABUTTON_2;
			base.DataTransferOrder = 18;
		}

		// Token: 0x06007B63 RID: 31587 RVA: 0x007113AC File Offset: 0x0070F5AC
		// Note: this type is marked as 'beforefieldinit'.
		static DataButtonInnerRecset()
		{
			short num = (short)1515163821;
			short num2 = num;
			num = (short)953258157;
			switch (num2 == num)
			{
			}
			num = (short)1122697216;
			short num3 = num;
			num = (short)1557004289;
			if (num != 0)
			{
			}
			num = (short)115343360;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset._Min = 1;
		}

		// Token: 0x040035EA RID: 13802
		public static int _MaxPool;

		// Token: 0x040035EB RID: 13803
		public static int _Max;

		// Token: 0x040035EC RID: 13804
		public int _DynMax;

		// Token: 0x040035ED RID: 13805
		public static int _Min;

		// Token: 0x040035EE RID: 13806
		public static int _DefaultRecordCount;
	}
}
