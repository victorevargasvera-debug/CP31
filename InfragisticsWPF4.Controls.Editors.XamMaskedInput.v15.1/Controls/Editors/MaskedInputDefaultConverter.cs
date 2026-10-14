using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200005B RID: 91
	internal class MaskedInputDefaultConverter : global::Infragistics.Controls.Editors.ValueInputDefaultConverter
	{
		// Token: 0x060004D2 RID: 1234 RVA: 0x00019600 File Offset: 0x00017800
		protected MaskedInputDefaultConverter(bool isDisplayTextConverter) : base(isDisplayTextConverter)
		{
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00019609 File Offset: 0x00017809
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

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00019622 File Offset: 0x00017822
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

		// Token: 0x060004D5 RID: 1237 RVA: 0x0001963C File Offset: 0x0001783C
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

		// Token: 0x060004D6 RID: 1238 RVA: 0x00019710 File Offset: 0x00017910
		protected override object ConvertHelper(bool convertingBack, object value, global::System.Type targetType, global::Infragistics.Controls.Editors.ValueInput valueInput, global::System.IFormatProvider formatProvider, string format)
		{
			if (!global::Infragistics.CoreUtilities.IsNull(value))
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
								goto IL_10D;
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
								return global::Infragistics.Controls.Editors.XamMaskedInput.InternalGetDataValue(maskInfo);
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
			IL_10D:
			return base.ConvertHelper(convertingBack, value, targetType, valueInput, formatProvider, format);
		}

		// Token: 0x040001BD RID: 445
		private static global::Infragistics.Controls.Editors.MaskedInputDefaultConverter _valueToDisplayTextConverter;

		// Token: 0x040001BE RID: 446
		private static global::Infragistics.Controls.Editors.MaskedInputDefaultConverter _valueToTextConverter;
	}
}
