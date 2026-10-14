using System;
using AcpCommonResources;
using AcpUtility;

namespace AcpBusinessLayer.UndoRedo
{
	// Token: 0x02000058 RID: 88
	public class ModifyDataTask<TDBValue> : global::AcpBusinessLayer.UndoRedo.FieldTaskBase where TDBValue : global::System.IComparable
	{
		// Token: 0x0600050D RID: 1293 RVA: 0x0006D17C File Offset: 0x0006B37C
		private ModifyDataTask()
		{
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0006D190 File Offset: 0x0006B390
		public ModifyDataTask(global::AcpBusinessLayer.AcpField<TDBValue> obj, TDBValue newValue)
		{
			int a_ = 9;
			base..ctor();
			this.field = obj;
			this.a = newValue;
			this.b = obj.ForceValid;
			base.Description = global::AcpCommonResources.AcpResources.Change.AcpStringFormat(new object[]
			{
				global::AcpBusinessLayer.UndoRedo.SetValueTask.b("ﯚￜ", a_) + this.field.UIName + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("栗", a_)
			});
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0006D20C File Offset: 0x0006B40C
		internal ModifyDataTask(global::AcpBusinessLayer.AcpField<TDBValue> obj, TDBValue newValue, global::AcpBusinessLayer.UndoRedo.SetRefRecsetTask setRefTask)
		{
			int a_ = 3;
			base..ctor();
			this.field = obj;
			this.a = newValue;
			this.b = obj.ForceValid;
			this.c = setRefTask;
			base.Description = global::AcpCommonResources.AcpResources.Change.AcpStringFormat(new object[]
			{
				global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_) + this.field.UIName + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_)
			});
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0006D290 File Offset: 0x0006B490
		public override void Do()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					this.c.Do();
					num2 = (short)644546561;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)859308032;
					short num3 = num2;
					num2 = (short)1440702549;
					short num4 = num2;
					num2 = (short)1542611029;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_36;
					default:
						goto IL_FF;
					}
					break;
				}
				case 2:
					goto IL_36;
				}
				goto IL_1C;
				IL_36:
				if (this.c == null)
				{
					goto IL_116;
				}
				num2 = (short)1908277249;
				if (num2 != 0)
				{
				}
				num2 = (short)1648033792;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_FF:
			num2 = (short)183631872;
			if (num2 != 0)
			{
			}
			IL_116:
			base.Do();
			return;
			IL_1C:
			this.SwapValues();
			num2 = (short)349896706;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0006D3BC File Offset: 0x0006B5BC
		public override void Undo()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					this.c.Undo();
					num2 = (short)1598816257;
					if (num2 != 0)
					{
					}
					num2 = (short)1638072321;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)1546715136;
					short num3 = num2;
					num2 = (short)2137982314;
					short num4 = num2;
					num2 = (short)757532010;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_37;
					default:
						goto IL_104;
					}
					break;
				}
				case 2:
					goto IL_37;
				}
				goto IL_1C;
				IL_37:
				if (this.c == null)
				{
					goto IL_11C;
				}
				num2 = (short)1306394624;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_104:
			num2 = (short)1048313856;
			if (num2 != 0)
			{
			}
			IL_11C:
			base.Undo();
			return;
			IL_1C:
			this.SwapValues();
			num2 = (short)1986854914;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0006D4EC File Offset: 0x0006B6EC
		protected virtual void SwapValues()
		{
			short num = (short)1546993015;
			short num2 = num;
			num = (short)557530487;
			switch (num2 == num)
			{
			}
			num = (short)616824832;
			if (num != 0)
			{
			}
			num = (short)160694272;
			short num3 = num;
			num = (short)1594884097;
			if (num != 0)
			{
			}
			TDBValue value = ((global::AcpBusinessLayer.AcpField<TDBValue>)this.field).Value;
			((global::AcpBusinessLayer.AcpField<TDBValue>)this.field).Value = this.a;
			this.a = value;
		}

		// Token: 0x0400016B RID: 363
		private TDBValue a;

		// Token: 0x0400016C RID: 364
		private bool b;

		// Token: 0x0400016D RID: 365
		private global::AcpBusinessLayer.UndoRedo.SetRefRecsetTask c;
	}
}
