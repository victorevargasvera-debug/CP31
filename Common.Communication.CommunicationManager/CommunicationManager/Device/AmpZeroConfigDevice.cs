using System;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager.Device
{
	// Token: 0x0200003A RID: 58
	public class AmpZeroConfigDevice : global::Motorola.Common.Communication.CommunicationManager.MotoDevice
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00019460 File Offset: 0x00017660
		public AmpZeroConfigDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile radioProfile, global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory sequenceManagerFactory, global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory communicationPipeFactory) : base(deviceInfo, radioProfile, sequenceManagerFactory, communicationManager, communicationPipeFactory)
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0001947C File Offset: 0x0001767C
		public override void Prefetch()
		{
			int a_ = 0;
			short num = (short)1216675846;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo ampDeviceInfo;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1719533569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (this.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.None)
					{
						num = (short)1573847045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6F;
				case 2:
				{
					num = (short)880443035;
					short num3 = num;
					num = (short)217480859;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num = (short)1389690881;
						if (num != 0)
						{
						}
						num = (short)1752236032;
						if (num != 0)
						{
						}
						num = (short)2147221504;
						short num4 = num;
						if (ampDeviceInfo == null)
						{
							num = (short)1898971139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C9;
					}
					}
					break;
				}
				case 3:
					goto IL_14F;
				case 4:
					goto IL_6F;
				case 5:
					goto IL_151;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				}
				IL_4A:
				if (this.radioState != global::Motorola.Common.Communication.CommonUtil.RadioState.Attached)
				{
					num = (short)506593280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_151;
				IL_6F:
				this.InitDeviceParams();
				ampDeviceInfo = (this.DeviceInfo as global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo);
				num = (short)451149826;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_151:
				base.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.InitializingDevice);
				this.a();
				num = (short)1429340164;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_14F:
			throw new global::System.InvalidOperationException(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ᑔ㩖⥘Ś㡜ⵞ๠⁢੤०ཨɪ੬⭮ᑰղᱴᑶᱸ孺ၼ੾ꖄꮊﲎ떔ﺖ뮚ﺜ쾠힢삤\udfa6\udda8讪슬즮醰馸闀ꇄꋆ뿈ꋊ껌꫎￐", a_));
			IL_1C9:
			ampDeviceInfo.SerialNumber = this.a(ampDeviceInfo);
			base.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Ready);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00019668 File Offset: 0x00017868
		private string a(global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo A_0)
		{
			int a_ = 16;
			string pskId = this.GetPskId();
			if (pskId != global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("⑤㝦ㅨ㑪⥬⩮㝰⍲♴㱶䡸", a_))
			{
				short num;
				for (;;)
				{
					num = (short)1668808704;
					short num2 = num;
					num = (short)1554460803;
					short num3 = num;
					num = (short)1126707331;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_8A;
					}
				}
				IL_8A:
				num = (short)1066795008;
				if (num != 0)
				{
				}
				num = (short)2052587521;
				if (num != 0)
				{
				}
				return pskId;
			}
			global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe = this.CommunicationPipeFactory.CreateCommunicationPipe(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read, new global::Motorola.Common.Communication.CommonUtil.SessionParameter(0, false, global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("⍤彦偨剪ⱬ⵮㉰㉲䍴䕶䭸䍺䡼㱾얀몂떄놆뮈벊뢌쮎풐ꊒ꒔ꊖꪘ궚ꦜ\udd9e閠関", a_)));
			communicationPipe.OpenPort(-1);
			string result = new global::Motorola.Common.Communication.AmpApSequenceManager(new global::Motorola.Common.Communication.AmpHttpMessageExecutor(communicationPipe, A_0.ConnectionInfo.Location, A_0.ConnectionInfo.UniqueAddress), null).ReadSerialNumber();
			communicationPipe.ClosePort();
			return result;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00019798 File Offset: 0x00017998
		private void a()
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			global::System.DateTime now;
			global::System.TimeSpan t;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_E9;
				case 1:
					if (!(global::System.DateTime.Now - now <= t))
					{
						num2 = (short)417464320;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1728184322;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					try
					{
						num2 = (short)462094339;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_1E0;
							case 1:
								for (;;)
								{
									base.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Connecting);
									num2 = (short)497402165;
									short num3 = num2;
									num2 = (short)1482932533;
									switch ((num3 == num2) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_1B2;
									}
								}
								IL_1B2:
								num2 = (short)520159232;
								if (num2 != 0)
								{
								}
								num2 = (short)275709952;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_204;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_14F;
								}
								continue;
							}
							IL_14F:
							if (this.RetrieveIPAddress(ref this._radioProfile))
							{
								num2 = (short)1035468801;
								num = (int)((global::System.IntPtr)num2);
							}
							else
							{
								global::System.Threading.Thread.Sleep(500);
								num2 = (short)2033713154;
								num = (int)((global::System.IntPtr)num2);
							}
						}
						IL_1E0:
						return;
						IL_204:
						goto IL_A8;
					}
					catch (global::System.Exception ex)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ݔᥖᵘቚ๜罞╠٢፤๦੨๪䵬䉮兰㙲ݴնᙸॺ嵼ᙾꎂ힄ﶈ力떔\ude96즘뮚\udc9cﮞ얠톢삤풦\udaa8讪횬龮첰鎲鮴", a_), new object[]
						{
							ex.Message
						});
						goto IL_A8;
					}
					return;
				case 3:
					goto IL_A8;
				}
				goto IL_29;
				IL_A8:
				num2 = (short)1320812545;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_E9:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ᙔ㡖ⱘ㝚㥜罞འౢᅤ䝦᭨๪ᥬᵮᑰᩲʹቶ奸⥺ᱼ᭾ꖄ캆麗ꮊ첌", a_));
			IL_29:
			num2 = (short)887881729;
			if (num2 != 0)
			{
			}
			t = global::System.TimeSpan.FromSeconds(60.0);
			now = global::System.DateTime.Now;
			num2 = (short)218234880;
			short num4 = num2;
			num2 = (short)1587806211;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000199EC File Offset: 0x00017BEC
		public override ushort OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			short num = (short)437017622;
			short num2 = num;
			num = (short)228350998;
			switch (num2 == num)
			{
			}
			num = (short)661913601;
			if (num != 0)
			{
			}
			num = (short)50855936;
			short num3 = num;
			num = (short)313589760;
			if (num != 0)
			{
			}
			base.RefreshIPAddress();
			return base.OpenSession(operationType, sessionParameter);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00019AA0 File Offset: 0x00017CA0
		protected override bool RetrieveIPAddress(ref global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile radioProfile)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile ldtradioProfile;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1190658049;
					if (num2 != 0)
					{
					}
					if (ldtradioProfile.ConnectMode == global::Motorola.Common.Communication.DeviceDiscovery.LDTConnectMode.WIFI)
					{
						num2 = (short)1068105730;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_130;
				case 1:
				{
					num2 = (short)135655150;
					short num3 = num2;
					num2 = (short)563932910;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)582549504;
						if (num2 != 0)
						{
						}
						break;
					}
					num2 = (short)1860567040;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					return true;
				case 3:
					if (ldtradioProfile != null)
					{
						num2 = (short)1282146304;
						short num4 = num2;
						num2 = (short)1669988353;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_130;
				}
				goto IL_20;
			}
			return true;
			IL_130:
			return global::Motorola.Common.Communication.DeviceDiscovery.RNDISDetector.RetreiveDeviceIPAddress(ref this._radioProfile);
			IL_20:
			ldtradioProfile = (radioProfile as global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile);
			num2 = (short)819593219;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00019BE8 File Offset: 0x00017DE8
		public override void CloseSession(bool pendingDeploy)
		{
			short num = (short)1503395840;
			short num2 = num;
			base.ValidateSession();
			try
			{
				num = (short)560136200;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.CommunicationManager.RemoveDevice(this.DeviceInfo.RadioID);
						global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector>.Instance().ClearDevice(this._radioProfile);
						num = (short)784793605;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!pendingDeploy)
						{
							num = (short)1552744448;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A8;
					case 2:
						num = (short)1718747137;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						base.SequenceManager.CloseSession(base.ActiveSession.ID, base.ActiveSession.OperationType, pendingDeploy);
						num = (short)610992132;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)1814068532;
						short num4 = num;
						num = (short)839679284;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1C7;
						default:
							num = (short)7667712;
							if (num != 0)
							{
							}
							goto IL_1E4;
						}
						break;
					}
					case 5:
						goto IL_1A8;
					case 6:
						if (base.ActiveSession != null)
						{
							goto IL_1C7;
						}
						goto IL_1E4;
					case 7:
						goto IL_1FC;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					}
					IL_7D:
					if (this.DeviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI)
					{
						num = (short)1489567746;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1A8:
					num = (short)55508998;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C7:
					num = (short)850460675;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E4:
					num = (short)1419968519;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1FC:;
			}
			finally
			{
				num = (short)1114898433;
				if (num != 0)
				{
				}
				base.DisposeSession();
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00019E40 File Offset: 0x00018040
		public override void InitDeviceParams()
		{
			int a_ = 3;
			short num = (short)1518338052;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.DeviceInfo.ConnectionInfo != null)
					{
						num = (short)1746075653;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_278;
				case 1:
				{
					num = (short)1332150272;
					short num3 = num;
					num = (short)547106594;
					short num4 = num;
					num = (short)639971106;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_111;
					default:
						num = (short)699006976;
						if (num != 0)
						{
						}
						connectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI;
						connectionInfo.Location = this._radioProfile.PortName;
						num = (short)783613958;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_111;
				case 3:
					if (this._radioProfile.PID == global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("བྷ㍙ᩛ㝝㽟⍡⥣㙥", a_))
					{
						num = (short)923533313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					connectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter;
					connectionInfo.Location = global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("恗橙楛浝", a_);
					num = (short)453967873;
					if (num != 0)
					{
					}
					num = (short)1289158663;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_4E;
					}
					continue;
				case 5:
					connectionInfo.SessionID = this.DeviceInfo.ConnectionInfo.SessionID;
					num = (short)1281163266;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_67;
				case 7:
					goto IL_67;
				}
				goto IL_4E;
				IL_67:
				num = (short)2000355328;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4E:
				global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = this.DeviceInfo;
				string serialNumber;
				if ((serialNumber = this._radioProfile.RadioSerialNumber) == null)
				{
					serialNumber = this._radioProfile.PhysicalLocation;
				}
				deviceInfo.SerialNumber = serialNumber;
				connectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo
				{
					IsTlsPskCompatible = true,
					UniqueAddress = this._radioProfile.IPAddress,
					DeviceInstance = this._radioProfile.DeviceInstanceID
				};
				num = (short)319750147;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_111:
			IL_278:
			this.DeviceInfo.ConnectionInfo = connectionInfo;
		}
	}
}
