using System;
using System.Globalization;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000AD RID: 173
	public sealed class SecondSection : global::Infragistics.Windows.Editors.NumberSection
	{
		// Token: 0x06000969 RID: 2409 RVA: 0x0002BE8A File Offset: 0x0002A08A
		public SecondSection() : base(2)
		{
			base.MinValue = 0m;
			base.MaxValue = 59m;
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x0002BEAC File Offset: 0x0002A0AC
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

		// Token: 0x0600096B RID: 2411 RVA: 0x0002BF28 File Offset: 0x0002A128
		public override void SetText(string text)
		{
			base.SetText(text.PadLeft(base.NumberOfDigits, '0'));
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0002BF40 File Offset: 0x0002A140
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			decimal d;
			return base.ValidateSection(contentModificationsAllowed) && base.ParseToInt(out d) && !(d < base.MinValue) && !(d > base.MaxValue);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0002BF84 File Offset: 0x0002A184
		internal override global::Infragistics.Windows.Editors.SectionBase InternalClone(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			global::Infragistics.Windows.Editors.SecondSection secondSection = new global::Infragistics.Windows.Editors.SecondSection();
			this.InternalCopy(secondSection);
			secondSection.InitSectionsCollection(sections);
			return secondSection;
		}
	}
}
