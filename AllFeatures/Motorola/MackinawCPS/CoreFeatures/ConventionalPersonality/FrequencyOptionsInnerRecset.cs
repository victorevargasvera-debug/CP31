using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using Motorola.MackinawCPS.CoreFeatures.ScanList;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x020005C0 RID: 1472
	[global::System.Serializable]
	public class FrequencyOptionsInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600C4AB RID: 50347 RVA: 0x00B85DC0 File Offset: 0x00B83FC0
		public FrequencyOptionsInnerRecset() : base(global::CommonResources.AcgResources.ID_FREQUENCYOPTIONS, global::CommonResources.AcgResources.ID_OPTION)
		{
			this.SetValues();
		}

		// Token: 0x0600C4AC RID: 50348 RVA: 0x00B85DE4 File Offset: 0x00B83FE4
		public FrequencyOptionsInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17006278 RID: 25208
		// (get) Token: 0x0600C4AD RID: 50349 RVA: 0x00B85E10 File Offset: 0x00B84010
		public override int MaxPool
		{
			get
			{
				short num = (short)892108622;
				short num2 = num;
				num = (short)1656258382;
				switch (num2 == num)
				{
				}
				num = (short)172818433;
				if (num != 0)
				{
				}
				num = (short)822607872;
				if (num != 0)
				{
				}
				num = (short)917110784;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset._MaxPool;
			}
		}

		// Token: 0x17006279 RID: 25209
		// (get) Token: 0x0600C4AE RID: 50350 RVA: 0x00B85EC0 File Offset: 0x00B840C0
		// (set) Token: 0x0600C4AF RID: 50351 RVA: 0x00B85F80 File Offset: 0x00B84180
		public override int Max
		{
			get
			{
				short num = (short)764149761;
				if (num != 0)
				{
				}
				if (this._DynMax != -1)
				{
					num = (short)776739875;
					short num2 = num;
					num = (short)738925603;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1628372992;
						if (num != 0)
						{
						}
						num = (short)1051131904;
						short num3 = num;
						return this._DynMax;
					}
					}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset._Max;
			}
			set
			{
				short num = (short)1658721382;
				short num2 = num;
				num = (short)1917326438;
				switch (num2 == num)
				{
				}
				num = (short)1542389761;
				if (num != 0)
				{
				}
				num = (short)703463424;
				if (num != 0)
				{
				}
				num = (short)1791492096;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x1700627A RID: 25210
		// (get) Token: 0x0600C4B0 RID: 50352 RVA: 0x00B86030 File Offset: 0x00B84230
		public override int Min
		{
			get
			{
				short num = (short)756848384;
				short num2 = num;
				num = (short)1412077312;
				switch (num2 == num)
				{
				}
				num = (short)1634664449;
				if (num != 0)
				{
				}
				num = (short)1685848064;
				if (num != 0)
				{
				}
				num = (short)1649999872;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset._Min;
			}
		}

		// Token: 0x1700627B RID: 25211
		// (get) Token: 0x0600C4B1 RID: 50353 RVA: 0x00B860E0 File Offset: 0x00B842E0
		// (set) Token: 0x0600C4B2 RID: 50354 RVA: 0x00B8618C File Offset: 0x00B8438C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1741208161;
				short num2 = num;
				num = (short)500349537;
				switch (num2 == num)
				{
				}
				num = (short)1369636865;
				if (num != 0)
				{
				}
				num = (short)641925120;
				if (num != 0)
				{
				}
				num = (short)1203306496;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)2097527447;
				short num2 = num;
				num = (short)1336457879;
				switch (num2 == num)
				{
				}
				num = (short)2111963137;
				if (num != 0)
				{
				}
				num = (short)1741225984;
				if (num != 0)
				{
				}
				num = (short)772538368;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700627C RID: 25212
		// (get) Token: 0x0600C4B3 RID: 50355 RVA: 0x00B86240 File Offset: 0x00B84440
		public bool HasDiffs
		{
			get
			{
				short num = (short)1436286976;
				short num2 = num;
				num = (short)1913586228;
				short num3 = num;
				num = (short)1830093364;
				switch (num3 == num)
				{
				}
				num = (short)845611008;
				if (num != 0)
				{
				}
				num = (short)435552257;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600C4B4 RID: 50356 RVA: 0x00B862F0 File Offset: 0x00B844F0
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1356398592;
			short num2 = num;
			num = (short)1547961092;
			short num3 = num;
			num = (short)1005454084;
			switch (num3 == num)
			{
			}
			num = (short)1678180352;
			if (num != 0)
			{
			}
			num = (short)1510342657;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner(this);
		}

		// Token: 0x0600C4B5 RID: 50357 RVA: 0x00B863A0 File Offset: 0x00B845A0
		internal void SetValues()
		{
			short num = (short)615972864;
			short num2 = num;
			num = (short)1749746953;
			short num3 = num;
			num = (short)608371977;
			switch (num3 == num)
			{
			}
			num = (short)949878785;
			if (num != 0)
			{
			}
			num = (short)877068288;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_FREQUENCYOPTIONS;
			base.KeySeed = global::CommonResources.AcgResources.ID_OPTION;
			base.DataTransferOrder = 44;
		}

		// Token: 0x0600C4B6 RID: 50358 RVA: 0x00B86478 File Offset: 0x00B84678
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1478361088;
			short num2 = num;
			num = (short)1375826980;
			short num3 = num;
			num = (short)1693479972;
			switch (num3 == num)
			{
			}
			num = (short)1040121857;
			if (num != 0)
			{
			}
			num = (short)265486336;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord();
			this.f(record);
		}

		// Token: 0x0600C4B7 RID: 50359 RVA: 0x00B86530 File Offset: 0x00B84730
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)334299136;
			short num2 = num;
			num = (short)502990974;
			short num3 = num;
			num = (short)1509502;
			switch (num3 == num)
			{
			}
			num = (short)1306460161;
			if (num != 0)
			{
			}
			num = (short)1091960832;
			if (num != 0)
			{
			}
			base.OnFinishedRemoveRecord();
			this.e(record);
		}

		// Token: 0x0600C4B8 RID: 50360 RVA: 0x00B865E8 File Offset: 0x00B847E8
		protected override void OnFinishedMoveRecord(global::AcpCommonLib.IAcpFeatureNode record, global::AcpCommonLib.IAcpFeatureNode targetRecord)
		{
			short num = (short)1961230336;
			short num2 = num;
			num = (short)2059812574;
			short num3 = num;
			num = (short)1887387358;
			switch (num3 == num)
			{
			}
			num = (short)1552875520;
			if (num != 0)
			{
			}
			num = (short)20840449;
			if (num != 0)
			{
			}
			base.OnFinishedMoveRecord();
			this.a(record, targetRecord);
		}

		// Token: 0x0600C4B9 RID: 50361 RVA: 0x00B866A0 File Offset: 0x00B848A0
		private void f(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1281163264;
			short num2 = num;
			num = (short)729677825;
			if (num != 0)
			{
			}
			num = (short)743075297;
			short num3 = num;
			num = (short)1757638113;
			switch (num3 == num)
			{
			}
			num = (short)941555712;
			if (num != 0)
			{
			}
			this.d(A_0);
			this.c(A_0);
			this.b(A_0);
			this.a(A_0);
		}

		// Token: 0x0600C4BA RID: 50362 RVA: 0x00B86764 File Offset: 0x00B84964
		private void e(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)355532800;
			short num2 = num;
			num = (short)1463407393;
			short num3 = num;
			num = (short)1230295841;
			switch (num3 == num)
			{
			}
			num = (short)15663105;
			if (num != 0)
			{
			}
			num = (short)1544683520;
			if (num != 0)
			{
			}
			this.c(A_0);
			this.b(A_0);
		}

		// Token: 0x0600C4BB RID: 50363 RVA: 0x00B8681C File Offset: 0x00B84A1C
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0, global::AcpCommonLib.IAcpFeatureNode A_1)
		{
			short num = (short)1712062464;
			short num2 = num;
			num = (short)1869742081;
			if (num != 0)
			{
			}
			num = (short)451295108;
			short num3 = num;
			num = (short)2122921860;
			switch (num3 == num)
			{
			}
			num = (short)838664192;
			if (num != 0)
			{
			}
			this.c(A_0);
			this.b(A_0);
		}

		// Token: 0x0600C4BC RID: 50364 RVA: 0x00B868D8 File Offset: 0x00B84AD8
		private void d(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)223215617;
			if (num != 0)
			{
			}
			num = (short)1487863812;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					goto IL_1AB;
				case 2:
					num = (short)22544390;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection frequencyOptionsInnerSection;
					frequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.SetValue(12851);
					num = (short)978518016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					num = (short)1769117703;
					short num3 = num;
					num = (short)1216845831;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AB;
					default:
						num = (short)1017249792;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_C2;
						}
						continue;
					}
					break;
				}
				case 5:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Signaling signaling;
					if (signaling.CnvPerSignalingDigitalModulatorType_A7857.Value == 0)
					{
						num = (short)2140864515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 6:
				{
					num = (short)890634240;
					short num4 = num;
					if (global::AcpCommonLib.AppInfoManager.AddDefaultRecord)
					{
						num = (short)532676617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 7:
					if (A_0.Parent.ParentSection != null)
					{
						num = (short)1454309386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.RxOptions rxOptions;
					if (rxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.Value == 2)
					{
						num = (short)873332737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 9:
					num = (short)1721237511;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = A_0.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection frequencyOptionsInnerSection = A_0[10149] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.RxOptions rxOptions = conventionalPersonality[10136] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.RxOptions;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Signaling signaling = conventionalPersonality[10144] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Signaling;
					num = (short)1105985544;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_C2:
				if (!global::AcpCommonLib.AppInfoManager.UndoRedoInProgress)
				{
					num = (short)612630530;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1AB:
				num = (short)378863621;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600C4BD RID: 50365 RVA: 0x00B86B64 File Offset: 0x00B84D64
		private void c(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset frequencyOptionsInnerRecset;
			short num2;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
				switch (num)
				{
				case 0:
				{
					if (frequencyOptionsInnerRecset.ParentSection != null)
					{
						num2 = (short)383123457;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)436252835;
					short num3 = num2;
					num2 = (short)1020637347;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3D9;
					default:
						num2 = (short)1019674624;
						if (num2 != 0)
						{
						}
						num2 = (short)1676804097;
						if (num2 != 0)
						{
						}
						num2 = (short)870383618;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if ((frequencyOptionsInnerRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality).Features.CnvPerFeaturesMixedVoteScanEnable_A38723.Value)
					{
						goto IL_3D9;
					}
					return;
				case 2:
					return;
				case 3:
					try
					{
						num2 = (short)709427200;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_117;
								}
								continue;
							case 1:
								try
								{
									num2 = (short)1880424448;
									num = (int)((global::System.IntPtr)num2);
									for (;;)
									{
										switch (num)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_18D;
											}
											continue;
										case 2:
										{
											if (!enumerator.MoveNext())
											{
												num2 = (short)1930756099;
												num = (int)((global::System.IntPtr)num2);
												continue;
											}
											global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
											(featureNode as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner).ScanListInnerSection.ScanLstScanListChannel_A7620.CalculateVisibility();
											(featureNode as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner).ScanListInnerSection.ScanLstScanListChannel_A7620.CalculateApplicability();
											(featureNode as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner).ScanListInnerSection.ScanLstScanListChannel_A7620.CalculateValidity();
											num2 = (short)1342570497;
											num = (int)((global::System.IntPtr)num2);
											continue;
										}
										case 3:
											num2 = (short)626917380;
											num = (int)((global::System.IntPtr)num2);
											continue;
										case 4:
											goto IL_23B;
										}
										IL_18F:
										num2 = (short)283443202;
										num = (int)((global::System.IntPtr)num2);
										continue;
										IL_18D:
										goto IL_18F;
									}
									IL_23B:
									break;
								}
								finally
								{
									num2 = (short)1014300672;
									num = (int)((global::System.IntPtr)num2);
									for (;;)
									{
										switch (num)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_271;
											}
											continue;
										case 1:
											enumerator.Dispose();
											num2 = (short)525467650;
											num = (int)((global::System.IntPtr)num2);
											continue;
										case 2:
											goto IL_2A5;
										}
										IL_271:
										if (enumerator == null)
										{
											break;
										}
										num2 = (short)737869825;
										num = (int)((global::System.IntPtr)num2);
									}
									IL_2A5:;
								}
								goto IL_2A8;
							case 2:
								if (!enumerator2.MoveNext())
								{
									num2 = (short)958267395;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_2A8;
							case 3:
								num2 = (short)1654259716;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 4:
								goto IL_300;
							}
							IL_119:
							num2 = (short)1895104514;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_117:
							goto IL_119;
							IL_2A8:
							enumerator = (((global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList)enumerator2.Current)[10132].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset).GetEnumerator();
							num2 = (short)322764801;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_300:
						return;
					}
					finally
					{
						num2 = (short)1476001792;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_335;
								}
								continue;
							case 1:
								enumerator2.Dispose();
								num2 = (short)1913389058;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_369;
							}
							IL_335:
							if (enumerator2 == null)
							{
								break;
							}
							num2 = (short)1131020289;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_369:;
					}
					goto IL_36C;
				case 4:
					goto IL_36C;
				}
				goto IL_24;
				IL_36C:
				enumerator2 = (global::AcpCommonLib.FeatureManager.GetFeature(2057) as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset).GetEnumerator();
				num2 = (short)917045251;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3D9:
				num2 = (short)2029846528;
				short num4 = num2;
				num2 = (short)893386756;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_24:
			frequencyOptionsInnerRecset = (A_0.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset);
			num2 = (short)23724032;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600C4BE RID: 50366 RVA: 0x00B86FC4 File Offset: 0x00B851C4
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)872415232;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset frequencyOptionsInnerRecset2;
				for (;;)
				{
					IL_29:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset frequencyOptionsInnerRecset;
						if (frequencyOptionsInnerRecset.ParentSection == null)
						{
							num = (short)1369440258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = frequencyOptionsInnerRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
						frequencyOptionsInnerRecset2 = (A_0.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset);
						num = (short)1418264577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_3C8;
					case 2:
						return;
					case 3:
						try
						{
							num = (short)423690246;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									num = (short)861405187;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
									if (frequencyOptionsInner != null)
									{
										num = (short)23461889;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									if (!global::AcpCommonLib.ConstraintManager.Suspended)
									{
										num = (short)108658696;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)283705351;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner)enumerator.Current;
									num = (short)1892417538;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality.Features.CnvPerFeaturesMixedVoteScanEnable_A38723.Value)
									{
										num = (short)711327754;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_138;
									}
									continue;
								case 7:
									num = (short)911605772;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)1665597445;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
									frequencyOptionsInner.CalculateVisibility();
									frequencyOptionsInner.CalculateApplicability();
									frequencyOptionsInner.CalculateValidity();
									num = (short)400687104;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									num = (short)67239947;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (!conventionalPersonality.Features.CnvPerFeaturesMixedVoteScanTxSteering_A38878.Value)
									{
										num = (short)953286665;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
									goto IL_2D5;
								}
								IL_166:
								num = (short)208142340;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_138:
								goto IL_166;
							}
							IL_2D5:
							return;
						}
						finally
						{
							num = (short)2006122496;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_30C;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)817758210;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_341;
								}
								IL_30C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1186856961;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_341:;
						}
						goto IL_344;
					case 4:
						goto IL_344;
					}
					goto IL_44;
					IL_344:
					num = (short)1145765888;
					short num3 = num;
					enumerator = frequencyOptionsInnerRecset2.GetEnumerator();
					num = (short)1478426627;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_3C8:
				num = (short)1636302849;
				if (num != 0)
				{
				}
				if (frequencyOptionsInnerRecset2 != null)
				{
					goto IL_3F3;
				}
				return;
				IL_44:
				num = (short)720260886;
				short num4 = num;
				num = (short)2129678102;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_3F3:
					num = (short)975372292;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_29;
				default:
				{
					num = (short)1481310208;
					if (num != 0)
					{
					}
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset frequencyOptionsInnerRecset = A_0.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset;
					num = (short)661520384;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_29;
				}
				}
				break;
			}
			}
		}

		// Token: 0x0600C4BF RID: 50367 RVA: 0x00B87400 File Offset: 0x00B85600
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)363921408;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_70;
				}
				bool flag2;
				for (;;)
				{
					IL_29:
					bool flag;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 0)
						{
							num = (short)1184038925;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_359;
					}
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						flag = conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.Value;
						goto IL_33A;
					}
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.Value || flag2)
						{
							num = (short)126287875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection frequencyOptionsInnerSection;
						frequencyOptionsInnerSection.CnvPerConventionalChannelOptionsDirectTalkaround_A9255.SetValue(false);
						num = (short)1851654154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.Value == 2)
						{
							num = (short)12320775;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_102;
					}
					case 5:
					{
						num = (short)120650150;
						short num3 = num;
						num = (short)1596520870;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)1556217856;
							if (num != 0)
							{
							}
							if (A_0.Parent.ParentSection != null)
							{
								num = (short)929038345;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					case 6:
						num = (short)1369047044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.ReferencedNode;
						num = (short)1413021710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality != null)
						{
							num = (short)1875116038;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = A_0.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection frequencyOptionsInnerSection = A_0[10149] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection;
						num = (short)659292168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						return;
					case 11:
						goto IL_102;
					case 12:
						num = (short)820445184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)127074305;
						if (num != 0)
						{
						}
						num = (short)1816985601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem != null)
						{
							num = (short)1813512192;
							short num4 = num;
							num = (short)94371852;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_359;
					}
					case 15:
						flag = false;
						goto IL_33A;
					}
					goto IL_70;
					IL_102:
					num = (short)530382850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33A:
					flag2 = flag;
					num = (short)117702667;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_359:
					num = (short)792723471;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_70:
				flag2 = false;
				num = (short)388825093;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600C4C0 RID: 50368 RVA: 0x00B87784 File Offset: 0x00B85984
		// Note: this type is marked as 'beforefieldinit'.
		static FrequencyOptionsInnerRecset()
		{
			short num = (short)1778057216;
			short num2 = num;
			num = (short)1226854172;
			short num3 = num;
			num = (short)948391708;
			switch (num3 == num)
			{
			}
			num = (short)1194459136;
			if (num != 0)
			{
			}
			num = (short)1130102785;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset._Min = 1;
		}

		// Token: 0x0400648A RID: 25738
		public static int _MaxPool;

		// Token: 0x0400648B RID: 25739
		public static int _Max;

		// Token: 0x0400648C RID: 25740
		public int _DynMax;

		// Token: 0x0400648D RID: 25741
		public static int _Min;

		// Token: 0x0400648E RID: 25742
		public static int _DefaultRecordCount;
	}
}
