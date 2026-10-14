using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics
{
	// Token: 0x02000094 RID: 148
	[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.DataMapping.Converter))]
	public sealed class DataMapping : global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.DataMappingPair>
	{
		// Token: 0x06000687 RID: 1671 RVA: 0x0001C14B File Offset: 0x0001A34B
		public bool TryAdd(string internalName, string externalName)
		{
			return this.TryAdd(new global::Infragistics.DataMappingPair(internalName, externalName));
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0001C15A File Offset: 0x0001A35A
		public bool TryAdd(global::Infragistics.DataMappingPair pair)
		{
			if (pair.InternalName != null && pair.ExternalName != null && !this.InternalToExternal.ContainsKey(pair.InternalName))
			{
				base.Add(pair);
				return true;
			}
			return false;
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0001C189 File Offset: 0x0001A389
		public global::System.Collections.Generic.IEnumerable<string> GetExternalNames()
		{
			return this.ExternalToInternal.Keys;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0001C198 File Offset: 0x0001A398
		public string GetExternalName(string internalName)
		{
			string result = null;
			this.InternalToExternal.TryGetValue(internalName, out result);
			return result;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0001C1B7 File Offset: 0x0001A3B7
		public global::System.Collections.Generic.IEnumerable<string> GetInternalNames()
		{
			return this.InternalToExternal.Keys;
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0001C1C4 File Offset: 0x0001A3C4
		public global::System.Collections.Generic.IEnumerable<string> GetInternalNames(string externalName)
		{
			global::System.Collections.Generic.IList<string> result = null;
			this.ExternalToInternal.TryGetValue(externalName, out result);
			return result;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0001C1E3 File Offset: 0x0001A3E3
		protected override void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.internalToExternal = null;
			this.externalToInternal = null;
			base.OnCollectionChanged(e);
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x0001C1FC File Offset: 0x0001A3FC
		private global::System.Collections.Generic.Dictionary<string, string> InternalToExternal
		{
			get
			{
				if (this.internalToExternal == null)
				{
					this.internalToExternal = new global::System.Collections.Generic.Dictionary<string, string>();
					foreach (global::Infragistics.DataMappingPair dataMappingPair in this)
					{
						this.internalToExternal[dataMappingPair.InternalName] = dataMappingPair.ExternalName;
					}
				}
				return this.internalToExternal;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x0001C270 File Offset: 0x0001A470
		private global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> ExternalToInternal
		{
			get
			{
				global::System.Collections.Generic.IList<string> list = null;
				if (this.externalToInternal == null)
				{
					this.externalToInternal = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>();
					foreach (global::Infragistics.DataMappingPair dataMappingPair in this)
					{
						if (!this.externalToInternal.TryGetValue(dataMappingPair.ExternalName, out list))
						{
							list = new global::System.Collections.Generic.List<string>();
							this.externalToInternal[dataMappingPair.ExternalName] = list;
						}
						list.Add(dataMappingPair.InternalName);
					}
				}
				return this.externalToInternal;
			}
		}

		// Token: 0x04000288 RID: 648
		private global::System.Collections.Generic.Dictionary<string, string> internalToExternal;

		// Token: 0x04000289 RID: 649
		private global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> externalToInternal;

		// Token: 0x02000095 RID: 149
		public class Converter : global::System.ComponentModel.TypeConverter
		{
			// Token: 0x06000691 RID: 1681 RVA: 0x0001C310 File Offset: 0x0001A510
			public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
			{
				return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
			}

			// Token: 0x06000692 RID: 1682 RVA: 0x0001C330 File Offset: 0x0001A530
			public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
			{
				string text = value as string;
				if (text != null)
				{
					global::Infragistics.DataMapping dataMapping = new global::Infragistics.DataMapping();
					foreach (string text2 in text.Split(new char[]
					{
						';'
					}))
					{
						string[] array2 = text2.Split(new char[]
						{
							'='
						});
						if (array2.Length == 2)
						{
							array2[0] = array2[0].Trim();
							array2[1] = array2[1].Trim();
							if (string.IsNullOrEmpty(array2[1]))
							{
								throw new global::System.InvalidOperationException("Cannot map from empty external name");
							}
							foreach (string text3 in array2[0].Split(new char[]
							{
								','
							}))
							{
								string text4 = text3.Trim();
								if (text4.Equals(""))
								{
									throw new global::System.InvalidOperationException("Cannot map to an empty external name: " + text2);
								}
								dataMapping.Add(new global::Infragistics.DataMappingPair(text4, array2[1]));
							}
						}
					}
					return dataMapping;
				}
				return base.ConvertFrom(context, culture, value);
			}

			// Token: 0x06000693 RID: 1683 RVA: 0x0001C449 File Offset: 0x0001A649
			public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
			{
				return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
			}

			// Token: 0x06000694 RID: 1684 RVA: 0x0001C468 File Offset: 0x0001A668
			public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
			{
				if (destinationType == typeof(string))
				{
					string text = "";
					global::Infragistics.DataMapping dataMapping = value as global::Infragistics.DataMapping;
					if (dataMapping != null)
					{
						foreach (global::Infragistics.DataMappingPair dataMappingPair in dataMapping)
						{
							string text2 = text;
							text = string.Concat(new string[]
							{
								text2,
								dataMappingPair.InternalName,
								"=",
								dataMappingPair.ExternalName,
								"; "
							});
						}
					}
					return text;
				}
				return base.ConvertTo(context, culture, value, destinationType);
			}
		}
	}
}
