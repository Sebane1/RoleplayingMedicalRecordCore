using RoleplayingMedicalRecordCore.MedicalTracking;


namespace RoleplayingMedicalRecordCore.MedicalManagment {
    public abstract class MedicalCondition : IMedicalCondition {
        private string _name;
        private string _description;
        private bool _isContagious;
        private bool _sufficientlyBeingTreated;
        private DateTime _dateCaught;
        private TimeSpan _conditionLifeSpan;
        private TimeSpan _timeUntilConditionWorsens;
        List<ISymptom> _symptoms;

        protected MedicalCondition(string name, string description, bool isContagious, bool sufficientlyBeingTreated, 
            DateTime dateCaught, TimeSpan conditionLifeSpan, TimeSpan timeUntilConditionWorsens, List<ISymptom> symptoms) {
            _name = name;
            _description = description;
            _isContagious = isContagious;
            _sufficientlyBeingTreated = sufficientlyBeingTreated;
            _dateCaught = dateCaught;
            _conditionLifeSpan = conditionLifeSpan;
            _timeUntilConditionWorsens = timeUntilConditionWorsens;
            _symptoms = symptoms;
        }

        public string Name => _name;

        public string Description => _description;

        public bool IsContagious => _isContagious;

        public bool SufficientlyBeingTreated => _sufficientlyBeingTreated;

        public DateTime DateCaught => _dateCaught;

        public TimeSpan ConditionLifeSpan => _conditionLifeSpan;

        public TimeSpan TimeUntilConditionWorsens => _timeUntilConditionWorsens;

        public List<ISymptom> Symptoms => _symptoms;

        public void CheckConditions() {
            foreach (var item in Symptoms) {
                item.ExecuteSymptomBehaviour();
            }
        }
    }
}
