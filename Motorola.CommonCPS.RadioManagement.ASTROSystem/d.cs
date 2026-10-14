using System;
using System.Runtime.CompilerServices;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.UI.CellRangeFill;
using Motorola.CommonCPS.UI.CellRangeFill.UndoRedo;
using Motorola.CommonCPS.UI.CellRangeSelect;

namespace Motorola.CommonCPS.RadioManagement.ASTROSystem
{
	// Token: 0x02000007 RID: 7
	internal class d : global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.SetCellValueTask
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000029B0 File Offset: 0x00000BB0
		public d(global::Infragistics.Windows.DataPresenter.DataRecordCollection A_0, global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition A_1, global::Motorola.CommonCPS.UI.CellRangeFill.ICellValueSetter A_2, object A_3, global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation A_4, global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange A_5, bool A_6) : base(A_0, A_1, A_2, A_3, A_4, A_5, A_6)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000029C4 File Offset: 0x00000BC4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem a()
		{
			short num = (short)521599622;
			short num2 = num;
			num = (short)986905222;
			switch (num2 == num)
			{
			}
			num = (short)1400307713;
			if (num != 0)
			{
			}
			num = (short)1330839552;
			short num3 = num;
			num = (short)776077312;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002A70 File Offset: 0x00000C70
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem A_0)
		{
			short num = (short)158190776;
			short num2 = num;
			num = (short)1143262392;
			switch (num2 == num)
			{
			}
			num = (short)846266369;
			if (num != 0)
			{
			}
			num = (short)2131689472;
			short num3 = num;
			num = (short)526778368;
			if (num != 0)
			{
			}
			this.a = A_0;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002B20 File Offset: 0x00000D20
		public override void Do()
		{
			short num = (short)626889683;
			short num2 = num;
			num = (short)1498780627;
			switch (num2 == num)
			{
			}
			num = (short)55836672;
			if (num != 0)
			{
			}
			num = (short)214499328;
			short num3 = num;
			num = (short)1546059777;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem source = (global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)base.GetTargetCell().Record.DataItem;
			this.a(new global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem());
			this.a().CopyFrom(source);
			base.Do();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002BFC File Offset: 0x00000DFC
		public override void Undo()
		{
			short num = (short)1017120915;
			short num2 = num;
			num = (short)2107771027;
			switch (num2 == num)
			{
			}
			num = (short)1543045121;
			if (num != 0)
			{
			}
			num = (short)929169408;
			short num3 = num;
			num = (short)1270022144;
			if (num != 0)
			{
			}
			((global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)base.GetTargetCell().Record.DataItem).CopyFrom(this.a());
		}

		// Token: 0x04000003 RID: 3
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem a;
	}
}
