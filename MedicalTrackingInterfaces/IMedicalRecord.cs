using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingMedicalRecordCore.MedicalTracking {
    public interface IMedicalRecord {
        List<IMedicalCondition> MedicalConditions { get; set; }
        public void CheckMedicalConditions();
    }
}
