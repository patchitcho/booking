using System.Collections.Generic;
using System.Reflection;

namespace ForceT.Shared
{
    public class RoleModel
    {
        public bool Admin { get; set; }
        public bool AdresseCreat { get; set; }
        public bool AdresseDlet { get; set; }
        public bool AdresseRead { get; set; }
        public bool AdresseUpdt { get; set; }
        public bool AgenceCreat { get; set; }
        public bool AgenceDlet { get; set; }
        public bool AgenceRead { get; set; }
        public bool AgenceUpdt { get; set; }
        public bool CourseCreat { get; set; }
        public bool CourseDlet { get; set; }
        public bool CourseRead { get; set; }
        public bool CourseUpdt { get; set; }
        public bool SondageCreat { get; set; }
        public bool SondageDlet { get; set; }
        public bool SondageRead { get; set; }
        public bool SondageUpdt { get; set; }
        public bool TourneeCreat { get; set; }
        public bool TourneeRead { get; set; }
        public bool TourneeDlet { get; set; }
        public bool TourneeUpdt { get; set; }
        public bool VehiculeCreat { get; set; }
        public bool VehiculeDlet { get; set; }
        public bool VehiculeRead { get; set; }
        public bool VehiculeUpdt { get; set; }
        public bool ZoneCreat { get; set; }
        public bool ZoneDlet { get; set; }
        public bool ZoneRead { get; set; }
        public bool ZoneUpdt { get; set; }

        //public override string ToString()
        //{
        //    PropertyInfo[] propertyInfos;
        //    List<string> propList = new List<string>();
        //    propertyInfos = typeof(RoleModel).GetProperties(BindingFlags.Public);
        //    foreach (var propertyinfo in propertyInfos)
        //    {
        //        propList.Add(propertyinfo.Name);
        //    }
        //}

    }
}
