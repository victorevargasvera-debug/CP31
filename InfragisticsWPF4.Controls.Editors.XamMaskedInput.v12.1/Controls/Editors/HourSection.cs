using System;
using System.Globalization;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200003C RID: 60
	public sealed class HourSection : global::Infragistics.Controls.Editors.NumberSection
	{
		// Token: 0x06000230 RID: 560 RVA: 0x0000E8C0 File Offset: 0x0000CAC0
		public HourSection() : base(2)
		{
			base.MinValue = 0m;
			base.MaxValue = 23m;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000E8E4 File Offset: 0x0000CAE4
		public override bool ValidateString(ref string str)
		{
			str = global::Infragistics.Controls.Editors.NumberSection.StripOutPadPromptCharacters(str, this);
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

		// Token: 0x06000232 RID: 562 RVA: 0x0000E960 File Offset: 0x0000CB60
		public override void SetText(string text)
		{
			base.SetText(text.PadLeft(base.NumberOfDigits, '0'));
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000E978 File Offset: 0x0000CB78
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			decimal d;
			return base.ValidateSection(contentModificationsAllowed) && this.ParseToInt(out d) && !(d < base.MinValue) && !(d > base.MaxValue);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000E9BC File Offset: 0x0000CBBC
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

		// Token: 0x06000235 RID: 565 RVA: 0x0000EAD0 File Offset: 0x0000CCD0
		internal override global::Infragistics.Controls.Editors.SectionBase InternalClone(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			global::Infragistics.Controls.Editors.HourSection hourSection = new global::Infragistics.Controls.Editors.HourSection();
			this.InternalCopy(hourSection);
			hourSection.InitSectionsCollection(sections);
			return hourSection;
		}
	}
}
