using System;
using System.Windows;

namespace Infragistics
{
	// Token: 0x0200002C RID: 44
	internal static class DependencyPropertyUtilities
	{
		// Token: 0x06000205 RID: 517 RVA: 0x0000968F File Offset: 0x0000788F
		internal static global::System.Windows.PropertyMetadata CreateMetadata(object defaultValue)
		{
			return global::Infragistics.DependencyPropertyUtilities.CreateMetadata(defaultValue, null);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00009698 File Offset: 0x00007898
		internal static global::System.Windows.PropertyMetadata CreateMetadata(global::System.Windows.PropertyChangedCallback propertyChangeCallback)
		{
			return global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.DependencyPropertyUtilities.MissingValue, propertyChangeCallback);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000096A5 File Offset: 0x000078A5
		internal static global::System.Windows.PropertyMetadata CreateMetadata(object defaultValue, global::System.Windows.PropertyChangedCallback propertyChangeCallback)
		{
			return global::Infragistics.DependencyPropertyUtilities.CreateMetadata(defaultValue, propertyChangeCallback, global::Infragistics.DependencyPropertyUtilities.MetadataOptionFlags.None);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000096B0 File Offset: 0x000078B0
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

		// Token: 0x06000209 RID: 521 RVA: 0x00009701 File Offset: 0x00007901
		public static object GetDefaultValue(global::System.Windows.DependencyObject d, global::System.Windows.DependencyProperty dp)
		{
			if (d != null)
			{
				return global::Infragistics.DependencyPropertyUtilities.GetDefaultValue(d.GetType(), dp);
			}
			return null;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00009714 File Offset: 0x00007914
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

		// Token: 0x0600020B RID: 523 RVA: 0x0000974B File Offset: 0x0000794B
		internal static string GetName(global::System.Windows.DependencyProperty dp)
		{
			return dp.Name;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00009753 File Offset: 0x00007953
		internal static string GetName(global::System.Windows.DependencyObject d, global::System.Windows.DependencyProperty dp)
		{
			return dp.Name;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000975B File Offset: 0x0000795B
		internal static global::System.Type GetType(global::System.Windows.DependencyProperty dp)
		{
			return dp.PropertyType;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00009764 File Offset: 0x00007964
		internal static global::System.Windows.DependencyProperty Register(string name, global::System.Type propertyType, global::System.Type ownerType, object defaultValue, global::System.Windows.PropertyChangedCallback propertyChangeCallback)
		{
			global::System.Windows.PropertyMetadata metadata = (propertyChangeCallback != null) ? global::Infragistics.DependencyPropertyUtilities.CreateMetadata(defaultValue, propertyChangeCallback) : global::Infragistics.DependencyPropertyUtilities.CreateMetadata(defaultValue);
			return global::Infragistics.DependencyPropertyUtilities.Register(name, propertyType, ownerType, metadata, false);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00009790 File Offset: 0x00007990
		internal static global::System.Windows.DependencyProperty Register(string name, global::System.Type propertyType, global::System.Type ownerType, global::System.Windows.PropertyMetadata metadata)
		{
			return global::Infragistics.DependencyPropertyUtilities.Register(name, propertyType, ownerType, metadata, false);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000979C File Offset: 0x0000799C
		private static global::System.Windows.DependencyProperty Register(string name, global::System.Type propertyType, global::System.Type ownerType, global::System.Windows.PropertyMetadata metadata, bool isAttached)
		{
			return isAttached ? global::System.Windows.DependencyProperty.RegisterAttached(name, propertyType, ownerType, metadata) : global::System.Windows.DependencyProperty.Register(name, propertyType, ownerType, metadata);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000097C3 File Offset: 0x000079C3
		internal static global::System.Windows.DependencyProperty RegisterAttached(string name, global::System.Type propertyType, global::System.Type ownerType, global::System.Windows.PropertyMetadata metadata)
		{
			return global::Infragistics.DependencyPropertyUtilities.Register(name, propertyType, ownerType, metadata, true);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000097CF File Offset: 0x000079CF
		internal static global::System.Windows.DependencyPropertyKey RegisterAttachedReadOnly(string name, global::System.Type propertyType, global::System.Type ownerType, object defaultValue, global::System.Windows.PropertyChangedCallback changeCallback)
		{
			return global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly(name, propertyType, ownerType, defaultValue, changeCallback, true);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x000097DD File Offset: 0x000079DD
		internal static global::System.Windows.DependencyPropertyKey RegisterReadOnly(string name, global::System.Type propertyType, global::System.Type ownerType, object defaultValue, global::System.Windows.PropertyChangedCallback changeCallback)
		{
			return global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly(name, propertyType, ownerType, defaultValue, changeCallback, false);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000097EC File Offset: 0x000079EC
		internal static global::System.Windows.DependencyPropertyKey RegisterReadOnly(string name, global::System.Type propertyType, global::System.Type ownerType, object defaultValue, global::System.Windows.PropertyChangedCallback changeCallback, bool isAttached)
		{
			global::System.Windows.PropertyMetadata propertyMetadata = global::Infragistics.DependencyPropertyUtilities.CreateMetadata(defaultValue, changeCallback);
			return isAttached ? global::System.Windows.DependencyProperty.RegisterAttachedReadOnly(name, propertyType, ownerType, propertyMetadata) : global::System.Windows.DependencyProperty.RegisterReadOnly(name, propertyType, ownerType, propertyMetadata);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000981C File Offset: 0x00007A1C
		internal static void SetCurrentValue(global::System.Windows.DependencyObject d, global::System.Windows.DependencyProperty property, object newValue)
		{
			d.SetCurrentValue(property, newValue);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00009828 File Offset: 0x00007A28
		public static bool ShouldSerialize(global::System.Windows.DependencyObject d, global::System.Windows.DependencyProperty dp)
		{
			object defaultValue = global::Infragistics.DependencyPropertyUtilities.GetDefaultValue(d, dp);
			object value = d.GetValue(dp);
			return !object.Equals(defaultValue, value);
		}

		// Token: 0x04000075 RID: 117
		private static readonly object MissingValue = global::System.Windows.DependencyProperty.UnsetValue;

		// Token: 0x0200002D RID: 45
		[global::System.Flags]
		internal enum MetadataOptionFlags
		{
			// Token: 0x04000077 RID: 119
			None = 0,
			// Token: 0x04000078 RID: 120
			BindsTwoWayByDefault = 1,
			// Token: 0x04000079 RID: 121
			Journal = 2
		}
	}
}
