using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.MPLConfiguration
{
	// Token: 0x02000539 RID: 1337
	[global::System.Serializable]
	public class MPLConfigurationRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600B208 RID: 45576 RVA: 0x00A55F28 File Offset: 0x00A54128
		public MPLConfigurationRecset() : base(global::CommonResources.AcgResources.ID_MPLCONFIGURATION, global::CommonResources.AcgResources.ID_MPLCONF)
		{
			this.SetValues();
		}

		// Token: 0x0600B209 RID: 45577 RVA: 0x00A55F4C File Offset: 0x00A5414C
		public MPLConfigurationRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x1700593A RID: 22842
		// (get) Token: 0x0600B20A RID: 45578 RVA: 0x00A55F78 File Offset: 0x00A54178
		public override int MaxPool
		{
			get
			{
				short num = (short)1702711259;
				short num2 = num;
				num = (short)1076121563;
				switch (num2 == num)
				{
				}
				num = (short)674496512;
				short num3 = num;
				num = (short)713883648;
				if (num != 0)
				{
				}
				num = (short)1423966209;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationRecset._MaxPool;
			}
		}

		// Token: 0x1700593B RID: 22843
		// (get) Token: 0x0600B20B RID: 45579 RVA: 0x00A56028 File Offset: 0x00A54228
		// (set) Token: 0x0600B20C RID: 45580 RVA: 0x00A560EC File Offset: 0x00A542EC
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)867758838;
					short num2 = num;
					num = (short)387838710;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B0;
					case 1:
						break;
					default:
					{
						num = (short)1131413504;
						short num3 = num;
						break;
					}
					}
					num = (short)1544945664;
					if (num != 0)
					{
					}
					num = (short)1268645889;
					if (num != 0)
					{
					}
					return global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationRecset._Max;
				}
				IL_B0:
				return this._DynMax;
			}
			set
			{
				short num = (short)1414090930;
				short num2 = num;
				num = (short)708464818;
				switch (num2 == num)
				{
				}
				num = (short)1780875264;
				short num3 = num;
				num = (short)1755381760;
				if (num != 0)
				{
				}
				num = (short)1122435073;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x1700593C RID: 22844
		// (get) Token: 0x0600B20D RID: 45581 RVA: 0x00A5619C File Offset: 0x00A5439C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1444111265;
				short num2 = num;
				num = (short)2088919969;
				switch (num2 == num)
				{
				}
				num = (short)1429864448;
				short num3 = num;
				num = (short)1110966272;
				if (num != 0)
				{
				}
				num = (short)1893662721;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700593D RID: 22845
		// (get) Token: 0x0600B20E RID: 45582 RVA: 0x00A5624C File Offset: 0x00A5444C
		// (set) Token: 0x0600B20F RID: 45583 RVA: 0x00A562F8 File Offset: 0x00A544F8
		public override int Min
		{
			get
			{
				short num = (short)107085825;
				if (num != 0)
				{
				}
				num = (short)676391741;
				short num2 = num;
				num = (short)609676093;
				switch (num2 == num)
				{
				default:
				{
					num = (short)828506112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1190002688;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationRecset._Min;
			}
			set
			{
				short num = (short)1600716801;
				if (num != 0)
				{
				}
				num = (short)1255967096;
				short num2 = num;
				num = (short)1000049016;
				switch (num2 == num)
				{
				default:
				{
					num = (short)720044032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1427832832;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationRecset._Min = value;
			}
		}

		// Token: 0x0600B210 RID: 45584 RVA: 0x00A563A8 File Offset: 0x00A545A8
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1491271681;
			if (num != 0)
			{
			}
			num = (short)781185470;
			short num2 = num;
			num = (short)1166537150;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1821638656;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)298385408;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfiguration(this);
		}

		// Token: 0x0600B211 RID: 45585 RVA: 0x00A5645C File Offset: 0x00A5465C
		internal void SetValues()
		{
			int a_ = 4;
			short num = (short)1406997137;
			short num2 = num;
			num = (short)260510353;
			switch (num2 == num)
			{
			}
			num = (short)205783040;
			short num3 = num;
			num = (short)916586497;
			if (num != 0)
			{
			}
			num = (short)99876864;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.Id = 2078;
			base.SingleInstance = false;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("蓄ꯆꗈ跊꣌껎ꗐꛒ꟔닖꫘黜냞賠鏢諤触賨藪駬돮닰鳲鯴臶鳸闺觼雾渀洂搄欆⤈䠊戌愎眐稒爔或欘稚検瘞丠䴢礤樦礨未ബ氮帰崲匴帶常为似帾㕀⩂⩄⥆ᕈيᵌ͎ቐ㱒㭔ㅖじ㱚⡜ⵞ`ᝢ౤ࡦݨ㽪ཬͮ彰୲ᑴ᩶ᕸ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_MPLCONFIGURATION;
			base.KeySeed = global::CommonResources.AcgResources.ID_MPLCONF;
			base.DataTransferOrder = 10;
		}

		// Token: 0x0600B212 RID: 45586 RVA: 0x00A56558 File Offset: 0x00A54758
		// Note: this type is marked as 'beforefieldinit'.
		static MPLConfigurationRecset()
		{
			short num = (short)1062771529;
			short num2 = num;
			num = (short)1418959689;
			switch (num2 == num)
			{
			}
			num = (short)1626341376;
			short num3 = num;
			num = (short)1204355072;
			if (num != 0)
			{
			}
			num = (short)205193217;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationRecset._Min = 1;
		}

		// Token: 0x04005789 RID: 22409
		public static int _MaxPool;

		// Token: 0x0400578A RID: 22410
		public static int _Max;

		// Token: 0x0400578B RID: 22411
		public int _DynMax;

		// Token: 0x0400578C RID: 22412
		public static int _Min;
	}
}
