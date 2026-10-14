using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide
{
	// Token: 0x0200023E RID: 574
	[global::System.Serializable]
	public class PresetZoneAndChannelTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600679F RID: 26527 RVA: 0x005C8F88 File Offset: 0x005C7188
		public PresetZoneAndChannelTableInnerRecset() : base(global::CommonResources.AcgResources.ID_PRESETZONEANDCHANNELTABLE)
		{
			this.SetValues();
		}

		// Token: 0x060067A0 RID: 26528 RVA: 0x005C8FA8 File Offset: 0x005C71A8
		public PresetZoneAndChannelTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170035C9 RID: 13769
		// (get) Token: 0x060067A1 RID: 26529 RVA: 0x005C8FD4 File Offset: 0x005C71D4
		public override int MaxPool
		{
			get
			{
				short num = (short)1005072424;
				short num2 = num;
				num = (short)320221224;
				switch (num2 == num)
				{
				}
				num = (short)2055733248;
				short num3 = num;
				num = (short)927334401;
				if (num != 0)
				{
				}
				num = (short)1649737728;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x170035CA RID: 13770
		// (get) Token: 0x060067A2 RID: 26530 RVA: 0x005C9084 File Offset: 0x005C7284
		// (set) Token: 0x060067A3 RID: 26531 RVA: 0x005C9148 File Offset: 0x005C7348
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)727414909;
					short num2 = num;
					num = (short)440957053;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1980432384;
						short num3 = num;
						num = (short)623509505;
						if (num != 0)
						{
						}
						num = (short)1110179840;
						if (num != 0)
						{
						}
						break;
					}
					}
					return global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerRecset._Max;
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1437611003;
				short num2 = num;
				num = (short)1382233083;
				switch (num2 == num)
				{
				}
				num = (short)1485307904;
				short num3 = num;
				num = (short)395902977;
				if (num != 0)
				{
				}
				num = (short)852164608;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x170035CB RID: 13771
		// (get) Token: 0x060067A4 RID: 26532 RVA: 0x005C91F8 File Offset: 0x005C73F8
		public override int Min
		{
			get
			{
				short num = (short)1620912790;
				short num2 = num;
				num = (short)1631136406;
				switch (num2 == num)
				{
				}
				num = (short)1606746112;
				short num3 = num;
				num = (short)168558592;
				if (num != 0)
				{
				}
				num = (short)2114781185;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerRecset._Min;
			}
		}

		// Token: 0x170035CC RID: 13772
		// (get) Token: 0x060067A5 RID: 26533 RVA: 0x005C92A8 File Offset: 0x005C74A8
		// (set) Token: 0x060067A6 RID: 26534 RVA: 0x005C9358 File Offset: 0x005C7558
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)685100086;
				short num2 = num;
				num = (short)1651166262;
				switch (num2 == num)
				{
				}
				num = (short)1434058752;
				short num3 = num;
				num = (short)1158610944;
				if (num != 0)
				{
				}
				num = (short)462815233;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)402649878;
				short num2 = num;
				num = (short)944304918;
				switch (num2 == num)
				{
				}
				num = (short)612171776;
				short num3 = num;
				num = (short)601292801;
				if (num != 0)
				{
				}
				num = (short)387776512;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170035CD RID: 13773
		// (get) Token: 0x060067A7 RID: 26535 RVA: 0x005C9408 File Offset: 0x005C7608
		public bool HasDiffs
		{
			get
			{
				short num = (short)191954945;
				if (num != 0)
				{
				}
				num = (short)962785788;
				short num2 = num;
				num = (short)153022972;
				switch (num2 == num)
				{
				default:
				{
					num = (short)891944960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)893845504;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060067A8 RID: 26536 RVA: 0x005C94B4 File Offset: 0x005C76B4
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)539170256;
			short num2 = num;
			num = (short)893261264;
			switch (num2 == num)
			{
			}
			num = (short)943390720;
			short num3 = num;
			num = (short)781320193;
			if (num != 0)
			{
			}
			num = (short)966918144;
			if (num != 0)
			{
			}
			global::AcpBusinessLayer.FeatureNode featureNode = new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInner(this);
			this.a(featureNode);
			return featureNode;
		}

		// Token: 0x060067A9 RID: 26537 RVA: 0x005C956C File Offset: 0x005C776C
		internal void SetValues()
		{
			short num = (short)1003061323;
			short num2 = num;
			num = (short)2104328267;
			switch (num2 == num)
			{
			}
			num = (short)2002518016;
			short num3 = num;
			num = (short)717225985;
			if (num != 0)
			{
			}
			num = (short)2101936128;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_PRESETZONEANDCHANNELTABLE;
			base.DataTransferOrder = 3;
		}

		// Token: 0x060067AA RID: 26538 RVA: 0x005C9638 File Offset: 0x005C7838
		private void a(global::AcpBusinessLayer.FeatureNode A_0)
		{
			short num = (short)2125070336;
			switch (num)
			{
			default:
			{
				num = (short)983433221;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerSection presetZoneAndChannelTableInnerSection;
					string value;
					global::AcpBusinessLayer.AcpField<string> presetModeSelect;
					global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerSection presetZoneAndChannelTableInnerSection2;
					switch (num2)
					{
					case 0:
						value = presetZoneAndChannelTableInnerSection.PresetModeSelect.Value;
						num = (short)379584537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_2B4;
					case 2:
						goto IL_2B4;
					case 3:
						if (!global::AcpCommonLib.AppInfoManager.UndoRedoInProgress)
						{
							num = (short)51576841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)1381957643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1080623123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_B3;
						}
						continue;
					case 6:
						goto IL_2B4;
					case 7:
						goto IL_2B4;
					case 8:
						goto IL_2B4;
					case 9:
						num = (short)975437828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_2B4;
					case 11:
						goto IL_316;
					case 12:
					{
						presetModeSelect = presetZoneAndChannelTableInnerSection.PresetModeSelect;
						int count = base.Count;
						num = (short)1736900634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_2B4;
					case 14:
						goto IL_2B4;
					case 15:
						goto IL_2D4;
					case 16:
						goto IL_2B4;
					case 17:
						goto IL_2B4;
					case 18:
					{
						num = (short)1164181504;
						short num3 = num;
						if (presetZoneAndChannelTableInnerSection != null)
						{
							num = (short)1450639372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInner presetZoneAndChannelTableInner = A_0 as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInner;
						if (presetZoneAndChannelTableInner == null)
						{
							num = (short)1835030;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						presetZoneAndChannelTableInnerSection2 = presetZoneAndChannelTableInner.PresetZoneAndChannelTableInnerSection;
						goto IL_4A8;
					}
					case 20:
						goto IL_2B4;
					case 21:
						num = (short)1597833217;
						if (num != 0)
						{
						}
						goto IL_2B4;
					case 22:
						presetZoneAndChannelTableInnerSection2 = null;
						goto IL_4A8;
					case 23:
						num = (short)1238892547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						num = (short)404029440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_2B4;
					case 26:
					{
						int count;
						switch (count)
						{
						case 0:
							value = global::CommonResources.AcgResources.ID_MS01;
							num = (short)1164378132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							value = global::CommonResources.AcgResources.ID_MS02;
							num = (short)1132331014;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							value = global::CommonResources.AcgResources.ID_MS03;
							num = (short)1020854288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							value = global::CommonResources.AcgResources.ID_MS04;
							num = (short)1781989378;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							value = global::CommonResources.AcgResources.ID_MS05;
							num = (short)169148426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							value = global::CommonResources.AcgResources.ID_MS06;
							num = (short)1469345242;
							short num4 = num;
							num = (short)1582853594;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)413925376;
								if (num != 0)
								{
								}
								num = (short)763297805;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							value = global::CommonResources.AcgResources.ID_MS07;
							num = (short)572325895;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							value = global::CommonResources.AcgResources.ID_MS08;
							num = (short)984940561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							value = global::CommonResources.AcgResources.ID_MS09;
							num = (short)1288175637;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							value = global::CommonResources.AcgResources.ID_MS10;
							num = (short)88080385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							break;
						case 11:
							value = global::CommonResources.AcgResources.ID_MS12;
							num = (short)1801650203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							value = global::CommonResources.AcgResources.ID_MS13;
							num = (short)2116681736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)84344856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						value = global::CommonResources.AcgResources.ID_MS11;
						num = (short)1305542670;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						goto IL_2B4;
					}
					IL_B3:
					if (A_0 != null)
					{
						num = (short)520421399;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_2B4:
					presetModeSelect.Value = value;
					num = (short)2134441999;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A8:
					presetZoneAndChannelTableInnerSection = presetZoneAndChannelTableInnerSection2;
					num = (short)1333592082;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_2D4:
				return;
				IL_316:
				return;
			}
			}
		}

		// Token: 0x060067AB RID: 26539 RVA: 0x005C9B7C File Offset: 0x005C7D7C
		// Note: this type is marked as 'beforefieldinit'.
		static PresetZoneAndChannelTableInnerRecset()
		{
			short num = (short)1804352113;
			short num2 = num;
			num = (short)929446513;
			switch (num2 == num)
			{
			}
			num = (short)1448542208;
			short num3 = num;
			num = (short)1945370625;
			if (num != 0)
			{
			}
			num = (short)640745472;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerRecset._Min = 1;
		}

		// Token: 0x040026BA RID: 9914
		public static int _MaxPool;

		// Token: 0x040026BB RID: 9915
		public static int _Max;

		// Token: 0x040026BC RID: 9916
		public int _DynMax;

		// Token: 0x040026BD RID: 9917
		public static int _Min;

		// Token: 0x040026BE RID: 9918
		public static int _DefaultRecordCount;
	}
}
