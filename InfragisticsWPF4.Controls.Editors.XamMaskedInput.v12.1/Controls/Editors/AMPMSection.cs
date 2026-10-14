using System;
using System.Globalization;
using Infragistics.Controls.Editors.Primitives;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200003D RID: 61
	public sealed class AMPMSection : global::Infragistics.Controls.Editors.DisplayCharsEditSection
	{
		// Token: 0x06000236 RID: 566 RVA: 0x0000EAF2 File Offset: 0x0000CCF2
		internal AMPMSection(string amValue, string pmValue)
		{
			global::Infragistics.Controls.Editors.Primitives.Utils.ValidateNull("amValue", amValue);
			global::Infragistics.Controls.Editors.Primitives.Utils.ValidateNull("pmValue", pmValue);
			this.amValue = amValue;
			this.pmValue = pmValue;
			this.CreateDisplayChars();
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0000EB24 File Offset: 0x0000CD24
		internal string AMValue
		{
			get
			{
				return this.amValue;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0000EB2C File Offset: 0x0000CD2C
		internal string PMValue
		{
			get
			{
				return this.pmValue;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000EB34 File Offset: 0x0000CD34
		internal override bool SupportsSpinning
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000EB37 File Offset: 0x0000CD37
		internal override bool CanSpin(bool up)
		{
			return true;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000EB3A File Offset: 0x0000CD3A
		internal override bool Spin(bool up, bool setLimit)
		{
			this.ToggleAMPM();
			return true;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000EB44 File Offset: 0x0000CD44
		internal void ToggleAMPM()
		{
			string text = this.GetText(global::Infragistics.Controls.Editors.InputMaskMode.Raw);
			global::System.Globalization.CultureInfo cultureInfo = base.MaskInfo.CultureInfo;
			if (global::Infragistics.Controls.Editors.Primitives.Utils.CompareStrings(text, this.amValue, true, cultureInfo) == 0)
			{
				this.SetText(this.pmValue);
				return;
			}
			if (global::Infragistics.Controls.Editors.Primitives.Utils.CompareStrings(text, this.pmValue, true, cultureInfo) == 0)
			{
				this.SetText(this.amValue);
				return;
			}
			this.SetText(this.amValue);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000EBAC File Offset: 0x0000CDAC
		internal override bool IsInputFull()
		{
			string text = this.GetText(global::Infragistics.Controls.Editors.InputMaskMode.Raw);
			global::System.Globalization.CultureInfo cultureInfo = base.MaskInfo.CultureInfo;
			return global::Infragistics.Controls.Editors.Primitives.Utils.CompareStrings(this.amValue, text, true, cultureInfo) == 0 || global::Infragistics.Controls.Editors.Primitives.Utils.CompareStrings(this.pmValue, text, true, cultureInfo) == 0;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000EBF0 File Offset: 0x0000CDF0
		private void CreateDisplayChars()
		{
			int num = global::System.Math.Max(this.amValue.Length, this.pmValue.Length);
			for (int i = 0; i < num; i++)
			{
				base.DisplayChars.Add(new global::Infragistics.Controls.Editors.AMPMSection.CustomDisplayChar(this));
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000EC38 File Offset: 0x0000CE38
		internal override global::Infragistics.Controls.Editors.SectionBase InternalClone(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			global::Infragistics.Controls.Editors.AMPMSection ampmsection = new global::Infragistics.Controls.Editors.AMPMSection(this.amValue, this.pmValue);
			this.InternalCopy(ampmsection);
			ampmsection.InitSectionsCollection(sections);
			return ampmsection;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000EC68 File Offset: 0x0000CE68
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
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = base.DisplayChars[i];
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

		// Token: 0x040000E2 RID: 226
		private string amValue;

		// Token: 0x040000E3 RID: 227
		private string pmValue;

		// Token: 0x0200003E RID: 62
		private sealed class CustomDisplayChar : global::Infragistics.Controls.Editors.InputCharBase
		{
			// Token: 0x06000241 RID: 577 RVA: 0x0000ED39 File Offset: 0x0000CF39
			internal CustomDisplayChar(global::Infragistics.Controls.Editors.AMPMSection section) : base(section)
			{
				base.IncludeMethod = global::Infragistics.Controls.Editors.DisplayCharIncludeMethod.Always;
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x06000242 RID: 578 RVA: 0x0000ED49 File Offset: 0x0000CF49
			public override bool IsEditable
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06000243 RID: 579 RVA: 0x0000ED4C File Offset: 0x0000CF4C
			public override bool MatchChar(char c)
			{
				base.Filter(c);
				global::Infragistics.Controls.Editors.AMPMSection ampmsection = (global::Infragistics.Controls.Editors.AMPMSection)base.Section;
				global::Infragistics.Controls.Editors.DisplayCharsCollection displayChars = ampmsection.DisplayChars;
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

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x06000244 RID: 580 RVA: 0x0000EE40 File Offset: 0x0000D040
			// (set) Token: 0x06000245 RID: 581 RVA: 0x0000EE58 File Offset: 0x0000D058
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
						c = base.Filter(c);
					}
					this.inputChar = c;
					base.NotifyPropertyChangedEvent(global::Infragistics.Controls.Editors.DisplayCharBase.PROPERTY_CHAR);
				}
			}

			// Token: 0x06000246 RID: 582 RVA: 0x0000EE94 File Offset: 0x0000D094
			internal override void InternalCopy(global::Infragistics.Controls.Editors.DisplayCharBase dest)
			{
				base.InternalCopy(dest);
				global::Infragistics.Controls.Editors.AMPMSection.CustomDisplayChar customDisplayChar = (global::Infragistics.Controls.Editors.AMPMSection.CustomDisplayChar)dest;
				customDisplayChar.inputChar = this.inputChar;
			}

			// Token: 0x06000247 RID: 583 RVA: 0x0000EEBC File Offset: 0x0000D0BC
			internal override global::Infragistics.Controls.Editors.DisplayCharBase InternalClone(global::Infragistics.Controls.Editors.SectionBase section)
			{
				global::Infragistics.Controls.Editors.AMPMSection.CustomDisplayChar customDisplayChar = new global::Infragistics.Controls.Editors.AMPMSection.CustomDisplayChar((global::Infragistics.Controls.Editors.AMPMSection)section);
				this.InternalCopy(customDisplayChar);
				return customDisplayChar;
			}

			// Token: 0x040000E4 RID: 228
			private char inputChar;
		}
	}
}
