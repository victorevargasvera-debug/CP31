using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x02000056 RID: 86
	public class PBBUtility
	{
		// Token: 0x060001FD RID: 509 RVA: 0x0003222C File Offset: 0x0003042C
		public static void ExtractBuildFile(string file, out string manifest, out string resource)
		{
			int a_ = 10;
			short num = (short)729808896;
			short num2 = num;
			num = (short)277151744;
			switch (num)
			{
			default:
			{
				string tempPath = global::System.IO.Path.GetTempPath();
				manifest = string.Empty;
				resource = string.Empty;
				try
				{
					num = (short)1293942785;
					if (num != 0)
					{
					}
					global::System.IO.Compression.ZipArchive zipArchive = global::System.IO.Compression.ZipFile.OpenRead(file);
					try
					{
						global::System.Collections.Generic.IEnumerator<global::System.IO.Compression.ZipArchiveEntry> enumerator = zipArchive.Entries.GetEnumerator();
						try
						{
							num = (short)285868034;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										goto IL_110;
									}
									global::System.IO.Compression.ZipArchiveEntry zipArchiveEntry = enumerator.Current;
									num = (short)742326279;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::System.IO.Compression.ZipArchiveEntry zipArchiveEntry;
									if (zipArchiveEntry.FullName.ToLower(global::System.Globalization.CultureInfo.CurrentCulture).EndsWith(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("뷎듐ꃒ뫔ꋖꯘ룚룜곞쿠苢韤铦諨", a_), global::System.StringComparison.OrdinalIgnoreCase))
									{
										num = (short)260767753;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_F1;
									}
									continue;
								case 4:
									goto IL_12B;
								case 5:
								{
									global::System.IO.Compression.ZipArchiveEntry zipArchiveEntry;
									manifest = global::System.IO.Path.Combine(tempPath, zipArchiveEntry.Name);
									zipArchiveEntry.ExtractToFile(manifest, true);
									num = (short)1989214212;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									num = (short)1359115375;
									short num4 = num;
									num = (short)610235503;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_110;
									default:
										num = (short)508100608;
										if (num != 0)
										{
										}
										num = (short)583860232;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::System.IO.Compression.ZipArchiveEntry zipArchiveEntry;
									if (zipArchiveEntry.FullName.ToLower(global::System.Globalization.CultureInfo.CurrentCulture).EndsWith(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("껎뿐럒꟔룖냘뿚냜뻞迠諢菤苦髨鿪쏬韮鳰鿲", a_), global::System.StringComparison.OrdinalIgnoreCase))
									{
										num = (short)1454309381;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_12B;
								}
								case 8:
									goto IL_2AF;
								case 9:
								{
									global::System.IO.Compression.ZipArchiveEntry zipArchiveEntry;
									resource = global::System.IO.Path.Combine(tempPath, zipArchiveEntry.Name);
									zipArchiveEntry.ExtractToFile(resource, true);
									num = (short)141361155;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_F3:
								num = (short)297205760;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_F1:
								goto IL_F3;
								IL_110:
								num = (short)395640838;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_12B:
								num = (short)1989214209;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_2AF:;
						}
						finally
						{
							num = (short)819527680;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2E4;
									}
									continue;
								case 1:
									goto IL_319;
								case 2:
									enumerator.Dispose();
									num = (short)900792321;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2E4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2035744770;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_319:;
						}
					}
					finally
					{
						num = (short)1355350016;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_351;
								}
								continue;
							case 1:
								goto IL_386;
							case 2:
								((global::System.IDisposable)zipArchive).Dispose();
								num = (short)519110657;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_351:
							if (zipArchive == null)
							{
								break;
							}
							num = (short)1629618178;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_386:;
					}
				}
				catch (global::System.Exception)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_PBB_Fail_To_Open_App_Package);
				}
				return;
			}
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0003261C File Offset: 0x0003081C
		public static string GetIconFilePath(string apkfile, string iconFileName)
		{
			int a_ = 11;
			short num = (short)1312489473;
			if (num != 0)
			{
			}
			num = (short)2139881472;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_E3;
				}
				string text;
				string text2;
				string text4;
				string text5;
				for (;;)
				{
					IL_58:
					num = (short)2054732778;
					short num3 = num;
					num = (short)817544170;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_641;
					case 1:
						break;
					default:
					{
						num = (short)1650655232;
						short num4 = num;
						break;
					}
					}
					num = (short)53018624;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1128071169;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.IO.Compression.ZipArchive zipArchive;
								switch (num2)
								{
								case 0:
									global::System.IO.Directory.CreateDirectory(text);
									num = (short)1378484228;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1A8;
									}
									continue;
								case 2:
									try
									{
										global::System.Collections.Generic.IEnumerator<global::System.IO.Compression.ZipArchiveEntry> enumerator = zipArchive.Entries.GetEnumerator();
										try
										{
											num = (short)1118502916;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.IO.Compression.ZipArchiveEntry zipArchiveEntry;
												string text3;
												switch (num2)
												{
												case 0:
													if (!enumerator.MoveNext())
													{
														num = (short)921829383;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													zipArchiveEntry = enumerator.Current;
													num = (short)1276117003;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 1:
													text2 = global::System.IO.Path.Combine(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBUtility.a, global::System.IO.Path.GetFileNameWithoutExtension(apkfile));
													num = (short)812449800;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													goto IL_3DB;
												case 3:
													goto IL_424;
												case 4:
													switch (0)
													{
													case 0:
														goto IL_253;
													}
													continue;
												case 5:
													global::System.IO.Directory.CreateDirectory(text2);
													num = (short)1718026242;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 6:
													goto IL_40C;
												case 7:
													goto IL_40C;
												case 8:
													if (!global::System.IO.Directory.Exists(text2))
													{
														num = (short)184352773;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_3DB;
												case 9:
													if (!string.IsNullOrEmpty(text3))
													{
														num = (short)521076737;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												case 10:
													zipArchiveEntry.ExtractToFile(global::System.IO.Path.Combine(text, zipArchiveEntry.Name), true);
													text3 = global::System.IO.Path.Combine(text, zipArchiveEntry.Name).Replace(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("ￏ", a_), global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("賏", a_));
													num = (short)676724745;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 11:
													if (zipArchiveEntry.FullName.EndsWith(iconFileName, global::System.StringComparison.OrdinalIgnoreCase))
													{
														num = (short)1159331850;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												IL_258:
												num = (short)1390542848;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_253:
												goto IL_258;
												IL_3DB:
												text4 = global::System.IO.Path.Combine(text2, zipArchiveEntry.Name);
												global::System.IO.File.Copy(text3, text4, true);
												num = (short)1087242246;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_40C:
												num = (short)2058092547;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_424:;
										}
										finally
										{
											num = (short)1552678912;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_459;
													}
													continue;
												case 1:
													goto IL_493;
												case 2:
													enumerator.Dispose();
													num = (short)1053818881;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_459:
												if (enumerator == null)
												{
													break;
												}
												num = (short)893911042;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_493:;
										}
										goto IL_569;
									}
									finally
									{
										num = (short)148045824;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_4CD;
												}
												continue;
											case 1:
												goto IL_506;
											case 2:
												((global::System.IDisposable)zipArchive).Dispose();
												num = (short)1105657857;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_4CD:
											if (zipArchive == null)
											{
												break;
											}
											num = (short)1529806850;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_506:;
									}
									goto IL_509;
									IL_569:
									num = (short)544997379;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_581;
								case 4:
									goto IL_509;
								}
								IL_1A8:
								if (!global::System.IO.Directory.Exists(text))
								{
									num = (short)1390018560;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_509:
								text5 = global::System.IO.Path.Combine(text, global::System.IO.Path.GetFileName(global::System.IO.Path.ChangeExtension(apkfile, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("ﻏ꣑뷓ꛕ", a_))));
								global::System.IO.File.Copy(apkfile, global::System.IO.Path.Combine(text, text5), true);
								global::System.IO.File.SetAttributes(text5, global::System.IO.FileAttributes.Normal);
								zipArchive = global::System.IO.Compression.ZipFile.Open(text5, global::System.IO.Compression.ZipArchiveMode.Read);
								num = (short)1308557314;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_581:
							goto IL_12A;
						}
						catch (global::System.Exception ex)
						{
							if (global::System.IO.Directory.Exists(text2))
							{
								global::System.IO.Directory.Delete(text2, true);
							}
							text4 = string.Empty;
							throw global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.CreateDirectMessageCommonException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("闏ꃑꛓ맕꫗龎껛믝铟郡跣菥黧菩苫觭탯鯱音駵雷\udaf9髻韽泿朁␃瘅椇縉搋㐍』", a_) + ex.Message, global::System.Array.Empty<object>()));
						}
						finally
						{
							num = (short)1804402688;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_602;
									}
									continue;
								case 1:
									goto IL_63E;
								case 2:
									global::System.IO.Directory.Delete(text, true);
									num = (short)1748959233;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_602:
								if (!global::System.IO.Directory.Exists(text))
								{
									break;
								}
								num = (short)579534850;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_63E:;
						}
						goto IL_641;
						IL_12A:
						num = (short)7405571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_641;
					case 2:
						return text4;
					case 3:
						if (string.IsNullOrEmpty(text4))
						{
							num = (short)1396113409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text4;
					}
					goto IL_E3;
					IL_641:
					text4 = global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBUtility.GetDefaultIconPath();
					num = (short)356253698;
					num2 = (int)((global::System.IntPtr)num);
				}
				return text4;
				IL_E3:
				text5 = string.Empty;
				text4 = string.Empty;
				text2 = string.Empty;
				text = global::System.IO.Path.Combine(global::System.IO.Path.GetTempPath(), global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("뗏꫑ꃓꓕ맗맙꣛苝", a_));
				num = (short)1330184192;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_58;
			}
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00032CF0 File Offset: 0x00030EF0
		private static byte[] a()
		{
			int a_ = 9;
			short num = (short)1076494336;
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
				string text;
				byte[] array;
				int num5;
				byte[] array2;
				for (;;)
				{
					IL_30:
					num = (short)904986624;
					short num3 = num;
					global::System.IO.Stream manifestResourceStream;
					switch (num2)
					{
					case 0:
						if (global::System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames().Contains(text))
						{
							num = (short)1622147074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20E;
					case 1:
						num = (short)1346502657;
						if (num != 0)
						{
						}
						try
						{
							manifestResourceStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
							int num4 = manifestResourceStream.Read(array, 0, num5);
							array2 = new byte[num4];
							global::System.Buffer.BlockCopy(array, 0, array2, 0, num4);
							return array2;
						}
						finally
						{
							num = (short)352976896;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)1031682815;
									short num6 = num;
									num = (short)793787135;
									switch ((num6 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)861208576;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_182;
										}
										continue;
									}
									break;
								}
								case 1:
									goto IL_1BB;
								case 2:
									((global::System.IDisposable)manifestResourceStream).Dispose();
									num = (short)794230785;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_182:
								if (manifestResourceStream == null)
								{
									break;
								}
								num = (short)1524826114;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1BB:;
						}
						goto IL_1BE;
					case 2:
						goto IL_1BE;
					}
					goto IL_6D;
					IL_1BE:
					manifestResourceStream = global::System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(text);
					num = (short)1533673473;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_20E:
				throw new global::System.Exception(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("裍맏뻑뇓럗듙ﳛ뫝觟釡迣웥蛧藩飫컭雯鷱至飵鳷\udbf9\udcfb", a_) + text);
				IL_6D:
				num5 = 307200;
				array = new byte[num5];
				array2 = null;
				text = global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("菍뿏ꛑ믓ꓕ럗뛙뷛ꏟ跡解该蟧蓩꿫뻭ꏯ\udcf1꛳韵鳷鏹鏻돽懿氁攃愅洇有椋怍搏㰑嬓昕紗栙紛樝䤟䴡䨣ࠥ砧䬩伫䔭儯唱儳ᠵ样砹縻ွп❁≃❅㵇♉㡋ݍ㍏㵑㩓硕⡗㑙㭛", a_);
				num = (short)1032454144;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00032F38 File Offset: 0x00031138
		public static string GetDefaultIconPath()
		{
			int a_ = 10;
			short num = (short)1529151488;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				string text;
				string text2;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_30:
						num = (short)1182188891;
						short num3 = num;
						num = (short)1610925403;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B7;
						default:
						{
							num = (short)419299328;
							if (num != 0)
							{
							}
							global::System.IO.FileStream fileStream;
							switch (num2)
							{
							case 0:
								if (global::System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames().Contains(text))
								{
									num = (short)492961792;
									short num4 = num;
									num = (short)48103426;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_272;
							case 1:
								try
								{
									global::System.IO.Stream manifestResourceStream = global::System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(text);
									try
									{
										manifestResourceStream.CopyTo(fileStream);
									}
									finally
									{
										num = (short)1499987968;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_19A;
												}
												continue;
											case 1:
												goto IL_1CF;
											case 2:
												((global::System.IDisposable)manifestResourceStream).Dispose();
												num = (short)452526081;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_19A:
											if (manifestResourceStream == null)
											{
												break;
											}
											num = (short)790822914;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_1CF:;
									}
									fileStream.Flush();
									return text2;
								}
								finally
								{
									num = (short)644677632;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_211;
											}
											continue;
										case 1:
											goto IL_249;
										case 2:
											((global::System.IDisposable)fileStream).Dispose();
											num = (short)444465153;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_211:
										if (fileStream == null)
										{
											break;
										}
										num = (short)2055602178;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_249:;
								}
								goto IL_24C;
							case 2:
								num = (short)988413953;
								if (num != 0)
								{
								}
								goto IL_24C;
							}
							goto IL_8F;
							IL_24C:
							fileStream = new global::System.IO.FileStream(text2, global::System.IO.FileMode.Create);
							num = (short)689700865;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
					IL_272:
					throw new global::System.Exception(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("觎룐뿒냔뛘뗚﷜믞裠郢軤쟦蟨蓪駬쿮韰鳲胴駶鷸\udafa\uddfc", a_) + text);
				}
				IL_8F:
				text2 = global::System.IO.Path.GetTempFileName() + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("ꇐ뷒닔", a_);
				text = global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("苎뻐꟒뫔ꗖ뛘럚볜ꋠ賢裤諦蛨藪껬뿮ꋰ\uddf2ꟴ零鷸鋺鋼닾怀洂搄怆氈昊栌愎攐㴒娔朖簘椚簜欞䠠䰢䬤द礨䨪丬䐮倰吲倴ᤶ椸示缼ᄾՀ♂⍄♆㱈❊㥌َ㉐㱒㭔祖⥘㕚㩜", a_);
				IL_B7:
				num = (short)1005977600;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00033204 File Offset: 0x00031404
		// Note: this type is marked as 'beforefieldinit'.
		static PBBUtility()
		{
			int a_ = 9;
			short num = (short)809550143;
			short num2 = num;
			num = (short)1268105535;
			switch (num2 == num)
			{
			default:
			{
				num = (short)372637696;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1807089665;
			if (num != 0)
			{
			}
			num = (short)1111293952;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBUtility.a = global::System.IO.Path.Combine(global::System.IO.Path.GetTempPath(), global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("ꟍ돏뷑뫓ꗕ蓗", a_));
		}

		// Token: 0x0400009B RID: 155
		private static string a;
	}
}
