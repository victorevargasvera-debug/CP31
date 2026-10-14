using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000B5 RID: 181
	public class ColumnSettings : global::Infragistics.DependencyObjectNotifier, global::Infragistics.IProvidePropertyPersistenceSettings
	{
		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x0001B892 File Offset: 0x00019A92
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x0001B89A File Offset: 0x00019A9A
		public virtual global::Infragistics.Controls.Grids.Column Column
		{
			get
			{
				return this._column;
			}
			protected internal set
			{
				if (this._column != value)
				{
					this._column = value;
				}
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x0001B8AC File Offset: 0x00019AAC
		protected virtual global::System.Collections.Generic.List<string> PropertiesToIgnore
		{
			get
			{
				if (this._propertiesThatShouldntBePersisted == null)
				{
					this._propertiesThatShouldntBePersisted = new global::System.Collections.Generic.List<string>
					{
						"Column"
					};
				}
				return this._propertiesThatShouldntBePersisted;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x0001B8DF File Offset: 0x00019ADF
		protected virtual global::System.Collections.Generic.List<string> PriorityProperties
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0001B8E2 File Offset: 0x00019AE2
		protected internal virtual void OnLoadedCatchUp()
		{
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0001B8E4 File Offset: 0x00019AE4
		protected virtual void FinishedLoadingPersistence()
		{
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0001B8E6 File Offset: 0x00019AE6
		protected internal virtual void Reset()
		{
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x0001B8E8 File Offset: 0x00019AE8
		global::System.Collections.Generic.List<string> global::Infragistics.IProvidePropertyPersistenceSettings.PropertiesToIgnore
		{
			get
			{
				return this.PropertiesToIgnore;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x0001B8F0 File Offset: 0x00019AF0
		global::System.Collections.Generic.List<string> global::Infragistics.IProvidePropertyPersistenceSettings.PriorityProperties
		{
			get
			{
				return this.PriorityProperties;
			}
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0001B8F8 File Offset: 0x00019AF8
		void global::Infragistics.IProvidePropertyPersistenceSettings.FinishedLoadingPersistence()
		{
			this.FinishedLoadingPersistence();
		}

		// Token: 0x0400017E RID: 382
		private global::Infragistics.Controls.Grids.Column _column;

		// Token: 0x0400017F RID: 383
		private global::System.Collections.Generic.List<string> _propertiesThatShouldntBePersisted;
	}
}
