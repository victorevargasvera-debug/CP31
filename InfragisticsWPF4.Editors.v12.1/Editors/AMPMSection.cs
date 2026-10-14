using System;
using System.Globalization;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000AA RID: 170
	public sealed class AMPMSection : global::Infragistics.Windows.Editors.DisplayCharsEditSection
	{
		// Token: 0x06000952 RID: 2386 RVA: 0x0002B992 File Offset: 0x00029B92
		internal AMPMSection(string amValue, string pmValue)
		{
			global::Infragistics.Windows.Editors.Utils.ValidateNull("amValue", amValue);
			global::Infragistics.Windows.Editors.Utils.ValidateNull("pmValue", pmValue);
			this.amValue = amValue;
			this.pmValue = pmValue;
			this.CreateDisplayChars();
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x0002B9C4 File Offset: 0x00029BC4
		internal string AMValue
		{
			get
			{
				return this.amValue;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x0002B9CC File Offset: 0x00029BCC
		internal string PMValue
		{
			get
			{
				return this.pmValue;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x0002B9D4 File Offset: 0x00029BD4
		internal override bool SupportsSpinning
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0002B9D7 File Offset: 0x00029BD7
		internal override bool CanSpin(bool up)
		{
			return true;
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0002B9DA File Offset: 0x00029BDA
		internal override bool Spin(bool up, bool setLimit)
		{
			this.ToggleAMPM();
			return true;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0002B9E4 File Offset: 0x00029BE4
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

		// Token: 0x06000959 RID: 2393 RVA: 0x0002BA54 File Offset: 0x00029C54
		internal override bool IsInputFull()
		{
			string text = this.GetText(global::Infragistics.Windows.Editors.MaskMode.Raw);
			return string.Compare(this.amValue, text, true, base.MaskInfo.CultureInfo) == 0 || string.Compare(this.pmValue, text, true, base.MaskInfo.CultureInfo) == 0;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0002BAA0 File Offset: 0x00029CA0
		private void CreateDisplayChars()
		{
			int num = global::System.Math.Max(this.amValue.Length, this.pmValue.Length);
			for (int i = 0; i < num; i++)
			{
				base.DisplayChars.Add(new global::Infragistics.Windows.Editors.AMPMSection.CustomDisplayChar(this));
			}
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0002BAE8 File Offset: 0x00029CE8
		internal override global::Infragistics.Windows.Editors.SectionBase InternalClone(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			global::Infragistics.Windows.Editors.AMPMSection ampmsection = new global::Infragistics.Windows.Editors.AMPMSection(this.amValue, this.pmValue);
			this.InternalCopy(ampmsection);
			ampmsection.InitSectionsCollection(sections);
			return ampmsection;
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0002BB18 File Offset: 0x00029D18
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

		// Token: 0x04000366 RID: 870
		private string amValue;

		// Token: 0x04000367 RID: 871
		private string pmValue;

		// Token: 0x020000AB RID: 171
		private sealed class CustomDisplayChar : global::Infragistics.Windows.Editors.InputCharBase
		{
			// Token: 0x0600095D RID: 2397 RVA: 0x0002BBE9 File Offset: 0x00029DE9
			internal CustomDisplayChar(global::Infragistics.Windows.Editors.AMPMSection section) : base(section)
			{
				base.IncludeMethod = global::Infragistics.Windows.Editors.DisplayCharIncludeMethod.Always;
			}

			// Token: 0x1700022C RID: 556
			// (get) Token: 0x0600095E RID: 2398 RVA: 0x0002BBF9 File Offset: 0x00029DF9
			public override bool IsEditable
			{
				get
				{
					return true;
				}
			}

			// Token: 0x0600095F RID: 2399 RVA: 0x0002BBFC File Offset: 0x00029DFC
			public override bool MatchChar(char c)
			{
				base.Filter(c);
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

			// Token: 0x1700022D RID: 557
			// (get) Token: 0x06000960 RID: 2400 RVA: 0x0002BCF0 File Offset: 0x00029EF0
			// (set) Token: 0x06000961 RID: 2401 RVA: 0x0002BD08 File Offset: 0x00029F08
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
					base.NotifyPropertyChangedEvent(global::Infragistics.Windows.Editors.DisplayCharBase.PROPERTY_CHAR);
				}
			}

			// Token: 0x06000962 RID: 2402 RVA: 0x0002BD44 File Offset: 0x00029F44
			internal override void InternalCopy(global::Infragistics.Windows.Editors.DisplayCharBase dest)
			{
				base.InternalCopy(dest);
				global::Infragistics.Windows.Editors.AMPMSection.CustomDisplayChar customDisplayChar = (global::Infragistics.Windows.Editors.AMPMSection.CustomDisplayChar)dest;
				customDisplayChar.inputChar = this.inputChar;
			}

			// Token: 0x06000963 RID: 2403 RVA: 0x0002BD6C File Offset: 0x00029F6C
			internal override global::Infragistics.Windows.Editors.DisplayCharBase InternalClone(global::Infragistics.Windows.Editors.SectionBase section)
			{
				global::Infragistics.Windows.Editors.AMPMSection.CustomDisplayChar customDisplayChar = new global::Infragistics.Windows.Editors.AMPMSection.CustomDisplayChar((global::Infragistics.Windows.Editors.AMPMSection)section);
				this.InternalCopy(customDisplayChar);
				return customDisplayChar;
			}

			// Token: 0x04000368 RID: 872
			private char inputChar;
		}
	}
}
