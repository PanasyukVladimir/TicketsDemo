﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsDemo.Data.Entities.BookingAggregate
{
    public class AgencyRepresentative
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int BookingAgenciesId { set; get; }
        public string BookingAgenciesCode { set; get; }
        public BookingAgencie BookingAgencie { set; get; }
    }
}
