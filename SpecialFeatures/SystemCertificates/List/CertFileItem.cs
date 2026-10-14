using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.SystemCertificates.List
{
	// Token: 0x020001A6 RID: 422
	public class CertFileItem : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x1400001B RID: 27
		// (add) Token: 0x060013F3 RID: 5107 RVA: 0x001CF330 File Offset: 0x001CD530
		// (remove) Token: 0x060013F4 RID: 5108 RVA: 0x001CF464 File Offset: 0x001CD664
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				short num;
				int num3;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)1675130097;
					short num2 = num;
					num = (short)1841984753;
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)711720960;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num = (short)1632960514;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_AC;
						case 1:
						{
							num = (short)64552960;
							short num4 = num;
							goto IL_AC;
						}
						case 2:
							return;
						}
						goto IL_66;
					}
					IL_AC:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.a, value2, propertyChangedEventHandler2);
					num = (short)1443495937;
					if (num != 0)
					{
					}
					num = (short)1823997952;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_66:
				propertyChangedEventHandler = this.a;
				num = (short)436011009;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)615972865;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8B;
				}
				int num3;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_30:
					num = (short)308997452;
					short num2 = num;
					num = (short)210496844;
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1634009088;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num = (short)1323237378;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D4;
						case 1:
							goto IL_D4;
						case 2:
							return;
						}
						goto IL_8B;
					}
					IL_D4:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.a, value2, propertyChangedEventHandler2);
					num = (short)734724096;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_8B:
				propertyChangedEventHandler = this.a;
				num = (short)1789132800;
				short num4 = num;
				num = (short)2046164993;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x001CF598 File Offset: 0x001CD798
		protected void OnPropertyChanged(string name)
		{
			short num = (short)1265106945;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)524288001;
					if (num != 0)
					{
					}
					num = (short)1659633664;
					short num3 = num;
					this.a(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
					num = (short)1990524930;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					num = (short)129755467;
					short num4 = num;
					num = (short)621078859;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_85;
					default:
						num = (short)628555776;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7A;
						}
						continue;
					}
					break;
				}
				case 2:
					return;
				}
				goto IL_7A;
				IL_85:
				num = (short)1255145472;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7A:
				if (this.a != null)
				{
					goto IL_85;
				}
				break;
			}
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x00003852 File Offset: 0x00001A52
		public CertFileItem(string fileName, global::System.Guid uuid)
		{
			this.FileName = fileName;
			this.SoftwareUuid = uuid;
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x001CF6BC File Offset: 0x001CD8BC
		// (set) Token: 0x060013F8 RID: 5112 RVA: 0x001CF76C File Offset: 0x001CD96C
		public string FileName
		{
			get
			{
				short num = (short)37214684;
				short num2 = num;
				num = (short)408213980;
				switch (num2 == num)
				{
				}
				num = (short)140902400;
				short num3 = num;
				num = (short)968359936;
				if (num != 0)
				{
				}
				num = (short)1151139841;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)558607293;
				short num2 = num;
				num = (short)1135258557;
				switch (num2 == num)
				{
				}
				num = (short)194641920;
				short num3 = num;
				num = (short)490340352;
				if (num != 0)
				{
				}
				num = (short)2121138177;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x001CF81C File Offset: 0x001CDA1C
		// (set) Token: 0x060013FA RID: 5114 RVA: 0x001CF8CC File Offset: 0x001CDACC
		public global::System.Guid SoftwareUuid
		{
			get
			{
				short num = (short)845086464;
				short num2 = num;
				num = (short)797179648;
				switch (num2 == num)
				{
				}
				num = (short)321060864;
				short num3 = num;
				num = (short)1026359297;
				if (num != 0)
				{
				}
				num = (short)1554055168;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1417805825;
				if (num != 0)
				{
				}
				num = (short)522488639;
				short num2 = num;
				num = (short)1204652863;
				switch (num2 == num)
				{
				default:
				{
					num = (short)684785664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1741225984;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x001CF97C File Offset: 0x001CDB7C
		// (set) Token: 0x060013FC RID: 5116 RVA: 0x001CFA28 File Offset: 0x001CDC28
		public global::SpecialFeatures.SystemCertificates.List.TheDownloadStatuses DownloadStatus
		{
			get
			{
				short num = (short)2033889124;
				short num2 = num;
				num = (short)276279140;
				switch (num2 == num)
				{
				}
				num = (short)1940652032;
				short num3 = num;
				num = (short)239665152;
				if (num != 0)
				{
				}
				num = (short)1965096961;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				int a_ = 12;
				short num = (short)314441729;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)371326977;
						if (num != 0)
						{
						}
						num = (short)791085056;
						short num3 = num;
						this.d = value;
						this.OnPropertyChanged(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮎ﺐﮔﮖ漢列첞햠슢톤튦\udaa8", a_));
						num = (short)1328676866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)1792128285;
						short num4 = num;
						num = (short)605730077;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8F;
						default:
							num = (short)748027904;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_83;
							}
							continue;
						}
						break;
					}
					case 2:
						return;
					}
					goto IL_83;
					IL_8F:
					num = (short)207486976;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_83:
					if (this.d != value)
					{
						goto IL_8F;
					}
					break;
				}
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x001CFB60 File Offset: 0x001CDD60
		// (set) Token: 0x060013FE RID: 5118 RVA: 0x001CFC10 File Offset: 0x001CDE10
		internal string FullPathAndName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1037909422;
				short num2 = num;
				num = (short)2131967406;
				switch (num2 == num)
				{
				}
				num = (short)190316544;
				short num3 = num;
				num = (short)1903296513;
				if (num != 0)
				{
				}
				num = (short)1570242560;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1404213915;
				short num2 = num;
				num = (short)86284955;
				switch (num2 == num)
				{
				}
				num = (short)2099576832;
				short num3 = num;
				num = (short)1693712384;
				if (num != 0)
				{
				}
				num = (short)32636929;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x04000B02 RID: 2818
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler a;

		// Token: 0x04000B03 RID: 2819
		private string b;

		// Token: 0x04000B04 RID: 2820
		private global::System.Guid c;

		// Token: 0x04000B05 RID: 2821
		private global::SpecialFeatures.SystemCertificates.List.TheDownloadStatuses d;

		// Token: 0x04000B06 RID: 2822
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string e;
	}
}
