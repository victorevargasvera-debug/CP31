using System;
using System.Collections;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200007D RID: 125
	public sealed class CharacterSet : global::Infragistics.Windows.Editors.InputCharBase
	{
		// Token: 0x0600077B RID: 1915 RVA: 0x00020000 File Offset: 0x0001E200
		internal CharacterSet()
		{
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00020008 File Offset: 0x0001E208
		internal CharacterSet(global::Infragistics.Windows.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00020011 File Offset: 0x0001E211
		internal void InitializeSet(global::Infragistics.Windows.Editors.CharacterSet.ICharSet set)
		{
			this._set = set;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0002001C File Offset: 0x0001E21C
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

		// Token: 0x0600077F RID: 1919 RVA: 0x0002014C File Offset: 0x0001E34C
		public override bool MatchChar(char c)
		{
			char c2 = base.Filter(c);
			return this._set.Contains(c2);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00020170 File Offset: 0x0001E370
		internal override global::Infragistics.Windows.Editors.DisplayCharBase InternalClone(global::Infragistics.Windows.Editors.SectionBase section)
		{
			global::Infragistics.Windows.Editors.CharacterSet characterSet = new global::Infragistics.Windows.Editors.CharacterSet(section);
			this.InternalCopy(characterSet);
			characterSet._set = this._set;
			return characterSet;
		}

		// Token: 0x04000299 RID: 665
		private global::Infragistics.Windows.Editors.CharacterSet.ICharSet _set;

		// Token: 0x0200007E RID: 126
		internal interface ICharSet
		{
			// Token: 0x06000781 RID: 1921
			bool Contains(char c);
		}

		// Token: 0x0200007F RID: 127
		internal class RangeSet : global::Infragistics.Windows.Editors.CharacterSet.ICharSet
		{
			// Token: 0x06000782 RID: 1922 RVA: 0x00020198 File Offset: 0x0001E398
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

			// Token: 0x06000783 RID: 1923 RVA: 0x000201C5 File Offset: 0x0001E3C5
			public bool Contains(char c)
			{
				return c >= this._start && c <= this._end;
			}

			// Token: 0x0400029A RID: 666
			private char _start;

			// Token: 0x0400029B RID: 667
			private char _end;
		}

		// Token: 0x02000080 RID: 128
		internal class CharSet : global::Infragistics.Windows.Editors.CharacterSet.ICharSet
		{
			// Token: 0x06000784 RID: 1924 RVA: 0x000201DE File Offset: 0x0001E3DE
			public CharSet(char[] set)
			{
				this._set = set;
			}

			// Token: 0x06000785 RID: 1925 RVA: 0x000201ED File Offset: 0x0001E3ED
			public bool Contains(char c)
			{
				return global::System.Array.IndexOf<char>(this._set, c) >= 0;
			}

			// Token: 0x0400029C RID: 668
			private char[] _set;
		}

		// Token: 0x02000081 RID: 129
		internal class AggregateSet : global::Infragistics.Windows.Editors.CharacterSet.ICharSet
		{
			// Token: 0x06000786 RID: 1926 RVA: 0x00020201 File Offset: 0x0001E401
			public AggregateSet(global::Infragistics.Windows.Editors.CharacterSet.ICharSet[] sets)
			{
				this._sets = sets;
			}

			// Token: 0x06000787 RID: 1927 RVA: 0x00020210 File Offset: 0x0001E410
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

			// Token: 0x0400029D RID: 669
			private global::Infragistics.Windows.Editors.CharacterSet.ICharSet[] _sets;
		}
	}
}
