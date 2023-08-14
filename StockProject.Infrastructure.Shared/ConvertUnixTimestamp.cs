using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProject.Infrastructure.Shared
{
    public static class ConvertUnixTimestamp
    {
        public static List<string> ConvertFromUnixTimestamp( List<string> value )
        {
            var result = new List<string>();

            foreach ( var item in value )
            {
                var date = new DateTime( 1970, 1, 1, 0, 0, 0, DateTimeKind.Utc ).AddSeconds(Convert.ToInt32( item )).ToString( "yyyy-MM-dd" );
                result.Add( date );
            }

            return result;
        }






    }
}
