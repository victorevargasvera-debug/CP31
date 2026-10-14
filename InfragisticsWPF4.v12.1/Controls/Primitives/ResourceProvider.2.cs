using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x02000079 RID: 121
	public abstract class ResourceProvider<T> : global::Infragistics.Controls.Primitives.ResourceProvider where T : struct
	{
		// Token: 0x060004EB RID: 1259 RVA: 0x000130F4 File Offset: 0x000112F4
		static ResourceProvider()
		{
			if (!typeof(T).IsEnum)
			{
				global::Infragistics.Controls.Primitives.ResourceProvider<T>._TypeExceptionMessage = global::SR.GetString("Provider_TypeNotEnum", new object[]
				{
					typeof(T)
				});
				return;
			}
			global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>(from f in typeof(T).GetFields(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public)
			where f.IsLiteral
			select (T)((object)f.GetValue(null)));
			list.Sort();
			global::Infragistics.Controls.Primitives.ResourceProvider<T>._Count = list.Count;
			if (global::Infragistics.Controls.Primitives.ResourceProvider<T>._Count < 1)
			{
				global::Infragistics.Controls.Primitives.ResourceProvider<T>._TypeExceptionMessage = global::SR.GetString("Provider_EnumEmpty", new object[]
				{
					typeof(T)
				});
				return;
			}
			int num = 0;
			foreach (T t in list)
			{
				int num2 = ((global::System.IConvertible)((object)t)).ToInt32(null);
				if (num2 != num)
				{
					global::Infragistics.Controls.Primitives.ResourceProvider<T>._TypeExceptionMessage = global::SR.GetString("Provider_SparseEnumValues", new object[]
					{
						typeof(T)
					});
					return;
				}
				num++;
			}
			global::Infragistics.Controls.Primitives.ResourceProvider<T>._Ids = list.ToArray();
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00013264 File Offset: 0x00011464
		protected ResourceProvider()
		{
			if (global::Infragistics.Controls.Primitives.ResourceProvider<T>._TypeExceptionMessage != null)
			{
				throw new global::System.NotSupportedException(global::Infragistics.Controls.Primitives.ResourceProvider<T>._TypeExceptionMessage);
			}
		}

		// Token: 0x170000C8 RID: 200
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override object this[object key]
		{
			get
			{
				T id;
				if (!global::Infragistics.Controls.Primitives.ResourceProvider<T>.TryGetEnumValueFromObject(key, out id))
				{
					throw new global::System.Collections.Generic.KeyNotFoundException(global::SR.GetString("Provider_KeyNotFound", new object[]
					{
						typeof(T),
						key
					}));
				}
				return this.GetResource(id);
			}
		}

		// Token: 0x170000C9 RID: 201
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override object this[string key]
		{
			get
			{
				return this[key];
			}
		}

		// Token: 0x170000CA RID: 202
		public object this[T key]
		{
			get
			{
				return this[key];
			}
		}

		// Token: 0x060004F0 RID: 1264
		protected abstract object GetResource(T id);

		// Token: 0x060004F1 RID: 1265 RVA: 0x000132E0 File Offset: 0x000114E0
		internal static bool TryGetEnumValueFromObject(object key, out T id)
		{
			if (key is T)
			{
				id = (T)((object)key);
			}
			else
			{
				id = global::Infragistics.Controls.Primitives.ResourceProvider<T>._Ids[0];
				string text = key as string;
				if (text == null || !global::System.Enum.TryParse<T>(text, out id))
				{
					global::System.IConvertible convertible = key as global::System.IConvertible;
					if (convertible == null)
					{
						return false;
					}
					int num;
					try
					{
						num = convertible.ToInt32(null);
					}
					catch (global::System.Exception)
					{
						return false;
					}
					if (num >= 0 && num < global::Infragistics.Controls.Primitives.ResourceProvider<T>._Count)
					{
						id = global::Infragistics.Controls.Primitives.ResourceProvider<T>._Ids[num];
						return true;
					}
					return false;
				}
			}
			return true;
		}

		// Token: 0x0400019A RID: 410
		private static string _TypeExceptionMessage;

		// Token: 0x0400019B RID: 411
		internal static readonly int _Count;

		// Token: 0x0400019C RID: 412
		internal static readonly T[] _Ids;
	}
}
