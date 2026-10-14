using System;
using AcpBusinessLayer.UndoRedo;
using AcpCommonResources;
using AcpUtility;

namespace AcpBusinessLayer
{
	// Token: 0x02000040 RID: 64
	public class DeleteMultipleRecordsTask : global::AcpBusinessLayer.MultiRecordTaskBase
	{
		// Token: 0x060004B5 RID: 1205 RVA: 0x00066374 File Offset: 0x00064574
		protected DeleteMultipleRecordsTask()
		{
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00066388 File Offset: 0x00064588
		public DeleteMultipleRecordsTask(global::AcpBusinessLayer.FeatureNode[] records)
		{
			int a_ = 3;
			base..ctor(records);
			base.Description = global::AcpCommonResources.AcpResources.Delete_Records.AcpStringFormat(new object[]
			{
				base.Count.ToString() + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_) + records[0].FeatureName
			});
			this.a = new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask[records.Length];
			for (int i = 0; i < records.Length; i++)
			{
				this.a[i] = new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(records[i]);
			}
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00066418 File Offset: 0x00064618
		public override void Do()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					num2 = (short)1244463105;
					if (num2 != 0)
					{
					}
					num2 = (short)407306240;
					short num3 = num2;
					goto IL_F0;
				}
				case 1:
					goto IL_108;
				case 2:
					goto IL_12A;
				case 3:
					goto IL_F0;
				}
				goto IL_20;
				IL_F0:
				num2 = (short)852426753;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_12A:
			base.Do();
			return;
			IL_20:
			num2 = (short)1338775445;
			short num4 = num2;
			num2 = (short)923473813;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_108:
				int num;
				int num5;
				if (num5 >= this.a.Length)
				{
					num2 = (short)99418114;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				global::AcpBusinessLayer.Recordset recordset;
				recordset.LastRecordInOperation = (num5 == base.Count - 1);
				this.a[num5].Do();
				num5++;
				num2 = (short)588513283;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)143065088;
				if (num2 != 0)
				{
				}
				global::AcpBusinessLayer.Recordset recordset = base.Records[0].Parent as global::AcpBusinessLayer.Recordset;
				recordset.LastRecordInOperation = false;
				int num5 = 0;
				num2 = (short)101056512;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00066594 File Offset: 0x00064794
		public override void Undo()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_AC;
				case 1:
					goto IL_114;
				case 2:
					goto IL_12F;
				case 3:
					goto IL_AC;
				}
				goto IL_20;
				IL_AC:
				num2 = (short)1008009216;
				short num3 = num2;
				num2 = (short)810156033;
				if (num2 != 0)
				{
				}
				num2 = (short)1768816641;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_12F:
			base.Undo();
			return;
			IL_20:
			num2 = (short)1948785863;
			short num4 = num2;
			num2 = (short)1783438535;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_114:
				int num;
				int num5;
				if (num5 < 0)
				{
					num2 = (short)1525350402;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				global::AcpBusinessLayer.Recordset recordset;
				recordset.LastRecordInOperation = (num5 == 0);
				this.a[num5].Undo();
				num5--;
				num2 = (short)1559232515;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)302448640;
				if (num2 != 0)
				{
				}
				global::AcpBusinessLayer.Recordset recordset = base.Records[0].Parent as global::AcpBusinessLayer.Recordset;
				recordset.LastRecordInOperation = false;
				int num5 = this.a.Length - 1;
				num2 = (short)459669504;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x04000148 RID: 328
		private global::AcpBusinessLayer.UndoRedo.DeleteRecordTask[] a;
	}
}
