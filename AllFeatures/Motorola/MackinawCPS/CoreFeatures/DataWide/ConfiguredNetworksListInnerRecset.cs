using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004C4 RID: 1220
	[global::System.Serializable]
	public class ConfiguredNetworksListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600A023 RID: 40995 RVA: 0x00955C78 File Offset: 0x00953E78
		public ConfiguredNetworksListInnerRecset() : base(global::CommonResources.AcgResources.ID_CONFIGUREDNETWORKSLIST)
		{
			this.SetValues();
		}

		// Token: 0x0600A024 RID: 40996 RVA: 0x00955C98 File Offset: 0x00953E98
		public ConfiguredNetworksListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17005056 RID: 20566
		// (get) Token: 0x0600A025 RID: 40997 RVA: 0x00955CC4 File Offset: 0x00953EC4
		public override int MaxPool
		{
			get
			{
				short num = (short)642757478;
				short num2 = num;
				num = (short)503034726;
				switch (num2 == num)
				{
				}
				num = (short)247529472;
				short num3 = num;
				num = (short)1195311104;
				if (num != 0)
				{
				}
				num = (short)1368129537;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17005057 RID: 20567
		// (get) Token: 0x0600A026 RID: 40998 RVA: 0x00955D78 File Offset: 0x00953F78
		// (set) Token: 0x0600A027 RID: 40999 RVA: 0x00955E3C File Offset: 0x0095403C
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)571106634;
					short num2 = num;
					num = (short)264463690;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1736376320;
						if (num != 0)
						{
						}
						num = (short)1546911744;
						short num3 = num;
						num = (short)686161921;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset._Max;
					}
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1000057252;
				short num2 = num;
				num = (short)590916004;
				switch (num2 == num)
				{
				}
				num = (short)1207566336;
				short num3 = num;
				num = (short)1154285569;
				if (num != 0)
				{
				}
				num = (short)1018560512;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17005058 RID: 20568
		// (get) Token: 0x0600A028 RID: 41000 RVA: 0x00955EEC File Offset: 0x009540EC
		public override int Min
		{
			get
			{
				short num = (short)79521986;
				short num2 = num;
				num = (short)983132354;
				switch (num2 == num)
				{
				}
				num = (short)1692336128;
				short num3 = num;
				num = (short)1223557121;
				if (num != 0)
				{
				}
				num = (short)1836777472;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset._Min;
			}
		}

		// Token: 0x17005059 RID: 20569
		// (get) Token: 0x0600A029 RID: 41001 RVA: 0x00955F9C File Offset: 0x0095419C
		// (set) Token: 0x0600A02A RID: 41002 RVA: 0x0095604C File Offset: 0x0095424C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1708130305;
				if (num != 0)
				{
				}
				num = (short)92621922;
				short num2 = num;
				num = (short)19287138;
				switch (num2 == num)
				{
				default:
				{
					num = (short)806617088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)789839872;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1732372703;
				short num2 = num;
				num = (short)371189983;
				switch (num2 == num)
				{
				}
				num = (short)1111818240;
				short num3 = num;
				num = (short)1599864833;
				if (num != 0)
				{
				}
				num = (short)1358036992;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700505A RID: 20570
		// (get) Token: 0x0600A02B RID: 41003 RVA: 0x009560F8 File Offset: 0x009542F8
		public bool HasDiffs
		{
			get
			{
				short num = (short)12799914;
				short num2 = num;
				num = (short)1439453098;
				switch (num2 == num)
				{
				}
				num = (short)243793920;
				short num3 = num;
				num = (short)1243742209;
				if (num != 0)
				{
				}
				num = (short)1272905728;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600A02C RID: 41004 RVA: 0x009561A8 File Offset: 0x009543A8
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1372979201;
			if (num != 0)
			{
			}
			num = (short)2093613056;
			short num2 = num;
			num = (short)204034351;
			short num3 = num;
			num = (short)1179734319;
			switch (num3 == num)
			{
			}
			num = (short)1866334208;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner(this);
		}

		// Token: 0x0600A02D RID: 41005 RVA: 0x00956254 File Offset: 0x00954454
		internal void SetValues()
		{
			short num = (short)533200575;
			short num2 = num;
			num = (short)82640575;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1161232384;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)583073792;
			if (num != 0)
			{
			}
			num = (short)2016018433;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_CONFIGUREDNETWORKSLIST;
			base.DataTransferOrder = 13;
		}

		// Token: 0x0600A02E RID: 41006 RVA: 0x00956320 File Offset: 0x00954520
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)340328449;
			if (num != 0)
			{
			}
			num = (short)958398464;
			short num2 = num;
			num = (short)868206250;
			short num3 = num;
			num = (short)308463274;
			switch (num3 == num)
			{
			}
			num = (short)1535967232;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord();
			this.c(record);
		}

		// Token: 0x0600A02F RID: 41007 RVA: 0x009563D8 File Offset: 0x009545D8
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1995138617;
			short num2 = num;
			num = (short)927163961;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2014183424;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1704394753;
			if (num != 0)
			{
			}
			num = (short)109379584;
			if (num != 0)
			{
			}
			base.OnFinishedRemoveRecord();
			this.b(record);
		}

		// Token: 0x0600A030 RID: 41008 RVA: 0x0095648C File Offset: 0x0095468C
		private void c(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1250901263;
			short num2 = num;
			num = (short)324680975;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1104412672;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1031536641;
			if (num != 0)
			{
			}
			num = (short)839254016;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x0600A031 RID: 41009 RVA: 0x0095653C File Offset: 0x0095473C
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)60493769;
			short num2 = num;
			num = (short)1787170761;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1099759616;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1392902145;
			if (num != 0)
			{
			}
			num = (short)1827799040;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x0600A032 RID: 41010 RVA: 0x009565F0 File Offset: 0x009547F0
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1789919236;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)209387521;
					if (num != 0)
					{
					}
					num = (short)1772109025;
					short num3 = num;
					num = (short)1942699233;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1931673600;
						if (num != 0)
						{
						}
						num = (short)56688645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (!global::AcpCommonLib.ConstraintManager.Suspended)
					{
						num = (short)1785397248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					goto IL_2A4;
				case 3:
					num = (short)1413349377;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 5:
				{
					if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
					{
						num = (short)1134231554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (A_0.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset).GetEnumerator();
					num = (short)1583284230;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					goto IL_2D2;
				}
				IL_41:
				if (global::AcpCommonLib.AppInfoManager.UnpackOperation)
				{
					break;
				}
				num = (short)1087438851;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_2A4:
			return;
			IL_2D2:
			num = (short)704839680;
			short num4 = num;
			try
			{
				num = (short)1312948228;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 1:
						num = (short)77266950;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner;
						configuredNetworksListInner.ConfiguredNetworksListInnerSection.DataWideWiFiNetworkSSID_42519.CalculateValidity();
						num = (short)1823932416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)1503526913;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner;
						num = (short)695861253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_A5;
						}
						continue;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner;
						if (configuredNetworksListInner != null)
						{
							num = (short)1878261762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						goto IL_158;
					}
					IL_A7:
					num = (short)870055939;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A5:
					goto IL_A7;
				}
				IL_158:
				return;
			}
			finally
			{
				num = (short)801570816;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_18D;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)306774018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1C1;
					}
					IL_18D:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1695875073;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1C1:;
			}
		}

		// Token: 0x0600A033 RID: 41011 RVA: 0x00956910 File Offset: 0x00954B10
		// Note: this type is marked as 'beforefieldinit'.
		static ConfiguredNetworksListInnerRecset()
		{
			short num = (short)699171537;
			short num2 = num;
			num = (short)1535738577;
			switch (num2 == num)
			{
			default:
			{
				num = (short)542834688;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)658243585;
			if (num != 0)
			{
			}
			num = (short)1727004672;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset._Min = 1;
		}

		// Token: 0x04004DF7 RID: 19959
		public static int _MaxPool;

		// Token: 0x04004DF8 RID: 19960
		public static int _Max;

		// Token: 0x04004DF9 RID: 19961
		public int _DynMax;

		// Token: 0x04004DFA RID: 19962
		public static int _Min;

		// Token: 0x04004DFB RID: 19963
		public static int _DefaultRecordCount;
	}
}
