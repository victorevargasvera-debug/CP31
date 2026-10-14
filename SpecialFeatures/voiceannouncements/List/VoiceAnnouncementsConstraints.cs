using System;
using System.IO;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AcpUtility;
using ACPVoiceAnnouncementLib;
using CommonResources;
using ConstraintHelper;

namespace SpecialFeatures.VoiceAnnouncements.List
{
	// Token: 0x0200002F RID: 47
	internal class VoiceAnnouncementsConstraints
	{
		// Token: 0x0600066E RID: 1646 RVA: 0x0005E2DC File Offset: 0x0005C4DC
		internal static bool conVoiceAnnouncementFileValidity(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)335413248;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8E;
				}
				bool result;
				string voiceFileName_A21220Value;
				global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementGeneralSection voiceAnnouncementGeneralSection;
				for (;;)
				{
					IL_27:
					string fmt;
					string message;
					switch (num2)
					{
					case 0:
					{
						global::AcpBusinessLayer.AcpVoiceFileStruct voiceFileDataInfo_A21213Value;
						if (voiceFileDataInfo_A21213Value.voiceData.Length <= 8188L)
						{
							num = (short)331743238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24C;
					}
					case 1:
						if (!global::ConstraintHelper.UtilityMack.IsAPXNextOrAloha)
						{
							num = (short)1325858821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
					{
						global::AcpBusinessLayer.AcpVoiceFileStruct voiceFileDataInfo_A21213Value;
						if (voiceFileDataInfo_A21213Value.voiceData != null)
						{
							num = (short)868614156;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EB;
					}
					case 3:
					{
						global::AcpBusinessLayer.AcpVoiceFileStruct voiceFileDataInfo_A21213Value;
						uint voiceAnnouncementFileHashcode_A24563Value;
						if (voiceAnnouncementFileHashcode_A24563Value == global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementFileClass.CalculateHashcode(voiceFileDataInfo_A21213Value.voiceData.GetBuffer(), 0, (int)voiceFileDataInfo_A21213Value.voiceData.Length))
						{
							num = (short)69402632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EB;
					}
					case 4:
						num = (short)1568997383;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1561395221;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)633798657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						fmt = global::CommonResources.AcgResources.ID_VOICEANNOUNCEMENTTOOBIGFORLEGACYRADIO;
						goto IL_19B;
					case 8:
						result = true;
						num = (short)18677775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, message);
						num = (short)985661463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (!global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(message))
						{
							num = (short)48300041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 11:
					{
						global::AcpBusinessLayer.AcpVoiceFileStruct voiceFileDataInfo_A21213Value;
						if (voiceFileDataInfo_A21213Value.voiceData != null)
						{
							num = (short)925433872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 12:
						num = (short)1196687373;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						global::AcpBusinessLayer.AcpVoiceFileStruct voiceFileDataInfo_A21213Value;
						if (voiceFileDataInfo_A21213Value.voiceData.Length != 0L)
						{
							num = (short)1521680402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EB;
					}
					case 14:
					{
						if (voiceFileName_A21220Value.IndexOfAny(global::System.IO.Path.GetInvalidFileNameChars()) != -1)
						{
							num = (short)994312212;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int voiceAnnouncementEncodeType_A22264Value = voiceAnnouncementGeneralSection.VoiceAnnouncementEncodeType_A22264Value;
						uint voiceAnnouncementFileHashcode_A24563Value = voiceAnnouncementGeneralSection.VoiceAnnouncementFileHashcode_A24563Value;
						global::AcpBusinessLayer.AcpVoiceFileStruct voiceFileDataInfo_A21213Value = voiceAnnouncementGeneralSection.VoiceFileDataInfo_A21213Value;
						num = (short)1369178114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_3C0;
					case 16:
					{
						num = (short)1375996247;
						short num3 = num;
						num = (short)1101990231;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3C0;
						default:
							num = (short)154140672;
							if (num != 0)
							{
							}
							num = (short)647168000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 17:
						goto IL_24C;
					case 18:
						num = (short)614137859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						fmt = global::CommonResources.AcgResources.ID_VOICEANNOUNCEMENTTOOBIGFORNEXTRADIO;
						goto IL_19B;
					case 20:
						return false;
					case 21:
					{
						global::AcpBusinessLayer.AcpVoiceFileStruct voiceFileDataInfo_A21213Value;
						if (voiceFileDataInfo_A21213Value.voiceData.Length > 4095L)
						{
							num = (short)1984430097;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 22:
						if (!global::ConstraintHelper.UtilityMack.IsAPXNextOrAloha)
						{
							num = (short)1084293124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)285474835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_354;
					}
					goto IL_8E;
					IL_19B:
					message = fmt.AcpStringFormat(new object[]
					{
						voiceFileName_A21220Value
					});
					num = (short)1026293770;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24C:
					num = (short)804913174;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3EB:
					num = (short)523567115;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C0:
					num = (short)709885953;
					if (num != 0)
					{
					}
					goto IL_3EB;
				}
				return false;
				IL_354:
				num = (short)2100101120;
				short num4 = num;
				return false;
				IL_8E:
				result = false;
				voiceAnnouncementGeneralSection = (self as global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementGeneralSection);
				voiceFileName_A21220Value = voiceAnnouncementGeneralSection.VoiceFileName_A21220Value;
				num = (short)1651703822;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0005E7A0 File Offset: 0x0005C9A0
		internal static void conSetVAFieldsValue(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
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
					global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementGeneralSection voiceAnnouncementGeneralSection;
					string voiceFileName_A21220Value = voiceAnnouncementGeneralSection.VoiceFileName_A21220Value;
					global::AcpBusinessLayer.AcpVoiceFileStruct acpVoiceFileStruct = new global::AcpBusinessLayer.AcpVoiceFileStruct(voiceFileName_A21220Value);
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(voiceAnnouncementGeneralSection.VoiceAnnouncementEncodeType_A22264, 1));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<uint>(voiceAnnouncementGeneralSection.VoiceAnnouncementFileHashcode_A24563, acpVoiceFileStruct.hashcode));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<global::AcpBusinessLayer.AcpVoiceFileStruct>(voiceAnnouncementGeneralSection.VoiceFileDataInfo_A21213, acpVoiceFileStruct));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<string>(voiceAnnouncementGeneralSection.VoiceFileName_A21220Object, global::System.IO.Path.GetFileNameWithoutExtension(voiceFileName_A21220Value)));
					voiceAnnouncementGeneralSection.VoiceFileName_A21220Object.SetValue(global::System.IO.Path.GetFileNameWithoutExtension(voiceFileName_A21220Value));
					num2 = (short)1939079169;
					if (num2 != 0)
					{
					}
					num2 = (short)1660420098;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (global::AcpCommonLib.AppInfoManager.LoadingVoiceData)
					{
						num2 = (short)2082275328;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			num2 = (short)1880445179;
			short num3 = num2;
			num2 = (short)1433489659;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num2 = (short)2030043136;
				short num4 = num2;
				num2 = (short)1419575296;
				if (num2 != 0)
				{
				}
				global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementGeneralSection voiceAnnouncementGeneralSection = self as global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementGeneralSection;
				break;
			}
			}
			num2 = (short)61669377;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0005E934 File Offset: 0x0005CB34
		internal static bool conSetVoiceAnnouncementFileEditability(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1536491520;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_53;
				}
				global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementGeneralSection voiceAnnouncementGeneralSection;
				bool voiceFileName_A21220_Editable;
				global::AcpBusinessLayer.FeatureNode featureNode;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						global::AcpBusinessLayer.Recordset recordset = voiceAnnouncementGeneralSection.ParentRecset as global::AcpBusinessLayer.Recordset;
						goto IL_124;
					}
					case 1:
					{
						global::AcpBusinessLayer.Recordset recordset;
						if (recordset.CumulativeMax <= global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.MaxVoiceFilesTotalMS)
						{
							num = (short)1814953991;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return voiceFileName_A21220_Editable;
					}
					case 2:
					{
						num = (short)1119027200;
						short num3 = num;
						num = (short)1805975553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						return voiceFileName_A21220_Editable;
					case 4:
					{
						num = (short)1330854283;
						short num4 = num;
						num = (short)1325611403;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_124;
						default:
						{
							num = (short)1623851008;
							if (num != 0)
							{
							}
							global::AcpBusinessLayer.Recordset recordset;
							if (recordset != null)
							{
								num = (short)1259929602;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return voiceFileName_A21220_Editable;
						}
						}
						break;
					}
					case 5:
						if (featureNode != null)
						{
							num = (short)761921542;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return voiceFileName_A21220_Editable;
					case 6:
						num = (short)1821835265;
						if (num != 0)
						{
						}
						num = (short)1816264712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::AcpBusinessLayer.Recordset recordset;
						recordset.SetRecordValidity(featureNode, true);
						num = (short)583860227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (!featureNode.Valid)
						{
							num = (short)884080640;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return voiceFileName_A21220_Editable;
					}
					goto IL_53;
					IL_124:
					num = (short)1177485316;
					num2 = (int)((global::System.IntPtr)num);
				}
				return voiceFileName_A21220_Editable;
				IL_53:
				voiceAnnouncementGeneralSection = (self as global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementGeneralSection);
				voiceFileName_A21220_Editable = voiceAnnouncementGeneralSection.VoiceFileName_A21220_Editable;
				featureNode = (voiceAnnouncementGeneralSection.VoiceFileName_A21220Object.Parent.Parent as global::AcpBusinessLayer.FeatureNode);
				num = (short)2015428613;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
