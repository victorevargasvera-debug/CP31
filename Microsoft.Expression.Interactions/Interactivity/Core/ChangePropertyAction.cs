using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Interactivity;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Microsoft.Expression.Interactivity.Core
{
	// Token: 0x02000005 RID: 5
	public class ChangePropertyAction : global::System.Windows.Interactivity.TargetedTriggerAction<object>
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002634 File Offset: 0x00000834
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002646 File Offset: 0x00000846
		public string PropertyName
		{
			get
			{
				return (string)base.GetValue(global::Microsoft.Expression.Interactivity.Core.ChangePropertyAction.PropertyNameProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Core.ChangePropertyAction.PropertyNameProperty, value);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002654 File Offset: 0x00000854
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002661 File Offset: 0x00000861
		public object Value
		{
			get
			{
				return base.GetValue(global::Microsoft.Expression.Interactivity.Core.ChangePropertyAction.ValueProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Core.ChangePropertyAction.ValueProperty, value);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000027 RID: 39 RVA: 0x0000266F File Offset: 0x0000086F
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002681 File Offset: 0x00000881
		public global::System.Windows.Duration Duration
		{
			get
			{
				return (global::System.Windows.Duration)base.GetValue(global::Microsoft.Expression.Interactivity.Core.ChangePropertyAction.DurationProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Core.ChangePropertyAction.DurationProperty, value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002694 File Offset: 0x00000894
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000026A6 File Offset: 0x000008A6
		public bool Increment
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Expression.Interactivity.Core.ChangePropertyAction.IncrementProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Core.ChangePropertyAction.IncrementProperty, value);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000026BC File Offset: 0x000008BC
		protected override void Invoke(object parameter)
		{
			if (base.AssociatedObject == null)
			{
				return;
			}
			if (string.IsNullOrEmpty(this.PropertyName))
			{
				return;
			}
			if (base.Target == null)
			{
				return;
			}
			global::System.Type type = base.Target.GetType();
			global::System.Reflection.PropertyInfo property = type.GetProperty(this.PropertyName);
			this.ValidateProperty(property);
			object obj = this.Value;
			global::System.ComponentModel.TypeConverter typeConverter = global::Microsoft.Expression.Interactivity.TypeConverterHelper.GetTypeConverter(property.PropertyType);
			global::System.Exception ex = null;
			try
			{
				if (this.Value != null)
				{
					if (typeConverter != null && typeConverter.CanConvertFrom(this.Value.GetType()))
					{
						obj = typeConverter.ConvertFrom(this.Value);
					}
					else
					{
						typeConverter = global::Microsoft.Expression.Interactivity.TypeConverterHelper.GetTypeConverter(this.Value.GetType());
						if (typeConverter != null && typeConverter.CanConvertTo(property.PropertyType))
						{
							obj = typeConverter.ConvertTo(this.Value, property.PropertyType);
						}
					}
				}
				if (this.Duration.HasTimeSpan)
				{
					this.ValidateAnimationPossible(type);
					object currentPropertyValue = global::Microsoft.Expression.Interactivity.Core.ChangePropertyAction.GetCurrentPropertyValue(base.Target, property);
					this.AnimatePropertyChange(property, currentPropertyValue, obj);
				}
				else
				{
					if (this.Increment)
					{
						obj = this.IncrementCurrentValue(property);
					}
					property.SetValue(base.Target, obj, new object[0]);
				}
			}
			catch (global::System.FormatException ex2)
			{
				ex = ex2;
			}
			catch (global::System.ArgumentException ex3)
			{
				ex = ex3;
			}
			catch (global::System.MethodAccessException ex4)
			{
				ex = ex4;
			}
			if (ex != null)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::ExceptionStringTable.ChangePropertyActionCannotSetValueExceptionMessage, new object[]
				{
					(this.Value != null) ? this.Value.GetType().Name : "null",
					this.PropertyName,
					property.PropertyType.Name
				}), ex);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000028A8 File Offset: 0x00000AA8
		private void AnimatePropertyChange(global::System.Reflection.PropertyInfo propertyInfo, object fromValue, object newValue)
		{
			global::System.Windows.Media.Animation.Storyboard storyboard = new global::System.Windows.Media.Animation.Storyboard();
			global::System.Windows.Media.Animation.Timeline timeline;
			if (typeof(double).IsAssignableFrom(propertyInfo.PropertyType))
			{
				timeline = this.CreateDoubleAnimation((double)fromValue, (double)newValue);
			}
			else if (typeof(global::System.Windows.Media.Color).IsAssignableFrom(propertyInfo.PropertyType))
			{
				timeline = this.CreateColorAnimation((global::System.Windows.Media.Color)fromValue, (global::System.Windows.Media.Color)newValue);
			}
			else if (typeof(global::System.Windows.Point).IsAssignableFrom(propertyInfo.PropertyType))
			{
				timeline = this.CreatePointAnimation((global::System.Windows.Point)fromValue, (global::System.Windows.Point)newValue);
			}
			else
			{
				timeline = this.CreateKeyFrameAnimation(fromValue, newValue);
			}
			timeline.Duration = this.Duration;
			storyboard.Children.Add(timeline);
			if (base.TargetObject == null && base.TargetName != null && base.Target is global::System.Windows.Freezable)
			{
				global::System.Windows.Media.Animation.Storyboard.SetTargetName(storyboard, base.TargetName);
			}
			else
			{
				global::System.Windows.Media.Animation.Storyboard.SetTarget(storyboard, (global::System.Windows.DependencyObject)base.Target);
			}
			global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(storyboard, new global::System.Windows.PropertyPath(propertyInfo.Name, new object[0]));
			storyboard.Completed += delegate(object o, global::System.EventArgs e)
			{
				propertyInfo.SetValue(this.Target, newValue, new object[0]);
			};
			storyboard.FillBehavior = global::System.Windows.Media.Animation.FillBehavior.Stop;
			global::System.Windows.FrameworkElement frameworkElement = base.AssociatedObject as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				storyboard.Begin(frameworkElement);
				return;
			}
			storyboard.Begin();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002A2C File Offset: 0x00000C2C
		private static object GetCurrentPropertyValue(object target, global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::System.Windows.FrameworkElement frameworkElement = target as global::System.Windows.FrameworkElement;
			target.GetType();
			object obj = propertyInfo.GetValue(target, null);
			if (frameworkElement != null && (propertyInfo.Name == "Width" || propertyInfo.Name == "Height") && double.IsNaN((double)obj))
			{
				if (propertyInfo.Name == "Width")
				{
					obj = frameworkElement.ActualWidth;
				}
				else
				{
					obj = frameworkElement.ActualHeight;
				}
			}
			return obj;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002AB4 File Offset: 0x00000CB4
		private void ValidateAnimationPossible(global::System.Type targetType)
		{
			if (this.Increment)
			{
				throw new global::System.InvalidOperationException(global::ExceptionStringTable.ChangePropertyActionCannotIncrementAnimatedPropertyChangeExceptionMessage);
			}
			if (!typeof(global::System.Windows.DependencyObject).IsAssignableFrom(targetType))
			{
				throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::ExceptionStringTable.ChangePropertyActionCannotAnimateTargetTypeExceptionMessage, new object[]
				{
					targetType.Name
				}));
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002B0C File Offset: 0x00000D0C
		private global::System.Windows.Media.Animation.Timeline CreateKeyFrameAnimation(object newValue, object fromValue)
		{
			global::System.Windows.Media.Animation.ObjectAnimationUsingKeyFrames objectAnimationUsingKeyFrames = new global::System.Windows.Media.Animation.ObjectAnimationUsingKeyFrames();
			global::System.Windows.Media.Animation.DiscreteObjectKeyFrame keyFrame = new global::System.Windows.Media.Animation.DiscreteObjectKeyFrame
			{
				KeyTime = global::System.Windows.Media.Animation.KeyTime.FromTimeSpan(new global::System.TimeSpan(0L)),
				Value = fromValue
			};
			global::System.Windows.Media.Animation.DiscreteObjectKeyFrame keyFrame2 = new global::System.Windows.Media.Animation.DiscreteObjectKeyFrame
			{
				KeyTime = global::System.Windows.Media.Animation.KeyTime.FromTimeSpan(this.Duration.TimeSpan),
				Value = newValue
			};
			objectAnimationUsingKeyFrames.KeyFrames.Add(keyFrame);
			objectAnimationUsingKeyFrames.KeyFrames.Add(keyFrame2);
			return objectAnimationUsingKeyFrames;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002B88 File Offset: 0x00000D88
		private global::System.Windows.Media.Animation.Timeline CreatePointAnimation(global::System.Windows.Point fromValue, global::System.Windows.Point newValue)
		{
			return new global::System.Windows.Media.Animation.PointAnimation
			{
				From = new global::System.Windows.Point?(fromValue),
				To = new global::System.Windows.Point?(newValue)
			};
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002BB4 File Offset: 0x00000DB4
		private global::System.Windows.Media.Animation.Timeline CreateColorAnimation(global::System.Windows.Media.Color fromValue, global::System.Windows.Media.Color newValue)
		{
			return new global::System.Windows.Media.Animation.ColorAnimation
			{
				From = new global::System.Windows.Media.Color?(fromValue),
				To = new global::System.Windows.Media.Color?(newValue)
			};
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002BE0 File Offset: 0x00000DE0
		private global::System.Windows.Media.Animation.Timeline CreateDoubleAnimation(double fromValue, double newValue)
		{
			return new global::System.Windows.Media.Animation.DoubleAnimation
			{
				From = new double?(fromValue),
				To = new double?(newValue)
			};
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002C0C File Offset: 0x00000E0C
		private void ValidateProperty(global::System.Reflection.PropertyInfo propertyInfo)
		{
			if (propertyInfo == null)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::ExceptionStringTable.ChangePropertyActionCannotFindPropertyNameExceptionMessage, new object[]
				{
					this.PropertyName,
					base.Target.GetType().Name
				}));
			}
			if (!propertyInfo.CanWrite)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::ExceptionStringTable.ChangePropertyActionPropertyIsReadOnlyExceptionMessage, new object[]
				{
					this.PropertyName,
					base.Target.GetType().Name
				}));
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002C9C File Offset: 0x00000E9C
		private object IncrementCurrentValue(global::System.Reflection.PropertyInfo propertyInfo)
		{
			if (!propertyInfo.CanRead)
			{
				throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::ExceptionStringTable.ChangePropertyActionCannotIncrementWriteOnlyPropertyExceptionMessage, new object[]
				{
					propertyInfo.Name
				}));
			}
			object value = propertyInfo.GetValue(base.Target, null);
			global::System.Type propertyType = propertyInfo.PropertyType;
			global::System.ComponentModel.TypeConverter typeConverter = global::Microsoft.Expression.Interactivity.TypeConverterHelper.GetTypeConverter(propertyInfo.PropertyType);
			object obj = this.Value;
			if (obj == null || value == null)
			{
				return obj;
			}
			if (typeConverter.CanConvertFrom(obj.GetType()))
			{
				obj = global::Microsoft.Expression.Interactivity.TypeConverterHelper.DoConversionFrom(typeConverter, obj);
			}
			object result;
			if (typeof(double).IsAssignableFrom(propertyType))
			{
				result = (double)value + (double)obj;
			}
			else if (typeof(int).IsAssignableFrom(propertyType))
			{
				result = (int)value + (int)obj;
			}
			else if (typeof(float).IsAssignableFrom(propertyType))
			{
				result = (float)value + (float)obj;
			}
			else if (typeof(string).IsAssignableFrom(propertyType))
			{
				result = (string)value + (string)obj;
			}
			else
			{
				result = global::Microsoft.Expression.Interactivity.Core.ChangePropertyAction.TryAddition(value, obj);
			}
			return result;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002DD4 File Offset: 0x00000FD4
		private static object TryAddition(object currentValue, object value)
		{
			global::System.Type type = value.GetType();
			global::System.Type type2 = currentValue.GetType();
			global::System.Reflection.MethodInfo methodInfo = null;
			object obj = value;
			foreach (global::System.Reflection.MethodInfo methodInfo2 in type2.GetMethods())
			{
				if (string.Compare(methodInfo2.Name, "op_Addition", global::System.StringComparison.Ordinal) == 0)
				{
					global::System.Reflection.ParameterInfo[] parameters = methodInfo2.GetParameters();
					global::System.Type parameterType = parameters[1].ParameterType;
					if (parameters[0].ParameterType.IsAssignableFrom(type2))
					{
						if (!parameterType.IsAssignableFrom(type))
						{
							global::System.ComponentModel.TypeConverter typeConverter = global::Microsoft.Expression.Interactivity.TypeConverterHelper.GetTypeConverter(parameterType);
							if (!typeConverter.CanConvertFrom(type))
							{
								goto IL_C4;
							}
							obj = global::Microsoft.Expression.Interactivity.TypeConverterHelper.DoConversionFrom(typeConverter, value);
						}
						if (methodInfo != null)
						{
							throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::ExceptionStringTable.ChangePropertyActionAmbiguousAdditionOperationExceptionMessage, new object[]
							{
								type2.Name
							}));
						}
						methodInfo = methodInfo2;
					}
				}
				IL_C4:;
			}
			object result;
			if (methodInfo != null)
			{
				result = methodInfo.Invoke(null, new object[]
				{
					currentValue,
					obj
				});
			}
			else
			{
				result = value;
			}
			return result;
		}

		// Token: 0x0400000A RID: 10
		public static readonly global::System.Windows.DependencyProperty PropertyNameProperty = global::System.Windows.DependencyProperty.Register("PropertyName", typeof(string), typeof(global::Microsoft.Expression.Interactivity.Core.ChangePropertyAction), null);

		// Token: 0x0400000B RID: 11
		public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(object), typeof(global::Microsoft.Expression.Interactivity.Core.ChangePropertyAction), null);

		// Token: 0x0400000C RID: 12
		public static readonly global::System.Windows.DependencyProperty DurationProperty = global::System.Windows.DependencyProperty.Register("Duration", typeof(global::System.Windows.Duration), typeof(global::Microsoft.Expression.Interactivity.Core.ChangePropertyAction), null);

		// Token: 0x0400000D RID: 13
		public static readonly global::System.Windows.DependencyProperty IncrementProperty = global::System.Windows.DependencyProperty.Register("Increment", typeof(bool), typeof(global::Microsoft.Expression.Interactivity.Core.ChangePropertyAction), null);
	}
}
