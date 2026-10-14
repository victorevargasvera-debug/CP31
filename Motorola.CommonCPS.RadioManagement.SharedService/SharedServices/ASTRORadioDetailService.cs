using System;
using System.Collections.Generic;
using System.Linq;
using CommonUtility;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200006D RID: 109
	internal class ASTRORadioDetailService : global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioDetailService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioDetailService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioDetailService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x0600076E RID: 1902 RVA: 0x00055210 File Offset: 0x00053410
		public ASTRORadioDetailService(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor, global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROValidationService astroValidateService) : base(serverAccessor, astroValidateService)
		{
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00055228 File Offset: 0x00053428
		public override void PacSpecial_Validate_AllowRestore(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.Common.Communication.Pba.PbaObject historical_PbaObject, global::Motorola.Common.Communication.CommonUtil.DeviceInfo historical_DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject current_PbaObject)
		{
			short num = (short)1623588864;
			short num2 = num;
			num = (short)853448709;
			short num3 = num;
			num = (short)1304205317;
			switch (num3 == num)
			{
			}
			num = (short)1604780032;
			if (num != 0)
			{
			}
			num = (short)1197539329;
			if (num != 0)
			{
			}
			this.a(radio, historical_PbaObject, historical_DeviceInfo, current_PbaObject);
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x000552DC File Offset: 0x000534DC
		public override bool ValidateRestore_PreSchedule(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob> selectedItems, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase device, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails radioDetail, out string error)
		{
			short num = (short)2042232832;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 1:
					goto IL_68;
				case 2:
				{
					num = (short)1296498689;
					if (num != 0)
					{
					}
					num = (short)196792258;
					short num3 = num;
					num = (short)257871810;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_68;
					default:
						goto IL_10B;
					}
					break;
				}
				case 3:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob historicalJob = selectedItems[0];
					byte[] radioFlashCode = radioDetail.RadioFlashCode;
					if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsEquals(historicalJob.JobFlashCode, radioFlashCode))
					{
						num = (short)181338114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				}
				IL_35:
				if (base.ValidateRestore_PreSchedule(selectedItems, device, radioDetail, out error))
				{
					num = (short)1553661953;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_125;
				IL_68:
				num = (short)907411459;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_10B:
			num = (short)1781923840;
			if (num != 0)
			{
			}
			error = global::Motorola.CommonCPS.ResourceRepository.Resources.Astro_Restore_FlashCode_invalid;
			return false;
			IL_125:
			num = (short)260112384;
			short num4 = num;
			return false;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0005543C File Offset: 0x0005363C
		protected override void FixIncorrectData_LPPackage(global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug, global::Motorola.CommonCPS.Server.EntityModel.Configuration configuration, ref global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField> validateEntityList)
		{
			short num = (short)443875328;
			short num2 = num;
			num = (short)1173969643;
			short num3 = num;
			num = (short)1821661931;
			switch (num3 == num)
			{
			}
			num = (short)2083782657;
			if (num != 0)
			{
			}
			num = (short)778960896;
			if (num != 0)
			{
			}
			base.FixIncorrectData_LPPackage(codeplug, configuration, ref validateEntityList);
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc> list = global::Motorola.CommonCPS.Common.CommonUtility.ObjectSeralizeUtility.JsonToObject<global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc>>((codeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).LanguageSetting);
			global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack latestASTROLPPackagesByFirmwareVersion = base.ServerAccessor.GetLatestASTROLPPackagesByFirmwareVersion(codeplug.FirmwareVersion, list[0].LanguageID);
			(codeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).ASTROLanguagePack = latestASTROLPPackagesByFirmwareVersion;
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntityList, latestASTROLPPackagesByFirmwareVersion);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00055534 File Offset: 0x00053734
		private void a(global::Motorola.CommonCPS.Server.EntityModel.Radio A_0, global::Motorola.Common.Communication.Pba.PbaObject A_1, global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_2, global::Motorola.Common.Communication.Pba.PbaObject A_3)
		{
			short num = (short)716177408;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A3;
				}
				string firmwareVersion;
				string softwareVersion;
				bool flag;
				global::Motorola.Common.CustomException.CommonErrorCode errorID;
				string cpversion;
				string cpversion2;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (!global::CommonUtility.VersionUtility.NoSignificantChange(firmwareVersion, softwareVersion))
						{
							num = (short)745537554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_241;
					case 1:
						goto IL_241;
					case 2:
						num = (short)622067712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_241;
					case 4:
						if (global::CommonUtility.VersionUtility.NoSignificantChange(firmwareVersion, softwareVersion))
						{
							goto IL_42C;
						}
						goto IL_44B;
					case 5:
						goto IL_241;
					case 6:
						flag = false;
						errorID = global::Motorola.Common.CustomException.CommonErrorCode.RMC_Restore_ASTRO_CPMajorShallNoLessThanFWMajor;
						num = (short)1280901123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (this.a(A_1, A_3))
						{
							num = (short)1142685708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_241;
					case 8:
						if (!flag)
						{
							num = (short)434962454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						num = (short)725483547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (!global::CommonUtility.VersionUtility.NoSignificantChange(cpversion, cpversion2))
						{
							num = (short)1708064783;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C6;
					case 11:
						if (this.a(A_1, A_3))
						{
							num = (short)2054291482;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_241;
					case 12:
						flag = true;
						num = (short)801701905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						num = (short)1366949888;
						short num3 = num;
						flag = true;
						num = (short)367394835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						if (global::CommonUtility.VersionUtility.NoSignificantChange(cpversion, cpversion2))
						{
							num = (short)989265929;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_160;
					case 15:
						num = (short)1724383255;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (global::CommonUtility.VersionUtility.NoSignificantChange(cpversion, cpversion2))
						{
							num = (short)1140850709;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_44B;
					case 17:
						goto IL_241;
					case 18:
						num = (short)867368980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)558825473;
						if (num != 0)
						{
						}
						goto IL_241;
					case 20:
						if (!global::CommonUtility.VersionUtility.CpNoLessThanFW_Major(cpversion2, firmwareVersion))
						{
							num = (short)1081344006;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1074331659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)599588868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						num = (short)1270006693;
						short num4 = num;
						num = (short)145802149;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_42C;
						default:
							goto IL_2AF;
						}
						break;
					}
					case 23:
						if (global::CommonUtility.VersionUtility.NoSignificantChange(firmwareVersion, softwareVersion))
						{
							num = (short)598605837;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C6;
					case 24:
						if (!global::CommonUtility.VersionUtility.NoSignificantChange(cpversion, cpversion2))
						{
							num = (short)650379266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_241;
					case 25:
						num = (short)1923219463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						flag = true;
						num = (short)1577320449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (!global::CommonUtility.VersionUtility.NoSignificantChange(firmwareVersion, softwareVersion))
						{
							num = (short)2026307609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_160;
					case 28:
						flag = true;
						num = (short)212533253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A3;
					IL_160:
					num = (short)181207064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_241:
					num = (short)235143176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C6:
					num = (short)595001358;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_42C:
					num = (short)1021902876;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_44B:
					num = (short)264765450;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2AF:
				num = (short)293994496;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(errorID);
				IL_A3:
				flag = false;
				errorID = global::Motorola.Common.CustomException.CommonErrorCode.RMC_Restore_ASTRO_SecurityPartitionShallNotModified;
				firmwareVersion = A_0.CurrentCodeplug.FirmwareVersion;
				cpversion = A_3.CodeplugData.CPVersion;
				softwareVersion = A_2.SoftwareVersion;
				cpversion2 = A_1.CodeplugData.CPVersion;
				num = (short)515047440;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00055A78 File Offset: 0x00053C78
		private bool a(global::Motorola.Common.Communication.Pba.PbaObject A_0, global::Motorola.Common.Communication.Pba.PbaObject A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
			global::Motorola.Common.Communication.Pba.DataBlock dataBlock2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_15F;
				case 1:
				{
					num2 = (short)1503167288;
					short num3 = num2;
					num2 = (short)1542226744;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15F;
					default:
						num2 = (short)288292865;
						if (num2 != 0)
						{
						}
						num2 = (short)52035584;
						if (num2 != 0)
						{
						}
						if (dataBlock.LegthInBits == dataBlock2.LegthInBits)
						{
							num2 = (short)481492992;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					}
					break;
				}
				case 2:
					return false;
				case 3:
				{
					global::System.Collections.Generic.IEnumerable<byte> first = this.a(dataBlock2);
					byte[] second = this.a(dataBlock);
					if (!first.SequenceEqual(second))
					{
						num2 = (short)9830402;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 4:
					goto IL_1A4;
				case 5:
				{
					if (dataBlock.PacketValue.Length != dataBlock2.PacketValue.Length)
					{
						num2 = (short)2080571396;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)454230016;
					short num4 = num2;
					num2 = (short)876412931;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_28;
				IL_15F:
				num2 = (short)1897463813;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_1A4:
			return false;
			IL_28:
			A_0.GetCodeplugInIshItemCollection();
			dataBlock2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTRORadioDetailService.a(A_0);
			dataBlock = global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTRORadioDetailService.a(A_1);
			num2 = (short)634060801;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00055C30 File Offset: 0x00053E30
		private byte[] a(global::Motorola.Common.Communication.Pba.DataBlock A_0)
		{
			short num = (short)1987248128;
			short num2 = num;
			num = (short)1148849126;
			short num3 = num;
			num = (short)292228070;
			switch (num3 == num)
			{
			}
			num = (short)1993736193;
			if (num != 0)
			{
			}
			num = (short)448462848;
			if (num != 0)
			{
			}
			int num4 = 1;
			int num5 = 2;
			byte[] array = new byte[A_0.LegthInBits / 8 - num4 - num5];
			global::System.Array.Copy(A_0.PacketValue, num4, array, 0, array.Length);
			byte b = 1;
			array[0] = (array[0] | b);
			return array;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00055D0C File Offset: 0x00053F0C
		private static global::Motorola.Common.Communication.Pba.DataBlock a(global::Motorola.Common.Communication.Pba.PbaObject A_0)
		{
			short num = (short)1232772948;
			short num2 = num;
			num = (short)2136383316;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_BA;
			case 1:
				break;
			default:
			{
				num = (short)1710489600;
				short num3 = num;
				break;
			}
			}
			num = (short)1848901632;
			if (num != 0)
			{
			}
			num = (short)636747777;
			if (num != 0)
			{
			}
			num = (short)466747392;
			switch (num)
			{
			default:
			{
				IL_BA:
				global::Motorola.Common.Communication.Pba.DataBlock result = null;
				using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>.Enumerator enumerator = A_0.CodeplugData.DataPartitions.GetEnumerator())
				{
					num = (short)410255360;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_109;
							}
							continue;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1777139716;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator2 = enumerator.Current.DataBlocks.GetEnumerator();
							num = (short)1912733698;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							try
							{
								num = (short)29425666;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num4)
									{
									case 0:
									{
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1488257025;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.Pba.DataBlock dataBlock = enumerator2.Current;
										num = (short)590675971;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										num = (short)150863877;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_1B0;
										}
										continue;
									case 3:
									{
										global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
										if (dataBlock.BlockType == 903)
										{
											num = (short)1380712454;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
										goto IL_263;
									case 6:
									{
										global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
										result = dataBlock;
										num = (short)903413764;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_1B2:
									num = (short)1377763328;
									num4 = (int)((global::System.IntPtr)num);
									continue;
									IL_1B0:
									goto IL_1B2;
								}
								IL_263:
								break;
							}
							finally
							{
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator2;
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_276;
						case 3:
							goto IL_28E;
						case 4:
							goto IL_276;
						}
						IL_135:
						num = (short)1373503489;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_109:
						goto IL_135;
						IL_276:
						num = (short)439615491;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_28E:;
				}
				return result;
			}
			}
		}
	}
}
