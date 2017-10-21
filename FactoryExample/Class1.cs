namespace FactoryExample
{

    public class Factory
    {
        public Klient CreateClient()
        {
            return new Klient();
        }

        public Zamowienie CreateZamowienie()
        {
            return new Zamowienie(new Klient());
        }


        public Word CreateWord()
        {
            return new Document
            {
                new Page
                {
                    new Paragraph
                    {
                        new Line(),
                        new Line(),
                        new Line(),
                        new Line(),
                        new Line(),
                    }
                },
                new Page
                {
                    new Paragraph
                    {
                        new Line(),
                        new Line(),
                        new Line(),
                        new Line(),
                        new Line(),
                    }
                }
            }
        }
    }

    public class Klient
    {
        public void DodajZamowienie(Zamowienie zamowienie)
        {
        }
    }

    public class Zamowienie
    {
        public Klient Klient { get; set; }
    }

    public class Example
    {
        public void Example()
        {
            var klient1 = new Klient();

            klient1.DodajZamowienie(new Zamowienie());

        }
    }
}

