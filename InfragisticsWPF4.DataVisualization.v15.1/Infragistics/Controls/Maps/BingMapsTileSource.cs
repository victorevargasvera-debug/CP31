using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Text;
using System.Threading;
using System.Windows;

namespace Infragistics.Controls.Maps
{
	// Token: 0x02000060 RID: 96
	public sealed class BingMapsTileSource : global::Infragistics.Controls.Maps.MapTileSource
	{
		// Token: 0x060005BD RID: 1469 RVA: 0x0001636B File Offset: 0x0001456B
		public BingMapsTileSource() : base(1073741824, 1073741824, 256, 256, 0)
		{
			this._cultureName = global::System.Threading.Thread.CurrentThread.CurrentCulture.Name;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0001639D File Offset: 0x0001459D
		public BingMapsTileSource(string tilePath, global::System.Collections.ObjectModel.ObservableCollection<string> subDomains) : this()
		{
			this.TilePath = tilePath;
			this.SubDomains = subDomains;
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x000163B3 File Offset: 0x000145B3
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x000163C5 File Offset: 0x000145C5
		public string TilePath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Maps.BingMapsTileSource.TilePathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Maps.BingMapsTileSource.TilePathProperty, value);
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x000163D3 File Offset: 0x000145D3
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x000163E5 File Offset: 0x000145E5
		public global::System.Collections.ObjectModel.ObservableCollection<string> SubDomains
		{
			get
			{
				return (global::System.Collections.ObjectModel.ObservableCollection<string>)base.GetValue(global::Infragistics.Controls.Maps.BingMapsTileSource.SubDomainsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Maps.BingMapsTileSource.SubDomainsProperty, value);
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x000163F3 File Offset: 0x000145F3
		private void subdomains_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x000163F5 File Offset: 0x000145F5
		// (set) Token: 0x060005C5 RID: 1477 RVA: 0x00016407 File Offset: 0x00014607
		public string CultureName
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Maps.BingMapsTileSource.CultureNameProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Maps.BingMapsTileSource.CultureNameProperty, value);
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00016418 File Offset: 0x00014618
		protected override void GetTileLayers(int tileLevel, int tilePositionX, int tilePositionY, global::System.Collections.Generic.IList<object> tileImageLayerSources)
		{
			if (!this.ValidateTileSourceProperties())
			{
				tileImageLayerSources.Clear();
				return;
			}
			if (this.TilePath == null)
			{
				return;
			}
			tileLevel -= 8;
			if (tileLevel > 0)
			{
				string quadKey = this.GetQuadKey(tileLevel, tilePositionX, tilePositionY);
				string text = this.TilePath;
				text = text.Replace("{culture}", this._cultureName);
				text = text.Replace("{quadkey}", quadKey);
				int index = global::System.Convert.ToInt32(quadKey.Substring(quadKey.Length - 1, 1));
				text = text.Replace("{subdomain}", this.SubDomains[index]);
				text = text.Replace("&token={token}", "");
				if (!global::System.Uri.IsWellFormedUriString(text, global::System.UriKind.Absolute))
				{
					return;
				}
				tileImageLayerSources.Add(new global::System.Uri(text));
			}
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x000164D0 File Offset: 0x000146D0
		private bool ValidateTileSourceProperties()
		{
			bool result = true;
			if (base.ReadLocalValue(global::Infragistics.Controls.Maps.BingMapsTileSource.TilePathProperty) == global::System.Windows.DependencyProperty.UnsetValue || string.IsNullOrEmpty(this.TilePath))
			{
				result = false;
			}
			if (base.ReadLocalValue(global::Infragistics.Controls.Maps.BingMapsTileSource.SubDomainsProperty) == global::System.Windows.DependencyProperty.UnsetValue || this.SubDomains == null || this.SubDomains.Count == 0)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0001652C File Offset: 0x0001472C
		private string GetQuadKey(int tileLevel, int tilePositionX, int tilePositionY)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (int i = tileLevel; i > 0; i--)
			{
				char c = '0';
				int num = 1 << i - 1;
				if ((tilePositionX & num) != 0)
				{
					c += '\u0001';
				}
				if ((tilePositionY & num) != 0)
				{
					c += '\u0001';
					c += '\u0001';
				}
				stringBuilder.Append(c);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00016580 File Offset: 0x00014780
		private static void OnPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Maps.BingMapsTileSource bingMapsTileSource = (global::Infragistics.Controls.Maps.BingMapsTileSource)d;
			if (e.Property == global::Infragistics.Controls.Maps.BingMapsTileSource.SubDomainsProperty || (e.Property == global::Infragistics.Controls.Maps.BingMapsTileSource.TilePathProperty | e.Property == global::Infragistics.Controls.Maps.BingMapsTileSource.CultureNameProperty))
			{
				if (e.Property == global::Infragistics.Controls.Maps.BingMapsTileSource.SubDomainsProperty)
				{
					global::System.Collections.ObjectModel.ObservableCollection<string> observableCollection = e.OldValue as global::System.Collections.ObjectModel.ObservableCollection<string>;
					global::System.Collections.ObjectModel.ObservableCollection<string> observableCollection2 = e.NewValue as global::System.Collections.ObjectModel.ObservableCollection<string>;
					if (observableCollection != null)
					{
						observableCollection.CollectionChanged -= bingMapsTileSource.subdomains_CollectionChanged;
					}
					if (observableCollection2 != null)
					{
						observableCollection2.CollectionChanged += bingMapsTileSource.subdomains_CollectionChanged;
					}
				}
				if (e.Property == global::Infragistics.Controls.Maps.BingMapsTileSource.CultureNameProperty)
				{
					bingMapsTileSource._cultureName = (string)e.NewValue;
				}
				bingMapsTileSource.InvalidateTileLayer(0, 0, 0, 0);
			}
		}

		// Token: 0x04000256 RID: 598
		public static readonly global::System.Windows.DependencyProperty TilePathProperty = global::System.Windows.DependencyProperty.Register("TilePath", typeof(string), typeof(global::Infragistics.Controls.Maps.BingMapsTileSource), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Maps.BingMapsTileSource.OnPropertyChanged)));

		// Token: 0x04000257 RID: 599
		public static readonly global::System.Windows.DependencyProperty SubDomainsProperty = global::System.Windows.DependencyProperty.Register("SubDomains", typeof(global::System.Collections.ObjectModel.ObservableCollection<string>), typeof(global::Infragistics.Controls.Maps.BingMapsTileSource), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Maps.BingMapsTileSource.OnPropertyChanged)));

		// Token: 0x04000258 RID: 600
		private string _cultureName;

		// Token: 0x04000259 RID: 601
		public static readonly global::System.Windows.DependencyProperty CultureNameProperty = global::System.Windows.DependencyProperty.Register("CultureName", typeof(string), typeof(global::Infragistics.Controls.Maps.BingMapsTileSource), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Maps.BingMapsTileSource.OnPropertyChanged)));
	}
}
