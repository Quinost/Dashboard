using System;
using System.Collections.Generic;

namespace Dashboard.Shared
{
    public class BugModel
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string System { get; set; }
        public DateTime Date { get; set; }
    }
}
