using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000344 RID: 836
	[global::System.Serializable]
	public class BottomFunctionButtonBCOListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06008025 RID: 32805 RVA: 0x0075CBA4 File Offset: 0x0075ADA4
		public BottomFunctionButtonBCOListInnerRecset() : base(global::CommonResources.AcgResources.ID_BOTTOMFUNCTIONBUTTONBCOLIST)
		{
			this.SetValues();
		}

		// Token: 0x06008026 RID: 32806 RVA: 0x0075CBC4 File Offset: 0x0075ADC4
		public BottomFunctionButtonBCOListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004185 RID: 16773
		// (get) Token: 0x06008027 RID: 32807 RVA: 0x0075CBF0 File Offset: 0x0075ADF0
		public override int MaxPool
		{
			get
			{
				short num = (short)1038958929;
				short num2 = num;
				num = (short)265699665;
				switch (num2 == num)
				{
				}
				num = (short)1951662081;
				if (num != 0)
				{
				}
				num = (short)332660736;
				short num3 = num;
				num = (short)1239810048;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004186 RID: 16774
		// (get) Token: 0x06008028 RID: 32808 RVA: 0x0075CCA0 File Offset: 0x0075AEA0
		// (set) Token: 0x06008029 RID: 32809 RVA: 0x0075CD64 File Offset: 0x0075AF64
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)480512811;
					short num2 = num;
					num = (short)1120865067;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2077097984;
						short num3 = num;
						num = (short)1135542273;
						if (num != 0)
						{
						}
						num = (short)293142528;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerRecset._Max;
					}
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)445169700;
				short num2 = num;
				num = (short)1060356132;
				switch (num2 == num)
				{
				}
				num = (short)1628504064;
				if (num != 0)
				{
				}
				num = (short)476971008;
				short num3 = num;
				num = (short)209453057;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004187 RID: 16775
		// (get) Token: 0x0600802A RID: 32810 RVA: 0x0075CE14 File Offset: 0x0075B014
		public override int Min
		{
			get
			{
				short num = (short)521357716;
				short num2 = num;
				num = (short)1679051156;
				switch (num2 == num)
				{
				}
				num = (short)1421541377;
				if (num != 0)
				{
				}
				num = (short)613548032;
				short num3 = num;
				num = (short)225050624;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerRecset._Min;
			}
		}

		// Token: 0x17004188 RID: 16776
		// (get) Token: 0x0600802B RID: 32811 RVA: 0x0075CEC0 File Offset: 0x0075B0C0
		// (set) Token: 0x0600802C RID: 32812 RVA: 0x0075CF70 File Offset: 0x0075B170
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)596277604;
				short num2 = num;
				num = (short)1325365604;
				switch (num2 == num)
				{
				}
				num = (short)384172033;
				if (num != 0)
				{
				}
				num = (short)290127872;
				short num3 = num;
				num = (short)1958477824;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)288749843;
				short num2 = num;
				num = (short)1913911571;
				switch (num2 == num)
				{
				}
				num = (short)1300824064;
				if (num != 0)
				{
				}
				num = (short)1421213696;
				short num3 = num;
				num = (short)1500053505;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17004189 RID: 16777
		// (get) Token: 0x0600802D RID: 32813 RVA: 0x0075D020 File Offset: 0x0075B220
		public bool HasDiffs
		{
			get
			{
				short num = (short)1901043791;
				short num2 = num;
				num = (short)184459343;
				switch (num2 == num)
				{
				}
				num = (short)914554881;
				if (num != 0)
				{
				}
				num = (short)1198850048;
				short num3 = num;
				num = (short)1769799680;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600802E RID: 32814 RVA: 0x0075D0D0 File Offset: 0x0075B2D0
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)139005550;
			short num2 = num;
			num = (short)155192942;
			switch (num2 == num)
			{
			}
			num = (short)1468923904;
			if (num != 0)
			{
			}
			num = (short)907935744;
			short num3 = num;
			num = (short)1860501505;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner(this);
		}

		// Token: 0x0600802F RID: 32815 RVA: 0x0075D180 File Offset: 0x0075B380
		internal void SetValues()
		{
			short num = (short)1396506625;
			if (num != 0)
			{
			}
			num = (short)1183727128;
			short num2 = num;
			num = (short)2086944280;
			switch (num2 == num)
			{
			}
			num = (short)744554496;
			short num3 = num;
			num = (short)951123968;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_BOTTOMFUNCTIONBUTTONBCOLIST;
			base.DataTransferOrder = 50;
			this.b();
		}

		// Token: 0x06008030 RID: 32816 RVA: 0x0075D250 File Offset: 0x0075B450
		private void b()
		{
			short num = (short)1830221135;
			short num2 = num;
			num = (short)482866511;
			switch (num2 == num)
			{
			}
			num = (short)2142371840;
			if (num != 0)
			{
			}
			num = (short)933822464;
			short num3 = num;
			num = (short)1088684033;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06008031 RID: 32817 RVA: 0x0075D300 File Offset: 0x0075B500
		private void a()
		{
			if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.LABTOOL)
			{
				short num = (short)138138731;
				short num2 = num;
				num = (short)338613355;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1540227072;
					short num3 = num;
					num = (short)196280321;
					if (num != 0)
					{
					}
					num = (short)1459224576;
					if (num != 0)
					{
					}
					base.HiddenStatic = false;
					return;
				}
				}
			}
			base.HiddenStatic = true;
		}

		// Token: 0x06008032 RID: 32818 RVA: 0x0075D3C8 File Offset: 0x0075B5C8
		// Note: this type is marked as 'beforefieldinit'.
		static BottomFunctionButtonBCOListInnerRecset()
		{
			short num = (short)1571712379;
			short num2 = num;
			num = (short)928804219;
			switch (num2 == num)
			{
			}
			num = (short)1676017665;
			if (num != 0)
			{
			}
			num = (short)10092544;
			short num3 = num;
			num = (short)1258160128;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerRecset._Min = 1;
		}

		// Token: 0x040039BB RID: 14779
		public static int _MaxPool;

		// Token: 0x040039BC RID: 14780
		public static int _Max;

		// Token: 0x040039BD RID: 14781
		public int _DynMax;

		// Token: 0x040039BE RID: 14782
		public static int _Min;

		// Token: 0x040039BF RID: 14783
		public static int _DefaultRecordCount;
	}
}
