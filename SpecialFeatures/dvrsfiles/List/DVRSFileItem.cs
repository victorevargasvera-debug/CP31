using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.DVRSFiles.List
{
	// Token: 0x02000127 RID: 295
	public class DVRSFileItem : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000FA5 RID: 4005 RVA: 0x001611F4 File Offset: 0x0015F3F4
		// (remove) Token: 0x06000FA6 RID: 4006 RVA: 0x0016132C File Offset: 0x0015F52C
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
				int num;
				short num2;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
					{
						num2 = (short)46792705;
						if (num2 != 0)
						{
						}
						num2 = (short)1197539328;
						short num3 = num2;
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							goto IL_110;
						}
						goto IL_86;
					}
					case 1:
						return;
					case 2:
					{
						num2 = (short)1189543969;
						short num4 = num2;
						num2 = (short)383451169;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_110;
						default:
							num2 = (short)1222311936;
							if (num2 != 0)
							{
							}
							goto IL_86;
						}
						break;
					}
					}
					goto IL_1C;
					IL_86:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.a, value2, propertyChangedEventHandler2);
					num2 = (short)151322624;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_110:
					num2 = (short)856817665;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				propertyChangedEventHandler = this.a;
				num2 = (short)497287170;
				num = (int)((global::System.IntPtr)num2);
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
				short num2;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
					{
						num2 = (short)644022272;
						short num3 = num2;
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							goto IL_10A;
						}
						goto IL_AA;
					}
					case 1:
						return;
					case 2:
					{
						num2 = (short)1127826925;
						short num4 = num2;
						num2 = (short)507069933;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_10A;
						default:
							num2 = (short)1227358208;
							if (num2 != 0)
							{
							}
							num2 = (short)259915777;
							if (num2 != 0)
							{
							}
							goto IL_AA;
						}
						break;
					}
					}
					goto IL_1C;
					IL_AA:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.a, value2, propertyChangedEventHandler2);
					num2 = (short)1085669376;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_10A:
					num2 = (short)2036203521;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				propertyChangedEventHandler = this.a;
				num2 = (short)1557463042;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x00161460 File Offset: 0x0015F660
		protected void OnPropertyChanged(string name)
		{
			short num = (short)1110769666;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1232174932;
				short num3 = num;
				num = (short)1116962644;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2100690945;
					if (num != 0)
					{
					}
					num = (short)1988362240;
					if (num != 0)
					{
					}
					num = (short)1341849600;
					short num4 = num;
					switch (num2)
					{
					case 0:
						this.a(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
						goto IL_FE;
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_CB;
						}
						continue;
					}
					IL_CB:
					if (this.a != null)
					{
						num = (short)1439432704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				}
				IL_FE:
				num = (short)1723531265;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x000034AA File Offset: 0x000016AA
		public DVRSFileItem(string fileName, global::System.Guid uuid)
		{
			this.FileName = fileName;
			this.SoftwareUuid = uuid;
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x00161584 File Offset: 0x0015F784
		// (set) Token: 0x06000FAA RID: 4010 RVA: 0x00161634 File Offset: 0x0015F834
		public string FileName
		{
			get
			{
				short num = (short)854344642;
				short num2 = num;
				num = (short)214385602;
				switch (num2 == num)
				{
				}
				num = (short)242417665;
				if (num != 0)
				{
				}
				num = (short)676528128;
				short num3 = num;
				num = (short)1238564864;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)409665537;
				if (num != 0)
				{
				}
				num = (short)1406693955;
				short num2 = num;
				num = (short)1702326851;
				switch (num2 == num)
				{
				}
				num = (short)674824192;
				short num3 = num;
				num = (short)1378156544;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000FAB RID: 4011 RVA: 0x001616E4 File Offset: 0x0015F8E4
		// (set) Token: 0x06000FAC RID: 4012 RVA: 0x00161794 File Offset: 0x0015F994
		public global::System.Guid SoftwareUuid
		{
			get
			{
				short num = (short)1905647684;
				short num2 = num;
				num = (short)665509956;
				switch (num2 == num)
				{
				}
				num = (short)276299777;
				if (num != 0)
				{
				}
				num = (short)788660224;
				short num3 = num;
				num = (short)62455808;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1630779035;
				short num2 = num;
				num = (short)1499379355;
				switch (num2 == num)
				{
				}
				num = (short)592969729;
				if (num != 0)
				{
				}
				num = (short)1779957760;
				short num3 = num;
				num = (short)1121124352;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000FAD RID: 4013 RVA: 0x00161848 File Offset: 0x0015FA48
		// (set) Token: 0x06000FAE RID: 4014 RVA: 0x001618F8 File Offset: 0x0015FAF8
		public global::SpecialFeatures.DVRSFiles.List.TheDownloadStatuses DownloadStatus
		{
			get
			{
				short num = (short)1818508377;
				short num2 = num;
				num = (short)35011673;
				switch (num2 == num)
				{
				}
				num = (short)298450944;
				if (num != 0)
				{
				}
				num = (short)49545216;
				short num3 = num;
				num = (short)2075590657;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				int a_ = 9;
				short num = (short)2034892802;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)374986072;
					short num3 = num;
					num = (short)1510331736;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)110821376;
						if (num != 0)
						{
						}
						num = (short)1279852544;
						short num4 = num;
						switch (num2)
						{
						case 0:
							this.d = value;
							this.OnPropertyChanged(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좋ﲑ秊聯ﺙ쾛솟횡톣향", a_));
							goto IL_110;
						case 1:
							return;
						case 2:
							num = (short)231604225;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_D1;
							}
							continue;
						}
						IL_D1:
						if (this.d != value)
						{
							num = (short)1127284736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					IL_110:
					num = (short)516292609;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x00161A30 File Offset: 0x0015FC30
		// (set) Token: 0x06000FB0 RID: 4016 RVA: 0x00161AE4 File Offset: 0x0015FCE4
		internal string FullPathAndName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1077542913;
				if (num != 0)
				{
				}
				num = (short)1837691219;
				short num2 = num;
				num = (short)1165226323;
				switch (num2 == num)
				{
				}
				num = (short)1408696320;
				short num3 = num;
				num = (short)1539244032;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)537776744;
				short num2 = num;
				num = (short)1254937192;
				switch (num2 == num)
				{
				}
				num = (short)143392769;
				if (num != 0)
				{
				}
				num = (short)557187072;
				short num3 = num;
				num = (short)1965686784;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x0400081B RID: 2075
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler a;

		// Token: 0x0400081C RID: 2076
		private string b;

		// Token: 0x0400081D RID: 2077
		private global::System.Guid c;

		// Token: 0x0400081E RID: 2078
		private global::SpecialFeatures.DVRSFiles.List.TheDownloadStatuses d;

		// Token: 0x0400081F RID: 2079
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string e;
	}
}
