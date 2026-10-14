using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000036 RID: 54
	public abstract class EditSectionBase : global::Infragistics.Controls.Editors.SectionBase
	{
		// Token: 0x060001BD RID: 445 RVA: 0x0000C41A File Offset: 0x0000A61A
		internal EditSectionBase()
		{
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000C422 File Offset: 0x0000A622
		protected global::Infragistics.Controls.Editors.DisplayCharBase SafeDisplayCharAt(int index)
		{
			if (index >= 0 && index < base.DisplayChars.Count)
			{
				return base.DisplayChars[index];
			}
			return null;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000C444 File Offset: 0x0000A644
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
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = this.SafeDisplayCharAt(i);
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase2 = this.SafeDisplayCharAt(i + positionsToShift);
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
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase3 = this.SafeDisplayCharAt(j);
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase4 = null;
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

		// Token: 0x060001C0 RID: 448 RVA: 0x0000C5CC File Offset: 0x0000A7CC
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
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = this.SafeDisplayCharAt(i);
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase2 = this.SafeDisplayCharAt(i + positionsToShift);
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
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase3 = this.SafeDisplayCharAt(j);
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase4 = null;
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

		// Token: 0x060001C1 RID: 449 RVA: 0x0000C768 File Offset: 0x0000A968
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

		// Token: 0x060001C2 RID: 450
		public abstract void SetText(string text);

		// Token: 0x060001C3 RID: 451 RVA: 0x0000C7C0 File Offset: 0x0000A9C0
		internal virtual bool IsInputFull()
		{
			for (int i = 0; i < base.DisplayChars.Count; i++)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = base.DisplayChars[i];
				if (displayCharBase.IsEditable && displayCharBase.IsEmpty)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000C803 File Offset: 0x0000AA03
		internal virtual bool CanShiftRight(int from, int positionsToShift)
		{
			return this.CanShift(from, positionsToShift, false);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000C80E File Offset: 0x0000AA0E
		internal virtual bool CanShiftLeft(int from, int positionsToShift)
		{
			return this.CanShift(from, positionsToShift, true);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000C819 File Offset: 0x0000AA19
		internal virtual bool ShiftLeft(int from, int positionsToShift)
		{
			return this.Shift(from, positionsToShift, true);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000C824 File Offset: 0x0000AA24
		internal virtual bool ShiftRight(int from, int positionsToShift)
		{
			return this.Shift(from, positionsToShift, false);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000C82F File Offset: 0x0000AA2F
		internal virtual bool DeleteCharWithNoShift(int pos)
		{
			if (pos < 0 || pos >= base.DisplayChars.Count)
			{
				return false;
			}
			base.DisplayChars[pos].Char = '\0';
			return true;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000C858 File Offset: 0x0000AA58
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

		// Token: 0x060001CA RID: 458 RVA: 0x0000C884 File Offset: 0x0000AA84
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

		// Token: 0x060001CB RID: 459 RVA: 0x0000C8B0 File Offset: 0x0000AAB0
		internal virtual bool ReplaceCharAt(int pos, char c)
		{
			if (pos < 0 || pos > base.DisplayChars.Count)
			{
				return false;
			}
			global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = base.DisplayChars[pos];
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

		// Token: 0x060001CC RID: 460 RVA: 0x0000C900 File Offset: 0x0000AB00
		internal virtual bool CanInsertCharAt(int pos, char c)
		{
			if (pos < 0 || pos > base.DisplayChars.Count)
			{
				return false;
			}
			global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = base.DisplayChars[pos];
			return displayCharBase != null && displayCharBase.IsEditable && displayCharBase.MatchChar(c) && base.LastDisplayChar.IsEmpty && this.CanShiftRight(pos, 1);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000C964 File Offset: 0x0000AB64
		internal virtual bool InsertCharAt(int pos, char c)
		{
			if (this.CanInsertCharAt(pos, c))
			{
				this.Shift(pos, 1, false);
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = this.SafeDisplayCharAt(pos);
				displayCharBase.Char = c;
				return true;
			}
			return false;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000C998 File Offset: 0x0000AB98
		internal virtual void EraseChars(int startIndex, int endIndex)
		{
			if (startIndex > endIndex)
			{
				int num = startIndex;
				startIndex = endIndex;
				endIndex = num;
			}
			global::Infragistics.Controls.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
			int count = displayChars.Count;
			for (int i = startIndex; i <= endIndex; i++)
			{
				if (i < count)
				{
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = displayChars[i];
					if (displayCharBase.IsEditable)
					{
						displayCharBase.Char = '\0';
					}
				}
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000C9E9 File Offset: 0x0000ABE9
		internal void EraseAllChars()
		{
			this.EraseChars(0, base.DisplayChars.Count - 1);
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000CA00 File Offset: 0x0000AC00
		internal virtual global::Infragistics.Controls.Editors.DisplayCharBase FirstFilledChar
		{
			get
			{
				global::Infragistics.Controls.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
				int count = displayChars.Count;
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = displayChars[i];
					if (displayCharBase.IsEditable && displayCharBase.Char != '\0')
					{
						return displayCharBase;
					}
				}
				return null;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0000CA42 File Offset: 0x0000AC42
		internal virtual bool IsEmpty
		{
			get
			{
				return null == this.FirstFilledChar;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x0000CA50 File Offset: 0x0000AC50
		internal virtual global::Infragistics.Controls.Editors.DisplayCharBase LastFilledChar
		{
			get
			{
				for (int i = base.DisplayChars.Count - 1; i >= 0; i--)
				{
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = base.DisplayChars[i];
					if (displayCharBase.IsEditable && displayCharBase.Char != '\0')
					{
						return displayCharBase;
					}
				}
				return null;
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000CA95 File Offset: 0x0000AC95
		public bool ValidateSection()
		{
			return this.ValidateSection(true);
		}

		// Token: 0x060001D4 RID: 468
		public abstract bool ValidateSection(bool contentModificationsAllowed);

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001D5 RID: 469
		public abstract global::Infragistics.Controls.Editors.EditOrientation Orientation { get; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000CA9E File Offset: 0x0000AC9E
		internal virtual bool SupportsSpinning
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000CAA1 File Offset: 0x0000ACA1
		internal virtual bool CanSpin(bool up)
		{
			return false;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000CAA4 File Offset: 0x0000ACA4
		internal virtual bool Spin(bool up, bool setLimit)
		{
			return false;
		}
	}
}
