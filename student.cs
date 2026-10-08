using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp6
{
    public class student
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public double Grade { get; set; }
        public override string ToString()
        {
            return $"{Id} - {FullName} - {Grade}";
        }
    }
}
