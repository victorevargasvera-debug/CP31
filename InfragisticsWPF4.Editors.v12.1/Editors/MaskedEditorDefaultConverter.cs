using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200009E RID: 158
	internal sealed class MaskedEditorDefaultConverter : global::Infragistics.Windows.Editors.ValueEditorDefaultConverter
	{
		// Token: 0x0600087D RID: 2173 RVA: 0x00028036 File Offset: 0x00026236
		private MaskedEditorDefaultConverter(bool isDisplayTextConverter) : base(isDisplayTextConverter)
		{
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x0002803F File Offset: 0x0002623F
		public new static global::Infragistics.Windows.Editors.MaskedEditorDefaultConverter ValueToTextConverter
		{
			get
			{
				if (global::Infragistics.Windows.Editors.MaskedEditorDefaultConverter._valueToTextConverter == null)
				{
					global::Infragistics.Windows.Editors.MaskedEditorDefaultConverter._valueToTextConverter = new global::Infragistics.Windows.Editors.MaskedEditorDefaultConverter(false);
				}
				return global::Infragistics.Windows.Editors.MaskedEditorDefaultConverter._valueToTextConverter;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x00028058 File Offset: 0x00026258
		public new static global::Infragistics.Windows.Editors.MaskedEditorDefaultConverter ValueToDisplayTextConverter
		{
			get
			{
				if (global::Infragistics.Windows.Editors.MaskedEditorDefaultConverter._valueToDisplayTextConverter == null)
				{
					global::Infragistics.Windows.Editors.MaskedEditorDefaultConverter._valueToDisplayTextConverter = new global::Infragistics.Windows.Editors.MaskedEditorDefaultConverter(true);
				}
				return global::Infragistics.Windows.Editors.MaskedEditorDefaultConverter._valueToDisplayTextConverter;
			}
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00028074 File Offset: 0x00026274
		internal string ConvertToTextBasedOnMask(global::Infragistics.Windows.Editors.XamMaskedEditor editor, object value, bool useSectionsDirectly)
		{
			global::Infragistics.Windows.Editors.MaskInfo maskInfo = global::Infragistics.Windows.Editors.MaskInfo.CreateMaskInfoForConverter(editor);
			global::Infragistics.Windows.Editors.SectionsCollection sections = maskInfo.Sections;
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
					global::System.Type right = global::Infragistics.Windows.Editors.XamMaskedEditor.DeduceEditAsType(sections, out flag2, out flag3);
					bool flag4 = global::Infragistics.Windows.Editors.XamMaskedEditor.HasNonDateTimeEditSections(sections);
					if (value is global::System.DateTime && typeof(global::System.DateTime) == right && !flag4)
					{
						global::Infragistics.Windows.Editors.XamMaskedEditor.SetDateTimeValue(sections, (global::System.DateTime)value, maskInfo, false);
						flag = true;
					}
				}
				if (!flag)
				{
					maskInfo.InternalRefreshValue(value);
				}
				bool flag5 = global::Infragistics.Windows.Editors.XamMaskedEditor.AreAllDisplayCharsEmpty(sections);
				if (flag5)
				{
					result = (this._isDisplayTextConverter ? editor.NullText : string.Empty);
				}
				else
				{
					result = global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(sections, this._isDisplayTextConverter ? maskInfo.DisplayMode : maskInfo.DataMode, maskInfo);
				}
			}
			finally
			{
				global::Infragistics.Windows.Editors.MaskInfo.ReleaseMaskInfoForConverter(maskInfo);
			}
			return result;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00028148 File Offset: 0x00026348
		protected override object ConvertHelper(bool convertingBack, object value, global::System.Type targetType, global::Infragistics.Windows.Editors.ValueEditor valueEditor, global::System.IFormatProvider formatProvider, string format)
		{
			if (value != null && global::System.DBNull.Value != value)
			{
				global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = valueEditor as global::Infragistics.Windows.Editors.XamMaskedEditor;
				if (xamMaskedEditor != null)
				{
					if (convertingBack)
					{
						if (xamMaskedEditor.IsInEditMode && !xamMaskedEditor._isEnteringEditMode && object.Equals(value, xamMaskedEditor.Text) && xamMaskedEditor.EditInfo != null && xamMaskedEditor.EditInfo._inOnTextChanged)
						{
							if (global::Infragistics.Windows.Editors.XamMaskedEditor.AreAllDisplayCharsEmpty(xamMaskedEditor.EditInfo.Sections))
							{
								return null;
							}
							return xamMaskedEditor.EditInfo.Value;
						}
						else
						{
							if (this._isDisplayTextConverter && object.Equals(value, xamMaskedEditor.NullText))
							{
								return null;
							}
							if (format != null && this._isDisplayTextConverter)
							{
								goto IL_11B;
							}
							global::Infragistics.Windows.Editors.MaskInfo maskInfo = global::Infragistics.Windows.Editors.MaskInfo.CreateMaskInfoForConverter(xamMaskedEditor);
							try
							{
								string text = (value != null) ? value.ToString() : string.Empty;
								int num = global::Infragistics.Windows.Editors.XamMaskedEditor.SetText(maskInfo.Sections, text, maskInfo);
								if (num < text.Length)
								{
									return null;
								}
								if (global::Infragistics.Windows.Editors.XamMaskedEditor.AreAllDisplayCharsEmpty(maskInfo.Sections))
								{
									return null;
								}
								return global::Infragistics.Windows.Editors.XamMaskedEditor.GetDataValue(maskInfo);
							}
							finally
							{
								global::Infragistics.Windows.Editors.MaskInfo.ReleaseMaskInfoForConverter(maskInfo);
							}
						}
					}
					if (typeof(string) == targetType && (format == null || !this._isDisplayTextConverter))
					{
						return this.ConvertToTextBasedOnMask(xamMaskedEditor, value, false);
					}
				}
			}
			IL_11B:
			return base.ConvertHelper(convertingBack, value, targetType, valueEditor, formatProvider, format);
		}

		// Token: 0x04000336 RID: 822
		private static global::Infragistics.Windows.Editors.MaskedEditorDefaultConverter _valueToDisplayTextConverter;

		// Token: 0x04000337 RID: 823
		private static global::Infragistics.Windows.Editors.MaskedEditorDefaultConverter _valueToTextConverter;
	}
}
