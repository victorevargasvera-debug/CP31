using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevAge.ComponentModel.Validator;
using DevAge.Drawing;
using DevAge.Windows.Forms;

namespace SourceGrid.Cells.Editors
{
	// Token: 0x0200038C RID: 908
	[global::System.ComponentModel.ToolboxItem(false)]
	internal class ImagePicker : global::SourceGrid.Cells.Editors.EditorControlBase
	{
		// Token: 0x06002AC1 RID: 10945 RVA: 0x0008FD28 File Offset: 0x0008DF28
		public ImagePicker() : base(typeof(byte[]))
		{
		}

		// Token: 0x06002AC2 RID: 10946 RVA: 0x0008FD3C File Offset: 0x0008DF3C
		protected override global::System.Windows.Forms.Control CreateControl()
		{
			return new global::DevAge.Windows.Forms.TextBoxUITypeEditor
			{
				BorderStyle = global::DevAge.Drawing.BorderStyle.None,
				Validator = new global::DevAge.ComponentModel.Validator.ValidatorTypeConverter(typeof(global::System.Drawing.Image))
			};
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x06002AC3 RID: 10947 RVA: 0x0008FD70 File Offset: 0x0008DF70
		public new global::DevAge.Windows.Forms.TextBoxUITypeEditor Control
		{
			get
			{
				return (global::DevAge.Windows.Forms.TextBoxUITypeEditor)base.Control;
			}
		}

		// Token: 0x06002AC4 RID: 10948 RVA: 0x0008FD80 File Offset: 0x0008DF80
		public override object GetEditedValue()
		{
			object value = this.Control.Value;
			if (value == null)
			{
				return null;
			}
			if (value is global::System.Drawing.Image)
			{
				global::DevAge.ComponentModel.Validator.ValidatorTypeConverter validatorTypeConverter = new global::DevAge.ComponentModel.Validator.ValidatorTypeConverter(typeof(global::System.Drawing.Image));
				return validatorTypeConverter.ValueToObject(value, typeof(byte[]));
			}
			if (value is byte[])
			{
				return value;
			}
			throw new global::SourceGrid.SourceGridException("Invalid edited value, expected byte[] or Image");
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x0008FDEC File Offset: 0x0008DFEC
		public override void SetEditValue(object editValue)
		{
			this.Control.Value = editValue;
			this.Control.TextBox.SelectAll();
		}

		// Token: 0x06002AC6 RID: 10950 RVA: 0x0008FE1C File Offset: 0x0008E01C
		public override string ValueToDisplayString(object p_Value)
		{
			return null;
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x0008FE20 File Offset: 0x0008E020
		protected override void OnSendCharToEditor(char key)
		{
		}
	}
}
