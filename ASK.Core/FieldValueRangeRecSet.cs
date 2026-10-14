using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;

namespace ASK.Core
{
	// Token: 0x02000009 RID: 9
	[global::System.Serializable]
	public class FieldValueRangeRecSet : global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Core.AccessFieldValueRange>
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00004C4C File Offset: 0x00002E4C
		public FieldValueRangeRecSet(ushort ownerId)
		{
			this.m_ownerId = ownerId;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004C68 File Offset: 0x00002E68
		internal bool a(global::ASK.Core.FieldValueRangeRecSet A_0)
		{
			short num = (short)1410465792;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_70;
				}
				bool result;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						goto IL_B5;
					case 1:
					{
						uint? num3;
						uint? num4;
						if (!(num3.GetValueOrDefault() == num4.GetValueOrDefault() & num3 != null == (num4 != null)))
						{
							num = (short)226623488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num5;
						num5++;
						num = (short)504627210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_13F;
					case 3:
						goto IL_344;
					case 4:
						IL_B0:
						num = (short)606339083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::ASK.Core.AccessFieldValueRange accessFieldValueRange;
						global::ASK.Core.AccessFieldValueRange accessFieldValueRange2;
						if (accessFieldValueRange.FieldID == accessFieldValueRange2.FieldID)
						{
							num = (short)1221918729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B5;
					}
					case 6:
						if (this.m_ownerId == A_0.m_ownerId)
						{
							num = (short)1538260996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13F;
					case 7:
						goto IL_344;
					case 8:
						goto IL_344;
					case 9:
					{
						global::ASK.Core.AccessFieldValueRange accessFieldValueRange;
						uint? num4 = accessFieldValueRange.Minimum;
						global::ASK.Core.AccessFieldValueRange accessFieldValueRange2;
						uint? num3 = accessFieldValueRange2.Minimum;
						num = (short)1340538895;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_259;
					case 11:
					{
						if (base.Count != A_0.Count)
						{
							num = (short)1419575298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num5 = 0;
						num = (short)1548877824;
						short num6 = num;
						num = (short)891027469;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						int num5;
						if (num5 >= base.Count)
						{
							num = (short)1360396295;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::ASK.Core.AccessFieldValueRange accessFieldValueRange = base.Items[num5];
						global::ASK.Core.AccessFieldValueRange accessFieldValueRange2 = A_0.Items[num5];
						num = (short)1665400837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_259;
					case 14:
					{
						global::ASK.Core.AccessFieldValueRange accessFieldValueRange;
						uint? num3 = accessFieldValueRange.Maximum;
						global::ASK.Core.AccessFieldValueRange accessFieldValueRange2;
						uint? num4 = accessFieldValueRange2.Maximum;
						num = (short)56426497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						uint? num3;
						uint? num4;
						if (num4.GetValueOrDefault() == num3.GetValueOrDefault() & num4 != null == (num3 != null))
						{
							num = (short)1080492046;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B5;
					}
					}
					goto IL_70;
					IL_344:
					num = (short)1031204190;
					short num7 = num;
					num = (short)1473047902;
					switch ((num7 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B0;
					default:
						goto IL_37A;
					}
					IL_B5:
					result = false;
					num = (short)704446472;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13F:
					num = (short)1294467073;
					if (num != 0)
					{
					}
					result = false;
					num = (short)1386741763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_259:
					num = (short)1455685644;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_37A:
				num = (short)1868890112;
				if (num != 0)
				{
				}
				return result;
				IL_70:
				result = true;
				num = (short)1689780230;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005008 File Offset: 0x00003208
		public FieldValueRangeRecSet(global::System.Xml.XmlNode node)
		{
			int a_ = 6;
			base..ctor();
			global::ASK.Core.AccessFieldValueRange accessFieldValueRange = null;
			short num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			for (global::System.Xml.XmlNode xmlNode = node.FirstChild; xmlNode != null; xmlNode = xmlNode.NextSibling)
			{
				string name = xmlNode.Name;
				string innerText = xmlNode.InnerText;
				if (global::ASK.Core.StatusMsg.b("၁╃⡅⽇⽉ɋ㭍㵏", a_) == name)
				{
					num2 = (int)short.Parse(innerText);
					if (num2 <= 0)
					{
						throw new global::System.Exception(global::ASK.Core.StatusMsg.b("ୁ⩃ぅ⥇♉╋⩍灏Q㕓㡕㽗㽙籛ᵝཟᝡ੣ብ䙧", a_));
					}
				}
				if (global::ASK.Core.StatusMsg.b("сⵃ⍅⑇⹉ᡋ⽍㝏", a_) == name)
				{
					num = short.Parse(innerText);
					this.m_ownerId = (ushort)num;
				}
				if (global::ASK.Core.StatusMsg.b("ف╃㉅⥇݉╋⁍", a_) == name)
				{
					uint value = uint.Parse(innerText);
					accessFieldValueRange = new global::ASK.Core.AccessFieldValueRange();
					accessFieldValueRange.FieldID = (int)num;
					accessFieldValueRange.Minimum = new uint?(value);
					num3++;
				}
				if (global::ASK.Core.StatusMsg.b("ف╃㉅⥇݉ⵋ㙍", a_) == name)
				{
					uint value2 = uint.Parse(innerText);
					if (accessFieldValueRange != null)
					{
						accessFieldValueRange.Maximum = new uint?(value2);
						uint? minimum = accessFieldValueRange.Minimum;
						uint? maximum = accessFieldValueRange.Maximum;
						if (minimum.GetValueOrDefault() > maximum.GetValueOrDefault() & (minimum != null & maximum != null))
						{
							throw new global::System.Exception(global::ASK.Core.StatusMsg.b("сⵃ⍅⑇⹉ᩋ⽍㱏❑ㅓѕ㥗㑙㭛㭝㉟ݡݣ㕥൧ṩ噫乭≯፱ᩳᅵᵷ婹㥻౽ꚅꖇꪉ솋ﺏﮑ望ﮕ벛ﶝ솟첡쪣즥\udca7誩캫쮭邯\udeb1톳억쮷骹좻횽ꆿ곁诅꧇닉ꗋꏍꗏ뿑", a_));
						}
						base.Add(accessFieldValueRange);
					}
					accessFieldValueRange = null;
					num4++;
				}
			}
			if (num2 != num3)
			{
				throw new global::System.Exception(global::ASK.Core.StatusMsg.b("сⵃ⍅⑇⹉ᩋ⽍㱏❑ㅓѕ㥗㑙㭛㭝㉟ݡݣ㕥൧ṩ噫乭≯፱ᩳᅵᵷ婹㥻౽ꚅꖇꪉ\ude8bﺏ햕肟쮡힣蚥욧얩\ud8ab躭햯쎱솳ힵ풷骹좻톽蛁ꗃ닅꧇蟉ꗋꃍ", a_));
			}
			if (num2 != num4)
			{
				throw new global::System.Exception(global::ASK.Core.StatusMsg.b("сⵃ⍅⑇⹉ᩋ⽍㱏❑ㅓѕ㥗㑙㭛㭝㉟ݡݣ㕥൧ṩ噫乭≯፱ᩳᅵᵷ婹㥻౽ꚅꖇꪉ\ude8bﺏ햕肟쮡힣蚥욧얩\ud8ab躭햯쎱솳ힵ풷骹좻톽蛁ꗃ닅꧇蟉귋뛍", a_));
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000051FC File Offset: 0x000033FC
		internal string a(int A_0)
		{
			int a_ = 7;
			short num = (short)1828585472;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4D;
				}
				int num3;
				string text;
				string text2;
				for (;;)
				{
					IL_32:
					global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessFieldValueRange> enumerator;
					string str;
					switch (num2)
					{
					case 0:
						goto IL_404;
					case 1:
						if (num3 >= A_0)
						{
							num = (short)1216479235;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text += global::ASK.Core.StatusMsg.b("䩂", a_);
						num3++;
						num = (short)1463418880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_404;
					case 3:
						num = (short)1910243329;
						if (num != 0)
						{
						}
						goto IL_2B1;
					case 4:
						try
						{
							num = (short)1170604034;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)521994243;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									num = (short)1068788956;
									short num4 = num;
									num = (short)1273457884;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_DF;
									default:
										num = (short)833486848;
										if (num != 0)
										{
										}
										break;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_B9;
									}
									continue;
								case 3:
									goto IL_23E;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										goto IL_DF;
									}
									global::ASK.Core.AccessFieldValueRange accessFieldValueRange = enumerator.Current;
									uint? minimum = accessFieldValueRange.Minimum;
									uint? maximum = accessFieldValueRange.Maximum;
									text2 += text;
									text2 += global::ASK.Core.StatusMsg.b("䩂祄͆⡈㽊ⱌɎ㡐㵒歔", a_);
									str = string.Format(global::ASK.Core.StatusMsg.b("㡂畄㩆", a_), minimum);
									text2 += str;
									text2 += global::ASK.Core.StatusMsg.b("罂橄͆⡈㽊ⱌɎ㡐㵒歔", a_);
									text2 += text;
									text2 += global::ASK.Core.StatusMsg.b("䩂祄͆⡈㽊ⱌɎぐ⭒歔", a_);
									str = string.Format(global::ASK.Core.StatusMsg.b("㡂畄㩆", a_), maximum);
									text2 += str;
									text2 += global::ASK.Core.StatusMsg.b("罂橄͆⡈㽊ⱌɎぐ⭒歔", a_);
									num = (short)590807041;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_BE:
								num = (short)1716322308;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B9:
								goto IL_BE;
								IL_DF:
								num = (short)977338368;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_23E:
							goto IL_467;
						}
						finally
						{
							num = (short)2045902850;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)299892737;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2AE;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_276;
									}
									continue;
								}
								IL_276:
								if (enumerator == null)
								{
									break;
								}
								num = (short)562102272;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2AE:;
						}
						goto IL_2B1;
					}
					goto IL_4D;
					IL_2B1:
					num = (short)607977472;
					short num5 = num;
					text2 += text;
					text2 += global::ASK.Core.StatusMsg.b("罂ॄ⹆⑈≊㥌⩎㕐ᝒ㑔⍖㡘ग़㡜㱞๠ᅢŤ奦捨", a_);
					text2 += text;
					text2 += global::ASK.Core.StatusMsg.b("䩂祄ņ⁈⹊⅌⭎Ր㉒㉔楖", a_);
					str = string.Format(global::ASK.Core.StatusMsg.b("㡂畄㩆", a_), this.m_ownerId);
					text2 += str;
					text2 += global::ASK.Core.StatusMsg.b("罂橄ņ⁈⹊⅌⭎Ր㉒㉔楖", a_);
					int count = base.Count;
					text2 += text;
					text2 += global::ASK.Core.StatusMsg.b("䩂祄ᕆ⡈╊⩌⩎ὐ♒㡔楖", a_);
					str = string.Format(global::ASK.Core.StatusMsg.b("㡂畄㩆", a_), count);
					text2 += str;
					text2 += global::ASK.Core.StatusMsg.b("罂橄ᕆ⡈╊⩌⩎ὐ♒㡔楖", a_);
					enumerator = base.GetEnumerator();
					num = (short)1412759556;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_404:
					num = (short)1132920833;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_467:
				text2 += text;
				text2 += global::ASK.Core.StatusMsg.b("罂橄୆⁈♊⑌㭎㑐㝒ᅔ㙖ⵘ㩚ཛྷ㩞ɠౢᝤͦ坨慪", a_);
				return text2;
				IL_4D:
				text2 = "";
				text = "";
				num3 = 0;
				num = (short)1611202562;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000056AC File Offset: 0x000038AC
		internal byte[] PackedData
		{
			get
			{
				short num = (short)1452146688;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)1070923777;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					global::System.Collections.ArrayList arrayList;
					int count;
					for (;;)
					{
						IL_50:
						global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessFieldValueRange> enumerator;
						byte b;
						switch (num2)
						{
						case 0:
							goto IL_4DC;
						case 1:
							try
							{
								num = (short)1697447938;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									uint? num4;
									uint? num3;
									switch (num2)
									{
									case 0:
										num = (short)404488200;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										num3 = num4;
										goto IL_396;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_F5;
										}
										continue;
									case 3:
									{
										if (enumerator.MoveNext())
										{
											num = (short)106430471;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1057093626;
										short num5 = num;
										num = (short)329381882;
										switch ((num5 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_3AE;
										default:
											num = (short)428998656;
											if (num != 0)
											{
											}
											num = (short)675807232;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
									{
										uint? num6;
										uint num7;
										num3 = new uint?(num6.GetValueOrDefault() & num7);
										goto IL_396;
									}
									case 5:
										num4 = null;
										num = (short)358285313;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
									{
										global::ASK.Core.AccessFieldValueRange accessFieldValueRange = enumerator.Current;
										uint? minimum = accessFieldValueRange.Minimum;
										uint? maximum = accessFieldValueRange.Maximum;
										uint? num6 = minimum;
										uint? num8;
										if (num6 == null)
										{
											num4 = null;
											num8 = num4;
										}
										else
										{
											num8 = new uint?(num6.GetValueOrDefault() >> 24);
										}
										num4 = num8;
										b = (byte)num4.Value;
										arrayList.Add(b);
										num6 = minimum;
										uint? num9;
										if (num6 == null)
										{
											num4 = null;
											num9 = num4;
										}
										else
										{
											num9 = new uint?(num6.GetValueOrDefault() >> 16);
										}
										num4 = num9;
										b = (byte)num4.Value;
										arrayList.Add(b);
										num6 = minimum;
										uint? num10;
										if (num6 == null)
										{
											num4 = null;
											num10 = num4;
										}
										else
										{
											num10 = new uint?(num6.GetValueOrDefault() >> 8);
										}
										num4 = num10;
										b = (byte)num4.Value;
										arrayList.Add(b);
										num6 = minimum;
										uint num7 = 255U;
										uint? num11;
										if (num6 == null)
										{
											num4 = null;
											num11 = num4;
										}
										else
										{
											num11 = new uint?(num6.GetValueOrDefault() & num7);
										}
										num4 = num11;
										b = (byte)num4.Value;
										arrayList.Add(b);
										num6 = maximum;
										uint? num12;
										if (num6 == null)
										{
											num4 = null;
											num12 = num4;
										}
										else
										{
											num12 = new uint?(num6.GetValueOrDefault() >> 24);
										}
										num4 = num12;
										b = (byte)num4.Value;
										arrayList.Add(b);
										num6 = maximum;
										uint? num13;
										if (num6 == null)
										{
											num4 = null;
											num13 = num4;
										}
										else
										{
											num13 = new uint?(num6.GetValueOrDefault() >> 16);
										}
										num4 = num13;
										b = (byte)num4.Value;
										arrayList.Add(b);
										num6 = maximum;
										uint? num14;
										if (num6 == null)
										{
											num4 = null;
											num14 = num4;
										}
										else
										{
											num14 = new uint?(num6.GetValueOrDefault() >> 8);
										}
										num4 = num14;
										b = (byte)num4.Value;
										arrayList.Add(b);
										num6 = maximum;
										num7 = 255U;
										num = (short)935264265;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
										goto IL_46A;
									case 9:
									{
										uint? num6;
										if (num6 == null)
										{
											num = (short)1124335621;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)966131716;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									goto IL_F5;
									IL_3AE:
									num = (short)1619066886;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_396:
									num4 = num3;
									b = (byte)num4.Value;
									arrayList.Add(b);
									goto IL_3AE;
									IL_3C8:
									num = (short)1523580931;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_F5:
									goto IL_3C8;
								}
								IL_46A:
								goto IL_554;
							}
							finally
							{
								num = (short)2117009410;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										num = (short)1888288769;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_4D9;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_4A3;
										}
										continue;
									}
									IL_4A3:
									if (enumerator == null)
									{
										break;
									}
									num = (short)627965952;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_4D9:;
							}
							goto IL_4DC;
						case 2:
							if (count > 0)
							{
								num = (short)556072960;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_554;
						}
						goto IL_63;
						IL_4DC:
						b = (byte)this.m_ownerId;
						arrayList.Add(b);
						arrayList.Add((byte)count);
						enumerator = base.Items.GetEnumerator();
						num = (short)1287979008;
						short num15 = num;
						num = (short)586678273;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_554:
					return (byte[])arrayList.ToArray(typeof(byte));
					IL_63:
					arrayList = new global::System.Collections.ArrayList();
					count = base.Count;
					num = (short)577044482;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_50;
				}
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00005C40 File Offset: 0x00003E40
		public ushort OwnerID
		{
			get
			{
				short num = (short)142214718;
				short num2 = num;
				num = (short)1442121278;
				switch (num2 == num)
				{
				}
				num = (short)1988362240;
				short num3 = num;
				num = (short)581304321;
				if (num != 0)
				{
				}
				num = (short)1620508672;
				if (num != 0)
				{
				}
				return this.m_ownerId;
			}
		}

		// Token: 0x04000011 RID: 17
		private ushort m_ownerId;
	}
}
