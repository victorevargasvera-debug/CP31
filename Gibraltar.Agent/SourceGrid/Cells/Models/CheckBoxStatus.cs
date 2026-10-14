using System;
using DevAge.Drawing;

namespace SourceGrid.Cells.Models
{
	// Token: 0x020003EE RID: 1006
	internal struct CheckBoxStatus
	{
		// Token: 0x06002CBF RID: 11455 RVA: 0x00096670 File Offset: 0x00094870
		public CheckBoxStatus(bool checkEnable, bool? bChecked, string caption)
		{
			this.CheckEnable = checkEnable;
			this.Caption = caption;
			this.mCheckState = global::DevAge.Drawing.CheckBoxState.Undefined;
			this.Checked = bChecked;
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x00096690 File Offset: 0x00094890
		public CheckBoxStatus(bool checkEnable, global::DevAge.Drawing.CheckBoxState checkState, string caption)
		{
			this.CheckEnable = checkEnable;
			this.mCheckState = checkState;
			this.Caption = caption;
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06002CC1 RID: 11457 RVA: 0x000966A8 File Offset: 0x000948A8
		// (set) Token: 0x06002CC2 RID: 11458 RVA: 0x000966B0 File Offset: 0x000948B0
		public global::DevAge.Drawing.CheckBoxState CheckState
		{
			get
			{
				return this.mCheckState;
			}
			set
			{
				this.mCheckState = value;
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06002CC3 RID: 11459 RVA: 0x000966BC File Offset: 0x000948BC
		// (set) Token: 0x06002CC4 RID: 11460 RVA: 0x000966FC File Offset: 0x000948FC
		public bool? Checked
		{
			get
			{
				if (this.CheckState == global::DevAge.Drawing.CheckBoxState.Checked)
				{
					return new bool?(true);
				}
				if (this.CheckState == global::DevAge.Drawing.CheckBoxState.Unchecked)
				{
					return new bool?(false);
				}
				return null;
			}
			set
			{
				if (value == null)
				{
					this.CheckState = global::DevAge.Drawing.CheckBoxState.Undefined;
					return;
				}
				if (value.Value)
				{
					this.CheckState = global::DevAge.Drawing.CheckBoxState.Checked;
					return;
				}
				this.CheckState = global::DevAge.Drawing.CheckBoxState.Unchecked;
			}
		}

		// Token: 0x04000F2E RID: 3886
		private global::DevAge.Drawing.CheckBoxState mCheckState;

		// Token: 0x04000F2F RID: 3887
		public bool CheckEnable;

		// Token: 0x04000F30 RID: 3888
		public string Caption;
	}
}
