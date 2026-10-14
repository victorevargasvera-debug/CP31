using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x02000305 RID: 773
	[global::System.Serializable]
	internal class CheckBoxThemed : global::DevAge.Drawing.VisualElements.CheckBoxBase
	{
		// Token: 0x060024D5 RID: 9429 RVA: 0x000805F4 File Offset: 0x0007E7F4
		public CheckBoxThemed()
		{
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x00080608 File Offset: 0x0007E808
		public CheckBoxThemed(global::DevAge.Drawing.VisualElements.CheckBoxThemed other) : base(other)
		{
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x0008061C File Offset: 0x0007E81C
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.CheckBoxThemed(this);
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x060024D8 RID: 9432 RVA: 0x00080624 File Offset: 0x0007E824
		// (set) Token: 0x060024D9 RID: 9433 RVA: 0x0008062C File Offset: 0x0007E82C
		public override global::DevAge.Drawing.ControlDrawStyle Style
		{
			get
			{
				return base.Style;
			}
			set
			{
				base.Style = value;
				this.mStandardCheckBox.Style = value;
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x060024DA RID: 9434 RVA: 0x00080644 File Offset: 0x0007E844
		// (set) Token: 0x060024DB RID: 9435 RVA: 0x0008064C File Offset: 0x0007E84C
		public override global::DevAge.Drawing.CheckBoxState CheckBoxState
		{
			get
			{
				return base.CheckBoxState;
			}
			set
			{
				base.CheckBoxState = value;
				this.mStandardCheckBox.CheckBoxState = value;
			}
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x00080664 File Offset: 0x0007E864
		protected global::System.Windows.Forms.VisualStyles.VisualStyleElement GetBackgroundElement()
		{
			if (this.Style == global::DevAge.Drawing.ControlDrawStyle.Hot)
			{
				if (this.CheckBoxState == global::DevAge.Drawing.CheckBoxState.Checked)
				{
					return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Button.CheckBox.CheckedHot;
				}
				if (this.CheckBoxState == global::DevAge.Drawing.CheckBoxState.Unchecked)
				{
					return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Button.CheckBox.UncheckedHot;
				}
				return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Button.CheckBox.MixedHot;
			}
			else if (this.Style == global::DevAge.Drawing.ControlDrawStyle.Pressed)
			{
				if (this.CheckBoxState == global::DevAge.Drawing.CheckBoxState.Checked)
				{
					return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Button.CheckBox.CheckedPressed;
				}
				if (this.CheckBoxState == global::DevAge.Drawing.CheckBoxState.Unchecked)
				{
					return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Button.CheckBox.UncheckedPressed;
				}
				return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Button.CheckBox.MixedPressed;
			}
			else if (this.Style == global::DevAge.Drawing.ControlDrawStyle.Disabled)
			{
				if (this.CheckBoxState == global::DevAge.Drawing.CheckBoxState.Checked)
				{
					return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Button.CheckBox.CheckedDisabled;
				}
				if (this.CheckBoxState == global::DevAge.Drawing.CheckBoxState.Unchecked)
				{
					return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Button.CheckBox.UncheckedDisabled;
				}
				return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Button.CheckBox.MixedDisabled;
			}
			else
			{
				if (this.CheckBoxState == global::DevAge.Drawing.CheckBoxState.Checked)
				{
					return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Button.CheckBox.CheckedNormal;
				}
				if (this.CheckBoxState == global::DevAge.Drawing.CheckBoxState.Unchecked)
				{
					return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Button.CheckBox.UncheckedNormal;
				}
				return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Button.CheckBox.MixedNormal;
			}
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x00080740 File Offset: 0x0007E940
		protected global::System.Windows.Forms.VisualStyles.VisualStyleRenderer GetRenderer(global::System.Windows.Forms.VisualStyles.VisualStyleElement element)
		{
			return new global::System.Windows.Forms.VisualStyles.VisualStyleRenderer(element);
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x00080748 File Offset: 0x0007E948
		protected override void OnDraw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			if (global::System.Windows.Forms.Application.RenderWithVisualStyles && global::System.Windows.Forms.VisualStyles.VisualStyleRenderer.IsElementDefined(this.GetBackgroundElement()))
			{
				this.GetRenderer(this.GetBackgroundElement()).DrawBackground(graphics.Graphics, global::System.Drawing.Rectangle.Round(area));
				return;
			}
			this.mStandardCheckBox.Draw(graphics, area);
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x000807A0 File Offset: 0x0007E9A0
		protected override global::System.Drawing.SizeF OnMeasureContent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF maxSize)
		{
			if (global::System.Windows.Forms.Application.RenderWithVisualStyles && global::System.Windows.Forms.VisualStyles.VisualStyleRenderer.IsElementDefined(this.GetBackgroundElement()))
			{
				return this.GetRenderer(this.GetBackgroundElement()).GetPartSize(measure.Graphics, global::System.Windows.Forms.VisualStyles.ThemeSizeType.True);
			}
			return this.mStandardCheckBox.Measure(measure, global::System.Drawing.Size.Empty, maxSize);
		}

		// Token: 0x04000CE1 RID: 3297
		private global::DevAge.Drawing.VisualElements.CheckBox mStandardCheckBox = new global::DevAge.Drawing.VisualElements.CheckBox();
	}
}
