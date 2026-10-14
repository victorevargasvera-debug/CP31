using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;

namespace SourceGrid.Cells.Editors
{
	// Token: 0x020003C3 RID: 963
	internal static class Factory
	{
		// Token: 0x06002C00 RID: 11264 RVA: 0x00093A70 File Offset: 0x00091C70
		public static global::SourceGrid.Cells.Editors.EditorBase Create(global::System.Type p_Type)
		{
			global::System.ComponentModel.TypeConverter converter = global::System.ComponentModel.TypeDescriptor.GetConverter(p_Type);
			global::System.Collections.ICollection collection = null;
			bool p_StandardValueExclusive = false;
			if (converter != null)
			{
				collection = converter.GetStandardValues();
				p_StandardValueExclusive = (collection != null && collection.Count > 0 && converter.GetStandardValuesExclusive());
			}
			object editor = global::System.ComponentModel.TypeDescriptor.GetEditor(p_Type, typeof(global::System.Drawing.Design.UITypeEditor));
			if (editor != null)
			{
				return new global::SourceGrid.Cells.Editors.TextBoxUITypeEditor(p_Type);
			}
			if (collection != null)
			{
				return new global::SourceGrid.Cells.Editors.ComboBox(p_Type, collection, p_StandardValueExclusive);
			}
			if (converter != null && converter.CanConvertFrom(typeof(string)))
			{
				return new global::SourceGrid.Cells.Editors.TextBox(p_Type);
			}
			return null;
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x00093B0C File Offset: 0x00091D0C
		public static global::SourceGrid.Cells.Editors.EditorBase Create(global::System.Type p_Type, object p_DefaultValue, bool p_bAllowNull, global::System.Collections.ICollection p_StandardValues, bool p_bStandardValueExclusive, global::System.ComponentModel.TypeConverter p_TypeConverter, global::System.Drawing.Design.UITypeEditor p_UITypeEditor)
		{
			global::SourceGrid.Cells.Editors.EditorBase editorBase;
			if (p_UITypeEditor == null)
			{
				if (p_StandardValues != null)
				{
					global::SourceGrid.Cells.Editors.ComboBox comboBox = new global::SourceGrid.Cells.Editors.ComboBox(p_Type);
					editorBase = comboBox;
				}
				else if (p_TypeConverter != null && p_TypeConverter.CanConvertFrom(typeof(string)))
				{
					global::SourceGrid.Cells.Editors.TextBox textBox = new global::SourceGrid.Cells.Editors.TextBox(p_Type);
					editorBase = textBox;
				}
				else
				{
					editorBase = null;
				}
			}
			else
			{
				editorBase = new global::SourceGrid.Cells.Editors.TextBoxUITypeEditor(p_Type)
				{
					Control = 
					{
						UITypeEditor = p_UITypeEditor
					}
				};
			}
			if (editorBase != null)
			{
				editorBase.DefaultValue = p_DefaultValue;
				editorBase.AllowNull = p_bAllowNull;
				editorBase.StandardValues = p_StandardValues;
				editorBase.StandardValuesExclusive = p_bStandardValueExclusive;
				editorBase.TypeConverter = p_TypeConverter;
			}
			return editorBase;
		}
	}
}
