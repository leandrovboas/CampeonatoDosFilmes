namespace Leandrovboas.CopaFilmes.Dominio.Entity
{
    public class FaseEliminatoria
    {
        protected FaseEliminatoria(FaseDeGrupo faseDeGrupo)
        {

        }

        public Disputa PrimeiraDisputa { get; set; }
        public Disputa SegundaDisputa { get; set; }
        public Disputa TerceiraDisputa { get; set; }
        public Disputa QuartaDisputa { get; set; }

        public static FaseEliminatoria GerarFaseEliminatoria(FaseDeGrupo faseDeGrupo) =>
            new FaseEliminatoria(faseDeGrupo);
    }
}