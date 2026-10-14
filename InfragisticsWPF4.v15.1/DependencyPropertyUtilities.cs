using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;

namespace Infragistics
{
	// Token: 0x0200003B RID: 59
	internal static class DependencyPropertyUtilities
	{
		// Token: 0x0600027D RID: 637 RVA: 0x0000AB40 File Offset: 0x00008D40
		[global::System.Diagnostics.Conditional("TYPECONVERTER_MISSING")]
		internal static void CoerceUsingTypeConverter<T>(ref T value, global::System.Type typeConverterType)
		{
			if (typeof(T) == null)
			{
				throw new global::System.InvalidOperationException();
			}
			if (value != null)
			{
				if (global::Infragistics.DependencyPropertyUtilities._typeConverterCache == null)
				{
					global::Infragistics.DependencyPropertyUtilities._typeConverterCache = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.ComponentModel.TypeConverter>();
				}
				global::System.ComponentModel.TypeConverter typeConverter;
				if (!global::Infragistics.DependencyPropertyUtilities._typeConverterCache.TryGetValue(typeConverterType, out typeConverter))
				{
					try
					{
						typeConverter = (global::System.ComponentModel.TypeConverter)global::System.Activator.CreateInstance(typeConverterType);
					}
					catch
					{
					}
					global::Infragistics.DependencyPropertyUtilities._typeConverterCache[typeConverterType] = typeConverter;
				}
				if (typeConverter != null && typeConverter.CanConvertFrom(value.GetType()))
				{
					value = (T)((object)typeConverter.ConvertFrom(value));
				}
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000ABEC File Offset: 0x00008DEC
		internal static global::System.Windows.PropertyMetadata CreateMetadata(object defaultValue)
		{
			return global::Infragistics.DependencyPropertyUtilities.CreateMetadata(defaultValue, null);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000ABF5 File Offset: 0x00008DF5
		internal static global::System.Windows.PropertyMetadata CreateMetadata(global::System.Windows.PropertyChangedCallback propertyChangeCallback)
		{
			return global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.DependencyPropertyUtilities.MissingValue, propertyChangeCallback);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000AC02 File Offset: 0x00008E02
		internal static global::System.Windows.PropertyMetadata CreateMetadata(object defaultValue, global::System.Windows.PropertyChangedCallback propertyChangeCallback)
		{
			return global::Infragistics.DependencyPropertyUtilities.CreateMetadata(defaultValue, propertyChangeCallback, global::Infragistics.DependencyPropertyUtilities.MetadataOptionFlags.None);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000AC0C File Offset: 0x00008E0C
		internal static global::System.Windows.PropertyMetadata CreateMetadata(object defaultValue, global::System.Windows.PropertyChangedCallback propertyChangeCallback, global::Infragistics.DependencyPropertyUtilities.MetadataOptionFlags flags)
		{
			global::System.Windows.FrameworkPropertyMetadataOptions frameworkPropertyMetadataOptions = global::System.Windows.FrameworkPropertyMetadataOptions.None;
			if (flags != global::Infragistics.DependencyPropertyUtilities.MetadataOptionFlags.None)
			{
				if ((flags & global::Infragistics.DependencyPropertyUtilities.MetadataOptionFlags.BindsTwoWayByDefault) == global::Infragistics.DependencyPropertyUtilities.MetadataOptionFlags.BindsTwoWayByDefault)
				{
					frameworkPropertyMetadataOptions |= global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault;
				}
				if ((flags & global::Infragistics.DependencyPropertyUtilities.MetadataOptionFlags.Journal) == global::Infragistics.DependencyPropertyUtilities.MetadataOptionFlags.Journal)
				{
					frameworkPropertyMetadataOptions |= global::System.Windows.FrameworkPropertyMetadataOptions.Journal;
				}
			}
			if (defaultValue != global::Infragistics.DependencyPropertyUtilities.MissingValue)
			{
				return new global::System.Windows.FrameworkPropertyMetadata(defaultValue, frameworkPropertyMetadataOptions, propertyChangeCallback);
			}
			if (frameworkPropertyMetadataOptions == global::System.Windows.FrameworkPropertyMetadataOptions.None)
			{
				return new global::System.Windows.FrameworkPropertyMetadata(propertyChangeCallback);
			}
			return new global::System.Windows.FrameworkPropertyMetadata(null, frameworkPropertyMetadataOptions, propertyChangeCallback);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000AC60 File Offset: 0x00008E60
		internal static global::System.Windows.PropertyChangedCallback CreateTypeConverterCallbackWrapper<T>(global::System.Windows.PropertyChangedCallback callback)
		{
			return callback;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000AC70 File Offset: 0x00008E70
		public static object GetDefaultValue(global::System.Windows.DependencyObject d, global::System.Windows.DependencyProperty dp)
		{
			if (d != null)
			{
				return global::Infragistics.DependencyPropertyUtilities.GetDefaultValue(d.GetType(), dp);
			}
			return null;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000AC84 File Offset: 0x00008E84
		public static object GetDefaultValue(global::System.Type type, global::System.Windows.DependencyProperty dp)
		{
			global::System.Windows.PropertyMetadata propertyMetadata = dp.GetMetadata(type);
			if (propertyMetadata == null)
			{
				propertyMetadata = dp.DefaultMetadata;
			}
			object obj = (propertyMetadata != null) ? propertyMetadata.DefaultValue : null;
			if (global::System.Windows.DependencyProperty.UnsetValue == obj)
			{
				obj = null;
			}
			return obj;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000ACBB File Offset: 0x00008EBB
		internal static string GetName(global::System.Windows.DependencyProperty dp)
		{
			return dp.Name;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000ACC3 File Offset: 0x00008EC3
		internal static string GetName(global::System.Windows.DependencyObject d, global::System.Windows.DependencyProperty dp)
		{
			return dp.Name;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000ACCB File Offset: 0x00008ECB
		internal static global::System.Type GetType(global::System.Windows.DependencyProperty dp)
		{
			return dp.PropertyType;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000ACD4 File Offset: 0x00008ED4
		internal static global::System.Windows.DependencyProperty Register(string name, global::System.Type propertyType, global::System.Type ownerType, object defaultValue, global::System.Windows.PropertyChangedCallback propertyChangeCallback)
		{
			global::System.Windows.PropertyMetadata metadata = (propertyChangeCallback != null) ? global::Infragistics.DependencyPropertyUtilities.CreateMetadata(defaultValue, propertyChangeCallback) : global::Infragistics.DependencyPropertyUtilities.CreateMetadata(defaultValue);
			return global::Infragistics.DependencyPropertyUtilities.Register(name, propertyType, ownerType, metadata, false);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000AD00 File Offset: 0x00008F00
		internal static global::System.Windows.DependencyProperty Register(string name, global::System.Type propertyType, global::System.Type ownerType, global::System.Windows.PropertyMetadata metadata)
		{
			return global::Infragistics.DependencyPropertyUtilities.Register(name, propertyType, ownerType, metadata, false);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000AD0C File Offset: 0x00008F0C
		private static global::System.Windows.DependencyProperty Register(string name, global::System.Type propertyType, global::System.Type ownerType, global::System.Windows.PropertyMetadata metadata, bool isAttached)
		{
			return isAttached ? global::System.Windows.DependencyProperty.RegisterAttached(name, propertyType, ownerType, metadata) : global::System.Windows.DependencyProperty.Register(name, propertyType, ownerType, metadata);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000AD33 File Offset: 0x00008F33
		internal static global::System.Windows.DependencyProperty RegisterAttached(string name, global::System.Type propertyType, global::System.Type ownerType, global::System.Windows.PropertyMetadata metadata)
		{
			return global::Infragistics.DependencyPropertyUtilities.Register(name, propertyType, ownerType, metadata, true);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000AD3F File Offset: 0x00008F3F
		internal static global::System.Windows.DependencyPropertyKey RegisterAttachedReadOnly(string name, global::System.Type propertyType, global::System.Type ownerType, object defaultValue, global::System.Windows.PropertyChangedCallback changeCallback)
		{
			return global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly(name, propertyType, ownerType, defaultValue, changeCallback, true);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000AD4D File Offset: 0x00008F4D
		internal static global::System.Windows.DependencyPropertyKey RegisterReadOnly(string name, global::System.Type propertyType, global::System.Type ownerType, object defaultValue, global::System.Windows.PropertyChangedCallback changeCallback)
		{
			return global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly(name, propertyType, ownerType, defaultValue, changeCallback, false);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000AD5C File Offset: 0x00008F5C
		internal static global::System.Windows.DependencyPropertyKey RegisterReadOnly(string name, global::System.Type propertyType, global::System.Type ownerType, object defaultValue, global::System.Windows.PropertyChangedCallback changeCallback, bool isAttached)
		{
			global::System.Windows.PropertyMetadata propertyMetadata = global::Infragistics.DependencyPropertyUtilities.CreateMetadata(defaultValue, changeCallback);
			return isAttached ? global::System.Windows.DependencyProperty.RegisterAttachedReadOnly(name, propertyType, ownerType, propertyMetadata) : global::System.Windows.DependencyProperty.RegisterReadOnly(name, propertyType, ownerType, propertyMetadata);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000AD8C File Offset: 0x00008F8C
		internal static void SetCurrentValue(global::System.Windows.DependencyObject d, global::System.Windows.DependencyProperty property, object newValue)
		{
			d.SetCurrentValue(property, newValue);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000AD98 File Offset: 0x00008F98
		public static bool ShouldSerialize(global::System.Windows.DependencyObject d, global::System.Windows.DependencyProperty dp)
		{
			object defaultValue = global::Infragistics.DependencyPropertyUtilities.GetDefaultValue(d, dp);
			object value = d.GetValue(dp);
			return !object.Equals(defaultValue, value);
		}

		// Token: 0x040000C0 RID: 192
		private static readonly object MissingValue = global::System.Windows.DependencyProperty.UnsetValue;

		// Token: 0x040000C1 RID: 193
		[global::System.ThreadStatic]
		private static global::System.Collections.Generic.Dictionary<global::System.Type, global::System.ComponentModel.TypeConverter> _typeConverterCache;

		// Token: 0x0200003C RID: 60
		[global::System.Flags]
		internal enum MetadataOptionFlags
		{
			// Token: 0x040000C3 RID: 195
			None = 0,
			// Token: 0x040000C4 RID: 196
			BindsTwoWayByDefault = 1,
			// Token: 0x040000C5 RID: 197
			Journal = 2
		}
	}
}
