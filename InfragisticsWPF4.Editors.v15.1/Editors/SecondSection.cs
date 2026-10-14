using System;
using System.Globalization;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000B4 RID: 180
	public sealed class SecondSection : global::Infragistics.Windows.Editors.NumberSection
	{
		// Token: 0x060009D7 RID: 2519 RVA: 0x0002DE92 File Offset: 0x0002C092
		public SecondSection() : base(2)
		{
			base.MinValue = 0m;
			base.MaxValue = 59m;
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0002DEB4 File Offset: 0x0002C0B4
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

		// Token: 0x060009D9 RID: 2521 RVA: 0x0002DF30 File Offset: 0x0002C130
		public override void SetText(string text)
		{
			base.SetText(text.PadLeft(base.NumberOfDigits, '0'));
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0002DF48 File Offset: 0x0002C148
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			decimal d;
			return base.ValidateSection(contentModificationsAllowed) && base.ParseToInt(out d) && !(d < base.MinValue) && !(d > base.MaxValue);
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0002DF8C File Offset: 0x0002C18C
		internal override global::Infragistics.Windows.Editors.SectionBase InternalClone(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			global::Infragistics.Windows.Editors.SecondSection secondSection = new global::Infragistics.Windows.Editors.SecondSection();
			this.InternalCopy(secondSection);
			secondSection.InitSectionsCollection(sections);
			return secondSection;
		}
	}
}
