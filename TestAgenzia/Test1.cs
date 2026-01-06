using _28._3;
namespace TestAgenzia
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Test_Aggiungi()
        {
            // Arrange
            Agenzia agenzia = new Agenzia
            {
                Nome = "Agenzia",
                Immobili = new List<Immobile>()
            };

            Appartamento appartamento = new Appartamento
            {
                ID = "A1",
                Indirizzo = "Via Roma 1",
                CAP = 00100,
                Citta = "Roma",
                Mq2 = 75.5f,
                Vani = 3,
                Bagni = 2
            };

            // Act
            agenzia.Aggiungi(appartamento);

            // Assert
            Assert.AreEqual(1, agenzia.Immobili.Count);
        }

        [TestMethod]
        public void Test_Ricerca()
        {
            // Arrange
            Agenzia agenzia = new Agenzia
            {
                Nome = "Agenzia",
                Immobili = new List<Immobile>()
            };
            Appartamento appartamento1 = new Appartamento
            {
                ID = "A1",
                Indirizzo = "Via Roma 1",
                CAP = 00100,
                Citta = "Roma",
                Mq2 = 75.5f,
                Vani = 3,
                Bagni = 2
            };
            Appartamento appartamento2 = new Appartamento
            {
                ID = "B2",
                Indirizzo = "Via Milano 2",
                CAP = 20100,
                Citta = "Milano",
                Mq2 = 85.0f,
                Vani = 4,
                Bagni = 2
            };
            agenzia.Aggiungi(appartamento1);
            agenzia.Aggiungi(appartamento2);

            // Act
            List<Immobile> risultati = agenzia.Ricerca("A1");

            // Assert
            Assert.AreEqual(1, risultati.Count);
            Assert.AreEqual("A1", risultati[0].ID);
        }
    }
}
