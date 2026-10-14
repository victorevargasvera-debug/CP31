using System;
using System.Globalization;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000A7 RID: 167
	public sealed class DaySection : global::Infragistics.Windows.Editors.NumberSection
	{
		// Token: 0x0600093B RID: 2363 RVA: 0x0002B121 File Offset: 0x00029321
		public DaySection() : base(2)
		{
			base.MinValue = 1m;
			base.MaxValue = 31m;
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0002B144 File Offset: 0x00029344
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
			if (num >= 1 && num <= 31)
			{
				str = num.ToString();
				return true;
			}
			return false;
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0002B1A0 File Offset: 0x000293A0
		public override void SetText(string text)
		{
			base.SetText(text.PadLeft(base.NumberOfDigits, '0'));
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0002B1B8 File Offset: 0x000293B8
		internal override bool CanInsertCharAt(int pos, char c)
		{
			if (!base.CanInsertCharAt(pos, c))
			{
				return false;
			}
			if (pos == 0 && base.DisplayChars[1].Char != '\0')
			{
				if (base.DisplayChars[1].Char <= '1' && c > '3')
				{
					return false;
				}
				if (base.DisplayChars[1].Char > '1' && c > '2')
				{
					return false;
				}
			}
			if (1 == pos)
			{
				if (base.DisplayChars[1].Char > '3')
				{
					return false;
				}
				if (base.DisplayChars[1].Char > '2' && c > '1')
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0002B258 File Offset: 0x00029458
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			decimal d;
			return base.ValidateSection(contentModificationsAllowed) && base.ParseToInt(out d) && !(d < 1m) && !(d > 31m);
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0002B29C File Offset: 0x0002949C
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
				this.SetText(calendar.GetDayOfMonth(global::System.DateTime.Now).ToString());
				return true;
			}
			catch (global::System.Exception)
			{
			}
			IL_48:
			decimal minValue = base.MinValue;
			decimal maxValue = base.MaxValue;
			int num = 1;
			int num2 = 12;
			int num3 = 0;
			int num4 = 9999;
			object obj = base.MaskInfo.MinValue;
			obj = base.MaskInfo.ValueToDataValue(obj);
			if (obj != null && obj is global::System.DateTime)
			{
				global::System.DateTime time = (global::System.DateTime)obj;
				minValue = calendar.GetDayOfMonth(time);
				num = calendar.GetMonth(time);
				num3 = calendar.GetYear(time);
			}
			object obj2 = base.MaskInfo.MaxValue;
			obj2 = base.MaskInfo.ValueToDataValue(obj2);
			if (obj2 != null && obj2 is global::System.DateTime)
			{
				global::System.DateTime time2 = (global::System.DateTime)obj2;
				maxValue = calendar.GetDayOfMonth(time2);
				num2 = calendar.GetMonth(time2);
				num4 = calendar.GetYear(time2);
			}
			if (num3 == num4 && num == num2)
			{
				return base.Spin(up, setLimit, minValue, maxValue);
			}
			return base.Spin(up, setLimit, base.MinValue, base.MaxValue);
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0002B3F8 File Offset: 0x000295F8
		internal override global::Infragistics.Windows.Editors.SectionBase InternalClone(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			global::Infragistics.Windows.Editors.DaySection daySection = new global::Infragistics.Windows.Editors.DaySection();
			this.InternalCopy(daySection);
			daySection.InitSectionsCollection(sections);
			return daySection;
		}
	}
}
