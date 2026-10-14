using System;
using System.Globalization;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200003B RID: 59
	public sealed class YearSection : global::Infragistics.Controls.Editors.NumberSection
	{
		// Token: 0x06000226 RID: 550 RVA: 0x0000E57E File Offset: 0x0000C77E
		public YearSection(bool isFourDigits) : base(isFourDigits ? 4 : 2)
		{
			this.isFourDigits = isFourDigits;
			base.MinValue = 0m;
			base.MaxValue = 9999m;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000E5B8 File Offset: 0x0000C7B8
		internal int GetYear()
		{
			int year = base.ToInt();
			return this.GetYear(year);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000E5D3 File Offset: 0x0000C7D3
		internal bool TryGetYear(out int year)
		{
			if (!base.TryToInt(out year))
			{
				return false;
			}
			year = this.GetYear(year);
			return true;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000E5EC File Offset: 0x0000C7EC
		private int GetYear(int year)
		{
			global::System.Globalization.Calendar calendar = base.Calendar;
			if (this.isFourDigits)
			{
				if (base.DisplayChars[0].Char == '\0' && base.DisplayChars[1].Char == '\0')
				{
					year = global::Infragistics.Controls.Editors.XamMaskedInput.ConvertToFourYear(year, calendar);
				}
			}
			else
			{
				year = global::Infragistics.Controls.Editors.XamMaskedInput.ConvertToFourYear(year, calendar);
			}
			return year;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000E644 File Offset: 0x0000C844
		internal override bool ParseToInt(out decimal val)
		{
			if (base.ParseToInt(out val))
			{
				global::Infragistics.Controls.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
				bool flag = !this.isFourDigits || (displayChars[0].Char == '\0' && '\0' == displayChars[1].Char);
				if (flag)
				{
					val = global::Infragistics.Controls.Editors.XamMaskedInput.ConvertToFourYear((int)val, base.Calendar);
				}
				return true;
			}
			return false;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000E6B4 File Offset: 0x0000C8B4
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			if (!base.ValidateSection(false))
			{
				return false;
			}
			if (contentModificationsAllowed)
			{
				try
				{
					int num;
					if (this.isFourDigits && this.TryGetYear(out num))
					{
						this.SetText(global::Infragistics.Controls.Editors.NumberSection.PadNumber((long)num, 4));
					}
				}
				catch (global::System.Exception)
				{
				}
			}
			return true;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000E708 File Offset: 0x0000C908
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
				this.SetText(calendar.GetYear(global::System.DateTime.Now).ToString());
				return true;
			}
			catch (global::System.Exception)
			{
			}
			IL_48:
			decimal num = base.MinValue;
			decimal num2 = base.MaxValue;
			object minValue = base.MaskInfo.MinValue;
			if (minValue != null)
			{
				try
				{
					if (minValue is global::System.DateTime)
					{
						num = calendar.GetYear((global::System.DateTime)minValue);
					}
				}
				catch (global::System.Exception)
				{
				}
			}
			object maxValue = base.MaskInfo.MaxValue;
			if (maxValue != null)
			{
				try
				{
					if (maxValue is global::System.DateTime)
					{
						num2 = calendar.GetYear((global::System.DateTime)maxValue);
					}
				}
				catch (global::System.Exception)
				{
				}
			}
			decimal num3;
			if (setLimit)
			{
				num3 = (up ? num : num2);
			}
			else
			{
				try
				{
					num3 = this.GetYear();
					num3 = (up ? (++num3) : (--num3));
				}
				catch
				{
					num3 = (up ? num : num2);
				}
			}
			return base.Spin(up, setLimit, num3, num, num2);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000E850 File Offset: 0x0000CA50
		public override void SetText(string text)
		{
			base.SetText(text.PadLeft(base.NumberOfDigits, '0'));
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000E868 File Offset: 0x0000CA68
		internal override global::Infragistics.Controls.Editors.SectionBase InternalClone(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			global::Infragistics.Controls.Editors.YearSection yearSection = new global::Infragistics.Controls.Editors.YearSection(this.isFourDigits);
			this.InternalCopy(yearSection);
			yearSection.InitSectionsCollection(sections);
			return yearSection;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000E890 File Offset: 0x0000CA90
		internal static void InitializeMinMax(global::Infragistics.Controls.Editors.YearSection yearSection, global::System.Globalization.Calendar calendar)
		{
			yearSection.MinValue = calendar.GetYear(calendar.MinSupportedDateTime);
			yearSection.MaxValue = calendar.GetYear(calendar.MaxSupportedDateTime);
		}

		// Token: 0x040000E1 RID: 225
		private bool isFourDigits = true;
	}
}
