using System;

namespace NLog.Internal
{
	// Token: 0x02000121 RID: 289
	internal class SimpleStringReader
	{
		// Token: 0x06000D8A RID: 3466 RVA: 0x00022018 File Offset: 0x00020218
		public SimpleStringReader(string text)
		{
			this._text = text;
			this.Position = 0;
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000D8B RID: 3467 RVA: 0x0002202E File Offset: 0x0002022E
		// (set) Token: 0x06000D8C RID: 3468 RVA: 0x00022036 File Offset: 0x00020236
		internal int Position { get; set; }

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x0002203F File Offset: 0x0002023F
		internal string Text
		{
			get
			{
				return this._text;
			}
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00022047 File Offset: 0x00020247
		internal int Peek()
		{
			if (this.Position < this._text.Length)
			{
				return (int)this._text[this.Position];
			}
			return -1;
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00022070 File Offset: 0x00020270
		internal int Read()
		{
			if (this.Position < this._text.Length)
			{
				string text = this._text;
				int position = this.Position;
				this.Position = position + 1;
				return (int)text[position];
			}
			return -1;
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x000220AE File Offset: 0x000202AE
		internal string Substring(int startIndex, int endIndex)
		{
			return this._text.Substring(startIndex, endIndex - startIndex);
		}

		// Token: 0x040003BC RID: 956
		private readonly string _text;
	}
}
