using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.ResourceRepository;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Comms
{
	// Token: 0x02000173 RID: 371
	public static class Extension
	{
		// Token: 0x0600127E RID: 4734 RVA: 0x00197690 File Offset: 0x00195890
		internal static global::Motorola.Common.Communication.CommonUtil.DeviceInfo Clone(this global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)1112324738;
			short num2 = num;
			num = (short)348633730;
			switch (num2 == num)
			{
			}
			num = (short)1991639040;
			short num3 = num;
			num = (short)1605697537;
			if (num != 0)
			{
			}
			num = (short)1669529600;
			if (num != 0)
			{
			}
			return new global::Motorola.Common.Communication.CommonUtil.DeviceInfo
			{
				CodeplugVersion = deviceInfo.CodeplugVersion,
				ConnectionInfo = deviceInfo.ConnectionInfo,
				Family = deviceInfo.Family,
				ModelNumber = deviceInfo.ModelNumber,
				RadioID = deviceInfo.RadioID,
				RadioState = deviceInfo.RadioState,
				SerialNumber = deviceInfo.SerialNumber,
				SoftwareVersion = deviceInfo.SoftwareVersion
			};
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x001977A0 File Offset: 0x001959A0
		internal static global::SpecialFeatures.Comms.RadioParams WrapperRadioParams(this global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo astroDeviceInfo)
		{
			short num;
			global::SpecialFeatures.Comms.RadioParams result;
			try
			{
				num = (short)1777926144;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					global::SpecialFeatures.Comms.RadioParams radioParams;
					for (;;)
					{
						IL_27:
						global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo;
						switch (num2)
						{
						case 0:
							if (astroDeviceInfo.UUID != null)
							{
								num = (short)1837891588;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_256;
						case 1:
							connectionInfo.UniqueAddress = astroDeviceInfo.ConnectionInfo.UniqueAddress;
							connectionInfo.ConnectionType = astroDeviceInfo.ConnectionInfo.ConnectionType;
							connectionInfo.Location = astroDeviceInfo.ConnectionInfo.Location;
							connectionInfo.SessionID = astroDeviceInfo.ConnectionInfo.SessionID;
							connectionInfo.IsTlsPskCompatible = astroDeviceInfo.ConnectionInfo.IsTlsPskCompatible;
							num = (short)1464139781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (astroDeviceInfo.ConnectionInfo != null)
							{
								num = (short)295174145;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2C4;
						case 3:
							goto IL_256;
						case 4:
						{
							num = (short)1445564633;
							short num3 = num;
							num = (short)219320537;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1929773056;
								if (num != 0)
								{
								}
								radioParams.Uuid = new global::System.Guid(astroDeviceInfo.UUID);
								num = (short)872742915;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							goto IL_2C4;
						case 6:
							goto IL_316;
						}
						goto IL_4A;
						IL_256:
						connectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo();
						num = (short)378929154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2C4:
						radioParams.ConnectionInfo = connectionInfo;
						radioParams.Family = astroDeviceInfo.Family;
						radioParams.RadioID = astroDeviceInfo.RadioID;
						radioParams.RadioState = astroDeviceInfo.RadioState;
						radioParams.RadioStorage = astroDeviceInfo.RadioStorage;
						result = radioParams;
						num = (short)2003304454;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_316:
					break;
					IL_4A:
					radioParams = new global::SpecialFeatures.Comms.RadioParams();
					radioParams.BootAppVersion = astroDeviceInfo.BootloaderVersion;
					radioParams.CodeplugVersion = astroDeviceInfo.CodeplugVersion;
					radioParams.DspVersion = astroDeviceInfo.DspVersion;
					radioParams.RadioBBFSuiteVersion = global::SpecialFeatures.Comms.Extension.GetRadioBBFSuiteVersion(astroDeviceInfo);
					radioParams.HostVersion = astroDeviceInfo.SoftwareVersion;
					radioParams.MaceFlashVersion = astroDeviceInfo.MaceFlashVersion;
					radioParams.ModelNumber = astroDeviceInfo.ModelNumber;
					radioParams.OptBoardName = astroDeviceInfo.OptionBoardName;
					radioParams.OptBrdFlashImageType = astroDeviceInfo.OptionBoardFlashImageType;
					radioParams.OptBrdFlashImageVersion = astroDeviceInfo.OptionBoardFlashImageVersion;
					radioParams.OptBrdHardwareType = astroDeviceInfo.OptionBoardHardwareType;
					radioParams.OptBrdHwHostVersion = astroDeviceInfo.OptionBoardHardwareHostVersion;
					radioParams.LTEOptBrdHwHostVersion = astroDeviceInfo.LTEOptionBoardHardwareHostVersion;
					radioParams.OptBrdHwNotPresentFlag = astroDeviceInfo.OptionBoardHardwareNotPresentFlag;
					radioParams.PsdtVersion = astroDeviceInfo.PsdtVersion;
					radioParams.ConBrdHardwareType = astroDeviceInfo.ConsoletteBoardHardwareType;
					radioParams.ConBrdHwHostVersion = astroDeviceInfo.ConsoletteBoardHardwareHostVersion;
					radioParams.SerialNumber = astroDeviceInfo.SerialNumber;
					radioParams.ESerialNumber = astroDeviceInfo.ESN;
					radioParams.MaceHardwareType = astroDeviceInfo.MaceSecureHardwareType;
					radioParams.MaceHardwareVersion = astroDeviceInfo.MaceSecureHardwareVersion;
					radioParams.TuneVersion = astroDeviceInfo.TuneVersion;
					num = (short)771751936;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				throw global::SpecialFeatures.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, global::Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
			}
			num = (short)2014576640;
			short num4 = num;
			num = (short)575471617;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00197B40 File Offset: 0x00195D40
		internal static string GetRadioBBFSuiteVersion(global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo deviceInfo)
		{
			short num = (short)306380801;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo ampDeviceInfo;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_F7;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
				{
					num = (short)1167988608;
					short num3 = num;
					num = (short)1807947648;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F7;
					default:
						num = (short)108527616;
						if (num != 0)
						{
						}
						ampDeviceInfo = (deviceInfo as global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo);
						num = (short)257228800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_13F;
				}
				IL_34:
				if (deviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.AMPRadio)
				{
					num = (short)307822593;
					if (num != 0)
					{
					}
					num = (short)349765634;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_144;
				IL_F7:
				if (ampDeviceInfo.RadioBBFSuiteVersion != null)
				{
					break;
				}
				num = (short)1610743808;
				short num4 = num;
				num = (short)32178179;
				num2 = (int)((global::System.IntPtr)num);
			}
			return ampDeviceInfo.RadioBBFSuiteVersion;
			IL_13F:
			return ampDeviceInfo.BpFirmwareVersion;
			IL_144:
			return deviceInfo.RadioBBFSuiteVersion;
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00197C98 File Offset: 0x00195E98
		internal static string GetSHA256Hash(this byte[] data)
		{
			int a_ = 0;
			short num = (short)1339889338;
			short num2 = num;
			num = (short)1670190778;
			string result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1424162817;
				if (num != 0)
				{
				}
				num = (short)1848442880;
				short num3 = num;
				num = (short)1595342848;
				if (num != 0)
				{
				}
				global::System.Security.Cryptography.SHA256 sha = new global::System.Security.Cryptography.SHA256CryptoServiceProvider();
				try
				{
					result = global::System.BitConverter.ToString(sha.ComputeHash(data)).Replace(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꺂", a_), "");
				}
				finally
				{
					num = (short)761331713;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							((global::System.IDisposable)sha).Dispose();
							num = (short)245825538;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_104;
							}
							continue;
						case 2:
							goto IL_139;
						}
						IL_104:
						if (sha == null)
						{
							break;
						}
						num = (short)1465057280;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_139:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x00197DF4 File Offset: 0x00195FF4
		internal static global::Motorola.Common.Communication.CommonUtil.DeviceInfo WrapperDeviceInfo(this global::SpecialFeatures.Comms.RadioParams radioPara)
		{
			short num;
			global::Motorola.Common.Communication.CommonUtil.DeviceInfo result;
			try
			{
				num = (short)767063142;
				short num2 = num;
				num = (short)1113683046;
				switch (num2 == num)
				{
				}
				num = (short)1956839424;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = new global::Motorola.Common.Communication.CommonUtil.DeviceInfo();
				global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo();
				connectionInfo.UniqueAddress = radioPara.ConnectionInfo.UniqueAddress;
				connectionInfo.ConnectionType = radioPara.ConnectionInfo.ConnectionType;
				connectionInfo.Location = radioPara.ConnectionInfo.Location;
				connectionInfo.InactivityTimeout = radioPara.ConnectionInfo.InactivityTimeout;
				deviceInfo.Family = radioPara.Family;
				deviceInfo.ConnectionInfo = connectionInfo;
				deviceInfo.CodeplugVersion = radioPara.CodeplugVersion;
				deviceInfo.ModelNumber = radioPara.ModelNumber;
				deviceInfo.RadioID = radioPara.RadioID;
				deviceInfo.RadioState = radioPara.RadioState;
				deviceInfo.RadioStorage = radioPara.RadioStorage;
				deviceInfo.ConnectionInfo.SessionID = radioPara.ConnectionInfo.SessionID;
				deviceInfo.SerialNumber = radioPara.SerialNumber;
				deviceInfo.SoftwareVersion = radioPara.HostVersion;
				result = deviceInfo;
			}
			catch (global::System.Exception ex)
			{
				throw global::SpecialFeatures.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, global::Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
			}
			num = (short)2126577664;
			short num3 = num;
			num = (short)1694040065;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00197F98 File Offset: 0x00196198
		internal static bool Serialize(this global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo astrodeviceInfo, string fileName)
		{
			short num;
			try
			{
				num = (short)675178195;
				short num2 = num;
				num = (short)1886217939;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1942683648;
					if (num != 0)
					{
					}
					global::System.IO.FileStream fileStream = global::System.IO.File.Create(fileName);
					try
					{
						new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Serialize(fileStream, astrodeviceInfo);
					}
					finally
					{
						num = (short)1588592641;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								((global::System.IDisposable)fileStream).Dispose();
								num = (short)509870082;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_91;
								}
								continue;
							case 2:
								goto IL_C5;
							}
							IL_91:
							if (fileStream == null)
							{
								break;
							}
							num = (short)576192512;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_C5:;
					}
					break;
				}
				}
			}
			catch (global::System.Exception)
			{
				return false;
			}
			num = (short)662044673;
			if (num != 0)
			{
			}
			num = (short)146079744;
			short num4 = num;
			return true;
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x001980E8 File Offset: 0x001962E8
		internal static global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo Deserialize(this global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo astrodeviceInfo, string fileName)
		{
			short num = (short)986382336;
			short num2 = num;
			global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo result = null;
			global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo result2;
			try
			{
				num = (short)438435324;
				short num3 = num;
				num = (short)1524104700;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1843331072;
					if (num != 0)
					{
					}
					global::System.IO.FileStream fileStream = global::System.IO.File.OpenRead(fileName);
					try
					{
						result = (new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Deserialize(fileStream) as global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo);
					}
					finally
					{
						num = (short)134873089;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								((global::System.IDisposable)fileStream).Dispose();
								num = (short)2052390914;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_EF;
								}
								continue;
							case 2:
								goto IL_124;
							}
							IL_EF:
							if (fileStream == null)
							{
								break;
							}
							num = (short)1153695744;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_124:;
					}
					break;
				}
				}
				goto IL_2E;
			}
			catch (global::System.Exception)
			{
				result2 = null;
			}
			return result2;
			IL_2E:
			num = (short)13959169;
			if (num != 0)
			{
			}
			return result;
		}
	}
}
