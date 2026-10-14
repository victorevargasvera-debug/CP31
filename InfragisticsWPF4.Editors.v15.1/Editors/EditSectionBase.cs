using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000AA RID: 170
	public abstract class EditSectionBase : global::Infragistics.Windows.Editors.SectionBase
	{
		// Token: 0x06000948 RID: 2376 RVA: 0x0002B2E2 File Offset: 0x000294E2
		internal EditSectionBase()
		{
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0002B2EA File Offset: 0x000294EA
		protected global::Infragistics.Windows.Editors.DisplayCharBase SafeDisplayCharAt(int index)
		{
			if (index >= 0 && index < base.DisplayChars.Count)
			{
				return base.DisplayChars[index];
			}
			return null;
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0002B30C File Offset: 0x0002950C
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

		// Token: 0x0600094B RID: 2379 RVA: 0x0002B494 File Offset: 0x00029694
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

		// Token: 0x0600094C RID: 2380 RVA: 0x0002B630 File Offset: 0x00029830
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

		// Token: 0x0600094D RID: 2381
		public abstract void SetText(string text);

		// Token: 0x0600094E RID: 2382 RVA: 0x0002B688 File Offset: 0x00029888
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

		// Token: 0x0600094F RID: 2383 RVA: 0x0002B6CB File Offset: 0x000298CB
		internal virtual bool CanShiftRight(int from, int positionsToShift)
		{
			return this.CanShift(from, positionsToShift, false);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0002B6D6 File Offset: 0x000298D6
		internal virtual bool CanShiftLeft(int from, int positionsToShift)
		{
			return this.CanShift(from, positionsToShift, true);
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0002B6E1 File Offset: 0x000298E1
		internal virtual bool ShiftLeft(int from, int positionsToShift)
		{
			return this.Shift(from, positionsToShift, true);
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0002B6EC File Offset: 0x000298EC
		internal virtual bool ShiftRight(int from, int positionsToShift)
		{
			return this.Shift(from, positionsToShift, false);
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0002B6F7 File Offset: 0x000298F7
		internal virtual bool DeleteCharWithNoShift(int pos)
		{
			if (pos < 0 || pos >= base.DisplayChars.Count)
			{
				return false;
			}
			base.DisplayChars[pos].Char = '\0';
			return true;
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0002B720 File Offset: 0x00029920
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

		// Token: 0x06000955 RID: 2389 RVA: 0x0002B74C File Offset: 0x0002994C
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

		// Token: 0x06000956 RID: 2390 RVA: 0x0002B778 File Offset: 0x00029978
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

		// Token: 0x06000957 RID: 2391 RVA: 0x0002B7C8 File Offset: 0x000299C8
		internal virtual bool CanInsertCharAt(int pos, char c)
		{
			if (pos < 0 || pos > base.DisplayChars.Count)
			{
				return false;
			}
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = base.DisplayChars[pos];
			return displayCharBase != null && displayCharBase.IsEditable && displayCharBase.MatchChar(c) && base.LastDisplayChar.IsEmpty && this.CanShiftRight(pos, 1);
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0002B82C File Offset: 0x00029A2C
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

		// Token: 0x06000959 RID: 2393 RVA: 0x0002B860 File Offset: 0x00029A60
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

		// Token: 0x0600095A RID: 2394 RVA: 0x0002B8B1 File Offset: 0x00029AB1
		internal void EraseAllChars()
		{
			this.EraseChars(0, base.DisplayChars.Count - 1);
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x0002B8C8 File Offset: 0x00029AC8
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

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x0002B90A File Offset: 0x00029B0A
		internal virtual bool IsEmpty
		{
			get
			{
				return null == this.FirstFilledChar;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x0002B918 File Offset: 0x00029B18
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

		// Token: 0x0600095E RID: 2398 RVA: 0x0002B95D File Offset: 0x00029B5D
		public bool ValidateSection()
		{
			return this.ValidateSection(true);
		}

		// Token: 0x0600095F RID: 2399
		public abstract bool ValidateSection(bool contentModificationsAllowed);

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000960 RID: 2400
		public abstract global::Infragistics.Windows.Editors.EditOrientation Orientation { get; }

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x0002B966 File Offset: 0x00029B66
		internal virtual bool SupportsSpinning
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x0002B969 File Offset: 0x00029B69
		internal virtual bool CanSpin(bool up)
		{
			return false;
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0002B96C File Offset: 0x00029B6C
		internal virtual bool Spin(bool up, bool setLimit)
		{
			return false;
		}
	}
}
