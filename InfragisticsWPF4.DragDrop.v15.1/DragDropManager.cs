using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Infragistics.DragDrop
{
	// Token: 0x02000002 RID: 2
	public class DragDropManager
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		public static global::System.Windows.DataTemplate CurrentCopyCursorTemplate
		{
			get
			{
				return global::Infragistics.DragDrop.DragDropManager.Instance._currentCopyCursorTemplate;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2 RVA: 0x000020DC File Offset: 0x000002DC
		public static global::System.Windows.DataTemplate CurrentCursorTemplate
		{
			get
			{
				return global::Infragistics.DragDrop.DragDropManager.Instance._currentCursorTemplate;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000003 RID: 3 RVA: 0x000020E8 File Offset: 0x000002E8
		public static global::System.Windows.DataTemplate CurrentDragTemplate
		{
			get
			{
				if (!global::Infragistics.DragDrop.DragDropManager.Instance._dragging)
				{
					return null;
				}
				return global::Infragistics.DragDrop.DragDropManager.Instance._dragDropEventArgs.DragTemplate;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002107 File Offset: 0x00000307
		public static global::System.Windows.DataTemplate CurrentDropNotAllowedCursorTemplate
		{
			get
			{
				return global::Infragistics.DragDrop.DragDropManager.Instance._currentDropNotAllowedCursorTemplate;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002113 File Offset: 0x00000313
		public static global::System.Windows.DataTemplate CurrentMoveCursorTemplate
		{
			get
			{
				return global::Infragistics.DragDrop.DragDropManager.Instance._currentMoveCursorTemplate;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000211F File Offset: 0x0000031F
		public static global::System.Windows.UIElement DragPopup
		{
			get
			{
				return global::Infragistics.DragDrop.DragDropManager.Instance._dragPopup;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000212B File Offset: 0x0000032B
		public static bool IsDragging
		{
			get
			{
				return global::Infragistics.DragDrop.DragDropManager.Instance._dragging;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002138 File Offset: 0x00000338
		private static void OnDragSourceChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (e.OldValue != null)
			{
				global::Infragistics.DragDrop.DragSource dragSource = e.OldValue as global::Infragistics.DragDrop.DragSource;
				if (dragSource != null)
				{
					if (dragSource.IsDraggable && dragSource.AssociatedObject != null)
					{
						if (global::Infragistics.DragDrop.DragDropManager.RegisteredDragSources.Contains(dragSource))
						{
							global::Infragistics.DragDrop.DragDropManager.RegisteredDragSources.Remove(dragSource);
						}
						global::Infragistics.DragDrop.DragDropManager.UnregisterDragSource(dragSource.AssociatedObject);
					}
					dragSource.AssociatedObject = null;
				}
			}
			if (e.NewValue != null)
			{
				global::Infragistics.DragDrop.DragSource dragSource2 = e.NewValue as global::Infragistics.DragDrop.DragSource;
				if (dragSource2 != null && !global::Infragistics.DragDrop.DragDropManager.RegisteredDragSources.Contains(dragSource2))
				{
					dragSource2.AssociatedObject = (d as global::System.Windows.UIElement);
					global::Infragistics.DragDrop.DragDropManager.RegisteredDragSources.Add(dragSource2);
					if (dragSource2.IsDraggable && dragSource2.AssociatedObject != null)
					{
						global::Infragistics.DragDrop.DragDropManager.RegisterDragSource(d as global::System.Windows.UIElement);
					}
				}
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000021F0 File Offset: 0x000003F0
		public static global::Infragistics.DragDrop.DragSource GetDragSource(global::System.Windows.DependencyObject obj)
		{
			return (global::Infragistics.DragDrop.DragSource)obj.GetValue(global::Infragistics.DragDrop.DragDropManager.DragSourceProperty);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002202 File Offset: 0x00000402
		public static void SetDragSource(global::System.Windows.DependencyObject obj, global::Infragistics.DragDrop.DragSource value)
		{
			obj.SetValue(global::Infragistics.DragDrop.DragDropManager.DragSourceProperty, value);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002210 File Offset: 0x00000410
		private static void OnDropTargetChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (e.OldValue != null)
			{
				global::Infragistics.DragDrop.DropTarget dropTarget = e.OldValue as global::Infragistics.DragDrop.DropTarget;
				if (dropTarget != null)
				{
					if (dropTarget.IsDropTarget && dropTarget.AssociatedObject != null)
					{
						global::Infragistics.DragDrop.DragDropManager.UnregisterDropTarget(dropTarget.AssociatedObject);
					}
					dropTarget.AssociatedObject = null;
				}
			}
			if (e.NewValue != null)
			{
				global::Infragistics.DragDrop.DropTarget dropTarget2 = e.NewValue as global::Infragistics.DragDrop.DropTarget;
				global::System.Windows.UIElement uielement = d as global::System.Windows.UIElement;
				if (dropTarget2 != null)
				{
					dropTarget2.AssociatedObject = uielement;
					if (dropTarget2.IsDropTarget && uielement != null)
					{
						global::Infragistics.DragDrop.DragDropManager.RegisterDropTarget(uielement);
					}
				}
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002290 File Offset: 0x00000490
		public static global::Infragistics.DragDrop.DropTarget GetDropTarget(global::System.Windows.DependencyObject obj)
		{
			return (global::Infragistics.DragDrop.DropTarget)obj.GetValue(global::Infragistics.DragDrop.DragDropManager.DropTargetProperty);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000022A2 File Offset: 0x000004A2
		public static void SetDropTarget(global::System.Windows.DependencyObject obj, global::Infragistics.DragDrop.DropTarget value)
		{
			obj.SetValue(global::Infragistics.DragDrop.DragDropManager.DropTargetProperty, value);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000022B0 File Offset: 0x000004B0
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000022B7 File Offset: 0x000004B7
		public static bool HighlightTargetsOnDragStart { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000022C0 File Offset: 0x000004C0
		public static global::Infragistics.DragDrop.DragDropManager Instance
		{
			get
			{
				if (global::Infragistics.DragDrop.DragDropManager._instance == null)
				{
					global::Infragistics.DragDrop.DragDropManager._instance = new global::Infragistics.DragDrop.DragDropManager();
					global::System.IO.Stream manifestResourceStream = typeof(global::Infragistics.DragDrop.DragDropManager).Assembly.GetManifestResourceStream("Infragistics.DragDrop.Templates.xaml");
					if (manifestResourceStream != null)
					{
						global::System.Windows.ResourceDictionary resourceDictionary = (global::System.Windows.ResourceDictionary)global::System.Windows.Markup.XamlReader.Load(manifestResourceStream);
						global::Infragistics.DragDrop.DragDropManager._instance._defaultDropNotAllowedCursorTemplate = (resourceDictionary["dropNotAllowedDataTemplate"] as global::System.Windows.DataTemplate);
						global::Infragistics.DragDrop.DragDropManager._instance._defaultMoveCursorTemplate = (resourceDictionary["moveDataTemplate"] as global::System.Windows.DataTemplate);
						global::Infragistics.DragDrop.DragDropManager._instance._defaultCopyCursorTemplate = (resourceDictionary["copyDataTemplate"] as global::System.Windows.DataTemplate);
						global::Infragistics.DragDrop.DragDropManager._instance._defaultDragTemplate = (resourceDictionary["dragDataTemplate"] as global::System.Windows.DataTemplate);
					}
					global::Infragistics.DragDrop.DragDropManager._instance._currentDropNotAllowedCursorTemplate = global::Infragistics.DragDrop.DragDropManager._instance._defaultDropNotAllowedCursorTemplate;
					global::Infragistics.DragDrop.DragDropManager._instance._currentMoveCursorTemplate = global::Infragistics.DragDrop.DragDropManager._instance._defaultMoveCursorTemplate;
					global::Infragistics.DragDrop.DragDropManager._instance._currentCopyCursorTemplate = global::Infragistics.DragDrop.DragDropManager._instance._defaultCopyCursorTemplate;
					global::Infragistics.DragDrop.DragDropManager._instance._currentCursorTemplate = global::Infragistics.DragDrop.DragDropManager._instance._defaultMoveCursorTemplate;
				}
				return global::Infragistics.DragDrop.DragDropManager._instance;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000023C7 File Offset: 0x000005C7
		// (set) Token: 0x06000012 RID: 18 RVA: 0x000023CF File Offset: 0x000005CF
		private global::System.Exception Error
		{
			get
			{
				return this._error;
			}
			set
			{
				if (this._error == null || value == null)
				{
					this._error = value;
				}
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000023E3 File Offset: 0x000005E3
		private static global::System.Collections.Generic.List<global::System.WeakReference> RegisteredDragSources
		{
			get
			{
				if (global::Infragistics.DragDrop.DragDropManager.Instance._registeredDragSources == null)
				{
					global::Infragistics.DragDrop.DragDropManager.Instance._registeredDragSources = new global::System.Collections.Generic.List<global::System.WeakReference>();
				}
				return global::Infragistics.DragDrop.DragDropManager.Instance._registeredDragSources;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000240A File Offset: 0x0000060A
		protected static global::System.Windows.UIElement CursorPopup
		{
			get
			{
				return global::Infragistics.DragDrop.DragDropManager.Instance._cursorPopup;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002418 File Offset: 0x00000618
		public static void EndDrag(bool dragCancel)
		{
			global::Infragistics.DragDrop.DragDropManager.Instance._endDrag = true;
			global::Infragistics.DragDrop.DragDropManager.Instance._mouseMoving = false;
			if (global::Infragistics.DragDrop.DragDropManager.Instance._dragging)
			{
				global::System.Windows.UIElement hostChild = global::Infragistics.DragDrop.PlatformProxy.GetHostChild(global::Infragistics.DragDrop.DragDropManager.Instance._dragPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual);
				if (global::Infragistics.DragDrop.DragDropManager.Instance._dragPopup != null && hostChild != null)
				{
					((global::System.Windows.FrameworkElement)hostChild).SizeChanged -= global::Infragistics.DragDrop.DragDropManager.DragPopupSizeChanged;
				}
				if (global::Infragistics.DragDrop.DragDropManager.Instance._cursorPopup != null)
				{
					global::System.Windows.UIElement hostChild2 = global::Infragistics.DragDrop.PlatformProxy.GetHostChild(global::Infragistics.DragDrop.DragDropManager.Instance._cursorPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual);
					global::Infragistics.DragDrop.PlatformProxy.CloseHost(global::Infragistics.DragDrop.DragDropManager.Instance._cursorPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, true, true);
					global::System.Windows.FrameworkElement frameworkElement = hostChild2 as global::System.Windows.FrameworkElement;
					if (frameworkElement != null)
					{
						frameworkElement.SizeChanged -= global::Infragistics.DragDrop.DragDropManager.CursorPopupSizeChanged;
					}
				}
				global::System.Windows.FrameworkElement frameworkElement2 = global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement as global::System.Windows.FrameworkElement;
				if (frameworkElement2 != null && global::Infragistics.DragDrop.DragDropManager.Instance._gotCursor)
				{
					if (frameworkElement2.Cursor == global::System.Windows.Input.Cursors.None)
					{
						frameworkElement2.Cursor = global::Infragistics.DragDrop.DragDropManager.Instance._originalCursor;
					}
					global::Infragistics.DragDrop.DragDropManager.Instance._originalCursor = null;
				}
				if (global::Infragistics.DragDrop.DragDropManager.Instance._targetMarkerPopup != null)
				{
					global::Infragistics.DragDrop.PlatformProxy.CloseHost(global::Infragistics.DragDrop.DragDropManager.Instance._targetMarkerPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, true, true);
					global::Infragistics.DragDrop.DragDropManager.Instance._targetMarkerPopup = null;
				}
				global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual.KeyDown -= global::Infragistics.DragDrop.DragDropManager.CursorPopupKeyDown;
				global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual.KeyUp -= global::Infragistics.DragDrop.DragDropManager.CursorPopupKeyUp;
				if (global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement != null)
				{
					global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement.MouseMove -= global::Infragistics.DragDrop.DragDropManager.OnMouseMove;
					global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement.RemoveHandler(global::System.Windows.UIElement.MouseLeftButtonUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Infragistics.DragDrop.DragDropManager.OnMouseLeftButtonUp));
				}
				if (dragCancel)
				{
					global::Infragistics.DragDrop.DragDropManager.OnDragCancel();
				}
				else if (global::Infragistics.DragDrop.DragDropManager.Instance._dropTargetElement != null)
				{
					global::Infragistics.DragDrop.DragDropManager.OnDrop(global::Infragistics.DragDrop.DragDropManager.Instance._mouseEventArgs);
				}
				global::Infragistics.DragDrop.DragDropManager.OnDragEnd();
			}
			global::Infragistics.DragDrop.DragDropManager.Instance._cursorPopup = null;
			global::Infragistics.DragDrop.DragDropManager.Instance._targetMarkerPopup = null;
			global::Infragistics.DragDrop.DragDropManager.Instance._gotCursor = false;
			global::Infragistics.DragDrop.DragDropManager.Instance._dragSourceElement = null;
			global::Infragistics.DragDrop.DragDropManager.Instance._dragSource = null;
			global::Infragistics.DragDrop.DragDropManager.Instance._originalDragSourceElement = null;
			global::Infragistics.DragDrop.DragDropManager.Instance._dropTargetElement = null;
			global::Infragistics.DragDrop.DragDropManager.Instance._dropTarget = null;
			global::Infragistics.DragDrop.DragDropManager.Instance._draggedElement = null;
			global::Infragistics.DragDrop.DragDropManager.Instance._dragDropEventArgs = null;
			global::Infragistics.DragDrop.DragDropManager.Instance._dragSourceDragTemplate = null;
			global::Infragistics.DragDrop.DragDropManager.Instance._mouseEventArgs = null;
			global::Infragistics.DragDrop.DragDropManager.Instance._dragObject = null;
			global::Infragistics.DragDrop.DragDropManager.Instance._snapshotImage = null;
			global::Infragistics.DragDrop.DragDropManager.Instance._mousePosition = default(global::System.Windows.Point);
			global::Infragistics.DragDrop.DragDropManager.Instance._mouseOffset = default(global::System.Windows.Point);
			global::Infragistics.DragDrop.DragDropManager.Instance._initialMousePosition = default(global::System.Windows.Point);
			global::Infragistics.DragDrop.DragDropManager.Instance._customMoveCursorTemplate = null;
			global::Infragistics.DragDrop.DragDropManager.Instance._customMoveCursorTemplate = global::Infragistics.DragDrop.DragDropManager.Instance._defaultMoveCursorTemplate;
			global::Infragistics.DragDrop.DragDropManager.Instance._customDropNotAllowedCursorTemplate = null;
			global::Infragistics.DragDrop.DragDropManager.Instance._currentDropNotAllowedCursorTemplate = global::Infragistics.DragDrop.DragDropManager.Instance._defaultDropNotAllowedCursorTemplate;
			global::Infragistics.DragDrop.DragDropManager.Instance._customCopyCursorTemplate = null;
			global::Infragistics.DragDrop.DragDropManager.Instance._currentCopyCursorTemplate = global::Infragistics.DragDrop.DragDropManager.Instance._defaultCopyCursorTemplate;
			global::Infragistics.DragDrop.DragDropManager.Instance._currentCursorTemplate = global::Infragistics.DragDrop.DragDropManager.Instance._defaultMoveCursorTemplate;
			if (global::Infragistics.DragDrop.DragDropManager.Instance._dragContentControl != null)
			{
				global::Infragistics.DragDrop.DragDropManager.Instance._dragContentControl.ContentTemplate = null;
				global::Infragistics.DragDrop.DragDropManager.Instance._dragContentControl.Content = null;
				global::Infragistics.DragDrop.DragDropManager.Instance._dragContentControl = null;
			}
			if (global::Infragistics.DragDrop.DragDropManager.Instance._customCursorContentControl != null)
			{
				global::Infragistics.DragDrop.DragDropManager.Instance._customCursorContentControl.ContentTemplate = global::Infragistics.DragDrop.DragDropManager.Instance._currentCursorTemplate;
				global::Infragistics.DragDrop.DragDropManager.Instance._customCursorContentControl.Content = null;
				global::Infragistics.DragDrop.DragDropManager.Instance._customCursorContentControl = null;
			}
			if (global::Infragistics.DragDrop.DragDropManager.Instance._dragPopup != null)
			{
				global::Infragistics.DragDrop.PlatformProxy.CloseHost(global::Infragistics.DragDrop.DragDropManager.Instance._dragPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, true, true);
			}
			global::Infragistics.DragDrop.DragDropManager.Instance._dragPopup = null;
			global::Infragistics.DragDrop.DragDropManager.Instance._mouseCaptured = false;
			global::Infragistics.DragDrop.DragDropManager.Instance._waitDragStart = false;
			global::Infragistics.DragDrop.DragDropManager.Instance._dragging = false;
			if (global::Infragistics.DragDrop.DragDropManager.Instance._needReleaseMouse)
			{
				if (global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement != null)
				{
					global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement.ReleaseMouseCapture();
				}
				global::Infragistics.DragDrop.DragDropManager.Instance._needReleaseMouse = false;
			}
			global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement = null;
			global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual = null;
			global::Infragistics.DragDrop.DragDropManager.Instance._popupHost = null;
			if (global::Infragistics.DragDrop.DragDropManager.Instance.Error != null)
			{
				global::System.Exception error = global::Infragistics.DragDrop.DragDropManager.Instance.Error;
				global::Infragistics.DragDrop.DragDropManager.Instance.Error = null;
				throw error;
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002885 File Offset: 0x00000A85
		public static void RefreshDragLayout()
		{
			global::Infragistics.DragDrop.PlatformProxy.RefreshHostsLayout(global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, global::Infragistics.DragDrop.DragDropManager.Instance._dragPopup, global::Infragistics.DragDrop.DragDropManager.Instance._cursorPopup, global::Infragistics.DragDrop.DragDropManager.Instance._targetMarkerPopup);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000028E0 File Offset: 0x00000AE0
		public static global::System.Collections.Generic.IEnumerable<global::Infragistics.DragDrop.DropTarget> GetDropTargets(global::System.Collections.Generic.IEnumerable<string> channels)
		{
			global::System.Collections.Generic.IList<global::System.Windows.UIElement> list = new global::System.Collections.Generic.List<global::System.Windows.UIElement>();
			for (int i = global::Infragistics.DragDrop.DragDropManager.Instance._dropTargets.Count - 1; i >= 0; i--)
			{
				global::System.WeakReference weakReference = global::Infragistics.DragDrop.DragDropManager.Instance._dropTargets[i];
				if (!weakReference.IsAlive)
				{
					global::Infragistics.DragDrop.DragDropManager.Instance._dropTargets.RemoveAt(i);
				}
				else
				{
					list.Add((global::System.Windows.UIElement)weakReference.Target);
				}
			}
			global::System.Collections.Generic.IEnumerable<global::Infragistics.DragDrop.DropTarget> enumerable = from dt in list.Select(new global::System.Func<global::System.Windows.UIElement, global::Infragistics.DragDrop.DropTarget>(global::Infragistics.DragDrop.DragDropManager.GetDropTarget))
			where dt != null
			select dt;
			if (channels == null)
			{
				return enumerable;
			}
			return from dt in enumerable
			where channels.Intersect(dt.DropChannels).Any<string>()
			select dt;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000029AD File Offset: 0x00000BAD
		private static void ApplyCursorTemplate()
		{
			if (global::Infragistics.DragDrop.DragDropManager.Instance._dropTargetElement == null)
			{
				global::Infragistics.DragDrop.DragDropManager.ApplyCursorTemplate(new global::Infragistics.DragDrop.OperationType?(global::Infragistics.DragDrop.OperationType.DropNotAllowed));
				return;
			}
			if ((global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Control) == global::System.Windows.Input.ModifierKeys.Control)
			{
				global::Infragistics.DragDrop.DragDropManager.ApplyCursorTemplate(new global::Infragistics.DragDrop.OperationType?(global::Infragistics.DragDrop.OperationType.Copy));
				return;
			}
			global::Infragistics.DragDrop.DragDropManager.ApplyCursorTemplate(new global::Infragistics.DragDrop.OperationType?(global::Infragistics.DragDrop.OperationType.Move));
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000029E8 File Offset: 0x00000BE8
		private static void ApplyCursorTemplate(global::Infragistics.DragDrop.OperationType? operationType)
		{
			if (global::Infragistics.DragDrop.DragDropManager.Instance._cursorPopup != null)
			{
				global::System.Windows.DataTemplate dataTemplate = null;
				global::Infragistics.DragDrop.OperationType valueOrDefault = operationType.GetValueOrDefault();
				if (operationType != null)
				{
					switch (valueOrDefault)
					{
					case global::Infragistics.DragDrop.OperationType.DropNotAllowed:
					{
						global::Infragistics.DragDrop.DragDropManager instance = global::Infragistics.DragDrop.DragDropManager.Instance;
						global::System.Windows.DataTemplate currentDropNotAllowedCursorTemplate;
						if ((currentDropNotAllowedCursorTemplate = global::Infragistics.DragDrop.DragDropManager.Instance._customDropNotAllowedCursorTemplate) == null)
						{
							currentDropNotAllowedCursorTemplate = (global::Infragistics.DragDrop.DragDropManager.Instance._dragSource.DropNotAllowedCursorTemplate ?? global::Infragistics.DragDrop.DragDropManager.Instance._defaultDropNotAllowedCursorTemplate);
						}
						instance._currentDropNotAllowedCursorTemplate = currentDropNotAllowedCursorTemplate;
						dataTemplate = global::Infragistics.DragDrop.DragDropManager.Instance._currentDropNotAllowedCursorTemplate;
						break;
					}
					case global::Infragistics.DragDrop.OperationType.Copy:
					{
						global::Infragistics.DragDrop.DragDropManager instance2 = global::Infragistics.DragDrop.DragDropManager.Instance;
						global::System.Windows.DataTemplate currentCopyCursorTemplate;
						if ((currentCopyCursorTemplate = global::Infragistics.DragDrop.DragDropManager.Instance._customCopyCursorTemplate) == null)
						{
							currentCopyCursorTemplate = (global::Infragistics.DragDrop.DragDropManager.Instance._dragSource.CopyCursorTemplate ?? global::Infragistics.DragDrop.DragDropManager.Instance._defaultCopyCursorTemplate);
						}
						instance2._currentCopyCursorTemplate = currentCopyCursorTemplate;
						dataTemplate = global::Infragistics.DragDrop.DragDropManager.Instance._currentCopyCursorTemplate;
						break;
					}
					case global::Infragistics.DragDrop.OperationType.Move:
					{
						global::Infragistics.DragDrop.DragDropManager instance3 = global::Infragistics.DragDrop.DragDropManager.Instance;
						global::System.Windows.DataTemplate currentMoveCursorTemplate;
						if ((currentMoveCursorTemplate = global::Infragistics.DragDrop.DragDropManager.Instance._customMoveCursorTemplate) == null)
						{
							currentMoveCursorTemplate = (global::Infragistics.DragDrop.DragDropManager.Instance._dragSource.MoveCursorTemplate ?? global::Infragistics.DragDrop.DragDropManager.Instance._defaultMoveCursorTemplate);
						}
						instance3._currentMoveCursorTemplate = currentMoveCursorTemplate;
						dataTemplate = global::Infragistics.DragDrop.DragDropManager.Instance._currentMoveCursorTemplate;
						break;
					}
					}
				}
				if (dataTemplate != null)
				{
					if (dataTemplate.Equals(global::Infragistics.DragDrop.DragDropManager.Instance._currentCursorTemplate))
					{
						return;
					}
					global::Infragistics.DragDrop.DragDropManager.Instance._currentCursorTemplate = dataTemplate;
					global::Infragistics.DragDrop.DragDropManager.Instance._customCursorContentControl.ContentTemplate = dataTemplate;
				}
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002B28 File Offset: 0x00000D28
		private static void ApplyDragTemplate(global::System.Windows.DataTemplate dataTemplate)
		{
			if (dataTemplate != null && dataTemplate != global::Infragistics.DragDrop.DragDropManager.Instance._dragContentControl.ContentTemplate)
			{
				global::Infragistics.DragDrop.DragDropManager.Instance._dragContentControl.Content = global::Infragistics.DragDrop.DragDropManager.Instance._dragObject;
				global::Infragistics.DragDrop.DragDropManager.Instance._dragContentControl.ContentTemplate = dataTemplate;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002B68 File Offset: 0x00000D68
		private static void CatchDragImage(global::System.Windows.UIElement snapshotElement)
		{
			global::System.Windows.FrameworkElement frameworkElement = snapshotElement as global::System.Windows.FrameworkElement;
			if (frameworkElement == null)
			{
				return;
			}
			double num = global::System.Math.Max(frameworkElement.DesiredSize.Width, frameworkElement.ActualWidth);
			double num2 = global::System.Math.Max(frameworkElement.DesiredSize.Height, frameworkElement.ActualHeight);
			global::System.Windows.Media.Imaging.RenderTargetBitmap renderTargetBitmap = new global::System.Windows.Media.Imaging.RenderTargetBitmap((int)num, (int)num2, 96.0, 96.0, global::System.Windows.Media.PixelFormats.Pbgra32);
			global::System.Windows.Rect layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(frameworkElement);
			global::System.Windows.Size size = new global::System.Windows.Size(num, num2);
			frameworkElement.Measure(size);
			frameworkElement.Arrange(new global::System.Windows.Rect(size));
			renderTargetBitmap.Render(frameworkElement);
			global::System.Windows.Media.Imaging.WriteableBitmap source = new global::System.Windows.Media.Imaging.WriteableBitmap(renderTargetBitmap);
			frameworkElement.Arrange(layoutSlot);
			global::Infragistics.DragDrop.DragDropManager.Instance._snapshotImage = new global::System.Windows.Controls.Image
			{
				Width = num,
				Height = num2,
				Source = source
			};
			if (frameworkElement.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
			{
				global::Infragistics.DragDrop.DragDropManager.Instance._snapshotImage.LayoutTransform = new global::System.Windows.Media.ScaleTransform(-1.0, 1.0);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002C84 File Offset: 0x00000E84
		private static bool ChannelsMatch(global::System.Windows.DependencyObject source, global::System.Windows.DependencyObject target)
		{
			bool result = false;
			global::Infragistics.DragDrop.DragSource dragSource = global::Infragistics.DragDrop.DragDropManager.GetDragSource(source);
			global::Infragistics.DragDrop.DropTarget dropTarget = global::Infragistics.DragDrop.DragDropManager.GetDropTarget(target);
			if (dragSource == null || dropTarget == null)
			{
				return false;
			}
			if (dragSource.DragChannels == null && dropTarget.DropChannels == null)
			{
				return true;
			}
			if (dragSource.DragChannels != null && dragSource.DragChannels.Count == 0 && dropTarget.DropChannels != null && dropTarget.DropChannels.Count == 0)
			{
				return true;
			}
			if (dragSource.DragChannels != null && dropTarget.DropChannels != null)
			{
				foreach (string b in dropTarget.DropChannels)
				{
					foreach (string a in dragSource.DragChannels)
					{
						if (a == b)
						{
							result = true;
							break;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002D80 File Offset: 0x00000F80
		private static global::System.Windows.UIElement FindTargetInRoot(global::System.Windows.Point position, global::System.Windows.UIElement reference)
		{
			global::System.Windows.Media.VisualTreeHelper.HitTest(reference, new global::System.Windows.Media.HitTestFilterCallback(global::Infragistics.DragDrop.DragDropManager.HitTestFilterInvisible), new global::System.Windows.Media.HitTestResultCallback(global::Infragistics.DragDrop.DragDropManager.HitTestResultCallback), new global::System.Windows.Media.PointHitTestParameters(position));
			global::System.Windows.UIElement target = global::Infragistics.DragDrop.DragDropManager.Instance._target;
			global::Infragistics.DragDrop.DragDropManager.Instance._target = null;
			if (target != null)
			{
				global::Infragistics.DragDrop.DragDropManager.IsPopupHosted(target, out global::Infragistics.DragDrop.DragDropManager.Instance._popupHost);
			}
			return target;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002DE0 File Offset: 0x00000FE0
		private static bool IsPopupHosted(global::System.Windows.UIElement instance, out global::System.Windows.Controls.Primitives.Popup host)
		{
			global::System.Windows.Controls.Primitives.Popup popup = null;
			host = null;
			global::System.Windows.FrameworkElement frameworkElement = instance as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				popup = (frameworkElement.Parent as global::System.Windows.Controls.Primitives.Popup);
			}
			if (popup != null && popup != global::Infragistics.DragDrop.DragDropManager.Instance._dragPopup && popup != global::Infragistics.DragDrop.DragDropManager.Instance._cursorPopup && popup != global::Infragistics.DragDrop.DragDropManager.Instance._targetMarkerPopup)
			{
				host = popup;
				return true;
			}
			return false;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002E38 File Offset: 0x00001038
		private static global::System.Windows.Media.HitTestFilterBehavior HitTestFilterInvisible(global::System.Windows.DependencyObject potentialHitTestTarget)
		{
			bool flag = false;
			global::System.Windows.UIElement uielement = potentialHitTestTarget as global::System.Windows.UIElement;
			bool isVisible;
			if (uielement != null)
			{
				isVisible = uielement.IsVisible;
				if (isVisible)
				{
					flag = uielement.IsHitTestVisible;
				}
			}
			else
			{
				global::System.Windows.UIElement3D uielement3D = potentialHitTestTarget as global::System.Windows.UIElement3D;
				if (uielement3D == null)
				{
					return global::System.Windows.Media.HitTestFilterBehavior.Continue;
				}
				isVisible = uielement3D.IsVisible;
				if (isVisible)
				{
					flag = uielement3D.IsHitTestVisible;
				}
			}
			if (!isVisible)
			{
				return global::System.Windows.Media.HitTestFilterBehavior.ContinueSkipSelfAndChildren;
			}
			if (!flag)
			{
				return global::System.Windows.Media.HitTestFilterBehavior.ContinueSkipSelf;
			}
			return global::System.Windows.Media.HitTestFilterBehavior.Continue;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002E90 File Offset: 0x00001090
		private static global::System.Windows.Media.HitTestResultBehavior HitTestResultCallback(global::System.Windows.Media.HitTestResult result)
		{
			for (global::System.Windows.DependencyObject dependencyObject = result.VisualHit; dependencyObject != null; dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject))
			{
				global::System.Windows.UIElement uielement = dependencyObject as global::System.Windows.UIElement;
				if (uielement != null && global::Infragistics.DragDrop.DragDropManager.Instance._dropTargets.Contains(uielement))
				{
					if (global::Infragistics.DragDrop.DragDropManager.ChannelsMatch(global::Infragistics.DragDrop.DragDropManager.Instance._dragSourceElement, uielement))
					{
						global::Infragistics.DragDrop.DragDropManager.Instance._target = uielement;
						return global::System.Windows.Media.HitTestResultBehavior.Stop;
					}
					if (global::Infragistics.DragDrop.DragDropManager.Instance._dragSource.FindDropTargetMode == global::Infragistics.DragDrop.FindDropTargetMode.TopMostTargetOnly)
					{
						return global::System.Windows.Media.HitTestResultBehavior.Stop;
					}
				}
			}
			return global::System.Windows.Media.HitTestResultBehavior.Continue;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002FA0 File Offset: 0x000011A0
		private static global::System.Windows.UIElement FindTarget(global::System.Windows.Input.MouseEventArgs e)
		{
			global::System.Windows.Point position = e.GetPosition(null);
			if (!global::Infragistics.DragDrop.DragDropManager.isThreadIdInitialized)
			{
				global::Infragistics.DragDrop.DragDropManager._currentThreadId = global::Infragistics.DragDrop.PlatformProxy.GetCurrentThreadId();
				global::Infragistics.DragDrop.DragDropManager.isThreadIdInitialized = true;
			}
			global::System.Collections.Generic.IList<global::System.Windows.FrameworkElement> enumeratedWindows = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>();
			global::System.Collections.Generic.IList<global::System.Windows.FrameworkElement> popupRoots = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>();
			global::Infragistics.DragDrop.PlatformProxy.EnumWindowsProc lpfn = delegate(global::System.IntPtr hwnd, global::System.IntPtr lParam)
			{
				global::System.Windows.Interop.HwndSource hwndSource = global::System.Windows.Interop.HwndSource.FromHwnd(hwnd);
				if (hwndSource != null && hwndSource.RootVisual != null)
				{
					global::System.Windows.Window window = hwndSource.RootVisual as global::System.Windows.Window;
					if (window != null)
					{
						enumeratedWindows.Add(window);
					}
					else if (hwndSource.RootVisual.GetType().Name == "PopupRoot")
					{
						popupRoots.Add((global::System.Windows.FrameworkElement)hwndSource.RootVisual);
					}
				}
				return true;
			};
			global::Infragistics.DragDrop.PlatformProxy.EnumThreadWindows(global::Infragistics.DragDrop.DragDropManager._currentThreadId, lpfn, global::System.IntPtr.Zero);
			global::System.Collections.Generic.IList<global::System.Windows.PresentationSource> list = (from global::System.Windows.PresentationSource ps in global::System.Windows.PresentationSource.CurrentSources
			where ps.RootVisual != null && ps.RootVisual.GetType().Name != "PopupRoot"
			select ps).ToList<global::System.Windows.PresentationSource>();
			foreach (global::System.Windows.PresentationSource presentationSource in list)
			{
				if (presentationSource.RootVisual != null)
				{
					if (presentationSource.RootVisual == global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual)
					{
						if (!enumeratedWindows.Contains((global::System.Windows.FrameworkElement)presentationSource.RootVisual))
						{
							enumeratedWindows.Add((global::System.Windows.FrameworkElement)presentationSource.RootVisual);
						}
					}
					else if (presentationSource.RootVisual.GetType().Name == "RootBrowserWindow")
					{
						if (!enumeratedWindows.Contains((global::System.Windows.FrameworkElement)presentationSource.RootVisual))
						{
							enumeratedWindows.Add((global::System.Windows.FrameworkElement)presentationSource.RootVisual);
						}
					}
					else
					{
						global::System.Windows.Documents.AdornerDecorator adornerDecorator = presentationSource.RootVisual as global::System.Windows.Documents.AdornerDecorator;
						if (adornerDecorator != null && adornerDecorator.Child.GetType().Name == "AvalonAdapter" && !enumeratedWindows.Contains((global::System.Windows.FrameworkElement)presentationSource.RootVisual))
						{
							enumeratedWindows.Add((global::System.Windows.FrameworkElement)presentationSource.RootVisual);
						}
					}
				}
			}
			foreach (global::System.Windows.FrameworkElement frameworkElement in popupRoots)
			{
				position = e.GetPosition(frameworkElement);
				global::System.Windows.UIElement uielement = global::Infragistics.DragDrop.DragDropManager.FindTargetInRoot(position, frameworkElement);
				if (uielement != null)
				{
					return uielement;
				}
			}
			bool flag = false;
			global::System.Windows.Documents.AdornerDecorator adornerDecorator2 = global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement as global::System.Windows.Documents.AdornerDecorator;
			if (adornerDecorator2 == null)
			{
				adornerDecorator2 = (global::Infragistics.DragDrop.PlatformProxy.GetRootVisual(global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement) as global::System.Windows.Documents.AdornerDecorator);
			}
			if (adornerDecorator2 != null && adornerDecorator2.Child.GetType().Name == "AvalonAdapter")
			{
				int num = 0;
				foreach (global::System.Windows.FrameworkElement reference in enumeratedWindows)
				{
					global::System.Windows.Media.HitTestResult hitTestResult = global::System.Windows.Media.VisualTreeHelper.HitTest(reference, position);
					if (hitTestResult != null)
					{
						num++;
					}
				}
				if (num > 1)
				{
					flag = true;
				}
			}
			foreach (global::System.Windows.FrameworkElement frameworkElement2 in enumeratedWindows)
			{
				if (frameworkElement2 != global::Infragistics.DragDrop.DragDropManager.Instance._dragPopup && frameworkElement2 != global::Infragistics.DragDrop.DragDropManager.Instance._cursorPopup && frameworkElement2 != global::Infragistics.DragDrop.DragDropManager.Instance._targetMarkerPopup && (!flag || frameworkElement2 == adornerDecorator2))
				{
					position = e.GetPosition(frameworkElement2);
					global::System.Windows.UIElement uielement = global::Infragistics.DragDrop.DragDropManager.FindTargetInRoot(position, frameworkElement2);
					if (uielement != null)
					{
						return uielement;
					}
					global::System.Windows.Media.HitTestResult hitTestResult2 = global::System.Windows.Media.VisualTreeHelper.HitTest(frameworkElement2, position);
				}
			}
			return null;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003358 File Offset: 0x00001558
		private static void GenerateTargetMarker(global::System.Windows.FrameworkElement target)
		{
			global::System.Windows.UIElement uielement = null;
			if (global::Infragistics.DragDrop.DragDropManager.Instance._popupHost != null)
			{
				uielement = global::Infragistics.DragDrop.DragDropManager.Instance._popupHost.Child;
			}
			else if (target != null)
			{
				uielement = global::Infragistics.DragDrop.PlatformProxy.GetRootVisual(target);
			}
			if (uielement == null)
			{
				return;
			}
			global::Infragistics.DragDrop.DragDropManager.Instance._targetMarkerPopup = global::Infragistics.DragDrop.PlatformProxy.GetHost(uielement, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, null);
			global::System.Windows.Controls.StackPanel stackPanel = new global::System.Windows.Controls.StackPanel();
			global::System.Windows.Controls.Border border = new global::System.Windows.Controls.Border
			{
				Background = global::Infragistics.DragDrop.DragDropManager.Instance._dropTarget.DropTargetMarkerBrush,
				CornerRadius = new global::System.Windows.CornerRadius(2.0),
				Opacity = 0.4
			};
			global::System.Windows.Media.TransformGroup transformGroup = new global::System.Windows.Media.TransformGroup();
			if (target.RenderTransform != null)
			{
				global::System.Windows.Media.TransformGroup transformGroup2 = target.RenderTransform as global::System.Windows.Media.TransformGroup;
				if (transformGroup2 != null)
				{
					foreach (global::System.Windows.Media.Transform transform in transformGroup2.Children)
					{
						if (transform is global::System.Windows.Media.ScaleTransform || transform is global::System.Windows.Media.RotateTransform)
						{
							transformGroup.Children.Add(transform);
						}
					}
				}
				if (target.RenderTransform is global::System.Windows.Media.ScaleTransform || target.RenderTransform is global::System.Windows.Media.RotateTransform)
				{
					transformGroup.Children.Add(target.RenderTransform);
				}
			}
			if (transformGroup.Children.Count > 0)
			{
				border.RenderTransform = transformGroup;
			}
			stackPanel.Children.Add(border);
			global::System.Windows.Point point;
			if (global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual.GetType().Name == "RootBrowserWindow")
			{
				point = target.PointToScreen(new global::System.Windows.Point(0.0, 0.0));
			}
			else if (target.IsDescendantOf(uielement))
			{
				global::System.Windows.Media.GeneralTransform generalTransform = target.TransformToVisual(uielement);
				point = generalTransform.Transform(new global::System.Windows.Point(0.0, 0.0));
			}
			else
			{
				point = new global::System.Windows.Point(0.0, 0.0);
			}
			double num = point.Y;
			double num2 = point.X;
			if (target.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
			{
				num2 -= target.RenderSize.Width;
			}
			if (global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual.GetType().Name != "RootBrowserWindow" && (((global::System.Windows.FrameworkElement)uielement).FlowDirection == global::System.Windows.FlowDirection.RightToLeft ^ global::System.Windows.SystemParameters.IsMenuDropRightAligned))
			{
				num2 += target.RenderSize.Width;
			}
			global::System.Windows.Media.Geometry layoutClip = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutClip(target);
			if (layoutClip == null)
			{
				border.Width = target.ActualWidth;
				border.Height = target.ActualHeight;
			}
			else
			{
				double height;
				if (layoutClip.Bounds.Top > 0.0)
				{
					height = layoutClip.Bounds.Height;
					num += layoutClip.Bounds.Top;
				}
				else
				{
					height = global::System.Math.Min(target.RenderSize.Height, layoutClip.Bounds.Height);
				}
				double num3;
				if (target.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
				{
					num3 = target.RenderSize.Width - layoutClip.Bounds.Right;
				}
				else
				{
					num3 = layoutClip.Bounds.Left;
				}
				num2 += num3;
				double width = global::System.Math.Min(target.RenderSize.Width, layoutClip.Bounds.Width);
				border.Width = width;
				border.Height = height;
			}
			global::Infragistics.DragDrop.PlatformProxy.SetHostPosition(global::Infragistics.DragDrop.DragDropManager.Instance._targetMarkerPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, num, num2);
			global::Infragistics.DragDrop.PlatformProxy.SetHostSize(global::Infragistics.DragDrop.DragDropManager.Instance._targetMarkerPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, border.Width, border.Height);
			global::Infragistics.DragDrop.PlatformProxy.OpenHost(global::Infragistics.DragDrop.DragDropManager.Instance._targetMarkerPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, stackPanel);
			global::Infragistics.DragDrop.PlatformProxy.CloseHost(global::Infragistics.DragDrop.DragDropManager.Instance._dragPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, false, false);
			if (global::Infragistics.DragDrop.DragDropManager.Instance._cursorPopup != null)
			{
				global::Infragistics.DragDrop.PlatformProxy.CloseHost(global::Infragistics.DragDrop.DragDropManager.Instance._cursorPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, false, false);
			}
			global::Infragistics.DragDrop.PlatformProxy.OpenHost(global::Infragistics.DragDrop.DragDropManager.Instance._dragPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, null);
			if (global::Infragistics.DragDrop.DragDropManager.Instance._cursorPopup != null)
			{
				global::Infragistics.DragDrop.PlatformProxy.OpenHost(global::Infragistics.DragDrop.DragDropManager.Instance._cursorPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, null);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000037C8 File Offset: 0x000019C8
		private static global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Windows.UIElement> GetElementsInDropTarget()
		{
			global::System.Collections.Generic.List<global::System.Windows.UIElement> list = new global::System.Collections.Generic.List<global::System.Windows.UIElement>(1)
			{
				global::Infragistics.DragDrop.DragDropManager.Instance._dropTargetElement
			};
			return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Windows.UIElement>(list);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000037F4 File Offset: 0x000019F4
		private static global::Infragistics.DragDrop.DragDropEventArgs GetDragDropEventArgs()
		{
			if (global::Infragistics.DragDrop.DragDropManager.Instance._dragDropEventArgs == null)
			{
				global::Infragistics.DragDrop.DragDropManager.Instance._dragDropEventArgs = new global::Infragistics.DragDrop.DragDropEventArgs
				{
					DragSource = global::Infragistics.DragDrop.DragDropManager.Instance._dragSourceElement,
					OriginalDragSource = global::Infragistics.DragDrop.DragDropManager.Instance._originalDragSourceElement,
					OperationType = null
				};
				global::Infragistics.DragDrop.DragSource dragSource = global::Infragistics.DragDrop.DragDropManager.Instance._dragSource;
				if (dragSource != null)
				{
					if (dragSource.DragTemplate != null)
					{
						global::Infragistics.DragDrop.DragDropManager.Instance._dragDropEventArgs.DragTemplate = dragSource.DragTemplate;
					}
					global::Infragistics.DragDrop.DragDropManager.Instance._dragDropEventArgs.CopyCursorTemplate = (dragSource.CopyCursorTemplate ?? global::Infragistics.DragDrop.DragDropManager.Instance._defaultCopyCursorTemplate);
					global::Infragistics.DragDrop.DragDropManager.Instance._dragDropEventArgs.MoveCursorTemplate = (dragSource.MoveCursorTemplate ?? global::Infragistics.DragDrop.DragDropManager.Instance._defaultMoveCursorTemplate);
					global::Infragistics.DragDrop.DragDropManager.Instance._dragDropEventArgs.DropNotAllowedCursorTemplate = (dragSource.DropNotAllowedCursorTemplate ?? global::Infragistics.DragDrop.DragDropManager.Instance._defaultDropNotAllowedCursorTemplate);
					global::System.Windows.Data.BindingExpression bindingExpression = global::System.Windows.Data.BindingOperations.GetBindingExpression(dragSource, global::Infragistics.DragDrop.DragSource.DataObjectProperty);
					if (dragSource.DataObject == null && bindingExpression != null)
					{
						bindingExpression.UpdateTarget();
					}
					global::Infragistics.DragDrop.DragDropManager.Instance._dragDropEventArgs.Data = dragSource.DataObject;
				}
			}
			return global::Infragistics.DragDrop.DragDropManager.Instance._dragDropEventArgs;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003924 File Offset: 0x00001B24
		private static void ShowDragPopup()
		{
			global::System.Windows.DataTemplate contentTemplate = global::Infragistics.DragDrop.DragDropManager.Instance._dragSourceDragTemplate ?? global::Infragistics.DragDrop.DragDropManager.Instance._defaultDragTemplate;
			global::Infragistics.DragDrop.DragDropManager.Instance._dragObject = new global::Infragistics.DragDrop.DragObject
			{
				DragImage = global::Infragistics.DragDrop.DragDropManager.Instance._snapshotImage,
				Data = global::Infragistics.DragDrop.DragDropManager.Instance._dragDropEventArgs.Data
			};
			if (global::Infragistics.DragDrop.DragDropManager.Instance._dragContentControl == null)
			{
				global::Infragistics.DragDrop.DragDropManager.Instance._dragContentControl = new global::System.Windows.Controls.ContentControl
				{
					ContentTemplate = contentTemplate,
					Content = global::Infragistics.DragDrop.DragDropManager.Instance._dragObject
				};
			}
			else
			{
				global::Infragistics.DragDrop.DragDropManager.Instance._dragContentControl.Content = global::Infragistics.DragDrop.DragDropManager.Instance._dragObject;
				global::Infragistics.DragDrop.DragDropManager.Instance._dragContentControl.ContentTemplate = contentTemplate;
			}
			global::Infragistics.DragDrop.DragDropManager.Instance._dragContentControl.SizeChanged += global::Infragistics.DragDrop.DragDropManager.DragPopupSizeChanged;
			global::System.Windows.FrameworkElement frameworkElement = global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement as global::System.Windows.FrameworkElement;
			if (frameworkElement != null && !global::Infragistics.DragDrop.DragDropManager.Instance._gotCursor)
			{
				global::Infragistics.DragDrop.DragDropManager.Instance._originalCursor = frameworkElement.Cursor;
				frameworkElement.Cursor = global::System.Windows.Input.Cursors.None;
				global::Infragistics.DragDrop.DragDropManager.Instance._gotCursor = true;
			}
			global::Infragistics.DragDrop.PlatformProxy.OpenHost(global::Infragistics.DragDrop.DragDropManager.Instance._dragPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, global::Infragistics.DragDrop.DragDropManager.Instance._dragContentControl);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003A64 File Offset: 0x00001C64
		private static void ShowCursorPopup()
		{
			if (global::Infragistics.DragDrop.DragDropManager.Instance._cursorPopup != null)
			{
				global::Infragistics.DragDrop.PlatformProxy.CloseHost(global::Infragistics.DragDrop.DragDropManager.Instance._cursorPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, true, true);
			}
			global::System.Windows.Controls.Grid grid = new global::System.Windows.Controls.Grid
			{
				Background = new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Transparent),
				Name = "popupChild"
			};
			global::Infragistics.DragDrop.DragDropManager.Instance._cursorPopup = global::Infragistics.DragDrop.PlatformProxy.GetHost(global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, grid);
			global::Infragistics.DragDrop.DragDropManager.Instance._customCursorContentControl = new global::System.Windows.Controls.ContentControl
			{
				Cursor = global::System.Windows.Input.Cursors.None,
				Content = new object(),
				HorizontalAlignment = global::System.Windows.HorizontalAlignment.Center,
				VerticalAlignment = global::System.Windows.VerticalAlignment.Center,
				ContentTemplate = global::Infragistics.DragDrop.DragDropManager.Instance._currentCursorTemplate
			};
			grid.Children.Add(global::Infragistics.DragDrop.DragDropManager.Instance._customCursorContentControl);
			global::System.Windows.UIElement rootVisual = global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual;
			grid.SizeChanged += global::Infragistics.DragDrop.DragDropManager.CursorPopupSizeChanged;
			rootVisual.KeyDown += global::Infragistics.DragDrop.DragDropManager.CursorPopupKeyDown;
			rootVisual.KeyUp += global::Infragistics.DragDrop.DragDropManager.CursorPopupKeyUp;
			global::Infragistics.DragDrop.PlatformProxy.OpenHost(global::Infragistics.DragDrop.DragDropManager.Instance._cursorPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, null);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003B98 File Offset: 0x00001D98
		private static void OnDragCancel()
		{
			try
			{
				global::Infragistics.DragDrop.DragSource dragSource = global::Infragistics.DragDrop.DragDropManager.Instance._dragSource;
				if (dragSource != null)
				{
					global::Infragistics.DragDrop.DragDropEventArgs dragDropEventArgs = global::Infragistics.DragDrop.DragDropManager.GetDragDropEventArgs();
					dragSource.OnDragCancel(dragDropEventArgs);
				}
			}
			catch (global::System.Exception error)
			{
				global::Infragistics.DragDrop.DragDropManager.Instance.Error = error;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003BE0 File Offset: 0x00001DE0
		private static void OnDragEnd()
		{
			try
			{
				if (global::Infragistics.DragDrop.DragDropManager.Instance._highlightedTargets.Count > 0)
				{
					foreach (global::Infragistics.DragDrop.DropTarget dropTarget in global::Infragistics.DragDrop.DragDropManager.Instance._highlightedTargets.GetTargets<global::Infragistics.DragDrop.DropTarget>())
					{
						dropTarget.HighlightDropTarget(false);
					}
					global::Infragistics.DragDrop.DragDropManager.Instance._highlightedTargets.Clear();
				}
				else if (global::Infragistics.DragDrop.DragDropManager.Instance._dropTarget != null)
				{
					global::Infragistics.DragDrop.DragDropManager.Instance._dropTarget.HighlightDropTarget(false);
				}
				global::Infragistics.DragDrop.DragSource dragSource = global::Infragistics.DragDrop.DragDropManager.Instance._dragSource;
				if (dragSource != null)
				{
					global::Infragistics.DragDrop.DragDropEventArgs dragDropEventArgs = global::Infragistics.DragDrop.DragDropManager.GetDragDropEventArgs();
					dragSource.OnDragEnd(dragDropEventArgs);
					global::Infragistics.DragDrop.DragDropManager.Instance._dragDropEventArgs = null;
				}
			}
			catch (global::System.Exception error)
			{
				global::Infragistics.DragDrop.DragDropManager.Instance.Error = error;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003CC0 File Offset: 0x00001EC0
		private static bool OnDragEnter()
		{
			try
			{
				global::Infragistics.DragDrop.DragSource dragSource = global::Infragistics.DragDrop.DragDropManager.Instance._dragSource;
				if (dragSource != null)
				{
					global::Infragistics.DragDrop.DragDropEventArgs dragDropEventArgs = global::Infragistics.DragDrop.DragDropManager.GetDragDropEventArgs();
					global::Infragistics.DragDrop.DragDropCancelEventArgs dragDropCancelEventArgs = new global::Infragistics.DragDrop.DragDropCancelEventArgs(dragDropEventArgs)
					{
						DropTarget = global::Infragistics.DragDrop.DragDropManager.Instance._dropTargetElement
					};
					dragSource.OnDragEnter(dragDropCancelEventArgs);
					if (dragDropCancelEventArgs.Cancel)
					{
						return false;
					}
					global::Infragistics.DragDrop.DragDropManager.ApplyDragTemplate(dragDropCancelEventArgs.DragTemplate);
					global::Infragistics.DragDrop.DragDropManager.SetCustomCursorTemplates(dragDropCancelEventArgs);
					global::Infragistics.DragDrop.DragDropManager.Instance._dragDropEventArgs = dragDropCancelEventArgs;
				}
				if (global::Infragistics.DragDrop.DragDropManager.Instance._highlightedTargets.Count == 0 || !global::Infragistics.DragDrop.DragDropManager.Instance._highlightedTargets.Contains(global::Infragistics.DragDrop.DragDropManager.Instance._dropTarget))
				{
					global::Infragistics.DragDrop.DragDropManager.Instance._dropTarget.HighlightDropTarget(true);
				}
			}
			catch (global::System.Exception error)
			{
				global::Infragistics.DragDrop.DragDropManager.Instance.Error = error;
			}
			return true;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003D90 File Offset: 0x00001F90
		private static void OnDragLeave()
		{
			try
			{
				if (global::Infragistics.DragDrop.DragDropManager.Instance._highlightedTargets.Count == 0 || !global::Infragistics.DragDrop.DragDropManager.Instance._highlightedTargets.Contains(global::Infragistics.DragDrop.DragDropManager.Instance._dropTarget))
				{
					global::Infragistics.DragDrop.DragDropManager.Instance._dropTarget.HighlightDropTarget(false);
				}
				global::Infragistics.DragDrop.DragSource dragSource = global::Infragistics.DragDrop.DragDropManager.Instance._dragSource;
				if (dragSource != null)
				{
					global::Infragistics.DragDrop.DragDropEventArgs dragDropEventArgs = global::Infragistics.DragDrop.DragDropManager.GetDragDropEventArgs();
					dragDropEventArgs.DropTarget = global::Infragistics.DragDrop.DragDropManager.Instance._dropTargetElement;
					dragSource.OnDragLeave(dragDropEventArgs);
					dragDropEventArgs.DropTarget = null;
					global::Infragistics.DragDrop.DragDropManager.ApplyDragTemplate(dragDropEventArgs.DragTemplate);
					global::Infragistics.DragDrop.DragDropManager.SetCustomCursorTemplates(dragDropEventArgs);
					global::Infragistics.DragDrop.DragDropManager.Instance._dragDropEventArgs = dragDropEventArgs;
				}
			}
			catch (global::System.Exception error)
			{
				global::Infragistics.DragDrop.DragDropManager.Instance.Error = error;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003E48 File Offset: 0x00002048
		private static void OnDragOver(global::System.Windows.Input.MouseEventArgs mouseArgs)
		{
			try
			{
				global::Infragistics.DragDrop.DragSource dragSource = global::Infragistics.DragDrop.DragDropManager.Instance._dragSource;
				if (dragSource != null)
				{
					global::Infragistics.DragDrop.DragDropEventArgs dragDropEventArgs = global::Infragistics.DragDrop.DragDropManager.GetDragDropEventArgs();
					global::Infragistics.DragDrop.DragDropMoveEventArgs dragDropMoveEventArgs = new global::Infragistics.DragDrop.DragDropMoveEventArgs(dragDropEventArgs, mouseArgs)
					{
						DropTarget = global::Infragistics.DragDrop.DragDropManager.Instance._dropTargetElement
					};
					dragSource.OnDragOver(dragDropMoveEventArgs);
					global::Infragistics.DragDrop.DragDropManager.ApplyDragTemplate(dragDropMoveEventArgs.DragTemplate);
					global::Infragistics.DragDrop.DragDropManager.SetCustomCursorTemplates(dragDropMoveEventArgs);
					global::Infragistics.DragDrop.DragDropManager.Instance._dragDropEventArgs = dragDropMoveEventArgs;
				}
			}
			catch (global::System.Exception error)
			{
				global::Infragistics.DragDrop.DragDropManager.Instance.Error = error;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003EC8 File Offset: 0x000020C8
		private static bool OnDragStart()
		{
			try
			{
				global::Infragistics.DragDrop.DragSource dragSource = global::Infragistics.DragDrop.DragDropManager.Instance._dragSource;
				global::Infragistics.DragDrop.DragDropEventArgs dragDropEventArgs = global::Infragistics.DragDrop.DragDropManager.GetDragDropEventArgs();
				global::Infragistics.DragDrop.DragDropStartEventArgs dragDropStartEventArgs = new global::Infragistics.DragDrop.DragDropStartEventArgs(dragDropEventArgs);
				if (dragSource != null)
				{
					dragSource.OnDragStart(dragDropStartEventArgs);
					if (dragDropStartEventArgs.Cancel)
					{
						return false;
					}
					global::Infragistics.DragDrop.DragDropManager.Instance._draggedElement = (dragDropStartEventArgs.DragSnapshotElement ?? dragDropStartEventArgs.DragSource);
					global::Infragistics.DragDrop.DragDropManager.CatchDragImage(global::Infragistics.DragDrop.DragDropManager.Instance._draggedElement);
					global::Infragistics.DragDrop.DragDropManager.SetCustomCursorTemplates(dragDropStartEventArgs);
				}
				global::Infragistics.DragDrop.DragDropManager.Instance._dragSourceDragTemplate = (dragDropStartEventArgs.DragTemplate ?? global::Infragistics.DragDrop.DragDropManager.Instance._dragSource.DragTemplate);
				global::Infragistics.DragDrop.DragDropManager.Instance._dragDropEventArgs = dragDropStartEventArgs;
				global::Infragistics.DragDrop.DragDropManager.TryHighlightDropTargets();
			}
			catch (global::System.Exception error)
			{
				global::Infragistics.DragDrop.DragDropManager.Instance.Error = error;
			}
			return true;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003F8C File Offset: 0x0000218C
		private static void OnDrop(global::System.Windows.Input.MouseEventArgs mouseEventArgs)
		{
			try
			{
				global::Infragistics.DragDrop.DragSource dragSource = global::Infragistics.DragDrop.DragDropManager.Instance._dragSource;
				if (dragSource != null)
				{
					global::Infragistics.DragDrop.DragDropEventArgs dragDropEventArgs = global::Infragistics.DragDrop.DragDropManager.GetDragDropEventArgs();
					global::Infragistics.DragDrop.DropEventArgs args = new global::Infragistics.DragDrop.DropEventArgs(dragDropEventArgs, mouseEventArgs)
					{
						DropTarget = global::Infragistics.DragDrop.DragDropManager.Instance._dropTargetElement,
						DropTargetElements = global::Infragistics.DragDrop.DragDropManager.GetElementsInDropTarget()
					};
					dragSource.OnDrop(args);
				}
			}
			catch (global::System.Exception error)
			{
				global::Infragistics.DragDrop.DragDropManager.Instance.Error = error;
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004010 File Offset: 0x00002210
		private static void TryHighlightDropTargets()
		{
			global::System.Collections.Generic.IEnumerable<global::Infragistics.DragDrop.DropTarget> dropTargets = global::Infragistics.DragDrop.DragDropManager.GetDropTargets(global::Infragistics.DragDrop.DragDropManager.Instance._dragSource.DragChannels);
			global::System.Collections.Generic.IEnumerable<global::Infragistics.DragDrop.DropTarget> enumerable = (from dt in dropTargets
			where dt.HighlightOnDragStart || global::Infragistics.DragDrop.DragDropManager.HighlightTargetsOnDragStart
			select dt).ToList<global::Infragistics.DragDrop.DropTarget>();
			foreach (global::Infragistics.DragDrop.DropTarget target in enumerable)
			{
				global::Infragistics.DragDrop.DragDropManager.Instance._highlightedTargets.Add(new global::System.WeakReference(target));
			}
			foreach (global::Infragistics.DragDrop.DropTarget dropTarget in enumerable)
			{
				dropTarget.HighlightDropTarget(true);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000040E8 File Offset: 0x000022E8
		private static void QueryContinueDrag(global::System.Windows.DependencyObject sender, bool escapePressed, bool mouseReleased)
		{
			if (sender == null)
			{
				if (escapePressed || mouseReleased)
				{
					global::Infragistics.DragDrop.DragDropManager.EndDrag(true);
				}
				return;
			}
			if (escapePressed)
			{
				global::Infragistics.DragDrop.DragDropManager.EndDrag(true);
				return;
			}
			if (mouseReleased)
			{
				global::Infragistics.DragDrop.DragDropManager.EndDrag(false);
				return;
			}
			global::Infragistics.DragDrop.DragDropEventArgs dragDropEventArgs = global::Infragistics.DragDrop.DragDropManager.GetDragDropEventArgs();
			if (dragDropEventArgs.OperationType != null)
			{
				global::Infragistics.DragDrop.DragDropManager.ApplyCursorTemplate(dragDropEventArgs.OperationType);
				return;
			}
			global::Infragistics.DragDrop.DragDropManager.ApplyCursorTemplate();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004140 File Offset: 0x00002340
		private static void RemoveTargetMarker()
		{
			if (global::Infragistics.DragDrop.DragDropManager.Instance._targetMarkerPopup != null)
			{
				global::Infragistics.DragDrop.PlatformProxy.CloseHost(global::Infragistics.DragDrop.DragDropManager.Instance._targetMarkerPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, true, true);
				global::Infragistics.DragDrop.DragDropManager.Instance._targetMarkerPopup = null;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004174 File Offset: 0x00002374
		private static void SetCursorPopupPosition()
		{
			int num = -1;
			int num2 = 0;
			global::System.Windows.FrameworkElement frameworkElement = (global::System.Windows.FrameworkElement)global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement;
			global::System.Windows.FrameworkElement frameworkElement2 = (global::System.Windows.FrameworkElement)global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual;
			bool flag = false;
			bool isMenuDropRightAligned = global::System.Windows.SystemParameters.IsMenuDropRightAligned;
			bool flag2 = frameworkElement2.FlowDirection == global::System.Windows.FlowDirection.RightToLeft;
			if ((flag2 && !isMenuDropRightAligned) || (!flag2 && isMenuDropRightAligned))
			{
				flag = true;
			}
			global::System.Windows.UIElement hostChild = global::Infragistics.DragDrop.PlatformProxy.GetHostChild(global::Infragistics.DragDrop.DragDropManager.Instance._cursorPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual);
			if (frameworkElement.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
			{
				num = 1;
				num2 = -1;
			}
			if (global::Infragistics.DragDrop.DragDropManager.Instance._cursorPopup != null)
			{
				double top = global::Infragistics.DragDrop.DragDropManager.Instance._mousePosition.Y - hostChild.DesiredSize.Height / 2.0;
				double num3 = global::Infragistics.DragDrop.DragDropManager.Instance._mousePosition.X + (double)num * (hostChild.DesiredSize.Width / 2.0) + (double)num2 * hostChild.DesiredSize.Width;
				if (global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual.GetType().Name != "RootBrowserWindow" && flag)
				{
					num3 += hostChild.DesiredSize.Width;
				}
				global::Infragistics.DragDrop.PlatformProxy.SetHostPosition(global::Infragistics.DragDrop.DragDropManager.Instance._cursorPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, top, num3);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000042CC File Offset: 0x000024CC
		private static void SetCustomCursorTemplate(global::System.Windows.DataTemplate cursor, global::Infragistics.DragDrop.OperationType cursorType)
		{
			switch (cursorType)
			{
			case global::Infragistics.DragDrop.OperationType.DropNotAllowed:
				global::Infragistics.DragDrop.DragDropManager.Instance._customDropNotAllowedCursorTemplate = cursor;
				return;
			case global::Infragistics.DragDrop.OperationType.Copy:
				global::Infragistics.DragDrop.DragDropManager.Instance._customCopyCursorTemplate = cursor;
				return;
			case global::Infragistics.DragDrop.OperationType.Move:
				global::Infragistics.DragDrop.DragDropManager.Instance._customMoveCursorTemplate = cursor;
				return;
			default:
				return;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004311 File Offset: 0x00002511
		private static void SetCustomCursorTemplates(global::Infragistics.DragDrop.DragDropEventArgs args)
		{
			global::Infragistics.DragDrop.DragDropManager.SetCustomCursorTemplate(args.CopyCursorTemplate, global::Infragistics.DragDrop.OperationType.Copy);
			global::Infragistics.DragDrop.DragDropManager.SetCustomCursorTemplate(args.MoveCursorTemplate, global::Infragistics.DragDrop.OperationType.Move);
			global::Infragistics.DragDrop.DragDropManager.SetCustomCursorTemplate(args.DropNotAllowedCursorTemplate, global::Infragistics.DragDrop.OperationType.DropNotAllowed);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004338 File Offset: 0x00002538
		private static void SetDragPopupPosition(global::System.Windows.Point draggedOffset)
		{
			global::System.Windows.DataTemplate dataTemplate = global::Infragistics.DragDrop.DragDropManager.Instance._dragSourceDragTemplate ?? global::Infragistics.DragDrop.DragDropManager.Instance._defaultDragTemplate;
			int num = -1;
			global::System.Windows.FrameworkElement frameworkElement = (global::System.Windows.FrameworkElement)global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement;
			int num2 = 0;
			global::System.Windows.FrameworkElement frameworkElement2 = (global::System.Windows.FrameworkElement)global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual;
			bool flag = false;
			bool isMenuDropRightAligned = global::System.Windows.SystemParameters.IsMenuDropRightAligned;
			bool flag2 = frameworkElement2.FlowDirection == global::System.Windows.FlowDirection.RightToLeft;
			if ((flag2 && !isMenuDropRightAligned) || (!flag2 && isMenuDropRightAligned))
			{
				flag = true;
			}
			global::System.Windows.UIElement hostChild = global::Infragistics.DragDrop.PlatformProxy.GetHostChild(global::Infragistics.DragDrop.DragDropManager.Instance._dragPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual);
			if (frameworkElement.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
			{
				num = 1;
				num2 = -1;
			}
			if (dataTemplate != global::Infragistics.DragDrop.DragDropManager.Instance._defaultDragTemplate || (global::Infragistics.DragDrop.DragDropManager.Instance._draggedElement != null && !global::Infragistics.DragDrop.DragDropManager.Instance._draggedElement.Equals(global::Infragistics.DragDrop.DragDropManager.Instance._originalDragSourceElement) && !global::Infragistics.DragDrop.DragDropManager.Instance._draggedElement.Equals(global::Infragistics.DragDrop.DragDropManager.Instance._dragSourceElement)))
			{
				double top = global::Infragistics.DragDrop.DragDropManager.Instance._mousePosition.Y - hostChild.DesiredSize.Height / 2.0;
				double num3 = global::Infragistics.DragDrop.DragDropManager.Instance._mousePosition.X + (double)num * (hostChild.DesiredSize.Width / 2.0) + (double)num2 * hostChild.DesiredSize.Width;
				if (global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual.GetType().Name != "RootBrowserWindow" && flag)
				{
					num3 += hostChild.DesiredSize.Width;
				}
				global::Infragistics.DragDrop.PlatformProxy.SetHostPosition(global::Infragistics.DragDrop.DragDropManager.Instance._dragPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, top, num3);
				return;
			}
			double num4 = (double)num * global::Infragistics.DragDrop.DragDropManager.Instance._mouseOffset.X;
			double top2 = global::Infragistics.DragDrop.DragDropManager.Instance._mousePosition.Y - global::Infragistics.DragDrop.DragDropManager.Instance._mouseOffset.Y + draggedOffset.Y;
			double num5 = global::Infragistics.DragDrop.DragDropManager.Instance._mousePosition.X + num4 + draggedOffset.X + (double)num2 * hostChild.DesiredSize.Width;
			if (global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual.GetType().Name != "RootBrowserWindow" && flag)
			{
				num5 += hostChild.DesiredSize.Width;
			}
			global::Infragistics.DragDrop.PlatformProxy.SetHostPosition(global::Infragistics.DragDrop.DragDropManager.Instance._dragPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, top2, num5);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000045B8 File Offset: 0x000027B8
		private static global::System.Windows.UIElement GetUIElementParent(global::System.Windows.DependencyObject element)
		{
			global::System.Windows.UIElement uielement = element as global::System.Windows.UIElement;
			if (uielement == null)
			{
				global::System.Windows.DependencyObject parent = global::System.Windows.LogicalTreeHelper.GetParent(element);
				for (uielement = (parent as global::System.Windows.UIElement); uielement == null; uielement = (parent as global::System.Windows.UIElement))
				{
					parent = global::System.Windows.LogicalTreeHelper.GetParent(parent);
					if (parent == null)
					{
						break;
					}
				}
			}
			return uielement;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000045F4 File Offset: 0x000027F4
		protected internal static void RegisterDragSource(global::System.Windows.UIElement element)
		{
			if (element != null && !global::Infragistics.DragDrop.DragDropManager.Instance._dragSources.Contains(element))
			{
				global::Infragistics.DragDrop.DragDropManager.Instance._dragSources.Add(element);
				element.AddHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Infragistics.DragDrop.DragDropManager.OnMouseLeftButtonDown), true);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004633 File Offset: 0x00002833
		protected internal static void RegisterDropTarget(global::System.Windows.UIElement element)
		{
			if (!global::Infragistics.DragDrop.DragDropManager.Instance._dropTargets.Contains(element))
			{
				global::Infragistics.DragDrop.DragDropManager.Instance._dropTargets.Add(element);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004657 File Offset: 0x00002857
		protected internal static void UnregisterDragSource(global::System.Windows.UIElement element)
		{
			if (element != null)
			{
				if (global::Infragistics.DragDrop.DragDropManager.Instance._dragSources.Contains(element))
				{
					global::Infragistics.DragDrop.DragDropManager.Instance._dragSources.Remove(element);
				}
				element.RemoveHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Infragistics.DragDrop.DragDropManager.OnMouseLeftButtonDown));
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004695 File Offset: 0x00002895
		protected internal static void UnregisterDropTarget(global::System.Windows.UIElement element)
		{
			if (global::Infragistics.DragDrop.DragDropManager.Instance._dropTargets.Contains(element))
			{
				global::Infragistics.DragDrop.DragDropManager.Instance._dropTargets.Remove(element);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000046B9 File Offset: 0x000028B9
		private static void CursorPopupKeyDown(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			global::Infragistics.DragDrop.DragDropManager.QueryContinueDrag(global::Infragistics.DragDrop.DragDropManager.Instance._dropTargetElement, false, false);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000046CC File Offset: 0x000028CC
		private static void CursorPopupKeyUp(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == global::System.Windows.Input.Key.Escape)
			{
				global::Infragistics.DragDrop.DragDropManager.QueryContinueDrag(global::Infragistics.DragDrop.DragDropManager.Instance._dropTargetElement, true, false);
				return;
			}
			global::Infragistics.DragDrop.DragDropManager.QueryContinueDrag(global::Infragistics.DragDrop.DragDropManager.Instance._dropTargetElement, false, false);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000046FC File Offset: 0x000028FC
		private static void CursorPopupSizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			global::System.Windows.UIElement hostChild = global::Infragistics.DragDrop.PlatformProxy.GetHostChild(global::Infragistics.DragDrop.DragDropManager.Instance._cursorPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual);
			global::Infragistics.DragDrop.PlatformProxy.SetHostSize(global::Infragistics.DragDrop.DragDropManager.Instance._cursorPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, hostChild.DesiredSize.Width, hostChild.DesiredSize.Height);
			global::Infragistics.DragDrop.DragDropManager.SetCursorPopupPosition();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004760 File Offset: 0x00002960
		private static void DragPopupSizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			global::System.Windows.UIElement hostChild = global::Infragistics.DragDrop.PlatformProxy.GetHostChild(global::Infragistics.DragDrop.DragDropManager.Instance._dragPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual);
			global::Infragistics.DragDrop.PlatformProxy.SetHostSize(global::Infragistics.DragDrop.DragDropManager.Instance._dragPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, hostChild.DesiredSize.Width, hostChild.DesiredSize.Height);
			global::Infragistics.DragDrop.DragDropManager.SetDragPopupPosition(global::Infragistics.DragDrop.DragDropManager.Instance._draggedOffset);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000047CC File Offset: 0x000029CC
		private static void OnMouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::Infragistics.DragDrop.DragDropManager.Instance._endDrag = false;
			if (global::Infragistics.DragDrop.DragDropManager.Instance._mouseCaptured)
			{
				return;
			}
			global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual = global::Infragistics.DragDrop.PlatformProxy.GetRootVisual((global::System.Windows.DependencyObject)sender);
			if (global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual == null)
			{
				return;
			}
			global::System.Windows.Point mousePosition = global::Infragistics.DragDrop.PlatformProxy.GetMousePosition(e, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual);
			global::Infragistics.DragDrop.DragDropManager.Instance._initialMousePosition.X = mousePosition.X;
			global::Infragistics.DragDrop.DragDropManager.Instance._initialMousePosition.Y = mousePosition.Y;
			global::Infragistics.DragDrop.DragDropManager.Instance._dragSourceElement = (global::System.Windows.UIElement)sender;
			global::Infragistics.DragDrop.DragDropManager.Instance._originalDragSourceElement = global::Infragistics.DragDrop.DragDropManager.GetUIElementParent(e.OriginalSource as global::System.Windows.DependencyObject);
			global::Infragistics.DragDrop.DragDropManager.Instance._dragSource = global::Infragistics.DragDrop.DragDropManager.GetDragSource(global::Infragistics.DragDrop.DragDropManager.Instance._dragSourceElement);
			global::System.Windows.UIElement uielement = global::Infragistics.DragDrop.DragDropManager.Instance._dragSourceElement;
			global::Infragistics.DragDrop.DragDropManager.Instance._mouseCaptured = global::Infragistics.DragDrop.DragDropManager.CaptureMouse(uielement, true);
			if (!global::Infragistics.DragDrop.DragDropManager.Instance._mouseCaptured)
			{
				uielement = global::Infragistics.DragDrop.DragDropManager.GetElementWithMouseCapture();
				if (uielement != null)
				{
					global::Infragistics.DragDrop.DragDropManager.Instance._mouseCaptured = global::Infragistics.DragDrop.DragDropManager.CaptureMouse(uielement, false);
				}
			}
			global::Infragistics.DragDrop.DragDropManager.Instance._waitDragStart = global::Infragistics.DragDrop.DragDropManager.Instance._mouseCaptured;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000048EC File Offset: 0x00002AEC
		private static bool CaptureMouse(global::System.Windows.UIElement element, bool needMouseRelease)
		{
			if (global::System.Windows.Input.Mouse.Captured != null)
			{
				return false;
			}
			if (element.CaptureMouse())
			{
				global::Infragistics.DragDrop.DragDropManager.Instance._needReleaseMouse = needMouseRelease;
				global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement = element;
				global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement.MouseMove += global::Infragistics.DragDrop.DragDropManager.OnMouseMove;
				global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement.AddHandler(global::System.Windows.UIElement.MouseLeftButtonUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Infragistics.DragDrop.DragDropManager.OnMouseLeftButtonUp), true);
				global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement.LostMouseCapture += global::Infragistics.DragDrop.DragDropManager.LostMouseCapture;
				global::System.Windows.FrameworkElement frameworkElement = global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement as global::System.Windows.FrameworkElement;
				if (frameworkElement != null)
				{
					frameworkElement.Unloaded += global::Infragistics.DragDrop.DragDropManager.TrackedElementUnloaded;
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000049A2 File Offset: 0x00002BA2
		private static void TrackedElementUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (global::Infragistics.DragDrop.DragDropManager.Instance._dragging || global::Infragistics.DragDrop.DragDropManager.Instance._waitDragStart)
			{
				if (global::Infragistics.DragDrop.DragDropManager.Instance._mouseCaptured)
				{
					global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement.ReleaseMouseCapture();
				}
				global::Infragistics.DragDrop.DragDropManager.ResolveTrackedElement(sender);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000049DD File Offset: 0x00002BDD
		private static void LostMouseCapture(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			global::Infragistics.DragDrop.DragDropManager.Instance._needReleaseMouse = false;
			global::Infragistics.DragDrop.DragDropManager.ResolveTrackedElement(sender);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000049F0 File Offset: 0x00002BF0
		private static void ResolveTrackedElement(object sender)
		{
			global::System.Windows.UIElement uielement = sender as global::System.Windows.UIElement;
			if (uielement == null)
			{
				return;
			}
			global::System.Windows.FrameworkElement frameworkElement = global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				frameworkElement.Unloaded -= global::Infragistics.DragDrop.DragDropManager.TrackedElementUnloaded;
			}
			uielement.LostMouseCapture -= global::Infragistics.DragDrop.DragDropManager.LostMouseCapture;
			uielement.MouseMove -= global::Infragistics.DragDrop.DragDropManager.OnMouseMove;
			uielement.RemoveHandler(global::System.Windows.UIElement.MouseLeftButtonUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Infragistics.DragDrop.DragDropManager.OnMouseLeftButtonUp));
			if (!global::Infragistics.DragDrop.DragDropManager.Instance._dragging && !global::Infragistics.DragDrop.DragDropManager.Instance._waitDragStart)
			{
				return;
			}
			if (frameworkElement != null && global::Infragistics.DragDrop.DragDropManager.Instance._gotCursor)
			{
				if (frameworkElement.Cursor == global::System.Windows.Input.Cursors.None)
				{
					frameworkElement.Cursor = global::Infragistics.DragDrop.DragDropManager.Instance._originalCursor;
				}
				global::Infragistics.DragDrop.DragDropManager.Instance._originalCursor = null;
			}
			if (global::Infragistics.DragDrop.DragDropManager.Instance._endDrag)
			{
				return;
			}
			if (global::Infragistics.DragDrop.DragDropManager.Instance._waitDragStart || global::Infragistics.DragDrop.DragDropManager.Instance._dragging)
			{
				if (global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement != null)
				{
					global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement.MouseMove -= global::Infragistics.DragDrop.DragDropManager.OnMouseMove;
					global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement.RemoveHandler(global::System.Windows.UIElement.MouseLeftButtonUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Infragistics.DragDrop.DragDropManager.OnMouseLeftButtonUp));
				}
				global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement = global::Infragistics.DragDrop.DragDropManager.GetElementWithMouseCapture();
				if (global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement == null)
				{
					global::Infragistics.DragDrop.DragDropManager.EndDrag(true);
					return;
				}
				global::Infragistics.DragDrop.DragDropManager.Instance._mouseCaptured = global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement.CaptureMouse();
				global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement.MouseMove += global::Infragistics.DragDrop.DragDropManager.OnMouseMove;
				global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement.AddHandler(global::System.Windows.UIElement.MouseLeftButtonUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Infragistics.DragDrop.DragDropManager.OnMouseLeftButtonUp), true);
				global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement.LostMouseCapture += global::Infragistics.DragDrop.DragDropManager.LostMouseCapture;
				if (global::Infragistics.DragDrop.DragDropManager.Instance._dragging)
				{
					frameworkElement = (global::Infragistics.DragDrop.DragDropManager.Instance._trackedElement as global::System.Windows.FrameworkElement);
					if (frameworkElement != null)
					{
						global::Infragistics.DragDrop.DragDropManager.Instance._originalCursor = frameworkElement.Cursor;
						frameworkElement.Cursor = global::System.Windows.Input.Cursors.None;
						global::Infragistics.DragDrop.DragDropManager.Instance._gotCursor = true;
					}
				}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00004C00 File Offset: 0x00002E00
		private static global::System.Windows.UIElement GetElementWithMouseCapture()
		{
			if (global::System.Windows.Input.Mouse.Captured != null)
			{
				global::System.Windows.UIElement uielement = global::System.Windows.Input.Mouse.Captured as global::System.Windows.UIElement;
				if (uielement != null)
				{
					return uielement;
				}
				return null;
			}
			else
			{
				global::System.Windows.UIElement uielement2 = global::Infragistics.DragDrop.DragDropManager.Instance._originalDragSourceElement;
				while (uielement2 != null)
				{
					global::System.Windows.UIElement uielement3 = global::System.Windows.Media.VisualTreeHelper.GetParent(uielement2) as global::System.Windows.UIElement;
					if (uielement3 == null)
					{
						if (uielement2 != null && uielement2 != global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual && uielement2.GetType().Name == "PopupRoot")
						{
							global::Infragistics.DragDrop.DragDropManager.Instance._needReleaseMouse = true;
							return uielement2;
						}
						break;
					}
					else
					{
						uielement2 = uielement3;
					}
				}
				if (global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual.CaptureMouse())
				{
					global::Infragistics.DragDrop.DragDropManager.Instance._needReleaseMouse = true;
					return global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual;
				}
				return null;
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00004CA3 File Offset: 0x00002EA3
		private static void OnMouseLeftButtonUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (global::Infragistics.DragDrop.DragDropManager.Instance._mouseCaptured)
			{
				global::Infragistics.DragDrop.DragDropManager.QueryContinueDrag(global::Infragistics.DragDrop.DragDropManager.Instance._dropTargetElement, false, true);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004CC4 File Offset: 0x00002EC4
		private static void OnMouseMove(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			if (global::Infragistics.DragDrop.DragDropManager.Instance._mouseMoving)
			{
				return;
			}
			global::Infragistics.DragDrop.DragDropManager.Instance._mouseMoving = true;
			if (global::Infragistics.DragDrop.DragDropManager.Instance._mouseCaptured)
			{
				global::System.Windows.Point mousePosition = global::Infragistics.DragDrop.PlatformProxy.GetMousePosition(e, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual);
				global::Infragistics.DragDrop.DragDropManager.Instance._mousePosition = mousePosition;
				global::Infragistics.DragDrop.DragDropManager.Instance._mouseEventArgs = e;
				global::System.Windows.UIElement uielement = global::Infragistics.DragDrop.DragDropManager.FindTarget(e);
				if (!global::Infragistics.DragDrop.DragDropManager.Instance._dragging && (global::System.Math.Abs(mousePosition.X - global::Infragistics.DragDrop.DragDropManager.Instance._initialMousePosition.X) > global::Infragistics.DragDrop.DragDropManager.Instance._dragSource.DraggingOffset || global::System.Math.Abs(mousePosition.Y - global::Infragistics.DragDrop.DragDropManager.Instance._initialMousePosition.Y) > global::Infragistics.DragDrop.DragDropManager.Instance._dragSource.DraggingOffset))
				{
					global::Infragistics.DragDrop.DragDropManager.Instance._dragging = true;
					global::Infragistics.DragDrop.DragDropManager.Instance._waitDragStart = false;
					global::Infragistics.DragDrop.DragDropManager.Instance._draggedOffset = new global::System.Windows.Point(mousePosition.X - global::Infragistics.DragDrop.DragDropManager.Instance._initialMousePosition.X, mousePosition.Y - global::Infragistics.DragDrop.DragDropManager.Instance._initialMousePosition.Y);
					if (global::Infragistics.DragDrop.DragDropManager.Instance._dragPopup != null)
					{
						global::Infragistics.DragDrop.PlatformProxy.CloseHost(global::Infragistics.DragDrop.DragDropManager.Instance._dragPopup, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, true, true);
					}
					global::Infragistics.DragDrop.DragDropManager.Instance._dragPopup = global::Infragistics.DragDrop.PlatformProxy.GetHost(global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, global::Infragistics.DragDrop.DragDropManager.Instance._rootVisual, new global::System.Windows.Controls.Grid());
					if (!global::Infragistics.DragDrop.DragDropManager.OnDragStart() || global::Infragistics.DragDrop.DragDropManager.Instance.Error != null)
					{
						global::Infragistics.DragDrop.DragDropManager.EndDrag(true);
						return;
					}
					try
					{
						global::Infragistics.DragDrop.DragDropManager.Instance._mouseOffset = global::Infragistics.DragDrop.DragDropManager.Instance._mouseEventArgs.GetPosition(global::Infragistics.DragDrop.DragDropManager.Instance._draggedElement);
					}
					catch (global::System.ArgumentException)
					{
						global::Infragistics.DragDrop.DragDropManager.Instance._mouseOffset = new global::System.Windows.Point(1.0, 1.0);
					}
					global::Infragistics.DragDrop.DragDropManager.ShowDragPopup();
					global::Infragistics.DragDrop.DragDropManager.ShowCursorPopup();
				}
				if (global::Infragistics.DragDrop.DragDropManager.Instance._dragging)
				{
					global::Infragistics.DragDrop.DragDropManager.SetDragPopupPosition(global::Infragistics.DragDrop.DragDropManager.Instance._draggedOffset);
					global::Infragistics.DragDrop.DragDropManager.SetCursorPopupPosition();
					if (uielement != null)
					{
						bool flag = false;
						if (global::Infragistics.DragDrop.DragDropManager.Instance._dropTargetElement != null)
						{
							if (global::Infragistics.DragDrop.DragDropManager.Instance._dropTargetElement != uielement)
							{
								flag = true;
								global::Infragistics.DragDrop.DragDropManager.OnDragLeave();
								if (global::Infragistics.DragDrop.DragDropManager.Instance.Error != null)
								{
									global::Infragistics.DragDrop.DragDropManager.EndDrag(true);
									return;
								}
								global::Infragistics.DragDrop.DragDropManager.Instance._dropTargetElement = uielement;
								global::Infragistics.DragDrop.DragDropManager.Instance._dropTarget = global::Infragistics.DragDrop.DragDropManager.GetDropTarget(global::Infragistics.DragDrop.DragDropManager.Instance._dropTargetElement);
								if (!global::Infragistics.DragDrop.DragDropManager.OnDragEnter() || global::Infragistics.DragDrop.DragDropManager.Instance.Error != null)
								{
									global::Infragistics.DragDrop.DragDropManager.EndDrag(true);
									return;
								}
							}
							else
							{
								global::Infragistics.DragDrop.DragDropManager.OnDragOver(e);
								if (global::Infragistics.DragDrop.DragDropManager.Instance.Error != null)
								{
									global::Infragistics.DragDrop.DragDropManager.EndDrag(true);
									return;
								}
							}
						}
						else
						{
							flag = true;
							global::Infragistics.DragDrop.DragDropManager.Instance._dropTargetElement = uielement;
							global::Infragistics.DragDrop.DragDropManager.Instance._dropTarget = global::Infragistics.DragDrop.DragDropManager.GetDropTarget(global::Infragistics.DragDrop.DragDropManager.Instance._dropTargetElement);
							if (!global::Infragistics.DragDrop.DragDropManager.OnDragEnter() || global::Infragistics.DragDrop.DragDropManager.Instance.Error != null)
							{
								global::Infragistics.DragDrop.DragDropManager.EndDrag(true);
								return;
							}
						}
						if (flag)
						{
							global::Infragistics.DragDrop.DragDropManager.RemoveTargetMarker();
							if (global::Infragistics.DragDrop.DragDropManager.Instance._dropTarget.DropTargetStyle == null)
							{
								global::Infragistics.DragDrop.DragDropManager.GenerateTargetMarker((global::System.Windows.FrameworkElement)global::Infragistics.DragDrop.DragDropManager.Instance._dropTargetElement);
							}
						}
					}
					else
					{
						global::Infragistics.DragDrop.DragDropManager.RemoveTargetMarker();
						if (global::Infragistics.DragDrop.DragDropManager.Instance._dropTargetElement != null)
						{
							global::Infragistics.DragDrop.DragDropManager.OnDragLeave();
							if (global::Infragistics.DragDrop.DragDropManager.Instance.Error != null)
							{
								global::Infragistics.DragDrop.DragDropManager.EndDrag(true);
								return;
							}
							global::Infragistics.DragDrop.DragDropManager.Instance._dropTargetElement = null;
						}
					}
					global::Infragistics.DragDrop.DragDropEventArgs dragDropEventArgs = global::Infragistics.DragDrop.DragDropManager.GetDragDropEventArgs();
					if (dragDropEventArgs.OperationType != null)
					{
						global::Infragistics.DragDrop.DragDropManager.ApplyCursorTemplate(dragDropEventArgs.OperationType);
					}
					else
					{
						global::Infragistics.DragDrop.DragDropManager.ApplyCursorTemplate();
					}
				}
			}
			global::Infragistics.DragDrop.DragDropManager.Instance._mouseMoving = false;
		}

		// Token: 0x04000001 RID: 1
		[global::System.ThreadStatic]
		private static global::Infragistics.DragDrop.DragDropManager _instance;

		// Token: 0x04000002 RID: 2
		private global::System.Collections.Generic.List<global::System.WeakReference> _dropTargets = new global::System.Collections.Generic.List<global::System.WeakReference>();

		// Token: 0x04000003 RID: 3
		private global::System.Collections.Generic.List<global::System.WeakReference> _dragSources = new global::System.Collections.Generic.List<global::System.WeakReference>();

		// Token: 0x04000004 RID: 4
		private global::System.Collections.Generic.IList<global::System.WeakReference> _highlightedTargets = new global::System.Collections.Generic.List<global::System.WeakReference>();

		// Token: 0x04000005 RID: 5
		private bool _dragging;

		// Token: 0x04000006 RID: 6
		private bool _mouseCaptured;

		// Token: 0x04000007 RID: 7
		private bool _needReleaseMouse;

		// Token: 0x04000008 RID: 8
		private bool _waitDragStart;

		// Token: 0x04000009 RID: 9
		private bool _mouseMoving;

		// Token: 0x0400000A RID: 10
		private bool _gotCursor;

		// Token: 0x0400000B RID: 11
		private bool _endDrag;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.UIElement _dragPopup;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.UIElement _cursorPopup;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.UIElement _targetMarkerPopup;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Controls.Image _snapshotImage;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.UIElement _dropTargetElement;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.UIElement _dragSourceElement;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.UIElement _originalDragSourceElement;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.UIElement _draggedElement;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.UIElement _trackedElement;

		// Token: 0x04000015 RID: 21
		private global::Infragistics.DragDrop.DragSource _dragSource;

		// Token: 0x04000016 RID: 22
		private global::Infragistics.DragDrop.DropTarget _dropTarget;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Point _initialMousePosition = new global::System.Windows.Point(0.0, 0.0);

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Point _mousePosition = new global::System.Windows.Point(0.0, 0.0);

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Point _mouseOffset = new global::System.Windows.Point(0.0, 0.0);

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Point _draggedOffset = new global::System.Windows.Point(0.0, 0.0);

		// Token: 0x0400001B RID: 27
		private global::System.Windows.DataTemplate _currentDropNotAllowedCursorTemplate;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.DataTemplate _customDropNotAllowedCursorTemplate;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.DataTemplate _defaultDropNotAllowedCursorTemplate;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.DataTemplate _currentMoveCursorTemplate;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.DataTemplate _customMoveCursorTemplate;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.DataTemplate _defaultMoveCursorTemplate;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.DataTemplate _currentCopyCursorTemplate;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.DataTemplate _customCopyCursorTemplate;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.DataTemplate _defaultCopyCursorTemplate;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.DataTemplate _currentCursorTemplate;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.DataTemplate _defaultDragTemplate;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.DataTemplate _dragSourceDragTemplate;

		// Token: 0x04000027 RID: 39
		private global::Infragistics.DragDrop.DragDropEventArgs _dragDropEventArgs;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Controls.ContentControl _customCursorContentControl;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Controls.ContentControl _dragContentControl;

		// Token: 0x0400002A RID: 42
		private global::Infragistics.DragDrop.DragObject _dragObject;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Input.MouseEventArgs _mouseEventArgs;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Input.Cursor _originalCursor;

		// Token: 0x0400002D RID: 45
		private global::System.Exception _error;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.UIElement _rootVisual;

		// Token: 0x0400002F RID: 47
		private global::System.Collections.Generic.List<global::System.WeakReference> _registeredDragSources;

		// Token: 0x04000030 RID: 48
		[global::System.ThreadStatic]
		private static int _currentThreadId;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.UIElement _target;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Controls.Primitives.Popup _popupHost;

		// Token: 0x04000033 RID: 51
		[global::System.ThreadStatic]
		private static bool isThreadIdInitialized;

		// Token: 0x04000034 RID: 52
		public static readonly global::System.Windows.DependencyProperty DragSourceProperty = global::System.Windows.DependencyProperty.RegisterAttached("DragSource", typeof(global::Infragistics.DragDrop.DragSource), typeof(global::Infragistics.DragDrop.DragDropManager), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.DragDrop.DragDropManager.OnDragSourceChanged)));

		// Token: 0x04000035 RID: 53
		public static readonly global::System.Windows.DependencyProperty DropTargetProperty = global::System.Windows.DependencyProperty.RegisterAttached("DropTarget", typeof(global::Infragistics.DragDrop.DropTarget), typeof(global::Infragistics.DragDrop.DragDropManager), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.DragDrop.DragDropManager.OnDropTargetChanged)));
	}
}
