using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AcpBusinessLayer;
using AcpCommonLib;
using ACPVoiceAnnouncementLib;
using AllFeatures;
using ConstraintHelper;
using Features.Radio_Ergonomics_Configuration.Display_and_Menu;
using Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.Tts
{
	// Token: 0x0200004F RID: 79
	public static class TTSUtils
	{
		// Token: 0x060003F2 RID: 1010 RVA: 0x00049B64 File Offset: 0x00047D64
		public static bool CheckTTSVoiceDuration(string tts)
		{
			int a_ = 10;
			short num = (short)1129381888;
			switch (num)
			{
			default:
			{
				num = (short)1165688834;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.AudioSampleModel audioSampleModel;
					int num3;
					int num5;
					global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.TTSMemoryAudioRepository instance;
					global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.MVASampleGenerator mvasampleGenerator;
					switch (num2)
					{
					case 0:
						if (audioSampleModel == null)
						{
							num = (short)729546755;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 1:
						num3 = 4095;
						goto IL_343;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_6A;
						}
						continue;
					case 3:
					{
						num = (short)215154688;
						short num4 = num;
						num = (short)888799233;
						if (num != 0)
						{
						}
						goto IL_2DD;
					}
					case 4:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_BC;
							}
							string text;
							bool result;
							for (;;)
							{
								IL_99:
								switch (num2)
								{
								case 0:
									goto IL_1FB;
								case 1:
									goto IL_1DB;
								case 2:
								{
									if (audioSampleModel.AudioBufferLength >= num5)
									{
										num = (short)348061702;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.IO.File.WriteAllBytes(text, audioSampleModel.AudioBuffer);
									global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementFileClass acpmotVoiceAnnouncementFileClass = global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementFileClass.LoadFromFile(text);
									global::AcpBusinessLayer.AcpVoiceFileStruct acpVoiceFileStruct = global::AcpBusinessLayer.AcpVoiceFileStruct.Parse(global::System.Convert.ToBase64String(acpmotVoiceAnnouncementFileClass.VoiceData, 0, acpmotVoiceAnnouncementFileClass.VoiceData.Length));
									num = (short)2143158276;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_220;
								case 4:
								{
									global::AcpBusinessLayer.AcpVoiceFileStruct acpVoiceFileStruct;
									if (acpVoiceFileStruct.getVoiceFileDuration() > global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSUtils.TTS_MAX_DURATION_MS)
									{
										num = (short)822738949;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									instance.AddOrReplaceAudio(tts, audioSampleModel);
									num = (short)1373700099;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									result = false;
									num = (short)1448673280;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									result = false;
									num = (short)102236161;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_BC;
							}
							IL_1DB:
							IL_1FB:
							return result;
							IL_220:
							return true;
							IL_BC:
							audioSampleModel = mvasampleGenerator.GenerateAudioSample(tts);
							text = global::System.IO.Path.Combine(global::System.IO.Path.GetTempPath(), global::System.Guid.NewGuid().ToString().Replace(global::AllFeatures.CodeplugGuid.b("", a_), "") + global::AllFeatures.CodeplugGuid.b("ꃌ많냐", a_));
							num = (short)1779171330;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_99;
						}
						finally
						{
							num = (short)1642921986;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2DA;
								case 1:
									goto IL_2BC;
								case 2:
								{
									num = (short)1258554529;
									short num6 = num;
									num = (short)1292108961;
									switch ((num6 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2BC;
									default:
										num = (short)117637120;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_2A2;
										}
										continue;
									}
									break;
								}
								}
								IL_2A2:
								if (mvasampleGenerator != null)
								{
									num = (short)1500774401;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
								IL_2BC:
								((global::System.IDisposable)mvasampleGenerator).Dispose();
								num = (short)860487680;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2DA:;
						}
						goto IL_2DD;
					case 5:
						num3 = 8188;
						goto IL_343;
					case 6:
						num = (short)188678145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_6A:
					if (!global::ConstraintHelper.UtilityMack.IsAPXNextOrAloha)
					{
						num = (short)461373446;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)356843525;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2DD:
					string targetSpeaker;
					mvasampleGenerator = new global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.MVASampleGenerator(targetSpeaker);
					num = (short)1458176004;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_343:
					num5 = num3;
					targetSpeaker = global::Features.Radio_Ergonomics_Configuration.Display_and_Menu.TtsSpeaker.TargetSpeaker;
					instance = global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.TTSMemoryAudioRepository.GetInstance(targetSpeaker);
					audioSampleModel = instance.GetAudio(tts);
					num = (short)1102381056;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
			}
			}
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00049F74 File Offset: 0x00048174
		public static global::System.Collections.Generic.Dictionary<global::AcpBusinessLayer.AcpRecRefField, global::AcpBusinessLayer.AcpStringField> GetWidePanelSelectedTTSFields()
		{
			short num = (short)1312882688;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.Dictionary<global::AcpBusinessLayer.AcpRecRefField, global::AcpBusinessLayer.AcpStringField> dictionary = new global::System.Collections.Generic.Dictionary<global::AcpBusinessLayer.AcpRecRefField, global::AcpBusinessLayer.AcpStringField>();
				global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> fieldsCollection = global::AcpCommonLib.FeatureManager.GetFeature(2301)[0].FeatureSectionsCollection.FirstOrDefault<global::AcpCommonLib.IAcpFeatureSection>().FieldsCollection;
				global::System.Collections.Generic.IEnumerable<global::AcpBusinessLayer.AcpStringField> source = fieldsCollection.OfType<global::AcpBusinessLayer.AcpStringField>();
				global::System.Collections.Generic.IEnumerable<global::AcpBusinessLayer.AcpRecRefField> source2 = fieldsCollection.OfType<global::AcpBusinessLayer.AcpRecRefField>();
				global::System.Func<global::AcpBusinessLayer.AcpRecRefField, bool> predicate = delegate(global::AcpBusinessLayer.AcpRecRefField i)
				{
					short num5 = (short)1955130851;
					short num6 = num5;
					num5 = (short)473951715;
					switch (num6 == num5)
					{
					}
					num5 = (short)1086914561;
					if (num5 != 0)
					{
					}
					num5 = (short)1138032640;
					short num7 = num5;
					num5 = (short)693960704;
					if (num5 != 0)
					{
					}
					return i.Value == 65535;
				};
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator = source2.Where(predicate).GetEnumerator();
					try
					{
						num = (short)1339359234;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								num = (short)1256783875;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_A2;
								}
								continue;
							case 3:
								goto IL_179;
							case 4:
							{
								global::AcpBusinessLayer.AcpStringField acpStringField;
								dictionary.Add(CS$<>8__locals1.selectedTtsField, acpStringField);
								num = (short)645005312;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1271529473;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpBusinessLayer.AcpRecRefField selectedTtsField = enumerator.Current;
								global::AcpBusinessLayer.AcpStringField acpStringField = source.FirstOrDefault(delegate(global::AcpBusinessLayer.AcpStringField i)
								{
									short num5 = (short)716223867;
									short num6 = num5;
									num5 = (short)1570026875;
									switch (num6 == num5)
									{
									}
									num5 = (short)1233846273;
									if (num5 != 0)
									{
									}
									num5 = (short)55115776;
									short num7 = num5;
									num5 = (short)145293312;
									if (num5 != 0)
									{
									}
									return i.UIName.Contains(selectedTtsField.UIName);
								});
								num = (short)729088006;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								global::AcpBusinessLayer.AcpStringField acpStringField;
								if (acpStringField != null)
								{
									num = (short)187236356;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_FA:
							num = (short)1397751813;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_A2:
							goto IL_FA;
						}
						IL_179:
						break;
					}
					finally
					{
						num = (short)1107361794;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_231;
							case 1:
								goto IL_214;
							case 2:
							{
								num = (short)899284045;
								short num3 = num;
								num = (short)1680866381;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_214;
								default:
									num = (short)1082195968;
									if (num != 0)
									{
									}
									switch (0)
									{
									case 0:
										goto IL_1FA;
									}
									continue;
								}
								break;
							}
							}
							IL_1FA:
							if (enumerator != null)
							{
								num = (short)398000129;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
							IL_214:
							enumerator.Dispose();
							num = (short)823853056;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_231:;
					}
				}
				num = (short)2008023040;
				short num4 = num;
				num = (short)1370816513;
				if (num != 0)
				{
				}
				return dictionary;
			}
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0004A24C File Offset: 0x0004844C
		public static void RunTTSAudioLenCheck()
		{
			short num = (short)1196687360;
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
				global::System.Collections.Generic.Dictionary<global::AcpBusinessLayer.AcpRecRefField, global::AcpBusinessLayer.AcpStringField> widePanelSelectedTTSFields;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone zone;
					int num6;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset;
					switch (num2)
					{
					case 0:
						goto IL_32E;
					case 1:
						goto IL_140;
					case 2:
					{
						int num3;
						if (num3 >= zoneChannelAssignmentRecset.Count)
						{
							num = (short)642187280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						zone = (zoneChannelAssignmentRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone;
						num = (short)671481861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::System.Collections.Generic.Dictionary<global::AcpBusinessLayer.AcpRecRefField, global::AcpBusinessLayer.AcpStringField>.Enumerator enumerator = widePanelSelectedTTSFields.GetEnumerator();
						num = (short)1504378892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection;
						if (channelAssignmentListInnerSection.ChannelAnnouncementID_A20175.Value == 65535)
						{
							num = (short)154140679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30A;
					}
					case 5:
						if (zone.ZoneVoiceAnnouncementID_A21514.Value == 65535)
						{
							num = (short)1226768394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_105;
					case 6:
						if (zoneChannelAssignmentRecset != null)
						{
							num = (short)2067660811;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection;
						string vcchannelAnnouncement_A20176Value = channelAssignmentListInnerSection.VCChannelAnnouncement_A20176Value;
						channelAssignmentListInnerSection.VCChannelAnnouncement_A20176.Valid = global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSUtils.CheckTTSVoiceDuration(vcchannelAnnouncement_A20176Value);
						num = (short)1020919817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						num = (short)1870069760;
						short num4 = num;
						int num3;
						num3++;
						num = (short)1048051712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_30A;
					case 10:
					{
						string tts = zone.VCZoneAnnouncement_A21515.ToString();
						zone.VCZoneAnnouncement_A21515.Valid = global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSUtils.CheckTTSVoiceDuration(tts);
						num = (short)320667665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						int num3 = 0;
						num = (short)1173028877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						try
						{
							num = (short)1768947713;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1EE;
									}
									continue;
								case 2:
									num = (short)1238695939;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_2F7;
								case 4:
								{
									global::System.Collections.Generic.Dictionary<global::AcpBusinessLayer.AcpRecRefField, global::AcpBusinessLayer.AcpStringField>.Enumerator enumerator;
									if (enumerator.MoveNext())
									{
										global::System.Collections.Generic.KeyValuePair<global::AcpBusinessLayer.AcpRecRefField, global::AcpBusinessLayer.AcpStringField> keyValuePair = enumerator.Current;
										num = (short)2144882552;
										short num5 = num;
										num = (short)773017464;
										switch ((num5 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num = (short)993198080;
											if (num != 0)
											{
											}
											num = (short)2111504389;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
									}
									num = (short)727580674;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::System.Collections.Generic.KeyValuePair<global::AcpBusinessLayer.AcpRecRefField, global::AcpBusinessLayer.AcpStringField> keyValuePair;
									global::AcpBusinessLayer.AcpStringField value = keyValuePair.Value;
									string tts2 = (value != null) ? value.ToString() : null;
									value.Valid = global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSUtils.CheckTTSVoiceDuration(tts2);
									num = (short)227868672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_271:
								num = (short)1070006276;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1EE:
								goto IL_271;
							}
							IL_2F7:
							goto IL_3B0;
						}
						finally
						{
							global::System.Collections.Generic.Dictionary<global::AcpBusinessLayer.AcpRecRefField, global::AcpBusinessLayer.AcpStringField>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_30A;
					case 13:
						goto IL_32E;
					case 14:
						if (widePanelSelectedTTSFields.Count<global::System.Collections.Generic.KeyValuePair<global::AcpBusinessLayer.AcpRecRefField, global::AcpBusinessLayer.AcpStringField>>() > 0)
						{
							num = (short)384630787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B0;
					case 15:
						goto IL_140;
					case 16:
						return;
					case 17:
						goto IL_105;
					case 18:
					{
						if (num6 >= channelAssignmentListInnerRecset.Count)
						{
							num = (short)1605959681;
							if (num != 0)
							{
							}
							num = (short)1551958024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection = (channelAssignmentListInnerRecset[num6] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner).ChannelAssignmentListInnerSection;
						num = (short)539230212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_7B;
					IL_105:
					channelAssignmentListInnerRecset = ((zone.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Channels.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset);
					num6 = 0;
					num = (short)1500512257;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_140:
					num = (short)1690173458;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30A:
					num6++;
					num = (short)641662991;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32E:
					num = (short)1487405058;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B0:
					zoneChannelAssignmentRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset);
					num = (short)523436038;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_7B:
				global::AcpCommonLib.FeatureManager.GetFeature(2301);
				widePanelSelectedTTSFields = global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSUtils.GetWidePanelSelectedTTSFields();
				num = (short)1445199886;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0004A7C8 File Offset: 0x000489C8
		// Note: this type is marked as 'beforefieldinit'.
		static TTSUtils()
		{
			short num = (short)65444137;
			short num2 = num;
			num = (short)1068734761;
			switch (num2 == num)
			{
			}
			num = (short)1433600001;
			if (num != 0)
			{
			}
			num = (short)1606615040;
			short num3 = num;
			num = (short)799735808;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSUtils.TTS_MAX_DURATION_MS = 3800;
		}

		// Token: 0x040001D6 RID: 470
		public static int TTS_MAX_DURATION_MS;
	}
}
