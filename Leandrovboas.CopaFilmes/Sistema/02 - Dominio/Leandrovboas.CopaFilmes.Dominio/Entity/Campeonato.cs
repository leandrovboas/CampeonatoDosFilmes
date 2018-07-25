namespace Leandrovboas.CopaFilmes.Dominio.Entity
{
    public class Campeonato
    {
        public FaseDeGrupo FaseDeGrupo { get; set; }
        public FaseEliminatoria FaseEliminatoria { get; set; }
        public FaseSemiFinal FaseSemiFinal { get; set; }
        public FaseFinal FaseFinal { get; set; }


        //TODO: Testar chain-of-responsibility https://www.dofactory.com/net/chain-of-responsibility-design-pattern
    }
}
