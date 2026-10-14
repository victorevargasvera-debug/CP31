using System;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Flashport.FlashkeyLib;
using SpecialFeatures.Flashport.FlashRadio;

namespace SpecialFeatures.Flashport
{
	// Token: 0x020000C7 RID: 199
	public class RMCFlashkey : global::System.IDisposable
	{
		// Token: 0x06000C70 RID: 3184 RVA: 0x00102B08 File Offset: 0x00100D08
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1945186120;
				short num2 = num;
				num = (short)491990856;
				switch (num2 == num)
				{
				}
				num = (short)1726676992;
				if (num != 0)
				{
				}
				this.a(false);
			}
			finally
			{
				num = (short)1824718849;
				if (num != 0)
				{
				}
				base.Finalize();
			}
			num = (short)2071789568;
			short num3 = num;
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00102BD0 File Offset: 0x00100DD0
		public void Open()
		{
			short num = (short)633731127;
			short num2 = num;
			num = (short)572061751;
			switch (num2 == num)
			{
			}
			num = (short)1967849472;
			short num3 = num;
			num = (short)307691521;
			if (num != 0)
			{
			}
			num = (short)1888813056;
			if (num != 0)
			{
			}
			this.Open(string.Empty, string.Empty, global::SpecialFeatures.Flashport.FlashkeyLib.FindType.FindAny);
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x00102C8C File Offset: 0x00100E8C
		internal void OpenFromModelNumber(string modelNumber)
		{
			int a_ = 1;
			short num = (short)2032771015;
			short num2 = num;
			num = (short)1098293191;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)162267136;
				short num3 = num;
				num = (short)895025153;
				if (num != 0)
				{
				}
				num = (short)88211456;
				if (num != 0)
				{
				}
				if (modelNumber != null)
				{
					this.Open(modelNumber, string.Empty, global::SpecialFeatures.Flashport.FlashkeyLib.FindType.MatchModelOnly);
					return;
				}
				break;
			}
			}
			throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삍ﾑ", a_));
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00102D64 File Offset: 0x00100F64
		internal void OpenFromFlashcode(string flashcode)
		{
			int a_ = 4;
			short num = (short)611992172;
			short num2 = num;
			num = (short)1436303980;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1235550208;
				short num3 = num;
				num = (short)1447624705;
				if (num != 0)
				{
				}
				num = (short)1450508288;
				if (num != 0)
				{
				}
				if (flashcode != null)
				{
					this.Open(string.Empty, flashcode, global::SpecialFeatures.Flashport.FlashkeyLib.FindType.MatchFlashcodeOnly);
					return;
				}
				break;
			}
			}
			throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﺌﲒ", a_));
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x00102E3C File Offset: 0x0010103C
		public bool Open(string modelNumber, string flashcode)
		{
			int a_ = 3;
			short num = (short)865665024;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)872349696;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				}
				case 1:
					if (string.IsNullOrEmpty(flashcode))
					{
						num = (short)642777090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_159;
				case 2:
					goto IL_11C;
				case 3:
					goto IL_CD;
				}
				IL_65:
				if (string.IsNullOrEmpty(modelNumber))
				{
					num = (short)1019012380;
					short num4 = num;
					num = (short)1233052956;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)848232448;
						if (num != 0)
						{
						}
						num = (short)28639235;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				else
				{
					num = (short)31129601;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_CD:
			throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8f煉ﶗ", a_));
			IL_11C:
			num = (short)1860304897;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾋ﶑", a_));
			IL_159:
			return this.Open(modelNumber, flashcode, global::SpecialFeatures.Flashport.FlashkeyLib.FindType.FindExactMatch);
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00102FAC File Offset: 0x001011AC
		protected bool Open(string modelNumber, string flashcode, global::SpecialFeatures.Flashport.FlashkeyLib.FindType match)
		{
			short num = (short)954466304;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1958019072;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				}
				case 1:
					if (!global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance.ValidateKey())
					{
						num = (short)311885826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_143;
				case 2:
					goto IL_13F;
				case 3:
					return false;
				}
				IL_5D:
				num = (short)2087190529;
				if (num != 0)
				{
				}
				if (!global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance.FindFlashkey(modelNumber, flashcode, match))
				{
					num = (short)635759976;
					short num4 = num;
					num = (short)1666182504;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)40501248;
						if (num != 0)
						{
						}
						num = (short)941817859;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				else
				{
					num = (short)778633217;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return false;
			IL_13F:
			throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::CommonResources.AppResources.FLASHkey_Validation_failed);
			IL_143:
			this.a = this.i();
			this.b = this.h();
			this.c = this.g();
			this.d = this.f();
			this.e = this.e();
			this.f = this.d();
			this.g = this.c();
			this.h = this.b();
			this.i = this.a();
			return true;
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x0010316C File Offset: 0x0010136C
		internal void Decode(string flashcode, ref byte[] decoded)
		{
			short num = (short)246218752;
			switch (num)
			{
			default:
			{
				num = (short)2005794821;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					switch (num2)
					{
					case 0:
						num = (short)1436024836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1C7;
					case 2:
						goto IL_17E;
					case 3:
						if (num3 != 25)
						{
							num = (short)473628673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
					{
						char c;
						if (global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.IsCharInFlashcodeMap(c))
						{
							num = (short)287440906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20A;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 6:
					{
						num = (short)646035626;
						short num4 = num;
						num = (short)1319024810;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_228;
						default:
							num = (short)893059072;
							if (num != 0)
							{
							}
							num = (short)779091971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						goto IL_20E;
					case 8:
						return;
					case 9:
						global::System.Array.Resize<byte>(ref decoded, 25);
						num = (short)662700034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						char c;
						decoded[num3++] = (byte)global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.GetFlashcodeIntValue(c);
						num = (short)315621382;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						char c;
						if (c != '-')
						{
							num = (short)243531776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C7;
					}
					case 12:
						goto IL_228;
					case 13:
						num = (short)138084353;
						if (num != 0)
						{
						}
						goto IL_20E;
					}
					IL_7C:
					num = (short)1368653824;
					short num5 = num;
					if (decoded.Length != 25)
					{
						num = (short)187695113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_17E:
					num3 = 0;
					int num6 = 0;
					num = (short)1920335885;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C7:
					num6++;
					num = (short)1532821511;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20E:
					num = (short)1726087180;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_228:
					if (num6 >= flashcode.Length)
					{
						num = (short)1698037768;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						char c = flashcode[num6];
						num = (short)1324875787;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_20A:
				decoded = null;
				return;
			}
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x00103448 File Offset: 0x00101648
		public string SerialNumber
		{
			get
			{
				short num = (short)700937703;
				short num2 = num;
				num = (short)1054111207;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)814088192;
					short num3 = num;
					num = (short)1749876736;
					if (num != 0)
					{
					}
					num = (short)1575813121;
					if (num != 0)
					{
					}
					if (global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance != null)
					{
						return this.a;
					}
					break;
				}
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x00103508 File Offset: 0x00101708
		// (set) Token: 0x06000C79 RID: 3193 RVA: 0x001035C4 File Offset: 0x001017C4
		public int UpgradesRemaining
		{
			get
			{
				short num = (short)168881431;
				short num2 = num;
				num = (short)631172375;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1202782208;
					short num3 = num;
					num = (short)1850671104;
					if (num != 0)
					{
					}
					if (global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance != null)
					{
						return this.b;
					}
					break;
				}
				}
				num = (short)375193601;
				if (num != 0)
				{
				}
				throw new global::System.InvalidOperationException();
			}
			set
			{
				int a_ = 3;
				short num = (short)574029825;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_AD;
					case 1:
					{
						num = (short)783454550;
						short num3 = num;
						num = (short)1299485014;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D3;
						default:
							num = (short)572456960;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_91;
							}
							continue;
						}
						break;
					}
					case 2:
					{
						num = (short)1481113600;
						short num4 = num;
						if (value >= 0)
						{
							num = (short)1422655491;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17B;
					}
					case 3:
						num = (short)1756168197;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_111;
					case 5:
						if (value > this.b)
						{
							goto IL_D3;
						}
						goto IL_18F;
					}
					IL_91:
					if (global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance == null)
					{
						num = (short)112263168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2030764034;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D3:
					num = (short)331022337;
					if (num != 0)
					{
					}
					num = (short)56229892;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_AD:
				throw new global::System.InvalidOperationException();
				IL_111:
				IL_17B:
				throw new global::System.ArgumentOutOfRangeException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("曆", a_));
				IL_18F:
				global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance.UpdateUpgradesRemCounter(value);
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x0010376C File Offset: 0x0010196C
		public int UpgradesPurchased
		{
			get
			{
				short num = (short)531322137;
				short num2 = num;
				num = (short)1712805145;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1642463232;
					short num3 = num;
					num = (short)1443692545;
					if (num != 0)
					{
					}
					num = (short)1937440768;
					if (num != 0)
					{
					}
					if (global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance != null)
					{
						return this.c;
					}
					break;
				}
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x0010382C File Offset: 0x00101A2C
		public string DateCode
		{
			get
			{
				short num = (short)308019191;
				short num2 = num;
				num = (short)688652279;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)772472832;
					short num3 = num;
					num = (short)1885208576;
					if (num != 0)
					{
					}
					if (global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance != null)
					{
						return this.d;
					}
					num = (short)1505624065;
					if (num != 0)
					{
					}
					break;
				}
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000C7C RID: 3196 RVA: 0x001038E8 File Offset: 0x00101AE8
		public string FactoryOrderNumber
		{
			get
			{
				short num = (short)860714612;
				short num2 = num;
				num = (short)1300723316;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)420216832;
					short num3 = num;
					num = (short)1634795521;
					if (num != 0)
					{
					}
					num = (short)723320832;
					if (num != 0)
					{
					}
					if (global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance != null)
					{
						return this.e;
					}
					break;
				}
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x001039A4 File Offset: 0x00101BA4
		internal string OldFlashcode
		{
			get
			{
				short num = (short)985871247;
				short num2 = num;
				num = (short)959722383;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1224015872;
					short num3 = num;
					num = (short)1330184193;
					if (num != 0)
					{
					}
					num = (short)1698037760;
					if (num != 0)
					{
					}
					if (global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance != null)
					{
						return this.f;
					}
					break;
				}
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x00103A64 File Offset: 0x00101C64
		public string NewFlashcode
		{
			get
			{
				short num = (short)167236608;
				short num2 = num;
				num = (short)291034112;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2140733440;
					short num3 = num;
					num = (short)2060451840;
					if (num != 0)
					{
					}
					num = (short)1085997057;
					if (num != 0)
					{
					}
					if (global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance != null)
					{
						return this.g;
					}
					break;
				}
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x00103B20 File Offset: 0x00101D20
		internal string OldModelNumber
		{
			get
			{
				short num = (short)1232029406;
				short num2 = num;
				num = (short)1829586654;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2093154304;
					short num3 = num;
					num = (short)838664192;
					if (num != 0)
					{
					}
					num = (short)706478081;
					if (num != 0)
					{
					}
					if (global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance != null)
					{
						return this.h;
					}
					break;
				}
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000C80 RID: 3200 RVA: 0x00103BE0 File Offset: 0x00101DE0
		public string NewModelNumber
		{
			get
			{
				short num = (short)296804095;
				short num2 = num;
				num = (short)922017535;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)502530048;
					short num3 = num;
					num = (short)2131689473;
					if (num != 0)
					{
					}
					num = (short)218497024;
					if (num != 0)
					{
					}
					if (global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance != null)
					{
						return this.i;
					}
					break;
				}
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00103CA0 File Offset: 0x00101EA0
		public void Close()
		{
			short num = (short)1173225472;
			short num2 = num;
			num = (short)1208991213;
			short num3 = num;
			num = (short)1517796845;
			switch (num3 == num)
			{
			}
			num = (short)2069692416;
			if (num != 0)
			{
			}
			num = (short)510001153;
			if (num != 0)
			{
			}
			this.a(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00103D58 File Offset: 0x00101F58
		private string i()
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_39;
			}
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_18A;
				case 1:
					num2 = (short)1768161286;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					string text;
					return text;
				}
				case 3:
					goto IL_A7;
				case 4:
					goto IL_188;
				case 5:
				{
					int num3;
					byte[] keySerialNumber;
					if (num3 >= keySerialNumber.Length - 1)
					{
						num2 = (short)460783618;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					string text;
					text += keySerialNumber[num3].ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좏ꂑ", a_));
					num3++;
					num2 = (short)1049034752;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
				{
					byte[] keySerialNumber;
					if (keySerialNumber.Length != 8)
					{
						num2 = (short)2066677760;
						short num4 = num2;
						num2 = (short)524484612;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					string text = string.Empty;
					int num3 = 1;
					num2 = (short)1116274695;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					goto IL_18A;
				}
				goto IL_39;
				IL_18A:
				num2 = (short)1902247937;
				if (num2 != 0)
				{
				}
				num2 = (short)1000865797;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_188:
			goto IL_1EC;
			IL_39:
			num2 = (short)1823687661;
			short num5 = num2;
			num2 = (short)260391917;
			switch ((num5 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_A7:
				byte[] keySerialNumber;
				if (keySerialNumber != null)
				{
					num2 = (short)469434369;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				break;
			}
			default:
			{
				num2 = (short)216268800;
				if (num2 != 0)
				{
				}
				byte[] keySerialNumber = global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance.GetKeySerialNumber();
				num2 = (short)75759619;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
			IL_1EC:
			throw new global::System.InvalidOperationException(global::CommonResources.AppResources.Unable_to_get_valid_Flashkey_Id);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00103F60 File Offset: 0x00102160
		private int h()
		{
			short num = (short)1303773184;
			short num2 = num;
			num = (short)2136875344;
			short num3 = num;
			num = (short)251142480;
			switch (num3 == num)
			{
			}
			num = (short)804126721;
			if (num != 0)
			{
			}
			num = (short)1031405568;
			if (num != 0)
			{
			}
			return (int)global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance.GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.UpgradesRemaining);
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x0010401C File Offset: 0x0010221C
		public bool ValidateFlashKey()
		{
			short num = (short)567607296;
			short num2 = num;
			num = (short)146582062;
			short num3 = num;
			num = (short)1194043950;
			switch (num3 == num)
			{
			}
			num = (short)1961426945;
			if (num != 0)
			{
			}
			num = (short)125239296;
			if (num != 0)
			{
			}
			return global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance.ValidateKey();
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x001040D0 File Offset: 0x001022D0
		public void DecrementFlashkeyCounter(int decreaseCount)
		{
			short num = (short)675892806;
			short num2 = num;
			num = (short)1124683334;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)422969344;
				short num3 = num;
				num = (short)125698049;
				if (num != 0)
				{
				}
				num = (short)2088697856;
				if (num != 0)
				{
				}
				if (global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance.UpdateUpgradesRemCounter(decreaseCount))
				{
					return;
				}
				break;
			}
			}
			throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::CommonResources.AppResources.FLASHkey_Validation_failed);
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00104194 File Offset: 0x00102394
		private int g()
		{
			short num = (short)1802888811;
			short num2 = num;
			num = (short)919266923;
			switch (num2 == num)
			{
			default:
			{
				num = (short)243400704;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1228210176;
			if (num != 0)
			{
			}
			num = (short)2031617;
			if (num != 0)
			{
			}
			return (int)global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance.GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.UpgradesPurchased);
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x0010424C File Offset: 0x0010244C
		private string f()
		{
			short num = (short)1287388260;
			short num2 = num;
			num = (short)2057108580;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1424162816;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)133627905;
			if (num != 0)
			{
			}
			num = (short)2072248320;
			if (num != 0)
			{
			}
			return (string)global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance.GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.DateCode);
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00104308 File Offset: 0x00102508
		private string e()
		{
			short num = (short)1247355931;
			short num2 = num;
			num = (short)1060054043;
			switch (num2 == num)
			{
			default:
			{
				num = (short)288686080;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)259522561;
			if (num != 0)
			{
			}
			num = (short)321585152;
			if (num != 0)
			{
			}
			return (string)global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance.GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.FactOrderNo);
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x001043C4 File Offset: 0x001025C4
		private string d()
		{
			short num = (short)1723809780;
			short num2 = num;
			num = (short)955990004;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1573978112;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)177340417;
			if (num != 0)
			{
			}
			num = (short)715849728;
			if (num != 0)
			{
			}
			return (string)global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance.GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.Flashcode);
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x0010447C File Offset: 0x0010267C
		private string c()
		{
			short num = (short)2004925600;
			short num2 = num;
			num = (short)1452588192;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2068840448;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)568655873;
			if (num != 0)
			{
			}
			num = (short)126091264;
			if (num != 0)
			{
			}
			return (string)global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance.GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.FlashcodeNew);
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x0010453C File Offset: 0x0010273C
		private string b()
		{
			short num = (short)1804075009;
			if (num != 0)
			{
			}
			num = (short)324861952;
			short num2 = num;
			num = (short)1505631124;
			short num3 = num;
			num = (short)279190420;
			switch (num3 == num)
			{
			}
			num = (short)1997209600;
			if (num != 0)
			{
			}
			return (string)global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance.GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.ModelNumber);
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x001045F8 File Offset: 0x001027F8
		private string a()
		{
			short num = (short)1831722036;
			short num2 = num;
			num = (short)586013748;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1393098752;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)342949889;
			if (num != 0)
			{
			}
			num = (short)1042153472;
			if (num != 0)
			{
			}
			return (string)global::SpecialFeatures.Flashport.FlashKeyManagerSingleTon.Instance.GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.ModelNumberNew);
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x001046B0 File Offset: 0x001028B0
		public void Dispose()
		{
			short num = (short)535522364;
			short num2 = num;
			num = (short)632122428;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1196425216;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1910898688;
			if (num != 0)
			{
			}
			num = (short)1492451329;
			if (num != 0)
			{
			}
			this.a(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00104768 File Offset: 0x00102968
		private void a(bool A_0)
		{
			short num = (short)123469825;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1728076382;
				short num3 = num;
				num = (short)638343774;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_C2;
				case 1:
					break;
				default:
				{
					num = (short)835387392;
					short num4 = num;
					break;
				}
				}
				num = (short)2006253568;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_C2;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_A3;
					}
					continue;
				case 2:
					goto IL_119;
				}
				IL_A3:
				if (A_0)
				{
					num = (short)1043267584;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_C2:
				this.a = null;
				this.b = 0;
				this.c = 0;
				this.d = null;
				this.e = null;
				this.f = null;
				this.g = null;
				this.h = null;
				this.i = null;
				num = (short)945160194;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_119:
			num = (short)1782185985;
			if (num != 0)
			{
			}
		}

		// Token: 0x04000610 RID: 1552
		private string a;

		// Token: 0x04000611 RID: 1553
		private int b;

		// Token: 0x04000612 RID: 1554
		private int c;

		// Token: 0x04000613 RID: 1555
		private string d;

		// Token: 0x04000614 RID: 1556
		private string e;

		// Token: 0x04000615 RID: 1557
		private string f;

		// Token: 0x04000616 RID: 1558
		private string g;

		// Token: 0x04000617 RID: 1559
		private string h;

		// Token: 0x04000618 RID: 1560
		private string i;

		// Token: 0x04000619 RID: 1561
		public const int FlashcodeSize = 25;
	}
}
