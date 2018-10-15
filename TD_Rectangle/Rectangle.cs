namespace TD_Rectangle
{
    public class Rectangle : IRectangle
    {
        private readonly int longueur;
        private readonly int largeur;
        public Rectangle(int longueur, int largeur)
        {
            this.longueur = longueur;
            this.largeur = largeur;
        }

        public int Perimetre()
        {
            return 2* (longueur+largeur);
        }

        public int Aire()
        {
            return longueur * largeur;
        }

        public bool EstCarre()
        {
            return longueur == largeur;
        }

        public string AfficherRectangle()
        {
            var description = $"Longueur: {this.longueur} - Largeur {this.largeur} - Périmètre: {this.Perimetre()} - Aire {this.Aire()}";
                return EstCarre()? $"{description} - il s'agit d'un carré" : $"{description} - il ne s'agit pas d'un carré";
        }
    }
}
