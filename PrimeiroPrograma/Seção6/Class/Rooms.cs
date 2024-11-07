
namespace PrimeiroPrograma.Seção6.Class {
    internal class Rooms {
        public string  Nome { get; set; }
        public string Email{ get; set; }
        public int Room { get; set; }

        public override string ToString() {
            return Room
                + ": "
                + Nome 
                + ", "
                +Email;
        }
    }
}
