using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x0200017F RID: 383
	[global::System.Serializable]
	public class RelockTimerInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06003E0F RID: 15887 RVA: 0x003AA310 File Offset: 0x003A8510
		public RelockTimerInnerRecset() : base(global::CommonResources.AcgResources.ID_RELOCKTIMER, true, false, true)
		{
			this.SetValues();
		}

		// Token: 0x06003E10 RID: 15888 RVA: 0x003AA334 File Offset: 0x003A8534
		public RelockTimerInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17001FD5 RID: 8149
		// (get) Token: 0x06003E11 RID: 15889 RVA: 0x003AA360 File Offset: 0x003A8560
		public override int MaxPool
		{
			get
			{
				short num = (short)933343184;
				short num2 = num;
				num = (short)738897872;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1722941440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)835059713;
				if (num != 0)
				{
				}
				num = (short)514850816;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RelockTimerInnerRecset._MaxPool;
			}
		}

		// Token: 0x17001FD6 RID: 8150
		// (get) Token: 0x06003E12 RID: 15890 RVA: 0x003AA410 File Offset: 0x003A8610
		// (set) Token: 0x06003E13 RID: 15891 RVA: 0x003AA4D4 File Offset: 0x003A86D4
		public override int Max
		{
			get
			{
				short num = (short)526450688;
				short num2 = num;
				if (this._DynMax != -1)
				{
					num = (short)1854252994;
					short num3 = num;
					num = (short)26191810;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)933429248;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
				}
				num = (short)1595146241;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RelockTimerInnerRecset._Max;
			}
			set
			{
				short num = (short)2025033242;
				short num2 = num;
				num = (short)1574735386;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1025245184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)970129409;
				if (num != 0)
				{
				}
				num = (short)877068288;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17001FD7 RID: 8151
		// (get) Token: 0x06003E14 RID: 15892 RVA: 0x003AA580 File Offset: 0x003A8780
		public override int Min
		{
			get
			{
				short num = (short)1850981911;
				short num2 = num;
				num = (short)68009495;
				switch (num2 == num)
				{
				default:
				{
					num = (short)198377472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1796997120;
				if (num != 0)
				{
				}
				num = (short)530579457;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RelockTimerInnerRecset._Min;
			}
		}

		// Token: 0x17001FD8 RID: 8152
		// (get) Token: 0x06003E15 RID: 15893 RVA: 0x003AA630 File Offset: 0x003A8830
		// (set) Token: 0x06003E16 RID: 15894 RVA: 0x003AA6E0 File Offset: 0x003A88E0
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)19296718;
				short num2 = num;
				num = (short)1616474574;
				switch (num2 == num)
				{
				default:
				{
					num = (short)684851200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)289669120;
				if (num != 0)
				{
				}
				num = (short)552665089;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RelockTimerInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1361089933;
				short num2 = num;
				num = (short)311727501;
				switch (num2 == num)
				{
				default:
				{
					num = (short)825163776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)492503040;
				if (num != 0)
				{
				}
				num = (short)288030721;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RelockTimerInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17001FD9 RID: 8153
		// (get) Token: 0x06003E17 RID: 15895 RVA: 0x003AA794 File Offset: 0x003A8994
		public bool HasDiffs
		{
			get
			{
				short num = (short)1920983972;
				short num2 = num;
				num = (short)531358628;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1842085888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)768802816;
				if (num != 0)
				{
				}
				num = (short)35651585;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06003E18 RID: 15896 RVA: 0x003AA844 File Offset: 0x003A8A44
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)342163457;
			if (num != 0)
			{
			}
			num = (short)896204800;
			short num2 = num;
			num = (short)1579886619;
			short num3 = num;
			num = (short)2146576411;
			switch (num3 == num)
			{
			}
			num = (short)45088768;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RelockTimerInner(this);
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x003AA8F4 File Offset: 0x003A8AF4
		internal void SetValues()
		{
			short num = (short)1631466112;
			short num2 = num;
			num = (short)1708470912;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1044316160;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)516161537;
			if (num != 0)
			{
			}
			num = (short)1682767872;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_RELOCKTIMER;
			base.DataTransferOrder = 7;
		}

		// Token: 0x06003E1A RID: 15898 RVA: 0x003AA9BC File Offset: 0x003A8BBC
		// Note: this type is marked as 'beforefieldinit'.
		static RelockTimerInnerRecset()
		{
			short num = (short)339612089;
			short num2 = num;
			num = (short)540742073;
			switch (num2 == num)
			{
			default:
			{
				num = (short)188350464;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)408289280;
			if (num != 0)
			{
			}
			num = (short)1394212865;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RelockTimerInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RelockTimerInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RelockTimerInnerRecset._Min = 1;
		}

		// Token: 0x040019DC RID: 6620
		public static int _MaxPool;

		// Token: 0x040019DD RID: 6621
		public static int _Max;

		// Token: 0x040019DE RID: 6622
		public int _DynMax;

		// Token: 0x040019DF RID: 6623
		public static int _Min;

		// Token: 0x040019E0 RID: 6624
		public static int _DefaultRecordCount;
	}
}
