using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ASK.Interface;
using CommonUtility;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000055 RID: 85
	public class ASTRORadioValidationService : global::Motorola.CommonCPS.RadioManagement.LocalService.RadioValidationService
	{
		// Token: 0x06000306 RID: 774 RVA: 0x0004B318 File Offset: 0x00049518
		public ASTRORadioValidationService(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServiceContainer serviceContainer) : base(serviceContainer)
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0004B32C File Offset: 0x0004952C
		public void ValidateDevice(global::Motorola.CommonCPS.Server.EntityModel.Radio d, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type, bool isRestoreJob, bool restoreJob_PbaCanNotBeDirectlyModified, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport, bool isWriteProtected, bool isGeneratingConfig, out global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest fieldsModifyRequest, out int supportedConnections, ref global::System.Collections.ObjectModel.Collection<global::ASK.Interface.ISystemKeyData> attachedASKs, ref bool? isSpecialKeyAttached)
		{
			short num;
			for (;;)
			{
				this.a = attachedASKs;
				this.b = isSpecialKeyAttached;
				try
				{
					this.ValidateDevice(d, type, isRestoreJob, restoreJob_PbaCanNotBeDirectlyModified, transport, isWriteProtected, isGeneratingConfig, out fieldsModifyRequest, out supportedConnections);
				}
				finally
				{
					attachedASKs = this.a;
					isSpecialKeyAttached = this.b;
				}
				num = (short)1959723009;
				if (num != 0)
				{
				}
				num = (short)1153737696;
				short num2 = num;
				num = (short)1835639776;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					goto IL_CB;
				}
				break;
			}
			num = (short)328204288;
			short num3 = num;
			IL_CB:
			num = (short)1685979136;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0004B42C File Offset: 0x0004962C
		public void ValidateDevice(global::Motorola.CommonCPS.Server.EntityModel.Radio d, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type, bool isRestoreJob, bool restoreJob_PbaCanNotBeDirectlyModified, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport, bool isWriteProtected, bool isGeneratingConfig, out global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest fieldsModifyRequest, out int supportedConnections, out global::Motorola.CommonCPS.Server.CommonDBConstants.JobType correctedJobType, ref global::System.Collections.ObjectModel.Collection<global::ASK.Interface.ISystemKeyData> attachedASKs, ref bool? isSpecialKeyAttached)
		{
			short num;
			for (;;)
			{
				this.a = attachedASKs;
				this.b = isSpecialKeyAttached;
				try
				{
					this.ValidateDevice(d, type, isRestoreJob, restoreJob_PbaCanNotBeDirectlyModified, transport, isWriteProtected, isGeneratingConfig, out fieldsModifyRequest, out supportedConnections, out correctedJobType);
				}
				finally
				{
					num = (short)638124033;
					if (num != 0)
					{
					}
					attachedASKs = this.a;
					isSpecialKeyAttached = this.b;
				}
				num = (short)1036353538;
				short num2 = num;
				num = (short)781352962;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_A9;
				}
			}
			IL_A9:
			num = (short)1861419008;
			if (num != 0)
			{
			}
			num = (short)463994880;
			short num3 = num;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0004B534 File Offset: 0x00049734
		protected override void ValidateForeignIP(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport)
		{
			short num = (short)451084289;
			if (num != 0)
			{
			}
			num = (short)789863279;
			short num2 = num;
			num = (short)192568175;
			switch (num2 == num)
			{
			}
			num = (short)1363214336;
			if (num != 0)
			{
			}
			num = (short)909180928;
			short num3 = num;
			(this._serviceContainer.RadioService as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService).ValidateForeignIP(radio, transport);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0004B5F4 File Offset: 0x000497F4
		protected override void ValidateWritingJob(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport, bool isRestoreJob, bool restoreJob_PbaCanNotBeDirectlyModified, bool isWriteProtected, out global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest secReq)
		{
			int a_ = 2;
			secReq = null;
			this.a(radio, isRestoreJob, restoreJob_PbaCanNotBeDirectlyModified);
			if (((global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)radio.CurrentCodeplug).DisableWriteProtect == null)
			{
				short num = (short)1922063663;
				short num2 = num;
				num = (short)541089071;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)330563585;
					if (num != 0)
					{
					}
					num = (short)1863254016;
					short num3 = num;
					num = (short)1718026240;
					if (num != 0)
					{
					}
					break;
				}
				}
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("堛眝匟䌡䘣䨥䴧紩師䜭䐯圱搳䐵圷丹夻崽㐿扁㝃⹅⥇⑉歋㩍灏けㅓ癕㙗⽙せ㉝䁟ᕡౣͥ٧䩩㽫൭ᡯ᝱ၳ͵ᑷό屻㑽", a_));
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			bool enableWriteProtect = !((global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)radio.CurrentCodeplug).DisableWriteProtect.Value;
			(this._serviceContainer.RadioService as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService).ValidateAstroWriting((global::Motorola.CommonCPS.Server.EntityModel.APXRadio)radio, enableWriteProtect, transport, isWriteProtected, isRestoreJob, restoreJob_PbaCanNotBeDirectlyModified, out secReq, ref this.a, ref this.b);
			this.a(isRestoreJob, restoreJob_PbaCanNotBeDirectlyModified, ref secReq);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0004B750 File Offset: 0x00049950
		protected override void ExtraValidation(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport, global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest fieldsShallBeUpdated)
		{
			short num = (short)77685244;
			short num2 = num;
			num = (short)1142317564;
			switch (num2 == num)
			{
			}
			num = (short)1597898752;
			if (num != 0)
			{
			}
			num = (short)822018049;
			if (num != 0)
			{
			}
			num = (short)1456668672;
			short num3 = num;
			global::Motorola.CommonCPS.Server.EntityModel.APXRadio radio2 = radio as global::Motorola.CommonCPS.Server.EntityModel.APXRadio;
			this._serviceContainer.DeviceOperation.ValidateIsAllowWriteLanguage(radio2, type);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0004B814 File Offset: 0x00049A14
		protected override bool HasRequiredConfig_For_WriteJob(global::Motorola.CommonCPS.Server.EntityModel.Radio radio)
		{
			if (radio.WorkingCodeplug.ConfigurationUuid == null)
			{
				short num = (short)1972595028;
				short num2 = num;
				num = (short)2064738644;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)205193217;
					if (num != 0)
					{
					}
					num = (short)1570439168;
					short num3 = num;
					num = (short)109576192;
					if (num != 0)
					{
					}
					break;
				}
				}
				return radio.WorkingCodeplug.TemplateUuid != null;
			}
			return true;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0004B8F0 File Offset: 0x00049AF0
		protected override void ValidateChangeIndicator(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport, bool isRestoreJob)
		{
			short num = (short)1921122311;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int? changeIndicator;
				switch (num2)
				{
				case 0:
					if (transport != global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference.OTA)
					{
						num = (short)985595907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_237;
				case 1:
					if (transport == global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference.WiredOrOTA)
					{
						num = (short)528941069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C5;
				case 2:
					if (changeIndicator != null)
					{
						num = (short)1816920070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					num = (short)317456385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_1C5;
				case 5:
					if (type != global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.WriteNoSwitchover)
					{
						num = (short)331546624;
						short num3 = num;
						num = (short)1219690504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25A;
				case 6:
					goto IL_29E;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 8:
					num = (short)920911882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					return;
				case 10:
					if (type == global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.WriteWithSwitchover)
					{
						num = (short)369688588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 11:
					return;
				case 12:
					goto IL_25A;
				case 13:
					num = (short)83427329;
					if (num != 0)
					{
					}
					goto IL_237;
				}
				IL_5D:
				if (isRestoreJob)
				{
					num = (short)151060491;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)155801382;
				short num4 = num;
				num = (short)588404518;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_29E;
				default:
					num = (short)458096640;
					if (num != 0)
					{
					}
					num = (short)1769930757;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1C5:
				this.b(radio);
				this.a(radio, transport);
				this.e(radio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
				this.d(radio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
				this.b(radio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
				this.c(radio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
				num = (short)476315657;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_237:
				this.c(radio);
				num = (short)858521604;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_25A:
				changeIndicator = radio.WorkingCodeplug.ChangeIndicator;
				num = (short)1108082690;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_29E:
				num = (short)1990459392;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0004BBD8 File Offset: 0x00049DD8
		private void e(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug A_0)
		{
			short num = (short)133496835;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement>.Enumerator enumerator;
			for (;;)
			{
				bool flag;
				switch (num2)
				{
				case 0:
					flag = (A_0.ASTROVoiceAnnouncements != null);
					goto IL_DC;
				case 1:
				{
					num = (short)312082432;
					short num3 = num;
					flag = (null != null);
					goto IL_DC;
				}
				case 2:
					enumerator = A_0.ASTROVoiceAnnouncements.GetEnumerator();
					num = (short)106496004;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 4:
					goto IL_11E;
				case 5:
					num = (short)757792769;
					if (num != 0)
					{
					}
					num = (short)1345388545;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3D:
				if (A_0 == null)
				{
					num = (short)999686149;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)345309184;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DC:
				if (!flag)
				{
					return;
				}
				num = (short)1028259842;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_11E:
			try
			{
				num = (short)1634402307;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)544997378;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1701071945;
						short num4 = num;
						num = (short)660229193;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D2;
						default:
							num = (short)651624448;
							if (num != 0)
							{
							}
							num = (short)1885143045;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_1FC;
					case 2:
						num = (short)725024772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_15D;
						}
						continue;
					case 4:
						goto IL_255;
					case 5:
						goto IL_1D2;
					}
					goto IL_15D;
					IL_1D2:
					if (!global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.FileExist(enumerator.Current.FileUuid))
					{
						num = (short)1193017345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_201:
					num = (short)181993472;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15D:
					goto IL_201;
				}
				IL_1FC:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DeviceLinkedVoiceFilesNotExistOnServer);
				IL_255:;
			}
			finally
			{
				((global::System.IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0004BE68 File Offset: 0x0004A068
		private void d(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug A_0)
		{
			short num = (short)1878654979;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates>.Enumerator enumerator;
			for (;;)
			{
				bool flag;
				switch (num2)
				{
				case 0:
					flag = (A_0.ASTROCACertificates != null);
					goto IL_DF;
				case 1:
				{
					num = (short)1779367936;
					short num3 = num;
					flag = (null != null);
					goto IL_DF;
				}
				case 2:
					enumerator = A_0.ASTROCACertificates.GetEnumerator();
					num = (short)1828388868;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)843972609;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				case 4:
					goto IL_121;
				case 5:
					num = (short)2080768001;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_64:
				if (A_0 == null)
				{
					num = (short)1680080901;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)815988736;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DF:
				if (!flag)
				{
					return;
				}
				num = (short)1457258498;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_121:
			try
			{
				num = (short)983367683;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1788018690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)585908465;
						short num4 = num;
						num = (short)207503601;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D2;
						default:
							num = (short)327417856;
							if (num != 0)
							{
							}
							num = (short)1236008965;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_1FC;
					case 2:
						num = (short)282787844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_160;
						}
						continue;
					case 4:
						goto IL_255;
					case 5:
						goto IL_1D2;
					}
					goto IL_160;
					IL_1D2:
					if (!global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.FileExist(enumerator.Current.FileUuid))
					{
						num = (short)1444675585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_201:
					num = (short)376897536;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_160:
					goto IL_201;
				}
				IL_1FC:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DeviceLinkedCACertificateFilesNotExistOnServer);
				IL_255:;
			}
			finally
			{
				((global::System.IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0004C0F8 File Offset: 0x0004A2F8
		private void c(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug A_0)
		{
			short num = (short)89456643;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>.Enumerator enumerator;
			for (;;)
			{
				bool flag;
				switch (num2)
				{
				case 0:
					num = (short)2053373953;
					if (num != 0)
					{
					}
					flag = (A_0.ASTRODVRSFiles != null);
					goto IL_E0;
				case 1:
					flag = (null != null);
					goto IL_E0;
				case 2:
					enumerator = A_0.ASTRODVRSFiles.GetEnumerator();
					num = (short)700645380;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 4:
					goto IL_123;
				case 5:
					num = (short)1845952513;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3D:
				if (A_0 == null)
				{
					num = (short)1254031365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1277820928;
				short num3 = num;
				num = (short)1700986880;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E0:
				if (!flag)
				{
					return;
				}
				num = (short)570884098;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_123:
			try
			{
				num = (short)1242300419;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)628817922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1915712715;
						short num4 = num;
						num = (short)694449355;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D2;
						default:
							num = (short)1408761856;
							if (num != 0)
							{
							}
							num = (short)1899495429;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_1FD;
					case 2:
						num = (short)314048516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_162;
						}
						continue;
					case 4:
						goto IL_256;
					case 5:
						goto IL_1D2;
					}
					goto IL_162;
					IL_1D2:
					if (!global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.FileExist(enumerator.Current.FileUuid))
					{
						num = (short)137297921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_202:
					num = (short)1592000512;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_162:
					goto IL_202;
				}
				IL_1FD:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DeviceLinkedDVRSFilesNotExistOnServer);
				IL_256:;
			}
			finally
			{
				((global::System.IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0004C388 File Offset: 0x0004A588
		private void b(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug A_0)
		{
			short num = (short)1784807427;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROTTSVoiceAnnouncement>.Enumerator enumerator;
			for (;;)
			{
				bool flag;
				switch (num2)
				{
				case 0:
					flag = (A_0.ASTROTTSVoiceAnnouncements != null);
					goto IL_B5;
				case 1:
					flag = (null != null);
					goto IL_B5;
				case 2:
					enumerator = A_0.ASTROTTSVoiceAnnouncements.GetEnumerator();
					num = (short)70057988;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 4:
					goto IL_F7;
				case 5:
					num = (short)1854734337;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3C:
				if (A_0 == null)
				{
					num = (short)1147600901;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)464322560;
				short num3 = num;
				num = (short)954662912;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B5:
				if (!flag)
				{
					goto IL_23D;
				}
				num = (short)259457026;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F7:
			try
			{
				num = (short)532545539;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1783300098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1741972803;
						short num4 = num;
						num = (short)1158047043;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1A8;
						default:
							num = (short)706150400;
							if (num != 0)
							{
							}
							num = (short)374996997;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_1D3;
					case 2:
						num = (short)713883652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_136;
						}
						continue;
					case 4:
						goto IL_22D;
					case 5:
						goto IL_1A8;
					}
					goto IL_136;
					IL_1A8:
					if (!global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.FileExist(enumerator.Current.FileUuid))
					{
						num = (short)1096744961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1D8:
					num = (short)809828352;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_136:
					goto IL_1D8;
				}
				IL_1D3:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DeviceLinkedTTSVoiceAnnouncementFilesNotExistOnServer);
				IL_22D:;
			}
			finally
			{
				((global::System.IDisposable)enumerator).Dispose();
			}
			IL_23D:
			num = (short)1664155649;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0004C618 File Offset: 0x0004A818
		private bool d(global::Motorola.CommonCPS.Server.EntityModel.Radio A_0)
		{
			short num = (short)1441988608;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3F;
				}
				global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
				bool flag;
				bool flag3;
				bool flag4;
				global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug2;
				bool flag5;
				int num5;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						num = (short)1987248128;
						short num3 = num;
						num = (short)1846576463;
						short num4 = num;
						num = (short)377652559;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_91;
						default:
							num = (short)1621884928;
							if (num != 0)
							{
							}
							flag = this.a(apxcodeplug.AstroPurchasedFlashCode, 7, 4);
							num = (short)1688928257;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						bool flag2 = this.a(apxcodeplug.AstroPurchasedFlashCode, 0, 3);
						flag3 = this.a(apxcodeplug.AstroPurchasedFlashCode, 6, 5);
						flag4 = this.a(apxcodeplug.AstroPurchasedFlashCode, 9, 5);
						flag5 = this.a(apxcodeplug2.AstroPurchasedFlashCode, 5, 5);
						if (flag2)
						{
							num = (short)1868759042;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 2:
						goto IL_1AC;
					case 3:
						if (num5 >= 15)
						{
							goto IL_91;
						}
						return false;
					}
					goto IL_3F;
					IL_91:
					num = (short)1139408896;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_1AC:
				num = (short)685965313;
				if (num != 0)
				{
				}
				return flag || flag3 || flag4 || flag5;
				IL_3F:
				apxcodeplug = (A_0.CurrentCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
				apxcodeplug2 = (A_0.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
				string firmwareVersion = A_0.CurrentCodeplug.FirmwareVersion;
				num5 = 0;
				int.TryParse(firmwareVersion.Substring(1, 2), out num5);
				num = (short)969211907;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0004C800 File Offset: 0x0004AA00
		private void c(global::Motorola.CommonCPS.Server.EntityModel.Radio A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			int num;
			global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug codeplug;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (!base.IsChangeIndicatorOn(codeplug, global::Motorola.CommonCPS.Server.CommonDBConstants.ChangeIndicator.FW))
					{
						num2 = (short)415105027;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_173;
				case 1:
					if (base.IsChangeIndicatorOn(codeplug, global::Motorola.CommonCPS.Server.CommonDBConstants.ChangeIndicator.LP))
					{
						num2 = (short)876478464;
						short num3 = num2;
						num2 = (short)595918861;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_26C;
				case 2:
					if (!this.a(A_0))
					{
						num2 = (short)314638342;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_26C;
				case 3:
					num2 = (short)1227685889;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)360382465;
					if (num2 != 0)
					{
					}
					num2 = (short)2049114117;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (base.IsChangeIndicatorOn(codeplug, global::Motorola.CommonCPS.Server.CommonDBConstants.ChangeIndicator.LP))
					{
						num2 = (short)183173128;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_26C;
				case 6:
					goto IL_21F;
				case 7:
					if (this.d(A_0))
					{
						num2 = (short)1619460107;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1985609728;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)1407451146;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (!base.IsChangeIndicatorOn(codeplug, global::Motorola.CommonCPS.Server.CommonDBConstants.ChangeIndicator.FW))
					{
						num2 = (short)36700164;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_26C;
				case 10:
					if (!this.a(A_0))
					{
						goto IL_251;
					}
					goto IL_26C;
				case 11:
					num2 = (short)346947593;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					goto IL_26A;
				case 13:
					num2 = (short)1882783746;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_48;
				IL_251:
				num2 = (short)608894988;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_26C:
				num2 = (short)1155654047;
				short num4 = num2;
				num2 = (short)744546719;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_251;
				default:
					goto IL_2A0;
				}
			}
			IL_173:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_ScheduleJob_LimitOTAPforAstroFwLp);
			IL_21F:
			goto IL_173;
			IL_26A:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_ScheduleJob_LimitOTAPforAstroLPnoFW);
			IL_2A0:
			num2 = (short)1068433408;
			if (num2 != 0)
			{
			}
			return;
			IL_48:
			codeplug = (A_0.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
			num2 = (short)1052835847;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0004CAC4 File Offset: 0x0004ACC4
		private void b(global::Motorola.CommonCPS.Server.EntityModel.Radio A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::System.Guid? firmwareUuid;
					if (firmwareUuid != null)
					{
						num2 = (short)1023475718;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_15B;
				}
				case 1:
					goto IL_191;
				case 2:
					goto IL_55;
				case 3:
					goto IL_156;
				case 4:
				{
					global::Motorola.CommonCPS.Server.EntityModel.Package package;
					if (package == null)
					{
						num2 = (short)1256390657;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1952194514;
					short num3 = num2;
					num2 = (short)1079517138;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_55;
					default:
					{
						num2 = (short)1235484672;
						if (num2 != 0)
						{
						}
						num2 = (short)139591681;
						if (num2 != 0)
						{
						}
						num2 = (short)218300416;
						short num4 = num2;
						num2 = (short)1946419208;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 5:
					goto IL_15B;
				case 6:
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.IPackageManagementService packageManagementService = this._serviceContainer.PackageManagementService;
					global::System.Guid? firmwareUuid = apxcodeplug.FirmwareUuid;
					global::Motorola.CommonCPS.Server.EntityModel.Package package = packageManagementService.GetPackage(firmwareUuid.Value);
					num2 = (short)625934341;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
				{
					global::Motorola.CommonCPS.Server.EntityModel.Package package = null;
					global::System.Guid? firmwareUuid = apxcodeplug.FirmwareUuid;
					num2 = (short)931856384;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
				{
					global::Motorola.CommonCPS.Server.EntityModel.Package package;
					if (!global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.FileExist(package.FileUuid))
					{
						num2 = (short)928579587;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				}
				goto IL_34;
				IL_55:
				if (base.IsChangeIndicatorOn(apxcodeplug, global::Motorola.CommonCPS.Server.CommonDBConstants.ChangeIndicator.FW))
				{
					num2 = (short)1457979399;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				return;
				IL_15B:
				num2 = (short)938344452;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_156:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DeviceLinkedFirmwareFilesNotExistOnServer);
			IL_191:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DeviceLinkedFirmwarePackageNotExistOnServer);
			IL_34:
			apxcodeplug = (A_0.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
			num2 = (short)508297218;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0004CCFC File Offset: 0x0004AEFC
		private void a(global::Motorola.CommonCPS.Server.EntityModel.Radio A_0, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
			global::System.Guid? fileUuid;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)467337218;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)1029767169;
					if (num2 != 0)
					{
					}
					num2 = (short)770703369;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (!this.a(A_0))
					{
						num2 = (short)842596356;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
				{
					num2 = (short)1867639978;
					short num3 = num2;
					num2 = (short)504753322;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F1;
					default:
						num2 = (short)1902313472;
						if (num2 != 0)
						{
						}
						num2 = (short)1777270792;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					goto IL_1F1;
				case 5:
					if (base.IsChangeIndicatorOn(apxcodeplug, global::Motorola.CommonCPS.Server.CommonDBConstants.ChangeIndicator.LP))
					{
						num2 = (short)901382147;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 6:
					goto IL_228;
				case 7:
					if (!this.a(apxcodeplug))
					{
						num2 = (short)2127822854;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 8:
					if (A_1 != global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference.Wired)
					{
						num2 = (short)1879834624;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F1;
				case 9:
					if (A_0.WorkMode == global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Configuration)
					{
						num2 = (short)419954698;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_22A;
				case 10:
					goto IL_1EF;
				case 11:
					if (fileUuid == null)
					{
						num2 = (short)1444085761;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_22A;
				}
				goto IL_40;
				IL_1F1:
				num2 = (short)1595670535;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_22A:
				num2 = (short)899153925;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1EF:
			num2 = (short)223019008;
			short num4 = num2;
			this.ValidateConfigurationForceWriteLp(A_0 as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
			return;
			IL_228:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DeviceLinkedLanguageFilesNotExistOnServer);
			IL_40:
			apxcodeplug = (A_0.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
			fileUuid = apxcodeplug.FileUuid;
			num2 = (short)414449675;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0004CF70 File Offset: 0x0004B170
		public void ValidateConfigurationForceWriteLp(global::Motorola.CommonCPS.Server.EntityModel.APXRadio radio)
		{
			short num = (short)1992228872;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
				global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug;
				string value;
				switch (num2)
				{
				case 0:
					if (apxcodeplug.ASTROLanguagePack != null)
					{
						num = (short)440926210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_266;
				case 1:
				{
					IL_D8:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc> list;
					if (list != null)
					{
						num = (short)1010827267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 2:
					num = (short)845938705;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)645529606;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1694826496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc> list;
					if (global::CommonUtility.ASTROLanguageUtility.Instance.IsSupportedLanguagePack(radio.CurrentCodeplug.FirmwareVersion, list[0].LanguageID))
					{
						num = (short)1964441604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 6:
				{
					num = (short)184942593;
					if (num != 0)
					{
					}
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc> list;
					if (list.Count == 0)
					{
						num = (short)2142371855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)667353106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					codeplug = radio.WorkingCodeplug;
					goto IL_207;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_78;
					}
					continue;
				case 9:
					codeplug = null;
					goto IL_207;
				case 10:
					value = apxcodeplug.LanguageSetting;
					goto IL_156;
				case 11:
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc> list = global::Motorola.CommonCPS.Common.CommonUtility.ObjectSeralizeUtility.JsonToObject<global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc>>(apxcodeplug.LanguageSetting);
					num = (short)1597177857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
					num = (short)876281861;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					value = null;
					goto IL_156;
				case 14:
					if (apxcodeplug == null)
					{
						num = (short)1193672723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)605224970;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					return;
				case 16:
					goto IL_205;
				case 17:
					if (!this.a(apxcodeplug))
					{
						num = (short)636420112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 18:
				{
					num = (short)1268383744;
					short num3 = num;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageSettingDesc> list;
					if (global::CommonUtility.ASTROLanguageUtility.Instance.IsFirmwareSupportCurrentLanguage(radio.CurrentCodeplug.FirmwareVersion, list[0].LanguageID))
					{
						num = (short)1475739660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 19:
					num = (short)572260365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					num = (short)1960640521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_78:
				if (radio == null)
				{
					num = (short)596115476;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)2126249991;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_156:
				if (string.IsNullOrEmpty(value))
				{
					return;
				}
				num = (short)1834332052;
				short num4 = num;
				num = (short)1363324820;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_D8;
				default:
					num = (short)520683520;
					if (num != 0)
					{
					}
					num = (short)1455423499;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_207:
				apxcodeplug = (codeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
				num = (short)1164050446;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_205:
			IL_266:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DeviceLinkedLanguageFilesNotExistOnServer);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0004D34C File Offset: 0x0004B54C
		private bool a(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug A_0)
		{
			short num = (short)1010434053;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1970274304;
				short num3 = num;
				bool flag;
				switch (num2)
				{
				case 0:
					flag = (A_0.ASTROLanguagePack != null);
					goto IL_139;
				case 1:
					num = (short)27983876;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)972216167;
					short num4 = num;
					num = (short)1211160423;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num = (short)1679032321;
						if (num != 0)
						{
						}
						num = (short)1341652992;
						if (num != 0)
						{
						}
						num = (short)1817378819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					flag = (null != null);
					goto IL_139;
				case 4:
					goto IL_128;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				}
				IL_65:
				if (A_0 == null)
				{
					num = (short)1322713090;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)547225600;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_139:
				if (!flag)
				{
					return true;
				}
				num = (short)1972830209;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_128:
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.FileExist(A_0.ASTROLanguagePack.FileUuid);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0004D4D0 File Offset: 0x0004B6D0
		private void a(bool A_0, bool A_1, ref global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest A_2)
		{
			short num = (short)466747394;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_D4;
				case 1:
					A_2 = null;
					num = (short)2079653888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)960561153;
					if (num != 0)
					{
					}
					num = (short)34543328;
					short num3 = num;
					num = (short)1156847328;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D6;
					default:
						num = (short)468779008;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A1;
						}
						continue;
					}
					break;
				}
				}
				IL_A1:
				if (!A_0 || !A_1)
				{
					break;
				}
				num = (short)305659905;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D4:
			IL_D6:
			num = (short)777912320;
			short num4 = num;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0004D5DC File Offset: 0x0004B7DC
		private void a(global::Motorola.CommonCPS.Server.EntityModel.Radio A_0, bool A_1, bool A_2)
		{
			int a_ = 9;
			short num = (short)250740747;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					bool? disableWriteProtect = ((global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)A_0.CurrentCodeplug).DisableWriteProtect;
					goto IL_E2;
				}
				case 1:
				{
					num = (short)1930362880;
					short num3 = num;
					num = (short)1279066113;
					if (num != 0)
					{
					}
					bool? disableWriteProtect = ((global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)A_0.CurrentCodeplug).DisableWriteProtect;
					num = (short)1679228935;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
				{
					bool? disableWriteProtect;
					bool value = disableWriteProtect.Value;
					disableWriteProtect = ((global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)A_0.WorkingCodeplug).DisableWriteProtect;
					bool value2 = disableWriteProtect.Value;
					if (!value)
					{
						return;
					}
					num = (short)178171037;
					short num4 = num;
					num = (short)370060445;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E2;
					default:
						num = (short)651755520;
						if (num != 0)
						{
						}
						num = (short)195887108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_298;
				case 4:
					num = (short)1708064773;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					bool value2;
					if (!value2)
					{
						num = (short)315293699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 6:
				{
					bool? disableWriteProtect = ((global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)A_0.WorkingCodeplug).DisableWriteProtect;
					num = (short)1770127369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
				{
					bool? disableWriteProtect;
					if (disableWriteProtect != null)
					{
						num = (short)818348038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_29D;
				}
				case 8:
					if (A_2)
					{
						num = (short)786432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 9:
				{
					bool? disableWriteProtect;
					if (disableWriteProtect == null)
					{
						num = (short)383844362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1264320520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					goto IL_207;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				}
				IL_5D:
				if (A_1)
				{
					num = (short)1935933441;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_E2:
				num = (short)530382850;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_207:
			goto IL_29D;
			IL_298:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Restore_ASTRO_ShallNotShutOffWriteProtected);
			IL_29D:
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("攢䨤唦न太䠬尮䔰尲䜴制ᤸ焺刼崾浀捂ㅄ⽆ⱈ歊ौ♎≐㉒㝔㭖㱘ౚ⽜㙞ᕠ٢㕤ᕦ٨Ὢ࡬౮հ卲ᩴᅶ奸᡺ࡼൾꦈ璉ﺘ뮚ﲜ얠莢튤좦\udba8삪쒬솮횰鎲횴\ud8b6\uddb8\udeba춼펾듀꓂ꇈꋊ뻌믎뻐ꇒ곔ﻖ律꣚뗜뻞跠迢엤触蛨鿪췬跮铰폲鯴苶闸韺폼", a_));
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0004D8AC File Offset: 0x0004BAAC
		private bool a(global::Motorola.CommonCPS.Server.EntityModel.Radio A_0)
		{
			short num = (short)2002321408;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7F;
				}
				global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
				global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug2;
				for (;;)
				{
					IL_28:
					global::System.Guid? guid;
					global::System.Guid? guid2;
					bool flag;
					global::System.Guid? guid3;
					global::System.Guid? guid4;
					global::System.Guid? guid5;
					global::System.Guid? guid6;
					switch (num2)
					{
					case 0:
						flag = (guid.GetValueOrDefault() == guid2.GetValueOrDefault());
						goto IL_2E4;
					case 1:
						num = (short)1764163602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (guid3 == null)
						{
							num = (short)470876166;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1125515274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1784152065;
						if (num != 0)
						{
						}
						num = (short)894107659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_20F;
					case 5:
						num = (short)1905721346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_12F;
					case 7:
						if (apxcodeplug == null)
						{
							num = (short)318636051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)630390800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						guid4 = apxcodeplug2.LanguagePackUuid;
						goto IL_134;
					case 9:
						if (guid != null != (guid2 != null))
						{
							num = (short)1185349633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)753401871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (guid5 != null)
						{
							num = (short)1376649220;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 11:
						flag = true;
						goto IL_2E4;
					case 12:
						guid = null;
						goto IL_2A8;
					case 13:
						guid6 = guid;
						goto IL_306;
					case 14:
						if (apxcodeplug2 == null)
						{
							num = (short)113901580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)31129608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (guid == null)
						{
							num = (short)806486019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)119996416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						guid6 = apxcodeplug.LanguagePackUuid;
						goto IL_306;
					case 17:
						guid4 = guid;
						goto IL_134;
					case 18:
						flag = false;
						goto IL_2E4;
					case 19:
					{
						guid = null;
						num = (short)842989568;
						short num3 = num;
						num = (short)986578957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_7F;
					IL_134:
					guid3 = guid4;
					guid = guid5;
					guid2 = guid3;
					num = (short)345555515;
					short num4 = num;
					num = (short)808370747;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_2A8:
						num = (short)1881669649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					default:
						num = (short)1106509824;
						if (num != 0)
						{
						}
						num = (short)1957363721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_2E4:
					if (!flag)
					{
						num = (short)599326725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_306:
					guid5 = guid6;
					num = (short)1251344398;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12F:
				return true;
				IL_20F:
				return apxcodeplug.ASTROLanguagePack.LpID == apxcodeplug2.ASTROLanguagePack.LpID;
				IL_7F:
				apxcodeplug = (A_0.CurrentCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
				apxcodeplug2 = (A_0.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
				num = (short)412942343;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0004DCB4 File Offset: 0x0004BEB4
		private bool a(byte[] A_0, int A_1, int A_2)
		{
			short num = (short)726073344;
			short num2 = num;
			bool result = false;
			bool result2;
			try
			{
				num = (short)881917952;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_6B;
						}
						continue;
					case 1:
						result = (((int)A_0[A_1] & 1 << A_2) != 0);
						num = (short)1580072965;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_146;
					case 3:
						if (A_0.Length > 4)
						{
							num = (short)1045037057;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12F;
					case 4:
					{
						num = (short)1813167345;
						short num4 = num;
						num = (short)1841675505;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_12F;
						default:
							num = (short)399638528;
							if (num != 0)
							{
							}
							num = (short)1317863427;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						goto IL_12F;
					}
					IL_6B:
					if (A_0 != null)
					{
						num = (short)8585220;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_12F:
					num = (short)370606082;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_146:
				return result;
			}
			catch
			{
				result2 = false;
			}
			num = (short)392691713;
			if (num != 0)
			{
			}
			return result2;
		}

		// Token: 0x04000087 RID: 135
		private global::System.Collections.ObjectModel.Collection<global::ASK.Interface.ISystemKeyData> a;

		// Token: 0x04000088 RID: 136
		private bool? b;
	}
}
