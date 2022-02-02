using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Win32HooksDemo
{
public class PItem
{
    public string ProcessName { get; set; }
    public string Title { get; set; }

    public PItem(string processname, string title)
    {
        this.ProcessName = processname;
        this.Title = title;
    }

    public override string ToString()
    {
        if (!string.IsNullOrEmpty(Title))
            return string.Format("{0} ({1})", this.ProcessName, this.Title);
        else
            return string.Format("{0}", this.ProcessName);
    }
}
}
