using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RepeaterIDList
{
	// Token: 0x02000521 RID: 1313
	[global::System.Serializable]
	public class SingletoneFrequencyTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600B17C RID: 45436 RVA: 0x00A48654 File Offset: 0x00A46854
		public SingletoneFrequencyTableInnerRecset() : base(global::CommonResources.AcgResources.ID_SINGLETONEFREQUENCYTABLE, global::CommonResources.AcgResources.ID_TONE_1)
		{
			this.SetValues();
		}

		// Token: 0x0600B17D RID: 45437 RVA: 0x00A48678 File Offset: 0x00A46878
		public SingletoneFrequencyTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x1700590A RID: 22794
		// (get) Token: 0x0600B17E RID: 45438 RVA: 0x00A486A4 File Offset: 0x00A468A4
		public override int MaxPool
		{
			get
			{
				short num = (short)63633089;
				short num2 = num;
				num = (short)1832641;
				switch (num2 == num)
				{
				}
				num = (short)2128347137;
				if (num != 0)
				{
				}
				num = (short)1674969088;
				if (num != 0)
				{
				}
				num = (short)1557266432;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.SingletoneFrequencyTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x1700590B RID: 22795
		// (get) Token: 0x0600B17F RID: 45439 RVA: 0x00A48750 File Offset: 0x00A46950
		// (set) Token: 0x0600B180 RID: 45440 RVA: 0x00A48814 File Offset: 0x00A46A14
		public override int Max
		{
			get
			{
				short num;
				for (;;)
				{
					num = (short)1072627713;
					if (num != 0)
					{
					}
					if (this._DynMax == -1)
					{
						break;
					}
					num = (short)1238959546;
					short num2 = num;
					num = (short)712443322;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_98;
					}
					goto Block_1;
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.SingletoneFrequencyTableInnerRecset._Max;
				Block_1:
				num = (short)1462566912;
				short num3 = num;
				IL_98:
				num = (short)1092943872;
				if (num != 0)
				{
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)555745281;
				if (num != 0)
				{
				}
				num = (short)1426047711;
				short num2 = num;
				num = (short)1796063967;
				switch (num2 == num)
				{
				}
				num = (short)1292435456;
				if (num != 0)
				{
				}
				num = (short)613613568;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x1700590C RID: 22796
		// (get) Token: 0x0600B181 RID: 45441 RVA: 0x00A488C0 File Offset: 0x00A46AC0
		public override int Min
		{
			get
			{
				short num = (short)1214840833;
				if (num != 0)
				{
				}
				num = (short)893972691;
				short num2 = num;
				num = (short)1629483219;
				switch (num2 == num)
				{
				}
				num = (short)1950482432;
				if (num != 0)
				{
				}
				num = (short)30408704;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.SingletoneFrequencyTableInnerRecset._Min;
			}
		}

		// Token: 0x1700590D RID: 22797
		// (get) Token: 0x0600B182 RID: 45442 RVA: 0x00A4896C File Offset: 0x00A46B6C
		// (set) Token: 0x0600B183 RID: 45443 RVA: 0x00A48A1C File Offset: 0x00A46C1C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1792802817;
				if (num != 0)
				{
				}
				num = (short)1357769948;
				short num2 = num;
				num = (short)1125182684;
				switch (num2 == num)
				{
				}
				num = (short)2133852160;
				if (num != 0)
				{
				}
				num = (short)422576128;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.SingletoneFrequencyTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1344092530;
				short num2 = num;
				num = (short)154745202;
				switch (num2 == num)
				{
				}
				num = (short)524353537;
				if (num != 0)
				{
				}
				num = (short)719454208;
				if (num != 0)
				{
				}
				num = (short)225574912;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.SingletoneFrequencyTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700590E RID: 22798
		// (get) Token: 0x0600B184 RID: 45444 RVA: 0x00A48AD0 File Offset: 0x00A46CD0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1429495986;
				short num2 = num;
				num = (short)824139954;
				switch (num2 == num)
				{
				}
				num = (short)1170210817;
				if (num != 0)
				{
				}
				num = (short)1594687488;
				if (num != 0)
				{
				}
				num = (short)528809984;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x0600B185 RID: 45445 RVA: 0x00A48B80 File Offset: 0x00A46D80
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1773925293;
			short num2 = num;
			num = (short)1260123053;
			switch (num2 == num)
			{
			}
			num = (short)261554177;
			if (num != 0)
			{
			}
			num = (short)1340080128;
			if (num != 0)
			{
			}
			num = (short)964427776;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.SingletoneFrequencyTableInner(this);
		}

		// Token: 0x0600B186 RID: 45446 RVA: 0x00A48C2C File Offset: 0x00A46E2C
		internal void SetValues()
		{
			short num = (short)1609002142;
			short num2 = num;
			num = (short)309357726;
			switch (num2 == num)
			{
			}
			num = (short)230883329;
			if (num != 0)
			{
			}
			num = (short)1288896512;
			if (num != 0)
			{
			}
			num = (short)68943872;
			short num3 = num;
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_SINGLETONEFREQUENCYTABLE;
			base.KeySeed = global::CommonResources.AcgResources.ID_TONE_1;
			base.DataTransferOrder = 33;
		}

		// Token: 0x0600B187 RID: 45447 RVA: 0x00A48D04 File Offset: 0x00A46F04
		// Note: this type is marked as 'beforefieldinit'.
		static SingletoneFrequencyTableInnerRecset()
		{
			short num = (short)129826817;
			if (num != 0)
			{
			}
			num = (short)1129516926;
			short num2 = num;
			num = (short)605884286;
			switch (num2 == num)
			{
			}
			num = (short)131465216;
			if (num != 0)
			{
			}
			num = (short)436994048;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.SingletoneFrequencyTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.SingletoneFrequencyTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.SingletoneFrequencyTableInnerRecset._Min = 1;
		}

		// Token: 0x04005423 RID: 21539
		public static int _MaxPool;

		// Token: 0x04005424 RID: 21540
		public static int _Max;

		// Token: 0x04005425 RID: 21541
		public int _DynMax;

		// Token: 0x04005426 RID: 21542
		public static int _Min;

		// Token: 0x04005427 RID: 21543
		public static int _DefaultRecordCount;
	}
}
