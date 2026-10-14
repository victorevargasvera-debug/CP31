using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Security;

namespace Infragistics
{
	// Token: 0x02000043 RID: 67
	public class FastReflectionHelper
	{
		// Token: 0x060003B5 RID: 949 RVA: 0x0000F0AD File Offset: 0x0000D2AD
		public FastReflectionHelper()
		{
			this.GetValueMethod = global::Infragistics.FastReflectionHelper.GetPropertyMode.CompiledLinqExpression;
			this.Invalid = true;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000F0E4 File Offset: 0x0000D2E4
		public FastReflectionHelper(bool useTraditionalReflection, string propertyName)
		{
			if (useTraditionalReflection)
			{
				this.GetValueMethod = global::Infragistics.FastReflectionHelper.GetPropertyMode.TraditionalReflection;
			}
			else
			{
				this.GetValueMethod = global::Infragistics.FastReflectionHelper.GetPropertyMode.CompiledLinqExpression;
			}
			this.UpdatePropertyName(propertyName);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000F134 File Offset: 0x0000D334
		private void UpdatePropertyName(string propertyName)
		{
			if (propertyName == null)
			{
				return;
			}
			bool flag = false;
			if (propertyName.StartsWith("["))
			{
				flag = true;
			}
			propertyName = propertyName.TrimStart(new char[]
			{
				'.',
				'['
			});
			int num = propertyName.IndexOfAny(new char[]
			{
				'[',
				'.'
			});
			if (num > 0 && (propertyName[num] == '[' || !flag))
			{
				string text = propertyName.Substring(num, propertyName.Length - num);
				this.innerHelper = new global::Infragistics.FastReflectionHelper(this.UseTraditionalReflection, text);
				this.UpdatePropertyName(propertyName.Substring(0, num));
				return;
			}
			int num2 = propertyName.IndexOf("]");
			if (num2 > 0)
			{
				string text2 = propertyName.Substring(num2 + 1, propertyName.Length - num2 - 1);
				if (text2.Length > 0)
				{
					this.innerHelper = new global::Infragistics.FastReflectionHelper(this.UseTraditionalReflection, text2);
				}
				propertyName = propertyName.Substring(0, num2);
				int num3;
				if (int.TryParse(propertyName, out num3))
				{
					this.GetValueMode = global::Infragistics.FastReflectionHelper.GetValueOperation.IntIndexer;
				}
				else
				{
					this.GetValueMode = global::Infragistics.FastReflectionHelper.GetValueOperation.StringIndexer;
				}
			}
			else
			{
				this.GetValueMode = global::Infragistics.FastReflectionHelper.GetValueOperation.GetProperty;
			}
			this.propertyName = propertyName;
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x0000F24A File Offset: 0x0000D44A
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x0000F252 File Offset: 0x0000D452
		private global::Infragistics.FastReflectionHelper.GetValueOperation GetValueMode { get; set; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060003BA RID: 954 RVA: 0x0000F25B File Offset: 0x0000D45B
		// (set) Token: 0x060003BB RID: 955 RVA: 0x0000F263 File Offset: 0x0000D463
		public string PropertyName
		{
			get
			{
				return this.propertyName;
			}
			set
			{
				if (this.propertyName != value)
				{
					this.UpdatePropertyName(value);
					this.Invalid = string.IsNullOrEmpty(this.PropertyName);
					this.type = null;
					this.getPropertyValueDictionary = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Func<object, object>>();
				}
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060003BC RID: 956 RVA: 0x0000F29D File Offset: 0x0000D49D
		// (set) Token: 0x060003BD RID: 957 RVA: 0x0000F2A5 File Offset: 0x0000D4A5
		private global::Infragistics.FastReflectionHelper.GetPropertyMode GetValueMethod { get; set; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060003BE RID: 958 RVA: 0x0000F2AE File Offset: 0x0000D4AE
		// (set) Token: 0x060003BF RID: 959 RVA: 0x0000F2B9 File Offset: 0x0000D4B9
		public bool UseTraditionalReflection
		{
			get
			{
				return this.GetValueMethod == global::Infragistics.FastReflectionHelper.GetPropertyMode.TraditionalReflection;
			}
			set
			{
				if (value)
				{
					this.GetValueMethod = global::Infragistics.FastReflectionHelper.GetPropertyMode.TraditionalReflection;
				}
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x0000F2C5 File Offset: 0x0000D4C5
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x0000F2CD File Offset: 0x0000D4CD
		public bool Invalid { get; private set; }

		// Token: 0x060003C2 RID: 962 RVA: 0x0000F2D6 File Offset: 0x0000D4D6
		public object GetPropertyValue(object item)
		{
			if (this.Invalid || item == null)
			{
				return null;
			}
			return this.GetPropertyValue(item.GetType(), item);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000F2F4 File Offset: 0x0000D4F4
		public object GetPropertyValue(global::System.Type itemType, object item)
		{
			if (this.Invalid || itemType == null || item == null)
			{
				return null;
			}
			object obj = null;
			switch (this.GetValueMethod)
			{
			case global::Infragistics.FastReflectionHelper.GetPropertyMode.TraditionalReflection:
				obj = this.GetPropertyValueTraditional(itemType, item);
				goto IL_6C;
			case global::Infragistics.FastReflectionHelper.GetPropertyMode.TypeDescriptor:
				obj = this.GetPropertyValueTypeDescriptor(itemType, item);
				goto IL_6C;
			}
			try
			{
				obj = this.GetValueFast(itemType, item);
			}
			catch (global::System.ArgumentException)
			{
				return this.FallbackFromFastReflection(itemType, item);
			}
			catch (global::System.Security.VerificationException)
			{
				return this.FallbackFromFastReflection(itemType, item);
			}
			IL_6C:
			if (this.innerHelper != null && obj != null)
			{
				obj = this.innerHelper.GetPropertyValue(obj);
			}
			return obj;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000F3A4 File Offset: 0x0000D5A4
		private object FallbackFromFastReflection(global::System.Type itemType, object item)
		{
			this.type = null;
			if (typeof(global::System.ComponentModel.ICustomTypeDescriptor).IsAssignableFrom(itemType))
			{
				this.GetValueMethod = global::Infragistics.FastReflectionHelper.GetPropertyMode.TypeDescriptor;
			}
			else
			{
				this.GetValueMethod = global::Infragistics.FastReflectionHelper.GetPropertyMode.TraditionalReflection;
			}
			return this.GetPropertyValue(itemType, item);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
		private global::System.Linq.Expressions.LambdaExpression GetIndexingFunction(global::System.Type itemType, object item, global::System.Type indexerType, global::System.Type delegateType)
		{
			global::System.Reflection.PropertyInfo property = this.type.GetProperty("Item", null, new global::System.Type[]
			{
				indexerType
			});
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(object), "obj");
			global::System.Linq.Expressions.ParameterExpression parameterExpression2 = global::System.Linq.Expressions.Expression.Parameter(indexerType, indexerType.Name);
			global::System.Linq.Expressions.UnaryExpression conversion = this.GetConversion(this.type, parameterExpression);
			global::System.Linq.Expressions.Expression expression = global::System.Linq.Expressions.Expression.MakeIndex(conversion, property, new global::System.Linq.Expressions.Expression[]
			{
				parameterExpression2
			});
			expression = this.GetConversion(typeof(object), expression);
			return global::System.Linq.Expressions.Expression.Lambda(delegateType, expression, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression,
				parameterExpression2
			});
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000F480 File Offset: 0x0000D680
		private object GetIntIndexerValue(global::System.Type itemType, object item)
		{
			if (itemType != this.type)
			{
				this.type = itemType;
				this.getIntIndexValue = null;
				if (!this.getIntIndexValueDictionary.TryGetValue(this.type, out this.getIntIndexValue))
				{
					if (this.getIntIndexValueDictionary.Count > 32)
					{
						this.getIntIndexValueDictionary.Clear();
					}
					try
					{
						this.getIntIndexValue = (global::System.Func<object, int, object>)this.GetIndexingFunction(itemType, item, typeof(int), typeof(global::System.Func<object, int, object>)).Compile();
					}
					catch (global::System.MissingMethodException)
					{
						return null;
					}
					this.getIntIndexValueDictionary.Add(this.type, this.getIntIndexValue);
				}
			}
			if (this.getIntIndexValue != null)
			{
				return this.getIntIndexValue(item, int.Parse(this.PropertyName));
			}
			return null;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000F55C File Offset: 0x0000D75C
		private object GetStringIndexerValue(global::System.Type itemType, object item)
		{
			if (itemType != this.type)
			{
				this.type = itemType;
				this.getStringIndexValue = null;
				if (!this.getStringIndexValueDictionary.TryGetValue(this.type, out this.getStringIndexValue))
				{
					if (this.getStringIndexValueDictionary.Count > 32)
					{
						this.getStringIndexValueDictionary.Clear();
					}
					try
					{
						this.getStringIndexValue = (global::System.Func<object, string, object>)this.GetIndexingFunction(itemType, item, typeof(string), typeof(global::System.Func<object, string, object>)).Compile();
					}
					catch (global::System.MissingMethodException)
					{
						return null;
					}
					this.getStringIndexValueDictionary.Add(this.type, this.getStringIndexValue);
				}
			}
			if (this.getStringIndexValue != null)
			{
				return this.getStringIndexValue(item, this.PropertyName);
			}
			return null;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000F634 File Offset: 0x0000D834
		private object GetPropertyValueFast(global::System.Type itemType, object item)
		{
			if (itemType != this.type)
			{
				this.type = itemType;
				this.getPropertyValue = null;
				if (!this.getPropertyValueDictionary.TryGetValue(this.type, out this.getPropertyValue))
				{
					if (this.getPropertyValueDictionary.Count > 32)
					{
						this.getPropertyValueDictionary.Clear();
					}
					global::System.Reflection.PropertyInfo property = this.type.GetProperty(this.propertyName);
					if (property != null)
					{
						global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(object), "obj");
						global::System.Linq.Expressions.UnaryExpression conversion = this.GetConversion(this.type, parameterExpression);
						global::System.Linq.Expressions.UnaryExpression body = global::System.Linq.Expressions.Expression.TypeAs(global::System.Linq.Expressions.Expression.Property(conversion, property), typeof(object));
						try
						{
							this.getPropertyValue = (global::System.Func<object, object>)global::System.Linq.Expressions.Expression.Lambda(body, new global::System.Linq.Expressions.ParameterExpression[]
							{
								parameterExpression
							}).Compile();
							goto IL_F4;
						}
						catch (global::System.MissingMethodException)
						{
							throw new global::System.ArgumentException();
						}
					}
					if (this.PropertyName != null && this.PropertyName.Length > 0)
					{
						throw new global::System.ArgumentException();
					}
					IL_F4:
					this.getPropertyValueDictionary.Add(this.type, this.getPropertyValue);
				}
			}
			if (this.getPropertyValue != null)
			{
				return this.getPropertyValue(item);
			}
			if ((this.PropertyName == null || this.PropertyName.Length == 0) && itemType.IsAssignableFrom(item.GetType()))
			{
				return item;
			}
			return null;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000F798 File Offset: 0x0000D998
		private object GetValueFast(global::System.Type itemType, object item)
		{
			switch (this.GetValueMode)
			{
			case global::Infragistics.FastReflectionHelper.GetValueOperation.StringIndexer:
				return this.GetStringIndexerValue(itemType, item);
			case global::Infragistics.FastReflectionHelper.GetValueOperation.IntIndexer:
				return this.GetIntIndexerValue(itemType, item);
			}
			return this.GetPropertyValueFast(itemType, item);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000F7DC File Offset: 0x0000D9DC
		private global::System.Linq.Expressions.UnaryExpression GetConversion(global::System.Type type, global::System.Linq.Expressions.Expression expression)
		{
			bool isValueType = type.IsValueType;
			bool isGenericType = type.IsGenericType;
			bool flag = isGenericType && type.GetGenericTypeDefinition() == typeof(global::System.Nullable<>);
			if (isValueType && (!isGenericType || !flag))
			{
				return global::System.Linq.Expressions.Expression.Convert(expression, type);
			}
			return global::System.Linq.Expressions.Expression.TypeAs(expression, type);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000F82C File Offset: 0x0000DA2C
		private object GetPropertyValueTraditional(global::System.Type itemType, object item)
		{
			if (this.PropertyName == null || this.PropertyName.Length == 0)
			{
				return item;
			}
			if (this.type != itemType)
			{
				this.type = itemType;
				this.propertyInfo = this.type.GetProperty(this.PropertyName);
			}
			if (!(this.propertyInfo != null))
			{
				return null;
			}
			return this.propertyInfo.GetValue(item, null);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000F89C File Offset: 0x0000DA9C
		private object GetPropertyValueTypeDescriptor(global::System.Type itemType, object item)
		{
			if (this.type != itemType)
			{
				this.type = itemType;
				this.PropertyDescriptor = global::System.ComponentModel.TypeDescriptor.GetProperties(item)[this.PropertyName];
			}
			if (this.PropertyDescriptor == null)
			{
				return null;
			}
			return this.PropertyDescriptor.GetValue(item);
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003CD RID: 973 RVA: 0x0000F8EB File Offset: 0x0000DAEB
		// (set) Token: 0x060003CE RID: 974 RVA: 0x0000F8F3 File Offset: 0x0000DAF3
		private global::System.ComponentModel.PropertyDescriptor PropertyDescriptor { get; set; }

		// Token: 0x04000149 RID: 329
		private global::Infragistics.FastReflectionHelper innerHelper;

		// Token: 0x0400014A RID: 330
		private string propertyName;

		// Token: 0x0400014B RID: 331
		private global::System.Type type;

		// Token: 0x0400014C RID: 332
		private global::System.Func<object, object> getPropertyValue;

		// Token: 0x0400014D RID: 333
		private global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Func<object, object>> getPropertyValueDictionary = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Func<object, object>>();

		// Token: 0x0400014E RID: 334
		private global::System.Func<object, string, object> getStringIndexValue;

		// Token: 0x0400014F RID: 335
		private global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Func<object, string, object>> getStringIndexValueDictionary = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Func<object, string, object>>();

		// Token: 0x04000150 RID: 336
		private global::System.Func<object, int, object> getIntIndexValue;

		// Token: 0x04000151 RID: 337
		private global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Func<object, int, object>> getIntIndexValueDictionary = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Func<object, int, object>>();

		// Token: 0x04000152 RID: 338
		private global::System.Reflection.PropertyInfo propertyInfo;

		// Token: 0x02000044 RID: 68
		private enum GetValueOperation
		{
			// Token: 0x04000158 RID: 344
			GetProperty,
			// Token: 0x04000159 RID: 345
			StringIndexer,
			// Token: 0x0400015A RID: 346
			IntIndexer
		}

		// Token: 0x02000045 RID: 69
		internal enum GetPropertyMode
		{
			// Token: 0x0400015C RID: 348
			CompiledLinqExpression,
			// Token: 0x0400015D RID: 349
			TraditionalReflection,
			// Token: 0x0400015E RID: 350
			TypeDescriptor
		}
	}
}
