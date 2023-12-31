﻿using System.ComponentModel.DataAnnotations.Schema;


namespace HotelLibrary.Models
{
    public class District : BaseEntity
    {

        [ForeignKey("City")]
        public long CityId { get; set; }
        public virtual City City { get; set; }
    }
}
