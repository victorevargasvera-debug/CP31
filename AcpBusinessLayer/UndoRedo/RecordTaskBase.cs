using System;
using System.Collections.Generic;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;

namespace AcpBusinessLayer.UndoRedo
{
	// Token: 0x02000051 RID: 81
	public class RecordTaskBase : global::AcpCommonLib.UndoRedo.UndoableTask
	{
		// Token: 0x060004F2 RID: 1266 RVA: 0x0006A388 File Offset: 0x00068588
		protected RecordTaskBase()
		{
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0006A39C File Offset: 0x0006859C
		public RecordTaskBase(global::AcpBusinessLayer.FeatureNode record)
		{
			this.record = record;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0006A3B8 File Offset: 0x000685B8
		public override void LaunchUI()
		{
			short num = (short)1308164096;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_52;
					}
					continue;
				case 1:
				{
					int count;
					if (count > 0)
					{
						num = (short)1491861512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_244;
				}
				case 2:
				{
					num = (short)2011037697;
					if (num != 0)
					{
					}
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = acpFeatureNode.FeatureSectionsCollection.GetEnumerator();
					enumerator.MoveNext();
					global::AcpCommonLib.UndoRedo.UndoManager.GoToSection(enumerator.Current);
					num = (short)158662659;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					num = (short)1302677212;
					short num3 = num;
					num = (short)399722204;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_215;
					}
					break;
				}
				case 4:
					goto IL_7B;
				case 5:
					if (acpFeatureNode != null)
					{
						num = (short)1851523074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
				{
					if (((global::AcpBusinessLayer.Recordset)this.record.Parent).Contains(this.record))
					{
						num = (short)146669577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					int count = ((global::AcpBusinessLayer.Recordset)this.record.Parent).Count;
					num = (short)1146421249;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					goto IL_244;
				case 8:
				{
					int count;
					acpFeatureNode = ((global::AcpBusinessLayer.Recordset)this.record.Parent)[count - 1];
					num = (short)551616512;
					short num4 = num;
					num = (short)997654535;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					acpFeatureNode = this.record;
					num = (short)1559494666;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_244;
				}
				IL_52:
				if (this.record.Parent.IsEmbeddedRecset)
				{
					num = (short)1201537028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				acpFeatureNode = null;
				num = (short)2033516550;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_244:
				num = (short)37748741;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_7B:
			global::AcpCommonLib.UndoRedo.UndoManager.GoToSection(this.record.Parent.ParentSection);
			return;
			IL_215:
			num = (short)1257570304;
			if (num != 0)
			{
			}
		}

		// Token: 0x04000155 RID: 341
		protected global::AcpBusinessLayer.FeatureNode record;
	}
}
