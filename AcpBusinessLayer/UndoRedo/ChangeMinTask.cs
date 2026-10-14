using System;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;

namespace AcpBusinessLayer.UndoRedo
{
	// Token: 0x02000053 RID: 83
	public class ChangeMinTask : global::AcpCommonLib.UndoRedo.UndoableTask
	{
		// Token: 0x060004F9 RID: 1273 RVA: 0x0006AA6C File Offset: 0x00068C6C
		public ChangeMinTask(global::AcpCommonLib.IAcpRecordset recordset, int newValue)
		{
			this.c = recordset;
			if (recordset != null)
			{
				this.a = this.c.Min;
			}
			this.b = newValue;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0006AAA8 File Offset: 0x00068CA8
		public override void Do()
		{
			short num = (short)510525440;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
					goto IL_119;
				case 2:
				{
					num = (short)2024931462;
					short num3 = num;
					num = (short)184221830;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11B;
					default:
						num = (short)1800536064;
						if (num != 0)
						{
						}
						this.c.Min = this.b;
						num = (short)774176769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_31:
				num = (short)2055077889;
				if (num != 0)
				{
				}
				num = (short)2100232192;
				short num4 = num;
				if (this.c == null)
				{
					break;
				}
				num = (short)1798045698;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_119:
			IL_11B:
			base.Do();
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0006ABD8 File Offset: 0x00068DD8
		public override void Undo()
		{
			short num = (short)696844288;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
					goto IL_116;
				case 2:
				{
					num = (short)1401337196;
					short num3 = num;
					num = (short)488093036;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_118;
					default:
						num = (short)1497759745;
						if (num != 0)
						{
						}
						num = (short)425525248;
						if (num != 0)
						{
						}
						this.c.Min = this.a;
						num = (short)65142785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_31:
				if (this.c == null)
				{
					break;
				}
				num = (short)410845184;
				short num4 = num;
				num = (short)2075918338;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_116:
			IL_118:
			base.Undo();
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0006AD04 File Offset: 0x00068F04
		public override void LaunchUI()
		{
			short num = (short)1294532608;
			short num2 = num;
			num = (short)2144862209;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_160;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 2:
					num = (short)1401487363;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (this.c.IsEmbeddedRecset)
					{
						num = (short)109772800;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					return;
				}
				IL_61:
				if (this.c == null)
				{
					break;
				}
				num = (short)807206913;
				if (num != 0)
				{
				}
				num = (short)1377987393;
				short num4 = num;
				num = (short)1686661953;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1511718912;
					if (num != 0)
					{
					}
					num = (short)681115650;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_160:
				global::AcpCommonLib.UndoRedo.UndoManager.GoToSection(this.c.ParentSection);
				num = (short)1585709060;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x04000159 RID: 345
		private int a;

		// Token: 0x0400015A RID: 346
		private int b;

		// Token: 0x0400015B RID: 347
		private global::AcpCommonLib.IAcpRecordset c;
	}
}
