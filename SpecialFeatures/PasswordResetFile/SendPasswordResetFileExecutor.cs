using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using CommonResources;
using Motorola.Common.Communication.CommonUtil;
using SpecialFeatures.Comms;
using SpecialFeatures.Flashport.FlashRadio;
using SpecialFeatures.ReadWritePassword;

namespace SpecialFeatures.PasswordResetFile
{
	// Token: 0x020000AA RID: 170
	internal class SendPasswordResetFileExecutor
	{
		// Token: 0x06000B8B RID: 2955 RVA: 0x00002DB7 File Offset: 0x00000FB7
		public SendPasswordResetFileExecutor(global::System.ComponentModel.BackgroundWorker backgroundWorker, global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp readWritePasswordApp)
		{
			this.a = backgroundWorker;
			this.b = readWritePasswordApp;
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x000DEDB0 File Offset: 0x000DCFB0
		public void SendPasswordResetFile(string passwordResetFilePath)
		{
			short num = (short)1908146176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1311571968;
				short num3 = num;
				int num4 = 0;
				try
				{
					this.a(num4, global::SpecialFeatures.PasswordResetFile.UserState.ConnectStart, global::SpecialFeatures.PasswordResetFile.UserState.None, global::CommonResources.AppResources.Find_valid_device);
					global::SpecialFeatures.Comms.IDeviceProxy deviceProxy = global::SpecialFeatures.PasswordResetFile.SendPasswordResetFileExecutor.a();
					try
					{
						switch (0)
						{
						case 0:
							goto IL_7F;
						}
						byte[] a_;
						for (;;)
						{
							IL_6C:
							switch (num2)
							{
							case 0:
								goto IL_173;
							case 1:
							{
								if (global::SpecialFeatures.PasswordResetFile.SendPasswordResetFileExecutor.a(deviceProxy, a_))
								{
									this.b.ClearCachedPasswordValidation();
									this.a(num4 += 25, global::SpecialFeatures.PasswordResetFile.UserState.ResetPasswordDone, global::SpecialFeatures.PasswordResetFile.UserState.None, global::CommonResources.AppResources.Password_has_been_updated_successfully);
									num = (short)1183055874;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)47839486;
								short num5 = num;
								num = (short)1684928766;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									num = (short)1423572992;
									if (num != 0)
									{
									}
									num = (short)459669504;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								goto IL_1B8;
							}
							goto IL_7F;
						}
						IL_173:
						throw new global::SpecialFeatures.PasswordResetFile.PasswordResetException(global::CommonResources.AppResources.Cannot_Reset_Radio_Password);
						IL_1B8:
						goto IL_225;
						IL_7F:
						this.a(num4 += 25, global::SpecialFeatures.PasswordResetFile.UserState.ConnectDone, global::SpecialFeatures.PasswordResetFile.UserState.ReadRadInfoStart, global::CommonResources.AppResources.Reading_and_validating_radio_parameters);
						global::SpecialFeatures.Comms.RadioParams radioParams = global::SpecialFeatures.PasswordResetFile.SendPasswordResetFileExecutor.a(deviceProxy);
						global::SpecialFeatures.Flashport.FlashRadio.RadioInfoParams a_2 = new global::SpecialFeatures.Flashport.FlashRadio.RadioInfoParams(radioParams.ModelNumber, global::SpecialFeatures.Flashport.FlashRadio.SerialNumberValidator.convertSerialNumberToAscii(radioParams.SerialNumber), null);
						this.a(num4, a_2);
						global::SpecialFeatures.PasswordResetFile.SendPasswordResetFileExecutor.a(radioParams);
						this.a(num4 += 25, global::SpecialFeatures.PasswordResetFile.UserState.ReadRadInfoDone, global::SpecialFeatures.PasswordResetFile.UserState.ResetFileValidationStart, global::CommonResources.AppResources.Reading_and_validating_radio_parameters);
						a_ = global::SpecialFeatures.PasswordResetFile.SendPasswordResetFileExecutor.a(passwordResetFilePath, radioParams);
						this.a(num4 += 25, global::SpecialFeatures.PasswordResetFile.UserState.ResetFileValidationDone, global::SpecialFeatures.PasswordResetFile.UserState.ResetPasswordStart, global::CommonResources.AppResources.Uploading_file_to_radio);
						num = (short)1930100737;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_6C;
					}
					finally
					{
						num = (short)1628241921;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								deviceProxy.Dispose();
								num = (short)579731458;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1EC;
								}
								continue;
							case 2:
								goto IL_222;
							}
							IL_1EC:
							if (deviceProxy == null)
							{
								break;
							}
							num = (short)325910528;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_222:;
					}
					IL_225:
					num = (short)1355677697;
					if (num != 0)
					{
					}
				}
				catch (global::SpecialFeatures.PasswordResetFile.PasswordResetException ex)
				{
					if (!string.IsNullOrWhiteSpace(ex.Message))
					{
						global::System.Diagnostics.Trace.TraceInformation(ex.Message);
					}
					throw;
				}
				catch (global::System.Exception ex2)
				{
					if (string.IsNullOrWhiteSpace(ex2.Message))
					{
						throw new global::SpecialFeatures.PasswordResetFile.PasswordResetException(global::CommonResources.AppResources.Password_Reset_Unexpected_Error);
					}
					global::System.Diagnostics.Trace.TraceError(ex2.Message);
					throw new global::SpecialFeatures.PasswordResetFile.PasswordResetException(global::CommonResources.AppResources.Password_Reset_Unexpected_Error, ex2.Message);
				}
				return;
			}
			}
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x000DF0B4 File Offset: 0x000DD2B4
		private void a(int A_0, global::SpecialFeatures.PasswordResetFile.UserState A_1, global::SpecialFeatures.PasswordResetFile.UserState A_2, string A_3)
		{
			short num = (short)1760568943;
			short num2 = num;
			num = (short)1622353519;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1495728128;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1047920641;
			if (num != 0)
			{
			}
			num = (short)1720451072;
			if (num != 0)
			{
			}
			global::SpecialFeatures.PasswordResetFile.ProgressUserState userState = new global::SpecialFeatures.PasswordResetFile.ProgressUserState(A_1, A_2, A_3);
			this.a.ReportProgress(A_0, userState);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x000DF174 File Offset: 0x000DD374
		private void a(int A_0, global::SpecialFeatures.Flashport.FlashRadio.RadioInfoParams A_1)
		{
			short num = (short)2090061918;
			short num2 = num;
			num = (short)1224462430;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1312686080;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1037565953;
			if (num != 0)
			{
			}
			num = (short)867434496;
			if (num != 0)
			{
			}
			this.a.ReportProgress(A_0, A_1);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x000DF22C File Offset: 0x000DD42C
		private static global::SpecialFeatures.Comms.IDeviceProxy a()
		{
			short num = (short)353554024;
			short num2 = num;
			num = (short)591711848;
			global::SpecialFeatures.Comms.IDeviceProxy result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1619853312;
				short num3 = num;
				num = (short)1128333312;
				if (num != 0)
				{
				}
				num = (short)1553268737;
				if (num != 0)
				{
				}
				global::SpecialFeatures.Comms.RadioParams radioPara = new global::SpecialFeatures.Comms.RadioParams
				{
					Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio,
					ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo
					{
						ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter
					}
				};
				try
				{
					result = global::SpecialFeatures.Comms.DeviceManagerSingleTon.Instance.CreateDeviceProxy(radioPara, global::Motorola.Common.Communication.CommonUtil.RadioOperation.PasswordReset);
				}
				catch (global::System.Exception)
				{
					throw new global::SpecialFeatures.PasswordResetFile.PasswordResetException(global::CommonResources.AppResources.Connect_Failed);
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x000DF328 File Offset: 0x000DD528
		private static global::SpecialFeatures.Comms.RadioParams a(global::SpecialFeatures.Comms.IDeviceProxy A_0)
		{
			try
			{
				global::SpecialFeatures.Comms.RadioParams radioParams = A_0.ReadExtendedDeviceInfo();
				goto IL_20;
			}
			catch (global::System.Exception)
			{
				throw new global::SpecialFeatures.PasswordResetFile.PasswordResetException(global::CommonResources.AppResources.Unable_to_read_radio_codeplug_parameters);
			}
			IL_15:
			throw new global::SpecialFeatures.PasswordResetFile.PasswordResetException(global::CommonResources.AppResources.Unable_to_read_radio_codeplug_parameters);
			IL_20:
			short num = (short)844550064;
			short num2 = num;
			num = (short)584830896;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1111818240;
				if (num != 0)
				{
				}
				num = (short)178520064;
				short num3 = num;
				global::SpecialFeatures.Comms.RadioParams radioParams;
				if (radioParams != null)
				{
					return radioParams;
				}
				break;
			}
			}
			num = (short)1895628801;
			if (num != 0)
			{
			}
			goto IL_15;
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x000DF40C File Offset: 0x000DD60C
		private static void a(global::SpecialFeatures.Comms.RadioParams A_0)
		{
			short num = (short)1623326720;
			short num2 = num;
			num = (short)2097479681;
			if (num != 0)
			{
			}
			num = (short)152534398;
			short num3 = num;
			num = (short)250772862;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)526057472;
				if (num != 0)
				{
				}
				num = (short)1078067202;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					goto IL_F3;
				case 1:
					if (!A_0.ConnectionInfo.IsTlsPskCompatible)
					{
						num = (short)298450947;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_D2;
					}
					continue;
				case 3:
					goto IL_135;
				}
				IL_D2:
				if (!global::SpecialFeatures.PasswordResetFile.SendPasswordResetFileExecutor.a(A_0.ModelNumber))
				{
					num = (short)1744764928;
					num4 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1969094657;
					num4 = (int)((global::System.IntPtr)num);
				}
			}
			IL_F3:
			throw new global::SpecialFeatures.PasswordResetFile.PasswordResetException(global::CommonResources.AppResources.Password_Reset_Via_File_Not_Supported_Model);
			IL_135:
			throw new global::SpecialFeatures.PasswordResetFile.PasswordResetException(global::CommonResources.AppResources.Password_Reset_Via_File_Not_Supported_Firmware);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x000DF55C File Offset: 0x000DD75C
		private static bool a(string A_0)
		{
			short num = (short)870042745;
			short num2 = num;
			num = (short)371182713;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1635450880;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)369754113;
			if (num != 0)
			{
			}
			num = (short)156499968;
			if (num != 0)
			{
			}
			return !global::Motorola.Common.Communication.CommonUtil.ModelNumber.IsAmp(A_0);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x000DF60C File Offset: 0x000DD80C
		private static byte[] a(string A_0, global::SpecialFeatures.Comms.RadioParams A_1)
		{
			short num = (short)1195131350;
			short num2 = num;
			num = (short)554254806;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1227161600;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)442105857;
			if (num != 0)
			{
			}
			num = (short)1454047232;
			if (num != 0)
			{
			}
			byte[] array = global::System.IO.File.ReadAllBytes(A_0);
			global::Motorola.Common.Communication.CommonUtil.ResetPasswordFileManager.ResetPasswordFileValidationStatus resetPasswordFileValidationStatus = global::Motorola.Common.Communication.CommonUtil.ResetPasswordFileManager.CheckFileContentsValid(array, global::SpecialFeatures.Flashport.FlashRadio.SerialNumberValidator.convertSerialNumberToAscii(A_1.SerialNumber));
			if (resetPasswordFileValidationStatus == global::Motorola.Common.Communication.CommonUtil.ResetPasswordFileManager.ResetPasswordFileValidationStatus.InvalidFile)
			{
				throw new global::SpecialFeatures.PasswordResetFile.PasswordResetException(global::CommonResources.AppResources.Password_Reset_File_Not_Valid);
			}
			if (resetPasswordFileValidationStatus == global::Motorola.Common.Communication.CommonUtil.ResetPasswordFileManager.ResetPasswordFileValidationStatus.InvalidSerialNumber)
			{
				throw new global::SpecialFeatures.PasswordResetFile.PasswordResetException(global::CommonResources.AppResources.Password_Reset_File_Serial_Number_Not_Matching);
			}
			return array;
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x000DF6F0 File Offset: 0x000DD8F0
		private static bool a(global::SpecialFeatures.Comms.IDeviceProxy A_0, byte[] A_1)
		{
			short num;
			bool result;
			try
			{
				num = (short)1623579283;
				short num2 = num;
				num = (short)1109383827;
				switch (num2 == num)
				{
				}
				num = (short)1231224832;
				if (num != 0)
				{
				}
				result = A_0.ResetPassword(A_1);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::SpecialFeatures.PasswordResetFile.PasswordResetException(global::CommonResources.AppResources.Sending_Reset_Radio_Password_Error, innerException);
			}
			num = (short)739115008;
			short num3 = num;
			num = (short)592969729;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x04000517 RID: 1303
		private readonly global::System.ComponentModel.BackgroundWorker a;

		// Token: 0x04000518 RID: 1304
		private readonly global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp b;
	}
}
