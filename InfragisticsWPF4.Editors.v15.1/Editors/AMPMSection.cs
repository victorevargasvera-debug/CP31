using System;
using System.Globalization;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000B1 RID: 177
	public sealed class AMPMSection : global::Infragistics.Windows.Editors.DisplayCharsEditSection
	{
		// Token: 0x060009C0 RID: 2496 RVA: 0x0002D99A File Offset: 0x0002BB9A
		internal AMPMSection(string amValue, string pmValue)
		{
			global::Infragistics.Windows.Editors.Utils.ValidateNull("amValue", amValue);
			global::Infragistics.Windows.Editors.Utils.ValidateNull("pmValue", pmValue);
			this.amValue = amValue;
			this.pmValue = pmValue;
			this.CreateDisplayChars();
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x0002D9CC File Offset: 0x0002BBCC
		internal string AMValue
		{
			get
			{
				return this.amValue;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x0002D9D4 File Offset: 0x0002BBD4
		internal string PMValue
		{
			get
			{
				return this.pmValue;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x0002D9DC File Offset: 0x0002BBDC
		internal override bool SupportsSpinning
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x0002D9DF File Offset: 0x0002BBDF
		internal override bool CanSpin(bool up)
		{
			return true;
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0002D9E2 File Offset: 0x0002BBE2
		internal override bool Spin(bool up, bool setLimit)
		{
			this.ToggleAMPM();
			return true;
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0002D9EC File Offset: 0x0002BBEC
		internal void ToggleAMPM()
		{
			string text = this.GetText(global::Infragistics.Windows.Editors.MaskMode.Raw);
			if (string.Compare(text, this.amValue, true, base.MaskInfo.CultureInfo) == 0)
			{
				this.SetText(this.pmValue);
				return;
			}
			if (string.Compare(text, this.pmValue, true, base.MaskInfo.CultureInfo) == 0)
			{
				this.SetText(this.amValue);
				return;
			}
			this.SetText(this.amValue);
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0002DA5C File Offset: 0x0002BC5C
		internal override bool IsInputFull()
		{
			string text = this.GetText(global::Infragistics.Windows.Editors.MaskMode.Raw);
			return string.Compare(this.amValue, text, true, base.MaskInfo.CultureInfo) == 0 || string.Compare(this.pmValue, text, true, base.MaskInfo.CultureInfo) == 0;
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0002DAA8 File Offset: 0x0002BCA8
		private void CreateDisplayChars()
		{
			int num = global::System.Math.Max(this.amValue.Length, this.pmValue.Length);
			for (int i = 0; i < num; i++)
			{
				base.DisplayChars.Add(new global::Infragistics.Windows.Editors.AMPMSection.CustomDisplayChar(this));
			}
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0002DAF0 File Offset: 0x0002BCF0
		internal override global::Infragistics.Windows.Editors.SectionBase InternalClone(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			global::Infragistics.Windows.Editors.AMPMSection ampmsection = new global::Infragistics.Windows.Editors.AMPMSection(this.amValue, this.pmValue);
			this.InternalCopy(ampmsection);
			ampmsection.InitSectionsCollection(sections);
			return ampmsection;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x0002DB20 File Offset: 0x0002BD20
		public override bool ValidateSection(bool contentModificationsAllowed)
		{
			if (!base.ValidateSection(contentModificationsAllowed))
			{
				return false;
			}
			if (contentModificationsAllowed)
			{
				string text = "";
				for (int i = 0; i < base.DisplayChars.Count; i++)
				{
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = base.DisplayChars[i];
					if (displayCharBase != null && !displayCharBase.IsEmpty)
					{
						text += displayCharBase.Char;
					}
				}
				if (text.Length > 0)
				{
					text = text.ToLower(global::System.Globalization.CultureInfo.CurrentCulture);
					bool flag = this.AMValue.ToLower(global::System.Globalization.CultureInfo.CurrentCulture).StartsWith(text);
					bool flag2 = this.PMValue.ToLower(global::System.Globalization.CultureInfo.CurrentCulture).StartsWith(text);
					if (flag && !flag2)
					{
						this.SetText(this.AMValue);
					}
					else if (flag2 && !flag)
					{
						this.SetText(this.PMValue);
					}
				}
			}
			return true;
		}

		// Token: 0x0400039D RID: 925
		private string amValue;

		// Token: 0x0400039E RID: 926
		private string pmValue;

		// Token: 0x020000B2 RID: 178
		private sealed class CustomDisplayChar : global::Infragistics.Windows.Editors.InputCharBase
		{
			// Token: 0x060009CB RID: 2507 RVA: 0x0002DBF1 File Offset: 0x0002BDF1
			internal CustomDisplayChar(global::Infragistics.Windows.Editors.AMPMSection section) : base(section)
			{
				base.IncludeMethod = global::Infragistics.Windows.Editors.DisplayCharIncludeMethod.Always;
			}

			// Token: 0x17000241 RID: 577
			// (get) Token: 0x060009CC RID: 2508 RVA: 0x0002DC01 File Offset: 0x0002BE01
			public override bool IsEditable
			{
				get
				{
					return true;
				}
			}

			// Token: 0x060009CD RID: 2509 RVA: 0x0002DC04 File Offset: 0x0002BE04
			public override bool MatchChar(char c)
			{
				this.Filter(c);
				global::Infragistics.Windows.Editors.AMPMSection ampmsection = (global::Infragistics.Windows.Editors.AMPMSection)base.Section;
				global::Infragistics.Windows.Editors.DisplayCharsCollection displayChars = ampmsection.DisplayChars;
				int index = base.Index;
				bool flag = false;
				bool flag2 = false;
				char c2 = char.ToLower(c, base.MaskInfo.CultureInfo);
				if (ampmsection.amValue.Length > index && char.ToLower(ampmsection.amValue[index], base.MaskInfo.CultureInfo) == c2)
				{
					flag = true;
				}
				if (ampmsection.pmValue.Length > index && char.ToLower(ampmsection.pmValue[index], base.MaskInfo.CultureInfo) == c2)
				{
					flag2 = true;
				}
				return (flag || flag2) && (index == 0 || (flag && base.PrevDisplayChar.MatchChar(ampmsection.amValue[index - 1])) || (flag2 && base.PrevDisplayChar.MatchChar(ampmsection.pmValue[index - 1])));
			}

			// Token: 0x17000242 RID: 578
			// (get) Token: 0x060009CE RID: 2510 RVA: 0x0002DCF8 File Offset: 0x0002BEF8
			// (set) Token: 0x060009CF RID: 2511 RVA: 0x0002DD10 File Offset: 0x0002BF10
			public override char Char
			{
				get
				{
					if (!this.MatchChar(this.inputChar))
					{
						return '\0';
					}
					return this.inputChar;
				}
				set
				{
					char c = value;
					if (value != '\0' && !this.MatchChar(c))
					{
						c = '\0';
					}
					if (c != '\0')
					{
						c = this.Filter(c);
					}
					this.inputChar = c;
					base.NotifyPropertyChangedEvent(global::Infragistics.Windows.Editors.DisplayCharBase.PROPERTY_CHAR);
				}
			}

			// Token: 0x060009D0 RID: 2512 RVA: 0x0002DD4C File Offset: 0x0002BF4C
			internal override void InternalCopy(global::Infragistics.Windows.Editors.DisplayCharBase dest)
			{
				base.InternalCopy(dest);
				global::Infragistics.Windows.Editors.AMPMSection.CustomDisplayChar customDisplayChar = (global::Infragistics.Windows.Editors.AMPMSection.CustomDisplayChar)dest;
				customDisplayChar.inputChar = this.inputChar;
			}

			// Token: 0x060009D1 RID: 2513 RVA: 0x0002DD74 File Offset: 0x0002BF74
			internal override global::Infragistics.Windows.Editors.DisplayCharBase InternalClone(global::Infragistics.Windows.Editors.SectionBase section)
			{
				global::Infragistics.Windows.Editors.AMPMSection.CustomDisplayChar customDisplayChar = new global::Infragistics.Windows.Editors.AMPMSection.CustomDisplayChar((global::Infragistics.Windows.Editors.AMPMSection)section);
				this.InternalCopy(customDisplayChar);
				return customDisplayChar;
			}

			// Token: 0x0400039F RID: 927
			private char inputChar;
		}
	}
}
