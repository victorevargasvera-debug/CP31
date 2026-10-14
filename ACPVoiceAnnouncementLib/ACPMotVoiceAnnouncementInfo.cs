using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace ACPVoiceAnnouncementLib
{
	// Token: 0x02000018 RID: 24
	public class ACPMotVoiceAnnouncementInfo : global::System.IEquatable<global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo>, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000061C4 File Offset: 0x000043C4
		internal byte[] CompressedData
		{
			get
			{
				short num = (short)742819576;
				short num2 = num;
				num = (short)281904888;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2045640704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)754712576;
				if (num != 0)
				{
				}
				num = (short)1547894785;
				if (num != 0)
				{
				}
				return this.k;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00006274 File Offset: 0x00004474
		internal int CompressionParam
		{
			get
			{
				short num = (short)389263457;
				short num2 = num;
				num = (short)1054912609;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1144127488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1971322881;
				if (num != 0)
				{
				}
				num = (short)1697185792;
				if (num != 0)
				{
				}
				return this.q;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00006324 File Offset: 0x00004524
		public string FileName
		{
			get
			{
				short num = (short)376977008;
				short num2 = num;
				num = (short)1703622256;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1119485952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)250019841;
				if (num != 0)
				{
				}
				num = (short)421789696;
				if (num != 0)
				{
				}
				return this.l;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000063D4 File Offset: 0x000045D4
		internal global::ACPVoiceAnnouncementLib.MotVoiceFileCompressionCode CompressionCode
		{
			get
			{
				short num = (short)2047606081;
				short num2 = num;
				num = (short)1703279937;
				switch (num2 == num)
				{
				default:
				{
					num = (short)212336640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2093154305;
				if (num != 0)
				{
				}
				num = (short)1748238336;
				if (num != 0)
				{
				}
				return this.m;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00006480 File Offset: 0x00004680
		internal int CompressedDataLength
		{
			get
			{
				short num = (short)2102263809;
				if (num != 0)
				{
				}
				num = (short)1579548672;
				short num2 = num;
				num = (short)1580328549;
				short num3 = num;
				num = (short)575858277;
				switch (num3 == num)
				{
				}
				num = (short)1241251840;
				if (num != 0)
				{
				}
				return this.n;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00006530 File Offset: 0x00004730
		internal uint CheckSum32
		{
			get
			{
				short num = (short)472363183;
				short num2 = num;
				num = (short)1454813359;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1609367552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1592983553;
				if (num != 0)
				{
				}
				num = (short)1493434368;
				if (num != 0)
				{
				}
				return this.s;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000065E0 File Offset: 0x000047E0
		internal int EstimatedPackSize
		{
			get
			{
				short num = (short)552928238;
				short num2 = num;
				num = (short)2013987822;
				switch (num2 == num)
				{
				default:
				{
					num = (short)492568576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)20185088;
				if (num != 0)
				{
				}
				num = (short)919797761;
				if (num != 0)
				{
				}
				return this.o;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00006690 File Offset: 0x00004890
		internal int VoiceDurationMS
		{
			get
			{
				short num = (short)553843708;
				short num2 = num;
				num = (short)391707644;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1801846784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1370488833;
				if (num != 0)
				{
				}
				num = (short)1501429760;
				if (num != 0)
				{
				}
				return this.r;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0000673C File Offset: 0x0000493C
		internal string ShortFileName
		{
			get
			{
				string result;
				short num;
				for (;;)
				{
					result = "";
					try
					{
						result = global::System.IO.Path.GetFileNameWithoutExtension(this.l);
					}
					catch
					{
					}
					num = (short)1815905169;
					short num2 = num;
					num = (short)56984465;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_7B;
					}
					break;
				}
				num = (short)351797248;
				short num3 = num;
				IL_7B:
				num = (short)1527513089;
				if (num != 0)
				{
				}
				num = (short)155123712;
				if (num != 0)
				{
				}
				return result;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00006814 File Offset: 0x00004A14
		internal void l()
		{
			short num = (short)1188131678;
			short num2 = num;
			num = (short)161903454;
			switch (num2 == num)
			{
			default:
			{
				num = (short)258736128;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)341704705;
			if (num != 0)
			{
			}
			num = (short)697892864;
			if (num != 0)
			{
			}
			this.p++;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000068CC File Offset: 0x00004ACC
		internal void m()
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)736296962;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_ED;
					case 1:
					{
						num = (short)3906944;
						short num3 = num;
						num = (short)1488821632;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1569325056;
							if (num != 0)
							{
							}
							this.p--;
							num = (short)88408064;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
					{
						num = (short)263127040;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					}
					}
					IL_5A:
					if (this.p <= 0)
					{
						goto IL_EF;
					}
					num = (short)1275527169;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_ED:
			IL_EF:
			num = (short)1099563009;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000069F0 File Offset: 0x00004BF0
		internal bool IsCodeplugReferenced
		{
			get
			{
				short num = (short)1829568512;
				short num2 = num;
				num = (short)107416525;
				short num3 = num;
				num = (short)684198861;
				switch (num3 == num)
				{
				}
				num = (short)392364033;
				if (num != 0)
				{
				}
				num = (short)145817600;
				if (num != 0)
				{
				}
				return this.p > 0;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00006AA4 File Offset: 0x00004CA4
		internal static global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo EmptyVoiceAnnouncementInfo
		{
			get
			{
				short num = (short)2036531200;
				short num2 = num;
				num = (short)1356762948;
				short num3 = num;
				num = (short)1452838724;
				switch (num3 == num)
				{
				}
				num = (short)1818689536;
				if (num != 0)
				{
				}
				num = (short)927924225;
				if (num != 0)
				{
				}
				return new global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo("", global::ACPVoiceAnnouncementLib.MotVoiceFileCompressionCode.AMR, 0, 0, 0U);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00006B5C File Offset: 0x00004D5C
		private ACPMotVoiceAnnouncementInfo()
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00006B70 File Offset: 0x00004D70
		internal ACPMotVoiceAnnouncementInfo(string A_0, global::ACPVoiceAnnouncementLib.MotVoiceFileCompressionCode A_1, int A_2, int A_3, uint A_4)
		{
			this.l = A_0;
			this.m = A_1;
			this.n = A_3;
			this.q = A_2;
			this.r = this.a();
			this.s = A_4;
			this.p = 0;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00006BBC File Offset: 0x00004DBC
		public ACPMotVoiceAnnouncementInfo(string file, global::ACPVoiceAnnouncementLib.MotVoiceFileCompressionCode compression, int compressionParameter, byte[] data, int rawDataLength)
		{
			this.l = file;
			this.o = 0;
			this.s = 0U;
			this.r = 0;
			this.k = data;
			this.m = compression;
			this.n = rawDataLength;
			this.q = compressionParameter;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00006C0C File Offset: 0x00004E0C
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00006CB8 File Offset: 0x00004EB8
		internal bool ItemValidity
		{
			get
			{
				short num = (short)715325440;
				short num2 = num;
				num = (short)1759838209;
				if (num != 0)
				{
				}
				num = (short)255309181;
				short num3 = num;
				num = (short)1813034365;
				switch (num3 == num)
				{
				}
				num = (short)1363804160;
				if (num != 0)
				{
				}
				return true;
			}
			set
			{
				short num = (short)267517952;
				short num2 = num;
				num = (short)328545589;
				short num3 = num;
				num = (short)1474442549;
				switch (num3 == num)
				{
				}
				num = (short)386269185;
				if (num != 0)
				{
				}
				num = (short)303300608;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00006D60 File Offset: 0x00004F60
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00006E0C File Offset: 0x0000500C
		internal bool ItemVisibility
		{
			get
			{
				short num = (short)498008064;
				short num2 = num;
				num = (short)1513881601;
				if (num != 0)
				{
				}
				num = (short)1570599041;
				short num3 = num;
				num = (short)328233089;
				switch (num3 == num)
				{
				}
				num = (short)967311360;
				if (num != 0)
				{
				}
				return true;
			}
			set
			{
				short num = (short)1926955008;
				short num2 = num;
				num = (short)1457741403;
				short num3 = num;
				num = (short)949837403;
				switch (num3 == num)
				{
				}
				num = (short)1253310465;
				if (num != 0)
				{
				}
				num = (short)800587776;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00006EB8 File Offset: 0x000050B8
		private int b()
		{
			short num = (short)1007091716;
			int num2 = (int)((global::System.IntPtr)num);
			int num6;
			int num7;
			for (;;)
			{
				int num4;
				switch (num2)
				{
				case 0:
					num = (short)1038942214;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1588920321;
					if (num != 0)
					{
					}
					goto IL_208;
				case 2:
				{
					if (this.n <= 2000)
					{
						num = (short)897318920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1040515072;
					short num3 = num;
					num4 = this.n / 2000;
					num = (short)1673199625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_243;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_50;
					}
					continue;
				case 5:
					num = (short)496566274;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (this.ShortFileName.Length > 0)
					{
						num = (short)1225261061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return 0;
				case 7:
					num4++;
					goto IL_78;
				case 8:
					num4 = 1;
					num = (short)919273482;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
				{
					num = (short)1646080066;
					short num5 = num;
					num = (short)338243650;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_78;
					default:
						num = (short)1365573632;
						if (num != 0)
						{
						}
						if (num4 * 2000 < this.n)
						{
							num = (short)1836122119;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_208;
					}
					break;
				}
				case 10:
					goto IL_208;
				}
				IL_50:
				if (this.ShortFileName != null)
				{
					num = (short)542244864;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_78:
				num = (short)1012858881;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_208:
				num6 = 28 + global::System.Text.Encoding.UTF8.GetByteCount(this.ShortFileName) + 1;
				num7 = num4 * 15 + this.n;
				num = (short)934084611;
				num2 = (int)((global::System.IntPtr)num);
			}
			return 0;
			IL_243:
			return num6 + num7;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000712C File Offset: 0x0000532C
		private int a()
		{
			short num = (short)637861888;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_73;
				}
				int num4;
				int num7;
				int num8;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_156;
					case 1:
						goto IL_1FC;
					case 2:
					{
						int num3;
						switch (num3)
						{
						case 0:
							num4 = 13;
							num = (short)2068774915;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num4 = 14;
							num = (short)256638990;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							num4 = 16;
							num = (short)940113920;
							short num5 = num;
							num = (short)1294511158;
							short num6 = num;
							num = (short)677293110;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)2131034112;
								if (num != 0)
								{
								}
								num = (short)1959460880;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							num4 = 18;
							num = (short)1504247817;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num4 = 20;
							num = (short)178847749;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							break;
						case 6:
							num4 = 27;
							num = (short)1585774604;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num4 = 32;
							num = (short)754778113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1314324484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = 21;
						num = (short)1480851462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_1FC;
					case 4:
						num = (short)241958925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_1FC;
					case 6:
						goto IL_1FC;
					case 7:
						if (num7 > 0)
						{
							num = (short)1850933259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return 0;
					case 8:
					{
						num7 = this.n - 6;
						num8 = 20;
						int num3 = this.q;
						num = (short)490995714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_1FC;
					case 10:
						if (this.m == global::ACPVoiceAnnouncementLib.MotVoiceFileCompressionCode.AMR)
						{
							num = (short)1450967048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FC;
					case 11:
						num = (short)1411121167;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1715666945;
						if (num != 0)
						{
						}
						goto IL_1FC;
					case 13:
						goto IL_1FC;
					case 14:
						goto IL_1FC;
					case 15:
						if (num4 > 0)
						{
							num = (short)721027072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return 0;
					case 16:
						goto IL_1FC;
					}
					goto IL_73;
					IL_1FC:
					num = (short)685113351;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_156:
				return num8 * (num7 / num4);
				IL_73:
				num8 = 20;
				num4 = 0;
				num7 = 0;
				num = (short)15794186;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00007494 File Offset: 0x00005694
		public bool Equals(global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo other)
		{
			short num = (short)1293811712;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)14462611;
					short num3 = num;
					num = (short)1147186835;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1452146689;
						if (num != 0)
						{
						}
						num = (short)739639296;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A7;
						}
						continue;
					}
					break;
				}
				case 1:
				{
					num = (short)1407123456;
					short num4 = num;
					if (this.l == other.l)
					{
						num = (short)543162371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 2:
					num = (short)13959169;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return true;
				}
				IL_A7:
				if (other == null)
				{
					return false;
				}
				num = (short)67108866;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000059 RID: 89 RVA: 0x000075D4 File Offset: 0x000057D4
		// (remove) Token: 0x0600005A RID: 90 RVA: 0x00007708 File Offset: 0x00005908
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				short num;
				int num3;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)337192542;
					short num2 = num;
					num = (short)523249246;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_67;
					default:
					{
						num = (short)1486684160;
						if (num != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num3)
						{
						case 0:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num = (short)1165885442;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_85;
						case 1:
							goto IL_85;
						case 2:
							goto IL_D6;
						}
						goto IL_67;
						IL_85:
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.t, value2, propertyChangedEventHandler2);
						num = (short)2053832704;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_D6:
				num = (short)733216769;
				if (num != 0)
				{
				}
				num = (short)557711360;
				short num4 = num;
				return;
				IL_67:
				propertyChangedEventHandler = this.t;
				num = (short)1863843841;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_65;
				}
				short num;
				int num3;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)863357035;
					short num2 = num;
					num = (short)1607190635;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_65;
					default:
					{
						num = (short)778633216;
						if (num != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num3)
						{
						case 0:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num = (short)1827340289;
								if (num != 0)
								{
								}
								num = (short)820248578;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_82;
						case 1:
							goto IL_82;
						case 2:
							goto IL_F9;
						}
						goto IL_65;
						IL_82:
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.t, value2, propertyChangedEventHandler2);
						num = (short)53018624;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_F9:
				num = (short)775094272;
				short num4 = num;
				return;
				IL_65:
				propertyChangedEventHandler = this.t;
				num = (short)2010251265;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00007838 File Offset: 0x00005A38
		private void a(string A_0)
		{
			short num = (short)1174405121;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.t(this, new global::System.ComponentModel.PropertyChangedEventArgs(A_0));
					num = (short)396951554;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1201537025;
					if (num != 0)
					{
					}
					num = (short)1716795053;
					short num3 = num;
					num = (short)785659565;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D6;
					case 1:
						break;
					default:
					{
						num = (short)858521600;
						short num4 = num;
						break;
					}
					}
					num = (short)1424162816;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_CE;
					}
					continue;
				}
				case 2:
					return;
				}
				goto IL_CE;
				IL_D6:
				num = (short)1641938944;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CE:
				if (this.t != null)
				{
					goto IL_D6;
				}
				break;
			}
		}

		// Token: 0x04000046 RID: 70
		private const int a = 6;

		// Token: 0x04000047 RID: 71
		private const int b = 2;

		// Token: 0x04000048 RID: 72
		private const int c = 1;

		// Token: 0x04000049 RID: 73
		private const int d = 9;

		// Token: 0x0400004A RID: 74
		private const int e = 4;

		// Token: 0x0400004B RID: 75
		private const int f = 14;

		// Token: 0x0400004C RID: 76
		private const int g = 27;

		// Token: 0x0400004D RID: 77
		private const int h = 2;

		// Token: 0x0400004E RID: 78
		private const int i = 15;

		// Token: 0x0400004F RID: 79
		private const int j = 2000;

		// Token: 0x04000050 RID: 80
		private byte[] k;

		// Token: 0x04000051 RID: 81
		private string l;

		// Token: 0x04000052 RID: 82
		private global::ACPVoiceAnnouncementLib.MotVoiceFileCompressionCode m;

		// Token: 0x04000053 RID: 83
		private int n;

		// Token: 0x04000054 RID: 84
		private int o;

		// Token: 0x04000055 RID: 85
		private int p;

		// Token: 0x04000056 RID: 86
		private int q;

		// Token: 0x04000057 RID: 87
		private int r;

		// Token: 0x04000058 RID: 88
		private uint s;

		// Token: 0x04000059 RID: 89
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler t;
	}
}
