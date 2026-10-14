using System;
using System.IO;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Windows;
using System.Windows.Markup;
using System.Xml;

namespace Infragistics
{
	// Token: 0x020000B4 RID: 180
	[global::System.Windows.Markup.ContentProperty("Value")]
	public class SafeSetter : global::System.Windows.Freezable
	{
		// Token: 0x060007C5 RID: 1989 RVA: 0x00024EA8 File Offset: 0x000230A8
		protected override global::System.Windows.Freezable CreateInstanceCore()
		{
			return new global::Infragistics.SafeSetter();
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00024EAF File Offset: 0x000230AF
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x00024EB6 File Offset: 0x000230B6
		internal static bool TestPartialTrust { get; set; }

		// Token: 0x060007C8 RID: 1992 RVA: 0x00024EC0 File Offset: 0x000230C0
		static SafeSetter()
		{
			global::Infragistics.SafeSetter.IsSafe = global::Infragistics.SafeSetter.IsPermissionGranted(new global::System.Security.Permissions.UIPermission(global::System.Security.Permissions.PermissionState.Unrestricted));
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00024F58 File Offset: 0x00023158
		[global::System.Security.SecuritySafeCritical]
		private static bool IsPermissionGranted(global::System.Security.CodeAccessPermission uIPermission)
		{
			bool result;
			try
			{
				uIPermission.Demand();
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x00024F88 File Offset: 0x00023188
		// (set) Token: 0x060007CB RID: 1995 RVA: 0x00024F95 File Offset: 0x00023195
		public object Value
		{
			get
			{
				return base.GetValue(global::Infragistics.SafeSetter.ValueProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.SafeSetter.ValueProperty, value);
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x00024FA3 File Offset: 0x000231A3
		// (set) Token: 0x060007CD RID: 1997 RVA: 0x00024FB5 File Offset: 0x000231B5
		public string ValueAsXamlString
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.SafeSetter.ValueAsXamlStringProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.SafeSetter.ValueAsXamlStringProperty, value);
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x00024FC3 File Offset: 0x000231C3
		// (set) Token: 0x060007CF RID: 1999 RVA: 0x00024FD5 File Offset: 0x000231D5
		public string PropertyName
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.SafeSetter.PropertyNameProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.SafeSetter.PropertyNameProperty, value);
			}
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00024FE4 File Offset: 0x000231E4
		internal void Apply(global::System.Windows.DependencyObject target)
		{
			if (this.PropertyName == null)
			{
				return;
			}
			if (target == null)
			{
				return;
			}
			if (base.CanFreeze)
			{
				base.Freeze();
			}
			if (global::Infragistics.SafeSetter.IsSafe && !global::Infragistics.SafeSetter.TestPartialTrust)
			{
				global::System.Reflection.PropertyInfo property = target.GetType().GetProperty(this.PropertyName);
				if (property == null)
				{
					return;
				}
				property.SetValue(target, this.EffectiveValue(), null);
			}
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00025044 File Offset: 0x00023244
		private object EffectiveValue()
		{
			if (this.ValueAsXamlString != null)
			{
				return this.LoadXamlString(this.ValueAsXamlString);
			}
			return this.Value;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00025064 File Offset: 0x00023264
		private object LoadXamlString(string value)
		{
			object result;
			using (global::System.IO.StringReader stringReader = new global::System.IO.StringReader(value))
			{
				using (global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(stringReader))
				{
					result = global::System.Windows.Markup.XamlReader.Load(xmlReader);
				}
			}
			return result;
		}

		// Token: 0x040002D1 RID: 721
		public static readonly bool IsSafe;

		// Token: 0x040002D2 RID: 722
		public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(object), typeof(global::Infragistics.SafeSetter), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x040002D3 RID: 723
		public static readonly global::System.Windows.DependencyProperty ValueAsXamlStringProperty = global::System.Windows.DependencyProperty.Register("ValueAsXamlString", typeof(string), typeof(global::Infragistics.SafeSetter), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x040002D4 RID: 724
		public static readonly global::System.Windows.DependencyProperty PropertyNameProperty = global::System.Windows.DependencyProperty.Register("PropertyName", typeof(string), typeof(global::Infragistics.SafeSetter), new global::System.Windows.PropertyMetadata(null));
	}
}
