using System;
using System.Text;
using Motorola.Common.Communication.AmpConfigPackage;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000B RID: 11
	public class AmpBpSequenceManager : global::Motorola.Common.Communication.ISequenceManager, global::Motorola.Common.Communication.IAmpProcessorSwitch
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00007114 File Offset: 0x00005314
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000071C4 File Offset: 0x000053C4
		public global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator
		{
			get
			{
				short num = (short)251854848;
				short num2 = num;
				num = (short)1302641160;
				short num3 = num;
				num = (short)2044901896;
				switch (num3 == num)
				{
				}
				num = (short)1154547713;
				if (num != 0)
				{
				}
				num = (short)610402304;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)705953792;
				short num2 = num;
				num = (short)1371632066;
				short num3 = num;
				num = (short)743076290;
				switch (num3 == num)
				{
				}
				num = (short)1345847296;
				if (num != 0)
				{
				}
				num = (short)2109145089;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00007274 File Offset: 0x00005474
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00007320 File Offset: 0x00005520
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ExtendedDeviceInfo
		{
			get
			{
				short num = (short)500301824;
				short num2 = num;
				num = (short)494954917;
				short num3 = num;
				num = (short)1393256869;
				switch (num3 == num)
				{
				}
				num = (short)1570963457;
				if (num != 0)
				{
				}
				num = (short)1129512960;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)530710528;
				short num2 = num;
				num = (short)1984478987;
				short num3 = num;
				num = (short)1514389259;
				switch (num3 == num)
				{
				}
				num = (short)2125856769;
				if (num != 0)
				{
				}
				num = (short)1500708864;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000073D0 File Offset: 0x000055D0
		public AmpBpSequenceManager(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper)
		{
			this.b = rcmpWrapper;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00007404 File Offset: 0x00005604
		public void CloseSession(ushort sessionId, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			short num = (short)328663040;
			short num2 = num;
			num = (short)411077636;
			short num3 = num;
			num = (short)1927515140;
			switch (num3 == num)
			{
			}
			num = (short)1575813120;
			if (num != 0)
			{
			}
			num = (short)1686306817;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000074AC File Offset: 0x000056AC
		public void OpenSession(ushort sessionId, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			short num = (short)2052063232;
			short num2 = num;
			num = (short)1954397919;
			short num3 = num;
			num = (short)134069983;
			switch (num3 == num)
			{
			}
			num = (short)371458049;
			if (num != 0)
			{
			}
			num = (short)146866176;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00007558 File Offset: 0x00005758
		public global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionId)
		{
			short num = (short)771555328;
			short num2 = num;
			num = (short)1536251033;
			short num3 = num;
			num = (short)2001032345;
			switch (num3 == num)
			{
			}
			num = (short)1713045504;
			if (num != 0)
			{
			}
			num = (short)1797783553;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00007604 File Offset: 0x00005804
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo()
		{
			short num = (short)878379008;
			short num2 = num;
			num = (short)1342200976;
			short num3 = num;
			num = (short)897211536;
			switch (num3 == num)
			{
			}
			num = (short)205651969;
			if (num != 0)
			{
			}
			num = (short)935460864;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.AmpBpSequenceManager.a(this.a());
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000076B8 File Offset: 0x000058B8
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			short num = (short)530513920;
			short num2 = num;
			num = (short)172687361;
			if (num != 0)
			{
			}
			num = (short)874884057;
			short num3 = num;
			num = (short)737520601;
			switch (num3 == num)
			{
			}
			num = (short)1369964544;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00007768 File Offset: 0x00005968
		public bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			short num = (short)1751711744;
			short num2 = num;
			num = (short)1218419802;
			short num3 = num;
			num = (short)672701530;
			switch (num3 == num)
			{
			}
			num = (short)693633025;
			if (num != 0)
			{
			}
			num = (short)697958400;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00007818 File Offset: 0x00005A18
		public global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionId, string pcrNewPassword, bool hostedDepotOperation, int? userDefersAllowed = null)
		{
			short num = (short)988545024;
			short num2 = num;
			num = (short)316747072;
			short num3 = num;
			num = (short)1195060544;
			switch (num3 == num)
			{
			}
			num = (short)2032271361;
			if (num != 0)
			{
			}
			num = (short)272564224;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000078C8 File Offset: 0x00005AC8
		public void SwitchDeviceToAp()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.Common.Communication.XcmpUsbRouteControl xcmpUsbRouteControl;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_E7;
				case 1:
				{
					if (xcmpUsbRouteControl.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						goto IL_129;
					}
					num2 = (short)1942391895;
					short num3 = num2;
					num2 = (short)329092183;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_129;
					default:
						num2 = (short)692781056;
						if (num2 != 0)
						{
						}
						num2 = (short)839778304;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					try
					{
						this.b.SendAndReceiveMessage(xcmpUsbRouteControl);
						goto IL_64;
					}
					catch (global::Motorola.Common.CustomException.CommonException ex) when (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure)
					{
						goto IL_129;
					}
					goto IL_11E;
					IL_64:
					num2 = (short)1835728897;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_E7:
			IL_11E:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerReadBasicDeviceInfoFailure);
			IL_129:
			num2 = (short)1395261440;
			short num4 = num2;
			return;
			IL_1C:
			num2 = (short)1803681793;
			if (num2 != 0)
			{
			}
			xcmpUsbRouteControl = new global::Motorola.Common.Communication.XcmpUsbRouteControl(global::Motorola.Common.Communication.UsbRouteControlFunction.SetApplicationProcessorRoute);
			num2 = (short)1974730754;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00007A38 File Offset: 0x00005C38
		private global::Motorola.Common.Communication.RadioParams a()
		{
			short num = (short)1821704192;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5E;
				}
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation2;
				global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation3;
				global::Motorola.Common.Communication.Rcmp.RcmpReadWriteModelNumber rcmpReadWriteModelNumber;
				global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber;
				global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber2;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						num = (short)2020526587;
						short num3 = num;
						num = (short)1585957371;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_277;
						default:
							num = (short)655032320;
							if (num != 0)
							{
							}
							num = (short)1992228868;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						num = (short)666304513;
						if (num != 0)
						{
						}
						num = (short)1397948418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (rcmpVersionInformation.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1154809861;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_279;
					case 3:
						if (rcmpVersionInformation2.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)701038602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_301;
					case 4:
						if (rcmpVersionInformation3.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)610271233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_279;
					case 5:
						num = (short)1968242691;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (rcmpReadWriteModelNumber.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)594542592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_279;
					case 7:
						num = (short)2011758603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						num = (short)44236800;
						short num4 = num;
						if (rcmpReadWriteSerialNumber.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)121044999;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_279;
					}
					case 9:
						goto IL_277;
					case 10:
						goto IL_183;
					case 11:
						if (rcmpReadWriteSerialNumber2.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1433272329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_279;
					}
					goto IL_5E;
					IL_277:
					num = (short)1373175814;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_183:
				IL_279:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerReadBasicDeviceInfoFailure);
				IL_301:
				return new global::Motorola.Common.Communication.RadioParams
				{
					SerialNumber = rcmpReadWriteSerialNumber.SerialNumber,
					ModelNumber = rcmpReadWriteModelNumber.ModelNumber,
					ESerialNumber = rcmpReadWriteSerialNumber2.SerialRawBytes,
					CodeplugVersion = rcmpVersionInformation3.VersionInformation.TrimEnd(this.a),
					HostVersion = rcmpVersionInformation.VersionInformation.TrimEnd(this.a),
					PsdtVersion = rcmpVersionInformation2.VersionInformation.TrimEnd(this.a)
				};
				IL_5E:
				rcmpReadWriteSerialNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.ReadRadioSerialNumber, null);
				this.b.SendAndReceiveMessage(rcmpReadWriteSerialNumber);
				rcmpReadWriteModelNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteModelNumber(0, null);
				this.b.SendAndReceiveMessage(rcmpReadWriteModelNumber);
				rcmpReadWriteSerialNumber2 = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.ReadESN, null);
				this.b.SendAndReceiveMessage(rcmpReadWriteSerialNumber2);
				rcmpVersionInformation3 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.CodeplugVersion);
				this.b.SendAndReceiveMessage(rcmpVersionInformation3);
				rcmpVersionInformation = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.HostSoftwareVersion);
				this.b.SendAndReceiveMessage(rcmpVersionInformation);
				rcmpVersionInformation2 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.PsdtVersion);
				this.b.SendAndReceiveMessage(rcmpVersionInformation2);
				num = (short)1519714312;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00007DB8 File Offset: 0x00005FB8
		private static global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo a(global::Motorola.Common.Communication.RadioParams A_0)
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo ampDeviceInfo;
			global::System.Version version;
			global::System.Version value;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1050047679;
					short num3 = num2;
					num2 = (short)879064255;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11A;
					default:
						goto IL_18D;
					}
					break;
				}
				case 1:
					goto IL_10E;
				case 2:
					if (ampDeviceInfo.ConnectionInfo == null)
					{
						num2 = (short)1406402564;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10E;
				case 3:
					goto IL_215;
				case 4:
					ampDeviceInfo.ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo();
					num2 = (short)25559041;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (string.IsNullOrEmpty(A_0.PsdtVersion))
					{
						num2 = (short)1624506368;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					version = new global::System.Version(A_0.PsdtVersion.Remove(0, 1));
					value = new global::System.Version(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("쯺쯼퇾㘀㌂⬄㜆㤈", a_));
					num2 = (short)1154351107;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_31;
				IL_11A:
				num2 = (short)134348805;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_10E:
				ampDeviceInfo.ConnectionInfo.OtapConnectionType = global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType.NONE;
				goto IL_11A;
			}
			IL_18D:
			num2 = (short)562888704;
			if (num2 != 0)
			{
			}
			num2 = (short)351141889;
			if (num2 != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_InvalidPSDT);
			IL_215:
			ampDeviceInfo.RadioStorage = ((version.CompareTo(value) >= 0) ? global::Motorola.Common.Communication.CommonUtil.RadioStorage.FileSystem : global::Motorola.Common.Communication.CommonUtil.RadioStorage.Raw);
			ampDeviceInfo.RadioBBFSuiteVersion = string.Empty;
			ampDeviceInfo.PendingBBFSuiteVersion = string.Empty;
			ampDeviceInfo.CodeplugSessionID = 0;
			ampDeviceInfo.DownloadPercent = 0;
			return ampDeviceInfo;
			IL_31:
			num2 = (short)344260608;
			short num4 = num2;
			ampDeviceInfo = new global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo
			{
				Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AMPRadio,
				ProcessorType = global::ProcessorType.BP
			};
			ampDeviceInfo.CodeplugVersion = A_0.CodeplugVersion;
			ampDeviceInfo.ModelNumber = A_0.ModelNumber;
			ampDeviceInfo.SerialNumber = global::System.Text.Encoding.Default.GetString(global::System.Convert.FromBase64String(A_0.SerialNumber));
			ampDeviceInfo.SoftwareVersion = A_0.HostVersion;
			num2 = (short)625213442;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x04000013 RID: 19
		private readonly char[] a = new char[]
		{
			'\0',
			' ',
			'\r',
			'\n'
		};

		// Token: 0x04000014 RID: 20
		private readonly global::Motorola.Common.Communication.IMessageExecutor b;
	}
}
