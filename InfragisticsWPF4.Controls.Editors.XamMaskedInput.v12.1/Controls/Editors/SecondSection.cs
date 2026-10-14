using System;
using System.Globalization;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000040 RID: 64
	public sealed class SecondSection : global::Infragistics.Controls.Editors.NumberSection
	{
		// Token: 0x0600024D RID: 589 RVA: 0x0000EFDA File Offset: 0x0000D1DA
		public SecondSection() : base(2)
		{
			base.MinValue = 0m;
			base.MaxValue = 59m;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000EFFC File Offset: 0x0000D1FC
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

		// Token: 0x0600024F RID: 591 RVA: 0x0000F078 File Offset: 0x0000D278
		public override void SetText(string text)
		{
			base.SetText(text.PadLeft(base.NumberOfDigits, '0'));
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000F090 File Offset: 0x0000D290
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			decimal d;
			return base.ValidateSection(contentModificationsAllowed) && this.ParseToInt(out d) && !(d < base.MinValue) && !(d > base.MaxValue);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000F0D4 File Offset: 0x0000D2D4
		internal override global::Infragistics.Controls.Editors.SectionBase InternalClone(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			global::Infragistics.Controls.Editors.SecondSection secondSection = new global::Infragistics.Controls.Editors.SecondSection();
			this.InternalCopy(secondSection);
			secondSection.InitSectionsCollection(sections);
			return secondSection;
		}
	}
}
