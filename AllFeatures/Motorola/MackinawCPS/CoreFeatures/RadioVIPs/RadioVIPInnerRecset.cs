using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioVIPs
{
	// Token: 0x020002ED RID: 749
	[global::System.Serializable]
	public class RadioVIPInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06007977 RID: 31095 RVA: 0x006E6958 File Offset: 0x006E4B58
		public RadioVIPInnerRecset() : base(global::CommonResources.AcgResources.ID_RADIOVIPTABLE, global::CommonResources.AcgResources.ID_RADIOVIP)
		{
			this.SetValues();
		}

		// Token: 0x06007978 RID: 31096 RVA: 0x006E697C File Offset: 0x006E4B7C
		public RadioVIPInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17003E6B RID: 15979
		// (get) Token: 0x06007979 RID: 31097 RVA: 0x006E69A8 File Offset: 0x006E4BA8
		public override int MaxPool
		{
			get
			{
				short num = (short)1693384704;
				short num2 = num;
				num = (short)411882108;
				short num3 = num;
				num = (short)37737084;
				switch (num3 == num)
				{
				}
				num = (short)892207104;
				if (num != 0)
				{
				}
				num = (short)837353473;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset._MaxPool;
			}
		}

		// Token: 0x17003E6C RID: 15980
		// (get) Token: 0x0600797A RID: 31098 RVA: 0x006E6A58 File Offset: 0x006E4C58
		// (set) Token: 0x0600797B RID: 31099 RVA: 0x006E6B18 File Offset: 0x006E4D18
		public override int Max
		{
			get
			{
				while (this._DynMax != -1)
				{
					short num = (short)140200822;
					short num2 = num;
					num = (short)1131891574;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1186201600;
						short num3 = num;
						num = (short)1769406465;
						if (num != 0)
						{
						}
						num = (short)1310457856;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
					}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset._Max;
			}
			set
			{
				short num = (short)1350893568;
				short num2 = num;
				num = (short)668408339;
				short num3 = num;
				num = (short)1284446739;
				switch (num3 == num)
				{
				}
				num = (short)48562177;
				if (num != 0)
				{
				}
				num = (short)2094202880;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17003E6D RID: 15981
		// (get) Token: 0x0600797C RID: 31100 RVA: 0x006E6BCC File Offset: 0x006E4DCC
		public override int Min
		{
			get
			{
				short num = (short)196608000;
				short num2 = num;
				num = (short)403285938;
				short num3 = num;
				num = (short)446146482;
				switch (num3 == num)
				{
				}
				num = (short)382271489;
				if (num != 0)
				{
				}
				num = (short)224460800;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset._Min;
			}
		}

		// Token: 0x17003E6E RID: 15982
		// (get) Token: 0x0600797D RID: 31101 RVA: 0x006E6C7C File Offset: 0x006E4E7C
		// (set) Token: 0x0600797E RID: 31102 RVA: 0x006E6D2C File Offset: 0x006E4F2C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1417936896;
				short num2 = num;
				num = (short)1904501579;
				short num3 = num;
				num = (short)528180043;
				switch (num3 == num)
				{
				}
				num = (short)256245761;
				if (num != 0)
				{
				}
				num = (short)190316544;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1441333248;
				short num2 = num;
				num = (short)1481484638;
				short num3 = num;
				num = (short)1065396574;
				switch (num3 == num)
				{
				}
				num = (short)1003945984;
				if (num != 0)
				{
				}
				num = (short)499908609;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17003E6F RID: 15983
		// (get) Token: 0x0600797F RID: 31103 RVA: 0x006E6DE0 File Offset: 0x006E4FE0
		public bool HasDiffs
		{
			get
			{
				short num = (short)327876608;
				short num2 = num;
				num = (short)1712128001;
				if (num != 0)
				{
				}
				num = (short)1948744054;
				short num3 = num;
				num = (short)2002024822;
				switch (num3 == num)
				{
				}
				num = (short)1493434368;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007980 RID: 31104 RVA: 0x006E6E8C File Offset: 0x006E508C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)551550976;
			short num2 = num;
			num = (short)2089877505;
			if (num != 0)
			{
			}
			num = (short)1439075662;
			short num3 = num;
			num = (short)992578894;
			switch (num3 == num)
			{
			}
			num = (short)75300864;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner(this);
		}

		// Token: 0x06007981 RID: 31105 RVA: 0x006E6F3C File Offset: 0x006E513C
		internal void SetValues()
		{
			short num = (short)509673472;
			short num2 = num;
			num = (short)128195588;
			short num3 = num;
			num = (short)319364100;
			switch (num3 == num)
			{
			}
			num = (short)1553006592;
			if (num != 0)
			{
			}
			num = (short)41615361;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_RADIOVIPTABLE;
			base.KeySeed = global::CommonResources.AcgResources.ID_RADIOVIP;
			base.DataTransferOrder = 15;
		}

		// Token: 0x06007982 RID: 31106 RVA: 0x006E7014 File Offset: 0x006E5214
		// Note: this type is marked as 'beforefieldinit'.
		static RadioVIPInnerRecset()
		{
			short num = (short)1990393856;
			short num2 = num;
			num = (short)515783686;
			short num3 = num;
			num = (short)557726726;
			switch (num3 == num)
			{
			}
			num = (short)34537473;
			if (num != 0)
			{
			}
			num = (short)56229888;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset._Min = 1;
		}

		// Token: 0x04003356 RID: 13142
		public static int _MaxPool;

		// Token: 0x04003357 RID: 13143
		public static int _Max;

		// Token: 0x04003358 RID: 13144
		public int _DynMax;

		// Token: 0x04003359 RID: 13145
		public static int _Min;

		// Token: 0x0400335A RID: 13146
		public static int _DefaultRecordCount;
	}
}
