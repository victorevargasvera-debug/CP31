using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevAge.ComponentModel.Validator;

namespace DevAge.Windows.Forms
{
	// Token: 0x020002CA RID: 714
	internal class DevAgeTextBoxButton : global::DevAge.Windows.Forms.EditableControlBase
	{
		// Token: 0x060022F0 RID: 8944 RVA: 0x0007AC50 File Offset: 0x00078E50
		public DevAgeTextBoxButton()
		{
			this.InitializeComponent();
			this.btDown.BackColor = global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.Control);
			this.txtBox.TextChanged += this.txtBox_TextChanged;
			base.SetContentAndButtonLocation(this.txtBox, this.btDown);
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x0007ACA8 File Offset: 0x00078EA8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x0007ACD0 File Offset: 0x00078ED0
		private void InitializeComponent()
		{
			this.btDown = new global::System.Windows.Forms.Button();
			this.txtBox = new global::DevAge.Windows.Forms.DevAgeTextBox();
			base.SuspendLayout();
			this.btDown.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btDown.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.btDown.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btDown.Location = new global::System.Drawing.Point(134, 2);
			this.btDown.Name = "btDown";
			this.btDown.Size = new global::System.Drawing.Size(24, 16);
			this.btDown.TabIndex = 1;
			this.btDown.Text = "...";
			this.btDown.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.btDown.Click += this.btDown_Click;
			this.txtBox.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtBox.AutoSize = false;
			this.txtBox.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.txtBox.HideSelection = false;
			this.txtBox.Location = new global::System.Drawing.Point(2, 2);
			this.txtBox.Name = "txtBox";
			this.txtBox.Size = new global::System.Drawing.Size(132, 16);
			this.txtBox.TabIndex = 0;
			this.txtBox.WordWrap = false;
			base.BackColor = global::System.Drawing.Color.Transparent;
			base.Controls.Add(this.txtBox);
			base.Controls.Add(this.btDown);
			base.Name = "TextBoxTypedButton";
			base.Size = new global::System.Drawing.Size(160, 20);
			base.ResumeLayout(false);
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x0007AE84 File Offset: 0x00079084
		// (set) Token: 0x060022F4 RID: 8948 RVA: 0x0007AE8C File Offset: 0x0007908C
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

		// Token: 0x060022F5 RID: 8949 RVA: 0x0007AEF0 File Offset: 0x000790F0
		private void mValidator_Changed(object sender, global::System.EventArgs e)
		{
			this.ApplyValidatorRules();
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x0007AEF8 File Offset: 0x000790F8
		protected virtual void ApplyValidatorRules()
		{
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x0007AEFC File Offset: 0x000790FC
		public virtual void ShowDialog()
		{
			this.OnDialogOpen(global::System.EventArgs.Empty);
			this.OnDialogClosed(global::System.EventArgs.Empty);
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x0007AF14 File Offset: 0x00079114
		private void btDown_Click(object sender, global::System.EventArgs e)
		{
			this.ShowDialog();
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x060022F9 RID: 8953 RVA: 0x0007AF1C File Offset: 0x0007911C
		public global::System.Windows.Forms.Button Button
		{
			get
			{
				return this.btDown;
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x060022FA RID: 8954 RVA: 0x0007AF24 File Offset: 0x00079124
		public global::System.Windows.Forms.TextBox TextBox
		{
			get
			{
				return this.txtBox;
			}
		}

		// Token: 0x14000098 RID: 152
		// (add) Token: 0x060022FB RID: 8955 RVA: 0x0007AF2C File Offset: 0x0007912C
		// (remove) Token: 0x060022FC RID: 8956 RVA: 0x0007AF48 File Offset: 0x00079148
		public event global::System.EventHandler DialogOpen;

		// Token: 0x060022FD RID: 8957 RVA: 0x0007AF64 File Offset: 0x00079164
		protected virtual void OnDialogOpen(global::System.EventArgs e)
		{
			if (this.DialogOpen != null)
			{
				this.DialogOpen(this, e);
			}
		}

		// Token: 0x14000099 RID: 153
		// (add) Token: 0x060022FE RID: 8958 RVA: 0x0007AF80 File Offset: 0x00079180
		// (remove) Token: 0x060022FF RID: 8959 RVA: 0x0007AF9C File Offset: 0x0007919C
		public event global::System.EventHandler DialogClosed;

		// Token: 0x06002300 RID: 8960 RVA: 0x0007AFB8 File Offset: 0x000791B8
		protected virtual void OnDialogClosed(global::System.EventArgs e)
		{
			if (this.DialogClosed != null)
			{
				this.DialogClosed(this, e);
			}
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x0007AFD4 File Offset: 0x000791D4
		protected override void OnBorderStyleChanged(global::System.EventArgs e)
		{
			base.OnBorderStyleChanged(e);
			base.SetContentAndButtonLocation(this.txtBox, this.btDown);
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x0007AFF0 File Offset: 0x000791F0
		protected override void OnBackColorChanged(global::System.EventArgs e)
		{
			base.OnBackColorChanged(e);
			if (this.txtBox != null)
			{
				if (base.BackColor == global::System.Drawing.Color.Transparent)
				{
					this.txtBox.BackColor = global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.Window);
					return;
				}
				this.txtBox.BackColor = base.BackColor;
			}
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x0007B04C File Offset: 0x0007924C
		protected override void OnForeColorChanged(global::System.EventArgs e)
		{
			base.OnForeColorChanged(e);
			if (this.txtBox != null)
			{
				this.txtBox.ForeColor = this.ForeColor;
			}
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x0007B074 File Offset: 0x00079274
		protected override void OnValidating(global::System.ComponentModel.CancelEventArgs e)
		{
			base.OnValidating(e);
			object obj;
			if (!this.IsValidValue(out obj))
			{
				e.Cancel = true;
			}
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x0007B0A0 File Offset: 0x000792A0
		public bool IsValidValue(out object convertedValue)
		{
			if (this.Validator == null)
			{
				convertedValue = this.txtBox.Text;
				return true;
			}
			if (this.mValue != null)
			{
				convertedValue = this.mValue;
				return true;
			}
			if (this.Validator.IsValidObject(this.TextBox.Text, out this.mValue))
			{
				convertedValue = this.mValue;
				return true;
			}
			convertedValue = null;
			return false;
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06002306 RID: 8966 RVA: 0x0007B110 File Offset: 0x00079310
		// (set) Token: 0x06002307 RID: 8967 RVA: 0x0007B13C File Offset: 0x0007933C
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
					if (this.Validator.IsStringConversionSupported())
					{
						this.TextBox.Text = this.Validator.ValueToString(value);
					}
					else
					{
						this.TextBox.Text = this.Validator.ValueToDisplayString(value);
					}
				}
				else if (value == null)
				{
					this.TextBox.Text = "";
				}
				else
				{
					this.TextBox.Text = value.ToString();
				}
				this.mValue = value;
			}
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x0007B1D4 File Offset: 0x000793D4
		private void txtBox_TextChanged(object sender, global::System.EventArgs e)
		{
			this.mValue = null;
		}

		// Token: 0x04000C84 RID: 3204
		private global::System.Windows.Forms.Button btDown;

		// Token: 0x04000C85 RID: 3205
		private global::System.Windows.Forms.TextBox txtBox;

		// Token: 0x04000C86 RID: 3206
		private global::System.ComponentModel.Container components;

		// Token: 0x04000C87 RID: 3207
		private global::DevAge.ComponentModel.Validator.IValidator mValidator;

		// Token: 0x04000C8A RID: 3210
		private object mValue;
	}
}
