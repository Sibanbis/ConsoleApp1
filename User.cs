using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class User
{
    public string PassportNumber { get; set; }
    public string PassportSeria { get; set; }
    public string Name { get; set; }
}
