using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;
using Motorola.Common.Communication.CommonUtil;
using Motorola.CommonCPS.Server.EntityModel;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS
{
	// Token: 0x02000029 RID: 41
	public sealed class CPS_Languages : global::System.Collections.IEnumerable
	{
		// Token: 0x06000090 RID: 144 RVA: 0x0000FF84 File Offset: 0x0000E184
		internal CPS_Languages()
		{
			int a_ = 1;
			this.appMajorVersion = string.Empty;
			this.appKey = string.Empty;
			this.AppRegistryKeyName = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("균苢诤胦鳨諪諬諮苰", a_);
			this.InstalledAppLanguagesRegistryValue = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꣠跢雤鏦裨蟪臬諮闰닲藴蟶闸鋺黼黾甀樂樄椆䔈樊挌栎搐爒爔爖樘", a_);
			this.DefaultAppLanguagesRegistryValue = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꗠ蛢菤蛦鳨蟪駬껮臰菲駴黶髸髺觼雾渀洂䤄昆月氊砌渎瘐瘒", a_);
			this.AppRegistryKeyBaseLocation = string.Concat(new object[]
			{
				global::PreEmptive.SoS.Runtime.FixedLengthStream.b("닠賢菤鏦黨諪鿬諮", a_),
				global::System.IO.Path.DirectorySeparatorChar,
				global::PreEmptive.SoS.Runtime.FixedLengthStream.b("고賢釤裦鯨蓪臬軮", a_),
				global::System.IO.Path.DirectorySeparatorChar
			});
			base..ctor();
			this.DefaultCPSLanguage = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("蓠跢", a_);
			this.localizedLanguages = new global::System.Collections.Generic.Dictionary<string, string>();
			try
			{
				this.DetermineAppMajorVersion();
				if (this.appMajorVersion == null)
				{
					throw new global::System.ApplicationException(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꋠ돢뛤룦ꗨ諪菬裮蓰鋲鋴鋶諸\udbfa黼郾漀瀂焄甆簈栊礌怎挐⤒㔔琖瘘渚焜笞Ġ䴢䨤匦न䴪䐬䄮唰ጲ吴䜶䤸场吼尾⁀㝂ⱄ⡆❈歊㭌⩎⍐⁒㱔㡖㝘", a_));
				}
				this.appKey = string.Concat(new object[]
				{
					this.AppRegistryKeyBaseLocation,
					global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꃠ鏢鷤ꇦ裨蛪蓬菮裰냲ꗴꓶ\ud9f8", a_),
					this.appMajorVersion,
					global::System.IO.Path.DirectorySeparatorChar,
					this.AppRegistryKeyName
				});
				if (global::Motorola.CommonCPS.Server.EntityModel.VersionInfoHelper.IsDFlagExisted(global::Motorola.Common.Communication.CommonUtil.DFlagType.DASTRO))
				{
					this.appKey = string.Concat(new object[]
					{
						this.AppRegistryKeyBaseLocation,
						global::PreEmptive.SoS.Runtime.FixedLengthStream.b("럠蛢韤鏦賨鏪뻬鯮郰鷲釴零诸鿺뻼꿾刀⌂", a_),
						this.appMajorVersion,
						global::System.IO.Path.DirectorySeparatorChar,
						this.AppRegistryKeyName
					});
				}
				this.DetermineInstalledLanguages();
				this.DetermineDefaultCPSLanguage();
			}
			catch (global::System.Exception ex)
			{
				string.Format(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꋠ돢뛤룦ꗨ諪菬裮蓰鋲鋴鋶諸\udbfa黼郾漀瀂焄甆簈栊礌怎挐㌒愔编欘縚樜㼞䀠䴢Ԥ䈦儨䠪䠬弮䔰娲娴夶ᔸᬺ堼䴾㍀ⱂ㝄絆楈お経㉎子", a_), ex.Message);
				throw;
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00010164 File Offset: 0x0000E364
		private void DetermineAppMajorVersion()
		{
			this.appMajorVersion = string.Empty;
			object[] customAttributes = global::System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(global::System.Reflection.AssemblyInformationalVersionAttribute), false);
			if (customAttributes.Length != 0)
			{
				short num = (short)893760729;
				short num2 = num;
				num = (short)1979888857;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)892010497;
					if (num != 0)
					{
					}
					num = (short)43122688;
					short num3 = num;
					num = (short)363528192;
					if (num != 0)
					{
					}
					this.appMajorVersion = ((global::System.Reflection.AssemblyInformationalVersionAttribute)customAttributes[0]).InformationalVersion.Substring(0, 6);
					return;
				}
				}
			}
			this.appMajorVersion = string.Empty;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00010258 File Offset: 0x0000E458
		private void DetermineInstalledLanguages()
		{
			short num = (short)1319632896;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_94;
				}
				string text4;
				for (;;)
				{
					IL_27:
					num = (short)1168591641;
					short num3 = num;
					num = (short)559237913;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16E;
					default:
						num = (short)664010752;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
						{
							try
							{
								switch (0)
								{
								case 0:
									goto IL_1FF;
								}
								global::System.Globalization.CultureInfo cultureInfo;
								string text;
								string text2;
								for (;;)
								{
									IL_1D0:
									char c;
									switch (num2)
									{
									case 0:
										if (!string.IsNullOrEmpty(cultureInfo.NativeName))
										{
											num = (short)1496580103;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_362;
									case 1:
										if (char.IsPunctuation(cultureInfo.NativeName[cultureInfo.NativeName.Length - 1]))
										{
											num = (short)2105081861;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_362;
									case 2:
										if (cultureInfo.TextInfo.IsRightToLeft)
										{
											num = (short)1684733958;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										c = '‎';
										num = (short)1343619076;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_389;
									case 4:
										goto IL_2D4;
									case 5:
										num = (short)1354432514;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										c = '‏';
										num = (short)475201544;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										num = (short)282787841;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										goto IL_2D4;
									case 9:
										goto IL_362;
									}
									goto IL_1FF;
									IL_2D4:
									text += c;
									num = (short)1881800713;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_362:
									this.localizedLanguages.Add(text, text2);
									num = (short)1806172163;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_389:
								goto IL_1A4;
								IL_1FF:
								string text3;
								text2 = text3.Trim();
								cultureInfo = new global::System.Globalization.CultureInfo(text2);
								text = cultureInfo.NativeName;
								num = (short)804126720;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_1D0;
							}
							catch (global::System.Globalization.CultureNotFoundException)
							{
								goto IL_1A4;
							}
							catch (global::System.Exception)
							{
								throw;
							}
							goto IL_397;
							IL_1A4:
							int num4;
							num4++;
							num = (short)203292674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							if (!string.IsNullOrEmpty(text4))
							{
								num = (short)1049821190;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_397;
						case 2:
							goto IL_135;
						case 3:
							goto IL_135;
						case 4:
							goto IL_16E;
						case 5:
						{
							int num4;
							string[] array;
							if (num4 >= array.Length)
							{
								num = (short)353107972;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string text3 = array[num4];
							global::System.Globalization.CultureInfo cultureInfo = null;
							num = (short)813236224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							string[] array = text4.Split(new char[]
							{
								','
							});
							int num4 = 0;
							num = (short)784990211;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_94;
						IL_135:
						num = (short)795213829;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_16E:
				IL_397:
				num = (short)1473314816;
				short num5 = num;
				return;
				IL_94:
				text4 = string.Empty;
				text4 = global::MackinawCPS.RegistrySettings.GetStringValue(this.appKey, this.InstalledAppLanguagesRegistryValue);
				num = (short)1378549761;
				if (num != 0)
				{
				}
				num = (short)835977217;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0001065C File Offset: 0x0000E85C
		private void DetermineDefaultCPSLanguage()
		{
			int a_ = 17;
			short num = (short)284557312;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_53;
				}
				string text;
				string text2;
				string text3;
				for (;;)
				{
					IL_30:
					string str;
					string str2;
					switch (num2)
					{
					case 0:
						if (string.IsNullOrEmpty(text))
						{
							num = (short)752156678;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C4;
					case 1:
						goto IL_C4;
					case 2:
						num = (short)1479016449;
						if (num != 0)
						{
						}
						try
						{
							text2 = text.Trim();
							new global::System.Globalization.CultureInfo(text2);
							this.DefaultCPSLanguage = text2;
							return;
						}
						catch (global::System.Globalization.CultureNotFoundException)
						{
							return;
						}
						catch (global::System.Exception)
						{
							throw;
						}
						goto IL_226;
					case 3:
					{
						try
						{
							num = (short)585170947;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Xml.XmlNode xmlNode;
									if (xmlNode != null)
									{
										num = (short)848429061;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_377;
								}
								case 1:
									goto IL_377;
								case 2:
									goto IL_38F;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_2D8;
									}
									continue;
								case 4:
								{
									global::System.Xml.XmlNode xmlNode = null;
									global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
									xmlDocument.Load(text3);
									xmlNode = xmlDocument.SelectSingleNode(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("\udef0郲髴駶鿸鋺髼諾猀戂焄渆昈攊∌税成瘒朔䐖簘漚検瘞传䐢嘤ࠦ搨䨪丬䐮堰崲吴䀶稸欺渼ᄾᅀㅂ⩄㝆ⱈ㥊㥌♎㑐⁒答і㱘⽚⥜㙞འѢᙤ䡦ᩨ๪ᥬ᭮ᡰᵲቴⱶ㥸ᕺᱼቾ뺂ꊄ튆愈ﾌ\udc8eﾒﺚ列\ude9e토펢즤캦쪨쪪\ud9ac욮\udeb0\uddb2領횶ힸ\udcba좼\udebeꛀꛂ髆뷊곌ꏎꓐ뛒", a_));
									num = (short)120455168;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::System.Xml.XmlNode xmlNode;
									text = xmlNode.InnerText;
									num = (short)407240705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_2D8:
								if (global::System.IO.File.Exists(text3))
								{
									num = (short)1824063492;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_377:
								num = (short)612106242;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_38F:
							goto IL_157;
						}
						catch (global::System.Exception)
						{
							goto IL_157;
						}
						return;
						IL_157:
						num = (short)1933600293;
						short num3 = num;
						num = (short)625436197;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_269;
						default:
							num = (short)338034688;
							if (num != 0)
							{
							}
							num = (short)816381952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
					{
						str = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.LocalApplicationData) + global::PreEmptive.SoS.Runtime.FixedLengthStream.b("귰뻲髴菶雸觺鋼鏾怀専嘄栆攈縊礌明縐紒昔㬖䘘刚猜簞", a_);
						str2 = string.Empty;
						object[] customAttributes = global::System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(global::System.Reflection.AssemblyInformationalVersionAttribute), false);
						if (customAttributes.Length == 0)
						{
							str2 = string.Empty;
							goto IL_226;
						}
						str2 = ((global::System.Reflection.AssemblyInformationalVersionAttribute)customAttributes[0]).InformationalVersion.Substring(1, 2);
						goto IL_226;
					}
					case 5:
					{
						num = (short)210501632;
						short num4 = num;
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)1279787010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 6:
						goto IL_269;
					}
					goto IL_53;
					IL_C4:
					num = (short)1300430853;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_226:
					text3 = str + global::PreEmptive.SoS.Runtime.FixedLengthStream.b("귰", a_) + str2 + global::PreEmptive.SoS.Runtime.FixedLengthStream.b("귰蛲蛴鋶诸髺跼迾⼀怂樄椆漈戊樌", a_);
					num = (short)150405123;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_269:
					text = global::MackinawCPS.RegistrySettings.GetStringValue(this.appKey, this.DefaultAppLanguagesRegistryValue);
					num = (short)192610305;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_53:
				text = string.Empty;
				text2 = string.Empty;
				text3 = string.Empty;
				string empty = string.Empty;
				num = (short)227540996;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00010A2C File Offset: 0x0000EC2C
		internal int Count
		{
			get
			{
				short num = (short)507448445;
				short num2 = num;
				num = (short)1383337085;
				switch (num2 == num)
				{
				default:
				{
					num = (short)651821056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1070727168;
				if (num != 0)
				{
				}
				num = (short)1448804353;
				if (num != 0)
				{
				}
				return this.localizedLanguages.Count;
			}
		}

		// Token: 0x1700000E RID: 14
		internal string this[string culture]
		{
			get
			{
				short num = (short)1032829471;
				short num2 = num;
				num = (short)1355069983;
				string result;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_D2:
					if (!this.localizedLanguages.TryGetValue(culture, out result))
					{
						return result;
					}
					num = (short)2061631490;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)533856257;
					if (num != 0)
					{
					}
					num = (short)226164736;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8D;
					}
					break;
				}
				for (;;)
				{
					IL_7B:
					switch (num3)
					{
					case 0:
						goto IL_11E;
					case 1:
						goto IL_D2;
					case 2:
						result = this.localizedLanguages[culture];
						num = (short)924909568;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8D;
				}
				IL_11E:
				return result;
				IL_8D:
				num = (short)304021504;
				short num4 = num;
				result = string.Empty;
				num = (short)696320001;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7B;
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00010C10 File Offset: 0x0000EE10
		internal bool IsLanguageAvailable(string language)
		{
			short num = (short)1066327309;
			short num2 = num;
			num = (short)340712717;
			bool result;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_A5:
				if (!this.localizedLanguages.ContainsValue(language))
				{
					return result;
				}
				num = (short)137822210;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)529530880;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				break;
			}
			for (;;)
			{
				IL_54:
				switch (num3)
				{
				case 0:
					goto IL_10B;
				case 1:
					goto IL_A5;
				case 2:
					num = (short)585957377;
					if (num != 0)
					{
					}
					result = true;
					num = (short)245825536;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_66;
			}
			IL_10B:
			return result;
			IL_66:
			result = false;
			num = (short)9437184;
			short num4 = num;
			num = (short)71368705;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_54;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00010D2C File Offset: 0x0000EF2C
		internal string[] AdditionalCPSLanguages()
		{
			short num = (short)54348522;
			short num2 = num;
			num = (short)1505577706;
			switch (num2 == num)
			{
			default:
			{
				num = (short)380305408;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1633681408;
			if (num != 0)
			{
			}
			num = (short)613023745;
			if (num != 0)
			{
			}
			return new global::System.Collections.Generic.List<string>(this.localizedLanguages.Values).ToArray();
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00010DE8 File Offset: 0x0000EFE8
		internal string[] AdditionalCPSLanguagesDisplayNames()
		{
			short num = (short)173155954;
			short num2 = num;
			num = (short)257304178;
			switch (num2 == num)
			{
			default:
			{
				num = (short)116391936;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1743257601;
			if (num != 0)
			{
			}
			num = (short)602210304;
			if (num != 0)
			{
			}
			return new global::System.Collections.Generic.List<string>(this.localizedLanguages.Keys).ToArray();
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00010EA4 File Offset: 0x0000F0A4
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00010F54 File Offset: 0x0000F154
		internal string DefaultCPSLanguage
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1865313614;
				short num2 = num;
				num = (short)1569025358;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1998585856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1311965184;
				if (num != 0)
				{
				}
				num = (short)1170472961;
				if (num != 0)
				{
				}
				return this.<DefaultCPSLanguage>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1002510405;
				short num2 = num;
				num = (short)326178885;
				switch (num2 == num)
				{
				default:
				{
					num = (short)197787648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1797062656;
				if (num != 0)
				{
				}
				num = (short)1422655489;
				if (num != 0)
				{
				}
				this.<DefaultCPSLanguage>k__BackingField = value;
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00011008 File Offset: 0x0000F208
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			short num = (short)449904640;
			short num2 = num;
			num = (short)1952860146;
			short num3 = num;
			num = (short)514934770;
			switch (num3 == num)
			{
			}
			num = (short)1501954048;
			if (num != 0)
			{
			}
			num = (short)713818113;
			if (num != 0)
			{
			}
			return this.localizedLanguages.GetEnumerator();
		}

		// Token: 0x04000043 RID: 67
		private global::System.Collections.Generic.Dictionary<string, string> localizedLanguages;

		// Token: 0x04000044 RID: 68
		private string appMajorVersion;

		// Token: 0x04000045 RID: 69
		private string appKey;

		// Token: 0x04000046 RID: 70
		private string AppRegistryKeyName;

		// Token: 0x04000047 RID: 71
		private string InstalledAppLanguagesRegistryValue;

		// Token: 0x04000048 RID: 72
		private string DefaultAppLanguagesRegistryValue;

		// Token: 0x04000049 RID: 73
		private string AppRegistryKeyBaseLocation;

		// Token: 0x0400004A RID: 74
		private const char LRM = '‎';

		// Token: 0x0400004B RID: 75
		private const char RLM = '‏';

		// Token: 0x0400004D RID: 77
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
