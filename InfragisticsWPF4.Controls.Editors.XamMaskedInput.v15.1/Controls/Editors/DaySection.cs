using System;
using System.Globalization;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000039 RID: 57
	public sealed class DaySection : global::Infragistics.Controls.Editors.NumberSection
	{
		// Token: 0x0600021F RID: 543 RVA: 0x0000E04D File Offset: 0x0000C24D
		public DaySection() : base(2)
		{
			base.MinValue = 1m;
			base.MaxValue = 31m;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000E070 File Offset: 0x0000C270
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
			if (num >= 1 && num <= 31)
			{
				str = num.ToString();
				return true;
			}
			return false;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000E0CC File Offset: 0x0000C2CC
		public override void SetText(string text)
		{
			base.SetText(text.PadLeft(base.NumberOfDigits, '0'));
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000E0E4 File Offset: 0x0000C2E4
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

		// Token: 0x06000223 RID: 547 RVA: 0x0000E184 File Offset: 0x0000C384
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			decimal d;
			return base.ValidateSection(contentModificationsAllowed) && this.ParseToInt(out d) && !(d < 1m) && !(d > 31m);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000E1C8 File Offset: 0x0000C3C8
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

		// Token: 0x06000225 RID: 549 RVA: 0x0000E324 File Offset: 0x0000C524
		internal override global::Infragistics.Controls.Editors.SectionBase InternalClone(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			global::Infragistics.Controls.Editors.DaySection daySection = new global::Infragistics.Controls.Editors.DaySection();
			this.InternalCopy(daySection);
			daySection.InitSectionsCollection(sections);
			return daySection;
		}
	}
}
