using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SourceGrid.Cells.Editors
{
	// Token: 0x020003E7 RID: 999
	[global::System.ComponentModel.ToolboxItem(false)]
	internal class NumericUpDown : global::SourceGrid.Cells.Editors.EditorControlBase
	{
		// Token: 0x06002C97 RID: 11415 RVA: 0x00095F8C File Offset: 0x0009418C
		public NumericUpDown() : base(typeof(decimal))
		{
		}

		// Token: 0x06002C98 RID: 11416 RVA: 0x00095FA0 File Offset: 0x000941A0
		public NumericUpDown(global::System.Type p_CellType, decimal p_Maximum, decimal p_Minimum, decimal p_Increment) : base(p_CellType)
		{
			if (p_CellType == null || p_CellType == typeof(int) || p_CellType == typeof(long) || p_CellType == typeof(decimal))
			{
				this.Control.Maximum = p_Maximum;
				this.Control.Minimum = p_Minimum;
				this.Control.Increment = p_Increment;
				return;
			}
			throw new global::SourceGrid.SourceGridException("Invalid CellType expected long, int or decimal");
		}

		// Token: 0x06002C99 RID: 11417 RVA: 0x00096020 File Offset: 0x00094220
		protected override global::System.Windows.Forms.Control CreateControl()
		{
			return new global::System.Windows.Forms.NumericUpDown
			{
				BorderStyle = global::System.Windows.Forms.BorderStyle.None
			};
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06002C9A RID: 11418 RVA: 0x00096040 File Offset: 0x00094240
		public new global::System.Windows.Forms.NumericUpDown Control
		{
			get
			{
				return (global::System.Windows.Forms.NumericUpDown)base.Control;
			}
		}

		// Token: 0x06002C9B RID: 11419 RVA: 0x00096050 File Offset: 0x00094250
		public override void SetEditValue(object editValue)
		{
			decimal value;
			if (editValue is decimal)
			{
				value = (decimal)editValue;
			}
			else if (editValue is long)
			{
				value = (long)editValue;
			}
			else if (editValue is int)
			{
				value = (int)editValue;
			}
			else
			{
				if (editValue != null)
				{
					throw new global::SourceGrid.SourceGridException("Invalid value, expected Decimal, Int or Long");
				}
				value = this.Control.Minimum;
			}
			decimal value2 = this.Control.Value;
			this.Control.Value = value;
		}

		// Token: 0x06002C9C RID: 11420 RVA: 0x000960EC File Offset: 0x000942EC
		public override object GetEditedValue()
		{
			if (base.ValueType == null)
			{
				return this.Control.Value;
			}
			if (base.ValueType == typeof(decimal))
			{
				return this.Control.Value;
			}
			if (base.ValueType == typeof(int))
			{
				return (int)this.Control.Value;
			}
			if (base.ValueType == typeof(long))
			{
				return (long)this.Control.Value;
			}
			throw new global::SourceGrid.SourceGridException("Invalid type of the cell expected decimal, long or int");
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x000961A0 File Offset: 0x000943A0
		protected override void OnSendCharToEditor(char key)
		{
		}
	}
}
