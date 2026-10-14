using System;
using System.Collections;
using System.Collections.Generic;
using AcpCommonLib;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000D3 RID: 211
	public class Flashcode : global::System.Collections.Generic.ICollection<global::SpecialFeatures.Flashport.FlashRadio.Option>, global::System.Collections.Generic.IEnumerable<global::SpecialFeatures.Flashport.FlashRadio.Option>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000CE9 RID: 3305 RVA: 0x00002F89 File Offset: 0x00001189
		public Flashcode()
		{
			this.b = false;
			this.a = new global::System.Collections.Generic.List<global::SpecialFeatures.Flashport.FlashRadio.Option>();
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x00002FA3 File Offset: 0x000011A3
		internal Flashcode(bool ordered)
		{
			this.b = ordered;
			this.a = new global::System.Collections.Generic.List<global::SpecialFeatures.Flashport.FlashRadio.Option>();
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x00109538 File Offset: 0x00107738
		public void Add(global::SpecialFeatures.Flashport.FlashRadio.Option item)
		{
			int a_ = 18;
			short num = (short)1761280001;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num4;
				global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator;
				switch (num2)
				{
				case 0:
					if (!this.b)
					{
						num = (short)744095749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_378;
				case 1:
					num = (short)1997602817;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_70;
					}
					continue;
				case 2:
					if (this.a.Count == 0)
					{
						num = (short)2004811780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8C;
				case 3:
					goto IL_87;
				case 4:
					goto IL_3B9;
				case 5:
				{
					num = (short)1623232799;
					short num3 = num;
					num = (short)1097306399;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8C;
					default:
						goto IL_15B;
					}
					break;
				}
				case 6:
					try
					{
						num = (short)581828612;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								this.a.Add(item);
								num = (short)266207239;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								this.a.Insert(num4, item);
								num = (short)1075183622;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)411893769;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::SpecialFeatures.Flashport.FlashRadio.Option option = enumerator.Current;
								num = (short)82640901;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_30B;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_1D7;
								}
								continue;
							case 5:
							{
								global::SpecialFeatures.Flashport.FlashRadio.Option option;
								if (item.DisplayOrder <= option.DisplayOrder)
								{
									num = (short)751304705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num4++;
								num = (short)1998454792;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								goto IL_1FB;
							case 7:
								goto IL_25D;
							case 8:
								if (num4 == this.a.Count)
								{
									num = (short)1419575296;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 9:
								num = (short)1597308931;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_200:
							num = (short)475398146;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1D7:
							goto IL_200;
						}
						IL_1FB:
						IL_25D:
						IL_30B:
						return;
					}
					finally
					{
						num = (short)859635712;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_340;
								}
								continue;
							case 1:
								goto IL_375;
							case 2:
								enumerator.Dispose();
								num = (short)1999503361;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_340:
							if (enumerator == null)
							{
								break;
							}
							num = (short)286720002;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_375:;
					}
					goto IL_378;
				}
				IL_70:
				if (item == null)
				{
					num = (short)1769144323;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)2036400128;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8C:
				num4 = 0;
				enumerator = this.a.GetEnumerator();
				num = (short)1454768128;
				short num5 = num;
				num = (short)872022022;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_378:
				num = (short)222167042;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_87:
			throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﲔﲘ", a_));
			IL_15B:
			num = (short)1857355776;
			if (num != 0)
			{
			}
			this.a.Add(item);
			return;
			IL_3B9:
			this.a.Add(item);
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x0010992C File Offset: 0x00107B2C
		public void Clear()
		{
			short num = (short)2140581674;
			short num2 = num;
			num = (short)1791536938;
			switch (num2 == num)
			{
			}
			num = (short)274137088;
			short num3 = num;
			num = (short)1400111105;
			if (num != 0)
			{
			}
			num = (short)1207828480;
			if (num != 0)
			{
			}
			this.a.Clear();
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x001099E4 File Offset: 0x00107BE4
		public bool Contains(global::SpecialFeatures.Flashport.FlashRadio.Option item)
		{
			int a_ = 1;
			short num = (short)470588464;
			short num2 = num;
			num = (short)1792646192;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1612382208;
				short num3 = num;
				num = (short)272367616;
				if (num != 0)
				{
				}
				num = (short)944832513;
				if (num != 0)
				{
				}
				if (item == null)
				{
					throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
				}
				break;
			}
			}
			return this.a.Contains(item);
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00109ABC File Offset: 0x00107CBC
		public global::SpecialFeatures.Flashport.FlashRadio.Option GetOptionByName(string name)
		{
			global::SpecialFeatures.Flashport.FlashRadio.Option result;
			short num;
			for (;;)
			{
				result = null;
				global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator = this.a.GetEnumerator();
				try
				{
					num = (short)885456897;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)769392645;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::SpecialFeatures.Flashport.FlashRadio.Option option = enumerator.Current;
							num = (short)759169027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_50;
							}
							continue;
						case 2:
							goto IL_10A;
						case 3:
						{
							global::SpecialFeatures.Flashport.FlashRadio.Option option;
							if (option.Name == name)
							{
								num = (short)2010447878;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							goto IL_126;
						case 5:
							num = (short)550043649;
							if (num != 0)
							{
							}
							num = (short)36765700;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::SpecialFeatures.Flashport.FlashRadio.Option option;
							result = option;
							num = (short)1332674562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_91:
						num = (short)894238720;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_50:
						goto IL_91;
					}
					IL_10A:
					IL_126:;
				}
				finally
				{
					num = (short)1383399424;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_159;
							}
							continue;
						case 1:
							goto IL_18D;
						case 2:
							enumerator.Dispose();
							num = (short)1795686401;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_159:
						if (enumerator == null)
						{
							break;
						}
						num = (short)450166786;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_18D:;
				}
				num = (short)734358597;
				short num3 = num;
				num = (short)1965911109;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					goto IL_1EE;
				}
				break;
			}
			num = (short)1354891264;
			short num4 = num;
			IL_1EE:
			num = (short)253493248;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00109CEC File Offset: 0x00107EEC
		public global::SpecialFeatures.Flashport.FlashRadio.Option GetOptionByPosition(int position)
		{
			global::SpecialFeatures.Flashport.FlashRadio.Option result;
			short num;
			for (;;)
			{
				result = null;
				global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator = this.a.GetEnumerator();
				try
				{
					num = (short)1628831745;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1109393413;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::SpecialFeatures.Flashport.FlashRadio.Option option = enumerator.Current;
							num = (short)2031619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_50;
							}
							continue;
						case 2:
							goto IL_DD;
						case 3:
						{
							global::SpecialFeatures.Flashport.FlashRadio.Option option;
							if (option.Position == position)
							{
								num = (short)224788486;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							goto IL_F9;
						case 5:
							num = (short)324861956;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::SpecialFeatures.Flashport.FlashRadio.Option option;
							result = option;
							num = (short)198508546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_8D:
						num = (short)1057685504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_50:
						goto IL_8D;
					}
					IL_DD:
					IL_F9:;
				}
				finally
				{
					num = (short)17039360;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_12C;
							}
							continue;
						case 1:
							goto IL_160;
						case 2:
							enumerator.Dispose();
							num = (short)1646264321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_12C:
						if (enumerator == null)
						{
							break;
						}
						num = (short)498532354;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_160:;
				}
				num = (short)1483226948;
				short num3 = num;
				num = (short)1308770116;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_197;
				}
			}
			IL_197:
			num = (short)962002944;
			short num4 = num;
			num = (short)1986199553;
			if (num != 0)
			{
			}
			num = (short)350420992;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00109F0C File Offset: 0x0010810C
		public global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> GetOptionsByPosition(int position)
		{
			short num = (short)941937341;
			short num2 = num;
			num = (short)474993341;
			int num3;
			global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator;
			global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> list;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B7:
				try
				{
					num = (short)1158807553;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)515899397;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::SpecialFeatures.Flashport.FlashRadio.Option option = enumerator.Current;
							num = (short)2008612867;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_133;
							}
							continue;
						case 3:
						{
							global::SpecialFeatures.Flashport.FlashRadio.Option option;
							if (option.Position == position)
							{
								num = (short)744161286;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							goto IL_1DE;
						case 5:
							num = (short)1688862724;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::SpecialFeatures.Flashport.FlashRadio.Option option;
							list.Add(option);
							num = (short)1894055938;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_171:
						num = (short)1089601536;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_133:
						goto IL_171;
					}
					IL_1DE:
					goto IL_B9;
				}
				finally
				{
					num = (short)513867776;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_214;
							}
							continue;
						case 1:
							goto IL_249;
						case 2:
							enumerator.Dispose();
							num = (short)878510081;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_214:
						if (enumerator == null)
						{
							break;
						}
						num = (short)127664130;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_249:;
				}
				goto IL_24C;
				IL_B9:
				num = (short)1995440131;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1659764737;
				if (num != 0)
				{
				}
				num = (short)829685760;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_91;
				}
				break;
			}
			for (;;)
			{
				IL_7B:
				switch (num3)
				{
				case 0:
					goto IL_B7;
				case 1:
					return list;
				case 2:
					goto IL_EE;
				case 3:
					if (list.Count == 0)
					{
						num = (short)1639317506;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return list;
				}
				goto IL_91;
			}
			IL_EE:
			goto IL_24C;
			IL_91:
			list = new global::System.Collections.Generic.List<global::SpecialFeatures.Flashport.FlashRadio.Option>();
			enumerator = this.a.GetEnumerator();
			num = (short)107675648;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7B;
			IL_24C:
			list = null;
			num = (short)1233256448;
			short num4 = num;
			num = (short)1314652161;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7B;
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x0010A1BC File Offset: 0x001083BC
		public global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> GetOptionsByOffset(int bytePos, int bitPos)
		{
			short num = (short)861967284;
			short num2 = num;
			num = (short)1614582708;
			int num3;
			global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> list;
			global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_91:
				try
				{
					num = (short)1255473155;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							global::SpecialFeatures.Flashport.FlashRadio.Option option;
							list.Add(option);
							num = (short)1234305025;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num = (short)898236423;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_13E;
							}
							continue;
						case 4:
							num = (short)472186886;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::SpecialFeatures.Flashport.FlashRadio.Option option;
							if (option.ByteOffset == bytePos)
							{
								num = (short)1872560130;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							goto IL_222;
						case 7:
						{
							global::SpecialFeatures.Flashport.FlashRadio.Option option;
							if (option.BitOffset == bitPos)
							{
								num = (short)868941824;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1564278788;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::SpecialFeatures.Flashport.FlashRadio.Option option = enumerator.Current;
							num = (short)2073952261;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_17B:
						num = (short)121372680;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_13E:
						goto IL_17B;
					}
					IL_222:
					goto IL_93;
				}
				finally
				{
					num = (short)1701249024;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_258;
							}
							continue;
						case 1:
							goto IL_28B;
						case 2:
							enumerator.Dispose();
							num = (short)1244856321;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_258:
						if (enumerator == null)
						{
							break;
						}
						num = (short)365625346;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_28B:;
				}
				goto IL_28E;
				IL_93:
				num = (short)1139081217;
				if (num != 0)
				{
				}
				num = (short)321716227;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)953810944;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6B;
				}
				break;
			}
			for (;;)
			{
				IL_55:
				switch (num3)
				{
				case 0:
					goto IL_91;
				case 1:
					return list;
				case 2:
					goto IL_F0;
				case 3:
					if (list.Count == 0)
					{
						num = (short)1449197570;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return list;
				}
				goto IL_6B;
			}
			IL_F0:
			goto IL_28E;
			IL_6B:
			list = new global::System.Collections.Generic.List<global::SpecialFeatures.Flashport.FlashRadio.Option>();
			enumerator = this.a.GetEnumerator();
			num = (short)1954611200;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_55;
			IL_28E:
			list = null;
			num = (short)1469841408;
			short num4 = num;
			num = (short)2085421057;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_55;
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x0010A4BC File Offset: 0x001086BC
		public global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> GetOptionsByField(global::AcpCommonLib.IAcpField field)
		{
			short num = (short)493748224;
			short num2 = num;
			num = (short)661751279;
			short num3 = num;
			num = (short)1493140975;
			int num4;
			global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator;
			global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> list;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_BF:
				try
				{
					num = (short)223019009;
					if (num != 0)
					{
					}
					num = (short)2119434241;
					num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2052784133;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::SpecialFeatures.Flashport.FlashRadio.Option option = enumerator.Current;
							num = (short)1828651011;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_163;
							}
							continue;
						case 3:
						{
							global::SpecialFeatures.Flashport.FlashRadio.Option option;
							if (option.DbField == field)
							{
								num = (short)1527644166;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							goto IL_20B;
						case 5:
							num = (short)1007484932;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::SpecialFeatures.Flashport.FlashRadio.Option option;
							list.Add(option);
							num = (short)290324482;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_19F:
						num = (short)118882304;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_163:
						goto IL_19F;
					}
					IL_20B:
					goto IL_C1;
				}
				finally
				{
					num = (short)1100480512;
					num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_240;
							}
							continue;
						case 1:
							goto IL_273;
						case 2:
							enumerator.Dispose();
							num = (short)498663425;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_240:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1092157442;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_273:;
				}
				goto IL_276;
				IL_C1:
				num = (short)315752451;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1577189376;
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
			for (;;)
			{
				IL_82:
				switch (num4)
				{
				case 0:
					goto IL_BF;
				case 1:
					return list;
				case 2:
					goto IL_F5;
				case 3:
					if (list.Count == 0)
					{
						num = (short)919601154;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return list;
				}
				goto IL_98;
			}
			IL_F5:
			goto IL_276;
			IL_98:
			list = new global::System.Collections.Generic.List<global::SpecialFeatures.Flashport.FlashRadio.Option>();
			enumerator = this.a.GetEnumerator();
			num = (short)765001728;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_82;
			IL_276:
			list = null;
			num = (short)2097741825;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_82;
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x0010A778 File Offset: 0x00108978
		public global::SpecialFeatures.Flashport.FlashRadio.Option GetOptionByField(global::AcpCommonLib.IAcpField field)
		{
			short num = (short)444997949;
			short num2 = num;
			num = (short)1144660285;
			global::SpecialFeatures.Flashport.FlashRadio.Option result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			case 1:
				break;
			default:
			{
				num = (short)2104557568;
				short num3 = num;
				break;
			}
			}
			num = (short)1994719232;
			if (num != 0)
			{
			}
			num = (short)2023292929;
			if (num != 0)
			{
			}
			result = null;
			global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator = this.a.GetEnumerator();
			try
			{
				num = (short)1596194818;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
					{
						global::SpecialFeatures.Flashport.FlashRadio.Option option;
						if (option.DbField == field)
						{
							num = (short)638124035;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						num = (short)1226637316;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_EE;
						}
						continue;
					case 3:
					{
						global::SpecialFeatures.Flashport.FlashRadio.Option option;
						result = option;
						num = (short)191037446;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_199;
					case 5:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)2000879617;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Flashport.FlashRadio.Option option = enumerator.Current;
						num = (short)694812672;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_17D;
					}
					IL_12C:
					num = (short)1704787973;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_EE:
					goto IL_12C;
				}
				IL_17D:
				IL_199:;
			}
			finally
			{
				num = (short)783613952;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_1CC;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)25690114;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_201;
					}
					IL_1CC:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1945108481;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_201:;
			}
			return result;
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x0010A99C File Offset: 0x00108B9C
		public int GetOptionBitPosition(string optName)
		{
			short num = (short)1364983808;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_46;
			}
			int result;
			for (;;)
			{
				IL_34:
				int num3;
				switch (num3)
				{
				case 0:
					goto IL_B2;
				case 1:
				{
					global::SpecialFeatures.Flashport.FlashRadio.Option optionByName;
					result = optionByName.BitOffset;
					num = (short)1843331074;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_114;
				}
				goto IL_46;
			}
			IL_114:
			return result;
			IL_46:
			num = (short)1633402009;
			short num4 = num;
			num = (short)756726937;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_B2:
				num = (short)1387855873;
				if (num != 0)
				{
				}
				global::SpecialFeatures.Flashport.FlashRadio.Option optionByName;
				if (optionByName != null)
				{
					num = (short)1874657281;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_34;
				}
				break;
			}
			default:
			{
				num = (short)1382612992;
				if (num != 0)
				{
				}
				result = -1;
				global::SpecialFeatures.Flashport.FlashRadio.Option optionByName = this.GetOptionByName(optName);
				num = (short)1612185600;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_34;
			}
			}
			return result;
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x0010AAC0 File Offset: 0x00108CC0
		public int GetOptionBytePosition(string optName)
		{
			short num = (short)230621184;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			int result;
			for (;;)
			{
				IL_33:
				int num3;
				switch (num3)
				{
				case 0:
					goto IL_B0;
				case 1:
				{
					global::SpecialFeatures.Flashport.FlashRadio.Option optionByName;
					result = optionByName.ByteOffset;
					num = (short)718798850;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_EB;
				}
				goto IL_45;
			}
			IL_EB:
			goto IL_ED;
			IL_45:
			num = (short)1137394167;
			short num4 = num;
			num = (short)332153335;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_B0:
				global::SpecialFeatures.Flashport.FlashRadio.Option optionByName;
				if (optionByName != null)
				{
					num = (short)189530113;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_33;
				}
				break;
			}
			default:
			{
				num = (short)1315700736;
				if (num != 0)
				{
				}
				result = -1;
				global::SpecialFeatures.Flashport.FlashRadio.Option optionByName = this.GetOptionByName(optName);
				num = (short)1242955776;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}
			}
			IL_ED:
			num = (short)845217793;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x0010ABE4 File Offset: 0x00108DE4
		public int GetOptionMask(string optName)
		{
			short num = (short)308805632;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			int result;
			for (;;)
			{
				IL_33:
				int num3;
				switch (num3)
				{
				case 0:
					goto IL_B0;
				case 1:
				{
					global::SpecialFeatures.Flashport.FlashRadio.Option optionByName;
					result = optionByName.Mask.Mask;
					num = (short)627245058;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_F1;
				}
				goto IL_45;
			}
			IL_F1:
			num = (short)1622540289;
			if (num != 0)
			{
			}
			return result;
			IL_45:
			num = (short)115824320;
			short num4 = num;
			num = (short)1466062528;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_B0:
				global::SpecialFeatures.Flashport.FlashRadio.Option optionByName;
				if (optionByName != null)
				{
					num = (short)462946305;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_33;
				}
				break;
			}
			default:
			{
				num = (short)1791754240;
				if (num != 0)
				{
				}
				result = -1;
				global::SpecialFeatures.Flashport.FlashRadio.Option optionByName = this.GetOptionByName(optName);
				num = (short)1383137280;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}
			}
			return result;
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x0010AD10 File Offset: 0x00108F10
		public void CopyTo(global::SpecialFeatures.Flashport.FlashRadio.Option[] array, int arrayIndex)
		{
			short num = (short)1674706944;
			short num2 = num;
			num = (short)1059591606;
			short num3 = num;
			num = (short)980096438;
			switch (num3 == num)
			{
			}
			num = (short)1605238784;
			if (num != 0)
			{
			}
			num = (short)1630797825;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x0010ADC0 File Offset: 0x00108FC0
		public int Count
		{
			get
			{
				short num = (short)1988689920;
				short num2 = num;
				num = (short)570258502;
				short num3 = num;
				num = (short)2080404550;
				switch (num3 == num)
				{
				}
				num = (short)1781268480;
				if (num != 0)
				{
				}
				num = (short)1707737089;
				if (num != 0)
				{
				}
				return this.a.Count;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x0010AE74 File Offset: 0x00109074
		public bool IsReadOnly
		{
			get
			{
				short num = (short)935002112;
				short num2 = num;
				num = (short)249298945;
				if (num != 0)
				{
				}
				num = (short)716251818;
				short num3 = num;
				num = (short)2040603306;
				switch (num3 == num)
				{
				}
				num = (short)1166802944;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x0010AF20 File Offset: 0x00109120
		public bool Remove(global::SpecialFeatures.Flashport.FlashRadio.Option item)
		{
			int a_ = 19;
			short num = (short)819789825;
			if (num != 0)
			{
			}
			num = (short)1143734272;
			short num2 = num;
			num = (short)961460804;
			short num3 = num;
			num = (short)1952234052;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1167654912;
				if (num != 0)
				{
				}
				if (item != null)
				{
					return this.a.Remove(item);
				}
				break;
			}
			throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾕﾙ", a_));
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x0010AFF4 File Offset: 0x001091F4
		public global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> GetEnumerator()
		{
			short num = (short)2022834176;
			short num2 = num;
			num = (short)1529226573;
			short num3 = num;
			num = (short)2114856269;
			switch (num3 == num)
			{
			}
			num = (short)2012741633;
			if (num != 0)
			{
			}
			num = (short)20643840;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Flashport.FlashRadio.Flashcode.<GetEnumerator>d__22 <GetEnumerator>d__ = new global::SpecialFeatures.Flashport.FlashRadio.Flashcode.<GetEnumerator>d__22(0);
			<GetEnumerator>d__.<>4__this = this;
			return <GetEnumerator>d__;
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x0010B0A8 File Offset: 0x001092A8
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			short num = (short)156499968;
			short num2 = num;
			num = (short)1717957068;
			short num3 = num;
			num = (short)2062741964;
			switch (num3 == num)
			{
			}
			num = (short)91815937;
			if (num != 0)
			{
			}
			num = (short)1332281344;
			if (num != 0)
			{
			}
			return this.GetEnumerator();
		}

		// Token: 0x0400063C RID: 1596
		private global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> a;

		// Token: 0x0400063D RID: 1597
		private bool b;
	}
}
