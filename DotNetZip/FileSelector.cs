using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using Ionic.Zip;

namespace Ionic
{
	// Token: 0x0200000C RID: 12
	public class FileSelector
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002B73 File Offset: 0x00000D73
		public FileSelector(string selectionCriteria) : this(selectionCriteria, true)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002B7D File Offset: 0x00000D7D
		public FileSelector(string selectionCriteria, bool traverseDirectoryReparsePoints)
		{
			if (!string.IsNullOrEmpty(selectionCriteria))
			{
				this._Criterion = global::Ionic.FileSelector._ParseCriterion(selectionCriteria);
			}
			this.TraverseReparsePoints = traverseDirectoryReparsePoints;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002BA0 File Offset: 0x00000DA0
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00002BB7 File Offset: 0x00000DB7
		public string SelectionCriteria
		{
			get
			{
				if (this._Criterion == null)
				{
					return null;
				}
				return this._Criterion.ToString();
			}
			set
			{
				if (value == null)
				{
					this._Criterion = null;
					return;
				}
				if (value.Trim() == "")
				{
					this._Criterion = null;
					return;
				}
				this._Criterion = global::Ionic.FileSelector._ParseCriterion(value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002BEA File Offset: 0x00000DEA
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002BF2 File Offset: 0x00000DF2
		public bool TraverseReparsePoints { get; set; }

		// Token: 0x06000031 RID: 49 RVA: 0x00002BFC File Offset: 0x00000DFC
		private static string NormalizeCriteriaExpression(string source)
		{
			string[][] array = new string[][]
			{
				new string[]
				{
					"([^']*)\\(\\(([^']+)",
					"$1( ($2"
				},
				new string[]
				{
					"(.)\\)\\)",
					"$1) )"
				},
				new string[]
				{
					"\\(([^'\\f\\n\\r\\t\\v\\x85\\p{Z}])",
					"( $1"
				},
				new string[]
				{
					"(\\S)\\)",
					"$1 )"
				},
				new string[]
				{
					"^\\)",
					" )"
				},
				new string[]
				{
					"(\\S)\\(",
					"$1 ("
				},
				new string[]
				{
					"\\)([^'\\f\\n\\r\\t\\v\\x85\\p{Z}])",
					") $1"
				},
				new string[]
				{
					"(=)('[^']*')",
					"$1 $2"
				},
				new string[]
				{
					"([^ !><])(>|<|!=|=)",
					"$1 $2"
				},
				new string[]
				{
					"(>|<|!=|=)([^ =])",
					"$1 $2"
				},
				new string[]
				{
					"/",
					"\\"
				}
			};
			string input = source;
			for (int i = 0; i < array.Length; i++)
			{
				string pattern = global::Ionic.FileSelector.RegexAssertions.PrecededByEvenNumberOfSingleQuotes + array[i][0] + global::Ionic.FileSelector.RegexAssertions.FollowedByEvenNumberOfSingleQuotesAndLineEnd;
				input = global::System.Text.RegularExpressions.Regex.Replace(input, pattern, array[i][1]);
			}
			string pattern2 = "/" + global::Ionic.FileSelector.RegexAssertions.FollowedByOddNumberOfSingleQuotesAndLineEnd;
			input = global::System.Text.RegularExpressions.Regex.Replace(input, pattern2, "\\");
			pattern2 = " " + global::Ionic.FileSelector.RegexAssertions.FollowedByOddNumberOfSingleQuotesAndLineEnd;
			return global::System.Text.RegularExpressions.Regex.Replace(input, pattern2, "\u0006");
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002D94 File Offset: 0x00000F94
		private static global::Ionic.SelectionCriterion _ParseCriterion(string s)
		{
			if (s == null)
			{
				return null;
			}
			s = global::Ionic.FileSelector.NormalizeCriteriaExpression(s);
			if (s.IndexOf(" ") == -1)
			{
				s = "name = " + s;
			}
			string[] array = s.Trim().Split(new char[]
			{
				' ',
				'\t'
			});
			if (array.Length < 3)
			{
				throw new global::System.ArgumentException(s);
			}
			global::Ionic.SelectionCriterion selectionCriterion = null;
			global::System.Collections.Generic.Stack<global::Ionic.FileSelector.ParseState> stack = new global::System.Collections.Generic.Stack<global::Ionic.FileSelector.ParseState>();
			global::System.Collections.Generic.Stack<global::Ionic.SelectionCriterion> stack2 = new global::System.Collections.Generic.Stack<global::Ionic.SelectionCriterion>();
			stack.Push(global::Ionic.FileSelector.ParseState.Start);
			int i = 0;
			while (i < array.Length)
			{
				string text = array[i].ToLower();
				uint num = global::<PrivateImplementationDetails>.ComputeStringHash(text);
				global::Ionic.FileSelector.ParseState parseState;
				if (num <= 1563699588U)
				{
					if (num <= 739023492U)
					{
						if (num <= 329706515U)
						{
							if (num != 254395046U)
							{
								if (num != 329706515U)
								{
									goto IL_8E3;
								}
								if (!(text == "ctime"))
								{
									goto IL_8E3;
								}
								goto IL_449;
							}
							else
							{
								if (!(text == "and"))
								{
									goto IL_8E3;
								}
								goto IL_310;
							}
						}
						else if (num != 597743964U)
						{
							if (num != 739023492U)
							{
								goto IL_8E3;
							}
							if (!(text == ")"))
							{
								goto IL_8E3;
							}
							parseState = stack.Pop();
							if (stack.Peek() != global::Ionic.FileSelector.ParseState.OpenParen)
							{
								throw new global::System.ArgumentException(string.Join(" ", array, i, array.Length - i));
							}
							stack.Pop();
							stack.Push(global::Ionic.FileSelector.ParseState.CriterionDone);
						}
						else
						{
							if (!(text == "size"))
							{
								goto IL_8E3;
							}
							goto IL_552;
						}
					}
					else if (num <= 1058081160U)
					{
						if (num != 755801111U)
						{
							if (num != 1058081160U)
							{
								goto IL_8E3;
							}
							if (!(text == "filename"))
							{
								goto IL_8E3;
							}
							goto IL_73C;
						}
						else
						{
							if (!(text == "("))
							{
								goto IL_8E3;
							}
							parseState = stack.Peek();
							if (parseState != global::Ionic.FileSelector.ParseState.Start && parseState != global::Ionic.FileSelector.ParseState.ConjunctionPending && parseState != global::Ionic.FileSelector.ParseState.OpenParen)
							{
								throw new global::System.ArgumentException(string.Join(" ", array, i, array.Length - i));
							}
							if (array.Length <= i + 4)
							{
								throw new global::System.ArgumentException(string.Join(" ", array, i, array.Length - i));
							}
							stack.Push(global::Ionic.FileSelector.ParseState.OpenParen);
						}
					}
					else if (num != 1361572173U)
					{
						if (num != 1563699588U)
						{
							goto IL_8E3;
						}
						if (!(text == "or"))
						{
							goto IL_8E3;
						}
						goto IL_310;
					}
					else
					{
						if (!(text == "type"))
						{
							goto IL_8E3;
						}
						goto IL_825;
					}
				}
				else if (num <= 2746858573U)
				{
					if (num <= 2211460629U)
					{
						if (num != 2166136261U)
						{
							if (num != 2211460629U)
							{
								goto IL_8E3;
							}
							if (!(text == "length"))
							{
								goto IL_8E3;
							}
							goto IL_552;
						}
						else
						{
							if (text == null)
							{
								goto IL_8E3;
							}
							if (text.Length != 0)
							{
								goto IL_8E3;
							}
							stack.Push(global::Ionic.FileSelector.ParseState.Whitespace);
						}
					}
					else if (num != 2369371622U)
					{
						if (num != 2746858573U)
						{
							goto IL_8E3;
						}
						if (!(text == "atime"))
						{
							goto IL_8E3;
						}
						goto IL_449;
					}
					else
					{
						if (!(text == "name"))
						{
							goto IL_8E3;
						}
						goto IL_73C;
					}
				}
				else if (num <= 3429620606U)
				{
					if (num != 2888110417U)
					{
						if (num != 3429620606U)
						{
							goto IL_8E3;
						}
						if (!(text == "xor"))
						{
							goto IL_8E3;
						}
						goto IL_310;
					}
					else
					{
						if (!(text == "mtime"))
						{
							goto IL_8E3;
						}
						goto IL_449;
					}
				}
				else if (num != 3791641492U)
				{
					if (num != 4191246291U)
					{
						goto IL_8E3;
					}
					if (!(text == "attrs"))
					{
						goto IL_8E3;
					}
					goto IL_825;
				}
				else
				{
					if (!(text == "attributes"))
					{
						goto IL_8E3;
					}
					goto IL_825;
				}
				IL_8FC:
				parseState = stack.Peek();
				if (parseState == global::Ionic.FileSelector.ParseState.CriterionDone)
				{
					stack.Pop();
					if (stack.Peek() == global::Ionic.FileSelector.ParseState.ConjunctionPending)
					{
						while (stack.Peek() == global::Ionic.FileSelector.ParseState.ConjunctionPending)
						{
							global::Ionic.CompoundCriterion compoundCriterion = stack2.Pop() as global::Ionic.CompoundCriterion;
							compoundCriterion.Right = selectionCriterion;
							selectionCriterion = compoundCriterion;
							stack.Pop();
							parseState = stack.Pop();
							if (parseState != global::Ionic.FileSelector.ParseState.CriterionDone)
							{
								throw new global::System.ArgumentException("??");
							}
						}
					}
					else
					{
						stack.Push(global::Ionic.FileSelector.ParseState.CriterionDone);
					}
				}
				if (parseState == global::Ionic.FileSelector.ParseState.Whitespace)
				{
					stack.Pop();
				}
				i++;
				continue;
				IL_310:
				parseState = stack.Peek();
				if (parseState != global::Ionic.FileSelector.ParseState.CriterionDone)
				{
					throw new global::System.ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				if (array.Length <= i + 3)
				{
					throw new global::System.ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				global::Ionic.LogicalConjunction conjunction = (global::Ionic.LogicalConjunction)global::System.Enum.Parse(typeof(global::Ionic.LogicalConjunction), array[i].ToUpper(), true);
				selectionCriterion = new global::Ionic.CompoundCriterion
				{
					Left = selectionCriterion,
					Right = null,
					Conjunction = conjunction
				};
				stack.Push(parseState);
				stack.Push(global::Ionic.FileSelector.ParseState.ConjunctionPending);
				stack2.Push(selectionCriterion);
				goto IL_8FC;
				IL_449:
				if (array.Length <= i + 2)
				{
					throw new global::System.ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				global::System.DateTime dateTime;
				try
				{
					dateTime = global::System.DateTime.ParseExact(array[i + 2], "yyyy-MM-dd-HH:mm:ss", null);
				}
				catch (global::System.FormatException)
				{
					try
					{
						dateTime = global::System.DateTime.ParseExact(array[i + 2], "yyyy/MM/dd-HH:mm:ss", null);
					}
					catch (global::System.FormatException)
					{
						try
						{
							dateTime = global::System.DateTime.ParseExact(array[i + 2], "yyyy/MM/dd", null);
						}
						catch (global::System.FormatException)
						{
							try
							{
								dateTime = global::System.DateTime.ParseExact(array[i + 2], "MM/dd/yyyy", null);
							}
							catch (global::System.FormatException)
							{
								dateTime = global::System.DateTime.ParseExact(array[i + 2], "yyyy-MM-dd", null);
							}
						}
					}
				}
				dateTime = global::System.DateTime.SpecifyKind(dateTime, global::System.DateTimeKind.Local).ToUniversalTime();
				selectionCriterion = new global::Ionic.TimeCriterion
				{
					Which = (global::Ionic.WhichTime)global::System.Enum.Parse(typeof(global::Ionic.WhichTime), array[i], true),
					Operator = (global::Ionic.ComparisonOperator)global::Ionic.EnumUtil.Parse(typeof(global::Ionic.ComparisonOperator), array[i + 1]),
					Time = dateTime
				};
				i += 2;
				stack.Push(global::Ionic.FileSelector.ParseState.CriterionDone);
				goto IL_8FC;
				IL_552:
				if (array.Length <= i + 2)
				{
					throw new global::System.ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				string text2 = array[i + 2];
				long size;
				if (text2.ToUpper().EndsWith("K"))
				{
					size = long.Parse(text2.Substring(0, text2.Length - 1)) * 1024L;
				}
				else if (text2.ToUpper().EndsWith("KB"))
				{
					size = long.Parse(text2.Substring(0, text2.Length - 2)) * 1024L;
				}
				else if (text2.ToUpper().EndsWith("M"))
				{
					size = long.Parse(text2.Substring(0, text2.Length - 1)) * 1024L * 1024L;
				}
				else if (text2.ToUpper().EndsWith("MB"))
				{
					size = long.Parse(text2.Substring(0, text2.Length - 2)) * 1024L * 1024L;
				}
				else if (text2.ToUpper().EndsWith("G"))
				{
					size = long.Parse(text2.Substring(0, text2.Length - 1)) * 1024L * 1024L * 1024L;
				}
				else if (text2.ToUpper().EndsWith("GB"))
				{
					size = long.Parse(text2.Substring(0, text2.Length - 2)) * 1024L * 1024L * 1024L;
				}
				else
				{
					size = long.Parse(array[i + 2]);
				}
				selectionCriterion = new global::Ionic.SizeCriterion
				{
					Size = size,
					Operator = (global::Ionic.ComparisonOperator)global::Ionic.EnumUtil.Parse(typeof(global::Ionic.ComparisonOperator), array[i + 1])
				};
				i += 2;
				stack.Push(global::Ionic.FileSelector.ParseState.CriterionDone);
				goto IL_8FC;
				IL_73C:
				if (array.Length <= i + 2)
				{
					throw new global::System.ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				global::Ionic.ComparisonOperator comparisonOperator = (global::Ionic.ComparisonOperator)global::Ionic.EnumUtil.Parse(typeof(global::Ionic.ComparisonOperator), array[i + 1]);
				if (comparisonOperator != global::Ionic.ComparisonOperator.NotEqualTo && comparisonOperator != global::Ionic.ComparisonOperator.EqualTo)
				{
					throw new global::System.ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				string text3 = array[i + 2];
				if (text3.StartsWith("'") && text3.EndsWith("'"))
				{
					text3 = text3.Substring(1, text3.Length - 2).Replace("\u0006", " ");
				}
				if (global::System.IO.Path.DirectorySeparatorChar == '/')
				{
					text3 = text3.Replace('\\', global::System.IO.Path.DirectorySeparatorChar);
				}
				selectionCriterion = new global::Ionic.NameCriterion
				{
					MatchingFileSpec = text3,
					Operator = comparisonOperator
				};
				i += 2;
				stack.Push(global::Ionic.FileSelector.ParseState.CriterionDone);
				goto IL_8FC;
				IL_825:
				if (array.Length <= i + 2)
				{
					throw new global::System.ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				global::Ionic.ComparisonOperator comparisonOperator2 = (global::Ionic.ComparisonOperator)global::Ionic.EnumUtil.Parse(typeof(global::Ionic.ComparisonOperator), array[i + 1]);
				if (comparisonOperator2 != global::Ionic.ComparisonOperator.NotEqualTo && comparisonOperator2 != global::Ionic.ComparisonOperator.EqualTo)
				{
					throw new global::System.ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				global::Ionic.SelectionCriterion selectionCriterion2;
				if (!(text == "type"))
				{
					global::Ionic.AttributesCriterion attributesCriterion = new global::Ionic.AttributesCriterion();
					attributesCriterion.AttributeString = array[i + 2];
					selectionCriterion2 = attributesCriterion;
					attributesCriterion.Operator = comparisonOperator2;
				}
				else
				{
					global::Ionic.TypeCriterion typeCriterion = new global::Ionic.TypeCriterion();
					typeCriterion.AttributeString = array[i + 2];
					selectionCriterion2 = typeCriterion;
					typeCriterion.Operator = comparisonOperator2;
				}
				selectionCriterion = selectionCriterion2;
				i += 2;
				stack.Push(global::Ionic.FileSelector.ParseState.CriterionDone);
				goto IL_8FC;
				IL_8E3:
				throw new global::System.ArgumentException("'" + array[i] + "'");
			}
			return selectionCriterion;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003758 File Offset: 0x00001958
		public override string ToString()
		{
			return "FileSelector(" + this._Criterion.ToString() + ")";
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003774 File Offset: 0x00001974
		private bool Evaluate(string filename)
		{
			return this._Criterion.Evaluate(filename);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003782 File Offset: 0x00001982
		[global::System.Diagnostics.Conditional("SelectorTrace")]
		private void SelectorTrace(string format, params object[] args)
		{
			if (this._Criterion != null && this._Criterion.Verbose)
			{
				global::System.Console.WriteLine(format, args);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000037A0 File Offset: 0x000019A0
		public global::System.Collections.Generic.ICollection<string> SelectFiles(string directory)
		{
			return this.SelectFiles(directory, false);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000037AC File Offset: 0x000019AC
		public global::System.Collections.ObjectModel.ReadOnlyCollection<string> SelectFiles(string directory, bool recurseDirectories)
		{
			if (this._Criterion == null)
			{
				throw new global::System.ArgumentException("SelectionCriteria has not been set");
			}
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			try
			{
				if (global::System.IO.Directory.Exists(directory))
				{
					foreach (string text in global::System.IO.Directory.GetFiles(directory))
					{
						if (this.Evaluate(text))
						{
							list.Add(text);
						}
					}
					if (recurseDirectories)
					{
						foreach (string text2 in global::System.IO.Directory.GetDirectories(directory))
						{
							if (this.TraverseReparsePoints || (global::System.IO.File.GetAttributes(text2) & global::System.IO.FileAttributes.ReparsePoint) == (global::System.IO.FileAttributes)0)
							{
								if (this.Evaluate(text2))
								{
									list.Add(text2);
								}
								list.AddRange(this.SelectFiles(text2, recurseDirectories));
							}
						}
					}
				}
			}
			catch (global::System.UnauthorizedAccessException)
			{
			}
			catch (global::System.IO.IOException)
			{
			}
			return list.AsReadOnly();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003884 File Offset: 0x00001A84
		private bool Evaluate(global::Ionic.Zip.ZipEntry entry)
		{
			return this._Criterion.Evaluate(entry);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003894 File Offset: 0x00001A94
		public global::System.Collections.Generic.ICollection<global::Ionic.Zip.ZipEntry> SelectEntries(global::Ionic.Zip.ZipFile zip)
		{
			if (zip == null)
			{
				throw new global::System.ArgumentNullException("zip");
			}
			global::System.Collections.Generic.List<global::Ionic.Zip.ZipEntry> list = new global::System.Collections.Generic.List<global::Ionic.Zip.ZipEntry>();
			foreach (global::Ionic.Zip.ZipEntry zipEntry in zip)
			{
				if (this.Evaluate(zipEntry))
				{
					list.Add(zipEntry);
				}
			}
			return list;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000038FC File Offset: 0x00001AFC
		public global::System.Collections.Generic.ICollection<global::Ionic.Zip.ZipEntry> SelectEntries(global::Ionic.Zip.ZipFile zip, string directoryPathInArchive)
		{
			if (zip == null)
			{
				throw new global::System.ArgumentNullException("zip");
			}
			global::System.Collections.Generic.List<global::Ionic.Zip.ZipEntry> list = new global::System.Collections.Generic.List<global::Ionic.Zip.ZipEntry>();
			string text = (directoryPathInArchive == null) ? null : directoryPathInArchive.Replace("/", "\\");
			if (text != null)
			{
				while (text.EndsWith("\\"))
				{
					text = text.Substring(0, text.Length - 1);
				}
			}
			foreach (global::Ionic.Zip.ZipEntry zipEntry in zip)
			{
				if ((directoryPathInArchive == null || global::System.IO.Path.GetDirectoryName(zipEntry.FileName) == directoryPathInArchive || global::System.IO.Path.GetDirectoryName(zipEntry.FileName) == text) && this.Evaluate(zipEntry))
				{
					list.Add(zipEntry);
				}
			}
			return list;
		}

		// Token: 0x04000022 RID: 34
		internal global::Ionic.SelectionCriterion _Criterion;

		// Token: 0x0200006B RID: 107
		private enum ParseState
		{
			// Token: 0x040003CE RID: 974
			Start,
			// Token: 0x040003CF RID: 975
			OpenParen,
			// Token: 0x040003D0 RID: 976
			CriterionDone,
			// Token: 0x040003D1 RID: 977
			ConjunctionPending,
			// Token: 0x040003D2 RID: 978
			Whitespace
		}

		// Token: 0x0200006C RID: 108
		private static class RegexAssertions
		{
			// Token: 0x040003D3 RID: 979
			public static readonly string PrecededByOddNumberOfSingleQuotes = "(?<=(?:[^']*'[^']*')*'[^']*)";

			// Token: 0x040003D4 RID: 980
			public static readonly string FollowedByOddNumberOfSingleQuotesAndLineEnd = "(?=[^']*'(?:[^']*'[^']*')*[^']*$)";

			// Token: 0x040003D5 RID: 981
			public static readonly string PrecededByEvenNumberOfSingleQuotes = "(?<=(?:[^']*'[^']*')*[^']*)";

			// Token: 0x040003D6 RID: 982
			public static readonly string FollowedByEvenNumberOfSingleQuotesAndLineEnd = "(?=(?:[^']*'[^']*')*[^']*$)";
		}
	}
}
