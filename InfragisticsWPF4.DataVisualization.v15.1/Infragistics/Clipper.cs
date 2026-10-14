using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace Infragistics
{
	// Token: 0x0200006C RID: 108
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public class Clipper
	{
		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x00018478 File Offset: 0x00016678
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x00018480 File Offset: 0x00016680
		public global::System.Collections.Generic.IList<global::System.Windows.Point> Target
		{
			get
			{
				return this.target;
			}
			set
			{
				if (this._firstClipper != null)
				{
					this._firstClipper.Clear();
				}
				this._firstClipper = null;
				this.target = value;
				global::System.Collections.Generic.IList<global::System.Windows.Point> list = this.target;
				if (this.leftClipper != null)
				{
					this.leftClipper.Dst = list;
					list = this.leftClipper;
					this._firstClipper = this.leftClipper;
				}
				if (this.bottomClipper != null)
				{
					this.bottomClipper.Dst = list;
					list = this.bottomClipper;
					this.bottomClipper.NextClipper = this._firstClipper;
					this._firstClipper = this.bottomClipper;
				}
				if (this.rightClipper != null)
				{
					this.rightClipper.Dst = list;
					list = this.rightClipper;
					this.rightClipper.NextClipper = this._firstClipper;
					this._firstClipper = this.rightClipper;
				}
				if (this.topClipper != null)
				{
					this.topClipper.Dst = list;
					list = this.topClipper;
					this.topClipper.NextClipper = this._firstClipper;
					this._firstClipper = this.topClipper;
				}
				this.Head = list;
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0001858C File Offset: 0x0001678C
		public Clipper(global::System.Windows.Rect clip, bool isClosed)
		{
			this.leftClipper = new global::Infragistics.LeftClipper
			{
				Edge = clip.Left,
				IsClosed = isClosed
			};
			this.bottomClipper = new global::Infragistics.BottomClipper
			{
				Edge = clip.Bottom,
				IsClosed = isClosed
			};
			this.rightClipper = new global::Infragistics.RightClipper
			{
				Edge = clip.Right,
				IsClosed = isClosed
			};
			this.topClipper = new global::Infragistics.TopClipper
			{
				Edge = clip.Top,
				IsClosed = isClosed
			};
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00018624 File Offset: 0x00016824
		public Clipper(double left, double bottom, double right, double top, bool isClosed)
		{
			this.leftClipper = ((!double.IsNaN(left)) ? new global::Infragistics.LeftClipper
			{
				Edge = left,
				IsClosed = isClosed
			} : null);
			this.bottomClipper = ((!double.IsNaN(bottom)) ? new global::Infragistics.BottomClipper
			{
				Edge = bottom,
				IsClosed = isClosed
			} : null);
			this.rightClipper = ((!double.IsNaN(right)) ? new global::Infragistics.RightClipper
			{
				Edge = right,
				IsClosed = isClosed
			} : null);
			this.topClipper = ((!double.IsNaN(top)) ? new global::Infragistics.TopClipper
			{
				Edge = top,
				IsClosed = isClosed
			} : null);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x000186D5 File Offset: 0x000168D5
		public void Add(global::System.Windows.Point point)
		{
			this.Head.Add(point);
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x000186E4 File Offset: 0x000168E4
		// (set) Token: 0x06000614 RID: 1556 RVA: 0x00018748 File Offset: 0x00016948
		public bool IsClosed
		{
			get
			{
				return (this.leftClipper == null || this.leftClipper.IsClosed) && (this.bottomClipper == null || this.bottomClipper.IsClosed) && (this.rightClipper == null || this.rightClipper.IsClosed) && (this.topClipper == null || this.topClipper.IsClosed);
			}
			set
			{
				if (this.leftClipper != null)
				{
					this.leftClipper.IsClosed = value;
				}
				if (this.bottomClipper != null)
				{
					this.bottomClipper.IsClosed = value;
				}
				if (this.rightClipper != null)
				{
					this.rightClipper.IsClosed = value;
				}
				if (this.topClipper != null)
				{
					this.topClipper.IsClosed = value;
				}
			}
		}

		// Token: 0x04000262 RID: 610
		private global::System.Collections.Generic.IList<global::System.Windows.Point> Head;

		// Token: 0x04000263 RID: 611
		private global::Infragistics.EdgeClipper _firstClipper;

		// Token: 0x04000264 RID: 612
		private global::System.Collections.Generic.IList<global::System.Windows.Point> target;

		// Token: 0x04000265 RID: 613
		private global::Infragistics.LeftClipper leftClipper;

		// Token: 0x04000266 RID: 614
		private global::Infragistics.BottomClipper bottomClipper;

		// Token: 0x04000267 RID: 615
		private global::Infragistics.RightClipper rightClipper;

		// Token: 0x04000268 RID: 616
		private global::Infragistics.TopClipper topClipper;
	}
}
