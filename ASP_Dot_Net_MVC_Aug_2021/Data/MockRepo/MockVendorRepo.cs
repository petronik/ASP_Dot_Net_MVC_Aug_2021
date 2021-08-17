﻿using ASP_Dot_Net_MVC_Aug_2021.Data.Interfaces;
using ASP_Dot_Net_MVC_Aug_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Dot_Net_MVC_Aug_2021.Data.MockRepo
{
    public class MockVendorRepo : IVendorRepo
    {
        private readonly static List<Vendor> _vendors = new List<Vendor> {
            new Vendor { V_code = 21225, V_name = "Bryson, Inc",    V_contact = "Smithson",  V_AreaCode = 615, V_phone = "223-3234", V_state = "TN", V_order = "Y" },
            new Vendor { V_code = 21226, V_name = "SuperLoo, Inc",  V_contact = "Flushing",     V_AreaCode = 904, V_phone = "215-8995", V_state = "FL", V_order = "N" },
            new Vendor { V_code = 21231, V_name = "D&E Supply",     V_contact = "Singh",     V_AreaCode = 615, V_phone = "228-3245", V_state = "TN", V_order = "Y" },
            new Vendor { V_code = 21344, V_name = "Gomez Bros.",    V_contact = "Singh",        V_AreaCode = 615, V_phone = "889-2546", V_state = "KY", V_order = "N" },
            new Vendor { V_code = 22567, V_name = "Dome Supply",    V_contact = "Smith",        V_AreaCode = 901, V_phone = "878-1419", V_state = "GA", V_order = "N" },
            new Vendor { V_code = 23119, V_name = "Randset Ltd.",   V_contact = "Anderson",     V_AreaCode = 901, V_phone = "678-3998", V_state = "GA", V_order = "Y" },
            new Vendor { V_code = 24004, V_name = "Brackman Bros.", V_contact = "Brownling",    V_AreaCode = 615, V_phone = "228-1410", V_state = "TN", V_order = "N" },
            new Vendor { V_code = 24288, V_name = "ORDVA, Inc.",    V_contact = "Hakford",      V_AreaCode = 615, V_phone = "898-1234", V_state = "TN", V_order = "Y" },
            new Vendor { V_code = 25443, V_name = "B&K, Inc.",      V_contact = "Smith",        V_AreaCode = 904, V_phone = "227-0093", V_state = "FL", V_order = "N" },
            new Vendor { V_code = 25501, V_name = "Damal Supplies", V_contact = "Smythe",       V_AreaCode = 615, V_phone = "890-3529", V_state = "TN", V_order = "N" },
            new Vendor { V_code = 25595, V_name = "Rubicon Systems",V_contact = "Orton",        V_AreaCode = 904, V_phone = "456-0092", V_state = "FL", V_order = "Y" },
        };

        public void CreateVendor(Vendor input)
        {
            int code = _vendors.Max(v => v.V_code) + 1;
            input.V_code = code;
            _vendors.Add(input);
        }

        public IEnumerable<Vendor> GetAllVendors()
        {
            return _vendors;
        }

        public Vendor GetVendorById(int id)
        {
            return _vendors.FirstOrDefault(v => v.V_code == id);
        }

        public bool SaveChanges()
        {
            return true;
        }

        public void UpdateVendor(Vendor input)
        {
            var itemInTheList = _vendors
                .FirstOrDefault(i => i.V_code == input.V_code);

            if (itemInTheList != null)
            {
                itemInTheList.V_AreaCode = input.V_AreaCode;
                itemInTheList.V_contact = input.V_contact;
                itemInTheList.V_name = input.V_name;
                itemInTheList.V_order = input.V_order;
                itemInTheList.V_phone = input.V_phone;
                itemInTheList.V_state = input.V_state;
            }
        }
    }
}
