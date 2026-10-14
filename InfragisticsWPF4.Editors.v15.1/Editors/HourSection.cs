using System;
using System.Globalization;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000B0 RID: 176
	public sealed class HourSection : global::Infragistics.Windows.Editors.NumberSection
	{
		// Token: 0x060009BA RID: 2490 RVA: 0x0002D768 File Offset: 0x0002B968
		public HourSection() : base(2)
		{
			base.MinValue = 0m;
			base.MaxValue = 23m;
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0002D78C File Offset: 0x0002B98C
		public override bool ValidateString(ref string str)
		{
			str = global::Infragistics.Windows.Editors.NumberSection.StripOutPadPromptCharacters(str, this);
			int value = -1;
			try
			{
				if (!int.TryParse(str, global::System.Globalization.NumberStyles.None, global::System.Globalization.NumberFormatInfo.CurrentInfo, out value))
				{
					return false;
				}
			}
			catch (global::System.Exception)
			{
				return false;
			}
			if (value >= base.MinValue && value <= base.MaxValue)
			{
				str = value.ToString();
				return true;
			}
			return false;
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0002D808 File Offset: 0x0002BA08
		public override void SetText(string text)
		{
			base.SetText(text.PadLeft(base.NumberOfDigits, '0'));
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x0002D820 File Offset: 0x0002BA20
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			decimal d;
			return base.ValidateSection(contentModificationsAllowed) && base.ParseToInt(out d) && !(d < base.MinValue) && !(d > base.MaxValue);
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0002D864 File Offset: 0x0002BA64
		internal override bool CanInsertCharAt(int pos, char c)
		{
			if (!base.CanInsertCharAt(pos, c))
			{
				return false;
			}
			if (base.MaxValue > 12m)
			{
				if (pos == 0)
				{
					if (base.DisplayChars[1].Char > '3' && c > '1')
					{
						return false;
					}
					if (base.DisplayChars[1].Char != '\0' && c > '2')
					{
						return false;
					}
				}
				if (1 == pos)
				{
					if (base.DisplayChars[1].Char > '2')
					{
						return false;
					}
					if ('2' == base.DisplayChars[1].Char && c > '3')
					{
						return false;
					}
				}
			}
			else
			{
				if (pos == 0)
				{
					if (base.DisplayChars[1].Char > '2' && c > '0')
					{
						return false;
					}
					if (base.DisplayChars[1].Char != '\0' && c > '1')
					{
						return false;
					}
				}
				if (1 == pos)
				{
					if (base.DisplayChars[1].Char > '1')
					{
						return false;
					}
					if ('1' == base.DisplayChars[1].Char && c > '2')
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0002D978 File Offset: 0x0002BB78
		internal override global::Infragistics.Windows.Editors.SectionBase InternalClone(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			global::Infragistics.Windows.Editors.HourSection hourSection = new global::Infragistics.Windows.Editors.HourSection();
			this.InternalCopy(hourSection);
			hourSection.InitSectionsCollection(sections);
			return hourSection;
		}
	}
}
