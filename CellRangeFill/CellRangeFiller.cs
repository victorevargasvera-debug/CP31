using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.UI.CellRangeFill.Constraints;
using Motorola.CommonCPS.UI.CellRangeSelect;

namespace Motorola.CommonCPS.UI.CellRangeFill
{
	// Token: 0x02000004 RID: 4
	public abstract class CellRangeFiller : global::Motorola.CommonCPS.UI.CellRangeFill.ICellRangeFiller
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002600 File Offset: 0x00000800
		protected CellRangeFiller(global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation operation) : this(null, operation)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002618 File Offset: 0x00000818
		protected CellRangeFiller(string name, global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation operation) : this(name, operation, global::Motorola.CommonCPS.UI.CellRangeFill.FillErrorAction.Abort, false)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002630 File Offset: 0x00000830
		protected CellRangeFiller(string name, global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation operation, global::Motorola.CommonCPS.UI.CellRangeFill.FillErrorAction errorAction, bool autoCorrect)
		{
			int a_ = 4;
			base..ctor();
			this.a = (string.IsNullOrEmpty(name) ? this.a(operation) : name);
			if (!global::System.Enum.IsDefined(typeof(global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation), operation))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("꓊뷌꫎ꏐ닒ꇔ뻖뛘뗚", a_), (int)operation, typeof(global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation));
			}
			this.b = operation;
			this.c = errorAction;
			this.AutoCorrect = autoCorrect;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000026B8 File Offset: 0x000008B8
		private string a(global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation A_0)
		{
			short num = (short)186157532;
			short num2 = num;
			num = (short)643729884;
			switch (num2 == num)
			{
			}
			num = (short)354025472;
			short num3 = num;
			num = (short)34471937;
			if (num != 0)
			{
			}
			num = (short)475004928;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.UI.CellRangeFill.DescriptionAttributeHelper.GetDescription(A_0);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002770 File Offset: 0x00000970
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002820 File Offset: 0x00000A20
		public bool AutoCorrect
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1781792769;
				if (num != 0)
				{
				}
				num = (short)1982227459;
				short num2 = num;
				num = (short)1066820611;
				switch (num2 == num)
				{
				default:
				{
					num = (short)790953984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1304952832;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1967521793;
				if (num != 0)
				{
				}
				num = (short)1614037286;
				short num2 = num;
				num = (short)153174310;
				switch (num2 == num)
				{
				default:
				{
					num = (short)675348480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)300351488;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000028D0 File Offset: 0x00000AD0
		public global::Motorola.CommonCPS.UI.CellRangeFill.FillErrorAction ErrorAction
		{
			get
			{
				short num = (short)391614675;
				short num2 = num;
				num = (short)1864863955;
				switch (num2 == num)
				{
				}
				num = (short)1544749056;
				short num3 = num;
				num = (short)1648164865;
				if (num != 0)
				{
				}
				num = (short)711852032;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002980 File Offset: 0x00000B80
		public string Name
		{
			get
			{
				short num = (short)528337901;
				short num2 = num;
				num = (short)984992749;
				switch (num2 == num)
				{
				}
				num = (short)1656946688;
				short num3 = num;
				num = (short)1300758529;
				if (num != 0)
				{
				}
				num = (short)30998528;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002A2C File Offset: 0x00000C2C
		public global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation Operation
		{
			get
			{
				short num = (short)1322852154;
				short num2 = num;
				num = (short)1558716218;
				switch (num2 == num)
				{
				}
				num = (short)927072256;
				short num3 = num;
				num = (short)1294336000;
				if (num != 0)
				{
				}
				num = (short)279314433;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002ADC File Offset: 0x00000CDC
		public bool CanExecute(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillParameter parameter)
		{
			short num = (short)1283784714;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return false;
				case 1:
				{
					global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange range;
					if (!range.IsSingleColumnRange)
					{
						num = (short)1051590656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1608777736;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					return false;
				case 3:
					goto IL_12A;
				case 4:
				{
					global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange range;
					if (range.EndRow > parameter.Records.Count)
					{
						num = (short)612106249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					range = parameter.Range;
					num = (short)1447559173;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
				{
					global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange range;
					if (range.EndColumn > parameter.Records.FieldLayout.Fields.Count)
					{
						num = (short)158072834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 6:
					return false;
				case 7:
				{
					global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange range;
					if (!range.IsNormalized)
					{
						num = (short)905379840;
						short num3 = num;
						num = (short)1695612934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					range = parameter.Range;
					num = (short)122421249;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
				{
					if (parameter.Records.Count == 0)
					{
						num = (short)687407107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1462304769;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange range = parameter.Range;
					num = (short)777453572;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					return false;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				case 11:
					return false;
				}
				IL_54:
				if (parameter == null)
				{
					num = (short)2106064907;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange range = parameter.Range;
					num = (short)1197015047;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return false;
			IL_12A:
			num = (short)144260452;
			short num4 = num;
			num = (short)619855204;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return false;
			default:
				num = (short)1208090624;
				if (num != 0)
				{
				}
				return false;
			}
			return false;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002D7C File Offset: 0x00000F7C
		public void Execute(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillParameter parameter)
		{
			short num = (short)613941254;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1899757570;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1452408837;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					global::Motorola.CommonCPS.UI.CellRangeFill.FillDirection direction;
					if (direction != global::Motorola.CommonCPS.UI.CellRangeFill.FillDirection.Down)
					{
						num = (short)1747189761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11C;
				}
				case 3:
				{
					global::Motorola.CommonCPS.UI.CellRangeFill.FillDirection direction;
					if (direction != global::Motorola.CommonCPS.UI.CellRangeFill.FillDirection.Up)
					{
						num = (short)1132593152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B4;
				}
				case 4:
					goto IL_B2;
				case 5:
					goto IL_1A0;
				case 6:
					num = (short)445251585;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_68;
					}
					continue;
				}
				IL_68:
				num = (short)1181351936;
				short num3 = num;
				if (!this.CanExecute(parameter))
				{
					num = (short)2079588356;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::Motorola.CommonCPS.UI.CellRangeFill.FillDirection direction = parameter.Direction;
					num = (short)2055667715;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_B2:
			throw new global::System.InvalidOperationException();
			IL_B4:
			this.DoFillUp(parameter.Records, parameter.Range, parameter.Setter, parameter.Constraint, parameter.SetCellValueTaskType, parameter.SelectionIndexes);
			return;
			IL_11C:
			this.DoFillDown(parameter.Records, parameter.Range, parameter.Setter, parameter.Constraint, parameter.SetCellValueTaskType, parameter.SelectionIndexes);
			return;
			IL_1A0:
			num = (short)1622074918;
			short num4 = num;
			num = (short)1017439782;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_B4;
			default:
				num = (short)473563136;
				if (num != 0)
				{
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002F7C File Offset: 0x0000117C
		protected void DoFillUp(global::Infragistics.Windows.DataPresenter.DataRecordCollection records, global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange range, global::Motorola.CommonCPS.UI.CellRangeFill.ICellValueSetter setter, global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint constraint, global::System.Type setCellValueTaskType, global::System.Collections.Generic.List<int> indexList = null)
		{
			short num = (short)817643181;
			short num2 = num;
			num = (short)1993686701;
			switch (num2 == num)
			{
			}
			num = (short)721158144;
			short num3 = num;
			num = (short)759889921;
			if (num != 0)
			{
			}
			num = (short)1992097792;
			if (num != 0)
			{
			}
			global::Infragistics.Windows.DataPresenter.Cell cell = records[range.EndRow].Cells[range.EndColumn];
			global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition> rangeIterator = range.Reverse(range.StartRow, range.EndRow - 1, indexList);
			this.DoFillCore(records, range, rangeIterator, cell.Value, setter, constraint, setCellValueTaskType);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003074 File Offset: 0x00001274
		protected void DoFillDown(global::Infragistics.Windows.DataPresenter.DataRecordCollection records, global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange range, global::Motorola.CommonCPS.UI.CellRangeFill.ICellValueSetter setter, global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint constraint, global::System.Type setCellValueTaskType, global::System.Collections.Generic.List<int> indexList = null)
		{
			short num = (short)898545111;
			short num2 = num;
			num = (short)740537815;
			switch (num2 == num)
			{
			}
			num = (short)1439825920;
			short num3 = num;
			num = (short)22347777;
			if (num != 0)
			{
			}
			num = (short)263913472;
			if (num != 0)
			{
			}
			global::Infragistics.Windows.DataPresenter.Cell cell = records[range.StartRow].Cells[range.StartColumn];
			global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition> rangeIterator = range.Forward(range.StartRow + 1, range.EndRow, indexList);
			this.DoFillCore(records, range, rangeIterator, cell.Value, setter, constraint, setCellValueTaskType);
		}

		// Token: 0x06000014 RID: 20
		protected abstract void DoFillCore(global::Infragistics.Windows.DataPresenter.DataRecordCollection records, global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange range, global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition> rangeIterator, object value, global::Motorola.CommonCPS.UI.CellRangeFill.ICellValueSetter setter, global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint constraint, global::System.Type setCellValueTaskType);

		// Token: 0x04000003 RID: 3
		private readonly string a;

		// Token: 0x04000004 RID: 4
		private readonly global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation b;

		// Token: 0x04000005 RID: 5
		private readonly global::Motorola.CommonCPS.UI.CellRangeFill.FillErrorAction c;

		// Token: 0x04000006 RID: 6
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool d;
	}
}
