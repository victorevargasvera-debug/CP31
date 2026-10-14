using System;
using System.Collections;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000083 RID: 131
	public sealed class CharacterSet : global::Infragistics.Windows.Editors.InputCharBase
	{
		// Token: 0x060007DC RID: 2012 RVA: 0x00021A28 File Offset: 0x0001FC28
		internal CharacterSet()
		{
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00021A30 File Offset: 0x0001FC30
		internal CharacterSet(global::Infragistics.Windows.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00021A39 File Offset: 0x0001FC39
		internal void InitializeSet(global::Infragistics.Windows.Editors.CharacterSet.ICharSet set)
		{
			this._set = set;
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00021A44 File Offset: 0x0001FC44
		internal static global::Infragistics.Windows.Editors.CharacterSet.ICharSet ParseSet(string str)
		{
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			char[] array = new char[str.Length];
			int num = 0;
			char start = '\0';
			bool flag = false;
			for (int i = 0; i < str.Length; i++)
			{
				char c = str[i];
				if ('\\' == c && !flag)
				{
					flag = true;
				}
				else
				{
					if ('-' == c && i > 0 && 1 + i < str.Length && !flag)
					{
						num--;
						i++;
						if (str[i] == '\\' && 1 + i < str.Length)
						{
							i++;
						}
						arrayList.Add(new global::Infragistics.Windows.Editors.CharacterSet.RangeSet(start, str[i]));
					}
					else
					{
						flag = false;
						array[num++] = c;
					}
					start = c;
				}
			}
			if (num > 0 && num < array.Length)
			{
				char[] array2 = new char[num];
				global::System.Array.Copy(array, array2, num);
				array = array2;
			}
			if (array.Length > 0)
			{
				arrayList.Add(new global::Infragistics.Windows.Editors.CharacterSet.CharSet(array));
			}
			if (1 == arrayList.Count)
			{
				return (global::Infragistics.Windows.Editors.CharacterSet.ICharSet)arrayList[0];
			}
			if (arrayList.Count > 0)
			{
				return new global::Infragistics.Windows.Editors.CharacterSet.AggregateSet((global::Infragistics.Windows.Editors.CharacterSet.ICharSet[])arrayList.ToArray(typeof(global::Infragistics.Windows.Editors.CharacterSet.ICharSet)));
			}
			return null;
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00021B74 File Offset: 0x0001FD74
		public override bool MatchChar(char c)
		{
			char c2 = this.Filter(c);
			return this._set.Contains(c2);
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00021B98 File Offset: 0x0001FD98
		internal override global::Infragistics.Windows.Editors.DisplayCharBase InternalClone(global::Infragistics.Windows.Editors.SectionBase section)
		{
			global::Infragistics.Windows.Editors.CharacterSet characterSet = new global::Infragistics.Windows.Editors.CharacterSet(section);
			this.InternalCopy(characterSet);
			characterSet._set = this._set;
			return characterSet;
		}

		// Token: 0x040002CC RID: 716
		private global::Infragistics.Windows.Editors.CharacterSet.ICharSet _set;

		// Token: 0x02000084 RID: 132
		internal interface ICharSet
		{
			// Token: 0x060007E2 RID: 2018
			bool Contains(char c);
		}

		// Token: 0x02000085 RID: 133
		internal class RangeSet : global::Infragistics.Windows.Editors.CharacterSet.ICharSet
		{
			// Token: 0x060007E3 RID: 2019 RVA: 0x00021BC0 File Offset: 0x0001FDC0
			public RangeSet(char start, char end)
			{
				if (start > end)
				{
					char c = start;
					start = end;
					end = c;
				}
				this._start = start;
				this._end = end;
			}

			// Token: 0x060007E4 RID: 2020 RVA: 0x00021BED File Offset: 0x0001FDED
			public bool Contains(char c)
			{
				return c >= this._start && c <= this._end;
			}

			// Token: 0x040002CD RID: 717
			private char _start;

			// Token: 0x040002CE RID: 718
			private char _end;
		}

		// Token: 0x02000086 RID: 134
		internal class CharSet : global::Infragistics.Windows.Editors.CharacterSet.ICharSet
		{
			// Token: 0x060007E5 RID: 2021 RVA: 0x00021C06 File Offset: 0x0001FE06
			public CharSet(char[] set)
			{
				this._set = set;
			}

			// Token: 0x060007E6 RID: 2022 RVA: 0x00021C15 File Offset: 0x0001FE15
			public bool Contains(char c)
			{
				return global::System.Array.IndexOf<char>(this._set, c) >= 0;
			}

			// Token: 0x040002CF RID: 719
			private char[] _set;
		}

		// Token: 0x02000087 RID: 135
		internal class AggregateSet : global::Infragistics.Windows.Editors.CharacterSet.ICharSet
		{
			// Token: 0x060007E7 RID: 2023 RVA: 0x00021C29 File Offset: 0x0001FE29
			public AggregateSet(global::Infragistics.Windows.Editors.CharacterSet.ICharSet[] sets)
			{
				this._sets = sets;
			}

			// Token: 0x060007E8 RID: 2024 RVA: 0x00021C38 File Offset: 0x0001FE38
			public bool Contains(char c)
			{
				for (int i = 0; i < this._sets.Length; i++)
				{
					if (this._sets[i].Contains(c))
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x040002D0 RID: 720
			private global::Infragistics.Windows.Editors.CharacterSet.ICharSet[] _sets;
		}
	}
}
