using System;
using System.Collections.Generic;
using System.Linq;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConfusabilityBridge;

namespace Features.Zone_Channel_Assignment
{
	// Token: 0x02000003 RID: 3
	public class VoiceAnnouncementCollisionChecker
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000578C File Offset: 0x0000398C
		internal static global::System.Collections.Generic.List<string> CalculateConfusability(string value, global::System.Collections.Generic.List<string> ttsValues, string languageCode = "enu")
		{
			short num = (short)98190454;
			short num2 = num;
			num = (short)176243830;
			global::System.Collections.Generic.List<string> confusedWith;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)855769089;
				if (num != 0)
				{
				}
				num = (short)738787328;
				short num3 = num;
				num = (short)447348736;
				if (num != 0)
				{
				}
				global::ConfusabilityBridge.Clarity clarity = new global::ConfusabilityBridge.Clarity(languageCode);
				try
				{
					ttsValues = ttsValues.Where(delegate(string s)
					{
						short num5 = (short)233736497;
						short num6 = num5;
						num5 = (short)1223723313;
						switch (num6 == num5)
						{
						}
						num5 = (short)1416429569;
						if (num5 != 0)
						{
						}
						num5 = (short)1738342400;
						if (num5 != 0)
						{
						}
						num5 = (short)1036779520;
						short num7 = num5;
						return !string.IsNullOrWhiteSpace(s);
					}).ToList<string>();
					ulong confusionThreshold = 99UL;
					confusedWith = clarity.compare(ttsValues.ToArray()).getConfusedWith(value, confusionThreshold);
				}
				finally
				{
					num = (short)158662658;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_156;
						case 1:
							((global::System.IDisposable)clarity).Dispose();
							num = (short)1136590848;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_121;
							}
							continue;
						}
						IL_121:
						if (clarity == null)
						{
							break;
						}
						num = (short)1211432961;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_156:;
				}
				break;
			}
			}
			return confusedWith;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00005904 File Offset: 0x00003B04
		internal static global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> GlobalConfusabilityMap(global::System.Collections.Generic.IEnumerable<string> ttsValues, string languageCode = "enu")
		{
			short num = (short)199688192;
			switch (num)
			{
			default:
			{
				num = (short)776273921;
				if (num != 0)
				{
				}
				num = (short)177274880;
				short num2 = num;
				global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>();
				global::ConfusabilityBridge.Clarity clarity = new global::ConfusabilityBridge.Clarity(languageCode);
				try
				{
					global::System.Collections.Generic.IEnumerable<string> source = ttsValues;
					global::System.Func<string, bool> predicate = delegate(string s)
					{
						short num5 = (short)1056911586;
						short num6 = num5;
						num5 = (short)2051682530;
						switch (num6 == num5)
						{
						}
						num5 = (short)630390785;
						if (num5 != 0)
						{
						}
						num5 = (short)1588854784;
						if (num5 != 0)
						{
						}
						num5 = (short)1972305920;
						short num7 = num5;
						return !string.IsNullOrWhiteSpace(s);
					};
					for (;;)
					{
						ttsValues = source.Where(predicate).ToList<string>();
						ulong confusionThreshold = 99UL;
						global::ConfusabilityBridge.Clarity.Evaluation evaluation = clarity.compare(ttsValues.ToArray<string>());
						global::System.Collections.Generic.IEnumerator<string> enumerator = ttsValues.GetEnumerator();
						try
						{
							num = (short)1943142403;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_169;
								case 2:
									num = (short)1369899008;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_E2;
									}
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1328611330;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text = enumerator.Current;
									dictionary.Add(text, evaluation.getConfusedWith(text, confusionThreshold));
									num = (short)369426433;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_E4:
								num = (short)1561395204;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_E2:
								goto IL_E4;
							}
							IL_169:
							break;
						}
						finally
						{
							num = (short)776667137;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_22B;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1A1;
									}
									continue;
								case 2:
								{
									enumerator.Dispose();
									num = (short)9091844;
									short num4 = num;
									num = (short)870693636;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_22D;
									default:
										num = (short)30998528;
										if (num != 0)
										{
										}
										num = (short)1480785920;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_1A1:
								if (enumerator == null)
								{
									break;
								}
								num = (short)251527170;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_22B:
							IL_22D:;
						}
					}
				}
				finally
				{
					num = (short)1808728065;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_2C2;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_28C;
							}
							continue;
						case 2:
							((global::System.IDisposable)clarity).Dispose();
							num = (short)1213988864;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_28C:
						if (clarity == null)
						{
							break;
						}
						num = (short)1393229826;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_2C2:;
				}
				return dictionary;
			}
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00005C0C File Offset: 0x00003E0C
		internal static string GetLanguageCode()
		{
			int a_ = 13;
			short num = (short)603848707;
			int num2 = (int)((global::System.IntPtr)num);
			string result;
			for (;;)
			{
				string key;
				string text;
				switch (num2)
				{
				case 0:
					return result;
				case 1:
				{
					if (!new global::System.Collections.Generic.Dictionary<string, string>
					{
						{
							global::CommonResources.AcgResources.ID_ENGLISH,
							global::AllFeatures.CodeplugGuid.b("ꯍ뻏ꟑ", a_)
						},
						{
							global::CommonResources.AcgResources.ID_ENGLISH_AU,
							global::AllFeatures.CodeplugGuid.b("ꯍ뻏돑", a_)
						},
						{
							global::CommonResources.AcgResources.ID_SPANISH_AR,
							global::AllFeatures.CodeplugGuid.b("뷍ꃏ뿑", a_)
						},
						{
							global::CommonResources.AcgResources.ID_SPANISH_CL,
							global::AllFeatures.CodeplugGuid.b("뷍ꃏ뿑", a_)
						},
						{
							global::CommonResources.AcgResources.ID_SPANISH_CO,
							global::AllFeatures.CodeplugGuid.b("뷍ꃏ뿑", a_)
						},
						{
							global::CommonResources.AcgResources.ID_FRENCH,
							global::AllFeatures.CodeplugGuid.b("꣍ꋏ뇑", a_)
						},
						{
							global::CommonResources.AcgResources.ID_PORTUGUESE,
							global::AllFeatures.CodeplugGuid.b("뻍꓏냑", a_)
						}
					}.TryGetValue(key, out result))
					{
						goto IL_284;
					}
					num = (short)1595776803;
					short num3 = num;
					num = (short)1649909539;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num = (short)818348033;
						if (num != 0)
						{
						}
						num = (short)1014431744;
						if (num != 0)
						{
						}
						num = (short)83558400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					text = null;
					goto IL_F6;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				case 4:
					text = null;
					goto IL_F6;
				}
				IL_42:
				global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = global::AcpCommonLib.FeatureManager.GetFeature(2010)[0].FeatureSectionsCollection.ToList<global::AcpCommonLib.IAcpFeatureSection>().FirstOrDefault(delegate(global::AcpCommonLib.IAcpFeatureSection i)
				{
					int a_2 = 10;
					short num5 = (short)1976881626;
					short num6 = num5;
					num5 = (short)178901466;
					switch (num6 == num5)
					{
					}
					num5 = (short)581566465;
					if (num5 != 0)
					{
					}
					num5 = (short)460128256;
					if (num5 != 0)
					{
					}
					num5 = (short)764739584;
					short num7 = num5;
					return i.FeatureSectionName.Contains(global::AllFeatures.CodeplugGuid.b("諊꧌많냐뷒뛔닖뷘", a_2));
				});
				if (acpFeatureSection == null)
				{
					num = (short)719126532;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				global::AcpCommonLib.IAcpField acpField = acpFeatureSection.FieldsCollection.FirstOrDefault(delegate(global::AcpCommonLib.IAcpField j)
				{
					int a_2 = 11;
					short num5 = (short)232476111;
					short num6 = num5;
					num5 = (short)144920015;
					switch (num6 == num5)
					{
					}
					num5 = (short)2146107393;
					if (num5 != 0)
					{
					}
					num5 = (short)1874460672;
					if (num5 != 0)
					{
					}
					num5 = (short)1320091648;
					short num7 = num5;
					return j.Name.Contains(global::AllFeatures.CodeplugGuid.b("裋ꟍꏏꋑ駓돕뛗꿙鷛뫝雟菡諣藥跧軩ꃫ迭黯闱至韵鿷鿹꿻鯽泿朁會爅愇攉戋儍儏⨑✓⸕⸗", a_2));
				});
				if (acpField == null)
				{
					num = (short)921567234;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				text = acpField.ToString();
				IL_F6:
				key = text;
				num = (short)476119040;
				short num4 = num;
				num = (short)407502849;
				num2 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_284:
			return global::AllFeatures.CodeplugGuid.b("ꯍ뻏ꟑ", a_);
		}
	}
}
