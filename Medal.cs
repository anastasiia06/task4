namespace WinFormsApp2
{
    internal class Medal
    {
        string country;
        int athletes;
        int gold;
        int silver;
        int bronze;


        public Medal(string country)
        {
            this.country = country;
        }

        public Medal(string country, int athletes)
        {
            this.country = country;
            this.athletes = athletes;
        }

        public Medal(string country, int athletes, int gold)
        {
            this.country = country;
            this.athletes = athletes;
            this.gold = gold;
        }

        public Medal(string country, int athletes, int gold, int silver)
        {
            this.country = country;
            this.athletes = athletes;
            this.gold = gold;
            this.silver = silver;
        }

        public Medal(string country, int athletes, int gold, int silver, int bronze)
        {
            this.country = country;
            this.athletes = athletes;
            this.gold = gold;
            this.silver = silver;
            this.bronze = bronze;
        }


        public string GetInformation()
        {
            string information;
            information = "Країна:  " + this.country + "; Спортсмени:  " + this.athletes.ToString() + "; Золото:  " + this.gold.ToString() + "; Срібло: "+ this.silver.ToString() + "; Бронза: " +this.bronze.ToString() ;
            return information;
        }

    }
}


