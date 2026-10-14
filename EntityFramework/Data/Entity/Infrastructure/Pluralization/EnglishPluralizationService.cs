using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Design.PluralizationServices;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace System.Data.Entity.Infrastructure.Pluralization
{
	// Token: 0x0200026B RID: 619
	public sealed class EnglishPluralizationService : global::System.Data.Entity.Infrastructure.Pluralization.IPluralizationService
	{
		// Token: 0x06001F67 RID: 8039 RVA: 0x00055F08 File Offset: 0x00054108
		public EnglishPluralizationService()
		{
			this._userDictionary = new global::System.Data.Entity.Infrastructure.Pluralization.BidirectionalDictionary<string, string>();
			this._irregularPluralsPluralizationService = new global::System.Data.Entity.ModelConfiguration.Design.PluralizationServices.StringBidirectionalDictionary(this._irregularPluralsList);
			this._assimilatedClassicalInflectionPluralizationService = new global::System.Data.Entity.ModelConfiguration.Design.PluralizationServices.StringBidirectionalDictionary(this._assimilatedClassicalInflectionList);
			this._oSuffixPluralizationService = new global::System.Data.Entity.ModelConfiguration.Design.PluralizationServices.StringBidirectionalDictionary(this._oSuffixList);
			this._classicalInflectionPluralizationService = new global::System.Data.Entity.ModelConfiguration.Design.PluralizationServices.StringBidirectionalDictionary(this._classicalInflectionList);
			this._wordsEndingWithSePluralizationService = new global::System.Data.Entity.ModelConfiguration.Design.PluralizationServices.StringBidirectionalDictionary(this._wordsEndingWithSeList);
			this._wordsEndingWithSisPluralizationService = new global::System.Data.Entity.ModelConfiguration.Design.PluralizationServices.StringBidirectionalDictionary(this._wordsEndingWithSisList);
			this._irregularVerbPluralizationService = new global::System.Data.Entity.ModelConfiguration.Design.PluralizationServices.StringBidirectionalDictionary(this._irregularVerbList);
			this._knownSingluarWords = new global::System.Collections.Generic.List<string>(this._irregularPluralsList.Keys.Concat(this._assimilatedClassicalInflectionList.Keys).Concat(this._oSuffixList.Keys).Concat(this._classicalInflectionList.Keys).Concat(this._irregularVerbList.Keys).Concat(this._uninflectiveWords).Except(this._knownConflictingPluralList));
			this._knownPluralWords = new global::System.Collections.Generic.List<string>(this._irregularPluralsList.Values.Concat(this._assimilatedClassicalInflectionList.Values).Concat(this._oSuffixList.Values).Concat(this._classicalInflectionList.Values).Concat(this._irregularVerbList.Values).Concat(this._uninflectiveWords));
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x00057CE7 File Offset: 0x00055EE7
		public EnglishPluralizationService(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Infrastructure.Pluralization.CustomPluralizationEntry> userDictionaryEntries) : this()
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Infrastructure.Pluralization.CustomPluralizationEntry>>(userDictionaryEntries, "userDictionaryEntries");
			userDictionaryEntries.Each(delegate(global::System.Data.Entity.Infrastructure.Pluralization.CustomPluralizationEntry entry)
			{
				this._userDictionary.AddValue(entry.Singular, entry.Plural);
			});
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x00057D0D File Offset: 0x00055F0D
		public string Pluralize(string word)
		{
			return global::System.Data.Entity.Infrastructure.Pluralization.EnglishPluralizationService.Capitalize(word, new global::System.Func<string, string>(this.InternalPluralize));
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x00057D24 File Offset: 0x00055F24
		private string InternalPluralize(string word)
		{
			if (this._userDictionary.ExistsInFirst(word))
			{
				return this._userDictionary.GetSecondValue(word);
			}
			if (this.IsNoOpWord(word))
			{
				return word;
			}
			string str;
			string suffixWord = global::System.Data.Entity.Infrastructure.Pluralization.EnglishPluralizationService.GetSuffixWord(word, out str);
			if (this.IsNoOpWord(suffixWord))
			{
				return str + suffixWord;
			}
			if (this.IsUninflective(suffixWord))
			{
				return str + suffixWord;
			}
			if (this._knownPluralWords.Contains(suffixWord.ToLowerInvariant()) || this.IsPlural(suffixWord))
			{
				return str + suffixWord;
			}
			if (this._irregularPluralsPluralizationService.ExistsInFirst(suffixWord))
			{
				return str + this._irregularPluralsPluralizationService.GetSecondValue(suffixWord);
			}
			string word2 = suffixWord;
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			list.Add("man");
			string str2;
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(word2, list, (string s) => s.Remove(s.Length - 2, 2) + "en", this._culture, out str2))
			{
				return str + str2;
			}
			string word3 = suffixWord;
			global::System.Collections.Generic.List<string> list2 = new global::System.Collections.Generic.List<string>();
			list2.Add("louse");
			list2.Add("mouse");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(word3, list2, (string s) => s.Remove(s.Length - 4, 4) + "ice", this._culture, out str2))
			{
				return str + str2;
			}
			string word4 = suffixWord;
			global::System.Collections.Generic.List<string> list3 = new global::System.Collections.Generic.List<string>();
			list3.Add("tooth");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(word4, list3, (string s) => s.Remove(s.Length - 4, 4) + "eeth", this._culture, out str2))
			{
				return str + str2;
			}
			string word5 = suffixWord;
			global::System.Collections.Generic.List<string> list4 = new global::System.Collections.Generic.List<string>();
			list4.Add("goose");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(word5, list4, (string s) => s.Remove(s.Length - 4, 4) + "eese", this._culture, out str2))
			{
				return str + str2;
			}
			string word6 = suffixWord;
			global::System.Collections.Generic.List<string> list5 = new global::System.Collections.Generic.List<string>();
			list5.Add("foot");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(word6, list5, (string s) => s.Remove(s.Length - 3, 3) + "eet", this._culture, out str2))
			{
				return str + str2;
			}
			string word7 = suffixWord;
			global::System.Collections.Generic.List<string> list6 = new global::System.Collections.Generic.List<string>();
			list6.Add("zoon");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(word7, list6, (string s) => s.Remove(s.Length - 3, 3) + "oa", this._culture, out str2))
			{
				return str + str2;
			}
			string word8 = suffixWord;
			global::System.Collections.Generic.List<string> list7 = new global::System.Collections.Generic.List<string>();
			list7.Add("cis");
			list7.Add("sis");
			list7.Add("xis");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(word8, list7, (string s) => s.Remove(s.Length - 2, 2) + "es", this._culture, out str2))
			{
				return str + str2;
			}
			if (this._assimilatedClassicalInflectionPluralizationService.ExistsInFirst(suffixWord))
			{
				return str + this._assimilatedClassicalInflectionPluralizationService.GetSecondValue(suffixWord);
			}
			if (this._classicalInflectionPluralizationService.ExistsInFirst(suffixWord))
			{
				return str + this._classicalInflectionPluralizationService.GetSecondValue(suffixWord);
			}
			string word9 = suffixWord;
			global::System.Collections.Generic.List<string> list8 = new global::System.Collections.Generic.List<string>();
			list8.Add("trix");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(word9, list8, (string s) => s.Remove(s.Length - 1, 1) + "ces", this._culture, out str2))
			{
				return str + str2;
			}
			string word10 = suffixWord;
			global::System.Collections.Generic.List<string> list9 = new global::System.Collections.Generic.List<string>();
			list9.Add("eau");
			list9.Add("ieu");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(word10, list9, (string s) => s + "x", this._culture, out str2))
			{
				return str + str2;
			}
			string word11 = suffixWord;
			global::System.Collections.Generic.List<string> list10 = new global::System.Collections.Generic.List<string>();
			list10.Add("inx");
			list10.Add("anx");
			list10.Add("ynx");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(word11, list10, (string s) => s.Remove(s.Length - 1, 1) + "ges", this._culture, out str2))
			{
				return str + str2;
			}
			string word12 = suffixWord;
			global::System.Collections.Generic.List<string> list11 = new global::System.Collections.Generic.List<string>();
			list11.Add("ch");
			list11.Add("sh");
			list11.Add("ss");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(word12, list11, (string s) => s + "es", this._culture, out str2))
			{
				return str + str2;
			}
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, new global::System.Collections.Generic.List<string>
			{
				"alf",
				"elf",
				"olf",
				"eaf",
				"arf"
			}, delegate(string s)
			{
				if (!s.EndsWith("deaf", true, this._culture))
				{
					return s.Remove(s.Length - 1, 1) + "ves";
				}
				return s;
			}, this._culture, out str2))
			{
				return str + str2;
			}
			string word13 = suffixWord;
			global::System.Collections.Generic.List<string> list12 = new global::System.Collections.Generic.List<string>();
			list12.Add("nife");
			list12.Add("life");
			list12.Add("wife");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(word13, list12, (string s) => s.Remove(s.Length - 2, 2) + "ves", this._culture, out str2))
			{
				return str + str2;
			}
			string word14 = suffixWord;
			global::System.Collections.Generic.List<string> list13 = new global::System.Collections.Generic.List<string>();
			list13.Add("ay");
			list13.Add("ey");
			list13.Add("iy");
			list13.Add("oy");
			list13.Add("uy");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(word14, list13, (string s) => s + "s", this._culture, out str2))
			{
				return str + str2;
			}
			if (suffixWord.EndsWith("y", true, this._culture))
			{
				return str + suffixWord.Remove(suffixWord.Length - 1, 1) + "ies";
			}
			if (this._oSuffixPluralizationService.ExistsInFirst(suffixWord))
			{
				return str + this._oSuffixPluralizationService.GetSecondValue(suffixWord);
			}
			string word15 = suffixWord;
			global::System.Collections.Generic.List<string> list14 = new global::System.Collections.Generic.List<string>();
			list14.Add("ao");
			list14.Add("eo");
			list14.Add("io");
			list14.Add("oo");
			list14.Add("uo");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(word15, list14, (string s) => s + "s", this._culture, out str2))
			{
				return str + str2;
			}
			if (suffixWord.EndsWith("o", true, this._culture))
			{
				return str + suffixWord + "es";
			}
			if (suffixWord.EndsWith("x", true, this._culture))
			{
				return str + suffixWord + "es";
			}
			return str + suffixWord + "s";
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x000583AF File Offset: 0x000565AF
		public string Singularize(string word)
		{
			return global::System.Data.Entity.Infrastructure.Pluralization.EnglishPluralizationService.Capitalize(word, new global::System.Func<string, string>(this.InternalSingularize));
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x000583C4 File Offset: 0x000565C4
		private string InternalSingularize(string word)
		{
			if (this._userDictionary.ExistsInSecond(word))
			{
				return this._userDictionary.GetFirstValue(word);
			}
			if (this.IsNoOpWord(word))
			{
				return word;
			}
			string str;
			string suffixWord = global::System.Data.Entity.Infrastructure.Pluralization.EnglishPluralizationService.GetSuffixWord(word, out str);
			if (this.IsNoOpWord(suffixWord))
			{
				return str + suffixWord;
			}
			if (this.IsUninflective(suffixWord))
			{
				return str + suffixWord;
			}
			if (this._knownSingluarWords.Contains(suffixWord.ToLowerInvariant()))
			{
				return str + suffixWord;
			}
			if (this._irregularVerbPluralizationService.ExistsInSecond(suffixWord))
			{
				return str + this._irregularVerbPluralizationService.GetFirstValue(suffixWord);
			}
			if (this._irregularPluralsPluralizationService.ExistsInSecond(suffixWord))
			{
				return str + this._irregularPluralsPluralizationService.GetFirstValue(suffixWord);
			}
			if (this._wordsEndingWithSisPluralizationService.ExistsInSecond(suffixWord))
			{
				return str + this._wordsEndingWithSisPluralizationService.GetFirstValue(suffixWord);
			}
			if (this._wordsEndingWithSePluralizationService.ExistsInSecond(suffixWord))
			{
				return str + this._wordsEndingWithSePluralizationService.GetFirstValue(suffixWord);
			}
			string suffixWord16 = suffixWord;
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			list.Add("men");
			string str2;
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord16, list, (string s) => s.Remove(s.Length - 2, 2) + "an", this._culture, out str2))
			{
				return str + str2;
			}
			string suffixWord2 = suffixWord;
			global::System.Collections.Generic.List<string> list2 = new global::System.Collections.Generic.List<string>();
			list2.Add("lice");
			list2.Add("mice");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord2, list2, (string s) => s.Remove(s.Length - 3, 3) + "ouse", this._culture, out str2))
			{
				return str + str2;
			}
			string suffixWord3 = suffixWord;
			global::System.Collections.Generic.List<string> list3 = new global::System.Collections.Generic.List<string>();
			list3.Add("teeth");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord3, list3, (string s) => s.Remove(s.Length - 4, 4) + "ooth", this._culture, out str2))
			{
				return str + str2;
			}
			string suffixWord4 = suffixWord;
			global::System.Collections.Generic.List<string> list4 = new global::System.Collections.Generic.List<string>();
			list4.Add("geese");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord4, list4, (string s) => s.Remove(s.Length - 4, 4) + "oose", this._culture, out str2))
			{
				return str + str2;
			}
			string suffixWord5 = suffixWord;
			global::System.Collections.Generic.List<string> list5 = new global::System.Collections.Generic.List<string>();
			list5.Add("feet");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord5, list5, (string s) => s.Remove(s.Length - 3, 3) + "oot", this._culture, out str2))
			{
				return str + str2;
			}
			string suffixWord6 = suffixWord;
			global::System.Collections.Generic.List<string> list6 = new global::System.Collections.Generic.List<string>();
			list6.Add("zoa");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord6, list6, (string s) => s.Remove(s.Length - 2, 2) + "oon", this._culture, out str2))
			{
				return str + str2;
			}
			string suffixWord7 = suffixWord;
			global::System.Collections.Generic.List<string> list7 = new global::System.Collections.Generic.List<string>();
			list7.Add("ches");
			list7.Add("shes");
			list7.Add("sses");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord7, list7, (string s) => s.Remove(s.Length - 2, 2), this._culture, out str2))
			{
				return str + str2;
			}
			if (this._assimilatedClassicalInflectionPluralizationService.ExistsInSecond(suffixWord))
			{
				return str + this._assimilatedClassicalInflectionPluralizationService.GetFirstValue(suffixWord);
			}
			if (this._classicalInflectionPluralizationService.ExistsInSecond(suffixWord))
			{
				return str + this._classicalInflectionPluralizationService.GetFirstValue(suffixWord);
			}
			string suffixWord8 = suffixWord;
			global::System.Collections.Generic.List<string> list8 = new global::System.Collections.Generic.List<string>();
			list8.Add("trices");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord8, list8, (string s) => s.Remove(s.Length - 3, 3) + "x", this._culture, out str2))
			{
				return str + str2;
			}
			string suffixWord9 = suffixWord;
			global::System.Collections.Generic.List<string> list9 = new global::System.Collections.Generic.List<string>();
			list9.Add("eaux");
			list9.Add("ieux");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord9, list9, (string s) => s.Remove(s.Length - 1, 1), this._culture, out str2))
			{
				return str + str2;
			}
			string suffixWord10 = suffixWord;
			global::System.Collections.Generic.List<string> list10 = new global::System.Collections.Generic.List<string>();
			list10.Add("inges");
			list10.Add("anges");
			list10.Add("ynges");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord10, list10, (string s) => s.Remove(s.Length - 3, 3) + "x", this._culture, out str2))
			{
				return str + str2;
			}
			string suffixWord11 = suffixWord;
			global::System.Collections.Generic.List<string> list11 = new global::System.Collections.Generic.List<string>();
			list11.Add("alves");
			list11.Add("elves");
			list11.Add("olves");
			list11.Add("eaves");
			list11.Add("arves");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord11, list11, (string s) => s.Remove(s.Length - 3, 3) + "f", this._culture, out str2))
			{
				return str + str2;
			}
			string suffixWord12 = suffixWord;
			global::System.Collections.Generic.List<string> list12 = new global::System.Collections.Generic.List<string>();
			list12.Add("nives");
			list12.Add("lives");
			list12.Add("wives");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord12, list12, (string s) => s.Remove(s.Length - 3, 3) + "fe", this._culture, out str2))
			{
				return str + str2;
			}
			string suffixWord13 = suffixWord;
			global::System.Collections.Generic.List<string> list13 = new global::System.Collections.Generic.List<string>();
			list13.Add("ays");
			list13.Add("eys");
			list13.Add("iys");
			list13.Add("oys");
			list13.Add("uys");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord13, list13, (string s) => s.Remove(s.Length - 1, 1), this._culture, out str2))
			{
				return str + str2;
			}
			if (suffixWord.EndsWith("ies", true, this._culture))
			{
				return str + suffixWord.Remove(suffixWord.Length - 3, 3) + "y";
			}
			if (this._oSuffixPluralizationService.ExistsInSecond(suffixWord))
			{
				return str + this._oSuffixPluralizationService.GetFirstValue(suffixWord);
			}
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, new global::System.Collections.Generic.List<string>
			{
				"aos",
				"eos",
				"ios",
				"oos",
				"uos"
			}, (string s) => suffixWord.Remove(suffixWord.Length - 1, 1), this._culture, out str2))
			{
				return str + str2;
			}
			string suffixWord14 = suffixWord;
			global::System.Collections.Generic.List<string> list14 = new global::System.Collections.Generic.List<string>();
			list14.Add("ces");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord14, list14, (string s) => s.Remove(s.Length - 1, 1), this._culture, out str2))
			{
				return str + str2;
			}
			string suffixWord15 = suffixWord;
			global::System.Collections.Generic.List<string> list15 = new global::System.Collections.Generic.List<string>();
			list15.Add("ces");
			list15.Add("ses");
			list15.Add("xes");
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord15, list15, (string s) => s.Remove(s.Length - 2, 2), this._culture, out str2))
			{
				return str + str2;
			}
			if (suffixWord.EndsWith("oes", true, this._culture))
			{
				return str + suffixWord.Remove(suffixWord.Length - 2, 2);
			}
			if (suffixWord.EndsWith("ss", true, this._culture))
			{
				return str + suffixWord;
			}
			if (suffixWord.EndsWith("s", true, this._culture))
			{
				return str + suffixWord.Remove(suffixWord.Length - 1, 1);
			}
			return str + suffixWord;
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x00058C14 File Offset: 0x00056E14
		private bool IsPlural(string word)
		{
			return this._userDictionary.ExistsInSecond(word) || (!this._userDictionary.ExistsInFirst(word) && (this.IsUninflective(word) || this._knownPluralWords.Contains(word.ToLower(this._culture)) || !this.Singularize(word).Equals(word)));
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x00058C78 File Offset: 0x00056E78
		private static string Capitalize(string word, global::System.Func<string, string> action)
		{
			string text = action(word);
			if (!global::System.Data.Entity.Infrastructure.Pluralization.EnglishPluralizationService.IsCapitalized(word))
			{
				return text;
			}
			if (text.Length == 0)
			{
				return text;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(text.Length);
			stringBuilder.Append(char.ToUpperInvariant(text[0]));
			stringBuilder.Append(text.Substring(1));
			return stringBuilder.ToString();
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x00058CD4 File Offset: 0x00056ED4
		private static string GetSuffixWord(string word, out string prefixWord)
		{
			int num = word.LastIndexOf(' ');
			prefixWord = word.Substring(0, num + 1);
			return word.Substring(num + 1);
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x00058CFF File Offset: 0x00056EFF
		private static bool IsCapitalized(string word)
		{
			return !string.IsNullOrEmpty(word) && char.IsUpper(word, 0);
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x00058D12 File Offset: 0x00056F12
		private static bool IsAlphabets(string word)
		{
			return !string.IsNullOrEmpty(word.Trim()) && word.Equals(word.Trim()) && !global::System.Text.RegularExpressions.Regex.IsMatch(word, "[^a-zA-Z\\s]");
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x00058D40 File Offset: 0x00056F40
		private bool IsUninflective(string word)
		{
			return global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.DoesWordContainSuffix(word, this._uninflectiveSuffixes, this._culture) || (!word.ToLower(this._culture).Equals(word) && word.EndsWith("ese", false, this._culture)) || this._uninflectiveWords.Contains(word.ToLowerInvariant());
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x00058D9F File Offset: 0x00056F9F
		private bool IsNoOpWord(string word)
		{
			return !global::System.Data.Entity.Infrastructure.Pluralization.EnglishPluralizationService.IsAlphabets(word) || word.Length <= 1 || this._pronounList.Contains(word.ToLowerInvariant());
		}

		// Token: 0x04000B51 RID: 2897
		private readonly global::System.Data.Entity.Infrastructure.Pluralization.BidirectionalDictionary<string, string> _userDictionary;

		// Token: 0x04000B52 RID: 2898
		private readonly global::System.Data.Entity.ModelConfiguration.Design.PluralizationServices.StringBidirectionalDictionary _irregularPluralsPluralizationService;

		// Token: 0x04000B53 RID: 2899
		private readonly global::System.Data.Entity.ModelConfiguration.Design.PluralizationServices.StringBidirectionalDictionary _assimilatedClassicalInflectionPluralizationService;

		// Token: 0x04000B54 RID: 2900
		private readonly global::System.Data.Entity.ModelConfiguration.Design.PluralizationServices.StringBidirectionalDictionary _oSuffixPluralizationService;

		// Token: 0x04000B55 RID: 2901
		private readonly global::System.Data.Entity.ModelConfiguration.Design.PluralizationServices.StringBidirectionalDictionary _classicalInflectionPluralizationService;

		// Token: 0x04000B56 RID: 2902
		private readonly global::System.Data.Entity.ModelConfiguration.Design.PluralizationServices.StringBidirectionalDictionary _irregularVerbPluralizationService;

		// Token: 0x04000B57 RID: 2903
		private readonly global::System.Data.Entity.ModelConfiguration.Design.PluralizationServices.StringBidirectionalDictionary _wordsEndingWithSePluralizationService;

		// Token: 0x04000B58 RID: 2904
		private readonly global::System.Data.Entity.ModelConfiguration.Design.PluralizationServices.StringBidirectionalDictionary _wordsEndingWithSisPluralizationService;

		// Token: 0x04000B59 RID: 2905
		private readonly global::System.Collections.Generic.List<string> _knownSingluarWords;

		// Token: 0x04000B5A RID: 2906
		private readonly global::System.Collections.Generic.List<string> _knownPluralWords;

		// Token: 0x04000B5B RID: 2907
		private readonly global::System.Globalization.CultureInfo _culture = new global::System.Globalization.CultureInfo("en-US");

		// Token: 0x04000B5C RID: 2908
		private readonly string[] _uninflectiveSuffixes = new string[]
		{
			"fish",
			"ois",
			"sheep",
			"deer",
			"pos",
			"itis",
			"ism"
		};

		// Token: 0x04000B5D RID: 2909
		private readonly string[] _uninflectiveWords = new string[]
		{
			"bison",
			"flounder",
			"pliers",
			"bream",
			"gallows",
			"proceedings",
			"breeches",
			"graffiti",
			"rabies",
			"britches",
			"headquarters",
			"salmon",
			"carp",
			"herpes",
			"scissors",
			"chassis",
			"high-jinks",
			"sea-bass",
			"clippers",
			"homework",
			"series",
			"cod",
			"innings",
			"shears",
			"contretemps",
			"jackanapes",
			"species",
			"corps",
			"mackerel",
			"swine",
			"debris",
			"measles",
			"trout",
			"diabetes",
			"mews",
			"tuna",
			"djinn",
			"mumps",
			"whiting",
			"eland",
			"news",
			"wildebeest",
			"elk",
			"pincers",
			"police",
			"hair",
			"ice",
			"chaos",
			"milk",
			"cotton",
			"corn",
			"millet",
			"hay",
			"pneumonoultramicroscopicsilicovolcanoconiosis",
			"information",
			"rice",
			"tobacco",
			"aircraft",
			"rabies",
			"scabies",
			"diabetes",
			"traffic",
			"cotton",
			"corn",
			"millet",
			"rice",
			"hay",
			"hemp",
			"tobacco",
			"cabbage",
			"okra",
			"broccoli",
			"asparagus",
			"lettuce",
			"beef",
			"pork",
			"venison",
			"bison",
			"mutton",
			"cattle",
			"offspring",
			"molasses",
			"shambles",
			"shingles"
		};

		// Token: 0x04000B5E RID: 2910
		private readonly global::System.Collections.Generic.Dictionary<string, string> _irregularVerbList = new global::System.Collections.Generic.Dictionary<string, string>
		{
			{
				"am",
				"are"
			},
			{
				"are",
				"are"
			},
			{
				"is",
				"are"
			},
			{
				"was",
				"were"
			},
			{
				"were",
				"were"
			},
			{
				"has",
				"have"
			},
			{
				"have",
				"have"
			}
		};

		// Token: 0x04000B5F RID: 2911
		private readonly global::System.Collections.Generic.List<string> _pronounList = new global::System.Collections.Generic.List<string>
		{
			"I",
			"we",
			"you",
			"he",
			"she",
			"they",
			"it",
			"me",
			"us",
			"him",
			"her",
			"them",
			"myself",
			"ourselves",
			"yourself",
			"himself",
			"herself",
			"itself",
			"oneself",
			"oneselves",
			"my",
			"our",
			"your",
			"his",
			"their",
			"its",
			"mine",
			"yours",
			"hers",
			"theirs",
			"this",
			"that",
			"these",
			"those",
			"all",
			"another",
			"any",
			"anybody",
			"anyone",
			"anything",
			"both",
			"each",
			"other",
			"either",
			"everyone",
			"everybody",
			"everything",
			"most",
			"much",
			"nothing",
			"nobody",
			"none",
			"one",
			"others",
			"some",
			"somebody",
			"someone",
			"something",
			"what",
			"whatever",
			"which",
			"whichever",
			"who",
			"whoever",
			"whom",
			"whomever",
			"whose"
		};

		// Token: 0x04000B60 RID: 2912
		private readonly global::System.Collections.Generic.Dictionary<string, string> _irregularPluralsList = new global::System.Collections.Generic.Dictionary<string, string>
		{
			{
				"brother",
				"brothers"
			},
			{
				"child",
				"children"
			},
			{
				"cow",
				"cows"
			},
			{
				"ephemeris",
				"ephemerides"
			},
			{
				"genie",
				"genies"
			},
			{
				"money",
				"moneys"
			},
			{
				"mongoose",
				"mongooses"
			},
			{
				"mythos",
				"mythoi"
			},
			{
				"octopus",
				"octopuses"
			},
			{
				"ox",
				"oxen"
			},
			{
				"soliloquy",
				"soliloquies"
			},
			{
				"trilby",
				"trilbys"
			},
			{
				"crisis",
				"crises"
			},
			{
				"synopsis",
				"synopses"
			},
			{
				"rose",
				"roses"
			},
			{
				"gas",
				"gases"
			},
			{
				"bus",
				"buses"
			},
			{
				"axis",
				"axes"
			},
			{
				"memo",
				"memos"
			},
			{
				"casino",
				"casinos"
			},
			{
				"silo",
				"silos"
			},
			{
				"stereo",
				"stereos"
			},
			{
				"studio",
				"studios"
			},
			{
				"lens",
				"lenses"
			},
			{
				"alias",
				"aliases"
			},
			{
				"pie",
				"pies"
			},
			{
				"corpus",
				"corpora"
			},
			{
				"viscus",
				"viscera"
			},
			{
				"hippopotamus",
				"hippopotami"
			},
			{
				"trace",
				"traces"
			},
			{
				"person",
				"people"
			},
			{
				"chilli",
				"chillies"
			},
			{
				"analysis",
				"analyses"
			},
			{
				"basis",
				"bases"
			},
			{
				"neurosis",
				"neuroses"
			},
			{
				"oasis",
				"oases"
			},
			{
				"synthesis",
				"syntheses"
			},
			{
				"thesis",
				"theses"
			},
			{
				"pneumonoultramicroscopicsilicovolcanoconiosis",
				"pneumonoultramicroscopicsilicovolcanoconioses"
			},
			{
				"status",
				"statuses"
			},
			{
				"prospectus",
				"prospectuses"
			},
			{
				"change",
				"changes"
			},
			{
				"lie",
				"lies"
			},
			{
				"calorie",
				"calories"
			},
			{
				"freebie",
				"freebies"
			},
			{
				"case",
				"cases"
			},
			{
				"house",
				"houses"
			},
			{
				"valve",
				"valves"
			},
			{
				"cloth",
				"clothes"
			}
		};

		// Token: 0x04000B61 RID: 2913
		private readonly global::System.Collections.Generic.Dictionary<string, string> _assimilatedClassicalInflectionList = new global::System.Collections.Generic.Dictionary<string, string>
		{
			{
				"alumna",
				"alumnae"
			},
			{
				"alga",
				"algae"
			},
			{
				"vertebra",
				"vertebrae"
			},
			{
				"codex",
				"codices"
			},
			{
				"murex",
				"murices"
			},
			{
				"silex",
				"silices"
			},
			{
				"aphelion",
				"aphelia"
			},
			{
				"hyperbaton",
				"hyperbata"
			},
			{
				"perihelion",
				"perihelia"
			},
			{
				"asyndeton",
				"asyndeta"
			},
			{
				"noumenon",
				"noumena"
			},
			{
				"phenomenon",
				"phenomena"
			},
			{
				"criterion",
				"criteria"
			},
			{
				"organon",
				"organa"
			},
			{
				"prolegomenon",
				"prolegomena"
			},
			{
				"agendum",
				"agenda"
			},
			{
				"datum",
				"data"
			},
			{
				"extremum",
				"extrema"
			},
			{
				"bacterium",
				"bacteria"
			},
			{
				"desideratum",
				"desiderata"
			},
			{
				"stratum",
				"strata"
			},
			{
				"candelabrum",
				"candelabra"
			},
			{
				"erratum",
				"errata"
			},
			{
				"ovum",
				"ova"
			},
			{
				"forum",
				"fora"
			},
			{
				"addendum",
				"addenda"
			},
			{
				"stadium",
				"stadia"
			},
			{
				"automaton",
				"automata"
			},
			{
				"polyhedron",
				"polyhedra"
			}
		};

		// Token: 0x04000B62 RID: 2914
		private readonly global::System.Collections.Generic.Dictionary<string, string> _oSuffixList = new global::System.Collections.Generic.Dictionary<string, string>
		{
			{
				"albino",
				"albinos"
			},
			{
				"generalissimo",
				"generalissimos"
			},
			{
				"manifesto",
				"manifestos"
			},
			{
				"archipelago",
				"archipelagos"
			},
			{
				"ghetto",
				"ghettos"
			},
			{
				"medico",
				"medicos"
			},
			{
				"armadillo",
				"armadillos"
			},
			{
				"guano",
				"guanos"
			},
			{
				"octavo",
				"octavos"
			},
			{
				"commando",
				"commandos"
			},
			{
				"inferno",
				"infernos"
			},
			{
				"photo",
				"photos"
			},
			{
				"ditto",
				"dittos"
			},
			{
				"jumbo",
				"jumbos"
			},
			{
				"pro",
				"pros"
			},
			{
				"dynamo",
				"dynamos"
			},
			{
				"lingo",
				"lingos"
			},
			{
				"quarto",
				"quartos"
			},
			{
				"embryo",
				"embryos"
			},
			{
				"lumbago",
				"lumbagos"
			},
			{
				"rhino",
				"rhinos"
			},
			{
				"fiasco",
				"fiascos"
			},
			{
				"magneto",
				"magnetos"
			},
			{
				"stylo",
				"stylos"
			}
		};

		// Token: 0x04000B63 RID: 2915
		private readonly global::System.Collections.Generic.Dictionary<string, string> _classicalInflectionList = new global::System.Collections.Generic.Dictionary<string, string>
		{
			{
				"stamen",
				"stamina"
			},
			{
				"foramen",
				"foramina"
			},
			{
				"lumen",
				"lumina"
			},
			{
				"anathema",
				"anathemata"
			},
			{
				"enema",
				"enemata"
			},
			{
				"oedema",
				"oedemata"
			},
			{
				"bema",
				"bemata"
			},
			{
				"enigma",
				"enigmata"
			},
			{
				"sarcoma",
				"sarcomata"
			},
			{
				"carcinoma",
				"carcinomata"
			},
			{
				"gumma",
				"gummata"
			},
			{
				"schema",
				"schemata"
			},
			{
				"charisma",
				"charismata"
			},
			{
				"lemma",
				"lemmata"
			},
			{
				"soma",
				"somata"
			},
			{
				"diploma",
				"diplomata"
			},
			{
				"lymphoma",
				"lymphomata"
			},
			{
				"stigma",
				"stigmata"
			},
			{
				"dogma",
				"dogmata"
			},
			{
				"magma",
				"magmata"
			},
			{
				"stoma",
				"stomata"
			},
			{
				"drama",
				"dramata"
			},
			{
				"melisma",
				"melismata"
			},
			{
				"trauma",
				"traumata"
			},
			{
				"edema",
				"edemata"
			},
			{
				"miasma",
				"miasmata"
			},
			{
				"abscissa",
				"abscissae"
			},
			{
				"formula",
				"formulae"
			},
			{
				"medusa",
				"medusae"
			},
			{
				"amoeba",
				"amoebae"
			},
			{
				"hydra",
				"hydrae"
			},
			{
				"nebula",
				"nebulae"
			},
			{
				"antenna",
				"antennae"
			},
			{
				"hyperbola",
				"hyperbolae"
			},
			{
				"nova",
				"novae"
			},
			{
				"aurora",
				"aurorae"
			},
			{
				"lacuna",
				"lacunae"
			},
			{
				"parabola",
				"parabolae"
			},
			{
				"apex",
				"apices"
			},
			{
				"latex",
				"latices"
			},
			{
				"vertex",
				"vertices"
			},
			{
				"cortex",
				"cortices"
			},
			{
				"pontifex",
				"pontifices"
			},
			{
				"vortex",
				"vortices"
			},
			{
				"index",
				"indices"
			},
			{
				"simplex",
				"simplices"
			},
			{
				"iris",
				"irides"
			},
			{
				"clitoris",
				"clitorides"
			},
			{
				"alto",
				"alti"
			},
			{
				"contralto",
				"contralti"
			},
			{
				"soprano",
				"soprani"
			},
			{
				"basso",
				"bassi"
			},
			{
				"crescendo",
				"crescendi"
			},
			{
				"tempo",
				"tempi"
			},
			{
				"canto",
				"canti"
			},
			{
				"solo",
				"soli"
			},
			{
				"aquarium",
				"aquaria"
			},
			{
				"interregnum",
				"interregna"
			},
			{
				"quantum",
				"quanta"
			},
			{
				"compendium",
				"compendia"
			},
			{
				"lustrum",
				"lustra"
			},
			{
				"rostrum",
				"rostra"
			},
			{
				"consortium",
				"consortia"
			},
			{
				"maximum",
				"maxima"
			},
			{
				"spectrum",
				"spectra"
			},
			{
				"cranium",
				"crania"
			},
			{
				"medium",
				"media"
			},
			{
				"speculum",
				"specula"
			},
			{
				"curriculum",
				"curricula"
			},
			{
				"memorandum",
				"memoranda"
			},
			{
				"stadium",
				"stadia"
			},
			{
				"dictum",
				"dicta"
			},
			{
				"millenium",
				"millenia"
			},
			{
				"trapezium",
				"trapezia"
			},
			{
				"emporium",
				"emporia"
			},
			{
				"minimum",
				"minima"
			},
			{
				"ultimatum",
				"ultimata"
			},
			{
				"enconium",
				"enconia"
			},
			{
				"momentum",
				"momenta"
			},
			{
				"vacuum",
				"vacua"
			},
			{
				"gymnasium",
				"gymnasia"
			},
			{
				"optimum",
				"optima"
			},
			{
				"velum",
				"vela"
			},
			{
				"honorarium",
				"honoraria"
			},
			{
				"phylum",
				"phyla"
			},
			{
				"focus",
				"foci"
			},
			{
				"nimbus",
				"nimbi"
			},
			{
				"succubus",
				"succubi"
			},
			{
				"fungus",
				"fungi"
			},
			{
				"nucleolus",
				"nucleoli"
			},
			{
				"torus",
				"tori"
			},
			{
				"genius",
				"genii"
			},
			{
				"radius",
				"radii"
			},
			{
				"umbilicus",
				"umbilici"
			},
			{
				"incubus",
				"incubi"
			},
			{
				"stylus",
				"styli"
			},
			{
				"uterus",
				"uteri"
			},
			{
				"stimulus",
				"stimuli"
			},
			{
				"apparatus",
				"apparatus"
			},
			{
				"impetus",
				"impetus"
			},
			{
				"prospectus",
				"prospectus"
			},
			{
				"cantus",
				"cantus"
			},
			{
				"nexus",
				"nexus"
			},
			{
				"sinus",
				"sinus"
			},
			{
				"coitus",
				"coitus"
			},
			{
				"plexus",
				"plexus"
			},
			{
				"status",
				"status"
			},
			{
				"hiatus",
				"hiatus"
			},
			{
				"afreet",
				"afreeti"
			},
			{
				"afrit",
				"afriti"
			},
			{
				"efreet",
				"efreeti"
			},
			{
				"cherub",
				"cherubim"
			},
			{
				"goy",
				"goyim"
			},
			{
				"seraph",
				"seraphim"
			},
			{
				"alumnus",
				"alumni"
			}
		};

		// Token: 0x04000B64 RID: 2916
		private readonly global::System.Collections.Generic.List<string> _knownConflictingPluralList = new global::System.Collections.Generic.List<string>
		{
			"they",
			"them",
			"their",
			"have",
			"were",
			"yourself",
			"are"
		};

		// Token: 0x04000B65 RID: 2917
		private readonly global::System.Collections.Generic.Dictionary<string, string> _wordsEndingWithSeList = new global::System.Collections.Generic.Dictionary<string, string>
		{
			{
				"house",
				"houses"
			},
			{
				"case",
				"cases"
			},
			{
				"enterprise",
				"enterprises"
			},
			{
				"purchase",
				"purchases"
			},
			{
				"surprise",
				"surprises"
			},
			{
				"release",
				"releases"
			},
			{
				"disease",
				"diseases"
			},
			{
				"promise",
				"promises"
			},
			{
				"refuse",
				"refuses"
			},
			{
				"whose",
				"whoses"
			},
			{
				"phase",
				"phases"
			},
			{
				"noise",
				"noises"
			},
			{
				"nurse",
				"nurses"
			},
			{
				"rose",
				"roses"
			},
			{
				"franchise",
				"franchises"
			},
			{
				"supervise",
				"supervises"
			},
			{
				"farmhouse",
				"farmhouses"
			},
			{
				"suitcase",
				"suitcases"
			},
			{
				"recourse",
				"recourses"
			},
			{
				"impulse",
				"impulses"
			},
			{
				"license",
				"licenses"
			},
			{
				"diocese",
				"dioceses"
			},
			{
				"excise",
				"excises"
			},
			{
				"demise",
				"demises"
			},
			{
				"blouse",
				"blouses"
			},
			{
				"bruise",
				"bruises"
			},
			{
				"misuse",
				"misuses"
			},
			{
				"curse",
				"curses"
			},
			{
				"prose",
				"proses"
			},
			{
				"purse",
				"purses"
			},
			{
				"goose",
				"gooses"
			},
			{
				"tease",
				"teases"
			},
			{
				"poise",
				"poises"
			},
			{
				"vase",
				"vases"
			},
			{
				"fuse",
				"fuses"
			},
			{
				"muse",
				"muses"
			},
			{
				"slaughterhouse",
				"slaughterhouses"
			},
			{
				"clearinghouse",
				"clearinghouses"
			},
			{
				"endonuclease",
				"endonucleases"
			},
			{
				"steeplechase",
				"steeplechases"
			},
			{
				"metamorphose",
				"metamorphoses"
			},
			{
				"intercourse",
				"intercourses"
			},
			{
				"commonsense",
				"commonsenses"
			},
			{
				"intersperse",
				"intersperses"
			},
			{
				"merchandise",
				"merchandises"
			},
			{
				"phosphatase",
				"phosphatases"
			},
			{
				"summerhouse",
				"summerhouses"
			},
			{
				"watercourse",
				"watercourses"
			},
			{
				"catchphrase",
				"catchphrases"
			},
			{
				"compromise",
				"compromises"
			},
			{
				"greenhouse",
				"greenhouses"
			},
			{
				"lighthouse",
				"lighthouses"
			},
			{
				"paraphrase",
				"paraphrases"
			},
			{
				"mayonnaise",
				"mayonnaises"
			},
			{
				"racecourse",
				"racecourses"
			},
			{
				"apocalypse",
				"apocalypses"
			},
			{
				"courthouse",
				"courthouses"
			},
			{
				"powerhouse",
				"powerhouses"
			},
			{
				"storehouse",
				"storehouses"
			},
			{
				"glasshouse",
				"glasshouses"
			},
			{
				"hypotenuse",
				"hypotenuses"
			},
			{
				"peroxidase",
				"peroxidases"
			},
			{
				"pillowcase",
				"pillowcases"
			},
			{
				"roundhouse",
				"roundhouses"
			},
			{
				"streetwise",
				"streetwises"
			},
			{
				"expertise",
				"expertises"
			},
			{
				"discourse",
				"discourses"
			},
			{
				"warehouse",
				"warehouses"
			},
			{
				"staircase",
				"staircases"
			},
			{
				"workhouse",
				"workhouses"
			},
			{
				"briefcase",
				"briefcases"
			},
			{
				"clubhouse",
				"clubhouses"
			},
			{
				"clockwise",
				"clockwises"
			},
			{
				"concourse",
				"concourses"
			},
			{
				"playhouse",
				"playhouses"
			},
			{
				"turquoise",
				"turquoises"
			},
			{
				"boathouse",
				"boathouses"
			},
			{
				"cellulose",
				"celluloses"
			},
			{
				"epitomise",
				"epitomises"
			},
			{
				"gatehouse",
				"gatehouses"
			},
			{
				"grandiose",
				"grandioses"
			},
			{
				"menopause",
				"menopauses"
			},
			{
				"penthouse",
				"penthouses"
			},
			{
				"racehorse",
				"racehorses"
			},
			{
				"transpose",
				"transposes"
			},
			{
				"almshouse",
				"almshouses"
			},
			{
				"customise",
				"customises"
			},
			{
				"footloose",
				"footlooses"
			},
			{
				"galvanise",
				"galvanises"
			},
			{
				"princesse",
				"princesses"
			},
			{
				"universe",
				"universes"
			},
			{
				"workhorse",
				"workhorses"
			}
		};

		// Token: 0x04000B66 RID: 2918
		private readonly global::System.Collections.Generic.Dictionary<string, string> _wordsEndingWithSisList = new global::System.Collections.Generic.Dictionary<string, string>
		{
			{
				"analysis",
				"analyses"
			},
			{
				"crisis",
				"crises"
			},
			{
				"basis",
				"bases"
			},
			{
				"atherosclerosis",
				"atheroscleroses"
			},
			{
				"electrophoresis",
				"electrophoreses"
			},
			{
				"psychoanalysis",
				"psychoanalyses"
			},
			{
				"photosynthesis",
				"photosyntheses"
			},
			{
				"amniocentesis",
				"amniocenteses"
			},
			{
				"metamorphosis",
				"metamorphoses"
			},
			{
				"toxoplasmosis",
				"toxoplasmoses"
			},
			{
				"endometriosis",
				"endometrioses"
			},
			{
				"tuberculosis",
				"tuberculoses"
			},
			{
				"pathogenesis",
				"pathogeneses"
			},
			{
				"osteoporosis",
				"osteoporoses"
			},
			{
				"parenthesis",
				"parentheses"
			},
			{
				"anastomosis",
				"anastomoses"
			},
			{
				"peristalsis",
				"peristalses"
			},
			{
				"hypothesis",
				"hypotheses"
			},
			{
				"antithesis",
				"antitheses"
			},
			{
				"apotheosis",
				"apotheoses"
			},
			{
				"thrombosis",
				"thromboses"
			},
			{
				"diagnosis",
				"diagnoses"
			},
			{
				"synthesis",
				"syntheses"
			},
			{
				"paralysis",
				"paralyses"
			},
			{
				"prognosis",
				"prognoses"
			},
			{
				"cirrhosis",
				"cirrhoses"
			},
			{
				"sclerosis",
				"scleroses"
			},
			{
				"psychosis",
				"psychoses"
			},
			{
				"apoptosis",
				"apoptoses"
			},
			{
				"symbiosis",
				"symbioses"
			}
		};
	}
}
