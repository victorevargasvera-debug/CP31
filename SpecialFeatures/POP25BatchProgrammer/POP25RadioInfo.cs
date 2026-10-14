using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml.Serialization;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.POP25BatchProgrammer
{
	// Token: 0x020000A4 RID: 164
	[global::System.Xml.Serialization.XmlType("Radio")]
	[global::System.Serializable]
	public class POP25RadioInfo : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x000DC074 File Offset: 0x000DA274
		// (set) Token: 0x06000B5C RID: 2908 RVA: 0x000DC128 File Offset: 0x000DA328
		public string Radio_ID
		{
			get
			{
				short num = (short)605028352;
				short num2 = num;
				num = (short)2028560665;
				short num3 = num;
				num = (short)617832729;
				switch (num3 == num)
				{
				}
				num = (short)535101441;
				if (num != 0)
				{
				}
				num = (short)652673024;
				if (num != 0)
				{
				}
				return this.radioID;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_30;
				}
				int num;
				int num3;
				short num4;
				int num7;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						int num2;
						if (num2 > num3)
						{
							num4 = (short)1534132229;
							num = (int)((global::System.IntPtr)num4);
							continue;
						}
						goto IL_1E1;
					}
					case 1:
						num4 = (short)590610432;
						num = (int)((global::System.IntPtr)num4);
						continue;
					case 2:
					{
						num4 = (short)506724352;
						short num5 = num4;
						if (this.radioID == "")
						{
							num4 = (short)1779564547;
							num = (int)((global::System.IntPtr)num4);
							continue;
						}
						goto IL_F9;
					}
					case 3:
						goto IL_A6;
					case 4:
					{
						int num2;
						if (!int.TryParse(value, out num2))
						{
							num4 = (short)2146828295;
							num = (int)((global::System.IntPtr)num4);
							continue;
						}
						num4 = (short)1658322950;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					case 5:
						goto IL_DF;
					case 6:
					{
						num4 = (short)2073016577;
						short num6 = num4;
						num4 = (short)2036381953;
						switch ((num6 == num4) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F9;
						default:
						{
							num4 = (short)2082013184;
							if (num4 != 0)
							{
							}
							int num2;
							if (num2 >= num7)
							{
								num4 = (short)707133441;
								num = (int)((global::System.IntPtr)num4);
								continue;
							}
							goto IL_F1;
						}
						}
						break;
					}
					case 7:
						goto IL_134;
					}
					goto IL_30;
					IL_F9:
					num4 = (short)542965764;
					num = (int)((global::System.IntPtr)num4);
				}
				IL_A6:
				this.Radio_ID_Valid = true;
				return;
				IL_DF:
				IL_F1:
				this.Radio_ID_Valid = false;
				return;
				IL_134:
				num4 = (short)562364417;
				if (num4 != 0)
				{
				}
				this.Radio_ID_Valid = false;
				return;
				IL_1E1:
				this.Radio_ID_Valid = true;
				return;
				IL_30:
				this.radioID = value;
				num7 = 1;
				num3 = 16777211;
				num4 = (short)863895554;
				num = (int)((global::System.IntPtr)num4);
				goto IL_0A;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x000DC320 File Offset: 0x000DA520
		// (set) Token: 0x06000B5E RID: 2910 RVA: 0x000DC3D4 File Offset: 0x000DA5D4
		public string Radio_IP
		{
			get
			{
				short num = (short)68812800;
				short num2 = num;
				num = (short)899530579;
				short num3 = num;
				num = (short)1408089939;
				switch (num3 == num)
				{
				}
				num = (short)1853030401;
				if (num != 0)
				{
				}
				num = (short)808321024;
				if (num != 0)
				{
				}
				return this.radioIpAddr;
			}
			set
			{
				int a_ = 5;
				short num = (short)262144;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_88;
					}
					string[] array;
					for (;;)
					{
						IL_31:
						int num4;
						switch (num2)
						{
						case 0:
							goto IL_38F;
						case 1:
							if (array.Length != 4)
							{
								num = (short)1578696708;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1687093266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_2E9;
						case 3:
						{
							int num3;
							if (num3 >= 0)
							{
								num = (short)1778712583;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2E9;
						}
						case 4:
							this.Radio_IP_Valid = false;
							num = (short)356712463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (this.radioIpAddr == "")
							{
								num = (short)1925840910;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2037448705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							int num3;
							string[] array2;
							if (!int.TryParse(array2[num4], out num3))
							{
								num = (short)1768030221;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1468465155;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							num = (short)704315392;
							short num5 = num;
							num = (short)1779499016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							int num3;
							if (num3 > 255)
							{
								num = (short)1297022978;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_197;
						}
						case 9:
							goto IL_260;
						case 10:
							goto IL_197;
						case 11:
							goto IL_38F;
						case 12:
							goto IL_197;
						case 13:
							goto IL_151;
						case 14:
							this.Radio_IP_Valid = true;
							num = (short)347865099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							goto IL_38F;
						case 16:
						{
							this.Radio_IP_Valid = true;
							string[] array2 = array;
							num4 = 0;
							num = (short)1899823123;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 17:
						{
							string[] array2;
							if (num4 >= array2.Length)
							{
								num = (short)477954048;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)665714694;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 18:
							if (array != null)
							{
								num = (short)208535568;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_38F;
						case 19:
							goto IL_260;
						}
						goto IL_88;
						IL_151:
						this.Radio_IP_Valid = false;
						num = (short)151781388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_38F:
						num = (short)1477657159;
						short num6 = num;
						num = (short)1994539591;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_151;
						default:
							goto IL_3C5;
						}
						IL_197:
						num4++;
						num = (short)650313737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_260:
						num = (short)1536032785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2E9:
						this.Radio_IP_Valid = false;
						num = (short)663355402;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3C5:
					num = (short)1626013696;
					if (num != 0)
					{
					}
					this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda87ﾏ춑\udd93욕", a_)));
					return;
					IL_88:
					this.radioIpAddr = value;
					array = value.Split(new char[]
					{
						'.'
					});
					num = (short)2107244545;
					if (num != 0)
					{
					}
					num = (short)738525189;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				}
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x000DC7D8 File Offset: 0x000DA9D8
		// (set) Token: 0x06000B60 RID: 2912 RVA: 0x000DC888 File Offset: 0x000DAA88
		[global::System.Xml.Serialization.XmlIgnore]
		public bool Radio_ID_Valid
		{
			get
			{
				short num = (short)60586588;
				short num2 = num;
				num = (short)726956636;
				switch (num2 == num)
				{
				}
				num = (short)801243137;
				if (num != 0)
				{
				}
				num = (short)1593049088;
				short num3 = num;
				num = (short)1293877248;
				if (num != 0)
				{
				}
				return this.radioId_valid;
			}
			set
			{
				short num = (short)1925249781;
				short num2 = num;
				num = (short)222886645;
				switch (num2 == num)
				{
				}
				num = (short)2017263617;
				if (num != 0)
				{
				}
				num = (short)1554579456;
				short num3 = num;
				num = (short)1662386176;
				if (num != 0)
				{
				}
				this.radioId_valid = value;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x000DC938 File Offset: 0x000DAB38
		// (set) Token: 0x06000B62 RID: 2914 RVA: 0x000DC9E8 File Offset: 0x000DABE8
		[global::System.Xml.Serialization.XmlIgnore]
		public bool Radio_IP_Valid
		{
			get
			{
				short num = (short)1502369091;
				short num2 = num;
				num = (short)1413502275;
				switch (num2 == num)
				{
				}
				num = (short)1822031873;
				if (num != 0)
				{
				}
				num = (short)2116288512;
				short num3 = num;
				num = (short)631701504;
				if (num != 0)
				{
				}
				return this.radioIp_valid;
			}
			set
			{
				short num = (short)264114122;
				short num2 = num;
				num = (short)1356271562;
				switch (num2 == num)
				{
				}
				num = (short)2116943873;
				if (num != 0)
				{
				}
				num = (short)1877737472;
				short num3 = num;
				num = (short)2076180480;
				if (num != 0)
				{
				}
				this.radioIp_valid = value;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x000DCA98 File Offset: 0x000DAC98
		// (set) Token: 0x06000B64 RID: 2916 RVA: 0x000DCB48 File Offset: 0x000DAD48
		[global::System.Xml.Serialization.XmlIgnore]
		public string Status
		{
			get
			{
				short num = (short)258867271;
				short num2 = num;
				num = (short)1333723207;
				switch (num2 == num)
				{
				}
				num = (short)1493762049;
				if (num != 0)
				{
				}
				num = (short)1905655808;
				short num3 = num;
				num = (short)934543360;
				if (num != 0)
				{
				}
				return this.status;
			}
			set
			{
				int a_ = 2;
				short num = (short)73924609;
				if (num != 0)
				{
				}
				num = (short)2144584118;
				short num2 = num;
				num = (short)1131397558;
				switch (num2 == num)
				{
				}
				num = (short)199294976;
				short num3 = num;
				num = (short)1186988032;
				if (num != 0)
				{
				}
				this.status = value;
				this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횄ﾊﲎ", a_)));
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x000DCC18 File Offset: 0x000DAE18
		// (set) Token: 0x06000B66 RID: 2918 RVA: 0x000DCCCC File Offset: 0x000DAECC
		[global::System.Xml.Serialization.XmlIgnore]
		public bool Radio_IP_ARS_Check
		{
			get
			{
				short num = (short)893297178;
				short num2 = num;
				num = (short)1314234906;
				switch (num2 == num)
				{
				}
				num = (short)235143168;
				if (num != 0)
				{
				}
				num = (short)700317696;
				short num3 = num;
				num = (short)815071233;
				if (num != 0)
				{
				}
				return this.radioIpARScheck;
			}
			set
			{
				int a_ = 13;
				short num = (short)1160197490;
				short num2 = num;
				num = (short)1127232882;
				switch (num2 == num)
				{
				}
				num = (short)688259073;
				if (num != 0)
				{
				}
				num = (short)204341248;
				short num3 = num;
				num = (short)590020608;
				if (num != 0)
				{
				}
				this.radioIpARScheck = value;
				this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슏ﾕ얙햛캝ﾟ쒫쮭펯\ud9b1", a_)));
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x000DCDA0 File Offset: 0x000DAFA0
		// (set) Token: 0x06000B68 RID: 2920 RVA: 0x000DCE54 File Offset: 0x000DB054
		[global::System.Xml.Serialization.XmlIgnore]
		public bool Radio_ID_Check
		{
			get
			{
				short num = (short)1090632611;
				short num2 = num;
				num = (short)1002290083;
				switch (num2 == num)
				{
				}
				num = (short)574488577;
				if (num != 0)
				{
				}
				num = (short)1685061632;
				short num3 = num;
				num = (short)100073472;
				if (num != 0)
				{
				}
				return this.radioIdcheck;
			}
			set
			{
				int a_ = 12;
				short num = (short)422216719;
				short num2 = num;
				num = (short)1600422927;
				switch (num2 == num)
				{
				}
				num = (short)1734213633;
				if (num != 0)
				{
				}
				num = (short)1333592064;
				short num3 = num;
				num = (short)884080640;
				if (num != 0)
				{
				}
				this.radioIdcheck = value;
				this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8eﲔ욘튚\ud99c삞쮢삤쒦슨", a_)));
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x000DCF28 File Offset: 0x000DB128
		// (set) Token: 0x06000B6A RID: 2922 RVA: 0x000DCFD8 File Offset: 0x000DB1D8
		[global::System.Xml.Serialization.XmlIgnore]
		internal int IndexInList
		{
			get
			{
				short num = (short)572104890;
				short num2 = num;
				num = (short)774217914;
				switch (num2 == num)
				{
				}
				num = (short)1811087361;
				if (num != 0)
				{
				}
				num = (short)1279590400;
				short num3 = num;
				num = (short)1926037504;
				if (num != 0)
				{
				}
				return this.indexInList;
			}
			set
			{
				int a_ = 0;
				short num = (short)588768884;
				short num2 = num;
				num = (short)174974580;
				switch (num2 == num)
				{
				}
				num = (short)1095041025;
				if (num != 0)
				{
				}
				num = (short)898301952;
				short num3 = num;
				num = (short)1562181632;
				if (num != 0)
				{
				}
				this.indexInList = value;
				this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪂쒌\udd90朗", a_)));
			}
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x000DD0A8 File Offset: 0x000DB2A8
		public void OnPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			short num = (short)234618881;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					num = (short)2039087105;
					if (num != 0)
					{
					}
					this.PropertyChanged(this, e);
					goto IL_FE;
				}
				IL_31:
				num = (short)196608000;
				short num3 = num;
				if (this.PropertyChanged == null)
				{
					break;
				}
				num = (short)373978323;
				short num4 = num;
				num = (short)1207465171;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)464519168;
					if (num != 0)
					{
					}
					num = (short)1111162882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_FE:
				num = (short)2131820544;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000B6C RID: 2924 RVA: 0x000DD1CC File Offset: 0x000DB3CC
		// (remove) Token: 0x06000B6D RID: 2925 RVA: 0x000DD308 File Offset: 0x000DB508
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
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
						return;
					case 1:
						goto IL_3A;
					case 2:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)903151616;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3A;
					}
					goto IL_1C;
					IL_3A:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
					num2 = (short)993606408;
					short num3 = num2;
					num2 = (short)1415461640;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)917766145;
						if (num2 != 0)
						{
						}
						num2 = (short)725286912;
						short num4 = num2;
						num2 = (short)1735131136;
						if (num2 != 0)
						{
						}
						num2 = (short)1097859074;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				propertyChangedEventHandler = this.PropertyChanged;
				num2 = (short)1739980801;
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
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
						return;
					case 1:
						goto IL_39;
					case 2:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)863436800;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					}
					goto IL_1C;
					IL_39:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
					num2 = (short)2005628613;
					short num3 = num2;
					num2 = (short)1987671749;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)572129281;
						if (num2 != 0)
						{
						}
						num2 = (short)525664256;
						short num4 = num2;
						num2 = (short)1892941824;
						if (num2 != 0)
						{
						}
						num2 = (short)1599143938;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				propertyChangedEventHandler = this.PropertyChanged;
				num2 = (short)1728053249;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x040004F0 RID: 1264
		public string radioIpAddr = "";

		// Token: 0x040004F1 RID: 1265
		public string radioID = "";

		// Token: 0x040004F2 RID: 1266
		private bool radioId_valid = true;

		// Token: 0x040004F3 RID: 1267
		private bool radioIp_valid = true;

		// Token: 0x040004F4 RID: 1268
		private string status = "";

		// Token: 0x040004F5 RID: 1269
		private bool radioIpARScheck = true;

		// Token: 0x040004F6 RID: 1270
		private bool radioIdcheck = true;

		// Token: 0x040004F7 RID: 1271
		private int indexInList;
	}
}
