using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Xml;
using Motorola.CommonCPS.RadioManagement.CommonBase.Comparers;
using Motorola.CommonCPS.ResourceRepository;
using RFResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.CommonBase
{
	// Token: 0x02000003 RID: 3
	public sealed class AppLanguage : global::System.Collections.IEnumerable
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		private AppLanguage()
		{
			int a_ = 8;
			this.n = string.Concat(new object[]
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ཛㅝٟᙡ፣ݥᩧཀྵ", a_),
				global::System.IO.Path.DirectorySeparatorChar,
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ᅛㅝᑟൡᙣ॥ѧ୩", a_),
				global::System.IO.Path.DirectorySeparatorChar
			});
			base..ctor();
			this.DefaultRMCLanguage = global::Motorola.CommonCPS.RadioManagement.CommonBase.AppLanguage.MainAssemblyCulture;
			this.a = new global::System.Collections.Generic.Dictionary<string, string>();
			this.b();
			this.a();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021A8 File Offset: 0x000003A8
		private string c()
		{
			int a_ = 5;
			short num = (short)540868609;
			if (num != 0)
			{
			}
			num = (short)1092234540;
			short num2 = num;
			num = (short)1267674412;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2071461888;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)212926464;
			if (num != 0)
			{
			}
			return global::System.Configuration.ConfigurationManager.AppSettings[global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ᡘ࡚ड़൞⹠ぢd୦౨ࡪᥬ੮ᕰ㽲ᑴ᥶Ṹ㝺ᑼ౾", a_)];
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002274 File Offset: 0x00000474
		private void b()
		{
			short num = (short)521207808;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4C;
				}
				string text4;
				for (;;)
				{
					IL_29:
					int num4;
					string[] array;
					switch (num2)
					{
					case 0:
						goto IL_334;
					case 1:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_11A;
							}
							global::System.Globalization.CultureInfo cultureInfo;
							string text;
							string text2;
							for (;;)
							{
								IL_EB:
								char c;
								switch (num2)
								{
								case 0:
									num = (short)1559101445;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_179;
								case 2:
									num = (short)86310920;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_179;
								case 4:
									goto IL_2F8;
								case 5:
									if (cultureInfo.TextInfo.IsRightToLeft)
									{
										num = (short)1260126214;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									c = '‎';
									num = (short)1022885889;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									c = '‏';
									num = (short)1964179459;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									num = (short)921744957;
									short num3 = num;
									num = (short)743421501;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_14B;
									default:
										num = (short)1293221888;
										if (num != 0)
										{
										}
										goto IL_2D1;
									}
									break;
								}
								case 8:
									if (char.IsPunctuation(cultureInfo.NativeName[cultureInfo.NativeName.Length - 1]))
									{
										num = (short)2059665408;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2D1;
								case 9:
									goto IL_14B;
								}
								goto IL_11A;
								IL_14B:
								if (!string.IsNullOrEmpty(cultureInfo.NativeName))
								{
									num = (short)600637442;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2D1;
								IL_179:
								text += c;
								num = (short)678494215;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2D1:
								this.a.Add(text, text2);
								num = (short)2100625412;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2F8:
							goto IL_C0;
							IL_11A:
							string text3;
							text2 = text3.Trim();
							cultureInfo = new global::System.Globalization.CultureInfo(text2);
							text = cultureInfo.NativeName;
							num = (short)466550793;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_EB;
						}
						catch (global::System.Globalization.CultureNotFoundException)
						{
							goto IL_C0;
						}
						goto IL_303;
						IL_C0:
						num4++;
						num = (short)914161669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1053818881;
						if (num != 0)
						{
						}
						if (num4 >= array.Length)
						{
							num = (short)690094083;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text3 = array[num4];
						global::System.Globalization.CultureInfo cultureInfo = null;
						num = (short)1989476353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						return;
					case 4:
						goto IL_303;
					case 5:
						goto IL_334;
					case 6:
						if (!string.IsNullOrEmpty(text4))
						{
							num = (short)1660354560;
							short num5 = num;
							num = (short)1885143044;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_4C;
					IL_303:
					array = text4.Split(new char[]
					{
						','
					});
					num4 = 0;
					num = (short)1169031168;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_334:
					num = (short)1616642050;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_4C:
				text4 = string.Empty;
				text4 = this.c();
				num = (short)1687158790;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000265C File Offset: 0x0000085C
		private void a()
		{
			int a_ = 9;
			short num = (short)554631169;
			if (num != 0)
			{
			}
			num = (short)556335104;
			short num2 = num;
			num = (short)2116157440;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_92;
				}
				string text;
				string text2;
				string text3;
				string folderPath;
				for (;;)
				{
					IL_7F:
					switch (num3)
					{
					case 0:
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)798687233;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						try
						{
							text2 = text.Trim();
							new global::System.Globalization.CultureInfo(text2);
							this.DefaultRMCLanguage = text2;
							return;
						}
						catch (global::System.Globalization.CultureNotFoundException)
						{
							return;
						}
						goto IL_E5;
					case 2:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_149;
							}
							for (;;)
							{
								IL_12A:
								switch (num3)
								{
								case 0:
								{
									global::System.Xml.XmlNode xmlNode;
									if (xmlNode != null)
									{
										num = (short)460455938;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_27A;
								}
								case 1:
									goto IL_293;
								case 2:
								{
									num = (short)428685355;
									short num4 = num;
									num = (short)2125871147;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_27A;
									default:
									{
										num = (short)934608896;
										if (num != 0)
										{
										}
										global::System.Xml.XmlNode xmlNode;
										text = xmlNode.InnerText;
										num = (short)2055340036;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 3:
								{
									global::System.Xml.XmlNode xmlNode = null;
									global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
									xmlDocument.Load(text3);
									string str = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("牜㱞๠ൢͤ๦๨ṪὬ๮հᩲᩴ᥶噸๺๼᩾킂ﶈ벒\ud894춠슢认욨욪사삮\udfb0鶲쒶춸즺튼醾釀뇂꫄럆곈맊만ꛎ듐ꃒﯔ蓖볘꿚꧜뛞迠蓢雤", a_);
									xmlNode = xmlDocument.SelectSingleNode(str + global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("牜ⱞѠᝢᅤ๦ݨ౪㙬⽮ὰቲᡴቶ䑸屺⹼᩾소ﾐ는쪖뚘ﲜ풠욢", a_));
									num = (short)2124283904;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_27A;
								case 5:
									if (global::System.IO.File.Exists(text3))
									{
										num = (short)1207631875;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_27A;
								}
								goto IL_149;
								IL_27A:
								num = (short)218562561;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_293:
							goto IL_E5;
							IL_149:
							text3 = global::System.IO.Path.Combine(folderPath, global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ၜぞᕠౢᝤࡦը੪ㅬⱮṰṲᡴᡶ᝸㡺⵼Ȿ\udd80쾂ﲔ잚쒠톢认쒦욨얪쮬욮횰", a_));
							num = (short)1551237125;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_12A;
						}
						catch
						{
							goto IL_E5;
						}
						return;
					}
					goto IL_92;
					IL_E5:
					num = (short)155058176;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_92:
				text = string.Empty;
				text2 = string.Empty;
				folderPath = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData);
				text3 = "";
				num = (short)1320943618;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7F;
			}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000293C File Offset: 0x00000B3C
		public static global::Motorola.CommonCPS.RadioManagement.CommonBase.AppLanguage GetInstance()
		{
			short num = (short)241565698;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1485021985;
					short num3 = num;
					num = (short)1811587873;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1176109056;
						if (num != 0)
						{
						}
						break;
					}
					global::Motorola.CommonCPS.RadioManagement.CommonBase.AppLanguage.o = new global::Motorola.CommonCPS.RadioManagement.CommonBase.AppLanguage();
					num = (short)1759117312;
					short num4 = num;
					num = (short)887422977;
					if (num != 0)
					{
					}
					num = (short)445317121;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_10F;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				if (global::Motorola.CommonCPS.RadioManagement.CommonBase.AppLanguage.o != null)
				{
					break;
				}
				num = (short)50921472;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10F:
			return global::Motorola.CommonCPS.RadioManagement.CommonBase.AppLanguage.o;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002A60 File Offset: 0x00000C60
		public void SetAppLanguage()
		{
			int a_ = 12;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_31;
				}
				int num;
				string name;
				for (;;)
				{
					IL_13:
					global::System.Globalization.CultureInfo cultureInfo;
					switch (num)
					{
					case 0:
						goto IL_2C1;
					case 1:
						goto IL_47F;
					case 2:
						goto IL_2C1;
					case 3:
						name = this.DefaultRMCLanguage;
						num2 = (short)1908539392;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						try
						{
							num2 = (short)882835466;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								switch (num)
								{
								case 0:
									cultureInfo = new global::System.Globalization.CultureInfo(197636);
									num2 = (short)1656946695;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 1:
									cultureInfo = new global::System.Globalization.CultureInfo(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("՟ᅡ䥣⭥で", a_));
									num2 = (short)1889337353;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 2:
									cultureInfo = new global::System.Globalization.CultureInfo(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("şၡ䥣ⵥ㽧", a_));
									cultureInfo.NumberFormat.DigitSubstitution = global::System.Globalization.DigitShapes.None;
									goto IL_16A;
								case 3:
									if (name == global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("՟ᅡ", a_))
									{
										num2 = (short)951123969;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									num2 = (short)1858076676;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 4:
									if (name == global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("şၡ", a_))
									{
										num2 = (short)806944770;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									cultureInfo = new global::System.Globalization.CultureInfo(name);
									num2 = (short)437452806;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 5:
									goto IL_2B1;
								case 6:
									goto IL_29A;
								case 7:
									goto IL_29A;
								case 8:
									goto IL_29A;
								case 9:
									goto IL_29A;
								case 10:
									switch (0)
									{
									case 0:
										goto IL_C9;
									}
									continue;
								}
								IL_C9:
								if (!(name == global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("᩟੡䥣㉥㽧", a_)))
								{
									num2 = (short)228982787;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								num2 = (short)9189026;
								short num3 = num2;
								num2 = (short)661337762;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num2 = (short)32833536;
									if (num2 != 0)
									{
									}
									num2 = (short)1508638720;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								IL_16A:
								num2 = (short)853934088;
								num = (int)((global::System.IntPtr)num2);
								continue;
								IL_29A:
								num2 = (short)1291124741;
								num = (int)((global::System.IntPtr)num2);
							}
							IL_2B1:
							goto IL_320;
						}
						catch (global::System.Globalization.CultureNotFoundException)
						{
							cultureInfo = new global::System.Globalization.CultureInfo(global::Motorola.CommonCPS.RadioManagement.CommonBase.AppLanguage.MainAssemblyCulture);
							goto IL_320;
						}
						goto IL_2C1;
						IL_320:
						global::System.Globalization.CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
						global::System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
						global::System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
						global::System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
						global::Motorola.CommonCPS.ResourceRepository.Resources.Culture = cultureInfo;
						this.a(cultureInfo);
						global::System.Windows.FrameworkContentElement.LanguageProperty.OverrideMetadata(typeof(global::System.Windows.Documents.TextElement), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Markup.XmlLanguage.GetLanguage(global::System.Globalization.CultureInfo.CurrentCulture.IetfLanguageTag)));
						global::System.Windows.FrameworkContentElement.LanguageProperty.OverrideMetadata(typeof(global::System.Windows.Controls.DefinitionBase), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Markup.XmlLanguage.GetLanguage(global::System.Globalization.CultureInfo.CurrentCulture.IetfLanguageTag)));
						global::System.Windows.FrameworkContentElement.LanguageProperty.OverrideMetadata(typeof(global::System.Windows.Documents.FixedDocument), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Markup.XmlLanguage.GetLanguage(global::System.Globalization.CultureInfo.CurrentCulture.IetfLanguageTag)));
						global::System.Windows.FrameworkContentElement.LanguageProperty.OverrideMetadata(typeof(global::System.Windows.Documents.FixedDocumentSequence), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Markup.XmlLanguage.GetLanguage(global::System.Globalization.CultureInfo.CurrentCulture.IetfLanguageTag)));
						global::System.Windows.FrameworkContentElement.LanguageProperty.OverrideMetadata(typeof(global::System.Windows.Documents.FlowDocument), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Markup.XmlLanguage.GetLanguage(global::System.Globalization.CultureInfo.CurrentCulture.IetfLanguageTag)));
						global::System.Windows.FrameworkContentElement.LanguageProperty.OverrideMetadata(typeof(global::System.Windows.Documents.TableColumn), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Markup.XmlLanguage.GetLanguage(global::System.Globalization.CultureInfo.CurrentCulture.IetfLanguageTag)));
						global::System.Windows.FrameworkElement.LanguageProperty.OverrideMetadata(typeof(global::System.Windows.FrameworkElement), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Markup.XmlLanguage.GetLanguage(global::System.Globalization.CultureInfo.CurrentCulture.IetfLanguageTag)));
						num2 = (short)1287979009;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						if (!string.IsNullOrEmpty(this.DefaultRMCLanguage))
						{
							num2 = (short)398196739;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						name = global::Motorola.CommonCPS.RadioManagement.CommonBase.AppLanguage.MainAssemblyCulture;
						num2 = (short)1107820546;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_31;
					IL_2C1:
					cultureInfo = null;
					num2 = (short)827850756;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_47F:
				goto IL_484;
				IL_31:
				name = string.Empty;
				num2 = (short)347734021;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			catch
			{
			}
			IL_484:
			num2 = (short)849084417;
			if (num2 != 0)
			{
			}
			num2 = (short)709492736;
			short num4 = num2;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002F74 File Offset: 0x00001174
		private void a(global::System.Globalization.CultureInfo A_0)
		{
			short num = (short)2110193665;
			if (num != 0)
			{
			}
			num = (short)866642615;
			short num2 = num;
			num = (short)748939959;
			switch (num2 == num)
			{
			default:
			{
				num = (short)795738112;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1306394624;
			if (num != 0)
			{
			}
			global::RFResourceRepository.RFResources.Culture = A_0;
			global::RFResourceRepository.RFErrorResources.Culture = A_0;
			global::RFResourceRepository.ASTRORFResources.Culture = A_0;
			global::RFResourceRepository.ASTRORFErrorResources.Culture = A_0;
			global::RFResourceRepository.PCRRFResources.Culture = A_0;
			global::RFResourceRepository.PCRRFErrorResources.Culture = A_0;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00003044 File Offset: 0x00001244
		public void SaveAppUserForUpgradeConfig(string selectedLanguage)
		{
			int a_ = 13;
			short num = (short)1828388864;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5B;
				}
				global::System.Xml.XmlDocument xmlDocument;
				string name;
				string text;
				string text2;
				for (;;)
				{
					IL_30:
					global::System.Xml.XmlNode xmlNode3;
					switch (num2)
					{
					case 0:
					{
						global::System.Xml.XmlNode xmlNode;
						if (xmlNode == null)
						{
							num = (short)924975107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						xmlNode.InnerText = selectedLanguage;
						num = (short)1608122370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::System.Xml.XmlNode xmlNode2 = xmlDocument.SelectSingleNode(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ɠౢ୤Ŧh౪ᡬᵮၰݲᱴᡶ᝸呺ࡼ౾횄ﶈﾊ", a_));
						global::System.Xml.XmlElement newChild = xmlDocument.CreateElement(name);
						xmlNode2.AppendChild(newChild);
						xmlNode3 = xmlDocument.SelectSingleNode(text);
						num = (short)827457544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_104;
					case 3:
					{
						xmlNode3 = xmlDocument.SelectSingleNode(text);
						num = (short)1453850624;
						short num3 = num;
						num = (short)1495728132;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						num = (short)2093241038;
						short num4 = num;
						num = (short)1859605198;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2A1;
						default:
							num = (short)1773010944;
							if (num != 0)
							{
							}
							if (xmlNode3 == null)
							{
								num = (short)1838284801;
								if (num != 0)
								{
								}
								num = (short)312606721;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A1;
						}
						break;
					}
					case 5:
						if (global::System.IO.File.Exists(text2))
						{
							num = (short)2062155783;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_34D;
					case 6:
						goto IL_348;
					case 7:
					{
						xmlDocument = new global::System.Xml.XmlDocument();
						xmlDocument.Load(text2);
						global::System.Xml.XmlNode xmlNode = xmlDocument.SelectSingleNode(text + global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("习ၢd፦ᵨɪͬ࡮⩰㍲᭴ᙶᑸṺ䁼塾튀ﾊ\udd90ﮔ뺘욚늜삠쾢키슦", a_));
						num = (short)1023410176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_2A1;
					}
					goto IL_5B;
					IL_2A1:
					global::System.Xml.XmlElement xmlElement = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("በ٢ᅤ፦hժ੬", a_));
					xmlElement.SetAttribute(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("འɢࡤɦ", a_), global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㉠٢।ɦ੨Ὢ࡬୮㵰ቲ᭴ၶ", a_));
					xmlElement.SetAttribute(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("በ٢ᝤ๦ࡨݪѬᕮᑰ㉲ٴ", a_), global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㉠ᝢᝤ๦ݨ౪", a_));
					global::System.Xml.XmlElement xmlElement2 = xmlDocument.CreateElement(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ᝠɢ।ቦ౨", a_));
					xmlElement2.InnerText = selectedLanguage;
					xmlElement.AppendChild(xmlElement2);
					xmlNode3.AppendChild(xmlElement);
					num = (short)411500550;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_104:
				IL_1BC:
				xmlDocument.Save(text2);
				return;
				IL_348:
				goto IL_1BC;
				IL_34D:
				global::System.Xml.XmlDocument xmlDocument2 = new global::System.Xml.XmlDocument();
				global::System.Xml.XmlDeclaration newChild2 = xmlDocument2.CreateXmlDeclaration(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("偠䵢啤", a_), global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ᑠᝢͤ䩦全", a_), null);
				xmlDocument2.AppendChild(newChild2);
				global::System.Xml.XmlNode xmlNode4 = xmlDocument2.CreateElement(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ɠౢ୤Ŧh౪ᡬᵮၰݲᱴᡶ᝸", a_));
				global::System.Xml.XmlElement xmlElement3 = xmlDocument2.CreateElement(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ᑠၢdᕦ㩨๪ᥬ᭮ᡰᵲቴѶ", a_));
				global::System.Xml.XmlElement xmlElement4 = xmlDocument2.CreateElement(name);
				global::System.Xml.XmlElement xmlElement5 = xmlDocument2.CreateElement(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("በ٢ᅤ፦hժ੬", a_));
				xmlElement5.SetAttribute(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("འɢࡤɦ", a_), global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㉠٢।ɦ੨Ὢ࡬୮㵰ቲ᭴ၶ", a_));
				xmlElement5.SetAttribute(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("በ٢ᝤ๦ࡨݪѬᕮᑰ㉲ٴ", a_), global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㉠ᝢᝤ๦ݨ౪", a_));
				global::System.Xml.XmlElement xmlElement6 = xmlDocument2.CreateElement(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ᝠɢ।ቦ౨", a_));
				xmlElement6.InnerText = selectedLanguage;
				xmlElement5.AppendChild(xmlElement6);
				xmlElement4.AppendChild(xmlElement5);
				xmlElement3.AppendChild(xmlElement4);
				xmlNode4.AppendChild(xmlElement3);
				xmlDocument2.AppendChild(xmlNode4);
				xmlDocument2.Save(text2);
				return;
				IL_5B:
				string folderPath = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData);
				text2 = "";
				text2 = global::System.IO.Path.Combine(folderPath, global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("Ⱡౢᅤࡦ᭨ѪŬ๮⵰ひᩴ᩶ᑸᑺ፼㱾톀킂\ud984쮆쎞풠킢삤햦螨좪슬솮ힰ\udab2튴", a_));
				text = string.Empty;
				name = string.Empty;
				text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("习b੤०ཨɪ੬ᩮͰቲŴṶᙸᕺ剼੾풆ﾊ歷ﾐ뢖풘펠첢즤욦螨슬슮\udcb0\udcb2\udbb4馶좺즼춾껀闄뗆ꛈ믊꣌뷎ꗐ뫒냔ꓖ裚룜ꯞ闠諢诤胦髨", a_);
				name = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("Ⱡౢᅤࡦ᭨ѪŬ๮彰ひᩴ᩶ᑸᑺ፼兾삀ꖊ\udd8cﶎﺐ辠삤펦\udda8슪쎬좮슰", a_);
				num = (short)1464598533;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000034B8 File Offset: 0x000016B8
		public int Count
		{
			get
			{
				short num = (short)927877832;
				short num2 = num;
				num = (short)361843400;
				switch (num2 == num)
				{
				}
				num = (short)1235025920;
				short num3 = num;
				num = (short)93650944;
				if (num != 0)
				{
				}
				num = (short)1613037569;
				if (num != 0)
				{
				}
				return this.a.Count;
			}
		}

		// Token: 0x17000004 RID: 4
		public string this[string culture]
		{
			get
			{
				int num;
				string result;
				short num2;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							goto IL_AF;
						case 1:
							if (this.a.TryGetValue(culture, out result))
							{
								num2 = (short)1006698498;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_FC;
						case 2:
							result = this.a[culture];
							num2 = (short)1381236736;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1C;
					}
					IL_AF:
					num2 = (short)286136521;
					short num3 = num2;
					num2 = (short)959977673;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_22;
					default:
						num2 = (short)1268121600;
						if (num2 != 0)
						{
						}
						break;
					}
					IL_FC:
					num2 = (short)79298561;
					if (num2 != 0)
					{
					}
					return result;
				}
				}
				IL_1C:
				result = string.Empty;
				IL_22:
				num2 = (short)356057088;
				short num4 = num2;
				num2 = (short)1372651521;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000036A0 File Offset: 0x000018A0
		public bool IsLanguageAvailable(string language)
		{
			int num;
			short num2;
			bool result;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_9C;
					case 1:
						if (this.a.ContainsValue(language))
						{
							num2 = (short)1365377026;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 2:
						result = true;
						num2 = (short)839385088;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				IL_9C:
				num2 = (short)560094208;
				short num3 = num2;
				num2 = (short)1763007488;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1E;
				default:
					num2 = (short)1253310465;
					if (num2 != 0)
					{
					}
					num2 = (short)566362112;
					if (num2 != 0)
					{
					}
					break;
				}
				return result;
			}
			}
			IL_1C:
			result = false;
			IL_1E:
			num2 = (short)558956544;
			short num4 = num2;
			num2 = (short)666370049;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000037C0 File Offset: 0x000019C0
		public string[] AdditionalRMCLanguages()
		{
			short num = (short)313134581;
			short num2 = num;
			num = (short)1561595381;
			switch (num2 == num)
			{
			}
			num = (short)924647424;
			short num3 = num;
			num = (short)181010433;
			if (num != 0)
			{
			}
			num = (short)1301020672;
			if (num != 0)
			{
			}
			return new global::System.Collections.Generic.List<string>(this.a.Values).ToArray();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003880 File Offset: 0x00001A80
		public string[] AdditionalRMCLanguagesDisplayNames()
		{
			short num = (short)940998988;
			short num2 = num;
			num = (short)1557037388;
			switch (num2 == num)
			{
			}
			num = (short)236978176;
			short num3 = num;
			num = (short)1002962945;
			if (num != 0)
			{
			}
			num = (short)2072576000;
			if (num != 0)
			{
			}
			return new global::System.Collections.Generic.List<string>(this.a.Keys).ToArray();
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000011 RID: 17 RVA: 0x0000393C File Offset: 0x00001B3C
		// (set) Token: 0x06000012 RID: 18 RVA: 0x000039F0 File Offset: 0x00001BF0
		public string DefaultRMCLanguage
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)889266108;
				short num2 = num;
				num = (short)1343627196;
				switch (num2 == num)
				{
				}
				num = (short)418578432;
				short num3 = num;
				num = (short)345571328;
				if (num != 0)
				{
				}
				num = (short)1703280641;
				if (num != 0)
				{
				}
				return this.p;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1572038031;
				short num2 = num;
				num = (short)859071887;
				switch (num2 == num)
				{
				}
				num = (short)234094592;
				short num3 = num;
				num = (short)1594621952;
				if (num != 0)
				{
				}
				num = (short)1363869697;
				if (num != 0)
				{
				}
				this.p = value;
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003AA4 File Offset: 0x00001CA4
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			short num = (short)1804693703;
			short num2 = num;
			num = (short)879063239;
			switch (num2 == num)
			{
			}
			num = (short)596246528;
			short num3 = num;
			num = (short)852033536;
			if (num != 0)
			{
			}
			num = (short)1980039169;
			if (num != 0)
			{
			}
			return this.a.GetEnumerator();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003B5C File Offset: 0x00001D5C
		// Note: this type is marked as 'beforefieldinit'.
		static AppLanguage()
		{
			int a_ = 6;
			short num = (short)128005602;
			short num2 = num;
			num = (short)852571618;
			switch (num2 == num)
			{
			}
			num = (short)1400307712;
			short num3 = num;
			num = (short)304480257;
			if (num != 0)
			{
			}
			num = (short)1858666496;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.CommonBase.AppLanguage.MainAssemblyCulture = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㽙㉛", a_);
		}

		// Token: 0x04000003 RID: 3
		private global::System.Collections.Generic.Dictionary<string, string> a;

		// Token: 0x04000004 RID: 4
		private const string b = "Motorola\\CommonCPS\\Localization\\user.config";

		// Token: 0x04000005 RID: 5
		private const string c = "/configuration/userSettings/Motorola.Common.Astro.Properties.Settings";

		// Token: 0x04000006 RID: 6
		private const string d = "Motorola.Common.Astro.Properties.Settings";

		// Token: 0x04000007 RID: 7
		private const string e = "SelectedLang";

		// Token: 0x04000008 RID: 8
		private const string f = "value";

		// Token: 0x04000009 RID: 9
		private const string g = "name";

		// Token: 0x0400000A RID: 10
		private const string h = "configuration";

		// Token: 0x0400000B RID: 11
		private const string i = "userSettings";

		// Token: 0x0400000C RID: 12
		private const string j = "setting";

		// Token: 0x0400000D RID: 13
		private const string k = "serializeAs";

		// Token: 0x0400000E RID: 14
		private const char l = '‎';

		// Token: 0x0400000F RID: 15
		private const char m = '‏';

		// Token: 0x04000010 RID: 16
		private string n;

		// Token: 0x04000011 RID: 17
		private static global::Motorola.CommonCPS.RadioManagement.CommonBase.AppLanguage o;

		// Token: 0x04000012 RID: 18
		public static readonly string MainAssemblyCulture;

		// Token: 0x04000013 RID: 19
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string p;
	}
}
