using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using AcpBusinessLayer;
using AcpCommonLib;
using ConstraintHelper;
using MackinawCPS.CommandLineCPS;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.EntityModel.GenericModel;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using Motorola.MackinawCPS.CoreFeatures.DataProfiles;
using Motorola.MackinawCPS.CoreFeatures.DataWide;
using Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using PreEmptive.SoS.Runtime;
using SpecialFeatures.Clone_Configuration.Common;
using SpecialFeatures.DVRSFiles.List;
using SpecialFeatures.Flashport.FlashRadio;
using SpecialFeatures.RadioFeatureSet;
using SpecialFeatures.ReadWritePassword;
using SpecialFeatures.Security;
using SpecialFeatures.Utilities;

namespace MackinawCPS
{
	// Token: 0x0200000C RID: 12
	public static class CommonUtility
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00005474 File Offset: 0x00003674
		internal static void PopulatecpAndDeviceColumnsFromDatabaseLayer(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug cp, global::Motorola.CommonCPS.Server.EntityModel.Radio dev, global::MackinawCPS.PopulateOpeartion operation)
		{
			int a_ = 2;
			short num;
			try
			{
				for (;;)
				{
					IL_09:
					num = (short)222560256;
					int num2 = (int)num;
					switch (num2)
					{
					default:
					{
						switch (0)
						{
						case 0:
							goto IL_124;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
						global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
						for (;;)
						{
							IL_31:
							global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
							int num4;
							int num5;
							global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile[] array2;
							global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[] array3;
							global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[] array4;
							switch (num2)
							{
							case 0:
								if (operation != global::MackinawCPS.PopulateOpeartion.Write)
								{
									num = (short)212074543;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_879;
							case 1:
								cp.APXRadioSystems = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>();
								num = (short)235864069;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								cp.UserLoginUnitID = ((radioWide.UserInformationAndPasswords.RadWideUserInformationandUserLoginUnitID_41306.Value == null) ? null : radioWide.UserInformationAndPasswords.RadWideUserInformationandUserLoginUnitID_41306.Value.Trim());
								cp.UserLoginUnitIDEnable = new bool?(radioWide.UserInformationAndPasswords.RadWideUserInformationandUserLoginUnitIDEnable_41305.Value);
								cp.UserLoginUnitIDTextSize = new int?(radioWide.UserInformationAndPasswords.RadWideUserInformationandUserLoginUnitIDTextSize_41309.Value);
								cp.UserNameDisplayTextSize = new int?(radioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.Value);
								global::Motorola.CommonCPS.Server.EntityModel.GenericModel.MultipleFieldsXML multipleFieldsXML = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.MultipleFieldsXML();
								global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue item = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("냡藣若ꇧ蓩諫臭럯韱髳鏵諷鯹郻뫽叿刁刃挅稇礉攋愍縏䴑唓ℕ‗⌙⸛", a_), radioInformation.General.RadInfoGeneralDSPVersion_A7892.Value);
								global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue item2 = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("냡藣若ꇧ蓩諫臭럯韱髳鏵諷鯹郻귽旿愁焃琅洇䈉洋簍琏攑甓搕紗丙攛渝䔟", a_), radioInformation.General.RadInfoGeneralSecureHardwareType.Value);
								global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue item3 = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("냡藣若ꇧ蓩諫臭럯韱髳鏵諷鯹郻귽旿愁焃琅洇䈉洋簍琏攑甓搕紗䰙礛氝匟䬡䬣䠥", a_), radioInformation.General.RadInfoGeneralSecureHardwareVersion.Value);
								global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue item4 = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("냡藣若ꇧ蓩諫臭럯韱髳鏵諷鯹郻꯽䏿企刃挅稇礉攋愍縏䴑唓⼕ⴗ⌙ⴛ", a_), radioInformation.General.RadInfoGeneralUCMVersion_A9591.Value);
								global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue item5 = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("냡藣若ꇧ蓩諫臭럯韱髳鏵諷鯹郻볽濿洁瀃樅朇欉栋欍戏䐑焓搕欗猙猛瀝缟挡ጣጥḧᴩ", a_), radioInformation.General.RadInfoGeneralBootloaderVersion_A7567.Value);
								global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue item6 = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("냡藣若ꇧ蓩諫臭럯韱髳鏵諷鯹郻꫽痿氁洃栅漇尉椋簍挏笑笓砕䜗嬙┛⬝ဟᬡ", a_), radioInformation.General.RadInfoGeneralTuningVersion_A9509.Value);
								global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue item7 = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("냡藣若ꇧ蓩諫臭럯韱髳鏵諷鯹郻껽叿䘁倃倅洇砉缋服缏簑䬓圕‗ⴙ⨛☝", a_), radioInformation.General.RadInfoGeneralPSDTVersion_A8768.Value);
								global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue item8 = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("냡藣若ꇧ蓩諫臭뿯英胳鿵韷铹맻蛽烿持樃甅愇攉戋䰍缏猑易爕娗甙紛氝䐟氡䔣䬥䴧甩洫ᴭܯܱ3༵", a_), radioInformation.OptionExpansionBoard.RadInfoOptionExpansionBoardBoardName_A37549.Value);
								global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue item9 = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("냡藣若ꇧ蓩諫臭뿯英胳鿵韷铹맻蛽烿持樃甅愇攉戋䰍缏猑易爕娗甙紛氝䐟搡䴣吥䔧崩䴫尭唯搱儳䐵䬷匹医倽Ἷ́睃煅硇繉瑋", a_), radioInformation.OptionExpansionBoard.RadInfoOptionExpansionBoardBoardFirmwareVersion_A37048.Value);
								global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue item10 = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("냡藣若ꇧ蓩諫臭뿯英胳鿵韷铹맻蛽烿持樃甅愇攉戋䰍缏猑易爕娗甙紛氝䐟瘡崣嘥䴧甩洫ᴭܯȱ3༵", a_), radioInformation.OptionExpansionBoard.RadInfoOptionExpansionBoardBoardType_A37049.Value);
								multipleFieldsXML.NameAndValueList.Add(item);
								multipleFieldsXML.NameAndValueList.Add(item2);
								multipleFieldsXML.NameAndValueList.Add(item3);
								multipleFieldsXML.NameAndValueList.Add(item4);
								multipleFieldsXML.NameAndValueList.Add(item5);
								multipleFieldsXML.NameAndValueList.Add(item6);
								multipleFieldsXML.NameAndValueList.Add(item7);
								multipleFieldsXML.NameAndValueList.Add(item8);
								multipleFieldsXML.NameAndValueList.Add(item9);
								multipleFieldsXML.NameAndValueList.Add(item10);
								cp.DeviceInfoFields = multipleFieldsXML.SerializeToXML(true);
								num = (short)122224646;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
							{
								if (cp.APXOtarProfiles == null)
								{
									num = (short)2109866025;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								cp.APXOtarProfiles.Clear();
								num = (short)2019170617;
								short num3 = num;
								num = (short)339417401;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_09;
								default:
									num = (short)1118175232;
									if (num != 0)
									{
									}
									num = (short)1105133620;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 4:
								goto IL_E0D;
							case 5:
								goto IL_685;
							case 6:
								if (operation != global::MackinawCPS.PopulateOpeartion.Write)
								{
									num = (short)1831206932;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1132;
							case 7:
								goto IL_1203;
							case 8:
								goto IL_879;
							case 9:
								try
								{
									num = (short)1598423044;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_B1D;
										case 1:
										{
											string text;
											cp.LastProgrammedDate = new global::System.DateTime?(global::System.DateTime.Parse(text));
											num = (short)25427976;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 2:
											goto IL_B36;
										case 3:
											goto IL_A0D;
										case 4:
											switch (0)
											{
											case 0:
												goto IL_9CF;
											}
											continue;
										case 5:
										{
											string text;
											int startIndex;
											if ((startIndex = text.IndexOf('‎')) < 0)
											{
												num = (short)252772353;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											text = text.Remove(startIndex, 1);
											num = (short)1622999046;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 6:
											goto IL_A0D;
										case 7:
										{
											string text = radioInformation.Tracking.RadInfoLabtoolLastProgrammedDateDBValue_A8411.UIValue;
											num = (short)752877571;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 8:
											goto IL_B1D;
										}
										IL_9CF:
										if (global::System.Globalization.CultureInfo.CurrentCulture.Name.ToLower() == global::PreEmptive.SoS.Runtime.FixedLengthStream.b("諡臣", a_))
										{
											num = (short)1207697415;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										cp.LastProgrammedDate = new global::System.DateTime?(global::System.DateTime.Parse(radioInformation.Tracking.RadInfoLabtoolLastProgrammedDateDBValue_A8411.UIValue));
										num = (short)781975552;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_A0D:
										num = (short)451411973;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_B1D:
										num = (short)1179648002;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_B36:;
								}
								catch
								{
								}
								goto IL_B3B;
							case 10:
								goto IL_E0D;
							case 11:
								cp.UserName = ((radioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsSoftIDUsername_A9169.Value == null) ? null : radioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsSoftIDUsername_A9169.Value.Trim());
								num = (short)784859179;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 12:
								goto IL_121C;
							case 13:
								goto IL_5B6;
							case 14:
								goto IL_336;
							case 15:
								if (operation == global::MackinawCPS.PopulateOpeartion.Read)
								{
									num = (short)1368391705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_918;
							case 16:
								goto IL_685;
							case 17:
								goto IL_336;
							case 18:
							{
								global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile[] array;
								if (num4 >= array.Length)
								{
									num = (short)367263777;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile = array[num4];
								apxdataProfile.OrderId = new int?(num5);
								cp.APXDataProfiles.Add(apxdataProfile);
								num5++;
								num4++;
								num = (short)1016004621;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 19:
								goto IL_813;
							case 20:
								global::MackinawCPS.CommonUtility.PopulatePassword2CodeplugColumn(cp, dev, operation);
								num = (short)145293343;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 21:
							{
								global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile[] array = array2;
								num4 = 0;
								num = (short)71893021;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 22:
								if (num4 != 1)
								{
									num = (short)1390084146;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								cp.BluetoothDunPeerIpAssignmentType = new int?(1);
								num = (short)20906032;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 23:
								dev.SerialNumber = radioInformation.General.RadInfoGeneralSerialNumber_A9122.Value;
								num = (short)1839333400;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 24:
								goto IL_119A;
							case 25:
								goto IL_8E6;
							case 26:
								goto IL_507;
							case 27:
								num = (short)82509839;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 28:
								num = (short)948305942;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 29:
								goto IL_5B6;
							case 30:
							{
								if (num4 >= array3.Length)
								{
									num = (short)780075064;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem = array3[num4];
								apxradioSystem.OrderId = new int?(num5);
								cp.APXRadioSystems.Add(apxradioSystem);
								num5++;
								num4++;
								num = (short)459866157;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 31:
								goto IL_1132;
							case 32:
								num = (short)2013986826;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 33:
								goto IL_5F0;
							case 34:
								goto IL_E0D;
							case 35:
								if (array2 != null)
								{
									num = (short)385024021;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5F0;
							case 36:
								if (cp.APXRadioSystems == null)
								{
									num = (short)844300289;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								cp.APXRadioSystems.Clear();
								num = (short)1249902608;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 37:
								if (radioInformation.Tracking.RadInfoLabtoolLastProgrammedDateDBValue_A8411.Value != 0L)
								{
									num = (short)1481179145;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_B3B;
							case 38:
								cp.BluetoothFriendlyName = ((radioWide.Bluetooth.RadWideBluetoothFriendlyName_A41181.Value == null) ? null : radioWide.Bluetooth.RadWideBluetoothFriendlyName_A41181.Value.Trim());
								cp.BluetoothDUNPeerIP = dataWide.General.DataWideGeneralBTDUNPeerIPAddress_A41123.UIValue;
								cp.BluetoothDUNSubscriberIP = dataWide.General.DataWideGeneralBTDUNSUIPAddress_A41120.UIValue;
								cp.BluetoothPANNetworkBaseAddress = radioWide.Bluetooth.RadWideBluetoothBluetoothPANNetworkAddress_41983.UIValue;
								num4 = dataWide.General.DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.Value;
								num = (short)119865388;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 39:
								goto IL_E0D;
							case 40:
								cp.APXDataProfiles = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>();
								num = (short)220135479;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 41:
								cp.APXOtarProfiles = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile>();
								num = (short)429064211;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 42:
								goto IL_918;
							case 43:
								cp.RadioAlias = ((radioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioAlias_A8829.Value == null) ? null : radioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioAlias_A8829.Value.Trim());
								num = (short)1464860672;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 44:
								if (num4 != 0)
								{
									num = (short)1547239452;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								cp.BluetoothDunPeerIpAssignmentType = new int?(0);
								num = (short)1109131281;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 45:
								goto IL_6F9;
							case 46:
								if (operation == global::MackinawCPS.PopulateOpeartion.Import)
								{
									num = (short)674168855;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_119A;
							case 47:
								cp.UserPIN = radioWide.UserInformationAndPasswords.RadWideUserInformationandPINPassword_41303Value;
								num = (short)984875059;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 48:
								goto IL_336;
							case 49:
								if (operation != global::MackinawCPS.PopulateOpeartion.Import)
								{
									num = (short)150929435;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_8E6;
							case 50:
								num = (short)1924464654;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 51:
								if (cp.APXDataProfiles == null)
								{
									num = (short)359268392;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								cp.APXDataProfiles.Clear();
								num = (short)637730842;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 52:
								goto IL_813;
							case 53:
								goto IL_6F9;
							case 54:
								if (operation != global::MackinawCPS.PopulateOpeartion.Save)
								{
									num = (short)1211695162;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1203;
							case 55:
								goto IL_507;
							case 56:
								global::MackinawCPS.CommonUtility.PopulateRadioSystemsFromCodeplug(array4, cp.Template);
								num = (short)477102083;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 57:
								switch (num4)
								{
								case 0:
									cp.SecureOperation = new int?(0);
									num = (short)2103312388;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									cp.SecureOperation = new int?(1);
									num = (short)1957101607;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_E0D;
								case 3:
									cp.SecureOperation = new int?(3);
									num = (short)2073559074;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								default:
									num = (short)172359712;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 58:
								dev.ModelNumber = radioInformation.General.RadInfoGeneralModelNumber_A8539.Value;
								num = (short)1784020999;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
							IL_336:
							radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
							cp.CodeplugVersion = radioInformation.General.RadInfoGeneralCodeplugVersion_A7683.Value;
							string radInfoFLASHportFLASHcode_A8132Value = radioInformation.FLASHport.RadInfoFLASHportFLASHcode_A8132Value;
							byte[] astroPurchasedFlashCode = new byte[0];
							global::SpecialFeatures.Flashport.FlashRadio.FlashcodeDecoder.Decode(radInfoFLASHportFLASHcode_A8132Value, ref astroPurchasedFlashCode);
							cp.AstroPurchasedFlashCode = astroPurchasedFlashCode;
							string usedFcodeValue = global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.getUsedFcodeValue();
							byte[] astroEnableFlashCode = new byte[0];
							global::SpecialFeatures.Flashport.FlashRadio.FlashcodeDecoder.Decode(usedFcodeValue, ref astroEnableFlashCode);
							cp.AstroEnableFlashCode = astroEnableFlashCode;
							num = (short)487456779;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_507:
							array2 = global::MackinawCPS.CommonUtility.PopulateDataProfiles();
							num5 = 1;
							num = (short)646381603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_5B6:
							num = (short)1958674450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_5F0:
							global::MackinawCPS.CommonUtility.PopulateDataProfilesFromCodeplug(array2, cp.Template);
							num = (short)2123366436;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_685:
							array4 = global::MackinawCPS.CommonUtility.PopulateSystems();
							num5 = 1;
							array3 = array4;
							num4 = 0;
							num = (short)1042546741;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_6F9:
							num = (short)1707343902;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_813:
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile> list = global::MackinawCPS.CommonUtility.PopulateAPXOtarProfiles();
							cp.APXOtarProfiles.AddRange(list);
							cp.OtarID = new int?(secureWide.ASTROOTAR.SecWideASTROOTARIndividualASTROOTARRadioID_A8284.Value);
							global::MackinawCPS.CommonUtility.PopulateAPXOtarProfilesFromCodeplug(list, cp.Template);
							global::MackinawCPS.CommonUtility.PopulateWiFiNetworksFromCodeplug(global::MackinawCPS.CommonUtility.PopulateWiFiNetworks(), cp.Template);
							num = (short)1043988488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_879:
							num = (short)639893553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_8E6:
							cp.FirmwareVersion = radioInformation.General.RadInfoGeneralFirmwareVersion_A8124.Value;
							num = (short)1371865130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_918:
							cp.CodeplugVersion = radioInformation.General.RadInfoGeneralCodeplugVersion_A7683.Value;
							global::MackinawCPS.CommonUtility.PopulateTemplateColumnsHelper((global::Motorola.CommonCPS.Server.EntityModel.APXTemplate)cp.Template);
							num = (short)2002714661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_B3B:
							cp.HomeSystemId = new int?(radioWide.General.RadWideGeneralOwnerSystemID_A37153.Value);
							cp.DisableWriteProtect = new bool?(radioWide.Depot.AdvancedExternalMicOnly.Value);
							cp.RadioInhibitedTrunking = new bool?(radioWide.Labtool.TrunkingRadioInhibited_A19483.Value);
							cp.OwnerAdvKeyType = new int?(radioWide.General.RadWideGeneralOwnerAdvancedKeyType_A38663.Value);
							cp.OwnerWacnId = new int?(radioWide.General.RadWideGeneralOwnerWACNID_A38656.Value);
							cp.AskRequired = new bool?(radioWide.General.RadWideGeneralASKRequired_A37152.Value);
							cp.AllowInvalidFrequency = new bool?(radioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493.Value);
							cp.RecSetCounts = global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCounts.PopulateAstroRecSetCounts();
							cp.AstroSysKeyLog = global::SpecialFeatures.Utilities.RMUtilities.PopulateAstroSysKeyLog();
							cp.BluetoothEnable = new bool?(radioWide.Bluetooth.RadWideBluetoothBluetoothEnable_A37028.Value);
							cp.DVRSHardwareEnable = new bool?((global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide).General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value);
							cp.VRID = new int?((global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide).General.DVRSWideLabtoolVrId_A43727.Value);
							cp.ASTRODVRSFiles = ((global::Motorola.CommonCPS.Server.EntityModel.APXTemplate)cp.Template).ASTRODVRSFiles;
							cp.LocationEnable = new bool?(radioWide.Location.RadWideLocationLocationEnable_A8448.Value);
							cp.P25LocationReporting = new bool?(radioWide.Location.RadWideLocP25LocationReporting_42412.Value);
							cp.OtarEnable = new bool?(secureWide.General.SecWideGeneralOTAREnable_A7966.Value);
							cp.AstroOtarEnable = new bool?(secureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value);
							cp.RadioAliasEnable = new bool?(radioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioAliasEnable_A8830.Value);
							num4 = secureWide.General.SecWideGeneralSecureOperation_A9067.Value;
							num = (short)1570177081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_E0D:
							cp.AESEnable = new bool?(secureWide.General.SecureWideAESAlgorithmEnable_43201.Value);
							num = (short)918421506;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1132:
							num = (short)614989870;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_119A:
							num = (short)1154547766;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1203:
							num = (short)341180428;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_124:
						secureWide = (global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
						radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
						dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
						cp.PeerIP = dataWide.General.DataWideGeneralPeerIPAddress1_A8524.UIValue;
						cp.SubscriberIP = dataWide.General.DataWideGeneralSubscriberIPAddress1_A9222.UIValue;
						cp.PeerIP_A41818 = dataWide.General.DataWideGeneralDVRIPAddress_A41818.UIValue;
						cp.SubscriberIP_A41819 = dataWide.General.DataWideGeneralMobileSubIPAddress_A41819.UIValue;
						num = (short)1501954086;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_31;
					}
					}
				}
				IL_121C:;
			}
			catch (global::System.Exception ex)
			{
				global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("맡꟣铥鷧蓩迫蛭闯胱꧳귵뷷苹鿻鯽烿瘁洃椅昇圉國帍缏我愓稕礗渙礛紝借挡䨣䈥氧伩娫䜭匯圱眳夵吷伹儻倽㌿с㙃⥅╇้ⵋ㩍ㅏけ㕓╕㵗ᙙ㵛❝՟ၡ㥣履䡧", a_) + ex.Message);
				throw new global::System.ApplicationException(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("닡诣雥鷧蛩跫髭闯틱音駵鳷鿹賻鋽痿攁␃朅昇渉Ⰻ樍甏搑紓甕紗㨙缛焝䰟圡䤣䠥嬧਩䨫伭夯帱䜳", a_));
			}
			num = (short)758513664;
			short num6 = num;
			num = (short)143392769;
			if (num != 0)
			{
			}
			global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("맡꟣铥鷧蓩迫蛭闯胱꧳귵뇷铹髻釽狿漁攃爅愇攉戋匍䬏圑稓爕䔗䄙䰛焝借圡䠣䜥尧伩伫席焯就倳爵崷䰹唻崽┿Ł⭃⩅㵇❉≋㵍ᙏ⁑㭓㭕᱗㭙⡛㽝ɟ͡ᝣͥ⑧୩ᕫ୭ɯ⽱", a_));
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00006770 File Offset: 0x00004970
		internal static void PopulatePassword2CodeplugColumn(global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug, global::Motorola.CommonCPS.Server.EntityModel.Radio dev, global::MackinawCPS.PopulateOpeartion operation)
		{
			switch (0)
			{
			case 0:
				goto IL_5C;
			}
			short num;
			int num3;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			global::AcpBusinessLayer.AcpField<string> radWideLabtoolRadioPassword_A;
			for (;;)
			{
				IL_0A:
				num = (short)519176192;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (operation == global::MackinawCPS.PopulateOpeartion.Import)
					{
						num = (short)1893138435;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_289;
				case 1:
					goto IL_22C;
				case 2:
					goto IL_25F;
				case 3:
					num = (short)1636368389;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (operation == global::MackinawCPS.PopulateOpeartion.Read)
					{
						num = (short)326762503;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AD;
				case 5:
					if (radioWide.Labtool.RadWideLabtoolArchiveReadPasswordEnable_A7462.Value)
					{
						num = (short)818937857;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_289;
				case 6:
					goto IL_201;
				case 7:
				{
					num = (short)755339349;
					short num4 = num;
					num = (short)1812762709;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_201;
					default:
						num = (short)163971072;
						if (num != 0)
						{
						}
						num = (short)915734534;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					goto IL_1AD;
				}
				goto IL_5C;
				IL_1AD:
				num = (short)1287192576;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_201:
				if (!radioWide.Labtool.RadWideLabtoolRadioReadPasswordEnable_A8869.Value)
				{
					num = (short)796262408;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_22C:
				(dev as global::Motorola.CommonCPS.Server.EntityModel.APXRadio).ReadPassword = new global::SpecialFeatures.ReadWritePassword.ReadWriteUtil().decryptMesg(radWideLabtoolRadioPassword_A.Value);
				num = (short)1720844290;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_25F:
			num = (short)1323171841;
			if (num != 0)
			{
			}
			IL_289:
			codeplug.PasswordPerDevice = false;
			return;
			IL_5C:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy passwordPolicy = global::MackinawCPS.CommonUtility.DecodePasswordPolicy(radioWide.Labtool.RadWideLabtoolRadioReadPasswordEnable_A8869.Value, radioWide.Labtool.RadWideLabtoolRadioWritePasswordEnable_A8889.Value, radioWide.Labtool.RadWideLabtoolArchiveReadPasswordEnable_A7462.Value);
			(codeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).PasswordPolicy = passwordPolicy;
			radWideLabtoolRadioPassword_A = radioWide.Labtool.RadWideLabtoolRadioPassword_A8837;
			(codeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).CodeplugPassword = new global::SpecialFeatures.ReadWritePassword.ReadWriteUtil().decryptMesg(radWideLabtoolRadioPassword_A.Value);
			num = (short)1323237380;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00006A10 File Offset: 0x00004C10
		internal static void PopulatecpAndDeviceColumnsFromDatabaseLayerForCruncherRead(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug cp, global::Motorola.CommonCPS.Server.EntityModel.Radio dev)
		{
			global::MackinawCPS.CommonUtility.PopulatecpAndDeviceColumnsFromDatabaseLayer(cp, dev, global::MackinawCPS.PopulateOpeartion.Read);
			string radInfoFLASHportFLASHcode_A8132Value = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).FLASHport.RadInfoFLASHportFLASHcode_A8132Value;
			if (global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadio.checkPCIFieldsValue(dev.ModelNumber, cp.FirmwareVersion, radInfoFLASHportFLASHcode_A8132Value))
			{
				short num;
				for (;;)
				{
					num = (short)1335193167;
					short num2 = num;
					num = (short)1308454479;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_75;
					}
				}
				IL_75:
				num = (short)594673664;
				short num3 = num;
				num = (short)642777088;
				if (num != 0)
				{
				}
				num = (short)1640693761;
				if (num != 0)
				{
				}
				cp.ExtendedFlags |= 1;
				return;
			}
			cp.ExtendedFlags &= -2;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00006B18 File Offset: 0x00004D18
		internal static void PopulatecpAndDeviceColumnsFromDatabaseLayerForCruncherWrite(global::Motorola.CommonCPS.Server.EntityModel.CruncherData cruncherData, global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation opType)
		{
			short num = (short)1865809920;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)12255232;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_73;
				}
				global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
				bool value;
				bool value2;
				bool value3;
				global::Motorola.CommonCPS.Server.EntityModel.JPASTROWriteJobUpdateData jpastrowriteJobUpdateData;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Labtool labtool;
				for (;;)
				{
					IL_50:
					switch (num2)
					{
					case 0:
						if (opType == global::MackinawCPS.CommandLineCPS.CruncherOperation.Operation.UPGRADE)
						{
							num = (short)247463937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_283;
					case 1:
						apxcodeplug.ExtendedFlags |= 1;
						num = (short)2132344834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_281;
					case 3:
						goto IL_20D;
					case 4:
						goto IL_189;
					case 5:
					{
						if (!value && !value2 && !value3)
						{
							jpastrowriteJobUpdateData.CodeplugPassword = string.Empty;
							num = (short)1525415940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2139450644;
						short num4 = num;
						num = (short)10448148;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_20D;
						default:
							num = (short)2004090881;
							if (num != 0)
							{
							}
							num = (short)946667520;
							if (num != 0)
							{
							}
							num = (short)964231171;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						goto IL_189;
					}
					goto IL_73;
					IL_189:
					jpastrowriteJobUpdateData.IsPasswordPerDevice = cruncherData.Codeplug.PasswordPerDevice;
					jpastrowriteJobUpdateData.LastSetJobUuid = labtool.RadWideLabtoolRCLastJobSetUUID;
					num = (short)376897536;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20D:
					string value4 = labtool.RadWideLabtoolRadioPassword_A8837.Value;
					jpastrowriteJobUpdateData.CodeplugPassword = new global::SpecialFeatures.ReadWritePassword.ReadWriteUtil().decryptMesg(value4);
					jpastrowriteJobUpdateData.PasswordPolicy = global::MackinawCPS.CommonUtility.DecodePasswordPolicy(value, value2, value3);
					num = (short)1283719174;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_281:
				IL_283:
				jpastrowriteJobUpdateData.ExtendedFlags = apxcodeplug.ExtendedFlags;
				cruncherData.WriteJobUpdateData = jpastrowriteJobUpdateData;
				return;
				IL_73:
				apxcodeplug = (cruncherData.Codeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
				global::Motorola.CommonCPS.Server.EntityModel.Radio radio = cruncherData.Radio;
				global::MackinawCPS.CommonUtility.PopulatecpAndDeviceColumnsFromDatabaseLayer(apxcodeplug, radio, global::MackinawCPS.PopulateOpeartion.Write);
				jpastrowriteJobUpdateData = new global::Motorola.CommonCPS.Server.EntityModel.JPASTROWriteJobUpdateData();
				labtool = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Labtool;
				value = labtool.RadWideLabtoolRadioReadPasswordEnable_A8869.Value;
				value2 = labtool.RadWideLabtoolRadioWritePasswordEnable_A8889.Value;
				value3 = labtool.RadWideLabtoolArchiveReadPasswordEnable_A7462.Value;
				num = (short)1885405189;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00006DBC File Offset: 0x00004FBC
		private static global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy DecodePasswordPolicy(bool readEnabled, bool writeEnabled, bool openEnabled)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy astropasswordPolicy;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_6B;
				case 1:
					num2 = (short)1413218305;
					if (num2 != 0)
					{
					}
					astropasswordPolicy |= global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.Open;
					num2 = (short)1823408134;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					astropasswordPolicy |= global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.Write;
					num2 = (short)1323368448;
					short num3 = num2;
					num2 = (short)862126080;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					goto IL_19A;
				case 4:
					if (readEnabled)
					{
						num2 = (short)1793064967;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_19A;
				case 5:
					goto IL_81;
				case 6:
					return astropasswordPolicy;
				case 7:
				{
					num2 = (short)1033461070;
					short num4 = num2;
					num2 = (short)1476287822;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_81;
					default:
						num2 = (short)1518927872;
						if (num2 != 0)
						{
						}
						astropasswordPolicy |= global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.Read;
						num2 = (short)817561603;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 8:
					if (writeEnabled)
					{
						num2 = (short)19660802;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6B;
				}
				goto IL_34;
				IL_6B:
				num2 = (short)317194245;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_81:
				if (openEnabled)
				{
					num2 = (short)822804481;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				break;
				IL_19A:
				num2 = (short)460783624;
				num = (int)((global::System.IntPtr)num2);
			}
			return astropasswordPolicy;
			IL_34:
			astropasswordPolicy = global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.None;
			num2 = (short)1403715588;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00006FA0 File Offset: 0x000051A0
		private static global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[] PopulateSystems()
		{
			short num = (short)1341521920;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_E6;
				}
				int num3;
				global::AcpCommonLib.IAcpRecordset feature;
				global::AcpCommonLib.IAcpRecordset feature2;
				global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[] array;
				bool flag;
				for (;;)
				{
					IL_27:
					global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
					int num4;
					global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem2;
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType;
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType astroSystemSubType;
					int num7;
					switch (num2)
					{
					case 0:
						apxradioSystem.SelectedDataProfileName = null;
						num = (short)1751646222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num3 += feature.Count;
						num = (short)516751379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 2)
						{
							num = (short)493486125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1280704536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 2)
						{
							num = (short)2116223001;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1062141979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num4 = feature2.Count;
						num = (short)317980680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_593;
					case 6:
						goto IL_913;
					case 7:
					{
						num = (short)1689891294;
						short num5 = num;
						num = (short)538161630;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7EC;
						default:
							num = (short)259719168;
							if (num != 0)
							{
							}
							goto IL_6E4;
						}
						break;
					}
					case 8:
						goto IL_3DA;
					case 9:
						if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 0)
						{
							num = (short)1009844261;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)926547985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						apxradioSystem2.RadioId = new int?(conventionalSystem.General.CnvSysGeneralMDCPrimaryID_A8744.Value);
						num = (short)1080623140;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_A56;
					case 12:
						return array;
					case 13:
						apxradioSystem2.SystemSubType = new global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType?(global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.QCII);
						num = (short)768475176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_A9D;
					case 15:
						if (!(systemSubType.GetValueOrDefault() == astroSystemSubType & systemSubType != null))
						{
							num = (short)1935343639;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6E4;
					case 16:
						goto IL_778;
					case 17:
						if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 1)
						{
							num = (short)221904922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)372899842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)1399521315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_9F1;
					case 20:
						if (systemSubType.GetValueOrDefault() == astroSystemSubType & systemSubType != null)
						{
							num = (short)2004418570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A56;
					case 21:
						goto IL_913;
					case 22:
						goto IL_3DA;
					case 23:
						systemSubType = apxradioSystem2.SystemSubType;
						astroSystemSubType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.DVRS;
						num = (short)434765854;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 3)
						{
							goto IL_7EC;
						}
						goto IL_913;
					case 25:
						apxradioSystem.SystemSubType = new global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType?(global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.TYPEII);
						num = (short)490536965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						apxradioSystem2.SystemSubType = new global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType?(global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.MDC);
						num = (short)1846935591;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
					{
						num = (short)1257373696;
						short num6 = num;
						if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
						{
							num = (short)1312555052;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_593;
					}
					case 28:
						apxradioSystem2.RadioId = new int?(conventionalSystem.General.CnvSysGeneralMDCPrimaryID_A8744.Value);
						apxradioSystem2.ExpandedMDCIDRange = conventionalSystem.General.CnvSysGeneralAdditionalMDCPID_A41761.Value;
						num = (short)674299935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (systemSubType.GetValueOrDefault() == astroSystemSubType & systemSubType != null)
						{
							num = (short)1777139740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						systemSubType = apxradioSystem2.SystemSubType;
						astroSystemSubType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.QCII;
						num = (short)3145748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (systemSubType.GetValueOrDefault() == astroSystemSubType & systemSubType != null)
						{
							num = (short)949878791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						systemSubType = apxradioSystem2.SystemSubType;
						astroSystemSubType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.MDC;
						num = (short)573440029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						goto IL_A56;
					case 32:
						if (trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.Value < 1)
						{
							num = (short)521797632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						apxradioSystem.SelectedDataProfileName = trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.ReferencedNode.ReferenceKey;
						num = (short)1816461353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (!flag)
						{
							num = (short)894763009;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9F1;
					case 34:
						if (num4 >= feature2.Count + feature.Count)
						{
							num = (short)23003148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						trunkingSystem = (feature[num4 - feature2.Count] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
						apxradioSystem = new global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem();
						apxradioSystem.SystemType = new global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?(global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.TRUNCKING);
						num = (short)1989017603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (!flag)
						{
							num = (short)902037508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return array;
					case 36:
						goto IL_A56;
					case 37:
						apxradioSystem2.SystemSubType = new global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType?(global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.ASTRO);
						num = (short)1827405845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (num7 >= feature2.Count)
						{
							num = (short)1718222866;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						conventionalSystem = (feature2[num7] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
						apxradioSystem2 = new global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem();
						apxradioSystem2.SystemType = new global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?(global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.CONVENTIONAL);
						num = (short)774569993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						goto IL_913;
					case 40:
						goto IL_913;
					case 41:
						goto IL_A9D;
					case 42:
						goto IL_778;
					case 43:
						goto IL_593;
					case 44:
						num = (short)879624193;
						if (num != 0)
						{
						}
						apxradioSystem.SystemSubType = new global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType?(global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.ASTRO25);
						num = (short)1568079915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						apxradioSystem2.SystemSubType = new global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType?(global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.DVRS);
						num = (short)316735494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E6;
					IL_3DA:
					num = (short)1886060578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_593:
					apxradioSystem.CnvGroupNumber = new int?(-1);
					apxradioSystem.SystemName = trunkingSystem.General.TrkSysGeneralKeyofTrunkingSystem_A12658.Value;
					apxradioSystem.SystemId = new int?(trunkingSystem.General.TrkSysGeneralSystemID_A9239.Value);
					apxradioSystem.RadioId = new int?(trunkingSystem.General.TrkSysGeneralUnitID_A12651.Value);
					apxradioSystem.WacnId = new int?(trunkingSystem.General.TrkSysGeneralHomeWACNID_A8205.Value);
					apxradioSystem.CoverageType = new int?(trunkingSystem.General.TrkSysGeneralCoverageType_A7782.Value);
					apxradioSystem.ShuffeledBandPlan = new bool?(trunkingSystem.TypeIIChannelSetup.TrkSysTypeIIChannelSetupShuffledBandPlan_A9128.Value);
					apxradioSystem.AskRequired = new bool?(trunkingSystem.General.TrkSysGeneralAskRequired_A44909.Value);
					array[num4] = apxradioSystem;
					num = (short)1502806048;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6E4:
					apxradioSystem2.RadioId = new int?(conventionalSystem.General.CnvSysGeneralIndividualID_A8287.Value);
					num = (short)1785659403;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_778:
					num = (short)1273167910;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7EC:
					num = (short)1087307789;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_913:
					apxradioSystem2.SystemName = conventionalSystem.General.CnvSysGeneralKeyofConventionalSystem_A20482.Value;
					apxradioSystem2.SystemId = new int?(conventionalSystem.General.CnvSysGeneralSystemID_A40122.Value);
					systemSubType = apxradioSystem2.SystemSubType;
					astroSystemSubType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.ASTRO;
					num = (short)2020278287;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9F1:
					array = new global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[num3];
					num7 = 0;
					num = (short)1462304784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A56:
					apxradioSystem2.CnvGroupNumber = new int?(conventionalSystem.General.CnvSysGeneralSystemGroupNumber_A21960.Value);
					array[num7] = apxradioSystem2;
					num7++;
					num = (short)1317601322;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A9D:
					num4++;
					num = (short)1494614038;
					num2 = (int)((global::System.IntPtr)num);
				}
				return array;
				IL_E6:
				feature2 = global::AcpCommonLib.FeatureManager.GetFeature(2053);
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2064);
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
				flag = global::SpecialFeatures.Security.RadioAccessValidator.IsConvOnly(radioInformation.General.RadInfoGeneralModelNumber_A8539.Value, radioInformation.FLASHport.RadInfoFLASHportFLASHcode_A8132Value, true);
				num3 = feature2.Count;
				num = (short)693633057;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00007A74 File Offset: 0x00005C74
		private static global::MackinawCPS.APXWiFiNetwork[] PopulateWiFiNetworks()
		{
			short num = (short)510132224;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_40;
				}
				global::MackinawCPS.APXWiFiNetwork[] array;
				int num4;
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset configuredNetworksListInnerRecset;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						goto IL_F6;
					case 1:
					{
						num = (short)121801755;
						short num3 = num;
						num = (short)429231131;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F6;
						default:
							num = (short)2004418560;
							if (num != 0)
							{
							}
							goto IL_DE;
						}
						break;
					}
					case 2:
						return array;
					case 3:
						goto IL_DE;
					}
					goto IL_40;
					IL_DE:
					num = (short)761921536;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F6:
					if (num4 >= configuredNetworksListInnerRecset.Count)
					{
						num = (short)934019074;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection configuredNetworksListInnerSection = (configuredNetworksListInnerRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner).ConfiguredNetworksListInnerSection;
						array[num4] = new global::MackinawCPS.APXWiFiNetwork
						{
							NetworkSSID = configuredNetworksListInnerSection.DataWideWiFiNetworkSSID_42519.Value,
							NetworkSecureType = configuredNetworksListInnerSection.DataWideWiFiNetworkSecurityType_42516.Value,
							NetworkPWD = configuredNetworksListInnerSection.DataWideWiFiNetworkEncryptedNetworkPassword_42517.Value,
							NetworkHidden = configuredNetworksListInnerSection.DataWideWIFINetworkHidden.Value
						};
						num4++;
						num = (short)1321074689;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				return array;
				IL_40:
				num = (short)1419313153;
				if (num != 0)
				{
				}
				configuredNetworksListInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide).WIFI.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset);
				array = new global::MackinawCPS.APXWiFiNetwork[configuredNetworksListInnerRecset.Count];
				num4 = 0;
				num = (short)112590848;
				short num5 = num;
				num = (short)1254490115;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00007C70 File Offset: 0x00005E70
		private static global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile[] PopulateDataProfiles()
		{
			short num = (short)1325596672;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_CB;
				}
				int num4;
				global::AcpCommonLib.IAcpRecordset feature;
				global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile[] array;
				for (;;)
				{
					IL_28:
					int value;
					global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile;
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
					switch (num2)
					{
					case 0:
						if (value != 1)
						{
							num = (short)1884094499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						apxdataProfile.BluetoothDunPeerIpAssignmentType = new int?(1);
						num = (short)204865540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_154;
					case 2:
						goto IL_743;
					case 3:
						apxdataProfile.SystemType = new int?(3);
						num = (short)517275663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_5FD;
					case 5:
						goto IL_743;
					case 6:
						num = (short)472055822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						apxdataProfile.SystemType = new int?(4);
						num = (short)106496022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						switch (value)
						{
						case 0:
							apxdataProfile.PacketDataMode = new int?(0);
							num = (short)538705921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							apxdataProfile.PacketDataMode = new int?(1);
							num = (short)754122786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							apxdataProfile.PacketDataMode = new int?(2);
							num = (short)1976303646;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)77398035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 9:
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 4)
						{
							num = (short)1994588167;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_587;
					case 10:
						goto IL_336;
					case 11:
						apxdataProfile.SystemType = new int?(2);
						num = (short)1447165980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_154;
					case 13:
						goto IL_5FD;
					case 14:
						goto IL_743;
					case 15:
						goto IL_378;
					case 16:
					{
						num = (short)1821729031;
						short num3 = num;
						num = (short)567697671;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_587;
						default:
							goto IL_898;
						}
						break;
					}
					case 17:
						apxdataProfile.SystemType = new int?(0);
						num = (short)719585316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (value != 0)
						{
							num = (short)1293549597;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						apxdataProfile.BluetoothDunPeerIpAssignmentType = new int?(0);
						num = (short)1648230413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)1508507660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_5FD;
					case 21:
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 2)
						{
							num = (short)2108817419;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_378;
					case 22:
						goto IL_378;
					case 23:
						if (num4 >= feature.Count)
						{
							num = (short)1825177616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						dataProfiles = (feature[num4] as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
						apxdataProfile = new global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile();
						apxdataProfile.Name = dataProfiles.General.DataProfGeneralkeyofDataProfiles_A19446.Value;
						apxdataProfile.PeerIP = dataProfiles.General.DataProfGeneralMobileComputerIPAddress_A8523.UIValue;
						apxdataProfile.SubscriberIP = dataProfiles.General.DataProfGeneralSubscriberIPAddress_A21157.UIValue;
						apxdataProfile.AirInterfaceAddress = dataProfiles.General.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.UIValue;
						num = (short)314048544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_378;
					case 25:
					{
						num = (short)877723648;
						short num5 = num;
						apxdataProfile.SystemType = new int?(1);
						num = (short)1406926872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						num = (short)421199873;
						if (num != 0)
						{
						}
						goto IL_336;
					case 27:
						goto IL_743;
					case 28:
						goto IL_378;
					case 29:
						num = (short)1210712064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_154;
					case 31:
						switch (value)
						{
						case 0:
							apxdataProfile.ArsMode = new int?(0);
							num = (short)577110018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							apxdataProfile.ArsMode = new int?(1);
							num = (short)1719009318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						case 4:
							goto IL_743;
						case 3:
							apxdataProfile.ArsMode = new int?(3);
							num = (short)81920027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							apxdataProfile.ArsMode = new int?(5);
							num = (short)672923653;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)120324102;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 32:
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 0)
						{
							num = (short)1755316249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1630011429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 3)
						{
							num = (short)310312963;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)408748041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						goto IL_154;
					case 35:
						num = (short)1778581524;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						goto IL_378;
					case 37:
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 1)
						{
							num = (short)1473904657;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1397227553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						goto IL_743;
					}
					goto IL_CB;
					IL_154:
					apxdataProfile.NatEnable = new bool?(dataProfiles.General.DataWideGeneralNATEnable_A38866.Value);
					value = dataProfiles.General.DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.Value;
					num = (short)765853714;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_336:
					num = (short)70778903;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_378:
					apxdataProfile.InheritFlag = new bool?(dataProfiles.General.DataProfGeneralAutoGenerateIPAddress_A19320.Value);
					apxdataProfile.AstroBluetoothDunPeerIp = dataProfiles.General.DataProfilesGeneralBTDUNPeerIPAddress_A41127.UIValue;
					apxdataProfile.AstroBluetoothDunSubscriberIp = dataProfiles.General.DataProfilesGeneralBTDUNSUIPAddress_A41126.UIValue;
					apxdataProfile.TrunkingGroupIds = global::SpecialFeatures.Utilities.RMUtilities.PopulateTrunkingGroupIDs(dataProfiles);
					value = dataProfiles.General.DataProfGeneralPacketDataMode_A8689.Value;
					num = (short)1459421192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_587:
					num = (short)912588821;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5FD:
					value = dataProfiles.Features.DataProfFeaturesARSMode_A7465.Value;
					num = (short)359858207;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_743:
					apxdataProfile.AutomaticRegistrationServerAddress = dataProfiles.Features.DataProfFeaturesAutomaticRegistrationServerAddress_A7524.UIValue;
					apxdataProfile.DirectLocationRegistration = new bool?(dataProfiles.Features.DataProfFeaturesDirLocReg_A42332.Value);
					apxdataProfile.LocationServerIPAddress = dataProfiles.Features.DataProfFeaturesLocServerIPAddr_A42333.UIValue;
					array[num4] = apxdataProfile;
					num4++;
					num = (short)1974403082;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_898:
				num = (short)679936000;
				if (num != 0)
				{
				}
				return array;
				IL_CB:
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2054);
				array = new global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile[feature.Count];
				num4 = 0;
				num = (short)1875836954;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000852C File Offset: 0x0000672C
		private static global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile> PopulateAPXOtarProfiles()
		{
			short num = (short)1760231424;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5A;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile> list;
				for (;;)
				{
					IL_27:
					int num3;
					global::AcpCommonLib.IAcpRecordset feature;
					string text;
					string flashCode;
					bool value;
					bool value2;
					bool flag;
					switch (num2)
					{
					case 0:
						goto IL_340;
					case 1:
						num = (short)322895877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						if (num3 >= feature.Count)
						{
							num = (short)499122186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = feature[num3] as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
						num = (short)666894342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_340;
					case 4:
					{
						num = (short)1673493853;
						short num4 = num;
						num = (short)453868893;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E8;
						default:
							num = (short)1836777472;
							if (num != 0)
							{
							}
							text = null;
							goto IL_11F;
						}
						break;
					}
					case 5:
					{
						string modelNumber;
						if (global::SpecialFeatures.Security.RadioAccessValidator.IsAstroMSOtarEnabled(modelNumber, flashCode))
						{
							num = (short)1278935048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					}
					case 6:
					{
						num = (short)143065088;
						short num5 = num;
						num = (short)1802371073;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile item = new global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile
						{
							Profile = ((secureKMFProfile != null) ? secureKMFProfile.ASTROOTARInformation.SecKmfProfASTROOTARInformationKeyofSecureKMFProfile_A12663.Value : null),
							OtarID = ((secureKMFProfile != null) ? new int?(secureKMFProfile.ASTROOTARInformation.SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Value) : null),
							IndependentList = ((secureKMFProfile != null) ? new bool?(secureKMFProfile.General.SecKmfProfGenIndependentKeyList_43597.Value) : null)
						};
						list.Add(item);
						num3++;
						num = (short)1085472771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
						string modelNumber = (radioInformation != null) ? radioInformation.General.RadInfoGeneralModelNumber_A8539.Value : null;
						if (radioInformation == null)
						{
							num = (short)1531904004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = radioInformation.FLASHport.RadInfoFLASHportFLASHcode_A8132Value;
						goto IL_11F;
					}
					case 8:
						goto IL_1E8;
					case 9:
						if (value && value2 && flag)
						{
							num = (short)777781249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					case 10:
						return list;
					}
					goto IL_5A;
					IL_11F:
					flashCode = text;
					global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide = global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
					value = secureWide.General.SecWideGeneralOTAREnable_A7966.Value;
					value2 = secureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value;
					flag = (secureWide.General.SecWideGeneralSecureOperation_A9067.Value == 1);
					num = (short)263847945;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E8:
					feature = global::AcpCommonLib.FeatureManager.GetFeature(2055);
					num3 = 0;
					num = (short)821493760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_340:
					num = (short)389414914;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_5A:
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile>();
				num = (short)677838855;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000088BC File Offset: 0x00006ABC
		internal static void PopulateTemplateColumnsFromDatabaseLayer(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate template)
		{
			short num = (short)1110369867;
			short num2 = num;
			num = (short)842589771;
			switch (num2 == num)
			{
			}
			num = (short)1581842432;
			short num3 = num;
			num = (short)86966273;
			if (num != 0)
			{
			}
			num = (short)554237952;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[] systems = global::MackinawCPS.CommonUtility.PopulateSystems();
			global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile[] profiles = global::MackinawCPS.CommonUtility.PopulateDataProfiles();
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile> apxOtarProfiles = global::MackinawCPS.CommonUtility.PopulateAPXOtarProfiles();
			global::MackinawCPS.CommonUtility.PopulateTemplateColumnsHelper(template);
			global::MackinawCPS.CommonUtility.PopulateRadioSystemsFromCodeplug(systems, template);
			global::MackinawCPS.CommonUtility.PopulateDataProfilesFromCodeplug(profiles, template);
			global::MackinawCPS.CommonUtility.PopulateAPXOtarProfilesFromCodeplug(apxOtarProfiles, template);
			global::MackinawCPS.CommonUtility.PopulateWiFiNetworksFromCodeplug(global::MackinawCPS.CommonUtility.PopulateWiFiNetworks(), template);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000899C File Offset: 0x00006B9C
		private static void PopulateAPXOtarProfilesFromCodeplug(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile> apxOtarProfiles, global::Motorola.CommonCPS.Server.EntityModel.Template target)
		{
			short num = (short)967442433;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					target = new global::Motorola.CommonCPS.Server.EntityModel.APXTemplate();
					num = (short)1095106561;
					if (num != 0)
					{
					}
					num = (short)1576140802;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_15;
				case 2:
				{
					num = (short)587682676;
					short num3 = num;
					num = (short)469455732;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						goto IL_C5;
					}
					break;
				}
				}
				goto IL_31;
				IL_15:
				switch (0)
				{
				case 0:
					IL_31:
					if (target != null)
					{
						goto IL_105;
					}
					num = (short)2037645312;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_C5:
			num = (short)374145024;
			short num4 = num;
			num = (short)909574144;
			if (num != 0)
			{
			}
			IL_105:
			((global::Motorola.CommonCPS.Server.EntityModel.APXTemplate)target).APXOtarProfiles = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().EntityCollectionsToXML<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile>(apxOtarProfiles.ToArray());
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00008ACC File Offset: 0x00006CCC
		private static void PopulateTemplateColumnsHelper(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate template)
		{
			short num = (short)2140026421;
			short num2 = num;
			num = (short)929576501;
			switch (num2 == num)
			{
			}
			num = (short)2118713344;
			short num3 = num;
			num = (short)163774465;
			if (num != 0)
			{
			}
			num = (short)2142633984;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide = global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide = global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			template.ProductFamily = new int?(1);
			template.ModelNumber = radioInformation.General.RadInfoGeneralModelNumber_A8539.Value;
			template.RadioAliasEnable = new bool?(radioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioAliasEnable_A8830.Value);
			template.OtarEnable = new bool?(secureWide.General.SecWideGeneralOTAREnable_A7966.Value);
			template.AstroOtarEnable = new bool?(secureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value);
			template.SecureOperation = new int?(secureWide.General.SecWideGeneralSecureOperation_A9067.Value);
			template.AESEnable = new bool?(secureWide.General.SecureWideAESAlgorithmEnable_43201.Value);
			template.BluetoothDunPeerIpAssignmentType = new int?(dataWide.General.DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.Value);
			template.BluetoothEnable = new bool?(radioWide.Bluetooth.RadWideBluetoothBluetoothEnable_A37028.Value);
			template.LocationEnable = new bool?(radioWide.Location.RadWideLocationLocationEnable_A8448.Value);
			template.P25LocationReporting = new bool?(radioWide.Location.RadWideLocP25LocationReporting_42412.Value);
			template.UserNameDisplayTextSize = radioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.Value;
			template.UserLoginUnitIDTextSize = radioWide.UserInformationAndPasswords.RadWideUserInformationandUserLoginUnitIDTextSize_41309.Value;
			template.UserLoginUnitIDEnable = radioWide.UserInformationAndPasswords.RadWideUserInformationandUserLoginUnitIDEnable_41305.Value;
			template.PeerIP_A41818 = dataWide.General.DataWideGeneralDVRIPAddress_A41818.UIValue;
			template.SubscriberIP_A41819 = dataWide.General.DataWideGeneralMobileSubIPAddress_A41819.UIValue;
			template.CodeplugVersion = radioInformation.General.RadInfoGeneralCodeplugVersion_A7683.Value;
			template.FirmwareVersion = radioInformation.General.RadInfoGeneralFirmwareVersion_A8124.Value;
			template.AllowInvalidFrequency = new bool?(radioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493.Value);
			global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu displayAndMenu = global::AcpCommonLib.FeatureManager.GetFeature(2010)[0] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu;
			template.LanguageIndex = new int?(displayAndMenu.Advanced.DispMenuAdvancedLanguageSelection_A8386Value);
			string radInfoFLASHportFLASHcode_A8132Value = radioInformation.FLASHport.RadInfoFLASHportFLASHcode_A8132Value;
			byte[] astroPurchasedFlashCode = new byte[0];
			global::SpecialFeatures.Flashport.FlashRadio.FlashcodeDecoder.Decode(radInfoFLASHportFLASHcode_A8132Value, ref astroPurchasedFlashCode);
			template.AstroPurchasedFlashCode = astroPurchasedFlashCode;
			string usedFcodeValue = global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.getUsedFcodeValue();
			byte[] astroEnableFlashCode = new byte[0];
			global::SpecialFeatures.Flashport.FlashRadio.FlashcodeDecoder.Decode(usedFcodeValue, ref astroEnableFlashCode);
			template.AstroEnableFlashCode = astroEnableFlashCode;
			template.RecSetCounts = global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCounts.PopulateAstroRecSetCounts();
			template.HomeSystemId = new int?(radioWide.General.RadWideGeneralOwnerSystemID_A37153.Value);
			template.OwnerAdvKeyType = new int?(radioWide.General.RadWideGeneralOwnerAdvancedKeyType_A38663.Value);
			template.OwnerWacnId = new int?(radioWide.General.RadWideGeneralOwnerWACNID_A38656.Value);
			template.BluetoothPANNetworkBaseAddress = radioWide.Bluetooth.RadWideBluetoothBluetoothPANNetworkAddress_41983.UIValue;
			template.WiFiEnable = new bool?(dataWide.WIFI.DataWideWIFIEnable_42506.Value);
			template.RegionalGovernance = new int?(radioInformation.General.RadInfoGeneralRegionalGovernance_A36710.Value);
			global::MackinawCPS.CommonUtility.PopulateDVRSFromCodeplugDB(template);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00008EB0 File Offset: 0x000070B0
		private static void PopulateDVRSFromCodeplugDB(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate target)
		{
			int a_ = 15;
			short num = (short)335151104;
			switch (num)
			{
			default:
			{
				num = (short)1942618125;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet dvrsfileListRecSet;
					global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset dvrsfileListInnerRecset;
					bool? dvrshardwareEnable;
					bool flag;
					switch (num2)
					{
					case 0:
						goto IL_B3;
					case 1:
					{
						num = (short)1326151207;
						short num3 = num;
						num = (short)1712616999;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3C9;
						default:
							num = (short)208535552;
							if (num != 0)
							{
							}
							if (dvrsfileListRecSet.Count > 0)
							{
								num = (short)338296842;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2B5;
						}
						break;
					}
					case 2:
						if (dvrsfileListRecSet != null)
						{
							num = (short)1126498312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DC;
					case 3:
						if (dvrsfileListInnerRecset != null)
						{
							num = (short)962068495;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B5;
					case 4:
						goto IL_2B5;
					case 5:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles> astrodvrsfiles = target.ASTRODVRSFiles;
						if (astrodvrsfiles == null)
						{
							return;
						}
						astrodvrsfiles.Clear();
						num = (short)280428561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_1DC;
					case 7:
						if (dvrsfileListRecSet.Count == 0)
						{
							num = (short)1287520262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
						num = (short)1094975495;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (dvrsfileListRecSet != null)
						{
							num = (short)110821388;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B5;
					case 10:
						goto IL_3C9;
					case 11:
						num = (short)343670785;
						if (num != 0)
						{
						}
						if (!(dvrshardwareEnable.GetValueOrDefault() == flag & dvrshardwareEnable != null))
						{
							num = (short)990445584;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DC;
					case 12:
					{
						num = (short)446758912;
						short num4 = num;
						num = (short)1334247425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						switch (0)
						{
						case 0:
							goto IL_94;
						}
						continue;
					case 14:
						target = new global::Motorola.CommonCPS.Server.EntityModel.APXTemplate();
						num = (short)836829184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						dvrsfileListInnerRecset.Clear();
						num = (short)1212022788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)1966473218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						return;
					}
					IL_94:
					if (target == null)
					{
						num = (short)1030160398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B3:
					global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide dvrswide = global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
					target.DVRSHardwareEnable = new bool?(dvrswide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value);
					target.DVRSHashCode = dvrswide.General.DVRSWideLabtoolDVRSSyncFieldsHash_A41811.Value;
					dvrsfileListRecSet = (global::AcpCommonLib.FeatureManager.GetFeature(4234) as global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet);
					dvrshardwareEnable = target.DVRSHardwareEnable;
					flag = false;
					num = (short)1321861131;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DC:
					num = (short)788463625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B5:
					num = (short)1552416773;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C9:
					global::SpecialFeatures.DVRSFiles.List.DVRSFileLabtoolSection dvrsfileLabtoolSection = dvrsfileListRecSet[0][10893] as global::SpecialFeatures.DVRSFiles.List.DVRSFileLabtoolSection;
					dvrsfileLabtoolSection.DVRSConfigDVRSFileName_A43736Object.Value = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꯮꟰ꇲ꛴ퟶ뿸鋺釼髾℀㈂", a_);
					dvrsfileListInnerRecset = (dvrsfileLabtoolSection.EmbeddedRecset as global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset);
					num = (short)1371799555;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000092AC File Offset: 0x000074AC
		private static void PopulateRadioSystemsFromCodeplug(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[] systems, global::Motorola.CommonCPS.Server.EntityModel.Template target)
		{
			short num = (short)230424577;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1770979329;
					if (num != 0)
					{
					}
					target = new global::Motorola.CommonCPS.Server.EntityModel.APXTemplate();
					num = (short)1811021826;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_16;
				case 2:
				{
					num = (short)984852248;
					short num3 = num;
					num = (short)146056984;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16;
					default:
						goto IL_C9;
					}
					break;
				}
				}
				goto IL_32;
				IL_16:
				switch (0)
				{
				case 0:
					IL_32:
					if (target != null)
					{
						goto IL_108;
					}
					num = (short)1507262464;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_C9:
			num = (short)1860501504;
			short num4 = num;
			num = (short)555876352;
			if (num != 0)
			{
			}
			IL_108:
			((global::Motorola.CommonCPS.Server.EntityModel.APXTemplate)target).RadioSystems = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().EntityCollectionsToXML<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>(systems);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000093D8 File Offset: 0x000075D8
		private static void PopulateDataProfilesFromCodeplug(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile[] profiles, global::Motorola.CommonCPS.Server.EntityModel.Template target)
		{
			short num = (short)1528496129;
			if (num != 0)
			{
			}
			num = (short)445579265;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					target = new global::Motorola.CommonCPS.Server.EntityModel.APXTemplate();
					num = (short)1966342146;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_3E;
				case 2:
				{
					num = (short)1057237467;
					short num3 = num;
					num = (short)312551899;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3E;
					default:
						goto IL_C7;
					}
					break;
				}
				}
				goto IL_5A;
				IL_3E:
				switch (0)
				{
				case 0:
					IL_5A:
					if (target != null)
					{
						goto IL_107;
					}
					num = (short)2089615360;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_C7:
			num = (short)603127808;
			short num4 = num;
			num = (short)1556414464;
			if (num != 0)
			{
			}
			IL_107:
			((global::Motorola.CommonCPS.Server.EntityModel.APXTemplate)target).DataProfiles = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().EntityCollectionsToXML<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>(profiles);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00009504 File Offset: 0x00007704
		private static void PopulateWiFiNetworksFromCodeplug(global::MackinawCPS.APXWiFiNetwork[] wifiNetworks, global::Motorola.CommonCPS.Server.EntityModel.Template target)
		{
			short num = (short)2025783297;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)2057830401;
					if (num != 0)
					{
					}
					target = new global::Motorola.CommonCPS.Server.EntityModel.APXTemplate();
					num = (short)1778188290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_16;
				case 2:
				{
					num = (short)33778312;
					short num3 = num;
					num = (short)414870152;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16;
					default:
						goto IL_C6;
					}
					break;
				}
				}
				goto IL_32;
				IL_16:
				switch (0)
				{
				case 0:
					IL_32:
					if (target != null)
					{
						goto IL_106;
					}
					num = (short)532807680;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_C6:
			num = (short)1403781120;
			short num4 = num;
			num = (short)1522270208;
			if (num != 0)
			{
			}
			IL_106:
			((global::Motorola.CommonCPS.Server.EntityModel.APXTemplate)target).WiFiNetworks = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().EntityCollectionsToXML<global::MackinawCPS.APXWiFiNetwork>(wifiNetworks);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00009630 File Offset: 0x00007830
		public static void SetFeatureSet(global::Motorola.CommonCPS.Server.EntityModel.Radio d, global::System.Guid radioUuid)
		{
			short num = (short)813039616;
			switch (num)
			{
			default:
			{
				bool isPortablePro = global::ConstraintHelper.UtilityMack.IsPortablePro;
				string radInfoFLASHportFLASHcode_A8132Value = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).FLASHport.RadInfoFLASHportFLASHcode_A8132Value;
				global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable = new global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable(isPortablePro, true);
				try
				{
					d.RadioFeatures.Clear();
					flashcodeTable.InitTable(true, d.ModelNumber, false);
					global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator = flashcodeTable.FLASHcode.GetEnumerator();
					try
					{
						num = (short)520159235;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::SpecialFeatures.Flashport.FlashRadio.Option option;
								d.RadioFeatures.Add(global::Motorola.CommonCPS.Server.EntityModel.RadioFeature.CreateRadioFeature(null, radioUuid, (int)option.OptionID, 8, 8, false, 8, 0, 0, ""));
								num = (short)395051009;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								num = (short)903282694;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_B4;
								}
								continue;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)46858242;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::SpecialFeatures.Flashport.FlashRadio.Option option = enumerator.Current;
								num = (short)1282539525;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
							{
								global::SpecialFeatures.Flashport.FlashRadio.Option option;
								if (flashcodeTable.IsOptionEnabledInFlashcode(option, radInfoFLASHportFLASHcode_A8132Value))
								{
									num = (short)549519360;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								goto IL_18D;
							}
							IL_F5:
							num = (short)336068612;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_B4:
							goto IL_F5;
						}
						IL_18D:;
					}
					finally
					{
						num = (short)1744502785;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1546584066;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_1A7;
							case 2:
							{
								num = (short)631465214;
								short num3 = num;
								num = (short)1605788926;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1A7;
								default:
									goto IL_231;
								}
								break;
							}
							}
							goto IL_1C4;
							IL_1A7:
							switch (0)
							{
							case 0:
								IL_1C4:
								if (enumerator == null)
								{
									goto IL_248;
								}
								num = (short)285343744;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
						}
						IL_231:
						num = (short)1352728576;
						if (num != 0)
						{
						}
						IL_248:;
					}
				}
				finally
				{
					num = (short)246284289;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							((global::System.IDisposable)flashcodeTable).Dispose();
							num = (short)1601830914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_27B;
							}
							continue;
						case 2:
							goto IL_2B1;
						}
						IL_27B:
						if (flashcodeTable == null)
						{
							break;
						}
						num = (short)1181351936;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2B1:;
				}
				num = (short)617349120;
				short num4 = num;
				num = (short)741867521;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x0400001B RID: 27
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
