using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace AcpASKLib
{
	// Token: 0x02000035 RID: 53
	public static class SecurityDocument
	{
		// Token: 0x06000171 RID: 369 RVA: 0x000285B0 File Offset: 0x000267B0
		public static bool FileOpenAccessLevel(string path)
		{
			int a_ = 17;
			short num = (short)1699545089;
			if (num != 0)
			{
			}
			num = (short)995688448;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1145700352;
				short num3 = num;
				bool result = true;
				if (!global::AcpASKLib.SecurityDocument.bAccessLevelFileOpened)
				{
					try
					{
						switch (0)
						{
						case 0:
							goto IL_B2;
						}
						global::System.Xml.XmlNode xmlNode;
						for (;;)
						{
							IL_8F:
							switch (num2)
							{
							case 0:
							{
								num = (short)2041020096;
								short num4 = num;
								num = (short)589659840;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									num = (short)1220739072;
									if (num != 0)
									{
									}
									num = (short)858456066;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								goto IL_208;
							case 2:
								goto IL_322;
							case 3:
							{
								string name;
								if (global::AcpASKLib.SystemKeyLoadedEventArgs.b("㱭ᕯᅱ᭳ѵᱷ", a_) == name)
								{
									num = (short)1383727109;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_29A;
							}
							case 4:
							{
								if (xmlNode == null)
								{
									num = (short)400818176;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								string name = xmlNode.Name;
								string innerText = xmlNode.InnerText;
								num = (short)1769340931;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								try
								{
									switch (0)
									{
									case 0:
										goto IL_117;
									}
									global::AcpASKLib.AccessRecord accessRecord;
									for (;;)
									{
										IL_F4:
										switch (num2)
										{
										case 0:
											if (accessRecord.RecordType == global::AcpASKLib.FeatureCategoryType.TRUNKING)
											{
												num = (short)349175811;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_1E3;
										case 1:
											goto IL_1E3;
										case 2:
											goto IL_1FB;
										case 3:
											global::AcpASKLib.Global.m_persistentData.SystemWideACLRecSet.AddNewRecord(accessRecord);
											num = (short)1178206209;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 4:
											global::AcpASKLib.Global.m_persistentData.RadioWideACLRecSet.AddNewRecord(accessRecord);
											num = (short)1883504645;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 5:
											goto IL_1E3;
										case 6:
											if (accessRecord.RecordType == global::AcpASKLib.FeatureCategoryType.RADIOWIDE)
											{
												num = (short)1823604740;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)1978662912;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_117;
										IL_1E3:
										num = (short)1415184386;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_1FB:
									goto IL_29A;
									IL_117:
									accessRecord = new global::AcpASKLib.AccessRecord(xmlNode);
									num = (short)537067526;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_F4;
								}
								catch
								{
									result = false;
									goto IL_29A;
								}
								goto IL_208;
							case 6:
								goto IL_208;
							}
							goto IL_B2;
							IL_208:
							num = (short)980025348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_29A:
							xmlNode = xmlNode.NextSibling;
							num = (short)218234881;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_322:
						return result;
						IL_B2:
						global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
						xmlDocument.Load(path);
						global::AcpASKLib.SecurityDocument.bAccessLevelFileOpened = true;
						xmlNode = xmlDocument.DocumentElement.FirstChild;
						num = (short)1492254726;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_8F;
					}
					catch (global::System.Exception ex)
					{
						if (ex is global::System.IO.FileNotFoundException)
						{
							global::AcpASKLib.SecurityDocument.bAccessLevelFileOpened = true;
						}
						throw;
					}
				}
				return result;
			}
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0002892C File Offset: 0x00026B2C
		public static bool FileSaveAccessLevel(string path)
		{
			int a_ = 14;
			short num = (short)1837105152;
			switch (num)
			{
			default:
			{
				num = (short)906559488;
				short num2 = num;
				string text = global::AcpASKLib.SystemKeyLoadedEventArgs.b("坪剬ᝮᱰὲ啴Ŷᱸॺ๼ᙾ뢄ꖆ뢈ꖊ붌궎꺐궒龔ꮖ\ud898ﺜ爵튠킢캦\udaa8\udfaa욮\uddb0횲讴붶", a_);
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessRecord> enumerator = global::AcpASKLib.Global.m_persistentData.SystemWideACLRecSet.GetEnumerator();
				try
				{
					num = (short)825098261;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::AcpASKLib.AccessRecord accessRecord;
						string text2;
						switch (num3)
						{
						case 0:
							num = (short)269418513;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (accessRecord.Name.Contains(global::AcpASKLib.SystemKeyLoadedEventArgs.b("䵪", a_)))
							{
								num = (short)1310723;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_344;
						case 2:
							goto IL_344;
						case 3:
							accessRecord.Name = accessRecord.Name.Replace(global::AcpASKLib.SystemKeyLoadedEventArgs.b("䵪", a_), global::AcpASKLib.SystemKeyLoadedEventArgs.b("䵪౬ɮŰ䡲", a_));
							num = (short)927662082;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (text2 != string.Empty)
							{
								num = (short)801570831;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 5:
							num = (short)1693319177;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							text += accessRecord.f();
							num = (short)131596300;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (!enumerator.MoveNext())
							{
								num = (short)1285488645;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							accessRecord = enumerator.Current;
							text2 = string.Empty;
							num = (short)1569193997;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							num = (short)1926758418;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							goto IL_45B;
						case 11:
							accessRecord.Name = accessRecord.Name.Replace(global::AcpASKLib.SystemKeyLoadedEventArgs.b("坪", a_), global::AcpASKLib.SystemKeyLoadedEventArgs.b("䵪Ŭ᭮䩰", a_));
							num = (short)966000654;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							goto IL_14B;
						case 13:
							if (!accessRecord.Name.Contains(global::AcpASKLib.SystemKeyLoadedEventArgs.b("䵪", a_)))
							{
								num = (short)17629184;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F4;
						case 14:
							goto IL_256;
						case 15:
							accessRecord.Name = text2;
							num = (short)1808138250;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							if (accessRecord.PrimaryKey != 4)
							{
								num = (short)177143816;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_14B;
						case 17:
							if (accessRecord.Name.Contains(global::AcpASKLib.SystemKeyLoadedEventArgs.b("坪", a_)))
							{
								num = (short)847314963;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_256;
						case 18:
							if (accessRecord.PrimaryKey != 5)
							{
								num = (short)1458634758;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_14B;
						case 19:
							goto IL_F4;
						case 20:
							if (accessRecord.Name.Contains(global::AcpASKLib.SystemKeyLoadedEventArgs.b("坪", a_)))
							{
								num = (short)743833611;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_256;
						case 21:
							switch (0)
							{
							case 0:
								goto IL_EF;
							}
							continue;
						}
						goto IL_EF;
						IL_F4:
						text2 = accessRecord.Name;
						num = (short)500760577;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_14B:
						num = (short)888078340;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_214:
						num = (short)549519367;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_EF:
						goto IL_214;
						IL_256:
						num = (short)56492048;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_344:
						num = (short)1081737236;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_45B:;
				}
				finally
				{
					num = (short)1956511746;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_4CA;
						case 1:
							enumerator.Dispose();
							num = (short)1579352064;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_493;
							}
							continue;
						}
						goto IL_493;
						IL_496:
						num = (short)1681981441;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_4CA:
						num = (short)1269596007;
						short num4 = num;
						num = (short)1547009895;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_496;
						default:
							goto IL_500;
						}
						IL_493:
						if (enumerator != null)
						{
							goto IL_496;
						}
						goto IL_4CA;
					}
					IL_500:
					num = (short)1608122368;
					if (num != 0)
					{
					}
				}
				num = (short)171048961;
				if (num != 0)
				{
				}
				text += global::AcpASKLib.SystemKeyLoadedEventArgs.b("坪䉬⹮ተၲၴѶ੸㝺ᑼ౾얂떊", a_);
				global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
				xmlDocument.LoadXml(text);
				xmlDocument.Save(path);
				return true;
			}
			}
		}

		// Token: 0x040001BA RID: 442
		public static bool bAccessLevelFileOpened;
	}
}
