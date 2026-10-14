using System;
using System.IO;
using AcpCryptoLib;
using IBtnWrapperLib;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.FlashkeyLib
{
	// Token: 0x02000104 RID: 260
	public class FlashkeyManager
	{
		// Token: 0x06000E5A RID: 3674 RVA: 0x00003275 File Offset: 0x00001475
		public FlashkeyManager()
		{
			this.a = new global::IBtnWrapperLib.MultiBtnWrapper();
			this.b = null;
			this.e = null;
			this.f = -1;
			this.g = -1;
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x001436D0 File Offset: 0x001418D0
		internal bool ValidateSerialNumber()
		{
			return true;
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x001438D8 File Offset: 0x00141AD8
		internal byte[] GetKeySerialNumber()
		{
			short num = (short)1225261057;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)109888292;
					short num3 = num;
					num = (short)1746715428;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						goto IL_117;
					}
					break;
				}
				case 1:
					goto IL_14;
				case 2:
				{
					num = (short)1045626880;
					short num4 = num;
					if (this.b == null)
					{
						num = (short)1324417024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_138;
				}
				case 3:
					goto IL_51;
				}
				goto IL_34;
				IL_14:
				switch (0)
				{
				case 0:
					IL_34:
					if (this.a == null)
					{
						num = (short)1337786371;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1331036162;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_51:
			num = (short)1126105089;
			if (num != 0)
			{
			}
			throw new global::System.NullReferenceException();
			IL_117:
			num = (short)342163456;
			if (num != 0)
			{
			}
			throw new global::System.NullReferenceException();
			IL_138:
			byte[] result;
			this.b.GetSerialNumber(out result);
			return result;
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x000032A4 File Offset: 0x000014A4
		internal object GetValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType fType)
		{
			if (fType == global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.UpgradesRemaining)
			{
				return 100;
			}
			return global::System.IO.File.ReadAllText(global::System.IO.Path.Combine(global::System.AppDomain.CurrentDomain.BaseDirectory, "flashcode.txt"));
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x00143A2C File Offset: 0x00141C2C
		internal bool UpdateUpgradesRemCounter(int howMany)
		{
			int a_ = 19;
			short num = (short)1572995072;
			switch (num)
			{
			default:
			{
				num = (short)1970077706;
				int num2 = (int)((global::System.IntPtr)num);
				bool flag;
				for (;;)
				{
					byte[] array4;
					switch (num2)
					{
					case 0:
						if (this.ValidateSerialNumber())
						{
							num = (short)1145307150;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22A;
					case 1:
					{
						byte[] array;
						global::System.Array.Resize<byte>(ref array, this.b.KeyDecDataSize);
						byte[] array2 = new byte[array.Length];
						global::System.Array.Copy(array, array2, array2.Length);
						num = (short)268763169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_6D8;
					case 3:
						if (!flag)
						{
							num = (short)1218248711;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_526;
					case 4:
					{
						byte[] array3;
						flag = this.a.WriteFileAtPage(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb95힗캙\uda9b낝邟銡钣", a_), array3.Length, 8, array3);
						num = (short)1125646363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						this.a.CreateButton();
						this.a.PortType = this.d;
						this.a.PortNumber = this.c;
						num = (short)2022178829;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_3A9;
					case 7:
					{
						num = (short)494469120;
						short num3 = num;
						num = (short)7995429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num = (short)228589602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_701;
					case 10:
					{
						num = (short)689856031;
						short num4 = num;
						num = (short)105668127;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_495;
						default:
							num = (short)906428416;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_13B;
							}
							continue;
						}
						break;
					}
					case 11:
					{
						int num5;
						if (num5 == 0)
						{
							num = (short)1668349969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22A;
					}
					case 12:
					{
						byte[] array;
						if (array != null)
						{
							num = (short)1606483969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A9;
					}
					case 13:
						if (this.ValidateSerialNumber())
						{
							num = (short)1644494856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A9;
					case 14:
						num = (short)1203306535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						byte[] array3;
						if (array3 != null)
						{
							num = (short)1622212636;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_189;
					}
					case 16:
					{
						byte[] array3;
						if (array3.Length != 0)
						{
							num = (short)23986180;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_189;
					}
					case 17:
						num = (short)1686241300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (flag)
						{
							num = (short)1635123225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A9;
					case 19:
						if (array4.Length != 0)
						{
							num = (short)1512243205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 20:
					{
						bool flag2;
						if (!flag2)
						{
							num = (short)563675165;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22A;
					}
					case 21:
					{
						byte[] array2;
						byte[] array3 = this.a(array2);
						num = (short)35651620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						num = (short)1344864275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_22A;
					case 24:
					{
						byte[] array = this.b(array4);
						num = (short)1736048652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
					{
						byte[] array3;
						this.b.StoreKeyData(array3);
						num = (short)282066950;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						if (this.b == null)
						{
							num = (short)930611202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						array4 = null;
						this.b.GetKeyData(out array4);
						num = (short)530972704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_189;
					case 28:
						num = (short)2102525968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						bool flag2 = true;
						int num5 = 10;
						num = (short)379453463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						goto IL_184;
					case 31:
					{
						int num5 = 10;
						bool flag2 = false;
						byte[] array3 = null;
						num = (short)1241710630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						goto IL_495;
					case 33:
					{
						byte[] array;
						if (this.b.UpdateUpgradesRemCounter(howMany, ref array))
						{
							num = (short)2086797343;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A9;
					}
					case 34:
						if (this.a())
						{
							num = (short)1121124376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A9;
					case 35:
						goto IL_3CC;
					case 36:
						goto IL_701;
					case 37:
					{
						int num5;
						if (num5-- <= 0)
						{
							num = (short)1973420072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5A2;
					}
					case 38:
						goto IL_5A2;
					case 39:
					{
						bool flag2;
						if (flag2)
						{
							num = (short)1600913429;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array;
						byte[] array3 = this.a(array);
						num = (short)270270473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						goto IL_526;
					}
					IL_13B:
					num = (short)1348861953;
					if (num != 0)
					{
					}
					if (this.a == null)
					{
						num = (short)1587478558;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)835256346;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_189:
					num = (short)455737355;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22A:
					num = (short)2035744771;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A9:
					this.a.CloseButton();
					num = (short)1277952035;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_495:
					if (array4 != null)
					{
						num = (short)1541210134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return flag;
					IL_526:
					num = (short)1704919058;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5A2:
					num = (short)443351040;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_701:
					num = (short)95158287;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_184:
				throw new global::System.NullReferenceException();
				IL_3CC:
				return flag;
				IL_6D8:
				throw new global::System.NullReferenceException();
			}
			}
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00144178 File Offset: 0x00142378
		internal bool ValidateKey()
		{
			return true;
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00144790 File Offset: 0x00142990
		internal bool FindFlashkey(string modelNumber, string flashcode, global::SpecialFeatures.Flashport.FlashkeyLib.FindType find)
		{
			return true;
			IL_3E:
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], 0);
			IL_48:
			int num;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_8F:
			if (this.a != null)
			{
				goto IL_21E;
			}
			short num2 = (short)1489240065;
			num = (int)((global::System.IntPtr)num2);
			goto IL_48;
			IL_B1:
			num2 = (short)981270528;
			short num3 = num2;
			throw new global::System.NullReferenceException();
			IL_E0:
			num2 = (short)2002714628;
			num = (int)((global::System.IntPtr)num2);
			goto IL_48;
			IL_F8:
			bool flag;
			if (flag)
			{
				goto IL_DF3;
			}
			num2 = (short)1387397122;
			num = (int)((global::System.IntPtr)num2);
			goto IL_48;
			IL_116:
			num2 = (short)388562947;
			num = (int)((global::System.IntPtr)num2);
			goto IL_48;
			IL_11B:
			num2 = (short)764280842;
			num = (int)((global::System.IntPtr)num2);
			goto IL_48;
			IL_134:
			short num4;
			short num5;
			if (num4 > num5)
			{
				goto IL_E0;
			}
			num2 = (short)424738825;
			num = (int)((global::System.IntPtr)num2);
			goto IL_48;
			IL_151:
			num2 = (short)475201537;
			if (num2 == 0)
			{
				goto IL_177;
			}
			IL_177:
			num2 = (short)714407948;
			num = (int)((global::System.IntPtr)num2);
			goto IL_48;
			IL_17C:
			num2 = (short)1832910862;
			num = (int)((global::System.IntPtr)num2);
			goto IL_48;
			IL_196:
			goto IL_30B;
			IL_1B4:
			if (find != global::SpecialFeatures.Flashport.FlashkeyLib.FindType.FindExactMatchOrRefresh)
			{
				goto IL_DF3;
			}
			num2 = (short)1280829735;
			short num6 = num2;
			num2 = (short)558229799;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6 == num2);
			IL_1EF:
			num2 = (short)633536512;
			if (num2 == 0)
			{
				goto IL_204;
			}
			IL_204:
			num2 = (short)2030567437;
			num = (int)((global::System.IntPtr)num2);
			goto IL_48;
			IL_21C:
			global::SpecialFeatures.Flashport.FlashkeyLib.Flashkey flashkey;
			this.b = flashkey;
			flag = true;
			num2 = (short)274464775;
			num = (int)((global::System.IntPtr)num2);
			goto IL_48;
			IL_21E:
			flashkey = null;
			short num7 = 2;
			num5 = 6;
			flag = false;
			num4 = num7;
			num2 = (short)715915269;
			num = (int)((global::System.IntPtr)num2);
			goto IL_48;
			IL_23E:
			goto IL_11B;
			IL_25B:
			if (!flag)
			{
				goto IL_17C;
			}
			num2 = (short)2060189711;
			num = (int)((global::System.IntPtr)num2);
			goto IL_48;
			IL_27A:
			goto IL_E0;
			IL_2A0:
			return flag;
			IL_2C4:
			if (flashkey == null)
			{
				goto IL_DF3;
			}
			num2 = (short)2092105739;
			num = (int)((global::System.IntPtr)num2);
			goto IL_48;
			IL_2E4:
			num2 = (short)778108934;
			num = (int)((global::System.IntPtr)num2);
			goto IL_48;
			IL_2E9:
			num4 += 4;
			num2 = (short)10092552;
			num = (int)((global::System.IntPtr)num2);
			goto IL_48;
			IL_306:
			goto IL_11B;
			try
			{
				IL_30B:
				switch (0)
				{
				case 0:
					goto IL_424;
				}
				short num9;
				for (;;)
				{
					IL_315:
					byte[] array2;
					int a_;
					short num8;
					switch (num)
					{
					case 0:
						goto IL_95D;
					case 1:
						flag = true;
						num2 = (short)364249137;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						num2 = (short)321257506;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
					{
						global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyLayout flashkeyLayout;
						byte[] array;
						string text = (string)flashkeyLayout.GetFieldValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.ModelNumber, array);
						char[] trimChars = new char[]
						{
							'\0',
							' '
						};
						num2 = (short)1874001967;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 4:
						goto IL_D09;
					case 5:
					{
						flag = true;
						byte[] romserialNum = this.a.GetROMSerialNum();
						this.b = new global::SpecialFeatures.Flashport.FlashkeyLib.Flashkey();
						num2 = (short)552009748;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 6:
						goto IL_8FA;
					case 7:
					{
						byte[] array;
						byte[] romserialNum2;
						if (!flashkey.InitFlashkey(array2, romserialNum2, array))
						{
							num2 = (short)1380253731;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						this.c = this.a.PortNumber;
						this.d = this.a.PortType;
						num2 = (short)812580879;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 8:
					{
						string text;
						char[] trimChars;
						if (text.TrimEnd(trimChars) == modelNumber.TrimEnd(trimChars))
						{
							num2 = (short)775880706;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_B95;
					}
					case 9:
						num2 = (short)2085290023;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 10:
					{
						global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyLayout flashkeyLayout;
						byte[] array;
						if (flashkeyLayout.InitLayout(array))
						{
							num2 = (short)461963267;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_8FA;
					}
					case 11:
						if (flashkey == null)
						{
							num2 = (short)1420886069;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_8FA;
					case 12:
					{
						string text;
						char[] trimChars;
						if (text.TrimEnd(trimChars) == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슏ꊑ꒓쒕쪗좙겛첝銡盛鲫ﲭ", a_))
						{
							num2 = (short)312737851;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_CCC;
					}
					case 13:
						if (find == global::SpecialFeatures.Flashport.FlashkeyLib.FindType.MatchModelOnly)
						{
							num2 = (short)284098620;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_B95;
					case 14:
						goto IL_8FA;
					case 15:
						goto IL_8FA;
					case 16:
						if (this.a())
						{
							num2 = (short)1447100479;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_8FA;
					case 17:
						if (!flag)
						{
							num2 = (short)1867710521;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_D09;
					case 18:
						num2 = (short)323026957;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 19:
						goto IL_820;
					case 20:
					{
						byte[] array;
						byte[] romserialNum;
						if (!this.b.InitFlashkey(array2, romserialNum, array))
						{
							num2 = (short)1112932382;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						this.c = this.a.PortNumber;
						this.d = this.a.PortType;
						num2 = (short)262340622;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 21:
						goto IL_B2E;
					case 22:
						if (flag)
						{
							num2 = (short)1433993253;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_8FA;
					case 23:
						if (this.a.PortType == 6)
						{
							num2 = (short)138018849;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_820;
					case 24:
						num2 = (short)1804730424;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 25:
						goto IL_A22;
					case 26:
						goto IL_DC3;
					case 27:
						if (find == global::SpecialFeatures.Flashport.FlashkeyLib.FindType.MatchFlashcodeOnly)
						{
							num2 = (short)783286326;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_5F5;
					case 28:
						if (num8 <= 15)
						{
							num2 = (short)1490223128;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_DC3;
					case 29:
						goto IL_8FA;
					case 30:
						flag = false;
						this.b = null;
						num2 = (short)989921345;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 31:
						num2 = (short)1893924900;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 32:
						num2 = (short)1499660300;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 33:
						num9 = 2;
						num2 = (short)379256851;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 34:
						if (find != global::SpecialFeatures.Flashport.FlashkeyLib.FindType.FindExactMatch)
						{
							num2 = (short)1019740169;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_A60;
					case 35:
						flashkey = null;
						num2 = (short)47579142;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 36:
						if (find != global::SpecialFeatures.Flashport.FlashkeyLib.FindType.FindExactMatchOrRefresh)
						{
							num2 = (short)898170898;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_527;
					case 37:
					{
						byte[] romserialNum3 = this.a.GetROMSerialNum();
						this.b = new global::SpecialFeatures.Flashport.FlashkeyLib.Flashkey();
						num2 = (short)264568893;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 38:
						flag = false;
						this.b = null;
						num2 = (short)78053428;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 39:
						if (find != global::SpecialFeatures.Flashport.FlashkeyLib.FindType.FindExactMatchOrRefresh)
						{
							num2 = (short)764149803;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_A60;
					case 40:
						if (array2 != null)
						{
							num2 = (short)1961820222;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_8FA;
					case 41:
					{
						global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyLayout flashkeyLayout;
						byte[] array;
						char[] trimChars;
						if (((string)flashkeyLayout.GetFieldValue(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType.Flashcode, array)).TrimEnd(trimChars) == flashcode.TrimEnd(trimChars))
						{
							num2 = (short)1740177409;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_5F5;
					}
					case 42:
					{
						bool flag2;
						if (flag2)
						{
							num2 = (short)1438711858;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_95D;
					}
					case 43:
						num2 = (short)1758461979;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 44:
						if (flag)
						{
							num2 = (short)2117730304;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_B2E;
					case 45:
						goto IL_DDC;
					case 46:
					{
						byte[] array;
						if (array != null)
						{
							num2 = (short)760676407;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_8FA;
					}
					case 47:
						if (find != global::SpecialFeatures.Flashport.FlashkeyLib.FindType.FindExactMatch)
						{
							num2 = (short)739573791;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_527;
					case 48:
						if (find == global::SpecialFeatures.Flashport.FlashkeyLib.FindType.FindExactMatchOrRefresh)
						{
							num2 = (short)1926103072;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_CCC;
					case 49:
						goto IL_5F5;
					case 50:
						num2 = (short)668794924;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 51:
						if (find == global::SpecialFeatures.Flashport.FlashkeyLib.FindType.FindAny)
						{
							num2 = (short)173932549;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_8FA;
					case 52:
						goto IL_8FA;
					case 53:
					{
						byte[] romserialNum2 = this.a.GetROMSerialNum();
						flashkey = new global::SpecialFeatures.Flashport.FlashkeyLib.Flashkey();
						num2 = (short)1004404743;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 54:
						goto IL_A60;
					case 55:
					{
						global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyLayout flashkeyLayout = new global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyLayout();
						num2 = (short)265355274;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 56:
					{
						if (flag)
						{
							num2 = (short)1899429914;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						this.a.PortNumber = num8;
						bool flag2 = this.a.FindFirstBtn(255);
						num2 = (short)1010630714;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 57:
					{
						bool flag2 = this.a.FindNextBtn();
						num2 = (short)1885143044;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 58:
					{
						bool flag2;
						if (flag2)
						{
							num2 = (short)338493461;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_95D;
					}
					case 59:
						num2 = (short)9699339;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 60:
						goto IL_527;
					case 61:
					{
						byte[] array;
						byte[] romserialNum3;
						if (!this.b.InitFlashkey(array2, romserialNum3, array))
						{
							num2 = (short)1323040806;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						this.c = this.a.PortNumber;
						this.d = this.a.PortType;
						num2 = (short)1213333533;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 62:
						num2 = (short)2027421712;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 63:
					{
						byte[] array = this.b(array2);
						num2 = (short)139984942;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 64:
						goto IL_A22;
					case 65:
						goto IL_8FA;
					}
					goto IL_424;
					IL_527:
					num2 = (short)824639496;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_5F5:
					num2 = (short)1897791510;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_820:
					num8 = num9;
					num2 = (short)598409280;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_8FA:
					num2 = (short)418250769;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_95D:
					num8 += 1;
					num2 = (short)914227225;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_A22:
					num2 = (short)764084252;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_A60:
					num2 = (short)520159273;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_B2E:
					short num10 = 256;
					short num11 = 0;
					this.a.ReadFileAtPage(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8f\udd91삓킕뚗ꪙ겛꺝", a_), ref num10, ref num11, out array2);
					num2 = (short)800325672;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_B95:
					num2 = (short)2085027888;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_CCC:
					num2 = (short)1983053875;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_D09:
					num2 = (short)1201864746;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_DC3:
					num2 = (short)364838957;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_DDC:
				goto IL_2E9;
				IL_424:
				this.a.PortType = num4;
				this.a.CreateButton();
				num9 = 1;
				num2 = (short)1302331415;
				num = (int)((global::System.IntPtr)num2);
				goto IL_315;
			}
			catch (global::System.Exception)
			{
				goto IL_2E9;
			}
			finally
			{
				this.a.CloseButton();
			}
			IL_DF3:
			return flag;
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x001455C8 File Offset: 0x001437C8
		internal bool IsRefreshKey()
		{
			return true;
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x00145948 File Offset: 0x00143B48
		internal bool IsModelUpgradeKey()
		{
			return false;
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x00145DD4 File Offset: 0x00143FD4
		private byte[] b(byte[] A_0)
		{
			short num = (short)878116864;
			switch (num)
			{
			default:
			{
				num = (short)1481048065;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)769916929;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						num = (short)57802752;
						short num3 = num;
						byte[] array;
						global::System.Array.Clear(array, 0, array.Length);
						num = (short)167706629;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_91;
						}
						continue;
					case 2:
						goto IL_AD;
					case 3:
					{
						byte[] array;
						byte[] array2;
						if (this.a(out array2, out array, false))
						{
							num = (short)1568473096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] result;
						return result;
					}
					case 4:
					{
						global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyLayout flashkeyLayout = new global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyLayout();
						byte[] encryptedData = flashkeyLayout.GetEncryptedData(A_0);
						global::AcpCryptoLib.FlashkeyCrypto flashkeyCrypto = new global::AcpCryptoLib.FlashkeyCrypto();
						byte[] array;
						byte[] array2;
						flashkeyCrypto.Init(array2, array);
						byte[] data = flashkeyCrypto.Decrypt(encryptedData);
						byte[] result = flashkeyLayout.GetAllData(data, A_0);
						global::System.Array.Clear(array2, 0, array2.Length);
						num = (short)1390739462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						byte[] result;
						return result;
					}
					case 6:
					{
						byte[] array;
						if (array != null)
						{
							num = (short)1739390976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] result;
						return result;
					}
					case 7:
					{
						byte[] array2;
						if (array2 == null)
						{
							byte[] result;
							return result;
						}
						num = (short)866246986;
						short num4 = num;
						num = (short)1301995850;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AD;
						default:
							num = (short)180289536;
							if (num != 0)
							{
							}
							num = (short)1871052804;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						num = (short)1580204039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_91:
					if (A_0 == null)
					{
						num = (short)260243458;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						byte[] result = null;
						num = (short)447414275;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_AD:
				throw new global::System.NullReferenceException();
			}
			}
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x0014602C File Offset: 0x0014422C
		private byte[] a(byte[] A_0)
		{
			short num = (short)245760000;
			switch (num)
			{
			default:
			{
				num = (short)1606483969;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1422393344;
						short num3 = num;
						byte[] array;
						global::System.Array.Clear(array, 0, array.Length);
						num = (short)1898643461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_68;
						}
						continue;
					case 2:
						goto IL_83;
					case 3:
					{
						byte[] array;
						byte[] array2;
						if (this.a(out array2, out array, true))
						{
							num = (short)908525576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] result;
						return result;
					}
					case 4:
					{
						global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyLayout flashkeyLayout = new global::SpecialFeatures.Flashport.FlashkeyLib.FlashkeyLayout();
						byte[] decryptedData = flashkeyLayout.GetDecryptedData(A_0);
						global::AcpCryptoLib.FlashkeyCrypto flashkeyCrypto = new global::AcpCryptoLib.FlashkeyCrypto();
						byte[] array;
						byte[] array2;
						flashkeyCrypto.Init(array2, array);
						byte[] data = flashkeyCrypto.Encrypt(decryptedData);
						byte[] result = flashkeyLayout.GetAllData(data, A_0);
						global::System.Array.Clear(array2, 0, array2.Length);
						num = (short)349700102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						byte[] result;
						return result;
					}
					case 6:
					{
						byte[] array;
						if (array != null)
						{
							num = (short)2086928385;
							if (num != 0)
							{
							}
							num = (short)533921792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] result;
						return result;
					}
					case 7:
					{
						byte[] array2;
						if (array2 == null)
						{
							byte[] result;
							return result;
						}
						num = (short)1664472653;
						short num4 = num;
						num = (short)1341249101;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_83;
						default:
							num = (short)1464401920;
							if (num != 0)
							{
							}
							num = (short)376766468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						num = (short)1823604743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_68:
					if (A_0 == null)
					{
						num = (short)1970929666;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						byte[] result = null;
						num = (short)52428803;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_83:
				throw new global::System.NullReferenceException();
			}
			}
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x0014627C File Offset: 0x0014447C
		private bool a()
		{
			short num = (short)804847621;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool result;
				byte[] romserialNum;
				switch (num2)
				{
				case 0:
					result = true;
					num = (short)640417795;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1937540508;
					short num3 = num;
					num = (short)83002780;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)383844352;
						if (num != 0)
						{
						}
						this.e = new byte[8];
						global::System.Array.Copy(romserialNum, this.e, 8);
						num = (short)1927282690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					if (this.e[0] == 24)
					{
						num = (short)988217352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = true;
					num = (short)83558413;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return result;
				case 4:
					num = (short)1351548929;
					if (num != 0)
					{
					}
					num = (short)1714487310;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				case 6:
					if (this.g >= 0)
					{
						num = (short)2035286016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 7:
					goto IL_AA;
				case 8:
					this.f = this.a.GetWCC(8U);
					num = (short)1538719756;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					return result;
				case 10:
					if (romserialNum != null)
					{
						num = (short)1999241220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_207;
				case 11:
					this.g = this.a.GetWCC(9U);
					num = (short)1614086150;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (this.f >= 0)
					{
						num = (short)1087635467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 13:
					return result;
				case 14:
					if (romserialNum.Length == 8)
					{
						num = (short)624885761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_207;
				}
				IL_60:
				num = (short)1772093440;
				short num4 = num;
				if (this.a == null)
				{
					num = (short)1629224967;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				result = false;
				romserialNum = this.a.GetROMSerialNum();
				num = (short)585367562;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_207:
				this.e = null;
				this.f = -1;
				this.g = -1;
				num = (short)2118975497;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AA:
			throw new global::System.NullReferenceException();
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x001465A8 File Offset: 0x001447A8
		private bool a(out byte[] A_0, out byte[] A_1, bool A_2)
		{
			short num = (short)1360396288;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_97;
				}
				bool result;
				for (;;)
				{
					IL_28:
					int num4;
					byte[] bytes;
					int num5;
					byte[] bytes2;
					switch (num2)
					{
					case 0:
						num = (short)977797131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						this.f++;
						num = (short)1617952782;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return result;
					case 3:
						goto IL_1FF;
					case 4:
						if (A_2)
						{
							num = (short)1631518721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E7;
					case 5:
						goto IL_1FF;
					case 6:
					{
						num = (short)540953193;
						short num3 = num;
						num = (short)773737065;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B7;
						default:
							num = (short)587988992;
							if (num != 0)
							{
							}
							num = (short)1160052740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						num = (short)1296760845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_313;
					case 9:
						return result;
					case 10:
						this.g++;
						num = (short)2025127957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (this.g >= 0)
						{
							num = (short)2065039378;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 12:
						if (this.f >= 0)
						{
							num = (short)1431240710;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 13:
						if (this.e.Length == 8)
						{
							num = (short)307101716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 14:
						goto IL_3E7;
					case 15:
						A_1 = new byte[8];
						num = (short)96469004;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_B7;
					case 17:
						goto IL_313;
					case 18:
						num = (short)177143833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						result = true;
						num = (short)729743362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						A_0 = new byte[8];
						global::System.Array.Copy(this.e, A_0, 8);
						global::System.Array.Reverse(A_0);
						A_1 = null;
						num = (short)1074003990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_E0;
					case 22:
						if (this.e[0] == 24)
						{
							num = (short)1090125839;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = true;
						num = (short)933167105;
						if (num != 0)
						{
						}
						num = (short)561577993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (num4 >= 8)
						{
							num = (short)958136339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_1[num4] = bytes[num4 - 4];
						num4++;
						num = (short)1557594117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (num5 >= 4)
						{
							num = (short)982319104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_1[num5] = bytes2[num5];
						num5++;
						num = (short)35454984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (A_2)
						{
							num = (short)1809448970;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E0;
					}
					goto IL_97;
					IL_B7:
					if (this.e != null)
					{
						num = (short)818282503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_E0:
					num = (short)546373632;
					short num6 = num;
					bytes = global::System.BitConverter.GetBytes(this.g);
					num4 = 4;
					num = (short)1540096003;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FF:
					num = (short)1564737559;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_313:
					num = (short)812253208;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E7:
					bytes2 = global::System.BitConverter.GetBytes(this.f);
					num5 = 0;
					num = (short)204406801;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_97:
				result = false;
				A_0 = null;
				A_1 = null;
				num = (short)811728912;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x04000794 RID: 1940
		private global::IBtnWrapperLib.MultiBtnWrapper a;

		// Token: 0x04000795 RID: 1941
		private global::SpecialFeatures.Flashport.FlashkeyLib.Flashkey b;

		// Token: 0x04000796 RID: 1942
		private short c;

		// Token: 0x04000797 RID: 1943
		private short d;

		// Token: 0x04000798 RID: 1944
		private byte[] e;

		// Token: 0x04000799 RID: 1945
		private int f;

		// Token: 0x0400079A RID: 1946
		private int g;
	}
}
