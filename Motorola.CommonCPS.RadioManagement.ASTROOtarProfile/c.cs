using System;
using System.Runtime.CompilerServices;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.UI.CellRangeFill;
using Motorola.CommonCPS.UI.CellRangeFill.UndoRedo;
using Motorola.CommonCPS.UI.CellRangeSelect;

namespace Motorola.CommonCPS.RadioManagement.ASTROOtarProfile
{
	// Token: 0x02000007 RID: 7
	internal class c : global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.SetCellValueTask
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002AA8 File Offset: 0x00000CA8
		public c(global::Infragistics.Windows.DataPresenter.DataRecordCollection A_0, global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition A_1, global::Motorola.CommonCPS.UI.CellRangeFill.ICellValueSetter A_2, object A_3, global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation A_4, global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange A_5, bool A_6) : base(A_0, A_1, A_2, A_3, A_4, A_5, A_6)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002ABC File Offset: 0x00000CBC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile a()
		{
			short num = (short)59441153;
			if (num != 0)
			{
			}
			num = (short)1507489139;
			short num2 = num;
			num = (short)1371895155;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1782710272;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1387986944;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002B6C File Offset: 0x00000D6C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile A_0)
		{
			short num = (short)1682906453;
			short num2 = num;
			num = (short)222960981;
			switch (num2 == num)
			{
			}
			num = (short)1738080256;
			short num3 = num;
			num = (short)1365180417;
			if (num != 0)
			{
			}
			num = (short)1108148224;
			if (num != 0)
			{
			}
			this.a = A_0;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002C1C File Offset: 0x00000E1C
		public override void Do()
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_9F;
			}
			short num;
			int num4;
			global::Infragistics.Windows.DataPresenter.Cell targetCell;
			for (;;)
			{
				IL_13:
				num = (short)1213869819;
				short num2 = num;
				num = (short)317271803;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)43515904;
					if (num != 0)
					{
					}
					num = (short)1297809408;
					short num3 = num;
					switch (num4)
					{
					case 0:
						goto IL_180;
					case 1:
						goto IL_1B6;
					case 2:
						if (!base.AutoCorrect)
						{
							num = (short)1760100353;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						num = (short)314048513;
						if (num != 0)
						{
						}
						if (!base.Setter.AreValuesEqual(targetCell, base.NewValue))
						{
							num = (short)1476788224;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_9F;
				}
				}
				IL_180:
				num = (short)943521794;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_1B6:
			throw new global::Motorola.CommonCPS.UI.CellRangeFill.FillOperationException(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("œ㡕㥗㡙せ㭝䁟ᙡୣ䙥᭧ཀྵᡫ乭፯᝱ᡳ᩵塷౹ᵻች", a_), base.Operation, base.Range, base.Position);
			IL_9F:
			targetCell = base.GetTargetCell();
			global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile source = (global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile)targetCell.Record.DataItem;
			this.a(new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile());
			this.a().CopyFrom(source);
			base.OldValue = targetCell.Value;
			base.Setter.SetValue(targetCell, base.NewValue, false, false, false);
			num = (short)886439939;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002DE4 File Offset: 0x00000FE4
		public override void Undo()
		{
			short num = (short)628895289;
			short num2 = num;
			num = (short)26357305;
			switch (num2 == num)
			{
			}
			num = (short)1552154624;
			short num3 = num;
			num = (short)520028160;
			if (num != 0)
			{
			}
			num = (short)1326514177;
			if (num != 0)
			{
			}
			((global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile)base.GetTargetCell().Record.DataItem).CopyFrom(this.a());
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002EB4 File Offset: 0x000010B4
		public override void Commit()
		{
			short num = (short)1740408480;
			short num2 = num;
			num = (short)732137120;
			switch (num2 == num)
			{
			}
			num = (short)1634861056;
			short num3 = num;
			num = (short)994574336;
			if (num != 0)
			{
			}
			num = (short)790822913;
			if (num != 0)
			{
			}
			global::Infragistics.Windows.DataPresenter.Cell targetCell = base.GetTargetCell();
			base.Setter.SetValue(targetCell, base.NewValue, true, true, true);
		}

		// Token: 0x04000003 RID: 3
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile a;
	}
}
