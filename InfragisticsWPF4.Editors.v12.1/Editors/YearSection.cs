using System;
using System.Globalization;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000A8 RID: 168
	public sealed class YearSection : global::Infragistics.Windows.Editors.NumberSection
	{
		// Token: 0x06000942 RID: 2370 RVA: 0x0002B41A File Offset: 0x0002961A
		public YearSection(bool isFourDigits) : base(isFourDigits ? 4 : 2)
		{
			this.isFourDigits = isFourDigits;
			base.MinValue = 0m;
			base.MaxValue = 9999m;
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0002B454 File Offset: 0x00029654
		internal int GetYear()
		{
			int year = base.ToInt();
			return this.GetYear(year);
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0002B46F File Offset: 0x0002966F
		internal bool TryGetYear(out int year)
		{
			if (!base.TryToInt(out year))
			{
				return false;
			}
			year = this.GetYear(year);
			return true;
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0002B488 File Offset: 0x00029688
		private int GetYear(int year)
		{
			global::System.Globalization.Calendar calendar = base.Calendar;
			if (this.isFourDigits)
			{
				if (base.DisplayChars[0].Char == '\0' && base.DisplayChars[1].Char == '\0')
				{
					year = global::Infragistics.Windows.Editors.XamMaskedEditor.ConvertToFourYear(year, calendar);
				}
			}
			else
			{
				year = global::Infragistics.Windows.Editors.XamMaskedEditor.ConvertToFourYear(year, calendar);
			}
			return year;
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0002B4E0 File Offset: 0x000296E0
		internal override bool ParseToInt(string rawText, out decimal val)
		{
			if (base.ParseToInt(rawText, out val))
			{
				global::Infragistics.Windows.Editors.DisplayCharsCollection displayChars = base.DisplayChars;
				bool flag = !this.isFourDigits || (displayChars[0].Char == '\0' && '\0' == displayChars[1].Char);
				if (flag)
				{
					val = global::Infragistics.Windows.Editors.XamMaskedEditor.ConvertToFourYear((int)val, base.Calendar);
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0002B554 File Offset: 0x00029754
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
						this.SetText(global::Infragistics.Windows.Editors.NumberSection.PadNumber((long)num, 4));
					}
				}
				catch (global::System.Exception)
				{
				}
			}
			return true;
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0002B5A8 File Offset: 0x000297A8
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

		// Token: 0x06000949 RID: 2377 RVA: 0x0002B6F0 File Offset: 0x000298F0
		public override void SetText(string text)
		{
			base.SetText(text.PadLeft(base.NumberOfDigits, '0'));
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0002B708 File Offset: 0x00029908
		internal override global::Infragistics.Windows.Editors.SectionBase InternalClone(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			global::Infragistics.Windows.Editors.YearSection yearSection = new global::Infragistics.Windows.Editors.YearSection(this.isFourDigits);
			this.InternalCopy(yearSection);
			yearSection.InitSectionsCollection(sections);
			return yearSection;
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0002B730 File Offset: 0x00029930
		internal static void InitializeMinMax(global::Infragistics.Windows.Editors.YearSection yearSection, global::System.Globalization.Calendar calendar)
		{
			yearSection.MinValue = calendar.GetYear(calendar.MinSupportedDateTime);
			yearSection.MaxValue = calendar.GetYear(calendar.MaxSupportedDateTime);
		}

		// Token: 0x04000365 RID: 869
		private bool isFourDigits = true;
	}
}
