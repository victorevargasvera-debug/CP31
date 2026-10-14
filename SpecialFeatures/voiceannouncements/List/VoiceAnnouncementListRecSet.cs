using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements.List
{
	// Token: 0x02000030 RID: 48
	[global::System.Serializable]
	public sealed class VoiceAnnouncementListRecSet : global::AcpBusinessLayer.Recordset, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06000672 RID: 1650 RVA: 0x000026C1 File Offset: 0x000008C1
		public VoiceAnnouncementListRecSet() : base(global::CommonResources.AppResources.Voice_Announcement_List, true, false, false)
		{
			this.SetValues();
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0005EB7C File Offset: 0x0005CD7C
		public new void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1828395259;
			short num2 = num;
			num = (short)346691835;
			switch (num2 == num)
			{
			}
			num = (short)1913585665;
			if (num != 0)
			{
			}
			num = (short)1488191488;
			if (num != 0)
			{
			}
			num = (short)504037376;
			short num3 = num;
			base.GetObjectData(info, context);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0005EC30 File Offset: 0x0005CE30
		internal VoiceAnnouncementListRecSet(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 10;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﲒ", a_));
			}
			this.SetValues();
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x0005EC70 File Offset: 0x0005CE70
		public override int MaxPool
		{
			get
			{
				short num = (short)568172134;
				short num2 = num;
				num = (short)333749862;
				switch (num2 == num)
				{
				}
				num = (short)722272256;
				if (num != 0)
				{
				}
				num = (short)38928385;
				if (num != 0)
				{
				}
				num = (short)102498304;
				short num3 = num;
				return global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet._MaxPool;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x0005ED20 File Offset: 0x0005CF20
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x0005EDE0 File Offset: 0x0005CFE0
		public override int Max
		{
			get
			{
				short num;
				while (this._DynMax != -1)
				{
					num = (short)1638207449;
					short num2 = num;
					num = (short)981012441;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)338231297;
						if (num != 0)
						{
						}
						num = (short)1023541248;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
				}
				num = (short)649461760;
				short num3 = num;
				return global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet._Max;
			}
			set
			{
				short num = (short)948908421;
				short num2 = num;
				num = (short)1699885445;
				switch (num2 == num)
				{
				}
				num = (short)559218689;
				if (num != 0)
				{
				}
				num = (short)2132410368;
				if (num != 0)
				{
				}
				num = (short)24182784;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x0005EE90 File Offset: 0x0005D090
		public override int Min
		{
			get
			{
				short num = (short)979002735;
				short num2 = num;
				num = (short)757228911;
				switch (num2 == num)
				{
				}
				num = (short)573046785;
				if (num != 0)
				{
				}
				num = (short)1183318016;
				if (num != 0)
				{
				}
				num = (short)1212022784;
				short num3 = num;
				return global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet._Min;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x0005EF40 File Offset: 0x0005D140
		public override int CounterToMax
		{
			get
			{
				short num;
				while (this.CumulativeMax < global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.MaxVoiceFilesTotalMS)
				{
					num = (short)376176641;
					if (num != 0)
					{
					}
					num = (short)913642011;
					short num2 = num;
					num = (short)1265832475;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)28639232;
						if (num != 0)
						{
						}
						return this.Max - base.Count;
					}
				}
				num = (short)1973420032;
				short num3 = num;
				return 0;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x0005F00C File Offset: 0x0005D20C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1144667254;
				short num2 = num;
				num = (short)1173765238;
				switch (num2 == num)
				{
				}
				num = (short)1583808512;
				if (num != 0)
				{
				}
				num = (short)1994457089;
				if (num != 0)
				{
				}
				num = (short)584712192;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0005F0BC File Offset: 0x0005D2BC
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)2101805059;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E2;
				case 1:
				{
					string text = global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.voiceFiles[global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.vaCount++];
					global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList = record as global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList;
					global::AcpBusinessLayer.AcpVoiceFileStruct acpVoiceFileStruct = new global::AcpBusinessLayer.AcpVoiceFileStruct(text);
					voiceAnnouncementList.General.VoiceAnnouncementEncodeType_A22264.SetValue(1);
					voiceAnnouncementList.General.VoiceAnnouncementFileHashcode_A24563.SetValue(acpVoiceFileStruct.hashcode);
					voiceAnnouncementList.General.VoiceFileDataInfo_A21213.SetValue(acpVoiceFileStruct);
					voiceAnnouncementList.General.VoiceFileName_A21220Object.Value = global::System.IO.Path.GetFileNameWithoutExtension(text);
					num = (short)2027749381;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					try
					{
						string text;
						global::System.IO.File.Delete(text);
						return;
					}
					catch (global::System.Exception)
					{
						return;
					}
					goto IL_E2;
				case 3:
					num = (short)649003009;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 4:
					if (global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.voiceFiles.Length <= global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.vaCount)
					{
						goto IL_10B;
					}
					return;
				case 5:
					if (global::ConstraintHelper.UtilityMack.bOpenFromRMC)
					{
						num = (short)2026307584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_62:
				if (!global::AcpCommonLib.AppInfoManager.LoadingVoiceData)
				{
					break;
				}
				num = (short)673853817;
				short num3 = num;
				num = (short)1234514297;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_10B;
				default:
					num = (short)1767636992;
					if (num != 0)
					{
					}
					num = (short)1152778241;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_E2:
				num = (short)296026116;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_10B:
				num = (short)1160642560;
				short num4 = num;
				num = (short)2131099650;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0005F2D4 File Offset: 0x0005D4D4
		public override void IncrementCumulativeMax(global::AcpCommonLib.IAcpFeatureNode record)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1454440455;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_166;
				case 2:
					base.SetRecordValidity(record, false);
					goto IL_74;
				case 3:
				{
					num2 = (short)996868097;
					if (num2 != 0)
					{
					}
					int voiceFileDuration = voiceAnnouncementList.General.VoiceFileDataInfo_A21213Value.getVoiceFileDuration();
					this.CumulativeMax += voiceFileDuration;
					num2 = (short)1116602374;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					goto IL_1AE;
				case 5:
					if (voiceAnnouncementList != null)
					{
						num2 = (short)1418592256;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AE;
				case 6:
					if (this.CumulativeMax > global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.MaxVoiceFilesTotalMS)
					{
						num2 = (short)1372061698;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_166;
				case 7:
					if (voiceAnnouncementList.General.VoiceFileDataInfo_A21213Value.voiceData != null)
					{
						num2 = (short)1901330435;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AE;
				}
				goto IL_30;
				IL_74:
				num2 = (short)333905921;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1AE:
				num2 = (short)1901422891;
				short num3 = num2;
				num2 = (short)1395747115;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_74;
				default:
					goto IL_1E4;
				}
				IL_166:
				num2 = (short)2002845696;
				short num4 = num2;
				base.CalculateEditability();
				num2 = (short)383844356;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1E4:
			num2 = (short)541196288;
			if (num2 != 0)
			{
			}
			return;
			IL_30:
			voiceAnnouncementList = (record as global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList);
			num2 = (short)282001413;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0005F4DC File Offset: 0x0005D6DC
		public override void DecrementCumulativeMax(global::AcpCommonLib.IAcpFeatureNode record)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					base.SetRecordValidity(record, true);
					num2 = (short)432537603;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					int voiceFileDuration;
					this.CumulativeMax -= voiceFileDuration;
					num2 = (short)1557987332;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_7B;
				case 3:
					num2 = (short)1563820033;
					if (num2 != 0)
					{
					}
					goto IL_1B0;
				case 4:
					goto IL_7B;
				case 5:
				{
					int voiceFileDuration = voiceAnnouncementList.General.VoiceFileDataInfo_A21213Value.getVoiceFileDuration();
					num2 = (short)1396703242;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					if (this.CumulativeMax <= global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.MaxVoiceFilesTotalMS)
					{
						num2 = (short)2091188224;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B0;
				case 7:
					return;
				case 8:
					if (voiceAnnouncementList != null)
					{
						num2 = (short)1063714825;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 9:
					goto IL_1D2;
				case 10:
				{
					int voiceFileDuration;
					if (this.CumulativeMax > voiceFileDuration)
					{
						num2 = (short)438697985;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)436361391;
					short num3 = num2;
					num2 = (short)4217007;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D2;
					default:
					{
						num2 = (short)1577320448;
						if (num2 != 0)
						{
						}
						this.CumulativeMax = 0;
						num2 = (short)435683328;
						short num4 = num2;
						num2 = (short)1001586690;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 11:
					if (voiceAnnouncementList.General.VoiceFileDataInfo_A21213Value.voiceData != null)
					{
						num2 = (short)1533476869;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_40;
				IL_7B:
				num2 = (short)1106378758;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1B0:
				base.CalculateEditability();
				num2 = (short)2124152839;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1D2:
				num2 = (short)203882507;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_40:
			voiceAnnouncementList = (record as global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList);
			num2 = (short)1769865224;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0005F77C File Offset: 0x0005D97C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1413611521;
			if (num != 0)
			{
			}
			num = (short)819755170;
			short num2 = num;
			num = (short)1328117922;
			switch (num2 == num)
			{
			}
			num = (short)1538064384;
			if (num != 0)
			{
			}
			num = (short)541065216;
			short num3 = num;
			return new global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList(this);
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x0005F82C File Offset: 0x0005DA2C
		public static int MaxVoiceFilesTotalMS
		{
			get
			{
				short num = (short)129655445;
				short num2 = num;
				num = (short)599220885;
				switch (num2 == num)
				{
				}
				num = (short)1299185665;
				if (num != 0)
				{
				}
				num = (short)789184512;
				if (num != 0)
				{
				}
				num = (short)827654144;
				short num3 = num;
				return 1000000;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x0005F8E0 File Offset: 0x0005DAE0
		internal static int VoiceFilesTotalMS
		{
			get
			{
				short num = (short)1986658304;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_3B;
					}
					global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet voiceAnnouncementListRecSet;
					int num4;
					for (;;)
					{
						IL_28:
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
							goto IL_27C;
						case 1:
							if (voiceAnnouncementListRecSet != null)
							{
								num = (short)1341718528;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A1;
						case 2:
							try
							{
								num = (short)1487405060;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										if (!enumerator.MoveNext())
										{
											goto IL_10E;
										}
										global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList = (global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList)enumerator.Current;
										num = (short)259719169;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
									{
										num = (short)284977016;
										short num3 = num;
										num = (short)670590840;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_10E;
										default:
										{
											num = (short)1470431232;
											if (num != 0)
											{
											}
											global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
											if (voiceAnnouncementList.General.VoiceFileName_A21220_Valid)
											{
												num = (short)724172803;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										}
										break;
									}
									case 2:
										goto IL_20B;
									case 3:
									{
										global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
										num4 += voiceAnnouncementList.General.VoiceFileDataInfo_A21213Value.getVoiceFileDuration();
										num = (short)553451526;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_EF;
										}
										continue;
									case 5:
										num = (short)93650946;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_F1:
									num = (short)1511718912;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_EF:
									goto IL_F1;
									IL_10E:
									num = (short)684064773;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_20B:
								goto IL_2A1;
							}
							finally
							{
								num = (short)1695547393;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										num = (short)1696464898;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_243;
										}
										continue;
									case 2:
										goto IL_279;
									}
									IL_243:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1189740544;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_279:;
							}
							goto IL_27C;
						}
						goto IL_3B;
						IL_27C:
						enumerator = voiceAnnouncementListRecSet.GetEnumerator();
						num = (short)631046146;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2A1:
					num = (short)1542389761;
					if (num != 0)
					{
					}
					return num4;
					IL_3B:
					num = (short)450363392;
					short num5 = num;
					num4 = 0;
					voiceAnnouncementListRecSet = (global::AcpCommonLib.FeatureManager.GetFeature(2300) as global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet);
					num = (short)977403905;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
			}
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0005FBD4 File Offset: 0x0005DDD4
		internal void SetValues()
		{
			int a_ = 13;
			short num = (short)1598900359;
			short num2 = num;
			num = (short)1756317831;
			switch (num2 == num)
			{
			}
			num = (short)1636499457;
			if (num != 0)
			{
			}
			num = (short)1603207168;
			if (num != 0)
			{
			}
			num = (short)1598685184;
			short num3 = num;
			this._DynMax = -1;
			base.Id = 2300;
			base.SingleInstance = false;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎏ﮙ\ud89d얟쎡킣펥\udaa7쾩\udfab閭\uddb1\ud9b3욵ힷ풹\ud9bb킽뒿黁鋃꧅ꇇ꧉꧋迍뻏병믓ꏕ뛗맙맛돝藟賡郣闥듧볩菫蟭鏯韱뗳飵雷闹觻都揿朁椃挅昇縉䀋服挏昑䠓䀕眗猙缛笝感䰡䨣䤥崧䐩伫䬭崯圱娳䈵琷匹伻䨽ᐿ⁁⡃桅ぇ⭉⅋≍", a_);
			base.UIName = global::CommonResources.AppResources.Voice_Announcement_List;
			base.DataTransferOrder = 41;
			base.HideRecordsFromTree = true;
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0005FCD0 File Offset: 0x0005DED0
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1260978176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_81;
				}
				global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet voiceAnnouncementListRecSet;
				for (;;)
				{
					IL_28:
					num = (short)618659840;
					short num3 = num;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
					switch (num2)
					{
					case 0:
						num = (short)844955649;
						if (num != 0)
						{
						}
						if (zoneChannelAssignmentRecset.Count > 0)
						{
							num = (short)1863516164;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						try
						{
							num = (short)1972437000;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset;
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
								switch (num2)
								{
								case 0:
									if (channelAssignmentListInnerRecset != null)
									{
										num = (short)1878917122;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									zoneChannelAssignment.Zone.ZoneVoiceAnnouncementID_A21514.ResetToDefaultWithUndo();
									num = (short)40566791;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)3735563;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									try
									{
										num = (short)1655177217;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
												channelAssignmentListInner.ChannelAssignmentListInnerSection.ChannelAnnouncementID_A20175.ResetToDefaultWithUndo();
												num = (short)1061683205;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
												switch (0)
												{
												case 0:
													goto IL_37D;
												}
												continue;
											case 2:
												num = (short)1181679620;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)1810759682;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner)enumerator.Current;
												num = (short)1799618566;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												goto IL_466;
											case 6:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
												if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ChannelAnnouncementID_A20175_UIValue == channelAssignmentListInner.ChannelAssignmentListInnerSection.ChannelAnnouncementID_A20175.InvalidText)
												{
													num = (short)2064252928;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											}
											IL_37F:
											num = (short)1810104323;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_37D:
											goto IL_37F;
										}
										IL_466:
										break;
									}
									finally
									{
										num = (short)684916736;
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
													goto IL_49E;
												}
												continue;
											case 1:
												goto IL_4D6;
											case 2:
												enumerator.Dispose();
												num = (short)1605894145;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_49E:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1373044738;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_4D6:;
									}
									goto IL_4D9;
								case 4:
									goto IL_4F2;
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = channelAssignmentListInnerRecset.GetEnumerator();
									num = (short)83165187;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_4D9;
								case 7:
									goto IL_1F4;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_1B3;
									}
									continue;
								case 9:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)684851206;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									zoneChannelAssignment = (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment)enumerator2.Current;
									num = (short)1099300874;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									if (zoneChannelAssignment.Zone.ZoneVoiceAnnouncementID_A21514_UIValue == zoneChannelAssignment.Zone.ZoneVoiceAnnouncementID_A21514.InvalidText)
									{
										num = (short)42598401;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1F4;
								case 11:
									if (channelAssignmentListInnerRecset.Count > 0)
									{
										num = (short)1864761349;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_1B8:
								num = (short)161611785;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1B3:
								goto IL_1B8;
								IL_1F4:
								channelAssignmentListInnerRecset = (zoneChannelAssignment.Channels.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset);
								num = (short)81461248;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4D9:
								num = (short)757858308;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4F2:
							return;
						}
						finally
						{
							for (;;)
							{
								IL_4F7:
								num = (short)1377959936;
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
											goto IL_52A;
										}
										continue;
									case 1:
										goto IL_5B2;
									case 2:
									{
										num = (short)366035462;
										short num4 = num;
										num = (short)167264774;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_4F7;
										default:
											num = (short)1866727424;
											if (num != 0)
											{
											}
											enumerator2.Dispose();
											num = (short)916193281;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									IL_52A:
									if (enumerator2 == null)
									{
										goto IL_5B4;
									}
									num = (short)1206648834;
									num2 = (int)((global::System.IntPtr)num);
								}
							}
							IL_5B2:
							IL_5B4:;
						}
						goto IL_5B5;
					case 2:
						if (zoneChannelAssignmentRecset != null)
						{
							num = (short)369754120;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						if (voiceAnnouncementListRecSet.Count > 0)
						{
							num = (short)1337982985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EA;
					case 4:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = zoneChannelAssignmentRecset.GetEnumerator();
						num = (short)2061959169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						try
						{
							num = (short)467075072;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_6AE;
									}
									continue;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1201602567;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList = (global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList)enumerator2.Current;
									num = (short)783482882;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
									if (voiceAnnouncementList.General.VoiceFileName_A21220_Valid)
									{
										num = (short)1759248388;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_7CE;
								case 4:
								{
									global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
									int num5;
									num5 += voiceAnnouncementList.General.VoiceFileDataInfo_A21213Value.getVoiceFileDuration();
									num = (short)1631059974;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									int num5;
									if (num5 > global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.MaxVoiceFilesTotalMS)
									{
										num = (short)856948744;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									num = (short)239927299;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
									base.SetRecordValidity(voiceAnnouncementList, false);
									num = (short)1994588165;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_775:
								num = (short)483655681;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6AE:
								goto IL_775;
							}
							IL_7CE:
							goto IL_EA;
						}
						finally
						{
							num = (short)2105212928;
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
										goto IL_805;
									}
									continue;
								case 1:
									goto IL_83D;
								case 2:
									enumerator2.Dispose();
									num = (short)819855361;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_805:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)486604802;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_83D:;
						}
						return;
					case 6:
						if (voiceAnnouncementListRecSet != null)
						{
							num = (short)946536455;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EA;
					case 7:
						goto IL_5B5;
					case 8:
						num = (short)1733820416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						int num5 = 0;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = voiceAnnouncementListRecSet.GetEnumerator();
						num = (short)869072901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_81;
					IL_EA:
					zoneChannelAssignmentRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset);
					num = (short)2047279106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B5:
					num = (short)799145987;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_81:
				voiceAnnouncementListRecSet = (global::AcpCommonLib.FeatureManager.GetFeature(2300) as global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet);
				num = (short)142934022;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0006056C File Offset: 0x0005E76C
		protected override void OnFinishedMoveRecord(global::AcpCommonLib.IAcpFeatureNode draggedRecord, global::AcpCommonLib.IAcpFeatureNode targetRecord)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1759379456;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_43;
					}
					global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet voiceAnnouncementListRecSet;
					for (;;)
					{
						IL_28:
						int num5;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
							goto IL_2B0;
						case 1:
						{
							num = (short)756809728;
							short num3 = num;
							if (voiceAnnouncementListRecSet != null)
							{
								num = (short)71499778;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						case 2:
						{
							num = (short)1645156254;
							short num4 = num;
							num = (short)1891964830;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)1822294016;
								if (num != 0)
								{
								}
								num = (short)435552259;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							if (voiceAnnouncementListRecSet.Count > 0)
							{
								num = (short)1563426816;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 4:
							num = (short)178585601;
							if (num != 0)
							{
							}
							try
							{
								num = (short)346095617;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 1:
										switch (0)
										{
										case 0:
											goto IL_104;
										}
										continue;
									case 2:
									{
										if (num5 > global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.MaxVoiceFilesTotalMS)
										{
											num = (short)1496711176;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
										base.SetRecordValidity(voiceAnnouncementList, true);
										num = (short)705953795;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
										num5 += voiceAnnouncementList.General.VoiceFileDataInfo_A21213Value.getVoiceFileDuration();
										num = (short)354615298;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)670498825;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList = (global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList)enumerator.Current;
										num = (short)1165099014;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
									{
										global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
										if (voiceAnnouncementList.General.VoiceFileName_A21220_Valid)
										{
											num = (short)1497759748;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 7:
										goto IL_23F;
									case 8:
									{
										global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
										base.SetRecordValidity(voiceAnnouncementList, false);
										num = (short)600375296;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
										num = (short)1351417863;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_171:
									num = (short)995491845;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_104:
									goto IL_171;
								}
								IL_23F:
								return;
							}
							finally
							{
								num = (short)376438784;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_276;
										}
										continue;
									case 1:
										goto IL_2AD;
									case 2:
										enumerator.Dispose();
										num = (short)1417805825;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_276:
									if (enumerator == null)
									{
										break;
									}
									num = (short)992739330;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2AD:;
							}
							goto IL_2B0;
						}
						break;
						IL_2B0:
						num5 = 0;
						enumerator = voiceAnnouncementListRecSet.GetEnumerator();
						num = (short)130744324;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_43:
					voiceAnnouncementListRecSet = (global::AcpCommonLib.FeatureManager.GetFeature(2300) as global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet);
					num = (short)1266417665;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
			}
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0006091C File Offset: 0x0005EB1C
		// Note: this type is marked as 'beforefieldinit'.
		static VoiceAnnouncementListRecSet()
		{
			short num = (short)1784114180;
			short num2 = num;
			num = (short)740256772;
			switch (num2 == num)
			{
			}
			num = (short)1066008576;
			if (num != 0)
			{
			}
			num = (short)56885249;
			if (num != 0)
			{
			}
			num = (short)61014016;
			short num3 = num;
			global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.vaCount = 0;
			global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet._MaxPool = int.MaxValue;
			global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet._Max = 5000;
			global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet._Min = 1;
		}

		// Token: 0x04000288 RID: 648
		public static string[] voiceFiles;

		// Token: 0x04000289 RID: 649
		public static int vaCount;

		// Token: 0x0400028A RID: 650
		public static int _MaxPool;

		// Token: 0x0400028B RID: 651
		public static int _Max;

		// Token: 0x0400028C RID: 652
		internal int _DynMax;

		// Token: 0x0400028D RID: 653
		public static int _Min;
	}
}
