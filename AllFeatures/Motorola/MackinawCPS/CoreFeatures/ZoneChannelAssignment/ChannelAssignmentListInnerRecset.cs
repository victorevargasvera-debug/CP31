using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ConventionalWide;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.ScanList;

namespace Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment
{
	// Token: 0x02000038 RID: 56
	[global::System.Serializable]
	public class ChannelAssignmentListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00007D44 File Offset: 0x00005F44
		public ChannelAssignmentListInnerRecset() : base(global::CommonResources.AcgResources.ID_CHANNELASSIGNMENTLIST, global::CommonResources.AcgResources.ID_CHANNEL)
		{
			this.SetValues();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00007D68 File Offset: 0x00005F68
		public ChannelAssignmentListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00007D94 File Offset: 0x00005F94
		public override int MaxPool
		{
			get
			{
				short num = (short)1281556480;
				short num2 = num;
				num = (short)1899921879;
				short num3 = num;
				num = (short)1670283735;
				switch (num3 == num)
				{
				}
				num = (short)299368448;
				if (num != 0)
				{
				}
				num = (short)455081985;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00007E44 File Offset: 0x00006044
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00007F04 File Offset: 0x00006104
		public override int Max
		{
			get
			{
				short num = (short)1807679488;
				short num2 = num;
				num = (short)1852600377;
				short num3 = num;
				num = (short)1818652729;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1410007041;
					if (num != 0)
					{
					}
					num = (short)638255104;
					if (num != 0)
					{
					}
					if (this._DynMax != -1)
					{
						return this._DynMax;
					}
					break;
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset._Max;
			}
			set
			{
				short num = (short)1895497728;
				short num2 = num;
				num = (short)660865025;
				if (num != 0)
				{
				}
				num = (short)21412213;
				short num3 = num;
				num = (short)1573960053;
				switch (num3 == num)
				{
				}
				num = (short)849149952;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00007FB0 File Offset: 0x000061B0
		public override int Min
		{
			get
			{
				short num = (short)1867579392;
				short num2 = num;
				num = (short)1902591970;
				short num3 = num;
				num = (short)409026530;
				switch (num3 == num)
				{
				}
				num = (short)91095041;
				if (num != 0)
				{
				}
				num = (short)817627136;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset._Min;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00008064 File Offset: 0x00006264
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00008114 File Offset: 0x00006314
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)596246528;
				short num2 = num;
				num = (short)1797259228;
				short num3 = num;
				num = (short)222167004;
				switch (num3 == num)
				{
				}
				num = (short)1019543553;
				if (num != 0)
				{
				}
				num = (short)868679680;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1866661888;
				short num2 = num;
				num = (short)1903739393;
				short num3 = num;
				num = (short)1306378753;
				switch (num3 == num)
				{
				}
				num = (short)525795329;
				if (num != 0)
				{
				}
				num = (short)791281664;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000081C0 File Offset: 0x000063C0
		public bool HasDiffs
		{
			get
			{
				short num = (short)805568512;
				short num2 = num;
				num = (short)1368183738;
				short num3 = num;
				num = (short)883545018;
				switch (num3 == num)
				{
				}
				num = (short)1280507905;
				if (num != 0)
				{
				}
				num = (short)1767047168;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000826C File Offset: 0x0000646C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1659764736;
			short num2 = num;
			num = (short)1705584201;
			short num3 = num;
			num = (short)71968329;
			switch (num3 == num)
			{
			}
			num = (short)1745813505;
			if (num != 0)
			{
			}
			num = (short)1998520320;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner(this);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00008318 File Offset: 0x00006518
		internal void SetValues()
		{
			short num = (short)1699938304;
			short num2 = num;
			num = (short)1782508960;
			short num3 = num;
			num = (short)634973600;
			switch (num3 == num)
			{
			}
			num = (short)1650589697;
			if (num != 0)
			{
			}
			num = (short)313720832;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_CHANNELASSIGNMENTLIST;
			base.KeySeed = global::CommonResources.AcgResources.ID_CHANNEL;
			base.DataTransferOrder = 46;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000083EC File Offset: 0x000065EC
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1248264192;
			short num2 = num;
			num = (short)756875265;
			if (num != 0)
			{
			}
			num = (short)464080961;
			short num3 = num;
			num = (short)1045188673;
			switch (num3 == num)
			{
			}
			num = (short)1112866816;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord();
			this.i(record);
			this.b();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000084AC File Offset: 0x000066AC
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1339949056;
			short num2 = num;
			num = (short)107573430;
			short num3 = num;
			num = (short)107638966;
			switch (num3 == num)
			{
			}
			num = (short)1510604801;
			if (num != 0)
			{
			}
			num = (short)376373248;
			if (num != 0)
			{
			}
			base.OnFinishedRemoveRecord();
			this.h(record);
			this.b();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00008568 File Offset: 0x00006768
		private void b()
		{
			short num = (short)930349056;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_73;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset scanListRecset;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset conventionalWideRecset;
					global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideRecset radioErgonomicsWideRecset;
					global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
					switch (num2)
					{
					case 0:
						num = (short)1021181959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (conventionalWideRecset != null)
						{
							num = (short)1348861957;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						return;
					case 3:
						if (scanListRecset != null)
						{
							num = (short)1554710532;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_399;
					case 4:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = scanListRecset.GetEnumerator();
						num = (short)1855389702;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						num = (short)2045116417;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (conventionalWideRecset[0][10055].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerRecset).GetEnumerator();
						num = (short)900268047;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						try
						{
							num = (short)843972608;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_113;
									}
									continue;
								case 1:
									try
									{
										num = (short)1495662592;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_1C8;
												}
												continue;
											case 1:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1934229506;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												(((global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner)enumerator2.Current)[10133] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection).ScanLstScanListChannel_A7620.CalculateValidity();
												num = (short)777256964;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												num = (short)1835925507;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												goto IL_254;
											}
											IL_1CA:
											num = (short)53673985;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1C8:
											goto IL_1CA;
										}
										IL_254:
										break;
									}
									finally
									{
										num = (short)804978688;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_28C;
												}
												continue;
											case 1:
												enumerator2.Dispose();
												num = (short)259325954;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_2C2;
											}
											IL_28C:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)793509889;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_2C2:;
									}
									goto IL_2C5;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)442695684;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = (((global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList)enumerator.Current)[10132].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset).GetEnumerator();
									num = (short)56164353;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_2DD;
								case 4:
									goto IL_2C5;
								}
								IL_152:
								num = (short)1851195394;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_113:
								goto IL_152;
								IL_2C5:
								num = (short)805306371;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2DD:;
						}
						finally
						{
							num = (short)447055220;
							short num3 = num;
							num = (short)452429172;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1479802880;
								if (num != 0)
								{
								}
								num = (short)1199243264;
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
											goto IL_360;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)108789762;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_396;
									}
									IL_360:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1094582273;
									num2 = (int)((global::System.IntPtr)num);
								}
								break;
							}
							IL_396:;
						}
						goto IL_399;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HomeMode homeMode = radioErgonomicsWideRecset[0][10076] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HomeMode;
						if (homeMode == null)
						{
							num = (short)1679949834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.AcpRangeField<int, string> homeModeChannel = homeMode.HomeModeChannel;
						if (homeModeChannel == null)
						{
							num = (short)1681129484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						homeModeChannel.CalculateValidity();
						num = (short)1640038408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_49F;
					case 9:
						if (radioErgonomicsWideRecset != null)
						{
							num = (short)773652480;
							short num4 = num;
							num = (short)629604352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_683;
					case 10:
						goto IL_49F;
					case 11:
					{
						if (radioErgonomicsWide == null)
						{
							num = (short)823525378;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerRecset presetZoneAndChannelTableInnerRecset = radioErgonomicsWide.PresetZoneAndChannel.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerRecset;
						num = (short)697303053;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_49F;
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerRecset presetZoneAndChannelTableInnerRecset;
						if (presetZoneAndChannelTableInnerRecset == null)
						{
							num = (short)1162412048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = presetZoneAndChannelTableInnerRecset.GetEnumerator();
						num = (short)1549467662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						try
						{
							num = (short)494403584;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_58F;
									}
									continue;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1750335490;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									((global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInner)enumerator.Current).PresetZoneAndChannelTableInnerSection.LabtoolPresetChannel_A41080.CalculateValidity();
									num = (short)785514500;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)674234371;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_616;
								}
								IL_591:
								num = (short)619708417;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_58F:
								goto IL_591;
							}
							IL_616:;
						}
						finally
						{
							num = (short)1395523584;
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
										goto IL_64B;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)175177730;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_680;
								}
								IL_64B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1631780865;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_680:;
						}
						goto IL_683;
					case 15:
						goto IL_731;
					case 16:
						return;
					}
					goto IL_73;
					IL_399:
					radioErgonomicsWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2033) as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideRecset);
					num = (short)1482227721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_49F:
					radioErgonomicsWide = (radioErgonomicsWideRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide);
					num = (short)763756555;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_683:
					conventionalWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2024) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset);
					num = (short)79495169;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_731:
				try
				{
					num = (short)63242240;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_76E;
							}
							continue;
						case 1:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1395064834;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							(((global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInner)enumerator.Current)[10056] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerSection).CnvWideASTROOTACChannel_A8629.CalculateValidity();
							num = (short)1235746820;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num = (short)568983555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_7FD;
						}
						IL_770:
						num = (short)2097414145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_76E:
						goto IL_770;
					}
					IL_7FD:;
				}
				finally
				{
					num = (short)134938624;
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
								goto IL_832;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)464912386;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_868;
						}
						IL_832:
						if (enumerator == null)
						{
							break;
						}
						num = (short)2041774081;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_868:;
				}
				return;
				IL_73:
				scanListRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2057) as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset);
				num = (short)10092547;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00008E44 File Offset: 0x00007044
		private void i(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1496889241;
			short num2 = num;
			num = (short)809351065;
			switch (num2 == num)
			{
			}
			num = (short)2066808833;
			if (num != 0)
			{
			}
			num = (short)577896448;
			short num3 = num;
			num = (short)1551564800;
			if (num != 0)
			{
			}
			this.f(A_0);
			this.c(A_0);
			this.a(A_0);
			this.e(A_0);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00008F0C File Offset: 0x0000710C
		private void h(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1192425444;
			short num2 = num;
			num = (short)477886436;
			switch (num2 == num)
			{
			}
			num = (short)1997340673;
			if (num != 0)
			{
			}
			num = (short)1837236224;
			short num3 = num;
			num = (short)2013462528;
			if (num != 0)
			{
			}
			this.a();
			this.g(A_0);
			this.f(A_0);
			this.d(A_0);
			this.b(A_0);
			this.a(A_0);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00008FDC File Offset: 0x000071DC
		private void a()
		{
			short num = (short)1432009191;
			short num2 = num;
			num = (short)782023143;
			switch (num2 == num)
			{
			}
			num = (short)1234894849;
			if (num != 0)
			{
			}
			num = (short)1833697280;
			short num3 = num;
			num = (short)1124270080;
			if (num != 0)
			{
			}
			global::AcpBusinessLayer.AcpField<bool> znChanCfgFPPProtectionProtectedZone_A = (base.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).FPPProtection.ZnChanCfgFPPProtectionProtectedZone_A8765;
			global::AcpBusinessLayer.AcpFieldBase znChanCfgFPPProtectionFPPEnable_A = (base.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).FPPProtection.ZnChanCfgFPPProtectionFPPEnable_A19562;
			znChanCfgFPPProtectionProtectedZone_A.CalculateValidity();
			znChanCfgFPPProtectionFPPEnable_A.CalculateValidity();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000090C8 File Offset: 0x000072C8
		private void g(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
			for (;;)
			{
				IL_0A:
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Labtool labtool;
				switch (num)
				{
				case 0:
					if (labtool == null)
					{
						num2 = (short)1793458176;
						short num3 = num2;
						num2 = (short)740622337;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)755957764;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return;
				case 2:
				{
					bool flag = global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
					labtool.ZnChanCfgLabtoolLastSelectedChnl_A41075.UIValue = global::CommonResources.AppResources._Unassigned_;
					if (flag)
					{
						num2 = (short)267452423;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 3:
					goto IL_15D;
				case 4:
					goto IL_1E6;
				case 5:
					return;
				case 6:
				{
					num2 = (short)2075559413;
					short num4 = num2;
					num2 = (short)2000651765;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E6;
					default:
						num2 = (short)577634304;
						if (num2 != 0)
						{
						}
						num2 = (short)580648962;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 7:
					global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
					num2 = (short)2143944705;
					if (num2 != 0)
					{
					}
					num2 = (short)472055811;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (zoneChannelAssignment == null)
					{
						num2 = (short)17694725;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					labtool = zoneChannelAssignment.Labtool;
					num2 = (short)111149056;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_34;
				IL_1E6:
				if (!(labtool.ZnChanCfgLabtoolLastSelectedChnl_A41075.UIValue == labtool.ZnChanCfgLabtoolLastSelectedChnl_A41075.InvalidText))
				{
					return;
				}
				num2 = (short)1947009030;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_15D:
			return;
			IL_34:
			zoneChannelAssignment = (A_0.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
			num2 = (short)1535705096;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000092F4 File Offset: 0x000074F4
		public override string GenerateKeyValue(global::AcpBusinessLayer.FeatureNode node)
		{
			int a_ = 17;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Channels channels;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					if (zoneChannelAssignment != null)
					{
						num2 = (short)2066284544;
						short num3 = num2;
						num2 = (short)1827405827;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AA;
				}
				case 1:
				{
					num2 = (short)930155375;
					short num4 = num2;
					num2 = (short)119933807;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)417529856;
						if (num2 != 0)
						{
						}
						num2 = (short)1208090625;
						if (num2 != 0)
						{
						}
						break;
					}
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = channels.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
					num2 = (short)2142240768;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_139;
				case 3:
					num2 = (short)638779396;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					if (zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
					{
						num2 = (short)129302530;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AA;
				}
				case 5:
					if (channels != null)
					{
						num2 = (short)1493893121;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AA;
				}
				goto IL_31;
			}
			IL_139:
			return global::AllFeatures.CodeplugGuid.b("", a_);
			IL_1AA:
			return base.GenerateKeyValue(node);
			IL_31:
			channels = (node.Parent.ParentSection as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Channels);
			num2 = (short)1438580741;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000094B4 File Offset: 0x000076B4
		private void f(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num)
				{
				case 0:
					goto IL_33C;
				case 1:
					try
					{
						num2 = (short)12582922;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_2CF;
							case 1:
								num2 = (short)1383727106;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
								if ((acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone != null)
								{
									num2 = (short)1085603846;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 3:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
								if ((acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneDynamicZoneEnable_A41257 != null)
								{
									num2 = (short)2057043973;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 4:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
								if ((acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
								{
									num2 = (short)977469451;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 5:
							{
								num2 = (short)255889845;
								short num3 = num2;
								num2 = (short)854102453;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num2 = (short)818151424;
									if (num2 != 0)
									{
									}
									num2 = (short)2033713156;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 6:
								num2 = (short)1582170115;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 7:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)141819912;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
								num2 = (short)1689124873;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 8:
								num2 = (short)2062548992;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 9:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
								if (acpFeatureNode != null)
								{
									num2 = (short)563347457;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 10:
								switch (0)
								{
								case 0:
									goto IL_E3;
								}
								continue;
							case 11:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
								(acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.CallConstraints();
								num2 = (short)80740364;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 12:
								goto IL_112;
							}
							IL_1A0:
							num2 = (short)1691877383;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_E3:
							goto IL_1A0;
						}
						IL_112:
						IL_2CF:
						return;
					}
					finally
					{
						num2 = (short)1416888322;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)1348993025;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_339;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_304;
								}
								continue;
							}
							IL_304:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)94699520;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_339:;
					}
					goto IL_33C;
				case 2:
					num2 = (short)1776812033;
					if (num2 != 0)
					{
					}
					if (zoneChannelAssignmentRecset != null)
					{
						num2 = (short)1062469632;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
				IL_33C:
				num2 = (short)496893952;
				short num4 = num2;
				enumerator = zoneChannelAssignmentRecset.GetEnumerator();
				num2 = (short)2032861185;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			zoneChannelAssignmentRecset = null;
			zoneChannelAssignmentRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset);
			num2 = (short)121634818;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00009868 File Offset: 0x00007A68
		private void e(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			int a_ = 2;
			short num = (short)1454440456;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1240465412;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
				{
					num = (short)1132789760;
					short num3 = num;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
					if (string.IsNullOrEmpty(channelAssignmentListInner.ChannelAssignmentListInnerSection.ChannelAnnouncementID_A20175.UIValue))
					{
						num = (short)613941255;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 3:
					if (this._DynMax == -1)
					{
						num = (short)2123628544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_132;
				case 4:
				{
					if (!global::ConstraintHelper.UtilityMack.IsNFPARadio)
					{
						num = (short)1678442502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = A_0 as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
					channelAssignmentListInner.ChannelAssignmentListInnerSection.ChannelAnnouncementID_A20175.SetRecset(global::AcpCommonLib.FeatureManager.GetFeature(2300));
					num = (short)1432092674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					num = (short)1859518467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_132;
				case 7:
				{
					num = (short)582877185;
					if (num != 0)
					{
					}
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
					channelAssignmentListInner.ChannelAssignmentListInnerSection.ChannelAnnouncementID_A20175.UIValue = global::AllFeatures.CodeplugGuid.b("ꃂ귄ꛆꟈꗊ꣌ꏎ뻐뷒냔", a_);
					goto IL_1D5;
				}
				case 8:
					switch (0)
					{
					case 0:
						goto IL_53;
					}
					continue;
				}
				IL_53:
				if (A_0 != null)
				{
					num = (short)1395130373;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_132;
				IL_1D5:
				num = (short)639107073;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_132:
				num = (short)1053652445;
				short num4 = num;
				num = (short)288323037;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1D5;
				default:
					goto IL_167;
				}
			}
			IL_167:
			num = (short)681574400;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00009AA0 File Offset: 0x00007CA0
		private void d(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)2128478208;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_62;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
				for (;;)
				{
					IL_27:
					num = (short)643694593;
					if (num != 0)
					{
					}
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
					switch (num2)
					{
					case 0:
						goto IL_530;
					case 1:
						try
						{
							num = (short)386203658;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)297664518;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (zoneChannelAssignment.Channels.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset).GetEnumerator();
									num = (short)1935671301;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
									if (zoneChannelAssignment.Channels != null)
									{
										num = (short)207224832;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
									if (zoneChannelAssignment != null)
									{
										num = (short)1366097927;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)1202389001;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = enumerator2.Current as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
									num = (short)281083907;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									try
									{
										num = (short)192479242;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
												channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630.CalculateValidity();
												num = (short)1256783877;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
												num = (short)2106785796;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
												if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630.Value != 0)
												{
													num = (short)1913913344;
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
													num = (short)179896327;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner)enumerator.Current;
												num = (short)1111162886;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
												if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630 != null)
												{
													num = (short)2010513417;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 6:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
												if (channelAssignmentListInner.ChannelAssignmentListInnerSection != null)
												{
													num = (short)1596325889;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 7:
												num = (short)795672584;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 8:
												goto IL_2F1;
											case 9:
												num = (short)208928770;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 10:
												switch (0)
												{
												case 0:
													goto IL_196;
												}
												continue;
											}
											IL_198:
											num = (short)452067331;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_196:
											goto IL_198;
										}
										IL_2F1:;
									}
									finally
									{
										num = (short)200212482;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
											switch (num2)
											{
											case 0:
											{
												enumerator.Dispose();
												num = (short)1446170644;
												short num3 = num;
												num = (short)726978580;
												switch ((num3 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													continue;
												default:
													num = (short)1846345728;
													if (num != 0)
													{
													}
													num = (short)1029373953;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 1:
												goto IL_3B1;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_329;
												}
												continue;
											}
											IL_329:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1513422848;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_3B1:;
									}
									break;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
									if (zoneChannelAssignment.Channels.EmbeddedRecset != null)
									{
										num = (short)195756033;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									num = (short)1192099842;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_4C0;
								case 9:
									num = (short)1259143176;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									switch (0)
									{
									case 0:
										goto IL_FA;
									}
									continue;
								}
								IL_3B4:
								num = (short)1198129156;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FA:
								goto IL_3B4;
							}
							IL_4C0:
							goto IL_555;
						}
						finally
						{
							num = (short)385417218;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator2.Dispose();
									num = (short)1898184705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_52D;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_4F7;
									}
									continue;
								}
								IL_4F7:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)787611648;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_52D:;
						}
						goto IL_530;
					case 2:
						if (zoneChannelAssignmentRecset != null)
						{
							num = (short)1192361984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_555;
					}
					goto IL_62;
					IL_530:
					enumerator2 = zoneChannelAssignmentRecset.GetEnumerator();
					num = (short)815464449;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_555:
				num = (short)353107968;
				short num4 = num;
				return;
				IL_62:
				zoneChannelAssignmentRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset);
				num = (short)76939266;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000A060 File Offset: 0x00008260
		private void c(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num;
			try
			{
				num = (short)351600640;
				switch (num)
				{
				default:
				{
					num = (short)105185301;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
						switch (num2)
						{
						case 0:
							goto IL_C52;
						case 1:
							goto IL_B7F;
						case 2:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
							if (channelAssignmentListInner.ChannelAssignmentListInnerSection == null)
							{
								num = (short)959119411;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpBusinessLayer.AcpRangeField<int, string> znChanCfgChannelsFiregroundSectorID_A = channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630;
							num = (short)995622953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::System.Collections.Generic.List<int> list;
							int num3;
							if (!list.Contains(num3))
							{
								num = (short)1319632932;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num3++;
							num = (short)1031077923;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::System.Collections.Generic.List<int> list;
							int num4;
							if (!list.Contains(num4))
							{
								num = (short)1703542810;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num4++;
							num = (short)1648754732;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_3EF;
						case 6:
							num = (short)39387146;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num = (short)1977286684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (!global::AcpCommonLib.AppInfoManager.AddDefaultRecord)
							{
								num = (short)1673855022;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C52;
						case 9:
						{
							global::AcpBusinessLayer.AcpRangeField<int, string> znChanCfgChannelsFiregroundSectorID_A;
							int num3 = znChanCfgChannelsFiregroundSectorID_A.Value;
							num = (short)814940193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							goto IL_B7A;
						case 11:
						{
							global::AcpBusinessLayer.AcpRangeField<int, string> znChanCfgChannelsFiregroundSectorID_A;
							int num4;
							if (num4 >= znChanCfgChannelsFiregroundSectorID_A.Value)
							{
								num = (short)48103447;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)356253700;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							num = (short)1731919926;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							if (A_0 == null)
							{
								num = (short)471269413;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = A_0 as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
							num = (short)145293314;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
							goto IL_18A;
						case 15:
							goto IL_917;
						case 16:
							if (!global::AcpCommonLib.AppInfoManager.DndOperation)
							{
								num = (short)303693839;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C52;
						case 17:
							goto IL_A0D;
						case 18:
							num = (short)1165492248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							if (!global::AcpCommonLib.AppInfoManager.UndoRedoInProgress)
							{
								num = (short)2038169607;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C52;
						case 20:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
							if (channelAssignmentListInner.Parent.ParentSection.ParentRecset == null)
							{
								num = (short)328925216;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection = channelAssignmentListInner.Parent.ParentSection.ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset;
							global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = collection.GetEnumerator();
							num = (short)1008361253;
							short num5 = num;
							num = (short)3497765;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1EC;
							default:
								num = (short)549519360;
								if (num != 0)
								{
								}
								num = (short)126287902;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 21:
							switch (0)
							{
							case 0:
								goto IL_121;
							}
							continue;
						case 22:
							goto IL_96D;
						case 23:
						{
							global::AcpBusinessLayer.AcpRangeField<int, string> znChanCfgChannelsFiregroundSectorID_A;
							znChanCfgChannelsFiregroundSectorID_A.Value = 0;
							num = (short)1693908992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 24:
						{
							global::AcpBusinessLayer.AcpRangeField<int, string> znChanCfgChannelsFiregroundSectorID_A;
							if (znChanCfgChannelsFiregroundSectorID_A.Value != 0)
							{
								num = (short)515833885;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C52;
						}
						case 25:
							goto IL_9F0;
						case 26:
						{
							global::AcpBusinessLayer.AcpRangeField<int, string> znChanCfgChannelsFiregroundSectorID_A;
							int num4;
							znChanCfgChannelsFiregroundSectorID_A.Value = num4;
							num = (short)1135476789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 27:
							num = (short)1276313605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
							if (!global::AcpCommonLib.AppInfoManager.BackgroundDeserializeOpertaion)
							{
								num = (short)243990546;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C52;
						case 29:
							num = (short)870907956;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
						{
							try
							{
								num = (short)1202585604;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									int num6;
									switch (num2)
									{
									case 0:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2;
										if (channelAssignmentListInner2 != null)
										{
											num = (short)1336999942;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_69E;
									}
									case 1:
									{
										global::AcpBusinessLayer.AcpRangeField<int, string> znChanCfgChannelsFiregroundSectorID_A2;
										if (znChanCfgChannelsFiregroundSectorID_A2 != null)
										{
											num = (short)268763151;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_69E;
									}
									case 2:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1552220172;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment)enumerator.Current;
										num = (short)53542926;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										goto IL_5E0;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_5DB;
										}
										continue;
									case 5:
										goto IL_8A3;
									case 6:
										num = (short)2001993744;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
									{
										global::AcpBusinessLayer.AcpRangeField<int, string> znChanCfgChannelsFiregroundSectorID_A2;
										if (znChanCfgChannelsFiregroundSectorID_A2.Value != 0)
										{
											num = (short)155254804;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_69E;
									}
									case 8:
										goto IL_5E0;
									case 9:
									{
										global::System.Collections.Generic.List<int> list;
										global::AcpBusinessLayer.AcpRangeField<int, string> znChanCfgChannelsFiregroundSectorID_A2;
										if (!list.Contains(znChanCfgChannelsFiregroundSectorID_A2.Value))
										{
											num = (short)1238040589;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_69E;
									}
									case 11:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
										if (num6 >= zoneChannelAssignment.Channels.EmbeddedRecset.Count)
										{
											num = (short)1115815946;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2 = zoneChannelAssignment.Channels.EmbeddedRecset[num6] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
										num = (short)351338496;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 12:
										num = (short)1530003461;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 13:
									{
										global::System.Collections.Generic.List<int> list;
										global::AcpBusinessLayer.AcpRangeField<int, string> znChanCfgChannelsFiregroundSectorID_A2;
										list.Add(znChanCfgChannelsFiregroundSectorID_A2.Value);
										num = (short)1117388819;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 14:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
										if (zoneChannelAssignment != null)
										{
											num = (short)760610833;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 15:
										num = (short)1944453127;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 16:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2;
										if (channelAssignmentListInner2 != A_0)
										{
											num = (short)635568146;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_69E;
									}
									case 17:
										num6 = 0;
										num = (short)1301217283;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 18:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2;
										global::AcpBusinessLayer.AcpRangeField<int, string> znChanCfgChannelsFiregroundSectorID_A2 = channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630;
										num = (short)874774529;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 19:
										goto IL_69E;
									case 20:
										num = (short)728629257;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5DB;
									IL_5E0:
									num = (short)1426587659;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_69E:
									num6++;
									num = (short)1939472392;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_7DD:
									num = (short)90898434;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_5DB:
									goto IL_7DD;
								}
								IL_8A3:
								goto IL_229;
							}
							finally
							{
								num = (short)610074624;
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
											goto IL_8DC;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)1083047938;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_914;
									}
									IL_8DC:
									if (enumerator == null)
									{
										break;
									}
									num = (short)937099265;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_914:;
							}
							goto IL_917;
							IL_229:
							int num7 = 255;
							num = (short)712572959;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 31:
						{
							global::AcpBusinessLayer.AcpRangeField<int, string> znChanCfgChannelsFiregroundSectorID_A;
							global::System.Collections.Generic.List<int> list;
							if (list.Contains(znChanCfgChannelsFiregroundSectorID_A.Value))
							{
								num = (short)734527497;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C52;
						}
						case 32:
							num = (short)455278606;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 33:
							goto IL_1AC;
						case 34:
							num = (short)874512406;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 35:
							goto IL_1AC;
						case 36:
						{
							global::AcpBusinessLayer.AcpRangeField<int, string> znChanCfgChannelsFiregroundSectorID_A;
							int num3;
							znChanCfgChannelsFiregroundSectorID_A.Value = num3;
							num = (short)668598322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 37:
							num = (short)207224872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 38:
						{
							int num3;
							int num7;
							if (num3 > num7)
							{
								num = (short)1162149931;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1826291715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 39:
							num = (short)1110245393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 40:
							goto IL_453;
						case 41:
						{
							global::AcpBusinessLayer.AcpRangeField<int, string> znChanCfgChannelsFiregroundSectorID_A;
							if (znChanCfgChannelsFiregroundSectorID_A == null)
							{
								num = (short)246546466;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)986382352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 42:
							goto IL_C6A;
						case 43:
						{
							int num4 = 1;
							num = (short)1448607745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 44:
							goto IL_B7F;
						case 45:
							goto IL_1A7;
						case 46:
							num = (short)1417347091;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 47:
							if (radioInformation.Labtool.RadInfoLabtoolQ445FiregroundSupport_A8796 != null)
							{
								num = (short)1733033996;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1EC;
						case 48:
							num = (short)1103560729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 49:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
							if (channelAssignmentListInner.Parent.ParentSection == null)
							{
								num = (short)803864582;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)734986260;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 50:
							goto IL_4DB;
						case 51:
							num = (short)54001709;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 52:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
							if (channelAssignmentListInner.Parent == null)
							{
								num = (short)1620312103;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1847459889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 53:
							goto IL_B5D;
						case 54:
							if (!radioInformation.Labtool.RadInfoLabtoolQ445FiregroundSupport_A8796.Value)
							{
								num = (short)1926234160;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1EC;
						}
						IL_121:
						if (global::AcpCommonLib.FeatureManager.GetFeature(2049) == null)
						{
							num = (short)497418267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
						num = (short)793641007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1AC:
						num = (short)68616230;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1EC:
						num = (short)882114573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_917:
						num = (short)1097269256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_B7F:
						num = (short)713162763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_C52:
						num = (short)1071251498;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_18A:
					IL_1A7:
					IL_3EF:
					IL_453:
					IL_4DB:
					IL_96D:
					IL_9F0:
					IL_A0D:
					IL_B5D:
					IL_B7A:
					IL_C6A:
					break;
				}
				}
			}
			catch
			{
			}
			num = (short)1569062912;
			short num8 = num;
			num = (short)1955594241;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000AD60 File Offset: 0x00008F60
		public void RefreshRecordsetToolBarNonACPMethod()
		{
			int a_ = 13;
			short num = (short)189182930;
			short num2 = num;
			num = (short)1750643666;
			switch (num2 == num)
			{
			}
			num = (short)1869938688;
			short num3 = num;
			num = (short)1169162240;
			if (num != 0)
			{
			}
			num = (short)941883393;
			if (num != 0)
			{
			}
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::AllFeatures.CodeplugGuid.b("跍뇏병闓닕볗", a_)));
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::AllFeatures.CodeplugGuid.b("跍뇏병郓돕듗뿙꣛믝", a_)));
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000AE48 File Offset: 0x00009048
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Channels channels;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
						if (channels != null)
						{
							num2 = (short)76611586;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 2:
					{
						num2 = (short)1682571265;
						if (num2 != 0)
						{
						}
						num2 = (short)316364251;
						short num3 = num2;
						num2 = (short)1771394523;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_35;
						default:
						{
							num2 = (short)1183711232;
							if (num2 != 0)
							{
							}
							num2 = (short)1953628160;
							short num4 = num2;
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = channels.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
							num2 = (short)95223811;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
						if (zoneChannelAssignment != null)
						{
							num2 = (short)1252130820;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
						zoneChannelAssignment.RSI.ZoneChannelAssignmentRSIMode_A41831.CalculateValidity();
						num2 = (short)1054277632;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_24;
				}
				return;
			}
			IL_24:
			channels = (A_0.Parent.ParentSection as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Channels);
			IL_35:
			num2 = (short)520749057;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000AFC8 File Offset: 0x000091C8
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1540227072;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7B;
				}
				global::AcpCommonLib.IAcpRecordset feature;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						feature.CalculateValidity();
						num = (short)2018181133;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = feature2[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						num = (short)347209736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_4DB;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
						if (zoneChannelAssignmentRecset != null)
						{
							num = (short)1681588234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2 != null)
						{
							num = (short)103546880;
							short num3 = num;
							num = (short)1131675662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DB;
					}
					case 5:
						try
						{
							num = (short)1426718721;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (acpFeatureNode != null)
									{
										num = (short)1566048258;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2CF;
									}
									continue;
								case 2:
									num = (short)1545928714;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)332070919;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_41C;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									(acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneZoneCloningEnable_43119.CallConstraints();
									num = (short)1307508741;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneZoneCloningEnable_43119 != null)
									{
										num = (short)1273692166;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									num = (short)1218772996;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1601503240;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)11796480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone != null)
									{
										num = (short)1326841859;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_34B:
								num = (short)606797833;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2CF:
								goto IL_34B;
							}
							IL_41C:
							return;
						}
						finally
						{
							num = (short)653738942;
							short num4 = num;
							num = (short)1106461630;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_483:
								switch (0)
								{
								case 0:
									goto IL_4A0;
								}
								break;
							default:
								num = (short)1864040448;
								if (num != 0)
								{
								}
								num = (short)328925186;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							for (;;)
							{
								IL_48D:
								switch (num2)
								{
								case 0:
									goto IL_4D8;
								case 1:
									enumerator.Dispose();
									num = (short)1713897472;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_483;
								}
								goto IL_4A0;
							}
							IL_4D8:
							goto IL_4DA;
							IL_4A0:
							if (enumerator != null)
							{
								num = (short)1423572993;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_48D;
							}
							IL_4DA:;
						}
						goto IL_4DB;
					case 6:
					{
						if (global::AcpCommonLib.ConstraintManager.Suspended)
						{
							num = (short)1805123602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool flag = false;
						global::AcpCommonLib.IAcpRecordset feature2 = global::AcpCommonLib.FeatureManager.GetFeature(2045);
						num = (short)1158938628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)419692556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide != null)
						{
							num = (short)1649278983;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DB;
					}
					case 9:
						if (feature != null)
						{
							num = (short)1461714944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12B;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = zoneChannelAssignmentRecset.GetEnumerator();
						num = (short)1425145861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2.Count > 0)
						{
							num = (short)553254913;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DB;
					}
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide.Features.RadWideFeaturesZoneCloneEnable_43130)
						{
							num = (short)88014865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DB;
					}
					case 13:
						goto IL_12B;
					case 14:
						num = (short)1370226699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						return;
					case 16:
					{
						bool flag;
						if (!flag)
						{
							num = (short)1054277647;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset = null;
						zoneChannelAssignmentRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset);
						num = (short)1734213635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						num = (short)656867329;
						if (num != 0)
						{
						}
						bool flag = true;
						num = (short)1091502082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						return;
					}
					goto IL_7B;
					IL_12B:
					num = (short)1903624198;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4DB:
					num = (short)1727332368;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_7B:
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2075);
				num = (short)476839945;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000B5B8 File Offset: 0x000097B8
		// Note: this type is marked as 'beforefieldinit'.
		static ChannelAssignmentListInnerRecset()
		{
			short num = (short)1475608576;
			short num2 = num;
			num = (short)1983410161;
			short num3 = num;
			num = (short)750481393;
			switch (num3 == num)
			{
			}
			num = (short)1086521344;
			if (num != 0)
			{
			}
			num = (short)653197313;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset._Min = 1;
		}

		// Token: 0x04000076 RID: 118
		public static int _MaxPool;

		// Token: 0x04000077 RID: 119
		public static int _Max;

		// Token: 0x04000078 RID: 120
		public int _DynMax;

		// Token: 0x04000079 RID: 121
		public static int _Min;

		// Token: 0x0400007A RID: 122
		public static int _DefaultRecordCount;
	}
}
