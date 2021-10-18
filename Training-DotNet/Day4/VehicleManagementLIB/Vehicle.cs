using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementLIB
{
    public class Vehicle
    {
        #region Variables
        int v_vehicleNo;
        string v_vehicleType;
        string v_vehicleName;
        int v_vehicleCapacity;
        #endregion

        #region Properties
        public int VehicleNo
        {
            get
            {
                return v_vehicleNo;
            }
            set
            {
                v_vehicleNo = value;
            }
        }

        public string VehicleType
        {
            get
            {
                return v_vehicleType;
            }
            set
            {
                v_vehicleType = value;
            }
        }

        public string VehicleName
        {
            get
            {
                return v_vehicleName;
            }
            set
            {
                v_vehicleName = value;
            }
        }

        public int VehicleCapacity
        {
            get
            {
                return v_vehicleCapacity;
            }
            set
            {
                v_vehicleCapacity = value;
            }
        }
        #endregion

        #region Constructors
        public Vehicle(int p_vno,string p_vname,string p_vtype,int p_vcapacity)
        {
            this.VehicleNo = p_vno;
            this.VehicleName = p_vname;
            this.VehicleCapacity = p_vcapacity;
            this.VehicleType = p_vtype;
        }
        #endregion
    }
}
