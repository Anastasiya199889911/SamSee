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
        private string YearId { get; set; }
        private string GanreId { get; set; }
        private string CountryId { get; set; }
        private int RatingId { get; set; }
        private string Producer { get; set; }
        private string AdditionalInf { get; set; }
        private string Description { get; set; }

        public void SetName(string name)
        {
            Name = name;
        }
        public void SetYear(string year)
        {
            YearId = year;
        }
        public void SetGanre(string ganre)
        {
            GanreId = ganre;
        }
        public void SetProducer(string producer)
        {
            Producer = producer;
        }
        public void SetCountry(string country)
        {
            CountryId = country;
        }
        public void SetAdditionalInf(string additionalinf)
        {
            AdditionalInf = additionalinf;
        }
        public void SetRating(int rating)
        {
            RatingId = rating;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetYear()
        {
            return YearId;
        }
        public string GetGanre()
        {
            return GanreId;
        }
        public string GetCountry()
        {
            return CountryId;
        }
        public int GetRating()
        {
            return RatingId;
        }
        public string GetProducer()
        {
            return Producer;
        }
        public string GetAdditionalInf()
        {
            return AdditionalInf;
        }
    }
}
