namespace RoleplayingMedicalRecordCore.MedicalTracking
{
    public interface ISymptom
    {
        public string Name { get; }
        public string Description { get; }
        public DateTime LastSymptomTreatment { get; }
        public TimeSpan TimeUntilSymptomReturns { get; }
        public bool TreatmentConditionMet { get; }
        public void ExecuteSymptomBehaviour();
        public void TreatSymptom();
        public void IncreaseSymptom();
    }
}
