using System;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics.Controls.Maps
{
	// Token: 0x0200005F RID: 95
	public class ArcGISOnlineTileSource : global::Infragistics.Controls.Maps.MapTileSource
	{
		// Token: 0x060005B1 RID: 1457 RVA: 0x00016032 File Offset: 0x00014232
		public ArcGISOnlineTileSource() : base(2097152, 2097152, 256, 256, 0)
		{
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x0001604F File Offset: 0x0001424F
		// (set) Token: 0x060005B3 RID: 1459 RVA: 0x00016061 File Offset: 0x00014261
		public string MapServerUri
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Maps.ArcGISOnlineTileSource.MapServerUriProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Maps.ArcGISOnlineTileSource.MapServerUriProperty, value);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0001606F File Offset: 0x0001426F
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x00016081 File Offset: 0x00014281
		public bool IsMapPublic
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Maps.ArcGISOnlineTileSource.IsMapPublicProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Maps.ArcGISOnlineTileSource.IsMapPublicProperty, value);
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x00016094 File Offset: 0x00014294
		// (set) Token: 0x060005B7 RID: 1463 RVA: 0x000160A6 File Offset: 0x000142A6
		public int LevelOfDetail
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Maps.ArcGISOnlineTileSource.LevelOfDetailProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Maps.ArcGISOnlineTileSource.LevelOfDetailProperty, value);
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x000160B9 File Offset: 0x000142B9
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x000160CB File Offset: 0x000142CB
		public string UserToken
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Maps.ArcGISOnlineTileSource.UserTokenProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Maps.ArcGISOnlineTileSource.UserTokenProperty, value);
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x000160DC File Offset: 0x000142DC
		protected override void GetTileLayers(int tileLevel, int tilePositionX, int tilePositionY, global::System.Collections.Generic.IList<object> tileImageLayerSources)
		{
			string text = this.MapServerUri + "/tile/{0}/{1}/{2}";
			string text2 = "";
			if (string.IsNullOrEmpty(this.MapServerUri) || this.LevelOfDetail < 1 || !global::System.Uri.IsWellFormedUriString(this.MapServerUri, global::System.UriKind.Absolute))
			{
				return;
			}
			if (!this.IsMapPublic)
			{
				if (string.IsNullOrEmpty(this.UserToken))
				{
					return;
				}
				text += "?token={3}";
				text2 = this.UserToken.Trim();
			}
			int num = tileLevel - 8;
			if (num > 0)
			{
				string uriString = string.Format(text, new object[]
				{
					num,
					tilePositionY,
					tilePositionX,
					text2
				});
				tileImageLayerSources.Add(new global::System.Uri(uriString));
			}
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x000161A0 File Offset: 0x000143A0
		private static void OnPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Maps.ArcGISOnlineTileSource arcGISOnlineTileSource = (global::Infragistics.Controls.Maps.ArcGISOnlineTileSource)d;
			if (e.Property == global::Infragistics.Controls.Maps.ArcGISOnlineTileSource.MapServerUriProperty)
			{
				arcGISOnlineTileSource.MapServerUri = (e.NewValue as string);
				arcGISOnlineTileSource.InvalidateTileLayer(0, 0, 0, 0);
			}
			if (e.Property == global::Infragistics.Controls.Maps.ArcGISOnlineTileSource.UserTokenProperty)
			{
				arcGISOnlineTileSource.UserToken = (e.NewValue as string);
				arcGISOnlineTileSource.InvalidateTileLayer(0, 0, 0, 0);
			}
			if (e.Property == global::Infragistics.Controls.Maps.ArcGISOnlineTileSource.LevelOfDetailProperty)
			{
				arcGISOnlineTileSource.ImageWidth = (long)(global::System.Math.Pow(2.0, (double)(arcGISOnlineTileSource.LevelOfDetail - 1)) * 256.0);
				arcGISOnlineTileSource.ImageHeight = (long)(global::System.Math.Pow(2.0, (double)(arcGISOnlineTileSource.LevelOfDetail - 1)) * 256.0);
			}
			if (e.Property == global::Infragistics.Controls.Maps.ArcGISOnlineTileSource.IsMapPublicProperty)
			{
				arcGISOnlineTileSource.InvalidateTileLayer(0, 0, 0, 0);
			}
		}

		// Token: 0x04000252 RID: 594
		public static readonly global::System.Windows.DependencyProperty MapServerUriProperty = global::System.Windows.DependencyProperty.Register("MapServerUri", typeof(string), typeof(global::Infragistics.Controls.Maps.ArcGISOnlineTileSource), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Maps.ArcGISOnlineTileSource.OnPropertyChanged)));

		// Token: 0x04000253 RID: 595
		public static readonly global::System.Windows.DependencyProperty IsMapPublicProperty = global::System.Windows.DependencyProperty.Register("IsMapPublic", typeof(bool), typeof(global::Infragistics.Controls.Maps.ArcGISOnlineTileSource), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Maps.ArcGISOnlineTileSource.OnPropertyChanged)));

		// Token: 0x04000254 RID: 596
		public static readonly global::System.Windows.DependencyProperty LevelOfDetailProperty = global::System.Windows.DependencyProperty.Register("LevelOfDetail", typeof(int), typeof(global::Infragistics.Controls.Maps.ArcGISOnlineTileSource), new global::System.Windows.PropertyMetadata(-1, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Maps.ArcGISOnlineTileSource.OnPropertyChanged)));

		// Token: 0x04000255 RID: 597
		public static readonly global::System.Windows.DependencyProperty UserTokenProperty = global::System.Windows.DependencyProperty.Register("UserToken", typeof(string), typeof(global::Infragistics.Controls.Maps.ArcGISOnlineTileSource), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Maps.ArcGISOnlineTileSource.OnPropertyChanged)));
	}
}
