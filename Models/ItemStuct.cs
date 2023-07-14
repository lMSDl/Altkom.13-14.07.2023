
//namespace - przestrzeń nazw, czyli adres pod którym "mieszka" klasa
namespace Models
{
    //public - modyfikator dostępu, określa widoczność klasy
    //class  - szablon opisujący zachowania i stany obiektów (instancji klasy), które są wytwarzane na jej podtawie
    //klasy zazwyczaj nazywamy z wielkiej litery
    //pełna nazwa klasy to namespace + nazwa
    public struct ItemStuct
    {
        //konstruktor bezparametrowy
        //jest to metoda (jak każda inna), którą charakteryzuje brak typu zwracanego
        //nazwa tej metody MUSI być taka sama jak nazwa klasy
        //jeśli w klasie nie ma żadnego konstruktora, to niejawnei zostanie wygenerowany konstruktor domyślny, jak poniżej
        public ItemStuct()
        {
            value = 0;
            Quantity = 0;
            description = "";
        }


        //konstruktor parametrowy - służy do zapewnienia klasie wartości poącztkowych dla pól i właściwości
        //jeśli w klasie istnieje konstruktor z parametrami, to domyślny konstruktor nie zostanie wygenerowany
        //chcąć posiadać też konstruktor bezparametrowy należy go dodatkowo utworzyć
        public ItemStuct(int value, int quantity, string description)
        {
            this.value = value;
            Quantity = quantity;
            this.description = description;
        }

        //klasa może posiadać dowolną ilość konstruktoróo ile różnią się ilością i typem/kolejnością parametrów
        public ItemStuct(string description)
        {
            value = 0;
            Quantity = 0;
            this.description = description;
        }


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

    }