using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.CloneWiFi
{
	// Token: 0x0200019B RID: 411
	public class WiFiRecord : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x001C58BC File Offset: 0x001C3ABC
		// (set) Token: 0x06001396 RID: 5014 RVA: 0x001C5968 File Offset: 0x001C3B68
		public string SSID
		{
			get
			{
				short num = (short)111673344;
				short num2 = num;
				num = (short)563571261;
				short num3 = num;
				num = (short)1329752637;
				switch (num3 == num)
				{
				}
				num = (short)2032599040;
				if (num != 0)
				{
				}
				num = (short)1075576833;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				int a_ = 5;
				short num = (short)359162849;
				short num2 = num;
				num = (short)587883489;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1635581953;
					if (num != 0)
					{
					}
					num = (short)1205469184;
					if (num != 0)
					{
					}
					num = (short)1164640256;
					short num3 = num;
					if (!(this.b == value))
					{
						this.b = value;
						this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb87\ud989얋쪍", a_)));
						return;
					}
					break;
				}
				}
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001397 RID: 5015 RVA: 0x001C5A4C File Offset: 0x001C3C4C
		// (set) Token: 0x06001398 RID: 5016 RVA: 0x001C5AFC File Offset: 0x001C3CFC
		public global::SpecialFeatures.CloneWiFi.WiFiPwd PWD
		{
			get
			{
				short num = (short)1976369152;
				short num2 = num;
				num = (short)9633793;
				if (num != 0)
				{
				}
				num = (short)485562570;
				short num3 = num;
				num = (short)2032015562;
				switch (num3 == num)
				{
				}
				num = (short)1839398912;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				int a_ = 10;
				short num = (short)1889678903;
				short num2 = num;
				num = (short)1018246711;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1666842624;
					if (num != 0)
					{
					}
					if (this.a != value)
					{
						num = (short)1034289153;
						if (num != 0)
						{
						}
						this.a = value;
						this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8c\ud88e햐", a_)));
						return;
					}
					num = (short)2093285376;
					short num3 = num;
					break;
				}
				}
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x001C5BE0 File Offset: 0x001C3DE0
		// (set) Token: 0x0600139A RID: 5018 RVA: 0x001C5C94 File Offset: 0x001C3E94
		public string FeatureName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)663289856;
				short num2 = num;
				num = (short)1416899115;
				short num3 = num;
				num = (short)1261972011;
				switch (num3 == num)
				{
				}
				num = (short)623509504;
				if (num != 0)
				{
				}
				num = (short)927989761;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1604976640;
				short num2 = num;
				num = (short)118606619;
				short num3 = num;
				num = (short)217107227;
				switch (num3 == num)
				{
				}
				num = (short)1308426240;
				if (num != 0)
				{
				}
				num = (short)1532952577;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x001C5D44 File Offset: 0x001C3F44
		public void OnPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			short num = (short)1962934273;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					this.d(this, e);
					num = (short)585727564;
					short num3 = num;
					num = (short)2053865036;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)759431169;
						if (num != 0)
						{
						}
						num = (short)1590951936;
						if (num != 0)
						{
						}
						num = (short)821100546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					return;
				}
				IL_31:
				num = (short)113377280;
				short num4 = num;
				if (this.d == null)
				{
					break;
				}
				num = (short)1033502720;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x0600139C RID: 5020 RVA: 0x001C5E68 File Offset: 0x001C4068
		// (remove) Token: 0x0600139D RID: 5021 RVA: 0x001C5FA4 File Offset: 0x001C41A4
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)1325465601;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				int num2;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_32:
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num2)
					{
					case 0:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num = (short)124649474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D9;
					case 1:
						goto IL_D9;
					case 2:
						goto IL_12A;
					}
					goto IL_44;
					IL_D9:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.d, value2, propertyChangedEventHandler2);
					num = (short)380698624;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12A:
				return;
				IL_44:
				num = (short)1743425696;
				short num3 = num;
				num = (short)2115276960;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				case 1:
					break;
				default:
				{
					num = (short)1608122368;
					short num4 = num;
					break;
				}
				}
				num = (short)1130758144;
				if (num != 0)
				{
				}
				propertyChangedEventHandler = this.d;
				num = (short)748355585;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				short num2;
				for (;;)
				{
					IL_0A:
					int num;
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)243662850;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_D5;
					case 1:
						goto IL_D5;
					case 2:
						goto IL_125;
					}
					goto IL_1C;
					IL_D5:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.d, value2, propertyChangedEventHandler2);
					num2 = (short)715653120;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_125:
				return;
				IL_1C:
				num2 = (short)1473297702;
				short num3 = num2;
				num2 = (short)1012514086;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num2 = (short)305856512;
					short num4 = num2;
					num2 = (short)124911617;
					if (num2 != 0)
					{
					}
					num2 = (short)573440000;
					if (num2 != 0)
					{
					}
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler = this.d;
					num2 = (short)1502543873;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x04000AB1 RID: 2737
		private global::SpecialFeatures.CloneWiFi.WiFiPwd a;

		// Token: 0x04000AB2 RID: 2738
		private string b;

		// Token: 0x04000AB3 RID: 2739
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;

		// Token: 0x04000AB4 RID: 2740
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler d;
	}
}
