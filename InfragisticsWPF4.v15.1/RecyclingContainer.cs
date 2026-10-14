using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics
{
	// Token: 0x02000084 RID: 132
	public abstract class RecyclingContainer<T> : global::Infragistics.ISupportRecycling, global::System.ComponentModel.INotifyPropertyChanged where T : global::System.Windows.FrameworkElement
	{
		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x00014688 File Offset: 0x00012888
		protected virtual global::System.Type RecyclingElementType
		{
			get
			{
				return global::Infragistics.RecyclingContainer<T>._recyclingElementType;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x0001468F File Offset: 0x0001288F
		protected virtual string RecyclingIdentifier
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x00014692 File Offset: 0x00012892
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x0001469A File Offset: 0x0001289A
		protected internal virtual bool IsDirty { get; set; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x000146A3 File Offset: 0x000128A3
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x000146AB File Offset: 0x000128AB
		protected global::System.Windows.FrameworkElement AttachedElement { get; set; }

		// Token: 0x06000532 RID: 1330
		protected abstract T CreateInstanceOfRecyclingElement();

		// Token: 0x06000533 RID: 1331 RVA: 0x000146B4 File Offset: 0x000128B4
		protected virtual void OnElementAttached(T element)
		{
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x000146B6 File Offset: 0x000128B6
		protected virtual void OnElementReleased(T element)
		{
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x000146B8 File Offset: 0x000128B8
		protected virtual bool OnElementReleasing(T element)
		{
			return true;
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x000146BB File Offset: 0x000128BB
		global::System.Type global::Infragistics.ISupportRecycling.RecyclingElementType
		{
			get
			{
				return this.RecyclingElementType;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x000146C3 File Offset: 0x000128C3
		string global::Infragistics.ISupportRecycling.RecyclingIdentifier
		{
			get
			{
				return this.RecyclingIdentifier;
			}
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x000146CB File Offset: 0x000128CB
		global::System.Windows.FrameworkElement global::Infragistics.ISupportRecycling.CreateInstanceOfRecyclingElement()
		{
			return this.CreateInstanceOfRecyclingElement();
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x000146D8 File Offset: 0x000128D8
		void global::Infragistics.ISupportRecycling.OnElementAttached(global::System.Windows.FrameworkElement elem)
		{
			this.OnElementAttached(elem as T);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x000146EB File Offset: 0x000128EB
		bool global::Infragistics.ISupportRecycling.OnElementReleasing(global::System.Windows.FrameworkElement elem)
		{
			return this.OnElementReleasing(elem as T);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x000146FE File Offset: 0x000128FE
		void global::Infragistics.ISupportRecycling.OnElementReleased(global::System.Windows.FrameworkElement elem)
		{
			this.OnElementReleased(elem as T);
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x00014711 File Offset: 0x00012911
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x00014719 File Offset: 0x00012919
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

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x00014722 File Offset: 0x00012922
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x0001472A File Offset: 0x0001292A
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

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000540 RID: 1344 RVA: 0x00014734 File Offset: 0x00012934
		// (remove) Token: 0x06000541 RID: 1345 RVA: 0x0001476C File Offset: 0x0001296C
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000542 RID: 1346 RVA: 0x000147A1 File Offset: 0x000129A1
		protected virtual void OnPropertyChanged(string name)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
			}
		}

		// Token: 0x040001E5 RID: 485
		private static global::System.Type _recyclingElementType = typeof(T);
	}
}
