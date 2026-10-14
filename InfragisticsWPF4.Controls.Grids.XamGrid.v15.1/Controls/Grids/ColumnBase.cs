using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000232 RID: 562
	public abstract class ColumnBase : global::Infragistics.DependencyObjectNotifier, global::Infragistics.IProvidePropertyPersistenceSettings
	{
		// Token: 0x06000FB2 RID: 4018 RVA: 0x0003B4E5 File Offset: 0x000396E5
		protected ColumnBase()
		{
			this.DataField = new global::Infragistics.DataField(string.Empty, null);
			this._cachedVisibility = this.Visibility;
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x0003B511 File Offset: 0x00039711
		// (set) Token: 0x06000FB4 RID: 4020 RVA: 0x0003B523 File Offset: 0x00039723
		public string Key
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.ColumnBase.KeyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnBase.KeyProperty, value);
			}
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x0003B531 File Offset: 0x00039731
		private static void KeyChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x0003B533 File Offset: 0x00039733
		// (set) Token: 0x06000FB7 RID: 4023 RVA: 0x0003B53B File Offset: 0x0003973B
		public global::System.Windows.Visibility Visibility
		{
			get
			{
				return this._cachedVisibility;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnBase.VisibilityProperty, value);
			}
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x0003B550 File Offset: 0x00039750
		private static void VisibilityChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnBase columnBase = (global::Infragistics.Controls.Grids.ColumnBase)obj;
			global::System.Windows.Visibility visibility = (global::System.Windows.Visibility)e.NewValue;
			columnBase._cachedVisibility = visibility;
			if (visibility == global::System.Windows.Visibility.Visible)
			{
				global::Infragistics.Controls.Grids.Column column = columnBase as global::Infragistics.Controls.Grids.Column;
				if (column != null && column.AllVisibleChildColumns.Count == 0 && column.AllColumns.Count > 0)
				{
					foreach (global::Infragistics.Controls.Grids.Column column2 in column.AllColumns)
					{
						column2.Visibility = global::System.Windows.Visibility.Visible;
					}
				}
				if (column != null && column.ParentColumn != null && column.ParentColumn.Visibility == global::System.Windows.Visibility.Collapsed)
				{
					column.ParentColumn.Visibility = global::System.Windows.Visibility.Visible;
					column.Visibility = global::System.Windows.Visibility.Visible;
				}
			}
			else
			{
				global::Infragistics.Controls.Grids.Column column3 = columnBase as global::Infragistics.Controls.Grids.Column;
				if (column3 != null && column3.ParentColumn != null && column3.ParentColumn.AllVisibleChildColumns.Count == 0)
				{
					column3.ParentColumn.Visibility = global::System.Windows.Visibility.Collapsed;
				}
			}
			columnBase.OnVisibilityChanged();
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x0003B654 File Offset: 0x00039854
		protected virtual void OnVisibilityChanged()
		{
			this.OnPropertyChanged("Visibility");
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x0003B661 File Offset: 0x00039861
		// (set) Token: 0x06000FBB RID: 4027 RVA: 0x0003B669 File Offset: 0x00039869
		public global::Infragistics.Controls.Grids.ColumnLayout ColumnLayout
		{
			get
			{
				return this._layout;
			}
			protected internal set
			{
				if (this._layout != value)
				{
					this._layout = value;
					this.OnColumnLayoutChanged();
				}
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000FBC RID: 4028 RVA: 0x0003B681 File Offset: 0x00039881
		// (set) Token: 0x06000FBD RID: 4029 RVA: 0x0003B68C File Offset: 0x0003988C
		public global::System.Windows.Style CellStyle
		{
			get
			{
				return this._cellStyle;
			}
			set
			{
				if (this._cellStyle != value)
				{
					this._cellStyle = value;
					global::System.Windows.Controls.ControlTemplate controlTemplateForConditionalFormatting = null;
					this.StrippedCellStyleForConditionalFormatting = global::Infragistics.Controls.Grids.XamGrid.CloneStyleWithoutControlTemplate(value, out controlTemplateForConditionalFormatting);
					this.ControlTemplateForConditionalFormatting = controlTemplateForConditionalFormatting;
					this.OnStyleChanged();
					this.OnPropertyChanged("CellStyle");
				}
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x0003B6D1 File Offset: 0x000398D1
		public virtual global::System.Windows.Style CellStyleResolved
		{
			get
			{
				if (this.CellStyle == null && this.ColumnLayout != null)
				{
					return this.ColumnLayout.CellStyleResolved;
				}
				return this.CellStyle;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000FBF RID: 4031 RVA: 0x0003B6F5 File Offset: 0x000398F5
		// (set) Token: 0x06000FC0 RID: 4032 RVA: 0x0003B6FD File Offset: 0x000398FD
		public global::System.Windows.Style HeaderStyle
		{
			get
			{
				return this._headerStyle;
			}
			set
			{
				if (this._headerStyle != value)
				{
					this._headerStyle = value;
					this.OnStyleChanged();
					this.OnPropertyChanged("HeaderStyle");
				}
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000FC1 RID: 4033 RVA: 0x0003B720 File Offset: 0x00039920
		public virtual global::System.Windows.Style HeaderStyleResolved
		{
			get
			{
				if (this.HeaderStyle == null && this.ColumnLayout != null)
				{
					return this.ColumnLayout.HeaderStyleResolved;
				}
				return this.HeaderStyle;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x0003B744 File Offset: 0x00039944
		// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x0003B74C File Offset: 0x0003994C
		public global::System.Windows.Style FooterStyle
		{
			get
			{
				return this._footerStyle;
			}
			set
			{
				if (this._footerStyle != value)
				{
					this._footerStyle = value;
					this.OnStyleChanged();
					this.OnPropertyChanged("FooterStyle");
				}
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x0003B76F File Offset: 0x0003996F
		public virtual global::System.Windows.Style FooterStyleResolved
		{
			get
			{
				if (this.FooterStyle == null && this.ColumnLayout != null)
				{
					return this.ColumnLayout.FooterStyleResolved;
				}
				return this.FooterStyle;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x0003B793 File Offset: 0x00039993
		// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x0003B79B File Offset: 0x0003999B
		public bool IsAutoGenerated { get; protected internal set; }

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x0003B7A4 File Offset: 0x000399A4
		// (set) Token: 0x06000FC8 RID: 4040 RVA: 0x0003B7B1 File Offset: 0x000399B1
		public object Tag
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Grids.ColumnBase.TagProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnBase.TagProperty, value);
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x0003B7BF File Offset: 0x000399BF
		// (set) Token: 0x06000FCA RID: 4042 RVA: 0x0003B7C7 File Offset: 0x000399C7
		public virtual global::System.Type DataType
		{
			get
			{
				return this._dataType;
			}
			protected internal set
			{
				if (value != this._dataType)
				{
					this._dataType = value;
					this.OnDataTypeChanged();
				}
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x0003B7E4 File Offset: 0x000399E4
		// (set) Token: 0x06000FCC RID: 4044 RVA: 0x0003B7F6 File Offset: 0x000399F6
		public string HeaderText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.ColumnBase.HeaderTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnBase.HeaderTextProperty, value);
			}
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x0003B804 File Offset: 0x00039A04
		private static void HeaderTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnBase columnBase = (global::Infragistics.Controls.Grids.ColumnBase)obj;
			columnBase.OnPropertyChanged("HeaderText");
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x0003B823 File Offset: 0x00039A23
		// (set) Token: 0x06000FCF RID: 4047 RVA: 0x0003B82B File Offset: 0x00039A2B
		public global::System.Windows.DataTemplate HeaderTemplate
		{
			get
			{
				return this._headerTemplate;
			}
			set
			{
				this._headerTemplate = value;
				this.OnPropertyChanged("HeaderTemplate");
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x0003B83F File Offset: 0x00039A3F
		public string DisplayNameResolved
		{
			get
			{
				if (string.IsNullOrEmpty(this.HeaderText))
				{
					return this.Key;
				}
				return this.HeaderText;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x0003B85B File Offset: 0x00039A5B
		// (set) Token: 0x06000FD2 RID: 4050 RVA: 0x0003B863 File Offset: 0x00039A63
		public virtual bool IsHideable
		{
			get
			{
				return this._isHideable;
			}
			set
			{
				if (this._isHideable != value)
				{
					this._isHideable = value;
					this.OnPropertyChanged("IsHideable");
				}
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x0003B880 File Offset: 0x00039A80
		protected internal virtual bool RequiresBoundDataKey
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x0003B884 File Offset: 0x00039A84
		protected virtual global::System.Collections.Generic.List<string> PropertiesToIgnore
		{
			get
			{
				if (this._propertiesThatShouldntBePersisted == null)
				{
					this._propertiesThatShouldntBePersisted = new global::System.Collections.Generic.List<string>
					{
						"ColumnLayout"
					};
				}
				return this._propertiesThatShouldntBePersisted;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x0003B8B7 File Offset: 0x00039AB7
		protected virtual global::System.Collections.Generic.List<string> PriorityProperties
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x0003B8BA File Offset: 0x00039ABA
		// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x0003B8C2 File Offset: 0x00039AC2
		protected internal global::Infragistics.DataField DataField { get; set; }

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x0003B8CB File Offset: 0x00039ACB
		// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x0003B8D3 File Offset: 0x00039AD3
		internal bool IsMoving { get; set; }

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x0003B8DC File Offset: 0x00039ADC
		// (set) Token: 0x06000FDB RID: 4059 RVA: 0x0003B8E4 File Offset: 0x00039AE4
		internal global::System.Windows.Style StrippedCellStyleForConditionalFormatting { get; set; }

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x0003B8ED File Offset: 0x00039AED
		internal virtual global::System.Windows.Style StrippedCellStyleForConditionalFormattingResolved
		{
			get
			{
				if (this.StrippedCellStyleForConditionalFormatting == null && this.ColumnLayout != null)
				{
					return this.ColumnLayout.StrippedCellStyleForConditionalFormattingResolved;
				}
				return this.StrippedCellStyleForConditionalFormatting;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x0003B911 File Offset: 0x00039B11
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x0003B919 File Offset: 0x00039B19
		internal global::System.Windows.Controls.ControlTemplate ControlTemplateForConditionalFormatting { get; set; }

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x0003B922 File Offset: 0x00039B22
		internal virtual global::System.Windows.Controls.ControlTemplate ControlTemplateForConditionalFormattingResolved
		{
			get
			{
				if (this.ControlTemplateForConditionalFormatting == null && this.ColumnLayout != null)
				{
					return this.ColumnLayout.ControlTemplateForConditionalFormattingResolved;
				}
				return this.ControlTemplateForConditionalFormatting;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x0003B948 File Offset: 0x00039B48
		internal int VisibleColumnIndex
		{
			get
			{
				global::Infragistics.Controls.Grids.ColumnLayout columnLayout = this.ColumnLayout;
				int result = -1;
				if (columnLayout != null && this is global::Infragistics.Controls.Grids.Column)
				{
					global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column> visibleColumns = columnLayout.Columns.VisibleColumns;
					if (this._lastVisibleColumnIndex < 0 || this._lastVisibleColumnIndex >= visibleColumns.Count || this != visibleColumns[this._lastVisibleColumnIndex])
					{
						this._lastVisibleColumnIndex = visibleColumns.IndexOf((global::Infragistics.Controls.Grids.Column)this);
					}
					result = this._lastVisibleColumnIndex;
				}
				return result;
			}
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x0003B9B5 File Offset: 0x00039BB5
		protected internal virtual void OnStyleChanged()
		{
			if (this.ColumnLayout != null)
			{
				this.ColumnLayout.Grid.ResetPanelRows();
			}
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x0003B9CF File Offset: 0x00039BCF
		protected virtual void OnDataTypeChanged()
		{
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x0003B9D4 File Offset: 0x00039BD4
		protected internal virtual object ResolveValue(object value, global::System.Globalization.CultureInfo culture)
		{
			if (this.DataType != null)
			{
				global::System.Type type = this.DataType;
				bool isGenericType = type.IsGenericType;
				bool flag = isGenericType && type.GetGenericTypeDefinition().Equals(typeof(global::System.Nullable<>));
				if (flag)
				{
					if (value == null)
					{
						return null;
					}
					global::System.Type underlyingType = global::System.Nullable.GetUnderlyingType(type);
					type = underlyingType;
				}
				else if (value == null)
				{
					return value;
				}
				global::System.Type type2 = value.GetType();
				if (!(value is global::System.IConvertible) || global::Infragistics.CoreUtilities.IsKnownType(type2))
				{
					if (type2 == type)
					{
						return value;
					}
					global::System.ComponentModel.TypeConverter converter = global::Infragistics.Controls.Grids.ColumnBase.GetConverter(type);
					if (converter != null && converter.CanConvertFrom(type2))
					{
						return converter.ConvertFrom(null, culture, value);
					}
				}
				return global::System.Convert.ChangeType(value, type, culture);
			}
			return value;
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x0003BA85 File Offset: 0x00039C85
		protected internal virtual object ResolveValue(object value)
		{
			return this.ResolveValue(value, global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x0003BA93 File Offset: 0x00039C93
		protected virtual void FinishedLoadingPersistence()
		{
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x0003BA95 File Offset: 0x00039C95
		protected virtual void OnColumnLayoutChanged()
		{
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0003BA98 File Offset: 0x00039C98
		internal static global::System.ComponentModel.TypeConverter GetConverter(global::System.Type type)
		{
			bool isEnum = type.IsEnum;
			if (type == null || global::Infragistics.CoreUtilities.IsKnownType(type) || isEnum || type == typeof(object))
			{
				return null;
			}
			if (global::Infragistics.Controls.Grids.ColumnBase._typeConverterTable == null)
			{
				global::Infragistics.Controls.Grids.ColumnBase._typeConverterTable = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.ComponentModel.TypeConverter>();
			}
			global::System.ComponentModel.TypeConverter typeConverter;
			if (!global::Infragistics.Controls.Grids.ColumnBase._typeConverterTable.TryGetValue(type, out typeConverter))
			{
				try
				{
					object[] customAttributes = type.GetCustomAttributes(typeof(global::System.ComponentModel.TypeConverterAttribute), true);
					if (customAttributes != null && customAttributes.Length > 0)
					{
						global::System.ComponentModel.TypeConverterAttribute typeConverterAttribute = customAttributes[0] as global::System.ComponentModel.TypeConverterAttribute;
						global::System.Type type2 = global::System.Type.GetType(typeConverterAttribute.ConverterTypeName, false);
						if (null != type2)
						{
							typeConverter = (global::System.ComponentModel.TypeConverter)global::System.Activator.CreateInstance(type2);
						}
					}
				}
				catch
				{
				}
				global::Infragistics.Controls.Grids.ColumnBase._typeConverterTable[type] = typeConverter;
			}
			return typeConverter;
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x0003BB60 File Offset: 0x00039D60
		global::System.Collections.Generic.List<string> global::Infragistics.IProvidePropertyPersistenceSettings.PropertiesToIgnore
		{
			get
			{
				return this.PropertiesToIgnore;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x0003BB68 File Offset: 0x00039D68
		global::System.Collections.Generic.List<string> global::Infragistics.IProvidePropertyPersistenceSettings.PriorityProperties
		{
			get
			{
				return this.PriorityProperties;
			}
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x0003BB70 File Offset: 0x00039D70
		void global::Infragistics.IProvidePropertyPersistenceSettings.FinishedLoadingPersistence()
		{
			this.FinishedLoadingPersistence();
		}

		// Token: 0x040004E9 RID: 1257
		private global::System.Windows.DataTemplate _headerTemplate;

		// Token: 0x040004EA RID: 1258
		private global::System.Type _dataType;

		// Token: 0x040004EB RID: 1259
		private global::System.Collections.Generic.List<string> _propertiesThatShouldntBePersisted;

		// Token: 0x040004EC RID: 1260
		private global::System.Windows.Style _cellStyle;

		// Token: 0x040004ED RID: 1261
		private global::System.Windows.Style _headerStyle;

		// Token: 0x040004EE RID: 1262
		private global::System.Windows.Style _footerStyle;

		// Token: 0x040004EF RID: 1263
		private bool _isHideable = true;

		// Token: 0x040004F0 RID: 1264
		private global::Infragistics.Controls.Grids.ColumnLayout _layout;

		// Token: 0x040004F1 RID: 1265
		private global::System.Windows.Visibility _cachedVisibility;

		// Token: 0x040004F2 RID: 1266
		[global::System.ThreadStatic]
		private static global::System.Collections.Generic.Dictionary<global::System.Type, global::System.ComponentModel.TypeConverter> _typeConverterTable;

		// Token: 0x040004F3 RID: 1267
		public static readonly global::System.Windows.DependencyProperty KeyProperty = global::System.Windows.DependencyProperty.Register("Key", typeof(string), typeof(global::Infragistics.Controls.Grids.ColumnBase), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnBase.KeyChanged)));

		// Token: 0x040004F4 RID: 1268
		public static readonly global::System.Windows.DependencyProperty VisibilityProperty = global::System.Windows.DependencyProperty.Register("Visibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Grids.ColumnBase), new global::System.Windows.PropertyMetadata(global::System.Windows.Visibility.Visible, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnBase.VisibilityChanged)));

		// Token: 0x040004F5 RID: 1269
		public static readonly global::System.Windows.DependencyProperty TagProperty = global::System.Windows.DependencyProperty.Register("Tag", typeof(object), typeof(global::Infragistics.Controls.Grids.ColumnBase), null);

		// Token: 0x040004F6 RID: 1270
		public static readonly global::System.Windows.DependencyProperty HeaderTextProperty = global::System.Windows.DependencyProperty.Register("HeaderText", typeof(string), typeof(global::Infragistics.Controls.Grids.ColumnBase), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnBase.HeaderTextChanged)));

		// Token: 0x040004F7 RID: 1271
		private int _lastVisibleColumnIndex;
	}
}
