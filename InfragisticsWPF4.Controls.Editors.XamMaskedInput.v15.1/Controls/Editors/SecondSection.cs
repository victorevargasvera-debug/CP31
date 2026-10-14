using System;
using System.Globalization;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200003F RID: 63
	public sealed class SecondSection : global::Infragistics.Controls.Editors.NumberSection
	{
		// Token: 0x0600024D RID: 589 RVA: 0x0000EDA2 File Offset: 0x0000CFA2
		public SecondSection() : base(2)
		{
			base.MinValue = 0m;
			base.MaxValue = 59m;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000EDC4 File Offset: 0x0000CFC4
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

		// Token: 0x0600024F RID: 591 RVA: 0x0000EE40 File Offset: 0x0000D040
		public override void SetText(string text)
		{
			base.SetText(text.PadLeft(base.NumberOfDigits, '0'));
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000EE58 File Offset: 0x0000D058
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			decimal d;
			return base.ValidateSection(contentModificationsAllowed) && this.ParseToInt(out d) && !(d < base.MinValue) && !(d > base.MaxValue);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000EE9C File Offset: 0x0000D09C
		internal override global::Infragistics.Controls.Editors.SectionBase InternalClone(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			global::Infragistics.Controls.Editors.SecondSection secondSection = new global::Infragistics.Controls.Editors.SecondSection();
			this.InternalCopy(secondSection);
			secondSection.InitSectionsCollection(sections);
			return secondSection;
		}
	}
}
