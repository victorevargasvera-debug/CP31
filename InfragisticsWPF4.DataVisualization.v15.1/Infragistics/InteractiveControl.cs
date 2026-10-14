using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using Infragistics.Controls;

namespace Infragistics
{
	// Token: 0x0200001A RID: 26
	public abstract class InteractiveControl : global::System.Windows.Controls.Control
	{
		// Token: 0x06000158 RID: 344 RVA: 0x00008654 File Offset: 0x00006854
		protected InteractiveControl()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.InteractiveControl);
			this.VisualElements = new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.VisualElement>();
			this.VisualElements.CollectionChanged += this.VisualElements_CollectionChanged;
			this.LastInput = new global::Infragistics.InputContext();
			this.MouseDownTools = new global::System.Collections.ObjectModel.Collection<global::Infragistics.ITool>();
			this.MouseMoveTools = new global::System.Collections.ObjectModel.Collection<global::Infragistics.ITool>();
			this.DefaultTool = new global::Infragistics.DefaultTool(this);
			this.CurrentTool = this.DefaultTool;
			this.DoubleClickTimer = new global::System.Windows.Threading.DispatcherTimer();
			this.DoubleClickTimer.Interval = new global::System.TimeSpan(0, 0, 0, 0, 300);
			this.DoubleClickTimer.Tick += this.DoubleClickTimer_Tick;
			this.ResizePoints = new global::System.Collections.Generic.List<global::Infragistics.Controls.ResizePoint>();
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00008718 File Offset: 0x00006918
		// (set) Token: 0x0600015A RID: 346 RVA: 0x0000872A File Offset: 0x0000692A
		public global::Infragistics.InputContext LastInput
		{
			get
			{
				return (global::Infragistics.InputContext)base.GetValue(global::Infragistics.InteractiveControl.LastInputProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.InteractiveControl.LastInputProperty, value);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00008738 File Offset: 0x00006938
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00008740 File Offset: 0x00006940
		internal global::System.Collections.Generic.List<global::Infragistics.Controls.ResizePoint> ResizePoints { get; set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00008749 File Offset: 0x00006949
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00008751 File Offset: 0x00006951
		private global::Infragistics.ITool DefaultTool
		{
			get
			{
				return this._defaultTool;
			}
			set
			{
				this._defaultTool = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600015F RID: 351 RVA: 0x0000875A File Offset: 0x0000695A
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00008762 File Offset: 0x00006962
		public virtual global::System.Windows.Controls.Canvas Canvas
		{
			get
			{
				return this._canvas;
			}
			protected set
			{
				this._canvas = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000161 RID: 353 RVA: 0x0000876B File Offset: 0x0000696B
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00008774 File Offset: 0x00006974
		public global::Infragistics.ITool CurrentTool
		{
			get
			{
				return this._currentTool;
			}
			set
			{
				if (this._currentTool != value)
				{
					if (this._currentTool != null)
					{
						this._currentTool.Stop();
					}
					if (value == null)
					{
						this._currentTool = this.DefaultTool;
					}
					else
					{
						this._currentTool = value;
					}
					if (this._currentTool != null)
					{
						this._currentTool.Start();
					}
				}
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000163 RID: 355 RVA: 0x000087C8 File Offset: 0x000069C8
		// (set) Token: 0x06000164 RID: 356 RVA: 0x000087D0 File Offset: 0x000069D0
		public global::System.Collections.ObjectModel.Collection<global::Infragistics.ITool> MouseDownTools
		{
			get
			{
				return this._mouseDownTools;
			}
			private set
			{
				this._mouseDownTools = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000165 RID: 357 RVA: 0x000087D9 File Offset: 0x000069D9
		// (set) Token: 0x06000166 RID: 358 RVA: 0x000087E1 File Offset: 0x000069E1
		public global::System.Collections.ObjectModel.Collection<global::Infragistics.ITool> MouseMoveTools
		{
			get
			{
				return this._mouseMoveTools;
			}
			private set
			{
				this._mouseMoveTools = value;
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000087EC File Offset: 0x000069EC
		internal virtual global::Infragistics.InteractiveElement HitTest(global::System.Windows.Point point)
		{
			global::System.Collections.ObjectModel.Collection<global::Infragistics.InteractiveElement> interactiveElements = this.InteractiveElements;
			for (int i = interactiveElements.Count - 1; i >= 0; i--)
			{
				global::Infragistics.InteractiveElement interactiveElement = interactiveElements[i];
				if (interactiveElement.HitTest(point))
				{
					return interactiveElement;
				}
			}
			return null;
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00008827 File Offset: 0x00006A27
		// (set) Token: 0x06000169 RID: 361 RVA: 0x0000882F File Offset: 0x00006A2F
		internal global::Infragistics.ShapeElement CapturedElement
		{
			get
			{
				return this._capturedElement;
			}
			set
			{
				this._capturedElement = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00008838 File Offset: 0x00006A38
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00008840 File Offset: 0x00006A40
		internal bool IsManuallyReleasingMouseCapture { get; set; }

		// Token: 0x0600016C RID: 364 RVA: 0x00008849 File Offset: 0x00006A49
		internal void ReleaseMouseCaptures()
		{
			if (this.CapturedElement != null && this.CapturedElement.ActiveFrameworkElement != null)
			{
				this.IsManuallyReleasingMouseCapture = true;
				this.CapturedElement.ActiveFrameworkElement.ReleaseMouseCapture();
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00008877 File Offset: 0x00006A77
		private bool IsCanvasValid()
		{
			return this.Canvas != null && this.Canvas.ActualHeight != 0.0 && this.Canvas.ActualWidth != 0.0;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000088B0 File Offset: 0x00006AB0
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseMove(e);
			if (!this.IsCanvasValid())
			{
				return;
			}
			this.LastInput.ViewMousePosition = e.GetPosition(null);
			global::System.Windows.Point position = e.GetPosition(this.Canvas);
			this.LastInput.DocMousePosition = position;
			global::System.Collections.Generic.ICollection<global::Infragistics.InteractiveElement> interactiveElements = this.InteractiveElements;
			foreach (global::Infragistics.InteractiveElement interactiveElement in interactiveElements)
			{
				if (interactiveElement.HitTest(position))
				{
					if (interactiveElement.IsMouseOver)
					{
						interactiveElement.OnMouseMove(e);
					}
					else
					{
						interactiveElement.OnMouseEnter(e);
					}
				}
				else if (interactiveElement.IsMouseOver)
				{
					interactiveElement.OnMouseLeave(e);
				}
			}
			this.CurrentTool.MouseMove();
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00008970 File Offset: 0x00006B70
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.LastInput.ViewMousePosition = e.GetPosition(null);
			this.LastInput.DocMousePosition = e.GetPosition(this.Canvas);
			if (!this.IsCanvasValid())
			{
				return;
			}
			this.CurrentTool.Start();
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000089C4 File Offset: 0x00006BC4
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			global::System.Collections.Generic.ICollection<global::Infragistics.InteractiveElement> interactiveElements = this.InteractiveElements;
			foreach (global::Infragistics.InteractiveElement interactiveElement in interactiveElements)
			{
				if (interactiveElement.IsMouseOver)
				{
					interactiveElement.OnMouseLeave(e);
				}
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00008A24 File Offset: 0x00006C24
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnLostMouseCapture(e);
			if (this.IsManuallyReleasingMouseCapture)
			{
				this.IsManuallyReleasingMouseCapture = false;
				return;
			}
			global::System.Collections.Generic.ICollection<global::Infragistics.InteractiveElement> interactiveElements = this.InteractiveElements;
			foreach (global::Infragistics.InteractiveElement interactiveElement in interactiveElements)
			{
				if (interactiveElement.IsMouseOver)
				{
					interactiveElement.OnMouseLeave(e);
				}
			}
			this.CurrentTool = null;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00008A9C File Offset: 0x00006C9C
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			if (!this.IsCanvasValid())
			{
				return;
			}
			this.LastInput.ViewMousePosition = e.GetPosition(null);
			this.LastInput.DocMousePosition = e.GetPosition(this.Canvas);
			global::System.Collections.Generic.ICollection<global::Infragistics.InteractiveElement> interactiveElements = this.InteractiveElements;
			global::System.Windows.Point docMousePosition = this.LastInput.DocMousePosition;
			foreach (global::Infragistics.InteractiveElement interactiveElement in interactiveElements)
			{
				if (interactiveElement.HitTest(docMousePosition))
				{
					interactiveElement.OnMouseLeftButtonDown(e);
				}
			}
			this.CurrentTool = null;
			this.CurrentTool.MouseLeftButtonDown(e);
			this.CheckMouseDoubleClick(e);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00008B54 File Offset: 0x00006D54
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonUp(e);
			if (!this.IsCanvasValid())
			{
				return;
			}
			this.LastInput.ViewMousePosition = e.GetPosition(null);
			this.LastInput.DocMousePosition = e.GetPosition(this.Canvas);
			global::System.Collections.Generic.ICollection<global::Infragistics.InteractiveElement> interactiveElements = this.InteractiveElements;
			foreach (global::Infragistics.InteractiveElement interactiveElement in interactiveElements)
			{
				if (interactiveElement.IsMouseCaptured)
				{
					interactiveElement.OnMouseLeftButtonUp(e);
				}
			}
			this.CurrentTool.MouseLeftButtonUp(e);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00008BF0 File Offset: 0x00006DF0
		protected virtual void OnMouseLeftButtonDoubleClick(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Collections.Generic.ICollection<global::Infragistics.InteractiveElement> interactiveElements = this.InteractiveElements;
			foreach (global::Infragistics.InteractiveElement interactiveElement in interactiveElements)
			{
				if (interactiveElement.IsMouseCaptured)
				{
					interactiveElement.OnMouseLeftButtonDoubleClick(e);
				}
			}
			this.CurrentTool.OnMouseLeftButtonDoubleClick();
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00008C54 File Offset: 0x00006E54
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnKeyDown(e);
			this.LastInput.Key = e.Key;
			global::System.Collections.Generic.ICollection<global::Infragistics.InteractiveElement> interactiveElements = this.InteractiveElements;
			global::System.Windows.Point docMousePosition = this.LastInput.DocMousePosition;
			foreach (global::Infragistics.InteractiveElement interactiveElement in interactiveElements)
			{
				if (interactiveElement.HitTest(docMousePosition))
				{
					interactiveElement.OnKeyDown(e);
				}
			}
			this.CurrentTool.KeyDown();
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00008CDC File Offset: 0x00006EDC
		protected override void OnKeyUp(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnKeyUp(e);
			this.LastInput.Key = e.Key;
			global::System.Collections.Generic.ICollection<global::Infragistics.InteractiveElement> interactiveElements = this.InteractiveElements;
			global::System.Windows.Point docMousePosition = this.LastInput.DocMousePosition;
			foreach (global::Infragistics.InteractiveElement interactiveElement in interactiveElements)
			{
				if (interactiveElement.HitTest(docMousePosition))
				{
					interactiveElement.OnKeyUp(e);
				}
			}
			this.CurrentTool.KeyUp();
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00008D64 File Offset: 0x00006F64
		private void VisualElements_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
				using (global::System.Collections.IEnumerator enumerator = e.NewItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						global::Infragistics.VisualElement visualElement = (global::Infragistics.VisualElement)obj;
						visualElement.SetView(this);
						visualElement.Render();
					}
					return;
				}
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				break;
			default:
				return;
			}
			foreach (object obj2 in e.OldItems)
			{
				global::Infragistics.VisualElement visualElement2 = (global::Infragistics.VisualElement)obj2;
				visualElement2.Remove();
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00008E2C File Offset: 0x0000702C
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00008E34 File Offset: 0x00007034
		private global::System.Windows.Point ClickPoint
		{
			get
			{
				return this._clickPoint;
			}
			set
			{
				this._clickPoint = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00008E3D File Offset: 0x0000703D
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00008E45 File Offset: 0x00007045
		private global::System.Windows.Threading.DispatcherTimer DoubleClickTimer
		{
			get
			{
				return this._doubleClickTimer;
			}
			set
			{
				this._doubleClickTimer = value;
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00008E50 File Offset: 0x00007050
		private void CheckMouseDoubleClick(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Windows.Point docMousePosition = this.LastInput.DocMousePosition;
			if (this.DoubleClickTimer.IsEnabled && !global::Infragistics.InteractiveControl.IsMouseMoved(this.ClickPoint, docMousePosition))
			{
				this.DoubleClickTimer.Stop();
				this.OnMouseLeftButtonDoubleClick(e);
				return;
			}
			this.DoubleClickTimer.Start();
			this.ClickPoint = docMousePosition;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00008EAC File Offset: 0x000070AC
		private static bool IsMouseMoved(global::System.Windows.Point pt1, global::System.Windows.Point pt2)
		{
			return global::System.Math.Abs(pt1.X - pt2.X) > 3.0 || global::System.Math.Abs(pt1.Y - pt2.Y) > 3.0;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00008EF9 File Offset: 0x000070F9
		private void DoubleClickTimer_Tick(object sender, global::System.EventArgs e)
		{
			this.DoubleClickTimer.Stop();
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00008F06 File Offset: 0x00007106
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00008F0E File Offset: 0x0000710E
		internal global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.VisualElement> VisualElements
		{
			get
			{
				return this._visualElements;
			}
			private set
			{
				this._visualElements = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00008F18 File Offset: 0x00007118
		internal global::System.Collections.ObjectModel.Collection<global::Infragistics.InteractiveElement> InteractiveElements
		{
			get
			{
				global::System.Collections.ObjectModel.Collection<global::Infragistics.InteractiveElement> collection = new global::System.Collections.ObjectModel.Collection<global::Infragistics.InteractiveElement>();
				foreach (global::Infragistics.VisualElement visualElement in this.VisualElements)
				{
					global::Infragistics.InteractiveElement interactiveElement = visualElement as global::Infragistics.InteractiveElement;
					if (interactiveElement != null)
					{
						collection.Add(interactiveElement);
					}
				}
				return collection;
			}
		}

		// Token: 0x0400006E RID: 110
		private const int DoubleClickInterval = 300;

		// Token: 0x0400006F RID: 111
		public static readonly global::System.Windows.DependencyProperty LastInputProperty = global::System.Windows.DependencyProperty.Register("LastInput", typeof(global::Infragistics.InputContext), typeof(global::Infragistics.InteractiveControl), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x04000070 RID: 112
		private global::Infragistics.ITool _defaultTool;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Controls.Canvas _canvas;

		// Token: 0x04000072 RID: 114
		private global::Infragistics.ITool _currentTool;

		// Token: 0x04000073 RID: 115
		private global::System.Collections.ObjectModel.Collection<global::Infragistics.ITool> _mouseDownTools;

		// Token: 0x04000074 RID: 116
		private global::System.Collections.ObjectModel.Collection<global::Infragistics.ITool> _mouseMoveTools;

		// Token: 0x04000075 RID: 117
		private global::Infragistics.ShapeElement _capturedElement;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Point _clickPoint;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Threading.DispatcherTimer _doubleClickTimer;

		// Token: 0x04000078 RID: 120
		private global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.VisualElement> _visualElements;
	}
}
