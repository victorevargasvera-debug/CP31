using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics
{
	// Token: 0x0200006D RID: 109
	public abstract class RecyclingContainer<T> : global::Infragistics.ISupportRecycling, global::System.ComponentModel.INotifyPropertyChanged where T : global::System.Windows.FrameworkElement
	{
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00011E70 File Offset: 0x00010070
		protected virtual global::System.Type RecyclingElementType
		{
			get
			{
				return global::Infragistics.RecyclingContainer<T>._recyclingElementType;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00011E77 File Offset: 0x00010077
		protected virtual string RecyclingIdentifier
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00011E7A File Offset: 0x0001007A
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x00011E82 File Offset: 0x00010082
		protected internal virtual bool IsDirty { get; set; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00011E8B File Offset: 0x0001008B
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x00011E93 File Offset: 0x00010093
		protected global::System.Windows.FrameworkElement AttachedElement { get; set; }

		// Token: 0x06000471 RID: 1137
		protected abstract T CreateInstanceOfRecyclingElement();

		// Token: 0x06000472 RID: 1138 RVA: 0x00011E9C File Offset: 0x0001009C
		protected virtual void OnElementAttached(T element)
		{
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00011E9E File Offset: 0x0001009E
		protected virtual void OnElementReleased(T element)
		{
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00011EA0 File Offset: 0x000100A0
		protected virtual bool OnElementReleasing(T element)
		{
			return true;
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00011EA3 File Offset: 0x000100A3
		global::System.Type global::Infragistics.ISupportRecycling.RecyclingElementType
		{
			get
			{
				return this.RecyclingElementType;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x00011EAB File Offset: 0x000100AB
		string global::Infragistics.ISupportRecycling.RecyclingIdentifier
		{
			get
			{
				return this.RecyclingIdentifier;
			}
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00011EB3 File Offset: 0x000100B3
		global::System.Windows.FrameworkElement global::Infragistics.ISupportRecycling.CreateInstanceOfRecyclingElement()
		{
			return this.CreateInstanceOfRecyclingElement();
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00011EC0 File Offset: 0x000100C0
		void global::Infragistics.ISupportRecycling.OnElementAttached(global::System.Windows.FrameworkElement elem)
		{
			this.OnElementAttached(elem as T);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00011ED3 File Offset: 0x000100D3
		bool global::Infragistics.ISupportRecycling.OnElementReleasing(global::System.Windows.FrameworkElement elem)
		{
			return this.OnElementReleasing(elem as T);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00011EE6 File Offset: 0x000100E6
		void global::Infragistics.ISupportRecycling.OnElementReleased(global::System.Windows.FrameworkElement elem)
		{
			this.OnElementReleased(elem as T);
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00011EF9 File Offset: 0x000100F9
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x00011F01 File Offset: 0x00010101
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

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x00011F0A File Offset: 0x0001010A
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x00011F12 File Offset: 0x00010112
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
		// (add) Token: 0x0600047F RID: 1151 RVA: 0x00011F1C File Offset: 0x0001011C
		// (remove) Token: 0x06000480 RID: 1152 RVA: 0x00011F54 File Offset: 0x00010154
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000481 RID: 1153 RVA: 0x00011F89 File Offset: 0x00010189
		protected virtual void OnPropertyChanged(string name)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
			}
		}

		// Token: 0x04000174 RID: 372
		private static global::System.Type _recyclingElementType = typeof(T);
	}
}
