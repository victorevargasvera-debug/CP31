using System;
using System.Collections.Generic;
using System.Text;

namespace System.Data.Entity.Core.Common.Utils
{
	// Token: 0x020005FB RID: 1531
	internal class ModifiableIteratorCollection<TElement> : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x06004B04 RID: 19204 RVA: 0x00108F56 File Offset: 0x00107156
		internal ModifiableIteratorCollection(global::System.Collections.Generic.IEnumerable<TElement> elements)
		{
			this.m_elements = new global::System.Collections.Generic.List<TElement>(elements);
			this.m_currentIteratorIndex = -1;
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06004B05 RID: 19205 RVA: 0x00108F71 File Offset: 0x00107171
		internal bool IsEmpty
		{
			get
			{
				return this.m_elements.Count == 0;
			}
		}

		// Token: 0x06004B06 RID: 19206 RVA: 0x00108F81 File Offset: 0x00107181
		internal TElement RemoveOneElement()
		{
			return this.Remove(this.m_elements.Count - 1);
		}

		// Token: 0x06004B07 RID: 19207 RVA: 0x00108F96 File Offset: 0x00107196
		internal void ResetIterator()
		{
			this.m_currentIteratorIndex = -1;
		}

		// Token: 0x06004B08 RID: 19208 RVA: 0x00108F9F File Offset: 0x0010719F
		internal void RemoveCurrentOfIterator()
		{
			this.Remove(this.m_currentIteratorIndex);
			this.m_currentIteratorIndex--;
		}

		// Token: 0x06004B09 RID: 19209 RVA: 0x00108FBC File Offset: 0x001071BC
		internal global::System.Collections.Generic.IEnumerable<TElement> Elements()
		{
			this.m_currentIteratorIndex = 0;
			while (this.m_currentIteratorIndex < this.m_elements.Count)
			{
				yield return this.m_elements[this.m_currentIteratorIndex];
				this.m_currentIteratorIndex++;
			}
			yield break;
		}

		// Token: 0x06004B0A RID: 19210 RVA: 0x00108FCC File Offset: 0x001071CC
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedString(builder, this.m_elements);
		}

		// Token: 0x06004B0B RID: 19211 RVA: 0x00108FDC File Offset: 0x001071DC
		private TElement Remove(int index)
		{
			TElement result = this.m_elements[index];
			int index2 = this.m_elements.Count - 1;
			this.m_elements[index] = this.m_elements[index2];
			this.m_elements.RemoveAt(index2);
			return result;
		}

		// Token: 0x04001A4A RID: 6730
		private readonly global::System.Collections.Generic.List<TElement> m_elements;

		// Token: 0x04001A4B RID: 6731
		private int m_currentIteratorIndex;
	}
}
