using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevAge.ComponentModel.Validator;

namespace DevAge.Windows.Forms
{
	// Token: 0x0200030B RID: 779
	internal class DevAgeComboBox : global::System.Windows.Forms.ComboBox
	{
		// Token: 0x06002531 RID: 9521 RVA: 0x00082190 File Offset: 0x00080390
		protected override void OnValidating(global::System.ComponentModel.CancelEventArgs e)
		{
			base.OnValidating(e);
			object p_Value;
			if (!this.IsValidValue(out p_Value))
			{
				e.Cancel = true;
				return;
			}
			if (this.FormatValue && this.Validator != null)
			{
				this.Text = this.Validator.ValueToDisplayString(p_Value);
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06002532 RID: 9522 RVA: 0x000821E8 File Offset: 0x000803E8
		// (set) Token: 0x06002533 RID: 9523 RVA: 0x000821F0 File Offset: 0x000803F0
		[global::System.ComponentModel.DefaultValue(false)]
		public bool FormatValue
		{
			get
			{
				return this.mFormatValue;
			}
			set
			{
				this.mFormatValue = value;
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x06002534 RID: 9524 RVA: 0x000821FC File Offset: 0x000803FC
		// (set) Token: 0x06002535 RID: 9525 RVA: 0x00082204 File Offset: 0x00080404
		[global::System.ComponentModel.DefaultValue(null)]
		public global::DevAge.ComponentModel.Validator.IValidator Validator
		{
			get
			{
				return this.mValidator;
			}
			set
			{
				if (this.mValidator != value)
				{
					if (this.mValidator != null)
					{
						this.mValidator.Changed -= this.mValidator_Changed;
					}
					this.mValidator = value;
					this.mValidator.Changed += this.mValidator_Changed;
					this.ApplyValidatorRules();
				}
			}
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x00082268 File Offset: 0x00080468
		private void mValidator_Changed(object sender, global::System.EventArgs e)
		{
			this.ApplyValidatorRules();
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x00082270 File Offset: 0x00080470
		public bool IsValidValue(out object convertedValue)
		{
			object obj;
			if (base.SelectedValue != null)
			{
				obj = base.SelectedValue;
			}
			else if (base.SelectedItem != null)
			{
				obj = base.SelectedItem;
			}
			else
			{
				obj = this.Text;
			}
			if (this.Validator != null)
			{
				return this.Validator.IsValidObject(obj, out convertedValue);
			}
			convertedValue = obj;
			return true;
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06002538 RID: 9528 RVA: 0x000822DC File Offset: 0x000804DC
		// (set) Token: 0x06002539 RID: 9529 RVA: 0x00082308 File Offset: 0x00080508
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public object Value
		{
			get
			{
				object result;
				if (this.IsValidValue(out result))
				{
					return result;
				}
				throw new global::System.ArgumentOutOfRangeException("Text");
			}
			set
			{
				if (this.Validator != null)
				{
					this.Text = this.Validator.ValueToDisplayString(value);
					return;
				}
				if (value == null)
				{
					this.Text = "";
					return;
				}
				this.Text = value.ToString();
			}
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x00082358 File Offset: 0x00080558
		protected virtual void ApplyValidatorRules()
		{
			base.Items.Clear();
			if (this.Validator != null && this.Validator.StandardValues != null)
			{
				foreach (object item in this.Validator.StandardValues)
				{
					base.Items.Add(item);
				}
				if (this.Validator.IsStringConversionSupported())
				{
					base.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDown;
					return;
				}
				base.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			}
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x00082408 File Offset: 0x00080608
		protected override void OnFormat(global::System.Windows.Forms.ListControlConvertEventArgs e)
		{
			base.OnFormat(e);
			if (e.DesiredType != typeof(string) || this.Validator == null)
			{
				return;
			}
			e.Value = this.Validator.ValueToDisplayString(e.ListItem);
		}

		// Token: 0x04000CFA RID: 3322
		private bool mFormatValue;

		// Token: 0x04000CFB RID: 3323
		private global::DevAge.ComponentModel.Validator.IValidator mValidator;
	}
}
