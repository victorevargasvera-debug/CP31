using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using AcpCryptoLib;
using AcpExceptionLib;
using Motorola.Common.BinarySerializer;

namespace AcpFileHandlerLib
{
	// Token: 0x02000006 RID: 6
	public class AcpFileHandler : global::AcpFileHandlerLib.IAcpFileHandler
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00004500 File Offset: 0x00002700
		public void WriteFile<T>(T writeBuffer, global::AcpFileHandlerLib.AcpFileHeader fileHeader, string filePath, bool encrypt)
		{
			int a_ = 5;
			short num = (short)1108475905;
			if (num != 0)
			{
			}
			num = (short)1749614592;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6D;
				}
				for (;;)
				{
					IL_5A:
					switch (num2)
					{
					case 0:
						goto IL_A7;
					case 1:
					{
						if (writeBuffer == null)
						{
							num = (short)1148846080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)708968448;
						short num3 = num;
						num = (short)1945436162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_EC;
					}
					goto IL_6D;
				}
				IL_A7:
				throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꋣ껥럧ꏩ苫髭闯胱髳韵铷ꗹ맻賽狿洁瘃", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("鏣铥臧黩觫곭藯铱鋳鏵諷\udaf9鿻鿽滿氁欃爅⠇栉椋⸍縏朑砓稕㘗", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, null);
				IL_EC:
				global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter;
				try
				{
					global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
					try
					{
						switch (0)
						{
						case 0:
							goto IL_143;
						}
						for (;;)
						{
							IL_124:
							global::System.IO.FileStream fileStream;
							switch (num2)
							{
							case 0:
								num = (short)895025156;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_4D7;
							case 2:
								try
								{
									num = (short)1227423746;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											binaryFormatter.Serialize(fileStream, fileHeader);
											num = (short)341311496;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											goto IL_39E;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_1E0;
											}
											continue;
										case 3:
											try
											{
												global::AcpCryptoLib.AcpCryptoStream acpCryptoStream;
												memoryStream.WriteTo(global::AcpFileHandlerLib.AcpFileHandler.b(fileStream, acpCryptoStream));
												goto IL_39E;
											}
											finally
											{
												num = (short)337903617;
												num2 = (int)((global::System.IntPtr)num);
												for (;;)
												{
													global::AcpCryptoLib.AcpCryptoStream acpCryptoStream;
													switch (num2)
													{
													case 0:
														((global::System.IDisposable)acpCryptoStream).Dispose();
														num = (short)1606090754;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													case 1:
														switch (0)
														{
														case 0:
															goto IL_33E;
														}
														continue;
													case 2:
														goto IL_377;
													}
													IL_33E:
													if (acpCryptoStream == null)
													{
														break;
													}
													num = (short)16711680;
													num2 = (int)((global::System.IntPtr)num);
												}
												IL_377:;
											}
											goto IL_37A;
										case 4:
											if (fileHeader != null)
											{
												num = (short)370671616;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_29D;
										case 5:
										{
											global::AcpCryptoLib.AcpCryptoStream acpCryptoStream = new global::AcpCryptoLib.AcpCryptoStream();
											num = (short)1650196483;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 6:
											if (encrypt)
											{
												num = (short)88801285;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											memoryStream.WriteTo(fileStream);
											num = (short)1593049089;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 7:
											goto IL_1F9;
										case 8:
											goto IL_29D;
										case 9:
											goto IL_3B7;
										}
										IL_1E0:
										if (fileStream == null)
										{
											num = (short)1792999431;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes(global::AcpFileHandlerLib.ACPFileCopyRightInfomation.Instance.CopyRightInformation);
										fileStream.Write(bytes, 0, bytes.Length);
										num = (short)1974599684;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_29D:
										num = (short)1461518342;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_39E:
										num = (short)1333854217;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_1F9:
									IL_37A:
									throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꋣ껥럧ꏩ苫髭闯胱髳韵铷ꗹ맻賽狿洁瘃", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꋣ迥蓧迩뿫髭苯韱闳鯵\ud8f7闹黻铽旿愁瀃★欇攉礋戍琏㈑稓礕気㨙縛笝\u001f䄡嘣䌥䤧帩䤫䨭", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, null);
									IL_3B7:
									goto IL_500;
								}
								finally
								{
									num = (short)314834945;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_451;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_3EF;
											}
											continue;
										case 2:
											goto IL_471;
										}
										IL_3EF:
										num = (short)1256985458;
										short num4 = num;
										num = (short)910431090;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											IL_451:
											((global::System.IDisposable)fileStream).Dispose();
											num = (short)2101542914;
											num2 = (int)((global::System.IntPtr)num);
											break;
										default:
											num = (short)1706688512;
											if (num != 0)
											{
											}
											if (fileStream == null)
											{
												goto IL_473;
											}
											num = (short)1701249024;
											num2 = (int)((global::System.IntPtr)num);
											break;
										}
									}
									IL_471:
									IL_473:;
								}
								goto IL_474;
								IL_500:
								num = (short)445972485;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								if (global::System.Environment.OSVersion.Platform != global::System.PlatformID.Unix)
								{
									num = (short)1984757760;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_4D9;
							case 4:
								if (global::AcpFileHandlerLib.AcpFileHandler.a(filePath, memoryStream.Length))
								{
									num = (short)1806237697;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_4D9;
							case 5:
								goto IL_518;
							}
							goto IL_143;
							IL_4D9:
							fileStream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write);
							num = (short)370999298;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_474:
						throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꋣ껥럧뷩黫蟭蓯韱꯳답釷觹韻ꇽ䛿省栃樅", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꫣ觥鳧쫩觫胭鿯蟱鏳黵\ud8f7鳹軻鯽旿∁眃瘅椇椉椋⸍缏簑㐓戕瀗缙㰛稝䤟儡伣", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, null);
						IL_4D7:
						goto IL_474;
						IL_518:
						goto IL_588;
						IL_143:
						binaryFormatter.Serialize(memoryStream, writeBuffer);
						num = (short)79036419;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_124;
					}
					finally
					{
						num = (short)1944518657;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)1566441474;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_54D;
								}
								continue;
							case 2:
								goto IL_585;
							}
							IL_54D:
							if (memoryStream == null)
							{
								break;
							}
							num = (short)1694695424;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_585:;
					}
					IL_588:;
				}
				catch (global::System.UnauthorizedAccessException innerException)
				{
					throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꋣ껥럧뷩黫蟭蓯韱꯳럵鯷駹駻跽珿崁䀃挅昇按椋樍", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("꟣蟥蛧蓩菫髭탯藱蛳鿵賷鿹\udcfb諽濿∁瘃挅椇渉ℋ愍縏縑洓㘕縗猙瀛笝టȡ䬣吥ࠧ䬩伫䴭唯䄱䜳ᘵ尷弹刻圽┿♁摃ㅅ⁇⽉≋湍❏⁑㵓≕ㅗ㑙㭛繝ٟୡࡣͥ", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, innerException);
				}
				catch (global::System.IO.IOException innerException2)
				{
					throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꋣ껥럧ꗩ鳫语黯귱뷳맵ꟷ뿹軻賽濿瀁", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("귣짥꟧쫩觫鳭苯鷱蛳훵韷駹鿻诽狿焁⠃★嬇漉椋⸍紏紑易猕㠗猙爛砝伟倡䤣䜥尧䌩䌫䀭ု嬱娳ᘵ䰷刹夻ḽ⤿ⱁ⩃⍅㩇橉⥋㙍㍏㝑⑓≕ㅗ㕙㉛灝", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, innerException2);
				}
				catch (global::System.Runtime.Serialization.SerializationException innerException3)
				{
					throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꋣ껥럧뷩黫蟭蓯韱꯳냵釷雹駻ꇽ䛿持洃樅", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꇣ铥髧藩黫컭飯鏱蓳蛵鷷铹\udcfb觽棿欁栃挅⠇礉椋簍礏猑砓缕戗猙爛礝\u001f䐡䴣䨥䴧ة缫䬭唯ሱ夳夵䨷弹᰻圽⸿⑁⭃㑅╇⭉㡋❍㽏㱑瑓㽕㙗穙⡛㙝՟䉡ൣࡥ٧ཀྵṫ乭ᕯੱᝳ፵ࡷ๹ᕻᅽ겁", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, innerException3);
				}
				catch (global::System.Exception ex)
				{
					if (ex is global::AcpExceptionLib.AcpException)
					{
						throw;
					}
					throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꋣ껥럧ꏩ苫髭闯胱髳韵铷ꗹ맻賽狿洁瘃", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("럣菥跧쫩臫臭苯韱퓳鿵雷鳹鏻賽淿持瀃漅朇搉Ⰻ服縏㈑怓縕紗㨙甛瀝丟䜡嘣إ䴧利伫䬭䀯䘱崳夵嘷ᐹ", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, ex);
				}
				return;
				IL_6D:
				binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
				num = (short)1059717121;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_5A;
			}
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004BF0 File Offset: 0x00002DF0
		public void WriteFile(byte[] writeBuffer, global::AcpFileHandlerLib.AcpFileHeader fileHeader, string filePath, bool encrypt, global::System.IO.FileMode fileMode)
		{
			int a_ = 8;
			short num = (short)578158592;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				for (;;)
				{
					IL_27:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter;
					for (;;)
					{
						IL_31:
						switch (num2)
						{
						case 0:
							if (global::AcpFileHandlerLib.AcpFileHandler.a(filePath, (long)writeBuffer.Length))
							{
								num = (short)861929473;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2139160578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_528;
						case 2:
							try
							{
								global::System.IO.FileStream fileStream = new global::System.IO.FileStream(filePath, fileMode, global::System.IO.FileAccess.Write);
								try
								{
									num = (short)913637378;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_3AA;
										case 1:
											try
											{
												num = (short)1011744768;
												num2 = (int)((global::System.IntPtr)num);
												for (;;)
												{
													global::System.IO.BinaryWriter binaryWriter;
													switch (num2)
													{
													case 0:
														switch (0)
														{
														case 0:
															goto IL_1AA;
														}
														continue;
													case 1:
														goto IL_309;
													case 2:
														if (fileHeader != null)
														{
															num = (short)1245380619;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_272;
													case 3:
														goto IL_309;
													case 4:
														binaryWriter.Write(global::AcpFileHandlerLib.AcpFileHandler.b(writeBuffer));
														num = (short)1371668483;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													case 5:
														if (encrypt)
														{
															num = (short)2009530374;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_222;
													case 6:
														num = (short)1040646152;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													case 7:
														goto IL_272;
													case 8:
														if (fileMode != global::System.IO.FileMode.Append)
														{
															num = (short)676265988;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_222;
													case 9:
														goto IL_321;
													case 10:
														goto IL_1C4;
													case 11:
														binaryFormatter.Serialize(fileStream, fileHeader);
														num = (short)496631815;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													IL_1AA:
													if (binaryWriter == null)
													{
														num = (short)1606680586;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													num = (short)1616510978;
													num2 = (int)((global::System.IntPtr)num);
													continue;
													IL_222:
													binaryWriter.Write(writeBuffer);
													num = (short)1680080897;
													num2 = (int)((global::System.IntPtr)num);
													continue;
													IL_272:
													num = (short)1559560197;
													num2 = (int)((global::System.IntPtr)num);
													continue;
													IL_309:
													num = (short)65142793;
													num2 = (int)((global::System.IntPtr)num);
												}
												IL_1C4:
												throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꇦꇨ듪ꓬ臮藰雲蟴駶飸韺ꋼ뫾猀焂樄甆", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꗦ胨藪賬鷮裰ꓲ蟴黶跸黺迼\udffe渀愂漄戆樈缊ⴌ氎縐昒礔猖㤘甚爜欞Ġ䄢䀤ܦ䨨太䠬丮䔰嘲儴", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, null);
												IL_321:;
											}
											finally
											{
												num = (short)1136197634;
												num2 = (int)((global::System.IntPtr)num);
												for (;;)
												{
													global::System.IO.BinaryWriter binaryWriter;
													switch (num2)
													{
													case 0:
														((global::System.IDisposable)binaryWriter).Dispose();
														num = (short)1360003073;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													case 1:
														goto IL_38E;
													case 2:
														switch (0)
														{
														case 0:
															goto IL_356;
														}
														continue;
													}
													IL_356:
													if (binaryWriter == null)
													{
														break;
													}
													num = (short)384368640;
													num2 = (int)((global::System.IntPtr)num);
												}
												IL_38E:;
											}
											num = (short)919732224;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_F2;
											}
											continue;
										case 3:
											goto IL_10A;
										}
										IL_F2:
										if (fileStream == null)
										{
											num = (short)1068957699;
											num2 = (int)((global::System.IntPtr)num);
										}
										else
										{
											global::System.IO.BinaryWriter binaryWriter = new global::System.IO.BinaryWriter(fileStream, global::System.Text.Encoding.UTF8);
											num = (short)68288513;
											num2 = (int)((global::System.IntPtr)num);
										}
									}
									IL_10A:
									throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꇦꇨ듪ꓬ臮藰雲蟴駶飸韺ꋼ뫾猀焂樄甆", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꇦ胨蟪裬볮藰臲郴零铸\udbfa鋼鷾欀昂昄猆⤈栊戌税紐眒㔔礖瘘漚㴜紞䐠̢䘤唦䰨䨪夬䨮唰", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, null);
									IL_3AA:;
								}
								finally
								{
									num = (short)1980366850;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											((global::System.IDisposable)fileStream).Dispose();
											num = (short)313982977;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											goto IL_417;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_3E0;
											}
											continue;
										}
										IL_3E0:
										if (fileStream == null)
										{
											break;
										}
										num = (short)437190656;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_417:;
								}
								return;
							}
							catch (global::System.UnauthorizedAccessException innerException)
							{
								throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꇦꇨ듪뫬鷮飰蟲郴ꣶ룸飺黼髾爀瀂娄䌆氈攊搌樎甐", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꓦ裨藪菬胮藰폲苴藶郸迺飼\udffe甀氂┄甆氈樊椌∎縐紒礔渖㤘級琜猞䐠༢Ԥ䠦嬨ପ䰬䰮到嘲䘴䐶ᤸ强堼儾⡀♂⅄杆㹈⍊⡌ⅎ煐⑒❔㹖ⵘ㉚㍜㡞䅠բ౤୦౨", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, innerException);
							}
							catch (global::System.IO.IOException innerException2)
							{
								throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꇦꇨ듪ꋬ鿮铰鷲ꫴ뻶뛸ꓺ룼跾猀氂眄", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("껦웨ꓪ췬諮菰臲髴藶\ud9f8铺黼鳾琀焂瘄⬆⤈堊栌樎ㄐ縒稔攖簘㬚琜焞䜠䰢圤䨦䠨弪䐬䀮弰ጲ尴夶ᤸ伺唼娾慀⩂⭄⥆ⱈ㥊浌⩎⥐げご❖ⵘ㉚㉜ㅞ你", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, innerException2);
							}
							catch (global::System.Exception ex)
							{
								if (ex is global::AcpExceptionLib.AcpException)
								{
									throw;
								}
								throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꇦꇨ듪ꓬ臮藰雲蟴駶飸韺ꋼ뫾猀焂樄甆", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("듦賨軪췬苮黰臲郴ퟶ郸闺鯼郾猀渂搄猆怈搊挌⼎砐紒㔔挖焘縚㴜瘞传䴢䀤唦न个唬䰮吰䌲䄴帶嘸唺ጼ", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, ex);
							}
							goto IL_49F;
						case 3:
							if (writeBuffer == null)
							{
								num = (short)441712644;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_49F;
						case 4:
							goto IL_82;
						}
						break;
						IL_49F:
						num = (short)2136993848;
						short num3 = num;
						num = (short)1896542264;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_27;
						default:
							num = (short)2124546048;
							if (num != 0)
							{
							}
							num = (short)1935540224;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_4C:
					binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
					num = (short)545652739;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				IL_82:
				num = (short)216465409;
				if (num != 0)
				{
				}
				throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꇦꇨ듪ꓬ臮藰雲蟴駶飸韺ꋼ뫾猀焂樄甆", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("郦鯨苪駬諮돰蛲鏴釶鳸觺\uddfc鳾怀洂欄栆紈⬊漌樎ㄐ紒怔笖甘㔚", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, null);
				IL_528:
				num = (short)443547648;
				short num4 = num;
				throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꇦꇨ듪뫬鷮飰蟲郴ꣶ뷸鋺軼链帀䔂瀄欆攈", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꧦ蛨鿪췬諮鿰鳲胴郶釸\udbfa鯼跾搀昂┄理礈樊渌樎ㄐ簒笔㜖洘猚砜㼞䔠䨢嘤䰦", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, null);
			}
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00005234 File Offset: 0x00003434
		public void ReadFile<T>(out T readBuffer, out global::AcpFileHandlerLib.AcpFileHeader fileHeader, string filePath, bool decrypt, global::System.Collections.Generic.IEnumerable<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> allowedTypes)
		{
			int a_ = 1;
			short num = (short)1024589824;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_8D;
					case 1:
						goto IL_F9;
					case 2:
					{
						if (!global::System.IO.File.Exists(filePath))
						{
							num = (short)372768768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1012727809;
						if (num != 0)
						{
						}
						num = (short)1404239872;
						short num3 = num;
						num = (short)115539969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_43;
				}
				IL_8D:
				throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꛟꫡ믣ꃥ臧蛩觫뇭뻯鷱胳꧵뻷闹觻都擿", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("듟諡臣웥軧菩胫语탯雱鯳鏵请\udaf9鋻釽瓿∁愃縅愇礉砋‍", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, null);
				IL_F9:
				global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_13C;
					}
					global::System.IO.FileStream fileStream;
					for (;;)
					{
						IL_129:
						switch (num2)
						{
						case 0:
							goto IL_1F3;
						case 1:
							goto IL_37A;
						case 2:
						{
							try
							{
								global::AcpFileHandlerLib.AcpFileHandler.VerifySerializedFile(fileStream, decrypt, allowedTypes);
								goto IL_15D;
							}
							finally
							{
								num = (short)1395982338;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										((global::System.IDisposable)fileStream).Dispose();
										num = (short)1747976193;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_1F0;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_1BB;
										}
										continue;
									}
									IL_1BB:
									if (fileStream == null)
									{
										break;
									}
									num = (short)130285568;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_1F0:;
							}
							goto Block_4;
							IL_15D:
							global::System.IO.FileStream fileStream2 = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
							num = (short)376766464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_13C;
						Block_4:
						try
						{
							IL_1F3:
							num = (short)1562378242;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_23E;
								case 1:
									goto IL_2A0;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_225;
									}
									continue;
								}
								IL_225:
								global::System.IO.FileStream fileStream2;
								if (fileStream2 == null)
								{
									num = (short)1189740544;
									num2 = (int)((global::System.IntPtr)num);
								}
								else
								{
									global::AcpFileHandlerLib.ACPFileCopyRightInfomation.Instance.SkipCopyRightInfoIfHas(fileStream2);
									fileHeader = (global::AcpFileHandlerLib.AcpFileHeader)binaryFormatter.Deserialize(fileStream2);
									global::AcpFileHandlerLib.AcpFileHandler.a<T>(out readBuffer, fileStream2, decrypt);
									num = (short)555024385;
									num2 = (int)((global::System.IntPtr)num);
								}
							}
							IL_23E:
							throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꛟꫡ믣꿥蛧黩觫鳭黯鏱飳꧵뷷裹軻釽狿", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꛟ诡裣菥믧黩黫语釯鿱퓳駵髷郹駻鷽瓿∁會椅紇昉栋⸍縏紑怓㘕稗缙㰛紝刟䜡䔣別䴧丩", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, null);
							IL_2A0:;
						}
						finally
						{
							num = (short)1954414594;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.IO.FileStream fileStream2;
								switch (num2)
								{
								case 0:
									((global::System.IDisposable)fileStream2).Dispose();
									num = (short)1085800449;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_35E;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2D8;
									}
									continue;
								}
								IL_2D8:
								if (fileStream2 == null)
								{
									break;
								}
								num = (short)1506408257;
								short num4 = num;
								num = (short)714536769;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_35E;
								default:
									num = (short)657850368;
									if (num != 0)
									{
									}
									num = (short)1003749376;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_35E:;
						}
						num = (short)2102984705;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_37A:
					return;
					IL_13C:
					fileStream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
					num = (short)2043150338;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_129;
				}
				catch (global::System.Runtime.Serialization.SerializationException innerException)
				{
					throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꛟꫡ믣껥跧诩裫语苯귱꛳鏵駷黹ꏻ룽懿欁栃", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꓟ蟡韣菥髧菩跫苭駯裱闳苵釷闹鋻\udefd替持洃樅⠇渉礋欍』昑笓㘕笗甙減氝唟刡倣䌥䰧਩䌫尭ု嬱娳䀵夷嘹唻娽怿⑁ⵃ⩅ⵇ橉⑋⭍ㅏ㙑ㅓ⑕硗㱙㍛ⱝൟ͡ၣ䡥", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, innerException);
				}
				catch (global::System.InvalidCastException)
				{
					throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꛟꫡ믣ꃥ臧蛩觫뇭뷯鯱蟳藵釷铹鯻ꇽ䣿朁攃戅洇砉", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("듟諡臣웥軧菩胫语탯雱鯳鏵请\udaf9鋻釽瓿∁會椅昇縉洋服縏㈑爓缕琗缙㰛瘝䔟䌡䀣䌥娧", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, null);
				}
				catch (global::System.IO.IOException innerException2)
				{
					throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꛟꫡ믣ꧥ飧迩苫뇭맯뷱꯳돵諷裹鏻賽", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("꧟췡ꯣ웥跧飩黫臭苯틱鯳闵鯷迹軻跽⳿∁圃挅洇⨉愋愍戏眑㐓缕瘗簙猛氝䴟䌡倣伥䜧䐩ఫ䜭帯ሱ䀳帵崷ᨹ唻倽⸿❁㙃晅ⵇ㉉⽋⭍⁏♑㵓㥕㙗瑙", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, innerException2);
				}
				catch (global::System.Exception ex)
				{
					if (ex is global::AcpExceptionLib.AcpException)
					{
						throw;
					}
					throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꛟꫡ믣꿥蛧黩觫鳭黯鏱飳꧵뷷裹軻釽狿", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("돟蟡臣웥藧藩黫语탯鯱髳郵韷裹釻鿽瓿欁欃栅⠇按戋⸍搏稑焓㘕焗琙爛笝刟ȡ䄣帥䬧伩尫娭夯崱娳ᠵ", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, ex);
				}
				return;
				IL_43:
				binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
				binaryFormatter.AssemblyFormat = global::System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
				fileHeader = null;
				readBuffer = default(T);
				num = (short)1978597378;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000056FC File Offset: 0x000038FC
		public void ReadFile<T>(out T readBuffer, string filePath, bool decrypt, global::System.Collections.Generic.IEnumerable<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> allowedTypes)
		{
			int a_ = 3;
			short num = (short)384827392;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_AB;
					case 1:
						goto IL_3BB;
					case 2:
					{
						if (!global::System.IO.File.Exists(filePath))
						{
							num = (short)1371078656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)403570688;
						short num3 = num;
						num = (short)1226244097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_43;
				}
				IL_AB:
				IL_355:
				throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꓡ곣맥껧菩胫语꿯볱鯳苵ꟷ볹鏻诽滿昁", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("뛡賣菥죧賩藫苭闯틱郳駵鷷觹\udcfb都濿瘁␃挅瀇按缋稍㸏", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, null);
				IL_3BB:
				try
				{
					switch (0)
					{
					case 0:
						goto IL_CD;
					}
					global::System.IO.FileStream fileStream2;
					for (;;)
					{
						IL_BA:
						global::System.IO.FileStream fileStream;
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)1663631362;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_13C;
									case 1:
										goto IL_17F;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_124;
										}
										continue;
									}
									IL_124:
									if (fileStream == null)
									{
										num = (short)936181760;
										num2 = (int)((global::System.IntPtr)num);
									}
									else
									{
										global::AcpFileHandlerLib.AcpFileHandler.a<T>(out readBuffer, fileStream, decrypt);
										num = (short)343736321;
										num2 = (int)((global::System.IntPtr)num);
									}
								}
								IL_13C:
								throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꓡ곣맥ꇧ蓩飫语苯鳱闳髵ꟷ뿹軻賽濿瀁", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꓡ跣諥跧맩飫鳭闯鏱駳훵韷飹電鯽揿瘁␃攅朇缉怋樍』簑笓戕㠗砙礛㸝䌟倡䄣䜥尧伩䠫", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, null);
								IL_17F:
								goto IL_2E2;
							}
							finally
							{
								num = (short)1247150082;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										((global::System.IDisposable)fileStream).Dispose();
										num = (short)317718529;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_1EE;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_1B8;
										}
										continue;
									}
									IL_1B8:
									if (fileStream == null)
									{
										break;
									}
									num = (short)1675886592;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_1EE:;
							}
							goto Block_4;
							IL_2E2:
							num = (short)554893313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_2FA;
						case 2:
							goto IL_1F1;
						}
						goto IL_CD;
						Block_4:
						try
						{
							IL_1F1:
							global::AcpFileHandlerLib.AcpFileHandler.VerifySerializedFile(fileStream2, decrypt, allowedTypes);
						}
						finally
						{
							num = (short)546963458;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									((global::System.IDisposable)fileStream2).Dispose();
									num = (short)1199702017;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2B7;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_231;
									}
									continue;
								}
								IL_231:
								if (fileStream2 == null)
								{
									break;
								}
								num = (short)864906279;
								short num4 = num;
								num = (short)1887398951;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_2B7;
								default:
									num = (short)1505755136;
									if (num != 0)
									{
									}
									num = (short)1435435008;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_2B7:;
						}
						fileStream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
						num = (short)613548032;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2FA:
					return;
					IL_CD:
					fileStream2 = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
					num = (short)2131820546;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_BA;
				}
				catch (global::System.IO.IOException innerException)
				{
					throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꓡ곣맥꟧髩觫胭꿯믱믳꧵뷷裹軻釽狿", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꯡ쯣ꧥ죧迩黫鳭鿯胱퓳駵鯷駹觻賽珿⸁␃唅洇漉Ⰻ挍缏怑焓㘕焗琙稛焝刟伡䔣別䄧䔩䈫อ夯就ᐳ䈵倷弹᰻圽⸿ⱁ⅃㑅桇⽉㑋ⵍ㕏≑⁓㽕㝗㑙牛", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, innerException);
				}
				catch (global::System.Exception ex)
				{
					if (ex is global::AcpExceptionLib.AcpException)
					{
						throw;
					}
					throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꓡ곣맥ꇧ蓩飫语苯鳱闳髵ꟷ뿹軻賽濿瀁", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("뇡臣菥죧蟩菫鳭闯틱鷳飵黷闹軻鏽懿瘁洃椅昇⨉攋怍』昑簓猕㠗猙爛瀝䔟倡У䌥倧䤩䤫席䐯嬱嬳堵ᘷ", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, ex);
				}
				goto IL_355;
				IL_43:
				num = (short)1555496961;
				if (num != 0)
				{
				}
				readBuffer = default(T);
				num = (short)2129985538;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00005B30 File Offset: 0x00003D30
		public void ReadFile(out byte[] readBuffer, out global::AcpFileHandlerLib.AcpFileHeader fileHeader, string filePath, bool decrypt)
		{
			int a_ = 19;
			short num = (short)512557056;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1894514689;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_69;
				}
				for (;;)
				{
					IL_56:
					switch (num2)
					{
					case 0:
						goto IL_BD;
					case 1:
						goto IL_A5;
					case 2:
						if (!global::System.IO.File.Exists(filePath))
						{
							num = (short)372572161;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)628752384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_69;
				}
				IL_A5:
				num = (short)116523008;
				short num3 = num;
				throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("등볳꧵뻷鏹郻鯽忿䰁欃爅圇䰉挋笍縏瘑", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("꛱鳳鏵\ud8f7鳹闻鋽旿∁怃椅洇礉Ⰻ怍缏昑㐓猕怗猙漛樝ฟ", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, null);
				IL_BD:
				global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter;
				try
				{
					global::System.IO.FileStream fileStream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
					try
					{
						num = (short)45088770;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1B2;
							case 1:
								goto IL_160;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_148;
								}
								continue;
							}
							IL_148:
							if (fileStream == null)
							{
								num = (short)2025521153;
								num2 = (int)((global::System.IntPtr)num);
							}
							else
							{
								fileHeader = (global::AcpFileHandlerLib.AcpFileHeader)binaryFormatter.Deserialize(fileStream);
								global::AcpFileHandlerLib.AcpFileHandler.a(out readBuffer, fileStream, decrypt);
								num = (short)2027749376;
								num2 = (int)((global::System.IntPtr)num);
							}
						}
						IL_160:
						throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("등볳꧵뇷铹裻鯽狿氁攃樅圇伉縋簍缏怑", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("등鷳髵鷷꧹裻賽旿持椃★朇栉昋欍猏昑㐓甕眗漙瀛稝\u001f䰡䬣別ࠧ䠩䤫อ匯䀱儳圵䰷弹堻", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, null);
						IL_1B2:;
					}
					finally
					{
						num = (short)880738306;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_21B;
							case 1:
								((global::System.IDisposable)fileStream).Dispose();
								num = (short)140443648;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1E6;
								}
								continue;
							}
							IL_1E6:
							if (fileStream == null)
							{
								break;
							}
							num = (short)1554841601;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_21B:;
					}
				}
				catch (global::System.Runtime.Serialization.SerializationException innerException)
				{
					throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("등볳꧵냷鿹鷻髽旿瀁嬃吅洇欉栋儍嘏猑紓稕", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("뛱釳藵鷷裹闻鿽泿欁縃朅簇按挋怍』琑甓缕琗㨙砛欝䔟ȡ倣䤥ࠧ䤩䌫尭䈯䜱䐳䈵崷帹᰻儽㈿扁ⵃ⡅㹇⭉⁋❍㑏牑㉓㽕㑗㽙籛㙝՟͡cͥᩧ䩩੫ŭɯάᕳɵ噷", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, innerException);
				}
				catch (global::System.InvalidCastException)
				{
					throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("등볳꧵뻷鏹郻鯽忿企洃甅笇按戋植伏娑焓眕簗缙減", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("꛱鳳鏵\ud8f7鳹闻鋽旿∁怃椅洇礉Ⰻ怍缏昑㐓甕眗琙栛缝䤟䰡У䀥䄧䘩䤫อ堯圱唳刵崷䠹", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, null);
				}
				catch (global::System.IO.IOException innerException2)
				{
					throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("등볳꧵럷諹駻都忿䬁䬃夅䴇砉縋愍戏", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("믱\udbf3맵\ud8f7鿹軻賽濿瀁␃椅欇椉礋簍挏㸑㐓䔕紗缙㰛猝伟倡䄣إ䄧䐩䨫䄭䈯弱唳䈵儷唹刻ḽ⤿ⱁ摃㉅⁇⽉汋❍㹏㱑ㅓ⑕硗㽙⑛㵝՟ቡၣཥݧѩ䉫", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, innerException2);
				}
				catch (global::System.Exception ex)
				{
					if (!(ex is global::AcpExceptionLib.AcpException))
					{
						num = (short)1898013478;
						short num4 = num;
						num = (short)887120678;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)839843840;
							if (num != 0)
							{
							}
							throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("등볳꧵뇷铹裻鯽狿氁攃樅圇伉縋簍缏怑", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꇱ釳鏵\ud8f7韹鏻賽旿∁洃栅渇攉縋挍焏昑紓礕瘗㨙甛瀝\u001f嘡䰣䌥ࠧ䌩䈫䀭唯䀱ᐳ匵䀷夹夻丽㐿⭁⭃⡅晇", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, ex);
						}
					}
					throw;
				}
				return;
				IL_69:
				readBuffer = null;
				binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
				num = (short)1642266626;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_56;
			}
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00005ECC File Offset: 0x000040CC
		public void ReadFile(out byte[] readBuffer, string filePath, bool decrypt)
		{
			int a_ = 2;
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
					goto IL_26A;
				case 1:
					goto IL_5B;
				case 2:
				{
					if (!global::System.IO.File.Exists(filePath))
					{
						num2 = (short)1653342209;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2136932352;
					short num3 = num2;
					num2 = (short)1645150208;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_25;
			}
			IL_5B:
			IL_206:
			throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("꟠ꯢ뫤ꇦ胨蟪裬냮뿰鳲致ꣶ뿸铺裼釾攀", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("뗠询胤쟦迨苪臬諮퇰韲髴鋶諸\udbfa鏼郾甀⌂怄缆怈砊礌ℎ", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, null);
			IL_26A:
			num2 = (short)1181745153;
			if (num2 != 0)
			{
			}
			try
			{
				global::System.IO.FileStream fileStream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
				try
				{
					num2 = (short)1814953986;
					num = (int)((global::System.IntPtr)num2);
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_F4;
						case 1:
							goto IL_B2;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_9B;
							}
							continue;
						}
						IL_9B:
						if (fileStream == null)
						{
							num2 = (short)229900289;
							num = (int)((global::System.IntPtr)num2);
						}
						else
						{
							global::AcpFileHandlerLib.AcpFileHandler.a(out readBuffer, fileStream, decrypt);
							num2 = (short)419430400;
							num = (int)((global::System.IntPtr)num2);
						}
					}
					IL_B2:
					throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("꟠ꯢ뫤껦蟨鿪裬鷮鿰鋲駴ꣶ본觺迼郾猀", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("꟠諢觤苦뫨鿪鿬諮郰黲헴飶鯸釺飼鳾甀⌂昄栆簈朊椌⼎缐簒愔㜖笘縚㴜簞匠䘢䐤匦䰨伪", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, null);
					IL_F4:;
				}
				finally
				{
					num2 = (short)1273954306;
					num = (int)((global::System.IntPtr)num2);
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_15B;
						case 1:
							((global::System.IDisposable)fileStream).Dispose();
							num2 = (short)1676345344;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_126;
							}
							continue;
						}
						IL_126:
						if (fileStream == null)
						{
							break;
						}
						num2 = (short)93323265;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_15B:;
				}
				return;
			}
			catch (global::System.IO.IOException innerException)
			{
				throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("꟠ꯢ뫤꣦駨軪菬냮룰볲ꫴ닶诸觺鋼跾", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("꣠쳢ꫤ쟦賨駪鿬胮菰폲髴银髸軺迼賾ⴀ⌂嘄戆氈⬊怌怎挐瘒㔔縖眘級爜洞䰠䈢儤並䘨䔪ബ䘮弰ጲ䄴弶尸ᬺ吼儾⽀♂㝄杆ⱈ㍊⹌⩎⅐❒㱔㡖㝘畚", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, innerException);
			}
			catch (global::System.Exception ex)
			{
				if (!(ex is global::AcpExceptionLib.AcpException))
				{
					num2 = (short)850688981;
					short num4 = num2;
					num2 = (short)1401125845;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1507459072;
						if (num2 != 0)
						{
						}
						throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("꟠ꯢ뫤껦蟨鿪裬鷮鿰鋲駴ꣶ본觺迼郾猀", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("닠蛢胤쟦蓨蓪鿬諮퇰髲鯴釶雸觺郼黾甀樂樄椆⤈戊挌⼎攐笒瀔㜖瀘甚猜稞匠̢䀤弦䨨个崬嬮堰尲嬴ᤶ", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, ex);
					}
				}
				throw;
			}
			goto IL_206;
			IL_25:
			readBuffer = null;
			num2 = (short)578551810;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000061BC File Offset: 0x000043BC
		public global::AcpFileHandlerLib.AcpFileHeader ReadHeader(string filePath)
		{
			int a_ = 19;
			short num = (short)112328704;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						goto IL_C3;
					case 1:
						goto IL_7F;
					case 2:
						if (!global::System.IO.File.Exists(filePath))
						{
							num = (short)1685520385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)708444160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_44;
				}
				IL_7F:
				num = (short)511246337;
				if (num != 0)
				{
				}
				num = (short)920846336;
				short num3 = num;
				throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("등볳꧵뻷鏹郻鯽忿䰁欃爅圇䰉挋笍縏瘑", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("꛱鳳鏵\ud8f7鳹闻鋽旿∁怃椅洇礉Ⰻ怍缏昑㐓猕怗猙漛樝ฟ", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, null);
				IL_C3:
				global::AcpFileHandlerLib.AcpFileHeader result;
				try
				{
					global::System.IO.FileStream fileStream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
					try
					{
						result = global::AcpFileHandlerLib.AcpFileHandler.a(fileStream);
					}
					finally
					{
						num = (short)1068500513;
						short num4 = num;
						num = (short)127206945;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_1AB:
							num = (short)1600061441;
							num2 = (int)((global::System.IntPtr)num);
							break;
						default:
							num = (short)1422983168;
							if (num != 0)
							{
							}
							num = (short)1390804994;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1DF;
							case 1:
								((global::System.IDisposable)fileStream).Dispose();
								num = (short)1849425920;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1A8;
								}
								continue;
							}
							break;
						}
						IL_1A8:
						if (fileStream != null)
						{
							goto IL_1AB;
						}
						IL_1DF:;
					}
				}
				catch (global::System.Runtime.Serialization.SerializationException innerException)
				{
					throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("등볳꧵냷鿹鷻髽旿瀁嬃吅洇欉栋儍嘏猑紓稕", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("뛱釳藵鷷裹闻鿽泿欁縃朅簇按挋怍』琑甓缕琗㨙砛欝䔟ȡ倣䤥ࠧ䤩䌫尭䈯䜱䐳䈵崷帹᰻儽㈿扁ⵃ⡅㹇⭉⁋❍㑏牑㉓㽕㑗㽙籛㙝՟͡cͥᩧ䩩੫ŭɯάᕳɵ噷", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, innerException);
				}
				catch (global::System.InvalidCastException innerException2)
				{
					throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("등볳꧵뻷鏹郻鯽忿企洃甅笇按戋植伏娑焓眕簗缙減", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("꛱鳳鏵\ud8f7黹駻跽旿瀁洃朅搇按瘋欍琏㈑瀓眕気笙㰛樝够刡䄣إ䰧䔩䤫崭帯ᔱ䀳ᘵ唷嬹䠻崽⠿扁ぃ⹅ⵇ橉ോⵍ⁏ᑑ㵓㩕㵗቙㥛㽝џݡᙣ䙥ᱧ፩ᱫ୭幯", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, innerException2);
				}
				catch (global::System.IO.IOException innerException3)
				{
					throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("등볳꧵럷諹駻都忿䬁䬃夅䴇砉縋愍戏", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("믱\udbf3맵\ud8f7鿹軻賽濿瀁␃椅欇椉礋簍挏㸑㐓䔕紗缙㰛猝伟倡䄣إ䄧䐩䨫䄭䈯弱唳䈵儷唹刻ḽ⤿ⱁ摃㉅⁇⽉汋❍㹏㱑ㅓ⑕硗㽙⑛㵝՟ቡၣཥݧѩ䉫", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, innerException3);
				}
				catch (global::System.Exception innerException4)
				{
					throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("등볳꧵뇷铹裻鯽狿氁攃樅圇伉縋簍缏怑", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꇱ釳鏵\ud8f7韹鏻賽旿∁洃栅渇攉縋挍焏昑紓礕瘗㨙甛瀝\u001f嘡䰣䌥ࠧ䌩䈫䀭唯䀱ᐳ匵䀷夹夻丽㐿⭁⭃⡅晇", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, innerException4);
				}
				return result;
				IL_44:
				new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
				num = (short)1933180930;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00006484 File Offset: 0x00004684
		public static void VerifySerializedFile(global::System.IO.FileStream fs, bool encrypted, global::System.Collections.Generic.IEnumerable<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> allowedTypes)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			byte[] array;
			short num2;
			for (;;)
			{
				IL_0A:
				global::AcpCryptoLib.AcpCryptoStream acpCryptoStream;
				switch (num)
				{
				case 0:
					goto IL_19F;
				case 1:
					try
					{
						global::AcpFileHandlerLib.AcpFileHandler.a(global::AcpFileHandlerLib.AcpFileHandler.a(fs, acpCryptoStream), array, (int)fs.Length);
						goto IL_1CA;
					}
					finally
					{
						num2 = (short)865730923;
						short num3 = num2;
						num2 = (short)866255211;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_FE:
							num2 = (short)1183318017;
							if (num2 != 0)
							{
							}
							num2 = (short)223019009;
							num = (int)((global::System.IntPtr)num2);
							break;
						default:
							num2 = (short)1399324672;
							if (num2 != 0)
							{
							}
							num2 = (short)537198594;
							num = (int)((global::System.IntPtr)num2);
							break;
						}
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_155;
							case 1:
								((global::System.IDisposable)acpCryptoStream).Dispose();
								num2 = (short)636878848;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_FB;
								}
								continue;
							}
							break;
						}
						IL_FB:
						if (acpCryptoStream != null)
						{
							goto IL_FE;
						}
						IL_155:;
					}
					goto IL_158;
				case 2:
					goto IL_158;
				case 3:
					if (encrypted)
					{
						num2 = (short)1679949826;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::AcpFileHandlerLib.AcpFileHandler.a(fs, array, (int)fs.Length);
					num2 = (short)1089142784;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
				IL_158:
				acpCryptoStream = new global::AcpCryptoLib.AcpCryptoStream();
				num2 = (short)1810300929;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_19F:
			num2 = (short)1990983680;
			short num4 = num2;
			IL_1CA:
			global::AcpFileHandlerLib.AcpFileHandler.a(array, allowedTypes);
			return;
			IL_20:
			global::AcpFileHandlerLib.AcpFileHandler.a(fs);
			array = new byte[fs.Length];
			num2 = (short)981270531;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00006674 File Offset: 0x00004874
		private static global::AcpFileHandlerLib.AcpFileHeader a(global::System.IO.FileStream A_0)
		{
			short num = (short)2013502812;
			short num2 = num;
			num = (short)1346739548;
			switch (num2 == num)
			{
			}
			num = (short)1103101953;
			if (num != 0)
			{
			}
			num = (short)231014400;
			if (num != 0)
			{
			}
			num = (short)87687168;
			short num3 = num;
			global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
			byte[] array = new byte[A_0.Length];
			global::AcpFileHandlerLib.AcpFileHandler.a(A_0, array, (int)A_0.Length);
			byte[] array2 = global::AcpFileHandlerLib.ACPFileCopyRightInfomation.Instance.SkipCopyRightInfoIfHas(array);
			global::AcpFileHandlerLib.AcpFileHandler.a(array2, global::AcpFileHandlerLib.AcpFileHandler.a);
			A_0.Position = (long)(array.Length - array2.Length);
			return (global::AcpFileHandlerLib.AcpFileHeader)binaryFormatter.Deserialize(A_0);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00006770 File Offset: 0x00004970
		private static global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult a(byte[] A_0, global::System.Collections.Generic.IEnumerable<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> A_1)
		{
			int a_ = 17;
			short num = (short)1104805889;
			if (num != 0)
			{
			}
			num = (short)1524636634;
			short num2 = num;
			num = (short)2040667098;
			switch (num2 == num)
			{
			}
			num = (short)123076608;
			if (num != 0)
			{
			}
			num = (short)608174080;
			short num3 = num;
			global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult binarySerializerVerificationResult = new global::Motorola.Common.BinarySerializer.BinarySerializer().Parse(A_0).Verify(A_1);
			if (binarySerializerVerificationResult.CheckFailed)
			{
				throw new global::System.Runtime.Serialization.SerializationException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("뛯鯱飳鏵\ud8f7韹闻駽棿瘁␃搅洇⨉漋愍戏怑愓昕気缙砛", a_));
			}
			return binarySerializerVerificationResult;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00006854 File Offset: 0x00004A54
		public byte[] EncodeStringToByteArray(string str)
		{
			short num = (short)437910358;
			short num2 = num;
			num = (short)1201666902;
			switch (num2 == num)
			{
			}
			num = (short)1194852353;
			if (num != 0)
			{
			}
			num = (short)482017280;
			if (num != 0)
			{
			}
			num = (short)1153171456;
			short num3 = num;
			return new global::System.Text.UTF8Encoding().GetBytes(str);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00006908 File Offset: 0x00004B08
		public string DecodeByteArrayToString(byte[] bytes)
		{
			short num = (short)1855699811;
			short num2 = num;
			num = (short)870955875;
			switch (num2 == num)
			{
			}
			num = (short)1987182593;
			if (num != 0)
			{
			}
			num = (short)1724055552;
			if (num != 0)
			{
			}
			num = (short)1160052736;
			short num3 = num;
			return new global::System.Text.UTF8Encoding().GetString(bytes);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000069C0 File Offset: 0x00004BC0
		private static global::System.Security.Cryptography.CryptoStream b(global::System.IO.FileStream A_0, global::AcpCryptoLib.AcpCryptoStream A_1)
		{
			int a_ = 2;
			short num;
			global::System.Security.Cryptography.CryptoStream result;
			try
			{
				num = (short)732780407;
				short num2 = num;
				num = (short)1539200887;
				switch (num2 == num)
				{
				}
				num = (short)564789248;
				if (num != 0)
				{
				}
				result = (global::System.Security.Cryptography.CryptoStream)A_1.GetWriter(A_0);
			}
			catch (global::System.Exception innerException)
			{
				throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("꟠ꯢ뫤ꇦ胨蟪裬냮듰鷲雴藶胸诺觼雾渀洂娄䄆栈戊愌", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꓠ跢蛤闦部鯪駬蛮黰鷲헴釶飸鋺釼", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, innerException);
			}
			num = (short)1949630465;
			if (num != 0)
			{
			}
			num = (short)991297536;
			short num3 = num;
			return result;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00006AB8 File Offset: 0x00004CB8
		private static byte[] b(byte[] A_0)
		{
			int a_ = 12;
			short num;
			byte[] result;
			try
			{
				num = (short)482738310;
				short num2 = num;
				num = (short)2088435846;
				switch (num2 == num)
				{
				}
				num = (short)622067712;
				if (num != 0)
				{
				}
				result = new global::AcpCryptoLib.AcpEncryptDecrypt().Encrypt(A_0);
			}
			catch (global::System.Exception innerException)
			{
				throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("귪ꗬ냮런髲駴鋶꛸뻺鏼鳾猀稂甄猆怈搊挌倎圐爒簔笖", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("껪菬賮菰諲藴菶郸铺鏼\udffe最戂氄欆", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, innerException);
			}
			num = (short)1850736641;
			if (num != 0)
			{
			}
			num = (short)1328349184;
			short num3 = num;
			return result;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00006BB0 File Offset: 0x00004DB0
		private static global::System.Security.Cryptography.CryptoStream a(global::System.IO.FileStream A_0, global::AcpCryptoLib.AcpCryptoStream A_1)
		{
			int a_ = 4;
			short num;
			global::System.Security.Cryptography.CryptoStream result;
			try
			{
				num = (short)1361812454;
				short num2 = num;
				num = (short)497064934;
				switch (num2 == num)
				{
				}
				num = (short)476250112;
				if (num != 0)
				{
				}
				result = (global::System.Security.Cryptography.CryptoStream)A_1.GetReader(A_0);
			}
			catch (global::System.Exception innerException)
			{
				throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꗢ귤룦꿨苪臬諮껰럲郴银诸苺跼课栀氂欄堆伈樊搌挎", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("꟢胤蓦鯨鋪鷬鯮飰鳲鯴ퟶ鿸髺铼鏾", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, innerException);
			}
			num = (short)578682881;
			if (num != 0)
			{
			}
			num = (short)1832583168;
			short num3 = num;
			return result;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00006CA8 File Offset: 0x00004EA8
		private static byte[] a(byte[] A_0)
		{
			int a_ = 8;
			short num;
			byte[] result;
			try
			{
				num = (short)1568798108;
				short num2 = num;
				num = (short)1398404508;
				switch (num2 == num)
				{
				}
				num = (short)1459290112;
				if (num != 0)
				{
				}
				result = new global::AcpCryptoLib.AcpEncryptDecrypt().Decrypt(A_0);
			}
			catch (global::System.Exception innerException)
			{
				throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꇦꇨ듪꯬蛮鷰雲ꫴ돶鳸飺迼蛾焀眂氄栆月吊䬌渎砐缒", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꏦ賨裪鿬雮臰蟲鳴飶韸\udbfa鯼黾栀漂", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, innerException);
			}
			num = (short)943849473;
			if (num != 0)
			{
			}
			num = (short)989790208;
			short num3 = num;
			return result;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00006DA0 File Offset: 0x00004FA0
		private static bool a(string A_0, long A_1)
		{
			short num = (short)561262037;
			short num2 = num;
			num = (short)1621962197;
			switch (num2 == num)
			{
			}
			num = (short)436011008;
			if (num != 0)
			{
			}
			num = (short)1051131905;
			if (num != 0)
			{
			}
			num = (short)460980224;
			short num3 = num;
			uint num4;
			uint num5;
			uint num6;
			uint num7;
			global::AcpFileHandlerLib.j.GetDiskFreeSpace(global::System.IO.Directory.GetDirectoryRoot(A_0), out num4, out num5, out num6, out num7);
			return (ulong)num6 * (ulong)num4 * (ulong)num5 < (ulong)(A_1 + 256L);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00006E70 File Offset: 0x00005070
		private static void a<a>(out a A_0, global::System.IO.FileStream A_1, bool A_2)
		{
			int a_ = 14;
			short num = (short)2080899072;
			switch (num)
			{
			default:
			{
				global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
				try
				{
					num = (short)1484455940;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1BA;
						case 1:
						{
							global::AcpCryptoLib.AcpCryptoStream acpCryptoStream = new global::AcpCryptoLib.AcpCryptoStream();
							num = (short)958332930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							try
							{
								global::AcpCryptoLib.AcpCryptoStream acpCryptoStream;
								A_0 = (a)((object)binaryFormatter.Deserialize(global::AcpFileHandlerLib.AcpFileHandler.a(A_1, acpCryptoStream)));
							}
							finally
							{
								num = (short)1559644683;
								short num3 = num;
								num = (short)44452363;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_16C:
									num = (short)1671757825;
									num2 = (int)((global::System.IntPtr)num);
									break;
								default:
									num = (short)415629312;
									if (num != 0)
									{
									}
									num = (short)250413058;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
								global::AcpCryptoLib.AcpCryptoStream acpCryptoStream;
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_19E;
									case 1:
										((global::System.IDisposable)acpCryptoStream).Dispose();
										num = (short)303759360;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_169;
										}
										continue;
									}
									break;
								}
								IL_169:
								if (acpCryptoStream != null)
								{
									goto IL_16C;
								}
								IL_19E:;
							}
							goto IL_1A1;
						case 3:
							goto IL_1A1;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_6A;
							}
							continue;
						}
						IL_6A:
						if (A_2)
						{
							num = (short)1231355905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_0 = (a)((object)binaryFormatter.Deserialize(A_1));
						num = (short)1888550915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1A1:
						num = (short)2041643008;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1BA:;
				}
				catch (global::System.Runtime.Serialization.SerializationException innerException)
				{
					throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("꯬꟮껰ꇲ郴零鷸ꓺ민雾洀昂娄䄆栈戊愌", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("룬臮郰釲駴鋶\ud9f8迺鋼\udffe攀昂瘄戆笈戊氌挎砐椒瀔㜖洘猚砜㼞䜠䨢䤤䈦न䠪䈬䄮䔰嘲嬴䌶", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, innerException);
				}
				catch (global::System.InvalidCastException innerException2)
				{
					throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("꯬꟮껰ꇲ郴零鷸ꓺ민雾洀昂娄䄆栈戊愌", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("맬蟮铰폲釴鋶諸黺迼雾怀漂氄紆氈漊ⴌ欎瀐朒琔㜖洘戚洜稞Ġ䜢䨤䈦娨䔪ਬ嬮ᄰ帲吴䌶娸区ᴼ䬾⥀♂敄㕆ⱈ⩊⥌ൎ⑐㕒㍔㉖⭘筚⥜♞ᅠ٢䭤", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, innerException2);
				}
				num = (short)2037514241;
				if (num != 0)
				{
				}
				num = (short)672989184;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00007120 File Offset: 0x00005320
		private static void a(out byte[] A_0, global::System.IO.FileStream A_1, bool A_2)
		{
			int a_ = 1;
			long num = A_1.Length - A_1.Position;
			global::System.IO.BinaryReader binaryReader = new global::System.IO.BinaryReader(A_1, global::System.Text.Encoding.UTF8);
			short num2;
			try
			{
				num2 = (short)342097920;
				int num3 = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_71;
						}
						continue;
					case 1:
					{
						if (A_2)
						{
							num2 = (short)1796603912;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						}
						byte[] array;
						A_0 = array;
						num2 = (short)74121221;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
					{
						byte[] array;
						if (array == null)
						{
							num2 = (short)2027290630;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)174784516;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 3:
						goto IL_1AB;
					case 4:
					{
						byte[] array;
						if ((long)binaryReader.Read(array, 0, (int)num) != num)
						{
							num2 = (short)1767440387;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)59506689;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 5:
						goto IL_1EF;
					case 6:
						goto IL_C2;
					case 7:
						goto IL_166;
					case 8:
					{
						byte[] array;
						A_0 = global::AcpFileHandlerLib.AcpFileHandler.a(array);
						num2 = (short)903086087;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 9:
						goto IL_88;
					}
					IL_71:
					if (binaryReader == null)
					{
						num2 = (short)500563977;
						num3 = (int)((global::System.IntPtr)num2);
					}
					else
					{
						byte[] array = new byte[num];
						num2 = (short)365232130;
						num3 = (int)((global::System.IntPtr)num2);
					}
				}
				IL_88:
				throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꛟꫡ믣꿥蛧黩觫鳭黯鏱飳꧵뷷裹軻釽狿", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꋟ诡諣蟥髧鏩뻫语釯雱釳蓵\ud8f7闹黻铽旿愁瀃★欇攉礋戍琏㈑稓礕気㨙縛笝\u001f䄡嘣䌥䤧帩䤫䨭", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, null);
				IL_C2:
				throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꛟꫡ믣꿥蛧黩觫鳭黯鏱飳꧵뷷裹軻釽狿", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("苟鯡郣菥돧럩쳫臭鋯飱釳闵賷\udaf9鿻釽痿渁怃★昇攉砋⸍爏眑㐓甕樗缙紛樝䔟䘡", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, null);
				IL_166:
				goto IL_2CC;
				IL_1AB:
				throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꛟꫡ믣듥跧诩裫뇭뛯鯱飳鏵ꟷ볹鷻韽泿", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("껟韡解蓥跧飩쳫臭雯틱雳迵賷鿹迻\udefd狿朁攃戅⠇按缋⸍縏紑怓㘕欗笙焛笝\u001f䌡圣إ䴧利尫䬭匯䘱儳刵ᘷ", a_), global::AcpExceptionLib.AcpException.SeverityLevel.Error, null);
				IL_1EF:;
			}
			finally
			{
				num2 = (short)2016089692;
				short num4 = num2;
				num2 = (short)300160604;
				int num3;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_271:
					num2 = (short)296026113;
					num3 = (int)((global::System.IntPtr)num2);
					break;
				default:
					num2 = (short)1541013504;
					if (num2 != 0)
					{
					}
					num2 = (short)1633288194;
					num3 = (int)((global::System.IntPtr)num2);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_2C9;
					case 1:
						num2 = (short)2121334785;
						if (num2 != 0)
						{
						}
						((global::System.IDisposable)binaryReader).Dispose();
						num2 = (short)1505230848;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_26E;
						}
						continue;
					}
					break;
				}
				IL_26E:
				if (binaryReader != null)
				{
					goto IL_271;
				}
				IL_2C9:;
			}
			IL_2CC:
			num2 = (short)299499520;
			short num5 = num2;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00007440 File Offset: 0x00005640
		private static void a(global::System.IO.Stream A_0, byte[] A_1, int A_2)
		{
			short num2;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				int num5;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1745354752;
						short num3 = num2;
						goto IL_38;
					}
					case 1:
						goto IL_71;
					case 2:
					{
						int num4;
						if ((num4 = A_0.Read(A_1, num5, A_2 - num5)) <= 0)
						{
							num2 = (short)556335105;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1908539393;
						if (num2 != 0)
						{
						}
						num5 += num4;
						num2 = (short)1328480256;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 3:
						goto IL_38;
					}
					goto IL_20;
					IL_38:
					num2 = (short)68026370;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_71:
				num2 = (short)323872210;
				short num6 = num2;
				num2 = (short)1549264338;
				switch ((num6 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_A7;
				}
				IL_20:
				num5 = 0;
				num2 = (short)1719664643;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_A7:
			num2 = (short)73662464;
			if (num2 != 0)
			{
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00007580 File Offset: 0x00005780
		// Note: this type is marked as 'beforefieldinit'.
		static AcpFileHandler()
		{
			int a_ = 13;
			short num = (short)1228088503;
			short num2 = num;
			num = (short)1096295607;
			switch (num2 == num)
			{
			}
			num = (short)347734017;
			if (num != 0)
			{
			}
			num = (short)1804206080;
			if (num != 0)
			{
			}
			num = (short)940376064;
			short num3 = num;
			global::AcpFileHandlerLib.AcpFileHandler.a = new global::System.Collections.Generic.HashSet<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo>
			{
				new global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo(global::AcpFileHandlerLib.AcpSaveFileDialog.b("귫跭胯등鷳髵鷷당鷻都擿渁愃琅䐇按渋‍儏焑搓倕焗瘙礛嘝䔟䌡䀣䌥娧", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("귫跭胯등鷳髵鷷당鷻都擿渁愃琅䐇按渋", a_))
			};
		}

		// Token: 0x04000011 RID: 17
		private static readonly global::System.Collections.Generic.HashSet<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> a;
	}
}
