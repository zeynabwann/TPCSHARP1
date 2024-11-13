namespace Name.Models
{
    public class Client
    {
        private int id;
        private String surnom;
        private String telephone;
        private String addresse;

        private static int count;

        public Client()
        {
            count++;
            id = count;
        }


        public int Id { get => id; set => id = value; }
        public string Surnom { get => surnom; set => surnom = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Addresse { get => addresse; set => addresse = value; }



        public override string ToString()
        {
            return "Client[" +
                    "id=" + id +
                    ", surnom='" + surnom + '\'' +
                    ", telephone='" + telephone + '\'' +
                    ", addresse='" + addresse + ']';

        }

        public bool equals(Client other)
        {
            if (this == other) return true;
            if (other == null) return false;
            Client client = (Client)other;
            return id == client.id &&
                    Object.Equals(surnom, client.surnom) &&
                    Object.Equals(telephone, client.telephone) &&
                    Object.Equals(addresse, client.addresse);

        }
    }
}