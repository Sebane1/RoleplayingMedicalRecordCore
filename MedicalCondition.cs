namespace RoleplayingMedicalRecordCore {
    public interface IMedicalCondition {
        public string Name { get; }
        public string Description { get; }
        public bool IsContagious { get; }
        public bool SufficientlyBeingTreated { get; }
        public DateTime DateCaught { get; }
        public TimeSpan ConditionLifeSpan  { get; }
        public TimeSpan TimeUntilConditionWorsens {  get; } 
        public List<ISymptom> Symptoms { get; }
        public void CheckConditions();
    }
}
