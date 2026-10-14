using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using AcpBusinessLayer;
using AcpCommonLib;
using ACPVoiceAnnouncementLib;
using Features.Radio_Ergonomics_Configuration.Display_and_Menu;
using Motorola.MackinawCPS.CoreFeatures.Tts;
using Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.VoiceAnnouncements.List;

namespace SpecialFeatures.VoiceAnnouncements
{
	// Token: 0x02000010 RID: 16
	public static class TtsDataTreeUpdater
	{
		// Token: 0x06000036 RID: 54 RVA: 0x000074C4 File Offset: 0x000056C4
		public static void AddTtsToFeatureManager()
		{
			short num;
			try
			{
				num = (short)1902706688;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					string speaker = global::SpecialFeatures.VoiceAnnouncements.TtsDataTreeUpdater.a();
					global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.TTSMemoryAudioRepository instance = global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.TTSMemoryAudioRepository.GetInstance(speaker);
					global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.MVASampleGenerator mvasampleGenerator = new global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.MVASampleGenerator(speaker);
					try
					{
						switch (0)
						{
						case 0:
							goto IL_9F;
						}
						global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet ttsvoiceAnnouncementListRecSet;
						for (;;)
						{
							IL_3C:
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
							global::System.Collections.Generic.Dictionary<global::AcpBusinessLayer.AcpRecRefField, global::AcpBusinessLayer.AcpStringField> widePanelSelectedTTSFields;
							int num3;
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset;
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone zone;
							switch (num2)
							{
							case 0:
								if (zoneChannelAssignmentRecset != null)
								{
									num = (short)265420812;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5A7;
							case 1:
							{
								global::System.Collections.Generic.Dictionary<global::AcpBusinessLayer.AcpRecRefField, global::AcpBusinessLayer.AcpStringField>.Enumerator enumerator = widePanelSelectedTTSFields.GetEnumerator();
								num = (short)870580237;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								if (ttsvoiceAnnouncementListRecSet != null)
								{
									num = (short)1524826115;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_23E;
							case 3:
								goto IL_42C;
							case 4:
								goto IL_23E;
							case 5:
							{
								if (num3 >= channelAssignmentListInnerRecset.Count)
								{
									num = (short)1925120010;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection = (channelAssignmentListInnerRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner).ChannelAssignmentListInnerSection;
								num = (short)1435303956;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								int num4;
								if (num4 >= zoneChannelAssignmentRecset.Count)
								{
									num = (short)112394256;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								zone = (zoneChannelAssignmentRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone;
								num = (short)1552482318;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								goto IL_5C0;
							case 8:
								goto IL_1FE;
							case 9:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection;
								global::AcpBusinessLayer.AcpRecRefField channelAnnouncementID_A = channelAssignmentListInnerSection.ChannelAnnouncementID_A20175;
								string text = channelAssignmentListInnerSection.VCChannelAnnouncement_A20176Value.Trim();
								global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.AudioSampleModel a_ = global::SpecialFeatures.VoiceAnnouncements.TtsDataTreeUpdater.a(instance, mvasampleGenerator, text);
								global::SpecialFeatures.VoiceAnnouncements.TtsDataTreeUpdater.a(channelAnnouncementID_A, text, a_);
								num = (short)205258773;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 10:
							{
								int num4;
								num4++;
								num = (short)1981808659;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 11:
								goto IL_56A;
							case 12:
							{
								int num4 = 0;
								num = (short)850526230;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 13:
								try
								{
									num = (short)1124335617;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
										{
											global::System.Collections.Generic.Dictionary<global::AcpBusinessLayer.AcpRecRefField, global::AcpBusinessLayer.AcpStringField>.Enumerator enumerator;
											if (!enumerator.MoveNext())
											{
												num = (short)166789125;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::System.Collections.Generic.KeyValuePair<global::AcpBusinessLayer.AcpRecRefField, global::AcpBusinessLayer.AcpStringField> keyValuePair = enumerator.Current;
											num = (short)1338966019;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 1:
											switch (0)
											{
											case 0:
												goto IL_129;
											}
											continue;
										case 2:
											goto IL_1EB;
										case 3:
										{
											global::System.Collections.Generic.KeyValuePair<global::AcpBusinessLayer.AcpRecRefField, global::AcpBusinessLayer.AcpStringField> keyValuePair;
											global::AcpBusinessLayer.AcpRecRefField key = keyValuePair.Key;
											global::AcpBusinessLayer.AcpStringField value = keyValuePair.Value;
											string text2 = (value != null) ? value.ToString() : null;
											global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.AudioSampleModel a_2 = global::SpecialFeatures.VoiceAnnouncements.TtsDataTreeUpdater.a(instance, mvasampleGenerator, text2);
											global::SpecialFeatures.VoiceAnnouncements.TtsDataTreeUpdater.a(key, text2, a_2);
											num = (short)777256964;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 5:
											num = (short)341180418;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_167:
										num = (short)150929408;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_129:
										goto IL_167;
									}
									IL_1EB:
									goto IL_474;
								}
								finally
								{
									global::System.Collections.Generic.Dictionary<global::AcpBusinessLayer.AcpRecRefField, global::AcpBusinessLayer.AcpStringField>.Enumerator enumerator;
									((global::System.IDisposable)enumerator).Dispose();
								}
								goto IL_1FE;
							case 14:
								if (zone.ZoneVoiceAnnouncementID_A21514.Value == 65535)
								{
									num = (short)981336081;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_56A;
							case 15:
								if (widePanelSelectedTTSFields.Count<global::System.Collections.Generic.KeyValuePair<global::AcpBusinessLayer.AcpRecRefField, global::AcpBusinessLayer.AcpStringField>>() > 0)
								{
									num = (short)468189185;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_474;
							case 16:
								goto IL_5A7;
							case 17:
							{
								global::AcpBusinessLayer.AcpRecRefField zoneVoiceAnnouncementID_A = zone.ZoneVoiceAnnouncementID_A21514;
								string text3 = zone.VCZoneAnnouncement_A21515.ToString().Trim();
								global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.AudioSampleModel a_3 = global::SpecialFeatures.VoiceAnnouncements.TtsDataTreeUpdater.a(instance, mvasampleGenerator, text3);
								global::SpecialFeatures.VoiceAnnouncements.TtsDataTreeUpdater.a(zoneVoiceAnnouncementID_A, text3, a_3);
								num = (short)228196363;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 18:
								goto IL_1FE;
							case 19:
								goto IL_3C6;
							case 20:
							{
								num = (short)1920153186;
								short num5 = num;
								num = (short)2147169890;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_42C;
								default:
								{
									num = (short)273481728;
									if (num != 0)
									{
									}
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection;
									if (channelAssignmentListInnerSection.ChannelAnnouncementID_A20175.Value == 65535)
									{
										num = (short)708313097;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3A2;
								}
								}
								break;
							}
							case 21:
								goto IL_3A2;
							case 22:
								goto IL_3C6;
							}
							goto IL_9F;
							IL_1FE:
							num = (short)1185808389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_23E:
							widePanelSelectedTTSFields = global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSUtils.GetWidePanelSelectedTTSFields();
							num = (short)89456655;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_3A2:
							num3++;
							num = (short)2055012360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_3C6:
							num = (short)283770886;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_42C:
							ttsvoiceAnnouncementListRecSet.Clear();
							num = (short)1559298052;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_474:
							zoneChannelAssignmentRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset);
							num = (short)803078144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_56A:
							channelAssignmentListInnerRecset = ((zone.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Channels.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset);
							num3 = 0;
							num = (short)2013462546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_5A7:
							num = (short)1030094855;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_5C0:
						break;
						IL_9F:
						ttsvoiceAnnouncementListRecSet = (global::AcpCommonLib.FeatureManager.GetFeature(2302) as global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet);
						num = (short)872284162;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_3C;
					}
					finally
					{
						num = (short)551944192;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_5F6;
								}
								continue;
							case 1:
								goto IL_62E;
							case 2:
								((global::System.IDisposable)mvasampleGenerator).Dispose();
								num = (short)748617729;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_5F6:
							if (mvasampleGenerator == null)
							{
								break;
							}
							num = (short)972029954;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_62E:;
					}
					break;
				}
				}
			}
			catch (global::System.Exception)
			{
			}
			num = (short)1365770240;
			short num6 = num;
			num = (short)1369964545;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00007BA4 File Offset: 0x00005DA4
		private static global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.AudioSampleModel a(global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.TTSMemoryAudioRepository A_0, global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.MVASampleGenerator A_1, string A_2)
		{
			global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.AudioSampleModel audioSampleModel;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						if (audioSampleModel != null)
						{
							return audioSampleModel;
						}
						num2 = (short)1764823105;
						short num3 = num2;
						num2 = (short)381227073;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)344588289;
							if (num2 != 0)
							{
							}
							num2 = (short)1286144000;
							if (num2 != 0)
							{
							}
							num2 = (short)503840770;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						return audioSampleModel;
					case 2:
					{
						num2 = (short)540475392;
						short num4 = num2;
						audioSampleModel = A_1.GenerateAudioSample(A_2);
						A_0.AddOrReplaceAudio(A_2, audioSampleModel);
						num2 = (short)1852702721;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				IL_1C:
				audioSampleModel = A_0.GetAudio(A_2);
				num2 = (short)1239351296;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return audioSampleModel;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00007CD4 File Offset: 0x00005ED4
		private static void a(global::AcpBusinessLayer.AcpRecRefField A_0, string A_1, global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.AudioSampleModel A_2)
		{
			int a_ = 6;
			short num = (short)703922176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C8;
				}
				global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet ttsvoiceAnnouncementListRecSet;
				for (;;)
				{
					IL_30:
					num = (short)1622092996;
					short num3 = num;
					num = (short)1026567364;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C8;
					default:
					{
						num = (short)226885633;
						if (num != 0)
						{
						}
						num = (short)1051525120;
						if (num != 0)
						{
						}
						global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList ttsvoiceAnnouncementList;
						switch (num2)
						{
						case 0:
							if (ttsvoiceAnnouncementListRecSet != null)
							{
								num = (short)179240965;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 1:
							goto IL_302;
						case 2:
							if (ttsvoiceAnnouncementList == null)
							{
								num = (short)231604231;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_20A;
						case 3:
							goto IL_244;
						case 4:
							goto IL_20A;
						case 5:
							ttsvoiceAnnouncementList = global::SpecialFeatures.VoiceAnnouncements.TtsDataTreeUpdater.a(A_1);
							num = (short)1053556738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::AcpBusinessLayer.AcpVoiceFileStruct acpVoiceFileStruct;
							if (acpVoiceFileStruct.getVoiceFileDuration() > global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSUtils.TTS_MAX_DURATION_MS)
							{
								num = (short)749076481;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							ttsvoiceAnnouncementList = new global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList(global::AcpCommonLib.FeatureManager.GetFeature(2302) as global::AcpBusinessLayer.Recordset);
							global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementGeneralSection general = ttsvoiceAnnouncementList.General;
							general.VoiceAnnouncementEncodeType_A22264.SetValue(1);
							general.VoiceAnnouncementFileHashcode_A24563.SetValue(acpVoiceFileStruct.hashcode);
							general.VoiceFileDataInfo_A21213.SetValue(acpVoiceFileStruct);
							general.VoiceFileName_A21220Object.SetValue(A_1);
							ttsvoiceAnnouncementListRecSet.Add(ttsvoiceAnnouncementList);
							num = (short)790298624;
							short num4 = num;
							num = (short)280887300;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							string text = global::System.IO.Path.Combine(global::System.IO.Path.GetTempPath(), global::System.Guid.NewGuid().ToString().Replace(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꒈ", a_), "") + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꞈﮌ", a_));
							global::System.IO.File.WriteAllBytes(text, A_2.AudioBuffer);
							global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementFileClass acpmotVoiceAnnouncementFileClass = global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementFileClass.LoadFromFile(text);
							global::AcpBusinessLayer.AcpVoiceFileStruct acpVoiceFileStruct = global::AcpBusinessLayer.AcpVoiceFileStruct.Parse(global::System.Convert.ToBase64String(acpmotVoiceAnnouncementFileClass.VoiceData, 0, acpmotVoiceAnnouncementFileClass.VoiceData.Length));
							num = (short)902823942;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_C8;
						IL_20A:
						A_0.GetType().GetField(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﮈﮔﲘﾚ펜얠욢", a_), global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic).SetValue(A_0, ttsvoiceAnnouncementList);
						num = (short)1450573827;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_244:
				return;
				IL_302:
				throw new global::System.Exception(A_1 + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꦈ\udf8a\ud98c\udc8e놐붜ﮞ풠톢쒤펦삨쒪쎬辮\ud8b0삲閴쎶횸풺鶼펾껀귂ꋄ", a_));
				IL_C8:
				ttsvoiceAnnouncementListRecSet = (global::AcpCommonLib.FeatureManager.GetFeature(2302) as global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet);
				num = (short)705953792;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00007FE8 File Offset: 0x000061E8
		private static global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList a(string A_0)
		{
			short num = (short)135480569;
			short num2 = num;
			num = (short)170018041;
			global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2104229888;
				short num3 = num;
				num = (short)1822359553;
				if (num != 0)
				{
				}
				num = (short)2004811776;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2302) as global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet).GetEnumerator();
				try
				{
					num = (short)163840001;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							num = (short)327683;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_F3;
							}
							continue;
						case 2:
						{
							global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList ttsvoiceAnnouncementList;
							if (ttsvoiceAnnouncementList.General.VoiceFileName_A21220Value == A_0)
							{
								num = (short)1768816646;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							goto IL_1AC;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)706740224;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList ttsvoiceAnnouncementList = (global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList)enumerator.Current;
							num = (short)1200291842;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_190;
						case 6:
						{
							global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementList ttsvoiceAnnouncementList;
							result = ttsvoiceAnnouncementList;
							num = (short)1888878597;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_F5:
						num = (short)1621426180;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_F3:
						goto IL_F5;
					}
					IL_190:
					break;
					IL_1AC:
					goto IL_B1;
				}
				finally
				{
					num = (short)951058432;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1E2;
							}
							continue;
						case 1:
							goto IL_217;
						case 2:
							enumerator.Dispose();
							num = (short)1219952641;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1E2:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1969422338;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_217:;
				}
				break;
				IL_B1:
				return null;
			}
			}
			return result;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00008220 File Offset: 0x00006420
		private static string a()
		{
			short num = (short)387426504;
			short num2 = num;
			num = (short)378317000;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1850736640;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)238092288;
			if (num != 0)
			{
			}
			num = (short)1390018561;
			if (num != 0)
			{
			}
			return global::Features.Radio_Ergonomics_Configuration.Display_and_Menu.TtsSpeaker.TargetSpeaker;
		}
	}
}
