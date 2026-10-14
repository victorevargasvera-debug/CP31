using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000031 RID: 49
	public abstract class UDPDetectorBase : global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00016D98 File Offset: 0x00014F98
		public global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType DetectorType
		{
			get
			{
				short num = (short)458139554;
				short num2 = num;
				num = (short)1336387490;
				switch (num2 == num)
				{
				}
				num = (short)1006764033;
				if (num != 0)
				{
				}
				num = (short)2044329984;
				short num3 = num;
				num = (short)165871616;
				if (num != 0)
				{
				}
				return this._detectorType;
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00016E44 File Offset: 0x00015044
		public virtual bool Start()
		{
			short num = (short)754253825;
			if (num != 0)
			{
			}
			num = (short)1253515445;
			short num2 = num;
			num = (short)930816181;
			switch (num2 == num)
			{
			}
			num = (short)506658816;
			short num3 = num;
			num = (short)1796603904;
			if (num != 0)
			{
			}
			this._backgroundThread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.BackgroundThread));
			this._backgroundThread.Start();
			return true;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00016F14 File Offset: 0x00015114
		public virtual void Stop()
		{
			short num = (short)2067005441;
			if (num != 0)
			{
			}
			num = (short)590733455;
			short num2 = num;
			num = (short)1657528463;
			switch (num2 == num)
			{
			}
			num = (short)1601896448;
			short num3 = num;
			num = (short)574488576;
			if (num != 0)
			{
			}
			this._isStopping = true;
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000139 RID: 313 RVA: 0x00016FC4 File Offset: 0x000151C4
		// (remove) Token: 0x0600013A RID: 314 RVA: 0x00017100 File Offset: 0x00015300
		public event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceAttached
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				short num;
				int num2;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)579796993;
					if (num != 0)
					{
					}
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler2;
					switch (num2)
					{
					case 0:
						if (deviceEventHandler == deviceEventHandler2)
						{
							num = (short)1985216513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_62;
					case 1:
						goto IL_101;
					case 2:
						goto IL_62;
					}
					goto IL_44;
					IL_62:
					deviceEventHandler2 = deviceEventHandler;
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler)global::System.Delegate.Combine(deviceEventHandler2, value);
					deviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler>(ref this.a, value2, deviceEventHandler2);
					num = (short)173462770;
					short num3 = num;
					num = (short)1916785906;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_44;
					default:
						num = (short)1821179904;
						if (num != 0)
						{
						}
						num = (short)1152581632;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_101:
				num = (short)1966931968;
				short num4 = num;
				return;
				IL_44:
				deviceEventHandler = this.a;
				num = (short)1398734850;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler2;
					switch (num)
					{
					case 0:
						if (deviceEventHandler == deviceEventHandler2)
						{
							num2 = (short)127074305;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					case 1:
						goto IL_FD;
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_39:
					deviceEventHandler2 = deviceEventHandler;
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler)global::System.Delegate.Remove(deviceEventHandler2, value);
					deviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler>(ref this.a, value2, deviceEventHandler2);
					num2 = (short)1497930209;
					short num3 = num2;
					num2 = (short)203725281;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C;
					default:
						num2 = (short)1580138496;
						if (num2 != 0)
						{
						}
						num2 = (short)1340801025;
						if (num2 != 0)
						{
						}
						num2 = (short)465174528;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				IL_FD:
				num2 = (short)1832583168;
				short num4 = num2;
				return;
				IL_1C:
				deviceEventHandler = this.a;
				num2 = (short)1312030722;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600013B RID: 315 RVA: 0x00017234 File Offset: 0x00015434
		// (remove) Token: 0x0600013C RID: 316 RVA: 0x0001736C File Offset: 0x0001556C
		public event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceDetached
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)187479786;
				short num2 = num;
				num = (short)389920490;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_82:
					num = (short)1410400257;
					if (num != 0)
					{
					}
					goto IL_AC;
				default:
					num = (short)1460404224;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_67;
					}
					break;
				}
				int num3;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler2;
				for (;;)
				{
					IL_55:
					switch (num3)
					{
					case 0:
						if (deviceEventHandler == deviceEventHandler2)
						{
							num = (short)1656094722;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC;
					case 1:
						goto IL_82;
					case 2:
						goto IL_FD;
					}
					goto IL_67;
				}
				IL_FD:
				num = (short)1678245888;
				short num4 = num;
				return;
				IL_67:
				deviceEventHandler = this.b;
				num = (short)1839071233;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_55;
				IL_AC:
				deviceEventHandler2 = deviceEventHandler;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler)global::System.Delegate.Combine(deviceEventHandler2, value);
				deviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler>(ref this.b, value2, deviceEventHandler2);
				num = (short)453902336;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_55;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)1843396230;
				short num2 = num;
				num = (short)839450246;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AA:
					goto IL_AC;
				default:
					num = (short)121503744;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					break;
				}
				int num3;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler2;
				for (;;)
				{
					IL_54:
					switch (num3)
					{
					case 0:
						if (deviceEventHandler == deviceEventHandler2)
						{
							num = (short)951779330;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC;
					case 1:
						goto IL_AA;
					case 2:
						goto IL_FD;
					}
					goto IL_66;
				}
				IL_FD:
				num = (short)1962999808;
				short num4 = num;
				return;
				IL_66:
				deviceEventHandler = this.b;
				num = (short)2116616193;
				if (num != 0)
				{
				}
				num = (short)1981349889;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
				IL_AC:
				deviceEventHandler2 = deviceEventHandler;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler)global::System.Delegate.Remove(deviceEventHandler2, value);
				deviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler>(ref this.b, value2, deviceEventHandler2);
				num = (short)705101824;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000174A4 File Offset: 0x000156A4
		public bool DeviceChanged(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg pnpMsg)
		{
			short num = (short)614533478;
			short num2 = num;
			num = (short)1637419366;
			switch (num2 == num)
			{
			}
			num = (short)1633157120;
			short num3 = num;
			num = (short)142082049;
			if (num != 0)
			{
			}
			num = (short)1212612608;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600013E RID: 318
		protected abstract void BackgroundThread();

		// Token: 0x0600013F RID: 319 RVA: 0x00017554 File Offset: 0x00015754
		internal void a(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile A_0)
		{
			int a_ = 14;
			short num = (short)2105274678;
			short num2 = num;
			num = (short)520614198;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D1:
				if (this.a == null)
				{
					return;
				}
				num = (short)2057895936;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)502988801;
				if (num != 0)
				{
				}
				num = (short)677576704;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_96;
				}
				break;
			}
			for (;;)
			{
				IL_84:
				switch (num3)
				{
				case 0:
				{
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs deviceMsgEventArgs = new global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs
					{
						PnPAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached
					};
					deviceMsgEventArgs.RadioInfoSet.Add(A_0);
					this.a(this, deviceMsgEventArgs);
					num = (short)283770882;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_D1;
				case 2:
					goto IL_132;
				}
				goto IL_96;
			}
			IL_132:
			num = (short)292028416;
			short num4 = num;
			return;
			IL_96:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("Ὄ὎歐獒᭔㉖⹘筚㥜㩞ᝠ੢٤ɦ啨ၪ嵬ቮ佰卲㑴፶ᵸṺ᥼", a_), new object[]
			{
				A_0.IPAddress
			});
			num = (short)1248854017;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_84;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000176C0 File Offset: 0x000158C0
		internal void b(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile A_0)
		{
			int a_ = 6;
			short num = (short)1282578060;
			short num2 = num;
			num = (short)490116748;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D1:
				if (this.b == null)
				{
					return;
				}
				num = (short)1526136832;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1621360641;
				if (num != 0)
				{
				}
				num = (short)1060110336;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_95;
				}
				break;
			}
			for (;;)
			{
				IL_83:
				switch (num3)
				{
				case 0:
				{
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs deviceMsgEventArgs = new global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs
					{
						PnPAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached
					};
					deviceMsgEventArgs.RadioInfoSet.Add(A_0);
					this.b(this, deviceMsgEventArgs);
					num = (short)2131558402;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_D1;
				case 2:
					goto IL_131;
				}
				goto IL_95;
			}
			IL_131:
			num = (short)1217265664;
			short num4 = num;
			return;
			IL_95:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᝄᝆ獈歊ौ⩎❐㩒㙔㉖敘⁚浜≞彠䍢㝤ɦѨѪ᭬੮ᕰ", a_), new object[]
			{
				A_0.IPAddress
			});
			num = (short)728760321;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_83;
		}

		// Token: 0x040000B3 RID: 179
		protected global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType _detectorType;

		// Token: 0x040000B4 RID: 180
		protected global::System.Threading.Thread _backgroundThread;

		// Token: 0x040000B5 RID: 181
		protected bool _isStopping;

		// Token: 0x040000B6 RID: 182
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler a;

		// Token: 0x040000B7 RID: 183
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler b;
	}
}
