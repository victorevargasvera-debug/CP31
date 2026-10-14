using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x02000464 RID: 1124
	[global::System.Serializable]
	public class SecondLOInjectionFrequencyListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600951D RID: 38173 RVA: 0x008C41E0 File Offset: 0x008C23E0
		public SecondLOInjectionFrequencyListInnerRecset() : base(global::CommonResources.AcgResources.ID_SECONDLOINJECTIONFREQUENCYLIST, true, false, true)
		{
			this.SetValues();
		}

		// Token: 0x0600951E RID: 38174 RVA: 0x008C4204 File Offset: 0x008C2404
		public SecondLOInjectionFrequencyListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004AF9 RID: 19193
		// (get) Token: 0x0600951F RID: 38175 RVA: 0x008C4230 File Offset: 0x008C2430
		public override int MaxPool
		{
			get
			{
				short num = (short)546308097;
				if (num != 0)
				{
				}
				num = (short)707924019;
				short num2 = num;
				num = (short)1600655411;
				switch (num2 == num)
				{
				}
				num = (short)1700265984;
				if (num != 0)
				{
				}
				num = (short)1766719488;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequencyListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004AFA RID: 19194
		// (get) Token: 0x06009520 RID: 38176 RVA: 0x008C42DC File Offset: 0x008C24DC
		// (set) Token: 0x06009521 RID: 38177 RVA: 0x008C439C File Offset: 0x008C259C
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)537983632;
					short num2 = num;
					num = (short)1854798480;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AD;
					case 1:
						break;
					default:
					{
						num = (short)2085355520;
						short num3 = num;
						break;
					}
					}
					num = (short)1612316673;
					if (num != 0)
					{
					}
					num = (short)1322778624;
					if (num != 0)
					{
					}
					return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequencyListInnerRecset._Max;
				}
				IL_AD:
				return this._DynMax;
			}
			set
			{
				short num = (short)1777376769;
				short num2 = num;
				num = (short)2141036033;
				switch (num2 == num)
				{
				}
				num = (short)1145176064;
				if (num != 0)
				{
				}
				num = (short)898367489;
				if (num != 0)
				{
				}
				num = (short)1236205568;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x17004AFB RID: 19195
		// (get) Token: 0x06009522 RID: 38178 RVA: 0x008C4450 File Offset: 0x008C2650
		public override int Min
		{
			get
			{
				short num = (short)2012941314;
				short num2 = num;
				num = (short)1243941890;
				switch (num2 == num)
				{
				}
				num = (short)1443561472;
				if (num != 0)
				{
				}
				num = (short)1048838145;
				if (num != 0)
				{
				}
				num = (short)1091174400;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequencyListInnerRecset._Min;
			}
		}

		// Token: 0x17004AFC RID: 19196
		// (get) Token: 0x06009523 RID: 38179 RVA: 0x008C44FC File Offset: 0x008C26FC
		// (set) Token: 0x06009524 RID: 38180 RVA: 0x008C45AC File Offset: 0x008C27AC
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1469762057;
				short num2 = num;
				num = (short)207407625;
				switch (num2 == num)
				{
				}
				num = (short)114098176;
				if (num != 0)
				{
				}
				num = (short)830865409;
				if (num != 0)
				{
				}
				num = (short)1433862144;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequencyListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)2102210933;
				short num2 = num;
				num = (short)1912484213;
				switch (num2 == num)
				{
				}
				num = (short)1744240640;
				if (num != 0)
				{
				}
				num = (short)494338049;
				if (num != 0)
				{
				}
				num = (short)1219821568;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequencyListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17004AFD RID: 19197
		// (get) Token: 0x06009525 RID: 38181 RVA: 0x008C465C File Offset: 0x008C285C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1316062443;
				short num2 = num;
				num = (short)1778353387;
				switch (num2 == num)
				{
				}
				num = (short)1461780480;
				if (num != 0)
				{
				}
				num = (short)149815297;
				if (num != 0)
				{
				}
				num = (short)755957760;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06009526 RID: 38182 RVA: 0x008C470C File Offset: 0x008C290C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1792438386;
			short num2 = num;
			num = (short)891449458;
			switch (num2 == num)
			{
			}
			num = (short)1503395841;
			if (num != 0)
			{
			}
			num = (short)1942945792;
			if (num != 0)
			{
			}
			num = (short)345243648;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequencyListInner(this);
		}

		// Token: 0x06009527 RID: 38183 RVA: 0x008C47B8 File Offset: 0x008C29B8
		internal void SetValues()
		{
			short num = (short)1405015269;
			short num2 = num;
			num = (short)295359717;
			switch (num2 == num)
			{
			}
			num = (short)1256128512;
			if (num != 0)
			{
			}
			num = (short)1237975041;
			if (num != 0)
			{
			}
			num = (short)418971648;
			short num3 = num;
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_SECONDLOINJECTIONFREQUENCYLIST;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06009528 RID: 38184 RVA: 0x008C4880 File Offset: 0x008C2A80
		// Note: this type is marked as 'beforefieldinit'.
		static SecondLOInjectionFrequencyListInnerRecset()
		{
			short num = (short)768433540;
			short num2 = num;
			num = (short)1257921924;
			switch (num2 == num)
			{
			}
			num = (short)1463549952;
			if (num != 0)
			{
			}
			num = (short)779157505;
			if (num != 0)
			{
			}
			num = (short)102563840;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequencyListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequencyListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequencyListInnerRecset._Min = 1;
		}

		// Token: 0x040049FD RID: 18941
		public static int _MaxPool;

		// Token: 0x040049FE RID: 18942
		public static int _Max;

		// Token: 0x040049FF RID: 18943
		public int _DynMax;

		// Token: 0x04004A00 RID: 18944
		public static int _Min;

		// Token: 0x04004A01 RID: 18945
		public static int _DefaultRecordCount;
	}
}
