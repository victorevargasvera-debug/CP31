using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.CloneWiFi
{
	// Token: 0x0200019A RID: 410
	public class WiFiPwd : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x001C5100 File Offset: 0x001C3300
		// (set) Token: 0x0600138E RID: 5006 RVA: 0x001C51B0 File Offset: 0x001C33B0
		public bool IsValid
		{
			get
			{
				short num = (short)1998585856;
				short num2 = num;
				num = (short)2051146094;
				short num3 = num;
				num = (short)722731374;
				switch (num3 == num)
				{
				}
				num = (short)1539309569;
				if (num != 0)
				{
				}
				num = (short)725024768;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				int a_ = 19;
				short num = (short)1117519873;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)649330688;
					short num3 = num;
					switch (num2)
					{
					case 0:
					{
						this.b = value;
						this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95척ﶛ즟욡", a_)));
						num = (short)2081194210;
						short num4 = num;
						num = (short)1941012706;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)307822592;
							if (num != 0)
							{
							}
							num = (short)549781506;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						num = (short)477954049;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_87;
						}
						continue;
					case 2:
						return;
					}
					IL_87:
					if (this.b == value)
					{
						break;
					}
					num = (short)1501036544;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x001C52EC File Offset: 0x001C34EC
		// (set) Token: 0x06001390 RID: 5008 RVA: 0x001C539C File Offset: 0x001C359C
		public string Content
		{
			get
			{
				short num = (short)703266816;
				short num2 = num;
				num = (short)1232217762;
				short num3 = num;
				num = (short)1071195810;
				switch (num3 == num)
				{
				}
				num = (short)1168572416;
				if (num != 0)
				{
				}
				num = (short)297598977;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				int a_ = 2;
				short num = (short)582352896;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_41;
						}
						continue;
					case 1:
						goto IL_D4;
					case 2:
						if (!this.IsValid)
						{
							num = (short)1196294148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						this.a = value;
						this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욄ﾊ", a_)));
						goto IL_145;
					case 4:
						this.IsValid = true;
						num = (short)1893531649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_41:
					if (!(this.a != value))
					{
						return;
					}
					num = (short)829157952;
					short num3 = num;
					num = (short)1202909760;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1285292032;
						if (num != 0)
						{
						}
						num = (short)1391919107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_145:
					num = (short)1263206402;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D4:
				num = (short)359399424;
				short num4 = num;
				num = (short)1653014529;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x001C552C File Offset: 0x001C372C
		public void OnPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			short num = (short)1651310593;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					this.c(this, e);
					num = (short)40727857;
					short num3 = num;
					num = (short)151745841;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)797638656;
						if (num != 0)
						{
						}
						num = (short)707657730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					return;
				}
				IL_30:
				num = (short)467861504;
				short num4 = num;
				num = (short)829423617;
				if (num != 0)
				{
				}
				if (this.c == null)
				{
					break;
				}
				num = (short)413990912;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06001392 RID: 5010 RVA: 0x001C564C File Offset: 0x001C384C
		// (remove) Token: 0x06001393 RID: 5011 RVA: 0x001C5784 File Offset: 0x001C3984
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
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
							num2 = (short)1468465153;
							if (num2 != 0)
							{
							}
							num2 = (short)1602945026;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_B0;
					case 1:
						goto IL_B0;
					case 2:
						goto IL_128;
					}
					goto IL_1C;
					IL_B0:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.c, value2, propertyChangedEventHandler2);
					num2 = (short)366673920;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_128:
				return;
				IL_1C:
				num2 = (short)1469976314;
				short num3 = num2;
				num2 = (short)534712058;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num2 = (short)621543424;
					short num4 = num2;
					num2 = (short)462815232;
					if (num2 != 0)
					{
					}
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler = this.c;
					num2 = (short)210894849;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
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
							num2 = (short)934150146;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_D9;
					case 1:
						goto IL_D9;
					case 2:
						goto IL_129;
					}
					goto IL_1C;
					IL_D9:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.c, value2, propertyChangedEventHandler2);
					num2 = (short)1893335040;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_129:
				return;
				IL_1C:
				num2 = (short)1377030652;
				short num3 = num2;
				num2 = (short)2115817980;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num2 = (short)684916736;
					short num4 = num2;
					num2 = (short)482344961;
					if (num2 != 0)
					{
					}
					num2 = (short)817823744;
					if (num2 != 0)
					{
					}
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler = this.c;
					num2 = (short)1200816129;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x04000AAE RID: 2734
		private string a = string.Empty;

		// Token: 0x04000AAF RID: 2735
		private bool b;

		// Token: 0x04000AB0 RID: 2736
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler c;
	}
}
