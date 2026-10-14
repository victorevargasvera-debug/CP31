using System;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AcpUtility
{
	// Token: 0x02000004 RID: 4
	public static class AssemblyValidator
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002230 File Offset: 0x00000430
		public static bool IsCallerAuthorized()
		{
			short num = (short)618856448;
			short num2 = num;
			num = (short)1677279383;
			short num3 = num;
			num = (short)1808089239;
			switch (num3 == num)
			{
			}
			num = (short)1295384577;
			if (num != 0)
			{
			}
			num = (short)798818304;
			if (num != 0)
			{
			}
			return global::AcpUtility.AssemblyValidator.IsCallerAuthorized(global::System.Reflection.Assembly.GetEntryAssembly());
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000022E8 File Offset: 0x000004E8
		public static bool IsCallerAuthorized(global::System.Reflection.Assembly caller)
		{
			int a_ = 6;
			short num = (short)520683520;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8C;
				}
				bool flag;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						string text;
						if (!text.Contains(global::AcpUtility.StreamExtensions.b("噢偤卦偨๪୬坮ၰ䕲ၴ䙶䩸䭺ὼ䥾떀", a_)))
						{
							num = (short)1850998792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E8;
					}
					case 1:
					{
						flag = true;
						global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.Registry.LocalMachine.OpenSubKey(global::AcpUtility.StreamExtensions.b("ぢ⩤Ⅶ㵨㱪ⱬ㵮㑰⽲㡴Ṷ᩸ॺቼ౾\udb86\uda88ﾊﾌﾐ\udb94ﺚ솜즞쒠톢첤솦삨좪첬\udbae\ud8b0\udcb2\udbb4", a_));
						num = (short)366477316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						int num3;
						string[] subKeyNames;
						if (num3 >= subKeyNames.Length)
						{
							num = (short)503644177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = subKeyNames[num3];
						num = (short)1827930115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						string text;
						if (!text.Contains(global::AcpUtility.StreamExtensions.b("ݢ呤啦嵨ཪ孬൮ၰ䝲䱴䑶䡸᡺䩼䵾", a_)))
						{
							num = (short)319225865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E8;
					}
					case 4:
					{
						global::Microsoft.Win32.RegistryKey registryKey;
						if (registryKey == null)
						{
							goto IL_12B;
						}
						num = (short)555099098;
						short num4 = num;
						num = (short)1602757594;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_37D;
						default:
							num = (short)1714487296;
							if (num != 0)
							{
							}
							num = (short)888864773;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
					{
						global::Microsoft.Win32.RegistryKey registryKey;
						string[] subKeyNames = registryKey.GetSubKeyNames();
						int num3 = 0;
						num = (short)1506672646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_208;
					case 7:
						goto IL_208;
					case 8:
						num = (short)327811090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)298057728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_163;
					case 11:
						num = (short)998113281;
						if (num != 0)
						{
						}
						num = (short)1129381903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_12B;
					case 13:
						goto IL_12B;
					case 14:
						if (caller != null)
						{
							num = (short)1447755787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = true;
						num = (short)1034747923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (global::AcpUtility.AssemblyValidator.a(caller))
						{
							num = (short)1610350593;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12B;
					case 16:
						goto IL_E8;
					case 17:
						num = (short)1367212044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						string text;
						if (text.Contains(global::AcpUtility.StreamExtensions.b("啢噤坦偨੪啬൮ᕰ䍲䅴䑶佸䍺᡼ᵾ낀", a_)))
						{
							num = (short)373948432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num3;
						num3++;
						goto IL_37D;
					}
					case 19:
						goto IL_12B;
					case 20:
						if (!flag)
						{
							num = (short)48103434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					goto IL_8C;
					IL_E8:
					flag = false;
					num = (short)326500365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12B:
					num = (short)1657208852;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_208:
					num = (short)1855520770;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37D:
					num = (short)141099008;
					short num5 = num;
					num = (short)1983578119;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_163:
				global::System.Windows.Forms.MessageBox.Show(global::AcpUtility.StreamExtensions.b("⩢୤፦౨ᥪͬ๮ᵰ卲ぴն୸ᑺོ彾ﮈ力뾐뎒솔ﾖﲘ뮚ﲜ토쾢첤쒦좨\udfaa쒬삮\udfb0鎲슴\udeb6햸ힺ鶼\uddbe꓀뛄꿆볈뿊꧌ꃎꛐ뷒ﯔ", a_) + global::System.Environment.NewLine + global::System.Environment.NewLine + global::AcpUtility.StreamExtensions.b("♢ᵤ๦ᵨ䭪⹬nᕰᙲ啴䝶Ÿ㵺㭼", a_));
				global::System.Environment.Exit(255);
				throw new global::System.Exception(global::AcpUtility.StreamExtensions.b("⩢୤፦౨ᥪͬ๮ᵰ卲ぴն୸ᑺོ彾ﮈ力뾐뎒솔ﾖﲘ뮚ﲜ토쾢첤쒦좨\udfaa쒬삮\udfb0鎲슴\udeb6햸ힺ鶼\uddbe꓀뛄꿆볈뿊꧌ꃎꛐ뷒ﯔ", a_) + global::System.Environment.NewLine + global::System.Environment.NewLine + global::AcpUtility.StreamExtensions.b("♢ᵤ๦ᵨ䭪⹬nᕰᙲ啴䝶Ÿ㵺㭼", a_));
				IL_8C:
				flag = false;
				num = (short)1161297934;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002774 File Offset: 0x00000974
		private static bool a(global::System.Reflection.Assembly A_0)
		{
			int a_ = 5;
			switch (0)
			{
			case 0:
				goto IL_3D;
			}
			int num;
			bool result;
			short num2;
			for (;;)
			{
				IL_13:
				bool flag;
				switch (num)
				{
				case 0:
					return result;
				case 1:
					if (!A_0.FullName.ToLower().EndsWith(global::AcpUtility.StreamExtensions.b("坡兣剥內ཀྵ੫噭ᅯ䑱ᅳ䝵䭷䩹ṻ䡽둿", a_)))
					{
						num2 = (short)553451526;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_117;
				case 2:
					num2 = (short)270467073;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					flag = A_0.FullName.ToLower().EndsWith(global::AcpUtility.StreamExtensions.b("呡坣噥內୩呫౭ᑯ䉱䁳䕵乷䉹᥻ᱽ녿", a_));
					goto IL_1C0;
				case 4:
					flag = true;
					goto IL_1C0;
				case 5:
					if (!A_0.FullName.ToLower().EndsWith(global::AcpUtility.StreamExtensions.b("١啣呥屧๩婫౭ᅯ䙱䵳䕵䥷᥹䭻䱽", a_)))
					{
						num2 = (short)2108882946;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_117;
				case 6:
					goto IL_22E;
				case 7:
					num2 = (short)1727725573;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					if (!(A_0 != null))
					{
						return result;
					}
					num2 = (short)1971912705;
					if (num2 != 0)
					{
					}
					num2 = (short)597394885;
					short num3 = num2;
					num2 = (short)2071299525;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_22E;
					default:
					{
						num2 = (short)296812544;
						short num4 = num2;
						num2 = (short)1455423488;
						if (num2 != 0)
						{
						}
						num2 = (short)2124414983;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_3D;
				IL_117:
				num2 = (short)1085145092;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1C0:
				result = flag;
				num2 = (short)1282211840;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_22E:
				num2 = (short)924778499;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_3D:
			result = false;
			num2 = (short)1692205064;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}
	}
}
