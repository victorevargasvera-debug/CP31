using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Microsoft.Practices.Prism.ViewModel
{
	// Token: 0x0200008B RID: 139
	public class ErrorsContainer<T>
	{
		// Token: 0x060003B7 RID: 951 RVA: 0x0000A580 File Offset: 0x00008780
		public ErrorsContainer(global::System.Action<string> raiseErrorsChanged)
		{
			if (raiseErrorsChanged == null)
			{
				throw new global::System.ArgumentNullException("raiseErrorsChanged");
			}
			this.raiseErrorsChanged = raiseErrorsChanged;
			this.validationResults = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<T>>();
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x0000A5A8 File Offset: 0x000087A8
		public bool HasErrors
		{
			get
			{
				return this.validationResults.Count != 0;
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000A5BC File Offset: 0x000087BC
		public global::System.Collections.Generic.IEnumerable<T> GetErrors(string propertyName)
		{
			string key = propertyName ?? string.Empty;
			global::System.Collections.Generic.List<T> result = null;
			if (this.validationResults.TryGetValue(key, out result))
			{
				return result;
			}
			return global::Microsoft.Practices.Prism.ViewModel.ErrorsContainer<T>.noErrors;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000A5F0 File Offset: 0x000087F0
		public void ClearErrors<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TProperty>> propertyExpression)
		{
			string propertyName = global::Microsoft.Practices.Prism.ViewModel.PropertySupport.ExtractPropertyName<TProperty>(propertyExpression);
			this.ClearErrors(propertyName);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000A60B File Offset: 0x0000880B
		public void ClearErrors(string propertyName)
		{
			this.SetErrors(propertyName, new global::System.Collections.Generic.List<T>());
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000A61C File Offset: 0x0000881C
		public void SetErrors<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TProperty>> propertyExpression, global::System.Collections.Generic.IEnumerable<T> propertyErrors)
		{
			string propertyName = global::Microsoft.Practices.Prism.ViewModel.PropertySupport.ExtractPropertyName<TProperty>(propertyExpression);
			this.SetErrors(propertyName, propertyErrors);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000A638 File Offset: 0x00008838
		public void SetErrors(string propertyName, global::System.Collections.Generic.IEnumerable<T> newValidationResults)
		{
			string text = propertyName ?? string.Empty;
			bool flag = this.validationResults.ContainsKey(text);
			bool flag2 = newValidationResults != null && newValidationResults.Count<T>() > 0;
			if (flag || flag2)
			{
				if (flag2)
				{
					this.validationResults[text] = new global::System.Collections.Generic.List<T>(newValidationResults);
					this.raiseErrorsChanged(text);
					return;
				}
				this.validationResults.Remove(text);
				this.raiseErrorsChanged(text);
			}
		}

		// Token: 0x040000DB RID: 219
		private static readonly T[] noErrors = new T[0];

		// Token: 0x040000DC RID: 220
		private readonly global::System.Action<string> raiseErrorsChanged;

		// Token: 0x040000DD RID: 221
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<T>> validationResults;
	}
}
