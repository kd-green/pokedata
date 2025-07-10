using System.ComponentModel;

namespace pokedata.Enums
{
    public enum HealthConditions
    {
        // sourced from https://www.ncbi.nlm.nih.gov/books/NBK263824/
        [Description("None")]
        None = 0,
        [Description("Diabetes Type 1")]
        DiabetesType1 = 1,
        [Description("Diabetes Type 2")]
        DiabetesType2 = 2,
        [Description("Diabetes Type 3")]
        Arthritis = 3,
        [Description("Arthritis")]
        HighBloodPressure = 4,
        [Description("Asthma")]
        Asthma = 5,
        [Description("Parkinson's Disease")]
        ParkinsonsDisease = 6,
        [Description("Multiple Sclerosis")]
        MultipleSclerosis = 7,
        [Description("Depression")]
        Depression = 8,
        [Description("Human Immunodeficiency Virus")]
        HIV = 9,
        [Description("Atrial Fibrillation")]
        AtrialFibrillation = 10,
        [Description("Chronic Obstructive Pulmonary Disease")]
        ChronicObstructivePulmonaryDisease = 11,
        [Description("Irritable Bowel Disease")]
        IrritableBowelDisease = 12,
        [Description("Migraine")]
        Migraine = 13,
        [Description("Chronic Pain")]
        ChronicPain = 14,
        [Description("Dementia")]
        Dementia = 15,
        [Description("Osteoarthritis")]
        Osteoarthritis = 16,
        [Description("Chronic Fatigue Syndrome")]
        ChronicFatigueSyndrome = 17,
        [Description("Epilepsy")]
        Epilepsy = 18,
        [Description("Inflamatory Bowel Disease")]
        InflammatoryBowelDisease = 19,
        [Description("Attention Deficit Hyperactivity Disorder")]
        ADHD = 20,
        [Description("Hepatitis B")]
        HepatitisB = 21,
        [Description("Hepatitis C")]
        HepatitisC = 22,
        [Description("Cancer")]
        Cancer = 23,
        [Description("Autism")]
        Autism = 24,
        [Description("Endometriosis")]
        Endometriosis = 25
    }
}
