using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.Communication.IshHandler;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.TLS.TlsPskForAstro;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200002A RID: 42
	public class MotoDevice : global::Motorola.Common.Communication.IMotoDevice, global::Motorola.Common.Communication.CommonUtil.IObservable, global::System.IDisposable
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0000CDE4 File Offset: 0x0000AFE4
		// (set) Token: 0x06000092 RID: 146 RVA: 0x0000CE94 File Offset: 0x0000B094
		protected global::Motorola.Common.Communication.CommunicationSession ActiveSession
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)284794248;
				short num2 = num;
				num = (short)1145609608;
				switch (num2 == num)
				{
				}
				num = (short)1991507968;
				short num3 = num;
				num = (short)940507136;
				if (num != 0)
				{
				}
				num = (short)766967809;
				if (num != 0)
				{
				}
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2015123190;
				short num2 = num;
				num = (short)933844726;
				switch (num2 == num)
				{
				}
				num = (short)1786773504;
				short num3 = num;
				num = (short)1435041793;
				if (num != 0)
				{
				}
				num = (short)1969618944;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0000CF48 File Offset: 0x0000B148
		// (set) Token: 0x06000094 RID: 148 RVA: 0x0000CFF8 File Offset: 0x0000B1F8
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ExtendedDeviceInfo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2048327681;
				if (num != 0)
				{
				}
				num = (short)820094198;
				short num2 = num;
				num = (short)892052726;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1545076736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)493879296;
				if (num != 0)
				{
				}
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1993080833;
				if (num != 0)
				{
				}
				num = (short)1383006208;
				short num2 = num;
				num = (short)700308015;
				short num3 = num;
				num = (short)937876015;
				switch (num3 == num)
				{
				}
				num = (short)1780219904;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000095 RID: 149 RVA: 0x0000D0A8 File Offset: 0x0000B2A8
		// (set) Token: 0x06000096 RID: 150 RVA: 0x0000D158 File Offset: 0x0000B358
		public virtual global::Motorola.Common.Communication.CommonUtil.DeviceInfo DeviceInfo
		{
			get
			{
				short num = (short)1026172802;
				short num2 = num;
				num = (short)1786324866;
				switch (num2 == num)
				{
				default:
				{
					num = (short)858652672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)897384449;
				if (num != 0)
				{
				}
				num = (short)131268608;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				short num = (short)2062785622;
				short num2 = num;
				num = (short)698457174;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1976696832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1888747521;
				if (num != 0)
				{
				}
				num = (short)254541824;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0000D20C File Offset: 0x0000B40C
		// (set) Token: 0x06000098 RID: 152 RVA: 0x0000D2BC File Offset: 0x0000B4BC
		public bool DifferentialWriteCapableRadio
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1776664858;
				short num2 = num;
				num = (short)1873854746;
				switch (num2 == num)
				{
				default:
				{
					num = (short)530448384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)73203713;
				if (num != 0)
				{
				}
				num = (short)1548877824;
				if (num != 0)
				{
				}
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)618986768;
				short num2 = num;
				num = (short)556203280;
				switch (num2 == num)
				{
				default:
				{
					num = (short)289931264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)722206721;
				if (num != 0)
				{
				}
				num = (short)1373503488;
				if (num != 0)
				{
				}
				this.k = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0000D36C File Offset: 0x0000B56C
		// (set) Token: 0x0600009A RID: 154 RVA: 0x0000D41C File Offset: 0x0000B61C
		public global::Motorola.Common.Communication.IshHandler.IOController IOController
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1155536263;
				short num2 = num;
				num = (short)89003399;
				switch (num2 == num)
				{
				default:
				{
					num = (short)207028224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)676855809;
				if (num != 0)
				{
				}
				num = (short)1123024896;
				if (num != 0)
				{
				}
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)881000449;
				if (num != 0)
				{
				}
				num = (short)876216320;
				short num2 = num;
				num = (short)936649710;
				short num3 = num;
				num = (short)768877550;
				switch (num3 == num)
				{
				}
				num = (short)895418368;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0000D4D0 File Offset: 0x0000B6D0
		// (set) Token: 0x0600009C RID: 156 RVA: 0x0000D584 File Offset: 0x0000B784
		public virtual bool Active
		{
			get
			{
				short num = (short)803214077;
				short num2 = num;
				num = (short)1807946493;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1407057920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)92864512;
				if (num != 0)
				{
				}
				num = (short)1661796353;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)210918042;
				short num2 = num;
				num = (short)853695130;
				switch (num2 == num)
				{
				default:
				{
					num = (short)393347072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)567083009;
				if (num != 0)
				{
				}
				num = (short)1280573440;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0000D634 File Offset: 0x0000B834
		public global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile RadioProfile
		{
			get
			{
				short num = (short)1609695233;
				if (num != 0)
				{
				}
				num = (short)1770061824;
				short num2 = num;
				num = (short)1479391948;
				short num3 = num;
				num = (short)1455536844;
				switch (num3 == num)
				{
				}
				num = (short)1850146816;
				if (num != 0)
				{
				}
				return this._radioProfile;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0000D794 File Offset: 0x0000B994
		// (set) Token: 0x0600009E RID: 158 RVA: 0x0000D6E4 File Offset: 0x0000B8E4
		public virtual global::Motorola.Common.Communication.CommonUtil.RadioState radioState
		{
			get
			{
				short num = (short)195293959;
				short num2 = num;
				num = (short)825553671;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1277100032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1852047361;
				if (num != 0)
				{
				}
				num = (short)1198129152;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1828368687;
				short num2 = num;
				num = (short)1836167471;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1547829248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1409220609;
				if (num != 0)
				{
				}
				num = (short)1522597888;
				if (num != 0)
				{
				}
				this.SetRadioState(value);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000D844 File Offset: 0x0000BA44
		protected void SetRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState newState)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					this.e = newState;
					num2 = (short)1509031937;
					if (num2 != 0)
					{
					}
					num2 = (short)1492713476;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_107;
				case 2:
					goto IL_B1;
				case 3:
				{
					num2 = (short)1465361221;
					short num3 = num2;
					num2 = (short)1993712453;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B1;
					default:
						goto IL_1B6;
					}
					break;
				}
				case 4:
					if (this.DeviceInfo != null)
					{
						num2 = (short)896925699;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_2D;
				IL_B1:
				if (this.e != global::Motorola.Common.Communication.CommonUtil.RadioState.Detached)
				{
					num2 = (short)497811456;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("൘⥚⑜㙞འѢ䕤፦٨䭪Ὤ੮ၰၲŴṶླྀ᩺ॼ᩾ꆀꖄ꾎ﺖ몚", a_), global::System.Array.Empty<object>());
					num2 = (short)578420737;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			IL_107:
			return;
			IL_1B6:
			num2 = (short)491782144;
			if (num2 != 0)
			{
			}
			this.DeviceInfo.RadioState = this.e;
			return;
			IL_2D:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("๘㉚⽜㩞ՠ䍢ⅤɦὨɪ๬੮兰⁲Ŵᙶ൸Ṻ嵼㱾권ﲒ랖ꮚ뾞햠첢薤\udca6風횪莬", a_), new object[]
			{
				this.e.ToString(),
				newState.ToString()
			});
			num2 = (short)214237184;
			short num4 = num2;
			num2 = (short)1811021826;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000DA24 File Offset: 0x0000BC24
		protected global::Motorola.Common.Communication.ISequenceManager SequenceManager
		{
			get
			{
				short num = (short)225018157;
				short num2 = num;
				num = (short)1766162733;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1418002432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1089142785;
				if (num != 0)
				{
				}
				num = (short)817364992;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.ActiveSession, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSessionNotOpened);
				return this.ActiveSession.SequenceManager;
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000DAE8 File Offset: 0x0000BCE8
		public MotoDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile radioProfile, global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory sequenceManagerFactory, global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory communicationPipeFactory) : this(sequenceManagerFactory, communicationManager, communicationPipeFactory)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(deviceInfo, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNullDeviceInfo);
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(deviceInfo.ConnectionInfo, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNullConnectionInfo);
			this.h = deviceInfo;
			this.DifferentialWriteCapableRadio = false;
			this.e = global::Motorola.Common.Communication.CommonUtil.RadioState.Attached;
			this._radioProfile = radioProfile;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000DB38 File Offset: 0x0000BD38
		public MotoDevice(global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory sequenceManagerFactory, global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory communicationPipeFactory)
		{
			this.SequenceManagerFactory = sequenceManagerFactory;
			this.CommunicationManager = communicationManager;
			this.CommunicationPipeFactory = communicationPipeFactory;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000DB8C File Offset: 0x0000BD8C
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)808531790;
				short num2 = num;
				num = (short)42088270;
				switch (num2 == num)
				{
				}
				num = (short)171638784;
				if (num != 0)
				{
				}
				this.a(false);
			}
			finally
			{
				num = (short)629669889;
				if (num != 0)
				{
				}
				base.Finalize();
			}
			num = (short)863109120;
			short num3 = num;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000DC54 File Offset: 0x0000BE54
		public virtual void InitDeviceParams()
		{
			short num = (short)703129803;
			short num2 = num;
			num = (short)1108338891;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1338310656;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1898708993;
			if (num != 0)
			{
			}
			num = (short)707264512;
			if (num != 0)
			{
			}
			this.ReadDeviceInfo();
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000DD04 File Offset: 0x0000BF04
		public virtual void InitDeviceExtendedDeviceParams()
		{
			short num = (short)2146925633;
			short num2 = num;
			num = (short)1576172609;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1756364800;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1812267009;
			if (num != 0)
			{
			}
			num = (short)752025600;
			if (num != 0)
			{
			}
			this.ReadExtendedDeviceInfo();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000DDB4 File Offset: 0x0000BFB4
		public virtual void Prefetch()
		{
			short num = (short)480182272;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1790377984;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_14;
				case 1:
				{
					num = (short)1170890404;
					short num4 = num;
					num = (short)975003300;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						goto IL_E3;
					}
					break;
				}
				case 2:
					this.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.InitializingDevice);
					global::System.Threading.Tasks.Task.Run(new global::System.Action(this.a));
					num = (short)81920001;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_5A;
				IL_14:
				switch (0)
				{
				case 0:
					IL_5A:
					if (this.radioState != global::Motorola.Common.Communication.CommonUtil.RadioState.Attached)
					{
						return;
					}
					num = (short)520617986;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_E3:
			num = (short)1189806081;
			if (num != 0)
			{
			}
			num = (short)1184432128;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000DEE4 File Offset: 0x0000C0E4
		private void e()
		{
			int a_ = 10;
			short num = (short)1530200075;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool flag;
				switch (num2)
				{
				case 0:
					if (flag)
					{
						num = (short)591396869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Threading.Thread.Sleep(500);
					num = (short)1488060428;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (this.radioState != global::Motorola.Common.Communication.CommonUtil.RadioState.InitializingDevice)
					{
						num = (short)1851392013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)603914243;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_1E8;
				case 3:
					try
					{
						num = (short)1827012609;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_E7;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_C3;
								}
								continue;
							case 2:
							{
								num = (short)1516369195;
								short num3 = num;
								num = (short)1577317675;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_E7;
								default:
									goto IL_15E;
								}
								break;
							}
							case 3:
								goto IL_104;
							}
							IL_C3:
							if (this.RetrieveIPAddress(ref this._radioProfile))
							{
								num = (short)236126208;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Threading.Thread.Sleep(500);
							num = (short)233832450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_E7:
							this.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Connecting);
							num = (short)1548484611;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_104:
						goto IL_3B5;
						IL_15E:
						num = (short)1561001984;
						if (num != 0)
						{
						}
						break;
					}
					catch (global::System.Exception ex)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("൞⽠❢Ɽ㑦䥨⽪࡬᥮ᡰၲၴ坶呸孺㡼ൾꞆ권\udd8e뾞薤춨쾪\udfac쪮슰삲閴첶覸욺鶼醾", a_), new object[]
						{
							ex.Message
						});
						global::System.Threading.Thread.Sleep(1000);
						break;
					}
					goto IL_1AF;
				case 4:
					if (this.CommunicationManager.DiscoveryWorkMode == global::Motorola.Common.Communication.CommonUtil.WorkMode.Active)
					{
						num = (short)894697479;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_228;
				case 5:
					goto IL_1E3;
				case 6:
					return;
				case 7:
				{
					num = (short)1192820736;
					short num4 = num;
					global::System.Threading.Thread.Sleep(1000);
					num = (short)533397512;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					goto IL_228;
				case 9:
					try
					{
						num = (short)932052993;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								this.OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create, null);
								this.InitDeviceParams();
								flag = true;
								num = (short)1044840451;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_2DE;
								}
								continue;
							case 2:
								goto IL_341;
							case 3:
								goto IL_32D;
							}
							IL_2DE:
							if (this.RetrieveIPAddress(ref this._radioProfile))
							{
								num = (short)1088421888;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_32D:
							num = (short)622264322;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_341:
						goto IL_1AF;
					}
					catch (global::System.Exception ex2)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("൞⽠❢Ɽ㑦䥨⽪࡬᥮ᡰၲၴ坶呸孺㡼ൾꞆ권욎ﾐ朗펖ﲘﲞ쒠쒤햦좨욪\udeac辮쪰莲좴鞶鞸", a_), new object[]
						{
							ex2.Message
						});
						global::System.Threading.Thread.Sleep(2000);
						goto IL_1AF;
					}
					finally
					{
						try
						{
							this.CloseSession(true);
						}
						catch (global::System.Exception)
						{
						}
						num = (short)443678721;
						if (num != 0)
						{
						}
					}
					goto IL_3B5;
				case 10:
					if (this.radioState != global::Motorola.Common.Communication.CommonUtil.RadioState.Connecting)
					{
						num = (short)1145569286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1205534729;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				case 12:
					goto IL_1E8;
				case 13:
					goto IL_3B5;
				}
				goto IL_66;
				IL_1AF:
				num = (short)1924136960;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E8:
				num = (short)332201994;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_228:
				flag = false;
				num = (short)1506017282;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_243:
				num = (short)978452481;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_66:
				goto IL_243;
				IL_3B5:
				num = (short)1119158276;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1E3:
			this.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Ready);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000E38C File Offset: 0x0000C58C
		public void ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState _radioState)
		{
			short num = (short)1623457793;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Ready)
					{
						num = (short)1770127362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 2:
				{
					num = (short)1571607428;
					short num3 = num;
					num = (short)808768388;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1388118017;
						if (num != 0)
						{
						}
						num = (short)212467712;
						if (num != 0)
						{
						}
						num = (short)1673986048;
						short num4 = num;
						this.g.Set();
						this.a(this);
						num = (short)1387593732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 3:
					this.DeviceInfo = new global::Motorola.Common.Communication.CommonUtil.DeviceInfo();
					num = (short)1963261957;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return;
				case 5:
					goto IL_8A;
				}
				IL_3C:
				if (this.DeviceInfo == null)
				{
					num = (short)262864899;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_8A:
				this.radioState = _radioState;
				num = (short)1558904832;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000E52C File Offset: 0x0000C72C
		protected virtual bool RetrieveIPAddress(ref global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile _radioProfile)
		{
			int a_ = 2;
			short num = (short)783613952;
			switch (num)
			{
			default:
			{
				num = (short)468582401;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string text;
					object obj;
					bool flag;
					switch (num2)
					{
					case 0:
						text = string.Empty;
						num = (short)554434569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_84;
						}
						continue;
					case 2:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_302;
							}
							bool result;
							for (;;)
							{
								IL_2DF:
								global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo;
								switch (num2)
								{
								case 0:
									if (this.a(_radioProfile.IPAddress))
									{
										num = (short)1585577988;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_48D;
								case 1:
									goto IL_488;
								case 2:
								{
									num = (short)729295263;
									short num3 = num;
									num = (short)2092902815;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_48D;
									default:
										num = (short)1867186176;
										if (num != 0)
										{
										}
										connectionInfo.SessionID = this.DeviceInfo.ConnectionInfo.SessionID;
										connectionInfo.IsTlsPskCompatible = this.DeviceInfo.ConnectionInfo.IsTlsPskCompatible;
										connectionInfo.Location = this.DeviceInfo.ConnectionInfo.Location;
										num = (short)1632763909;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									if (this.DeviceInfo.ConnectionInfo != null)
									{
										num = (short)620101634;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_460;
								case 4:
									connectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo();
									connectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter;
									connectionInfo.UniqueAddress = _radioProfile.IPAddress;
									connectionInfo.DeviceInstance = _radioProfile.DeviceInstanceID;
									num = (short)55246851;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_460;
								case 6:
									goto IL_4A8;
								}
								goto IL_302;
								IL_460:
								this.DeviceInfo.ConnectionInfo = connectionInfo;
								result = true;
								num = (short)907542529;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_48D:
								result = false;
								num = (short)753926150;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_488:
							IL_4A8:
							return result;
							IL_302:
							global::System.Threading.Monitor.Enter(obj, ref flag);
							num = (short)176422912;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_2DF;
						}
						finally
						{
							num = (short)1432879105;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									global::System.Threading.Monitor.Exit(obj);
									num = (short)108855298;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_4E0;
									}
									continue;
								case 2:
									goto IL_515;
								}
								IL_4E0:
								if (!flag)
								{
									break;
								}
								num = (short)558432256;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_515:;
						}
						goto IL_518;
					case 3:
					{
						num = (short)1136852992;
						short num4 = num;
						num = (short)673841163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (this.DeviceInfo.ConnectionInfo != null)
						{
							num = (short)808321027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A9;
					case 5:
						goto IL_A9;
					case 6:
						goto IL_518;
					case 7:
						num = (short)382795780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)954990593;
						if (num != 0)
						{
						}
						if (this.DeviceInfo.ConnectionInfo != null)
						{
							num = (short)81723402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 9:
						if (this.DeviceInfo.ConnectionInfo.UniqueAddress != null)
						{
							num = (short)670171142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_230;
					case 10:
						this.DeviceInfo.ConnectionInfo.UniqueAddress = "";
						num = (short)1534197772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (this.DeviceInfo.ConnectionInfo.UniqueAddress != _radioProfile.IPAddress)
						{
							num = (short)697106432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A9;
					case 12:
						return false;
					case 13:
						goto IL_230;
					}
					IL_84:
					if (global::Motorola.Common.Communication.DeviceDiscovery.RNDISDetector.RetreiveDeviceIPAddress(ref _radioProfile))
					{
						num = (short)857669639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)633667592;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A9:
					obj = global::Motorola.Common.Communication.CommunicationManager.MotoDevice.d;
					flag = false;
					num = (short)1028718594;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_230:
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ၖ㱘⽚絜ㅞѠᑢ䕤⹦㥨䭪ⱬ୮ᕰŲၴѶ੸孺ټ佾ﲀ뺂뮄ﲆ뢈권ﾐ뎒톔ﺜ爵膠\ud8a2鞤\udaa6螨", a_), new object[]
					{
						text,
						_radioProfile.IPAddress,
						_radioProfile.RadioIdString
					});
					num = (short)90046469;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_518:
					text = this.DeviceInfo.ConnectionInfo.UniqueAddress;
					num = (short)2074476557;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
			}
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000EAA0 File Offset: 0x0000CCA0
		public bool WaitForReady(int timeout)
		{
			short num = (short)223805441;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1823997953;
					if (num != 0)
					{
					}
					if (this.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Busy)
					{
						num = (short)1830879239;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1025507332;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 2:
				{
					num = (short)2106621417;
					short num3 = num;
					num = (short)1542225385;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num = (short)1850540032;
						if (num != 0)
						{
						}
						if (this.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Detached)
						{
							num = (short)1357709318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C9;
					}
					break;
				}
				case 3:
					num = (short)878444546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (this.radioState != global::Motorola.Common.Communication.CommonUtil.RadioState.Removing)
					{
						num = (short)1817706499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
					num = (short)1057685504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_11E;
				case 7:
					goto IL_1C3;
				}
				IL_46:
				num = (short)1722613760;
				short num4 = num;
				if (this.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Ready)
				{
					return true;
				}
				num = (short)386072581;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_11E:
			return false;
			IL_1C3:
			return true;
			IL_1C9:
			return this.g.WaitOne(timeout);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000EC84 File Offset: 0x0000CE84
		public void Register(global::Motorola.Common.Communication.CommonUtil.IObserver anObserver)
		{
			short num = (short)1488837280;
			short num2 = num;
			num = (short)1826740896;
			switch (num2 == num)
			{
			}
			num = (short)628883456;
			short num3 = num;
			num = (short)160956416;
			if (num != 0)
			{
			}
			num = (short)1481768961;
			if (num != 0)
			{
			}
			this.f.Add(anObserver);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000ED38 File Offset: 0x0000CF38
		public void UnRegister(global::Motorola.Common.Communication.CommonUtil.IObserver anObserver)
		{
			short num = (short)1792136921;
			short num2 = num;
			num = (short)617797337;
			switch (num2 == num)
			{
			}
			num = (short)657915904;
			short num3 = num;
			num = (short)751697921;
			if (num != 0)
			{
			}
			num = (short)1829044224;
			if (num != 0)
			{
			}
			this.f.Remove(anObserver);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000EDEC File Offset: 0x0000CFEC
		private void a(object A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			int num2;
			short num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_17B;
				case 1:
				{
					if (num2 < 0)
					{
						goto IL_199;
					}
					global::Motorola.Common.Communication.CommonUtil.IObserver observer = this.f[num2];
					num3 = (short)785448963;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 2:
				{
					global::Motorola.Common.Communication.CommonUtil.IObserver observer;
					observer.Notify(A_0);
					num3 = (short)2084044805;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 3:
				{
					global::Motorola.Common.Communication.CommonUtil.IObserver observer;
					if (observer != null)
					{
						num3 = (short)842334209;
						if (num3 != 0)
						{
						}
						num3 = (short)1954217986;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_7D;
				}
				case 4:
				{
					num3 = (short)179237648;
					short num4 = num3;
					num3 = (short)1952641808;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_199;
					default:
						num3 = (short)1920598016;
						if (num3 != 0)
						{
						}
						goto IL_17B;
					}
					break;
				}
				case 5:
					goto IL_7D;
				case 6:
					return;
				}
				goto IL_2C;
				IL_7D:
				num2--;
				num3 = (short)353042436;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_17B:
				num3 = (short)830275585;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_199:
				num3 = (short)1873805318;
				num = (int)((global::System.IntPtr)num3);
			}
			return;
			IL_2C:
			num2 = this.f.Count - 1;
			num3 = (short)2040987648;
			short num5 = num3;
			num3 = (short)1661599744;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000EFAC File Offset: 0x0000D1AC
		private bool a(string IPAddr)
		{
			int a_ = 0;
			short num;
			for (;;)
			{
				num = (short)1744830464;
				switch (num)
				{
				default:
				{
					bool result;
					using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>.Enumerator enumerator = this.CommunicationManager.DeviceInfoList.GetEnumerator())
					{
						num = (short)1154023432;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile rndisradioProfile;
							global::Motorola.Common.Communication.CommunicationManager.MotoDevice motoDevice;
							switch (num2)
							{
							case 0:
							{
								global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo;
								if (deviceInfo.ConnectionInfo != null)
								{
									num = (short)91488267;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								if (global::Motorola.Common.Communication.DeviceDiscovery.RNDISDetector.RetreiveDeviceIPAddress(ref rndisradioProfile))
								{
									num = (short)1731526659;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_326;
							case 2:
								num = (short)551157781;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								num = (short)351797257;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_34B;
							case 5:
								if (motoDevice.radioState != global::Motorola.Common.Communication.CommonUtil.RadioState.Ready)
								{
									num = (short)2136604684;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_350;
							case 6:
								goto IL_326;
							case 7:
							{
								global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo;
								if (deviceInfo.ConnectionInfo.UniqueAddress == IPAddr)
								{
									num = (short)851771407;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 8:
								switch (0)
								{
								case 0:
									goto IL_15B;
								}
								continue;
							case 9:
								if (IPAddr != rndisradioProfile.IPAddress)
								{
									num = (short)1174929427;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_326;
							case 10:
							{
								global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo;
								if (deviceInfo.RadioID != this.DeviceInfo.RadioID)
								{
									num = (short)144310286;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 11:
								num = (short)298254343;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 12:
								num = (short)1874722829;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 13:
								if (motoDevice.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Busy)
								{
									num = (short)821886996;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_326;
							case 14:
							{
								global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo;
								motoDevice = (this.CommunicationManager.GetDevice(deviceInfo.RadioID) as global::Motorola.Common.Communication.CommunicationManager.MotoDevice);
								num = (short)1884487696;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 15:
								num = (short)1329004554;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 16:
								if (motoDevice != null)
								{
									num = (short)554958866;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 17:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1198194690;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = enumerator.Current;
								num = (short)1675100160;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 18:
							{
								global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo;
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteWarning(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ፔ㡖ⱘ㕚㥜罞ՠᙢᕤ୦hࡪ౬᭮ᑰᝲ啴㹶⥸孺㱼᭾愈ꮊ뾎뎒杖練릘겜趠莢펤욦얨슪즬캮얰\udab2\udab4\ud9b6馸\uddba\udcbc횾귀ꛂꇄ", a_), new object[]
								{
									IPAddr,
									deviceInfo.RadioID
								});
								num = (short)2100101125;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 19:
							{
								global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo;
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteWarning(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("Ŕ㽖㱘筚㥜㩞ᝠ੢٤ɦ䥨ၪ嵬ቮ兰ͲᩴṶ᝸ེ๼彾ꖄ권ﾐ杖ﺚﺜ膠螦튨骪킬莮醰쒲\uddb4\udeb6\udab8펺鶼첾꧀곂냄ꯆ귈꿌꫎꣒꫖", a_), new object[]
								{
									deviceInfo.RadioID,
									IPAddr,
									rndisradioProfile.IPAddress
								});
								this.CommunicationManager.ReDetectDevice(deviceInfo.RadioID);
								num = (short)755499014;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 20:
								goto IL_350;
							case 21:
								goto IL_4F5;
							}
							IL_256:
							num = (short)1189806097;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_15B:
							goto IL_256;
							IL_326:
							global::System.Threading.Thread.Sleep(5000);
							result = false;
							num = (short)161873924;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_350:
							rndisradioProfile = new global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile();
							rndisradioProfile.NetCfgInstanceId = motoDevice.RadioProfile.NetCfgInstanceId;
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ٔ⍖㡘⥚⥜罞፠٢ͤᕦ౨ᡪլٮὰᑲ啴㹶⥸孺ᱼ᭾愈ꮊ뎒Ꞗ뮚난뾞\udaa0銢\ud8a4", a_), new object[]
							{
								IPAddr,
								rndisradioProfile.NetCfgInstanceId
							});
							num = (short)414187521;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_34B:
						return result;
						IL_4F5:
						goto IL_3C;
					}
					return result;
					IL_3C:
					num = (short)1375721198;
					short num3 = num;
					num = (short)1756813038;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_72;
					}
					break;
				}
				}
			}
			IL_72:
			num = (short)1287520257;
			if (num != 0)
			{
			}
			num = (short)658178048;
			if (num != 0)
			{
			}
			num = (short)1796538368;
			short num4 = num;
			return true;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000F4E0 File Offset: 0x0000D6E0
		protected internal void RefreshIPAddress()
		{
			int a_ = 12;
			short num = (short)529530881;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteWarning(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("㍠٢ᅤᕦh๪᭬੮兰㩲╴坶㡸ὺ᥼ൾꞆ떔ﾘ膠잢첤풦쪨쒪\udbac쪮쎰횲톴鞶춸펺\ud8bc龾돀ꋂꇄ껆ꛈ", a_), global::System.Array.Empty<object>());
					num = (short)1931411458;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_1E;
				case 2:
					return;
				}
				goto IL_3A;
				IL_1E:
				switch (0)
				{
				case 0:
				{
					IL_3A:
					num = (short)1853149209;
					short num3 = num;
					num = (short)1464848409;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E;
					case 1:
						break;
					default:
					{
						num = (short)1677131776;
						short num4 = num;
						break;
					}
					}
					num = (short)575078401;
					if (num != 0)
					{
					}
					num = (short)1739259904;
					if (num != 0)
					{
					}
					if (this.RetrieveIPAddress(ref this._radioProfile))
					{
						return;
					}
					num = (short)873070592;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000F624 File Offset: 0x0000D824
		public virtual ushort OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			int a_ = 8;
			short num = (short)1379336193;
			if (num != 0)
			{
			}
			num = (short)883425280;
			short num2 = num;
			ushort num3 = 0;
			object obj = this.a;
			bool flag = false;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_94;
				}
				int num4;
				for (;;)
				{
					IL_72:
					switch (num4)
					{
					case 0:
						if (this.ActiveSession != null)
						{
							num = (short)1135017988;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D4;
					case 1:
						try
						{
							this.CreateSession(num3, operationType, sessionParameter);
							this.d();
							return num3;
						}
						catch
						{
							if (this.DeviceInfo.ConnectionInfo.SessionID != 0)
							{
								num = (short)1017545481;
								short num5 = num;
								num = (short)1322484489;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1953693696;
									if (num != 0)
									{
									}
									if (this.DeviceInfo.ConnectionInfo.SessionID == num3)
									{
										goto IL_1A0;
									}
									break;
								}
							}
							global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator.Instance.ReturnID(num3);
							IL_1A0:
							throw;
						}
						goto IL_1A2;
					case 2:
						goto IL_D4;
					case 3:
						sessionParameter = new global::Motorola.Common.Communication.CommonUtil.SessionParameter(0, false, null);
						num = (short)371720198;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_1A2;
					case 5:
						if (sessionParameter == null)
						{
							num = (short)836763651;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C6;
					case 6:
						goto IL_1C6;
					}
					break;
					IL_D4:
					num = (short)1157169157;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A2:
					this.DisposeSession();
					num = (short)117964802;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C6:
					num3 = this.a(operationType, sessionParameter);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ቜ⽞Ѡൢ㙤ɦᩨᡪѬnὰ卲㙴ɶ୸ॺ᡼ᅾꎂ횄愈ﾐ뎒\udc94펖릘궜膠힤슦\udfa8슪슬\udaae슰鎲튶쪸좺풼킾꿀賄菆냊ﳌ닎￐", a_), new object[]
					{
						num3,
						sessionParameter.PreviousSessionID
					});
					num = (short)771358721;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_94:
				global::System.Threading.Monitor.Enter(obj, ref flag);
				num = (short)2006384640;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_72;
			}
			finally
			{
				num = (short)1137049601;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						global::System.Threading.Monitor.Exit(obj);
						num = (short)1759576066;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_273;
						}
						continue;
					case 2:
						goto IL_2A7;
					}
					IL_273:
					if (!flag)
					{
						break;
					}
					num = (short)1379139584;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_2A7:;
			}
			return num3;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000F910 File Offset: 0x0000DB10
		private ushort a(global::Motorola.Common.Communication.CommonUtil.RadioOperation A_0, global::Motorola.Common.Communication.CommonUtil.SessionParameter A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_87;
			}
			short num;
			int num3;
			ushort result;
			for (;;)
			{
				IL_0A:
				num = (short)1961295872;
				short num2 = num;
				ushort num5;
				ushort num6;
				switch (num3)
				{
				case 0:
					goto IL_31B;
				case 1:
				{
					num = (short)611778561;
					if (num != 0)
					{
					}
					num = (short)207381968;
					short num4 = num;
					num = (short)1624401360;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_31B;
					default:
						num = (short)701300736;
						if (num != 0)
						{
						}
						num5 = global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator.Instance.GenerateNewUnqiueID(A_1.PreviousSessionID, 2);
						goto IL_32D;
					}
					break;
				}
				case 2:
					if (this.DeviceInfo.ConnectionInfo.SessionID == A_1.PreviousSessionID)
					{
						num = (short)1470496781;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1630666752;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return result;
				case 4:
					num = (short)1925709831;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (this.DeviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio)
					{
						num = (short)466288644;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)200343562;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_15F;
				case 7:
					if (this.CommunicationManager.DiscoveryWorkMode == global::Motorola.Common.Communication.CommonUtil.WorkMode.Lazy)
					{
						num = (short)334233609;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)321388560;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					return result;
				case 9:
					result = 1;
					num = (short)1771241483;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (this.DeviceInfo.ConnectionInfo.SessionID != 0)
					{
						num = (short)413532177;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37F;
				case 11:
					return result;
				case 12:
					if (this.DeviceInfo.ConnectionInfo.SessionID == A_1.PreviousSessionID)
					{
						num = (short)395575302;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)229048335;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_37F;
				case 14:
					num = (short)1342177292;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					num5 = this.DeviceInfo.ConnectionInfo.SessionID;
					goto IL_32D;
				case 16:
					if (this.DeviceInfo.ConnectionInfo.SessionID != 0)
					{
						num = (short)684130318;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15F;
				case 17:
					num = (short)678821890;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					num6 = global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator.Instance.GenerateNewUnqiueID(A_1.PreviousSessionID, 1);
					goto IL_347;
				}
				goto IL_87;
				IL_15F:
				num = (short)980156417;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_32D:
				result = num5;
				num = (short)182124552;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_347:
				result = num6;
				num = (short)1900871683;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_31B:
				num6 = this.DeviceInfo.ConnectionInfo.SessionID;
				goto IL_347;
				IL_37F:
				num = (short)1744568338;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_87:
			result = 0;
			num = (short)605880325;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000FCC8 File Offset: 0x0000DEC8
		public virtual void CloseSession(bool pendingDeploy)
		{
			int a_ = 10;
			short num = (short)985976104;
			short num2 = num;
			num = (short)926076200;
			switch (num2 == num)
			{
			}
			num = (short)46989312;
			short num3 = num;
			num = (short)349372416;
			if (num != 0)
			{
			}
			num = (short)1484718081;
			if (num != 0)
			{
			}
			global::System.Diagnostics.Trace.TraceInformation(string.Format(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ў᩠卢ᡤ㩦㉨ၪ屬ቮⱰ⡲๴䕶Ѹ♺♼Ѿ늀ﺂ\ud884\udc86쪈ﲎ삒ﲠ\udea4鎦풨풮蒰캲鞶쾺\udcbc춾뗀ꛄꯆꛈ룊꓌ꇎ뛐ꛔ닖꫘꣚드냞迠췢", a_), new object[]
			{
				this.DeviceInfo.ConnectionInfo.ConnectionType,
				this.DeviceInfo.Family,
				this.DeviceInfo.SerialNumber,
				this.DeviceInfo.ModelNumber,
				this.DeviceInfo.SoftwareVersion,
				this.DeviceInfo.CodeplugVersion
			}));
			this.ValidateSession();
			this.b(pendingDeploy);
			global::System.Diagnostics.Trace.TraceInformation(string.Format(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ў᩠卢ᡤ㩦㉨ၪ屬ቮⱰ⡲๴䕶Ѹ♺♼Ѿ늀ﺂ\ud884\udc86쪈ﲎ삒ﲠ\udea4鎦풨풮蒰캲鞶쪸\udeba캼첾ꣀ곂ꯄ꫈ꟊꋌ볎듐럒ﯔ", a_), new object[]
			{
				this.DeviceInfo.ConnectionInfo.ConnectionType,
				this.DeviceInfo.Family,
				this.DeviceInfo.SerialNumber,
				this.DeviceInfo.ModelNumber,
				this.DeviceInfo.SoftwareVersion,
				this.DeviceInfo.CodeplugVersion
			}));
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000FE88 File Offset: 0x0000E088
		protected virtual void CreateSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe = this.CommunicationPipeFactory.CreateCommunicationPipe(this.DeviceInfo, operation, sessionParameter);
			short num;
			try
			{
				communicationPipe.OpenPort(-1);
				global::Motorola.Common.Communication.ISequenceManager sequenceManager = this.SequenceManagerFactory.CreateSequenceManager(this.DeviceInfo, operation, communicationPipe, sessionParameter);
				sequenceManager.OpenSession(sessionID, operation);
				this.ActiveSession = new global::Motorola.Common.Communication.CommunicationSession(sessionID, operation, communicationPipe, sequenceManager);
				this.DeviceInfo.ConnectionInfo.SessionID = sessionID;
			}
			catch
			{
				if (communicationPipe.IsOpen)
				{
					num = (short)560516788;
					short num2 = num;
					num = (short)1452265140;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)129695744;
						if (num != 0)
						{
						}
						communicationPipe.ClosePort();
						break;
					}
				}
				throw;
			}
			num = (short)227672064;
			short num3 = num;
			num = (short)1769996289;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000FFB4 File Offset: 0x0000E1B4
		protected void UpdateSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter, ushort sessionID)
		{
			int a_ = 3;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_31;
				}
				int num;
				global::Motorola.Common.Communication.ISequenceManager sequenceManager;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						goto IL_16D;
					case 1:
					{
						num2 = (short)1962905572;
						short num3 = num2;
						num2 = (short)347443172;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_16D;
						default:
							num2 = (short)340459520;
							if (num2 != 0)
							{
							}
							if ((sequenceManager as global::Motorola.Common.Communication.IDifferentialWritable).DifferentialWriteSupported(sessionID, operation))
							{
								num2 = (short)1145700354;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_16D;
						}
						break;
					}
					case 2:
						this.DifferentialWriteCapableRadio = true;
						this.InitDeviceExtendedDeviceParams();
						num2 = (short)1669332992;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						goto IL_1AF;
					case 4:
						if (sequenceManager is global::Motorola.Common.Communication.IDifferentialWritable)
						{
							num2 = (short)1117061125;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_16D;
					case 5:
						num2 = (short)1191837697;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_31;
					IL_16D:
					sequenceManager.OpenSession(this.ActiveSession.ID, operation);
					this.ActiveSession.SequenceManager = sequenceManager;
					this.ActiveSession.OperationType = operation;
					num2 = (short)1534263299;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_1AF:
				goto IL_1C4;
				IL_31:
				sequenceManager = this.SequenceManagerFactory.CreateSequenceManager(this.DeviceInfo, operation, this.ActiveSession.CommunicationPipe, sessionParameter);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("౗⍙ⱛ㭝䁟ൡɣ䙥⭧թūͭ⁯᭱ѳ፵塷ཹཻ᭽ꊁ慎ꪉﶏﾑ蓮ﶛ즟춡쪣蚥솧\ud9a9貫햭肯쾱骳", a_), new object[]
				{
					this.ActiveSession.CommunicationPipe
				});
				num2 = (short)1294860292;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			catch (global::System.Exception)
			{
				this.ActiveSession.CommunicationPipe.ClosePort();
				throw;
			}
			IL_1C4:
			num2 = (short)1747517441;
			if (num2 != 0)
			{
			}
			num2 = (short)684720128;
			short num4 = num2;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000101F0 File Offset: 0x0000E3F0
		private void b(bool A_0)
		{
			int a_ = 16;
			short num = (short)1066401802;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1869348871;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (!A_0)
					{
						num = (short)184549376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_42E;
				case 2:
					if (this.DeviceInfo.ConnectionInfo == null)
					{
						num = (short)656146440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.DeviceInfo.ConnectionInfo.SessionID = 0;
					num = (short)1226113025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1608450065;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (this.ActiveSession.OperationType != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
					{
						num = (short)657522707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_214;
				case 5:
				{
					num = (short)535479202;
					short num3 = num;
					num = (short)639812514;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_27E;
					default:
					{
						num = (short)1246298112;
						short num4 = num;
						num = (short)696451072;
						if (num != 0)
						{
						}
						num = (short)2013855753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 6:
					goto IL_117;
				case 7:
					if (this.DeviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap)
					{
						num = (short)768278531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_42E;
				case 8:
					return;
				case 9:
					if (this.DeviceInfo.ConnectionInfo != null)
					{
						num = (short)844038156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_81;
					}
					continue;
				case 11:
					try
					{
						try
						{
							this.SequenceManager.CloseSession(this.ActiveSession.ID, this.ActiveSession.OperationType, A_0);
						}
						finally
						{
							this.ActiveSession.CommunicationPipe.ClosePort();
						}
						return;
					}
					catch (global::System.Exception ex)
					{
						global::System.Diagnostics.Trace.TraceError(string.Concat(new string[]
						{
							string.Format(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("㹤ᱦ奨ᙪぬ㑮ੰ䉲ࡴ⩶≸z佼ɾ\udc80\ud882ﺄ뒆횊회첎﶐쪘ﺚ좠첢쮤益", a_), new object[]
							{
								this.DeviceInfo.ConnectionInfo.ConnectionType,
								this.DeviceInfo.Family,
								this.DeviceInfo.SerialNumber,
								this.DeviceInfo.ModelNumber
							}),
							global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("㹤", a_),
							this.DeviceInfo.SoftwareVersion,
							global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("㡤㱦", a_),
							this.DeviceInfo.CodeplugVersion,
							global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("㡤䝦ⱨ፪๬੮Űݲᱴᡶ᝸孺ၼ᩾놊권", a_),
							ex.Message
						}), new object[]
						{
							ex.StackTrace
						});
						throw ex;
					}
					finally
					{
						this.ActiveSession = null;
					}
					goto IL_42E;
				case 12:
					num = (short)1003094034;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (this.DeviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseLightRadio)
					{
						num = (short)1761738758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_42E;
				case 14:
					goto IL_27E;
				case 15:
					goto IL_214;
				case 16:
					global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator.Instance.ReturnID(this.DeviceInfo.ConnectionInfo.SessionID);
					this.DeviceInfo.ConnectionInfo.SessionID = 0;
					num = (short)194248724;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					if (this.DeviceInfo.Family != global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRadio)
					{
						num = (short)800325646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_117;
				case 18:
					if (this.DeviceInfo.ConnectionInfo.SessionID != 0)
					{
						num = (short)1829044240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 19:
					num = (short)196280321;
					if (num != 0)
					{
					}
					goto IL_42E;
				case 20:
					return;
				}
				IL_81:
				if (this.ActiveSession == null)
				{
					num = (short)558956549;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)554565634;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_117:
				num = (short)379846660;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_214:
				num = (short)1428422667;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_27E:
				num = (short)1669595149;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_42E:
				global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator.Instance.ReturnID(this.ActiveSession.ID);
				num = (short)1443430415;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00010780 File Offset: 0x0000E980
		protected void DisposeSession()
		{
			short num = (short)1706719251;
			short num2 = num;
			num = (short)1882814483;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_C4:
				goto IL_E0;
			default:
				num = (short)1299513344;
				if (num != 0)
				{
				}
				num = (short)551026690;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				IL_6B:
				num = (short)1999962113;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
					goto IL_C4;
				case 1:
					goto IL_10C;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_A4;
					}
					continue;
				}
				IL_A4:
				if (this.ActiveSession == null)
				{
					return;
				}
				num = (short)1174274048;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_10C:
			num = (short)1287716864;
			short num4 = num;
			try
			{
				this.ActiveSession.CommunicationPipe.ClosePort();
				return;
			}
			finally
			{
				this.ActiveSession = null;
			}
			IL_E0:
			global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator.Instance.ReturnID(this.ActiveSession.ID);
			num = (short)864092161;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_6B;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000108D8 File Offset: 0x0000EAD8
		public virtual void Init(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			short num = (short)242709016;
			short num2 = num;
			num = (short)1046639128;
			switch (num2 == num)
			{
			}
			num = (short)2094530560;
			short num3 = num;
			num = (short)486604800;
			if (num != 0)
			{
			}
			num = (short)809697281;
			if (num != 0)
			{
			}
			this.DeviceInfo.ConnectionInfo.SessionID = deviceInfo.ConnectionInfo.SessionID;
			this.ValidateSession();
			this.ActiveSession.SequenceManager.ProgressIndicator = progressIndicator;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000109B4 File Offset: 0x0000EBB4
		protected void ValidateSession()
		{
			short num = (short)1199569633;
			short num2 = num;
			num = (short)286063329;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_9D:
				global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.ActiveSession, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSessionNotOpened);
				global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsFalse(this.ActiveSession.ID == this.DeviceInfo.ConnectionInfo.SessionID, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSessionNotMatched);
				num = (short)60751873;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)56360960;
				if (num != 0)
				{
				}
				num = (short)1278214146;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_9D;
				case 1:
					goto IL_EA;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_7D;
					}
					continue;
				}
				IL_7D:
				if (this.ActiveSession == null)
				{
					return;
				}
				num = (short)841220096;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_EA:
			num = (short)512622593;
			if (num != 0)
			{
			}
			num = (short)1200881664;
			short num4 = num;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00010B00 File Offset: 0x0000ED00
		public virtual void DeviceControl(global::Motorola.Common.Communication.CommonUtil.DeviceControlInputParams inputParams, ref global::Motorola.Common.Communication.CommonUtil.DeviceControlOutputParams outputParams)
		{
			short num = (short)1798933855;
			short num2 = num;
			num = (short)1902415199;
			switch (num2 == num)
			{
			}
			num = (short)309723136;
			short num3 = num;
			num = (short)1779302401;
			if (num != 0)
			{
			}
			num = (short)836698112;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00010BA8 File Offset: 0x0000EDA8
		public virtual bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			short num = (short)1580343049;
			short num2 = num;
			num = (short)1370431241;
			switch (num2 == num)
			{
			}
			num = (short)1753219072;
			short num3 = num;
			num = (short)449904641;
			if (num != 0)
			{
			}
			num = (short)1469317120;
			if (num != 0)
			{
			}
			return this.SequenceManager.UpdateProgrammingStatus(status, sessionID);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00010C60 File Offset: 0x0000EE60
		public virtual global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo()
		{
			int a_ = 17;
			short num = (short)1212756699;
			short num2 = num;
			num = (short)757871323;
			global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_FA:
				deviceInfo.RadioID = this.DeviceInfo.RadioID;
				num = (short)329711617;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)873594880;
				if (num != 0)
				{
				}
				num = (short)903872513;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_98;
				}
				break;
			}
			for (;;)
			{
				IL_86:
				switch (num3)
				{
				case 0:
					goto IL_F8;
				case 1:
					goto IL_123;
				case 2:
					if (string.IsNullOrEmpty(deviceInfo.RadioID))
					{
						num = (short)570884096;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14F;
				}
				goto IL_98;
			}
			IL_F8:
			goto IL_FA;
			IL_123:
			num = (short)1682767872;
			short num4 = num;
			IL_14F:
			deviceInfo.ConnectionInfo.UniqueAddress = this.DeviceInfo.ConnectionInfo.UniqueAddress;
			deviceInfo.ConnectionInfo.ConnectionType = this.DeviceInfo.ConnectionInfo.ConnectionType;
			deviceInfo.ConnectionInfo.SessionID = this.DeviceInfo.ConnectionInfo.SessionID;
			deviceInfo.RadioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
			this.DeviceInfo = deviceInfo;
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("㑥൧୩࡫ݭṯᕱ味ትᵷ౹ᕻᵽꊁﺋﶓ秊몙瀞튟芡얣蚥\udaa7쮩좫잭\udfaf銱쎳\udfb5첷특鲻ꖿ냁귃Ʂ꓇苋믍뷏냑뇓ꓕ", a_) + this.DeviceInfo.SerialNumber + global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("䙥ὧ୩Ὣ乭ͯݱᝳᕵᵷॹཻ᡽", a_), global::System.Array.Empty<object>());
			return this.DeviceInfo;
			IL_98:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("㕥ᱧ୩ṫᩭ偯qᅳ᝵ᱷ፹ቻ᥽ꁿ꺍憐ﲑ秊ﶛ즟춡쪣袥蚧蒩", a_), global::System.Array.Empty<object>());
			deviceInfo = this.SequenceManager.ReadDeviceInfo();
			num = (short)2094006274;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_86;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00010E5C File Offset: 0x0000F05C
		public virtual global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			int a_ = 8;
			switch (0)
			{
			case 0:
				goto IL_55;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)2035417102;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					this.DeviceInfo.RadioStorage = extendedDeviceInfo.RadioStorage;
					this.ExtendedDeviceInfo = extendedDeviceInfo;
					num2 = (short)253165574;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (this.DeviceInfo.ConnectionInfo.ConnectionType != global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork)
					{
						num2 = (short)1908604928;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E8;
				case 3:
					extendedDeviceInfo.RadioID = this.DeviceInfo.RadioID;
					num2 = (short)997064709;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (string.IsNullOrEmpty(extendedDeviceInfo.RadioID))
					{
						num2 = (short)703594499;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_17B;
				case 5:
					goto IL_17B;
				case 6:
					goto IL_2CA;
				case 7:
					if (extendedDeviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.MatrixRepeaterRadio)
					{
						num2 = (short)1679884296;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3BD;
				case 8:
					goto IL_1E3;
				case 9:
				{
					num2 = (short)945975978;
					short num3 = num2;
					num2 = (short)1010135722;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_17B;
					default:
						goto IL_241;
					}
					break;
				}
				case 10:
					if (this.DifferentialWriteCapableRadio)
					{
						num2 = (short)1305804801;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2CA;
				case 11:
					num2 = (short)837615623;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					goto IL_E8;
				case 13:
					if (extendedDeviceInfo.Family != global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRepeaterRadio)
					{
						num2 = (short)2001141771;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1E3;
				case 14:
					if (this.DeviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.DMR3Network)
					{
						num2 = (short)1631453196;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3BD;
				}
				goto IL_55;
				IL_E8:
				num2 = (short)148570125;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_17B:
				num2 = (short)1729167360;
				short num4 = num2;
				num2 = (short)936640522;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1E3:
				this.DeviceInfo.Family = extendedDeviceInfo.Family;
				num2 = (short)1440677897;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2CA:
				bool isTlsPskCompatible = extendedDeviceInfo.ConnectionInfo.IsTlsPskCompatible;
				extendedDeviceInfo.ConnectionInfo = this.DeviceInfo.ConnectionInfo;
				extendedDeviceInfo.ConnectionInfo.IsTlsPskCompatible = isTlsPskCompatible;
				extendedDeviceInfo.RadioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
				this.DeviceInfo.CodeplugVersion = extendedDeviceInfo.CodeplugVersion;
				this.DeviceInfo.ModelNumber = extendedDeviceInfo.ModelNumber;
				this.DeviceInfo.SerialNumber = extendedDeviceInfo.SerialNumber;
				this.DeviceInfo.SoftwareVersion = extendedDeviceInfo.SoftwareVersion;
				num2 = (short)642056194;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_241:
			num2 = (short)1387462656;
			if (num2 != 0)
			{
			}
			IL_3BD:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ཛྷ㩞`ݢ౤०๨䭪࡬ᝮհᙲ᭴፶ᱸὺ嵼᭾ꮊﲒ殺쾠莢쎤좦\udba8讪첬辮쎰튲톴\udeb6횸鮺쪼횾뗀ꯂ铆곈맊꓌껎뷐鯔ꋖ듘맚룜귞쇠", a_) + this.DeviceInfo.SerialNumber + global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("絜⡞`ၢ䕤ᑦᱨࡪ๬੮ɰr፴ɶᕸ", a_), global::System.Array.Empty<object>());
			return extendedDeviceInfo;
			IL_55:
			num2 = (short)1534197761;
			if (num2 != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("๜⭞`ᅢᅤ䝦᭨๪౬୮ᡰᵲቴ坶ᱸͺॼ᩾ꦈ年랖ﮜ펠캢쒤펦삨쒪쎬膮龰鶲", a_), global::System.Array.Empty<object>());
			extendedDeviceInfo = this.SequenceManager.ReadExtendedDeviceInfo();
			num2 = (short)191954948;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00011264 File Offset: 0x0000F464
		public global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba)
		{
			short num = (short)597819393;
			if (num != 0)
			{
			}
			num = (short)982198386;
			short num2 = num;
			num = (short)1935157362;
			switch (num2 == num)
			{
			default:
			{
				num = (short)948305920;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)917897216;
			if (num != 0)
			{
			}
			return this.SequenceManager.ReadDevice(referencePba, this.ActiveSession.ID);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00011324 File Offset: 0x0000F524
		public byte QueryRadioUpdateStatus()
		{
			if (!(this.SequenceManager is global::Motorola.Common.Communication.IQueryRadioStatus))
			{
				short num = (short)644948718;
				short num2 = num;
				num = (short)1857430254;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_0F;
				case 1:
					break;
				default:
				{
					num = (short)1569849344;
					short num3 = num;
					break;
				}
				}
				num = (short)1563099137;
				if (num != 0)
				{
				}
				num = (short)831062016;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			IL_0F:
			return ((global::Motorola.Common.Communication.IQueryRadioStatus)this.SequenceManager).QueryRadioUpdateStatus();
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000113F0 File Offset: 0x0000F5F0
		public global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks<T>(global::System.Collections.Generic.ICollection<T> blockList)
		{
			if (!(this.SequenceManager is global::Motorola.Common.Communication.IIshBlockSupport))
			{
				short num = (short)365492192;
				short num2 = num;
				num = (short)260044768;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_0F;
				case 1:
					break;
				default:
				{
					num = (short)711262208;
					short num3 = num;
					break;
				}
				}
				num = (short)130940928;
				if (num != 0)
				{
				}
				num = (short)1670643713;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			IL_0F:
			return ((global::Motorola.Common.Communication.IIshBlockSupport)this.SequenceManager).ReadBlocks<T>(blockList);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000114C0 File Offset: 0x0000F6C0
		public bool ResetPassword(byte[] resetBytes)
		{
			global::Motorola.Common.Communication.ICpsSequenceManager cpsSequenceManager = this.SequenceManager as global::Motorola.Common.Communication.ICpsSequenceManager;
			if (cpsSequenceManager == null)
			{
				short num = (short)191448591;
				short num2 = num;
				num = (short)247940623;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_11;
				case 1:
					break;
				default:
				{
					num = (short)196214784;
					short num3 = num;
					break;
				}
				}
				num = (short)536281089;
				if (num != 0)
				{
				}
				num = (short)1145634816;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_PasswordResetFailed, global::Motorola.CommonCPS.ResourceRepository.Resources.Wrong_SequenceManager_Used);
			}
			IL_11:
			return cpsSequenceManager.ResetPassword(resetBytes);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00011590 File Offset: 0x0000F790
		public global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, string pcrNewPassword, int? userDefersAllowed)
		{
			short num = (short)92012549;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool flag;
				switch (num2)
				{
				case 0:
					goto IL_17A;
				case 1:
					num = (short)1295450113;
					if (num != 0)
					{
					}
					flag = false;
					goto IL_17C;
				case 2:
				{
					global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = this.DeviceInfo;
					if (deviceInfo == null)
					{
						num = (short)1362296833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					flag = (deviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.DMR3Controller);
					goto IL_17C;
				}
				case 3:
					this.SequenceManager.ExtendedDeviceInfo = this.ExtendedDeviceInfo;
					num = (short)499908614;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					this.SequenceManager.ExtendedDeviceInfo = (global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo)this.DeviceInfo;
					num = (short)426990242;
					short num3 = num;
					num = (short)1513642658;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_17A;
					default:
						num = (short)1865678848;
						if (num != 0)
						{
						}
						num = (short)1042808832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 6:
					goto IL_86;
				}
				IL_40:
				if (this.DifferentialWriteCapableRadio)
				{
					num = (short)1762131971;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_86:
				num = (short)1256652802;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_17C:
				if (!flag)
				{
					break;
				}
				num = (short)643301380;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_17A:
			num = (short)542638080;
			short num4 = num;
			return this.SequenceManager.WriteDevice(writePBA, this.ActiveSession.ID, pcrNewPassword, false, userDefersAllowed);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0001177C File Offset: 0x0000F97C
		public void ForceWriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA)
		{
			short num = (short)1838368128;
			short num2 = num;
			num = (short)1184646528;
			switch (num2 == num)
			{
			}
			num = (short)1434976256;
			short num3 = num;
			num = (short)1990393856;
			if (num != 0)
			{
			}
			num = (short)1100677121;
			if (num != 0)
			{
			}
			((global::Motorola.Common.Communication.IDepotSequenceManager)this.SequenceManager).ForceWriteDevice(writePBA, this.ActiveSession.ID);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00011840 File Offset: 0x0000FA40
		public void DepotForceWriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA)
		{
			short num = (short)51969105;
			short num2 = num;
			num = (short)2125855825;
			switch (num2 == num)
			{
			}
			num = (short)657719296;
			short num3 = num;
			num = (short)930611201;
			if (num != 0)
			{
			}
			num = (short)1970405376;
			if (num != 0)
			{
			}
			((global::Motorola.Common.Communication.IDepotSequenceManager)this.SequenceManager).DepotForceWriteDevice(writePBA, this.ActiveSession.ID);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00011908 File Offset: 0x0000FB08
		public void UpdateSerialNumber(string serialNumber)
		{
			short num = (short)143612881;
			short num2 = num;
			num = (short)2001951697;
			switch (num2 == num)
			{
			default:
			{
				num = (short)927662080;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2145976321;
			if (num != 0)
			{
			}
			num = (short)155123712;
			if (num != 0)
			{
			}
			((global::Motorola.Common.Communication.IDepotSequenceManager)this.SequenceManager).UpdateSerialNumber(serialNumber);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000119C4 File Offset: 0x0000FBC4
		public void FactoryReset()
		{
			short num = (short)206273220;
			short num2 = num;
			num = (short)581991108;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1431568384;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1516503040;
			if (num != 0)
			{
			}
			num = (short)168361985;
			if (num != 0)
			{
			}
			((global::Motorola.Common.Communication.IDepotSequenceManager)this.SequenceManager).FactoryReset();
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00011A84 File Offset: 0x0000FC84
		public void UnkillRadio(byte[] authenticationValue)
		{
			short num = (short)393523504;
			short num2 = num;
			num = (short)1572385072;
			switch (num2 == num)
			{
			default:
			{
				num = (short)948830208;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)786890753;
			if (num != 0)
			{
			}
			num = (short)2078343168;
			if (num != 0)
			{
			}
			((global::Motorola.Common.Communication.IDepotSequenceManager)this.SequenceManager).UnkillRadio(authenticationValue);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00011B40 File Offset: 0x0000FD40
		public byte[] ReadUnkillChallengeValue()
		{
			short num = (short)1980136195;
			short num2 = num;
			num = (short)695630595;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1706819584;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1669070849;
			if (num != 0)
			{
			}
			num = (short)847052800;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.IDepotSequenceManager)this.SequenceManager).ReadUnkillChallengeValue();
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00011BFC File Offset: 0x0000FDFC
		public void UpdateMACAddress(byte[] macAddress)
		{
			if (this.SequenceManager is global::Motorola.Common.Communication.IUpdatesMacAddress)
			{
				short num = (short)1388642305;
				if (num != 0)
				{
				}
			}
			else
			{
				short num = (short)1937818543;
				short num2 = num;
				num = (short)1805697967;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)416677888;
					short num3 = num;
					num = (short)1633353728;
					if (num != 0)
					{
					}
					throw new global::System.NotImplementedException();
				}
				}
			}
			((global::Motorola.Common.Communication.IUpdatesMacAddress)this.SequenceManager).UpdateMACAddress(macAddress);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00011CCC File Offset: 0x0000FECC
		public bool SetFWDLConfig(ushort tg, string version)
		{
			if (!(this.SequenceManager is global::Motorola.Common.Communication.IFwdl))
			{
				short num = (short)1480894556;
				short num2 = num;
				num = (short)1182312540;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1628962816;
					if (num != 0)
					{
					}
					num = (short)66781184;
					short num3 = num;
					num = (short)372899841;
					if (num != 0)
					{
					}
					throw new global::System.NotImplementedException();
				}
				}
			}
			return ((global::Motorola.Common.Communication.IFwdl)this.SequenceManager).SetFWDLConfig(tg, version);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00011D9C File Offset: 0x0000FF9C
		public void SendUpdateIMEType(byte ime)
		{
			short num = (short)279183361;
			if (num != 0)
			{
			}
			num = (short)1275265024;
			short num2 = num;
			num = (short)1778811761;
			short num3 = num;
			num = (short)1252557681;
			switch (num3 == num)
			{
			}
			num = (short)2018050048;
			if (num != 0)
			{
			}
			((global::Motorola.Common.Communication.IDepotSequenceManager)this.SequenceManager).UpdateIMEType(ime);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00011E54 File Offset: 0x00010054
		public void SendUpdateDateCode(byte[] datecode, ushort source)
		{
			short num = (short)1725004631;
			short num2 = num;
			num = (short)318012247;
			switch (num2 == num)
			{
			default:
			{
				num = (short)963903488;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)613941249;
			if (num != 0)
			{
			}
			num = (short)1129709568;
			if (num != 0)
			{
			}
			((global::Motorola.Common.Communication.IDepotSequenceManager)this.SequenceManager).UpdateDateCode(datecode, source);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00011F10 File Offset: 0x00010110
		public void CBIProgramme()
		{
			short num = (short)848321605;
			short num2 = num;
			num = (short)1571380293;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2061500416;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1343619073;
			if (num != 0)
			{
			}
			num = (short)2122711040;
			if (num != 0)
			{
			}
			((global::Motorola.Common.Communication.IDepotSequenceManager)this.SequenceManager).CBIProgramme();
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00011FC8 File Offset: 0x000101C8
		public virtual void SwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			short num = (short)909377539;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_EC;
				case 1:
					if (mode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.FLASHSTRAP)
					{
						num = (short)275841024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13F;
				case 2:
					goto IL_BA;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				}
				IL_35:
				num = (short)813649121;
				short num3 = num;
				num = (short)215698657;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_BA:
					num = (short)1412562945;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)434765824;
					if (num != 0)
					{
					}
					if (!(this.SequenceManager is global::Motorola.Common.Communication.ICpsSequenceManager))
					{
						goto IL_13F;
					}
					num = (short)549584898;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_EC:
			num = (short)2125791233;
			if (num != 0)
			{
			}
			num = (short)1180434432;
			short num4 = num;
			((global::Motorola.Common.Communication.ICpsSequenceManager)this.SequenceManager).SwitchRadioMode(mode);
			return;
			IL_13F:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0001211C File Offset: 0x0001031C
		public virtual void UpdateRadioDisplay()
		{
			short num = (short)1950860669;
			short num2 = num;
			num = (short)599770493;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1496514560;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)271056897;
			if (num != 0)
			{
			}
			num = (short)1847459840;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000121D8 File Offset: 0x000103D8
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePacksInfo()
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			if (!(this.SequenceManager is global::Motorola.Common.Communication.ILanguagePackSupport))
			{
				short num = (short)161284097;
				if (num != 0)
				{
				}
				num = (short)1090833930;
				short num2 = num;
				num = (short)2056048138;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1480130560;
					short num3 = num;
					num = (short)649199616;
					if (num != 0)
					{
					}
					throw new global::System.NotImplementedException();
				}
				}
			}
			return ((global::Motorola.Common.Communication.ILanguagePackSupport)this.SequenceManager).ReadLanguagePacksInfo();
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000122B8 File Offset: 0x000104B8
		public void WriteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			if (!(this.SequenceManager is global::Motorola.Common.Communication.ILanguagePackSupport))
			{
				short num = (short)1105471009;
				short num2 = num;
				num = (short)756885025;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)11730944;
					if (num != 0)
					{
					}
					num = (short)1762066432;
					short num3 = num;
					num = (short)1804337153;
					if (num != 0)
					{
					}
					throw new global::System.NotImplementedException();
				}
				}
			}
			((global::Motorola.Common.Communication.ILanguagePackSupport)this.SequenceManager).WriteLanguagePacks(languagePackData);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00012388 File Offset: 0x00010588
		public void DeleteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			if (!(this.SequenceManager is global::Motorola.Common.Communication.ILanguagePackSupport))
			{
				short num = (short)1173767533;
				short num2 = num;
				num = (short)1114850669;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)499449856;
					if (num != 0)
					{
					}
					num = (short)1474035712;
					short num3 = num;
					num = (short)217776129;
					if (num != 0)
					{
					}
					throw new global::System.NotImplementedException();
				}
				}
			}
			((global::Motorola.Common.Communication.ILanguagePackSupport)this.SequenceManager).DeleteLanguagePacks(languagePackData);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00012454 File Offset: 0x00010654
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePacksInfo()
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			if (this.SequenceManager is global::Motorola.Common.Communication.ICpsSequenceManager)
			{
				short num = (short)1552220161;
				if (num != 0)
				{
				}
			}
			else
			{
				short num = (short)668049636;
				short num2 = num;
				num = (short)477405412;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)24707072;
					short num3 = num;
					num = (short)1696595968;
					if (num != 0)
					{
					}
					throw new global::System.NotImplementedException();
				}
				}
			}
			return ((global::Motorola.Common.Communication.ICpsSequenceManager)this.SequenceManager).ReadTTSLanguagePacksInfo();
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00012530 File Offset: 0x00010730
		public void WriteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			if (!(this.SequenceManager is global::Motorola.Common.Communication.ICpsSequenceManager))
			{
				short num = (short)249081133;
				short num2 = num;
				num = (short)1369484589;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)669908993;
					if (num != 0)
					{
					}
					num = (short)29294592;
					short num3 = num;
					num = (short)1702035456;
					if (num != 0)
					{
					}
					throw new global::System.NotImplementedException();
				}
				}
			}
			((global::Motorola.Common.Communication.ICpsSequenceManager)this.SequenceManager).WriteTTSLanguagePacks(languagePackData);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000125FC File Offset: 0x000107FC
		public void DeleteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			if (!(this.SequenceManager is global::Motorola.Common.Communication.ICpsSequenceManager))
			{
				short num = (short)837324145;
				short num2 = num;
				num = (short)2116259185;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1821966337;
					if (num != 0)
					{
					}
					num = (short)1324285952;
					short num3 = num;
					num = (short)1280638976;
					if (num != 0)
					{
					}
					throw new global::System.NotImplementedException();
				}
				}
			}
			((global::Motorola.Common.Communication.ICpsSequenceManager)this.SequenceManager).DeleteTTSLanguagePacks(languagePackData);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000126CC File Offset: 0x000108CC
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> ReadFilesListInDir(global::Motorola.Common.Communication.Pba.FileItem dir)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			global::Motorola.Common.Communication.ICpsFileSequenceManager cpsFileSequenceManager = this.SequenceManager as global::Motorola.Common.Communication.ICpsFileSequenceManager;
			if (cpsFileSequenceManager == null)
			{
				short num = (short)1625680920;
				short num2 = num;
				num = (short)1014819864;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)228720641;
					if (num != 0)
					{
					}
					num = (short)1330577408;
					short num3 = num;
					num = (short)1638072320;
					if (num != 0)
					{
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNotSupportForDevice);
				}
				}
			}
			return cpsFileSequenceManager.ReadFilesListInDir(dir);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000127A8 File Offset: 0x000109A8
		public global::Motorola.Common.Communication.Pba.FileItem ReadFile(global::Motorola.Common.Communication.Pba.FileItem file)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			global::Motorola.Common.Communication.ICpsFileSequenceManager cpsFileSequenceManager = this.SequenceManager as global::Motorola.Common.Communication.ICpsFileSequenceManager;
			if (cpsFileSequenceManager == null)
			{
				short num = (short)115024203;
				short num2 = num;
				num = (short)1407131979;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1796079617;
					if (num != 0)
					{
					}
					num = (short)373751808;
					short num3 = num;
					num = (short)2094858240;
					if (num != 0)
					{
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNotSupportForDevice);
				}
				}
			}
			return cpsFileSequenceManager.ReadFile(file);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00012884 File Offset: 0x00010A84
		public void WriteFile(global::Motorola.Common.Communication.Pba.FileItem file)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			global::Motorola.Common.Communication.ICpsFileSequenceManager cpsFileSequenceManager = this.SequenceManager as global::Motorola.Common.Communication.ICpsFileSequenceManager;
			if (cpsFileSequenceManager == null)
			{
				short num = (short)951463780;
				short num2 = num;
				num = (short)253767524;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)414318593;
					if (num != 0)
					{
					}
					num = (short)2023424000;
					short num3 = num;
					num = (short)1495138304;
					if (num != 0)
					{
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNotSupportForDevice);
				}
				}
			}
			cpsFileSequenceManager.WriteFile(file, null);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00012964 File Offset: 0x00010B64
		public void DeleteFile(global::Motorola.Common.Communication.Pba.FileItem file)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			global::Motorola.Common.Communication.ICpsFileSequenceManager cpsFileSequenceManager = this.SequenceManager as global::Motorola.Common.Communication.ICpsFileSequenceManager;
			if (cpsFileSequenceManager == null)
			{
				short num = (short)1269050161;
				short num2 = num;
				num = (short)835726129;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)464977920;
					if (num != 0)
					{
					}
					num = (short)862257152;
					short num3 = num;
					num = (short)853409793;
					if (num != 0)
					{
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNotSupportForDevice);
				}
				}
			}
			cpsFileSequenceManager.DeleteFile(file);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00012A40 File Offset: 0x00010C40
		public long GetFileOrDirSize(global::Motorola.Common.Communication.Pba.FileItem fileOrDir)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			global::Motorola.Common.Communication.ICpsFileSequenceManager cpsFileSequenceManager = this.SequenceManager as global::Motorola.Common.Communication.ICpsFileSequenceManager;
			if (cpsFileSequenceManager == null)
			{
				short num = (short)1541607188;
				short num2 = num;
				num = (short)1726091028;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)770179073;
					if (num != 0)
					{
					}
					num = (short)513277952;
					short num3 = num;
					num = (short)1415053312;
					if (num != 0)
					{
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNotSupportForDevice);
				}
				}
			}
			return cpsFileSequenceManager.GetFileOrDirSize(fileOrDir);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00012B18 File Offset: 0x00010D18
		private void d()
		{
			short num = (short)1310916610;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_6E;
				case 1:
					global::System.Threading.Thread.Sleep(5);
					num = (short)863764480;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if (this.DeviceInfo.Family != global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio)
				{
					break;
				}
				num = (short)731840513;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_6E:
			num = (short)112999532;
			short num3 = num;
			num = (short)428424300;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_6E;
			case 1:
				break;
			default:
			{
				num = (short)1412038656;
				short num4 = num;
				break;
			}
			}
			num = (short)2105016320;
			if (num != 0)
			{
			}
			num = (short)1238040577;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00012C34 File Offset: 0x00010E34
		public virtual void UpgradeFlashStrap(global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			short num = (short)1507548012;
			short num2 = num;
			num = (short)1085037420;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1418985472;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)449773569;
			if (num != 0)
			{
			}
			num = (short)1459486720;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00012CF0 File Offset: 0x00010EF0
		public virtual void EraseRadio(global::System.Collections.Generic.List<string> sections)
		{
			short num = (short)1262092289;
			if (num != 0)
			{
			}
			num = (short)655687680;
			short num2 = num;
			num = (short)400973111;
			short num3 = num;
			num = (short)1426283831;
			switch (num3 == num)
			{
			}
			num = (short)1410334720;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00012DA8 File Offset: 0x00010FA8
		public virtual void EraseRadioFromTo(uint startAddress, uint size)
		{
			short num = (short)1062218696;
			short num2 = num;
			num = (short)1623731144;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1463287808;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)672006145;
			if (num != 0)
			{
			}
			num = (short)739442688;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00012E60 File Offset: 0x00011060
		public virtual void UpgradeFDT(string destModel, string destCPVersion, string serialNumber)
		{
			short num = (short)252084865;
			short num2 = num;
			num = (short)748454529;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2045378560;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)419889153;
			if (num != 0)
			{
			}
			num = (short)1863319552;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00012F18 File Offset: 0x00011118
		public virtual void WriteImage(global::Motorola.Common.Communication.CommonUtil.MemoryImage image)
		{
			short num = (short)1814211346;
			short num2 = num;
			num = (short)1644669714;
			switch (num2 == num)
			{
			default:
			{
				num = (short)121438208;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1204289537;
			if (num != 0)
			{
			}
			num = (short)383123456;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00012FD4 File Offset: 0x000111D4
		public void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject updatePBA, bool hostedDepotOperation, int? userDefersAllowed)
		{
			short num = (short)1445856944;
			short num2 = num;
			num = (short)1561986736;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1319436288;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1865154561;
			if (num != 0)
			{
			}
			num = (short)1146421248;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			((global::Motorola.Common.Communication.IUpdatesDeviceForFlash)this.SequenceManager).UpdateDevice(updatePBA, this.ActiveSession.ID, hostedDepotOperation, userDefersAllowed);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000130AC File Offset: 0x000112AC
		public void PreUpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject updatePBA, bool hostedDepotOperation)
		{
			short num = (short)191202825;
			short num2 = num;
			num = (short)1570997769;
			switch (num2 == num)
			{
			default:
			{
				num = (short)231800832;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1931739136;
			if (num != 0)
			{
			}
			num = (short)1613889537;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			((global::Motorola.Common.Communication.IFlashSequenceManager)this.SequenceManager).PreUpdateDevice(updatePBA, this.ActiveSession.ID, hostedDepotOperation);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00013184 File Offset: 0x00011384
		private void c()
		{
			short num = (short)1743126529;
			if (num != 0)
			{
			}
			num = (short)224854016;
			short num2 = num;
			num = (short)1675596944;
			short num3 = num;
			num = (short)784569488;
			switch (num3 == num)
			{
			}
			num = (short)756285440;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			((global::Motorola.Common.Communication.IUpdatesDeviceForFlash)this.SequenceManager).ValidateUpdate();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00013250 File Offset: 0x00011450
		public bool WriteRamdownloader(string filePath)
		{
			short num = (short)607091766;
			short num2 = num;
			num = (short)1900575798;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1468268544;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1982464001;
			if (num != 0)
			{
			}
			num = (short)1822228480;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			return ((global::Motorola.Common.Communication.IFlashSequenceManager)this.SequenceManager).WriteRamdownloader(filePath);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0001331C File Offset: 0x0001151C
		public global::Motorola.Common.Communication.Pba.UpdateDeviceData ReadImage(global::Motorola.Common.Communication.Pba.UpdateDeviceData updateData)
		{
			short num = (short)1816243599;
			short num2 = num;
			num = (short)1538239887;
			switch (num2 == num)
			{
			default:
			{
				num = (short)61407232;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1677262849;
			if (num != 0)
			{
			}
			num = (short)384761856;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			return ((global::Motorola.Common.Communication.IFlashSequenceManager)this.SequenceManager).ReadImage(updateData);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000133E8 File Offset: 0x000115E8
		public virtual global::Motorola.Common.Communication.CommonUtil.MemoryImage ReadImageByAddress(uint startAddress, uint size)
		{
			short num = (short)498719389;
			short num2 = num;
			num = (short)340122269;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1694433280;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1598095360;
			if (num != 0)
			{
			}
			num = (short)557907969;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			return null;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000134A0 File Offset: 0x000116A0
		public void EnableFeature(string fwVersion, string serialNumber, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIDs)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			if (!(this.SequenceManager is global::Motorola.Common.Communication.ICpsSequenceManager))
			{
				short num = (short)891319367;
				short num2 = num;
				num = (short)922907719;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1855520769;
					if (num != 0)
					{
					}
					num = (short)841547776;
					short num3 = num;
					num = (short)1900412928;
					if (num != 0)
					{
					}
					throw new global::System.NotImplementedException();
				}
				}
			}
			((global::Motorola.Common.Communication.ICpsSequenceManager)this.SequenceManager).EnableFeature(fwVersion, serialNumber, xmlHashInput, featureCodeIDs);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00013588 File Offset: 0x00011788
		public string ReadHashInputAndValidate(global::Motorola.Common.Communication.Pba.PbaObject validatePba, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			if (!(this.SequenceManager is global::Motorola.Common.Communication.ICpsSequenceManager))
			{
				short num = (short)1331101697;
				if (num != 0)
				{
				}
				num = (short)1119553605;
				short num2 = num;
				num = (short)811862085;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1777598464;
					short num3 = num;
					num = (short)740294656;
					if (num != 0)
					{
					}
					throw new global::System.NotImplementedException();
				}
				}
			}
			return ((global::Motorola.Common.Communication.ICpsSequenceManager)this.SequenceManager).ReadHashInputAndValidate(validatePba, blockList);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00013668 File Offset: 0x00011868
		public virtual void SendFPGAErase(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			short num;
			if (!(this.SequenceManager is global::Motorola.Common.Communication.ICpsSequenceManager))
			{
				num = (short)173651104;
				short num2 = num;
				num = (short)1450947744;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)720568320;
					short num3 = num;
					num = (short)2111438848;
					if (num != 0)
					{
					}
					throw new global::System.NotImplementedException();
				}
				}
			}
			num = (short)1575682049;
			if (num != 0)
			{
			}
			((global::Motorola.Common.Communication.ICpsSequenceManager)this.SequenceManager).SendFPGAErase(fileType);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00013744 File Offset: 0x00011944
		public virtual void SendFPGAReset(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			if (!(this.SequenceManager is global::Motorola.Common.Communication.ICpsSequenceManager))
			{
				short num = (short)1993474049;
				if (num != 0)
				{
				}
				num = (short)206918181;
				short num2 = num;
				num = (short)1530483237;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)948371456;
					short num3 = num;
					num = (short)1908867072;
					if (num != 0)
					{
					}
					throw new global::System.NotImplementedException();
				}
				}
			}
			((global::Motorola.Common.Communication.ICpsSequenceManager)this.SequenceManager).SendFPGAReset(fileType);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00013824 File Offset: 0x00011A24
		public virtual global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(string password)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			if (!(this.SequenceManager is global::Motorola.Common.Communication.ICpsSequenceManager))
			{
				short num = (short)1930496772;
				short num2 = num;
				num = (short)1804274436;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1226375169;
					if (num != 0)
					{
					}
					num = (short)199294976;
					short num3 = num;
					num = (short)1232404480;
					if (num != 0)
					{
					}
					throw new global::System.NotImplementedException();
				}
				}
			}
			return ((global::Motorola.Common.Communication.ICpsSequenceManager)this.SequenceManager).ValidateLocalPassword(password);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00013900 File Offset: 0x00011B00
		public virtual global::Motorola.Common.Communication.CommonUtil.FDTInfo GetFdtInfo(global::Motorola.Common.Communication.CommonUtil.FDTType fdtType)
		{
			short num = (short)800063489;
			if (num != 0)
			{
			}
			num = (short)923402240;
			short num2 = num;
			num = (short)767551368;
			short num3 = num;
			num = (short)1462953864;
			switch (num3 == num)
			{
			}
			num = (short)23855104;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(this.SequenceManager, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSequenceManagerNotCreated);
			return null;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000139BC File Offset: 0x00011BBC
		public void ReadRadioParameters(global::Motorola.Common.Communication.CommonUtil.RadioParameterPairs paramPairs)
		{
			short num = (short)627376131;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_11E;
				case 1:
					if (paramPairs.RadioParameters.Count<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.RadioParameterType, object>>() > 0)
					{
						num = (short)2101542912;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_120;
				case 2:
					goto IL_DF;
				case 3:
					num = (short)1537146881;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				}
				IL_5C:
				num = (short)981024817;
				short num3 = num;
				num = (short)1579827249;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_DF:
					num = (short)162922497;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)2085289984;
					if (num != 0)
					{
					}
					if (!(this.SequenceManager is global::Motorola.Common.Communication.IRadioParamSupport))
					{
						goto IL_120;
					}
					num = (short)1142620162;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_11E:
			((global::Motorola.Common.Communication.IRadioParamSupport)this.SequenceManager).ReadRadioParameters(paramPairs);
			return;
			IL_120:
			num = (short)174587904;
			short num4 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00013B18 File Offset: 0x00011D18
		public void FreeDeviceStatuse(bool closeConnectWithError)
		{
			short num = (short)993853447;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)441581574;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1647116289;
					if (num != 0)
					{
					}
					if (this.DeviceInfo.ConnectionInfo != null)
					{
						num = (short)35913728;
						short num3 = num;
						num = (short)642187264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
				{
					num = (short)1470889148;
					short num4 = num;
					num = (short)1387592892;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1352925184;
						if (num != 0)
						{
						}
						global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator.Instance.ReturnID(this.DeviceInfo.ConnectionInfo.SessionID);
						this.DeviceInfo.ConnectionInfo.SessionID = 0;
						num = (short)2029060101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_68;
				case 4:
					if (this.ActiveSession == null)
					{
						num = (short)1187512329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.DeviceInfo.ConnectionInfo.SessionID = 0;
					global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator.Instance.ReturnID(this.ActiveSession.ID);
					num = (short)1285226504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_13F;
				case 6:
					if (this.DeviceInfo.ConnectionInfo.SessionID != 0)
					{
						num = (short)661389314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 8:
					goto IL_AC;
				case 9:
					num = (short)770506753;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_4D:
				if (!closeConnectWithError)
				{
					num = (short)1621950467;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1043005444;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_68:
			return;
			IL_AC:
			try
			{
				this.ActiveSession.CommunicationPipe.ClosePort();
				return;
			}
			finally
			{
				this.ActiveSession = null;
			}
			return;
			IL_13F:;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00013DB0 File Offset: 0x00011FB0
		public virtual void WaitForCancelReading()
		{
			short num = (short)475076050;
			short num2 = num;
			num = (short)558241234;
			switch (num2 == num)
			{
			}
			num = (short)1728708609;
			if (num != 0)
			{
			}
			num = (short)541327360;
			if (num != 0)
			{
			}
			num = (short)1672544256;
			short num3 = num;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00013E58 File Offset: 0x00012058
		public virtual void SynPrepareDevice()
		{
			short num = (short)834535425;
			if (num != 0)
			{
			}
			num = (short)1809100287;
			short num2 = num;
			num = (short)1372761599;
			switch (num2 == num)
			{
			}
			num = (short)941817856;
			if (num != 0)
			{
			}
			num = (short)1663107072;
			short num3 = num;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00013F04 File Offset: 0x00012104
		public void Dispose()
		{
			short num = (short)815529985;
			if (num != 0)
			{
			}
			num = (short)1567410146;
			short num2 = num;
			num = (short)64800738;
			switch (num2 == num)
			{
			}
			num = (short)75235328;
			if (num != 0)
			{
			}
			num = (short)1668349952;
			short num3 = num;
			this.a(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00013FBC File Offset: 0x000121BC
		private void a(bool A_0)
		{
			short num = (short)1453457414;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1572470785;
					if (num != 0)
					{
					}
					num = (short)2080243720;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_E0;
				case 2:
					goto IL_94;
				case 3:
				{
					global::System.Threading.ManualResetEvent manualResetEvent = this.g;
					if (manualResetEvent == null)
					{
						num = (short)633405444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					manualResetEvent.Dispose();
					num = (short)1678901250;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_94;
				case 5:
				{
					num = (short)1050824958;
					short num3 = num;
					num = (short)694767870;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)136773632;
						if (num != 0)
						{
						}
						this.CloseSession(true);
						break;
					}
					num = (short)243728385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 7:
					goto IL_B2;
				case 8:
					if (A_0)
					{
						num = (short)1938751493;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E0;
				}
				IL_49:
				if (!this.b)
				{
					num = (short)920322048;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_94:
				this.b = true;
				num = (short)688455687;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E0:
				num = (short)1358888963;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B2:
			num = (short)123207680;
			short num4 = num;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000141B4 File Offset: 0x000123B4
		public void SwitchAmpRadioToApMode()
		{
			int a_ = 0;
			short num;
			for (;;)
			{
				num = (short)1965686785;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						try
						{
							this.b();
							return;
						}
						catch (global::System.Exception ex)
						{
							global::System.Diagnostics.Trace.TraceError(string.Format(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("๔ⱖ楘♚\\ў᩠剢ᡤ㩦㉨ၪ彬ቮⱰ⡲๴䑶Ѹ♺♼Ȿ쪊ﾎ쎐ﺖ쾚\ude9e토쪤쎦첨풮薰캲슸躺삼胄뿆꫈껊뷌믎룐볒믔듘뻚껜곞胠蓢胤\udde6짨郪\udbec鋮", a_), new object[]
							{
								this.DeviceInfo.ConnectionInfo.ConnectionType,
								this.DeviceInfo.Family,
								this.DeviceInfo.SerialNumber,
								this.DeviceInfo.ModelNumber,
								this.DeviceInfo.SoftwareVersion,
								this.DeviceInfo.CodeplugVersion,
								ex.Message
							}), new object[]
							{
								ex.StackTrace,
								ex.StackTrace
							});
							throw ex;
						}
						finally
						{
							try
							{
								this.CloseSession(false);
							}
							catch
							{
							}
						}
						goto IL_177;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					case 2:
						goto IL_63;
					}
					IL_39:
					if (this.DeviceInfo.Family != global::Motorola.Common.Communication.CommonUtil.ProductFamily.AMPRadio)
					{
						num = (short)711655426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_177:
					num = (short)1696923648;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_63:
				num = (short)167641088;
				short num3 = num;
				num = (short)2023030785;
				if (num != 0)
				{
				}
				num = (short)349441210;
				short num4 = num;
				num = (short)88870074;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_1C9;
				}
			}
			IL_1C9:
			num = (short)689045504;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000143C8 File Offset: 0x000125C8
		private void b()
		{
			short num = (short)1385955330;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)542179329;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.IAmpProcessorSwitch ampProcessorSwitch;
				switch (num2)
				{
				case 0:
					goto IL_A9;
				case 1:
					goto IL_E7;
				case 2:
				{
					num = (short)1720123392;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_88;
					}
					continue;
				}
				case 3:
				{
					global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter = new global::Motorola.Common.Communication.CommonUtil.SessionParameter(0, false, null);
					global::Motorola.Common.Communication.CommonUtil.RadioOperation radioOperation = global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create;
					this.CreateSession(this.a(radioOperation, sessionParameter), radioOperation, sessionParameter);
					num = (short)1183973376;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					if (ampProcessorSwitch == null)
					{
						num = (short)2123759617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11E;
				}
				IL_88:
				if (this.ActiveSession == null)
				{
					num = (short)300154883;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A9:
				ampProcessorSwitch = (this.SequenceManager as global::Motorola.Common.Communication.IAmpProcessorSwitch);
				num = (short)989200388;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_E7:
			return;
			IL_11E:
			num = (short)928918844;
			short num4 = num;
			num = (short)358952252;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			default:
			{
				num = (short)1304494080;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.IAmpProcessorSwitch ampProcessorSwitch;
				ampProcessorSwitch.SwitchDeviceToAp();
				return;
			}
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00014544 File Offset: 0x00012744
		public virtual bool EstablishSecureConnection(string psk)
		{
			int a_ = 2;
			short num = (short)256114692;
			int num2 = (int)((global::System.IntPtr)num);
			bool flag;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_2A3;
				case 1:
					if (flag)
					{
						num = (short)361234438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return flag;
				case 2:
				{
					global::Motorola.Common.Communication.CommunicationPipe.SecureTlsCommPipe secureTlsCommPipe;
					if (secureTlsCommPipe == null)
					{
						num = (short)1088749571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					flag = secureTlsCommPipe.TryEstablishSecureConnection(psk);
					num = (short)1588723712;
					short num3 = num;
					num = (short)1040121857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_384;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 5:
					goto IL_64;
				case 6:
					global::System.Diagnostics.Trace.TraceInformation(string.Format(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ౖ≘歚⁜ɞ㩠ᡢ呤ᩦ㑨なᙬ嵮౰⹲⹴౶䩸ٺ⁼⑾쒀ﲎ戀삒\udc9e캠춢쮤슦쪨\udfaa쒬삮\udfb0첶趸욺뫀룄髆鿊ꗌ꫎믒듔맖뷘꣚뗜뻞諠蛢엤軦髨쯪觬胮鿰雲\udbf4ퟶ뫸铺郼鋾琀洂氄搆栈缊搌怎缐㌒昔挖砘椚検稞䔠ഢ", a_), new object[]
					{
						this.DeviceInfo.ConnectionInfo.ConnectionType,
						this.DeviceInfo.Family,
						this.DeviceInfo.SerialNumber,
						this.DeviceInfo.ModelNumber,
						this.DeviceInfo.SoftwareVersion,
						this.DeviceInfo.CodeplugVersion
					}));
					num = (short)970588160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_49:
				if (psk == null)
				{
					num = (short)1652424709;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::System.Diagnostics.Trace.TraceInformation(string.Format(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ౖ≘歚⁜ɞ㩠ᡢ呤ᩦ㑨なᙬ嵮౰⹲⹴౶䩸ٺ⁼⑾쒀ﲎ戀삒\udc9e캠춢쮤슦쪨\udfaa쒬삮\udfb0첶趸욺뫀룄髆鷌鳎髐ꏔ뛖뗘껚룜쇠飢폤髦", a_), new object[]
					{
						this.DeviceInfo.ConnectionInfo.ConnectionType,
						this.DeviceInfo.Family,
						this.DeviceInfo.SerialNumber,
						this.DeviceInfo.ModelNumber,
						this.DeviceInfo.SoftwareVersion,
						this.DeviceInfo.CodeplugVersion,
						psk
					}));
					global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter = new global::Motorola.Common.Communication.CommonUtil.SessionParameter(0, false, null);
					global::Motorola.Common.Communication.CommunicationPipe.SecureTlsCommPipe secureTlsCommPipe = this.CommunicationPipeFactory.CreateCommunicationPipe(this.DeviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read, sessionParameter) as global::Motorola.Common.Communication.CommunicationPipe.SecureTlsCommPipe;
					num = (short)320536578;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_64:
			global::System.Diagnostics.Trace.TraceError(string.Format(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ౖ≘歚⁜ɞ㩠ᡢ呤ᩦ㑨なᙬ嵮౰⹲⹴౶䩸ٺ⁼⑾쒀ﲎ戀삒\udc9e캠춢쮤슦쪨\udfaa쒬삮\udfb0첶趸욺뫀룄髆鷌鳎髐ꏔ뛖뗘껚룜쇠跢郤详藨", a_), new object[]
			{
				this.DeviceInfo.ConnectionInfo.ConnectionType,
				this.DeviceInfo.Family,
				this.DeviceInfo.SerialNumber,
				this.DeviceInfo.ModelNumber,
				this.DeviceInfo.SoftwareVersion,
				this.DeviceInfo.CodeplugVersion
			}));
			throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("❖⩘ず", a_), global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ݖ㡘⥚㱜㉞Ѡᝢdᕦ䥨ࡪ౬ŮὰᱲŴ坶᭸Ṻ嵼ᅾꦆ", a_));
			IL_2A3:
			return flag;
			IL_384:
			num = (short)689735565;
			short num4 = num;
			num = (short)335710093;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return flag;
			default:
				num = (short)1812135936;
				if (num != 0)
				{
				}
				num = (short)31129601;
				if (num != 0)
				{
				}
				global::System.Diagnostics.Trace.TraceError(string.Format(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ౖ≘歚⁜ɞ㩠ᡢ呤ᩦ㑨なᙬ嵮౰⹲⹴౶䩸ٺ⁼⑾쒀ﲎ戀삒\udc9e캠춢쮤슦쪨\udfaa쒬삮\udfb0첶趸욺뫀룄髆裊ꋌ뫎뷐럒믔귘ﯚ룜곞闠苢蟤详胨飪藬쿮藰鯲郴ퟶ諸黺黼諾猀昂┄搆昈攊挌樎爐朒簔砖眘㬚樜瘞唠䬢䨤刦崨ପ堬尮堰崲刴᜶樸帺帼䨾㍀♂ᅄ⭆㩈ࡊ≌≎㱐͒㱔❖㱘畚", a_), new object[]
				{
					this.DeviceInfo.ConnectionInfo.ConnectionType,
					this.DeviceInfo.Family,
					this.DeviceInfo.SerialNumber,
					this.DeviceInfo.ModelNumber,
					this.DeviceInfo.SoftwareVersion,
					this.DeviceInfo.CodeplugVersion
				}));
				throw new global::System.InvalidOperationException(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ᑖ㙘⹚ㅜ㭞འ䑢ᅤ䝦౨ᡪᥬ๮፰ὲᱴѶᅸ孺ॼ᝾ꎂﺊﾌ놐杖練ﺚﺜ좠첢쮤螦\udea8슪\ud9ac잮\udeb0욲솴鞶첸좺풼톾ꛀ雄ꋆ꫈뻊뿌꫎藐뿒ꛔ铖뛘뛚냜连裠鏢胤짦", a_));
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00014950 File Offset: 0x00012B50
		public virtual string GetPskId()
		{
			short num = (short)1533572545;
			short num2 = num;
			num = (short)925726145;
			switch (num2 == num)
			{
			}
			num = (short)25690112;
			if (num != 0)
			{
			}
			num = (short)774504449;
			if (num != 0)
			{
			}
			num = (short)1246035968;
			short num3 = num;
			return new global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsIdentityClient(this.CommunicationPipeFactory.CreateCommunicationPipe(this.DeviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.TlsHandshake, null), new global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsConnectClientFactory()).GetPskId();
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00014A28 File Offset: 0x00012C28
		// Note: this type is marked as 'beforefieldinit'.
		static MotoDevice()
		{
			short num = (short)2452078;
			short num2 = num;
			num = (short)1497918062;
			switch (num2 == num)
			{
			}
			num = (short)240975873;
			if (num != 0)
			{
			}
			num = (short)774766592;
			short num3 = num;
			num = (short)1528954880;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommunicationManager.MotoDevice.d = new object();
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00014AD8 File Offset: 0x00012CD8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a()
		{
			short num = (short)1913805303;
			short num2 = num;
			num = (short)219568631;
			switch (num2 == num)
			{
			}
			num = (short)334364672;
			if (num != 0)
			{
			}
			num = (short)1845493760;
			short num3 = num;
			num = (short)2036072449;
			if (num != 0)
			{
			}
			this.e();
		}

		// Token: 0x04000027 RID: 39
		private object a = new object();

		// Token: 0x04000028 RID: 40
		private bool b;

		// Token: 0x04000029 RID: 41
		private bool c = true;

		// Token: 0x0400002A RID: 42
		private static object d;

		// Token: 0x0400002B RID: 43
		protected global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile _radioProfile;

		// Token: 0x0400002C RID: 44
		private global::Motorola.Common.Communication.CommonUtil.RadioState e;

		// Token: 0x0400002D RID: 45
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IObserver> f = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IObserver>();

		// Token: 0x0400002E RID: 46
		private global::System.Threading.ManualResetEvent g = new global::System.Threading.ManualResetEvent(false);

		// Token: 0x0400002F RID: 47
		private global::Motorola.Common.Communication.CommonUtil.DeviceInfo h;

		// Token: 0x04000030 RID: 48
		protected readonly global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory SequenceManagerFactory;

		// Token: 0x04000031 RID: 49
		protected readonly global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager CommunicationManager;

		// Token: 0x04000032 RID: 50
		protected readonly global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory CommunicationPipeFactory;

		// Token: 0x04000033 RID: 51
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.CommunicationSession i;

		// Token: 0x04000034 RID: 52
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo j;

		// Token: 0x04000035 RID: 53
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool k;

		// Token: 0x04000036 RID: 54
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.IshHandler.IOController l;
	}
}
