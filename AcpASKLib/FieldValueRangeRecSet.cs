using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;

namespace AcpASKLib
{
	// Token: 0x0200000D RID: 13
	[global::System.Serializable]
	public class FieldValueRangeRecSet : global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.AccessFieldValueRange>
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00004FB4 File Offset: 0x000031B4
		public FieldValueRangeRecSet(ushort ownerId)
		{
			this.m_ownerId = ownerId;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004FD0 File Offset: 0x000031D0
		internal bool a(global::AcpASKLib.FieldValueRangeRecSet A_0)
		{
			short num = (short)173998080;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				bool result;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						return result;
					case 1:
					{
						int num3;
						if (num3 >= base.Count)
						{
							num = (short)367919104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpASKLib.AccessFieldValueRange accessFieldValueRange = base.Items[num3];
						global::AcpASKLib.AccessFieldValueRange accessFieldValueRange2 = A_0.Items[num3];
						num = (short)1357250569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::AcpASKLib.AccessFieldValueRange accessFieldValueRange;
						uint? num4 = accessFieldValueRange.Minimum;
						global::AcpASKLib.AccessFieldValueRange accessFieldValueRange2;
						uint? num5 = accessFieldValueRange2.Minimum;
						num = (short)1758658561;
						if (num != 0)
						{
						}
						num = (short)275644431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::AcpASKLib.AccessFieldValueRange accessFieldValueRange;
						uint? num5 = accessFieldValueRange.Maximum;
						global::AcpASKLib.AccessFieldValueRange accessFieldValueRange2;
						uint? num4 = accessFieldValueRange2.Maximum;
						num = (short)844759046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_118;
					case 5:
						return result;
					case 6:
					{
						uint? num4;
						uint? num5;
						if (!(num5.GetValueOrDefault() == num4.GetValueOrDefault() & num5 != null == (num4 != null)))
						{
							num = (short)985464839;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num3;
						num3++;
						num = (short)1150484494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_FE;
					case 8:
						goto IL_2D1;
					case 9:
					{
						global::AcpASKLib.AccessFieldValueRange accessFieldValueRange;
						global::AcpASKLib.AccessFieldValueRange accessFieldValueRange2;
						if (accessFieldValueRange.FieldID == accessFieldValueRange2.FieldID)
						{
							num = (short)1347158018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FE;
					}
					case 10:
					{
						num = (short)882350838;
						short num6 = num;
						num = (short)291085046;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2D1;
						default:
							num = (short)1625227264;
							if (num != 0)
							{
							}
							if (this.m_ownerId == A_0.m_ownerId)
							{
								num = (short)1060962315;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1DC;
						}
						break;
					}
					case 11:
						num = (short)689569805;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_1DC;
					case 13:
					{
						if (base.Count != A_0.Count)
						{
							num = (short)27066380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num3 = 0;
						num = (short)369950728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_2D1;
					case 15:
					{
						uint? num4;
						uint? num5;
						if (num4.GetValueOrDefault() == num5.GetValueOrDefault() & num4 != null == (num5 != null))
						{
							num = (short)812974083;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FE;
					}
					}
					goto IL_6E;
					IL_FE:
					result = false;
					num = (short)660996100;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DC:
					result = false;
					num = (short)958136325;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D1:
					num = (short)1502216193;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_118:
				num = (short)38273024;
				short num7 = num;
				return result;
				IL_6E:
				result = true;
				num = (short)1138229258;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005374 File Offset: 0x00003574
		public FieldValueRangeRecSet(global::System.Xml.XmlNode node)
		{
			int a_ = 7;
			base..ctor();
			global::AcpASKLib.AccessFieldValueRange accessFieldValueRange = null;
			short num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			for (global::System.Xml.XmlNode xmlNode = node.FirstChild; xmlNode != null; xmlNode = xmlNode.NextSibling)
			{
				string name = xmlNode.Name;
				string innerText = xmlNode.InnerText;
				if (global::AcpASKLib.SystemKeyLoadedEventArgs.b("㙣ݥ٧൩५⁭կά", a_) == name)
				{
					num2 = (int)short.Parse(innerText);
					if (num2 <= 0)
					{
						throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ⵣࡥṧ୩kݭᑯ剱♳᝵ᙷᵹ᥻幽썿ﲇꒉ", a_));
					}
				}
				if (global::AcpASKLib.SystemKeyLoadedEventArgs.b("≣ཥ൧٩࡫㩭ᅯᕱ", a_) == name)
				{
					num = short.Parse(innerText);
					this.m_ownerId = (ushort)num;
				}
				if (global::AcpASKLib.SystemKeyLoadedEventArgs.b("⁣ݥᱧ୩Ⅻݭṯ", a_) == name)
				{
					uint value = uint.Parse(innerText);
					accessFieldValueRange = new global::AcpASKLib.AccessFieldValueRange();
					accessFieldValueRange.FieldID = (int)num;
					accessFieldValueRange.Minimum = new uint?(value);
					num3++;
				}
				if (global::AcpASKLib.SystemKeyLoadedEventArgs.b("⁣ݥᱧ୩Ⅻ཭࡯", a_) == name)
				{
					uint value2 = uint.Parse(innerText);
					if (accessFieldValueRange != null)
					{
						accessFieldValueRange.Maximum = new uint?(value2);
						uint? minimum = accessFieldValueRange.Minimum;
						uint? maximum = accessFieldValueRange.Maximum;
						if (minimum.GetValueOrDefault() > maximum.GetValueOrDefault() & (minimum != null & maximum != null))
						{
							throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("≣ཥ൧٩࡫㡭ᅯṱų፵⩷᭹ቻ᥽킁\udb87뒍낏삑ﾗﾙ벛\udb9d튟킡쮣풥袧螩貫\ud9af\udcb1\uddb3\ud8b5햷쾹톻麽ꎿꏁ꫃ꣅꟇ뻉곍뗏룓돕ꯗ꧙ﳛꫝ裟菡諣웥ꗧ诩铫蟭鷯蟱駳", a_));
						}
						base.Add(accessFieldValueRange);
					}
					accessFieldValueRange = null;
					num4++;
				}
			}
			if (num2 != num3)
			{
				throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("≣ཥ൧٩࡫㡭ᅯṱų፵⩷᭹ቻ᥽킁\udb87뒍낏삑ﾗﾙ벛\udb9d튟킡쮣풥袧螩貫ﲭ톯\udcb1펳펵﮷햹즻킽뒿귃뗅꓉ꏋ뫍럑ꗓꏕ맗뛙ﳛꫝ迟싡ꃣ蟥鳧诩ꇫ蟭黯", a_));
			}
			if (num2 != num4)
			{
				throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("≣ཥ൧٩࡫㡭ᅯṱų፵⩷᭹ቻ᥽킁\udb87뒍낏삑ﾗﾙ벛\udb9d튟킡쮣풥袧螩貫ﲭ톯\udcb1펳펵﮷햹즻킽뒿귃뗅꓉ꏋ뫍럑ꗓꏕ맗뛙ﳛꫝ迟싡ꃣ蟥鳧诩ꇫ迭裯", a_));
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00005568 File Offset: 0x00003768
		internal string a(int A_0)
		{
			int a_ = 5;
			short num = (short)232325120;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				int num4;
				string text;
				string text2;
				for (;;)
				{
					IL_30:
					global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessFieldValueRange> enumerator;
					string str;
					switch (num2)
					{
					case 0:
					{
						num = (short)704839681;
						if (num != 0)
						{
						}
						num = (short)1365704704;
						short num3 = num;
						goto IL_2A9;
					}
					case 1:
						goto IL_3D7;
					case 2:
						if (num4 >= A_0)
						{
							num = (short)502988800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text += global::AcpASKLib.SystemKeyLoadedEventArgs.b("歡", a_);
						num4++;
						num = (short)667746305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						try
						{
							num = (short)1128136708;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_235;
								case 1:
									num = (short)1758789632;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1451622401;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)47677066;
									short num5 = num;
									num = (short)1584365194;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
									{
										num = (short)218169344;
										if (num != 0)
										{
										}
										global::AcpASKLib.AccessFieldValueRange accessFieldValueRange = enumerator.Current;
										uint? minimum = accessFieldValueRange.Minimum;
										uint? maximum = accessFieldValueRange.Maximum;
										text2 += text;
										text2 += global::AcpASKLib.SystemKeyLoadedEventArgs.b("歡塣≥१ṩ൫⍭᥯ᱱ䩳", a_);
										str = string.Format(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᥡ呣᭥", a_), minimum);
										text2 += str;
										text2 += global::AcpASKLib.SystemKeyLoadedEventArgs.b("幡䭣≥१ṩ൫⍭᥯ᱱ䩳", a_);
										text2 += text;
										text2 += global::AcpASKLib.SystemKeyLoadedEventArgs.b("歡塣≥१ṩ൫⍭ᅯੱ䩳", a_);
										str = string.Format(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᥡ呣᭥", a_), maximum);
										text2 += str;
										text2 += global::AcpASKLib.SystemKeyLoadedEventArgs.b("幡䭣≥१ṩ൫⍭ᅯੱ䩳", a_);
										num = (short)1630535682;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_B4;
									}
									continue;
								}
								IL_B9:
								num = (short)558563331;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B4:
								goto IL_B9;
							}
							IL_235:
							goto IL_464;
						}
						finally
						{
							num = (short)142671874;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)2046033921;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2A6;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_26D;
									}
									continue;
								}
								IL_26D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2066481152;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2A6:;
						}
						goto IL_2A9;
					case 4:
						goto IL_3D7;
					}
					goto IL_4B;
					IL_2A9:
					text2 += text;
					text2 += global::AcpASKLib.SystemKeyLoadedEventArgs.b("幡⡣ཥէͩᡫ୭ᑯ㙱ᕳɵ᥷⡹᥻ᵽ뢅芇", a_);
					text2 += text;
					text2 += global::AcpASKLib.SystemKeyLoadedEventArgs.b("歡塣⁥ŧཀྵk੭⑯፱፳䡵", a_);
					str = string.Format(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᥡ呣᭥", a_), this.m_ownerId);
					text2 += str;
					text2 += global::AcpASKLib.SystemKeyLoadedEventArgs.b("幡䭣⁥ŧཀྵk੭⑯፱፳䡵", a_);
					int count = base.Count;
					text2 += text;
					text2 += global::AcpASKLib.SystemKeyLoadedEventArgs.b("歡塣㑥१ѩ୫୭㹯ݱᥳ䡵", a_);
					str = string.Format(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᥡ呣᭥", a_), count);
					text2 += str;
					text2 += global::AcpASKLib.SystemKeyLoadedEventArgs.b("幡䭣㑥१ѩ୫୭㹯ݱᥳ䡵", a_);
					enumerator = base.GetEnumerator();
					num = (short)1566179331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D7:
					num = (short)251985922;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_464:
				text2 += text;
				text2 += global::AcpASKLib.SystemKeyLoadedEventArgs.b("幡䭣⩥ŧݩիᩭᕯᙱび᝵౷᭹⹻᭽뚇肉", a_);
				return text2;
				IL_4B:
				text2 = "";
				text = "";
				num4 = 0;
				num = (short)2120613892;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00005A14 File Offset: 0x00003C14
		internal byte[] PackedData
		{
			get
			{
				short num = (short)1486225408;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)104988673;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					global::System.Collections.ArrayList arrayList;
					int count;
					for (;;)
					{
						IL_4F:
						global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessFieldValueRange> enumerator;
						byte b;
						switch (num2)
						{
						case 0:
							goto IL_506;
						case 1:
							try
							{
								num = (short)1769406469;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									uint? num4;
									uint? num5;
									switch (num2)
									{
									case 0:
									{
										uint? num3;
										if (num3 == null)
										{
											num = (short)895156227;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1905065988;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										goto IL_443;
									case 3:
										num4 = null;
										num = (short)1517420552;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										uint? num3;
										uint num6;
										num5 = new uint?(num3.GetValueOrDefault() & num6);
										goto IL_3BA;
									}
									case 5:
										switch (0)
										{
										case 0:
											goto IL_11D;
										}
										continue;
									case 6:
										if (!enumerator.MoveNext())
										{
											num = (short)1005322247;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)2001534985;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										num = (short)626196482;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										num5 = num4;
										goto IL_3BA;
									case 9:
									{
										global::AcpASKLib.AccessFieldValueRange accessFieldValueRange = enumerator.Current;
										uint? minimum = accessFieldValueRange.Minimum;
										uint? maximum = accessFieldValueRange.Maximum;
										uint? num3 = minimum;
										uint? num7;
										if (num3 == null)
										{
											num4 = null;
											num7 = num4;
										}
										else
										{
											num7 = new uint?(num3.GetValueOrDefault() >> 24);
										}
										num4 = num7;
										b = (byte)num4.Value;
										arrayList.Add(b);
										num3 = minimum;
										uint? num8;
										if (num3 == null)
										{
											num4 = null;
											num8 = num4;
										}
										else
										{
											num8 = new uint?(num3.GetValueOrDefault() >> 16);
										}
										num4 = num8;
										b = (byte)num4.Value;
										arrayList.Add(b);
										num3 = minimum;
										uint? num9;
										if (num3 == null)
										{
											num4 = null;
											num9 = num4;
										}
										else
										{
											num9 = new uint?(num3.GetValueOrDefault() >> 8);
										}
										num4 = num9;
										b = (byte)num4.Value;
										arrayList.Add(b);
										num3 = minimum;
										uint num6 = 255U;
										uint? num10;
										if (num3 == null)
										{
											num4 = null;
											num10 = num4;
										}
										else
										{
											num10 = new uint?(num3.GetValueOrDefault() & num6);
										}
										num4 = num10;
										b = (byte)num4.Value;
										arrayList.Add(b);
										num3 = maximum;
										uint? num11;
										if (num3 == null)
										{
											num4 = null;
											num11 = num4;
										}
										else
										{
											num11 = new uint?(num3.GetValueOrDefault() >> 24);
										}
										num4 = num11;
										b = (byte)num4.Value;
										arrayList.Add(b);
										num3 = maximum;
										uint? num12;
										if (num3 == null)
										{
											num4 = null;
											num12 = num4;
										}
										else
										{
											num12 = new uint?(num3.GetValueOrDefault() >> 16);
										}
										num4 = num12;
										b = (byte)num4.Value;
										arrayList.Add(b);
										num3 = maximum;
										uint? num13;
										if (num3 == null)
										{
											num4 = null;
											num13 = num4;
										}
										else
										{
											num13 = new uint?(num3.GetValueOrDefault() >> 8);
										}
										num4 = num13;
										b = (byte)num4.Value;
										arrayList.Add(b);
										num3 = maximum;
										num6 = 255U;
										num = (short)1668874240;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									goto IL_11D;
									IL_3BA:
									num4 = num5;
									b = (byte)num4.Value;
									arrayList.Add(b);
									num = (short)2024931329;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_3EC:
									num = (short)84475910;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_11D:
									goto IL_3EC;
								}
								IL_443:
								goto IL_552;
							}
							finally
							{
								num = (short)216465409;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_503;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_47C;
										}
										continue;
									case 2:
									{
										enumerator.Dispose();
										num = (short)1415620089;
										short num14 = num;
										num = (short)590849529;
										switch ((num14 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_482;
										default:
											num = (short)224067584;
											if (num != 0)
											{
											}
											num = (short)65208320;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									goto IL_47C;
									IL_482:
									num = (short)1261830146;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_47C:
									if (enumerator != null)
									{
										goto IL_482;
									}
									break;
								}
								IL_503:;
							}
							goto IL_506;
						case 2:
							if (count > 0)
							{
								num = (short)1779433472;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_552;
						}
						goto IL_62;
						IL_506:
						b = (byte)this.m_ownerId;
						arrayList.Add(b);
						arrayList.Add((byte)count);
						enumerator = base.Items.GetEnumerator();
						num = (short)1974796289;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_552:
					return (byte[])arrayList.ToArray(typeof(byte));
					IL_62:
					num = (short)326500352;
					short num15 = num;
					arrayList = new global::System.Collections.ArrayList();
					count = base.Count;
					num = (short)105644034;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_4F;
				}
				}
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00005FA4 File Offset: 0x000041A4
		public ushort OwnerID
		{
			get
			{
				short num = (short)549349322;
				short num2 = num;
				num = (short)1848010698;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1289027584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)127139841;
				if (num != 0)
				{
				}
				num = (short)516096000;
				if (num != 0)
				{
				}
				return this.m_ownerId;
			}
		}

		// Token: 0x040000D8 RID: 216
		private ushort m_ownerId;
	}
}
