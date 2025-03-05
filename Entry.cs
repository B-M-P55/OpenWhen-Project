using System;

namespace OpenWhen
{
    public class Entry
    {
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string BeforeReading { get; set; }
        public string AfterReading { get; set; }
        
        public Entry(string category, string beforeReading)
        {
            Category = category;
            BeforeReading = beforeReading;
            AfterReading = "";
            Date = DateTime.Now;
        }
    }
}