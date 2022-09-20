namespace Animals;

// Crie a sua classe Chicken aqui
public class Chicken {
    // propriedades
    public Guid Id { get; set; } = Guid.NewGuid();
    public int EggsPerWeek { get; set; }
    // ? pode ser nula
    public Chicken? Mother { get; set; }
    public Chicken (int eggsPerWeek, Chicken mother) {
            if (eggsPerWeek < 0) {
            throw new ArgumentException ("Eggs per week must be greater than zero");
        }
        EggsPerWeek = eggsPerWeek;
        Mother = mother;
    }

        public Chicken (int eggsPerWeek) {
        if (eggsPerWeek < 0) {
            throw new ArgumentException ("Eggs per week must be greater than zero");
        }
        EggsPerWeek = eggsPerWeek;
    }

}