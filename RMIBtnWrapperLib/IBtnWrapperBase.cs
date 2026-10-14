using System;
using System.Text;

namespace RMIBtnWrapperLib
{
	// Token: 0x02000010 RID: 16
	public abstract class IBtnWrapperBase : global::RMIBtnWrapperLib.IIBtnWrapper
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00010C88 File Offset: 0x0000EE88
		public IBtnWrapperBase()
		{
			this.portNum = 1;
			this.portType = 2;
			this.maxRetryCnt = 5;
			this.bMotoBtn = true;
			this.bButtonOpened = false;
			this.hSession = 0;
			this.btnCommon = null;
		}

		// Token: 0x06000048 RID: 72
		public abstract void OpenButton(int options);

		// Token: 0x06000049 RID: 73 RVA: 0x00010CCC File Offset: 0x0000EECC
		public void OpenNonMotoBtn(int options)
		{
			int a_ = 11;
			short num = (short)1018338706;
			short num2 = num;
			num = (short)1823907218;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)1582039040;
				short num3 = num;
				break;
			}
			}
			num = (short)2052128769;
			if (num != 0)
			{
			}
			num = (short)781385728;
			if (num != 0)
			{
			}
			this.bMotoBtn = false;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_C9;
				}
				int num4;
				for (;;)
				{
					IL_B7:
					switch (num4)
					{
					case 0:
						goto IL_12D;
					case 1:
						if (this.a())
						{
							num = (short)57540610;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)142540800;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_102;
					}
					goto IL_C9;
				}
				IL_102:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("있ꊎ\udc90ﲒﺞ膠쪢튦\udda8\udfaa슬솮醰킲\udab4\ud9b6춸\udaba풼톾닀냄꧆꣈뻊만꟎뻐ꇒ볔귖볘뿚﷜맞裠迢胤짦", a_));
				IL_12D:
				return;
				IL_C9:
				this.OpenButton(options);
				num = (short)2065235969;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_B7;
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00010E1C File Offset: 0x0000F01C
		public void CreateFile(string fileName, out short pMaxBytes)
		{
			int a_ = 11;
			short num = (short)1870856192;
			switch (num)
			{
			default:
			{
				num = (short)1160577025;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1635319808;
					short num3 = num;
					short num4;
					switch (num2)
					{
					case 0:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_F4;
							}
							byte[] array;
							short num5;
							for (;;)
							{
								IL_DD:
								switch (num2)
								{
								case 0:
									if (array != null)
									{
										num = (short)60620802;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_18C;
								case 1:
									goto IL_1B8;
								case 2:
									this.btnCommon.CreateFile(this.hSession, out num4, array, out num5);
									pMaxBytes = num5;
									num = (short)556924931;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)786497537;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_F4;
							}
							IL_18C:
							throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("삈ﮌ﶐朗랖煮철욢쮤펦螨讪욮\uddb0횲閴ힸ쾺쾼욾ꫂꯄꇆꛈ맊ꃌ껎ꗐ뫒뫔맖律룚볜뇞迠賢釤쟦诨軪췬臮蓰鿲駴", a_));
							IL_1B8:
							return;
							IL_F4:
							this.btnCommon.GetSessionHandle(ref this.hSession);
							this.btnCommon.DoTMSetup(this.hSession);
							array = null;
							array = this.btnCommon.LoadFileName(fileName);
							num5 = 1;
							num = (short)188022784;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_DD;
						}
						catch (global::RMIBtnWrapperLib.TMEXException ex)
						{
							throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("즊ﮎﲒﮔ랖삠힢첤좦잨讪좬\uddae쎰\udcb2잴趶馸", a_) + ex.Message, ex);
						}
						catch (global::System.Exception ex2)
						{
							throw ex2;
						}
						finally
						{
							num = (short)32047105;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2A5;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_212;
									}
									continue;
								case 2:
									this.btnCommon.CloseFile(this.hSession, ref num4);
									num4 = -1;
									num = (short)359202816;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_212:
								num = (short)115603800;
								short num6 = num;
								num = (short)1747843416;
								switch ((num6 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_2A7;
								default:
									num = (short)166854656;
									if (num != 0)
									{
									}
									if (num4 <= -1)
									{
										goto IL_2A7;
									}
									num = (short)1892548610;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_2A5:
							IL_2A7:;
						}
						goto IL_2A8;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_84;
						}
						continue;
					case 2:
						goto IL_CE;
					}
					IL_84:
					num = (short)166330369;
					if (num != 0)
					{
					}
					if (!this.bButtonOpened)
					{
						num = (short)298516482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_2A8:
					num4 = -1;
					pMaxBytes = 0;
					num = (short)1162018816;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CE:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("튈쾊벌튎놐\udc92\ud99a햠첢쮤螦잨쒪\ud9ac辮튰튲\ud9b4\udbb6\udcb8\udfba", a_));
			}
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00011154 File Offset: 0x0000F354
		public void WriteFile(string fileName, short numDataBytes, byte[] pFileData)
		{
			int a_ = 1;
			short num = (short)1924923392;
			switch (num)
			{
			default:
			{
				num = (short)1561198593;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						short num3;
						if (numDataBytes > num3)
						{
							num = (short)417595398;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						short hFile = -1;
						num = (short)1513881609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_81;
						}
						continue;
					case 2:
						if (pFileData != null)
						{
							num = (short)2143420424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18D;
					case 3:
						num = (short)1535442944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)1763901441;
						if (num != 0)
						{
						}
						short num3 = 7057;
						num = (short)1077477387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_A2;
					case 6:
						goto IL_F8;
					case 7:
						if (numDataBytes >= 1)
						{
							num = (short)601030659;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18D;
					case 8:
						goto IL_483;
					case 9:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_224;
							}
							byte[] array;
							for (;;)
							{
								IL_1F9:
								switch (num2)
								{
								case 0:
									num = (short)2133393414;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (array != null)
									{
										num = (short)1766850565;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3C1;
								case 2:
									if (array[4] == 0)
									{
										num = (short)386990087;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_42F;
								case 3:
								{
									try
									{
										this.btnCommon.DeleteFile(this.hSession, array);
										goto IL_3D5;
									}
									catch (global::RMIBtnWrapperLib.TMEXException ex)
									{
										if (ex.ErrorCode == -6)
										{
											num = (short)296615350;
											short num4 = num;
											num = (short)770178486;
											switch ((num4 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												break;
											default:
												num = (short)1591607296;
												if (num != 0)
												{
												}
												goto IL_3D5;
											}
										}
										throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("㩾ꦈﲔ練ﺘ뮚ﲜ뾞잠쪢즤슦鎨讪", a_) + ex.Message);
									}
									goto IL_3C1;
									IL_3D5:
									short num5 = 0;
									short hFile;
									this.btnCommon.CreateFile(this.hSession, out hFile, array, out num5);
									this.btnCommon.WriteFile(this.hSession, hFile, pFileData, numDataBytes);
									this.btnCommon.CloseFile(this.hSession, ref hFile);
									num = (short)1903951872;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_32C;
								case 5:
								{
									string fileName2 = global::RMIBtnWrapperLib.IBtnWrapperBase.GetFileName(array);
									num = (short)849674242;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_465;
								case 7:
									num = (short)467337224;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									string fileName2;
									if (fileName2 == global::RMIBtnWrapperLib.TMEXException.g("㉾삀펂쎄", a_))
									{
										num = (short)2002321412;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_42F;
								}
								}
								goto IL_224;
								IL_42F:
								num = (short)73728003;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_32C:
							throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("⑾얀놂랄\uda86ꦈ쪊랖붜튞覦馨讪쒬\udcae醰솲킴쒶춸즺풼\udcbe뗀ꛂꇄ", a_));
							IL_3C1:
							throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("㙾권즎ﾒ랖\udc98\ud8a0莢즦쾨쒪\udfac슮킰잲\udcb4\ud8b6ힸ", a_));
							IL_465:
							return;
							IL_224:
							this.btnCommon.GetSessionHandle(ref this.hSession);
							this.btnCommon.DoTMSetup(this.hSession);
							array = null;
							array = this.btnCommon.LoadFileName(fileName);
							num = (short)1818886145;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1F9;
						}
						catch (global::RMIBtnWrapperLib.TMEXException innerException)
						{
							throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("ᙾ쎀권\ud88e朗릘\ude9a캠톢薤誦覨\ud8aa좬쪮醰者\udbb4\ud9b6\udcb8즺잾ꋀꛂ뗄돆ꃈ꓊ꏌ럐볒꟔뷘뻚꧜뻞裠迢雤", a_), innerException);
						}
						catch (global::System.Exception ex2)
						{
							throw ex2;
						}
						goto IL_483;
					case 10:
						goto IL_1A1;
					case 11:
						goto IL_1A1;
					case 12:
					{
						byte[] romserialNum = this.GetROMSerialNum();
						short num3 = 0;
						if (romserialNum[0] == 12)
						{
							num = (short)978255876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)892862464;
						short num6 = num;
						num3 = 420;
						num = (short)1867251722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_81:
					if (!this.bButtonOpened)
					{
						num = (short)348913669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)732364812;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A1:
					num = (short)618725378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_483:
					num = (short)768671751;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A2:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("⑾얀늂\ud884Ꞇ욈ﮊ펐붜캠힢薤쒦좨잪솬쪮햰", a_));
				IL_F8:
				IL_18D:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("⑾얀놂\ud884Ꞇ삈ﮌ﶐朗랖煮뾞토슢횤풦첨쾪趬\udbae\udeb0鎲얶킸쾺\ud8bc料ꣀ꿂ꃄ", a_));
			}
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000116BC File Offset: 0x0000F8BC
		public void ReadFile(string fileName, ref short pNumBytes, out byte[] pFileData)
		{
			int a_ = 16;
			short num = (short)541327360;
			switch (num)
			{
			default:
			{
				num = (short)1210646529;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					short num5;
					switch (num2)
					{
					case 0:
						if (pNumBytes == 0)
						{
							num = (short)740622340;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)745472010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_84;
						}
						continue;
					case 2:
					{
						short num3 = 7057;
						num = (short)1262551043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_3BD;
					case 4:
					{
						num = (short)1045430272;
						short num4 = num;
						short num3;
						pNumBytes = num3;
						num = (short)1532297223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_3B8;
					case 6:
						goto IL_A4;
					case 7:
						goto IL_40B;
					case 8:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_13C;
							}
							byte[] array;
							for (;;)
							{
								IL_125:
								switch (num2)
								{
								case 0:
									if (array != null)
									{
										num = (short)1919156226;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1F2;
								case 1:
									goto IL_21F;
								case 2:
									this.btnCommon.OpenFile(this.hSession, out num5, array, false);
									this.btnCommon.ReadFile(this.hSession, num5, ref pNumBytes, out pFileData);
									this.btnCommon.CloseFile(this.hSession, ref num5);
									num = (short)1730871299;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)55771137;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_13C;
							}
							IL_1F2:
							throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("잍ﺏ歹ﺙ벛\ud89d즟캡솣蚥쒩\ud8ab\udcad즯銱ﶳ\ud8b5\udeb7햹캻펽ꆿ뛁귃꧅ꛇ", a_));
							IL_21F:
							return;
							IL_13C:
							this.btnCommon.GetSessionHandle(ref this.hSession);
							this.btnCommon.DoTMSetup(this.hSession);
							array = this.btnCommon.LoadFileName(fileName);
							num = (short)1627062272;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_125;
						}
						catch (global::RMIBtnWrapperLib.TMEXException ex)
						{
							throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("튏벛첝얟쎡삣蚥\ud8a9\udeab솭슯袱钳", a_) + ex.Message, ex);
						}
						catch (global::System.Exception ex2)
						{
							throw ex2;
						}
						finally
						{
							num = (short)1734279169;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_30B;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_27A;
									}
									continue;
								case 2:
									this.btnCommon.CloseFile(this.hSession, ref num5);
									num = (short)2083454976;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_27A:
								num = (short)242737156;
								short num6 = num;
								num = (short)654958596;
								switch ((num6 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_30D;
								default:
									num = (short)1540227072;
									if (num != 0)
									{
									}
									if (num5 <= -1)
									{
										goto IL_30D;
									}
									num = (short)1784938498;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_30B:
							IL_30D:;
						}
						goto IL_30E;
					case 9:
						num = (short)555614209;
						if (num != 0)
						{
						}
						num = (short)1643511821;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (pNumBytes >= 1)
						{
							num = (short)1395261449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A9;
					case 11:
						goto IL_3BD;
					case 12:
					{
						byte[] romserialNum = this.GetROMSerialNum();
						short num3 = 0;
						if (romserialNum[0] == 12)
						{
							num = (short)2078605314;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = 420;
						num = (short)162332683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						short num3;
						if (pNumBytes > num3)
						{
							num = (short)1508048901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40B;
					}
					}
					IL_84:
					if (!this.bButtonOpened)
					{
						num = (short)1235615750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_30E:
					pFileData = null;
					num = (short)1577320460;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3BD:
					num = (short)1963261952;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_40B:
					num5 = -1;
					num = (short)789381128;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A4:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("햍풏ꎑ즓뚕힗鍊힡킣튥잧쒩貫삭\udfaf욱钳햵\ud9b7횹킻\udbbd꒿", a_));
				IL_A9:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("햍풏ꂑ즓뚕쪗ﾙﶛ瞧쮡좣쎥袧첩춫잭\udcafힱ킳貵颷튻좽ꆿ껁귃ꋅ뫉귋볍뇏뿑뇓ꋕ뷗꣙ﳛ꣝臟軡釣菥죧菩苫컭쳯英뫳菵闷룹藻諽旿焁㨃⠅", a_));
				IL_3B8:
				goto IL_A9;
			}
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00011BA8 File Offset: 0x0000FDA8
		public bool WriteFileAtPage(string fileName, int numDataBytes, short nStartPage, byte[] pFileData)
		{
			int a_ = 12;
			short num = (short)1623392256;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_74;
				}
				bool result;
				for (;;)
				{
					IL_31:
					short num4;
					switch (num2)
					{
					case 0:
						goto IL_16E;
					case 1:
					{
						num = (short)1440546816;
						short num3 = num;
						byte[] romserialNum = this.GetROMSerialNum();
						num4 = 0;
						if (romserialNum[0] == 12)
						{
							num = (short)983040003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_446;
					}
					case 2:
						if (!this.bButtonOpened)
						{
							num = (short)1354694656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1251803142;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num4 = 7057;
						num = (short)40894474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)344326152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_1F9;
							}
							for (;;)
							{
								IL_17D:
								num = (short)667438099;
								short num5 = num;
								num = (short)917654547;
								byte[] array;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1499201536;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										array = this.btnCommon.LoadFileName(fileName);
										num = (short)1819082760;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_3A1;
									case 2:
										if (this.hSession != 0)
										{
											num = (short)1601896454;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_388;
									case 3:
										if (this.btnCommon.DoTMSetup(this.hSession))
										{
											num = (short)265027584;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_388;
									case 4:
										goto IL_32B;
									case 5:
									{
										string b;
										if (new global::System.Text.ASCIIEncoding().GetString(array) == b)
										{
											num = (short)1030815748;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_355;
									}
									case 6:
										num = (short)1509228547;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										goto IL_388;
									case 8:
										if (array != null)
										{
											num = (short)1328676873;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_341;
									case 9:
									{
										string b = global::RMIBtnWrapperLib.TMEXException.g("잉춋\ude8d횏ꊑ", a_);
										num = (short)401276933;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									goto IL_1F9;
									IL_388:
									num = (short)1029242881;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_355:
								result = this.btnCommon.WriteFile(this.hSession, array, pFileData, numDataBytes, nStartPage);
								num = (short)828571655;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_32B:
							throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("톉좋벍ꊏ쾑뒓힕ﮗ蓮鍊펟芡킣즥袧ﺭ鲱蒳隵톷즹鲻첽ꖿ뇁냃듅ꇇ꧉룋ꯍ듏ﳑ", a_));
							IL_341:
							throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("쎉ﺑﶓ뢗\udc99얟芡좥\udca7\ud8a9햫躭羚\udcb1튳\ud9b5쪷ힹ\uddbb쪽ꦿ귁꫃", a_));
							IL_3A1:
							return result;
							IL_1F9:
							this.btnCommon.GetSessionHandle(ref this.hSession);
							num = (short)764805122;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_17D;
						}
						catch (global::RMIBtnWrapperLib.TMEXException ex)
						{
							throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("캋ﮍﮓ뢗좙鍊ﾝ쒟芡풥\udaa7얩\udeab钭邯", a_) + ex.Message, ex);
						}
						catch (global::System.Exception ex2)
						{
							throw ex2;
						}
						finally
						{
							num = (short)1674575873;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								short num6;
								switch (num2)
								{
								case 0:
									this.btnCommon.CloseFile(this.hSession, ref num6);
									num = (short)352124930;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3FE;
									}
									continue;
								case 2:
									goto IL_443;
								}
								IL_3FE:
								if (num6 <= -1)
								{
									break;
								}
								num = (short)52363264;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_443:;
						}
						goto IL_446;
					case 6:
						if (pFileData != null)
						{
							num = (short)997720068;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E3;
					case 7:
						if (numDataBytes <= (int)num4)
						{
							num = (short)108855307;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E3;
					case 8:
						num = (short)1746993153;
						if (num != 0)
						{
						}
						if (numDataBytes >= 1)
						{
							num = (short)2031878156;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E3;
					case 9:
						goto IL_4A8;
					case 10:
						goto IL_131;
					case 11:
						num = (short)294322190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1056636935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_131;
					case 14:
					{
						if (fileName == "")
						{
							num = (short)373817353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						short num6 = -1;
						num = (short)1583022085;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_74;
					IL_131:
					num = (short)1114243074;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_446:
					num4 = 420;
					num = (short)1676345357;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E3:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("톉좋벍춏늑욓聯ﺙ\uda9b첟잡蒣삥즧쎩삫쮭풯袱钳ﾵ횷첹\uddbb튽ꦿꛁ뛅꧇룉귋ꏍ뗏ꛑ뇓ꓕ곙뷛닝闟蟡쓣迥蛧쫩탫黭뻯蟱駳듵臷軹駻跽㻿Ⰱ", a_));
				IL_16E:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("톉좋뾍춏늑\udb93ﶗ\ude9b풟횡쮣좥袧쒩쎫\udaad邯톱햳\udab5풷\udfb9\ud8bb", a_));
				IL_4A8:
				goto IL_E3;
				IL_74:
				result = false;
				num = (short)938672129;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000121A8 File Offset: 0x000103A8
		public int GetWCC(uint pageNo)
		{
			int a_ = 12;
			short num = (short)1229520896;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4F;
			}
			int num3;
			int result;
			for (;;)
			{
				IL_3D:
				switch (num3)
				{
				case 0:
				{
					this.btnCommon.GetSessionHandle(ref this.hSession);
					this.btnCommon.DoTMSetup(this.hSession);
					result = this.btnCommon.a(this.hSession, pageNo);
					num = (short)2080270898;
					short num4 = num;
					num = (short)22243890;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)967049217;
						if (num != 0)
						{
						}
						num = (short)1766391808;
						if (num != 0)
						{
						}
						num = (short)1473773570;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (this.btnCommon != null)
					{
						num = (short)568852480;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_83;
				case 2:
					return result;
				}
				goto IL_4F;
			}
			IL_83:
			throw new global::RMIBtnWrapperLib.TMEXException(global::RMIBtnWrapperLib.TMEXException.g("캋ﮍﮓ뢗춙ﾝ킟튡솣풥袧캫쒭햯톱삳隵톷즹鲻킽꾿뛁꿅ꛇꏉ룋ꟍ뇏뻑뷓곕뷗뻙ﳛ￝", a_));
			IL_4F:
			result = -1;
			num = (short)521994241;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_3D;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00012310 File Offset: 0x00010510
		public void ReadMemoryData(byte addrLSB, byte addrMSB, short numBytesRequested, byte[] data)
		{
			int a_ = 11;
			short num;
			for (;;)
			{
				num = (short)264765441;
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
							goto IL_3A;
						}
						continue;
					case 2:
						goto IL_245;
					}
					IL_3A:
					if (!this.bButtonOpened)
					{
						num = (short)1281359872;
						short num3 = num;
						num = (short)924123136;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1261633538;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_1A7:
				num = (short)724404565;
				short num4 = num;
				num = (short)517966165;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_1DE;
				}
				IL_83:
				goto IL_1A7;
				IL_245:
				try
				{
					switch (0)
					{
					case 0:
						goto IL_B0;
					}
					for (;;)
					{
						IL_92:
						switch (num2)
						{
						case 0:
							this.btnCommon.ReadMemoryData(this.hSession, addrLSB, addrMSB, numBytesRequested, data);
							num = (short)1109393410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)280887299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_169;
						case 3:
							if (this.btnCommon.DoTMSetup(this.hSession))
							{
								num = (short)1473380352;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_169;
						case 4:
							if (this.hSession != 0)
							{
								num = (short)1689976833;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_169;
						case 5:
							goto IL_180;
						}
						goto IL_B0;
						IL_169:
						num = (short)2093547525;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_180:
					return;
					IL_B0:
					this.btnCommon.GetSessionHandle(ref this.hSession);
					num = (short)1286012932;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_92;
				}
				catch (global::RMIBtnWrapperLib.TMEXException ex)
				{
					throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("즊ﮎﲒﮔ랖쮘ﺚﲜﮞ膠힤햦욨\ud9aa鞬辮", a_) + ex.Message, ex);
				}
				catch (global::System.Exception ex2)
				{
					throw ex2;
				}
				goto IL_1A7;
			}
			IL_1DE:
			num = (short)2020081665;
			if (num != 0)
			{
			}
			num = (short)1521745920;
			if (num != 0)
			{
			}
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("튈쾊벌튎놐\udc92\ud99a햠첢쮤螦잨쒪\ud9ac辮튰튲\ud9b4\udbb6\udcb8\udfba", a_));
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00012584 File Offset: 0x00010784
		public void ReadFileAtPage(string fileName, ref short pNumBytes, ref short nStartPage, out byte[] pFileData)
		{
			int a_ = 5;
			short num = (short)839450624;
			switch (num)
			{
			default:
			{
				num = (short)1636237312;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					short num5;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_8D;
						}
						continue;
					case 1:
					{
						byte[] romserialNum = this.GetROMSerialNum();
						short num3 = 0;
						if (romserialNum[0] == 12)
						{
							num = (short)524288011;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = 420;
						num = (short)796196877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)611844106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_AD;
					case 4:
						goto IL_504;
					case 5:
						try
						{
							num = (short)39166620;
							short num4 = num;
							num = (short)1052484252;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)169672704;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_1CC;
								}
								break;
							}
							for (;;)
							{
								IL_1A5:
								switch (num2)
								{
								case 0:
									if (this.hSession != 0)
									{
										num = (short)1141243910;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_30C;
								case 1:
									goto IL_324;
								case 2:
								{
									byte[] array;
									this.btnCommon.ReadFile(this.hSession, array, ref nStartPage, ref pNumBytes, out pFileData);
									num = (short)381616135;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									if (this.btnCommon.DoTMSetup(this.hSession))
									{
										num = (short)774242308;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_30C;
								case 4:
								{
									num = (short)466747393;
									if (num != 0)
									{
									}
									byte[] array = this.btnCommon.LoadFileName(fileName);
									num = (short)808845317;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									byte[] array;
									if (array != null)
									{
										num = (short)325976066;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2F8;
								}
								case 6:
									num = (short)654639107;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_30C;
								}
								goto IL_1CC;
								IL_30C:
								num = (short)1453719553;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2F8:
							throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("쪂놐햒ﲔﮖﲘ뮚\ud89c햠톢\udca4螦얪쮬삮쎰\udeb2풴쎶킸풺펼", a_));
							IL_324:
							return;
							IL_1CC:
							this.btnCommon.GetSessionHandle(ref this.hSession);
							num = (short)1291583488;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1A5;
						}
						catch (global::RMIBtnWrapperLib.TMEXException ex)
						{
							throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("임ﶈﾊ놐솒ﶘ뮚\ud89c펠첢힤鶦覨", a_) + ex.Message, ex);
						}
						catch (global::System.Exception ex2)
						{
							throw ex2;
						}
						finally
						{
							num = (short)1780875265;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									this.btnCommon.CloseFile(this.hSession, ref num5);
									num = (short)119799810;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_37D;
									}
									continue;
								case 2:
									goto IL_3C2;
								}
								IL_37D:
								if (num5 <= -1)
								{
									break;
								}
								num = (short)1042808832;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3C2:;
						}
						goto IL_3C5;
					case 6:
						goto IL_493;
					case 7:
						if (fileName == "")
						{
							num = (short)304218124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_493;
					case 8:
						if (pNumBytes == 0)
						{
							num = (short)1079377929;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)341508110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						short num3;
						pNumBytes = num3;
						num = (short)12320774;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						short num3;
						if (pNumBytes <= num3)
						{
							num = (short)1567883279;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B2;
					}
					case 11:
					{
						short num3 = 7057;
						num = (short)1932656644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_450;
					case 13:
						goto IL_504;
					case 14:
						if (pNumBytes >= 1)
						{
							num = (short)2081554434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B2;
					case 15:
						num = (short)1144848391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_8D:
					if (!this.bButtonOpened)
					{
						num = (short)542703619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3C5:
					pFileData = null;
					num = (short)116523009;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_493:
					num5 = -1;
					num = (short)384106501;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_504:
					num = (short)1805058056;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_AD:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\ud882솄뚆품ꮊ슌ﾎﶒ힔膠춢쪤펦覨좪첬쎮\uddb0횲톴", a_));
				IL_B2:
				num = (short)1500643328;
				short num6 = num;
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\ud882솄떆품ꮊ\udf8c펔ﺖﺚ붜咽삠쪢즤슦춨醪趬\udfb0얲풴\udbb6킸\udfba鶼쾾ꃀ뇂꓄꫆곈뿊꣌뷎ꗒ듔믖곘뻚﷜뛞迠쏢\ud9e4韦꟨黪胬귮裰蟲郴蓶쟸헺", a_));
				IL_450:
				goto IL_B2;
			}
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00012B20 File Offset: 0x00010D20
		public bool DoesFileExist(string fileName)
		{
			int a_ = 1;
			short num = (short)1398331174;
			short num2 = num;
			num = (short)1959581478;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)639434752;
				if (num != 0)
				{
				}
				num = (short)1686896641;
				if (num != 0)
				{
				}
				num = (short)565575680;
				num3 = (int)num;
				switch (num3)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_DD;
					}
					break;
				}
				break;
			}
			for (;;)
			{
				IL_A1:
				num = (short)181469184;
				short num4 = num;
				switch (num3)
				{
				case 0:
					goto IL_115;
				case 1:
					if (!this.bButtonOpened)
					{
						num = (short)671940608;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1909063682;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_274;
				}
				goto IL_DD;
			}
			IL_115:
			IL_245:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("⑾얀늂\ud884Ꞇ욈ﮊ펐붜캠힢薤쒦좨잪솬쪮햰", a_));
			IL_274:
			bool result;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_13F;
				}
				short num5;
				for (;;)
				{
					IL_124:
					switch (num3)
					{
					case 0:
						goto IL_207;
					case 1:
						result = true;
						this.btnCommon.CloseFile(this.hSession, ref num5);
						num = (short)1178009600;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_207;
					case 3:
						if (num5 > -1)
						{
							num = (short)651755521;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = false;
						num = (short)1874526210;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_221;
					}
					goto IL_13F;
					IL_207:
					num = (short)1033306116;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_221:
				return result;
				IL_13F:
				num5 = -1;
				this.btnCommon.GetSessionHandle(ref this.hSession);
				this.btnCommon.DoTMSetup(this.hSession);
				byte[] fentry = this.btnCommon.LoadFileName(fileName);
				this.btnCommon.OpenFile(this.hSession, out num5, fentry, true);
				num = (short)665976835;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_124;
			}
			catch (global::RMIBtnWrapperLib.TMEXException ex)
			{
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("ᙾ쎀권膠욢힤햦욨\ud9aa鞬辮", a_) + ex.Message, ex);
			}
			catch (global::System.Exception ex2)
			{
				throw ex2;
			}
			goto IL_245;
			IL_DD:
			result = false;
			num = (short)1751973889;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_A1;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00012DDC File Offset: 0x00010FDC
		public void InitButton(byte[] version, byte[] communityCode, string userid, string password, string authCode, short alarmOffset, char offsetFormat, char expirationAction, bool bWPTimer)
		{
			int a_ = 13;
			short num = (short)949288960;
			switch (num)
			{
			default:
			{
				num = (short)44040193;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_A3;
					case 1:
						goto IL_3D;
					case 2:
						goto IL_577;
					}
					goto IL_5A;
					IL_3D:
					switch (0)
					{
					case 0:
					{
						IL_5A:
						num = (short)1050542080;
						short num3 = num;
						if (!this.bButtonOpened)
						{
							num = (short)1590820864;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							num = (short)1721250264;
							short num4 = num;
							num = (short)1617048024;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_3D;
							default:
								num = (short)1484914688;
								if (num != 0)
								{
								}
								num = (short)1176436738;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
						}
						break;
					}
					}
				}
				IL_A3:
				IL_4D6:
				num = (short)995360769;
				if (num != 0)
				{
				}
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("킊즌뺎첐뎒\uda94ﲘ\udf9c햠힢쪤즦覨얪슬\udbae醰킲풴\udbb6햸\udeba\ud9bc", a_));
				IL_577:
				try
				{
					switch (0)
					{
					case 0:
						goto IL_115;
					}
					bool flag;
					for (;;)
					{
						IL_B2:
						switch (num2)
						{
						case 0:
							if (authCode.CompareTo(global::RMIBtnWrapperLib.TMEXException.g("쾌캎힐톒횔Ꚗ\ud898ꦚ\udf9c\udc9e銠醤얦쾨캪钬蒴莶躸了趼諭蛆﷌럎돐닒돔뗖뫘볜췠폢鷤藦諨\ud8ea賬\udfee觰쟲韴釶鳸胺췼蟾㠀愂", a_)) == 0)
							{
								num = (short)1476591618;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)589692945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (this.bMotoBtn)
							{
								num = (short)771751957;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_263;
						case 2:
							this.bMotoBtn = true;
							flag = true;
							num = (short)691863557;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_439;
						case 4:
							this.btnCommon.SetTimer(this.hSession, alarmOffset, global::RMIBtnWrapperLib.TimerType.realTime, offsetFormat, expirationAction, bWPTimer);
							num = (short)1417216015;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_32A;
						case 6:
							if (flag)
							{
								num = (short)1433403411;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A6;
						case 7:
							if (this.btnCommon.ValidateBtnInitTimerArgs(offsetFormat, expirationAction))
							{
								num = (short)839385106;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_439;
						case 8:
							if (this.GetROMSerialNum()[0] == 4)
							{
								num = (short)561577988;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4A1;
						case 9:
							goto IL_439;
						case 10:
							goto IL_4BA;
						case 11:
							goto IL_263;
						case 12:
							goto IL_32A;
						case 13:
							this.bMotoBtn = false;
							flag = true;
							num = (short)419889164;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							this.btnCommon.GetSessionHandle(ref this.hSession);
							this.btnCommon.DoTMSetup(this.hSession);
							this.btnCommon.FormatButton(this.hSession);
							num = (short)564658177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							goto IL_4A1;
						case 16:
						{
							bool flag2 = this.btnCommon.ValidateBtnInitUserArgs(version, communityCode, userid, password);
							num = (short)821035017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 17:
							if (authCode.CompareTo(global::RMIBtnWrapperLib.TMEXException.g("뮌춎튐톒Ꚕꖖꢘ겚ꪜ\uda9e醠邢醤骨莲芺ﲼ覾蓀﯂胄ﻈ﷊﷌럎鋐铔믘뷚룜췠폢鷤폦诨跪裬\udeee觰닲铴샶髸胺췼蟾䌀㨂", a_)) == 0)
							{
								num = (short)1362427917;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_32A;
						case 18:
							num = (short)642318356;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
						{
							bool flag2 = false;
							num = (short)1288175623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 20:
						{
							if (this.bMotoBtn)
							{
								num = (short)460914704;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							bool flag2 = true;
							num = (short)66060291;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 21:
						{
							string authCode2 = global::RMIBtnWrapperLib.TMEXException.g("캌뺎펐튒펔햖\ud898ꮚﶞ잠醢骨馬춮튰育풴螶솸辺\udfbc\ud9be꓀輸蟄藆诈﯊裌곎닒ﯖ볘ꃚ꟞틠ퟢ퓤ꛦ\ud8e8폪꣬\udeee연쓲열迶鯸髺鯼鷾㠀愂", a_);
							this.btnCommon.WriteMapfFile(this.hSession, version, communityCode, userid, password, authCode2);
							num = (short)428670987;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 22:
						{
							bool flag2;
							if (flag2)
							{
								num = (short)439418894;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4A1;
						}
						}
						goto IL_115;
						IL_263:
						num = (short)250675208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_32A:
						num = (short)1518862342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_439:
						num = (short)103350294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4A1:
						num = (short)1979318282;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2A6:
					throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("얊ﮎ놐\udba0욢솤覦", a_));
					IL_4BA:
					return;
					IL_115:
					this.bOpenForInit = false;
					flag = false;
					num = (short)873725952;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_B2;
				}
				catch (global::RMIBtnWrapperLib.TMEXException innerException)
				{
					throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("쾌搜杖練릘튚햠쪢쒤쮦삨톪첬\udbae\ud8b0\udcb2\udbb4鞶ﲸ즺쾼킾돀뫈껊꣌飐뷒믔닖ꯘ黚ꗜ볞蓠鏢釤軦蛨藪췬觮黰臲헴鏶鳸迺鳼雾洀瀂", a_), innerException);
				}
				catch (global::System.Exception ex)
				{
					throw ex;
				}
				goto IL_4D6;
			}
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0001339C File Offset: 0x0001159C
		internal bool a()
		{
			int a_ = 2;
			bool result;
			short num;
			for (;;)
			{
				result = false;
				try
				{
					string fileName = global::RMIBtnWrapperLib.TMEXException.g("쵿쎁풃삅ꚇ몉", a_);
					result = this.DoesFileExist(fileName);
				}
				catch (global::System.Exception ex)
				{
					throw ex;
				}
				num = (short)1584627930;
				short num2 = num;
				num = (short)383680730;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					goto IL_83;
				}
				break;
			}
			num = (short)711786496;
			short num3 = num;
			IL_83:
			num = (short)1407516672;
			if (num != 0)
			{
			}
			num = (short)1861943297;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0001347C File Offset: 0x0001167C
		public void CloseButton()
		{
			short num = (short)932446210;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					this.btnCommon.EndSession(this.hSession);
					num = (short)1261371395;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 3:
					IL_138:
					goto IL_61;
				case 4:
				{
					num = (short)1675231232;
					short num3 = num;
					if (this.hSession > 0)
					{
						num = (short)428539905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_61;
				}
				case 5:
					num = (short)1868759044;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3C:
				if (this.btnCommon != null)
				{
					num = (short)176553989;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_61:
				num = (short)1721597482;
				short num4 = num;
				num = (short)58949162;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_138;
				default:
					num = (short)1810694145;
					if (num != 0)
					{
					}
					num = (short)1201471488;
					if (num != 0)
					{
					}
					this.btnCommon = null;
					this.bButtonOpened = false;
					this.bOpenForInit = false;
					this.portNum = 1;
					num = (short)1279262720;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00013634 File Offset: 0x00011834
		public void DeleteFile(string fileName)
		{
			int a_ = 9;
			short num = (short)1975648258;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_262;
				case 1:
					goto IL_AC;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				}
				IL_3A:
				num = (short)721747969;
				if (num != 0)
				{
				}
				num = (short)1448148992;
				short num3 = num;
				if (!this.bButtonOpened)
				{
					num = (short)1167720449;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1941569536;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_AC:
			IL_236:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\udc86춈몊킌꾎\ude90練\udb98캠춢薤즦욨\udfaa趬첮킰\udfb2\ud9b4튶\uddb8", a_));
			IL_262:
			try
			{
				switch (0)
				{
				case 0:
					goto IL_D5;
				}
				byte[] array;
				for (;;)
				{
					IL_BB:
					switch (num2)
					{
					case 0:
						goto IL_21D;
					case 1:
						if (global::RMIBtnWrapperLib.IBtnWrapperBase.a(array) == 0)
						{
							num = (short)454098948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F2;
					case 2:
						while (global::RMIBtnWrapperLib.IBtnWrapperBase.GetFileName(array) == global::RMIBtnWrapperLib.TMEXException.g("쪆좈\udb8a쮌", a_))
						{
							num = (short)1032321264;
							short num4 = num;
							num = (short)1264580848;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1793196032;
								if (num != 0)
								{
								}
								num = (short)1452539907;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_BB;
							}
						}
						goto IL_1F2;
					case 3:
						goto IL_1ED;
					case 4:
						num = (short)896401410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D5;
					IL_1F2:
					this.btnCommon.DeleteFile(this.hSession, array);
					num = (short)747503616;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1ED:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\udc86춈릊뾌튎놐튒ﲘ뾞햠첢薤ﮪ膮膰鎲\udcb4쒶馸즺\ud8bc첾뗀뇂계꓆뷈껊꧌", a_));
				IL_21D:
				return;
				IL_D5:
				this.btnCommon.GetSessionHandle(ref this.hSession);
				this.btnCommon.DoTMSetup(this.hSession);
				array = null;
				array = this.btnCommon.LoadFileName(fileName);
				num = (short)1221656577;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_BB;
			}
			catch (global::RMIBtnWrapperLib.TMEXException innerException)
			{
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("쮈ﺊ歷ﮎﺐﶒ떔\ud896ﺚﺞ햠쪢쪤즦覨\udfac\uddae\udeb0솲閴骶馸좺\ud8bc\udabe諂ꯄ꧆곈맊裌럎닐뛒ꗔꏖ냘듚돜￞蟠賢韤쟦跨軪駬軮飰鿲蛴", a_), innerException);
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
			goto IL_236;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000138DC File Offset: 0x00011ADC
		public void GetNumDaysLeft(ref short pDaysLeft)
		{
			int a_ = 15;
			short num = (short)1848836098;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_176;
				case 1:
					goto IL_CF;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				}
				IL_39:
				num = (short)1383218918;
				short num3 = num;
				num = (short)1500921574;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_120;
				default:
					num = (short)1042939905;
					if (num != 0)
					{
					}
					num = (short)1018560512;
					if (num != 0)
					{
					}
					if (!this.bButtonOpened)
					{
						num = (short)318832641;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1021575168;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_CF:
			IL_120:
			num = (short)722403328;
			short num4 = num;
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("회쮎ꂐ캒떔\ud896ﺚ\udd9e풠힢톤좦잨讪쎬삮얰鎲횴횶햸ힺ\ud8bc\udbbe", a_));
			IL_176:
			try
			{
				this.btnCommon.GetSessionHandle(ref this.hSession);
				this.btnCommon.DoTMSetup(this.hSession);
				this.btnCommon.GetNumDaysLeft(this.hSession, global::RMIBtnWrapperLib.TimerType.realTime, ref pDaysLeft);
				return;
			}
			catch (global::RMIBtnWrapperLib.TMEXException innerException)
			{
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("춎뮚쒠톢쒤펦삨쒪쎬辮풰솲잴\ud8b6쮸鮺邼龾닀ꛂꃄ胈ꗊꏌ꫎ꏐ雒귔듖볘ꯚ꧜뛞軠跢엤臦蛨駪췬诮铰蟲铴黶闸裺", a_), innerException);
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
			goto IL_120;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00013A80 File Offset: 0x00011C80
		public byte[] GetROMSerialNum()
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			byte[] result;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_137;
				case 1:
					this.btnCommon.GetSessionHandle(ref this.hSession);
					this.btnCommon.DoTMSetup(this.hSession);
					result = this.btnCommon.GetROMSerialNum(this.hSession, true);
					num2 = (short)1532624896;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1038680064;
					short num3 = num2;
					num2 = (short)252190821;
					short num4 = num2;
					num2 = (short)473636965;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)1022623744;
						if (num2 != 0)
						{
						}
						if (this.btnCommon != null)
						{
							num2 = (short)1705377793;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_D5;
					}
					break;
				}
				}
				goto IL_25;
			}
			IL_D5:
			throw new global::RMIBtnWrapperLib.TMEXException(global::RMIBtnWrapperLib.TMEXException.g("첍秊몙쮛솟튡풣쎥\udaa7誩청\udaafힱힳ습颷펹쾻麽꺿귁냃ꇇ꓉ꗋ뫍맏돑룓뿕ꋗ뿙룛ﻝ쇟", a_));
			IL_137:
			num2 = (short)643235841;
			if (num2 != 0)
			{
			}
			return result;
			IL_25:
			result = new byte[8];
			num2 = (short)1781006338;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00013BF0 File Offset: 0x00011DF0
		public string GetROMSerialNumString()
		{
			int a_ = 4;
			string text = null;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_31;
				}
				int num;
				int num4;
				byte[] romserialNum;
				for (;;)
				{
					IL_17:
					switch (num)
					{
					case 0:
						goto IL_123;
					case 1:
						goto IL_50;
					case 2:
					{
						num2 = (short)1689827959;
						short num3 = num2;
						num2 = (short)264223351;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_CA;
						default:
							num2 = (short)1796800512;
							if (num2 != 0)
							{
							}
							num2 = (short)777125888;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
						goto IL_50;
					case 4:
						if (num4 < 0)
						{
							num2 = (short)173408258;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_CA;
					}
					goto IL_31;
					IL_50:
					num2 = (short)1324941316;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_CA:
					text += string.Format(global::RMIBtnWrapperLib.TMEXException.g("女뒃벅뢉", a_), romserialNum[num4]);
					num4--;
					num2 = (short)1265631235;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_123:
				goto IL_127;
				IL_31:
				romserialNum = this.GetROMSerialNum();
				num4 = 7;
				num2 = (short)85524481;
				num = (int)((global::System.IntPtr)num2);
				goto IL_17;
			}
			catch (global::RMIBtnWrapperLib.TMEXException ex)
			{
				throw ex;
			}
			catch (global::System.Exception ex2)
			{
				throw ex2;
			}
			IL_127:
			num2 = (short)758185985;
			if (num2 != 0)
			{
			}
			num2 = (short)760676352;
			short num5 = num2;
			return text;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00013DA8 File Offset: 0x00011FA8
		internal void b()
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_39;
			}
			int num;
			byte[] romserialNum;
			byte[] array;
			short num2;
			for (;;)
			{
				IL_13:
				int num3;
				switch (num)
				{
				case 0:
					goto IL_13B;
				case 1:
					goto IL_13B;
				case 2:
					goto IL_17E;
				case 3:
					return;
				case 4:
					if (romserialNum.Length == array.Length)
					{
						num2 = (short)1912995847;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_229;
				case 5:
					goto IL_207;
				case 6:
					if (romserialNum[num3] != array[num3])
					{
						num2 = (short)1632960517;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num3++;
					num2 = (short)690028544;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					num2 = (short)1721120760;
					short num4 = num2;
					num2 = (short)387069944;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_17E;
					default:
						num2 = (short)980615169;
						if (num2 != 0)
						{
						}
						num2 = (short)747372544;
						if (num2 != 0)
						{
						}
						num3 = 0;
						num2 = (short)555286529;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_39;
				IL_13B:
				num2 = (short)1421934592;
				short num5 = num2;
				num2 = (short)1991114754;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_17E:
				if (num3 >= romserialNum.Length)
				{
					num2 = (short)169345027;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					num2 = (short)306380806;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			return;
			IL_207:
			throw new global::RMIBtnWrapperLib.TMEXException(global::RMIBtnWrapperLib.TMEXException.g("⑾얀놂뒄\uda86ꦈ쾌搜杖練릘즚튜튞膠잢쪤슦\udaa8讪쎬삮얰鎲\ud8b4횶춸\ud8ba햼龾럀ꋂ꧄닆곈뻌믎뻐ꇒ냔돖律닚돜￞胠離釤迦蛨駪蓬问郰蟲鳴飶韸\udbfa鯼雾洀昂⬄✆䠈栊渌樎成怒㔔猖簘甚琜稞䔠ഢ", a_));
			IL_229:
			throw new global::RMIBtnWrapperLib.TMEXException(global::RMIBtnWrapperLib.TMEXException.g("⑾얀놂뒄\uda86ꦈ쾌搜杖練릘즚튜튞膠잢쪤슦\udaa8讪쎬삮얰鎲\ud8b4횶춸\ud8ba햼龾럀ꋂ꧄닆곈뻌믎뻐ꇒ냔돖律닚돜￞胠離釤迦蛨駪蓬问郰蟲鳴飶韸\udbfa鯼雾洀昂⬄✆䠈栊渌樎成怒㔔猖簘甚琜稞䔠ഢ", a_));
			IL_39:
			this.btnCommon.GetSessionHandle(ref this.hSession);
			this.btnCommon.DoTMSetup(this.hSession);
			romserialNum = this.btnCommon.GetROMSerialNum(this.hSession, false);
			array = new byte[8];
			this.btnCommon.GetMAPFFieldData(this.hSession, ref array, 6, 8);
			num2 = (short)100270084;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00013FF4 File Offset: 0x000121F4
		public void GetMaxFileSpace(string fileName, out short pMaxBytes)
		{
			int a_ = 7;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_187;
				case 1:
					goto IL_FE;
				case 2:
				{
					num2 = (short)862912512;
					short num3 = num2;
					num2 = (short)365831593;
					short num4 = num2;
					num2 = (short)773334441;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)594149377;
						if (num2 != 0)
						{
						}
						num2 = (short)845611008;
						if (num2 != 0)
						{
						}
						if (!this.bButtonOpened)
						{
							num2 = (short)1398145025;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)383057920;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_25;
			}
			IL_FE:
			IL_15A:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\ude84쎆뢈횊권삎ﮔ햖쾠莢쮤좦\udda8讪캬캮\uddb0\udfb2킴펶", a_));
			IL_187:
			try
			{
				this.btnCommon.GetSessionHandle(ref this.hSession);
				this.btnCommon.DoTMSetup(this.hSession);
				this.btnCommon.GetMaxFileSpaceAvailable(this.hSession, fileName, out pMaxBytes);
				return;
			}
			catch (global::RMIBtnWrapperLib.TMEXException ex)
			{
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("얆ﲈﾊ歷ﾐ뎒杖ﲘﲜ좠첢쮤螦첨\ud9aa\udfac삮쎰覲閴", a_) + ex.Message, ex);
			}
			catch (global::System.Exception ex2)
			{
				throw ex2;
			}
			goto IL_15A;
			IL_25:
			pMaxBytes = 0;
			num2 = (short)613285890;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000141AC File Offset: 0x000123AC
		public void GetFileSize(string fileName, ref short pFileSz)
		{
			int a_ = 8;
			short num = (short)1710489603;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				byte[] array;
				switch (num2)
				{
				case 0:
					goto IL_96;
				case 1:
					goto IL_96;
				case 2:
				{
					num = (short)588382208;
					short num3 = num;
					num = (short)322869259;
					short num4 = num;
					num = (short)690526219;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A9;
					default:
						num = (short)1121124352;
						if (num != 0)
						{
						}
						try
						{
							this.ReadFile(fileName, ref pFileSz, out array);
							return;
						}
						catch (global::System.Exception ex)
						{
							throw ex;
						}
						goto IL_1A9;
					}
					break;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				case 4:
					if (this.GetROMSerialNum()[0] == 12)
					{
						num = (short)1766129669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					pFileSz = 420;
					num = (short)1535705088;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_1A9;
				case 6:
					goto IL_91;
				}
				IL_4A:
				num = (short)1061879809;
				if (num != 0)
				{
				}
				if (!this.bButtonOpened)
				{
					num = (short)1815740422;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				array = null;
				num = (short)2004418564;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_96:
				num = (short)538050562;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A9:
				pFileSz = 7057;
				num = (short)138608641;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_91:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\udd85첇뮉톋꺍\udf8f\uda97쾟첡蒣좥잧\udea9貫춭톯\udeb1\ud8b3펵\udcb7", a_));
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00014398 File Offset: 0x00012598
		public static string GetFileName(byte[] fentry)
		{
			int a_ = 15;
			switch (0)
			{
			case 0:
				goto IL_3D;
			}
			int num;
			short num2;
			global::System.Text.StringBuilder stringBuilder;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)854917121;
					if (num2 != 0)
					{
					}
					goto IL_12E;
				case 1:
					num2 = (short)969605128;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					int num3 = 0;
					num2 = (short)747241479;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (fentry.Length == 40)
					{
						num2 = (short)115539970;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_165;
				case 4:
					goto IL_194;
				case 5:
					if (fentry != null)
					{
						num2 = (short)920911872;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_165;
				case 6:
				{
					num2 = (short)147980288;
					short num4 = num2;
					int num3;
					if (num3 >= 4)
					{
						num2 = (short)362545153;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					stringBuilder.Append((char)fentry[num3]);
					num3++;
					num2 = (short)1604780036;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					goto IL_194;
				case 8:
				{
					num2 = (short)2043112452;
					short num5 = num2;
					num2 = (short)666528772;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12E;
					default:
						goto IL_EC;
					}
					break;
				}
				}
				goto IL_3D;
				IL_12E:
				num2 = (short)1163198467;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_194:
				num2 = (short)1065418758;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_EC:
			num2 = (short)386662400;
			if (num2 != 0)
			{
			}
			return stringBuilder.ToString();
			IL_165:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("쒌璉ﺖﶘ뮚\udb9c춠욢薤잨\udfaa\udfac횮醰\udab2\udbb4톶횸즺킼\udebe뗀ꫂ꫄꧆", a_));
			IL_3D:
			stringBuilder = new global::System.Text.StringBuilder();
			num2 = (short)2119565317;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000145A4 File Offset: 0x000127A4
		internal static byte a(byte[] A_0)
		{
			int a_ = 6;
			short num = (short)1368260608;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_7C;
			}
			int num3;
			byte result;
			for (;;)
			{
				IL_3B:
				num = (short)1206190081;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
					return result;
				case 1:
					goto IL_147;
				case 2:
					num = (short)941621249;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					result = A_0[4];
					num = (short)326565888;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)1252000539;
					short num4 = num;
					num = (short)12124955;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_147;
					default:
						num = (short)1778843648;
						if (num != 0)
						{
						}
						if (A_0 != null)
						{
							num = (short)798031874;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FE;
					}
					break;
				}
				}
				goto IL_7C;
				IL_147:
				if (A_0.Length != 40)
				{
					break;
				}
				num = (short)803602435;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_FE:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("춃ﺇ늑튓ﾕﾙ벛\udb9d캟횡횣\udfa5袧쎩슫좭\udfaf삱\ud9b3ힵ첷펹펻킽", a_));
			IL_7C:
			result = byte.MaxValue;
			num = (short)577765380;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_3B;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0001471C File Offset: 0x0001291C
		// (set) Token: 0x0600005F RID: 95 RVA: 0x000147CC File Offset: 0x000129CC
		public short PortNumber
		{
			get
			{
				short num = (short)799785000;
				short num2 = num;
				num = (short)1409400872;
				switch (num2 == num)
				{
				}
				num = (short)82903040;
				short num3 = num;
				num = (short)474677249;
				if (num != 0)
				{
				}
				num = (short)2104426496;
				if (num != 0)
				{
				}
				return this.portNum;
			}
			set
			{
				short num = (short)1800690251;
				short num2 = num;
				num = (short)800938571;
				switch (num2 == num)
				{
				}
				num = (short)1164705792;
				short num3 = num;
				num = (short)657260545;
				if (num != 0)
				{
				}
				num = (short)1283719168;
				if (num != 0)
				{
				}
				this.portNum = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0001487C File Offset: 0x00012A7C
		// (set) Token: 0x06000061 RID: 97 RVA: 0x0001492C File Offset: 0x00012B2C
		public short PortType
		{
			get
			{
				short num = (short)1670327489;
				short num2 = num;
				num = (short)537799873;
				switch (num2 == num)
				{
				}
				num = (short)261881856;
				short num3 = num;
				num = (short)1487273985;
				if (num != 0)
				{
				}
				num = (short)2049441792;
				if (num != 0)
				{
				}
				return this.portType;
			}
			set
			{
				short num = (short)1905100106;
				short num2 = num;
				num = (short)1048806730;
				switch (num2 == num)
				{
				}
				num = (short)2063794176;
				short num3 = num;
				num = (short)1841430528;
				if (num != 0)
				{
				}
				num = (short)691863553;
				if (num != 0)
				{
				}
				this.portType = value;
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000149DC File Offset: 0x00012BDC
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1964310531;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						global::RMIBtnWrapperLib.TMEXAPI.TMEndSession(this.hSession);
						this.hSession = 0;
						num = (short)85327873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_A8;
					case 2:
					{
						num = (short)1222966823;
						short num3 = num;
						num = (short)1006960167;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15;
						default:
							goto IL_F5;
						}
						break;
					}
					case 3:
						goto IL_15;
					}
					goto IL_35;
					IL_15:
					switch (0)
					{
					case 0:
						IL_35:
						num = (short)509607937;
						if (num != 0)
						{
						}
						if (this.hSession <= 0)
						{
							goto IL_A8;
						}
						num = (short)804716544;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					continue;
					IL_A8:
					num = (short)90439682;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F5:
				num = (short)1447821312;
				if (num != 0)
				{
				}
			}
			finally
			{
				base.Finalize();
			}
			num = (short)254607360;
			short num4 = num;
		}

		// Token: 0x040000AC RID: 172
		protected int hSession;

		// Token: 0x040000AD RID: 173
		protected short portNum;

		// Token: 0x040000AE RID: 174
		protected short portType;

		// Token: 0x040000AF RID: 175
		protected short maxRetryCnt;

		// Token: 0x040000B0 RID: 176
		protected bool bButtonOpened;

		// Token: 0x040000B1 RID: 177
		protected bool bMotoBtn;

		// Token: 0x040000B2 RID: 178
		protected bool bOpenForInit;

		// Token: 0x040000B3 RID: 179
		protected global::RMIBtnWrapperLib.IBtnCommon btnCommon;
	}
}
