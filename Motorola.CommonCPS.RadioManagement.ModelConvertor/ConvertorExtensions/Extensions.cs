using System;
using CommonUtility;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.ConvertorExtensions
{
	// Token: 0x02000011 RID: 17
	public static class Extensions
	{
		// Token: 0x0600003D RID: 61 RVA: 0x000071C0 File Offset: 0x000053C0
		public static global::Motorola.CommonCPS.Server.EntityModel.MatrixRadioSummary ToSummary(this global::Motorola.CommonCPS.Server.EntityModel.MatrixRadio radio)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.MatrixRadioSummary matrixRadioSummary;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug matrixCodeplug;
					if (matrixCodeplug.Provisioning != null)
					{
						num2 = (short)952827905;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return matrixRadioSummary;
				}
				case 1:
				{
					num2 = (short)754253825;
					if (num2 != 0)
					{
					}
					global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug matrixCodeplug;
					matrixRadioSummary.ProvisioningName = matrixCodeplug.Provisioning.PackageName;
					num2 = (short)1077215236;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug matrixCodeplug = radio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug;
					goto IL_132;
				}
				case 3:
				{
					num2 = (short)1425379536;
					short num3 = num2;
					num2 = (short)451252432;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_132;
					default:
						num2 = (short)463798272;
						if (num2 != 0)
						{
						}
						if (radio.WorkingCodeplug != null)
						{
							num2 = (short)280100866;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return matrixRadioSummary;
					}
					break;
				}
				case 4:
					return matrixRadioSummary;
				}
				goto IL_24;
				IL_132:
				num2 = (short)1015611392;
				num = (int)((global::System.IntPtr)num2);
			}
			return matrixRadioSummary;
			IL_24:
			matrixRadioSummary = new global::Motorola.CommonCPS.Server.EntityModel.MatrixRadioSummary();
			matrixRadioSummary.Uuid = radio.Uuid;
			matrixRadioSummary.Timestamp = radio.Timestamp;
			global::CommonUtility.RadioSummaryConverter.PopulateFromRadio(matrixRadioSummary, new global::CommonUtility.RadioSummaryDataContext(radio));
			num2 = (short)1478557696;
			short num4 = num2;
			num2 = (short)519176195;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00007364 File Offset: 0x00005564
		public static global::Motorola.CommonCPS.Server.EntityModel.APXRadioSummary ToSummary(this global::Motorola.CommonCPS.Server.EntityModel.APXRadio radio)
		{
			short num = (short)1757493207;
			short num2 = num;
			num = (short)2061121495;
			switch (num2 == num)
			{
			}
			num = (short)1376845824;
			if (num != 0)
			{
			}
			num = (short)200605696;
			short num3 = num;
			num = (short)2093088769;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.APXRadioSummary apxradioSummary = new global::Motorola.CommonCPS.Server.EntityModel.APXRadioSummary();
			apxradioSummary.Uuid = radio.Uuid;
			apxradioSummary.Timestamp = radio.Timestamp;
			global::CommonUtility.RadioSummaryConverter.PopulateFromRadio(apxradioSummary, new global::CommonUtility.RadioSummaryDataContext(radio));
			return apxradioSummary;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00007438 File Offset: 0x00005638
		private static void a(global::Motorola.CommonCPS.Server.EntityModel.ASTRORadioSummary A_0, global::Motorola.CommonCPS.Server.EntityModel.APXRadio A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
				switch (num)
				{
				case 0:
					if (apxcodeplug != null)
					{
						num2 = (short)1587675146;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					num2 = (short)836108288;
					short num3 = num2;
					A_0.HomeSystemId = apxcodeplug.HomeSystemId;
					num2 = (short)1144520707;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_16E;
				case 3:
					goto IL_16E;
				case 4:
					num2 = (short)402915329;
					if (num2 != 0)
					{
					}
					if (A_1.WorkingCodeplug != null)
					{
						num2 = (short)8323081;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
				{
					int? ownerAdvKeyType;
					int num4;
					if (!(ownerAdvKeyType.GetValueOrDefault() == num4 & ownerAdvKeyType != null))
					{
						ownerAdvKeyType = A_0.OwnerAdvKeyType;
						num4 = 1;
						num2 = (short)2140471302;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1575836844;
					short num5 = num2;
					num2 = (short)1035558060;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_444;
					default:
						num2 = (short)387186688;
						if (num2 != 0)
						{
						}
						num2 = (short)2074804225;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 6:
				{
					int? ownerAdvKeyType;
					int num4;
					if (ownerAdvKeyType.GetValueOrDefault() == num4 & ownerAdvKeyType != null)
					{
						num2 = (short)395378696;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_16E;
				}
				case 7:
					return;
				case 8:
					goto IL_444;
				case 9:
					apxcodeplug = (A_1.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
					num2 = (short)2424832;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
				{
					A_0.AstroPurchasedFlashCode = apxcodeplug.AstroPurchasedFlashCode;
					A_0.PeerIP = apxcodeplug.PeerIP;
					A_0.PeerIP_A41818 = apxcodeplug.PeerIP_A41818;
					A_0.AskRequired = apxcodeplug.AskRequired;
					A_0.BluetoothDUNPeerIP = apxcodeplug.BluetoothDUNPeerIP;
					A_0.BluetoothDUNSubscriberIP = apxcodeplug.BluetoothDUNSubscriberIP;
					A_0.BluetoothFriendlyName = apxcodeplug.BluetoothFriendlyName;
					A_0.OtarID = apxcodeplug.OtarID;
					A_0.VRID = apxcodeplug.VRID;
					A_0.DVRSHardwareEnable = apxcodeplug.DVRSHardwareEnable;
					A_0.SubscriberIP = apxcodeplug.SubscriberIP;
					A_0.SubscriberIP_A41819 = apxcodeplug.SubscriberIP_A41819;
					A_0.UserLoginUnitID = apxcodeplug.UserLoginUnitID;
					A_0.UserName = apxcodeplug.UserName;
					A_0.UserPIN = apxcodeplug.UserPIN;
					A_0.RadioAliasEnable = apxcodeplug.RadioAliasEnable;
					A_0.OtarEnable = apxcodeplug.OtarEnable;
					A_0.AstroOtarEnable = apxcodeplug.AstroOtarEnable;
					A_0.SecureOperation = apxcodeplug.SecureOperation;
					A_0.AESEnable = apxcodeplug.AESEnable;
					A_0.BluetoothDunPeerIpAssignmentType = apxcodeplug.BluetoothDunPeerIpAssignmentType;
					A_0.BluetoothEnable = apxcodeplug.BluetoothEnable;
					A_0.UserNameDisplayTextSize = apxcodeplug.UserNameDisplayTextSize;
					A_0.UserLoginUnitIDTextSize = apxcodeplug.UserLoginUnitIDTextSize;
					A_0.UserLoginUnitIDEnable = apxcodeplug.UserLoginUnitIDEnable;
					A_0.AutomaticRegistrationServerAddress = apxcodeplug.AutomaticRegistrationServerAddress;
					A_0.AstroPurchasedFlashCode = apxcodeplug.AstroPurchasedFlashCode;
					A_0.UpgradeAbility = apxcodeplug.UpgradeAbility;
					A_0.OwnerAdvKeyType = apxcodeplug.OwnerAdvKeyType;
					A_0.DisableWriteProtect = apxcodeplug.DisableWriteProtect;
					A_0.LocationEnable = apxcodeplug.LocationEnable;
					A_0.LocationServerIPAddress = apxcodeplug.LocationServerIPAddress;
					A_0.BluetoothPANNetworkBaseAddress = apxcodeplug.BluetoothPANNetworkBaseAddress;
					A_0.P25LocationReporting = apxcodeplug.P25LocationReporting;
					A_0.ArsMode = apxcodeplug.ArsMode;
					A_0.DirectLocationRegistration = apxcodeplug.DirectLocationRegistration;
					int? ownerAdvKeyType = A_0.OwnerAdvKeyType;
					int num4 = 0;
					num2 = (short)396492805;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_3C;
				IL_16E:
				A_0.GroupDataJobId = A_1.LastJob.GroupDataJobId;
				A_0.MaceSecureHardwareType = A_1.MaceSecureHardwareType;
				num2 = (short)1766916103;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_444:
				A_0.OwnerWacnId = apxcodeplug.OwnerWacnId;
				num2 = (short)243662850;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_3C:
			A_0.ForeignIP = A_1.ForeignIP;
			A_0.APXRadioType = A_1.APXRadioType;
			num2 = (short)1146880004;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00007890 File Offset: 0x00005A90
		public static global::Motorola.CommonCPS.Server.EntityModel.PBBRadioSummary ToSummary(this global::Motorola.CommonCPS.Server.EntityModel.PBBRadio radio)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.PBBRadioSummary pbbradioSummary;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug pbbcodeplug;
					if (pbbcodeplug.Provisioning != null)
					{
						num2 = (short)618725386;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A2;
				}
				case 1:
					return pbbradioSummary;
				case 2:
				{
					global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug pbbcodeplug;
					if (pbbcodeplug.PBBFirmware != null)
					{
						goto IL_C5;
					}
					return pbbradioSummary;
				}
				case 3:
				{
					global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug pbbcodeplug;
					pbbradioSummary.PBBFirmwareVersion = pbbcodeplug.PBBFirmware.PackageVersion;
					num2 = (short)1673461761;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					if (radio.WorkingCodeplug != null)
					{
						num2 = (short)1329135625;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return pbbradioSummary;
				case 5:
				{
					num2 = (short)1123475081;
					short num3 = num2;
					num2 = (short)1696390793;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C5;
					default:
					{
						num2 = (short)1179779072;
						if (num2 != 0)
						{
						}
						global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug pbbcodeplug;
						pbbradioSummary.HomeSetPackageName = pbbcodeplug.PBBHomeSet.PackageName;
						num2 = (short)1837891590;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 6:
					goto IL_E1;
				case 7:
				{
					global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug pbbcodeplug;
					if (pbbcodeplug.PBBHomeSet != null)
					{
						num2 = (short)1360068613;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E1;
				}
				case 8:
					goto IL_A2;
				case 9:
				{
					num2 = (short)1162346497;
					if (num2 != 0)
					{
					}
					global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug pbbcodeplug = radio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug;
					num2 = (short)1311571975;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
				{
					global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug pbbcodeplug;
					pbbradioSummary.ProvisioningName = pbbcodeplug.Provisioning.PackageName;
					num2 = (short)1532821512;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_3C;
				IL_A2:
				num2 = (short)2081030146;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_C5:
				num2 = (short)1079115779;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_E1:
				num2 = (short)920125440;
				short num4 = num2;
				num2 = (short)724500480;
				num = (int)((global::System.IntPtr)num2);
			}
			return pbbradioSummary;
			IL_3C:
			pbbradioSummary = new global::Motorola.CommonCPS.Server.EntityModel.PBBRadioSummary();
			pbbradioSummary.Uuid = radio.Uuid;
			pbbradioSummary.Timestamp = radio.Timestamp;
			global::CommonUtility.RadioSummaryConverter.PopulateFromRadio(pbbradioSummary, new global::CommonUtility.RadioSummaryDataContext(radio));
			num2 = (short)1878851588;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00007B2C File Offset: 0x00005D2C
		private static void a(global::Motorola.CommonCPS.Server.EntityModel.Package A_0, global::Motorola.CommonCPS.Server.EntityModel.PackageSummary A_1)
		{
			if (A_0 == null)
			{
				short num = (short)559349760;
				short num2 = num;
				num = (short)1961799969;
				short num3 = num;
				num = (short)2113319201;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1449525249;
					if (num != 0)
					{
					}
					num = (short)316669952;
					if (num != 0)
					{
					}
					return;
				}
			}
			A_1.FileUuid = A_0.FileUuid;
			A_1.CreatedDate = A_0.CreatedDate;
			A_1.ModifiedDate = A_0.ModifiedDate;
			A_1.Comment = A_0.Comment;
			A_1.Timestamp = A_0.Timestamp;
			A_1.Uuid = A_0.Uuid;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00007C28 File Offset: 0x00005E28
		private static void a(global::Motorola.CommonCPS.Server.EntityModel.PCRPackage A_0, global::Motorola.CommonCPS.Server.EntityModel.PCRPackageSummary A_1)
		{
			short num = (short)748123040;
			short num2 = num;
			num = (short)243364768;
			switch (num2 == num)
			{
			}
			num = (short)455999488;
			if (num != 0)
			{
			}
			num = (short)1433796608;
			short num3 = num;
			num = (short)263454721;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Extensions.a(A_0, A_1);
			global::System.Guid guid;
			A_1.PackageGroup = new global::System.Guid?(global::System.Guid.TryParse(A_0.PackageGroup, out guid) ? guid : global::System.Guid.Empty);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00007D00 File Offset: 0x00005F00
		private static void a(global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage A_0, global::Motorola.CommonCPS.Server.EntityModel.ASTROPackageSummary A_1)
		{
			short num = (short)2054422385;
			short num2 = num;
			num = (short)1640234865;
			switch (num2 == num)
			{
			}
			num = (short)1613692929;
			if (num != 0)
			{
			}
			num = (short)1213005824;
			short num3 = num;
			num = (short)235143168;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Extensions.a(A_0, A_1);
			A_1.PackageDescription = A_0.PackageDescription;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00007DBC File Offset: 0x00005FBC
		public static global::Motorola.CommonCPS.Server.EntityModel.PackageSummary AutoConverToSummary(this global::Motorola.CommonCPS.Server.EntityModel.Package package)
		{
			short num = (short)1388773387;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)956694528;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_133;
				case 1:
					if (package is global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement)
					{
						num = (short)790233097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)788135943;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_F7;
				case 3:
					if (package is global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncement)
					{
						num = (short)1278803978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)346292228;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (typeof(global::Motorola.CommonCPS.Server.EntityModel.PackageSummary) == package.GetType())
					{
						num = (short)1990721550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_39E;
				case 5:
					goto IL_2C6;
				case 6:
					goto IL_360;
				case 7:
					if (package is global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates)
					{
						num = (short)924450822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1500119048;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (package is global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles)
					{
						num = (short)1719402497;
						if (num != 0)
						{
						}
						num = (short)223805445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1219624972;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_172;
				case 10:
					goto IL_311;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_96;
					}
					continue;
				case 12:
					if (package is global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroup)
					{
						num = (short)1589837824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1413677069;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (package is global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack)
					{
						num = (short)1955856386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1597898755;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_261;
				case 15:
					goto IL_207;
				case 16:
					goto IL_B8;
				case 17:
					if (package is global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack)
					{
						num = (short)141268001;
						short num4 = num;
						num = (short)1123062817;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1628897280;
							if (num != 0)
							{
							}
							num = (short)2018902031;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
					}
					num = (short)1729560577;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_96:
				if (package is global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware)
				{
					num = (short)1837236240;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)75038737;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_B8:
			return (package as global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware).ToSummary();
			IL_F7:
			return (package as global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack).ToSummary();
			IL_133:
			return (package as global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroup).ToSummary();
			IL_172:
			return (package as global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement).ToSummary();
			IL_207:
			return (package as global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack).ToSummary();
			IL_261:
			global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary = new global::Motorola.CommonCPS.Server.EntityModel.PackageSummary();
			global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Extensions.a(package, packageSummary);
			return packageSummary;
			IL_2C6:
			return (package as global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles).ToSummary();
			IL_311:
			return (package as global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncement).ToSummary();
			IL_360:
			return (package as global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates).ToSummary();
			IL_39E:
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000816C File Offset: 0x0000636C
		public static global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary ToSummary(this global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware package)
		{
			short num;
			for (;;)
			{
				num = (short)1393295361;
				if (num != 0)
				{
				}
				if (package != null)
				{
					goto IL_AB;
				}
				num = (short)1556007935;
				short num2 = num;
				num = (short)1600113663;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_62;
				}
			}
			IL_62:
			num = (short)591659008;
			short num3 = num;
			num = (short)1191378944;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary();
			IL_AB:
			global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary astrofirmwareSummary = new global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary
			{
				PackageName = package.PackageName,
				PackageVersion = package.PackageVersion,
				HfwsFlag = package.HfwsFlag,
				DspVersion = package.DspVersion,
				SoftwareVersion = package.SoftwareVersion,
				MaceFlashVersion = package.MaceFlashVersion,
				PsdtVersion = package.PsdtVersion,
				OptBrdHwHostVersion = package.OptBrdHwHostVersion,
				LTEOptBrdHwHostVersion = package.LTEOptBrdHwHostVersion,
				ConBrdHwHostVersion = package.ConBrdHwHostVersion,
				TargetModel = package.TargetModel,
				ReferenceCount = package.ReferenceCount,
				IsFreonFirmwareUpgradeFile = package.IsFreonFirmwareUpgradeFile,
				IsOMAPFirmwareUpgradeFile = package.IsOMAPFirmwareUpgradeFile,
				BaseSoftwareVersion = package.BaseSoftwareVersion,
				BuildTimestamp = package.BuildTimestamp,
				TargetRelease = package.TargetRelease,
				MaxCodeplugVersion = package.MaxCodeplugVersion
			};
			global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Extensions.a(package, astrofirmwareSummary);
			return astrofirmwareSummary;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000830C File Offset: 0x0000650C
		public static global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary ToSummary(this global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroup package)
		{
			while (package == null)
			{
				short num = (short)202472865;
				short num2 = num;
				num = (short)1293385121;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1155334144;
					if (num != 0)
					{
					}
					num = (short)927727616;
					short num3 = num;
					num = (short)108986369;
					if (num != 0)
					{
					}
					return new global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary();
				}
				}
			}
			global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary pcrfirmwareCodeplugPairGroupSummary = new global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary
			{
				PackageName = package.PackageName,
				FirmwareVersion = package.FirmwareVersion,
				CodeplugVersion = package.CodeplugVersion,
				Region = package.Region,
				Size = package.Size,
				ReferenceCount = package.ReferenceCount,
				IsUpdating = package.IsUpdating,
				RDate = package.RDate
			};
			global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Extensions.a(package, pcrfirmwareCodeplugPairGroupSummary);
			return pcrfirmwareCodeplugPairGroupSummary;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00008434 File Offset: 0x00006634
		public static global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary ToSummary(this global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack package)
		{
			short num = (short)978059266;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_102;
				case 1:
					goto IL_BC;
				case 2:
				{
					num = (short)663289856;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				}
				}
				IL_59:
				num = (short)304695636;
				short num4 = num;
				num = (short)1860979028;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_E5;
				default:
					num = (short)1809121280;
					if (num != 0)
					{
					}
					if (package == null)
					{
						num = (short)2096955393;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1396113408;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_BC:
			num = (short)712310785;
			if (num != 0)
			{
			}
			IL_E5:
			return new global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary();
			IL_102:
			global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary astrolanguagePackSummary = new global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary
			{
				PackageName = package.PackageName,
				PackageVersion = package.PackageVersion,
				PackageLanguage = package.PackageLanguage,
				LpID = package.LpID,
				CompatibleVersion = package.CompatibleVersion,
				ReferenceCount = package.ReferenceCount,
				FileSize = ((package.RMFile == null) ? null : package.RMFile.Length)
			};
			global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Extensions.a(package, astrolanguagePackSummary);
			return astrolanguagePackSummary;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000085C4 File Offset: 0x000067C4
		public static global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary ToSummary(this global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack package)
		{
			short num = (short)68485122;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_102;
				case 1:
					goto IL_BC;
				case 2:
				{
					num = (short)807206912;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				}
				}
				IL_59:
				num = (short)765735253;
				short num4 = num;
				num = (short)1408446805;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_BE;
				default:
					num = (short)2138177536;
					if (num != 0)
					{
					}
					if (package == null)
					{
						num = (short)1611333633;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)813498368;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_BC:
			IL_BE:
			num = (short)1528365057;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary();
			IL_102:
			global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary pcrlanguagePackSummary = new global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary
			{
				PackageName = package.PackageName,
				PackageVersion = package.PackageVersion,
				LpID = package.PackageID,
				LanguagePackFamily = package.LanguagePackFamily,
				ReferenceCount = package.ReferenceCount,
				FileSize = ((package.RMFile == null) ? null : package.RMFile.Length)
			};
			global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Extensions.a(package, pcrlanguagePackSummary);
			return pcrlanguagePackSummary;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00008748 File Offset: 0x00006948
		public static global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary ToSummary(this global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement package)
		{
			while (package == null)
			{
				short num = (short)294416426;
				short num2 = num;
				num = (short)666202154;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1422000128;
					if (num != 0)
					{
					}
					num = (short)2022965248;
					short num3 = num;
					num = (short)861011969;
					if (num != 0)
					{
					}
					return new global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary();
				}
				}
			}
			global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary astrovoiceAnnouncementSummary = new global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary
			{
				PackageName = package.PackageName,
				PackageVersion = package.PackageVersion,
				ReferenceCount = package.ReferenceCount
			};
			global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Extensions.a(package, astrovoiceAnnouncementSummary);
			return astrovoiceAnnouncementSummary;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00008830 File Offset: 0x00006A30
		public static global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary ToSummary(this global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates package)
		{
			while (package == null)
			{
				short num = (short)226441475;
				short num2 = num;
				num = (short)782252291;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)386990081;
					if (num != 0)
					{
					}
					num = (short)1592197120;
					short num3 = num;
					num = (short)1733033984;
					if (num != 0)
					{
					}
					return new global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary();
				}
				}
			}
			global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary astrocacertificatesSummary = new global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary
			{
				PackageName = package.PackageName,
				PackageVersion = package.PackageVersion,
				ReferenceCount = package.ReferenceCount
			};
			global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Extensions.a(package, astrocacertificatesSummary);
			return astrocacertificatesSummary;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000891C File Offset: 0x00006B1C
		public static global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary ToSummary(this global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles package)
		{
			while (package == null)
			{
				short num = (short)1581941423;
				short num2 = num;
				num = (short)748782255;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)57737217;
					if (num != 0)
					{
					}
					num = (short)964689920;
					short num3 = num;
					num = (short)975568896;
					if (num != 0)
					{
					}
					return new global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary();
				}
				}
			}
			global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary astrodvrsfilesSummary = new global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary
			{
				PackageName = package.PackageName,
				PackageVersion = package.PackageVersion,
				ReferenceCount = package.ReferenceCount,
				DVRSFileHash = package.DVRSFileHash,
				DVRSTimestamp = package.DVRSTimestamp,
				ConfigDataName = package.ConfigDataName,
				DVRType = package.DVRType
			};
			global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Extensions.a(package, astrodvrsfilesSummary);
			return astrodvrsfilesSummary;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00008A38 File Offset: 0x00006C38
		public static global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncementSummary ToSummary(this global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncement package)
		{
			while (package == null)
			{
				short num = (short)1848936975;
				short num2 = num;
				num = (short)935627279;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)819462145;
					if (num != 0)
					{
					}
					num = (short)596705280;
					short num3 = num;
					num = (short)1580859392;
					if (num != 0)
					{
					}
					return new global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncementSummary();
				}
				}
			}
			global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncementSummary pcrvoiceAnnouncementSummary = new global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncementSummary
			{
				PackageName = package.PackageName,
				ReferenceCount = package.ReferenceCount
			};
			global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Extensions.a(package, pcrvoiceAnnouncementSummary);
			return pcrvoiceAnnouncementSummary;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00008B14 File Offset: 0x00006D14
		public static global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary ToSummary(this global::Motorola.CommonCPS.Server.EntityModel.Configuration item)
		{
			while (item is global::Motorola.CommonCPS.Server.EntityModel.APXConfiguration)
			{
				short num = (short)1863755189;
				short num2 = num;
				num = (short)33334709;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1993342977;
					if (num != 0)
					{
					}
					num = (short)618332160;
					short num3 = num;
					num = (short)1472397312;
					if (num != 0)
					{
					}
					return new global::Motorola.CommonCPS.Server.EntityModel.APXConfigurationViewSummary
					{
						Name = item.Name,
						Uuid = item.Uuid,
						Comment = item.Comment,
						CreatedDate = item.CreatedDate,
						DBNodeUuid = item.DBNodeUuid,
						ModifiedDate = item.ConfigurationExt.ModifiedDate,
						RadioCount = item.RadioCount,
						Timestamp = item.Timestamp,
						VersionStamp = new long?(item.ConfigurationExt.VersionStamp),
						ProductLine = new int?((int)item.ProductFamily),
						OrginalCPVersion = item.OrginalCPVersion,
						Original_RadioSN = item.Original_RadioSN,
						Original_FirmwareVersion = item.Original_FirmwareVersion,
						OriginalFlashCode = ((global::Motorola.CommonCPS.Server.EntityModel.APXConfiguration)item).OriginalFlashCode,
						OriginalModelNumber = ((global::Motorola.CommonCPS.Server.EntityModel.APXConfiguration)item).OriginalModelNumber,
						Original_CFS = ((global::Motorola.CommonCPS.Server.EntityModel.APXConfiguration)item).OriginalModelNumber
					};
				}
				}
			}
			return new global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary
			{
				Name = item.Name,
				Uuid = item.Uuid,
				Comment = item.Comment,
				CreatedDate = item.CreatedDate,
				DBNodeUuid = item.DBNodeUuid,
				ModifiedDate = item.ConfigurationExt.ModifiedDate,
				RadioCount = item.RadioCount,
				Timestamp = item.Timestamp,
				VersionStamp = new long?(item.ConfigurationExt.VersionStamp),
				ProductLine = new int?((int)item.ProductFamily),
				OrginalCPVersion = item.OrginalCPVersion,
				Original_RadioSN = item.Original_RadioSN,
				Original_FirmwareVersion = item.Original_FirmwareVersion
			};
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00008D68 File Offset: 0x00006F68
		public static global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary ToSummary(this global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile dataProfile)
		{
			short num = (short)1324985901;
			short num2 = num;
			num = (short)829468205;
			switch (num2 == num)
			{
			}
			num = (short)1529020416;
			if (num != 0)
			{
			}
			num = (short)1943207936;
			short num3 = num;
			num = (short)1691746305;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary
			{
				CodeplugUuid = dataProfile.CodeplugUuid,
				AirInterfaceIP = dataProfile.AirInterfaceAddress,
				BluetoothDUNPeerIP = dataProfile.AstroBluetoothDunPeerIp,
				BluetoothDUNSubscriberIP = dataProfile.AstroBluetoothDunSubscriberIp,
				AutoGenerateIPs = dataProfile.InheritFlag,
				ProfileName = dataProfile.Name,
				PeerIP = dataProfile.PeerIP,
				SubscriberIP = dataProfile.SubscriberIP,
				SystemType = dataProfile.SystemType,
				PacketDataMode = dataProfile.PacketDataMode,
				NatEnable = dataProfile.NatEnable,
				BluetoothDunPeerIpAssignmentType = dataProfile.BluetoothDunPeerIpAssignmentType,
				ArsMode = dataProfile.ArsMode,
				AutomaticRegistrationServerAddress = dataProfile.AutomaticRegistrationServerAddress,
				Uuid = dataProfile.Uuid,
				Timestamp = dataProfile.Timestamp
			};
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00008EDC File Offset: 0x000070DC
		public static global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary ToSummary(this global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem entity, global::Motorola.CommonCPS.Server.EntityModel.APXRadio radio)
		{
			short num = (short)836042752;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_66;
			}
			global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary apxradioSystemSummary;
			for (;;)
			{
				IL_34:
				int num3;
				switch (num3)
				{
				case 0:
				{
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
					if (apxcodeplug.Template != null)
					{
						num = (short)1380646916;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F1;
				}
				case 1:
				{
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug = radio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug;
					num = (short)1373437962;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
				{
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
					apxradioSystemSummary.RadioAlias = apxcodeplug.RadioAlias;
					num = (short)427622400;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					apxradioSystemSummary.JobStatus = new global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus?(radio.LastJob.JobStatus);
					num = (short)1859190793;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
					apxradioSystemSummary.TemplateName = apxcodeplug.Template.Name;
					num = (short)1175519237;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					goto IL_1F1;
				case 6:
					goto IL_21A;
				case 7:
					if (radio.WorkingCodeplug != null)
					{
						num = (short)1142226945;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return apxradioSystemSummary;
				case 8:
					if (radio.LastJob != null)
					{
						num = (short)231735299;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21F;
				case 9:
					goto IL_21F;
				case 10:
				{
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
					if (apxcodeplug != null)
					{
						num = (short)488046594;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F1;
				}
				}
				break;
				IL_1F1:
				apxradioSystemSummary.RadioStatus = new int?(radio.RadioStatus);
				num = (short)1730412550;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_21F:
				apxradioSystemSummary.SerialNumber = radio.SerialNumber;
				apxradioSystemSummary.RadioUuid = new global::System.Guid?(radio.Uuid);
				num = (short)1725497345;
				if (num != 0)
				{
				}
				num = (short)331415559;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_66:
			apxradioSystemSummary = new global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary
			{
				Uuid = entity.Uuid,
				SystemSubType = entity.SystemSubType,
				SystemId = entity.SystemId,
				SystemType = entity.SystemType,
				SystemName = entity.SystemName,
				RadioId = entity.RadioId,
				Timestamp = entity.Timestamp,
				AskRequired = entity.AskRequired
			};
			num = (short)1331208890;
			short num4 = num;
			num = (short)1694737082;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_21A:
				break;
			default:
			{
				num = (short)1312096256;
				if (num != 0)
				{
				}
				num = (short)445906952;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_34;
			}
			}
			return apxradioSystemSummary;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000091D8 File Offset: 0x000073D8
		public static global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary ToSummary(this global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem rawData, global::Motorola.CommonCPS.Server.EntityModel.MatrixRadio radio)
		{
			short num = (short)1200422912;
			switch (num)
			{
			default:
			{
				num = (short)1720909829;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary pcrradioSystemSummary;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return pcrradioSystemSummary;
					case 1:
					{
						for (;;)
						{
							num = (short)370623131;
							short num3 = num;
							num = (short)108544667;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_266;
							}
						}
						IL_266:
						num = (short)1830813696;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.Server.EntityModel.Configuration configuration;
						pcrradioSystemSummary.ConfigurationUuid = new global::System.Guid?(configuration.Uuid);
						pcrradioSystemSummary.ConfigurationName = configuration.Name;
						num = (short)569049088;
						short num4 = num;
						num = (short)409206784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (radio.WorkingCodeplug != null)
						{
							num = (short)1746665479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return pcrradioSystemSummary;
					case 3:
					{
						global::Motorola.CommonCPS.Server.EntityModel.Configuration configuration;
						if (configuration != null)
						{
							num = (short)327090177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return pcrradioSystemSummary;
					}
					case 4:
					{
						num = (short)1966997505;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug matrixCodeplug;
						pcrradioSystemSummary.RadioAlias = matrixCodeplug.RadioAlias;
						global::Motorola.CommonCPS.Server.EntityModel.Configuration configuration = matrixCodeplug.Configuration;
						num = (short)1123221507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_64;
						}
						continue;
					case 6:
					{
						global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug matrixCodeplug;
						if (matrixCodeplug != null)
						{
							num = (short)1598816260;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return pcrradioSystemSummary;
					}
					case 7:
					{
						global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug matrixCodeplug = radio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug;
						num = (short)2014445574;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_64:
					global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary pcrradioSystemSummary2 = new global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary();
					pcrradioSystemSummary2.Uuid = rawData.Uuid;
					pcrradioSystemSummary2.RepeaterId = rawData.RepeaterId;
					pcrradioSystemSummary2.ControllerId = rawData.ControllerId;
					pcrradioSystemSummary2.RedundancyGroupId = rawData.RedundancyGroupId;
					pcrradioSystemSummary2.ControllerRedundancyGroupId = rawData.ControllerRedundancyGroupId;
					pcrradioSystemSummary2.NetworkId = rawData.NetworkId;
					pcrradioSystemSummary2.DMR3SystemAlias = rawData.DMR3SystemAlias;
					pcrradioSystemSummary2.ConvPersAlias = rawData.DMR3SystemAlias;
					pcrradioSystemSummary2.SiteId = rawData.SiteId;
					pcrradioSystemSummary2.SiteAlias = rawData.SiteAlias;
					pcrradioSystemSummary2.SUId = rawData.SUId;
					pcrradioSystemSummary2.DMR3FNEType = rawData.DMR3FNEType;
					pcrradioSystemSummary2.DMR3AuthenticationKey = rawData.DMR3AuthenticationKey;
					pcrradioSystemSummary2.CodeplugUuid = rawData.CodeplugUuid;
					pcrradioSystemSummary2.Timestamp = rawData.Timestamp;
					pcrradioSystemSummary2.DMR3SystemUUID = rawData.DMR3SystemUUID;
					pcrradioSystemSummary2.SerialNumber = radio.SerialNumber;
					pcrradioSystemSummary2.RadioUuid = new global::System.Guid?(radio.Uuid);
					int? productFamily = radio.ProductFamily;
					pcrradioSystemSummary2.ProductFamily = ((productFamily != null) ? new global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily?((global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily)productFamily.GetValueOrDefault()) : null);
					pcrradioSystemSummary2.GroupUuid = radio.GroupUuid;
					pcrradioSystemSummary = pcrradioSystemSummary2;
					num = (short)2107637762;
					num2 = (int)((global::System.IntPtr)num);
				}
				return pcrradioSystemSummary;
			}
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00009514 File Offset: 0x00007714
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(957306503 + A_1) + (global::System.IntPtr)22 + (global::System.IntPtr)88);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_55;
			}
			IL_22:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_55:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_22;
		}
	}
}
