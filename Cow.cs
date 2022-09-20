namespace Animals;

// Crie a sua classe Cow aqui
public class Cow {
    // propriedades
    public Guid Id { get; set; } = Guid.NewGuid();
    public int Weight { get; set; }
    public string Breed { get; set; }
    // contrutor
    public Cow (int weight, string breed) {
        if (weight <= 0) {
            throw new ArgumentException ("Weight must be greater than zero");
        }
        if (string.IsNullOrEmpty (breed)) {
            throw new ArgumentException ("Breed must not be null or empty");
        }
        Weight = weight;
        Breed = breed;
    }
}