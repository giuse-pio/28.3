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

        [TestMethod]
        public void Test_Ricerca_NonTrovato()
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
            agenzia.Aggiungi(appartamento1);

            // Act
            List<Immobile> risultati = agenzia.Ricerca("A2");

            // Assert
            Assert.AreEqual(0, risultati.Count);
        }
        [TestMethod]
        public void Test_AggiungiBox()
        {
            //Arrange
            Agenzia agenzia = new Agenzia
            {
                Nome = "Agenzia",
                Immobili = new List<Immobile>()
            };
            Box box = new Box
            {
                ID = "B1",
                NumPostiAuto = 2
            };

            agenzia.Aggiungi(box);
            Assert.AreEqual(1, agenzia.Immobili.Count);
            Assert.AreEqual("B1", agenzia.Immobili[0].ID);
            Assert.AreEqual(2, ((Box)agenzia.Immobili[0]).NumPostiAuto);
        }
        [TestMethod]
        public void Test_AggiungiVilla()
        {
            Villa villa = new Villa
            {
                ID = "V1",
                Indirizzo = "Via Firenze 3",
                CAP = 50100,
                Citta = "Firenze",
                Mq2 = 150.0f,
                Vani = 5,
                Bagni = 3
            };
            Assert.AreEqual("V1", villa.ID);
            Assert.AreEqual(150, villa.Mq2);

        }
        [TestMethod]
        public void Test_PiuImmobili() 
        { 
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
            Villa villa = new Villa
            {
                ID = "V1",
                Indirizzo = "Via Firenze 3",
                CAP = 50100,
                Citta = "Firenze",
                Mq2 = 150.0f,
                Vani = 5,
                Bagni = 3
            };

            agenzia.Aggiungi(appartamento);
            agenzia.Aggiungi(villa);
            
            Assert.AreEqual(2, agenzia.Immobili.Count);

        }
        [TestMethod]
        public void Test_Ricerca_ListaVuota()
        {
            Agenzia agenzia = new Agenzia();

            var risultati = agenzia.Ricerca("A1");

            Assert.AreEqual(0, risultati.Count);
        }
    }
    
}
