using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Controls
{
	// Token: 0x02000026 RID: 38
	public class DraggingTool : global::Infragistics.Tool, global::Infragistics.Controls.ICancelableTool
	{
		// Token: 0x060001F4 RID: 500 RVA: 0x0000A280 File Offset: 0x00008480
		public DraggingTool(global::Infragistics.InteractiveControl view) : base(view)
		{
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0000A289 File Offset: 0x00008489
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x0000A291 File Offset: 0x00008491
		bool global::Infragistics.Controls.ICancelableTool.IsCanceled
		{
			get
			{
				return this.IsCanceled;
			}
			set
			{
				this.IsCanceled = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0000A29A File Offset: 0x0000849A
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x0000A2A2 File Offset: 0x000084A2
		private global::System.Windows.Point PrevPoint
		{
			get
			{
				return this._prevPoint;
			}
			set
			{
				this._prevPoint = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0000A2AB File Offset: 0x000084AB
		// (set) Token: 0x060001FA RID: 506 RVA: 0x0000A2B3 File Offset: 0x000084B3
		private global::Infragistics.Controls.ThumbNode ThumbNode
		{
			get
			{
				return this._thumbNode;
			}
			set
			{
				this._thumbNode = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001FB RID: 507 RVA: 0x0000A2BC File Offset: 0x000084BC
		// (set) Token: 0x060001FC RID: 508 RVA: 0x0000A2C4 File Offset: 0x000084C4
		internal bool IsCanceled
		{
			get
			{
				return this._isCanceled;
			}
			set
			{
				this._isCanceled = value;
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000A2D0 File Offset: 0x000084D0
		public override bool CanStart(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Windows.Point docMousePosition = base.LastInput.DocMousePosition;
			global::Infragistics.InteractiveElement interactiveElement = base.View.HitTest(docMousePosition);
			if (interactiveElement != null)
			{
				global::Infragistics.Controls.ThumbNode thumbNode = interactiveElement as global::Infragistics.Controls.ThumbNode;
				if (thumbNode != null)
				{
					this.ThumbNode = thumbNode;
					this.PrevPoint = docMousePosition;
					return true;
				}
			}
			return false;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000A314 File Offset: 0x00008514
		public override void Start()
		{
			base.Start();
			this.ThumbNode.Start();
			this.IsCanceled = false;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000A330 File Offset: 0x00008530
		public override void MouseMove()
		{
			global::System.Windows.Point docMousePosition = base.LastInput.DocMousePosition;
			double x = docMousePosition.X - this.PrevPoint.X;
			double y = docMousePosition.Y - this.PrevPoint.Y;
			global::System.Windows.Point offset = new global::System.Windows.Point(x, y);
			this.ThumbNode.DoMove(offset);
			this.PrevPoint = docMousePosition;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000A395 File Offset: 0x00008595
		public override void KeyDown()
		{
			base.KeyDown();
			if (base.LastInput.Key == global::System.Windows.Input.Key.Escape)
			{
				this.IsCanceled = true;
				base.StopTool();
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000A3B9 File Offset: 0x000085B9
		public override void MouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.StopTool();
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000A3C1 File Offset: 0x000085C1
		public override void Stop()
		{
			this.ThumbNode.Finish(this.IsCanceled);
			base.Stop();
		}

		// Token: 0x04000096 RID: 150
		private global::System.Windows.Point _prevPoint;

		// Token: 0x04000097 RID: 151
		private global::Infragistics.Controls.ThumbNode _thumbNode;

		// Token: 0x04000098 RID: 152
		private bool _isCanceled;
	}
}
