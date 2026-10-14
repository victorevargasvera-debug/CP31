using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000E8 RID: 232
	public class RowsFilter : global::Infragistics.IRecordFilter, global::Infragistics.IExpressConditions, global::System.ComponentModel.INotifyPropertyChanged, global::System.IDisposable
	{
		// Token: 0x17000251 RID: 593
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x0001F78C File Offset: 0x0001D98C
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.ConditionCollection Conditions
		{
			get
			{
				if (this._conditions == null)
				{
					this._conditions = new global::Infragistics.ConditionCollection();
					this._conditions.CollectionItemChanged += this.Conditions_CollectionItemChanged;
					this._conditions.CollectionChanged += this.Conditions_CollectionChanged;
					this._conditions.PropertyChanged += this.Conditions_PropertyChanged;
				}
				if (this._conditions.Parent != this)
				{
					this._conditions.Parent = this;
				}
				return this._conditions;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x0001F811 File Offset: 0x0001DA11
		// (set) Token: 0x0600078E RID: 1934 RVA: 0x0001F819 File Offset: 0x0001DA19
		public global::System.Type ObjectType
		{
			get
			{
				return this._objectType;
			}
			set
			{
				if (this._objectType == null)
				{
					this._objectType = value;
				}
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x0001F830 File Offset: 0x0001DA30
		// (set) Token: 0x06000790 RID: 1936 RVA: 0x0001F838 File Offset: 0x0001DA38
		public global::Infragistics.CachedTypedInfo ObjectTypedInfo { get; set; }

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x0001F841 File Offset: 0x0001DA41
		// (set) Token: 0x06000792 RID: 1938 RVA: 0x0001F849 File Offset: 0x0001DA49
		public global::Infragistics.Controls.Grids.Column Column
		{
			get
			{
				return this._column;
			}
			set
			{
				if (this._column == null)
				{
					this._column = value;
				}
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x0001F85C File Offset: 0x0001DA5C
		public virtual string FieldName
		{
			get
			{
				string result = null;
				if (this.Column != null)
				{
					result = this.Column.Key;
				}
				return result;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x0001F880 File Offset: 0x0001DA80
		public virtual global::System.Type FieldType
		{
			get
			{
				global::System.Type result = null;
				if (this.Column != null)
				{
					result = this.Column.DataType;
				}
				return result;
			}
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0001F8A4 File Offset: 0x0001DAA4
		public RowsFilter(global::System.Type objectType, global::Infragistics.Controls.Grids.Column column)
		{
			this.ObjectType = objectType;
			this.Column = column;
			if (this.Column != null && this.Column.ColumnLayout != null)
			{
				this.ObjectTypedInfo = this.Column.ColumnLayout.ObjectDataTypeInfo;
			}
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0001F8F0 File Offset: 0x0001DAF0
		public RowsFilter()
		{
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0001F8F8 File Offset: 0x0001DAF8
		protected virtual global::System.Linq.Expressions.Expression GetCurrentExpression()
		{
			global::System.Linq.Expressions.Expression result = null;
			if (this.Column != null && this.Column.ColumnLayout != null)
			{
				this.ObjectTypedInfo = this.Column.ColumnLayout.ObjectDataTypeInfo;
				bool flag = this.Column is global::Infragistics.Controls.Grids.DateColumn;
				global::Infragistics.FilterContext context = global::Infragistics.FilterContext.CreateGenericFilter(this.Column.ColumnLayout.ObjectDataTypeInfo, this.Column.DataType, this.Column.FilterColumnSettings.FilterCaseSensitive, flag && this.Column.ColumnLayout.FilteringSettings.AllowFilteringResolved != global::Infragistics.Controls.Grids.FilterUIType.FilterMenu);
				result = this.GetCurrentExpression(context);
			}
			return result;
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0001F99F File Offset: 0x0001DB9F
		protected virtual global::System.Linq.Expressions.Expression GetCurrentExpression(global::Infragistics.FilterContext context)
		{
			if (this.Column != null && this.Column.ColumnLayout != null)
			{
				this.ObjectTypedInfo = this.Column.ColumnLayout.ObjectDataTypeInfo;
			}
			return context.CreateExpression(this.Conditions);
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x0001F9D8 File Offset: 0x0001DBD8
		string global::Infragistics.IRecordFilter.FieldName
		{
			get
			{
				return this.FieldName;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x0001F9E0 File Offset: 0x0001DBE0
		global::Infragistics.ConditionCollection global::Infragistics.IRecordFilter.Conditions
		{
			get
			{
				return this.Conditions;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x0001F9E8 File Offset: 0x0001DBE8
		global::System.Type global::Infragistics.IRecordFilter.ObjectType
		{
			get
			{
				return this.ObjectType;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x0001F9F0 File Offset: 0x0001DBF0
		global::System.Type global::Infragistics.IRecordFilter.FieldType
		{
			get
			{
				return this.FieldType;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x0001F9F8 File Offset: 0x0001DBF8
		global::Infragistics.CachedTypedInfo global::Infragistics.IRecordFilter.ObjectTypedInfo
		{
			get
			{
				return this.ObjectTypedInfo;
			}
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0001FA00 File Offset: 0x0001DC00
		global::System.Linq.Expressions.Expression global::Infragistics.IExpressConditions.GetCurrentExpression(global::Infragistics.FilterContext context)
		{
			return this.GetCurrentExpression(context);
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0001FA09 File Offset: 0x0001DC09
		global::System.Linq.Expressions.Expression global::Infragistics.IExpressConditions.GetCurrentExpression()
		{
			return this.GetCurrentExpression();
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0001FA11 File Offset: 0x0001DC11
		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060007A1 RID: 1953 RVA: 0x0001FA30 File Offset: 0x0001DC30
		// (remove) Token: 0x060007A2 RID: 1954 RVA: 0x0001FA68 File Offset: 0x0001DC68
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060007A3 RID: 1955 RVA: 0x0001FAA0 File Offset: 0x0001DCA0
		protected virtual void Dispose(bool disposing)
		{
			if (this._conditions != null)
			{
				this._conditions.CollectionItemChanged -= this.Conditions_CollectionItemChanged;
				this._conditions.CollectionChanged -= this.Conditions_CollectionChanged;
				this._conditions.PropertyChanged -= this.Conditions_PropertyChanged;
				this._conditions.Dispose();
				this._conditions.Parent = null;
				this._conditions = null;
			}
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0001FB18 File Offset: 0x0001DD18
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0001FB27 File Offset: 0x0001DD27
		private void Conditions_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.OnPropertyChanged("Conditions");
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0001FB34 File Offset: 0x0001DD34
		private void Conditions_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.OnPropertyChanged("ConditionsChanged");
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0001FB41 File Offset: 0x0001DD41
		private void Conditions_CollectionItemChanged(object sender, global::System.EventArgs e)
		{
			this.OnPropertyChanged("ConditionsItemChanged");
		}

		// Token: 0x040001DE RID: 478
		private global::Infragistics.ConditionCollection _conditions;

		// Token: 0x040001DF RID: 479
		private global::System.Type _objectType;

		// Token: 0x040001E0 RID: 480
		private global::Infragistics.Controls.Grids.Column _column;
	}
}
