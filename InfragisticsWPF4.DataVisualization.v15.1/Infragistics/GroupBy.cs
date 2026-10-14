using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace Infragistics
{
	// Token: 0x02000047 RID: 71
	public class GroupBy : global::System.Windows.DependencyObject, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged
	{
		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x0000FA7C File Offset: 0x0000DC7C
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x0000FA8E File Offset: 0x0000DC8E
		public global::System.Collections.IEnumerable ItemsSource
		{
			get
			{
				return (global::System.Collections.IEnumerable)base.GetValue(global::Infragistics.GroupBy.ItemsSourceProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.GroupBy.ItemsSourceProperty, value);
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0000FA9C File Offset: 0x0000DC9C
		// (set) Token: 0x060003DB RID: 987 RVA: 0x0000FAAE File Offset: 0x0000DCAE
		public string KeyMemberPath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.GroupBy.KeyMemberPathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.GroupBy.KeyMemberPathProperty, value);
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060003DC RID: 988 RVA: 0x0000FABC File Offset: 0x0000DCBC
		// (set) Token: 0x060003DD RID: 989 RVA: 0x0000FACE File Offset: 0x0000DCCE
		public string ValueMemberPath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.GroupBy.ValueMemberPathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.GroupBy.ValueMemberPathProperty, value);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060003DE RID: 990 RVA: 0x0000FADC File Offset: 0x0000DCDC
		// (set) Token: 0x060003DF RID: 991 RVA: 0x0000FAEE File Offset: 0x0000DCEE
		public string GroupMemberPath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.GroupBy.GroupMemberPathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.GroupBy.GroupMemberPathProperty, value);
			}
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000FAFC File Offset: 0x0000DCFC
		private void OnPropertyChanged(string propertyName, object oldValue, object newValue)
		{
			this.RefreshOutput();
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x0000FB04 File Offset: 0x0000DD04
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x0000FB0C File Offset: 0x0000DD0C
		internal int NumberOfSeries { get; set; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x0000FB15 File Offset: 0x0000DD15
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x0000FB1D File Offset: 0x0000DD1D
		internal global::System.Collections.Generic.List<string> SeriesKeys
		{
			get
			{
				return this._seriesKeys;
			}
			set
			{
				this._seriesKeys = value;
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000FB26 File Offset: 0x0000DD26
		private void RefreshOutput()
		{
			if (!this.Valid())
			{
				return;
			}
			this.Listen();
			this.RefreshItems();
			this.RaiseCollectionChanged();
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0000FB80 File Offset: 0x0000DD80
		private void RefreshItems()
		{
			this._frh.PropertyName = this.GroupMemberPath;
			this._output.Clear();
			global::System.Collections.Generic.List<global::Infragistics.GroupBy.Group> list = (from item in this.ItemsSource.OfType<object>()
			group item by this._frh.GetPropertyValue(item) into gr
			select new global::Infragistics.GroupBy.Group
			{
				Key = gr.Key,
				Items = gr.ToList<object>()
			}).ToList<global::Infragistics.GroupBy.Group>();
			this._frh.PropertyName = this.KeyMemberPath;
			global::Infragistics.GroupingProxyHelper.CreateObject objectCreator = this.GetObjectCreator(list);
			global::System.Collections.Generic.Dictionary<string, bool> dictionary = new global::System.Collections.Generic.Dictionary<string, bool>();
			this.SeriesKeys.Clear();
			foreach (global::Infragistics.GroupBy.Group group in list)
			{
				global::Infragistics.GroupingBase groupingBase = objectCreator();
				groupingBase.Key = group.Key;
				foreach (object obj in group.Items)
				{
					object propertyValue = this._frh.GetPropertyValue(obj);
					string text = "Unkeyed";
					if (propertyValue != null)
					{
						text = this.Sanitize(propertyValue.ToString());
					}
					groupingBase.SetObjectForKey(text, obj);
					if (!dictionary.ContainsKey(text))
					{
						dictionary.Add(text, true);
						this.SeriesKeys.Add(text);
					}
				}
				this._output.Add(groupingBase);
			}
			this.NumberOfSeries = this.SeriesKeys.Count;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0000FD24 File Offset: 0x0000DF24
		private global::Infragistics.GroupingProxyHelper.CreateObject GetObjectCreator(global::System.Collections.Generic.List<global::Infragistics.GroupBy.Group> groups)
		{
			global::System.Collections.Generic.List<global::Infragistics.ConcretePropertyInfo> properties = this.GetProperties(groups);
			if (global::Infragistics.GroupingProxyHelper.DistinctKeysTypes(properties) == null)
			{
				return null;
			}
			global::Infragistics.GroupingProxyHelper.CreateObject result;
			try
			{
				result = global::Infragistics.GroupingProxyHelper.CreateObjectCreator(properties);
			}
			catch (global::System.MissingMethodException)
			{
				result = (() => new global::Infragistics.GroupingBase());
			}
			return result;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00010180 File Offset: 0x0000E380
		private global::System.Collections.Generic.List<global::Infragistics.ConcretePropertyInfo> GetProperties(global::System.Collections.Generic.List<global::Infragistics.GroupBy.Group> groups)
		{
			var source = from g in groups
			from item in g.Items
			group item by this._frh.GetPropertyValue(item) into gr
			select new
			{
				Key = gr.Key,
				Types = from item in gr
				group item by item.GetType() into subGr
				select subGr.Key
			};
			var enumerable = from kt in source
			from t in kt.Types
			select new
			{
				Key = kt.Key,
				Type = t
			};
			global::System.Collections.Generic.List<global::Infragistics.ConcretePropertyInfo> list = new global::System.Collections.Generic.List<global::Infragistics.ConcretePropertyInfo>();
			foreach (var <>f__AnonymousType in enumerable)
			{
				object key = <>f__AnonymousType.Key;
				string text = "Unkeyed";
				if (key != null)
				{
					text = this.Sanitize(key.ToString());
				}
				global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> enumerable2 = from p in <>f__AnonymousType.Type.GetProperties(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.FlattenHierarchy)
				select p;
				foreach (global::System.Reflection.PropertyInfo propertyInfo in enumerable2)
				{
					list.Add(new global::Infragistics.ConcretePropertyInfo
					{
						SourceType = <>f__AnonymousType.Type,
						Key = text,
						Name = propertyInfo.Name,
						PropertyType = propertyInfo.PropertyType,
						PropertyName = text + "_" + propertyInfo.Name
					});
				}
			}
			return list;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0001038C File Offset: 0x0000E58C
		private string Sanitize(string key)
		{
			return key.Replace(".", "__dot__");
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x000103A0 File Offset: 0x0000E5A0
		private void Listen()
		{
			if (this._source != null)
			{
				this._source.CollectionChanged -= this.Source_CollectionChanged;
			}
			this._source = (this.ItemsSource as global::System.Collections.Specialized.INotifyCollectionChanged);
			if (this._source != null)
			{
				this._source.CollectionChanged += this.Source_CollectionChanged;
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000103FC File Offset: 0x0000E5FC
		private void Source_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.RefreshOutput();
			this.RaiseCollectionChanged();
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0001040A File Offset: 0x0000E60A
		private bool Valid()
		{
			return this.ItemsSource != null && this.GroupMemberPath != null && this.KeyMemberPath != null;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0001042A File Offset: 0x0000E62A
		private void RaiseCollectionChanged()
		{
			if (this.CollectionChanged != null)
			{
				this.CollectionChanged(this, new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060003EE RID: 1006 RVA: 0x00010448 File Offset: 0x0000E648
		// (remove) Token: 0x060003EF RID: 1007 RVA: 0x00010480 File Offset: 0x0000E680
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;

		// Token: 0x060003F0 RID: 1008 RVA: 0x000104B5 File Offset: 0x0000E6B5
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			if (this._output == null)
			{
				return new global::System.Collections.Generic.List<object>().GetEnumerator();
			}
			return this._output.GetEnumerator();
		}

		// Token: 0x04000164 RID: 356
		public static readonly global::System.Windows.DependencyProperty ItemsSourceProperty = global::System.Windows.DependencyProperty.Register("ItemsSource", typeof(global::System.Collections.IEnumerable), typeof(global::Infragistics.GroupBy), new global::System.Windows.PropertyMetadata(null, delegate(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			(o as global::Infragistics.GroupBy).OnPropertyChanged("ItemsSource", e.OldValue, e.NewValue);
		}));

		// Token: 0x04000165 RID: 357
		public static readonly global::System.Windows.DependencyProperty KeyMemberPathProperty = global::System.Windows.DependencyProperty.Register("KeyMemberPath", typeof(string), typeof(global::Infragistics.GroupBy), new global::System.Windows.PropertyMetadata(null, delegate(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			(o as global::Infragistics.GroupBy).OnPropertyChanged("KeyMemberPath", e.OldValue, e.NewValue);
		}));

		// Token: 0x04000166 RID: 358
		public static readonly global::System.Windows.DependencyProperty ValueMemberPathProperty = global::System.Windows.DependencyProperty.Register("ValueMemberPath", typeof(string), typeof(global::Infragistics.GroupBy), new global::System.Windows.PropertyMetadata(null, delegate(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			(o as global::Infragistics.GroupBy).OnPropertyChanged("ValueMemberPath", e.OldValue, e.NewValue);
		}));

		// Token: 0x04000167 RID: 359
		public static readonly global::System.Windows.DependencyProperty GroupMemberPathProperty = global::System.Windows.DependencyProperty.Register("GroupMemberPath", typeof(string), typeof(global::Infragistics.GroupBy), new global::System.Windows.PropertyMetadata(null, delegate(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			(o as global::Infragistics.GroupBy).OnPropertyChanged("GroupMemberPath", e.OldValue, e.NewValue);
		}));

		// Token: 0x04000168 RID: 360
		private global::Infragistics.FastReflectionHelper _frh = new global::Infragistics.FastReflectionHelper();

		// Token: 0x04000169 RID: 361
		private global::System.Collections.Specialized.INotifyCollectionChanged _source;

		// Token: 0x0400016A RID: 362
		private global::System.Collections.Generic.List<string> _seriesKeys = new global::System.Collections.Generic.List<string>();

		// Token: 0x0400016C RID: 364
		private global::System.Collections.Generic.List<object> _output = new global::System.Collections.Generic.List<object>();

		// Token: 0x02000048 RID: 72
		private class Group
		{
			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x06000404 RID: 1028 RVA: 0x000106AE File Offset: 0x0000E8AE
			// (set) Token: 0x06000405 RID: 1029 RVA: 0x000106B6 File Offset: 0x0000E8B6
			public object Key { get; set; }

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x06000406 RID: 1030 RVA: 0x000106BF File Offset: 0x0000E8BF
			// (set) Token: 0x06000407 RID: 1031 RVA: 0x000106C7 File Offset: 0x0000E8C7
			public global::System.Collections.Generic.IList<object> Items { get; set; }
		}
	}
}
