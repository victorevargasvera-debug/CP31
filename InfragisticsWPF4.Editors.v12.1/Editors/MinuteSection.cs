using System;
using System.Globalization;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000AC RID: 172
	public sealed class MinuteSection : global::Infragistics.Windows.Editors.NumberSection
	{
		// Token: 0x06000964 RID: 2404 RVA: 0x0002BD8D File Offset: 0x00029F8D
		public MinuteSection() : base(2)
		{
			base.MinValue = 0m;
			base.MaxValue = 59m;
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0002BDB0 File Offset: 0x00029FB0
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

		// Token: 0x06000966 RID: 2406 RVA: 0x0002BE0C File Offset: 0x0002A00C
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			decimal d;
			return base.ValidateSection(contentModificationsAllowed) && base.ParseToInt(out d) && !(d < 0m) && !(d >= 60m);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x0002BE50 File Offset: 0x0002A050
		public override void SetText(string text)
		{
			base.SetText(text.PadLeft(base.NumberOfDigits, '0'));
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0002BE68 File Offset: 0x0002A068
		internal override global::Infragistics.Windows.Editors.SectionBase InternalClone(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			global::Infragistics.Windows.Editors.MinuteSection minuteSection = new global::Infragistics.Windows.Editors.MinuteSection();
			this.InternalCopy(minuteSection);
			minuteSection.InitSectionsCollection(sections);
			return minuteSection;
		}
	}
}
