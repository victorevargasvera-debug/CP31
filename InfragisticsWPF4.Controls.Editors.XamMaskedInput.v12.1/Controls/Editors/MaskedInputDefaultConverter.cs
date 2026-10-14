using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200005B RID: 91
	internal class MaskedInputDefaultConverter : global::Infragistics.Controls.Editors.ValueInputDefaultConverter
	{
		// Token: 0x060004BE RID: 1214 RVA: 0x000191E8 File Offset: 0x000173E8
		protected MaskedInputDefaultConverter(bool isDisplayTextConverter) : base(isDisplayTextConverter)
		{
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x000191F1 File Offset: 0x000173F1
		public new static global::Infragistics.Controls.Editors.MaskedInputDefaultConverter ValueToTextConverter
		{
			get
			{
				if (global::Infragistics.Controls.Editors.MaskedInputDefaultConverter._valueToTextConverter == null)
				{
					global::Infragistics.Controls.Editors.MaskedInputDefaultConverter._valueToTextConverter = new global::Infragistics.Controls.Editors.MaskedInputDefaultConverter(false);
				}
				return global::Infragistics.Controls.Editors.MaskedInputDefaultConverter._valueToTextConverter;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x0001920A File Offset: 0x0001740A
		public new static global::Infragistics.Controls.Editors.MaskedInputDefaultConverter ValueToDisplayTextConverter
		{
			get
			{
				if (global::Infragistics.Controls.Editors.MaskedInputDefaultConverter._valueToDisplayTextConverter == null)
				{
					global::Infragistics.Controls.Editors.MaskedInputDefaultConverter._valueToDisplayTextConverter = new global::Infragistics.Controls.Editors.MaskedInputDefaultConverter(true);
				}
				return global::Infragistics.Controls.Editors.MaskedInputDefaultConverter._valueToDisplayTextConverter;
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00019224 File Offset: 0x00017424
		internal string ConvertToTextBasedOnMask(global::Infragistics.Controls.Editors.XamMaskedInput editor, object value, bool useSectionsDirectly)
		{
			global::Infragistics.Controls.Editors.MaskInfo maskInfo = global::Infragistics.Controls.Editors.MaskInfo.CreateMaskInfoForConverter(editor);
			global::Infragistics.Controls.Editors.SectionsCollection sections = maskInfo.Sections;
			if (sections == null)
			{
				return null;
			}
			string result;
			try
			{
				bool flag = false;
				if (useSectionsDirectly)
				{
					bool flag2;
					bool flag3;
					global::System.Type right = global::Infragistics.Controls.Editors.XamMaskedInput.DeduceEditAsType(sections, out flag2, out flag3);
					bool flag4 = global::Infragistics.Controls.Editors.XamMaskedInput.HasNonDateTimeEditSections(sections);
					if (value is global::System.DateTime && typeof(global::System.DateTime) == right && !flag4)
					{
						global::Infragistics.Controls.Editors.XamMaskedInput.SetDateTimeValue(sections, (global::System.DateTime)value, maskInfo, false);
						flag = true;
					}
				}
				if (!flag)
				{
					maskInfo.InternalRefreshValue(value);
				}
				bool flag5 = global::Infragistics.Controls.Editors.XamMaskedInput.AreAllDisplayCharsEmpty(sections);
				if (flag5)
				{
					result = (this._isDisplayTextConverter ? editor.NullText : string.Empty);
				}
				else
				{
					result = global::Infragistics.Controls.Editors.XamMaskedInput.GetText(sections, this._isDisplayTextConverter ? maskInfo.DisplayMode : maskInfo.DataMode, maskInfo);
				}
			}
			finally
			{
				global::Infragistics.Controls.Editors.MaskInfo.ReleaseMaskInfoForConverter(maskInfo);
			}
			return result;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x000192F8 File Offset: 0x000174F8
		protected override object ConvertHelper(bool convertingBack, object value, global::System.Type targetType, global::Infragistics.Controls.Editors.ValueInput valueInput, global::System.IFormatProvider formatProvider, string format)
		{
			if (value != null && global::System.DBNull.Value != value)
			{
				global::Infragistics.Controls.Editors.XamMaskedInput xamMaskedInput = valueInput as global::Infragistics.Controls.Editors.XamMaskedInput;
				if (xamMaskedInput != null)
				{
					if (convertingBack)
					{
						if (xamMaskedInput.IsInEditMode && object.Equals(value, xamMaskedInput.Text) && xamMaskedInput.EditInfo != null && xamMaskedInput.EditInfo._inOnTextChanged)
						{
							if (global::Infragistics.Controls.Editors.XamMaskedInput.AreAllDisplayCharsEmpty(xamMaskedInput.EditInfo.Sections))
							{
								return null;
							}
							return xamMaskedInput.EditInfo.Value;
						}
						else
						{
							if (this._isDisplayTextConverter && object.Equals(value, xamMaskedInput.NullText))
							{
								return null;
							}
							if (format != null && this._isDisplayTextConverter)
							{
								goto IL_113;
							}
							global::Infragistics.Controls.Editors.MaskInfo maskInfo = global::Infragistics.Controls.Editors.MaskInfo.CreateMaskInfoForConverter(xamMaskedInput);
							try
							{
								string text = (value != null) ? value.ToString() : string.Empty;
								int num = global::Infragistics.Controls.Editors.XamMaskedInput.SetText(maskInfo.Sections, text, maskInfo);
								if (num < text.Length)
								{
									return null;
								}
								if (global::Infragistics.Controls.Editors.XamMaskedInput.AreAllDisplayCharsEmpty(maskInfo.Sections))
								{
									return null;
								}
								return global::Infragistics.Controls.Editors.XamMaskedInput.GetDataValue(maskInfo);
							}
							finally
							{
								global::Infragistics.Controls.Editors.MaskInfo.ReleaseMaskInfoForConverter(maskInfo);
							}
						}
					}
					if (typeof(string) == targetType && (format == null || !this._isDisplayTextConverter))
					{
						return this.ConvertToTextBasedOnMask(xamMaskedInput, value, false);
					}
				}
			}
			IL_113:
			return base.ConvertHelper(convertingBack, value, targetType, valueInput, formatProvider, format);
		}

		// Token: 0x040001B0 RID: 432
		private static global::Infragistics.Controls.Editors.MaskedInputDefaultConverter _valueToDisplayTextConverter;

		// Token: 0x040001B1 RID: 433
		private static global::Infragistics.Controls.Editors.MaskedInputDefaultConverter _valueToTextConverter;
	}
}
