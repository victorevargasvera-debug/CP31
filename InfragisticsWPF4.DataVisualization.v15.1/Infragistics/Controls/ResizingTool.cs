using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Controls
{
	// Token: 0x02000027 RID: 39
	public class ResizingTool : global::Infragistics.Tool, global::Infragistics.Controls.ICancelableTool
	{
		// Token: 0x06000203 RID: 515 RVA: 0x0000A3DA File Offset: 0x000085DA
		public ResizingTool(global::Infragistics.InteractiveControl view) : base(view)
		{
			this._thumbNodes = new global::System.Collections.Generic.List<global::Infragistics.Controls.ThumbNode>();
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0000A3EE File Offset: 0x000085EE
		// (set) Token: 0x06000205 RID: 517 RVA: 0x0000A3F6 File Offset: 0x000085F6
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

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000206 RID: 518 RVA: 0x0000A3FF File Offset: 0x000085FF
		// (set) Token: 0x06000207 RID: 519 RVA: 0x0000A407 File Offset: 0x00008607
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

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0000A410 File Offset: 0x00008610
		// (set) Token: 0x06000209 RID: 521 RVA: 0x0000A418 File Offset: 0x00008618
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

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600020A RID: 522 RVA: 0x0000A421 File Offset: 0x00008621
		// (set) Token: 0x0600020B RID: 523 RVA: 0x0000A429 File Offset: 0x00008629
		private global::System.Collections.Generic.List<global::Infragistics.Controls.ThumbNode> ThumbNodes
		{
			get
			{
				return this._thumbNodes;
			}
			set
			{
				this._thumbNodes = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600020C RID: 524 RVA: 0x0000A432 File Offset: 0x00008632
		// (set) Token: 0x0600020D RID: 525 RVA: 0x0000A43A File Offset: 0x0000863A
		private bool IsCanceled
		{
			get
			{
				return this._canceled;
			}
			set
			{
				this._canceled = value;
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000A444 File Offset: 0x00008644
		public override bool CanStart(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Windows.Point docMousePosition = base.LastInput.DocMousePosition;
			global::Infragistics.InteractiveElement interactiveElement = base.View.HitTest(docMousePosition);
			if (interactiveElement != null)
			{
				global::Infragistics.Controls.ThumbNode thumbNode = interactiveElement as global::Infragistics.Controls.ThumbNode;
				if (thumbNode != null)
				{
					global::Infragistics.ShapeElement shapeElement = thumbNode.HitResizeThumb(docMousePosition);
					if (shapeElement != null)
					{
						this.ThumbNode = thumbNode;
						this.PrevPoint = docMousePosition;
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000A493 File Offset: 0x00008693
		public override void Start()
		{
			base.Start();
			this.ThumbNode.Start();
			this.IsCanceled = false;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000A4B0 File Offset: 0x000086B0
		public override void MouseMove()
		{
			global::System.Windows.Point docMousePosition = base.LastInput.DocMousePosition;
			double x = docMousePosition.X - this.PrevPoint.X;
			double y = docMousePosition.Y - this.PrevPoint.Y;
			global::System.Windows.Point offset = new global::System.Windows.Point(x, y);
			this.PrevPoint = docMousePosition;
			this.ThumbNode.DoResize(offset);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000A518 File Offset: 0x00008718
		public void MouseMove(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Windows.Point docMousePosition = base.LastInput.DocMousePosition;
			double x = docMousePosition.X - this.PrevPoint.X;
			double y = docMousePosition.Y - this.PrevPoint.Y;
			global::System.Windows.Point offset = new global::System.Windows.Point(x, y);
			this.PrevPoint = docMousePosition;
			this.ThumbNode.DoResize(offset);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000A57D File Offset: 0x0000877D
		public override void KeyDown()
		{
			base.KeyDown();
			if (base.LastInput.Key == global::System.Windows.Input.Key.Escape)
			{
				this.IsCanceled = true;
				base.StopTool();
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000A5A1 File Offset: 0x000087A1
		public override void MouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.StopTool();
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000A5A9 File Offset: 0x000087A9
		public override void Stop()
		{
			this.ThumbNode.Finish(this.IsCanceled);
			base.Stop();
		}

		// Token: 0x04000099 RID: 153
		private global::System.Windows.Point _prevPoint;

		// Token: 0x0400009A RID: 154
		private global::Infragistics.Controls.ThumbNode _thumbNode;

		// Token: 0x0400009B RID: 155
		private global::System.Collections.Generic.List<global::Infragistics.Controls.ThumbNode> _thumbNodes;

		// Token: 0x0400009C RID: 156
		private bool _canceled;
	}
}
