using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200025B RID: 603
	public class ImageColumnContentProvider : global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase
	{
		// Token: 0x06001354 RID: 4948 RVA: 0x000489E0 File Offset: 0x00046BE0
		public ImageColumnContentProvider()
		{
			this._image = new global::System.Windows.Controls.Image();
			this._imageHolder = new global::System.Windows.Controls.ContentControl
			{
				Content = this._image
			};
			this._imageHolder.Loaded += this.ImageHolder_Loaded;
			this._imageHolder.Unloaded += this.ImageHolder_Unloaded;
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x00048A45 File Offset: 0x00046C45
		public override global::System.Windows.FrameworkElement ResolveDisplayElement(global::Infragistics.Controls.Grids.Cell cell, global::System.Windows.Data.Binding cellBinding)
		{
			this.SetUpImageDimensions(cell);
			this.ApplyBindingToDisplayElement(cell, cellBinding);
			return this._imageHolder;
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x00048A5C File Offset: 0x00046C5C
		private void ApplyBindingToDisplayElement(global::Infragistics.Controls.Grids.Cell cell, global::System.Windows.Data.Binding binding)
		{
			if (binding != null)
			{
				this._image.SetBinding(global::System.Windows.Controls.Image.SourceProperty, binding);
			}
			this.SetUpImageDimensions(cell);
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x00048A7A File Offset: 0x00046C7A
		public override void AdjustDisplayElement(global::Infragistics.Controls.Grids.Cell cell)
		{
			this.SetUpImageDimensions(cell);
			this._image.Measure(new global::System.Windows.Size(1.0, 1.0));
			this._image.InvalidateMeasure();
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x00048AB0 File Offset: 0x00046CB0
		protected override global::System.Windows.FrameworkElement ResolveEditorControl(global::Infragistics.Controls.Grids.Cell cell, object editorValue, double availableWidth, double availableHeight, global::System.Windows.Data.Binding editorBinding)
		{
			return null;
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x00048AB3 File Offset: 0x00046CB3
		public override object ResolveValueFromEditor(global::Infragistics.Controls.Grids.Cell cell)
		{
			return null;
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x00048AB8 File Offset: 0x00046CB8
		public override global::System.Windows.FrameworkElement GenerateGroupByCellContent(global::Infragistics.Controls.Grids.Primitives.GroupByCell cell, global::System.Windows.Data.Binding cellBinding)
		{
			global::Infragistics.Controls.Grids.ImageColumn imageColumn = (global::Infragistics.Controls.Grids.ImageColumn)cell.ResolveColumn;
			if (imageColumn.Key != null)
			{
				this._image.DataContext = cell.Row.Data;
				if (cellBinding != null)
				{
					this._image.SetBinding(global::System.Windows.Controls.Image.SourceProperty, cellBinding);
				}
				global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase.SetControlStyle(this._image, imageColumn.ImageStyle);
				if (imageColumn.ImageHeight != 0.0)
				{
					this._image.Height = imageColumn.ImageHeight;
				}
				if (imageColumn.ImageWidth != 0.0)
				{
					this._image.Width = imageColumn.ImageWidth;
				}
			}
			return this._imageHolder;
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x00048B62 File Offset: 0x00046D62
		public override void ResetContent()
		{
			if (this._image != null)
			{
				this._image.Measure(new global::System.Windows.Size(1.0, 1.0));
			}
			base.ResetContent();
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x00048B94 File Offset: 0x00046D94
		private void SetUpImageDimensions(global::Infragistics.Controls.Grids.Cell cell)
		{
			global::Infragistics.Controls.Grids.ImageColumn imageColumn = (global::Infragistics.Controls.Grids.ImageColumn)cell.Column;
			if (imageColumn.Key != null)
			{
				global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase.SetControlStyle(this._image, imageColumn.ImageStyle);
				double num = imageColumn.ImageHeight;
				if (num != 0.0 && (this._image.Height != num || (this._image.Height == num && !this._heightSet)))
				{
					this._image.Height = num;
					cell.Row.ActualHeight = 0.0;
					this._heightSet = true;
				}
				num = imageColumn.ImageWidth;
				if (num != 0.0 || (this._image.Width == num && !this._widthSet))
				{
					this._image.Width = num;
					this._widthSet = true;
				}
			}
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x00048C63 File Offset: 0x00046E63
		private void ImageHolder_Loaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this._imageHolder.Content = this._image;
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x00048C76 File Offset: 0x00046E76
		private void ImageHolder_Unloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this._imageHolder.Content = null;
		}

		// Token: 0x040005F0 RID: 1520
		private readonly global::System.Windows.Controls.Image _image;

		// Token: 0x040005F1 RID: 1521
		private readonly global::System.Windows.Controls.ContentControl _imageHolder;

		// Token: 0x040005F2 RID: 1522
		private bool _heightSet;

		// Token: 0x040005F3 RID: 1523
		private bool _widthSet;
	}
}
