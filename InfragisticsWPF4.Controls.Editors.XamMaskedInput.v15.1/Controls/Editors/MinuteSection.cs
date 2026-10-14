using System;
using System.Globalization;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200003E RID: 62
	public sealed class MinuteSection : global::Infragistics.Controls.Editors.NumberSection
	{
		// Token: 0x06000248 RID: 584 RVA: 0x0000ECA5 File Offset: 0x0000CEA5
		public MinuteSection() : base(2)
		{
			base.MinValue = 0m;
			base.MaxValue = 59m;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000ECC8 File Offset: 0x0000CEC8
		public override bool ValidateString(ref string str)
		{
			str = global::Infragistics.Controls.Editors.NumberSection.StripOutPadPromptCharacters(str, this);
			int num = -1;
			try
			{
				if (!int.TryParse(str, global::System.Globalization.NumberStyles.None, global::System.Globalization.NumberFormatInfo.CurrentInfo, out num))
				{
					return false;
				}
			}
			catch (global::System.Exception)
			{
				return false;
			}
			if (num >= 0 && num <= 59)
			{
				str = num.ToString();
				return true;
			}
			return false;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000ED24 File Offset: 0x0000CF24
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			decimal d;
			return base.ValidateSection(contentModificationsAllowed) && this.ParseToInt(out d) && !(d < 0m) && !(d >= 60m);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000ED68 File Offset: 0x0000CF68
		public override void SetText(string text)
		{
			base.SetText(text.PadLeft(base.NumberOfDigits, '0'));
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000ED80 File Offset: 0x0000CF80
		internal override global::Infragistics.Controls.Editors.SectionBase InternalClone(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			global::Infragistics.Controls.Editors.MinuteSection minuteSection = new global::Infragistics.Controls.Editors.MinuteSection();
			this.InternalCopy(minuteSection);
			minuteSection.InitSectionsCollection(sections);
			return minuteSection;
		}
	}
}
