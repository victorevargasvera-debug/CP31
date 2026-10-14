using System;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;

namespace AcpBusinessLayer.UndoRedo
{
	// Token: 0x02000054 RID: 84
	public class ChangePermissionsTask : global::AcpCommonLib.UndoRedo.UndoableTask
	{
		// Token: 0x060004FD RID: 1277 RVA: 0x0006AE74 File Offset: 0x00069074
		public ChangePermissionsTask(global::AcpCommonLib.IAcpRecordset recordset, global::AcpCommonLib.Permissions newValue)
		{
			this.c = recordset;
			if (recordset != null)
			{
				this.a = this.c.Permissions;
			}
			this.b = newValue;
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0006AEB0 File Offset: 0x000690B0
		public ChangePermissionsTask(global::AcpCommonLib.IAcpFeatureNode featureNode, global::AcpCommonLib.Permissions newValue)
		{
			this.d = featureNode;
			if (this.d != null)
			{
				this.a = this.d.Permissions;
			}
			this.b = newValue;
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0006AEF0 File Offset: 0x000690F0
		public override void Do()
		{
			short num = (short)1377867317;
			short num2 = num;
			num = (short)1676187189;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_CB:
				num = (short)460914689;
				if (num != 0)
				{
				}
				this.c.Permissions = this.b;
				num = (short)115343363;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
			{
				num = (short)1811218432;
				if (num != 0)
				{
				}
				num = (short)1293549568;
				short num4 = num;
				num = (short)917831682;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					if (this.d != null)
					{
						num = (short)1690238980;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_181;
				case 1:
					goto IL_CB;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_AF;
					}
					continue;
				case 3:
					goto IL_11E;
				case 4:
					this.d.Permissions = this.b;
					num = (short)721747973;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_11C;
				}
				IL_AF:
				if (this.c != null)
				{
					num = (short)2120679425;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_11E:
				num = (short)13762560;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_11C:
			IL_181:
			base.Do();
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0006B084 File Offset: 0x00069284
		public override void Undo()
		{
			short num = (short)1135495709;
			short num2 = num;
			num = (short)735595037;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F4:
				this.c.Permissions = this.a;
				num = (short)1375993859;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
			{
				num = (short)463077376;
				if (num != 0)
				{
				}
				num = (short)1881866240;
				short num4 = num;
				num = (short)385613826;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			}
			for (;;)
			{
				num = (short)1201078273;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
					if (this.d != null)
					{
						num = (short)527892484;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_185;
				case 1:
					goto IL_F4;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_D6;
					}
					continue;
				case 3:
					goto IL_121;
				case 4:
					this.d.Permissions = this.a;
					num = (short)178913285;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_11F;
				}
				IL_D6:
				if (this.c != null)
				{
					num = (short)1097138177;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_121:
				num = (short)976814080;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_11F:
			IL_185:
			base.Undo();
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0006B21C File Offset: 0x0006941C
		public override void LaunchUI()
		{
			short num = (short)1950547968;
			short num2 = num;
			num = (short)1726873601;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_15D;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 2:
					num = (short)1913454595;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (this.c.IsEmbeddedRecset)
					{
						num = (short)783941632;
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
				num = (short)260456306;
				short num4 = num;
				num = (short)2111913842;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)247463937;
					if (num != 0)
					{
					}
					num = (short)113180672;
					if (num != 0)
					{
					}
					num = (short)1049755650;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_15D:
				global::AcpCommonLib.UndoRedo.UndoManager.GoToSection(this.c.ParentSection);
				num = (short)699596804;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0400015C RID: 348
		private global::AcpCommonLib.Permissions a;

		// Token: 0x0400015D RID: 349
		private global::AcpCommonLib.Permissions b;

		// Token: 0x0400015E RID: 350
		private global::AcpCommonLib.IAcpRecordset c;

		// Token: 0x0400015F RID: 351
		private global::AcpCommonLib.IAcpFeatureNode d;
	}
}
