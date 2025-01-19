using RoleplayingMedicalRecordCore.MedicalTracking;

namespace RoleplayingMedicalRecordCore.MedicalManagment
{
    public class MedicalManager : IMedicalRecord
    {
        private List<IMedicalCondition> _medicalConditions = new List<IMedicalCondition>();
        public List<IMedicalCondition> MedicalConditions { get => _medicalConditions; set => _medicalConditions = value; }

        public void CheckMedicalConditions()
        {
            foreach (IMedicalCondition condition in MedicalConditions)
            {
                condition.CheckConditions();
            }
        }
    }
}
