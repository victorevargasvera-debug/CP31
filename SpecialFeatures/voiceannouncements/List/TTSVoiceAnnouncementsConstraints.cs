using System;
using System.IO;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using ACPVoiceAnnouncementLib;

namespace SpecialFeatures.VoiceAnnouncements.List
{
	// Token: 0x0200002A RID: 42
	internal class TTSVoiceAnnouncementsConstraints
	{
		// Token: 0x060005F9 RID: 1529 RVA: 0x00057284 File Offset: 0x00055484
		internal static bool conTTSVoiceAnnouncementFileValidity(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			uint voiceAnnouncementFileHashcode_A24563Value;
			global::AcpBusinessLayer.AcpVoiceFileStruct voiceFileDataInfo_A21213Value;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1202847745;
					if (num2 != 0)
					{
					}
					if (voiceAnnouncementFileHashcode_A24563Value == global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementFileClass.CalculateHashcode(voiceFileDataInfo_A21213Value.voiceData.GetBuffer(), 0, (int)voiceFileDataInfo_A21213Value.voiceData.Length))
					{
						num2 = (short)1941897217;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					result = true;
					num2 = (short)1993015302;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)2073427972;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)1364709108;
					short num3 = num2;
					num2 = (short)1837485812;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1119158272;
						if (num2 != 0)
						{
						}
						break;
					}
					num2 = (short)1265238016;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					if (voiceFileDataInfo_A21213Value.voiceData.Length != 0L)
					{
						num2 = (short)1536950275;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 5:
					if (voiceFileDataInfo_A21213Value.voiceData != null)
					{
						num2 = (short)1125253122;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 6:
					return result;
				}
				goto IL_2C;
			}
			return result;
			IL_2C:
			num2 = (short)1652359168;
			short num4 = num2;
			result = false;
			global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementGeneralSection ttsvoiceAnnouncementGeneralSection = self as global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementGeneralSection;
			int voiceAnnouncementEncodeType_A22264Value = ttsvoiceAnnouncementGeneralSection.VoiceAnnouncementEncodeType_A22264Value;
			voiceAnnouncementFileHashcode_A24563Value = ttsvoiceAnnouncementGeneralSection.VoiceAnnouncementFileHashcode_A24563Value;
			voiceFileDataInfo_A21213Value = ttsvoiceAnnouncementGeneralSection.VoiceFileDataInfo_A21213Value;
			num2 = (short)1482883077;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0005746C File Offset: 0x0005566C
		internal static void conSetTTSVAFieldsValue(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementGeneralSection ttsvoiceAnnouncementGeneralSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)2005687210;
					short num3 = num2;
					num2 = (short)1915968426;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)2145386497;
						if (num2 != 0)
						{
						}
						num2 = (short)817299456;
						if (num2 != 0)
						{
						}
						break;
					}
					string voiceFileName_A21220Value = ttsvoiceAnnouncementGeneralSection.VoiceFileName_A21220Value;
					global::AcpBusinessLayer.AcpVoiceFileStruct acpVoiceFileStruct = new global::AcpBusinessLayer.AcpVoiceFileStruct(voiceFileName_A21220Value);
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(ttsvoiceAnnouncementGeneralSection.VoiceAnnouncementEncodeType_A22264, 1));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<uint>(ttsvoiceAnnouncementGeneralSection.VoiceAnnouncementFileHashcode_A24563, acpVoiceFileStruct.hashcode));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<global::AcpBusinessLayer.AcpVoiceFileStruct>(ttsvoiceAnnouncementGeneralSection.VoiceFileDataInfo_A21213, acpVoiceFileStruct));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<string>(ttsvoiceAnnouncementGeneralSection.VoiceFileName_A21220Object, global::System.IO.Path.GetFileNameWithoutExtension(voiceFileName_A21220Value)));
					ttsvoiceAnnouncementGeneralSection.VoiceFileName_A21220Object.SetValue(global::System.IO.Path.GetFileNameWithoutExtension(voiceFileName_A21220Value));
					num2 = (short)1550909440;
					short num4 = num2;
					num2 = (short)2119434241;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return;
				case 2:
					if (global::AcpCommonLib.AppInfoManager.LoadingVoiceData)
					{
						num2 = (short)1618149376;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			ttsvoiceAnnouncementGeneralSection = (self as global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementGeneralSection);
			num2 = (short)148766722;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x000575F8 File Offset: 0x000557F8
		internal static bool conSetTTSVoiceAnnouncementFileEditability(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)615841792;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_54;
				}
				bool voiceFileName_A21220_Editable;
				global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementGeneralSection ttsvoiceAnnouncementGeneralSection;
				global::AcpBusinessLayer.FeatureNode featureNode;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						num = (short)86573064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::AcpBusinessLayer.Recordset recordset;
						if (recordset != null)
						{
							num = (short)1962475520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return voiceFileName_A21220_Editable;
					}
					case 2:
					{
						global::AcpBusinessLayer.Recordset recordset = ttsvoiceAnnouncementGeneralSection.ParentRecset as global::AcpBusinessLayer.Recordset;
						num = (short)1286471681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (!featureNode.Valid)
						{
							num = (short)780533762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return voiceFileName_A21220_Editable;
					case 4:
						return voiceFileName_A21220_Editable;
					case 5:
					{
						global::AcpBusinessLayer.Recordset recordset;
						recordset.SetRecordValidity(featureNode, true);
						num = (short)568197124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)2049835011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						if (featureNode == null)
						{
							return voiceFileName_A21220_Editable;
						}
						num = (short)1379270656;
						short num3 = num;
						num = (short)751759747;
						short num4 = num;
						num = (short)167309699;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return voiceFileName_A21220_Editable;
						default:
							num = (short)603389952;
							if (num != 0)
							{
							}
							num = (short)1497038854;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
					{
						global::AcpBusinessLayer.Recordset recordset;
						if (recordset.CumulativeMax <= global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.MaxVoiceFilesTotalMS)
						{
							num = (short)818937857;
							if (num != 0)
							{
							}
							num = (short)818610181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return voiceFileName_A21220_Editable;
					}
					}
					goto IL_54;
				}
				return voiceFileName_A21220_Editable;
				IL_54:
				ttsvoiceAnnouncementGeneralSection = (self as global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementGeneralSection);
				voiceFileName_A21220_Editable = ttsvoiceAnnouncementGeneralSection.VoiceFileName_A21220_Editable;
				featureNode = (ttsvoiceAnnouncementGeneralSection.VoiceFileName_A21220Object.Parent.Parent as global::AcpBusinessLayer.FeatureNode);
				num = (short)614072327;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}
	}
}
