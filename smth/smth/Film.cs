using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smth
{
    class Film
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private Year YearId { get; set; }
        private Ganre GanreId { get; set; }
        private Country CountryId { get; set; }
        private Rating RatingId { get; set; }
        private string Producer { get; set; }
        private string AdditionalInf { get; set; }
        private string Description { get; set; }
    }
}
