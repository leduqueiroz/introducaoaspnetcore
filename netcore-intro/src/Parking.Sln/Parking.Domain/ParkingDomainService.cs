using Parking.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain
{
    public class ParkingDomainService : IParkingDomainService
    {
        private ParkingDataContext _context { get; set; }

        public ParkingDomainService(ParkingDataContext context)
        {
            _context = context;
        }

        public bool Create(Parking parking)
        {
            try
            {
                _context.Parking.Add(parking);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
