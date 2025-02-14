using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazor.Components.Model
{
    public class StudentModel
    {
            public int RollNum { get; set; }
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public string? Address { get; set; }
            public string? Pincode { get; set; }
            public bool IsDelete { get; set; }

    }
}
