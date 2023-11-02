using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class Task
    {
    static private int Id;
    public string Description;
    public string CreationDate;
    public string DueDate;
    public string StartDate;
    public string DoneDate;


    static void SetId()
    {
        Id++;
    }
}
}
