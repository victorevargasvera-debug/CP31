using System;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;

namespace AcpBusinessLayer.UndoRedo
{
	// Token: 0x02000052 RID: 82
	public class ChangeMaxTask : global::AcpCommonLib.UndoRedo.UndoableTask
	{
		// Token: 0x060004F5 RID: 1269 RVA: 0x0006A664 File Offset: 0x00068864
		public ChangeMaxTask(global::AcpCommonLib.IAcpRecordset recordset, int newValue)
		{
			this.c = recordset;
			if (recordset != null)
			{
				this.a = this.c.Max;
			}
			this.b = newValue;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0006A6A0 File Offset: 0x000688A0
		public override void Do()
		{
			short num = (short)1854406657;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_110;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
				{
					num = (short)1428684208;
					short num3 = num;
					num = (short)1688141232;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)795541504;
						if (num != 0)
						{
						}
						this.c.Max = this.b;
						num = (short)1292500992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_30:
				num = (short)726335488;
				short num4 = num;
				if (this.c == null)
				{
					break;
				}
				num = (short)291962881;
				if (num != 0)
				{
				}
				num = (short)344129538;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_110:
			base.Do();
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0006A7C8 File Offset: 0x000689C8
		public override void Undo()
		{
			short num = (short)1710686209;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_11B;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
				{
					num = (short)414035315;
					short num3 = num;
					num = (short)1329048947;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)170000384;
						if (num != 0)
						{
						}
						this.c.Max = this.a;
						num = (short)698679296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_31:
				num = (short)1466761216;
				short num4 = num;
				if (this.c == null)
				{
					break;
				}
				num = (short)1624702977;
				if (num != 0)
				{
				}
				num = (short)1894318082;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_11B:
			base.Undo();
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0006A8F8 File Offset: 0x00068AF8
		public override void LaunchUI()
		{
			short num = (short)612761600;
			short num2 = num;
			num = (short)281346049;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_15F;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				case 2:
					num = (short)645267459;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (this.c.IsEmbeddedRecset)
					{
						num = (short)723058688;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					return;
				}
				IL_60:
				if (this.c == null)
				{
					break;
				}
				num = (short)1136445215;
				short num4 = num;
				num = (short)89048863;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1535115264;
					if (num != 0)
					{
					}
					num = (short)1386414082;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_15F:
				global::AcpCommonLib.UndoRedo.UndoManager.GoToSection(this.c.ParentSection);
				num = (short)204537857;
				if (num != 0)
				{
				}
				num = (short)544210948;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x04000156 RID: 342
		private readonly int a;

		// Token: 0x04000157 RID: 343
		private readonly int b;

		// Token: 0x04000158 RID: 344
		private global::AcpCommonLib.IAcpRecordset c;
	}
}
