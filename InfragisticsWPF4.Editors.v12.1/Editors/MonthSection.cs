using System;
using System.Globalization;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000A6 RID: 166
	public sealed class MonthSection : global::Infragistics.Windows.Editors.NumberSection
	{
		// Token: 0x06000932 RID: 2354 RVA: 0x0002AE29 File Offset: 0x00029029
		public MonthSection() : base(2)
		{
			base.MinValue = 1m;
			base.MaxValue = 12m;
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0002AE4C File Offset: 0x0002904C
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
			if (num >= 1 && num <= base.MaxValue)
			{
				str = num.ToString();
				return true;
			}
			return false;
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0002AEB8 File Offset: 0x000290B8
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			decimal d;
			return base.ValidateSection(contentModificationsAllowed) && base.ParseToInt(out d) && !(d < 1m) && !(d > base.MaxValue);
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0002AEFB File Offset: 0x000290FB
		public override void SetText(string text)
		{
			base.SetText(text.PadLeft(base.NumberOfDigits, '0'));
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0002AF14 File Offset: 0x00029114
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

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x0002AFA6 File Offset: 0x000291A6
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

		// Token: 0x06000938 RID: 2360 RVA: 0x0002AFC4 File Offset: 0x000291C4
		internal override bool Spin(bool up, bool setLimit)
		{
			string text = this.GetText(global::Infragistics.Windows.Editors.MaskMode.Raw);
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

		// Token: 0x06000939 RID: 2361 RVA: 0x0002B0E0 File Offset: 0x000292E0
		internal override global::Infragistics.Windows.Editors.SectionBase InternalClone(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			global::Infragistics.Windows.Editors.MonthSection monthSection = new global::Infragistics.Windows.Editors.MonthSection();
			this.InternalCopy(monthSection);
			monthSection.InitSectionsCollection(sections);
			return monthSection;
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0002B102 File Offset: 0x00029302
		internal static void InitializeMinMax(global::Infragistics.Windows.Editors.MonthSection section, global::System.Globalization.Calendar calendar)
		{
			if (calendar is global::System.Globalization.EastAsianLunisolarCalendar || calendar is global::System.Globalization.HebrewCalendar)
			{
				section.MaxValue = 13m;
			}
		}
	}
}
