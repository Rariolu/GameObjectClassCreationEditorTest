﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class IndentedStringBuilder
{
    StringBuilder sb = new StringBuilder();
    int indents = 0;
    public int Indents
    {
        get
        {
            return indents;
        }
        set
        {
            indents = value;
        }
    }
    public void AppendLine(string text)
    {
        Append(text + "\n");
    }
    public void AppendLineFormat(string format, params object[] args)
    {
        Append(string.Format(format+"\n", args));
    }
    public void Append(string text)
    {
        string inds = "";
        for(int i = 0; i < Indents; i++)
        {
            inds += "\t";
        }
        sb.Append(inds + text);
    }
    public override string ToString()
    {
        return sb.ToString();
    }
}