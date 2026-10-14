using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000013 RID: 19
	public sealed class CharacterSet : global::Infragistics.Controls.Editors.InputCharBase
	{
		// Token: 0x0600006F RID: 111 RVA: 0x00003C80 File Offset: 0x00001E80
		internal CharacterSet()
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003C88 File Offset: 0x00001E88
		internal CharacterSet(global::Infragistics.Controls.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003C91 File Offset: 0x00001E91
		internal void InitializeSet(global::Infragistics.Controls.Editors.CharacterSet.ICharSet set)
		{
			this._set = set;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003C9C File Offset: 0x00001E9C
		internal static global::Infragistics.Controls.Editors.CharacterSet.ICharSet ParseSet(string str)
		{
			global::System.Collections.Generic.List<global::Infragistics.Controls.Editors.CharacterSet.ICharSet> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Editors.CharacterSet.ICharSet>();
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
						list.Add(new global::Infragistics.Controls.Editors.CharacterSet.RangeSet(start, str[i]));
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
				list.Add(new global::Infragistics.Controls.Editors.CharacterSet.CharSet(array));
			}
			if (1 == list.Count)
			{
				return list[0];
			}
			if (list.Count > 0)
			{
				return new global::Infragistics.Controls.Editors.CharacterSet.AggregateSet(list.ToArray());
			}
			return null;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003DB8 File Offset: 0x00001FB8
		public override bool MatchChar(char c)
		{
			char c2 = this.Filter(c);
			return this._set.Contains(c2);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003DDC File Offset: 0x00001FDC
		internal override global::Infragistics.Controls.Editors.DisplayCharBase InternalClone(global::Infragistics.Controls.Editors.SectionBase section)
		{
			global::Infragistics.Controls.Editors.CharacterSet characterSet = new global::Infragistics.Controls.Editors.CharacterSet(section);
			this.InternalCopy(characterSet);
			characterSet._set = this._set;
			return characterSet;
		}

		// Token: 0x0400004F RID: 79
		private global::Infragistics.Controls.Editors.CharacterSet.ICharSet _set;

		// Token: 0x02000014 RID: 20
		internal interface ICharSet
		{
			// Token: 0x06000075 RID: 117
			bool Contains(char c);
		}

		// Token: 0x02000015 RID: 21
		internal class RangeSet : global::Infragistics.Controls.Editors.CharacterSet.ICharSet
		{
			// Token: 0x06000076 RID: 118 RVA: 0x00003E04 File Offset: 0x00002004
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

			// Token: 0x06000077 RID: 119 RVA: 0x00003E31 File Offset: 0x00002031
			public bool Contains(char c)
			{
				return c >= this._start && c <= this._end;
			}

			// Token: 0x04000050 RID: 80
			private char _start;

			// Token: 0x04000051 RID: 81
			private char _end;
		}

		// Token: 0x02000016 RID: 22
		internal class CharSet : global::Infragistics.Controls.Editors.CharacterSet.ICharSet
		{
			// Token: 0x06000078 RID: 120 RVA: 0x00003E4A File Offset: 0x0000204A
			public CharSet(char[] set)
			{
				this._set = set;
			}

			// Token: 0x06000079 RID: 121 RVA: 0x00003E59 File Offset: 0x00002059
			public bool Contains(char c)
			{
				return global::System.Array.IndexOf<char>(this._set, c) >= 0;
			}

			// Token: 0x04000052 RID: 82
			private char[] _set;
		}

		// Token: 0x02000017 RID: 23
		internal class AggregateSet : global::Infragistics.Controls.Editors.CharacterSet.ICharSet
		{
			// Token: 0x0600007A RID: 122 RVA: 0x00003E6D File Offset: 0x0000206D
			public AggregateSet(global::Infragistics.Controls.Editors.CharacterSet.ICharSet[] sets)
			{
				this._sets = sets;
			}

			// Token: 0x0600007B RID: 123 RVA: 0x00003E7C File Offset: 0x0000207C
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

			// Token: 0x04000053 RID: 83
			private global::Infragistics.Controls.Editors.CharacterSet.ICharSet[] _sets;
		}
	}
}
