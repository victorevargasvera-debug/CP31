using System;
using System.Text;

namespace IBtnWrapperLib
{
	// Token: 0x02000011 RID: 17
	public abstract class IBtnWrapperBase : global::IBtnWrapperLib.IIBtnWrapper
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00010C50 File Offset: 0x0000EE50
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

		// Token: 0x06000049 RID: 73 RVA: 0x00010C94 File Offset: 0x0000EE94
		public void OpenNonMotoBtn(int options)
		{
			int a_ = 8;
			this.bMotoBtn = false;
			short num;
			try
			{
				num = (short)721536392;
				short num2 = num;
				num = (short)337167752;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_EC:
					num = (short)500039681;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)189399041;
					if (num != 0)
					{
					}
					num = (short)782696448;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_9F;
					}
					break;
				}
				for (;;)
				{
					IL_8D:
					switch (num3)
					{
					case 0:
						goto IL_D6;
					case 1:
						goto IL_100;
					case 2:
						if (this.a())
						{
							num = (short)1127546880;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EC;
					}
					goto IL_9F;
				}
				IL_D6:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ཀⱂ⭄橆ш⑊㥌⁎⍐㱒㥔㙖祘㉚὜⩞ᕠᝢ੤०䥨ࡪɬŮհቲᱴ᥶੸孺ࡼᅾ力떔놞", a_));
				IL_100:
				goto IL_103;
				IL_9F:
				this.OpenButton(options);
				num = (short)1204224002;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_8D;
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
			IL_103:
			num = (short)948633600;
			short num4 = num;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00010DE0 File Offset: 0x0000EFE0
		public void CreateFile(string fileName, out short pMaxBytes)
		{
			int a_ = 5;
			short num = (short)564002816;
			switch (num)
			{
			default:
			{
				num = (short)1314783234;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					short num3;
					switch (num2)
					{
					case 0:
						goto IL_7A;
					case 1:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_C6;
							}
							byte[] array;
							short num4;
							for (;;)
							{
								IL_AF:
								switch (num2)
								{
								case 0:
									goto IL_174;
								case 1:
									this.btnCommon.CreateFile(this.hSession, out num3, array, out num4);
									pMaxBytes = num4;
									num = (short)2041905152;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									num = (short)266072798;
									short num5 = num;
									num = (short)1447490270;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_174;
									default:
										goto IL_1C1;
									}
									break;
								}
								case 3:
									if (array != null)
									{
										num = (short)500695041;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_160;
								}
								goto IL_C6;
								IL_174:
								num = (short)2004811778;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_160:
							throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("眽⸿㑁╃⩅ⅇ⹉汋⽍≏㕑⅓㭕㵗㑙⡛灝䁟②ൣ੥൧䩩⥫mѯq൳噵ᅷᑹ᩻ᅽ꺍望벛ﲝ얟芡쪣펥쒧용", a_));
							IL_1C1:
							num = (short)346685440;
							if (num != 0)
							{
							}
							goto IL_2AF;
							IL_C6:
							this.btnCommon.GetSessionHandle(ref this.hSession);
							this.btnCommon.DoTMSetup(this.hSession);
							array = null;
							array = this.btnCommon.LoadFileName(fileName);
							num4 = 1;
							num = (short)265027587;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_AF;
						}
						catch (global::IBtnWrapperLib.TMEXException ex)
						{
							throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("圽ȿ㝁ぃ㉅❇⑉汋⅍⁏㝑♓㝕ⱗ㍙㍛そ䁟ݡᙣᑥݧᡩ噫乭", a_) + ex.Message, ex);
						}
						catch (global::System.Exception ex2)
						{
							throw ex2;
						}
						finally
						{
							num = (short)304676866;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									this.btnCommon.CloseFile(this.hSession, ref num3);
									num3 = -1;
									num = (short)1337327617;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_276;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_22F;
									}
									continue;
								}
								IL_22F:
								if (num3 <= -1)
								{
									break;
								}
								num = (short)670826496;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_276:;
						}
						goto IL_279;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					}
					IL_5A:
					if (!this.bButtonOpened)
					{
						num = (short)2040725504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_279:
					num3 = -1;
					pMaxBytes = 0;
					num = (short)479592449;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_7A:
				num = (short)1825964033;
				if (num != 0)
				{
				}
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("攽п獁᥃晅݇㩉⥋⁍቏❑⁓≕㝗㑙籛そཟᙡ䑣ե१٩k୭ᑯ", a_));
				IL_2AF:
				num = (short)865140736;
				short num6 = num;
				return;
			}
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00011114 File Offset: 0x0000F314
		public void WriteFile(string fileName, short numDataBytes, byte[] pFileData)
		{
			int a_ = 12;
			short num = (short)1098055680;
			switch (num)
			{
			default:
			{
				num = (short)599457794;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1A4;
					case 1:
						num = (short)1097596937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_82;
						}
						continue;
					case 3:
					{
						num = (short)653328384;
						short num3 = num;
						short num4 = 7057;
						num = (short)1457258500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_1A4;
					case 5:
						if (pFileData != null)
						{
							num = (short)971309062;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_190;
					case 6:
						num = (short)1521156097;
						if (num != 0)
						{
						}
						goto IL_4A9;
					case 7:
						if (numDataBytes >= 1)
						{
							num = (short)1671561217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_190;
					case 8:
						goto IL_F8;
					case 9:
					{
						short num4;
						if (numDataBytes > num4)
						{
							num = (short)304676872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						short hFile = -1;
						num = (short)430112780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						byte[] romserialNum = this.GetROMSerialNum();
						short num4 = 0;
						if (romserialNum[0] == 12)
						{
							num = (short)1442447363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = 420;
						num = (short)1030356992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_A3;
					case 12:
						try
						{
							num = (short)1353525257;
							short num5 = num;
							num = (short)2040932361;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1030029312;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_299;
								}
								break;
							}
							byte[] array;
							for (;;)
							{
								IL_26E:
								switch (num2)
								{
								case 0:
									if (array != null)
									{
										num = (short)1156120584;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3E9;
								case 1:
									num = (short)682426375;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_3A2;
								case 3:
									num = (short)1144193030;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (array[4] == 0)
									{
										num = (short)369557507;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_458;
								case 5:
								{
									try
									{
										this.btnCommon.DeleteFile(this.hSession, array);
										goto IL_3FD;
									}
									catch (global::IBtnWrapperLib.TMEXException ex)
									{
										if (ex.ErrorCode != -6)
										{
											throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("D㕆㭈⑊㽌潎㕐㙒㥔㉖ⵘ㉚㍜㡞䅠ɢ䕤Ŧhݪ࡬啮兰", a_) + ex.Message);
										}
										goto IL_3FD;
									}
									goto IL_3E9;
									IL_3FD:
									short num6 = 0;
									short hFile;
									this.btnCommon.CreateFile(this.hSession, out hFile, array, out num6);
									this.btnCommon.WriteFile(this.hSession, hFile, pFileData, numDataBytes);
									this.btnCommon.CloseFile(this.hSession, ref hFile);
									num = (short)2045575169;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									string fileName2;
									if (fileName2 == global::IBtnWrapperLib.TMEXException.g("ࡄن᥈ൊ", a_))
									{
										num = (short)905576450;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_458;
								}
								case 7:
									goto IL_48E;
								case 8:
								{
									string fileName2 = global::IBtnWrapperLib.IBtnWrapperBase.GetFileName(array);
									num = (short)1664811012;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_299;
								IL_458:
								num = (short)1683030021;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3A2:
							throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("Ṅ͆筈祊၌潎ၐげ㙔㉖⩘⡚絜⭞๠䍢⡤♦㥨⵪䍬彮兰ᩲٴ坶୸Ṻ๼୾ꎌ", a_));
							IL_3E9:
							throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ౄ⥆㽈⩊⅌♎㕐獒ፔ㹖㕘㹚絜ᩞའᝢᝤṦ䥨≪ͬ८ṰŲᡴᙶ൸ቺቼᅾ", a_));
							IL_48E:
							return;
							IL_299:
							this.btnCommon.GetSessionHandle(ref this.hSession);
							this.btnCommon.DoTMSetup(this.hSession);
							array = null;
							array = this.btnCommon.LoadFileName(fileName);
							num = (short)647036928;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_26E;
						}
						catch (global::IBtnWrapperLib.TMEXException innerException)
						{
							throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ⱄՆ㱈㽊㥌⁎㽐獒ɔ╖じ⽚㡜罞①ᅢᝤࡦ᭨䭪䁬佮ɰᙲၴ坶へᕺ፼᩾욂ﶄﮊ歷ﺐﶒ떔붜ﮞ쒠힢쒤캦얨\ud8aa", a_), innerException);
						}
						catch (global::System.Exception ex2)
						{
							throw ex2;
						}
						goto IL_4A9;
					}
					IL_82:
					if (!this.bButtonOpened)
					{
						num = (short)53411851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)478281738;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A4:
					num = (short)508559365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A9:
					num = (short)1607925767;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A3:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("Ṅ͆硈ᙊ浌N⅐㙒㭔ᕖⱘ⽚⥜ぞའ䍢୤ࡦᵨ䭪๬๮ᵰὲၴ፶", a_));
				IL_F8:
				IL_190:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("Ṅ͆筈ᙊ浌َ㽐╒㑔㭖じ㽚絜㹞፠Ѣ䕤ᝦࡨᡪṬ੮ᕰ卲Ŵᡶ奸ⱺོᙾ쎄ꎌ", a_));
			}
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00011678 File Offset: 0x0000F878
		public void ReadFile(string fileName, ref short pNumBytes, out byte[] pFileData)
		{
			int a_ = 15;
			short num = (short)1184759808;
			short num2 = num;
			num = (short)262275072;
			switch (num)
			{
			default:
			{
				num = (short)1760362497;
				if (num != 0)
				{
				}
				num = (short)841875456;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					short num5;
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_D4;
						}
						continue;
					case 1:
					{
						short num4;
						pNumBytes = num4;
						num = (short)2022440963;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_3E3;
					case 3:
						goto IL_431;
					case 4:
						goto IL_3DE;
					case 5:
					{
						short num4 = 7057;
						num = (short)1527316489;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						byte[] romserialNum = this.GetROMSerialNum();
						short num4 = 0;
						if (romserialNum[0] == 12)
						{
							num = (short)1967587333;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = 420;
						num = (short)953942018;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (pNumBytes == 0)
						{
							num = (short)1920598017;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)72679437;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_18F;
							}
							byte[] array;
							for (;;)
							{
								IL_178:
								switch (num3)
								{
								case 0:
									goto IL_259;
								case 1:
									this.btnCommon.OpenFile(this.hSession, out num5, array, false);
									this.btnCommon.ReadFile(this.hSession, num5, ref pNumBytes, out pFileData);
									this.btnCommon.CloseFile(this.hSession, ref num5);
									num = (short)172294144;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									num = (short)1894520223;
									short num6 = num;
									num = (short)744035743;
									switch ((num6 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_259;
									default:
										goto IL_2A7;
									}
									break;
								}
								case 3:
									if (array != null)
									{
										num = (short)1437401089;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_245;
								}
								goto IL_18F;
								IL_259:
								num = (short)1415512066;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_245:
							throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("Ň⑉㩋⽍㱏㭑こ癕ṗ㍙せ㭝䁟❡੣ብᩧ፩䱫❭ṯᑱ᭳ѵᕷ᭹ࡻ᝽", a_));
							IL_2A7:
							num = (short)1183449088;
							if (num != 0)
							{
							}
							return;
							IL_18F:
							this.btnCommon.GetSessionHandle(ref this.hSession);
							this.btnCommon.DoTMSetup(this.hSession);
							array = this.btnCommon.LoadFileName(fileName);
							num = (short)1386872835;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_178;
						}
						catch (global::IBtnWrapperLib.TMEXException ex)
						{
							throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ⅇࡉ㥋㩍⑏㵑㩓癕੗㽙㵛㩝䁟❡ᙣᑥݧᡩ噫乭", a_) + ex.Message, ex);
						}
						catch (global::System.Exception ex2)
						{
							throw ex2;
						}
						finally
						{
							num = (short)134479874;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									this.btnCommon.CloseFile(this.hSession, ref num5);
									num = (short)2009006081;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_35A;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_315;
									}
									continue;
								}
								IL_315:
								if (num5 <= -1)
								{
									break;
								}
								num = (short)341180416;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_35A:;
						}
						goto IL_35D;
					case 9:
						goto IL_3E3;
					case 10:
						num = (short)940376075;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						short num4;
						if (pNumBytes > num4)
						{
							num = (short)788004868;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_431;
					}
					case 12:
						goto IL_F4;
					case 13:
						if (pNumBytes >= 1)
						{
							num = (short)95813642;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F9;
					}
					IL_D4:
					if (!this.bButtonOpened)
					{
						num = (short)2022244364;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_35D:
					pFileData = null;
					num = (short)663552006;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E3:
					num = (short)1719074823;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_431:
					num5 = -1;
					num = (short)1084030984;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_F4:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ፇ้絋ፍ灏ᵑ⑓㍕㙗ᡙ⥛⩝ᑟൡ੣䙥٧թᡫ乭፯፱ᡳ᩵ᵷṹ", a_));
				IL_F9:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ፇ้繋ፍ灏Qㅓ㝕㱗᱙㕛㉝՟䉡ɣݥŧ٩५੭䩯剱㵳ᡵ๷᭹ၻ᝽ꊁ慎뚕ﮙ얟芡춣좥袧隩\udcab얯\udfb1쾵첷\udfb9쾻肽", a_));
				IL_3DE:
				goto IL_F9;
			}
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00011B64 File Offset: 0x0000FD64
		public bool WriteFileAtPage(string fileName, int numDataBytes, short nStartPage, byte[] pFileData)
		{
			int a_ = 7;
			short num = (short)728629248;
			short num2 = num;
			num = (short)611319808;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				num = (short)1028981620;
				short num4 = num;
				num = (short)1093403508;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1BC:
					if (!this.bButtonOpened)
					{
						num = (short)71958538;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)383582213;
						num3 = (int)((global::System.IntPtr)num);
					}
					break;
				default:
					num = (short)1519190016;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_E8;
					}
					break;
				}
				bool result;
				for (;;)
				{
					IL_A5:
					short num5;
					switch (num3)
					{
					case 0:
						if (numDataBytes <= (int)num5)
						{
							num = (short)1518272526;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_156;
					case 1:
					{
						num = (short)1549139969;
						if (num != 0)
						{
						}
						byte[] romserialNum = this.GetROMSerialNum();
						num5 = 0;
						if (romserialNum[0] == 12)
						{
							num = (short)1447231501;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_461;
					}
					case 2:
						num = (short)85327876;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_1A4;
					case 4:
						if (numDataBytes >= 1)
						{
							num = (short)725286923;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_156;
					case 5:
						if (pFileData != null)
						{
							num = (short)891224066;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_156;
					case 6:
					{
						if (fileName == "")
						{
							num = (short)1736638476;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						short num6 = -1;
						num = (short)862453769;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_1A4;
					case 8:
						goto IL_1BC;
					case 9:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_21E;
							}
							for (;;)
							{
								IL_1EF:
								switch (num3)
								{
								case 0:
									if (this.hSession != 0)
									{
										num = (short)296943617;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3A6;
								case 1:
									num = (short)675807235;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									byte[] array = this.btnCommon.LoadFileName(fileName);
									num = (short)1154613253;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									if (this.btnCommon.DoTMSetup(this.hSession))
									{
										num = (short)1160249346;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3A6;
								case 4:
									goto IL_3A6;
								case 5:
								{
									byte[] array;
									if (array != null)
									{
										num = (short)1731133449;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_360;
								}
								case 6:
									goto IL_3BE;
								case 7:
								{
									byte[] array;
									string b;
									if (new global::System.Text.ASCIIEncoding().GetString(array) == b)
									{
										num = (short)733609992;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									result = this.btnCommon.WriteFile(this.hSession, array, pFileData, numDataBytes, nStartPage);
									num = (short)1317011460;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_34A;
								case 9:
								{
									string b = global::IBtnWrapperLib.TMEXException.g("ി́ᑃE硇", a_);
									num = (short)1594032135;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_21E;
								IL_3A6:
								num = (short)1243283462;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_34A:
							throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ᬿف癃瑅ᕇ橉ോⵍ㍏㝑❓╕硗⹙㍛繝ⵟ⍡㑣⁥䙧婩䱫ݭͯ剱ٳ፵୷๹๻᝽ꚇ", a_));
							IL_360:
							throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("िⱁ㉃❅⑇⍉⡋湍ᙏ㭑㡓㍕硗Ὑ㉛⩝቟᭡䑣⽥٧౩ͫᱭᵯ፱sή᝷ᑹ", a_));
							IL_3BE:
							return result;
							IL_21E:
							this.btnCommon.GetSessionHandle(ref this.hSession);
							num = (short)1370030080;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_1EF;
						}
						catch (global::IBtnWrapperLib.TMEXException ex)
						{
							throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("⤿Aㅃ㉅㱇╉≋湍ɏ㝑㕓㉕硗Ὑ⹛ⱝཟၡ幣䙥", a_) + ex.Message, ex);
						}
						catch (global::System.Exception ex2)
						{
							throw ex2;
						}
						finally
						{
							num = (short)469434368;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								short num6;
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_41A;
									}
									continue;
								case 1:
									goto IL_45E;
								case 2:
									this.btnCommon.CloseFile(this.hSession, ref num6);
									num = (short)710606849;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_41A:
								if (num6 <= -1)
								{
									break;
								}
								num = (short)1779236866;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_45E:;
						}
						goto IL_461;
					case 10:
						goto IL_1E0;
					case 11:
						num = (short)1204879360;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_4C2;
					case 13:
						num5 = 7057;
						num = (short)1494614019;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						num = (short)921436166;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E8;
					IL_1A4:
					num = (short)1731395592;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_461:
					num5 = 420;
					num = (short)1897267207;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_156:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ᬿف癃ᭅ桇ᡉ⥋⽍㑏ᑑ㵓㩕㵗穙㩛㽝य़๡ţɥ剧䩩╫mٯ፱ᡳήᱷ婹౻ώﲇﺋ꺍ﶗ몙肟麡풣\udda7잩힭쒯ힱ잳袵隷", a_));
				IL_1E0:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ᬿف畃ᭅ桇Չ㱋⭍㹏ၑ⅓≕ⱗ㕙㉛繝๟ൡၣ䙥୧୩kɭᕯᙱ", a_));
				IL_4C2:
				goto IL_156;
				IL_E8:
				result = false;
				num = (short)1705967617;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_A5;
			}
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00012158 File Offset: 0x00010358
		public int GetWCC(uint pageNo)
		{
			int a_ = 2;
			short num;
			for (;;)
			{
				IL_09:
				switch (0)
				{
				case 0:
					goto IL_6F;
				}
				int num3;
				int result;
				for (;;)
				{
					IL_13:
					num = (short)1193512088;
					short num2 = num;
					num = (short)376671384;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_09;
					default:
						num = (short)1468071936;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							if (this.btnCommon != null)
							{
								num = (short)858456066;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D2;
						case 1:
							return result;
						case 2:
							this.btnCommon.GetSessionHandle(ref this.hSession);
							this.btnCommon.DoTMSetup(this.hSession);
							result = this.btnCommon.a(this.hSession, pageNo);
							num = (short)1373241345;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F;
					}
				}
				IL_6F:
				num = (short)1203765248;
				short num4 = num;
				result = -1;
				num = (short)1313865728;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_13;
			}
			IL_D2:
			num = (short)1231880193;
			if (num != 0)
			{
			}
			throw new global::IBtnWrapperLib.TMEXException(global::IBtnWrapperLib.TMEXException.g("刺缼䨾㕀㝂⩄⥆楈᱊㽌⹎⅐⍒ご╖祘ᑚ㽜㕞Ѡbᅤ䝦hᡪ䵬ŮṰݲ啴Ṷ᝸ቺॼᙾﶆ권꺎", a_));
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000122C4 File Offset: 0x000104C4
		public void ReadMemoryData(byte addrLSB, byte addrMSB, short numBytesRequested, byte[] data)
		{
			int a_ = 6;
			short num = (short)705259347;
			short num2 = num;
			num = (short)28010323;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_91:
				switch (0)
				{
				case 0:
					goto IL_AD;
				}
				break;
			default:
			{
				num = (short)1805582336;
				short num3 = num;
				num = (short)232587264;
				if (num != 0)
				{
				}
				num = (short)168034304;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			}
			IL_9B:
			switch (num4)
			{
			case 0:
				goto IL_91;
			case 1:
				try
				{
					switch (0)
					{
					case 0:
						goto IL_11F;
					}
					for (;;)
					{
						IL_101:
						switch (num4)
						{
						case 0:
							if (this.hSession != 0)
							{
								num = (short)619577345;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1DA;
						case 1:
							num = (short)73334789;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_1DA;
						case 3:
							goto IL_1F1;
						case 4:
							this.btnCommon.ReadMemoryData(this.hSession, addrLSB, addrMSB, numBytesRequested, data);
							num = (short)214171650;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (this.btnCommon.DoTMSetup(this.hSession))
							{
								num = (short)72351748;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1DA;
						}
						goto IL_11F;
						IL_1DA:
						num = (short)491847683;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1F1:
					return;
					IL_11F:
					this.btnCommon.GetSessionHandle(ref this.hSession);
					num = (short)977993728;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_101;
				}
				catch (global::IBtnWrapperLib.TMEXException ex)
				{
					throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("嘾̀㙂ㅄ㍆♈╊浌ᵎ㑐㉒ㅔ睖᱘⥚⽜ぞ፠奢䕤", a_) + ex.Message, ex);
				}
				catch (global::System.Exception ex2)
				{
					throw ex2;
				}
				goto IL_215;
			case 2:
				num = (short)618266625;
				if (num != 0)
				{
				}
				goto IL_215;
			}
			goto IL_AD;
			IL_215:
			throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("搾Հ牂ᡄ杆و㭊⡌ⅎፐ♒⅔⍖㙘㕚絜ㅞ๠ᝢ䕤ѦࡨݪŬ੮ᕰ", a_));
			IL_AD:
			if (!this.bButtonOpened)
			{
				num = (short)762642434;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_9B;
			}
			num = (short)247988225;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_9B;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00012538 File Offset: 0x00010738
		public void ReadFileAtPage(string fileName, ref short pNumBytes, ref short nStartPage, out byte[] pFileData)
		{
			int a_ = 12;
			short num = (short)1977024512;
			short num2 = num;
			num = (short)1982005248;
			switch (num)
			{
			default:
			{
				num = (short)1511784453;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					short num6;
					switch (num3)
					{
					case 0:
					{
						byte[] romserialNum = this.GetROMSerialNum();
						short num4 = 0;
						if (romserialNum[0] == 12)
						{
							num = (short)897908743;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = 420;
						num = (short)256835587;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)1089601550;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_D8;
					case 3:
						goto IL_50B;
					case 4:
						if (pNumBytes >= 1)
						{
							num = (short)363593729;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DD;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_B7;
						}
						continue;
					case 6:
						goto IL_50B;
					case 7:
					{
						short num4 = 7057;
						num = (short)647823366;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (pNumBytes == 0)
						{
							num = (short)118816780;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1053229060;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (fileName == "")
						{
							num = (short)487587851;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_472;
					case 10:
						num = (short)450756617;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_3E1;
					case 12:
					{
						short num4;
						pNumBytes = num4;
						num = (short)1382137726;
						short num5 = num;
						num = (short)645185406;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)1530068992;
							if (num != 0)
							{
							}
							num = (short)793575439;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 13:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_17F;
							}
							for (;;)
							{
								IL_158:
								switch (num3)
								{
								case 0:
									if (this.hSession != 0)
									{
										num = (short)1182072833;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_29D;
								case 1:
									num = (short)2023817219;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_29D;
								case 3:
									if (this.btnCommon.DoTMSetup(this.hSession))
									{
										num = (short)858128388;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_29D;
								case 4:
								{
									byte[] array = this.btnCommon.LoadFileName(fileName);
									num = (short)410189831;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_2B5;
								case 6:
								{
									byte[] array;
									this.btnCommon.ReadFile(this.hSession, array, ref nStartPage, ref pNumBytes, out pFileData);
									num = (short)535822338;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									byte[] array;
									if (array != null)
									{
										num = (short)382271494;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_289;
								}
								}
								goto IL_17F;
								IL_29D:
								num = (short)747765765;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_289:
							throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ౄ⥆㽈⩊⅌♎㕐獒ፔ㹖㕘㹚絜ᩞའᝢᝤṦ䥨≪ͬ८ṰŲᡴᙶ൸ቺቼᅾ", a_));
							IL_2B5:
							return;
							IL_17F:
							this.btnCommon.GetSessionHandle(ref this.hSession);
							num = (short)367656960;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_158;
						}
						catch (global::IBtnWrapperLib.TMEXException ex)
						{
							throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ⱄՆ㱈㽊㥌⁎㽐獒ݔ㉖㡘㽚絜ᩞ፠ᅢ੤ᕦ卨䭪", a_) + ex.Message, ex);
						}
						catch (global::System.Exception ex2)
						{
							throw ex2;
						}
						finally
						{
							num = (short)344784896;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_30E;
									}
									continue;
								case 1:
									goto IL_352;
								case 2:
									this.btnCommon.CloseFile(this.hSession, ref num6);
									num = (short)2119041025;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_30E:
								if (num6 <= -1)
								{
									break;
								}
								num = (short)690028546;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_352:;
						}
						goto IL_355;
					case 14:
					{
						short num4;
						if (pNumBytes <= num4)
						{
							num = (short)751632394;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DD;
					}
					case 15:
						goto IL_472;
					}
					IL_B7:
					if (!this.bButtonOpened)
					{
						num = (short)2114519042;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_355:
					pFileData = null;
					num = (short)851050496;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_472:
					num = (short)814743553;
					if (num != 0)
					{
					}
					num6 = -1;
					num = (short)443613197;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_50B:
					num = (short)749469704;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_D8:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("Ṅ͆硈ᙊ浌N⅐㙒㭔ᕖⱘ⽚⥜ぞའ䍢୤ࡦᵨ䭪๬๮ᵰὲၴ፶", a_));
				IL_DD:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("Ṅ͆筈ᙊ浌ᵎ㑐㉒ㅔᅖじ㝚㡜罞ݠɢ౤୦౨ཪ坬佮㡰ᵲʹᙶᕸቺ᥼彾歷뎒뾞좠춢薤鮦\ud9a8\ud8ac슮쪲솴튶쪸薺鎼", a_));
				IL_3E1:
				goto IL_DD;
			}
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00012ADC File Offset: 0x00010CDC
		public bool DoesFileExist(string fileName)
		{
			int a_ = 17;
			short num = (short)104529920;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)428499498;
				short num3 = num;
				num = (short)965501482;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_DD;
				default:
				{
					num = (short)739508225;
					if (num != 0)
					{
					}
					num = (short)957612032;
					short num4 = num;
					num = (short)384696320;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_DD;
					}
					break;
				}
				}
				for (;;)
				{
					IL_CA:
					switch (num2)
					{
					case 0:
						if (!this.bButtonOpened)
						{
							num = (short)1201799170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1475018753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_274;
					case 2:
						goto IL_116;
					}
					goto IL_DD;
				}
				IL_116:
				IL_247:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ᅉࡋ罍൏牑᭓♕㵗㑙ṛ⭝ᑟᙡୣࡥ䡧ѩͫᩭ偯ᅱᕳ᩵ᑷό᡻", a_));
				IL_274:
				bool result;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_140;
					}
					short num5;
					for (;;)
					{
						IL_125:
						switch (num2)
						{
						case 0:
							if (num5 > -1)
							{
								num = (short)540803073;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = false;
							num = (short)1875312644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							result = true;
							this.btnCommon.CloseFile(this.hSession, ref num5);
							num = (short)949288963;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_223;
						case 3:
							goto IL_20B;
						case 4:
							goto IL_20B;
						}
						goto IL_140;
						IL_20B:
						num = (short)502267906;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_223:
					return result;
					IL_140:
					num5 = -1;
					this.btnCommon.GetSessionHandle(ref this.hSession);
					this.btnCommon.DoTMSetup(this.hSession);
					byte[] fentry = this.btnCommon.LoadFileName(fileName);
					this.btnCommon.OpenFile(this.hSession, out num5, fentry, true);
					num = (short)1777467392;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_125;
				}
				catch (global::IBtnWrapperLib.TMEXException ex)
				{
					throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("⍉๋㭍⑏♑㭓㡕硗㕙ⱛ㭝቟͡ၣཥݧѩ䱫୭ɯq᭳ѵ䉷婹", a_) + ex.Message, ex);
				}
				catch (global::System.Exception ex2)
				{
					throw ex2;
				}
				goto IL_247;
				IL_DD:
				result = false;
				num = (short)1159725056;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_CA;
			}
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00012D98 File Offset: 0x00010F98
		public void InitButton(byte[] version, byte[] communityCode, string userid, string password, string authCode, short alarmOffset, char offsetFormat, char expirationAction, bool bWPTimer)
		{
			int a_ = 19;
			short num;
			for (;;)
			{
				num = (short)78512128;
				switch (num)
				{
				default:
				{
					num = (short)342345833;
					short num2 = num;
					num = (short)628803689;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_82;
					}
					goto Block_1;
				}
				}
			}
			Block_1:
			num = (short)1591738368;
			short num3 = num;
			IL_82:
			num = (short)943259648;
			if (num != 0)
			{
			}
			num = (short)216006656;
			int num4 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num4)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_CC;
					}
					continue;
				case 1:
					goto IL_56F;
				case 2:
					goto IL_EC;
				}
				IL_CC:
				if (!this.bButtonOpened)
				{
					num = (short)1280573442;
					num4 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1605566465;
					num4 = (int)((global::System.IntPtr)num);
				}
			}
			IL_EC:
			IL_542:
			throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ᝋ੍慏ད瑓ᥕ⡗㽙㉛ᱝᕟᙡၣ॥٧䩩ɫŭѯ剱ᝳ᝵ᑷᙹ᥻᩽", a_));
			IL_56F:
			try
			{
				switch (0)
				{
				case 0:
					goto IL_15E;
				}
				bool flag;
				for (;;)
				{
					IL_FB:
					switch (num4)
					{
					case 0:
						this.bMotoBtn = false;
						flag = true;
						num = (short)833880072;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)289538068;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_39B;
					case 3:
						if (this.bMotoBtn)
						{
							num = (short)1798963206;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D2;
					case 4:
						if (authCode.CompareTo(global::IBtnWrapperLib.TMEXException.g("㝋్ᅏᑑᙓᕕ楗᭙湛ᱝ⍟兡╣剥੧౩५坭㉯ぱㅳ䝵䱷䵹㹻乽앿놁낃랅즇뮉뒋뺍流蓮궛ﾝ銟躡钣\udea5쪧즩龫쾭肯쪱肳풵\udeb7\udfb9잻躽뢿﯁ꛃ", a_)) == 0)
						{
							num = (short)730398732;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1185546259;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						this.btnCommon.SetTimer(this.hSession, alarmOffset, global::IBtnWrapperLib.TimerType.realTime, offsetFormat, expirationAction, bWPTimer);
						num = (short)1535180809;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						string authCode2 = global::IBtnWrapperLib.TMEXException.g("㝋്慏ၑᕓၕᩗ᭙汛♝ɟѡ噣⑥⭧奩⵫婭ቯᅱ䝳᝵䡷ɹ䡻ᱽ붃쒅쪇좉벋쮍ꎑ꒕뒗ﾙ꺝\ud89f醡那鞥鮩钫膯蚱莳蚵삷\ud8b9\uddbb\ud8bdꊿ﯁ꛃ", a_);
						this.btnCommon.WriteMapfFile(this.hSession, version, communityCode, userid, password, authCode2);
						num = (short)455409685;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						bool flag2 = this.btnCommon.ValidateBtnInitUserArgs(version, communityCode, userid, password);
						num = (short)828309519;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_39B;
					case 9:
						goto IL_510;
					case 10:
						if (this.GetROMSerialNum()[0] == 4)
						{
							num = (short)1044054021;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_510;
					case 11:
						goto IL_4A7;
					case 12:
						num = (short)862191617;
						if (num != 0)
						{
						}
						this.bMotoBtn = true;
						flag = true;
						num = (short)1925251074;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (this.btnCommon.ValidateBtnInitTimerArgs(offsetFormat, expirationAction))
						{
							num = (short)2005073921;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A7;
					case 14:
						this.btnCommon.GetSessionHandle(ref this.hSession);
						this.btnCommon.DoTMSetup(this.hSession);
						this.btnCommon.FormatButton(this.hSession);
						num = (short)1865285635;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_4A7;
					case 16:
						goto IL_529;
					case 17:
					{
						bool flag2;
						if (flag2)
						{
							num = (short)819986446;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_510;
					}
					case 18:
					{
						bool flag2 = false;
						num = (short)344129549;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						if (authCode.CompareTo(global::IBtnWrapperLib.TMEXException.g("㝋硍቏ᅑᙓ敕橗歙歛楝╟剡坣剥⩧奩⽫Ɑ㑯㍱䑳㉵㱷㭹䕻㽽뙿잁벃쎅벇붉몋뺍톑ꞓ힕겗瀞ﮝ醟躡钣\udea5鲧좩쪫쮭膯쪱ힵ辷\ud9b9잻躽뢿胁ﷃ", a_)) == 0)
						{
							num = (short)1207697408;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39B;
					case 20:
					{
						if (this.bMotoBtn)
						{
							num = (short)1783562247;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool flag2 = true;
						num = (short)1042743307;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						goto IL_2D2;
					case 22:
						if (flag)
						{
							num = (short)1809252370;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_317;
					}
					goto IL_15E;
					IL_2D2:
					num = (short)1313144842;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_39B:
					num = (short)1098711062;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A7:
					num = (short)1237123089;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_510:
					num = (short)413663248;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_317:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ɋ⅍⑏牑㕓⍕ⱗ㉙㍛ⱝय़ᡡţɥ䙧", a_));
				IL_529:
				return;
				IL_15E:
				this.bOpenForInit = false;
				flag = false;
				num = (short)281280516;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_FB;
			}
			catch (global::IBtnWrapperLib.TMEXException innerException)
			{
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("╋్╏♑⁓㥕㙗穙ᕛそय़ᙡൣݥѧͩᙫ཭ѯ᭱᭳ᡵ塷㽹๻౽ꒃꮅꢇ黎낏\udb91望ﶗ\ud99b쎟잡풣튥솧얩슫躭횯\uddb1욳隵\udcb7\udfb9좻\udfbdꦿ껁럃", a_), innerException);
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
			goto IL_542;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00013350 File Offset: 0x00011550
		internal bool a()
		{
			int a_ = 2;
			short num = (short)758251520;
			short num2 = num;
			num = (short)1925507311;
			short num3 = num;
			num = (short)1330178287;
			bool result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1864433665;
				if (num != 0)
				{
				}
				num = (short)349765632;
				if (num != 0)
				{
				}
				result = false;
				try
				{
					string fileName = global::IBtnWrapperLib.TMEXException.g("瘺簼漾݀浂畄", a_);
					result = this.DoesFileExist(fileName);
				}
				catch (global::System.Exception ex)
				{
					throw ex;
				}
				break;
			}
			return result;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00013430 File Offset: 0x00011630
		public void CloseButton()
		{
			short num = (short)572588032;
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
					num = (short)619511812;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return;
				case 3:
					num = (short)1200357377;
					if (num != 0)
					{
					}
					this.btnCommon.EndSession(this.hSession);
					num = (short)1534525445;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (this.hSession > 0)
					{
						num = (short)1669398531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D6;
				case 5:
					goto IL_D6;
				}
				IL_3D:
				if (this.btnCommon == null)
				{
					break;
				}
				num = (short)1475143531;
				short num3 = num;
				num = (short)1057482603;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1754136576;
					if (num != 0)
					{
					}
					num = (short)2094661632;
					short num4 = num;
					num = (short)1911816193;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_D6:
				this.btnCommon = null;
				this.bButtonOpened = false;
				this.bOpenForInit = false;
				this.portNum = 1;
				num = (short)2068512770;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000135DC File Offset: 0x000117DC
		public void DeleteFile(string fileName)
		{
			int a_ = 18;
			short num = (short)426180608;
			short num2 = num;
			num = (short)577387371;
			short num3 = num;
			num = (short)1800354667;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_238:
				num = (short)1905262594;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1371471872;
				if (num != 0)
				{
				}
				num = (short)135987200;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_AD;
					}
					continue;
				case 1:
					goto IL_CD;
				case 2:
					goto IL_252;
				}
				IL_AD:
				if (this.bButtonOpened)
				{
					goto IL_238;
				}
				num = (short)130613249;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_CD:
			IL_1FD:
			num = (short)513867777;
			if (num != 0)
			{
			}
			throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("၊ौ繎౐獒ᩔ❖㱘㕚὜⩞ᕠᝢ੤०䥨ժɬ᭮兰ၲᑴ᭶ᕸṺ᥼", a_));
			IL_252:
			try
			{
				switch (0)
				{
				case 0:
					goto IL_F6;
				}
				byte[] array;
				for (;;)
				{
					IL_DC:
					switch (num4)
					{
					case 0:
						num = (short)2014511107;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (global::IBtnWrapperLib.IBtnWrapperBase.a(array) == 0)
						{
							num = (short)1712652288;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BB;
					case 2:
						goto IL_1B9;
					case 3:
						if (global::IBtnWrapperLib.IBtnWrapperBase.GetFileName(array) == global::IBtnWrapperLib.TMEXException.g("يౌ὎ᝐ", a_))
						{
							num = (short)1424359426;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BB;
					case 4:
						goto IL_1E4;
					}
					goto IL_F6;
					IL_1BB:
					this.btnCommon.DeleteFile(this.hSession, array);
					num = (short)466812932;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_1B9:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("၊ौ絎捐๒畔ᙖ㩘㡚㡜ⱞበ䍢ᅤࡦ䥨♪ⱬ㽮㝰嵲䕴坶ၸࡺ嵼ൾ歷붒", a_));
				IL_1E4:
				return;
				IL_F6:
				this.btnCommon.GetSessionHandle(ref this.hSession);
				this.btnCommon.DoTMSetup(this.hSession);
				array = null;
				array = this.btnCommon.LoadFileName(fileName);
				num = (short)1449918465;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_DC;
			}
			catch (global::IBtnWrapperLib.TMEXException innerException)
			{
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("≊ཌ㩎═❒㩔㥖祘ᑚⵜ㩞፠ɢᅤ๦٨ժ䵬⩮ͰŲᩴն奸噺嵼౾ꖄ캆ﶎ풐쾠莢쎤좦\udba8讪즬쪮얰튲\udcb4\udbb6쪸", a_), innerException);
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
			goto IL_1FD;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00013874 File Offset: 0x00011A74
		public void GetNumDaysLeft(ref short pDaysLeft)
		{
			int a_ = 6;
			short num = (short)495976448;
			short num2 = num;
			num = (short)1213920823;
			short num3 = num;
			num = (short)406451767;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_158:
				num = (short)2020671490;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)618463232;
				if (num != 0)
				{
				}
				num = (short)90374144;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_AC;
					}
					continue;
				case 1:
					goto IL_CB;
				case 2:
					goto IL_171;
				}
				IL_AC:
				if (this.bButtonOpened)
				{
					goto IL_158;
				}
				num = (short)1162608641;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_CB:
			IL_11C:
			num = (short)1433731073;
			if (num != 0)
			{
			}
			throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("搾Հ牂ᡄ杆و㭊⡌ⅎፐ♒⅔⍖㙘㕚絜ㅞ๠ᝢ䕤ѦࡨݪŬ੮ᕰ", a_));
			IL_171:
			try
			{
				this.btnCommon.GetSessionHandle(ref this.hSession);
				this.btnCommon.DoTMSetup(this.hSession);
				this.btnCommon.GetNumDaysLeft(this.hSession, global::IBtnWrapperLib.TimerType.realTime, ref pDaysLeft);
				return;
			}
			catch (global::IBtnWrapperLib.TMEXException innerException)
			{
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("嘾̀㙂ㅄ㍆♈╊浌⁎⅐㙒❔㙖ⵘ㉚㉜ㅞ䅠٢ᝤᕦ٨ᥪ䵬䉮兰rၴቶ奸㉺፼ᅾ삄ﾆﶌﮎﲒﮔ랖ﾘ뾞얠욢톤욦삨잪\udeac", a_), innerException);
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
			goto IL_11C;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00013A14 File Offset: 0x00011C14
		public byte[] GetROMSerialNum()
		{
			int a_ = 14;
			short num = (short)596836352;
			short num2 = num;
			num = (short)616730991;
			short num3 = num;
			num = (short)873435503;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_99;
			default:
				num = (short)1161297920;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_99;
				}
				break;
			}
			int num4;
			byte[] result;
			for (;;)
			{
				IL_87:
				switch (num4)
				{
				case 0:
					if (this.btnCommon != null)
					{
						num = (short)782172161;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D4;
				case 1:
					this.btnCommon.GetSessionHandle(ref this.hSession);
					this.btnCommon.DoTMSetup(this.hSession);
					result = this.btnCommon.GetROMSerialNum(this.hSession, true);
					num = (short)1015676930;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_136;
				}
				goto IL_99;
			}
			IL_D4:
			throw new global::IBtnWrapperLib.TMEXException(global::IBtnWrapperLib.TMEXException.g("⹆ୈ㹊㥌㭎㹐㵒畔V⭘㩚ⵜ⽞Ѡᅢ䕤⡦୨Ū࡬౮հ卲ᱴѶ奸ᕺቼ୾ꆀﶈ릘몚", a_));
			IL_136:
			num = (short)291241985;
			if (num != 0)
			{
			}
			return result;
			IL_99:
			result = new byte[8];
			num = (short)1306263552;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_87;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00013B84 File Offset: 0x00011D84
		public string GetROMSerialNumString()
		{
			int a_ = 10;
			short num = (short)1409034607;
			short num2 = num;
			num = (short)2028087663;
			string text;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1955987457;
				if (num != 0)
				{
				}
				num = (short)991690752;
				if (num != 0)
				{
				}
				num = (short)1520304128;
				short num3 = num;
				text = null;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_D1;
					}
					int num4;
					int num5;
					byte[] romserialNum;
					for (;;)
					{
						IL_B7:
						switch (num4)
						{
						case 0:
							if (num5 < 0)
							{
								num = (short)2103050243;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							text += string.Format(global::IBtnWrapperLib.TMEXException.g("㡂畄絆ㅈ祊が", a_), romserialNum[num5]);
							num5--;
							num = (short)1499004930;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_F0;
						case 2:
							goto IL_F0;
						case 3:
							num = (short)356253700;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_176;
						}
						goto IL_D1;
						IL_F0:
						num = (short)138936320;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_176:
					break;
					IL_D1:
					romserialNum = this.GetROMSerialNum();
					num5 = 7;
					num = (short)1841037313;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_B7;
				}
				catch (global::IBtnWrapperLib.TMEXException ex)
				{
					throw ex;
				}
				catch (global::System.Exception ex2)
				{
					throw ex2;
				}
				break;
			}
			}
			return text;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00013D28 File Offset: 0x00011F28
		internal void b()
		{
			int a_ = 1;
			short num;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_62;
				}
				for (;;)
				{
					IL_13:
					num = (short)906231808;
					short num2 = num;
					int num3;
					switch (num3)
					{
					case 0:
						goto IL_13A;
					case 1:
					{
						int num4 = 0;
						num = (short)50855936;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						int num4;
						byte[] romserialNum;
						if (num4 >= romserialNum.Length)
						{
							num = (short)712638470;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1704394757;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_1DA;
					case 4:
					{
						byte[] romserialNum;
						byte[] array;
						if (romserialNum.Length == array.Length)
						{
							num = (short)864616449;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FC;
					}
					case 5:
					{
						int num4;
						byte[] romserialNum;
						byte[] array;
						if (romserialNum[num4] != array[num4])
						{
							num = (short)1476984835;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4++;
						num = (short)1765867527;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						return;
					case 7:
						goto IL_13A;
					}
					break;
					IL_13A:
					num = (short)823263234;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_62:
				num = (short)1282414988;
				short num5 = num;
				num = (short)803346828;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)279838720;
					if (num != 0)
					{
					}
					this.btnCommon.GetSessionHandle(ref this.hSession);
					this.btnCommon.DoTMSetup(this.hSession);
					byte[] romserialNum = this.btnCommon.GetROMSerialNum(this.hSession, false);
					byte[] array = new byte[8];
					this.btnCommon.GetMAPFFieldData(this.hSession, ref array, 6, 8);
					num = (short)11599876;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_13;
				}
				}
			}
			return;
			IL_1DA:
			throw new global::IBtnWrapperLib.TMEXException(global::IBtnWrapperLib.TMEXException.g("愹砻ఽ焿ὁ摃⽅ੇ㽉㡋㩍㽏㱑瑓ѕ᝗᝙籛㩝ཟݡᝣ䙥٧թᡫ乭ᵯ፱sᕵၷ婹੻ώꚅﮇﺉﲍ뒓ﾕ몙ﶛ풟쪡쮣풥솧킩춫\udaad\ud9af\uddb1\udab3隵\udeb7펹킻\udbbd藃ꗅꯇ꿉뿋뷍뛑뇓룕뇗뿙룛", a_));
			IL_1FC:
			num = (short)2125463553;
			if (num != 0)
			{
			}
			throw new global::IBtnWrapperLib.TMEXException(global::IBtnWrapperLib.TMEXException.g("愹砻ఽ焿ὁ摃⽅ੇ㽉㡋㩍㽏㱑瑓ѕ᝗᝙籛㩝ཟݡᝣ䙥٧թᡫ乭ᵯ፱sᕵၷ婹੻ώꚅﮇﺉﲍ뒓ﾕ몙ﶛ풟쪡쮣풥솧킩춫\udaad\ud9af\uddb1\udab3隵\udeb7펹킻\udbbd藃ꗅꯇ꿉뿋뷍뛑뇓룕뇗뿙룛", a_));
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00013F70 File Offset: 0x00012170
		public void GetMaxFileSpace(string fileName, out short pMaxBytes)
		{
			int a_ = 6;
			short num = (short)491913216;
			short num2 = num;
			num = (short)1462958825;
			short num3 = num;
			num = (short)1601960681;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_98;
			default:
				num = (short)1222311936;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_98;
				}
				break;
			}
			int num4;
			for (;;)
			{
				IL_86:
				switch (num4)
				{
				case 0:
					if (!this.bButtonOpened)
					{
						num = (short)829095937;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)421134338;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_CF;
				case 2:
					goto IL_17F;
				}
				goto IL_98;
			}
			IL_CF:
			num = (short)344522753;
			if (num != 0)
			{
			}
			IL_153:
			throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("搾Հ牂ᡄ杆و㭊⡌ⅎፐ♒⅔⍖㙘㕚絜ㅞ๠ᝢ䕤ѦࡨݪŬ੮ᕰ", a_));
			IL_17F:
			try
			{
				this.btnCommon.GetSessionHandle(ref this.hSession);
				this.btnCommon.DoTMSetup(this.hSession);
				this.btnCommon.GetMaxFileSpaceAvailable(this.hSession, fileName, out pMaxBytes);
				return;
			}
			catch (global::IBtnWrapperLib.TMEXException ex)
			{
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("嘾̀㙂ㅄ㍆♈╊浌⁎⅐㙒❔㙖ⵘ㉚㉜ㅞ䅠٢ᝤᕦ٨ᥪ坬佮", a_) + ex.Message, ex);
			}
			catch (global::System.Exception ex2)
			{
				throw ex2;
			}
			goto IL_153;
			IL_98:
			pMaxBytes = 0;
			num = (short)2128281600;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_86;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00014120 File Offset: 0x00012320
		public void GetFileSize(string fileName, ref short pFileSz)
		{
			int a_ = 17;
			short num = (short)693108736;
			short num2 = num;
			num = (short)1741065019;
			short num3 = num;
			num = (short)1916111675;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1496711168;
				if (num != 0)
				{
				}
				num = (short)1416167427;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					byte[] array;
					switch (num4)
					{
					case 0:
						goto IL_199;
					case 1:
						goto IL_D7;
					case 2:
						try
						{
							this.ReadFile(fileName, ref pFileSz, out array);
							return;
						}
						catch (global::System.Exception ex)
						{
							throw ex;
						}
						goto IL_199;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_BA;
						}
						continue;
					case 4:
						if (this.GetROMSerialNum()[0] == 12)
						{
							num = (short)1560412160;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						pFileSz = 420;
						num = (short)1227227141;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_100;
					case 6:
						goto IL_100;
					}
					IL_BA:
					if (!this.bButtonOpened)
					{
						num = (short)762970113;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					array = null;
					num = (short)803405828;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_100:
					num = (short)1881931778;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_199:
					pFileSz = 7057;
					num = (short)430047238;
					num4 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
			IL_D7:
			num = (short)1290403841;
			if (num != 0)
			{
			}
			throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ᅉࡋ罍൏牑᭓♕㵗㑙ṛ⭝ᑟᙡୣࡥ䡧ѩͫᩭ偯ᅱᕳ᩵ᑷό᡻", a_));
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000142FC File Offset: 0x000124FC
		public static string GetFileName(byte[] fentry)
		{
			int a_ = 16;
			short num = (short)104868600;
			short num2 = num;
			num = (short)1690970872;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_115:
				num = (short)1738997767;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)369688576;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_87;
				}
				break;
			}
			global::System.Text.StringBuilder stringBuilder;
			for (;;)
			{
				IL_5D:
				switch (num3)
				{
				case 0:
				{
					int num4 = 0;
					num = (short)1139867654;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_115;
				case 2:
					goto IL_12F;
				case 3:
					goto IL_1C2;
				case 4:
				{
					int num4;
					if (num4 >= 4)
					{
						num = (short)328269832;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					stringBuilder.Append((char)fentry[num4]);
					num4++;
					num = (short)1732116483;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					num = (short)309854209;
					if (num != 0)
					{
					}
					if (fentry != null)
					{
						num = (short)465764353;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_192;
				case 6:
					goto IL_1C2;
				case 7:
					if (fentry.Length == 40)
					{
						num = (short)447021056;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_192;
				case 8:
					num = (short)1211367426;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_87;
				IL_1C2:
				num = (short)240320516;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_12F:
			return stringBuilder.ToString();
			IL_192:
			throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("H╊㭌⹎㵐㩒ㅔ睖὘㉚ㅜ㩞䅠♢୤፦᭨ቪ䵬ٮὰᕲᩴնᑸ᩺ॼᙾ", a_));
			IL_87:
			stringBuilder = new global::System.Text.StringBuilder();
			num = (short)1948385280;
			short num5 = num;
			num = (short)195231749;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_5D;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00014510 File Offset: 0x00012710
		internal static byte a(byte[] A_0)
		{
			int a_ = 10;
			short num = (short)1601860182;
			short num2 = num;
			num = (short)1569092182;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1724841984;
				if (num != 0)
				{
				}
				num = (short)1004666880;
				short num3 = num;
				num = (short)724041729;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_C7;
				}
				break;
			}
			}
			int num4;
			byte result;
			for (;;)
			{
				IL_AD:
				switch (num4)
				{
				case 0:
					num = (short)941817858;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (A_0 != null)
					{
						num = (short)1126760448;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FB;
				case 2:
					if (A_0.Length == 40)
					{
						num = (short)2029191172;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FB;
				case 3:
					return result;
				case 4:
					result = A_0[4];
					num = (short)755761155;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_C7;
			}
			IL_FB:
			throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ੂ⭄ㅆ⡈❊⑌⭎煐ᕒ㱔㭖㱘筚ᡜㅞᕠᅢᱤ䝦hժ୬nͰṲᑴͶၸᑺ፼", a_));
			IL_C7:
			result = byte.MaxValue;
			num = (short)501153793;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_AD;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00014680 File Offset: 0x00012880
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00014730 File Offset: 0x00012930
		public short PortNumber
		{
			get
			{
				short num = (short)1209335809;
				if (num != 0)
				{
				}
				num = (short)2045444096;
				short num2 = num;
				num = (short)101753734;
				short num3 = num;
				num = (short)1170973574;
				switch (num3 == num)
				{
				}
				num = (short)1276313600;
				if (num != 0)
				{
				}
				return this.portNum;
			}
			set
			{
				short num = (short)247267290;
				short num2 = num;
				num = (short)1881604058;
				switch (num2 == num)
				{
				default:
				{
					num = (short)488374272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)807665664;
				if (num != 0)
				{
				}
				num = (short)928251905;
				if (num != 0)
				{
				}
				this.portNum = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000147E0 File Offset: 0x000129E0
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00014894 File Offset: 0x00012A94
		public short PortType
		{
			get
			{
				short num = (short)42522901;
				short num2 = num;
				num = (short)1397020949;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1136656384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)217710593;
				if (num != 0)
				{
				}
				num = (short)421462016;
				if (num != 0)
				{
				}
				return this.portType;
			}
			set
			{
				short num = (short)859743116;
				short num2 = num;
				num = (short)616211340;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1973420032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1381302272;
				if (num != 0)
				{
				}
				num = (short)2134310913;
				if (num != 0)
				{
				}
				this.portType = value;
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00014944 File Offset: 0x00012B44
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1099778288;
				short num2 = num;
				num = (short)1232881904;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_B4:
					num = (short)1054605313;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1804926976;
					if (num != 0)
					{
					}
					num = (short)1004535808;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_81;
						}
						continue;
					case 1:
						goto IL_CA;
					case 2:
						goto IL_9F;
					case 3:
						goto IL_DF;
					}
					IL_81:
					if (this.hSession > 0)
					{
						num = (short)3407874;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_CA:
					num = (short)1005518851;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_9F:
				global::IBtnWrapperLib.TMEXAPI.TMEndSession(this.hSession);
				this.hSession = 0;
				goto IL_B4;
				IL_DF:;
			}
			finally
			{
				num = (short)1014235137;
				if (num != 0)
				{
				}
				base.Finalize();
			}
			num = (short)97255424;
			short num4 = num;
		}

		// Token: 0x040000B3 RID: 179
		protected int hSession;

		// Token: 0x040000B4 RID: 180
		protected short portNum;

		// Token: 0x040000B5 RID: 181
		protected short portType;

		// Token: 0x040000B6 RID: 182
		protected short maxRetryCnt;

		// Token: 0x040000B7 RID: 183
		protected bool bButtonOpened;

		// Token: 0x040000B8 RID: 184
		protected bool bMotoBtn;

		// Token: 0x040000B9 RID: 185
		protected bool bOpenForInit;

		// Token: 0x040000BA RID: 186
		protected global::IBtnWrapperLib.IBtnCommon btnCommon;
	}
}
