using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x0200033B RID: 827
	[global::System.Serializable]
	public class DirectModeBCOListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06007F4E RID: 32590 RVA: 0x00752DB0 File Offset: 0x00750FB0
		public DirectModeBCOListInnerRecset() : base(global::CommonResources.AcgResources.ID_DIRECTMODEBCOLIST, true, false, true)
		{
			this.SetValues();
		}

		// Token: 0x06007F4F RID: 32591 RVA: 0x00752DD4 File Offset: 0x00750FD4
		public DirectModeBCOListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004121 RID: 16673
		// (get) Token: 0x06007F50 RID: 32592 RVA: 0x00752E00 File Offset: 0x00751000
		public override int MaxPool
		{
			get
			{
				short num = (short)1787766357;
				short num2 = num;
				num = (short)1617241685;
				switch (num2 == num)
				{
				}
				num = (short)1695940608;
				if (num != 0)
				{
				}
				num = (short)1366622208;
				short num3 = num;
				num = (short)149946369;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004122 RID: 16674
		// (get) Token: 0x06007F51 RID: 32593 RVA: 0x00752EB0 File Offset: 0x007510B0
		// (set) Token: 0x06007F52 RID: 32594 RVA: 0x00752F74 File Offset: 0x00751174
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)1460385781;
					short num2 = num;
					num = (short)278050805;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)403636224;
						if (num != 0)
						{
						}
						num = (short)1242562560;
						short num3 = num;
						break;
					}
					}
					num = (short)935133185;
					if (num != 0)
					{
					}
					return global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset._Max;
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1505518453;
				short num2 = num;
				num = (short)1543463797;
				switch (num2 == num)
				{
				}
				num = (short)2029518849;
				if (num != 0)
				{
				}
				num = (short)772538368;
				short num3 = num;
				num = (short)2121793536;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004123 RID: 16675
		// (get) Token: 0x06007F53 RID: 32595 RVA: 0x00753028 File Offset: 0x00751228
		public override int Min
		{
			get
			{
				short num = (short)676035023;
				short num2 = num;
				num = (short)390887887;
				switch (num2 == num)
				{
				}
				num = (short)1003814913;
				if (num != 0)
				{
				}
				num = (short)352649216;
				short num3 = num;
				num = (short)865337344;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset._Min;
			}
		}

		// Token: 0x17004124 RID: 16676
		// (get) Token: 0x06007F54 RID: 32596 RVA: 0x007530D8 File Offset: 0x007512D8
		// (set) Token: 0x06007F55 RID: 32597 RVA: 0x00753188 File Offset: 0x00751388
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)2074295291;
				short num2 = num;
				num = (short)199375867;
				switch (num2 == num)
				{
				}
				num = (short)784728065;
				if (num != 0)
				{
				}
				num = (short)1161232384;
				short num3 = num;
				num = (short)265486336;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1212133036;
				short num2 = num;
				num = (short)538226348;
				switch (num2 == num)
				{
				}
				num = (short)709754881;
				if (num != 0)
				{
				}
				num = (short)1958281216;
				short num3 = num;
				num = (short)1213399040;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17004125 RID: 16677
		// (get) Token: 0x06007F56 RID: 32598 RVA: 0x00753234 File Offset: 0x00751434
		public bool HasDiffs
		{
			get
			{
				short num = (short)1604583425;
				if (num != 0)
				{
				}
				num = (short)2070724790;
				short num2 = num;
				num = (short)2079899830;
				switch (num2 == num)
				{
				}
				num = (short)1413480448;
				short num3 = num;
				num = (short)1336147968;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007F57 RID: 32599 RVA: 0x007532E4 File Offset: 0x007514E4
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)883067073;
			short num2 = num;
			num = (short)9472193;
			switch (num2 == num)
			{
			}
			num = (short)1688993793;
			if (num != 0)
			{
			}
			num = (short)1778581504;
			short num3 = num;
			num = (short)1025507328;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner(this);
		}

		// Token: 0x06007F58 RID: 32600 RVA: 0x00753394 File Offset: 0x00751594
		internal void SetValues()
		{
			short num = (short)500726301;
			short num2 = num;
			num = (short)1188985373;
			switch (num2 == num)
			{
			}
			num = (short)1823539201;
			if (num != 0)
			{
			}
			num = (short)529924096;
			short num3 = num;
			num = (short)1499201536;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTMODEBCOLIST;
			base.DataTransferOrder = 14;
			this.b();
		}

		// Token: 0x06007F59 RID: 32601 RVA: 0x00753460 File Offset: 0x00751660
		private void b()
		{
			short num = (short)1861484545;
			if (num != 0)
			{
			}
			num = (short)352232990;
			short num2 = num;
			num = (short)100836894;
			switch (num2 == num)
			{
			}
			num = (short)1491533824;
			short num3 = num;
			num = (short)32636928;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06007F5A RID: 32602 RVA: 0x00753510 File Offset: 0x00751710
		private void a()
		{
			if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.LABTOOL)
			{
				short num = (short)489357313;
				if (num != 0)
				{
				}
				num = (short)134559253;
				short num2 = num;
				num = (short)27211285;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)422379520;
					short num3 = num;
					num = (short)576323584;
					if (num != 0)
					{
					}
					break;
				}
				}
				base.HiddenStatic = false;
				return;
			}
			base.HiddenStatic = true;
		}

		// Token: 0x06007F5B RID: 32603 RVA: 0x007535D4 File Offset: 0x007517D4
		// Note: this type is marked as 'beforefieldinit'.
		static DirectModeBCOListInnerRecset()
		{
			short num = (short)1318083351;
			short num2 = num;
			num = (short)815094551;
			switch (num2 == num)
			{
			}
			num = (short)729022464;
			if (num != 0)
			{
			}
			num = (short)1278803968;
			short num3 = num;
			num = (short)2027683841;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset._Min = 1;
		}

		// Token: 0x040039A8 RID: 14760
		public static int _MaxPool;

		// Token: 0x040039A9 RID: 14761
		public static int _Max;

		// Token: 0x040039AA RID: 14762
		public int _DynMax;

		// Token: 0x040039AB RID: 14763
		public static int _Min;

		// Token: 0x040039AC RID: 14764
		public static int _DefaultRecordCount;
	}
}
