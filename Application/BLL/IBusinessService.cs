﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BLL;

namespace BLL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBusinessService" in both code and config file together.
    [ServiceContract]
    public interface IBusinessService
    {
        [OperationContract]
        List<AutomobileSerializable> GetAutomobiles();

        [OperationContract]
        List<VendorSerializable> GetAllVendors();
    }
}
