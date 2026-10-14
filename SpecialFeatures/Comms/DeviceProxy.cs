using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using AcpCommonLib;
using CommonResources;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Service;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.ResourceRepository;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.RadioLanguagePack;

namespace SpecialFeatures.Comms
{
	// Token: 0x02000161 RID: 353
	public class DeviceProxy : global::SpecialFeatures.Comms.IDeviceProxy, global::System.IDisposable
	{
		// Token: 0x060011D0 RID: 4560 RVA: 0x00185190 File Offset: 0x00183390
		public DeviceProxy(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation radioOp, string psk = null)
		{
			int a_ = 10;
			this.g = true;
			this.h = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꊌ\udb8e쎐튒\udb94쒖\udf98\ude9a쾜낞", a_);
			base..ctor();
			this.f = radioOp;
			this.d = deviceInfo;
			try
			{
				this.a = new global::SpecialFeatures.Comms.DeviceServiceHandler();
				this.a.ProgressEventHandler += this.a;
				this.b = global::SpecialFeatures.Comms.DeviceServiceManagerProvider.Instance.GetDeviceOperationService(this.a);
				global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter = string.IsNullOrEmpty(psk) ? null : new global::Motorola.Common.Communication.CommonUtil.SessionParameter(0, false, psk);
				ushort sessionID = this.b.OpenSession(this.d, this.f, sessionParameter, false);
				this.d.ConnectionInfo.SessionID = sessionID;
				global::SpecialFeatures.Comms.DeviceManagerSingleTon.Instance.DeviceLostEvent += this.a;
			}
			catch (global::System.Exception ex)
			{
				this.a();
				global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw global::SpecialFeatures.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, global::Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x060011D1 RID: 4561 RVA: 0x00185294 File Offset: 0x00183494
		public bool CurrentRadioIsConnected
		{
			get
			{
				short num = (short)195986351;
				short num2 = num;
				num = (short)30442415;
				switch (num2 == num)
				{
				}
				num = (short)486866945;
				if (num != 0)
				{
				}
				num = (short)1824980992;
				if (num != 0)
				{
				}
				num = (short)258080768;
				short num3 = num;
				return this.g;
			}
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00185344 File Offset: 0x00183544
		public global::Motorola.Common.Communication.Pba.PbaObject Read(global::SpecialFeatures.Comms.RadioParams radioPara, global::System.ComponentModel.ProgressChangedEventHandler prgressIndicator = null)
		{
			short num;
			global::Motorola.Common.Communication.Pba.PbaObject result;
			try
			{
				num = (short)1259246058;
				short num2 = num;
				num = (short)912364010;
				switch (num2 == num)
				{
				}
				num = (short)1777598464;
				if (num != 0)
				{
				}
				this.c = prgressIndicator;
				result = this.b.ReadDevice(radioPara.WrapperDeviceInfo(), null);
			}
			catch (global::System.Exception ex)
			{
				this.a();
				global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw global::SpecialFeatures.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, global::Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
			}
			finally
			{
				this.c = null;
			}
			num = (short)605814785;
			if (num != 0)
			{
			}
			num = (short)815333376;
			short num3 = num;
			return result;
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x00185444 File Offset: 0x00183644
		public global::Motorola.Common.Communication.Pba.PbaObject ReadBlock(global::SpecialFeatures.Comms.RadioParams radioPara, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> blockList, global::System.ComponentModel.ProgressChangedEventHandler prgressIndicator = null)
		{
			short num;
			global::Motorola.Common.Communication.Pba.PbaObject result;
			try
			{
				num = (short)699531264;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					int num4;
					object[] array;
					for (;;)
					{
						IL_27:
						switch (num2)
						{
						case 0:
							goto IL_176;
						case 1:
							goto IL_110;
						case 2:
							goto IL_67;
						case 3:
							goto IL_67;
						case 4:
						{
							num = (short)568352392;
							short num3 = num;
							num = (short)2040618632;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_110;
							default:
								num = (short)1091305472;
								if (num != 0)
								{
								}
								num = (short)704053249;
								if (num != 0)
								{
								}
								if (num4 >= blockList.Count)
								{
									num = (short)952631297;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								array[num4] = blockList[num4];
								num4++;
								num = (short)510328834;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_42;
						IL_67:
						num = (short)1186201604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_110:
						this.c = prgressIndicator;
						result = this.b.ReadBlocks(radioPara.WrapperDeviceInfo(), array);
						num = (short)1474035712;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_176:
					break;
					IL_42:
					array = new object[blockList.Count];
					num4 = 0;
					num = (short)531365891;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				this.a();
				global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw global::SpecialFeatures.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, global::Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
			}
			finally
			{
				this.c = null;
			}
			num = (short)1430519808;
			short num5 = num;
			return result;
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x0018564C File Offset: 0x0018384C
		public bool Write(global::SpecialFeatures.Comms.RadioParams radioPara, global::Motorola.Common.Communication.Pba.PbaObject targetPba, global::System.ComponentModel.ProgressChangedEventHandler prgressIndicator = null)
		{
			short num;
			bool result;
			try
			{
				num = (short)1757354184;
				short num2 = num;
				num = (short)230037704;
				switch (num2 == num)
				{
				}
				num = (short)190775297;
				if (num != 0)
				{
				}
				num = (short)1165885440;
				if (num != 0)
				{
				}
				this.c = prgressIndicator;
				this.b.WriteDevice(radioPara.WrapperDeviceInfo(), targetPba, null);
				this.e = true;
				result = true;
			}
			catch (global::System.Exception ex)
			{
				this.a();
				global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw global::SpecialFeatures.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, global::Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
			}
			finally
			{
				this.c = null;
			}
			num = (short)1021444096;
			short num3 = num;
			return result;
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00185760 File Offset: 0x00183960
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo()
		{
			short num = (short)1161363457;
			if (num != 0)
			{
			}
			num = (short)143408169;
			short num2 = num;
			num = (short)2102541353;
			switch (num2 == num)
			{
			}
			num = (short)1221656576;
			if (num != 0)
			{
			}
			num = (short)1191182336;
			short num3 = num;
			return this.b.ReadDeviceInfo(this.d);
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x0018581C File Offset: 0x00183A1C
		public global::SpecialFeatures.Comms.RadioParams ReadExtendedDeviceInfo()
		{
			short num;
			global::SpecialFeatures.Comms.RadioParams result;
			try
			{
				num = (short)917361021;
				short num2 = num;
				num = (short)1801048445;
				switch (num2 == num)
				{
				}
				num = (short)792330240;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo astroDeviceInfo = this.b.ReadExtendedDeviceInfo(this.d) as global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo;
				astroDeviceInfo.ConnectionInfo = this.d.ConnectionInfo;
				result = astroDeviceInfo.WrapperRadioParams();
			}
			catch (global::System.Exception ex)
			{
				this.a();
				global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw global::SpecialFeatures.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, global::Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
			}
			num = (short)484311041;
			if (num != 0)
			{
			}
			num = (short)1339883520;
			short num3 = num;
			return result;
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x00185924 File Offset: 0x00183B24
		public bool ResetPassword(byte[] passwordResetFileContent)
		{
			short num;
			bool result;
			try
			{
				num = (short)1756436702;
				short num2 = num;
				num = (short)1792350430;
				switch (num2 == num)
				{
				}
				num = (short)2039021568;
				if (num != 0)
				{
				}
				num = (short)142671873;
				if (num != 0)
				{
				}
				result = this.b.ResetPassword(this.d, passwordResetFileContent);
			}
			catch (global::System.Exception ex)
			{
				this.a();
				global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw global::SpecialFeatures.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, global::Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
			}
			num = (short)1624047616;
			short num3 = num;
			return result;
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00185A0C File Offset: 0x00183C0C
		public bool ForceWrite(global::SpecialFeatures.Comms.RadioParams radioPara, global::Motorola.Common.Communication.Pba.PbaObject targetPba, global::System.ComponentModel.ProgressChangedEventHandler prgressIndicator = null)
		{
			short num;
			bool result;
			try
			{
				num = (short)473459057;
				short num2 = num;
				num = (short)1178167665;
				switch (num2 == num)
				{
				}
				num = (short)1782906880;
				if (num != 0)
				{
				}
				this.c = prgressIndicator;
				this.b.ForceWriteDevice(radioPara.WrapperDeviceInfo(), targetPba);
				this.e = true;
				result = true;
			}
			catch (global::System.Exception ex)
			{
				this.a();
				global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw global::SpecialFeatures.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, global::Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
			}
			finally
			{
				num = (short)1364525057;
				if (num != 0)
				{
				}
				this.c = null;
			}
			num = (short)370802688;
			short num3 = num;
			return result;
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00185B18 File Offset: 0x00183D18
		public bool UpdateSN(global::SpecialFeatures.Comms.RadioParams radioPara, string serialNumber)
		{
			short num;
			bool result;
			try
			{
				num = (short)1815840085;
				short num2 = num;
				num = (short)1240171861;
				switch (num2 == num)
				{
				}
				num = (short)1198784512;
				if (num != 0)
				{
				}
				this.b.UpdateSerialNumber(radioPara.WrapperDeviceInfo(), serialNumber);
				result = true;
			}
			catch (global::System.Exception ex)
			{
				this.a();
				global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw global::SpecialFeatures.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, global::Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
			}
			num = (short)2095710209;
			if (num != 0)
			{
			}
			num = (short)190251008;
			short num3 = num;
			return result;
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00185C04 File Offset: 0x00183E04
		public bool CBIProgram(global::SpecialFeatures.Comms.RadioParams radioPara)
		{
			short num;
			bool result;
			try
			{
				num = (short)920849502;
				short num2 = num;
				num = (short)362613854;
				switch (num2 == num)
				{
				}
				num = (short)629211136;
				if (num != 0)
				{
				}
				this.b.CBIProgramme(radioPara.WrapperDeviceInfo());
				result = true;
			}
			catch (global::System.Exception ex)
			{
				this.a();
				global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw global::SpecialFeatures.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, global::Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
			}
			num = (short)1549402113;
			if (num != 0)
			{
			}
			num = (short)1944715264;
			short num3 = num;
			return result;
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00185CF0 File Offset: 0x00183EF0
		public void UpdateDevice(global::SpecialFeatures.Comms.RadioParams radioPara, global::Motorola.Common.Communication.Pba.PbaObject targetPba, global::System.ComponentModel.ProgressChangedEventHandler prgressIndicator = null)
		{
			short num;
			try
			{
				num = (short)1966493057;
				short num2 = num;
				num = (short)531058049;
				switch (num2 == num)
				{
				}
				num = (short)199163904;
				if (num != 0)
				{
				}
				this.c = prgressIndicator;
				this.b.UpdateDevice(radioPara.WrapperDeviceInfo(), targetPba, false, null);
			}
			catch (global::System.Exception ex)
			{
				this.a();
				global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw global::SpecialFeatures.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, global::Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
			}
			finally
			{
				num = (short)1315504129;
				if (num != 0)
				{
				}
				this.c = null;
			}
			num = (short)30605312;
			short num3 = num;
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00185E00 File Offset: 0x00184000
		public void ValidateUpdate(global::SpecialFeatures.Comms.RadioParams radioPara, global::System.ComponentModel.ProgressChangedEventHandler prgressIndicator = null)
		{
			short num;
			try
			{
				num = (short)1948711694;
				short num2 = num;
				num = (short)2048916238;
				switch (num2 == num)
				{
				}
				num = (short)37945345;
				if (num != 0)
				{
				}
				num = (short)1848705024;
				if (num != 0)
				{
				}
				this.c = prgressIndicator;
				this.b.CloseSession(this.d, false);
			}
			catch (global::System.Exception ex)
			{
				this.a();
				global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw global::SpecialFeatures.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, global::Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
			}
			finally
			{
				this.c = null;
			}
			num = (short)357957632;
			short num3 = num;
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x00185F00 File Offset: 0x00184100
		public void WriteLanguagePack(global::SpecialFeatures.Comms.RadioParams radioParam, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData, global::System.ComponentModel.ProgressChangedEventHandler prgressIndicator = null)
		{
			short num2;
			try
			{
				this.c = prgressIndicator;
				this.b.WriteLanguagePacks(radioParam.WrapperDeviceInfo(), languagePackData);
			}
			catch (global::System.Exception ex)
			{
				this.a();
				global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::CommonResources.AppResources.WriteLanguagePack_Astro_WriteRadioLanguagePackFailed);
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_50;
				}
				int num;
				global::Motorola.Common.CustomException.CommonErrorCode warningOTAPErrorCode;
				for (;;)
				{
					IL_3E:
					switch (num)
					{
					case 0:
						global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.warningOTAPMessage = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(warningOTAPErrorCode.ToString(), null);
						goto IL_FD;
					case 1:
						goto IL_116;
					case 2:
					{
						if (warningOTAPErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.None)
						{
							goto IL_118;
						}
						num2 = (short)1482021657;
						short num3 = num2;
						num2 = (short)204004121;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FD;
						default:
							num2 = (short)1119682560;
							if (num2 != 0)
							{
							}
							num2 = (short)594083840;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_50;
					IL_FD:
					num2 = (short)407240705;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_116:
				IL_118:
				this.c = null;
				goto EndFinally_6;
				IL_50:
				warningOTAPErrorCode = (languagePackData.LanguagePacks[0] as global::Motorola.Common.Communication.Pba.AstroFilePackInfo).warningOTAPErrorCode;
				num2 = (short)1121058818;
				num = (int)((global::System.IntPtr)num2);
				goto IL_3E;
				EndFinally_6:;
			}
			num2 = (short)371523585;
			if (num2 != 0)
			{
			}
			num2 = (short)2078605312;
			short num4 = num2;
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x0018609C File Offset: 0x0018429C
		public bool LoadTxmCertificate(global::SpecialFeatures.Comms.RadioParams radioParam, string path)
		{
			try
			{
				byte[] array = global::System.IO.File.ReadAllBytes(path);
				string filePath = this.h + global::System.IO.Path.GetFileName(path);
				global::Motorola.Common.Communication.Pba.FileItem file = new global::Motorola.Common.Communication.Pba.FileItem(0, filePath, array.Length, array, null, null);
				this.b.WriteFile(radioParam.WrapperDeviceInfo(), file);
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				global::AcpCommonLib.AppInfoManager.StatusMsgReport.Clear();
				global::AcpCommonLib.StatusMsgType type = global::AcpCommonLib.StatusMsgType.Error;
				global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(type, global::CommonResources.AppResources.Radio_denied_file_transfer);
				bool result = false;
				goto IL_83;
			}
			catch (global::System.Exception)
			{
				global::AcpCommonLib.AppInfoManager.StatusMsgReport.Clear();
				global::AcpCommonLib.StatusMsgType type2 = global::AcpCommonLib.StatusMsgType.Error;
				global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(type2, global::CommonResources.AppResources.Load_Txm_Cert_Failed);
				bool result = false;
				goto IL_83;
			}
			return true;
			IL_83:
			short num = (short)342491137;
			if (num != 0)
			{
			}
			num = (short)68833353;
			short num2 = num;
			num = (short)371150921;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return true;
			default:
			{
				num = (short)2137784320;
				if (num != 0)
				{
				}
				num = (short)5898240;
				short num3 = num;
				bool result;
				return result;
			}
			}
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x001861E8 File Offset: 0x001843E8
		public string QueryTxmCertificate(global::SpecialFeatures.Comms.RadioParams radioParam, string path)
		{
			short num;
			string result;
			try
			{
				num = (short)1865809920;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> list;
					switch (0)
					{
					case 0:
						break;
					default:
						for (;;)
						{
							IL_28:
							switch (num2)
							{
							case 0:
							{
								num = (short)251984719;
								short num3 = num;
								num = (short)815266639;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_5E;
								default:
									num = (short)1657208832;
									if (num != 0)
									{
									}
									result = global::CommonResources.AppResources.None_Id;
									num = (short)1304100865;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								goto IL_100;
							case 2:
								goto IL_12C;
							case 3:
								if (list.Count == 0)
								{
									num = (short)553189376;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								result = global::System.IO.Path.GetFileNameWithoutExtension(list[0].FilePath);
								num = (short)326369282;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3F;
						}
						IL_100:
						IL_12C:
						goto IL_153;
					}
					IL_3F:
					global::Motorola.Common.Communication.Pba.FileItem dir = new global::Motorola.Common.Communication.Pba.FileItem(0, path, 0, null, null, null);
					list = this.b.ReadFilesListInDir(radioParam.WrapperDeviceInfo(), dir);
					IL_5E:
					num = (short)40960003;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
			}
			catch (global::System.Exception)
			{
				global::AcpCommonLib.AppInfoManager.StatusMsgReport.Clear();
				global::AcpCommonLib.StatusMsgType type = global::AcpCommonLib.StatusMsgType.Error;
				global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(type, global::CommonResources.AppResources.Failed_to_read_installed_certificate_id);
				result = global::CommonResources.AcgResources.ID_UNKNOWN;
			}
			IL_153:
			num = (short)224002049;
			if (num != 0)
			{
			}
			num = (short)1958477824;
			short num4 = num;
			return result;
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x001863B8 File Offset: 0x001845B8
		private void a()
		{
			short num = (short)240123904;
			short num2 = num;
			num = (short)641990659;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)943384688;
					short num4 = num;
					num = (short)1131800688;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6C;
					default:
						num = (short)2079391744;
						if (num != 0)
						{
						}
						if (this.d != null)
						{
							num = (short)667746305;
							if (num != 0)
							{
							}
							num = (short)1902706690;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14A;
					}
					break;
				}
				case 2:
					try
					{
						this.b.CloseSession(this.d, true);
						goto IL_14A;
					}
					catch
					{
						goto IL_14A;
					}
					goto IL_9F;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 4:
					goto IL_9F;
				}
				goto IL_61;
				IL_6C:
				num = (short)870252548;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_61:
				if (this.b != null)
				{
					goto IL_6C;
				}
				break;
				IL_9F:
				num = (short)989200385;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_14A:
				this.b = null;
				num = (short)125698048;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x00186540 File Offset: 0x00184740
		private void a(object A_0, global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs A_1)
		{
			short num = (short)1752891392;
			short num2 = num;
			num = (short)895025154;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					this.g = false;
					num = (short)2024472580;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)193092482;
					short num4 = num;
					num = (short)182016898;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_141;
					default:
						num = (short)1844248577;
						if (num != 0)
						{
						}
						num = (short)1342177280;
						if (num != 0)
						{
						}
						num = (short)700317699;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 3:
					if (this.a(this.d, A_1.DeviceInfo))
					{
						goto IL_141;
					}
					return;
				case 4:
					return;
				}
				IL_61:
				if (this.d != null)
				{
					num = (short)305790977;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_141:
				num = (short)1022427136;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x001866A8 File Offset: 0x001848A8
		private void a(object A_0, global::System.ComponentModel.ProgressChangedEventArgs A_1)
		{
			short num = (short)502775851;
			short num2 = num;
			num = (short)1912455211;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_AD:
				num = (short)1625227265;
				if (num != 0)
				{
				}
				num = (short)1675034626;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)861667328;
				if (num != 0)
				{
				}
				num = (short)1741946880;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				num = (short)232390656;
				short num4 = num;
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_A5;
					}
					continue;
				case 1:
					return;
				case 2:
					this.c(null, A_1);
					num = (short)730726401;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
			}
			IL_A5:
			if (this.c != null)
			{
				goto IL_AD;
			}
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x001867C8 File Offset: 0x001849C8
		private bool a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_1)
		{
			short num = (short)968491008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)1379205121;
				if (num != 0)
				{
				}
				num = (short)347602946;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return false;
					case 1:
						num = (short)1607991299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7F;
						}
						continue;
					case 3:
						if (A_1 == null)
						{
							num = (short)600702976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BA;
					case 4:
						goto IL_A0;
						try
						{
							bool result;
							for (;;)
							{
								IL_A0:
								switch (0)
								{
								case 0:
									goto IL_BD;
								}
								global::System.IO.MemoryStream memoryStream2;
								for (;;)
								{
									IL_AA:
									switch (num2)
									{
									case 0:
										goto IL_179;
									case 1:
										goto IL_2AC;
									case 2:
									{
										byte[] array;
										try
										{
											global::System.IO.MemoryStream memoryStream;
											new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Serialize(memoryStream, A_1);
											memoryStream.Position = 0L;
											array = new byte[memoryStream.Length];
											memoryStream.Read(array, 0, array.Length);
											goto IL_281;
										}
										finally
										{
											num = (short)567017472;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.IO.MemoryStream memoryStream;
												switch (num2)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_141;
													}
													continue;
												case 1:
													goto IL_176;
												case 2:
													((global::System.IDisposable)memoryStream).Dispose();
													num = (short)975503361;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_141:
												if (memoryStream == null)
												{
													break;
												}
												num = (short)456523778;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_176:;
										}
										goto Block_5;
										IL_281:
										byte[] array2;
										result = string.Equals(array2.GetSHA256Hash(), array.GetSHA256Hash());
										num = (short)1195638785;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
									Block_5:
									try
									{
										IL_179:
										new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Serialize(memoryStream2, A_0);
										memoryStream2.Position = 0L;
										byte[] array2 = new byte[memoryStream2.Length];
										memoryStream2.Read(array2, 0, array2.Length);
									}
									finally
									{
										num = (short)1848573952;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_1DA;
												}
												continue;
											case 1:
												goto IL_210;
											case 2:
												((global::System.IDisposable)memoryStream2).Dispose();
												num = (short)1866006529;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_1DA:
											if (memoryStream2 == null)
											{
												break;
											}
											num = (short)1702363138;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_210:;
									}
									num = (short)146318140;
									short num3 = num;
									num = (short)812098364;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_A0;
									default:
									{
										num = (short)578551808;
										if (num != 0)
										{
										}
										global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
										num = (short)2044198914;
										num2 = (int)((global::System.IntPtr)num);
										break;
									}
									}
								}
								IL_BD:
								memoryStream2 = new global::System.IO.MemoryStream();
								num = (short)772407296;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_AA;
							}
							IL_2AC:
							return result;
						}
						catch
						{
							return false;
						}
						goto IL_2BA;
					}
					IL_7F:
					if (A_0 != null)
					{
						num = (short)61669377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_2BA:
					num = (short)1690763264;
					short num4 = num;
					num = (short)1726414852;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
			}
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x00186B60 File Offset: 0x00184D60
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)702281854;
				short num2 = num;
				num = (short)1433139326;
				switch (num2 == num)
				{
				}
				num = (short)1547567104;
				if (num != 0)
				{
				}
				this.a(false);
			}
			finally
			{
				num = (short)704184321;
				if (num != 0)
				{
				}
				base.Finalize();
			}
			num = (short)1458503680;
			short num3 = num;
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x00186C28 File Offset: 0x00184E28
		public void Dispose()
		{
			short num = (short)1526854007;
			short num2 = num;
			num = (short)1624174967;
			switch (num2 == num)
			{
			}
			num = (short)920387585;
			if (num != 0)
			{
			}
			num = (short)190185472;
			if (num != 0)
			{
			}
			num = (short)514654208;
			short num3 = num;
			this.a(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x00186CE0 File Offset: 0x00184EE0
		private void a(bool A_0)
		{
			short num = (short)1079050241;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_0)
					{
						num = (short)92340234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EE;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_50;
					}
					continue;
				case 2:
				{
					num = (short)1156841472;
					short num3 = num;
					goto IL_26B;
				}
				case 3:
					goto IL_1EE;
				case 4:
				{
					num = (short)325873765;
					short num4 = num;
					num = (short)1436840037;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_24B;
					default:
						num = (short)713621504;
						if (num != 0)
						{
						}
						global::SpecialFeatures.Comms.DeviceManagerSingleTon.Instance.DeviceLostEvent -= this.a;
						this.a.ProgressEventHandler -= this.a;
						this.a = null;
						this.c = null;
						num = (short)457768962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					num = (short)2050228224;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					try
					{
						num = (short)1092222978;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_144;
							case 1:
								this.b.CloseSession(this.d, false);
								num = (short)1461780484;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_AD;
								}
								continue;
							case 3:
								goto IL_12D;
							case 4:
								goto IL_12D;
							}
							IL_AD:
							if (this.f == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
							{
								num = (short)1040121857;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.b.CloseSession(this.d, !this.e);
							num = (short)1819738115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_12D:
							num = (short)121634816;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_144:
						goto IL_24B;
					}
					catch (global::System.Exception ex)
					{
						global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
						throw global::SpecialFeatures.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, global::Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
					}
					finally
					{
						this.b = null;
					}
					goto IL_165;
				case 7:
					return;
				case 8:
					if (this.a != null)
					{
						num = (short)401735684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26B;
				case 9:
					num = (short)213909505;
					if (num != 0)
					{
					}
					if (this.b != null)
					{
						num = (short)1167261702;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_24B;
				case 10:
					goto IL_165;
				}
				IL_50:
				if (!this.i)
				{
					num = (short)1952776197;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_165:
				num = (short)561053704;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1EE:
				this.i = true;
				num = (short)1722023943;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_24B:
				this.d = null;
				num = (short)824246275;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_26B:
				num = (short)1055784969;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x040009C1 RID: 2497
		private global::SpecialFeatures.Comms.DeviceServiceHandler a;

		// Token: 0x040009C2 RID: 2498
		private global::Motorola.Common.Communication.Service.IDeviceOperation b;

		// Token: 0x040009C3 RID: 2499
		private global::System.ComponentModel.ProgressChangedEventHandler c;

		// Token: 0x040009C4 RID: 2500
		private global::Motorola.Common.Communication.CommonUtil.DeviceInfo d;

		// Token: 0x040009C5 RID: 2501
		private bool e;

		// Token: 0x040009C6 RID: 2502
		private global::Motorola.Common.Communication.CommonUtil.RadioOperation f;

		// Token: 0x040009C7 RID: 2503
		private bool g;

		// Token: 0x040009C8 RID: 2504
		private readonly string h;

		// Token: 0x040009C9 RID: 2505
		private bool i;
	}
}
