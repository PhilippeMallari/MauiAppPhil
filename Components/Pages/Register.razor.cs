using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppPhil.Components.Pages
{
    public partial class Register
    {
        Employee new_employee = new Employee();
        List<CountryNames> countryNames = new List<CountryNames>()
        {
            new CountryNames(){ CountryID=1, CountryName="Canada"},
            new CountryNames(){ CountryID=2, CountryName="USA"},
            new CountryNames(){ CountryID=3, CountryName="Philippines"}
        };
    }
}
