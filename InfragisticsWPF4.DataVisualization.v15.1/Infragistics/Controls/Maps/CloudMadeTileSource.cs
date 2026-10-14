using System;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics.Controls.Maps
{
	// Token: 0x02000061 RID: 97
	public sealed class CloudMadeTileSource : global::Infragistics.Controls.Maps.MapTileSource
	{
		// Token: 0x060005CB RID: 1483 RVA: 0x000166EC File Offset: 0x000148EC
		public CloudMadeTileSource() : base(134217728, 134217728, 256, 256, 0)
		{
			this._random = new global::System.Random();
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x00016714 File Offset: 0x00014914
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x00016726 File Offset: 0x00014926
		public string Key
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Maps.CloudMadeTileSource.KeyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Maps.CloudMadeTileSource.KeyProperty, value);
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00016734 File Offset: 0x00014934
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x00016746 File Offset: 0x00014946
		public string Parameter
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Maps.CloudMadeTileSource.ParameterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Maps.CloudMadeTileSource.ParameterProperty, value);
			}
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00016754 File Offset: 0x00014954
		protected override void GetTileLayers(int tileLevel, int tilePositionX, int tilePositionY, global::System.Collections.Generic.IList<object> tileImageLayerSources)
		{
			int num = tileLevel - 8;
			if (num > 0)
			{
				string[] array = new string[]
				{
					"a",
					"b",
					"c"
				};
				string text = "http://{S}.tile.cloudmade.com/{K}/{P}/256/{Z}/{X}/{Y}.png";
				text = text.Replace("{S}", array[this._random.Next(array.Length)]);
				text = text.Replace("{K}", (this.Key == null) ? "" : this.Key);
				text = text.Replace("{P}", (this.Parameter == null) ? "" : this.Parameter);
				text = text.Replace("{Z}", num.ToString());
				text = text.Replace("{X}", tilePositionX.ToString());
				text = text.Replace("{Y}", tilePositionY.ToString());
				tileImageLayerSources.Add(new global::System.Uri(text));
			}
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00016838 File Offset: 0x00014A38
		private static void OnPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Maps.CloudMadeTileSource cloudMadeTileSource = (global::Infragistics.Controls.Maps.CloudMadeTileSource)d;
			if (e.Property == global::Infragistics.Controls.Maps.CloudMadeTileSource.ParameterProperty)
			{
				cloudMadeTileSource.InvalidateTileLayer(0, 0, 0, 0);
			}
		}

		// Token: 0x0400025A RID: 602
		private const string TilePathMapnik = "http://{S}.tile.cloudmade.com/{K}/{P}/256/{Z}/{X}/{Y}.png";

		// Token: 0x0400025B RID: 603
		private const string KeyPropertyName = "Key";

		// Token: 0x0400025C RID: 604
		private const string ParameterPropertyName = "Parameter";

		// Token: 0x0400025D RID: 605
		private readonly global::System.Random _random;

		// Token: 0x0400025E RID: 606
		public static readonly global::System.Windows.DependencyProperty KeyProperty = global::System.Windows.DependencyProperty.Register("Key", typeof(string), typeof(global::Infragistics.Controls.Maps.CloudMadeTileSource), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x0400025F RID: 607
		public static readonly global::System.Windows.DependencyProperty ParameterProperty = global::System.Windows.DependencyProperty.Register("Parameter", typeof(string), typeof(global::Infragistics.Controls.Maps.CloudMadeTileSource), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Maps.CloudMadeTileSource.OnPropertyChanged)));
	}
}
