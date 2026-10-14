using System;
using System.Runtime.InteropServices;

[AttributeUsage(1), ComVisible(false)]
public sealed class DotfuscatorAttribute : Attribute
{
    private string a;
    private int c;

    public DotfuscatorAttribute(string a, int c)
    {
        base..ctor();
        this.a = a;
        this.c = c;
        return;
    }

    public string A
    {
        get
        {
            return this.a;
        }
    }

    public int C
    {
        get
        {
            return this.c;
        }
    }
}

