using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevAge.ComponentModel.Validator;

namespace DevAge.Windows.Forms
{
	// Token: 0x020002F0 RID: 752
	internal class DevAgeTextBox : global::System.Windows.Forms.TextBox
	{
		// Token: 0x06002430 RID: 9264 RVA: 0x0007DF28 File Offset: 0x0007C128
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

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06002431 RID: 9265 RVA: 0x0007DFA0 File Offset: 0x0007C1A0
		// (set) Token: 0x06002432 RID: 9266 RVA: 0x0007DFA8 File Offset: 0x0007C1A8
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

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06002433 RID: 9267 RVA: 0x0007DFB4 File Offset: 0x0007C1B4
		// (set) Token: 0x06002434 RID: 9268 RVA: 0x0007DFBC File Offset: 0x0007C1BC
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

		// Token: 0x06002435 RID: 9269 RVA: 0x0007E020 File Offset: 0x0007C220
		private void mValidator_Changed(object sender, global::System.EventArgs e)
		{
			this.ApplyValidatorRules();
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x0007E028 File Offset: 0x0007C228
		protected virtual void ApplyValidatorRules()
		{
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x0007E02C File Offset: 0x0007C22C
		public bool IsValidValue(out object convertedValue)
		{
			if (this.Validator != null)
			{
				return this.Validator.IsValidObject(this.Text, out convertedValue);
			}
			convertedValue = this.Text;
			return true;
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06002438 RID: 9272 RVA: 0x0007E06C File Offset: 0x0007C26C
		// (set) Token: 0x06002439 RID: 9273 RVA: 0x0007E098 File Offset: 0x0007C298
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

		// Token: 0x04000CC0 RID: 3264
		private bool mFormatValue;

		// Token: 0x04000CC1 RID: 3265
		private global::DevAge.ComponentModel.Validator.IValidator mValidator;
	}
}
