using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x0200046C RID: 1132
	[global::System.Serializable]
	public class TxSynthesizerReferenceDividerListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060095AA RID: 38314 RVA: 0x008CA604 File Offset: 0x008C8804
		public TxSynthesizerReferenceDividerListInnerRecset() : base(global::CommonResources.AcgResources.ID_TXSYNTHESIZERREFERENCEDIVIDERLIST, true, false, true)
		{
			this.SetValues();
		}

		// Token: 0x060095AB RID: 38315 RVA: 0x008CA628 File Offset: 0x008C8828
		public TxSynthesizerReferenceDividerListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004B32 RID: 19250
		// (get) Token: 0x060095AC RID: 38316 RVA: 0x008CA654 File Offset: 0x008C8854
		public override int MaxPool
		{
			get
			{
				short num = (short)1804606841;
				short num2 = num;
				num = (short)1793465721;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1732640768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1283653633;
				if (num != 0)
				{
				}
				num = (short)1892614144;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004B33 RID: 19251
		// (get) Token: 0x060095AD RID: 38317 RVA: 0x008CA700 File Offset: 0x008C8900
		// (set) Token: 0x060095AE RID: 38318 RVA: 0x008CA7C0 File Offset: 0x008C89C0
		public override int Max
		{
			get
			{
				short num = (short)2057371649;
				if (num != 0)
				{
				}
				if (this._DynMax != -1)
				{
					num = (short)1210888756;
					short num2 = num;
					num = (short)5354036;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)311623680;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
				}
				num = (short)270729216;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerListInnerRecset._Max;
			}
			set
			{
				short num = (short)1536292346;
				short num2 = num;
				num = (short)714929658;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1735720960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2008219649;
				if (num != 0)
				{
				}
				num = (short)880541696;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004B34 RID: 19252
		// (get) Token: 0x060095AF RID: 38319 RVA: 0x008CA870 File Offset: 0x008C8A70
		public override int Min
		{
			get
			{
				short num = (short)1909081061;
				short num2 = num;
				num = (short)327828453;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1329922048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1717960704;
				if (num != 0)
				{
				}
				num = (short)33619969;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerListInnerRecset._Min;
			}
		}

		// Token: 0x17004B35 RID: 19253
		// (get) Token: 0x060095B0 RID: 38320 RVA: 0x008CA920 File Offset: 0x008C8B20
		// (set) Token: 0x060095B1 RID: 38321 RVA: 0x008CA9CC File Offset: 0x008C8BCC
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)783599026;
				short num2 = num;
				num = (short)383763890;
				switch (num2 == num)
				{
				}
				num = (short)2059141120;
				short num3 = num;
				num = (short)1947074561;
				if (num != 0)
				{
				}
				num = (short)370081792;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1726265101;
				short num2 = num;
				num = (short)1490532109;
				switch (num2 == num)
				{
				}
				num = (short)776470528;
				short num3 = num;
				num = (short)1169293313;
				if (num != 0)
				{
				}
				num = (short)1862205440;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17004B36 RID: 19254
		// (get) Token: 0x060095B2 RID: 38322 RVA: 0x008CAA7C File Offset: 0x008C8C7C
		public bool HasDiffs
		{
			get
			{
				short num = (short)845893268;
				short num2 = num;
				num = (short)1776176788;
				switch (num2 == num)
				{
				}
				num = (short)847577088;
				short num3 = num;
				num = (short)1828847617;
				if (num != 0)
				{
				}
				num = (short)2009268224;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060095B3 RID: 38323 RVA: 0x008CAB2C File Offset: 0x008C8D2C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1761459604;
			short num2 = num;
			num = (short)2009709972;
			switch (num2 == num)
			{
			}
			num = (short)1899692032;
			short num3 = num;
			num = (short)994377729;
			if (num != 0)
			{
			}
			num = (short)207552512;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerListInner(this);
		}

		// Token: 0x060095B4 RID: 38324 RVA: 0x008CABD8 File Offset: 0x008C8DD8
		internal void SetValues()
		{
			short num = (short)879807867;
			short num2 = num;
			num = (short)1723911547;
			switch (num2 == num)
			{
			}
			num = (short)688259072;
			short num3 = num;
			num = (short)1373110273;
			if (num != 0)
			{
			}
			num = (short)1491599360;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_TXSYNTHESIZERREFERENCEDIVIDERLIST;
			base.DataTransferOrder = 5;
		}

		// Token: 0x060095B5 RID: 38325 RVA: 0x008CACA4 File Offset: 0x008C8EA4
		// Note: this type is marked as 'beforefieldinit'.
		static TxSynthesizerReferenceDividerListInnerRecset()
		{
			short num = (short)1317470209;
			if (num != 0)
			{
			}
			num = (short)1017079138;
			short num2 = num;
			num = (short)1464034658;
			switch (num2 == num)
			{
			default:
			{
				num = (short)599654400;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)270401536;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerListInnerRecset._Min = 1;
		}

		// Token: 0x04004A0C RID: 18956
		public static int _MaxPool;

		// Token: 0x04004A0D RID: 18957
		public static int _Max;

		// Token: 0x04004A0E RID: 18958
		public int _DynMax;

		// Token: 0x04004A0F RID: 18959
		public static int _Min;

		// Token: 0x04004A10 RID: 18960
		public static int _DefaultRecordCount;
	}
}
