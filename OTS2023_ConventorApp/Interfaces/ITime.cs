using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp.Interfaces
{
    internal interface ITime
    {
        string ConvertHours(string value);

        string ConvertMinutes(string value);

        string ConvertSeconds(string value);
    }
}
