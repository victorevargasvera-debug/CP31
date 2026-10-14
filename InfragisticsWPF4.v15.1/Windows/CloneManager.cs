using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Markup.Primitives;
using System.Windows.Media;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows
{
	// Token: 0x020000B6 RID: 182
	internal class CloneManager
	{
		// Token: 0x060006EA RID: 1770 RVA: 0x0001995C File Offset: 0x00017B5C
		public object Clone(object source)
		{
			global::System.Windows.Markup.Primitives.MarkupObject markupObjectFor = global::System.Windows.Markup.Primitives.MarkupWriter.GetMarkupObjectFor(source);
			global::Infragistics.Windows.CloneInfo cloneInfo = new global::Infragistics.Windows.CloneInfo(source);
			return this.Clone(markupObjectFor, cloneInfo);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00019981 File Offset: 0x00017B81
		public virtual bool ShouldClone(object source)
		{
			return true;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00019984 File Offset: 0x00017B84
		protected virtual object Clone(global::System.Windows.Markup.Primitives.MarkupObject mo, global::Infragistics.Windows.CloneInfo cloneInfo)
		{
			object obj = mo.Instance;
			if (obj == null || this.GetCloneBehavior(obj) == global::Infragistics.Windows.Internal.CloneBehavior.ShareInstance)
			{
				return obj;
			}
			if (cloneInfo.TryGetClonedObject(obj, out obj))
			{
				return obj;
			}
			obj = global::System.Activator.CreateInstance(mo.ObjectType);
			object instance = mo.Instance;
			cloneInfo.AddClone(instance, obj);
			foreach (global::System.Windows.Markup.Primitives.MarkupProperty markupProperty in mo.Properties)
			{
				if (markupProperty.DependencyProperty == null || !this.ShouldSkipProperty(markupProperty))
				{
					object obj2 = global::Infragistics.Windows.CloneManager.GetValue(instance, markupProperty);
					bool flag = obj2 is global::System.Windows.Media.Visual || obj2 is global::System.Windows.ContentElement;
					if (obj2 != null && !(obj2 is string))
					{
						global::System.Type type = obj2.GetType();
						if (!type.IsValueType)
						{
							global::Infragistics.Windows.Internal.CloneBehavior? cloneBehavior = null;
							global::System.ComponentModel.PropertyDescriptor propertyDescriptor = markupProperty.PropertyDescriptor;
							if (propertyDescriptor != null)
							{
								foreach (object obj3 in propertyDescriptor.Attributes)
								{
									global::System.Attribute attribute = (global::System.Attribute)obj3;
									global::Infragistics.Windows.Internal.CloneBehaviorAttribute cloneBehaviorAttribute = attribute as global::Infragistics.Windows.Internal.CloneBehaviorAttribute;
									if (cloneBehaviorAttribute != null)
									{
										cloneBehavior = new global::Infragistics.Windows.Internal.CloneBehavior?(cloneBehaviorAttribute.Behavior);
										break;
									}
								}
							}
							if (cloneBehavior != null)
							{
								flag = (cloneBehavior.Value == global::Infragistics.Windows.Internal.CloneBehavior.CloneObject);
							}
						}
					}
					if (flag)
					{
						if (!this.ShouldClone(obj2))
						{
							continue;
						}
						global::System.Windows.Markup.Primitives.MarkupObject markupObjectFor = global::System.Windows.Markup.Primitives.MarkupWriter.GetMarkupObjectFor(obj2);
						obj2 = this.Clone(markupObjectFor, cloneInfo);
					}
					global::System.Windows.Markup.MarkupExtension markupExtension = obj2 as global::System.Windows.Markup.MarkupExtension;
					if (markupExtension != null)
					{
						obj2 = markupExtension.ProvideValue(cloneInfo.ServiceProvider);
					}
					if (markupProperty.DependencyProperty != null)
					{
						((global::System.Windows.DependencyObject)obj).SetValue(markupProperty.DependencyProperty, obj2);
					}
					else if (markupProperty.PropertyDescriptor != null && !markupProperty.PropertyDescriptor.IsReadOnly)
					{
						markupProperty.PropertyDescriptor.SetValue(obj, obj2);
					}
					else if (markupProperty.Items != null && markupProperty.PropertyType != typeof(string))
					{
						this.CloneItems(obj, markupProperty, cloneInfo);
					}
				}
			}
			return obj;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00019BB8 File Offset: 0x00017DB8
		protected virtual void CloneItems(object clone, global::System.Windows.Markup.Primitives.MarkupProperty mp, global::Infragistics.Windows.CloneInfo cloneInfo)
		{
			if (mp.Items == null || mp.PropertyDescriptor == null)
			{
				return;
			}
			object value = mp.PropertyDescriptor.GetValue(clone);
			global::System.Collections.IList list = value as global::System.Collections.IList;
			if (list != null)
			{
				foreach (global::System.Windows.Markup.Primitives.MarkupObject markupObject in mp.Items)
				{
					if (this.ShouldClone(markupObject.Instance))
					{
						object value2 = this.Clone(markupObject, cloneInfo);
						list.Add(value2);
					}
				}
			}
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00019C4C File Offset: 0x00017E4C
		protected virtual global::Infragistics.Windows.Internal.CloneBehavior GetCloneBehavior(object source)
		{
			if (source is global::System.Windows.DependencyObject)
			{
				return global::Infragistics.Windows.Internal.CloneBehavior.CloneObject;
			}
			return global::Infragistics.Windows.Internal.CloneBehavior.ShareInstance;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00019C59 File Offset: 0x00017E59
		protected virtual bool ShouldSkipProperty(global::System.Windows.Markup.Primitives.MarkupProperty property)
		{
			return false;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00019C5C File Offset: 0x00017E5C
		private static object GetValue(object source, global::System.Windows.Markup.Primitives.MarkupProperty mp)
		{
			global::System.Windows.DependencyObject dependencyObject = source as global::System.Windows.DependencyObject;
			if (mp.DependencyProperty != null && dependencyObject != null)
			{
				object obj = dependencyObject.ReadLocalValue(mp.DependencyProperty);
				if (obj is global::System.Enum)
				{
					return obj;
				}
			}
			else if (mp.PropertyDescriptor != null)
			{
				object value = mp.PropertyDescriptor.GetValue(source);
				if (value is global::System.Enum)
				{
					return value;
				}
			}
			return mp.Value;
		}
	}
}
