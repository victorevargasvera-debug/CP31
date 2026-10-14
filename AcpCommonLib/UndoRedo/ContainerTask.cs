using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AcpCommonLib.UndoRedo
{
	// Token: 0x02000032 RID: 50
	public class ContainerTask : global::AcpCommonLib.UndoRedo.UndoableTask
	{
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00011BFC File Offset: 0x0000FDFC
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00011CB0 File Offset: 0x0000FEB0
		public global::System.Collections.Generic.List<global::AcpCommonLib.UndoRedo.UndoableTask> Tasks
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1968391344;
				short num2 = num;
				num = (short)118441136;
				switch (num2 == num)
				{
				}
				num = (short)2029125633;
				if (num != 0)
				{
				}
				num = (short)1022885888;
				short num3 = num;
				num = (short)427294720;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)561832395;
				short num2 = num;
				num = (short)515105227;
				switch (num2 == num)
				{
				}
				num = (short)990052353;
				if (num != 0)
				{
				}
				num = (short)1281097728;
				short num3 = num;
				num = (short)871366656;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00011D64 File Offset: 0x0000FF64
		private ContainerTask()
		{
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00011D78 File Offset: 0x0000FF78
		public ContainerTask(string description)
		{
			this.Tasks = new global::System.Collections.Generic.List<global::AcpCommonLib.UndoRedo.UndoableTask>();
			base.Description = description;
			global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00011DA4 File Offset: 0x0000FFA4
		public override void Do()
		{
			short num = (short)646774791;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num3;
				switch (num2)
				{
				case 0:
					goto IL_173;
				case 1:
					num = (short)496959494;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num3 = 0;
					num = (short)1479868420;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_BE;
				case 4:
				{
					num = (short)2060631135;
					short num4 = num;
					num = (short)1967897695;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BE;
					default:
						num = (short)69140480;
						if (num != 0)
						{
						}
						goto IL_A9;
					}
					break;
				}
				case 5:
				{
					num = (short)1917517824;
					short num5 = num;
					goto IL_A9;
				}
				case 6:
					goto IL_A4;
				case 7:
					num = (short)445120513;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_6F;
					}
					continue;
				}
				IL_6F:
				if (this.a)
				{
					num = (short)235864066;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.a = true;
				num = (short)540999680;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A9:
				num = (short)386400259;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BE:
				if (num3 >= this.Tasks.Count)
				{
					num = (short)2100101121;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					this.Tasks[num3].Do();
					num3++;
					num = (short)1465319429;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_A4:
			IL_173:
			base.Do();
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00011F88 File Offset: 0x00010188
		public override void Undo()
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				int num2;
				short num3;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_EC;
					case 1:
						goto IL_46;
					case 2:
						if (num2 < 0)
						{
							num3 = (short)1109917696;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)242679809;
						if (num3 != 0)
						{
						}
						this.Tasks[num2].Undo();
						num2--;
						num3 = (short)301465601;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 3:
						goto IL_46;
					}
					break;
					IL_46:
					num3 = (short)2032118523;
					short num4 = num3;
					num3 = (short)1132964603;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
					{
						num3 = (short)1479016448;
						if (num3 != 0)
						{
						}
						num3 = (short)1153564672;
						short num5 = num3;
						num3 = (short)545914882;
						num = (int)((global::System.IntPtr)num3);
						break;
					}
					}
				}
				IL_20:
				num2 = this.Tasks.Count - 1;
				num3 = (short)228851715;
				num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
			IL_EC:
			base.Undo();
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000120E4 File Offset: 0x000102E4
		public void AddTask(global::AcpCommonLib.UndoRedo.UndoableTask task)
		{
			short num = (short)1477312512;
			short num2 = num;
			num = (short)1481375746;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1468661761;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
				{
					num = (short)172684962;
					short num4 = num;
					num = (short)805893794;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)681639936;
						if (num != 0)
						{
						}
						this.Tasks.Add(task);
						task.Do();
						num = (short)1774714881;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_80;
					}
					continue;
				}
				IL_80:
				if (task == null)
				{
					break;
				}
				num = (short)571932672;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00012204 File Offset: 0x00010404
		public override void LaunchUI()
		{
			short num = (short)689373184;
			short num2 = num;
			num = (short)1368915970;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					num = (short)292894295;
					short num4 = num;
					num = (short)453523031;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F2;
					default:
						num = (short)1299120128;
						if (num != 0)
						{
						}
						this.Tasks[0].LaunchUI();
						num = (short)433651713;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_F2;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				}
				IL_59:
				if (this.Tasks.Count <= 0)
				{
					return;
				}
				num = (short)845217792;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_F2:
			num = (short)524419073;
			if (num != 0)
			{
			}
		}

		// Token: 0x040000A1 RID: 161
		private bool a;

		// Token: 0x040000A2 RID: 162
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::AcpCommonLib.UndoRedo.UndoableTask> b;
	}
}
