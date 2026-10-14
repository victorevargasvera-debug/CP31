using System;
using System.Windows.Input;

namespace Infragistics
{
	// Token: 0x0200001D RID: 29
	public class DefaultTool : global::Infragistics.Tool
	{
		// Token: 0x0600019C RID: 412 RVA: 0x0000901F File Offset: 0x0000721F
		public DefaultTool(global::Infragistics.InteractiveControl view) : base(view)
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00009028 File Offset: 0x00007228
		public override void MouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			foreach (global::Infragistics.ITool tool in base.View.MouseDownTools)
			{
				if (tool != null && tool.CanStart(e))
				{
					base.View.CurrentTool = tool;
					break;
				}
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00009090 File Offset: 0x00007290
		public override void MouseMove()
		{
			foreach (global::Infragistics.ITool tool in base.View.MouseMoveTools)
			{
				if (tool != null && tool.CanStart())
				{
					base.View.CurrentTool = tool;
					break;
				}
			}
		}
	}
}
