using System;
using System.Globalization;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000038 RID: 56
	public sealed class MonthSection : global::Infragistics.Controls.Editors.NumberSection
	{
		// Token: 0x06000216 RID: 534 RVA: 0x0000DD55 File Offset: 0x0000BF55
		public MonthSection() : base(2)
		{
			base.MinValue = 1m;
			base.MaxValue = 12m;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000DD78 File Offset: 0x0000BF78
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
			if (num >= 1 && num <= base.MaxValue)
			{
				str = num.ToString();
				return true;
			}
			return false;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000DDE4 File Offset: 0x0000BFE4
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			decimal d;
			return base.ValidateSection(contentModificationsAllowed) && this.ParseToInt(out d) && !(d < 1m) && !(d > base.MaxValue);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000DE27 File Offset: 0x0000C027
		public override void SetText(string text)
		{
			base.SetText(text.PadLeft(base.NumberOfDigits, '0'));
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000DE40 File Offset: 0x0000C040
		internal override bool CanInsertCharAt(int pos, char c)
		{
			if (!base.CanInsertCharAt(pos, c))
			{
				return false;
			}
			if (pos == 0)
			{
				if (base.DisplayChars[1].Char > this.MaxTrailingChar && c > '0')
				{
					return false;
				}
				if (base.DisplayChars[1].Char != '\0' && c >= '2')
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
				if ('1' == base.DisplayChars[1].Char && c > this.MaxTrailingChar)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0000DED2 File Offset: 0x0000C0D2
		private char MaxTrailingChar
		{
			get
			{
				if (base.MaxValue == 13m)
				{
					return '3';
				}
				return '2';
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000DEF0 File Offset: 0x0000C0F0
		internal override bool Spin(bool up, bool setLimit)
		{
			string text = this.GetText(global::Infragistics.Controls.Editors.InputMaskMode.Raw);
			global::System.Globalization.Calendar calendar = base.Calendar;
			if (text != null && text.Length != 0)
			{
				if (base.IsInt(text))
				{
					goto IL_48;
				}
			}
			try
			{
				this.SetText(calendar.GetMonth(global::System.DateTime.Now).ToString());
				return true;
			}
			catch (global::System.Exception)
			{
			}
			IL_48:
			decimal minValue = base.MinValue;
			decimal maxValue = base.MaxValue;
			int num = 0;
			int num2 = 9999;
			object minValue2 = base.MaskInfo.MinValue;
			if (minValue2 != null && minValue2 is global::System.DateTime)
			{
				global::System.DateTime time = (global::System.DateTime)minValue2;
				minValue = calendar.GetMonth(time);
				num = calendar.GetYear(time);
			}
			object maxValue2 = base.MaskInfo.MaxValue;
			if (maxValue2 != null && maxValue2 is global::System.DateTime)
			{
				global::System.DateTime time2 = (global::System.DateTime)maxValue2;
				maxValue = calendar.GetMonth(time2);
				num2 = calendar.GetYear(time2);
			}
			if (num == num2)
			{
				return base.Spin(up, setLimit, minValue, maxValue);
			}
			return base.Spin(up, setLimit, base.MinValue, base.MaxValue);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000E00C File Offset: 0x0000C20C
		internal override global::Infragistics.Controls.Editors.SectionBase InternalClone(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			global::Infragistics.Controls.Editors.MonthSection monthSection = new global::Infragistics.Controls.Editors.MonthSection();
			this.InternalCopy(monthSection);
			monthSection.InitSectionsCollection(sections);
			return monthSection;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000E02E File Offset: 0x0000C22E
		internal static void InitializeMinMax(global::Infragistics.Controls.Editors.MonthSection section, global::System.Globalization.Calendar calendar)
		{
			if (calendar is global::System.Globalization.EastAsianLunisolarCalendar || calendar is global::System.Globalization.HebrewCalendar)
			{
				section.MaxValue = 13m;
			}
		}
	}
}
