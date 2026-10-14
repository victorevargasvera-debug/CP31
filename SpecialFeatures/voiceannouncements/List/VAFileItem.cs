using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements.List
{
	// Token: 0x02000022 RID: 34
	public class VAFileItem : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000592 RID: 1426 RVA: 0x00052378 File Offset: 0x00050578
		// (remove) Token: 0x06000593 RID: 1427 RVA: 0x000524B0 File Offset: 0x000506B0
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num2;
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
					for (;;)
					{
						IL_0A:
						int num;
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num)
						{
						case 0:
							goto IL_AD;
						case 1:
							goto IL_FC;
						case 2:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num2 = (short)1158545409;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_AD;
						}
						break;
						IL_AD:
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.a, value2, propertyChangedEventHandler2);
						num2 = (short)1345454082;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					propertyChangedEventHandler = this.a;
					num2 = (short)1580284110;
					short num3 = num2;
					num2 = (short)1853765838;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1682178049;
						if (num2 != 0)
						{
						}
						num2 = (short)1039400960;
						if (num2 != 0)
						{
						}
						num2 = (short)769982464;
						int num = (int)((global::System.IntPtr)num2);
						goto IL_0A;
					}
					}
				}
				IL_FC:
				num2 = (short)1451360256;
				short num4 = num2;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num2;
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
					for (;;)
					{
						IL_0A:
						int num;
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num)
						{
						case 0:
							goto IL_B0;
						case 1:
							goto IL_FF;
						case 2:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num2 = (short)722599937;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_B0;
						}
						break;
						IL_B0:
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.a, value2, propertyChangedEventHandler2);
						num2 = (short)148045826;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					propertyChangedEventHandler = this.a;
					num2 = (short)1663959041;
					if (num2 != 0)
					{
					}
					num2 = (short)741975313;
					short num3 = num2;
					num2 = (short)975611153;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1097859072;
						if (num2 != 0)
						{
						}
						num2 = (short)1425014784;
						int num = (int)((global::System.IntPtr)num2);
						goto IL_0A;
					}
					}
				}
				IL_FF:
				num2 = (short)2135228416;
				short num4 = num2;
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x000525E8 File Offset: 0x000507E8
		protected void OnPropertyChanged(string name)
		{
			short num = (short)510327241;
			short num2 = num;
			num = (short)873331145;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_AC:
				num = (short)2051145730;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)235339776;
				if (num != 0)
				{
				}
				num = (short)443351040;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				num = (short)846200832;
				short num4 = num;
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_A4;
					}
					continue;
				case 1:
					return;
				case 2:
					num = (short)1525481473;
					if (num != 0)
					{
					}
					this.a(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
					num = (short)868876289;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
			}
			IL_A4:
			if (this.a != null)
			{
				goto IL_AC;
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x000026AB File Offset: 0x000008AB
		public VAFileItem(string fileName, global::System.Guid uuid)
		{
			this.FileName = fileName;
			this.SoftwareUuid = uuid;
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x0005270C File Offset: 0x0005090C
		// (set) Token: 0x06000597 RID: 1431 RVA: 0x000527BC File Offset: 0x000509BC
		public string FileName
		{
			get
			{
				short num = (short)284491776;
				short num2 = num;
				num = (short)1266772286;
				short num3 = num;
				num = (short)799172926;
				switch (num3 == num)
				{
				}
				num = (short)811532289;
				if (num != 0)
				{
				}
				num = (short)726269952;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)658898944;
				short num2 = num;
				num = (short)1404485279;
				short num3 = num;
				num = (short)1635499679;
				switch (num3 == num)
				{
				}
				num = (short)186056705;
				if (num != 0)
				{
				}
				num = (short)22020096;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x0005286C File Offset: 0x00050A6C
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x0005291C File Offset: 0x00050B1C
		public global::System.Guid SoftwareUuid
		{
			get
			{
				short num = (short)1269825536;
				short num2 = num;
				num = (short)614363929;
				short num3 = num;
				num = (short)1189835545;
				switch (num3 == num)
				{
				}
				num = (short)1975975936;
				if (num != 0)
				{
				}
				num = (short)1484062721;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)2026504192;
				short num2 = num;
				num = (short)1911090474;
				short num3 = num;
				num = (short)2142170410;
				switch (num3 == num)
				{
				}
				num = (short)671940609;
				if (num != 0)
				{
				}
				num = (short)941948928;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x000529CC File Offset: 0x00050BCC
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x00052A7C File Offset: 0x00050C7C
		public global::SpecialFeatures.VoiceAnnouncements.List.TheDownloadStatuses DownloadStatus
		{
			get
			{
				short num = (short)2003173376;
				short num2 = num;
				num = (short)1538112164;
				short num3 = num;
				num = (short)940489380;
				switch (num3 == num)
				{
				}
				num = (short)739442689;
				if (num != 0)
				{
				}
				num = (short)1633026048;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				int a_ = 3;
				short num = (short)546556993;
				short num2 = num;
				num = (short)1624099905;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_DC:
					num = (short)826933250;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)394788864;
					if (num != 0)
					{
					}
					num = (short)1576599552;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						num = (short)44105729;
						if (num != 0)
						{
						}
						num = (short)1607335936;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_D3;
						}
						continue;
					}
					case 1:
						return;
					case 2:
						this.d = value;
						this.OnPropertyChanged(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슅ﶉﾏ얕ﮙ펟", a_));
						num = (short)1547698177;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_D3:
				if (this.d != value)
				{
					goto IL_DC;
				}
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x00052BAC File Offset: 0x00050DAC
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x00052C58 File Offset: 0x00050E58
		internal string FullPathAndName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1435828224;
				short num2 = num;
				num = (short)2134449537;
				short num3 = num;
				num = (short)1323703681;
				switch (num3 == num)
				{
				}
				num = (short)795148289;
				if (num != 0)
				{
				}
				num = (short)1618149376;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)248446976;
				short num2 = num;
				num = (short)1827263442;
				short num3 = num;
				num = (short)579326930;
				switch (num3 == num)
				{
				}
				num = (short)1148190720;
				if (num != 0)
				{
				}
				num = (short)96337921;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x0400025D RID: 605
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler a;

		// Token: 0x0400025E RID: 606
		private string b;

		// Token: 0x0400025F RID: 607
		private global::System.Guid c;

		// Token: 0x04000260 RID: 608
		private global::SpecialFeatures.VoiceAnnouncements.List.TheDownloadStatuses d;

		// Token: 0x04000261 RID: 609
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string e;
	}
}
