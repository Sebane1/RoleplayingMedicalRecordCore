using RoleplayingMedicalRecordCore.MedicalTracking;

namespace RoleplayingMedicalRecordCore.MedicalManagmenet {
    public class MedicalManager : IMedicalRecord {
        public List<IMedicalCondition> MedicalConditions { get; set; }

        public void CheckMedicalConditions() {
            foreach (IMedicalCondition condition in MedicalConditions) {
                condition.CheckConditions();
            }
        }
    }
}
