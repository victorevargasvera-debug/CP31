using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment
{
	// Token: 0x0200004D RID: 77
	[global::System.Serializable]
	public class ZoneChannelAssignmentRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060003CC RID: 972 RVA: 0x00045694 File Offset: 0x00043894
		public ZoneChannelAssignmentRecset() : base(global::CommonResources.AcgResources.ID_ZONECHANNELASSIGNMENT, global::CommonResources.AcgResources.ID_ZONE)
		{
			this.SetValues();
		}

		// Token: 0x060003CD RID: 973 RVA: 0x000456B8 File Offset: 0x000438B8
		public ZoneChannelAssignmentRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060003CE RID: 974 RVA: 0x000456E4 File Offset: 0x000438E4
		public override int MaxPool
		{
			get
			{
				short num = (short)421338687;
				short num2 = num;
				num = (short)1564614207;
				switch (num2 == num)
				{
				}
				num = (short)1629749249;
				if (num != 0)
				{
				}
				num = (short)1897332736;
				if (num != 0)
				{
				}
				num = (short)1222901760;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset._MaxPool;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060003CF RID: 975 RVA: 0x00045794 File Offset: 0x00043994
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x00045858 File Offset: 0x00043A58
		public override int Max
		{
			get
			{
				short num = (short)371916800;
				short num2 = num;
				num = (short)27904163;
				short num3 = num;
				num = (short)1258670243;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1607401472;
					if (num != 0)
					{
					}
					num = (short)1637154817;
					if (num != 0)
					{
					}
					if (this._DynMax != -1)
					{
						return this._DynMax;
					}
					break;
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset._Max;
			}
			set
			{
				short num = (short)2112661046;
				short num2 = num;
				num = (short)2092738102;
				switch (num2 == num)
				{
				}
				num = (short)1540620288;
				if (num != 0)
				{
				}
				num = (short)1498021889;
				if (num != 0)
				{
				}
				num = (short)1120075776;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x0004590C File Offset: 0x00043B0C
		public bool HasDiffs
		{
			get
			{
				short num = (short)342594831;
				short num2 = num;
				num = (short)2135856399;
				switch (num2 == num)
				{
				}
				num = (short)1813315585;
				if (num != 0)
				{
				}
				num = (short)2037055488;
				if (num != 0)
				{
				}
				num = (short)1569521664;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x000459BC File Offset: 0x00043BBC
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00045A68 File Offset: 0x00043C68
		public override int Min
		{
			get
			{
				short num = (short)1850630520;
				short num2 = num;
				num = (short)206463352;
				switch (num2 == num)
				{
				}
				num = (short)788267008;
				if (num != 0)
				{
				}
				num = (short)1428881409;
				if (num != 0)
				{
				}
				num = (short)928120832;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset._Min;
			}
			set
			{
				short num = (short)580208423;
				short num2 = num;
				num = (short)1805862695;
				switch (num2 == num)
				{
				}
				num = (short)1228996609;
				if (num != 0)
				{
				}
				num = (short)881459200;
				if (num != 0)
				{
				}
				num = (short)677904384;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset._Min = value;
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00045B18 File Offset: 0x00043D18
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)344637917;
			short num2 = num;
			num = (short)148226525;
			switch (num2 == num)
			{
			}
			num = (short)1860435968;
			if (num != 0)
			{
			}
			num = (short)1810104321;
			if (num != 0)
			{
			}
			num = (short)1808400384;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment(this);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00045BC8 File Offset: 0x00043DC8
		internal void SetValues()
		{
			int a_ = 17;
			short num = (short)1300844727;
			short num2 = num;
			num = (short)1670860983;
			switch (num2 == num)
			{
			}
			num = (short)1998979073;
			if (num != 0)
			{
			}
			num = (short)1877606400;
			if (num != 0)
			{
			}
			num = (short)1827405824;
			short num3 = num;
			this._DynMax = -1;
			base.Id = 2051;
			base.SingleInstance = false;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("鏑룓뫕黗뿙뷛ꫝ闟郡臣闥폧ꧩ菫菭胯鷱髳鏵雷軹ꃻꓽ濿氁愃★䬇戉洋怍縏眑砓㘕夗椙漛眝䜟䰡䤣䌥䘧帩瀫琭弯就儳电倷嬹刻倽┿⹁Ճ㕅㭇⍉⭋⁍㵏㝑㩓≕౗㡙せ灝ᡟ͡ॣ੥", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ZONECHANNELASSIGNMENT;
			base.KeySeed = global::CommonResources.AcgResources.ID_ZONE;
			base.DataTransferOrder = 46;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00045CC4 File Offset: 0x00043EC4
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)720527753;
			short num2 = num;
			num = (short)1490575753;
			switch (num2 == num)
			{
			}
			num = (short)448069633;
			if (num != 0)
			{
			}
			num = (short)1218379776;
			if (num != 0)
			{
			}
			num = (short)258670592;
			short num3 = num;
			base.OnFinishedAddRecord(record);
			this.i(record);
			this.j(record);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00045D80 File Offset: 0x00043F80
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1248263596;
			short num2 = num;
			num = (short)1313078700;
			switch (num2 == num)
			{
			}
			num = (short)1533542401;
			if (num != 0)
			{
			}
			num = (short)851968000;
			if (num != 0)
			{
			}
			num = (short)1115881472;
			short num3 = num;
			base.OnFinishedRemoveRecord(record);
			this.h(record);
			this.j(record);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00045E40 File Offset: 0x00044040
		protected override void OnFinishedMoveRecord(global::AcpCommonLib.IAcpFeatureNode record, global::AcpCommonLib.IAcpFeatureNode targetRecord)
		{
			short num = (short)1951802446;
			short num2 = num;
			num = (short)867771470;
			switch (num2 == num)
			{
			}
			num = (short)1569718273;
			if (num != 0)
			{
			}
			num = (short)995295232;
			if (num != 0)
			{
			}
			num = (short)1334837248;
			short num3 = num;
			base.OnFinishedMoveRecord();
			this.b(record, targetRecord);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00045EF8 File Offset: 0x000440F8
		private void j(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1036687265;
			short num2 = num;
			num = (short)2024970145;
			switch (num2 == num)
			{
			}
			num = (short)2074869760;
			if (num != 0)
			{
			}
			num = (short)1384120321;
			if (num != 0)
			{
			}
			num = (short)708378624;
			short num3 = num;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00045FA0 File Offset: 0x000441A0
		private void i(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)311270989;
			short num2 = num;
			num = (short)1641979469;
			switch (num2 == num)
			{
			}
			num = (short)2102001665;
			if (num != 0)
			{
			}
			num = (short)1420492800;
			if (num != 0)
			{
			}
			num = (short)87621632;
			short num3 = num;
			this.f(A_0);
			this.e(A_0);
			this.a(A_0);
			this.c(A_0);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00046064 File Offset: 0x00044264
		private void h(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)447625252;
			short num2 = num;
			num = (short)924465188;
			switch (num2 == num)
			{
			}
			num = (short)1783103488;
			if (num != 0)
			{
			}
			num = (short)279052289;
			if (num != 0)
			{
			}
			num = (short)1852375040;
			short num3 = num;
			this.g(A_0);
			this.f(A_0);
			this.e(A_0);
			this.d(A_0);
			this.b(A_0);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00046134 File Offset: 0x00044334
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0, global::AcpCommonLib.IAcpFeatureNode A_1)
		{
			short num = (short)1844912737;
			short num2 = num;
			num = (short)964371041;
			switch (num2 == num)
			{
			}
			num = (short)1315635201;
			if (num != 0)
			{
			}
			num = (short)735772672;
			if (num != 0)
			{
			}
			num = (short)568000512;
			short num3 = num;
			this.a(A_0, A_1);
		}

		// Token: 0x060003DD RID: 989 RVA: 0x000461E8 File Offset: 0x000443E8
		private void g(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1654521856;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1716387840;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_73;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideRecset radioErgonomicsWideRecset;
				for (;;)
				{
					IL_50:
					global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerRecset presetZoneAndChannelTableInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
					switch (num2)
					{
					case 0:
					{
						if (presetZoneAndChannelTableInnerRecset == null)
						{
							num = (short)2059141125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = presetZoneAndChannelTableInnerRecset.GetEnumerator();
						num = (short)1428291586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						if (radioErgonomicsWideRecset != null)
						{
							radioErgonomicsWide = (radioErgonomicsWideRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide);
							num = (short)1205207044;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1857926250;
						short num4 = num;
						num = (short)2003022954;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_396;
						default:
							num = (short)1539768320;
							if (num != 0)
							{
							}
							num = (short)1250230275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						try
						{
							num = (short)1385955329;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
									num = (short)1835925511;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1BC;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)112459782;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInner presetZoneAndChannelTableInner = (global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInner)enumerator.Current;
									num = (short)1764360195;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInner presetZoneAndChannelTableInner;
									if (presetZoneAndChannelTableInner.PresetZoneAndChannelTableInnerSection.LabtoolPresetZone_A41079.UIValue == presetZoneAndChannelTableInner.PresetZoneAndChannelTableInnerSection.LabtoolPresetZone_A41079.InvalidText)
									{
										num = (short)1522401285;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_2F0;
								case 5:
									num = (short)1426456584;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)899809284;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									bool flag = global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
									global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInner presetZoneAndChannelTableInner;
									presetZoneAndChannelTableInner.PresetZoneAndChannelTableInnerSection.LabtoolPresetZone_A41079.UIValue = global::CommonResources.AppResources._Unassigned_;
									if (flag)
									{
										num = (short)562167808;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_224:
								num = (short)1110769666;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1BC:
								goto IL_224;
							}
							IL_2F0:
							return;
						}
						finally
						{
							num = (short)829095937;
							if (num != 0)
							{
							}
							num = (short)441712640;
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
										goto IL_34D;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)2109210626;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_382;
								}
								IL_34D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)689963009;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_382:;
						}
						goto IL_385;
					case 3:
						return;
					case 4:
						if (radioErgonomicsWide == null)
						{
							num = (short)544473094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_385;
					case 5:
						return;
					case 6:
						return;
					}
					goto IL_73;
					IL_396:
					num = (short)1749286912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_385:
					presetZoneAndChannelTableInnerRecset = (radioErgonomicsWide.PresetZoneAndChannel.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerRecset);
					goto IL_396;
				}
				return;
				IL_73:
				radioErgonomicsWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2033) as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideRecset);
				num = (short)1664352257;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x000465E4 File Offset: 0x000447E4
		private void f(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_5C;
			}
			short num;
			int num3;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
			for (;;)
			{
				IL_0A:
				num = (short)573243392;
				short num2 = num;
				switch (num3)
				{
				case 0:
				{
					num = (short)598739412;
					short num4 = num;
					num = (short)57543124;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_81;
					default:
						num = (short)866254848;
						if (num != 0)
						{
						}
						num = (short)1387593729;
						if (num != 0)
						{
						}
						num = (short)1763966982;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (!global::AcpCommonLib.ConstraintManager.Suspended)
					{
						goto IL_81;
					}
					return;
				case 2:
					zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.CallConstraints();
					num = (short)251658244;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1923874824;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return;
				case 5:
					if (zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257 != null)
					{
						num = (short)1298989058;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					if (zoneChannelAssignment.Zone != null)
					{
						num = (short)2051080199;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					num = (short)592117765;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (zoneChannelAssignment != null)
					{
						num = (short)678756352;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_5C;
				IL_81:
				num = (short)730791939;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_5C:
			zoneChannelAssignment = (A_0 as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
			num = (short)1892876289;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x000467E8 File Offset: 0x000449E8
		private void e(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1427439616;
			switch (num)
			{
			default:
			{
				num = (short)864813061;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
					bool value;
					switch (num2)
					{
					case 0:
						if (radioWideRecset != null)
						{
							num = (short)379781134;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = zoneChannelAssignmentRecset.GetEnumerator();
						num = (short)1423310866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_1D5;
					case 3:
						num = (short)272105478;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide.Labtool.RadWideLabtoolDynamicZoneCable_A41258 != null)
						{
							num = (short)1302790156;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_93;
						}
						continue;
					case 6:
						if (!global::AcpCommonLib.ConstraintManager.Suspended)
						{
							num = (short)526581775;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide != null)
						{
							num = (short)2094727168;
							short num3 = num;
							num = (short)1169424392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 8:
						num = (short)1567490067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						return;
					case 10:
					{
						num = (short)1215889409;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = radioWideRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						num = (short)773128199;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)1749680132;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						radioWide.Labtool.RadWideLabtoolDynamicZoneCable_A41258.SetValue(value);
						num = (short)1397161993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (radioWideRecset.Count > 0)
						{
							num = (short)1624244234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 14:
						num = (short)1910243341;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)649789456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
						{
							num = (short)1660813314;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F0;
					case 17:
						if (zoneChannelAssignmentRecset != null)
						{
							num = (short)770572289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_57F;
					case 18:
						try
						{
							num = (short)602537985;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)1011314868;
									short num4 = num;
									num = (short)970682548;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_37E;
									default:
									{
										num = (short)613416960;
										if (num != 0)
										{
										}
										global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
										if (zoneChannelAssignment.Zone != null)
										{
											num = (short)179109893;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2A8;
									}
									continue;
								case 2:
									num = (short)1381302280;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									value = true;
									num = (short)166461447;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
									if (zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257 != null)
									{
										num = (short)193724418;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_37E;
								case 6:
									num = (short)386859008;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_417;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
									if (zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
									{
										num = (short)75825155;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
									if (zoneChannelAssignment != null)
									{
										num = (short)2092630022;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1690304524;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment)enumerator.Current;
									num = (short)34209801;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									goto IL_47E;
								case 12:
									num = (short)421265419;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2A8;
								IL_37E:
								num = (short)297926660;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3BF:
								num = (short)17039370;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2A8:
								goto IL_3BF;
							}
							IL_417:
							IL_47E:
							goto IL_57F;
						}
						finally
						{
							num = (short)611975170;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)438370305;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_4ED;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_4B6;
									}
									continue;
								}
								IL_4B6:
								if (enumerator == null)
								{
									break;
								}
								num = (short)28180480;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4ED:;
						}
						goto IL_4F0;
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide.Labtool != null)
						{
							num = (short)1125253131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					IL_93:
					if (!global::AcpCommonLib.AppInfoManager.UnpackOperation)
					{
						num = (short)1507524611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_4F0:
					value = false;
					zoneChannelAssignmentRecset = ((A_0 as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset);
					num = (short)307691537;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_57F:
					radioWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset);
					num = (short)1856438272;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_1D5:
				return;
			}
			}
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00046E48 File Offset: 0x00045048
		private void d(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)379453440;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_60;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
				for (;;)
				{
					IL_27:
					num = (short)1757478913;
					if (num != 0)
					{
					}
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
					switch (num2)
					{
					case 0:
					{
						num = (short)1832845312;
						short num3 = num;
						goto IL_553;
					}
					case 1:
						try
						{
							num = (short)1606483978;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)144965633;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
									if (zoneChannelAssignment.Channels.EmbeddedRecset != null)
									{
										num = (short)810680327;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									try
									{
										num = (short)853213194;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
												channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630.CalculateValidity();
												num = (short)1769865218;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
												if (channelAssignmentListInner.ChannelAssignmentListInnerSection != null)
												{
													num = (short)1356005383;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 3:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)1993146373;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner)enumerator.Current;
												num = (short)1076887553;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
												if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630 != null)
												{
													num = (short)1391132681;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 5:
												num = (short)1979711494;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
												goto IL_319;
											case 7:
												num = (short)1678245892;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 8:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
												if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630.Value != 0)
												{
													num = (short)54394880;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 9:
												num = (short)644743176;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 10:
												switch (0)
												{
												case 0:
													goto IL_1BE;
												}
												continue;
											}
											IL_1C0:
											num = (short)1519779843;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1BE:
											goto IL_1C0;
										}
										IL_319:;
									}
									finally
									{
										num = (short)959315970;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
											switch (num2)
											{
											case 0:
												enumerator.Dispose();
												num = (short)1683619841;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_385;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_34D;
												}
												continue;
											}
											IL_34D:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1850540032;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_385:;
									}
									break;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
									if (zoneChannelAssignment != null)
									{
										num = (short)23986181;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)256245769;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = enumerator2.Current as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
									num = (short)900792323;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)1220149256;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_491;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (zoneChannelAssignment.Channels.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset).GetEnumerator();
									num = (short)1712783362;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
									if (zoneChannelAssignment.Channels != null)
									{
										num = (short)1988755456;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									num = (short)21561350;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									switch (0)
									{
									case 0:
										goto IL_125;
									}
									continue;
								}
								IL_388:
								num = (short)1997668356;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_125:
								goto IL_388;
							}
							IL_491:
							return;
						}
						finally
						{
							num = (short)1829306370;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									enumerator2.Dispose();
									num = (short)1208984197;
									short num4 = num;
									num = (short)251699845;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)282984448;
										if (num != 0)
										{
										}
										num = (short)1571815425;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_550;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_4C8;
									}
									continue;
								}
								IL_4C8:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)362283008;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_550:;
						}
						goto IL_553;
					case 2:
						if (zoneChannelAssignmentRecset != null)
						{
							num = (short)1065353216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_60;
					IL_553:
					enumerator2 = zoneChannelAssignmentRecset.GetEnumerator();
					num = (short)2107441153;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_60:
				zoneChannelAssignmentRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset);
				num = (short)761987074;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00047400 File Offset: 0x00045600
		private void c(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)125698048;
			switch (num)
			{
			default:
			{
				num = (short)1464401922;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)320536576;
					short num3 = num;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						try
						{
							num = (short)1040056322;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
								int num6;
								int num7;
								int num8;
								int num9;
								int num10;
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.List<int> list;
									int num4;
									if (!list.Contains(num4))
									{
										num = (short)382730262;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num4++;
									num = (short)1443758098;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_53B;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1CD;
									}
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
									if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630 != null)
									{
										num = (short)365625374;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9B0;
								}
								case 4:
									num = (short)441450547;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)1979842626;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_348;
								case 7:
								{
									bool flag = false;
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
									int num4 = channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630.Value;
									num = (short)922026049;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_386;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
									if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630.Value != 0)
									{
										num = (short)180486151;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9B0;
								}
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2;
									if (zoneChannelAssignment != zoneChannelAssignment2)
									{
										num = (short)49610799;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_872;
								}
								case 11:
								{
									num = (short)509604738;
									short num5 = num;
									num = (short)715518850;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_4E7;
									default:
										num = (short)1097334784;
										if (num != 0)
										{
										}
										if (!global::AcpCommonLib.AppInfoManager.UndoRedoInProgress)
										{
											num = (short)866058294;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_B79;
									}
									break;
								}
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2;
									if (channelAssignmentListInner2 != null)
									{
										num = (short)1759838250;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3D3;
								}
								case 13:
									if (radioInformation.Labtool.RadInfoLabtoolQ445FiregroundSupport_A8796 != null)
									{
										num = (short)256638980;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A23;
								case 14:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
									if (zoneChannelAssignment != null)
									{
										num = (short)629211171;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_872;
								}
								case 15:
								{
									int value;
									if (value != 0)
									{
										num = (short)1061683219;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3D3;
								}
								case 16:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2;
									int value = channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630.Value;
									num = (short)912850959;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 17:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
									if (num6 >= zoneChannelAssignment.Channels.EmbeddedRecset.Count)
									{
										num = (short)2042560549;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2 = zoneChannelAssignment.Channels.EmbeddedRecset[num6] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
									num = (short)1848049676;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 18:
									goto IL_A68;
								case 19:
									num = (short)1308033083;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									goto IL_9D4;
								case 21:
									goto IL_3D3;
								case 22:
								{
									int num4;
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
									channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630.Value = num4;
									global::System.Collections.Generic.List<int> list;
									list.Add(num4);
									bool flag = true;
									num = (short)1456078875;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 23:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2;
									if (num7 >= zoneChannelAssignment2.Channels.EmbeddedRecset.Count)
									{
										num = (short)614072373;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = zoneChannelAssignment2.Channels.EmbeddedRecset[num7] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
									num = (short)1280901146;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 24:
									num = (short)129892391;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
									goto IL_4E7;
								case 26:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
									if (channelAssignmentListInner != null)
									{
										num = (short)273023007;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9B0;
								}
								case 27:
									goto IL_53B;
								case 28:
									if (!global::AcpCommonLib.AppInfoManager.BackgroundDeserializeOpertaion)
									{
										num = (short)1156907053;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B79;
								case 29:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2;
									if (channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630 != null)
									{
										num = (short)1485307920;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3D3;
								}
								case 30:
									num = (short)249298953;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 31:
									num = (short)2003828739;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 32:
									goto IL_40F;
								case 33:
									num7 = 0;
									num = (short)1276837896;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 34:
								{
									bool flag;
									if (!flag)
									{
										num = (short)2118909998;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9B0;
								}
								case 35:
									num = (short)1009385482;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 36:
									goto IL_8D5;
								case 37:
									goto IL_872;
								case 38:
									goto IL_B91;
								case 39:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
									if (num8 >= channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630.Value)
									{
										num = (short)1469710380;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1292632121;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 40:
									num = (short)1593835552;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 41:
									if (!global::AcpCommonLib.AppInfoManager.DndOperation)
									{
										num = (short)746192901;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B79;
								case 42:
									num = (short)655294493;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 43:
								{
									global::System.Collections.Generic.List<int> list;
									int value;
									list.Add(value);
									num = (short)1570308117;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 44:
									goto IL_276;
								case 45:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2 = A_0 as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
									global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
									num9 = 0;
									num = (short)494272548;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 46:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
									channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630.Value = 0;
									num = (short)329777200;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 47:
									num6 = 0;
									num = (short)1040318489;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 48:
									goto IL_9B0;
								case 49:
								{
									int num4;
									if (num4 > num10)
									{
										num = (short)1340145665;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)494993408;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 50:
									num = (short)1182400575;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 51:
									if (!radioInformation.Labtool.RadInfoLabtoolQ445FiregroundSupport_A8796.Value)
									{
										num = (short)1463943218;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A23;
								case 52:
								{
									bool flag;
									if (!flag)
									{
										num = (short)1644560408;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_276;
								}
								case 53:
									goto IL_B79;
								case 54:
									num = (short)362676252;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 55:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
									channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630.Value = num8;
									global::System.Collections.Generic.List<int> list;
									list.Add(num8);
									bool flag = true;
									num = (short)1947861050;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 56:
									goto IL_8D5;
								case 57:
								{
									global::System.Collections.Generic.List<int> list;
									if (!list.Contains(num8))
									{
										num = (short)121045047;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num8++;
									num = (short)690749446;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 58:
									goto IL_276;
								case 59:
								{
									global::System.Collections.Generic.List<int> list;
									int value;
									if (!list.Contains(value))
									{
										num = (short)1272447019;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3D3;
								}
								case 60:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2;
									if (num9 >= zoneChannelAssignment2.Parent.Count)
									{
										num = (short)1410596897;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = zoneChannelAssignment2.Parent[num9] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
									num = (short)1023737870;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 61:
									goto IL_348;
								case 62:
									num = (short)1927413771;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 63:
									goto IL_964;
								case 64:
									goto IL_386;
								case 65:
									goto IL_A68;
								case 66:
									if (!global::AcpCommonLib.AppInfoManager.AddDefaultRecord)
									{
										num = (short)1302659134;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B79;
								}
								IL_1CD:
								if (global::AcpCommonLib.FeatureManager.GetFeature(2049) == null)
								{
									num = (short)1029636136;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
								num = (short)1844576269;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_276:
								num = (short)137297954;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_348:
								num = (short)1908080692;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_386:
								num = (short)1967521815;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3D3:
								num6++;
								num = (short)1055784980;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_53B:
								num8 = 1;
								num = (short)160301117;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_872:
								num9++;
								num = (short)1288896568;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8D5:
								num = (short)1873936444;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_9B0:
								num7++;
								num = (short)679608384;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_9D4:
								num = (short)162070545;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4E7:
								goto IL_9D4;
								IL_A23:
								num10 = 255;
								num = (short)486211625;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A68:
								num = (short)480641073;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B79:
								num = (short)574160934;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_40F:
							IL_964:
							IL_B91:
							goto IL_BB6;
						}
						catch
						{
							goto IL_BB6;
						}
						goto IL_B96;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7A;
						}
						continue;
					}
					IL_7A:
					if (A_0 == null)
					{
						num = (short)1592524800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B96:
					num = (short)1335623681;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_BB6:
				num = (short)805371905;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00048008 File Offset: 0x00046208
		public void RefreshRecordsetToolBarNonACPMethod()
		{
			int a_ = 13;
			short num = (short)1798092308;
			short num2 = num;
			num = (short)455390740;
			switch (num2 == num)
			{
			}
			num = (short)221184001;
			if (num != 0)
			{
			}
			num = (short)913375232;
			if (num != 0)
			{
			}
			num = (short)110231552;
			short num3 = num;
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::AllFeatures.CodeplugGuid.b("跍뇏병闓닕볗", a_)));
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::AllFeatures.CodeplugGuid.b("跍뇏병郓돕듗뿙꣛믝", a_)));
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x000480EC File Offset: 0x000462EC
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0, global::AcpCommonLib.IAcpFeatureNode A_1)
		{
			short num = (short)956104704;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8B;
				}
				int num3;
				int num6;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment record;
					int num4;
					int num5;
					switch (num2)
					{
					case 0:
						if (base.IndexOf(record) == num3)
						{
							num = (short)374407181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_1CC;
					case 2:
						goto IL_D5;
					case 3:
						num = (short)994443283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)768540673;
						if (num != 0)
						{
						}
						goto IL_210;
					case 5:
						num4 = num3;
						num = (short)1495728129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (num5 < num6)
						{
							num = (short)1505755145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_210;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment record2;
						if (base.IndexOf(record2) == num3)
						{
							num = (short)1167982595;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5FF;
					}
					case 8:
						return;
					case 9:
					{
						num = (short)1379729408;
						short num7 = num;
						(base[num5] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneZoneCloningEnable_43119.CalculateValidity();
						num = (short)382271492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_D5;
					case 11:
						goto IL_5FF;
					case 12:
						goto IL_1CC;
					case 13:
						num = (short)1487863823;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (num4 < num6)
						{
							num = (short)2044854288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B7;
					case 15:
						if (num3 < num6)
						{
							num = (short)1408499717;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 16:
						(base[num4] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneZoneCloningEnable_43119.CalculateValidity();
						num = (short)1986265105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_2B7;
					case 18:
						goto IL_57D;
					case 19:
						if (num3 < num6)
						{
							num = (short)1597308946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5FF;
					case 20:
					{
						try
						{
							num = (short)1280638981;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)1386872838;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1156644867;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_4B6;
								case 3:
									if (((global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment)enumerator.Current).Zone.ZnChanCfgZoneZoneCloningEnable_43119.Value)
									{
										num = (short)368443396;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									num3++;
									num = (short)1223950338;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_3F9;
									}
									continue;
								case 6:
									num = (short)1909391361;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3FB:
								num = (short)1874198528;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3F9:
								goto IL_3FB;
							}
							IL_4B6:
							goto IL_26B;
						}
						finally
						{
							num = (short)1448214529;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_57A;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_4EE;
									}
									continue;
								case 2:
								{
									enumerator.Dispose();
									num = (short)92727327;
									short num8 = num;
									num = (short)413001759;
									switch ((num8 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)1300627456;
										if (num != 0)
										{
										}
										num = (short)2145976320;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_4EE:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1549402114;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_57A:;
						}
						goto IL_57D;
						IL_26B:
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment record2 = A_0 as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
						num = (short)1855127559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						if (num5 >= base.Count)
						{
							num = (short)1448542219;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)965148678;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (num4 >= base.Count)
						{
							num = (short)203030536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)578551822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8B;
					IL_D5:
					num = (short)2023424021;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CC:
					num = (short)161742870;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_210:
					(base[num5] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneZoneCloningEnable_43119.CalculateApplicability();
					(base[num5] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneZoneCloningEnable_43119.CalculateEditability();
					num5++;
					num = (short)682557450;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B7:
					(base[num4] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneZoneCloningEnable_43119.CalculateApplicability();
					(base[num4] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneZoneCloningEnable_43119.CalculateEditability();
					num4++;
					num = (short)880803852;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_57D:
					num5 = num3;
					num = (short)270991362;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5FF:
					record = (A_1 as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
					num = (short)936771584;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_8B:
				num6 = 15;
				num3 = 0;
				enumerator = base.GetEnumerator();
				num = (short)398786580;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0004875C File Offset: 0x0004695C
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					zoneChannelAssignment.Zone.ZnChanCfgZoneZoneCloningEnable_43119.CallConstraints();
					num2 = (short)592707591;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)1301504732;
					short num3 = num2;
					num2 = (short)1940677340;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_277;
					default:
						num2 = (short)774045696;
						if (num2 != 0)
						{
						}
						num2 = (short)47382531;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
				{
					num2 = (short)909443072;
					short num4 = num2;
					if (zoneChannelAssignment.Zone.ZnChanCfgZoneZoneCloningEnable_43119.Editable)
					{
						goto IL_277;
					}
					return;
				}
				case 3:
					if (zoneChannelAssignment.Zone.ZnChanCfgZoneZoneCloningEnable_43119 != null)
					{
						num2 = (short)1953300492;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					num2 = (short)613875721;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)568721416;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (zoneChannelAssignment != null)
					{
						num2 = (short)1326186501;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 7:
					return;
				case 8:
					if (zoneChannelAssignment.Zone != null)
					{
						num2 = (short)1247150081;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 9:
					if (zoneChannelAssignment.Zone.ZnChanCfgZoneZoneCloningEnable_43119.Applicable)
					{
						num2 = (short)1134100480;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 10:
					num2 = (short)1652031489;
					if (num2 != 0)
					{
					}
					if (!global::AcpCommonLib.ConstraintManager.Suspended)
					{
						num2 = (short)1936916491;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 11:
					num2 = (short)591200262;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					num2 = (short)926547970;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_44;
				IL_277:
				num2 = (short)1532035076;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_44:
			zoneChannelAssignment = (A_0 as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
			num2 = (short)1058471946;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x000489FC File Offset: 0x00046BFC
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			int a_ = 12;
			short num = (short)495714311;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1575446640;
					short num3 = num;
					num = (short)79587440;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_191;
					default:
						goto IL_1FD;
					}
					break;
				}
				case 1:
					goto IL_18C;
				case 2:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
					if (string.IsNullOrEmpty(channelAssignmentListInner.ChannelAssignmentListInnerSection.ChannelAnnouncementID_A20175.UIValue))
					{
						num = (short)214892552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 3:
					if (this._DynMax == -1)
					{
						num = (short)1314455556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					goto IL_191;
				case 5:
					num = (short)1861812227;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					if (!global::ConstraintHelper.UtilityMack.IsNFPARadio)
					{
						num = (short)90374144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = (A_0 as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Channels.EmbeddedRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
					channelAssignmentListInner.ChannelAssignmentListInnerSection.ChannelAnnouncementID_A20175.SetRecset(global::AcpCommonLib.FeatureManager.GetFeature(2300));
					num = (short)2142109698;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					switch (0)
					{
					case 0:
						goto IL_52;
					}
					continue;
				case 8:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
					channelAssignmentListInner.ChannelAssignmentListInnerSection.ChannelAnnouncementID_A20175.UIValue = global::AllFeatures.CodeplugGuid.b("껌꟎냐뷒믔닖뗘듚돜뫞", a_);
					num = (short)747962368;
					short num4 = num;
					num = (short)1159266305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_52:
				if (A_0 != null)
				{
					num = (short)1042153477;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_191:
				num = (short)1801650182;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_18C:
			return;
			IL_1FD:
			num = (short)1457324032;
			if (num != 0)
			{
			}
			num = (short)1700855809;
			if (num != 0)
			{
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00048C48 File Offset: 0x00046E48
		// Note: this type is marked as 'beforefieldinit'.
		static ZoneChannelAssignmentRecset()
		{
			short num = (short)812295165;
			short num2 = num;
			num = (short)1313711101;
			switch (num2 == num)
			{
			}
			num = (short)1844969473;
			if (num != 0)
			{
			}
			num = (short)1137049600;
			if (num != 0)
			{
			}
			num = (short)431292416;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset._Min = 1;
		}

		// Token: 0x040001CD RID: 461
		public static int _MaxPool;

		// Token: 0x040001CE RID: 462
		public static int _Max;

		// Token: 0x040001CF RID: 463
		public int _DynMax;

		// Token: 0x040001D0 RID: 464
		public static int _Min;
	}
}
