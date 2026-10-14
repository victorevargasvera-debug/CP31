using System;
using System.Runtime.Serialization;
using Motorola.CommonCPS.UI.CellRangeFill.Constraints;
using Motorola.CommonCPS.UI.CellRangeSelect;

namespace Motorola.CommonCPS.UI.CellRangeFill
{
	// Token: 0x0200001C RID: 28
	[global::System.Serializable]
	public class FillOperationException : global::System.Exception
	{
		// Token: 0x0600009C RID: 156 RVA: 0x0000A6C0 File Offset: 0x000088C0
		public FillOperationException(string message, global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation operation, global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange range, global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition position) : this(message, operation, range, position, null)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000A6DC File Offset: 0x000088DC
		public FillOperationException(string message, global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation operation, global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange range, global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition position, global::System.Exception innerException) : base(message, innerException)
		{
			this.operation = operation;
			this.range = range;
			this.position = position;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0000A708 File Offset: 0x00008908
		public global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation Operation
		{
			get
			{
				short num = (short)2085664133;
				short num2 = num;
				num = (short)724481413;
				switch (num2 == num)
				{
				}
				num = (short)1539309568;
				short num3 = num;
				num = (short)80609281;
				if (num != 0)
				{
				}
				num = (short)1960902656;
				if (num != 0)
				{
				}
				return this.operation;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0000A7B8 File Offset: 0x000089B8
		public global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange Range
		{
			get
			{
				short num = (short)989247956;
				short num2 = num;
				num = (short)1318894036;
				switch (num2 == num)
				{
				}
				num = (short)2129854464;
				short num3 = num;
				num = (short)1757806593;
				if (num != 0)
				{
				}
				num = (short)1456865280;
				if (num != 0)
				{
				}
				return this.range;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000A864 File Offset: 0x00008A64
		public global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition Position
		{
			get
			{
				short num = (short)488126531;
				short num2 = num;
				num = (short)1287206979;
				switch (num2 == num)
				{
				}
				num = (short)403046400;
				short num3 = num;
				num = (short)2135621632;
				if (num != 0)
				{
				}
				num = (short)229834753;
				if (num != 0)
				{
				}
				return this.position;
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000A914 File Offset: 0x00008B14
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 5;
			short num = (short)491293578;
			short num2 = num;
			num = (short)1071090570;
			switch (num2 == num)
			{
			}
			num = (short)221642752;
			short num3 = num;
			num = (short)1723924481;
			if (num != 0)
			{
			}
			num = (short)1596325888;
			if (num != 0)
			{
			}
			info.AddValue(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("請ꟍ볏뻑鯓ꛕ뷗꣙뷛ꫝ觟跡諣", a_), this.operation);
			info.AddValue(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("迋ꯍ볏뻑蛓럕뛗뷙맛", a_), this.range);
			info.AddValue(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("迋ꯍ볏뻑蓓맕ꯗ동꣛럝迟賡", a_), this.position);
			base.GetObjectData(info, context);
		}

		// Token: 0x0400003F RID: 63
		private global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation operation;

		// Token: 0x04000040 RID: 64
		private global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange range;

		// Token: 0x04000041 RID: 65
		private global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition position;
	}
}
