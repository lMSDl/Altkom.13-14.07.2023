
//namespace - przestrzeń nazw, czyli adres pod którym "mieszka" klasa
namespace Models
{
    //public - modyfikator dostępu, określa widoczność klasy
    //class  - szablon opisujący zachowania i stany obiektów (instancji klasy), które są wytwarzane na jej podtawie
    //klasy zazwyczaj nazywamy z wielkiej litery
    //pełna nazwa klasy to namespace + nazwa
    public class Item
    {
        //brak modyfikatora dotępu == private - oznacza dostęp tylko z wnętrza klasy
        //pole klasy albo zmienną globalną
        private int value;

        //getter - służy do pobierania wartości wskazanego pola
        /*private*/ public int GetValue()
        {
            //return - kończy metodę i zwraca wartość (obowiązkowy gdy metoda nie jest void)
            return value;
        }

        //setter - służy do ustawiania wartości wskazanego pola
        public void SetValue(int value)
        {
            //w związku z zbieżnością nazw pola i argumentu metody
            //musimy odwołać się do klasy przez "this" żeby rozróżnić zmienne
            this.value = value;
        }

        //Auto-Property
        public int Quantity { /*private*/ get; set; }

        //backfield do full-property
        private string description;
        //Full-property
        public string Description
        {
            get
            {
                return description;
            }
            //setter wbudowany w property - posiada niejawny parametr o nazwie value
            set
            {
                if (description == null)
                    return;
                description = value;
            }
        }
    }

    public class Item2
    {

    }
    }