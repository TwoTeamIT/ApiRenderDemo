namespace ApiRenderDemo.Entity
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cognome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public bool Abilitato { get; set; }

        public static List<UserEntity> GetMockUtenti()
        {
            return new List<UserEntity>
        {
            new UserEntity { Id = 1, Nome = "Luca", Cognome = "Rossi", Email = "luca.rossi@example.com", Telefono = "+39 345 1234567", Abilitato = true },
            new UserEntity { Id = 2, Nome = "Giulia", Cognome = "Bianchi", Email = "giulia.bianchi@example.com", Telefono = "+39 347 9876543", Abilitato = false },
            new UserEntity { Id = 3, Nome = "Marco", Cognome = "Verdi", Email = "marco.verdi@example.com", Telefono = "+39 342 5678901", Abilitato = true },
            new UserEntity { Id = 4, Nome = "Chiara", Cognome = "Russo", Email = "chiara.russo@example.com", Telefono = "+39 349 1357911", Abilitato = false },
            new UserEntity { Id = 5, Nome = "Davide", Cognome = "Ferrari", Email = "davide.ferrari@example.com", Telefono = "+39 348 2244668", Abilitato = true },
            new UserEntity { Id = 6, Nome = "Sara", Cognome = "Martini", Email = "sara.martini@example.com", Telefono = "+39 340 9988776", Abilitato = true },
            new UserEntity { Id = 7, Nome = "Andrea", Cognome = "Conti", Email = "andrea.conti@example.com", Telefono = "+39 346 1122334", Abilitato = false },
            new UserEntity { Id = 8, Nome = "Francesca", Cognome = "Moretti", Email = "francesca.moretti@example.com", Telefono = "+39 341 7788990", Abilitato = true }
        };
        }
    }
}
