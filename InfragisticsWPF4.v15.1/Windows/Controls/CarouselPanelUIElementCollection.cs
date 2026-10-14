using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200026F RID: 623
	internal class CarouselPanelUIElementCollection : global::System.Windows.Controls.UIElementCollection
	{
		// Token: 0x06001986 RID: 6534 RVA: 0x000625A4 File Offset: 0x000607A4
		public CarouselPanelUIElementCollection(global::Infragistics.Windows.Controls.XamCarouselPanel carouselPanel, global::System.Windows.UIElement visualParent, global::System.Windows.FrameworkElement logicalParent) : base(visualParent, logicalParent)
		{
			this._carouselPanel = carouselPanel;
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x000625B8 File Offset: 0x000607B8
		public override int Add(global::System.Windows.UIElement element)
		{
			if (this.CarouselPanel.IsInCarouselListBox)
			{
				return base.Add(new global::Infragistics.Windows.Controls.CarouselListBoxItem(this.CarouselPanel)
				{
					Content = element
				});
			}
			int result = base.Add(new global::Infragistics.Windows.Controls.CarouselPanelItem(this.CarouselPanel)
			{
				Content = element
			});
			this.RaiseCollectionChanged();
			return result;
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x0006260F File Offset: 0x0006080F
		public override void Clear()
		{
			base.Clear();
			this.RaiseCollectionChanged();
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x0006261D File Offset: 0x0006081D
		public override global::System.Collections.IEnumerator GetEnumerator()
		{
			return base.GetEnumerator();
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x00062625 File Offset: 0x00060825
		public override void Insert(int index, global::System.Windows.UIElement element)
		{
			base.Insert(index, element);
			this.RaiseCollectionChanged();
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x00062635 File Offset: 0x00060835
		public override void Remove(global::System.Windows.UIElement element)
		{
			base.Remove(element);
			this.RaiseCollectionChanged();
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x00062644 File Offset: 0x00060844
		public override void RemoveAt(int index)
		{
			base.RemoveAt(index);
			this.RaiseCollectionChanged();
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x00062653 File Offset: 0x00060853
		public override void RemoveRange(int index, int count)
		{
			base.RemoveRange(index, count);
			this.RaiseCollectionChanged();
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x0600198E RID: 6542 RVA: 0x00062663 File Offset: 0x00060863
		internal global::Infragistics.Windows.Controls.XamCarouselPanel CarouselPanel
		{
			get
			{
				return this._carouselPanel;
			}
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x0600198F RID: 6543 RVA: 0x0006266C File Offset: 0x0006086C
		// (remove) Token: 0x06001990 RID: 6544 RVA: 0x000626A4 File Offset: 0x000608A4
		internal event global::System.EventHandler<global::System.EventArgs> CollectionChanged;

		// Token: 0x06001991 RID: 6545 RVA: 0x000626D9 File Offset: 0x000608D9
		private void RaiseCollectionChanged()
		{
			if (this.CollectionChanged != null)
			{
				this.CollectionChanged(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x04000CC2 RID: 3266
		private global::Infragistics.Windows.Controls.XamCarouselPanel _carouselPanel;
	}
}
