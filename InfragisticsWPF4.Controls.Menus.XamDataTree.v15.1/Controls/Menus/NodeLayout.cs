using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Windows;

namespace Infragistics.Controls.Menus
{
	// Token: 0x02000025 RID: 37
	public class NodeLayout : global::Infragistics.Controls.Menus.NodeLayoutBase
	{
		// Token: 0x06000110 RID: 272 RVA: 0x00005A3A File Offset: 0x00003C3A
		public NodeLayout()
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00005A4D File Offset: 0x00003C4D
		public NodeLayout(global::Infragistics.Controls.Menus.XamDataTree tree)
		{
			this.Tree = tree;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00005A67 File Offset: 0x00003C67
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00005A70 File Offset: 0x00003C70
		public global::Infragistics.Controls.Menus.XamDataTree Tree
		{
			get
			{
				return this._tree;
			}
			internal set
			{
				if (this._tree != null)
				{
					if (this._tree == value)
					{
						return;
					}
					this._tree.PropertyChanged -= this.Tree_PropertyChanged;
				}
				this._tree = value;
				if (this._tree != null)
				{
					this._tree.PropertyChanged += this.Tree_PropertyChanged;
					foreach (global::Infragistics.Controls.Menus.NodeLayout nodeLayout in this.NodeLayouts)
					{
						nodeLayout.Tree = value;
					}
				}
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00005B0C File Offset: 0x00003D0C
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00005B1E File Offset: 0x00003D1E
		public string TargetTypeName
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Menus.NodeLayout.TargetTypeNameProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.NodeLayout.TargetTypeNameProperty, value);
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00005B2C File Offset: 0x00003D2C
		private static void TargetTypeNameChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00005B2E File Offset: 0x00003D2E
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00005B40 File Offset: 0x00003D40
		public global::System.Windows.Visibility Visibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Menus.NodeLayout.VisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.NodeLayout.VisibilityProperty, value);
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00005B54 File Offset: 0x00003D54
		private static void VisibilityChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.NodeLayout nodeLayout = (global::Infragistics.Controls.Menus.NodeLayout)obj;
			nodeLayout.OnVisibilityChanged();
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00005B6E File Offset: 0x00003D6E
		protected virtual void OnVisibilityChanged()
		{
			this.OnPropertyChanged("Visibility");
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00005B7B File Offset: 0x00003D7B
		// (set) Token: 0x0600011C RID: 284 RVA: 0x00005B8D File Offset: 0x00003D8D
		public string DisplayMemberPath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Menus.NodeLayout.DisplayMemberPathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.NodeLayout.DisplayMemberPathProperty, value);
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00005B9C File Offset: 0x00003D9C
		private static void DisplayMemberPathChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.NodeLayout nodeLayout = (global::Infragistics.Controls.Menus.NodeLayout)obj;
			if (nodeLayout.Tree != null)
			{
				nodeLayout.Tree.InvalidateScrollPanel(true, false, true);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00005BC8 File Offset: 0x00003DC8
		public string DisplayMemberPathResolved
		{
			get
			{
				string result = "";
				if (!string.IsNullOrEmpty(this.DisplayMemberPath))
				{
					result = this.DisplayMemberPath;
				}
				else if (this.Tree != null)
				{
					result = this.Tree.DisplayMemberPath;
				}
				return result;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00005C06 File Offset: 0x00003E06
		// (set) Token: 0x06000120 RID: 288 RVA: 0x00005C18 File Offset: 0x00003E18
		public string CheckBoxMemberPath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Menus.NodeLayout.CheckBoxMemberPathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.NodeLayout.CheckBoxMemberPathProperty, value);
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00005C28 File Offset: 0x00003E28
		private static void CheckBoxMemberPathChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.NodeLayout nodeLayout = (global::Infragistics.Controls.Menus.NodeLayout)obj;
			nodeLayout.OnPropertyChanged("CheckBoxMemberPath");
			nodeLayout.OnPropertyChanged("CheckBoxMemberPathResolved");
			if (nodeLayout.Tree != null)
			{
				nodeLayout.Tree.InvalidateScrollPanel(true, false, true);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00005C68 File Offset: 0x00003E68
		public string CheckBoxMemberPathResolved
		{
			get
			{
				string result = "";
				if (!string.IsNullOrEmpty(this.CheckBoxMemberPath))
				{
					result = this.CheckBoxMemberPath;
				}
				else if (this.Tree != null)
				{
					result = this.Tree.CheckBoxMemberPath;
				}
				return result;
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00005CA8 File Offset: 0x00003EA8
		private static void OnIsEnabledMemberPathChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.NodeLayout nodeLayout = (global::Infragistics.Controls.Menus.NodeLayout)d;
			nodeLayout.OnPropertyChanged("IsEnabledMemberPath");
			nodeLayout.OnPropertyChanged("IsEnabledMemberPathResolved");
			if (nodeLayout.Tree != null)
			{
				nodeLayout.Tree.InvalidateScrollPanel(true, false, true);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00005CE8 File Offset: 0x00003EE8
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00005CFA File Offset: 0x00003EFA
		public string IsEnabledMemberPath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Menus.NodeLayout.IsEnabledMemberPathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.NodeLayout.IsEnabledMemberPathProperty, value);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00005D08 File Offset: 0x00003F08
		public string IsEnabledMemberPathResolved
		{
			get
			{
				if (!string.IsNullOrEmpty(this.IsEnabledMemberPath))
				{
					return this.IsEnabledMemberPath;
				}
				if (this.Tree != null)
				{
					return this.Tree.IsEnabledMemberPath;
				}
				return "";
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00005D37 File Offset: 0x00003F37
		// (set) Token: 0x06000128 RID: 296 RVA: 0x00005D49 File Offset: 0x00003F49
		public string IsExpandedMemberPath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Menus.NodeLayout.IsExpandedMemberPathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.NodeLayout.IsExpandedMemberPathProperty, value);
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00005D58 File Offset: 0x00003F58
		private static void IsExpandedMemberPathChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.NodeLayout nodeLayout = (global::Infragistics.Controls.Menus.NodeLayout)obj;
			nodeLayout.OnPropertyChanged("IsExpandedMemberPath");
			nodeLayout.OnPropertyChanged("IsExpandedMemberPathResolved");
			if (nodeLayout.Tree != null)
			{
				nodeLayout.Tree.InvalidateScrollPanel(true, false, true);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00005D98 File Offset: 0x00003F98
		public string IsExpandedMemberPathResolved
		{
			get
			{
				if (!string.IsNullOrEmpty(this.IsExpandedMemberPath))
				{
					return this.IsExpandedMemberPath;
				}
				if (this.Tree != null)
				{
					return this.Tree.IsExpandedMemberPath;
				}
				return "";
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00005DC7 File Offset: 0x00003FC7
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00005DD9 File Offset: 0x00003FD9
		public string IsSelectedMemberPath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Menus.NodeLayout.IsSelectedMemberPathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.NodeLayout.IsSelectedMemberPathProperty, value);
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00005DE8 File Offset: 0x00003FE8
		private static void OnIsSelectedMemberPathChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.NodeLayout nodeLayout = (global::Infragistics.Controls.Menus.NodeLayout)obj;
			nodeLayout.OnPropertyChanged("IsSelectedMemberPath");
			nodeLayout.OnPropertyChanged("IsSelectedMemberPathResolved");
			nodeLayout.OnIsSelectedMemberPathChanged((string)e.OldValue, (string)e.NewValue);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00005E30 File Offset: 0x00004030
		private void OnIsSelectedMemberPathChanged(string oldValue, string newValue)
		{
			if (this.Tree != null)
			{
				if (string.IsNullOrEmpty(newValue))
				{
					this.Tree.UnregisterLayoutForSelectedDataItems(this);
				}
				else
				{
					this.Tree.RegisterLayoutForSelectedDataItems(this);
				}
				this.Tree.ReflectChangesOverModel = string.IsNullOrEmpty(oldValue);
				this.Tree.UpdateLayoutSelectedItemsBySelectedMemberPath(this, true, true);
				this.Tree.ReflectChangesOverModel = true;
				this._cachedSelectedMemberPath = newValue;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00005E9C File Offset: 0x0000409C
		public string IsSelectedMemberPathResolved
		{
			get
			{
				string result = "";
				string text;
				if (base.Dispatcher.CheckAccess())
				{
					text = this.IsSelectedMemberPath;
				}
				else
				{
					text = this._cachedSelectedMemberPath;
				}
				if (!string.IsNullOrEmpty(text))
				{
					result = text;
				}
				else if (this.Tree != null)
				{
					result = this.Tree.IsSelectedMemberPathResolved;
				}
				return result;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00005EEF File Offset: 0x000040EF
		public global::Infragistics.Controls.Menus.NodeLayoutCollection NodeLayouts
		{
			get
			{
				if (this._nodeLayouts == null)
				{
					this._nodeLayouts = new global::Infragistics.Controls.Menus.NodeLayoutCollection();
					this._nodeLayouts.CollectionChanged += this.NodeLayouts_CollectionChanged;
				}
				return this._nodeLayouts;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00005F21 File Offset: 0x00004121
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00005F33 File Offset: 0x00004133
		public double Indentation
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.Menus.NodeLayout.IndentationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.NodeLayout.IndentationProperty, value);
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00005F48 File Offset: 0x00004148
		private static void IndentationChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.NodeLayout nodeLayout = (global::Infragistics.Controls.Menus.NodeLayout)obj;
			nodeLayout.OnPropertyChanged("Indentation");
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00005F68 File Offset: 0x00004168
		public double IndentationResolved
		{
			get
			{
				if (!double.IsNaN(this.Indentation))
				{
					return this.Indentation;
				}
				if (this.Tree != null)
				{
					return this.Tree.Indentation;
				}
				return (double)global::Infragistics.Controls.Menus.XamDataTree.IndentationProperty.GetMetadata(typeof(global::Infragistics.Controls.Menus.XamDataTree)).DefaultValue;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00005FBB File Offset: 0x000041BB
		// (set) Token: 0x06000136 RID: 310 RVA: 0x00005FCD File Offset: 0x000041CD
		public global::System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Menus.NodeLayout.ItemTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.NodeLayout.ItemTemplateProperty, value);
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00005FDC File Offset: 0x000041DC
		private static void ItemTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.NodeLayout nodeLayout = (global::Infragistics.Controls.Menus.NodeLayout)obj;
			nodeLayout.OnPropertyChanged("ItemTemplate");
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00005FFB File Offset: 0x000041FB
		public global::System.Windows.DataTemplate ItemTemplateResolved
		{
			get
			{
				if (this.ItemTemplate == null && this.Tree != null)
				{
					return this.Tree.ItemTemplate;
				}
				return this.ItemTemplate;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0000601F File Offset: 0x0000421F
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00006031 File Offset: 0x00004231
		public string HeaderText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Menus.NodeLayout.HeaderTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.NodeLayout.HeaderTextProperty, value);
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00006040 File Offset: 0x00004240
		private static void HeaderTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.NodeLayout nodeLayout = (global::Infragistics.Controls.Menus.NodeLayout)obj;
			nodeLayout.OnPropertyChanged("HeaderText");
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0000605F File Offset: 0x0000425F
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00006071 File Offset: 0x00004271
		public global::System.Windows.DataTemplate HeaderTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Menus.NodeLayout.HeaderTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.NodeLayout.HeaderTemplateProperty, value);
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00006080 File Offset: 0x00004280
		private static void HeaderTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.NodeLayout nodeLayout = (global::Infragistics.Controls.Menus.NodeLayout)obj;
			nodeLayout.OnPropertyChanged("HeaderTemplate");
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000609F File Offset: 0x0000429F
		public object HeaderContentResolved
		{
			get
			{
				if (this.HeaderTemplate != null)
				{
					return this.HeaderTemplate;
				}
				if (string.IsNullOrEmpty(this.HeaderText))
				{
					return base.Key;
				}
				return this.HeaderText;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000140 RID: 320 RVA: 0x000060CA File Offset: 0x000042CA
		// (set) Token: 0x06000141 RID: 321 RVA: 0x000060DC File Offset: 0x000042DC
		public global::System.Windows.DataTemplate EditorTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Menus.NodeLayout.EditorTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.NodeLayout.EditorTemplateProperty, value);
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000060EC File Offset: 0x000042EC
		private static void EditorTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.NodeLayout nodeLayout = (global::Infragistics.Controls.Menus.NodeLayout)obj;
			nodeLayout.OnPropertyChanged("EditorTemplate");
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0000610B File Offset: 0x0000430B
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0000614C File Offset: 0x0000434C
		public global::Infragistics.Controls.Menus.TreeEditingSettingsOverride EditingSettings
		{
			get
			{
				if (this._editingSettings == null)
				{
					this._editingSettings = new global::Infragistics.Controls.Menus.TreeEditingSettingsOverride();
					this._editingSettings.PropertyChanged += this.EditingSettings_PropertyChanged;
				}
				this._editingSettings.NodeLayout = this;
				return this._editingSettings;
			}
			set
			{
				if (this._editingSettings != value)
				{
					if (this._editingSettings != null)
					{
						this._editingSettings.PropertyChanged -= this.EditingSettings_PropertyChanged;
					}
					this._editingSettings = value;
					if (this._editingSettings != null)
					{
						this._editingSettings.PropertyChanged += this.EditingSettings_PropertyChanged;
					}
				}
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000061A7 File Offset: 0x000043A7
		private void EditingSettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000146 RID: 326 RVA: 0x000061A9 File Offset: 0x000043A9
		// (set) Token: 0x06000147 RID: 327 RVA: 0x000061E8 File Offset: 0x000043E8
		public global::Infragistics.Controls.Menus.CheckBoxSettingsOverride CheckBoxSettings
		{
			get
			{
				if (this._checkboxSettings == null)
				{
					this._checkboxSettings = new global::Infragistics.Controls.Menus.CheckBoxSettingsOverride();
					this._checkboxSettings.PropertyChanged += this.CheckboxSettings_PropertyChanged;
				}
				this._checkboxSettings.NodeLayout = this;
				return this._checkboxSettings;
			}
			set
			{
				if (this._checkboxSettings != value)
				{
					if (this._checkboxSettings != null)
					{
						this._checkboxSettings.PropertyChanged -= this.CheckboxSettings_PropertyChanged;
					}
					this._checkboxSettings = value;
					if (this._checkboxSettings != null)
					{
						this._checkboxSettings.PropertyChanged += this.CheckboxSettings_PropertyChanged;
					}
				}
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00006243 File Offset: 0x00004443
		private void CheckboxSettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00006245 File Offset: 0x00004445
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00006257 File Offset: 0x00004457
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? IsDraggable
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Menus.NodeLayout.IsDraggableProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.NodeLayout.IsDraggableProperty, value);
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000626C File Offset: 0x0000446C
		private static void IsDraggableChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.NodeLayout nodeLayout = (global::Infragistics.Controls.Menus.NodeLayout)obj;
			nodeLayout.OnPropertyChanged("IsDraggable");
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600014C RID: 332 RVA: 0x0000628C File Offset: 0x0000448C
		public bool IsDraggableResolved
		{
			get
			{
				bool result = false;
				if (this.IsDraggable != null)
				{
					result = this.IsDraggable.Value;
				}
				else if (this.Tree != null)
				{
					result = this.Tree.IsDraggable;
				}
				return result;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600014D RID: 333 RVA: 0x000062D1 File Offset: 0x000044D1
		// (set) Token: 0x0600014E RID: 334 RVA: 0x000062E3 File Offset: 0x000044E3
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? IsDropTarget
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Menus.NodeLayout.IsDropTargetProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.NodeLayout.IsDropTargetProperty, value);
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000062F8 File Offset: 0x000044F8
		private static void IsDropTargetChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.NodeLayout nodeLayout = (global::Infragistics.Controls.Menus.NodeLayout)obj;
			nodeLayout.OnPropertyChanged("IsDropTarget");
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00006318 File Offset: 0x00004518
		public bool IsDropTargetResolved
		{
			get
			{
				bool result = false;
				if (this.IsDropTarget != null)
				{
					result = this.IsDropTarget.Value;
				}
				else if (this.Tree != null)
				{
					result = this.Tree.IsDropTarget;
				}
				return result;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000635D File Offset: 0x0000455D
		public global::System.Windows.Style NodeStyleResolved
		{
			get
			{
				if (this.NodeStyle == null && this.Tree != null)
				{
					return this.Tree.NodeStyle;
				}
				return this.NodeStyle;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00006381 File Offset: 0x00004581
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00006393 File Offset: 0x00004593
		public global::System.Windows.Style NodeStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Menus.NodeLayout.NodeStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.NodeLayout.NodeStyleProperty, value);
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000063A4 File Offset: 0x000045A4
		private static void NodeStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.NodeLayout nodeLayout = (global::Infragistics.Controls.Menus.NodeLayout)obj;
			nodeLayout.OnPropertyChanged("NodeStyle");
			if (nodeLayout.Tree != null)
			{
				nodeLayout.Tree.InvalidateScrollPanel(false);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000155 RID: 341 RVA: 0x000063D7 File Offset: 0x000045D7
		// (set) Token: 0x06000156 RID: 342 RVA: 0x000063E9 File Offset: 0x000045E9
		public global::System.Windows.DataTemplate ExpandedIconTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Menus.NodeLayout.ExpandedIconTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.NodeLayout.ExpandedIconTemplateProperty, value);
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000063F8 File Offset: 0x000045F8
		private static void ExpandedIconTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.NodeLayout nodeLayout = (global::Infragistics.Controls.Menus.NodeLayout)obj;
			nodeLayout.OnPropertyChanged("ExpandedIconTemplate");
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00006418 File Offset: 0x00004618
		public global::System.Windows.DataTemplate ExpandedIconTemplateResolved
		{
			get
			{
				global::System.Windows.DataTemplate expandedIconTemplate = this.ExpandedIconTemplate;
				if (expandedIconTemplate == null && this.Tree != null)
				{
					expandedIconTemplate = this.Tree.ExpandedIconTemplate;
				}
				return expandedIconTemplate;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00006444 File Offset: 0x00004644
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00006456 File Offset: 0x00004656
		public global::System.Windows.DataTemplate CollapsedIconTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Menus.NodeLayout.CollapsedIconTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.NodeLayout.CollapsedIconTemplateProperty, value);
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00006464 File Offset: 0x00004664
		private static void CollapsedIconTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.NodeLayout nodeLayout = (global::Infragistics.Controls.Menus.NodeLayout)obj;
			nodeLayout.OnPropertyChanged("CollapsedIconTemplate");
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00006484 File Offset: 0x00004684
		public global::System.Windows.DataTemplate CollapsedIconTemplateResolved
		{
			get
			{
				global::System.Windows.DataTemplate collapsedIconTemplate = this.CollapsedIconTemplate;
				if (collapsedIconTemplate == null && this.Tree != null)
				{
					collapsedIconTemplate = this.Tree.CollapsedIconTemplate;
				}
				return collapsedIconTemplate;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600015D RID: 349 RVA: 0x000064B0 File Offset: 0x000046B0
		// (set) Token: 0x0600015E RID: 350 RVA: 0x000064B8 File Offset: 0x000046B8
		internal bool IsDefinedGlobally { get; set; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600015F RID: 351 RVA: 0x000064C1 File Offset: 0x000046C1
		// (set) Token: 0x06000160 RID: 352 RVA: 0x000064C9 File Offset: 0x000046C9
		internal bool IsInitialized { get; set; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000161 RID: 353 RVA: 0x000064D2 File Offset: 0x000046D2
		// (set) Token: 0x06000162 RID: 354 RVA: 0x000064DA File Offset: 0x000046DA
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.DataField> DataFields { get; set; }

		// Token: 0x06000163 RID: 355 RVA: 0x000064E3 File Offset: 0x000046E3
		protected override void OnKeyChanged()
		{
			base.OnKeyChanged();
			if (this.Tree != null && this.Tree.GlobalNodeLayouts.Contains(this))
			{
				this.IsDefinedGlobally = true;
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000650D File Offset: 0x0000470D
		protected override void OnPropertyChanged(string propertyName)
		{
			base.OnPropertyChanged(propertyName);
			this.NotifyNodeManagers_PropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00006524 File Offset: 0x00004724
		internal global::System.Reflection.PropertyInfo ResolvePropertyInfo(object data)
		{
			if (this._propertyInfo != null && data != null && this._propertyInfo.DeclaringType != data.GetType())
			{
				this._propertyInfo = null;
			}
			if (this._propertyInfo == null && data != null && !string.IsNullOrEmpty(base.Key))
			{
				if (this.IsDefinedGlobally && !string.IsNullOrEmpty(this.TargetTypeName))
				{
					global::System.Type type = data.GetType();
					global::System.Reflection.PropertyInfo[] properties = type.GetProperties(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public);
					foreach (global::System.Reflection.PropertyInfo propertyInfo in properties)
					{
						if (!(type == typeof(global::System.Data.DataRowView)) || !(propertyInfo.Name == "DataView"))
						{
							object obj = null;
							try
							{
								obj = propertyInfo.GetValue(data, null);
							}
							catch (global::System.Reflection.TargetParameterCountException)
							{
							}
							if (obj != null)
							{
								global::System.Collections.IEnumerable enumerable = obj as global::System.Collections.IEnumerable;
								if (enumerable != null)
								{
									global::System.Type type2 = global::Infragistics.DataManagerBase.ResolveItemType(enumerable);
									if (type2 != null && this == this.Tree.GlobalNodeLayouts.FromType(type2))
									{
										this._propertyInfo = propertyInfo;
										break;
									}
								}
							}
						}
					}
				}
				else
				{
					this._propertyInfo = data.GetType().GetProperty(base.Key, global::System.Reflection.BindingFlags.Public);
				}
			}
			return this._propertyInfo;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000166 RID: 358 RVA: 0x0000667C File Offset: 0x0000487C
		// (remove) Token: 0x06000167 RID: 359 RVA: 0x000066B4 File Offset: 0x000048B4
		internal event global::System.EventHandler<global::Infragistics.Controls.Menus.NodeLayoutEventArgs> ChildNodeLayoutRemoved;

		// Token: 0x06000168 RID: 360 RVA: 0x000066EC File Offset: 0x000048EC
		internal void OnChildNodeLayoutRemoved()
		{
			if (this.ChildNodeLayoutRemoved != null)
			{
				global::Infragistics.Controls.Menus.NodeLayoutEventArgs e = new global::Infragistics.Controls.Menus.NodeLayoutEventArgs
				{
					NodeLayout = this
				};
				this.ChildNodeLayoutRemoved(this, e);
				this.NotifyNodeManagers_ChildNodeLayoutRemoved(e);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000169 RID: 361 RVA: 0x00006724 File Offset: 0x00004924
		// (remove) Token: 0x0600016A RID: 362 RVA: 0x0000675C File Offset: 0x0000495C
		internal event global::System.EventHandler<global::Infragistics.Controls.Menus.NodeLayoutEventArgs> ChildNodeLayoutAdded;

		// Token: 0x0600016B RID: 363 RVA: 0x00006794 File Offset: 0x00004994
		internal void OnChildNodeLayoutAdded()
		{
			if (this.ChildNodeLayoutAdded != null)
			{
				global::Infragistics.Controls.Menus.NodeLayoutEventArgs e = new global::Infragistics.Controls.Menus.NodeLayoutEventArgs
				{
					NodeLayout = this
				};
				this.ChildNodeLayoutAdded(this, e);
				this.NotifyNodeManagers_ChildNodeLayoutAdded(e);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600016C RID: 364 RVA: 0x000067CC File Offset: 0x000049CC
		// (remove) Token: 0x0600016D RID: 365 RVA: 0x00006804 File Offset: 0x00004A04
		internal event global::System.EventHandler<global::Infragistics.Controls.Menus.NodeLayoutEventArgs> ChildNodeLayoutVisibilityChanged;

		// Token: 0x0600016E RID: 366 RVA: 0x0000683C File Offset: 0x00004A3C
		internal void OnChildNodeLayoutVisibilityChanged()
		{
			if (this.ChildNodeLayoutVisibilityChanged != null)
			{
				global::Infragistics.Controls.Menus.NodeLayoutEventArgs e = new global::Infragistics.Controls.Menus.NodeLayoutEventArgs
				{
					NodeLayout = this
				};
				this.ChildNodeLayoutVisibilityChanged(this, e);
				this.NotifyNodeManagers_ChildNodeLayoutVisibilityChanged(e);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600016F RID: 367 RVA: 0x00006874 File Offset: 0x00004A74
		// (remove) Token: 0x06000170 RID: 368 RVA: 0x000068AC File Offset: 0x00004AAC
		internal event global::System.EventHandler<global::System.EventArgs> NodeLayoutDisposed;

		// Token: 0x06000171 RID: 369 RVA: 0x000068E1 File Offset: 0x00004AE1
		internal void OnNodeLayoutDisposed()
		{
			if (this.NodeLayoutDisposed != null)
			{
				this.NodeLayoutDisposed(this, global::System.EventArgs.Empty);
				this.NotifyNodeManagers_NodeLayoutDisposed(global::System.EventArgs.Empty);
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00006908 File Offset: 0x00004B08
		private void Tree_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.OnPropertyChanged(e.PropertyName);
			this.Tree.InvalidateScrollPanel(true);
			this.CheckBoxSettings.InvalidateResolvedProperties();
			string propertyName;
			if ((propertyName = e.PropertyName) != null)
			{
				if (propertyName == "CollapsedIconTemplate")
				{
					this.OnPropertyChanged(e.PropertyName + "Resolved");
					return;
				}
				if (!(propertyName == "ExpandedIconTemplate"))
				{
					return;
				}
				this.OnPropertyChanged(e.PropertyName + "Resolved");
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000698C File Offset: 0x00004B8C
		private void NodeLayouts_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
			{
				using (global::System.Collections.IEnumerator enumerator = e.NewItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						global::Infragistics.Controls.Menus.NodeLayout nodeLayout = (global::Infragistics.Controls.Menus.NodeLayout)obj;
						nodeLayout.Tree = this.Tree;
					}
					return;
				}
			}
			if (e.OldItems != null)
			{
				foreach (object obj2 in e.OldItems)
				{
					global::Infragistics.Controls.Menus.NodeLayout nodeLayout2 = (global::Infragistics.Controls.Menus.NodeLayout)obj2;
					nodeLayout2.Tree = null;
				}
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00006A4C File Offset: 0x00004C4C
		internal void UnSubscribeForNotifications(global::Infragistics.Controls.Menus.NodesManager nodesManager)
		{
			if (this._managersToBeNotified.Contains(nodesManager))
			{
				this._managersToBeNotified.Remove(nodesManager);
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00006A69 File Offset: 0x00004C69
		internal void SubscribeForNotifications(global::Infragistics.Controls.Menus.NodesManager nodesManager)
		{
			this._managersToBeNotified.Add(nodesManager);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00006A78 File Offset: 0x00004C78
		private void NotifyNodeManagers_PropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			foreach (global::Infragistics.Controls.Menus.NodesManager nodesManager in this._managersToBeNotified)
			{
				nodesManager.OnNodeLayoutPropertyChanged(this, e);
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00006ACC File Offset: 0x00004CCC
		private void NotifyNodeManagers_ChildNodeLayoutRemoved(global::Infragistics.Controls.Menus.NodeLayoutEventArgs e)
		{
			foreach (global::Infragistics.Controls.Menus.NodesManager nodesManager in this._managersToBeNotified)
			{
				nodesManager.NodeLayout_ChildNodeLayoutRemoved(this, e);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00006B20 File Offset: 0x00004D20
		private void NotifyNodeManagers_ChildNodeLayoutAdded(global::Infragistics.Controls.Menus.NodeLayoutEventArgs e)
		{
			foreach (global::Infragistics.Controls.Menus.NodesManager nodesManager in this._managersToBeNotified)
			{
				nodesManager.NodeLayout_ChildNodeLayoutAdded(this, e);
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00006B74 File Offset: 0x00004D74
		private void NotifyNodeManagers_ChildNodeLayoutVisibilityChanged(global::Infragistics.Controls.Menus.NodeLayoutEventArgs e)
		{
			foreach (global::Infragistics.Controls.Menus.NodesManager nodesManager in this._managersToBeNotified)
			{
				nodesManager.NodeLayout_ChildNodeLayoutVisibilityChanged(this, e);
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00006BC8 File Offset: 0x00004DC8
		private void NotifyNodeManagers_NodeLayoutDisposed(global::System.EventArgs e)
		{
			foreach (global::Infragistics.Controls.Menus.NodesManager nodesManager in this._managersToBeNotified)
			{
				nodesManager.NodeLayout_NodeLayoutDisposed(this, e);
			}
		}

		// Token: 0x0400004E RID: 78
		protected internal const string ROOT_LAYOUT_KEY = "XamDataTree_Root_XamDataTree";

		// Token: 0x0400004F RID: 79
		private global::Infragistics.Controls.Menus.XamDataTree _tree;

		// Token: 0x04000050 RID: 80
		private global::System.Reflection.PropertyInfo _propertyInfo;

		// Token: 0x04000051 RID: 81
		private global::Infragistics.Controls.Menus.NodeLayoutCollection _nodeLayouts;

		// Token: 0x04000052 RID: 82
		private global::Infragistics.Controls.Menus.TreeEditingSettingsOverride _editingSettings;

		// Token: 0x04000053 RID: 83
		private global::Infragistics.Controls.Menus.CheckBoxSettingsOverride _checkboxSettings;

		// Token: 0x04000054 RID: 84
		private string _cachedSelectedMemberPath;

		// Token: 0x04000055 RID: 85
		public static readonly global::System.Windows.DependencyProperty TargetTypeNameProperty = global::System.Windows.DependencyProperty.Register("TargetTypeName", typeof(string), typeof(global::Infragistics.Controls.Menus.NodeLayout), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.NodeLayout.TargetTypeNameChanged)));

		// Token: 0x04000056 RID: 86
		public static readonly global::System.Windows.DependencyProperty VisibilityProperty = global::System.Windows.DependencyProperty.Register("Visibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Menus.NodeLayout), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.NodeLayout.VisibilityChanged)));

		// Token: 0x04000057 RID: 87
		public static readonly global::System.Windows.DependencyProperty DisplayMemberPathProperty = global::System.Windows.DependencyProperty.Register("DisplayMemberPath", typeof(string), typeof(global::Infragistics.Controls.Menus.NodeLayout), new global::System.Windows.PropertyMetadata("", new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.NodeLayout.DisplayMemberPathChanged)));

		// Token: 0x04000058 RID: 88
		public static readonly global::System.Windows.DependencyProperty CheckBoxMemberPathProperty = global::System.Windows.DependencyProperty.Register("CheckBoxMemberPath", typeof(string), typeof(global::Infragistics.Controls.Menus.NodeLayout), new global::System.Windows.PropertyMetadata("", new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.NodeLayout.CheckBoxMemberPathChanged)));

		// Token: 0x04000059 RID: 89
		public static readonly global::System.Windows.DependencyProperty IsEnabledMemberPathProperty = global::Infragistics.DependencyPropertyUtilities.Register("IsEnabledMemberPath", typeof(string), typeof(global::Infragistics.Controls.Menus.NodeLayout), global::Infragistics.DependencyPropertyUtilities.CreateMetadata("", new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.NodeLayout.OnIsEnabledMemberPathChanged)));

		// Token: 0x0400005A RID: 90
		public static readonly global::System.Windows.DependencyProperty IsExpandedMemberPathProperty = global::System.Windows.DependencyProperty.Register("IsExpandedMemberPath", typeof(string), typeof(global::Infragistics.Controls.Menus.NodeLayout), new global::System.Windows.PropertyMetadata("", new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.NodeLayout.IsExpandedMemberPathChanged)));

		// Token: 0x0400005B RID: 91
		public static readonly global::System.Windows.DependencyProperty IsSelectedMemberPathProperty = global::System.Windows.DependencyProperty.Register("IsSelectedMemberPath", typeof(string), typeof(global::Infragistics.Controls.Menus.NodeLayout), new global::System.Windows.PropertyMetadata(string.Empty, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.NodeLayout.OnIsSelectedMemberPathChanged)));

		// Token: 0x0400005C RID: 92
		public static readonly global::System.Windows.DependencyProperty IndentationProperty = global::System.Windows.DependencyProperty.Register("Indentation", typeof(double), typeof(global::Infragistics.Controls.Menus.NodeLayout), new global::System.Windows.PropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.NodeLayout.IndentationChanged)));

		// Token: 0x0400005D RID: 93
		public static readonly global::System.Windows.DependencyProperty ItemTemplateProperty = global::System.Windows.DependencyProperty.Register("ItemTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Menus.NodeLayout), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.NodeLayout.ItemTemplateChanged)));

		// Token: 0x0400005E RID: 94
		public static readonly global::System.Windows.DependencyProperty HeaderTextProperty = global::System.Windows.DependencyProperty.Register("HeaderText", typeof(string), typeof(global::Infragistics.Controls.Menus.NodeLayout), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.NodeLayout.HeaderTextChanged)));

		// Token: 0x0400005F RID: 95
		public static readonly global::System.Windows.DependencyProperty HeaderTemplateProperty = global::System.Windows.DependencyProperty.Register("HeaderTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Menus.NodeLayout), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.NodeLayout.HeaderTemplateChanged)));

		// Token: 0x04000060 RID: 96
		public static readonly global::System.Windows.DependencyProperty EditorTemplateProperty = global::System.Windows.DependencyProperty.Register("EditorTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Menus.NodeLayout), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.NodeLayout.EditorTemplateChanged)));

		// Token: 0x04000061 RID: 97
		public static readonly global::System.Windows.DependencyProperty IsDraggableProperty = global::System.Windows.DependencyProperty.Register("IsDraggable", typeof(bool?), typeof(global::Infragistics.Controls.Menus.NodeLayout), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.NodeLayout.IsDraggableChanged)));

		// Token: 0x04000062 RID: 98
		public static readonly global::System.Windows.DependencyProperty IsDropTargetProperty = global::System.Windows.DependencyProperty.Register("IsDropTarget", typeof(bool?), typeof(global::Infragistics.Controls.Menus.NodeLayout), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.NodeLayout.IsDropTargetChanged)));

		// Token: 0x04000063 RID: 99
		public static readonly global::System.Windows.DependencyProperty NodeStyleProperty = global::System.Windows.DependencyProperty.Register("NodeStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Menus.NodeLayout), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.NodeLayout.NodeStyleChanged)));

		// Token: 0x04000064 RID: 100
		public static readonly global::System.Windows.DependencyProperty ExpandedIconTemplateProperty = global::System.Windows.DependencyProperty.Register("ExpandedIconTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Menus.NodeLayout), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.NodeLayout.ExpandedIconTemplateChanged)));

		// Token: 0x04000065 RID: 101
		public static readonly global::System.Windows.DependencyProperty CollapsedIconTemplateProperty = global::System.Windows.DependencyProperty.Register("CollapsedIconTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Menus.NodeLayout), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.NodeLayout.CollapsedIconTemplateChanged)));

		// Token: 0x0400006A RID: 106
		private global::System.Collections.Generic.HashSet<global::Infragistics.Controls.Menus.NodesManager> _managersToBeNotified = new global::System.Collections.Generic.HashSet<global::Infragistics.Controls.Menus.NodesManager>();
	}
}
