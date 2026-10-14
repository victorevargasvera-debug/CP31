using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Xml;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x02000004 RID: 4
	public class RUDPConfigParams
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000027A0 File Offset: 0x000009A0
		public void LoadConfig(string configFilePath)
		{
			int a_ = 2;
			short num = (short)658833408;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)185729024;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					case 1:
						return;
					case 2:
						try
						{
							global::System.IO.FileStream fileStream = new global::System.IO.FileStream(configFilePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
							try
							{
								switch (0)
								{
								case 0:
									goto IL_A6;
								}
								global::System.Collections.IEnumerator enumerator;
								global::System.Xml.XmlDocument xmlDocument;
								for (;;)
								{
									IL_8F:
									switch (num2)
									{
									case 0:
										try
										{
											num = (short)50987010;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
												{
													num = (short)1680779463;
													short num3 = num;
													num = (short)1706600647;
													switch ((num3 == num) ? 1 : 0)
													{
													case 0:
													case 2:
														goto IL_124;
													default:
														num = (short)196345856;
														if (num != 0)
														{
														}
														num = (short)1134952452;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												case 2:
													switch (0)
													{
													case 0:
														goto IL_122;
													}
													continue;
												case 3:
													if (!enumerator.MoveNext())
													{
														num = (short)2121728000;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_124;
												case 4:
													goto IL_1EB;
												}
												goto IL_122;
												IL_124:
												global::Motorola.Common.Communication.RUDP.RUDPConfigParams.a((global::System.Xml.XmlNode)enumerator.Current, this.b);
												num = (short)715522049;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_152:
												num = (short)1579745283;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_122:
												goto IL_152;
											}
											IL_1EB:
											goto IL_531;
										}
										finally
										{
											switch (0)
											{
											case 0:
												goto IL_20D;
											}
											global::System.IDisposable disposable;
											for (;;)
											{
												IL_1FA:
												switch (num2)
												{
												case 0:
													if (disposable != null)
													{
														num = (short)890306561;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_262;
												case 1:
													disposable.Dispose();
													num = (short)1403781122;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													goto IL_260;
												}
												goto IL_20D;
											}
											IL_260:
											IL_262:
											goto EndFinally_21;
											IL_20D:
											disposable = (enumerator as global::System.IDisposable);
											num = (short)2082406400;
											num2 = (int)((global::System.IntPtr)num);
											goto IL_1FA;
											EndFinally_21:;
										}
										goto IL_263;
									case 1:
										try
										{
											num = (short)2066743298;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 1:
													if (!enumerator.MoveNext())
													{
														num = (short)542965763;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::Motorola.Common.Communication.RUDP.RUDPConfigParams.a((global::System.Xml.XmlNode)enumerator.Current, this);
													num = (short)782827520;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													switch (0)
													{
													case 0:
														goto IL_30F;
													}
													continue;
												case 3:
													num = (short)117243908;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 4:
													goto IL_387;
												}
												IL_311:
												num = (short)2071199745;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_30F:
												goto IL_311;
											}
											IL_387:
											goto IL_29B;
										}
										finally
										{
											switch (0)
											{
											case 0:
												goto IL_3A9;
											}
											global::System.IDisposable disposable;
											for (;;)
											{
												IL_396:
												switch (num2)
												{
												case 0:
													if (disposable != null)
													{
														num = (short)1332019201;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_3FC;
												case 1:
													disposable.Dispose();
													num = (short)1969815554;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													goto IL_3FA;
												}
												goto IL_3A9;
											}
											IL_3FA:
											IL_3FC:
											goto EndFinally_20;
											IL_3A9:
											disposable = (enumerator as global::System.IDisposable);
											num = (short)402128896;
											num2 = (int)((global::System.IntPtr)num);
											goto IL_396;
											EndFinally_20:;
										}
										goto Block_6;
										IL_29B:
										enumerator = xmlDocument.SelectNodes(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("琥紧温簫洭弯就刳張強樹崻䰽ℿ⽁⅃㉅ⵇ㡉㽋慍ṏ㝑㍓㥕ⱗ㍙㵛⩝य़ൡ੣㙥१ᡩ൫ͭᕯٱᅳѵ୷啹ⱻώ", a_)).GetEnumerator();
										num = (short)1920270338;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_3FD;
									case 3:
										goto IL_54A;
									}
									goto IL_A6;
									IL_263:
									enumerator = xmlDocument.SelectNodes(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("琥紧温簫洭弯就刳張強樹崻䰽ℿ⽁⅃㉅ⵇ㡉㽋慍ፏ㵑㩓㡕㵗㥙⡛㝝ᙟୡၣὥ㡧୩ṫ཭ᵯ᝱s፵੷ॹ卻⹽", a_)).GetEnumerator();
									num = (short)467337216;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_531:
									num = (short)1545273347;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									Block_6:
									try
									{
										IL_3FD:
										num = (short)857145346;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)564264964;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_437;
												}
												continue;
											case 3:
												if (!enumerator.MoveNext())
												{
													num = (short)360120320;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.Common.Communication.RUDP.RUDPConfigParams.a((global::System.Xml.XmlNode)enumerator.Current, this.a);
												num = (short)786169857;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
												goto IL_4B6;
											}
											IL_468:
											num = (short)1520435203;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_437:
											goto IL_468;
										}
										IL_4B6:
										goto IL_263;
									}
									finally
									{
										switch (0)
										{
										case 0:
											goto IL_4D8;
										}
										global::System.IDisposable disposable;
										for (;;)
										{
											IL_4C5:
											switch (num2)
											{
											case 0:
												if (disposable != null)
												{
													num = (short)1406795777;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_530;
											case 1:
												disposable.Dispose();
												num = (short)478740482;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_52E;
											}
											goto IL_4D8;
										}
										IL_52E:
										IL_530:
										goto EndFinally_19;
										IL_4D8:
										disposable = (enumerator as global::System.IDisposable);
										num = (short)1283063808;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_4C5;
										EndFinally_19:;
									}
									goto IL_531;
								}
								IL_54A:
								goto IL_5B7;
								IL_A6:
								xmlDocument = new global::System.Xml.XmlDocument();
								xmlDocument.Load(fileStream);
								enumerator = xmlDocument.SelectNodes(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("琥紧温簫洭弯就刳張強樹崻䰽ℿ⽁⅃㉅ⵇ㡉㽋慍ፏ㵑㩓さㅗ㵙⥛ⱝşᙡൣ॥٧㩩൫ᱭᅯάᅳɵᵷࡹཻ兽큿", a_)).GetEnumerator();
								num = (short)1847459841;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_8F;
							}
							finally
							{
								num = (short)1733689344;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_57E;
										}
										continue;
									case 1:
										goto IL_5B4;
									case 2:
										((global::System.IDisposable)fileStream).Dispose();
										num = (short)137560065;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_57E:
									if (fileStream == null)
									{
										break;
									}
									num = (short)820248578;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_5B4:;
							}
							IL_5B7:
							num = (short)2111307777;
							if (num != 0)
							{
							}
							return;
						}
						catch (global::System.Exception systemException)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_InvalidConfigurationFile, systemException);
						}
						goto IL_5EF;
					}
					IL_59:
					if (configFilePath == null)
					{
						num = (short)420610049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_5EF:
					num = (short)1627062272;
					short num4 = num;
					num = (short)1446117378;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002E60 File Offset: 0x00001060
		private static void a(global::System.Xml.XmlNode A_0, object A_1)
		{
			int a_ = 12;
			short num = (short)1176305664;
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
				float num3;
				float num6;
				global::System.Reflection.PropertyInfo property;
				uint num9;
				uint num12;
				int num13;
				int num16;
				for (;;)
				{
					IL_30:
					int num14;
					int num15;
					switch (num2)
					{
					case 0:
					{
						num3 = float.Parse(A_0.Attributes[global::Motorola.Common.Communication.RUDP.RUDPSocket.i("䘯匱堳䌵崷", a_)].Value, global::System.Globalization.CultureInfo.InvariantCulture);
						float num4 = float.Parse(A_0.Attributes[global::Motorola.Common.Communication.RUDP.RUDPSocket.i("崯嬱娳怵夷嘹䤻嬽", a_)].Value, global::System.Globalization.CultureInfo.InvariantCulture);
						float num5 = float.Parse(A_0.Attributes[global::Motorola.Common.Communication.RUDP.RUDPSocket.i("崯匱䰳怵夷嘹䤻嬽", a_)].Value, global::System.Globalization.CultureInfo.InvariantCulture);
						num6 = float.Parse(A_0.Attributes[global::Motorola.Common.Communication.RUDP.RUDPSocket.i("启圱刳圵䴷嘹䠻", a_)].Value, global::System.Globalization.CultureInfo.InvariantCulture);
						num = (short)1294270484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (property.PropertyType == typeof(int))
						{
							num = (short)1626389548;
							short num7 = num;
							num = (short)1552399404;
							switch ((num7 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_184;
							case 1:
								break;
							default:
							{
								num = (short)1523646464;
								short num8 = num;
								break;
							}
							}
							num = (short)1493499904;
							if (num != 0)
							{
							}
							num = (short)1423179797;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1032192012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)935657481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num9 = uint.Parse(A_0.Attributes[global::Motorola.Common.Communication.RUDP.RUDPSocket.i("䘯匱堳䌵崷", a_)].Value, global::System.Globalization.CultureInfo.InvariantCulture);
						uint num10 = uint.Parse(A_0.Attributes[global::Motorola.Common.Communication.RUDP.RUDPSocket.i("崯嬱娳怵夷嘹䤻嬽", a_)].Value, global::System.Globalization.CultureInfo.InvariantCulture);
						uint num11 = uint.Parse(A_0.Attributes[global::Motorola.Common.Communication.RUDP.RUDPSocket.i("崯匱䰳怵夷嘹䤻嬽", a_)].Value, global::System.Globalization.CultureInfo.InvariantCulture);
						num12 = uint.Parse(A_0.Attributes[global::Motorola.Common.Communication.RUDP.RUDPSocket.i("启圱刳圵䴷嘹䠻", a_)].Value, global::System.Globalization.CultureInfo.InvariantCulture);
						num = (short)13762575;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (property.PropertyType == typeof(uint))
						{
							num = (short)47513603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_69E;
					case 5:
						goto IL_688;
					case 6:
						goto IL_548;
					case 7:
						num = (short)779354113;
						if (num != 0)
						{
						}
						num = (short)428408840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						float num5;
						if (num3 > num5)
						{
							num = (short)1095630859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)166658067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (num13 > num14)
						{
							num = (short)780140550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)290717718;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_560;
					case 11:
						goto IL_670;
					case 12:
						if (property.PropertyType == typeof(float))
						{
							num = (short)102236160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1112145924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						uint num11;
						if (num9 > num11)
						{
							num = (short)1901461521;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1514274830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_370;
					case 15:
					{
						uint num10;
						if (num9 >= num10)
						{
							num = (short)73859095;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_217;
					}
					case 16:
						if (num13 >= num15)
						{
							num = (short)233504770;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_548;
					case 17:
						goto IL_217;
					case 18:
						goto IL_230;
					case 19:
						goto IL_1F1;
					case 20:
					{
						float num4;
						if (num3 >= num4)
						{
							num = (short)1047003143;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_670;
					}
					case 21:
						goto IL_184;
					case 22:
						goto IL_211;
					case 23:
						num = (short)459735053;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_97;
					IL_184:
					num13 = int.Parse(A_0.Attributes[global::Motorola.Common.Communication.RUDP.RUDPSocket.i("䘯匱堳䌵崷", a_)].Value, global::System.Globalization.CultureInfo.InvariantCulture);
					num15 = int.Parse(A_0.Attributes[global::Motorola.Common.Communication.RUDP.RUDPSocket.i("崯嬱娳怵夷嘹䤻嬽", a_)].Value, global::System.Globalization.CultureInfo.InvariantCulture);
					num14 = int.Parse(A_0.Attributes[global::Motorola.Common.Communication.RUDP.RUDPSocket.i("崯匱䰳怵夷嘹䤻嬽", a_)].Value, global::System.Globalization.CultureInfo.InvariantCulture);
					num16 = int.Parse(A_0.Attributes[global::Motorola.Common.Communication.RUDP.RUDPSocket.i("启圱刳圵䴷嘹䠻", a_)].Value, global::System.Globalization.CultureInfo.InvariantCulture);
					num = (short)1498152976;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_217:
					num = (short)735510546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_548:
					num = (short)1452015626;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_670:
					num = (short)778043397;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1F1:
				float num17 = num3;
				goto IL_68C;
				IL_211:
				int num18 = num13;
				goto IL_3B6;
				IL_230:
				uint num19 = num12;
				goto IL_408;
				IL_370:
				num19 = num9;
				goto IL_408;
				IL_3B6:
				int num20 = num18;
				property.SetValue(A_1, num20, null);
				return;
				IL_408:
				uint num21 = num19;
				property.SetValue(A_1, num21, null);
				return;
				IL_560:
				num18 = num16;
				goto IL_3B6;
				IL_688:
				num17 = num6;
				IL_68C:
				float num22 = num17;
				property.SetValue(A_1, num22, null);
				return;
				IL_69E:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_InvalidTypeInConfigurationFile);
				IL_97:
				property = A_1.GetType().GetProperty(A_0.Attributes[global::Motorola.Common.Communication.RUDP.RUDPSocket.i("帯匱夳匵", a_)].Value, global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic);
				num = (short)1740177409;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00003518 File Offset: 0x00001718
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000035C8 File Offset: 0x000017C8
		public global::Motorola.Common.Communication.RUDP.NegotiateParams SynNegociateParameters
		{
			get
			{
				short num = (short)1382384686;
				short num2 = num;
				num = (short)1016497198;
				switch (num2 == num)
				{
				}
				num = (short)1634467841;
				if (num != 0)
				{
				}
				num = (short)1657274368;
				short num3 = num;
				num = (short)815726592;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1133563826;
				short num2 = num;
				num = (short)1925304242;
				switch (num2 == num)
				{
				}
				num = (short)1623916544;
				if (num != 0)
				{
				}
				num = (short)1152778240;
				short num3 = num;
				num = (short)1110507521;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00003678 File Offset: 0x00001878
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00003724 File Offset: 0x00001924
		public global::Motorola.Common.Communication.RUDP.ConnectivityParams ConnectivityParameters
		{
			get
			{
				short num = (short)1296254895;
				short num2 = num;
				num = (short)1092503471;
				switch (num2 == num)
				{
				}
				num = (short)1232273408;
				if (num != 0)
				{
				}
				num = (short)2097938432;
				short num3 = num;
				num = (short)471334913;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1973146370;
				short num2 = num;
				num = (short)860476162;
				switch (num2 == num)
				{
				}
				num = (short)687013889;
				if (num != 0)
				{
				}
				num = (short)1411383296;
				short num3 = num;
				num = (short)1326972928;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000037D4 File Offset: 0x000019D4
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00003880 File Offset: 0x00001A80
		public int NegotiationAlgorithm
		{
			get
			{
				short num = (short)29731446;
				short num2 = num;
				num = (short)185444982;
				switch (num2 == num)
				{
				}
				num = (short)658178048;
				if (num != 0)
				{
				}
				num = (short)840957952;
				short num3 = num;
				num = (short)1978204161;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)448289720;
				short num2 = num;
				num = (short)1981701048;
				switch (num2 == num)
				{
				}
				num = (short)646119425;
				if (num != 0)
				{
				}
				num = (short)478674944;
				short num3 = num;
				num = (short)9437184;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000012 RID: 18 RVA: 0x0000392C File Offset: 0x00001B2C
		// (set) Token: 0x06000013 RID: 19 RVA: 0x000039D8 File Offset: 0x00001BD8
		public int CloseWaitTimeout
		{
			get
			{
				short num = (short)1836843009;
				if (num != 0)
				{
				}
				num = (short)1131285625;
				short num2 = num;
				num = (short)1342901369;
				switch (num2 == num)
				{
				}
				num = (short)214564864;
				short num3 = num;
				num = (short)1876426752;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)1315895258;
				short num2 = num;
				num = (short)659617754;
				switch (num2 == num)
				{
				}
				num = (short)656801793;
				if (num != 0)
				{
				}
				num = (short)2145845248;
				short num3 = num;
				num = (short)1914896384;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00003A8C File Offset: 0x00001C8C
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00003B3C File Offset: 0x00001D3C
		public int MaxNumberofRetries
		{
			get
			{
				short num = (short)983656796;
				short num2 = num;
				num = (short)1279551836;
				switch (num2 == num)
				{
				}
				num = (short)835649537;
				if (num != 0)
				{
				}
				num = (short)952958976;
				short num3 = num;
				num = (short)610140160;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)21448298;
				short num2 = num;
				num = (short)815023722;
				switch (num2 == num)
				{
				}
				num = (short)966918144;
				if (num != 0)
				{
				}
				num = (short)1731592192;
				short num3 = num;
				num = (short)1093992449;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00003BEC File Offset: 0x00001DEC
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00003C9C File Offset: 0x00001E9C
		public int TimeBetweenRetries
		{
			get
			{
				short num = (short)1606148351;
				short num2 = num;
				num = (short)125886719;
				switch (num2 == num)
				{
				}
				num = (short)583335937;
				if (num != 0)
				{
				}
				num = (short)325255168;
				short num3 = num;
				num = (short)484769792;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)1182999813;
				short num2 = num;
				num = (short)1351886085;
				switch (num2 == num)
				{
				}
				num = (short)701628417;
				if (num != 0)
				{
				}
				num = (short)964886528;
				short num3 = num;
				num = (short)1826553856;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00003D50 File Offset: 0x00001F50
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00003DFC File Offset: 0x00001FFC
		public float RetryCurveShape
		{
			get
			{
				short num = (short)185465432;
				short num2 = num;
				num = (short)1368390232;
				switch (num2 == num)
				{
				}
				num = (short)725090305;
				if (num != 0)
				{
				}
				num = (short)1386151936;
				short num3 = num;
				num = (short)2145976320;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)988544374;
				short num2 = num;
				num = (short)772472182;
				switch (num2 == num)
				{
				}
				num = (short)1785266176;
				if (num != 0)
				{
				}
				num = (short)396951552;
				short num3 = num;
				num = (short)597426177;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00003EAC File Offset: 0x000020AC
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00003F60 File Offset: 0x00002160
		public int MaxTimeBetweenRetries
		{
			get
			{
				short num = (short)109095069;
				short num2 = num;
				num = (short)2113185949;
				switch (num2 == num)
				{
				}
				num = (short)928776193;
				if (num != 0)
				{
				}
				num = (short)414121984;
				short num3 = num;
				num = (short)1559953408;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				short num = (short)185545151;
				short num2 = num;
				num = (short)961032639;
				switch (num2 == num)
				{
				}
				num = (short)1753808897;
				if (num != 0)
				{
				}
				num = (short)1116930048;
				short num3 = num;
				num = (short)194707456;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00004014 File Offset: 0x00002214
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000040C4 File Offset: 0x000022C4
		public int InactivityTimeout
		{
			get
			{
				short num = (short)605609937;
				short num2 = num;
				num = (short)1120460753;
				switch (num2 == num)
				{
				}
				num = (short)1962606592;
				if (num != 0)
				{
				}
				num = (short)1261830144;
				short num3 = num;
				num = (short)521273345;
				if (num != 0)
				{
				}
				return this.i;
			}
			set
			{
				short num = (short)2141519873;
				if (num != 0)
				{
				}
				num = (short)1567416008;
				short num2 = num;
				num = (short)1851645640;
				switch (num2 == num)
				{
				}
				num = (short)803471360;
				short num3 = num;
				num = (short)18284544;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00004174 File Offset: 0x00002374
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00004224 File Offset: 0x00002424
		public int DelayedAckTimeout
		{
			get
			{
				short num = (short)504678731;
				short num2 = num;
				num = (short)111724875;
				switch (num2 == num)
				{
				}
				num = (short)1810235393;
				if (num != 0)
				{
				}
				num = (short)863043584;
				short num3 = num;
				num = (short)1277165568;
				if (num != 0)
				{
				}
				return this.j;
			}
			set
			{
				short num = (short)1332396632;
				short num2 = num;
				num = (short)1062650456;
				switch (num2 == num)
				{
				}
				num = (short)285933568;
				if (num != 0)
				{
				}
				num = (short)1032454144;
				short num3 = num;
				num = (short)2043740161;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000042D8 File Offset: 0x000024D8
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00004388 File Offset: 0x00002588
		public int CloseProcessingMode
		{
			get
			{
				short num = (short)874368665;
				short num2 = num;
				num = (short)2134888089;
				switch (num2 == num)
				{
				}
				num = (short)171638785;
				if (num != 0)
				{
				}
				num = (short)1859911680;
				short num3 = num;
				num = (short)1028784128;
				if (num != 0)
				{
				}
				return this.k;
			}
			set
			{
				short num = (short)1479016449;
				if (num != 0)
				{
				}
				num = (short)1714925633;
				short num2 = num;
				num = (short)1484894273;
				switch (num2 == num)
				{
				}
				num = (short)163840000;
				short num3 = num;
				num = (short)1615265792;
				if (num != 0)
				{
				}
				this.k = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00004438 File Offset: 0x00002638
		// (set) Token: 0x06000023 RID: 35 RVA: 0x000044E8 File Offset: 0x000026E8
		public uint MaxUserTxDataSize
		{
			get
			{
				short num = (short)1296854376;
				short num2 = num;
				num = (short)440823144;
				switch (num2 == num)
				{
				}
				num = (short)1456668673;
				if (num != 0)
				{
				}
				num = (short)319750144;
				short num3 = num;
				num = (short)2035089408;
				if (num != 0)
				{
				}
				return this.l;
			}
			set
			{
				short num = (short)1819952227;
				short num2 = num;
				num = (short)1530610787;
				switch (num2 == num)
				{
				}
				num = (short)1069023232;
				if (num != 0)
				{
				}
				num = (short)503775232;
				short num3 = num;
				num = (short)551223297;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000024 RID: 36 RVA: 0x0000459C File Offset: 0x0000279C
		// (set) Token: 0x06000025 RID: 37 RVA: 0x0000464C File Offset: 0x0000284C
		public uint MaxUserRxDataSize
		{
			get
			{
				short num = (short)1323040769;
				if (num != 0)
				{
				}
				num = (short)374574428;
				short num2 = num;
				num = (short)360418652;
				switch (num2 == num)
				{
				}
				num = (short)1858011136;
				short num3 = num;
				num = (short)996737024;
				if (num != 0)
				{
				}
				return this.m;
			}
			set
			{
				short num = (short)578232611;
				short num2 = num;
				num = (short)1070604579;
				switch (num2 == num)
				{
				}
				num = (short)1715273729;
				if (num != 0)
				{
				}
				num = (short)1365180416;
				short num3 = num;
				num = (short)511901696;
				if (num != 0)
				{
				}
				this.m = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000046FC File Offset: 0x000028FC
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000047A8 File Offset: 0x000029A8
		public int MaxIncomingMsgQueueSize
		{
			get
			{
				short num = (short)1105828235;
				short num2 = num;
				num = (short)1563924875;
				switch (num2 == num)
				{
				}
				num = (short)1841168384;
				if (num != 0)
				{
				}
				num = (short)1096679424;
				short num3 = num;
				num = (short)2110980097;
				if (num != 0)
				{
				}
				return this.n;
			}
			set
			{
				short num = (short)769908130;
				short num2 = num;
				num = (short)952753570;
				switch (num2 == num)
				{
				}
				num = (short)3801089;
				if (num != 0)
				{
				}
				num = (short)2064384000;
				short num3 = num;
				num = (short)392429568;
				if (num != 0)
				{
				}
				this.n = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0000485C File Offset: 0x00002A5C
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00004908 File Offset: 0x00002B08
		public int MaxOutgoingMsgQueueSize
		{
			get
			{
				short num = (short)368124542;
				short num2 = num;
				num = (short)1726554750;
				switch (num2 == num)
				{
				}
				num = (short)1510539265;
				if (num != 0)
				{
				}
				num = (short)922812416;
				short num3 = num;
				num = (short)523108352;
				if (num != 0)
				{
				}
				return this.o;
			}
			set
			{
				short num = (short)1674528638;
				short num2 = num;
				num = (short)165627774;
				switch (num2 == num)
				{
				}
				num = (short)1182990337;
				if (num != 0)
				{
				}
				num = (short)2126708736;
				short num3 = num;
				num = (short)907476992;
				if (num != 0)
				{
				}
				this.o = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000049B8 File Offset: 0x00002BB8
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00004A64 File Offset: 0x00002C64
		public int ListofValidClientAddresses
		{
			get
			{
				short num = (short)1336425660;
				short num2 = num;
				num = (short)2044476604;
				switch (num2 == num)
				{
				}
				num = (short)1736441857;
				if (num != 0)
				{
				}
				num = (short)673710080;
				short num3 = num;
				num = (short)1735131136;
				if (num != 0)
				{
				}
				return this.p;
			}
			set
			{
				short num = (short)811536514;
				short num2 = num;
				num = (short)1712197762;
				switch (num2 == num)
				{
				}
				num = (short)734658561;
				if (num != 0)
				{
				}
				num = (short)2026831872;
				short num3 = num;
				num = (short)472121344;
				if (num != 0)
				{
				}
				this.p = value;
			}
		}

		// Token: 0x04000004 RID: 4
		private global::Motorola.Common.Communication.RUDP.NegotiateParams a = new global::Motorola.Common.Communication.RUDP.NegotiateParams();

		// Token: 0x04000005 RID: 5
		private global::Motorola.Common.Communication.RUDP.ConnectivityParams b = new global::Motorola.Common.Communication.RUDP.ConnectivityParams();

		// Token: 0x04000006 RID: 6
		private int c = 1;

		// Token: 0x04000007 RID: 7
		private int d = 1000;

		// Token: 0x04000008 RID: 8
		private int e = 3;

		// Token: 0x04000009 RID: 9
		private int f = 3000;

		// Token: 0x0400000A RID: 10
		private float g = 1f;

		// Token: 0x0400000B RID: 11
		private int h = 40000;

		// Token: 0x0400000C RID: 12
		private int i = 25000;

		// Token: 0x0400000D RID: 13
		private int j = 75;

		// Token: 0x0400000E RID: 14
		private int k = 1;

		// Token: 0x0400000F RID: 15
		private uint l = 10000U;

		// Token: 0x04000010 RID: 16
		private uint m = 10000U;

		// Token: 0x04000011 RID: 17
		private int n = 10;

		// Token: 0x04000012 RID: 18
		private int o = 10;

		// Token: 0x04000013 RID: 19
		private int p;
	}
}
