using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevAge.ComponentModel.Validator;

namespace DevAge.Windows.Forms
{
	// Token: 0x020002F2 RID: 754
	internal class DevAgeMaskedTextBox : global::System.Windows.Forms.MaskedTextBox
	{
		// Token: 0x06002442 RID: 9282 RVA: 0x0007E1E4 File Offset: 0x0007C3E4
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
				if (this.Validator.IsStringConversionSupported())
				{
					this.Text = this.Validator.ValueToString(p_Value);
					return;
				}
				this.Text = this.Validator.ValueToDisplayString(p_Value);
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06002443 RID: 9283 RVA: 0x0007E25C File Offset: 0x0007C45C
		// (set) Token: 0x06002444 RID: 9284 RVA: 0x0007E264 File Offset: 0x0007C464
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

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06002445 RID: 9285 RVA: 0x0007E270 File Offset: 0x0007C470
		// (set) Token: 0x06002446 RID: 9286 RVA: 0x0007E278 File Offset: 0x0007C478
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

		// Token: 0x06002447 RID: 9287 RVA: 0x0007E2DC File Offset: 0x0007C4DC
		private void mValidator_Changed(object sender, global::System.EventArgs e)
		{
			this.ApplyValidatorRules();
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x0007E2E4 File Offset: 0x0007C4E4
		protected virtual void ApplyValidatorRules()
		{
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x0007E2E8 File Offset: 0x0007C4E8
		public bool IsValidValue(out object convertedValue)
		{
			if (this.Validator != null)
			{
				return this.Validator.IsValidObject(this.Text, out convertedValue);
			}
			convertedValue = this.Text;
			return true;
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x0600244A RID: 9290 RVA: 0x0007E328 File Offset: 0x0007C528
		// (set) Token: 0x0600244B RID: 9291 RVA: 0x0007E354 File Offset: 0x0007C554
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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
					if (this.Validator.IsStringConversionSupported())
					{
						this.Text = this.Validator.ValueToString(value);
						return;
					}
					this.Text = this.Validator.ValueToDisplayString(value);
					return;
				}
				else
				{
					if (value == null)
					{
						this.Text = "";
						return;
					}
					this.Text = value.ToString();
					return;
				}
			}
		}

		// Token: 0x04000CC4 RID: 3268
		private bool mFormatValue;

		// Token: 0x04000CC5 RID: 3269
		private global::DevAge.ComponentModel.Validator.IValidator mValidator;
	}
}
