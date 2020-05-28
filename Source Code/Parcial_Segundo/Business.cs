namespace Parcial_Segundo
{
    public class Business
    {
        public int idBusiness { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public Business()
        {
            idBusiness = -1;
            name = "";
            description = "";
        }
    }
}