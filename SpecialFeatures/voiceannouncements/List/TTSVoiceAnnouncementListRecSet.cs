using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using ConstraintHelper;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements.List
{
	// Token: 0x0200002B RID: 43
	[global::System.Serializable]
	public sealed class TTSVoiceAnnouncementListRecSet : global::AcpBusinessLayer.Recordset, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x060005FD RID: 1533 RVA: 0x00057840 File Offset: 0x00055A40
		public TTSVoiceAnnouncementListRecSet()
		{
			int a_ = 12;
			base..ctor(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솎ﺐﶒ뢔킖처튚붜쮞薤욨슪캬쪮醰\udbb4\ud9b6횸캺펼\udcbe꓀껂ꃄ꧆뷈臌ꛎꋐ꟒", a_), true, false, false);
			this.SetValues();
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00057874 File Offset: 0x00055A74
		public new void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1686462595;
			short num2 = num;
			num = (short)81551491;
			switch (num2 == num)
			{
			}
			num = (short)2044002304;
			short num3 = num;
			num = (short)612892673;
			if (num != 0)
			{
			}
			num = (short)57540608;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00057928 File Offset: 0x00055B28
		internal TTSVoiceAnnouncementListRecSet(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 9;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("﶑", a_));
			}
			this.SetValues();
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x00057968 File Offset: 0x00055B68
		public override int MaxPool
		{
			get
			{
				short num = (short)1856503809;
				if (num != 0)
				{
				}
				num = (short)135548747;
				short num2 = num;
				num = (short)1132613451;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1773207552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)858521600;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet._MaxPool;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x00057A14 File Offset: 0x00055C14
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x00057AD8 File Offset: 0x00055CD8
		public override int Max
		{
			get
			{
				if (this._DynMax != -1)
				{
					short num = (short)1655193967;
					short num2 = num;
					num = (short)1854226799;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2013003776;
						if (num != 0)
						{
						}
						num = (short)1269301249;
						if (num != 0)
						{
						}
						num = (short)317784064;
						short num3 = num;
						return this._DynMax;
					}
					}
				}
				return global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet._Max;
			}
			set
			{
				short num = (short)1879965697;
				if (num != 0)
				{
				}
				num = (short)1975869478;
				short num2 = num;
				num = (short)989028390;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2119761920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1437138944;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00057B88 File Offset: 0x00055D88
		public override int Min
		{
			get
			{
				short num = (short)1330741375;
				short num2 = num;
				num = (short)2015723647;
				switch (num2 == num)
				{
				}
				num = (short)202309632;
				short num3 = num;
				num = (short)495910913;
				if (num != 0)
				{
				}
				num = (short)59441152;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet._Min;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x00057C38 File Offset: 0x00055E38
		public override int CounterToMax
		{
			get
			{
				if (this.CumulativeMax >= global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet.MaxVoiceFilesTotalMS)
				{
					short num = (short)312016897;
					if (num != 0)
					{
					}
					num = (short)79708646;
					short num2 = num;
					num = (short)2098610662;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)72286208;
						short num3 = num;
						num = (short)1247215616;
						if (num != 0)
						{
						}
						break;
					}
					}
					return 0;
				}
				return this.Max - base.Count;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x00057D04 File Offset: 0x00055F04
		public bool HasDiffs
		{
			get
			{
				short num = (short)1171113105;
				short num2 = num;
				num = (short)630572177;
				switch (num2 == num)
				{
				}
				num = (short)1664286720;
				short num3 = num;
				num = (short)1496973312;
				if (num != 0)
				{
				}
				num = (short)817102849;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00057DB0 File Offset: 0x00055FB0
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)409075716;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet.voiceFiles.Length <= global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet.vaCount)
					{
						num = (short)1119944705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					try
					{
						num = (short)1363804161;
						if (num != 0)
						{
						}
						string text;
						global::System.IO.File.Delete(text);
						return;
					}
					catch (global::System.Exception)
					{
						return;
					}
					goto IL_9A;
				case 2:
				{
					string text = global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet.voiceFiles[global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet.vaCount++];
					global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList ttsvoiceAnnouncementList = record as global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList;
					global::AcpBusinessLayer.AcpVoiceFileStruct acpVoiceFileStruct = new global::AcpBusinessLayer.AcpVoiceFileStruct(text);
					ttsvoiceAnnouncementList.General.VoiceAnnouncementEncodeType_A22264.SetValue(1);
					ttsvoiceAnnouncementList.General.VoiceAnnouncementFileHashcode_A24563.SetValue(acpVoiceFileStruct.hashcode);
					ttsvoiceAnnouncementList.General.VoiceFileDataInfo_A21213.SetValue(acpVoiceFileStruct);
					ttsvoiceAnnouncementList.General.VoiceFileName_A21220Object.Value = global::System.IO.Path.GetFileNameWithoutExtension(text);
					num = (short)274268160;
					short num3 = num;
					num = (short)948699141;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_9A;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 5:
					if (global::ConstraintHelper.UtilityMack.bOpenFromRMC)
					{
						num = (short)1914765315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_3D:
				if (global::AcpCommonLib.AppInfoManager.LoadingVoiceData)
				{
					num = (short)1126891522;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9A:
				num = (short)548520181;
				short num4 = num;
				num = (short)2014363893;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)353501184;
					if (num != 0)
					{
					}
					num = (short)962265088;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00057FCC File Offset: 0x000561CC
		public override void IncrementCumulativeMax(global::AcpCommonLib.IAcpFeatureNode record)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			short num2;
			global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList ttsvoiceAnnouncementList;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					base.SetRecordValidity(record, false);
					num2 = (short)1989017601;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_1DA;
				case 2:
					if (ttsvoiceAnnouncementList.General.VoiceFileDataInfo_A21213Value.voiceData != null)
					{
						num2 = (short)2136080391;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					num2 = (short)1204748290;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (this.CumulativeMax > global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet.MaxVoiceFilesTotalMS)
					{
						num2 = (short)161021952;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1DA;
				case 5:
					return;
				case 6:
					if (ttsvoiceAnnouncementList != null)
					{
						num2 = (short)920977411;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 7:
				{
					num2 = (short)1352990721;
					if (num2 != 0)
					{
					}
					int voiceFileDuration = ttsvoiceAnnouncementList.General.VoiceFileDataInfo_A21213Value.getVoiceFileDuration();
					this.CumulativeMax += voiceFileDuration;
					num2 = (short)1208483844;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_30;
				IL_1DA:
				base.CalculateEditability();
				num2 = (short)1729167365;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_30:
			ttsvoiceAnnouncementList = (record as global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList);
			num2 = (short)1319895040;
			short num3 = num2;
			num2 = (short)1911794331;
			short num4 = num2;
			num2 = (short)196979355;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)102039552;
				if (num2 != 0)
				{
				}
				num2 = (short)1519976454;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x000581D4 File Offset: 0x000563D4
		public override void DecrementCumulativeMax(global::AcpCommonLib.IAcpFeatureNode record)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList ttsvoiceAnnouncementList;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (ttsvoiceAnnouncementList.General.VoiceFileDataInfo_A21213Value.voiceData != null)
					{
						num2 = (short)1177550852;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					num2 = (short)597164032;
					short num3 = num2;
					goto IL_15B;
				}
				case 2:
					goto IL_7B;
				case 3:
					goto IL_7B;
				case 4:
				{
					int voiceFileDuration = ttsvoiceAnnouncementList.General.VoiceFileDataInfo_A21213Value.getVoiceFileDuration();
					num2 = (short)1991704583;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
				{
					int voiceFileDuration;
					this.CumulativeMax -= voiceFileDuration;
					num2 = (short)491257859;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					num2 = (short)950337536;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					int voiceFileDuration;
					if (this.CumulativeMax > voiceFileDuration)
					{
						num2 = (short)1069088773;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.CumulativeMax = 0;
					num2 = (short)326565889;
					if (num2 != 0)
					{
					}
					num2 = (short)1009909762;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					if (ttsvoiceAnnouncementList != null)
					{
						num2 = (short)2064646150;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 9:
					for (;;)
					{
						base.SetRecordValidity(record, true);
						num2 = (short)368874907;
						short num4 = num2;
						num2 = (short)1271109019;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_203;
						}
					}
					IL_203:
					num2 = (short)535822336;
					if (num2 != 0)
					{
					}
					num2 = (short)98959361;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					return;
				case 11:
					if (this.CumulativeMax <= global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet.MaxVoiceFilesTotalMS)
					{
						num2 = (short)520880137;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_15B;
				}
				goto IL_40;
				IL_7B:
				num2 = (short)656277515;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_15B:
				base.CalculateEditability();
				num2 = (short)556597258;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_40:
			ttsvoiceAnnouncementList = (record as global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList);
			num2 = (short)270794760;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0005846C File Offset: 0x0005666C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)168560687;
			short num2 = num;
			num = (short)1214777391;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1346764800;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1136852992;
			if (num != 0)
			{
			}
			num = (short)1200357377;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList(this);
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x0005851C File Offset: 0x0005671C
		public static int MaxVoiceFilesTotalMS
		{
			get
			{
				short num = (short)95412002;
				short num2 = num;
				num = (short)525917986;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1602879488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)557580289;
				if (num != 0)
				{
				}
				num = (short)133234688;
				if (num != 0)
				{
				}
				return 1000000;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x000585CC File Offset: 0x000567CC
		internal static int VoiceFilesTotalMS
		{
			get
			{
				short num = (short)39714816;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					int num4;
					global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet ttsvoiceAnnouncementListRecSet;
					for (;;)
					{
						IL_27:
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
						{
							num = (short)86638592;
							short num3 = num;
							try
							{
								num = (short)1788149763;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 1:
									{
										global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList ttsvoiceAnnouncementList;
										if (ttsvoiceAnnouncementList.General.VoiceFileName_A21220_Valid)
										{
											num = (short)2064908293;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										num = (short)1960968196;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_EC;
										}
										continue;
									case 4:
										goto IL_1B9;
									case 5:
									{
										global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList ttsvoiceAnnouncementList;
										num4 += ttsvoiceAnnouncementList.General.VoiceFileDataInfo_A21213Value.getVoiceFileDuration();
										num = (short)1184301056;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)718012418;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList ttsvoiceAnnouncementList = (global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList)enumerator.Current;
										num = (short)1773338625;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_EE:
									num = (short)1810956294;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_EC:
									goto IL_EE;
								}
								IL_1B9:
								return num4;
							}
							finally
							{
								num = (short)1403125762;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_274;
									case 1:
										enumerator.Dispose();
										goto IL_25C;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_1F0;
										}
										continue;
									}
									IL_1F0:
									num = (short)724021285;
									short num5 = num;
									num = (short)1060155429;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										IL_25C:
										num = (short)1213661184;
										num2 = (int)((global::System.IntPtr)num);
										break;
									default:
										num = (short)139001856;
										if (num != 0)
										{
										}
										if (enumerator == null)
										{
											goto IL_276;
										}
										num = (short)620494849;
										num2 = (int)((global::System.IntPtr)num);
										break;
									}
								}
								IL_274:
								IL_276:;
							}
							goto IL_277;
						}
						case 1:
							num = (short)691470337;
							if (num != 0)
							{
							}
							goto IL_277;
						case 2:
							if (ttsvoiceAnnouncementListRecSet != null)
							{
								num = (short)1739522049;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return num4;
						}
						goto IL_3A;
						IL_277:
						enumerator = ttsvoiceAnnouncementListRecSet.GetEnumerator();
						num = (short)2019819520;
						num2 = (int)((global::System.IntPtr)num);
					}
					return num4;
					IL_3A:
					num4 = 0;
					ttsvoiceAnnouncementListRecSet = (global::AcpCommonLib.FeatureManager.GetFeature(2302) as global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet);
					num = (short)464191490;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x000588BC File Offset: 0x00056ABC
		internal void SetValues()
		{
			int a_ = 2;
			short num = (short)1465516033;
			if (num != 0)
			{
			}
			num = (short)1449787392;
			short num2 = num;
			num = (short)1262888598;
			short num3 = num;
			num = (short)575219350;
			switch (num3 == num)
			{
			}
			num = (short)1910571008;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.Id = 2302;
			base.SingleInstance = false;
			base.UIPagePath = "";
			base.UIName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮄ꮊꂌ꾎횐욒\udc94랖춘쾚캜뾞첢첤쒦첨讪솮\udfb0\udcb2살\ud9b6\udab8\udeba킼\udabe꿀럂识ꃈ룊만", a_);
			base.DataTransferOrder = 40;
			base.HideRecordsFromTree = true;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x000589B8 File Offset: 0x00056BB8
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)871694336;
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
				global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet ttsvoiceAnnouncementListRecSet;
				for (;;)
				{
					IL_28:
					int num4;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						num = (short)1187512321;
						if (num != 0)
						{
						}
						num = (short)2135490561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (ttsvoiceAnnouncementListRecSet.Count > 0)
						{
							num = (short)2125004800;
							short num3 = num;
							num = (short)1983709186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						goto IL_2C9;
					case 3:
						try
						{
							num = (short)202506245;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (num4 > global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet.MaxVoiceFilesTotalMS)
									{
										num = (short)1820983298;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									num = (short)363986947;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList ttsvoiceAnnouncementList;
									base.SetRecordValidity(ttsvoiceAnnouncementList, false);
									num = (short)1979056135;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_20D;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1707016193;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList ttsvoiceAnnouncementList = (global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList)enumerator.Current;
									num = (short)413794312;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_FA;
									}
									continue;
								case 6:
								{
									global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList ttsvoiceAnnouncementList;
									num4 += ttsvoiceAnnouncementList.General.VoiceFileDataInfo_A21213Value.getVoiceFileDuration();
									num = (short)805044224;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList ttsvoiceAnnouncementList;
									if (ttsvoiceAnnouncementList.General.VoiceFileName_A21220_Valid)
									{
										num = (short)238682118;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_142:
								num = (short)947126276;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FA:
								goto IL_142;
							}
							IL_20D:
							return;
						}
						finally
						{
							num = (short)1068761090;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2C6;
								case 1:
									enumerator.Dispose();
									goto IL_2AD;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_244;
									}
									continue;
								}
								IL_244:
								num = (short)111494840;
								short num5 = num;
								num = (short)644957880;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_2AD:
									num = (short)324009984;
									num2 = (int)((global::System.IntPtr)num);
									break;
								default:
									num = (short)588709888;
									if (num != 0)
									{
									}
									if (enumerator == null)
									{
										goto IL_2C8;
									}
									num = (short)592969729;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_2C6:
							IL_2C8:;
						}
						goto IL_2C9;
					case 4:
						if (ttsvoiceAnnouncementListRecSet != null)
						{
							num = (short)1687420928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_43;
					IL_2C9:
					num4 = 0;
					enumerator = ttsvoiceAnnouncementListRecSet.GetEnumerator();
					num = (short)1267597315;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_43:
				ttsvoiceAnnouncementListRecSet = (global::AcpCommonLib.FeatureManager.GetFeature(2302) as global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet);
				num = (short)940310532;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00058D38 File Offset: 0x00056F38
		protected override void OnFinishedMoveRecord(global::AcpCommonLib.IAcpFeatureNode draggedRecord, global::AcpCommonLib.IAcpFeatureNode targetRecord)
		{
			short num = (short)430833664;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6A;
				}
				global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet ttsvoiceAnnouncementListRecSet;
				for (;;)
				{
					IL_28:
					num = (short)1650982913;
					if (num != 0)
					{
					}
					int num4;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						num = (short)1040449537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (ttsvoiceAnnouncementListRecSet.Count > 0)
						{
							num = (short)1253310464;
							short num3 = num;
							num = (short)1597702146;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						goto IL_302;
					case 3:
						try
						{
							num = (short)809500678;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									if (num4 > global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet.MaxVoiceFilesTotalMS)
									{
										num = (short)853868547;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList ttsvoiceAnnouncementList;
									base.SetRecordValidity(ttsvoiceAnnouncementList, true);
									num = (short)392822784;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)973864964;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList ttsvoiceAnnouncementList;
									base.SetRecordValidity(ttsvoiceAnnouncementList, false);
									num = (short)562561032;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_240;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1149698050;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList ttsvoiceAnnouncementList = (global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList)enumerator.Current;
									num = (short)1533345801;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_105;
									}
									continue;
								case 7:
								{
									global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList ttsvoiceAnnouncementList;
									num4 += ttsvoiceAnnouncementList.General.VoiceFileDataInfo_A21213Value.getVoiceFileDuration();
									num = (short)1352597505;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList ttsvoiceAnnouncementList;
									if (ttsvoiceAnnouncementList.General.VoiceFileName_A21220_Valid)
									{
										num = (short)1171062791;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_172:
								num = (short)795344901;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_105:
								goto IL_172;
							}
							IL_240:
							return;
						}
						finally
						{
							num = (short)1906835458;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2FF;
								case 1:
									enumerator.Dispose();
									goto IL_2E6;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_279;
									}
									continue;
								}
								IL_279:
								num = (short)80923782;
								short num5 = num;
								num = (short)1839582342;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_2E6:
									num = (short)1239416832;
									num2 = (int)((global::System.IntPtr)num);
									break;
								default:
									num = (short)1685127168;
									if (num != 0)
									{
									}
									if (enumerator == null)
									{
										goto IL_301;
									}
									num = (short)2080112641;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_2FF:
							IL_301:;
						}
						goto IL_302;
					case 4:
						if (ttsvoiceAnnouncementListRecSet != null)
						{
							num = (short)798294016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_6A;
					IL_302:
					num4 = 0;
					enumerator = ttsvoiceAnnouncementListRecSet.GetEnumerator();
					num = (short)1295122435;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_6A:
				ttsvoiceAnnouncementListRecSet = (global::AcpCommonLib.FeatureManager.GetFeature(2302) as global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet);
				num = (short)1754791940;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x000590F4 File Offset: 0x000572F4
		// Note: this type is marked as 'beforefieldinit'.
		static TTSVoiceAnnouncementListRecSet()
		{
			short num = (short)169441177;
			short num2 = num;
			num = (short)1367635865;
			switch (num2 == num)
			{
			default:
			{
				num = (short)673120256;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)609746945;
			if (num != 0)
			{
			}
			num = (short)968949760;
			if (num != 0)
			{
			}
			global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet.vaCount = 0;
			global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet._MaxPool = int.MaxValue;
			global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet._Max = 5000;
			global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet._Min = 0;
		}

		// Token: 0x0400026E RID: 622
		public static string[] voiceFiles;

		// Token: 0x0400026F RID: 623
		public static int vaCount;

		// Token: 0x04000270 RID: 624
		public static int _MaxPool;

		// Token: 0x04000271 RID: 625
		public static int _Max;

		// Token: 0x04000272 RID: 626
		internal int _DynMax;

		// Token: 0x04000273 RID: 627
		public static int _Min;
	}
}
