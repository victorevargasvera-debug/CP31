using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.SmartKeyFob
{
	// Token: 0x020002CE RID: 718
	[global::System.Serializable]
	public class SmartKeyFobButtonTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600771E RID: 30494 RVA: 0x006BC334 File Offset: 0x006BA534
		public SmartKeyFobButtonTableInnerRecset() : base(global::CommonResources.AcgResources.ID_SMARTKEYFOBBUTTONTABLE, global::CommonResources.AcgResources.ID_FOBBUTTON)
		{
			this.SetValues();
		}

		// Token: 0x0600771F RID: 30495 RVA: 0x006BC358 File Offset: 0x006BA558
		public SmartKeyFobButtonTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17003D48 RID: 15688
		// (get) Token: 0x06007720 RID: 30496 RVA: 0x006BC384 File Offset: 0x006BA584
		public override int MaxPool
		{
			get
			{
				short num = (short)1223566824;
				short num2 = num;
				num = (short)1477256680;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1337786368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)286916609;
				if (num != 0)
				{
				}
				num = (short)1409351680;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x17003D49 RID: 15689
		// (get) Token: 0x06007721 RID: 30497 RVA: 0x006BC434 File Offset: 0x006BA634
		// (set) Token: 0x06007722 RID: 30498 RVA: 0x006BC4F8 File Offset: 0x006BA6F8
		public override int Max
		{
			get
			{
				if (this._DynMax != -1)
				{
					short num = (short)368192717;
					short num2 = num;
					num = (short)949890253;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)999161857;
						if (num != 0)
						{
						}
						num = (short)1329528832;
						if (num != 0)
						{
						}
						num = (short)544669696;
						short num3 = num;
						return this._DynMax;
					}
					}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset._Max;
			}
			set
			{
				short num = (short)908883124;
				short num2 = num;
				num = (short)1693611188;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1220870144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)448069633;
				if (num != 0)
				{
				}
				num = (short)770310144;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17003D4A RID: 15690
		// (get) Token: 0x06007723 RID: 30499 RVA: 0x006BC5A8 File Offset: 0x006BA7A8
		public override int Min
		{
			get
			{
				short num = (short)1267776444;
				short num2 = num;
				num = (short)2117516220;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2144337920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)128057345;
				if (num != 0)
				{
				}
				num = (short)329449472;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset._Min;
			}
		}

		// Token: 0x17003D4B RID: 15691
		// (get) Token: 0x06007724 RID: 30500 RVA: 0x006BC658 File Offset: 0x006BA858
		// (set) Token: 0x06007725 RID: 30501 RVA: 0x006BC704 File Offset: 0x006BA904
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1647414394;
				short num2 = num;
				num = (short)1835502714;
				switch (num2 == num)
				{
				default:
				{
					num = (short)975110144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)857735168;
				if (num != 0)
				{
				}
				num = (short)65077249;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)439583124;
				short num2 = num;
				num = (short)511541652;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1056178176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)832897025;
				if (num != 0)
				{
				}
				num = (short)729088000;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17003D4C RID: 15692
		// (get) Token: 0x06007726 RID: 30502 RVA: 0x006BC7B4 File Offset: 0x006BA9B4
		public bool HasDiffs
		{
			get
			{
				short num = (short)79691664;
				short num2 = num;
				num = (short)1298792336;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1342636032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1977548800;
				if (num != 0)
				{
				}
				num = (short)1696792577;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007727 RID: 30503 RVA: 0x006BC860 File Offset: 0x006BAA60
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)2037837469;
			short num2 = num;
			num = (short)497544861;
			switch (num2 == num)
			{
			default:
			{
				num = (short)845611008;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1684144129;
			if (num != 0)
			{
			}
			num = (short)683016192;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInner(this);
		}

		// Token: 0x06007728 RID: 30504 RVA: 0x006BC910 File Offset: 0x006BAB10
		internal void SetValues()
		{
			short num = (short)1992795162;
			short num2 = num;
			num = (short)750560282;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1463222272;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1367605249;
			if (num != 0)
			{
			}
			num = (short)243138560;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_SMARTKEYFOBBUTTONTABLE;
			base.KeySeed = global::CommonResources.AcgResources.ID_FOBBUTTON;
			base.DataTransferOrder = 120;
		}

		// Token: 0x06007729 RID: 30505 RVA: 0x006BC9E8 File Offset: 0x006BABE8
		// Note: this type is marked as 'beforefieldinit'.
		static SmartKeyFobButtonTableInnerRecset()
		{
			short num = (short)1030552510;
			short num2 = num;
			num = (short)2047802302;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1556480000;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1094189057;
			if (num != 0)
			{
			}
			num = (short)571801600;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset._Min = 1;
		}

		// Token: 0x040031B5 RID: 12725
		public static int _MaxPool;

		// Token: 0x040031B6 RID: 12726
		public static int _Max;

		// Token: 0x040031B7 RID: 12727
		public int _DynMax;

		// Token: 0x040031B8 RID: 12728
		public static int _Min;

		// Token: 0x040031B9 RID: 12729
		public static int _DefaultRecordCount;
	}
}
