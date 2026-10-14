using System;
using System.Windows;

namespace Infragistics
{
	// Token: 0x02000085 RID: 133
	public abstract class DependencyObjectRecyclingContainer<T> : global::Infragistics.DependencyObjectNotifier, global::Infragistics.ISupportRecycling where T : global::System.Windows.FrameworkElement
	{
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x000147D6 File Offset: 0x000129D6
		protected virtual global::System.Type RecyclingElementType
		{
			get
			{
				return global::Infragistics.DependencyObjectRecyclingContainer<T>._recyclingElementType;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x000147DD File Offset: 0x000129DD
		protected virtual string RecyclingIdentifier
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x000147E0 File Offset: 0x000129E0
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x000147E8 File Offset: 0x000129E8
		protected virtual bool IsDirty { get; set; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x000147F1 File Offset: 0x000129F1
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x000147F9 File Offset: 0x000129F9
		protected global::System.Windows.FrameworkElement AttachedElement { get; set; }

		// Token: 0x0600054B RID: 1355
		protected abstract T CreateInstanceOfRecyclingElement();

		// Token: 0x0600054C RID: 1356 RVA: 0x00014802 File Offset: 0x00012A02
		protected virtual void OnElementAttached(T element)
		{
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00014804 File Offset: 0x00012A04
		protected virtual void OnElementReleased(T element)
		{
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00014806 File Offset: 0x00012A06
		protected virtual bool OnElementReleasing(T element)
		{
			return true;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00014809 File Offset: 0x00012A09
		global::System.Type global::Infragistics.ISupportRecycling.RecyclingElementType
		{
			get
			{
				return this.RecyclingElementType;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x00014811 File Offset: 0x00012A11
		string global::Infragistics.ISupportRecycling.RecyclingIdentifier
		{
			get
			{
				return this.RecyclingIdentifier;
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00014819 File Offset: 0x00012A19
		global::System.Windows.FrameworkElement global::Infragistics.ISupportRecycling.CreateInstanceOfRecyclingElement()
		{
			return this.CreateInstanceOfRecyclingElement();
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00014826 File Offset: 0x00012A26
		void global::Infragistics.ISupportRecycling.OnElementAttached(global::System.Windows.FrameworkElement elem)
		{
			this.OnElementAttached(elem as T);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00014839 File Offset: 0x00012A39
		bool global::Infragistics.ISupportRecycling.OnElementReleasing(global::System.Windows.FrameworkElement elem)
		{
			return this.OnElementReleasing(elem as T);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0001484C File Offset: 0x00012A4C
		void global::Infragistics.ISupportRecycling.OnElementReleased(global::System.Windows.FrameworkElement elem)
		{
			this.OnElementReleased(elem as T);
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x0001485F File Offset: 0x00012A5F
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x00014867 File Offset: 0x00012A67
		global::System.Windows.FrameworkElement global::Infragistics.ISupportRecycling.AttachedElement
		{
			get
			{
				return this.AttachedElement;
			}
			set
			{
				this.AttachedElement = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x00014870 File Offset: 0x00012A70
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x00014878 File Offset: 0x00012A78
		bool global::Infragistics.ISupportRecycling.IsDirty
		{
			get
			{
				return this.IsDirty;
			}
			set
			{
				this.IsDirty = value;
			}
		}

		// Token: 0x040001E9 RID: 489
		private static global::System.Type _recyclingElementType = typeof(T);
	}
}
