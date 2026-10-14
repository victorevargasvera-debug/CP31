using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000A3 RID: 163
	public abstract class EditSectionBase : global::Infragistics.Windows.Editors.SectionBase
	{
		// Token: 0x060008DA RID: 2266 RVA: 0x000292FA File Offset: 0x000274FA
		internal EditSectionBase()
		{
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00029302 File Offset: 0x00027502
		protected global::Infragistics.Windows.Editors.DisplayCharBase SafeDisplayCharAt(int index)
		{
			if (index >= 0 && index < base.DisplayChars.Count)
			{
				return base.DisplayChars[index];
			}
			return null;
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00029324 File Offset: 0x00027524
		private bool CanShift(int from, int positionsToShift, bool left)
		{
			int count = base.DisplayChars.Count;
			if (from < 0 || from >= count)
			{
				return false;
			}
			if (positionsToShift < 0)
			{
				return false;
			}
			if (from + positionsToShift > count)
			{
				return false;
			}
			bool result = true;
			if (left)
			{
				for (int i = from; i < base.DisplayChars.Count; i++)
				{
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = this.SafeDisplayCharAt(i);
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase2 = this.SafeDisplayCharAt(i + positionsToShift);
					if (displayCharBase == null || displayCharBase.IsEditable)
					{
						if (displayCharBase2 != null && !displayCharBase2.IsEditable)
						{
							int num = positionsToShift + 1;
							while (displayCharBase2 != null && !displayCharBase2.IsEditable)
							{
								displayCharBase2 = this.SafeDisplayCharAt(i + num);
								num++;
							}
						}
						char c = '\0';
						if (displayCharBase2 != null)
						{
							c = displayCharBase2.Char;
						}
						if ((displayCharBase == null || (c != '\0' && !displayCharBase.MatchChar(c))) && c != '\0')
						{
							result = false;
							break;
						}
					}
				}
			}
			else
			{
				for (int j = base.DisplayChars.Count - 1; j >= from; j--)
				{
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase3 = this.SafeDisplayCharAt(j);
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase4 = null;
					if (j - positionsToShift >= from)
					{
						displayCharBase4 = this.SafeDisplayCharAt(j - positionsToShift);
					}
					if (displayCharBase3 == null || displayCharBase3.IsEditable)
					{
						if (displayCharBase4 != null && !displayCharBase4.IsEditable)
						{
							int num2 = positionsToShift + 1;
							while (displayCharBase4 != null && !displayCharBase4.IsEditable)
							{
								displayCharBase4 = this.SafeDisplayCharAt(j - num2);
								num2++;
							}
						}
						char c2 = '\0';
						if (displayCharBase4 != null)
						{
							c2 = displayCharBase4.Char;
						}
						if ((displayCharBase3 == null || (c2 != '\0' && !displayCharBase3.MatchChar(c2))) && c2 != '\0')
						{
							result = false;
							break;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x000294AC File Offset: 0x000276AC
		private bool Shift(int from, int positionsToShift, bool left)
		{
			if (!this.CanShift(from, positionsToShift, left))
			{
				return false;
			}
			int count = base.DisplayChars.Count;
			if (from < 0 || from >= count)
			{
				return false;
			}
			if (positionsToShift < 0)
			{
				return false;
			}
			if (from + positionsToShift > count)
			{
				return false;
			}
			bool result = true;
			if (left)
			{
				for (int i = from; i < base.DisplayChars.Count; i++)
				{
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = this.SafeDisplayCharAt(i);
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase2 = this.SafeDisplayCharAt(i + positionsToShift);
					if (displayCharBase == null || displayCharBase.IsEditable)
					{
						if (displayCharBase2 != null && !displayCharBase2.IsEditable)
						{
							int num = positionsToShift + 1;
							while (displayCharBase2 != null && !displayCharBase2.IsEditable)
							{
								displayCharBase2 = this.SafeDisplayCharAt(i + num);
								num++;
							}
						}
						char c = '\0';
						if (displayCharBase2 != null)
						{
							c = displayCharBase2.Char;
						}
						if (displayCharBase != null && (c == '\0' || displayCharBase.MatchChar(c)))
						{
							displayCharBase.Char = c;
						}
						else
						{
							result = false;
						}
					}
				}
			}
			else
			{
				for (int j = base.DisplayChars.Count - 1; j >= from; j--)
				{
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase3 = this.SafeDisplayCharAt(j);
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase4 = null;
					if (j - positionsToShift >= from)
					{
						displayCharBase4 = this.SafeDisplayCharAt(j - positionsToShift);
					}
					if (displayCharBase3 == null || displayCharBase3.IsEditable)
					{
						if (displayCharBase4 != null && !displayCharBase4.IsEditable)
						{
							int num2 = positionsToShift + 1;
							while (displayCharBase4 != null && !displayCharBase4.IsEditable)
							{
								displayCharBase4 = this.SafeDisplayCharAt(j - num2);
								num2++;
							}
						}
						char c2 = '\0';
						if (displayCharBase4 != null)
						{
							c2 = displayCharBase4.Char;
						}
						if (displayCharBase3 != null && (c2 == '\0' || displayCharBase3.MatchChar(c2)))
						{
							displayCharBase3.Char = c2;
						}
						else
						{
							result = false;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00029648 File Offset: 0x00027848
		internal bool IsInt(string str)
		{
			if (str.Length == 0)
			{
				return false;
			}
			int i = 0;
			if (base.PlusSignChar == str[i] || base.MinusSignChar == str[i])
			{
				i++;
			}
			while (i < str.Length)
			{
				if (!char.IsDigit(str, i))
				{
					return false;
				}
				i++;
			}
			return true;
		}

		// Token: 0x060008DF RID: 2271
		public abstract void SetText(string text);

		// Token: 0x060008E0 RID: 2272 RVA: 0x000296A0 File Offset: 0x000278A0
		internal virtual bool IsInputFull()
		{
			for (int i = 0; i < base.DisplayChars.Count; i++)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = base.DisplayChars[i];
				if (displayCharBase.IsEditable && displayCharBase.IsEmpty)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x000296E3 File Offset: 0x000278E3
		internal virtual bool CanShiftRight(int from, int positionsToShift)
		{
			return this.CanShift(from, positionsToShift, false);
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x000296EE File Offset: 0x000278EE
		internal virtual bool CanShiftLeft(int from, int positionsToShift)
		{
			return this.CanShift(from, positionsToShift, true);
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x000296F9 File Offset: 0x000278F9
		internal virtual bool ShiftLeft(int from, int positionsToShift)
		{
			return this.Shift(from, positionsToShift, true);
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00029704 File Offset: 0x00027904
		internal virtual bool ShiftRight(int from, int positionsToShift)
		{
			return this.Shift(from, positionsToShift, false);
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0002970F File Offset: 0x0002790F
		internal virtual bool DeleteCharWithNoShift(int pos)
		{
			if (pos < 0 || pos >= base.DisplayChars.Count)
			{
				return false;
			}
			base.DisplayChars[pos].Char = '\0';
			return true;
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00029738 File Offset: 0x00027938
		internal virtual bool DeleteCharsAndShift(int pos, int count)
		{
			if (pos < 0 || pos >= base.DisplayChars.Count)
			{
				return false;
			}
			if (this.CanShiftLeft(pos, count))
			{
				this.ShiftLeft(pos, count);
				return true;
			}
			return false;
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00029764 File Offset: 0x00027964
		internal virtual bool DeleteCharAndShift(int pos)
		{
			if (pos < 0 || pos >= base.DisplayChars.Count)
			{
				return false;
			}
			if (this.CanShiftLeft(pos, 1))
			{
				this.ShiftLeft(pos, 1);
				return true;
			}
			return false;
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00029790 File Offset: 0x00027990
		internal virtual bool ReplaceCharAt(int pos, char c)
		{
			if (pos < 0 || pos > base.DisplayChars.Count)
			{
				return false;
			}
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = base.DisplayChars[pos];
			if (displayCharBase == null)
			{
				return false;
			}
			if (!displayCharBase.IsEditable)
			{
				return false;
			}
			if (!displayCharBase.MatchChar(c))
			{
				return false;
			}
			displayCharBase.Char = c;
			return true;
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x000297E0 File Offset: 0x000279E0
		internal virtual bool CanInsertCharAt(int pos, char c)
		{
			if (pos < 0 || pos > base.DisplayChars.Count)
			{
				return false;
			}
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = base.DisplayChars[pos];
			return displayCharBase != null && displayCharBase.IsEditable && displayCharBase.MatchChar(c) && base.LastDisplayChar.IsEmpty && this.CanShiftRight(pos, 1);
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00029844 File Offset: 0x00027A44
		internal virtual bool InsertCharAt(int pos, char c)
		{
			if (this.CanInsertCharAt(pos, c))
			{
				this.Shift(pos, 1, false);
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = this.SafeDisplayCharAt(pos);
				displayCharBase.Char = c;
				return true;
			}
			return false;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00029878 File Offset: 0x00027A78
		internal virtual void EraseChars(int startIndex, int endIndex)
		{
			if (startIndex > endIndex)
			{
				int num = startIndex;
				startIndex = endIndex;
				endIndex = num;
			}
			global::Infragistics.Windows.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
			int count = displayChars.Count;
			for (int i = startIndex; i <= endIndex; i++)
			{
				if (i < count)
				{
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = displayChars[i];
					if (displayCharBase.IsEditable)
					{
						displayCharBase.Char = '\0';
					}
				}
			}
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x000298C9 File Offset: 0x00027AC9
		internal void EraseAllChars()
		{
			this.EraseChars(0, base.DisplayChars.Count - 1);
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x000298E0 File Offset: 0x00027AE0
		internal virtual global::Infragistics.Windows.Editors.DisplayCharBase FirstFilledChar
		{
			get
			{
				global::Infragistics.Windows.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
				int count = displayChars.Count;
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = displayChars[i];
					if (displayCharBase.IsEditable && displayCharBase.Char != '\0')
					{
						return displayCharBase;
					}
				}
				return null;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x00029922 File Offset: 0x00027B22
		internal virtual bool IsEmpty
		{
			get
			{
				return null == this.FirstFilledChar;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x00029930 File Offset: 0x00027B30
		internal virtual global::Infragistics.Windows.Editors.DisplayCharBase LastFilledChar
		{
			get
			{
				for (int i = base.DisplayChars.Count - 1; i >= 0; i--)
				{
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = base.DisplayChars[i];
					if (displayCharBase.IsEditable && displayCharBase.Char != '\0')
					{
						return displayCharBase;
					}
				}
				return null;
			}
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00029975 File Offset: 0x00027B75
		public bool ValidateSection()
		{
			return this.ValidateSection(true);
		}

		// Token: 0x060008F1 RID: 2289
		public abstract bool ValidateSection(bool contentModificationsAllowed);

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060008F2 RID: 2290
		public abstract global::Infragistics.Windows.Editors.EditOrientation Orientation { get; }

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x0002997E File Offset: 0x00027B7E
		internal virtual bool SupportsSpinning
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00029981 File Offset: 0x00027B81
		internal virtual bool CanSpin(bool up)
		{
			return false;
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00029984 File Offset: 0x00027B84
		internal virtual bool Spin(bool up, bool setLimit)
		{
			return false;
		}
	}
}
