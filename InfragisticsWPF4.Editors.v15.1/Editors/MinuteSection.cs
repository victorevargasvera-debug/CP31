using System;
using System.Globalization;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000B3 RID: 179
	public sealed class MinuteSection : global::Infragistics.Windows.Editors.NumberSection
	{
		// Token: 0x060009D2 RID: 2514 RVA: 0x0002DD95 File Offset: 0x0002BF95
		public MinuteSection() : base(2)
		{
			base.MinValue = 0m;
			base.MaxValue = 59m;
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0002DDB8 File Offset: 0x0002BFB8
		public override bool ValidateString(ref string str)
		{
			str = global::Infragistics.Windows.Editors.NumberSection.StripOutPadPromptCharacters(str, this);
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

		// Token: 0x060009D4 RID: 2516 RVA: 0x0002DE14 File Offset: 0x0002C014
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			decimal d;
			return base.ValidateSection(contentModificationsAllowed) && base.ParseToInt(out d) && !(d < 0m) && !(d >= 60m);
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0002DE58 File Offset: 0x0002C058
		public override void SetText(string text)
		{
			base.SetText(text.PadLeft(base.NumberOfDigits, '0'));
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0002DE70 File Offset: 0x0002C070
		internal override global::Infragistics.Windows.Editors.SectionBase InternalClone(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			global::Infragistics.Windows.Editors.MinuteSection minuteSection = new global::Infragistics.Windows.Editors.MinuteSection();
			this.InternalCopy(minuteSection);
			minuteSection.InitSectionsCollection(sections);
			return minuteSection;
		}
	}
}
