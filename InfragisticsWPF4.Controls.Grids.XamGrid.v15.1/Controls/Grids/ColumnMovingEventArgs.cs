using System;
using System.Windows;
using System.Windows.Input;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001A3 RID: 419
	public class ColumnMovingEventArgs : global::Infragistics.Controls.Grids.ColumnEventArgs
	{
		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x0002A20D File Offset: 0x0002840D
		// (set) Token: 0x06000B6F RID: 2927 RVA: 0x0002A215 File Offset: 0x00028415
		public global::Infragistics.Controls.Grids.Primitives.HeaderCellControl DraggingHeader { get; internal set; }

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x0002A21E File Offset: 0x0002841E
		// (set) Token: 0x06000B71 RID: 2929 RVA: 0x0002A226 File Offset: 0x00028426
		protected internal global::System.Windows.Input.MouseEventArgs MouseArgs { get; set; }

		// Token: 0x06000B72 RID: 2930 RVA: 0x0002A230 File Offset: 0x00028430
		public global::System.Windows.Point GetPosition(global::System.Windows.UIElement relativeTo)
		{
			global::System.Windows.Point result = default(global::System.Windows.Point);
			if (this.MouseArgs != null)
			{
				result = this.MouseArgs.GetPosition(relativeTo);
			}
			return result;
		}
	}
}
