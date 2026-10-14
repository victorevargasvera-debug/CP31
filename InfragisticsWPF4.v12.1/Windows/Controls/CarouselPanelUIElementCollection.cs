using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200023A RID: 570
	internal class CarouselPanelUIElementCollection : global::System.Windows.Controls.UIElementCollection
	{
		// Token: 0x06001784 RID: 6020 RVA: 0x0005BB2C File Offset: 0x00059D2C
		public CarouselPanelUIElementCollection(global::Infragistics.Windows.Controls.XamCarouselPanel carouselPanel, global::System.Windows.UIElement visualParent, global::System.Windows.FrameworkElement logicalParent) : base(visualParent, logicalParent)
		{
			this._carouselPanel = carouselPanel;
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x0005BB40 File Offset: 0x00059D40
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

		// Token: 0x06001786 RID: 6022 RVA: 0x0005BB97 File Offset: 0x00059D97
		public override void Clear()
		{
			base.Clear();
			this.RaiseCollectionChanged();
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x0005BBA5 File Offset: 0x00059DA5
		public override global::System.Collections.IEnumerator GetEnumerator()
		{
			return base.GetEnumerator();
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x0005BBAD File Offset: 0x00059DAD
		public override void Insert(int index, global::System.Windows.UIElement element)
		{
			base.Insert(index, element);
			this.RaiseCollectionChanged();
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x0005BBBD File Offset: 0x00059DBD
		public override void Remove(global::System.Windows.UIElement element)
		{
			base.Remove(element);
			this.RaiseCollectionChanged();
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x0005BBCC File Offset: 0x00059DCC
		public override void RemoveAt(int index)
		{
			base.RemoveAt(index);
			this.RaiseCollectionChanged();
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x0005BBDB File Offset: 0x00059DDB
		public override void RemoveRange(int index, int count)
		{
			base.RemoveRange(index, count);
			this.RaiseCollectionChanged();
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x0005BBEB File Offset: 0x00059DEB
		internal global::Infragistics.Windows.Controls.XamCarouselPanel CarouselPanel
		{
			get
			{
				return this._carouselPanel;
			}
		}

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x0600178D RID: 6029 RVA: 0x0005BBF4 File Offset: 0x00059DF4
		// (remove) Token: 0x0600178E RID: 6030 RVA: 0x0005BC2C File Offset: 0x00059E2C
		internal event global::System.EventHandler<global::System.EventArgs> CollectionChanged;

		// Token: 0x0600178F RID: 6031 RVA: 0x0005BC61 File Offset: 0x00059E61
		private void RaiseCollectionChanged()
		{
			if (this.CollectionChanged != null)
			{
				this.CollectionChanged(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x04000B5F RID: 2911
		private global::Infragistics.Windows.Controls.XamCarouselPanel _carouselPanel;
	}
}
