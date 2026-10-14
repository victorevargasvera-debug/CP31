using System;
using System.Runtime.CompilerServices;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.UI.CellRangeFill;
using Motorola.CommonCPS.UI.CellRangeFill.UndoRedo;
using Motorola.CommonCPS.UI.CellRangeSelect;

namespace Motorola.CommonCPS.RadioManagement.ASTRODataProfile
{
	// Token: 0x02000007 RID: 7
	internal class c : global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.SetCellValueTask
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002DDC File Offset: 0x00000FDC
		public c(global::Infragistics.Windows.DataPresenter.DataRecordCollection A_0, global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition A_1, global::Motorola.CommonCPS.UI.CellRangeFill.ICellValueSetter A_2, object A_3, global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation A_4, global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange A_5, bool A_6) : base(A_0, A_1, A_2, A_3, A_4, A_5, A_6)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile a()
		{
			short num = (short)308406813;
			short num2 = num;
			num = (short)324397597;
			switch (num2 == num)
			{
			}
			num = (short)630521856;
			if (num != 0)
			{
			}
			num = (short)871759872;
			short num3 = num;
			num = (short)1647968257;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002EA4 File Offset: 0x000010A4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile A_0)
		{
			short num = (short)388605510;
			short num2 = num;
			num = (short)1637525062;
			switch (num2 == num)
			{
			}
			num = (short)1942028288;
			if (num != 0)
			{
			}
			num = (short)1289027584;
			short num3 = num;
			num = (short)1212940289;
			if (num != 0)
			{
			}
			this.a = A_0;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002F54 File Offset: 0x00001154
		public override void Do()
		{
			short num = (short)948272000;
			short num2 = num;
			num = (short)1888844672;
			switch (num2 == num)
			{
			}
			num = (short)242024448;
			if (num != 0)
			{
			}
			num = (short)902234112;
			short num3 = num;
			num = (short)725024769;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile source = (global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)base.GetTargetCell().Record.DataItem;
			this.a(new global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile());
			this.a().CopyFrom(source);
			base.Do();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000302C File Offset: 0x0000122C
		public override void Undo()
		{
			short num = (short)1451917566;
			short num2 = num;
			num = (short)765755646;
			switch (num2 == num)
			{
			}
			num = (short)405471233;
			if (num != 0)
			{
			}
			num = (short)372572160;
			short num3 = num;
			num = (short)1409679360;
			if (num != 0)
			{
			}
			((global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)base.GetTargetCell().Record.DataItem).CopyFrom(this.a());
		}

		// Token: 0x04000003 RID: 3
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile a;
	}
}
