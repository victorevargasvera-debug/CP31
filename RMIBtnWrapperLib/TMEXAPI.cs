using System;

namespace RMIBtnWrapperLib
{
	// Token: 0x02000014 RID: 20
	public class TMEXAPI
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00015A44 File Offset: 0x00013C44
		public static short TMReadFile(int session_handle, byte[] state_buffer, short file_handle, byte[] read_buffer, short buff_size)
		{
			int a_ = 5;
			short num = (short)343277571;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_CD;
				case 1:
					goto IL_11B;
				case 2:
					goto IL_13A;
				case 3:
				{
					num = (short)666521499;
					short num3 = num;
					num = (short)924864411;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11B;
					default:
						num = (short)1996947456;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_89;
						}
						continue;
					}
					break;
				}
				}
				IL_89:
				num = (short)643301377;
				if (num != 0)
				{
				}
				if (global::System.IntPtr.Size == 4)
				{
					num = (short)244514816;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1434386433;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_11B:
				if (global::System.IntPtr.Size != 8)
				{
					goto IL_148;
				}
				num = (short)1190789122;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CD:
			num = (short)846921728;
			short num4 = num;
			return global::RMIBtnWrapperLib.TMEXAPI_32.TMReadFile(session_handle, state_buffer, file_handle, read_buffer, buff_size);
			IL_13A:
			return global::RMIBtnWrapperLib.TMEXAPI_64.TMReadFile(session_handle, state_buffer, file_handle, read_buffer, buff_size);
			IL_148:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("풂권떔뾞잠첢힤螦\udda8쎪좬辮튰욲잴얶\udcb8햺즼龾뇀뇂꫄꓆곈룊뻌", a_));
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00015BAC File Offset: 0x00013DAC
		public static int TMExtendedStartSession(short PortNum, short PortType, int[] EnhancedOptions)
		{
			int a_ = 7;
			short num = (short)1906835459;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_D0;
				case 1:
					goto IL_118;
				case 2:
					goto IL_139;
				case 3:
				{
					num = (short)658672704;
					short num3 = num;
					num = (short)434211904;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_118;
					default:
						num = (short)6815745;
						if (num != 0)
						{
						}
						num = (short)1819148288;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_B4;
						}
						continue;
					}
					break;
				}
				}
				IL_B4:
				if (global::System.IntPtr.Size == 4)
				{
					num = (short)15597568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)867631105;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_118:
				if (global::System.IntPtr.Size != 8)
				{
					goto IL_144;
				}
				num = (short)507510786;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D0:
			num = (short)1553661952;
			short num4 = num;
			return global::RMIBtnWrapperLib.TMEXAPI_32.TMExtendedStartSession(PortNum, PortType, EnhancedOptions);
			IL_139:
			return global::RMIBtnWrapperLib.TMEXAPI_64.TMExtendedStartSession(PortNum, PortType, EnhancedOptions);
			IL_144:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("튄꾎朗랖爵膠얢쪤햦覨\udfaa얬쪮醰킲살얶쮸\udeba펼쮾돂럄꣆꫈껊뻌볎￐", a_));
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00015D10 File Offset: 0x00013F10
		public static short TMEndSession(int sessionHandle)
		{
			int a_ = 5;
			short num = (short)1205469187;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_AA;
				case 1:
					goto IL_F3;
				case 2:
					goto IL_13B;
				case 3:
				{
					num = (short)1873230645;
					short num3 = num;
					num = (short)1796160309;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F3;
					default:
						num = (short)1530855424;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_8D;
						}
						continue;
					}
					break;
				}
				}
				IL_8D:
				if (global::System.IntPtr.Size == 4)
				{
					num = (short)828964864;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1968373761;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F3:
				num = (short)248381441;
				if (num != 0)
				{
				}
				if (global::System.IntPtr.Size != 8)
				{
					goto IL_147;
				}
				num = (short)1097531394;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AA:
			return global::RMIBtnWrapperLib.TMEXAPI_32.TMEndSession(sessionHandle);
			IL_13B:
			num = (short)400949248;
			short num4 = num;
			return global::RMIBtnWrapperLib.TMEXAPI_64.TMEndSession(sessionHandle);
			IL_147:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("풂권떔뾞잠첢힤螦\udda8쎪좬辮튰욲잴얶\udcb8햺즼龾뇀뇂꫄꓆곈룊뻌", a_));
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00015E78 File Offset: 0x00014078
		public static short TMValidSession(int sessionHandle)
		{
			int a_ = 14;
			short num = (short)1111031811;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_A7;
				case 1:
					goto IL_F0;
				case 2:
					goto IL_13A;
				case 3:
				{
					num = (short)922034534;
					short num3 = num;
					num = (short)936911206;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F0;
					default:
						num = (short)1802633216;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_89;
						}
						continue;
					}
					break;
				}
				}
				IL_89:
				if (global::System.IntPtr.Size == 4)
				{
					num = (short)404815872;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1562312705;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F0:
				num = (short)810483713;
				if (num != 0)
				{
				}
				if (global::System.IntPtr.Size != 8)
				{
					goto IL_146;
				}
				num = (short)820314114;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A7:
			return global::RMIBtnWrapperLib.TMEXAPI_32.TMValidSession(sessionHandle);
			IL_13A:
			num = (short)132251648;
			short num4 = num;
			return global::RMIBtnWrapperLib.TMEXAPI_64.TMValidSession(sessionHandle);
			IL_146:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\udb8bﲍﾏﲑ뚕流뺝풟\udba1풣쎥袧첩쎫\udcad邯욱\udcb3펵颷\ud9b9즻첽늿ꟁ꫃닅뫉뻋ꇍ돏럑ꟓꗕ", a_));
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00015FE0 File Offset: 0x000141E0
		public static short TMSetup(int session_handle)
		{
			int a_ = 15;
			short num = (short)292421632;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1D;
				case 1:
					goto IL_10F;
				case 2:
				{
					num = (short)1590296576;
					short num3 = num;
					if (global::System.IntPtr.Size == 8)
					{
						num = (short)1546059777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_118;
				}
				case 3:
					goto IL_A6;
				}
				goto IL_3D;
				IL_1D:
				switch (0)
				{
				case 0:
					IL_3D:
					if (global::System.IntPtr.Size == 4)
					{
						num = (short)596017364;
						short num4 = num;
						num = (short)486441172;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D;
						default:
							num = (short)506134528;
							if (num != 0)
							{
							}
							num = (short)75104259;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					else
					{
						num = (short)1277296642;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_A6:
			return global::RMIBtnWrapperLib.TMEXAPI_32.TMSetup(session_handle);
			IL_10F:
			return global::RMIBtnWrapperLib.TMEXAPI_64.TMSetup(session_handle);
			IL_118:
			num = (short)728432641;
			if (num != 0)
			{
			}
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\uda8cﶎﺐﶒ랖ﮘ뾞햠\udaa2햤슦覨춪슬\uddae醰잲\uddb4튶馸\ud8ba좼춾돀ꛂꯄ돆믊뿌ꃎ닐뛒ꛔꓖ", a_));
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00016140 File Offset: 0x00014340
		public static short TMFamilySearchSetup(int session_handle, byte[] state_buffer, short family_type)
		{
			int a_ = 10;
			short num = (short)1727332352;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1D;
				case 1:
					goto IL_13E;
				case 2:
					if (global::System.IntPtr.Size == 8)
					{
						num = (short)1098448897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_149;
				case 3:
					goto IL_AB;
				}
				goto IL_3D;
				IL_1D:
				switch (0)
				{
				case 0:
					IL_3D:
					if (global::System.IntPtr.Size == 4)
					{
						num = (short)616429769;
						short num3 = num;
						num = (short)1368324297;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D;
						default:
							num = (short)258342912;
							if (num != 0)
							{
							}
							num = (short)96665603;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					else
					{
						num = (short)1333592064;
						short num4 = num;
						num = (short)1070727170;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_AB:
			num = (short)1153957889;
			if (num != 0)
			{
			}
			return global::RMIBtnWrapperLib.TMEXAPI_32.TMFamilySearchSetup(session_handle, state_buffer, family_type);
			IL_13E:
			return global::RMIBtnWrapperLib.TMEXAPI_64.TMFamilySearchSetup(session_handle, state_buffer, family_type);
			IL_149:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\udf87늑ﾕ몙킟잡蒣삥잧\ud8a9貫\udaad\ud8afힱ钳햵춷좹캻\udbbd꺿뛁뛅뫇ꗉ꿋ꯍꏏꇑ䀘", a_));
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000162AC File Offset: 0x000144AC
		public static short TMCreateFile(int session_handle, byte[] state_buffer, out short maxwrite, byte[] fentry)
		{
			int a_ = 12;
			short num = (short)295239680;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1E;
				case 1:
					goto IL_13E;
				case 2:
					if (global::System.IntPtr.Size == 8)
					{
						num = (short)480313345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14A;
				case 3:
					goto IL_A8;
				}
				goto IL_3E;
				IL_1E:
				switch (0)
				{
				case 0:
					IL_3E:
					if (global::System.IntPtr.Size == 4)
					{
						num = (short)2039104706;
						short num3 = num;
						num = (short)1558922434;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E;
						default:
							num = (short)2040201216;
							if (num != 0)
							{
							}
							num = (short)745996291;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					else
					{
						num = (short)398655488;
						short num4 = num;
						num = (short)945553410;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_A8:
			num = (short)1007681537;
			if (num != 0)
			{
			}
			return global::RMIBtnWrapperLib.TMEXAPI_32.TMCreateFile(session_handle, state_buffer, out maxwrite, fentry);
			IL_13E:
			return global::RMIBtnWrapperLib.TMEXAPI_64.TMCreateFile(session_handle, state_buffer, out maxwrite, fentry);
			IL_14A:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\udd89ﺋﺏ뒓벛\ud99f튡솣蚥캧얩\udeab躭쒯\udab1톳隵\udbb7쾹캻첽ꖿ곁냃룇룉ꏋ귍뗏ꇑꟓ", a_));
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00016418 File Offset: 0x00014618
		public static short TMWriteFile(int session_handle, byte[] state_buffer, short file_handle, byte[] write_buffer, short num_write)
		{
			int a_ = 13;
			short num = (short)1541734400;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1D;
				case 1:
					goto IL_139;
				case 2:
				{
					num = (short)416219136;
					short num3 = num;
					num = (short)465960961;
					if (num != 0)
					{
					}
					if (global::System.IntPtr.Size == 8)
					{
						num = (short)1313865729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14A;
				}
				case 3:
					goto IL_A2;
				}
				goto IL_3D;
				IL_1D:
				switch (0)
				{
				case 0:
					IL_3D:
					if (global::System.IntPtr.Size == 4)
					{
						num = (short)746610489;
						short num4 = num;
						num = (short)905338681;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D;
						default:
							num = (short)1334247424;
							if (num != 0)
							{
							}
							num = (short)1811546115;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					else
					{
						num = (short)1330118658;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_A2:
			return global::RMIBtnWrapperLib.TMEXAPI_32.TMWriteFile(session_handle, state_buffer, file_handle, write_buffer, num_write);
			IL_139:
			return global::RMIBtnWrapperLib.TMEXAPI_64.TMWriteFile(session_handle, state_buffer, file_handle, write_buffer, num_write);
			IL_14A:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\udc8aﾌﾐ떔붜\ud8a0펢삤螦쾨쒪\udfac辮얰\udbb2킴鞶\udab8캺쾼춾꓀귂뇄마맊ꋌ곎듐ꃒꛔ淪", a_));
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00016584 File Offset: 0x00014784
		public static short TMFirst(int session_handle, byte[] state_buffer)
		{
			int a_ = 11;
			short num = (short)1521876992;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1D;
				case 1:
					goto IL_13C;
				case 2:
					if (global::System.IntPtr.Size == 8)
					{
						num = (short)1465974785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_146;
				case 3:
					goto IL_D1;
				}
				goto IL_3D;
				IL_1D:
				switch (0)
				{
				case 0:
					IL_3D:
					if (global::System.IntPtr.Size == 4)
					{
						num = (short)1260383265;
						short num3 = num;
						num = (short)1129638945;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D;
						default:
							num = (short)983629824;
							if (num != 0)
							{
							}
							num = (short)714014721;
							if (num != 0)
							{
							}
							num = (short)1674313731;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					else
					{
						num = (short)885325824;
						short num4 = num;
						num = (short)1818165250;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_D1:
			return global::RMIBtnWrapperLib.TMEXAPI_32.TMFirst(session_handle, state_buffer);
			IL_13C:
			return global::RMIBtnWrapperLib.TMEXAPI_64.TMFirst(session_handle, state_buffer);
			IL_146:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\ude88力뎒ﺖ뮚토욢薤솦욨\ud9aa趬\udbae\ud9b0횲閴풶첸즺쾼\udabe꿀럂럆믈꓊껌꫎ꋐꃒﯔ", a_));
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000166EC File Offset: 0x000148EC
		public static short TMNext(int session_handle, byte[] state_buffer)
		{
			int a_ = 10;
			short num = (short)1105461248;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1D;
				case 1:
					goto IL_13B;
				case 2:
					if (global::System.IntPtr.Size == 8)
					{
						num = (short)95682561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_145;
				case 3:
					goto IL_CF;
				}
				goto IL_3D;
				IL_1D:
				switch (0)
				{
				case 0:
					IL_3D:
					num = (short)2053373953;
					if (num != 0)
					{
					}
					if (global::System.IntPtr.Size == 4)
					{
						num = (short)1450557072;
						short num3 = num;
						num = (short)1939848848;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D;
						default:
							num = (short)1154351104;
							if (num != 0)
							{
							}
							num = (short)822542339;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					else
					{
						num = (short)886898688;
						short num4 = num;
						num = (short)689307650;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_CF:
			return global::RMIBtnWrapperLib.TMEXAPI_32.TMNext(session_handle, state_buffer);
			IL_13B:
			return global::RMIBtnWrapperLib.TMEXAPI_64.TMNext(session_handle, state_buffer);
			IL_145:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\udf87늑ﾕ몙킟잡蒣삥잧\ud8a9貫\udaad\ud8afힱ钳햵춷좹캻\udbbd꺿뛁뛅뫇ꗉ꿋ꯍꏏꇑ䀘", a_));
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00016854 File Offset: 0x00014A54
		public static short TMRom(int session_handle, byte[] state_buffer, short[] ROM)
		{
			int a_ = 12;
			short num = (short)1533018112;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1D;
				case 1:
					goto IL_13E;
				case 2:
					if (global::System.IntPtr.Size == 8)
					{
						num = (short)455868417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_149;
				case 3:
					goto IL_D3;
				}
				goto IL_3D;
				IL_1D:
				switch (0)
				{
				case 0:
					IL_3D:
					if (global::System.IntPtr.Size == 4)
					{
						num = (short)409507982;
						short num3 = num;
						num = (short)1366595726;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D;
						default:
						{
							num = (short)1683554304;
							short num4 = num;
							num = (short)759889920;
							if (num != 0)
							{
							}
							num = (short)1716715523;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
					else
					{
						num = (short)1737424898;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_D3:
			num = (short)1319436289;
			if (num != 0)
			{
			}
			return global::RMIBtnWrapperLib.TMEXAPI_32.TMRom(session_handle, state_buffer, ROM);
			IL_13E:
			return global::RMIBtnWrapperLib.TMEXAPI_64.TMRom(session_handle, state_buffer, ROM);
			IL_149:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\udd89ﺋﺏ뒓벛\ud99f튡솣蚥캧얩\udeab躭쒯\udab1톳隵\udbb7쾹캻첽ꖿ곁냃룇룉ꏋ귍뗏ꇑꟓ", a_));
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000169C0 File Offset: 0x00014BC0
		public static short TMOpenFile(int session_handle, byte[] state_buffer, byte[] fentry)
		{
			int a_ = 12;
			short num;
			for (;;)
			{
				num = (short)157810688;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 1:
						if (global::System.IntPtr.Size == 8)
						{
							num = (short)1936719875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_145;
					case 2:
						goto IL_5C;
					case 3:
						goto IL_13A;
					}
					IL_3D:
					if (global::System.IntPtr.Size == 4)
					{
						num = (short)1921318914;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)665452545;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_5C:
				num = (short)105599820;
				short num3 = num;
				num = (short)1241994060;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					goto IL_BD;
				}
				break;
			}
			num = (short)1373634560;
			short num4 = num;
			IL_BD:
			num = (short)1574109184;
			if (num != 0)
			{
			}
			num = (short)189071361;
			if (num != 0)
			{
			}
			return global::RMIBtnWrapperLib.TMEXAPI_32.TMOpenFile(session_handle, state_buffer, fentry);
			IL_13A:
			return global::RMIBtnWrapperLib.TMEXAPI_64.TMOpenFile(session_handle, state_buffer, fentry);
			IL_145:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\udd89ﺋﺏ뒓벛\ud99f튡솣蚥캧얩\udeab躭쒯\udab1톳隵\udbb7쾹캻첽ꖿ곁냃룇룉ꏋ귍뗏ꇑꟓ", a_));
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00016B28 File Offset: 0x00014D28
		public static short TMCloseFile(int session_handle, byte[] state_buffer, short file_handle)
		{
			int a_ = 1;
			short num;
			for (;;)
			{
				num = (short)186974208;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 1:
						if (global::System.IntPtr.Size == 8)
						{
							num = (short)778436611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11D;
					case 2:
						goto IL_5D;
					case 3:
						goto IL_112;
					}
					IL_3D:
					if (global::System.IntPtr.Size == 4)
					{
						num = (short)331939842;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)892010497;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_5D:
				num = (short)858166155;
				short num3 = num;
				num = (short)64394123;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					goto IL_BC;
				}
				break;
			}
			num = (short)348454912;
			short num4 = num;
			IL_BC:
			num = (short)714604544;
			if (num != 0)
			{
			}
			return global::RMIBtnWrapperLib.TMEXAPI_32.TMCloseFile(session_handle, state_buffer, file_handle);
			IL_112:
			return global::RMIBtnWrapperLib.TMEXAPI_64.TMCloseFile(session_handle, state_buffer, file_handle);
			IL_11D:
			num = (short)1282473985;
			if (num != 0)
			{
			}
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("⡾ꦈﮎ놐ﲘ뮚ﮜ펠莢톤쾦첨讪캬\udaae쎰솲킴\ud9b6춸鮺춼춾껀ꃂꃄ듆뫈", a_));
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00016C8C File Offset: 0x00014E8C
		public static short TMDeleteFile(int session_handle, byte[] state_buffer, byte[] fentry)
		{
			int a_ = 17;
			short num = (short)461242369;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_5A;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 2:
					goto IL_13B;
				case 3:
					num = (short)100007937;
					if (num != 0)
					{
					}
					if (global::System.IntPtr.Size == 8)
					{
						num = (short)2034040832;
						short num3 = num;
						num = (short)340066306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_149;
				}
				IL_3D:
				if (global::System.IntPtr.Size == 4)
				{
					num = (short)2105016320;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1019111092;
					short num4 = num;
					num = (short)812279476;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5A;
					default:
						num = (short)1713831936;
						if (num != 0)
						{
						}
						num = (short)980090883;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_5A:
			return global::RMIBtnWrapperLib.TMEXAPI_32.TMDeleteFile(session_handle, state_buffer, fentry);
			IL_13B:
			return global::RMIBtnWrapperLib.TMEXAPI_64.TMDeleteFile(session_handle, state_buffer, fentry);
			IL_149:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\ud88eﲒﮔ릘連膠힢\udca4힦첨讪쮬삮쎰鎲솴\udfb6\udcb8鮺\udebc쪾돀뇂ꃄ꧆뷈뷌뷎뻐냒냔ꓖ꫘", a_));
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00016DF8 File Offset: 0x00014FF8
		public static short TMFormat(int session_handle, byte[] state_buffer)
		{
			int a_ = 7;
			short num = (short)880607233;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_5A;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 2:
					goto IL_E7;
				case 3:
					if (global::System.IntPtr.Size == 8)
					{
						num = (short)149356546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11C;
				}
				IL_3E:
				if (global::System.IntPtr.Size == 4)
				{
					num = (short)2131427328;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)526450071;
					short num3 = num;
					num = (short)1288174999;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5A;
					default:
						num = (short)670236672;
						if (num != 0)
						{
						}
						num = (short)2087649283;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_5A:
			return global::RMIBtnWrapperLib.TMEXAPI_32.TMFormat(session_handle, state_buffer);
			IL_E7:
			num = (short)519372800;
			short num4 = num;
			return global::RMIBtnWrapperLib.TMEXAPI_64.TMFormat(session_handle, state_buffer);
			IL_11C:
			num = (short)979435521;
			if (num != 0)
			{
			}
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("튄꾎朗랖爵膠얢쪤햦覨\udfaa얬쪮醰킲살얶쮸\udeba펼쮾돂럄꣆꫈껊뻌볎￐", a_));
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00016F5C File Offset: 0x0001515C
		public static short TMFirstFile(int session_handle, byte[] state_buffer, byte[] fentry)
		{
			int a_ = 5;
			short num = (short)1080623105;
			if (num != 0)
			{
			}
			num = (short)1393491969;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_83;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				case 2:
					goto IL_13A;
				case 3:
					if (global::System.IntPtr.Size == 8)
					{
						num = (short)1137770496;
						short num3 = num;
						num = (short)1993146370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_148;
				}
				IL_65:
				if (global::System.IntPtr.Size == 4)
				{
					num = (short)317652992;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)174117964;
					short num4 = num;
					num = (short)1101190220;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_83;
					default:
						num = (short)1844445184;
						if (num != 0)
						{
						}
						num = (short)1804533763;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_83:
			return global::RMIBtnWrapperLib.TMEXAPI_32.TMFirstFile(session_handle, state_buffer, fentry);
			IL_13A:
			return global::RMIBtnWrapperLib.TMEXAPI_64.TMFirstFile(session_handle, state_buffer, fentry);
			IL_148:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("풂권떔뾞잠첢힤螦\udda8쎪좬辮튰욲잴얶\udcb8햺즼龾뇀뇂꫄꓆곈룊뻌", a_));
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000170C4 File Offset: 0x000152C4
		public static short TMNextFile(int session_handle, byte[] state_buffer, byte[] fentry)
		{
			int a_ = 17;
			short num = (short)1141440513;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_5A;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 2:
					goto IL_13B;
				case 3:
					if (global::System.IntPtr.Size == 8)
					{
						num = (short)1413480448;
						short num3 = num;
						num = (short)2025062402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_149;
				}
				IL_3E:
				if (global::System.IntPtr.Size == 4)
				{
					num = (short)1192230912;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1480523777;
					if (num != 0)
					{
					}
					num = (short)2069109125;
					short num4 = num;
					num = (short)2048727429;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5A;
					default:
						num = (short)1771503616;
						if (num != 0)
						{
						}
						num = (short)1908932611;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_5A:
			return global::RMIBtnWrapperLib.TMEXAPI_32.TMNextFile(session_handle, state_buffer, fentry);
			IL_13B:
			return global::RMIBtnWrapperLib.TMEXAPI_64.TMNextFile(session_handle, state_buffer, fentry);
			IL_149:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\ud88eﲒﮔ릘連膠힢\udca4힦첨讪쮬삮쎰鎲솴\udfb6\udcb8鮺\udebc쪾돀뇂ꃄ꧆뷈뷌뷎뻐냒냔ꓖ꫘", a_));
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00017230 File Offset: 0x00015430
		public static short TMStrongAccess(int session_handle, byte[] state_buffer)
		{
			int a_ = 10;
			short num = (short)669122561;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_5A;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 2:
					goto IL_13B;
				case 3:
					if (global::System.IntPtr.Size == 8)
					{
						num = (short)321781760;
						short num3 = num;
						num = (short)2065891330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_148;
				}
				IL_3D:
				if (global::System.IntPtr.Size == 4)
				{
					num = (short)166920192;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1822756103;
					short num4 = num;
					num = (short)1216089351;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5A;
					default:
						num = (short)2049835008;
						if (num != 0)
						{
						}
						num = (short)140312579;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_5A:
			num = (short)789250049;
			if (num != 0)
			{
			}
			return global::RMIBtnWrapperLib.TMEXAPI_32.TMStrongAccess(session_handle, state_buffer);
			IL_13B:
			return global::RMIBtnWrapperLib.TMEXAPI_64.TMStrongAccess(session_handle, state_buffer);
			IL_148:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\udf87늑ﾕ몙킟잡蒣삥잧\ud8a9貫\udaad\ud8afힱ钳햵춷좹캻\udbbd꺿뛁뛅뫇ꗉ꿋ꯍꏏꇑ䀘", a_));
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00017398 File Offset: 0x00015598
		public static short TMBlockStream(int sessionHandle, byte[] dataBlock, short len)
		{
			int a_ = 4;
			short num = (short)551092225;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_5B;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 2:
					goto IL_EA;
				case 3:
					if (global::System.IntPtr.Size == 8)
					{
						num = (short)1977483266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_149;
				}
				IL_3D:
				if (global::System.IntPtr.Size == 4)
				{
					num = (short)1102708736;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)15935793;
					short num3 = num;
					num = (short)1934567729;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5B;
					default:
						num = (short)170524672;
						if (num != 0)
						{
						}
						num = (short)1870856195;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_5B:
			return global::RMIBtnWrapperLib.TMEXAPI_32.TMBlockStream(sessionHandle, dataBlock, len);
			IL_EA:
			num = (short)217120768;
			short num4 = num;
			num = (short)1044578305;
			if (num != 0)
			{
			}
			return global::RMIBtnWrapperLib.TMEXAPI_64.TMBlockStream(sessionHandle, dataBlock, len);
			IL_149:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("햁겋憐뒓鍊뺝욟춡횣蚥\udca7슩즫躭펯잱욳쒵\uddb7풹좻麽낿냁ꯃꗅ귇막뿋", a_));
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00017504 File Offset: 0x00015704
		public static short TMOneWireCom(int sessionHandle, short command, short argument)
		{
			int a_ = 16;
			short num = (short)1375404033;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_81;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 2:
					goto IL_13B;
				case 3:
					if (global::System.IntPtr.Size == 8)
					{
						num = (short)30867456;
						short num3 = num;
						num = (short)330104834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_149;
				}
				IL_3E:
				num = (short)623312897;
				if (num != 0)
				{
				}
				if (global::System.IntPtr.Size == 4)
				{
					num = (short)236126208;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)2004603054;
					short num4 = num;
					num = (short)351981742;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_81;
					default:
						num = (short)1780744192;
						if (num != 0)
						{
						}
						num = (short)1389363203;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_81:
			return global::RMIBtnWrapperLib.TMEXAPI_32.TMOneWireCom(sessionHandle, command, argument);
			IL_13B:
			return global::RMIBtnWrapperLib.TMEXAPI_64.TMOneWireCom(sessionHandle, command, argument);
			IL_149:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\ud98d﶑望뢗肟횡\udda3횥춧誩쪫솭슯銱삳\udeb5\uddb7骹\udfbb쮽늿냁ꇃꣅ볇볋볍뿏뇑뇓ꗕꯗ", a_));
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00017670 File Offset: 0x00015870
		public static short TMTouchReset(int session_handle)
		{
			int a_ = 11;
			short num = (short)1701380097;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_5B;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 2:
					goto IL_139;
				case 3:
					if (global::System.IntPtr.Size == 8)
					{
						num = (short)1234632704;
						short num3 = num;
						num = (short)2054094850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_145;
				}
				IL_3D:
				if (global::System.IntPtr.Size == 4)
				{
					num = (short)906100736;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)932577281;
					if (num != 0)
					{
					}
					num = (short)711222356;
					short num4 = num;
					num = (short)38560852;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5B;
					default:
						num = (short)539295744;
						if (num != 0)
						{
						}
						num = (short)1826226179;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_5B:
			return global::RMIBtnWrapperLib.TMEXAPI_32.TMTouchReset(session_handle);
			IL_139:
			return global::RMIBtnWrapperLib.TMEXAPI_64.TMTouchReset(session_handle);
			IL_145:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\ude88力뎒ﺖ뮚토욢薤솦욨\ud9aa趬\udbae\ud9b0횲閴풶첸즺쾼\udabe꿀럂럆믈꓊껌꫎ꋐꃒﯔ", a_));
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000177D8 File Offset: 0x000159D8
		public static short TMTouchByte(int session_handle, short outbyte)
		{
			int a_ = 3;
			short num = (short)354222081;
			if (num != 0)
			{
			}
			num = (short)578682881;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_80;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				case 2:
					goto IL_137;
				case 3:
					if (global::System.IntPtr.Size == 8)
					{
						num = (short)201719808;
						short num3 = num;
						num = (short)1433468930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_144;
				}
				IL_64:
				if (global::System.IntPtr.Size == 4)
				{
					num = (short)120061952;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)528864858;
					short num4 = num;
					num = (short)626906714;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_80;
					default:
						num = (short)607977472;
						if (num != 0)
						{
						}
						num = (short)1401290755;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_80:
			return global::RMIBtnWrapperLib.TMEXAPI_32.TMTouchByte(session_handle, outbyte);
			IL_137:
			return global::RMIBtnWrapperLib.TMEXAPI_64.TMTouchByte(session_handle, outbyte);
			IL_144:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("횀ꮊ뎒ﺚ붜咽캠톢薤펦솨캪趬첮쒰솲잴튶ힸ쾺鶼쾾돀곂ꛄꋆ뫈룊", a_));
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0001793C File Offset: 0x00015B3C
		public static short TMCRC(short length, byte[] buf, ushort seed, short Type)
		{
			int a_ = 19;
			short num = (short)1245970433;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_5C;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 2:
					goto IL_EE;
				case 3:
					if (global::System.IntPtr.Size == 8)
					{
						num = (short)1687158786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_125;
				}
				IL_3E:
				if (global::System.IntPtr.Size == 4)
				{
					num = (short)958332928;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1748793143;
					short num3 = num;
					num = (short)360085303;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5C;
					default:
						num = (short)675151872;
						if (num != 0)
						{
						}
						num = (short)1210712067;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_5C:
			return global::RMIBtnWrapperLib.TMEXAPI_32.TMCRC(length, buf, seed, Type);
			IL_EE:
			num = (short)839778304;
			short num4 = num;
			return global::RMIBtnWrapperLib.TMEXAPI_64.TMCRC(length, buf, seed, Type);
			IL_125:
			num = (short)736886785;
			if (num != 0)
			{
			}
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("욐杖練ﺘ뮚ﾜ햠莢톤\udea6\ud9a8캪趬즮\udeb0솲閴쎶톸\udeba鶼\udcbe듀뇂럄ꋆꟈ뿊뿎ꏐ볒뛔닖꫘꣚", a_));
		}
	}
}
