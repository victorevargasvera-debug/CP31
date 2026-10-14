using System;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200002C RID: 44
	public class WiFiDevice : global::Motorola.Common.Communication.CommunicationManager.MotoDevice
	{
		// Token: 0x060000FB RID: 251 RVA: 0x00014CD8 File Offset: 0x00012ED8
		protected internal WiFiDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile profile, global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory sequenceManagerFactory, global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory communicationPipeFactory) : base(deviceInfo, profile, sequenceManagerFactory, communicationManager, communicationPipeFactory)
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00014D00 File Offset: 0x00012F00
		public override void Prefetch()
		{
			int a_ = 7;
			short num;
			try
			{
				num = (short)1271005184;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_3E;
						}
						continue;
					case 1:
						goto IL_7E;
					case 2:
						goto IL_9A;
					case 3:
						this.InitDeviceParams();
						num = (short)1228144641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3E:
					if (this.RetrieveIPAddress(ref this._radioProfile))
					{
						num = (short)1303052291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7E:
					base.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Ready);
					num = (short)1626472450;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_9A:;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("๛ၝ⑟⭡㝣䙥Ⱨཀྵᩫݭ፯᝱味孵塷㽹๻౽ꒃꪉ\udb8b횏ﮑ뒓욕ﾙ瀞ﮝ풟송첣蚥펧骩톫躭麯", a_), new object[]
				{
					ex.Message
				});
			}
			finally
			{
				for (;;)
				{
					try
					{
						this.CloseSession(true);
					}
					catch (global::System.Exception)
					{
					}
					num = (short)1158756694;
					short num3 = num;
					num = (short)842283350;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_10F;
					}
				}
				IL_10F:
				num = (short)264896512;
				if (num != 0)
				{
				}
			}
			num = (short)1331625985;
			if (num != 0)
			{
			}
			num = (short)287113216;
			short num4 = num;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00014EAC File Offset: 0x000130AC
		public override ushort OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			short num = (short)928519708;
			short num2 = num;
			num = (short)768153116;
			switch (num2 == num)
			{
			}
			num = (short)930021377;
			if (num != 0)
			{
			}
			num = (short)1852964864;
			short num3 = num;
			num = (short)427622400;
			if (num != 0)
			{
			}
			this.OperationType = operationType;
			return base.OpenSession(operationType, sessionParameter);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00014F68 File Offset: 0x00013168
		public override void CloseSession(bool pendingDeploy)
		{
			base.ValidateSession();
			short num;
			try
			{
				num = (short)1170341891;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_176;
					case 1:
						goto IL_13D;
					case 2:
						this.CommunicationManager.RemoveDevice(this.DeviceInfo.RadioID);
						global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector>.Instance().ClearDevice(this._radioProfile);
						num = (short)699596806;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_49;
						}
						continue;
					case 4:
						base.SequenceManager.CloseSession(base.ActiveSession.ID, base.ActiveSession.OperationType, pendingDeploy);
						num = (short)1828061189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_15E;
					case 6:
					{
						num = (short)1224462623;
						short num3 = num;
						num = (short)442421535;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_13D;
						default:
							num = (short)339869696;
							if (num != 0)
							{
							}
							goto IL_126;
						}
						break;
					}
					}
					IL_49:
					if (!pendingDeploy)
					{
						num = (short)2000748546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_126:
					num = (short)1798569985;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13D:
					if (base.ActiveSession != null)
					{
						num = (short)466288644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_15E:
					num = (short)1286733824;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_176:;
			}
			finally
			{
				num = (short)1021509633;
				if (num != 0)
				{
				}
				base.DisposeSession();
			}
			num = (short)716505088;
			short num4 = num;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00015160 File Offset: 0x00013360
		public override void InitDeviceParams()
		{
			short num = (short)1331101697;
			if (num != 0)
			{
			}
			num = (short)341724349;
			short num2 = num;
			num = (short)730156221;
			switch (num2 == num)
			{
			}
			num = (short)1063321600;
			short num3 = num;
			num = (short)45613056;
			if (num != 0)
			{
			}
			this.DeviceInfo.SerialNumber = base.RadioProfile.RadioSerialNumber;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00015220 File Offset: 0x00013420
		protected override bool RetrieveIPAddress(ref global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile _radioProfile)
		{
			short num = (short)1113472599;
			short num2 = num;
			num = (short)1983528535;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)408223745;
				if (num != 0)
				{
				}
				num = (short)89980928;
				if (num != 0)
				{
				}
				num = (short)466223104;
				int num3 = (int)num;
				switch (num3)
				{
				default:
				{
					object obj = this.a;
					bool flag = false;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_CF;
						}
						global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile ldtradioProfile;
						for (;;)
						{
							IL_A8:
							global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo;
							bool flag2;
							switch (num3)
							{
							case 0:
								if (this.DeviceInfo.ConnectionInfo != null)
								{
									num = (short)995622914;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_200;
							case 1:
								goto IL_228;
							case 2:
								connectionInfo.SessionID = this.DeviceInfo.ConnectionInfo.SessionID;
								num = (short)1130168325;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								num = (short)1974861831;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								if (ldtradioProfile != null)
								{
									num = (short)1400832003;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)906559494;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_200;
							case 6:
								flag2 = false;
								goto IL_17E;
							case 7:
								flag2 = ldtradioProfile.TlsPsk;
								goto IL_17E;
							}
							goto IL_CF;
							IL_17E:
							bool isTlsPskCompatible = flag2;
							connectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo
							{
								ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI,
								UniqueAddress = _radioProfile.IPAddress,
								DeviceInstance = _radioProfile.DeviceInstanceID,
								Location = _radioProfile.PortName,
								IsTlsPskCompatible = isTlsPskCompatible
							};
							num = (short)1713635328;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_200:
							this.DeviceInfo.ConnectionInfo = connectionInfo;
							result = true;
							num = (short)2162689;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_228:
						break;
						IL_CF:
						global::System.Threading.Monitor.Enter(obj, ref flag);
						ldtradioProfile = (_radioProfile as global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile);
						num = (short)1230372868;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_A8;
					}
					finally
					{
						num = (short)1166671872;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_25C;
								}
								continue;
							case 1:
								goto IL_292;
							case 2:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)1491533825;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_25C:
							if (!flag)
							{
								break;
							}
							num = (short)1012662274;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_292:;
					}
					break;
				}
				}
				break;
			}
			}
			num = (short)1563623424;
			short num4 = num;
			return result;
		}

		// Token: 0x04000038 RID: 56
		private readonly object a = new object();

		// Token: 0x04000039 RID: 57
		protected global::Motorola.Common.Communication.CommonUtil.RadioOperation OperationType;
	}
}
